using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using UnrealSharp;
using SDK.Script.EngineSDK;
using SDK.Script.PortalWarsSDK;

namespace SharpGate
{
    public class Splitgate
    {
        String staticGameName => "PortalWars-Win64-Shipping";
        Process process;
        public Overlay overlay;
        public void InitWindow()
        {
            while (true)
            {
                process = Process.GetProcesses().FirstOrDefault(p => p.ProcessName.Contains(staticGameName) && p.MainWindowHandle != IntPtr.Zero);
                if (process != null) break;
                Thread.Sleep(500);
            }
            Process.GetProcesses().FirstOrDefault(p => p.ProcessName.Contains("anticheat.x64.equ8"))?.Kill();
            var ue = new UnrealEngine(new Memory(process));
            //new UnrealEngine(new Memory(process)).LoadAddesses(SDK.Addresses.Hardcoded.Payload);
            // thx hinnie https://github.com/hinnie123/splitgate-load-library-injector/blob/main/splitgate-load-library-injector/splitgate-load-library-injector.cpp#L95
            var addr = UnrealEngine.Memory.FindPattern("41 80 38 00 74 0D");
            UnrealEngine.Memory.WriteProcessMemory((UInt64)addr, new Byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });
            //var val = UnrealEngine.Memory.ReadProcessMemory<UInt64>(addr);
            ue.UpdateAddresses();
            overlay = new Overlay(process);
        }
        public void Start()
        {
            while (!Hotkeys.IsPressed(Keys.Delete) && !process.HasExited)
            {
                overlay.Begin();
                if (EngineLoop() > 0) { UEObject.ClearCache(); }
                overlay.End();
            }
        }
        public class Config
        {
            public Boolean Menu = !Hotkeys.ToggledKey(Keys.Insert);
            public Boolean Esp = !Hotkeys.ToggledKey(Keys.F1);
            public Boolean Radar = !Hotkeys.ToggledKey(Keys.F2);
            public Boolean Aimbot = Hotkeys.IsPressed(Keys.F3);
        }
        Int32 EngineLoop()
        {
            if (UnrealEngine.GWorldPtr == 0) return 1;
            var cfg = new Config();
            var World = new World(UnrealEngine.Memory.ReadProcessMemory<UInt64>(UnrealEngine.GWorldPtr)); if (!World.IsA<World>()) return 1;
            if (cfg.Menu)
            {
                var sb = new StringBuilder();
                sb.AppendLine("Shalzuth's Helper Tool");
                sb.AppendLine("FPS : " + overlay.MeasuredFps.ToString("0.00"));
                sb.AppendLine("Hide menu (Insert)");
                sb.AppendLine("Unload (Delete)");
                var fields = cfg.GetType().GetFields();
                for (var i = 1; i < fields.Length; i++) sb.AppendLine(fields[i].Name + "(F" + i + ")");
                overlay.DrawText(sb.ToString(), new Vector2(20, 20), Color.OrangeRed);
            }
            var OwningGameInstance = World.OwningGameInstance; if (!OwningGameInstance.IsA<GameInstance>()) return 1;
            var LocalPlayers = OwningGameInstance.LocalPlayers;
            var PlayerController = LocalPlayers[0].PlayerController.As<PortalWarsBasePlayerController>(); if (!PlayerController.IsA<PlayerController>()) return 1;
            //if (PlayerController.IsA(out MainMenuPlayerController mainmenu)) mainmenu.LoginMenuWidget.StartLoginFlow();
            var Player = PlayerController.Player;
            var AcknowledgedPawn = PlayerController.AcknowledgedPawn.As<PortalWarsCharacter>(); if (AcknowledgedPawn == null || !AcknowledgedPawn.IsA<Character>()) return 1;
            var PlayerState = AcknowledgedPawn.PlayerState.As<PortalWarsPlayerState>(); if (PlayerState == null || !PlayerState.IsA<PlayerState>()) return 1;
            if (PlayerState.GetFieldAddr("TeamNum") == 0) return 0;
            var PlayerTeam = PlayerState.TeamNum;
            var PlayerCameraManager = PlayerController.PlayerCameraManager;
            var CameraCache = PlayerCameraManager.CameraCachePrivate;
            var CameraPOV = CameraCache["POV"];
            var CameraLocation = UnrealEngine.Memory.ReadProcessMemory<Vector3>(CameraPOV["Location"].Address);
            var CameraRotation = UnrealEngine.Memory.ReadProcessMemory<Vector3>(CameraPOV["Rotation"].Address);
            var CameraFOV = UnrealEngine.Memory.ReadProcessMemory<Single>(CameraPOV["FOV"].Address);

            var bestAngle = Single.MaxValue;
            var target = Vector2.Zero;

            var Actors = new Array<Actor>(World.PersistentLevel.Address + UnrealEngine.ActorListOffset);
            for (var i = 0u; i < Actors.Num; i++)
            {
                var Actor = Actors[i];
                if (Actor.Address == 0) continue;
                if (Actor.Address == Player.Address) continue;
                if (!Actor.IsA<Actor>()) continue;
                if (Actor.IsA(out Portal portal))
                {
                    var RootComponent = Actor.RootComponent; if (RootComponent.Address == 0) continue; if (!RootComponent.IsA<SceneComponent>()) continue;
                    var RelativeLocation = RootComponent.RelativeLocation; if (RelativeLocation.Address == 0) continue;
                    var RelativeRotation = RootComponent.RelativeRotation; if (RelativeRotation.Address == 0) continue;
                    var Location = UnrealEngine.Memory.ReadProcessMemory<Vector3>(RelativeLocation.Address);
                    var worldLoc = overlay.WorldToScreen(Location, CameraLocation, CameraRotation, CameraFOV);
                    overlay.DrawText("Portal!", worldLoc, Color.Yellow);
                }
                if (Actor.IsA(out PortalWarsCharacter character))
                {
                    //if (Actor.bActorIsBeingDestroyed) continue; // this flag doesn't work?
                    if (character.Health == 0) continue;
                    if (character.PlayerState.GetFieldAddr("TeamNum") == 0) continue;
                    if (character.PlayerState?.As<PortalWarsPlayerState>().TeamNum == PlayerTeam) continue;
                    var RootComponent = Actor.RootComponent; if (RootComponent.Address == 0) continue; if (!RootComponent.IsA<SceneComponent>()) continue;
                    var RelativeLocation = RootComponent.RelativeLocation; if (RelativeLocation.Address == 0) continue;
                    var RelativeRotation = RootComponent.RelativeRotation; if (RelativeRotation.Address == 0) continue;
                    var Location = UnrealEngine.Memory.ReadProcessMemory<Vector3>(RelativeLocation.Address);
                    var Rotation = UnrealEngine.Memory.ReadProcessMemory<Vector3>(RelativeRotation.Address);
                    var mesh = character.Mesh;
                    var componentToWorldMatrix = UnrealEngine.Memory.ReadProcessMemory<Extensions.Transform>(mesh.Address + 0x1c0).ToMatrixWithScale();
                    if (mesh.GetFieldAddr("CachedBoneSpaceTransforms") == 0) continue;
                    if (mesh.CachedBoneSpaceTransforms == null || mesh.CachedBoneSpaceTransforms.Address == 0) continue;
                    var boneStartAddr = mesh.CachedBoneSpaceTransforms.Address - 0x290;// - 0x68; // why doesn't CachedBoneSpaceTransforms work?
                    var boneStart = UnrealEngine.Memory.ReadProcessMemory<UInt64>(boneStartAddr);
                    for (var j = 48u; j <= 48; j++)
                    {
                        var boneMatrix = UnrealEngine.Memory.ReadProcessMemory<Extensions.Transform>(boneStart + j * 12 * 4).ToMatrixWithScale();
                        var finalBoneMatrix = Matrix4x4.Multiply(boneMatrix, componentToWorldMatrix);
                        var boneLocation = new Vector3(finalBoneMatrix.M41, finalBoneMatrix.M42, finalBoneMatrix.M43);
                        //var worldLoc = overlay.WorldToScreen(boneLocation, CameraLocation, CameraRotation, CameraFOV);
                        var radarLoc = overlay.WorldToWindow(boneLocation, CameraLocation, CameraRotation, 5000, 500);
                        if (cfg.Esp) overlay.DrawBox(Location, Rotation, CameraLocation, CameraRotation, CameraFOV, Color.Yellow);
                        if (cfg.Radar) overlay.DrawText("X", radarLoc, Color.OrangeRed);
                        if (cfg.Aimbot)
                        {
                            var turnVector = CameraLocation.CalcRotation(boneLocation, CameraRotation, 0.0f);
                            var turnWeight = (Single)(CameraRotation - turnVector).Length();
                            if (turnWeight < bestAngle)
                            {
                                bestAngle = turnWeight;
                                target = overlay.WorldToScreen(boneLocation, CameraLocation, CameraRotation, CameraFOV);
                            }
                        }
                    }
                }
            }
            if (cfg.Aimbot) AimAtPos(target);
            return 0;
        }

        [DllImport("user32")] static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);
        private void AimAtPos(Vector2 location, Single smoothSpeed = 1)
        {
            Single ScreenCenterX = 1920 / 2;
            Single ScreenCenterY = 1080 / 2;
            if (Math.Abs(location.X - ScreenCenterX) > ScreenCenterX / 4) return;
            if (Math.Abs(location.Y - ScreenCenterY) > ScreenCenterY / 4) return;
            Single TargetX = 0;
            Single TargetY = 0;
            if (location.X > ScreenCenterX)
            {
                TargetX = -(ScreenCenterX - location.X);
                TargetX /= smoothSpeed;
            }
            else if (location.X < ScreenCenterX)
            {
                TargetX = location.X - ScreenCenterX;
                TargetX /= smoothSpeed;
            }
            if (location.Y > ScreenCenterY)
            {
                TargetY = -(ScreenCenterY - location.Y);
                TargetY /= smoothSpeed;
            }
            else if (location.Y < ScreenCenterY)
            {
                TargetY = location.Y - ScreenCenterY;
                TargetY /= smoothSpeed;
            }
            //if (TargetX > 10) TargetX = 10;
            //if (TargetY > 10) TargetY = 10;
            mouse_event(0x0001, (int)TargetX, (int)TargetY, 0, 0);
        }
    }
}