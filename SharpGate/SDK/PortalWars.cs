using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.AkAudioSDK;
using SDK.Script.UMGSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.PortalWarsGlobalsSDK;
using SDK.Script.AIModuleSDK;
using SDK.Script.SlateCoreSDK;
using SDK.Script.LevelSequenceSDK;
using SDK.Script.NavigationSystemSDK;
using SDK.Script.InputCoreSDK;
using SDK.Script.MediaAssetsSDK;
using SDK.Script.OnlineSubsystem1047SDK;
using SDK.Script.OnlineSubsystemUtilsSDK;
using SDK.Script.GameplayCamerasSDK;
using Overlay = SDK.Script.UMGSDK.Overlay;
namespace SDK.Script.PortalWarsSDK
{
    public class AmbianceVolume : TriggerVolume
    {
        public AmbianceVolume(ulong addr) : base(addr) { }
        public AkAudioEvent EventOnEnter { get { return this[nameof(EventOnEnter)].As<AkAudioEvent>(); } set { this["EventOnEnter"] = value; } }
        public AkAudioEvent EventOnExit { get { return this[nameof(EventOnExit)].As<AkAudioEvent>(); } set { this["EventOnExit"] = value; } }
        public Object StateGroup { get { return this[nameof(StateGroup)]; } set { this[nameof(StateGroup)] = value; } }
        public Object StateOnEnter { get { return this[nameof(StateOnEnter)]; } set { this[nameof(StateOnEnter)] = value; } }
        public Object StateOnExit { get { return this[nameof(StateOnExit)]; } set { this[nameof(StateOnExit)] = value; } }
        public void OnOverlapEnd(Actor OverlappedActor, Actor OtherActor) { Invoke(nameof(OnOverlapEnd), OverlappedActor, OtherActor); }
        public void OnOverlapBegin(Actor OverlappedActor, Actor OtherActor) { Invoke(nameof(OnOverlapBegin), OverlappedActor, OtherActor); }
    }
    public class AmmoCounterWidgetComponent : WidgetComponent
    {
        public AmmoCounterWidgetComponent(ulong addr) : base(addr) { }
        public PortalWarsAmmoCounterWidget AmmoCounterWidget { get { return this[nameof(AmmoCounterWidget)].As<PortalWarsAmmoCounterWidget>(); } set { this["AmmoCounterWidget"] = value; } }
        public float TickInterval { get { return this[nameof(TickInterval)].GetValue<float>(); } set { this[nameof(TickInterval)].SetValue<float>(value); } }
    }
    public class PortalWarsCharacterAnimNotify : AnimNotify
    {
        public PortalWarsCharacterAnimNotify(ulong addr) : base(addr) { }
    }
    public class AnimNotify_FootDown : PortalWarsCharacterAnimNotify
    {
        public AnimNotify_FootDown(ulong addr) : base(addr) { }
    }
    public class AnimNotify_Jump : PortalWarsCharacterAnimNotify
    {
        public AnimNotify_Jump(ulong addr) : base(addr) { }
    }
    public class AnimNotify_LandJump : PortalWarsCharacterAnimNotify
    {
        public AnimNotify_LandJump(ulong addr) : base(addr) { }
    }
    public class AnimNotify_StartTurn : PortalWarsCharacterAnimNotify
    {
        public AnimNotify_StartTurn(ulong addr) : base(addr) { }
    }
    public class AnnouncerInterface : Object
    {
        public AnnouncerInterface(ulong addr) : base(addr) { }
        public PortalWarsAkComponent AkAnnouncer { get { return this[nameof(AkAnnouncer)].As<PortalWarsAkComponent>(); } set { this["AkAnnouncer"] = value; } }
    }
    public class CullableActor : Actor
    {
        public CullableActor(ulong addr) : base(addr) { }
    }
    public class BaseGun : CullableActor
    {
        public BaseGun(ulong addr) : base(addr) { }
        public Object MuzzleAttachPoint { get { return this[nameof(MuzzleAttachPoint)]; } set { this[nameof(MuzzleAttachPoint)] = value; } }
        public ParticleSystem MuzzleFX { get { return this[nameof(MuzzleFX)].As<ParticleSystem>(); } set { this["MuzzleFX"] = value; } }
        public Vector Muzzle1pScale { get { return this[nameof(Muzzle1pScale)].As<Vector>(); } set { this["Muzzle1pScale"] = value; } }
        public Vector Muzzle3pScale { get { return this[nameof(Muzzle3pScale)].As<Vector>(); } set { this["Muzzle3pScale"] = value; } }
        public ParticleSystemComponent MuzzlePSC_1P { get { return this[nameof(MuzzlePSC_1P)].As<ParticleSystemComponent>(); } set { this["MuzzlePSC_1P"] = value; } }
        public ParticleSystemComponent MuzzlePSC_3P { get { return this[nameof(MuzzlePSC_3P)].As<ParticleSystemComponent>(); } set { this["MuzzlePSC_3P"] = value; } }
        public bool bLoopedMuzzleFX { get { return this[nameof(bLoopedMuzzleFX)].Flag; } set { this[nameof(bLoopedMuzzleFX)].Flag = value; } }
        public PortalWarsCharacter MyPawn { get { return this[nameof(MyPawn)].As<PortalWarsCharacter>(); } set { this["MyPawn"] = value; } }
        public SkeletalMeshComponent Mesh1P { get { return this[nameof(Mesh1P)].As<SkeletalMeshComponent>(); } set { this["Mesh1P"] = value; } }
        public StaticMeshComponent Mesh3P { get { return this[nameof(Mesh3P)].As<StaticMeshComponent>(); } set { this["Mesh3P"] = value; } }
        public ECustomizationType SkinType { get { return (ECustomizationType)this[nameof(SkinType)].GetValue<int>(); } set { this[nameof(SkinType)].SetValue<int>((int)value); } }
        public float ColorIntensity3P { get { return this[nameof(ColorIntensity3P)].GetValue<float>(); } set { this[nameof(ColorIntensity3P)].SetValue<float>(value); } }
        public float ColorIntensity1P { get { return this[nameof(ColorIntensity1P)].GetValue<float>(); } set { this[nameof(ColorIntensity1P)].SetValue<float>(value); } }
        public float LoudnessForBots { get { return this[nameof(LoudnessForBots)].GetValue<float>(); } set { this[nameof(LoudnessForBots)].SetValue<float>(value); } }
        public void UpdateSkins() { Invoke(nameof(UpdateSkins)); }
        public SkeletalMeshComponent getMesh1P() { return Invoke<SkeletalMeshComponent>(nameof(getMesh1P)); }
        public int GetControllingTeam() { return Invoke<int>(nameof(GetControllingTeam)); }
        public void ClientRemoved() { Invoke(nameof(ClientRemoved)); }
    }
    public class Gun : BaseGun
    {
        public Gun(ulong addr) : base(addr) { }
        public EBodyPart BodyPartTargetForBots { get { return (EBodyPart)this[nameof(BodyPartTargetForBots)].GetValue<int>(); } set { this[nameof(BodyPartTargetForBots)].SetValue<int>((int)value); } }
        public float TimeBetweenShotsForBots { get { return this[nameof(TimeBetweenShotsForBots)].GetValue<float>(); } set { this[nameof(TimeBetweenShotsForBots)].SetValue<float>(value); } }
        public WeaponData WeaponConfig { get { return this[nameof(WeaponConfig)].As<WeaponData>(); } set { this["WeaponConfig"] = value; } }
        public Object PickupClass { get { return this[nameof(PickupClass)]; } set { this[nameof(PickupClass)] = value; } }
        public byte gunValue { get { return this[nameof(gunValue)].GetValue<byte>(); } set { this[nameof(gunValue)].SetValue<byte>(value); } }
        public int CurrentAmmo { get { return this[nameof(CurrentAmmo)].GetValue<int>(); } set { this[nameof(CurrentAmmo)].SetValue<int>(value); } }
        public int CurrentAmmoInClip { get { return this[nameof(CurrentAmmoInClip)].GetValue<int>(); } set { this[nameof(CurrentAmmoInClip)].SetValue<int>(value); } }
        public float EquipTime { get { return this[nameof(EquipTime)].GetValue<float>(); } set { this[nameof(EquipTime)].SetValue<float>(value); } }
        public bool bAutoEquip { get { return this[nameof(bAutoEquip)].Flag; } set { this[nameof(bAutoEquip)].Flag = value; } }
        public bool bCanFirePortalsWhileEquipped { get { return this[nameof(bCanFirePortalsWhileEquipped)].Flag; } set { this[nameof(bCanFirePortalsWhileEquipped)].Flag = value; } }
        public RecoilData recoilConfig { get { return this[nameof(recoilConfig)].As<RecoilData>(); } set { this["recoilConfig"] = value; } }
        public Object SpectatorCameraShake { get { return this[nameof(SpectatorCameraShake)]; } set { this[nameof(SpectatorCameraShake)] = value; } }
        public AkAudioEvent MeleeSwingEvent { get { return this[nameof(MeleeSwingEvent)].As<AkAudioEvent>(); } set { this["MeleeSwingEvent"] = value; } }
        public AkAudioEvent MeleeHitEvent { get { return this[nameof(MeleeHitEvent)].As<AkAudioEvent>(); } set { this["MeleeHitEvent"] = value; } }
        public bool isMeleeWeapon { get { return this[nameof(isMeleeWeapon)].Flag; } set { this[nameof(isMeleeWeapon)].Flag = value; } }
        public Object MeleeDamageType { get { return this[nameof(MeleeDamageType)]; } set { this[nameof(MeleeDamageType)] = value; } }
        public float MinTimeBeforeApplyingMeleeDmg { get { return this[nameof(MinTimeBeforeApplyingMeleeDmg)].GetValue<float>(); } set { this[nameof(MinTimeBeforeApplyingMeleeDmg)].SetValue<float>(value); } }
        public float MeleeRangeScaleOverride { get { return this[nameof(MeleeRangeScaleOverride)].GetValue<float>(); } set { this[nameof(MeleeRangeScaleOverride)].SetValue<float>(value); } }
        public float MeleeHitCameraShakeScale { get { return this[nameof(MeleeHitCameraShakeScale)].GetValue<float>(); } set { this[nameof(MeleeHitCameraShakeScale)].SetValue<float>(value); } }
        public float MeleeCameraShakeDelay { get { return this[nameof(MeleeCameraShakeDelay)].GetValue<float>(); } set { this[nameof(MeleeCameraShakeDelay)].SetValue<float>(value); } }
        public int GunID { get { return this[nameof(GunID)].GetValue<int>(); } set { this[nameof(GunID)].SetValue<int>(value); } }
        public Object InternalName { get { return this[nameof(InternalName)]; } set { this[nameof(InternalName)] = value; } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Object ShortDisplayName { get { return this[nameof(ShortDisplayName)]; } set { this[nameof(ShortDisplayName)] = value; } }
        public Texture2D GunIcon { get { return this[nameof(GunIcon)].As<Texture2D>(); } set { this["GunIcon"] = value; } }
        public AutoAimData AutoAimConfig { get { return this[nameof(AutoAimConfig)].As<AutoAimData>(); } set { this["AutoAimConfig"] = value; } }
        public EWeaponState CurrentState { get { return (EWeaponState)this[nameof(CurrentState)].GetValue<int>(); } set { this[nameof(CurrentState)].SetValue<int>((int)value); } }
        public ForceFeedbackEffect FireForceFeedback { get { return this[nameof(FireForceFeedback)].As<ForceFeedbackEffect>(); } set { this["FireForceFeedback"] = value; } }
        public ForceFeedbackEffect MeleeForceFeedback { get { return this[nameof(MeleeForceFeedback)].As<ForceFeedbackEffect>(); } set { this["MeleeForceFeedback"] = value; } }
        public WeaponAnimMontage EquipAnim { get { return this[nameof(EquipAnim)].As<WeaponAnimMontage>(); } set { this["EquipAnim"] = value; } }
        public WeaponAnimMontage FireAnim { get { return this[nameof(FireAnim)].As<WeaponAnimMontage>(); } set { this["FireAnim"] = value; } }
        public WeaponAnimMontage ReloadAnim { get { return this[nameof(ReloadAnim)].As<WeaponAnimMontage>(); } set { this["ReloadAnim"] = value; } }
        public WeaponAnimMontage ReloadShortAnim { get { return this[nameof(ReloadShortAnim)].As<WeaponAnimMontage>(); } set { this["ReloadShortAnim"] = value; } }
        public Array<WeaponAnimMontage> MeleeAnims { get { return new Array<WeaponAnimMontage>(this[nameof(MeleeAnims)].Address); } }
        public WeaponAnimMontage ThrowGrenadeAnim { get { return this[nameof(ThrowGrenadeAnim)].As<WeaponAnimMontage>(); } set { this["ThrowGrenadeAnim"] = value; } }
        public WeaponAnimMontage FirePortalAnim { get { return this[nameof(FirePortalAnim)].As<WeaponAnimMontage>(); } set { this["FirePortalAnim"] = value; } }
        public WeaponAnimMontage SprintingFirePortalAnim { get { return this[nameof(SprintingFirePortalAnim)].As<WeaponAnimMontage>(); } set { this["SprintingFirePortalAnim"] = value; } }
        public WeaponAnimMontage ClosePortalAnim { get { return this[nameof(ClosePortalAnim)].As<WeaponAnimMontage>(); } set { this["ClosePortalAnim"] = value; } }
        public WeaponAnimMontage SprintingClosePortalAnim { get { return this[nameof(SprintingClosePortalAnim)].As<WeaponAnimMontage>(); } set { this["SprintingClosePortalAnim"] = value; } }
        public WeaponAnimMontage InspectWeaponAnim { get { return this[nameof(InspectWeaponAnim)].As<WeaponAnimMontage>(); } set { this["InspectWeaponAnim"] = value; } }
        public WeaponAnimList WeaponSpecificAnimations { get { return this[nameof(WeaponSpecificAnimations)].As<WeaponAnimList>(); } set { this["WeaponSpecificAnimations"] = value; } }
        public AkAudioEvent FireEvent { get { return this[nameof(FireEvent)].As<AkAudioEvent>(); } set { this["FireEvent"] = value; } }
        public AkAudioEvent OutOfAmmoEvent { get { return this[nameof(OutOfAmmoEvent)].As<AkAudioEvent>(); } set { this["OutOfAmmoEvent"] = value; } }
        public AkAudioEvent FireStopEvent { get { return this[nameof(FireStopEvent)].As<AkAudioEvent>(); } set { this["FireStopEvent"] = value; } }
        public AkAudioEvent ZoomInEvent { get { return this[nameof(ZoomInEvent)].As<AkAudioEvent>(); } set { this["ZoomInEvent"] = value; } }
        public AkAudioEvent ZoomOutEvent { get { return this[nameof(ZoomOutEvent)].As<AkAudioEvent>(); } set { this["ZoomOutEvent"] = value; } }
        public AkAudioEvent AmmoPickupEvent { get { return this[nameof(AmmoPickupEvent)].As<AkAudioEvent>(); } set { this["AmmoPickupEvent"] = value; } }
        public AkAudioEvent GunCollisionEvent { get { return this[nameof(GunCollisionEvent)].As<AkAudioEvent>(); } set { this["GunCollisionEvent"] = value; } }
        public AkAudioEvent EquipEvent { get { return this[nameof(EquipEvent)].As<AkAudioEvent>(); } set { this["EquipEvent"] = value; } }
        public AmmoCounterWidgetComponent AmmoCounter { get { return this[nameof(AmmoCounter)].As<AmmoCounterWidgetComponent>(); } set { this["AmmoCounter"] = value; } }
        public FuzzyConfig FuzzyConfig { get { return this[nameof(FuzzyConfig)].As<FuzzyConfig>(); } set { this["FuzzyConfig"] = value; } }
        public void ServerGoToState(EWeaponState NewState) { Invoke(nameof(ServerGoToState), NewState); }
        public void PlayWeaponSound(AkAudioEvent Sound) { Invoke(nameof(PlayWeaponSound), Sound); }
        public void OnRep_CurrentState(EWeaponState PrevState) { Invoke(nameof(OnRep_CurrentState), PrevState); }
        public void OnRep_AmmoInClip() { Invoke(nameof(OnRep_AmmoInClip)); }
        public void OnRep_Ammo() { Invoke(nameof(OnRep_Ammo)); }
        public void OnGunImageLoaded() { Invoke(nameof(OnGunImageLoaded)); }
        public void LoopWeaponSound(bool IsFiring) { Invoke(nameof(LoopWeaponSound), IsFiring); }
        public bool GetCanZoom() { return Invoke<bool>(nameof(GetCanZoom)); }
        public PortalWarsAkComponent GetAkComponent() { return Invoke<PortalWarsAkComponent>(nameof(GetAkComponent)); }
        public void ClientStartReload() { Invoke(nameof(ClientStartReload)); }
    }
    public class LineTraceGun : Gun
    {
        public LineTraceGun(ulong addr) : base(addr) { }
        public LineTraceGunData LineTraceGunConfig { get { return this[nameof(LineTraceGunConfig)].As<LineTraceGunData>(); } set { this["LineTraceGunConfig"] = value; } }
        public Object ImpactTemplate { get { return this[nameof(ImpactTemplate)]; } set { this[nameof(ImpactTemplate)] = value; } }
        public GunImpactEffectManager ImpactManager { get { return this[nameof(ImpactManager)].As<GunImpactEffectManager>(); } set { this["ImpactManager"] = value; } }
        public float MaxImpactEffectDistance { get { return this[nameof(MaxImpactEffectDistance)].GetValue<float>(); } set { this[nameof(MaxImpactEffectDistance)].SetValue<float>(value); } }
        public float MaxSimulatedImpactEffectDistance { get { return this[nameof(MaxSimulatedImpactEffectDistance)].GetValue<float>(); } set { this[nameof(MaxSimulatedImpactEffectDistance)].SetValue<float>(value); } }
        public Array<LineTraceInfo> BulletNotify { get { return new Array<LineTraceInfo>(this[nameof(BulletNotify)].Address); } }
        public ParticleSystem TrailFX { get { return this[nameof(TrailFX)].As<ParticleSystem>(); } set { this["TrailFX"] = value; } }
        public Object TrailTargetParam { get { return this[nameof(TrailTargetParam)]; } set { this[nameof(TrailTargetParam)] = value; } }
        public Object ColorParam { get { return this[nameof(ColorParam)]; } set { this[nameof(ColorParam)] = value; } }
        public byte tracerFrequency { get { return this[nameof(tracerFrequency)].GetValue<byte>(); } set { this[nameof(tracerFrequency)].SetValue<byte>(value); } }
        public AkAudioEvent BulletWhizEvent { get { return this[nameof(BulletWhizEvent)].As<AkAudioEvent>(); } set { this["BulletWhizEvent"] = value; } }
        public float MaxBulletWhizDist { get { return this[nameof(MaxBulletWhizDist)].GetValue<float>(); } set { this[nameof(MaxBulletWhizDist)].SetValue<float>(value); } }
        public float BulletWhizDelay { get { return this[nameof(BulletWhizDelay)].GetValue<float>(); } set { this[nameof(BulletWhizDelay)].SetValue<float>(value); } }
        public Vector BulletWhizStart { get { return this[nameof(BulletWhizStart)].As<Vector>(); } set { this["BulletWhizStart"] = value; } }
        public Vector BulletWhizEnd { get { return this[nameof(BulletWhizEnd)].As<Vector>(); } set { this["BulletWhizEnd"] = value; } }
        public Vector BulletWhizClosestPoint { get { return this[nameof(BulletWhizClosestPoint)].As<Vector>(); } set { this["BulletWhizClosestPoint"] = value; } }
        public void ServerNotifyMiss(Array<LineTraceInfo> bulletTraces) { Invoke(nameof(ServerNotifyMiss), bulletTraces); }
        public void ServerNotifyHit(LineTraceHitResult lineHit, float ReticleSpread, Array<LineTraceInfo> bulletTraces) { Invoke(nameof(ServerNotifyHit), lineHit, ReticleSpread, bulletTraces); }
        public void PlayBulletWhiz(Vector StartPoint, Vector EndPoint) { Invoke(nameof(PlayBulletWhiz), StartPoint, EndPoint); }
        public void OnRep_BulletNotify() { Invoke(nameof(OnRep_BulletNotify)); }
        public float GetCurrentSpread() { return Invoke<float>(nameof(GetCurrentSpread)); }
    }
    public class AssaultRifle : LineTraceGun
    {
        public AssaultRifle(ulong addr) : base(addr) { }
    }
    public class Bat : Gun
    {
        public Bat(ulong addr) : base(addr) { }
        public float BatteryPercentagePerSwing { get { return this[nameof(BatteryPercentagePerSwing)].GetValue<float>(); } set { this[nameof(BatteryPercentagePerSwing)].SetValue<float>(value); } }
        public ParticleSystem MeleeImpact1PFX { get { return this[nameof(MeleeImpact1PFX)].As<ParticleSystem>(); } set { this["MeleeImpact1PFX"] = value; } }
        public ParticleSystem MeleeImpact3PFX { get { return this[nameof(MeleeImpact3PFX)].As<ParticleSystem>(); } set { this["MeleeImpact3PFX"] = value; } }
        public LinearColor ElectricityInEffectsRangeColor { get { return this[nameof(ElectricityInEffectsRangeColor)].As<LinearColor>(); } set { this["ElectricityInEffectsRangeColor"] = value; } }
        public LinearColor ElectricityInMeleeRangeColor { get { return this[nameof(ElectricityInMeleeRangeColor)].As<LinearColor>(); } set { this["ElectricityInMeleeRangeColor"] = value; } }
        public LinearColor BatInEffectsRangeEmissiveColor { get { return this[nameof(BatInEffectsRangeEmissiveColor)].As<LinearColor>(); } set { this["BatInEffectsRangeEmissiveColor"] = value; } }
        public LinearColor BatInMeleeRangeEmissiveColor { get { return this[nameof(BatInMeleeRangeEmissiveColor)].As<LinearColor>(); } set { this["BatInMeleeRangeEmissiveColor"] = value; } }
        public float EffectsRange { get { return this[nameof(EffectsRange)].GetValue<float>(); } set { this[nameof(EffectsRange)].SetValue<float>(value); } }
        public float MaxOpenPercentInEffectsRange { get { return this[nameof(MaxOpenPercentInEffectsRange)].GetValue<float>(); } set { this[nameof(MaxOpenPercentInEffectsRange)].SetValue<float>(value); } }
        public float FullyOpenInterpSpeed { get { return this[nameof(FullyOpenInterpSpeed)].GetValue<float>(); } set { this[nameof(FullyOpenInterpSpeed)].SetValue<float>(value); } }
        public float FullyClosedInterpSpeed { get { return this[nameof(FullyClosedInterpSpeed)].GetValue<float>(); } set { this[nameof(FullyClosedInterpSpeed)].SetValue<float>(value); } }
        public float EffectsRangeInterpSpeed { get { return this[nameof(EffectsRangeInterpSpeed)].GetValue<float>(); } set { this[nameof(EffectsRangeInterpSpeed)].SetValue<float>(value); } }
        public float PlateInterpToVisibleSpeed { get { return this[nameof(PlateInterpToVisibleSpeed)].GetValue<float>(); } set { this[nameof(PlateInterpToVisibleSpeed)].SetValue<float>(value); } }
        public float PlateInterpToHiddenSpeed { get { return this[nameof(PlateInterpToHiddenSpeed)].GetValue<float>(); } set { this[nameof(PlateInterpToHiddenSpeed)].SetValue<float>(value); } }
        public MaterialInstanceDynamic BatDynamicMaterial { get { return this[nameof(BatDynamicMaterial)].As<MaterialInstanceDynamic>(); } set { this["BatDynamicMaterial"] = value; } }
        public MaterialInstanceDynamic ElectricityDynamicMaterial { get { return this[nameof(ElectricityDynamicMaterial)].As<MaterialInstanceDynamic>(); } set { this["ElectricityDynamicMaterial"] = value; } }
        public MaterialInstanceDynamic PlatesDynamicMaterial { get { return this[nameof(PlatesDynamicMaterial)].As<MaterialInstanceDynamic>(); } set { this["PlatesDynamicMaterial"] = value; } }
        public MaterialInstanceDynamic ThirdPersonBatDynamicMaterial { get { return this[nameof(ThirdPersonBatDynamicMaterial)].As<MaterialInstanceDynamic>(); } set { this["ThirdPersonBatDynamicMaterial"] = value; } }
        public MaterialInstanceDynamic ThirdPersonElectricityDynamicMaterial { get { return this[nameof(ThirdPersonElectricityDynamicMaterial)].As<MaterialInstanceDynamic>(); } set { this["ThirdPersonElectricityDynamicMaterial"] = value; } }
        public AkAudioEvent BatAmbientStartEvent { get { return this[nameof(BatAmbientStartEvent)].As<AkAudioEvent>(); } set { this["BatAmbientStartEvent"] = value; } }
        public AkAudioEvent BatAmbientStopEvent { get { return this[nameof(BatAmbientStopEvent)].As<AkAudioEvent>(); } set { this["BatAmbientStopEvent"] = value; } }
        public AkAudioEvent BatOpenedSFX { get { return this[nameof(BatOpenedSFX)].As<AkAudioEvent>(); } set { this["BatOpenedSFX"] = value; } }
        public AkAudioEvent OutOfAmmoMeleeHitSound { get { return this[nameof(OutOfAmmoMeleeHitSound)].As<AkAudioEvent>(); } set { this["OutOfAmmoMeleeHitSound"] = value; } }
        public AkAudioEvent OutOfAmmoSwingEvent { get { return this[nameof(OutOfAmmoSwingEvent)].As<AkAudioEvent>(); } set { this["OutOfAmmoSwingEvent"] = value; } }
        public ForceFeedbackEffect OutOfAmmoMeleeForceFeedback { get { return this[nameof(OutOfAmmoMeleeForceFeedback)].As<ForceFeedbackEffect>(); } set { this["OutOfAmmoMeleeForceFeedback"] = value; } }
    }
    public class BurstLineTraceGun : LineTraceGun
    {
        public BurstLineTraceGun(ulong addr) : base(addr) { }
        public BurstLineTraceGunData BurstLineTraceGunConfig { get { return this[nameof(BurstLineTraceGunConfig)].As<BurstLineTraceGunData>(); } set { this["BurstLineTraceGunConfig"] = value; } }
    }
    public class BattleRifle : BurstLineTraceGun
    {
        public BattleRifle(ulong addr) : base(addr) { }
    }
    public class BTDecorator_CheckGameMode : BTDecorator
    {
        public BTDecorator_CheckGameMode(ulong addr) : base(addr) { }
        public Object GameModeClass { get { return this[nameof(GameModeClass)]; } set { this[nameof(GameModeClass)] = value; } }
    }
    public class BTDecorator_HasAmmo : BTDecorator
    {
        public BTDecorator_HasAmmo(ulong addr) : base(addr) { }
    }
    public class BTDecorator_HasReceivedKillRecently : BTDecorator
    {
        public BTDecorator_HasReceivedKillRecently(ulong addr) : base(addr) { }
        public float MaxTime { get { return this[nameof(MaxTime)].GetValue<float>(); } set { this[nameof(MaxTime)].SetValue<float>(value); } }
    }
    public class BTDecorator_IsOnNavMesh : BTDecorator
    {
        public BTDecorator_IsOnNavMesh(ulong addr) : base(addr) { }
    }
    public class BTDecorator_IsRecoveringNavMesh : BTDecorator
    {
        public BTDecorator_IsRecoveringNavMesh(ulong addr) : base(addr) { }
    }
    public class BTDecorator_IsStuck : BTDecorator
    {
        public BTDecorator_IsStuck(ulong addr) : base(addr) { }
    }
    public class BTDecorator_LOSToEnemy : BTDecorator
    {
        public BTDecorator_LOSToEnemy(ulong addr) : base(addr) { }
        public float MaxDistance { get { return this[nameof(MaxDistance)].GetValue<float>(); } set { this[nameof(MaxDistance)].SetValue<float>(value); } }
        public bool bUseWeaponFalloffRange { get { return this[nameof(bUseWeaponFalloffRange)].Flag; } set { this[nameof(bUseWeaponFalloffRange)].Flag = value; } }
    }
    public class BTDecorator_NotifyRequestingPath : BTDecorator
    {
        public BTDecorator_NotifyRequestingPath(ulong addr) : base(addr) { }
    }
    public class BTDecorator_OddballEquipped : BTDecorator
    {
        public BTDecorator_OddballEquipped(ulong addr) : base(addr) { }
    }
    public class BTDecorator_PortalIsNearSelf : BTDecorator
    {
        public BTDecorator_PortalIsNearSelf(ulong addr) : base(addr) { }
        public float IdealXYRange { get { return this[nameof(IdealXYRange)].GetValue<float>(); } set { this[nameof(IdealXYRange)].SetValue<float>(value); } }
        public bool bLinkedPortalsOnly { get { return this[nameof(bLinkedPortalsOnly)].Flag; } set { this[nameof(bLinkedPortalsOnly)].Flag = value; } }
    }
    public class BTDecorator_PortalIsNearTarget : BTDecorator_BlackboardBase
    {
        public BTDecorator_PortalIsNearTarget(ulong addr) : base(addr) { }
        public float XYRange { get { return this[nameof(XYRange)].GetValue<float>(); } set { this[nameof(XYRange)].SetValue<float>(value); } }
        public float MinZRange { get { return this[nameof(MinZRange)].GetValue<float>(); } set { this[nameof(MinZRange)].SetValue<float>(value); } }
    }
    public class BTDecorator_Probability : BTDecorator
    {
        public BTDecorator_Probability(ulong addr) : base(addr) { }
        public float SuccessChance { get { return this[nameof(SuccessChance)].GetValue<float>(); } set { this[nameof(SuccessChance)].SetValue<float>(value); } }
    }
    public class BTDecorator_TeamControlsKOTH : BTDecorator
    {
        public BTDecorator_TeamControlsKOTH(ulong addr) : base(addr) { }
    }
    public class BTDecorator_TeamControlsOddball : BTDecorator
    {
        public BTDecorator_TeamControlsOddball(ulong addr) : base(addr) { }
    }
    public class BTDecorator_TeamInControlDOM : BTDecorator
    {
        public BTDecorator_TeamInControlDOM(ulong addr) : base(addr) { }
    }
    public class BTDecorator_WeaponCheck : BTDecorator
    {
        public BTDecorator_WeaponCheck(ulong addr) : base(addr) { }
        public Object WeaponClass { get { return this[nameof(WeaponClass)]; } set { this[nameof(WeaponClass)] = value; } }
    }
    public class BTDecorator_WithinRange : BTDecorator
    {
        public BTDecorator_WithinRange(ulong addr) : base(addr) { }
        public BlackboardKeySelector BlackboardKey { get { return this[nameof(BlackboardKey)].As<BlackboardKeySelector>(); } set { this["BlackboardKey"] = value; } }
        public float defaultRange { get { return this[nameof(defaultRange)].GetValue<float>(); } set { this[nameof(defaultRange)].SetValue<float>(value); } }
    }
    public class BTDecoratorFlagEquipped : BTDecorator
    {
        public BTDecoratorFlagEquipped(ulong addr) : base(addr) { }
    }
    public class BTDecoratorOnHill : BTDecorator
    {
        public BTDecoratorOnHill(ulong addr) : base(addr) { }
    }
    public class BTDecoratorTeamControlsFlag : BTDecorator
    {
        public BTDecoratorTeamControlsFlag(ulong addr) : base(addr) { }
    }
    public class BTDecoratorTeamControlsNeutralFlag : BTDecorator
    {
        public BTDecoratorTeamControlsNeutralFlag(ulong addr) : base(addr) { }
    }
    public class BTService_AssignTarget : BTService
    {
        public BTService_AssignTarget(ulong addr) : base(addr) { }
        public float ShotByEnemyRelevantTime { get { return this[nameof(ShotByEnemyRelevantTime)].GetValue<float>(); } set { this[nameof(ShotByEnemyRelevantTime)].SetValue<float>(value); } }
        public float PortalRelevantDistance { get { return this[nameof(PortalRelevantDistance)].GetValue<float>(); } set { this[nameof(PortalRelevantDistance)].SetValue<float>(value); } }
        public float MinTimeBeforeSwitchingTargets { get { return this[nameof(MinTimeBeforeSwitchingTargets)].GetValue<float>(); } set { this[nameof(MinTimeBeforeSwitchingTargets)].SetValue<float>(value); } }
        public float MinThreatDifferenceToSwitch { get { return this[nameof(MinThreatDifferenceToSwitch)].GetValue<float>(); } set { this[nameof(MinThreatDifferenceToSwitch)].SetValue<float>(value); } }
    }
    public class BTService_FindPickup : BTService
    {
        public BTService_FindPickup(ulong addr) : base(addr) { }
        public float NearPickupRadius { get { return this[nameof(NearPickupRadius)].GetValue<float>(); } set { this[nameof(NearPickupRadius)].SetValue<float>(value); } }
        public float NeedWeaponPickupRadius { get { return this[nameof(NeedWeaponPickupRadius)].GetValue<float>(); } set { this[nameof(NeedWeaponPickupRadius)].SetValue<float>(value); } }
        public Object SubClassRestriction { get { return this[nameof(SubClassRestriction)]; } set { this[nameof(SubClassRestriction)] = value; } }
        public float MinDifficulty { get { return this[nameof(MinDifficulty)].GetValue<float>(); } set { this[nameof(MinDifficulty)].SetValue<float>(value); } }
    }
    public class BTService_RandomJump : BTService
    {
        public BTService_RandomJump(ulong addr) : base(addr) { }
        public float MinDistanceToEnd { get { return this[nameof(MinDistanceToEnd)].GetValue<float>(); } set { this[nameof(MinDistanceToEnd)].SetValue<float>(value); } }
        public float MinVelocity { get { return this[nameof(MinVelocity)].GetValue<float>(); } set { this[nameof(MinVelocity)].SetValue<float>(value); } }
        public float EpsilonVelocityParallelToPath { get { return this[nameof(EpsilonVelocityParallelToPath)].GetValue<float>(); } set { this[nameof(EpsilonVelocityParallelToPath)].SetValue<float>(value); } }
    }
    public class BTService_RefreshFocus : BTService
    {
        public BTService_RefreshFocus(ulong addr) : base(addr) { }
        public float MaxLongRangeRadius { get { return this[nameof(MaxLongRangeRadius)].GetValue<float>(); } set { this[nameof(MaxLongRangeRadius)].SetValue<float>(value); } }
        public float MaxCloseRangeRadius { get { return this[nameof(MaxCloseRangeRadius)].GetValue<float>(); } set { this[nameof(MaxCloseRangeRadius)].SetValue<float>(value); } }
        public float MaxAimAngle { get { return this[nameof(MaxAimAngle)].GetValue<float>(); } set { this[nameof(MaxAimAngle)].SetValue<float>(value); } }
    }
    public class BTService_ShootEnemy : BTService
    {
        public BTService_ShootEnemy(ulong addr) : base(addr) { }
        public float defaultRange { get { return this[nameof(defaultRange)].GetValue<float>(); } set { this[nameof(defaultRange)].SetValue<float>(value); } }
        public float MinDifficultyToMelee { get { return this[nameof(MinDifficultyToMelee)].GetValue<float>(); } set { this[nameof(MinDifficultyToMelee)].SetValue<float>(value); } }
    }
    public class BTService_StuckMonitor : BTService
    {
        public BTService_StuckMonitor(ulong addr) : base(addr) { }
        public float MinStuckTime { get { return this[nameof(MinStuckTime)].GetValue<float>(); } set { this[nameof(MinStuckTime)].SetValue<float>(value); } }
        public float StuckDistanceTolerance { get { return this[nameof(StuckDistanceTolerance)].GetValue<float>(); } set { this[nameof(StuckDistanceTolerance)].SetValue<float>(value); } }
    }
    public class BTTask_CheckPathingSuccess : BTTaskNode
    {
        public BTTask_CheckPathingSuccess(ulong addr) : base(addr) { }
    }
    public class BTTask_ChooseDOMHill : BTTaskNode
    {
        public BTTask_ChooseDOMHill(ulong addr) : base(addr) { }
    }
    public class BTTask_ChoosePortal : BTTaskNode
    {
        public BTTask_ChoosePortal(ulong addr) : base(addr) { }
        public float PortalTraceRadius { get { return this[nameof(PortalTraceRadius)].GetValue<float>(); } set { this[nameof(PortalTraceRadius)].SetValue<float>(value); } }
    }
    public class BTTask_Crouch : BTTaskNode
    {
        public BTTask_Crouch(ulong addr) : base(addr) { }
        public bool shouldCrouch { get { return this[nameof(shouldCrouch)].Flag; } set { this[nameof(shouldCrouch)].Flag = value; } }
    }
    public class BTTask_FindPickup : BTTaskNode
    {
        public BTTask_FindPickup(ulong addr) : base(addr) { }
        public float NearPickupRadius { get { return this[nameof(NearPickupRadius)].GetValue<float>(); } set { this[nameof(NearPickupRadius)].SetValue<float>(value); } }
    }
    public class BTTask_FindTeabag : BTTaskNode
    {
        public BTTask_FindTeabag(ulong addr) : base(addr) { }
        public float nearTeaBagRadius { get { return this[nameof(nearTeaBagRadius)].GetValue<float>(); } set { this[nameof(nearTeaBagRadius)].SetValue<float>(value); } }
    }
    public class BTTask_LoseEnemy : BTTaskNode
    {
        public BTTask_LoseEnemy(ulong addr) : base(addr) { }
    }
    public class BTTask_MoveToWithSprint : BTTask_MoveTo
    {
        public BTTask_MoveToWithSprint(ulong addr) : base(addr) { }
    }
    public class BTTask_PlayEmote : BTTaskNode
    {
        public BTTask_PlayEmote(ulong addr) : base(addr) { }
    }
    public class BTTask_Reload : BTTaskNode
    {
        public BTTask_Reload(ulong addr) : base(addr) { }
    }
    public class BTTask_ResetHeardSounds : BTTaskNode
    {
        public BTTask_ResetHeardSounds(ulong addr) : base(addr) { }
    }
    public class BTTask_SetFocus : BTTask_BlackboardBase
    {
        public BTTask_SetFocus(ulong addr) : base(addr) { }
        public bool shouldLookForward { get { return this[nameof(shouldLookForward)].Flag; } set { this[nameof(shouldLookForward)].Flag = value; } }
    }
    public class BTTask_SpawnPortal : BTTaskNode
    {
        public BTTask_SpawnPortal(ulong addr) : base(addr) { }
        public float NearPortalWallRadius { get { return this[nameof(NearPortalWallRadius)].GetValue<float>(); } set { this[nameof(NearPortalWallRadius)].SetValue<float>(value); } }
        public float XYRange { get { return this[nameof(XYRange)].GetValue<float>(); } set { this[nameof(XYRange)].SetValue<float>(value); } }
        public float MinZRange { get { return this[nameof(MinZRange)].GetValue<float>(); } set { this[nameof(MinZRange)].SetValue<float>(value); } }
        public float Timeout { get { return this[nameof(Timeout)].GetValue<float>(); } set { this[nameof(Timeout)].SetValue<float>(value); } }
        public float Delay { get { return this[nameof(Delay)].GetValue<float>(); } set { this[nameof(Delay)].SetValue<float>(value); } }
        public bool bIsLeftPortal { get { return this[nameof(bIsLeftPortal)].Flag; } set { this[nameof(bIsLeftPortal)].Flag = value; } }
    }
    public class BTTask_Strafe : BTTaskNode
    {
        public BTTask_Strafe(ulong addr) : base(addr) { }
        public float IdealRange { get { return this[nameof(IdealRange)].GetValue<float>(); } set { this[nameof(IdealRange)].SetValue<float>(value); } }
        public float MinStrafeDistance { get { return this[nameof(MinStrafeDistance)].GetValue<float>(); } set { this[nameof(MinStrafeDistance)].SetValue<float>(value); } }
        public float MaxStrafeDistance { get { return this[nameof(MaxStrafeDistance)].GetValue<float>(); } set { this[nameof(MaxStrafeDistance)].SetValue<float>(value); } }
        public float RandomConeAngle { get { return this[nameof(RandomConeAngle)].GetValue<float>(); } set { this[nameof(RandomConeAngle)].SetValue<float>(value); } }
    }
    public class BTTask_StrafeQuick : BTTask_MoveTo
    {
        public BTTask_StrafeQuick(ulong addr) : base(addr) { }
        public float MinStrafeDistance { get { return this[nameof(MinStrafeDistance)].GetValue<float>(); } set { this[nameof(MinStrafeDistance)].SetValue<float>(value); } }
        public float MaxStrafeDistance { get { return this[nameof(MaxStrafeDistance)].GetValue<float>(); } set { this[nameof(MaxStrafeDistance)].SetValue<float>(value); } }
        public float TolerableRadius { get { return this[nameof(TolerableRadius)].GetValue<float>(); } set { this[nameof(TolerableRadius)].SetValue<float>(value); } }
        public float ProbabilityToCrouch { get { return this[nameof(ProbabilityToCrouch)].GetValue<float>(); } set { this[nameof(ProbabilityToCrouch)].SetValue<float>(value); } }
        public float MinCrouchedTime { get { return this[nameof(MinCrouchedTime)].GetValue<float>(); } set { this[nameof(MinCrouchedTime)].SetValue<float>(value); } }
        public float MaxCrouchedTime { get { return this[nameof(MaxCrouchedTime)].GetValue<float>(); } set { this[nameof(MaxCrouchedTime)].SetValue<float>(value); } }
        public float MinTimeBetweenCrouch { get { return this[nameof(MinTimeBetweenCrouch)].GetValue<float>(); } set { this[nameof(MinTimeBetweenCrouch)].SetValue<float>(value); } }
        public float MaxTimeBetweenCrouch { get { return this[nameof(MaxTimeBetweenCrouch)].GetValue<float>(); } set { this[nameof(MaxTimeBetweenCrouch)].SetValue<float>(value); } }
        public float MaxAngleForAimedAtTest { get { return this[nameof(MaxAngleForAimedAtTest)].GetValue<float>(); } set { this[nameof(MaxAngleForAimedAtTest)].SetValue<float>(value); } }
        public float MinDifficultyForQuickStraffing { get { return this[nameof(MinDifficultyForQuickStraffing)].GetValue<float>(); } set { this[nameof(MinDifficultyForQuickStraffing)].SetValue<float>(value); } }
        public float MinDifficultyForOccasionalQuickStraffing { get { return this[nameof(MinDifficultyForOccasionalQuickStraffing)].GetValue<float>(); } set { this[nameof(MinDifficultyForOccasionalQuickStraffing)].SetValue<float>(value); } }
        public float ProbabilityForOccasionalQuickStraffing { get { return this[nameof(ProbabilityForOccasionalQuickStraffing)].GetValue<float>(); } set { this[nameof(ProbabilityForOccasionalQuickStraffing)].SetValue<float>(value); } }
        public bool bUseLazyWhenNotAimedAt { get { return this[nameof(bUseLazyWhenNotAimedAt)].Flag; } set { this[nameof(bUseLazyWhenNotAimedAt)].Flag = value; } }
        public float IdealRangeForNonTraceWeapon { get { return this[nameof(IdealRangeForNonTraceWeapon)].GetValue<float>(); } set { this[nameof(IdealRangeForNonTraceWeapon)].SetValue<float>(value); } }
        public float MinStrafeDistanceLazy { get { return this[nameof(MinStrafeDistanceLazy)].GetValue<float>(); } set { this[nameof(MinStrafeDistanceLazy)].SetValue<float>(value); } }
        public float MaxStrafeDistanceLazy { get { return this[nameof(MaxStrafeDistanceLazy)].GetValue<float>(); } set { this[nameof(MaxStrafeDistanceLazy)].SetValue<float>(value); } }
        public float RandomConeAngleLazy { get { return this[nameof(RandomConeAngleLazy)].GetValue<float>(); } set { this[nameof(RandomConeAngleLazy)].SetValue<float>(value); } }
    }
    public class BTTask_StuckMove : BTTask_MoveTo
    {
        public BTTask_StuckMove(ulong addr) : base(addr) { }
    }
    public class BTTask_UsePortal : BTTaskNode
    {
        public BTTask_UsePortal(ulong addr) : base(addr) { }
        public float Timeout { get { return this[nameof(Timeout)].GetValue<float>(); } set { this[nameof(Timeout)].SetValue<float>(value); } }
    }
    public class BTTask_Wander : BTTask_MoveTo
    {
        public BTTask_Wander(ulong addr) : base(addr) { }
        public float WanderRadius { get { return this[nameof(WanderRadius)].GetValue<float>(); } set { this[nameof(WanderRadius)].SetValue<float>(value); } }
        public float WanderOffset { get { return this[nameof(WanderOffset)].GetValue<float>(); } set { this[nameof(WanderOffset)].SetValue<float>(value); } }
        public bool bShouldWanderForward { get { return this[nameof(bShouldWanderForward)].Flag; } set { this[nameof(bShouldWanderForward)].Flag = value; } }
        public bool bKeepWandering { get { return this[nameof(bKeepWandering)].Flag; } set { this[nameof(bKeepWandering)].Flag = value; } }
        public bool bCanSprint { get { return this[nameof(bCanSprint)].Flag; } set { this[nameof(bCanSprint)].Flag = value; } }
        public bool bUseBlackboardCenter { get { return this[nameof(bUseBlackboardCenter)].Flag; } set { this[nameof(bUseBlackboardCenter)].Flag = value; } }
        public BlackboardKeySelector BlackboardKeyActorWanderCenter { get { return this[nameof(BlackboardKeyActorWanderCenter)].As<BlackboardKeySelector>(); } set { this["BlackboardKeyActorWanderCenter"] = value; } }
    }
    public class BTTask_WanderMoveTo : BTTask_MoveToWithSprint
    {
        public BTTask_WanderMoveTo(ulong addr) : base(addr) { }
    }
    public class BTTaskNode_FindNearbyPortalWall : BTTaskNode
    {
        public BTTaskNode_FindNearbyPortalWall(ulong addr) : base(addr) { }
        public float NearPortalWallRadius { get { return this[nameof(NearPortalWallRadius)].GetValue<float>(); } set { this[nameof(NearPortalWallRadius)].SetValue<float>(value); } }
    }
    public class BTTaskNode_SetEnemyAsTargetLocation : BTTaskNode
    {
        public BTTaskNode_SetEnemyAsTargetLocation(ulong addr) : base(addr) { }
    }
    public class BTTaskNode_SetTargetLoc : BTTask_BlackboardBase
    {
        public BTTaskNode_SetTargetLoc(ulong addr) : base(addr) { }
    }
    public class BTTaskPickupGun : BTTaskNode
    {
        public BTTaskPickupGun(ulong addr) : base(addr) { }
    }
    public class CharacterPieceSkeletalMeshComponent : SkeletalMeshComponent
    {
        public CharacterPieceSkeletalMeshComponent(ulong addr) : base(addr) { }
    }
    public class PortalWarsAIController : AIController
    {
        public PortalWarsAIController(ulong addr) : base(addr) { }
        public BlackboardComponent BlackboardComp { get { return this[nameof(BlackboardComp)].As<BlackboardComponent>(); } set { this["BlackboardComp"] = value; } }
        public BehaviorTreeComponent BehaviorComp { get { return this[nameof(BehaviorComp)].As<BehaviorTreeComponent>(); } set { this["BehaviorComp"] = value; } }
        public AISenseConfig_Hearing HearConfig { get { return this[nameof(HearConfig)].As<AISenseConfig_Hearing>(); } set { this["HearConfig"] = value; } }
        public float MinOffsetHeightPathFollowing { get { return this[nameof(MinOffsetHeightPathFollowing)].GetValue<float>(); } set { this[nameof(MinOffsetHeightPathFollowing)].SetValue<float>(value); } }
        public float MaxOffsetHeightPathFollowing { get { return this[nameof(MaxOffsetHeightPathFollowing)].GetValue<float>(); } set { this[nameof(MaxOffsetHeightPathFollowing)].SetValue<float>(value); } }
        public float MaxOffsetLateralPathFollowing { get { return this[nameof(MaxOffsetLateralPathFollowing)].GetValue<float>(); } set { this[nameof(MaxOffsetLateralPathFollowing)].SetValue<float>(value); } }
        public void SetPortalEnemy(Pawn InPawn, Vector InFocusLoc) { Invoke(nameof(SetPortalEnemy), InPawn, InFocusLoc); }
        public void SetNearPortalWall(PortalWall Wall) { Invoke(nameof(SetNearPortalWall), Wall); }
        public void SetLeftPortal(Portal InPortal) { Invoke(nameof(SetLeftPortal), InPortal); }
        public void SetEnemy(Pawn InPawn) { Invoke(nameof(SetEnemy), InPawn); }
        public void ResetHeardSounds() { Invoke(nameof(ResetHeardSounds)); }
        public void ReloadGun() { Invoke(nameof(ReloadGun)); }
        public void ReceivedKills() { Invoke(nameof(ReceivedKills)); }
        public bool PortalLineOfSightTo(PortalWarsCharacter Enemy, Vector OutFocusLoc, Portal Portal) { return Invoke<bool>(nameof(PortalLineOfSightTo), Enemy, OutFocusLoc, Portal); }
        public Vector GetTargetLoc() { return Invoke<Vector>(nameof(GetTargetLoc)); }
        public Vector GetNavRecoveryDestination() { return Invoke<Vector>(nameof(GetNavRecoveryDestination)); }
        public Portal GetLeftPortal() { return Invoke<Portal>(nameof(GetLeftPortal)); }
        public Vector GetGoalLocation() { return Invoke<Vector>(nameof(GetGoalLocation)); }
        public PortalWarsCharacter GetEnemy() { return Invoke<PortalWarsCharacter>(nameof(GetEnemy)); }
        public PortalWarsCharacter FindPortalEnemyThruPortal(Vector OutPortalEnemyLoc, Portal Portal) { return Invoke<PortalWarsCharacter>(nameof(FindPortalEnemyThruPortal), OutPortalEnemyLoc, Portal); }
        public PortalWarsCharacter FindPortalEnemy(Vector OutLocationThroughPortal, Portal OutPortalChecked) { return Invoke<PortalWarsCharacter>(nameof(FindPortalEnemy), OutLocationThroughPortal, OutPortalChecked); }
        public PortalWarsCharacter FindClosestVisibleEnemy(bool bWithLOS) { return Invoke<PortalWarsCharacter>(nameof(FindClosestVisibleEnemy), bWithLOS); }
    }
    public class CTFPortalWarsAIController : PortalWarsAIController
    {
        public CTFPortalWarsAIController(ulong addr) : base(addr) { }
    }
    public class DMR : LineTraceGun
    {
        public DMR(ulong addr) : base(addr) { }
    }
    public class DominationHill : Actor
    {
        public DominationHill(ulong addr) : base(addr) { }
        public EDOMHillState HillState { get { return (EDOMHillState)this[nameof(HillState)].GetValue<int>(); } set { this[nameof(HillState)].SetValue<int>((int)value); } }
        public LinearColor DefaultHillColor { get { return this[nameof(DefaultHillColor)].As<LinearColor>(); } set { this["DefaultHillColor"] = value; } }
        public LinearColor FriendlyTeamHillColor { get { return this[nameof(FriendlyTeamHillColor)].As<LinearColor>(); } set { this["FriendlyTeamHillColor"] = value; } }
        public LinearColor EnemyTeamHillColor { get { return this[nameof(EnemyTeamHillColor)].As<LinearColor>(); } set { this["EnemyTeamHillColor"] = value; } }
        public LinearColor AlphaTeamHillColor { get { return this[nameof(AlphaTeamHillColor)].As<LinearColor>(); } set { this["AlphaTeamHillColor"] = value; } }
        public LinearColor BravoTeamHillColor { get { return this[nameof(BravoTeamHillColor)].As<LinearColor>(); } set { this["BravoTeamHillColor"] = value; } }
        public SceneComponent reachableLocComponent { get { return this[nameof(reachableLocComponent)].As<SceneComponent>(); } set { this["reachableLocComponent"] = value; } }
        public Object HillName { get { return this[nameof(HillName)]; } set { this[nameof(HillName)] = value; } }
        public PortalWarsDOMHillIndicator Indicator { get { return this[nameof(Indicator)].As<PortalWarsDOMHillIndicator>(); } set { this["Indicator"] = value; } }
        public float timeToCaptureHill { get { return this[nameof(timeToCaptureHill)].GetValue<float>(); } set { this[nameof(timeToCaptureHill)].SetValue<float>(value); } }
        public float timeCapturingHill { get { return this[nameof(timeCapturingHill)].GetValue<float>(); } set { this[nameof(timeCapturingHill)].SetValue<float>(value); } }
        public Array<int> TeamCount { get { return new Array<int>(this[nameof(TeamCount)].Address); } }
        public bool bIsActive { get { return this[nameof(bIsActive)].Flag; } set { this[nameof(bIsActive)].Flag = value; } }
        public StaticMeshComponent Mesh { get { return this[nameof(Mesh)].As<StaticMeshComponent>(); } set { this["Mesh"] = value; } }
        public StaticMeshComponent OverlapMesh { get { return this[nameof(OverlapMesh)].As<StaticMeshComponent>(); } set { this["OverlapMesh"] = value; } }
        public void OnRep_IsActive() { Invoke(nameof(OnRep_IsActive)); }
        public void OnRep_HillState(EDOMHillState PrevState) { Invoke(nameof(OnRep_HillState), PrevState); }
        public float getTimeToCaptureHill() { return Invoke<float>(nameof(getTimeToCaptureHill)); }
        public float getTimeCapturingHill() { return Invoke<float>(nameof(getTimeCapturingHill)); }
        public int GetControllingTeam() { return Invoke<int>(nameof(GetControllingTeam)); }
    }
    public class DOMPortalWarsAIController : PortalWarsAIController
    {
        public DOMPortalWarsAIController(ulong addr) : base(addr) { }
    }
    public class Projectile : CullableActor
    {
        public Projectile(ulong addr) : base(addr) { }
        public PWProjectileMovementComponent MovementComp { get { return this[nameof(MovementComp)].As<PWProjectileMovementComponent>(); } set { this["MovementComp"] = value; } }
        public SphereComponent CollisionComp { get { return this[nameof(CollisionComp)].As<SphereComponent>(); } set { this["CollisionComp"] = value; } }
        public SphereComponent PawnCollisionComp { get { return this[nameof(PawnCollisionComp)].As<SphereComponent>(); } set { this["PawnCollisionComp"] = value; } }
        public byte ProjectileID { get { return this[nameof(ProjectileID)].GetValue<byte>(); } set { this[nameof(ProjectileID)].SetValue<byte>(value); } }
        public bool bIsInitialProjectile { get { return this[nameof(bIsInitialProjectile)].Flag; } set { this[nameof(bIsInitialProjectile)].Flag = value; } }
        public PortalWarsAkComponent AkComp { get { return this[nameof(AkComp)].As<PortalWarsAkComponent>(); } set { this["AkComp"] = value; } }
        public ParticleSystemComponent ParticleComp { get { return this[nameof(ParticleComp)].As<ParticleSystemComponent>(); } set { this["ParticleComp"] = value; } }
        public StaticMeshComponent MeshComp { get { return this[nameof(MeshComp)].As<StaticMeshComponent>(); } set { this["MeshComp"] = value; } }
        public ParticleSystem ExplosionFX { get { return this[nameof(ExplosionFX)].As<ParticleSystem>(); } set { this["ExplosionFX"] = value; } }
        public AkAudioEvent ExplosionEvent { get { return this[nameof(ExplosionEvent)].As<AkAudioEvent>(); } set { this["ExplosionEvent"] = value; } }
        public AkAudioEvent ProjectileLoopStartEvent { get { return this[nameof(ProjectileLoopStartEvent)].As<AkAudioEvent>(); } set { this["ProjectileLoopStartEvent"] = value; } }
        public AkAudioEvent ProjectileLoopStopEvent { get { return this[nameof(ProjectileLoopStopEvent)].As<AkAudioEvent>(); } set { this["ProjectileLoopStopEvent"] = value; } }
        public DecalData Decal { get { return this[nameof(Decal)].As<DecalData>(); } set { this["Decal"] = value; } }
        public bool canTeleport { get { return this[nameof(canTeleport)].Flag; } set { this[nameof(canTeleport)].Flag = value; } }
        public bool bExploded { get { return this[nameof(bExploded)].Flag; } set { this[nameof(bExploded)].Flag = value; } }
        public bool bDestroyed { get { return this[nameof(bDestroyed)].Flag; } set { this[nameof(bDestroyed)].Flag = value; } }
        public float OverlapSphereGrowthRate { get { return this[nameof(OverlapSphereGrowthRate)].GetValue<float>(); } set { this[nameof(OverlapSphereGrowthRate)].SetValue<float>(value); } }
        public float MaxPawnOverlapSphereSize { get { return this[nameof(MaxPawnOverlapSphereSize)].GetValue<float>(); } set { this[nameof(MaxPawnOverlapSphereSize)].SetValue<float>(value); } }
        public void OnRep_ProjectileID() { Invoke(nameof(OnRep_ProjectileID)); }
        public void OnRep_Exploded() { Invoke(nameof(OnRep_Exploded)); }
        public void OnImpact(HitResult HitResult) { Invoke(nameof(OnImpact), HitResult); }
        public void DisableAndDestroy() { Invoke(nameof(DisableAndDestroy)); }
    }
    public class ExplosiveProjectile : Projectile
    {
        public ExplosiveProjectile(ulong addr) : base(addr) { }
        public float ExplosionRadius { get { return this[nameof(ExplosionRadius)].GetValue<float>(); } set { this[nameof(ExplosionRadius)].SetValue<float>(value); } }
        public float ExplosionInnerRadius { get { return this[nameof(ExplosionInnerRadius)].GetValue<float>(); } set { this[nameof(ExplosionInnerRadius)].SetValue<float>(value); } }
    }
    public class EMPExplosiveProjectile : ExplosiveProjectile
    {
        public EMPExplosiveProjectile(ulong addr) : base(addr) { }
        public Object GrenadePickupClass { get { return this[nameof(GrenadePickupClass)]; } set { this[nameof(GrenadePickupClass)] = value; } }
    }
    public class EnvQueryGenerator_PathGridOffset : EnvQueryGenerator_SimpleGrid
    {
        public EnvQueryGenerator_PathGridOffset(ulong addr) : base(addr) { }
        public AIDataProviderBoolValue PathToItem { get { return this[nameof(PathToItem)].As<AIDataProviderBoolValue>(); } set { this["PathToItem"] = value; } }
        public Object NavigationFilter { get { return this[nameof(NavigationFilter)]; } set { this[nameof(NavigationFilter)] = value; } }
        public AIDataProviderFloatValue ScanRangeMultiplier { get { return this[nameof(ScanRangeMultiplier)].As<AIDataProviderFloatValue>(); } set { this["ScanRangeMultiplier"] = value; } }
        public AIDataProviderFloatValue OffsetSize { get { return this[nameof(OffsetSize)].As<AIDataProviderFloatValue>(); } set { this["OffsetSize"] = value; } }
        public AIDataProviderBoolValue RandomizeProjectionData { get { return this[nameof(RandomizeProjectionData)].As<AIDataProviderBoolValue>(); } set { this["RandomizeProjectionData"] = value; } }
        public AIDataProviderFloatValue ProjectDownRandomMultiplier { get { return this[nameof(ProjectDownRandomMultiplier)].As<AIDataProviderFloatValue>(); } set { this["ProjectDownRandomMultiplier"] = value; } }
        public AIDataProviderFloatValue ProjectUpRandomMultiplier { get { return this[nameof(ProjectUpRandomMultiplier)].As<AIDataProviderFloatValue>(); } set { this["ProjectUpRandomMultiplier"] = value; } }
        public AIDataProviderFloatValue ExtentXRandomMultiplier { get { return this[nameof(ExtentXRandomMultiplier)].As<AIDataProviderFloatValue>(); } set { this["ExtentXRandomMultiplier"] = value; } }
    }
    public class Fists : Gun
    {
        public Fists(ulong addr) : base(addr) { }
    }
    public class FlagCaptureZone : Actor
    {
        public FlagCaptureZone(ulong addr) : base(addr) { }
        public byte TeamIndex { get { return this[nameof(TeamIndex)].GetValue<byte>(); } set { this[nameof(TeamIndex)].SetValue<byte>(value); } }
        public PortalWarsFlagZoneIndicator Indicator { get { return this[nameof(Indicator)].As<PortalWarsFlagZoneIndicator>(); } set { this["Indicator"] = value; } }
        public StaticMeshComponent Mesh { get { return this[nameof(Mesh)].As<StaticMeshComponent>(); } set { this["Mesh"] = value; } }
        public StaticMeshComponent OverlapMesh { get { return this[nameof(OverlapMesh)].As<StaticMeshComponent>(); } set { this["OverlapMesh"] = value; } }
        public SceneComponent FlagSpawnPoint { get { return this[nameof(FlagSpawnPoint)].As<SceneComponent>(); } set { this["FlagSpawnPoint"] = value; } }
        public Object FlagPickupClass { get { return this[nameof(FlagPickupClass)]; } set { this[nameof(FlagPickupClass)] = value; } }
        public PortalWarsCTFGameState CTFGameState { get { return this[nameof(CTFGameState)].As<PortalWarsCTFGameState>(); } set { this["CTFGameState"] = value; } }
        public PortalWarsNeutralCTFGameState NeutralCTFGameState { get { return this[nameof(NeutralCTFGameState)].As<PortalWarsNeutralCTFGameState>(); } set { this["NeutralCTFGameState"] = value; } }
    }
    public class SpecialItem : Gun
    {
        public SpecialItem(ulong addr) : base(addr) { }
    }
    public class FlagItem : SpecialItem
    {
        public FlagItem(ulong addr) : base(addr) { }
        public byte TeamIndex { get { return this[nameof(TeamIndex)].GetValue<byte>(); } set { this[nameof(TeamIndex)].SetValue<byte>(value); } }
        public MaterialInstance FriendlyTeamFlagMaterial { get { return this[nameof(FriendlyTeamFlagMaterial)].As<MaterialInstance>(); } set { this["FriendlyTeamFlagMaterial"] = value; } }
        public MaterialInstance EnemyTeamFlagMaterial { get { return this[nameof(EnemyTeamFlagMaterial)].As<MaterialInstance>(); } set { this["EnemyTeamFlagMaterial"] = value; } }
        public MaterialInstance AlphaTeamFlagMaterial { get { return this[nameof(AlphaTeamFlagMaterial)].As<MaterialInstance>(); } set { this["AlphaTeamFlagMaterial"] = value; } }
        public MaterialInstance BravoTeamFlagMaterial { get { return this[nameof(BravoTeamFlagMaterial)].As<MaterialInstance>(); } set { this["BravoTeamFlagMaterial"] = value; } }
        public PortalWarsCTFGameState CTFGameState { get { return this[nameof(CTFGameState)].As<PortalWarsCTFGameState>(); } set { this["CTFGameState"] = value; } }
        public void OnRep_Team() { Invoke(nameof(OnRep_Team)); }
    }
    public class TeleportableActor : CullableActor
    {
        public TeleportableActor(ulong addr) : base(addr) { }
    }
    public class PortalWarsPickup : TeleportableActor
    {
        public PortalWarsPickup(ulong addr) : base(addr) { }
        public float PickupLifetime { get { return this[nameof(PickupLifetime)].GetValue<float>(); } set { this[nameof(PickupLifetime)].SetValue<float>(value); } }
        public float InitVelocityMultiplier { get { return this[nameof(InitVelocityMultiplier)].GetValue<float>(); } set { this[nameof(InitVelocityMultiplier)].SetValue<float>(value); } }
        public bool validForAI { get { return this[nameof(validForAI)].Flag; } set { this[nameof(validForAI)].Flag = value; } }
        public bool AllowAutoPickup { get { return this[nameof(AllowAutoPickup)].Flag; } set { this[nameof(AllowAutoPickup)].Flag = value; } }
        public bool AllowManualPickup { get { return this[nameof(AllowManualPickup)].Flag; } set { this[nameof(AllowManualPickup)].Flag = value; } }
        public StaticMeshComponent PickupMesh { get { return this[nameof(PickupMesh)].As<StaticMeshComponent>(); } set { this["PickupMesh"] = value; } }
        public bool bIsGravityEnabled { get { return this[nameof(bIsGravityEnabled)].Flag; } set { this[nameof(bIsGravityEnabled)].Flag = value; } }
        public float PickupDistance { get { return this[nameof(PickupDistance)].GetValue<float>(); } set { this[nameof(PickupDistance)].SetValue<float>(value); } }
        public PortalWarsTutorialGoal Goal { get { return this[nameof(Goal)].As<PortalWarsTutorialGoal>(); } set { this["Goal"] = value; } }
        public int HiddenUntilGoal { get { return this[nameof(HiddenUntilGoal)].GetValue<int>(); } set { this[nameof(HiddenUntilGoal)].SetValue<int>(value); } }
    }
    public class PortalWarsGunPickup : PortalWarsPickup
    {
        public PortalWarsGunPickup(ulong addr) : base(addr) { }
        public Object WeaponClass { get { return this[nameof(WeaponClass)]; } set { this[nameof(WeaponClass)] = value; } }
        public byte gunValue { get { return this[nameof(gunValue)].GetValue<byte>(); } set { this[nameof(gunValue)].SetValue<byte>(value); } }
        public Object GunDisplayName { get { return this[nameof(GunDisplayName)]; } set { this[nameof(GunDisplayName)] = value; } }
        public Texture2D GunImage { get { return this[nameof(GunImage)].As<Texture2D>(); } set { this["GunImage"] = value; } }
        public int GunID { get { return this[nameof(GunID)].GetValue<int>(); } set { this[nameof(GunID)].SetValue<int>(value); } }
        public int TotalAmmo { get { return this[nameof(TotalAmmo)].GetValue<int>(); } set { this[nameof(TotalAmmo)].SetValue<int>(value); } }
        public float ImpactThreshold { get { return this[nameof(ImpactThreshold)].GetValue<float>(); } set { this[nameof(ImpactThreshold)].SetValue<float>(value); } }
        public void OnGunImageLoaded() { Invoke(nameof(OnGunImageLoaded)); }
        public void OnComponentHit(PrimitiveComponent HitComp, Actor OtherActor, PrimitiveComponent OtherComp, Vector NormalImpulse, HitResult Hit) { Invoke(nameof(OnComponentHit), HitComp, OtherActor, OtherComp, NormalImpulse, Hit); }
    }
    public class FlagItemPickup : PortalWarsGunPickup
    {
        public FlagItemPickup(ulong addr) : base(addr) { }
        public bool bAtInitialSpawn { get { return this[nameof(bAtInitialSpawn)].Flag; } set { this[nameof(bAtInitialSpawn)].Flag = value; } }
        public byte TeamIndex { get { return this[nameof(TeamIndex)].GetValue<byte>(); } set { this[nameof(TeamIndex)].SetValue<byte>(value); } }
        public CapsuleComponent CapsuleCollisionComp { get { return this[nameof(CapsuleCollisionComp)].As<CapsuleComponent>(); } set { this["CapsuleCollisionComp"] = value; } }
        public MaterialInstance FriendlyTeamFlagMaterial { get { return this[nameof(FriendlyTeamFlagMaterial)].As<MaterialInstance>(); } set { this["FriendlyTeamFlagMaterial"] = value; } }
        public MaterialInstance EnemyTeamFlagMaterial { get { return this[nameof(EnemyTeamFlagMaterial)].As<MaterialInstance>(); } set { this["EnemyTeamFlagMaterial"] = value; } }
        public MaterialInstance AlphaTeamFlagMaterial { get { return this[nameof(AlphaTeamFlagMaterial)].As<MaterialInstance>(); } set { this["AlphaTeamFlagMaterial"] = value; } }
        public MaterialInstance BravoTeamFlagMaterial { get { return this[nameof(BravoTeamFlagMaterial)].As<MaterialInstance>(); } set { this["BravoTeamFlagMaterial"] = value; } }
        public float CurrentTimeToReset { get { return this[nameof(CurrentTimeToReset)].GetValue<float>(); } set { this[nameof(CurrentTimeToReset)].SetValue<float>(value); } }
        public PortalWarsCTFGameState CTFGameState { get { return this[nameof(CTFGameState)].As<PortalWarsCTFGameState>(); } set { this["CTFGameState"] = value; } }
        public Vector BoxExtent { get { return this[nameof(BoxExtent)].As<Vector>(); } set { this["BoxExtent"] = value; } }
        public float BoxZOffset { get { return this[nameof(BoxZOffset)].GetValue<float>(); } set { this[nameof(BoxZOffset)].SetValue<float>(value); } }
        public void OnRep_Team() { Invoke(nameof(OnRep_Team)); }
    }
    public class ProjectileGun : Gun
    {
        public ProjectileGun(ulong addr) : base(addr) { }
        public ProjectileWeaponData ProjectileConfig { get { return this[nameof(ProjectileConfig)].As<ProjectileWeaponData>(); } set { this["ProjectileConfig"] = value; } }
        public float LocalHitDetectionDuration { get { return this[nameof(LocalHitDetectionDuration)].GetValue<float>(); } set { this[nameof(LocalHitDetectionDuration)].SetValue<float>(value); } }
        public bool bSpawnsLocalProjectiles { get { return this[nameof(bSpawnsLocalProjectiles)].Flag; } set { this[nameof(bSpawnsLocalProjectiles)].Flag = value; } }
        public Array<Projectile> LocalProjectiles { get { return new Array<Projectile>(this[nameof(LocalProjectiles)].Address); } }
        public void ServerSpawnProjectile(Vector_NetQuantize Origin, Vector_NetQuantizeNormal Dir, byte ProjectileID) { Invoke(nameof(ServerSpawnProjectile), Origin, Dir, ProjectileID); }
        public void ServerHandleExplosionLocal(HitResult Impact, byte ProjectileID) { Invoke(nameof(ServerHandleExplosionLocal), Impact, ProjectileID); }
    }
    public class GrenadeLauncher : ProjectileGun
    {
        public GrenadeLauncher(ulong addr) : base(addr) { }
        public byte CurrentGrenades { get { return this[nameof(CurrentGrenades)].GetValue<byte>(); } set { this[nameof(CurrentGrenades)].SetValue<byte>(value); } }
        public byte NumStartingGrenades { get { return this[nameof(NumStartingGrenades)].GetValue<byte>(); } set { this[nameof(NumStartingGrenades)].SetValue<byte>(value); } }
        public byte MaxGrenades { get { return this[nameof(MaxGrenades)].GetValue<byte>(); } set { this[nameof(MaxGrenades)].SetValue<byte>(value); } }
    }
    public class GunImpactEffectManager : Actor
    {
        public GunImpactEffectManager(ulong addr) : base(addr) { }
        public ParticleSystem DefaultFX { get { return this[nameof(DefaultFX)].As<ParticleSystem>(); } set { this["DefaultFX"] = value; } }
        public ParticleSystem ConcreteFX { get { return this[nameof(ConcreteFX)].As<ParticleSystem>(); } set { this["ConcreteFX"] = value; } }
        public ParticleSystem DirtFX { get { return this[nameof(DirtFX)].As<ParticleSystem>(); } set { this["DirtFX"] = value; } }
        public ParticleSystem WaterFX { get { return this[nameof(WaterFX)].As<ParticleSystem>(); } set { this["WaterFX"] = value; } }
        public ParticleSystem SnowFX { get { return this[nameof(SnowFX)].As<ParticleSystem>(); } set { this["SnowFX"] = value; } }
        public ParticleSystem MetalFX { get { return this[nameof(MetalFX)].As<ParticleSystem>(); } set { this["MetalFX"] = value; } }
        public ParticleSystem WoodFX { get { return this[nameof(WoodFX)].As<ParticleSystem>(); } set { this["WoodFX"] = value; } }
        public ParticleSystem GlassFX { get { return this[nameof(GlassFX)].As<ParticleSystem>(); } set { this["GlassFX"] = value; } }
        public ParticleSystem GrassFX { get { return this[nameof(GrassFX)].As<ParticleSystem>(); } set { this["GrassFX"] = value; } }
        public ParticleSystem FleshFX { get { return this[nameof(FleshFX)].As<ParticleSystem>(); } set { this["FleshFX"] = value; } }
        public ParticleSystem BrickFX { get { return this[nameof(BrickFX)].As<ParticleSystem>(); } set { this["BrickFX"] = value; } }
        public ParticleSystem ClothFX { get { return this[nameof(ClothFX)].As<ParticleSystem>(); } set { this["ClothFX"] = value; } }
        public ParticleSystem RubberFX { get { return this[nameof(RubberFX)].As<ParticleSystem>(); } set { this["RubberFX"] = value; } }
        public ParticleSystem PlasticFX { get { return this[nameof(PlasticFX)].As<ParticleSystem>(); } set { this["PlasticFX"] = value; } }
        public ParticleSystem PortalWallFX { get { return this[nameof(PortalWallFX)].As<ParticleSystem>(); } set { this["PortalWallFX"] = value; } }
        public DecalData DefaultDecal { get { return this[nameof(DefaultDecal)].As<DecalData>(); } set { this["DefaultDecal"] = value; } }
        public AkAudioEvent BulletImpactEvent { get { return this[nameof(BulletImpactEvent)].As<AkAudioEvent>(); } set { this["BulletImpactEvent"] = value; } }
    }
    public class ImpactProjectile : Projectile
    {
        public ImpactProjectile(ulong addr) : base(addr) { }
    }
    public class IntegerSpinBox : Widget
    {
        public IntegerSpinBox(ulong addr) : base(addr) { }
        public int Value { get { return this[nameof(Value)].GetValue<int>(); } set { this[nameof(Value)].SetValue<int>(value); } }
        public Object ValueDelegate { get { return this[nameof(ValueDelegate)]; } set { this[nameof(ValueDelegate)] = value; } }
        public SpinBoxStyle WidgetStyle { get { return this[nameof(WidgetStyle)].As<SpinBoxStyle>(); } set { this["WidgetStyle"] = value; } }
        public SlateWidgetStyleAsset Style { get { return this[nameof(Style)].As<SlateWidgetStyleAsset>(); } set { this["Style"] = value; } }
        public int Delta { get { return this[nameof(Delta)].GetValue<int>(); } set { this[nameof(Delta)].SetValue<int>(value); } }
        public int SliderExponent { get { return this[nameof(SliderExponent)].GetValue<int>(); } set { this[nameof(SliderExponent)].SetValue<int>(value); } }
        public SlateFontInfo Font { get { return this[nameof(Font)].As<SlateFontInfo>(); } set { this["Font"] = value; } }
        public byte Justification { get { return this[nameof(Justification)].GetValue<byte>(); } set { this[nameof(Justification)].SetValue<byte>(value); } }
        public float MinDesiredWidth { get { return this[nameof(MinDesiredWidth)].GetValue<float>(); } set { this[nameof(MinDesiredWidth)].SetValue<float>(value); } }
        public bool ClearKeyboardFocusOnCommit { get { return this[nameof(ClearKeyboardFocusOnCommit)].Flag; } set { this[nameof(ClearKeyboardFocusOnCommit)].Flag = value; } }
        public bool SelectAllTextOnCommit { get { return this[nameof(SelectAllTextOnCommit)].Flag; } set { this[nameof(SelectAllTextOnCommit)].Flag = value; } }
        public SlateColor ForegroundColor { get { return this[nameof(ForegroundColor)].As<SlateColor>(); } set { this["ForegroundColor"] = value; } }
        public Object OnValueChanged { get { return this[nameof(OnValueChanged)]; } set { this[nameof(OnValueChanged)] = value; } }
        public Object OnValueCommitted { get { return this[nameof(OnValueCommitted)]; } set { this[nameof(OnValueCommitted)] = value; } }
        public Object OnBeginSliderMovement { get { return this[nameof(OnBeginSliderMovement)]; } set { this[nameof(OnBeginSliderMovement)] = value; } }
        public Object OnEndSliderMovement { get { return this[nameof(OnEndSliderMovement)]; } set { this[nameof(OnEndSliderMovement)] = value; } }
        public bool bOverride_MinValue { get { return this[nameof(bOverride_MinValue)].Flag; } set { this[nameof(bOverride_MinValue)].Flag = value; } }
        public bool bOverride_MaxValue { get { return this[nameof(bOverride_MaxValue)].Flag; } set { this[nameof(bOverride_MaxValue)].Flag = value; } }
        public bool bOverride_MinSliderValue { get { return this[nameof(bOverride_MinSliderValue)].Flag; } set { this[nameof(bOverride_MinSliderValue)].Flag = value; } }
        public bool bOverride_MaxSliderValue { get { return this[nameof(bOverride_MaxSliderValue)].Flag; } set { this[nameof(bOverride_MaxSliderValue)].Flag = value; } }
        public int MinValue { get { return this[nameof(MinValue)].GetValue<int>(); } set { this[nameof(MinValue)].SetValue<int>(value); } }
        public int MaxValue { get { return this[nameof(MaxValue)].GetValue<int>(); } set { this[nameof(MaxValue)].SetValue<int>(value); } }
        public int MinSliderValue { get { return this[nameof(MinSliderValue)].GetValue<int>(); } set { this[nameof(MinSliderValue)].SetValue<int>(value); } }
        public int MaxSliderValue { get { return this[nameof(MaxSliderValue)].GetValue<int>(); } set { this[nameof(MaxSliderValue)].SetValue<int>(value); } }
        public void SetValue(int NewValue) { Invoke(nameof(SetValue), NewValue); }
        public void SetMinValue(int NewValue) { Invoke(nameof(SetMinValue), NewValue); }
        public void SetMinSliderValue(int NewValue) { Invoke(nameof(SetMinSliderValue), NewValue); }
        public void SetMaxValue(int NewValue) { Invoke(nameof(SetMaxValue), NewValue); }
        public void SetMaxSliderValue(int NewValue) { Invoke(nameof(SetMaxSliderValue), NewValue); }
        public void SetForegroundColor(SlateColor InForegroundColor) { Invoke(nameof(SetForegroundColor), InForegroundColor); }
        public void OnSpinBoxValueCommittedEvent__DelegateSignature(int InValue, byte CommitMethod) { Invoke(nameof(OnSpinBoxValueCommittedEvent__DelegateSignature), InValue, CommitMethod); }
        public void OnSpinBoxValueChangedEvent__DelegateSignature(int InValue) { Invoke(nameof(OnSpinBoxValueChangedEvent__DelegateSignature), InValue); }
        public void OnSpinBoxBeginSliderMovement__DelegateSignature() { Invoke(nameof(OnSpinBoxBeginSliderMovement__DelegateSignature)); }
        public int GetValue() { return Invoke<int>(nameof(GetValue)); }
        public int GetMinValue() { return Invoke<int>(nameof(GetMinValue)); }
        public int GetMinSliderValue() { return Invoke<int>(nameof(GetMinSliderValue)); }
        public int GetMaxValue() { return Invoke<int>(nameof(GetMaxValue)); }
        public int GetMaxSliderValue() { return Invoke<int>(nameof(GetMaxSliderValue)); }
        public void ClearMinValue() { Invoke(nameof(ClearMinValue)); }
        public void ClearMinSliderValue() { Invoke(nameof(ClearMinSliderValue)); }
        public void ClearMaxValue() { Invoke(nameof(ClearMaxValue)); }
        public void ClearMaxSliderValue() { Invoke(nameof(ClearMaxSliderValue)); }
    }
    public class KOTHPortalWarsAIController : PortalWarsAIController
    {
        public KOTHPortalWarsAIController(ulong addr) : base(addr) { }
    }
    public class MainMenuGameMode : GameModeBase
    {
        public MainMenuGameMode(ulong addr) : base(addr) { }
        public void OnPartyUpdate() { Invoke(nameof(OnPartyUpdate)); }
    }
    public class MainMenuGameState : GameStateBase
    {
        public MainMenuGameState(ulong addr) : base(addr) { }
        public PortalWarsCharacter MyCharacter { get { return this[nameof(MyCharacter)].As<PortalWarsCharacter>(); } set { this["MyCharacter"] = value; } }
        public StaticMeshActor MainPlatform { get { return this[nameof(MainPlatform)].As<StaticMeshActor>(); } set { this["MainPlatform"] = value; } }
        public Portal MyPortal { get { return this[nameof(MyPortal)].As<Portal>(); } set { this["MyPortal"] = value; } }
        public Array<PortalWarsCharacter> PartyCharacters { get { return new Array<PortalWarsCharacter>(this[nameof(PartyCharacters)].Address); } }
        public PreviewItem LootboxItem { get { return this[nameof(LootboxItem)].As<PreviewItem>(); } set { this["LootboxItem"] = value; } }
        public CameraActor LootboxCam { get { return this[nameof(LootboxCam)].As<CameraActor>(); } set { this["LootboxCam"] = value; } }
        public PortalWarsCharacter LootboxCharacter { get { return this[nameof(LootboxCharacter)].As<PortalWarsCharacter>(); } set { this["LootboxCharacter"] = value; } }
        public Array<Portal> LootboxPortals { get { return new Array<Portal>(this[nameof(LootboxPortals)].Address); } }
        public StaticMeshActor LootboxGlow { get { return this[nameof(LootboxGlow)].As<StaticMeshActor>(); } set { this["LootboxGlow"] = value; } }
        public PreviewItem InspectItem { get { return this[nameof(InspectItem)].As<PreviewItem>(); } set { this["InspectItem"] = value; } }
        public CameraActor MainCam { get { return this[nameof(MainCam)].As<CameraActor>(); } set { this["MainCam"] = value; } }
        public CameraActor InspectCam { get { return this[nameof(InspectCam)].As<CameraActor>(); } set { this["InspectCam"] = value; } }
        public LevelSequenceActor LootboxSequence { get { return this[nameof(LootboxSequence)].As<LevelSequenceActor>(); } set { this["LootboxSequence"] = value; } }
    }
    public class PortalWarsBasePlayerController : PlayerController
    {
        public PortalWarsBasePlayerController(ulong addr) : base(addr) { }
        public void ServerKickForInactivity() { Invoke(nameof(ServerKickForInactivity)); }
        public void KickForInactivity() { Invoke(nameof(KickForInactivity)); }
    }
    public class MainMenuPlayerController : PortalWarsBasePlayerController
    {
        public MainMenuPlayerController(ulong addr) : base(addr) { }
        public PortalWarsLoginMenuWidget LoginMenuWidget { get { return this[nameof(LoginMenuWidget)].As<PortalWarsLoginMenuWidget>(); } set { this["LoginMenuWidget"] = value; } }
        public Object LoginMenuWidgetClass { get { return this[nameof(LoginMenuWidgetClass)]; } set { this[nameof(LoginMenuWidgetClass)] = value; } }
        public PortalWarsMainMenuWidget MainMenuWidget { get { return this[nameof(MainMenuWidget)].As<PortalWarsMainMenuWidget>(); } set { this["MainMenuWidget"] = value; } }
        public Object MainMenuWidgetClass { get { return this[nameof(MainMenuWidgetClass)]; } set { this[nameof(MainMenuWidgetClass)] = value; } }
        public AkAudioEvent MainMenuMusicEvent { get { return this[nameof(MainMenuMusicEvent)].As<AkAudioEvent>(); } set { this["MainMenuMusicEvent"] = value; } }
        public AkAudioEvent MainMenuMusicStopEvent { get { return this[nameof(MainMenuMusicStopEvent)].As<AkAudioEvent>(); } set { this["MainMenuMusicStopEvent"] = value; } }
        public MainMenuGameState GameStateRef { get { return this[nameof(GameStateRef)].As<MainMenuGameState>(); } set { this["GameStateRef"] = value; } }
        public PortalWarsGameInstance GameInstanceRef { get { return this[nameof(GameInstanceRef)].As<PortalWarsGameInstance>(); } set { this["GameInstanceRef"] = value; } }
        public PortalWarsLocalPlayer LocalPlayerRef { get { return this[nameof(LocalPlayerRef)].As<PortalWarsLocalPlayer>(); } set { this["LocalPlayerRef"] = value; } }
        public PortalWarsIntroVideoWidget IntroVideoWidget { get { return this[nameof(IntroVideoWidget)].As<PortalWarsIntroVideoWidget>(); } set { this["IntroVideoWidget"] = value; } }
        public Object IntroVideoWidgetClass { get { return this[nameof(IntroVideoWidgetClass)]; } set { this[nameof(IntroVideoWidgetClass)] = value; } }
        public PortalWarsAutoSettingsWidget AutoSettingsWidget { get { return this[nameof(AutoSettingsWidget)].As<PortalWarsAutoSettingsWidget>(); } set { this["AutoSettingsWidget"] = value; } }
        public Object AutoSettingsWidgetClass { get { return this[nameof(AutoSettingsWidgetClass)]; } set { this[nameof(AutoSettingsWidgetClass)] = value; } }
        public void InitMainMenu() { Invoke(nameof(InitMainMenu)); }
        public void InitEquippedSkins() { Invoke(nameof(InitEquippedSkins)); }
        public void ClientReturnedToMenus() { Invoke(nameof(ClientReturnedToMenus)); }
    }
    public class MultiKillGun : LineTraceGun
    {
        public MultiKillGun(ulong addr) : base(addr) { }
        public void ServerNotifyHits(Array<LineTraceHitResult> lineHits, float ReticleSpread, Array<LineTraceInfo> bulletTraces) { Invoke(nameof(ServerNotifyHits), lineHits, ReticleSpread, bulletTraces); }
    }
    public class NavArea_Jump : NavArea
    {
        public NavArea_Jump(ulong addr) : base(addr) { }
    }
    public class NeutralCTFPortalWarsAIController : PortalWarsAIController
    {
        public NeutralCTFPortalWarsAIController(ulong addr) : base(addr) { }
    }
    public class NeutralFlagCaptureZone : FlagCaptureZone
    {
        public NeutralFlagCaptureZone(ulong addr) : base(addr) { }
    }
    public class NeutralFlagItem : FlagItem
    {
        public NeutralFlagItem(ulong addr) : base(addr) { }
        public PortalWarsNeutralCTFGameState NeutralCTFGameState { get { return this[nameof(NeutralCTFGameState)].As<PortalWarsNeutralCTFGameState>(); } set { this["NeutralCTFGameState"] = value; } }
    }
    public class NeutralFlagItemPickup : FlagItemPickup
    {
        public NeutralFlagItemPickup(ulong addr) : base(addr) { }
        public MaterialInstance NeutralFlagMaterial { get { return this[nameof(NeutralFlagMaterial)].As<MaterialInstance>(); } set { this["NeutralFlagMaterial"] = value; } }
        public PortalWarsNeutralCTFGameState NeutralCTFGameState { get { return this[nameof(NeutralCTFGameState)].As<PortalWarsNeutralCTFGameState>(); } set { this["NeutralCTFGameState"] = value; } }
    }
    public class OddballItem : SpecialItem
    {
        public OddballItem(ulong addr) : base(addr) { }
        public PortalWarsOddballGameState OddballGameState { get { return this[nameof(OddballGameState)].As<PortalWarsOddballGameState>(); } set { this["OddballGameState"] = value; } }
    }
    public class OddballItemPickup : PortalWarsGunPickup
    {
        public OddballItemPickup(ulong addr) : base(addr) { }
        public float SphereRadius { get { return this[nameof(SphereRadius)].GetValue<float>(); } set { this[nameof(SphereRadius)].SetValue<float>(value); } }
        public PortalWarsOddballGameState OddballGameState { get { return this[nameof(OddballGameState)].As<PortalWarsOddballGameState>(); } set { this["OddballGameState"] = value; } }
    }
    public class OddballPortalWarsAIController : PortalWarsAIController
    {
        public OddballPortalWarsAIController(ulong addr) : base(addr) { }
    }
    public class OddballSpawnPoint : Actor
    {
        public OddballSpawnPoint(ulong addr) : base(addr) { }
        public StaticMeshComponent Mesh { get { return this[nameof(Mesh)].As<StaticMeshComponent>(); } set { this["Mesh"] = value; } }
        public SceneComponent BallSpawnPoint { get { return this[nameof(BallSpawnPoint)].As<SceneComponent>(); } set { this["BallSpawnPoint"] = value; } }
        public Object OddballPickupClass { get { return this[nameof(OddballPickupClass)]; } set { this[nameof(OddballPickupClass)] = value; } }
        public PortalWarsOddballGameState OddballGameState { get { return this[nameof(OddballGameState)].As<PortalWarsOddballGameState>(); } set { this["OddballGameState"] = value; } }
    }
    public class OutOfBoundsVolume : Volume
    {
        public OutOfBoundsVolume(ulong addr) : base(addr) { }
    }
    public class Pistol : LineTraceGun
    {
        public Pistol(ulong addr) : base(addr) { }
    }
    public class PlasmaProjectile : ImpactProjectile
    {
        public PlasmaProjectile(ulong addr) : base(addr) { }
    }
    public class PlasmaRifle : ProjectileGun
    {
        public PlasmaRifle(ulong addr) : base(addr) { }
        public float currentHeatLevel { get { return this[nameof(currentHeatLevel)].GetValue<float>(); } set { this[nameof(currentHeatLevel)].SetValue<float>(value); } }
        public float heatIncreasePerShot { get { return this[nameof(heatIncreasePerShot)].GetValue<float>(); } set { this[nameof(heatIncreasePerShot)].SetValue<float>(value); } }
        public float coolDownRate { get { return this[nameof(coolDownRate)].GetValue<float>(); } set { this[nameof(coolDownRate)].SetValue<float>(value); } }
        public float totalHeatCapacity { get { return this[nameof(totalHeatCapacity)].GetValue<float>(); } set { this[nameof(totalHeatCapacity)].SetValue<float>(value); } }
        public AkAudioEvent OverHeatChargeEvent { get { return this[nameof(OverHeatChargeEvent)].As<AkAudioEvent>(); } set { this["OverHeatChargeEvent"] = value; } }
        public AkAudioEvent OverHeatChargeStopEvent { get { return this[nameof(OverHeatChargeStopEvent)].As<AkAudioEvent>(); } set { this["OverHeatChargeStopEvent"] = value; } }
        public void OnRep_CurrentHeatLevel() { Invoke(nameof(OnRep_CurrentHeatLevel)); }
    }
    public class Portal : CullableActor
    {
        public Portal(ulong addr) : base(addr) { }
        public Vector PortalGrow_Scale_Start { get { return this[nameof(PortalGrow_Scale_Start)].As<Vector>(); } set { this["PortalGrow_Scale_Start"] = value; } }
        public float portalGrow_TotalSeconds { get { return this[nameof(portalGrow_TotalSeconds)].GetValue<float>(); } set { this[nameof(portalGrow_TotalSeconds)].SetValue<float>(value); } }
        public byte DoRep_portalGrow_StartAnim { get { return this[nameof(DoRep_portalGrow_StartAnim)].GetValue<byte>(); } set { this[nameof(DoRep_portalGrow_StartAnim)].SetValue<byte>(value); } }
        public byte DoRep_portalShrink_StartAnim { get { return this[nameof(DoRep_portalShrink_StartAnim)].GetValue<byte>(); } set { this[nameof(DoRep_portalShrink_StartAnim)].SetValue<byte>(value); } }
        public bool isLeftPortal { get { return this[nameof(isLeftPortal)].Flag; } set { this[nameof(isLeftPortal)].Flag = value; } }
        public PortalWarsAkComponent AkPortal { get { return this[nameof(AkPortal)].As<PortalWarsAkComponent>(); } set { this["AkPortal"] = value; } }
        public AkAudioEvent PortalAmb_PlayEvent { get { return this[nameof(PortalAmb_PlayEvent)].As<AkAudioEvent>(); } set { this["PortalAmb_PlayEvent"] = value; } }
        public AkAudioEvent PortalAmb_StopEvent { get { return this[nameof(PortalAmb_StopEvent)].As<AkAudioEvent>(); } set { this["PortalAmb_StopEvent"] = value; } }
        public AkAudioEvent PortalOpen_Event { get { return this[nameof(PortalOpen_Event)].As<AkAudioEvent>(); } set { this["PortalOpen_Event"] = value; } }
        public AkAudioEvent PortalClose_Event { get { return this[nameof(PortalClose_Event)].As<AkAudioEvent>(); } set { this["PortalClose_Event"] = value; } }
        public byte DoRep_initPortalColor { get { return this[nameof(DoRep_initPortalColor)].GetValue<byte>(); } set { this[nameof(DoRep_initPortalColor)].SetValue<byte>(value); } }
        public PortalWarsCharacter MyPawn { get { return this[nameof(MyPawn)].As<PortalWarsCharacter>(); } set { this["MyPawn"] = value; } }
        public PortalWarsPlayerState MyPlayerState { get { return this[nameof(MyPlayerState)].As<PortalWarsPlayerState>(); } set { this["MyPlayerState"] = value; } }
        public Portal linkedPortal { get { return this[nameof(linkedPortal)].As<Portal>(); } set { this["linkedPortal"] = value; } }
        public LinearColor UnlinkedPortalColor { get { return this[nameof(UnlinkedPortalColor)].As<LinearColor>(); } set { this["UnlinkedPortalColor"] = value; } }
        public LinearColor LeftPortalColor { get { return this[nameof(LeftPortalColor)].As<LinearColor>(); } set { this["LeftPortalColor"] = value; } }
        public LinearColor RightPortalColor { get { return this[nameof(RightPortalColor)].As<LinearColor>(); } set { this["RightPortalColor"] = value; } }
        public StaticMeshComponent PortalMesh { get { return this[nameof(PortalMesh)].As<StaticMeshComponent>(); } set { this["PortalMesh"] = value; } }
        public StaticMeshComponent portalCollisionFrameMesh { get { return this[nameof(portalCollisionFrameMesh)].As<StaticMeshComponent>(); } set { this["portalCollisionFrameMesh"] = value; } }
        public StaticMeshComponent portalRingMesh { get { return this[nameof(portalRingMesh)].As<StaticMeshComponent>(); } set { this["portalRingMesh"] = value; } }
        public StaticMeshComponent PortalThruPortalMesh { get { return this[nameof(PortalThruPortalMesh)].As<StaticMeshComponent>(); } set { this["PortalThruPortalMesh"] = value; } }
        public PortalWall PortalWall { get { return this[nameof(PortalWall)].As<PortalWall>(); } set { this["PortalWall"] = value; } }
        public StaticMeshComponent smallPortalOverlapBox { get { return this[nameof(smallPortalOverlapBox)].As<StaticMeshComponent>(); } set { this["smallPortalOverlapBox"] = value; } }
        public StaticMeshComponent largePortalOverlapBox { get { return this[nameof(largePortalOverlapBox)].As<StaticMeshComponent>(); } set { this["largePortalOverlapBox"] = value; } }
        public MaterialInstanceDynamic portalDynamicMaterial { get { return this[nameof(portalDynamicMaterial)].As<MaterialInstanceDynamic>(); } set { this["portalDynamicMaterial"] = value; } }
        public MaterialInstance DefaultPortalMaterial { get { return this[nameof(DefaultPortalMaterial)].As<MaterialInstance>(); } set { this["DefaultPortalMaterial"] = value; } }
        public MaterialInstance DefaultPortalRingMaterial { get { return this[nameof(DefaultPortalRingMaterial)].As<MaterialInstance>(); } set { this["DefaultPortalRingMaterial"] = value; } }
        public Material renderedPortalMaterial { get { return this[nameof(renderedPortalMaterial)].As<Material>(); } set { this["renderedPortalMaterial"] = value; } }
        public float MaxDepth { get { return this[nameof(MaxDepth)].GetValue<float>(); } set { this[nameof(MaxDepth)].SetValue<float>(value); } }
        public LinearColor EnemyPortalColor { get { return this[nameof(EnemyPortalColor)].As<LinearColor>(); } set { this["EnemyPortalColor"] = value; } }
        public LinearColor AlphaTeamPortalColor { get { return this[nameof(AlphaTeamPortalColor)].As<LinearColor>(); } set { this["AlphaTeamPortalColor"] = value; } }
        public LinearColor BravoTeamPortalColor { get { return this[nameof(BravoTeamPortalColor)].As<LinearColor>(); } set { this["BravoTeamPortalColor"] = value; } }
        public PortalWarsIndicatorWidget PortalIndicatorWidget { get { return this[nameof(PortalIndicatorWidget)].As<PortalWarsIndicatorWidget>(); } set { this["PortalIndicatorWidget"] = value; } }
        public void UpdateSkins() { Invoke(nameof(UpdateSkins)); }
        public void portalShrink_StartAnim() { Invoke(nameof(portalShrink_StartAnim)); }
        public void portalGrow_StartAnim() { Invoke(nameof(portalGrow_StartAnim)); }
        public void OnRep_MyPawn() { Invoke(nameof(OnRep_MyPawn)); }
        public void initializePortalColor() { Invoke(nameof(initializePortalColor)); }
        public void initializePortal() { Invoke(nameof(initializePortal)); }
        public void EndOverlapSmallBox(PrimitiveComponent OverlappedComponent, Actor OtherActor, PrimitiveComponent OtherComp, int OtherBodyIndex) { Invoke(nameof(EndOverlapSmallBox), OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex); }
        public void EndOverlapLargeBox(PrimitiveComponent OverlappedComponent, Actor OtherActor, PrimitiveComponent OtherComp, int OtherBodyIndex) { Invoke(nameof(EndOverlapLargeBox), OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex); }
        public void BeginOverlapSmallBox(PrimitiveComponent OverlappedComponent, Actor OtherActor, PrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, HitResult SweepResult) { Invoke(nameof(BeginOverlapSmallBox), OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult); }
        public void BeginOverlapLargeBox(PrimitiveComponent OverlappedComponent, Actor OtherActor, PrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, HitResult SweepResult) { Invoke(nameof(BeginOverlapLargeBox), OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult); }
    }
    public class PortalLauncher : BaseGun
    {
        public PortalLauncher(ulong addr) : base(addr) { }
        public Object portalBPClass { get { return this[nameof(portalBPClass)]; } set { this[nameof(portalBPClass)] = value; } }
        public Portal leftPortal { get { return this[nameof(leftPortal)].As<Portal>(); } set { this["leftPortal"] = value; } }
        public Portal rightPortal { get { return this[nameof(rightPortal)].As<Portal>(); } set { this["rightPortal"] = value; } }
        public float portalLauncherRange { get { return this[nameof(portalLauncherRange)].GetValue<float>(); } set { this[nameof(portalLauncherRange)].SetValue<float>(value); } }
        public float timeBetweenPortalShots { get { return this[nameof(timeBetweenPortalShots)].GetValue<float>(); } set { this[nameof(timeBetweenPortalShots)].SetValue<float>(value); } }
        public float timeToDestroyPortalAfterDeath { get { return this[nameof(timeToDestroyPortalAfterDeath)].GetValue<float>(); } set { this[nameof(timeToDestroyPortalAfterDeath)].SetValue<float>(value); } }
        public Vector trailFXOffset { get { return this[nameof(trailFXOffset)].As<Vector>(); } set { this["trailFXOffset"] = value; } }
        public PortalWarsAkComponent AkPortalGun { get { return this[nameof(AkPortalGun)].As<PortalWarsAkComponent>(); } set { this["AkPortalGun"] = value; } }
        public AkAudioEvent FirePortalEvent { get { return this[nameof(FirePortalEvent)].As<AkAudioEvent>(); } set { this["FirePortalEvent"] = value; } }
        public AkAudioEvent ClosePortalEvent { get { return this[nameof(ClosePortalEvent)].As<AkAudioEvent>(); } set { this["ClosePortalEvent"] = value; } }
        public AkAudioEvent SuccessfulPortalEvent { get { return this[nameof(SuccessfulPortalEvent)].As<AkAudioEvent>(); } set { this["SuccessfulPortalEvent"] = value; } }
        public AkAudioEvent FailPortalEvent { get { return this[nameof(FailPortalEvent)].As<AkAudioEvent>(); } set { this["FailPortalEvent"] = value; } }
        public ParticleSystem TrailFX { get { return this[nameof(TrailFX)].As<ParticleSystem>(); } set { this["TrailFX"] = value; } }
        public Object TrailTargetParam { get { return this[nameof(TrailTargetParam)]; } set { this[nameof(TrailTargetParam)] = value; } }
        public Object TrailColorParam { get { return this[nameof(TrailColorParam)]; } set { this[nameof(TrailColorParam)] = value; } }
        public LinearColor LeftPortalEffectColor { get { return this[nameof(LeftPortalEffectColor)].As<LinearColor>(); } set { this["LeftPortalEffectColor"] = value; } }
        public LinearColor RightPortalEffectColor { get { return this[nameof(RightPortalEffectColor)].As<LinearColor>(); } set { this["RightPortalEffectColor"] = value; } }
        public LinearColor FriendlyPortalEffectColor { get { return this[nameof(FriendlyPortalEffectColor)].As<LinearColor>(); } set { this["FriendlyPortalEffectColor"] = value; } }
        public LinearColor EnemyPortalEffectColor { get { return this[nameof(EnemyPortalEffectColor)].As<LinearColor>(); } set { this["EnemyPortalEffectColor"] = value; } }
        public void spawnPortalFX_Multicast(Vector_NetQuantize EndPoint, bool bIsLeftPortal) { Invoke(nameof(spawnPortalFX_Multicast), EndPoint, bIsLeftPortal); }
        public void ServerClosePortal(bool bIsLeftPortal) { Invoke(nameof(ServerClosePortal), bIsLeftPortal); }
        public void ServerAttemptToSpawnPortal(bool bIsLeftPortal, Vector_NetQuantize StartTrace, Vector ShootDir) { Invoke(nameof(ServerAttemptToSpawnPortal), bIsLeftPortal, StartTrace, ShootDir); }
        public void DelaySpawnPortalFX(Vector_NetQuantize EndPoint, bool bIsLeftPortal) { Invoke(nameof(DelaySpawnPortalFX), EndPoint, bIsLeftPortal); }
    }
    public class PortalSceneCapture2D : SceneCapture2D
    {
        public PortalSceneCapture2D(ulong addr) : base(addr) { }
        public Portal Portal { get { return this[nameof(Portal)].As<Portal>(); } set { this["Portal"] = value; } }
    }
    public class PortalWall : Actor
    {
        public PortalWall(ulong addr) : base(addr) { }
        public StaticMeshComponent PortalWallMesh { get { return this[nameof(PortalWallMesh)].As<StaticMeshComponent>(); } set { this["PortalWallMesh"] = value; } }
        public bool validForAI { get { return this[nameof(validForAI)].Flag; } set { this[nameof(validForAI)].Flag = value; } }
        public bool isDoubleSided { get { return this[nameof(isDoubleSided)].Flag; } set { this[nameof(isDoubleSided)].Flag = value; } }
        public bool shouldDisableForCTF { get { return this[nameof(shouldDisableForCTF)].Flag; } set { this[nameof(shouldDisableForCTF)].Flag = value; } }
        public PortalWarsTutorialGoal Goal { get { return this[nameof(Goal)].As<PortalWarsTutorialGoal>(); } set { this["Goal"] = value; } }
        public Array<StaticMeshActor> Blocks { get { return new Array<StaticMeshActor>(this[nameof(Blocks)].Address); } }
        public int HiddenUntilGoal { get { return this[nameof(HiddenUntilGoal)].GetValue<int>(); } set { this[nameof(HiddenUntilGoal)].SetValue<int>(value); } }
        public void disablePortalWall() { Invoke(nameof(disablePortalWall)); }
    }
    public class PortalWall_Circular : PortalWall
    {
        public PortalWall_Circular(ulong addr) : base(addr) { }
    }
    public class PortalWall_Cube : PortalWall
    {
        public PortalWall_Cube(ulong addr) : base(addr) { }
    }
    public class PortalWarsActorChannel : ActorChannel
    {
        public PortalWarsActorChannel(ulong addr) : base(addr) { }
    }
    public class PortalWarsUserWidget : UserWidget
    {
        public PortalWarsUserWidget(ulong addr) : base(addr) { }
        public EWidgetPlatformVisibility PlatformVisibility { get { return (EWidgetPlatformVisibility)this[nameof(PlatformVisibility)].GetValue<int>(); } set { this[nameof(PlatformVisibility)].SetValue<int>((int)value); } }
        public bool bIsDuplicate { get { return this[nameof(bIsDuplicate)].Flag; } set { this[nameof(bIsDuplicate)].Flag = value; } }
        public bool bIsDeferred { get { return this[nameof(bIsDeferred)].Flag; } set { this[nameof(bIsDeferred)].Flag = value; } }
        public Object DeferredWidgetBPClass { get { return this[nameof(DeferredWidgetBPClass)]; } set { this[nameof(DeferredWidgetBPClass)] = value; } }
        public void UpdateControllerVisibility() { Invoke(nameof(UpdateControllerVisibility)); }
        public void OnControllerStatusChanged_BP(bool bIsUsingController) { Invoke(nameof(OnControllerStatusChanged_BP), bIsUsingController); }
        public void OnControllerStatusChanged() { Invoke(nameof(OnControllerStatusChanged)); }
        public void OnChildWidgetFocusReceived(Widget Widget) { Invoke(nameof(OnChildWidgetFocusReceived), Widget); }
        public void OnChildWidgetFocusLost(Widget Widget) { Invoke(nameof(OnChildWidgetFocusLost), Widget); }
        public void OnChildButtonFocusReceived(Widget Widget) { Invoke(nameof(OnChildButtonFocusReceived), Widget); }
        public void OnChildButtonFocusLost(Widget Widget) { Invoke(nameof(OnChildButtonFocusLost), Widget); }
        public bool IsLocalPlayerUsingController() { return Invoke<bool>(nameof(IsLocalPlayerUsingController)); }
        public Widget GetWidgetToFocus() { return Invoke<Widget>(nameof(GetWidgetToFocus)); }
        public ESlateVisibility GetControllerVisibility() { return Invoke<ESlateVisibility>(nameof(GetControllerVisibility)); }
    }
    public class PortalWarsMenuWidget : PortalWarsUserWidget
    {
        public PortalWarsMenuWidget(ulong addr) : base(addr) { }
        public PortalWarsNavBarWidget NavBar { get { return this[nameof(NavBar)].As<PortalWarsNavBarWidget>(); } set { this["NavBar"] = value; } }
        public WidgetSwitcher WidgetSwitcher { get { return this[nameof(WidgetSwitcher)].As<WidgetSwitcher>(); } set { this["WidgetSwitcher"] = value; } }
        public Object OnBackButtonClicked { get { return this[nameof(OnBackButtonClicked)]; } set { this[nameof(OnBackButtonClicked)] = value; } }
        public PortalWarsButtonWidget BackButton { get { return this[nameof(BackButton)].As<PortalWarsButtonWidget>(); } set { this["BackButton"] = value; } }
        public Widget ButtonPanel { get { return this[nameof(ButtonPanel)].As<Widget>(); } set { this["ButtonPanel"] = value; } }
        public UserWidget ParentWidget { get { return this[nameof(ParentWidget)].As<UserWidget>(); } set { this["ParentWidget"] = value; } }
        public WidgetAnimation FadeInAnimation { get { return this[nameof(FadeInAnimation)].As<WidgetAnimation>(); } set { this["FadeInAnimation"] = value; } }
        public bool bTrackMenuEvents { get { return this[nameof(bTrackMenuEvents)].Flag; } set { this[nameof(bTrackMenuEvents)].Flag = value; } }
        public Object MenuInternalName { get { return this[nameof(MenuInternalName)]; } set { this[nameof(MenuInternalName)] = value; } }
        public AkAudioEvent MenuOpenedEvent { get { return this[nameof(MenuOpenedEvent)].As<AkAudioEvent>(); } set { this["MenuOpenedEvent"] = value; } }
        public AkAudioEvent MenuClosedEvent { get { return this[nameof(MenuClosedEvent)].As<AkAudioEvent>(); } set { this["MenuClosedEvent"] = value; } }
        public void OnMenuOpenedBP() { Invoke(nameof(OnMenuOpenedBP)); }
        public void OnMenuOpened() { Invoke(nameof(OnMenuOpened)); }
        public void OnMenuClosedBP() { Invoke(nameof(OnMenuClosedBP)); }
        public void OnMenuClosed() { Invoke(nameof(OnMenuClosed)); }
        public void OnChildMenuWidgetCreated(UserWidget Widget) { Invoke(nameof(OnChildMenuWidgetCreated), Widget); }
        public void OnChildMenuBackButtonClicked() { Invoke(nameof(OnChildMenuBackButtonClicked)); }
        public void OnBackButtonClickedInternal() { Invoke(nameof(OnBackButtonClickedInternal)); }
        public void GoToState(byte NewState) { Invoke(nameof(GoToState), NewState); }
        public void ForceAnimationToEnd(WidgetAnimation Animation) { Invoke(nameof(ForceAnimationToEnd), Animation); }
    }
    public class PortalWarsAddFriendsWidget : PortalWarsMenuWidget
    {
        public PortalWarsAddFriendsWidget(ulong addr) : base(addr) { }
        public PanelWidget IncomingFriendRequestPanel { get { return this[nameof(IncomingFriendRequestPanel)].As<PanelWidget>(); } set { this["IncomingFriendRequestPanel"] = value; } }
        public PanelWidget OutgoingFriendRequestPanel { get { return this[nameof(OutgoingFriendRequestPanel)].As<PanelWidget>(); } set { this["OutgoingFriendRequestPanel"] = value; } }
        public ScrollBox ItemsScrollBox { get { return this[nameof(ItemsScrollBox)].As<ScrollBox>(); } set { this["ItemsScrollBox"] = value; } }
        public Object FriendRequestEntryWidgetClass { get { return this[nameof(FriendRequestEntryWidgetClass)]; } set { this[nameof(FriendRequestEntryWidgetClass)] = value; } }
        public Object FriendRequestDialogWidgetClass { get { return this[nameof(FriendRequestDialogWidgetClass)]; } set { this[nameof(FriendRequestDialogWidgetClass)] = value; } }
        public PortalWarsTextInputWidget FriendCodeTextInput { get { return this[nameof(FriendCodeTextInput)].As<PortalWarsTextInputWidget>(); } set { this["FriendCodeTextInput"] = value; } }
        public TextBlock FriendCodeText { get { return this[nameof(FriendCodeText)].As<TextBlock>(); } set { this["FriendCodeText"] = value; } }
        public PortalWarsButtonWidget SendRequestButton { get { return this[nameof(SendRequestButton)].As<PortalWarsButtonWidget>(); } set { this["SendRequestButton"] = value; } }
        public PortalWarsButtonWidget CopyButton { get { return this[nameof(CopyButton)].As<PortalWarsButtonWidget>(); } set { this["CopyButton"] = value; } }
        public TextBlock ErrorText { get { return this[nameof(ErrorText)].As<TextBlock>(); } set { this["ErrorText"] = value; } }
        public void UpdateFriendCodeText() { Invoke(nameof(UpdateFriendCodeText)); }
        public void RefreshWidget() { Invoke(nameof(RefreshWidget)); }
        public void RefreshSendRequestButton() { Invoke(nameof(RefreshSendRequestButton)); }
        public void RefreshFriendRequests() { Invoke(nameof(RefreshFriendRequests)); }
        public void OnSendRequestButtonClicked() { Invoke(nameof(OnSendRequestButtonClicked)); }
        public void OnRequestEntryDeclined(PortalWarsEntryWidget Widget) { Invoke(nameof(OnRequestEntryDeclined), Widget); }
        public void OnRequestEntryAccepted(PortalWarsEntryWidget Widget) { Invoke(nameof(OnRequestEntryAccepted), Widget); }
        public void OnPrivelegesUpdated() { Invoke(nameof(OnPrivelegesUpdated)); }
        public void OnFriendCodeTextInputFocusChanged(Widget Widget) { Invoke(nameof(OnFriendCodeTextInputFocusChanged), Widget); }
        public void OnCopyButtonClicked() { Invoke(nameof(OnCopyButtonClicked)); }
        public bool GetSendRequestButtonEnabled() { return Invoke<bool>(nameof(GetSendRequestButtonEnabled)); }
    }
    public class PortalWarsAkComponent : AkComponent
    {
        public PortalWarsAkComponent(ulong addr) : base(addr) { }
    }
    public class PortalWarsAmmoCounterWidget : UserWidget
    {
        public PortalWarsAmmoCounterWidget(ulong addr) : base(addr) { }
        public TextBlock AmmoText { get { return this[nameof(AmmoText)].As<TextBlock>(); } set { this["AmmoText"] = value; } }
        public ProgressBar ChargeProgressBar { get { return this[nameof(ChargeProgressBar)].As<ProgressBar>(); } set { this["ChargeProgressBar"] = value; } }
    }
    public class PortalWarsAnimInstance : AnimInstance
    {
        public PortalWarsAnimInstance(ulong addr) : base(addr) { }
        public byte AnimationType { get { return this[nameof(AnimationType)].GetValue<byte>(); } set { this[nameof(AnimationType)].SetValue<byte>(value); } }
        public float AimPitch { get { return this[nameof(AimPitch)].GetValue<float>(); } set { this[nameof(AimPitch)].SetValue<float>(value); } }
        public float Yaw { get { return this[nameof(Yaw)].GetValue<float>(); } set { this[nameof(Yaw)].SetValue<float>(value); } }
        public float YawLastTick { get { return this[nameof(YawLastTick)].GetValue<float>(); } set { this[nameof(YawLastTick)].SetValue<float>(value); } }
        public float YawChangeOverFrame { get { return this[nameof(YawChangeOverFrame)].GetValue<float>(); } set { this[nameof(YawChangeOverFrame)].SetValue<float>(value); } }
        public bool bIsMoving { get { return this[nameof(bIsMoving)].Flag; } set { this[nameof(bIsMoving)].Flag = value; } }
        public bool bIsSprinting { get { return this[nameof(bIsSprinting)].Flag; } set { this[nameof(bIsSprinting)].Flag = value; } }
        public bool bIsJumping { get { return this[nameof(bIsJumping)].Flag; } set { this[nameof(bIsJumping)].Flag = value; } }
        public bool bIsFalling { get { return this[nameof(bIsFalling)].Flag; } set { this[nameof(bIsFalling)].Flag = value; } }
        public bool bIsCrouching { get { return this[nameof(bIsCrouching)].Flag; } set { this[nameof(bIsCrouching)].Flag = value; } }
        public bool bIsAccelerating { get { return this[nameof(bIsAccelerating)].Flag; } set { this[nameof(bIsAccelerating)].Flag = value; } }
        public Vector Velocity { get { return this[nameof(Velocity)].As<Vector>(); } set { this["Velocity"] = value; } }
        public float MoveSpeed { get { return this[nameof(MoveSpeed)].GetValue<float>(); } set { this[nameof(MoveSpeed)].SetValue<float>(value); } }
        public float NormalizedMoveSpeed { get { return this[nameof(NormalizedMoveSpeed)].GetValue<float>(); } set { this[nameof(NormalizedMoveSpeed)].SetValue<float>(value); } }
        public float SpeedHorizontal { get { return this[nameof(SpeedHorizontal)].GetValue<float>(); } set { this[nameof(SpeedHorizontal)].SetValue<float>(value); } }
        public float SpeedVertical { get { return this[nameof(SpeedVertical)].GetValue<float>(); } set { this[nameof(SpeedVertical)].SetValue<float>(value); } }
        public float Direction { get { return this[nameof(Direction)].GetValue<float>(); } set { this[nameof(Direction)].SetValue<float>(value); } }
        public float HeadScale { get { return this[nameof(HeadScale)].GetValue<float>(); } set { this[nameof(HeadScale)].SetValue<float>(value); } }
        public float MovementModifier { get { return this[nameof(MovementModifier)].GetValue<float>(); } set { this[nameof(MovementModifier)].SetValue<float>(value); } }
        public bool bIsPlayingEmote { get { return this[nameof(bIsPlayingEmote)].Flag; } set { this[nameof(bIsPlayingEmote)].Flag = value; } }
        public AnimSequence EmoteAnimSequence { get { return this[nameof(EmoteAnimSequence)].As<AnimSequence>(); } set { this["EmoteAnimSequence"] = value; } }
        public BlendSpace1D WalkBlendSpace { get { return this[nameof(WalkBlendSpace)].As<BlendSpace1D>(); } set { this["WalkBlendSpace"] = value; } }
        public AnimSequence SprintAnim { get { return this[nameof(SprintAnim)].As<AnimSequence>(); } set { this["SprintAnim"] = value; } }
        public AnimSequence JumpStartAnim { get { return this[nameof(JumpStartAnim)].As<AnimSequence>(); } set { this["JumpStartAnim"] = value; } }
        public AnimSequence JumpLoopAnim { get { return this[nameof(JumpLoopAnim)].As<AnimSequence>(); } set { this["JumpLoopAnim"] = value; } }
        public AnimSequence JumpEndAnim { get { return this[nameof(JumpEndAnim)].As<AnimSequence>(); } set { this["JumpEndAnim"] = value; } }
        public PortalWarsAkComponent AkFoot { get { return this[nameof(AkFoot)].As<PortalWarsAkComponent>(); } set { this["AkFoot"] = value; } }
        public void PlayWwiseEvent(AkAudioEvent WwiseEvent, PortalWarsAkComponent AkComponent) { Invoke(nameof(PlayWwiseEvent), WwiseEvent, AkComponent); }
        public void FootstepEvent(bool isLanding, AkAudioEvent WwiseEvent) { Invoke(nameof(FootstepEvent), isLanding, WwiseEvent); }
    }
    public class PortalWarsAnimInstanceV2 : AnimInstance
    {
        public PortalWarsAnimInstanceV2(ulong addr) : base(addr) { }
        public float AOOverrideAlpha { get { return this[nameof(AOOverrideAlpha)].GetValue<float>(); } set { this[nameof(AOOverrideAlpha)].SetValue<float>(value); } }
        public float AOAlpha { get { return this[nameof(AOAlpha)].GetValue<float>(); } set { this[nameof(AOAlpha)].SetValue<float>(value); } }
        public float LeanAlpha { get { return this[nameof(LeanAlpha)].GetValue<float>(); } set { this[nameof(LeanAlpha)].SetValue<float>(value); } }
        public float State_IsSprinting { get { return this[nameof(State_IsSprinting)].GetValue<float>(); } set { this[nameof(State_IsSprinting)].SetValue<float>(value); } }
        public float BodyCorrectionAlpha { get { return this[nameof(BodyCorrectionAlpha)].GetValue<float>(); } set { this[nameof(BodyCorrectionAlpha)].SetValue<float>(value); } }
        public float ArmsCorrectionAlpha { get { return this[nameof(ArmsCorrectionAlpha)].GetValue<float>(); } set { this[nameof(ArmsCorrectionAlpha)].SetValue<float>(value); } }
        public float HandsCorrectionAlpha { get { return this[nameof(HandsCorrectionAlpha)].GetValue<float>(); } set { this[nameof(HandsCorrectionAlpha)].SetValue<float>(value); } }
        public float UBA { get { return this[nameof(UBA)].GetValue<float>(); } set { this[nameof(UBA)].SetValue<float>(value); } }
        public float UBA_LowerWeight { get { return this[nameof(UBA_LowerWeight)].GetValue<float>(); } set { this[nameof(UBA_LowerWeight)].SetValue<float>(value); } }
        public float UBA_LowerAdd { get { return this[nameof(UBA_LowerAdd)].GetValue<float>(); } set { this[nameof(UBA_LowerAdd)].SetValue<float>(value); } }
        public float UBA_UpperWeight { get { return this[nameof(UBA_UpperWeight)].GetValue<float>(); } set { this[nameof(UBA_UpperWeight)].SetValue<float>(value); } }
        public float UBA_UpperAdd { get { return this[nameof(UBA_UpperAdd)].GetValue<float>(); } set { this[nameof(UBA_UpperAdd)].SetValue<float>(value); } }
        public float UBA_RArmWeight { get { return this[nameof(UBA_RArmWeight)].GetValue<float>(); } set { this[nameof(UBA_RArmWeight)].SetValue<float>(value); } }
        public float UBA_RArmAdd { get { return this[nameof(UBA_RArmAdd)].GetValue<float>(); } set { this[nameof(UBA_RArmAdd)].SetValue<float>(value); } }
        public float UBA_LArmWeight { get { return this[nameof(UBA_LArmWeight)].GetValue<float>(); } set { this[nameof(UBA_LArmWeight)].SetValue<float>(value); } }
        public float UBA_LArmAdd { get { return this[nameof(UBA_LArmAdd)].GetValue<float>(); } set { this[nameof(UBA_LArmAdd)].SetValue<float>(value); } }
        public float LArmIKAlpha { get { return this[nameof(LArmIKAlpha)].GetValue<float>(); } set { this[nameof(LArmIKAlpha)].SetValue<float>(value); } }
        public float RArmIKAlpha { get { return this[nameof(RArmIKAlpha)].GetValue<float>(); } set { this[nameof(RArmIKAlpha)].SetValue<float>(value); } }
        public float LArm_Override { get { return this[nameof(LArm_Override)].GetValue<float>(); } set { this[nameof(LArm_Override)].SetValue<float>(value); } }
        public float Stride { get { return this[nameof(Stride)].GetValue<float>(); } set { this[nameof(Stride)].SetValue<float>(value); } }
        public float Stride_Upper { get { return this[nameof(Stride_Upper)].GetValue<float>(); } set { this[nameof(Stride_Upper)].SetValue<float>(value); } }
        public float PlayRate { get { return this[nameof(PlayRate)].GetValue<float>(); } set { this[nameof(PlayRate)].SetValue<float>(value); } }
        public Vector2D LeanValue { get { return this[nameof(LeanValue)].As<Vector2D>(); } set { this["LeanValue"] = value; } }
        public Vector2D LeaningValue_Falling { get { return this[nameof(LeaningValue_Falling)].As<Vector2D>(); } set { this["LeaningValue_Falling"] = value; } }
        public float LeanFallingAlpha { get { return this[nameof(LeanFallingAlpha)].GetValue<float>(); } set { this[nameof(LeanFallingAlpha)].SetValue<float>(value); } }
        public float LandVelocity { get { return this[nameof(LandVelocity)].GetValue<float>(); } set { this[nameof(LandVelocity)].SetValue<float>(value); } }
        public float LandPredictionAlpha { get { return this[nameof(LandPredictionAlpha)].GetValue<float>(); } set { this[nameof(LandPredictionAlpha)].SetValue<float>(value); } }
        public bool bLanded { get { return this[nameof(bLanded)].Flag; } set { this[nameof(bLanded)].Flag = value; } }
        public AnimSequenceBase BlendAnim { get { return this[nameof(BlendAnim)].As<AnimSequenceBase>(); } set { this["BlendAnim"] = value; } }
        public PortalWarsCharacter Character { get { return this[nameof(Character)].As<PortalWarsCharacter>(); } set { this["Character"] = value; } }
        public Gun EquippedGun { get { return this[nameof(EquippedGun)].As<Gun>(); } set { this["EquippedGun"] = value; } }
        public bool bHasWeapon { get { return this[nameof(bHasWeapon)].Flag; } set { this[nameof(bHasWeapon)].Flag = value; } }
        public byte AnimationType { get { return this[nameof(AnimationType)].GetValue<byte>(); } set { this[nameof(AnimationType)].SetValue<byte>(value); } }
        public EWeaponType WeaponType { get { return (EWeaponType)this[nameof(WeaponType)].GetValue<int>(); } set { this[nameof(WeaponType)].SetValue<int>((int)value); } }
        public Object WeaponMap { get { return this[nameof(WeaponMap)]; } set { this[nameof(WeaponMap)] = value; } }
        public float Yaw { get { return this[nameof(Yaw)].GetValue<float>(); } set { this[nameof(Yaw)].SetValue<float>(value); } }
        public float YawLastTick { get { return this[nameof(YawLastTick)].GetValue<float>(); } set { this[nameof(YawLastTick)].SetValue<float>(value); } }
        public float YawChangeOverFrame { get { return this[nameof(YawChangeOverFrame)].GetValue<float>(); } set { this[nameof(YawChangeOverFrame)].SetValue<float>(value); } }
        public bool bIsMoving { get { return this[nameof(bIsMoving)].Flag; } set { this[nameof(bIsMoving)].Flag = value; } }
        public bool bIsSprinting { get { return this[nameof(bIsSprinting)].Flag; } set { this[nameof(bIsSprinting)].Flag = value; } }
        public bool bIsJumping { get { return this[nameof(bIsJumping)].Flag; } set { this[nameof(bIsJumping)].Flag = value; } }
        public bool bIsFalling { get { return this[nameof(bIsFalling)].Flag; } set { this[nameof(bIsFalling)].Flag = value; } }
        public bool bIsFallingAndNotJumping { get { return this[nameof(bIsFallingAndNotJumping)].Flag; } set { this[nameof(bIsFallingAndNotJumping)].Flag = value; } }
        public bool bIsCrouching { get { return this[nameof(bIsCrouching)].Flag; } set { this[nameof(bIsCrouching)].Flag = value; } }
        public bool bIsAccelerating { get { return this[nameof(bIsAccelerating)].Flag; } set { this[nameof(bIsAccelerating)].Flag = value; } }
        public bool bIsThrusting { get { return this[nameof(bIsThrusting)].Flag; } set { this[nameof(bIsThrusting)].Flag = value; } }
        public bool bShouldWeaponLean { get { return this[nameof(bShouldWeaponLean)].Flag; } set { this[nameof(bShouldWeaponLean)].Flag = value; } }
        public bool bIsAlive { get { return this[nameof(bIsAlive)].Flag; } set { this[nameof(bIsAlive)].Flag = value; } }
        public bool bLandAnimationAlmostFinished { get { return this[nameof(bLandAnimationAlmostFinished)].Flag; } set { this[nameof(bLandAnimationAlmostFinished)].Flag = value; } }
        public bool bGroundedToFallLoop { get { return this[nameof(bGroundedToFallLoop)].Flag; } set { this[nameof(bGroundedToFallLoop)].Flag = value; } }
        public bool bGroundedToJump { get { return this[nameof(bGroundedToJump)].Flag; } set { this[nameof(bGroundedToJump)].Flag = value; } }
        public bool bIsMovingAndAccelerating { get { return this[nameof(bIsMovingAndAccelerating)].Flag; } set { this[nameof(bIsMovingAndAccelerating)].Flag = value; } }
        public bool bLandToGrounded { get { return this[nameof(bLandToGrounded)].Flag; } set { this[nameof(bLandToGrounded)].Flag = value; } }
        public bool bIdleToTIP { get { return this[nameof(bIdleToTIP)].Flag; } set { this[nameof(bIdleToTIP)].Flag = value; } }
        public bool bTurnRToTIP { get { return this[nameof(bTurnRToTIP)].Flag; } set { this[nameof(bTurnRToTIP)].Flag = value; } }
        public bool bTurnLToTIP { get { return this[nameof(bTurnLToTIP)].Flag; } set { this[nameof(bTurnLToTIP)].Flag = value; } }
        public Vector Velocity { get { return this[nameof(Velocity)].As<Vector>(); } set { this["Velocity"] = value; } }
        public Vector RelativeVelocity { get { return this[nameof(RelativeVelocity)].As<Vector>(); } set { this["RelativeVelocity"] = value; } }
        public float MoveSpeed { get { return this[nameof(MoveSpeed)].GetValue<float>(); } set { this[nameof(MoveSpeed)].SetValue<float>(value); } }
        public float NormalizedMoveSpeed { get { return this[nameof(NormalizedMoveSpeed)].GetValue<float>(); } set { this[nameof(NormalizedMoveSpeed)].SetValue<float>(value); } }
        public float SpeedHorizontal { get { return this[nameof(SpeedHorizontal)].GetValue<float>(); } set { this[nameof(SpeedHorizontal)].SetValue<float>(value); } }
        public float SpeedVertical { get { return this[nameof(SpeedVertical)].GetValue<float>(); } set { this[nameof(SpeedVertical)].SetValue<float>(value); } }
        public float Direction { get { return this[nameof(Direction)].GetValue<float>(); } set { this[nameof(Direction)].SetValue<float>(value); } }
        public float FiringCurveValue { get { return this[nameof(FiringCurveValue)].GetValue<float>(); } set { this[nameof(FiringCurveValue)].SetValue<float>(value); } }
        public float CrouchAmount { get { return this[nameof(CrouchAmount)].GetValue<float>(); } set { this[nameof(CrouchAmount)].SetValue<float>(value); } }
        public float CrouchSpeed { get { return this[nameof(CrouchSpeed)].GetValue<float>(); } set { this[nameof(CrouchSpeed)].SetValue<float>(value); } }
        public float TurnAngle { get { return this[nameof(TurnAngle)].GetValue<float>(); } set { this[nameof(TurnAngle)].SetValue<float>(value); } }
        public bool bTurnRLoop { get { return this[nameof(bTurnRLoop)].Flag; } set { this[nameof(bTurnRLoop)].Flag = value; } }
        public bool bTurnLLoop { get { return this[nameof(bTurnLLoop)].Flag; } set { this[nameof(bTurnLLoop)].Flag = value; } }
        public bool bTIPToTurnL { get { return this[nameof(bTIPToTurnL)].Flag; } set { this[nameof(bTIPToTurnL)].Flag = value; } }
        public bool bTIPToTurnR { get { return this[nameof(bTIPToTurnR)].Flag; } set { this[nameof(bTIPToTurnR)].Flag = value; } }
        public float RootYawOffset { get { return this[nameof(RootYawOffset)].GetValue<float>(); } set { this[nameof(RootYawOffset)].SetValue<float>(value); } }
        public Rotator RootYawOffsetRot { get { return this[nameof(RootYawOffsetRot)].As<Rotator>(); } set { this["RootYawOffsetRot"] = value; } }
        public Rotator RootYawOffsetRootRot { get { return this[nameof(RootYawOffsetRootRot)].As<Rotator>(); } set { this["RootYawOffsetRootRot"] = value; } }
        public CurveFloat RootYawSpeed { get { return this[nameof(RootYawSpeed)].As<CurveFloat>(); } set { this["RootYawSpeed"] = value; } }
        public CurveVector PlayRatesCurve { get { return this[nameof(PlayRatesCurve)].As<CurveVector>(); } set { this["PlayRatesCurve"] = value; } }
        public CurveFloat LeanFallingCurve { get { return this[nameof(LeanFallingCurve)].As<CurveFloat>(); } set { this["LeanFallingCurve"] = value; } }
        public CurveFloat LandPredictionCurve { get { return this[nameof(LandPredictionCurve)].As<CurveFloat>(); } set { this["LandPredictionCurve"] = value; } }
        public float TrueDirection { get { return this[nameof(TrueDirection)].GetValue<float>(); } set { this[nameof(TrueDirection)].SetValue<float>(value); } }
        public float TurnAmount { get { return this[nameof(TurnAmount)].GetValue<float>(); } set { this[nameof(TurnAmount)].SetValue<float>(value); } }
        public float PreviousTurnAmount { get { return this[nameof(PreviousTurnAmount)].GetValue<float>(); } set { this[nameof(PreviousTurnAmount)].SetValue<float>(value); } }
        public bool bCanTurn { get { return this[nameof(bCanTurn)].Flag; } set { this[nameof(bCanTurn)].Flag = value; } }
        public Rotator AimRot2 { get { return this[nameof(AimRot2)].As<Rotator>(); } set { this["AimRot2"] = value; } }
        public Rotator AimRot2Root { get { return this[nameof(AimRot2Root)].As<Rotator>(); } set { this["AimRot2Root"] = value; } }
        public float AimSweepTime { get { return this[nameof(AimSweepTime)].GetValue<float>(); } set { this[nameof(AimSweepTime)].SetValue<float>(value); } }
        public Vector HeadScale { get { return this[nameof(HeadScale)].As<Vector>(); } set { this["HeadScale"] = value; } }
        public float MovementModifier { get { return this[nameof(MovementModifier)].GetValue<float>(); } set { this[nameof(MovementModifier)].SetValue<float>(value); } }
        public bool bIsPlayingEmote { get { return this[nameof(bIsPlayingEmote)].Flag; } set { this[nameof(bIsPlayingEmote)].Flag = value; } }
        public AnimSequence EmoteAnimSequence { get { return this[nameof(EmoteAnimSequence)].As<AnimSequence>(); } set { this["EmoteAnimSequence"] = value; } }
        public BlendSpace1D WalkBlendSpace { get { return this[nameof(WalkBlendSpace)].As<BlendSpace1D>(); } set { this["WalkBlendSpace"] = value; } }
        public BlendSpace1D LeanBlendSpace { get { return this[nameof(LeanBlendSpace)].As<BlendSpace1D>(); } set { this["LeanBlendSpace"] = value; } }
        public AnimSequence SprintAnim { get { return this[nameof(SprintAnim)].As<AnimSequence>(); } set { this["SprintAnim"] = value; } }
        public AnimSequence JumpStartAnim { get { return this[nameof(JumpStartAnim)].As<AnimSequence>(); } set { this["JumpStartAnim"] = value; } }
        public AnimSequence JumpLoopAnim { get { return this[nameof(JumpLoopAnim)].As<AnimSequence>(); } set { this["JumpLoopAnim"] = value; } }
        public AnimSequence JumpEndAnim { get { return this[nameof(JumpEndAnim)].As<AnimSequence>(); } set { this["JumpEndAnim"] = value; } }
        public float BatOpenPercent { get { return this[nameof(BatOpenPercent)].GetValue<float>(); } set { this[nameof(BatOpenPercent)].SetValue<float>(value); } }
        public PortalWarsAkComponent AkFoot { get { return this[nameof(AkFoot)].As<PortalWarsAkComponent>(); } set { this["AkFoot"] = value; } }
        public void PlayWwiseEvent(AkAudioEvent WwiseEvent, PortalWarsAkComponent AkComponent) { Invoke(nameof(PlayWwiseEvent), WwiseEvent, AkComponent); }
        public void FootstepEvent(bool bIsLanding) { Invoke(nameof(FootstepEvent), bIsLanding); }
        public void AnimNotify_Unland() { Invoke(nameof(AnimNotify_Unland)); }
        public void AnimNotify_Land() { Invoke(nameof(AnimNotify_Land)); }
        public void AnimNotify_CanTurn() { Invoke(nameof(AnimNotify_CanTurn)); }
        public void AnimNotify_CantTurn() { Invoke(nameof(AnimNotify_CantTurn)); }
    }
    public class PortalWarsAssetManager : AssetManager
    {
        public PortalWarsAssetManager(ulong addr) : base(addr) { }
    }
    public class PortalWarsAudioSettings : Object
    {
        public PortalWarsAudioSettings(ulong addr) : base(addr) { }
    }
    public class PortalWarsSettingsSubWidget : PortalWarsMenuWidget
    {
        public PortalWarsSettingsSubWidget(ulong addr) : base(addr) { }
        public PortalWarsButtonWidget ApplyButton { get { return this[nameof(ApplyButton)].As<PortalWarsButtonWidget>(); } set { this["ApplyButton"] = value; } }
        public PortalWarsButtonWidget RestoreButton { get { return this[nameof(RestoreButton)].As<PortalWarsButtonWidget>(); } set { this["RestoreButton"] = value; } }
        public Object DiscardDialogClass { get { return this[nameof(DiscardDialogClass)]; } set { this[nameof(DiscardDialogClass)] = value; } }
        public void ResetToDefaults() { Invoke(nameof(ResetToDefaults)); }
        public void OnValueChanged() { Invoke(nameof(OnValueChanged)); }
        public void OnDiscardAccepted() { Invoke(nameof(OnDiscardAccepted)); }
        public void ApplySettings() { Invoke(nameof(ApplySettings)); }
    }
    public class PortalWarsAudioSettingsWidget : PortalWarsSettingsSubWidget
    {
        public PortalWarsAudioSettingsWidget(ulong addr) : base(addr) { }
        public PortalWarsSpinSliderWidget Master { get { return this[nameof(Master)].As<PortalWarsSpinSliderWidget>(); } set { this["Master"] = value; } }
        public PortalWarsSpinSliderWidget Gameplay { get { return this[nameof(Gameplay)].As<PortalWarsSpinSliderWidget>(); } set { this["Gameplay"] = value; } }
        public PortalWarsSpinSliderWidget Music { get { return this[nameof(Music)].As<PortalWarsSpinSliderWidget>(); } set { this["Music"] = value; } }
        public PortalWarsSpinSliderWidget Announcer { get { return this[nameof(Announcer)].As<PortalWarsSpinSliderWidget>(); } set { this["Announcer"] = value; } }
        public PortalWarsSpinSliderWidget Ambiance { get { return this[nameof(Ambiance)].As<PortalWarsSpinSliderWidget>(); } set { this["Ambiance"] = value; } }
        public PortalWarsCheckBoxWidget MuteWhileMinimized { get { return this[nameof(MuteWhileMinimized)].As<PortalWarsCheckBoxWidget>(); } set { this["MuteWhileMinimized"] = value; } }
        public WidgetSwitcher VoiceSwitcher { get { return this[nameof(VoiceSwitcher)].As<WidgetSwitcher>(); } set { this["VoiceSwitcher"] = value; } }
        public PortalWarsSpinSliderWidget VOIP { get { return this[nameof(VOIP)].As<PortalWarsSpinSliderWidget>(); } set { this["VOIP"] = value; } }
        public PortalWarsCheckBoxWidget OpenMic { get { return this[nameof(OpenMic)].As<PortalWarsCheckBoxWidget>(); } set { this["OpenMic"] = value; } }
        public PortalWarsCheckBoxWidget ProximityEnabled { get { return this[nameof(ProximityEnabled)].As<PortalWarsCheckBoxWidget>(); } set { this["ProximityEnabled"] = value; } }
        public PortalWarsDropdownWidget VoiceChatInputDevice { get { return this[nameof(VoiceChatInputDevice)].As<PortalWarsDropdownWidget>(); } set { this["VoiceChatInputDevice"] = value; } }
        public PortalWarsDropdownWidget VoiceChatOutputDevice { get { return this[nameof(VoiceChatOutputDevice)].As<PortalWarsDropdownWidget>(); } set { this["VoiceChatOutputDevice"] = value; } }
    }
    public class PortalWarsDialogWidget : PortalWarsMenuWidget
    {
        public PortalWarsDialogWidget(ulong addr) : base(addr) { }
        public Object OnDialogClosed { get { return this[nameof(OnDialogClosed)]; } set { this[nameof(OnDialogClosed)] = value; } }
        public Object OnDialogClosedPointer { get { return this[nameof(OnDialogClosedPointer)]; } set { this[nameof(OnDialogClosedPointer)] = value; } }
        public float MaxLifetime { get { return this[nameof(MaxLifetime)].GetValue<float>(); } set { this[nameof(MaxLifetime)].SetValue<float>(value); } }
        public ProgressBar LifetimeProgressBar { get { return this[nameof(LifetimeProgressBar)].As<ProgressBar>(); } set { this["LifetimeProgressBar"] = value; } }
        public float MinLifetime { get { return this[nameof(MinLifetime)].GetValue<float>(); } set { this[nameof(MinLifetime)].SetValue<float>(value); } }
        public PortalWarsButtonWidget CloseButton { get { return this[nameof(CloseButton)].As<PortalWarsButtonWidget>(); } set { this["CloseButton"] = value; } }
        public WidgetAnimation OpenAnimation { get { return this[nameof(OpenAnimation)].As<WidgetAnimation>(); } set { this["OpenAnimation"] = value; } }
        public void SetCloseButtonsEnabled(bool InIsEnabled) { Invoke(nameof(SetCloseButtonsEnabled), InIsEnabled); }
        public void OnMinLifetimeReached() { Invoke(nameof(OnMinLifetimeReached)); }
        public void CloseDialog() { Invoke(nameof(CloseDialog)); }
    }
    public class PortalWarsAutoSettingsWidget : PortalWarsDialogWidget
    {
        public PortalWarsAutoSettingsWidget(ulong addr) : base(addr) { }
    }
    public class PortalWarsAvoidanceManager : AvoidanceManager
    {
        public PortalWarsAvoidanceManager(ulong addr) : base(addr) { }
    }
    public class PortalWarsBaseGameMode : GameMode
    {
        public PortalWarsBaseGameMode(ulong addr) : base(addr) { }
        public int MaxPlayers { get { return this[nameof(MaxPlayers)].GetValue<int>(); } set { this[nameof(MaxPlayers)].SetValue<int>(value); } }
        public Object BotPawnClass { get { return this[nameof(BotPawnClass)]; } set { this[nameof(BotPawnClass)] = value; } }
        public Object AIControllerClass { get { return this[nameof(AIControllerClass)]; } set { this[nameof(AIControllerClass)] = value; } }
    }
    public class PortalWarsBaseGameState : GameState
    {
        public PortalWarsBaseGameState(ulong addr) : base(addr) { }
        public Array<PlayerState> InactivePlayerArray { get { return new Array<PlayerState>(this[nameof(InactivePlayerArray)].Address); } }
        public int RemainingTime { get { return this[nameof(RemainingTime)].GetValue<int>(); } set { this[nameof(RemainingTime)].SetValue<int>(value); } }
        public int ReplicatedRemainingTime { get { return this[nameof(ReplicatedRemainingTime)].GetValue<int>(); } set { this[nameof(ReplicatedRemainingTime)].SetValue<int>(value); } }
        public Object PlaylistType { get { return this[nameof(PlaylistType)]; } set { this[nameof(PlaylistType)] = value; } }
        public EServerType ServerType { get { return (EServerType)this[nameof(ServerType)].GetValue<int>(); } set { this[nameof(ServerType)].SetValue<int>((int)value); } }
        public GameConfig GameConfig { get { return this[nameof(GameConfig)].As<GameConfig>(); } set { this["GameConfig"] = value; } }
        public int MaxPlayers { get { return this[nameof(MaxPlayers)].GetValue<int>(); } set { this[nameof(MaxPlayers)].SetValue<int>(value); } }
        public void OnRepRemainingTime() { Invoke(nameof(OnRepRemainingTime)); }
        public void OnRep_GameConfig() { Invoke(nameof(OnRep_GameConfig)); }
        public Array<PortalWarsPlayerState> GetSortedPlayers(int TeamNum, bool bSortByScore) { return Invoke<Array<PortalWarsPlayerState>>(nameof(GetSortedPlayers), TeamNum, bSortByScore); }
        public int GetRemainingTime() { return Invoke<int>(nameof(GetRemainingTime)); }
        public int GetNumberOfPlayersOnTeam(int TeamNum) { return Invoke<int>(nameof(GetNumberOfPlayersOnTeam), TeamNum); }
    }
    public class PortalWarsButtonWidget : PortalWarsUserWidget
    {
        public PortalWarsButtonWidget(ulong addr) : base(addr) { }
        public Object OnClicked { get { return this[nameof(OnClicked)]; } set { this[nameof(OnClicked)] = value; } }
        public Object OnDoubleClicked { get { return this[nameof(OnDoubleClicked)]; } set { this[nameof(OnDoubleClicked)] = value; } }
        public Object OnHovered { get { return this[nameof(OnHovered)]; } set { this[nameof(OnHovered)] = value; } }
        public Object OnUnhovered { get { return this[nameof(OnUnhovered)]; } set { this[nameof(OnUnhovered)] = value; } }
        public Object OnEnabledStateChanged { get { return this[nameof(OnEnabledStateChanged)]; } set { this[nameof(OnEnabledStateChanged)] = value; } }
        public PortalWarsButton Button { get { return this[nameof(Button)].As<PortalWarsButton>(); } set { this["Button"] = value; } }
        public PortalWarsButtonWidget ButtonWidget { get { return this[nameof(ButtonWidget)].As<PortalWarsButtonWidget>(); } set { this["ButtonWidget"] = value; } }
        public bool bDebounce { get { return this[nameof(bDebounce)].Flag; } set { this[nameof(bDebounce)].Flag = value; } }
        public float DebounceTime { get { return this[nameof(DebounceTime)].GetValue<float>(); } set { this[nameof(DebounceTime)].SetValue<float>(value); } }
        public AkAudioEvent PressedEvent { get { return this[nameof(PressedEvent)].As<AkAudioEvent>(); } set { this["PressedEvent"] = value; } }
        public AkAudioEvent HoveredEvent { get { return this[nameof(HoveredEvent)].As<AkAudioEvent>(); } set { this["HoveredEvent"] = value; } }
        public WidgetAnimation HoverAnimation { get { return this[nameof(HoverAnimation)].As<WidgetAnimation>(); } set { this["HoverAnimation"] = value; } }
        public bool bTrackButtonEvents { get { return this[nameof(bTrackButtonEvents)].Flag; } set { this[nameof(bTrackButtonEvents)].Flag = value; } }
        public Object ButtonInternalName { get { return this[nameof(ButtonInternalName)]; } set { this[nameof(ButtonInternalName)] = value; } }
        public Object Title { get { return this[nameof(Title)]; } set { this[nameof(Title)] = value; } }
        public TextBlock TitleText { get { return this[nameof(TitleText)].As<TextBlock>(); } set { this["TitleText"] = value; } }
        public Key GamepadKey { get { return this[nameof(GamepadKey)].As<Key>(); } set { this["GamepadKey"] = value; } }
        public bool bBindToGamepadButton { get { return this[nameof(bBindToGamepadButton)].Flag; } set { this[nameof(bBindToGamepadButton)].Flag = value; } }
        public Texture2D GamepadKeyIcon { get { return this[nameof(GamepadKeyIcon)].As<Texture2D>(); } set { this["GamepadKeyIcon"] = value; } }
        public WidgetSwitcher ConsoleSwitcher { get { return this[nameof(ConsoleSwitcher)].As<WidgetSwitcher>(); } set { this["ConsoleSwitcher"] = value; } }
        public Widget NewIndicator { get { return this[nameof(NewIndicator)].As<Widget>(); } set { this["NewIndicator"] = value; } }
        public TextBlock newText { get { return this[nameof(newText)].As<TextBlock>(); } set { this["newText"] = value; } }
        public void SetNewItems_BP(int InNewItems) { Invoke(nameof(SetNewItems_BP), InNewItems); }
        public void RefreshEnabledState() { Invoke(nameof(RefreshEnabledState)); }
        public void OnGamepadButtonPressed() { Invoke(nameof(OnGamepadButtonPressed)); }
        public void OnButtonUnhovered() { Invoke(nameof(OnButtonUnhovered)); }
        public void OnButtonHovered() { Invoke(nameof(OnButtonHovered)); }
        public void OnButtonDoubleClicked() { Invoke(nameof(OnButtonDoubleClicked)); }
        public void OnButtonClicked() { Invoke(nameof(OnButtonClicked)); }
        public bool IsEnabled() { return Invoke<bool>(nameof(IsEnabled)); }
        public ESlateVisibility GetNewVisibility() { return Invoke<ESlateVisibility>(nameof(GetNewVisibility)); }
        public Texture2D GetGamepadKeyIcon() { return Invoke<Texture2D>(nameof(GetGamepadKeyIcon)); }
    }
    public class PortalWarsEntryWidget : PortalWarsButtonWidget
    {
        public PortalWarsEntryWidget(ulong addr) : base(addr) { }
        public bool bIsSelected { get { return this[nameof(bIsSelected)].Flag; } set { this[nameof(bIsSelected)].Flag = value; } }
        public Object OnEntrySelected { get { return this[nameof(OnEntrySelected)]; } set { this[nameof(OnEntrySelected)] = value; } }
        public Object OnEntryDoubleClicked { get { return this[nameof(OnEntryDoubleClicked)]; } set { this[nameof(OnEntryDoubleClicked)] = value; } }
        public Object OnEntryHovered { get { return this[nameof(OnEntryHovered)]; } set { this[nameof(OnEntryHovered)] = value; } }
        public Object OnEntryUnhovered { get { return this[nameof(OnEntryUnhovered)]; } set { this[nameof(OnEntryUnhovered)] = value; } }
        public bool bSelectOnControllerHover { get { return this[nameof(bSelectOnControllerHover)].Flag; } set { this[nameof(bSelectOnControllerHover)].Flag = value; } }
        public WidgetAnimation FadeInAnimation { get { return this[nameof(FadeInAnimation)].As<WidgetAnimation>(); } set { this["FadeInAnimation"] = value; } }
        public WidgetAnimation FadeOutAnimation { get { return this[nameof(FadeOutAnimation)].As<WidgetAnimation>(); } set { this["FadeOutAnimation"] = value; } }
        public void RefreshEntry_BP() { Invoke(nameof(RefreshEntry_BP)); }
        public void RefreshEntry() { Invoke(nameof(RefreshEntry)); }
    }
    public class PortalWarsRewardEntryWidget : PortalWarsEntryWidget
    {
        public PortalWarsRewardEntryWidget(ulong addr) : base(addr) { }
        public TextBlock RewardTitleText { get { return this[nameof(RewardTitleText)].As<TextBlock>(); } set { this["RewardTitleText"] = value; } }
        public TextBlock RewardValueText { get { return this[nameof(RewardValueText)].As<TextBlock>(); } set { this["RewardValueText"] = value; } }
        public TextBlock RewardDescriptionText { get { return this[nameof(RewardDescriptionText)].As<TextBlock>(); } set { this["RewardDescriptionText"] = value; } }
        public Image RarityIcon { get { return this[nameof(RarityIcon)].As<Image>(); } set { this["RarityIcon"] = value; } }
        public Image RarityBG { get { return this[nameof(RarityBG)].As<Image>(); } set { this["RarityBG"] = value; } }
        public Image RarityBorder { get { return this[nameof(RarityBorder)].As<Image>(); } set { this["RarityBorder"] = value; } }
        public Image RarityScrim { get { return this[nameof(RarityScrim)].As<Image>(); } set { this["RarityScrim"] = value; } }
        public Object RarityBackgrounds { get { return this[nameof(RarityBackgrounds)]; } set { this[nameof(RarityBackgrounds)] = value; } }
        public Object RarityScrims { get { return this[nameof(RarityScrims)]; } set { this[nameof(RarityScrims)] = value; } }
        public Object RarityTitleColors { get { return this[nameof(RarityTitleColors)]; } set { this[nameof(RarityTitleColors)] = value; } }
        public Object RarityBorderColors { get { return this[nameof(RarityBorderColors)]; } set { this[nameof(RarityBorderColors)] = value; } }
        public Image RewardImage { get { return this[nameof(RewardImage)].As<Image>(); } set { this["RewardImage"] = value; } }
        public WidgetSwitcher ThumbnailSwitcher { get { return this[nameof(ThumbnailSwitcher)].As<WidgetSwitcher>(); } set { this["ThumbnailSwitcher"] = value; } }
        public Border NameTagBorder { get { return this[nameof(NameTagBorder)].As<Border>(); } set { this["NameTagBorder"] = value; } }
        public Widget XPRewardRoot { get { return this[nameof(XPRewardRoot)].As<Widget>(); } set { this["XPRewardRoot"] = value; } }
        public Widget DropRewardRoot { get { return this[nameof(DropRewardRoot)].As<Widget>(); } set { this["DropRewardRoot"] = value; } }
        public Object CustomizationThumbnailPaddings { get { return this[nameof(CustomizationThumbnailPaddings)]; } set { this[nameof(CustomizationThumbnailPaddings)] = value; } }
        public Object RewardThumbnailPaddings { get { return this[nameof(RewardThumbnailPaddings)]; } set { this[nameof(RewardThumbnailPaddings)] = value; } }
        public Object CustomizationRenderAngles { get { return this[nameof(CustomizationRenderAngles)]; } set { this[nameof(CustomizationRenderAngles)] = value; } }
        public Object RewardRenderAngles { get { return this[nameof(RewardRenderAngles)]; } set { this[nameof(RewardRenderAngles)] = value; } }
        public ESlateVisibility GetRewardVisibility() { return Invoke<ESlateVisibility>(nameof(GetRewardVisibility)); }
        public Object GetRewardValueText() { return Invoke<Object>(nameof(GetRewardValueText)); }
        public Object GetRewardTitleText() { return Invoke<Object>(nameof(GetRewardTitleText)); }
        public Object GetRewardRarityText() { return Invoke<Object>(nameof(GetRewardRarityText)); }
        public Texture2D GetRewardRarityIcon() { return Invoke<Texture2D>(nameof(GetRewardRarityIcon)); }
        public LinearColor GetRewardRarityColor() { return Invoke<LinearColor>(nameof(GetRewardRarityColor)); }
        public Object GetRewardFullTitleText() { return Invoke<Object>(nameof(GetRewardFullTitleText)); }
        public Object GetRewardDescriptionText() { return Invoke<Object>(nameof(GetRewardDescriptionText)); }
        public LinearColor GetRarityTitleColor() { return Invoke<LinearColor>(nameof(GetRarityTitleColor)); }
        public Texture2D GetRarityScrim() { return Invoke<Texture2D>(nameof(GetRarityScrim)); }
        public LinearColor GetRarityBorderColor() { return Invoke<LinearColor>(nameof(GetRarityBorderColor)); }
        public Texture2D GetRarityBG() { return Invoke<Texture2D>(nameof(GetRarityBG)); }
    }
    public class PortalWarsRewardPassEntryWidget : PortalWarsRewardEntryWidget
    {
        public PortalWarsRewardPassEntryWidget(ulong addr) : base(addr) { }
        public Widget LockedRoot { get { return this[nameof(LockedRoot)].As<Widget>(); } set { this["LockedRoot"] = value; } }
        public Widget CompletedRoot { get { return this[nameof(CompletedRoot)].As<Widget>(); } set { this["CompletedRoot"] = value; } }
        public TextBlock LevelText { get { return this[nameof(LevelText)].As<TextBlock>(); } set { this["LevelText"] = value; } }
        public TextBlock DisplayNameText { get { return this[nameof(DisplayNameText)].As<TextBlock>(); } set { this["DisplayNameText"] = value; } }
        public WidgetSwitcher BackgroundSwitcher { get { return this[nameof(BackgroundSwitcher)].As<WidgetSwitcher>(); } set { this["BackgroundSwitcher"] = value; } }
        public WidgetAnimation SelectedAnimation { get { return this[nameof(SelectedAnimation)].As<WidgetAnimation>(); } set { this["SelectedAnimation"] = value; } }
        public ESlateVisibility GetLockedVisibility() { return Invoke<ESlateVisibility>(nameof(GetLockedVisibility)); }
        public Object GetLevelText() { return Invoke<Object>(nameof(GetLevelText)); }
    }
    public class PortalWarsBattlePassEntryWidget : PortalWarsRewardPassEntryWidget
    {
        public PortalWarsBattlePassEntryWidget(ulong addr) : base(addr) { }
        public ProgressBar XPProgressBar { get { return this[nameof(XPProgressBar)].As<ProgressBar>(); } set { this["XPProgressBar"] = value; } }
        public Widget FreeIndicator { get { return this[nameof(FreeIndicator)].As<Widget>(); } set { this["FreeIndicator"] = value; } }
    }
    public class PortalWarsCareerProgressWidget : PortalWarsUserWidget
    {
        public PortalWarsCareerProgressWidget(ulong addr) : base(addr) { }
        public TextBlock PlayerNameText { get { return this[nameof(PlayerNameText)].As<TextBlock>(); } set { this["PlayerNameText"] = value; } }
        public Image AvatarImage { get { return this[nameof(AvatarImage)].As<Image>(); } set { this["AvatarImage"] = value; } }
        public PortalWarsProgressionIconWidget ProgressionLevelIcon { get { return this[nameof(ProgressionLevelIcon)].As<PortalWarsProgressionIconWidget>(); } set { this["ProgressionLevelIcon"] = value; } }
        public TextBlock ProgressionLevelText { get { return this[nameof(ProgressionLevelText)].As<TextBlock>(); } set { this["ProgressionLevelText"] = value; } }
        public ProgressBar ProgressionProgressBar { get { return this[nameof(ProgressionProgressBar)].As<ProgressBar>(); } set { this["ProgressionProgressBar"] = value; } }
        public TextBlock ProgressionLevelProgressText { get { return this[nameof(ProgressionLevelProgressText)].As<TextBlock>(); } set { this["ProgressionLevelProgressText"] = value; } }
        public TextBlock ProgressionLevelTotalText { get { return this[nameof(ProgressionLevelTotalText)].As<TextBlock>(); } set { this["ProgressionLevelTotalText"] = value; } }
        public Widget ProgressionProgressRoot { get { return this[nameof(ProgressionProgressRoot)].As<Widget>(); } set { this["ProgressionProgressRoot"] = value; } }
        public PortalWarsProgressionIconWidget BattlePassLevelIcon { get { return this[nameof(BattlePassLevelIcon)].As<PortalWarsProgressionIconWidget>(); } set { this["BattlePassLevelIcon"] = value; } }
        public TextBlock BattlePassLevelText { get { return this[nameof(BattlePassLevelText)].As<TextBlock>(); } set { this["BattlePassLevelText"] = value; } }
        public ProgressBar BattlePassProgressBar { get { return this[nameof(BattlePassProgressBar)].As<ProgressBar>(); } set { this["BattlePassProgressBar"] = value; } }
        public TextBlock BattlePassLevelProgressText { get { return this[nameof(BattlePassLevelProgressText)].As<TextBlock>(); } set { this["BattlePassLevelProgressText"] = value; } }
        public TextBlock BattlePassLevelTotalText { get { return this[nameof(BattlePassLevelTotalText)].As<TextBlock>(); } set { this["BattlePassLevelTotalText"] = value; } }
        public Widget BattlePassProgressRoot { get { return this[nameof(BattlePassProgressRoot)].As<Widget>(); } set { this["BattlePassProgressRoot"] = value; } }
        public WidgetSwitcher BattlePassSwitcher { get { return this[nameof(BattlePassSwitcher)].As<WidgetSwitcher>(); } set { this["BattlePassSwitcher"] = value; } }
        public TextBlock RankText { get { return this[nameof(RankText)].As<TextBlock>(); } set { this["RankText"] = value; } }
        public Image RankIcon { get { return this[nameof(RankIcon)].As<Image>(); } set { this["RankIcon"] = value; } }
        public Widget RankRoot { get { return this[nameof(RankRoot)].As<Widget>(); } set { this["RankRoot"] = value; } }
        public bool bShowRank { get { return this[nameof(bShowRank)].Flag; } set { this[nameof(bShowRank)].Flag = value; } }
        public void RefreshWidget() { Invoke(nameof(RefreshWidget)); }
        public void InitProfileData() { Invoke(nameof(InitProfileData)); }
        public float GetProgressionProgressPercent() { return Invoke<float>(nameof(GetProgressionProgressPercent)); }
        public ESlateVisibility GetProgressionMaxLevelVisibility() { return Invoke<ESlateVisibility>(nameof(GetProgressionMaxLevelVisibility)); }
        public Object GetProgressionLevelTotalText() { return Invoke<Object>(nameof(GetProgressionLevelTotalText)); }
        public Object GetProgressionLevelProgressText() { return Invoke<Object>(nameof(GetProgressionLevelProgressText)); }
        public int GetProgressionLevel() { return Invoke<int>(nameof(GetProgressionLevel)); }
        public float GetBattlePassProgressPercent() { return Invoke<float>(nameof(GetBattlePassProgressPercent)); }
        public ESlateVisibility GetBattlePassMaxLevelVisibility() { return Invoke<ESlateVisibility>(nameof(GetBattlePassMaxLevelVisibility)); }
        public Object GetBattlePassLevelTotalText() { return Invoke<Object>(nameof(GetBattlePassLevelTotalText)); }
        public Object GetBattlePassLevelProgressText() { return Invoke<Object>(nameof(GetBattlePassLevelProgressText)); }
        public int GetBattlePassLevel() { return Invoke<int>(nameof(GetBattlePassLevel)); }
    }
    public class PortalWarsBattlePassPanelWidget : PortalWarsCareerProgressWidget
    {
        public PortalWarsBattlePassPanelWidget(ulong addr) : base(addr) { }
        public TextBlock RewardTitleText { get { return this[nameof(RewardTitleText)].As<TextBlock>(); } set { this["RewardTitleText"] = value; } }
        public PortalWarsRewardEntryWidget RewardEntry { get { return this[nameof(RewardEntry)].As<PortalWarsRewardEntryWidget>(); } set { this["RewardEntry"] = value; } }
        public TextBlock UnlockedText { get { return this[nameof(UnlockedText)].As<TextBlock>(); } set { this["UnlockedText"] = value; } }
        public PortalWarsButtonWidget ViewBattlePassButton { get { return this[nameof(ViewBattlePassButton)].As<PortalWarsButtonWidget>(); } set { this["ViewBattlePassButton"] = value; } }
        public void OnViewBattlePassClicked() { Invoke(nameof(OnViewBattlePassClicked)); }
        public Object GetUnlockedText() { return Invoke<Object>(nameof(GetUnlockedText)); }
        public Object GetRewardTitleText() { return Invoke<Object>(nameof(GetRewardTitleText)); }
    }
    public class PortalWarsInspectWidget : PortalWarsMenuWidget
    {
        public PortalWarsInspectWidget(ulong addr) : base(addr) { }
        public float PreviewDelayTime { get { return this[nameof(PreviewDelayTime)].GetValue<float>(); } set { this[nameof(PreviewDelayTime)].SetValue<float>(value); } }
        public Object InspectItemWidgetClass { get { return this[nameof(InspectItemWidgetClass)]; } set { this[nameof(InspectItemWidgetClass)] = value; } }
        public CanvasPanel InspectPanel { get { return this[nameof(InspectPanel)].As<CanvasPanel>(); } set { this["InspectPanel"] = value; } }
        public TextBlock DisplayNameText { get { return this[nameof(DisplayNameText)].As<TextBlock>(); } set { this["DisplayNameText"] = value; } }
        public TextBlock RarityText { get { return this[nameof(RarityText)].As<TextBlock>(); } set { this["RarityText"] = value; } }
        public Image RarityIcon { get { return this[nameof(RarityIcon)].As<Image>(); } set { this["RarityIcon"] = value; } }
        public Widget ItemInfoRoot { get { return this[nameof(ItemInfoRoot)].As<Widget>(); } set { this["ItemInfoRoot"] = value; } }
        public PortalWarsButtonWidget EquipButton { get { return this[nameof(EquipButton)].As<PortalWarsButtonWidget>(); } set { this["EquipButton"] = value; } }
        public WidgetSwitcher EquipSwitcher { get { return this[nameof(EquipSwitcher)].As<WidgetSwitcher>(); } set { this["EquipSwitcher"] = value; } }
        public MainMenuGameState GameStateRef { get { return this[nameof(GameStateRef)].As<MainMenuGameState>(); } set { this["GameStateRef"] = value; } }
        public void UpdatePreview(bool bClearPrevious) { Invoke(nameof(UpdatePreview), bClearPrevious); }
        public void UpdateEquipState() { Invoke(nameof(UpdateEquipState)); }
        public void PreviewItem() { Invoke(nameof(PreviewItem)); }
        public void OnEquipButtonClicked() { Invoke(nameof(OnEquipButtonClicked)); }
        public void OnCustomizationsUpdate() { Invoke(nameof(OnCustomizationsUpdate)); }
        public Object GetRarityText() { return Invoke<Object>(nameof(GetRarityText)); }
        public Texture2D GetRarityIcon() { return Invoke<Texture2D>(nameof(GetRarityIcon)); }
        public LinearColor GetRarityColor() { return Invoke<LinearColor>(nameof(GetRarityColor)); }
        public Object GetDisplayName() { return Invoke<Object>(nameof(GetDisplayName)); }
    }
    public class PortalWarsRewardPassWidget : PortalWarsInspectWidget
    {
        public PortalWarsRewardPassWidget(ulong addr) : base(addr) { }
        public Object EntryWidgetClass { get { return this[nameof(EntryWidgetClass)]; } set { this[nameof(EntryWidgetClass)] = value; } }
        public Object EntryWidgetClassOverrides { get { return this[nameof(EntryWidgetClassOverrides)]; } set { this[nameof(EntryWidgetClassOverrides)] = value; } }
        public PortalWarsCustomScrollWidget ItemsPanel { get { return this[nameof(ItemsPanel)].As<PortalWarsCustomScrollWidget>(); } set { this["ItemsPanel"] = value; } }
        public Array<RewardPassEntryData> RewardPassEntries { get { return new Array<RewardPassEntryData>(this[nameof(RewardPassEntries)].Address); } }
        public TextBlock CurrentLevelText { get { return this[nameof(CurrentLevelText)].As<TextBlock>(); } set { this["CurrentLevelText"] = value; } }
        public void OnRewardEntrySelected(PortalWarsEntryWidget Entry) { Invoke(nameof(OnRewardEntrySelected), Entry); }
        public void OnRewardEntryScrolledTo(Widget Widget) { Invoke(nameof(OnRewardEntryScrolledTo), Widget); }
        public void OnProgressionUpdate() { Invoke(nameof(OnProgressionUpdate)); }
        public RewardData GetSelectedRewardData() { return Invoke<RewardData>(nameof(GetSelectedRewardData)); }
        public Widget GetRewardEntryWidget(Object WidgetId) { return Invoke<Widget>(nameof(GetRewardEntryWidget), WidgetId); }
        public Object GetCurrentLevelText() { return Invoke<Object>(nameof(GetCurrentLevelText)); }
    }
    public class PortalWarsBattlePassWidget : PortalWarsRewardPassWidget
    {
        public PortalWarsBattlePassWidget(ulong addr) : base(addr) { }
        public Widget PremiumActiveRoot { get { return this[nameof(PremiumActiveRoot)].As<Widget>(); } set { this["PremiumActiveRoot"] = value; } }
        public PortalWarsBPRedeemableButton PurchaseButton { get { return this[nameof(PurchaseButton)].As<PortalWarsBPRedeemableButton>(); } set { this["PurchaseButton"] = value; } }
        public ESlateVisibility GetPurchaseButtonVisibility() { return Invoke<ESlateVisibility>(nameof(GetPurchaseButtonVisibility)); }
        public bool GetPurchaseButtonEnabled() { return Invoke<bool>(nameof(GetPurchaseButtonEnabled)); }
    }
    public class PortalWarsBlockedPlayersWidget : PortalWarsMenuWidget
    {
        public PortalWarsBlockedPlayersWidget(ulong addr) : base(addr) { }
        public PortalWarsButtonWidget RefreshButton { get { return this[nameof(RefreshButton)].As<PortalWarsButtonWidget>(); } set { this["RefreshButton"] = value; } }
        public PanelWidget BlockedPlayersPanel { get { return this[nameof(BlockedPlayersPanel)].As<PanelWidget>(); } set { this["BlockedPlayersPanel"] = value; } }
        public Object PlayerEntryWidgetClass { get { return this[nameof(PlayerEntryWidgetClass)]; } set { this[nameof(PlayerEntryWidgetClass)] = value; } }
        public Object PlayerActionsWidgetClass { get { return this[nameof(PlayerActionsWidgetClass)]; } set { this[nameof(PlayerActionsWidgetClass)] = value; } }
        public TextBlock ErrorText { get { return this[nameof(ErrorText)].As<TextBlock>(); } set { this["ErrorText"] = value; } }
        public void RefreshPlayersList() { Invoke(nameof(RefreshPlayersList)); }
        public void OnPlayerEntrySelected(PortalWarsEntryWidget Entry) { Invoke(nameof(OnPlayerEntrySelected), Entry); }
        public bool GetRefreshButtonEnabled() { return Invoke<bool>(nameof(GetRefreshButtonEnabled)); }
        public void DelayedRefreshPlayersList() { Invoke(nameof(DelayedRefreshPlayersList)); }
    }
    public class PortalWarsCharacter : Character
    {
        public PortalWarsCharacter(ulong addr) : base(addr) { }
        public PortalWarsGameState GameStateRef { get { return this[nameof(GameStateRef)].As<PortalWarsGameState>(); } set { this["GameStateRef"] = value; } }
        public float Health { get { return this[nameof(Health)].GetValue<float>(); } set { this[nameof(Health)].SetValue<float>(value); } }
        public float MaxHealth { get { return this[nameof(MaxHealth)].GetValue<float>(); } set { this[nameof(MaxHealth)].SetValue<float>(value); } }
        public float healthRechargeDelay { get { return this[nameof(healthRechargeDelay)].GetValue<float>(); } set { this[nameof(healthRechargeDelay)].SetValue<float>(value); } }
        public AkAudioEvent HealthRechargeStartEvent { get { return this[nameof(HealthRechargeStartEvent)].As<AkAudioEvent>(); } set { this["HealthRechargeStartEvent"] = value; } }
        public AkAudioEvent HealthRechargeStopEvent { get { return this[nameof(HealthRechargeStopEvent)].As<AkAudioEvent>(); } set { this["HealthRechargeStopEvent"] = value; } }
        public AkAudioEvent LowHealthStartEvent { get { return this[nameof(LowHealthStartEvent)].As<AkAudioEvent>(); } set { this["LowHealthStartEvent"] = value; } }
        public AkAudioEvent LowHealthStopEvent { get { return this[nameof(LowHealthStopEvent)].As<AkAudioEvent>(); } set { this["LowHealthStopEvent"] = value; } }
        public AkAudioEvent KillHealthLoopEvents { get { return this[nameof(KillHealthLoopEvents)].As<AkAudioEvent>(); } set { this["KillHealthLoopEvents"] = value; } }
        public HitInfo LastCausedHitInfo { get { return this[nameof(LastCausedHitInfo)].As<HitInfo>(); } set { this["LastCausedHitInfo"] = value; } }
        public AnimMontage upperBodyFlinchMontage { get { return this[nameof(upperBodyFlinchMontage)].As<AnimMontage>(); } set { this["upperBodyFlinchMontage"] = value; } }
        public AnimMontage lowerBodyFlinchMontage { get { return this[nameof(lowerBodyFlinchMontage)].As<AnimMontage>(); } set { this["lowerBodyFlinchMontage"] = value; } }
        public AnimMontage headFlinchMontage { get { return this[nameof(headFlinchMontage)].As<AnimMontage>(); } set { this["headFlinchMontage"] = value; } }
        public Object SuicideDamageType { get { return this[nameof(SuicideDamageType)]; } set { this[nameof(SuicideDamageType)] = value; } }
        public Object portalDamageType { get { return this[nameof(portalDamageType)]; } set { this[nameof(portalDamageType)] = value; } }
        public AkAudioEvent PlayerTakeDamageEvent { get { return this[nameof(PlayerTakeDamageEvent)].As<AkAudioEvent>(); } set { this["PlayerTakeDamageEvent"] = value; } }
        public AkAudioEvent RagdollCollisionEvent { get { return this[nameof(RagdollCollisionEvent)].As<AkAudioEvent>(); } set { this["RagdollCollisionEvent"] = value; } }
        public float RagdollImpactSFXThreshold { get { return this[nameof(RagdollImpactSFXThreshold)].GetValue<float>(); } set { this[nameof(RagdollImpactSFXThreshold)].SetValue<float>(value); } }
        public float PostDeathPortalLifetime { get { return this[nameof(PostDeathPortalLifetime)].GetValue<float>(); } set { this[nameof(PostDeathPortalLifetime)].SetValue<float>(value); } }
        public float RagdollLifetime { get { return this[nameof(RagdollLifetime)].GetValue<float>(); } set { this[nameof(RagdollLifetime)].SetValue<float>(value); } }
        public Array<PortalWarsAIController> TargetingBots { get { return new Array<PortalWarsAIController>(this[nameof(TargetingBots)].Address); } }
        public CameraComponent ThirdPersonCamera { get { return this[nameof(ThirdPersonCamera)].As<CameraComponent>(); } set { this["ThirdPersonCamera"] = value; } }
        public SpringArmComponent ThirdPersonCameraArm { get { return this[nameof(ThirdPersonCameraArm)].As<SpringArmComponent>(); } set { this["ThirdPersonCameraArm"] = value; } }
        public float ReplayCameraLagSpeed { get { return this[nameof(ReplayCameraLagSpeed)].GetValue<float>(); } set { this[nameof(ReplayCameraLagSpeed)].SetValue<float>(value); } }
        public float ReplayCameraRotationLagSpeed { get { return this[nameof(ReplayCameraRotationLagSpeed)].GetValue<float>(); } set { this[nameof(ReplayCameraRotationLagSpeed)].SetValue<float>(value); } }
        public float SpectatorCameraLagSpeed { get { return this[nameof(SpectatorCameraLagSpeed)].GetValue<float>(); } set { this[nameof(SpectatorCameraLagSpeed)].SetValue<float>(value); } }
        public float SpectatorCameraRotationLagSpeed { get { return this[nameof(SpectatorCameraRotationLagSpeed)].GetValue<float>(); } set { this[nameof(SpectatorCameraRotationLagSpeed)].SetValue<float>(value); } }
        public CameraComponent SpectatorFirstPersonCamera { get { return this[nameof(SpectatorFirstPersonCamera)].As<CameraComponent>(); } set { this["SpectatorFirstPersonCamera"] = value; } }
        public SpringArmComponent SpectatorFirstPersonCameraArm { get { return this[nameof(SpectatorFirstPersonCameraArm)].As<SpringArmComponent>(); } set { this["SpectatorFirstPersonCameraArm"] = value; } }
        public Array<Object> DefaultInventoryClasses { get { return new Array<Object>(this[nameof(DefaultInventoryClasses)].Address); } }
        public Array<Gun> Inventory { get { return new Array<Gun>(this[nameof(Inventory)].Address); } }
        public Gun CurrentWeapon { get { return this[nameof(CurrentWeapon)].As<Gun>(); } set { this["CurrentWeapon"] = value; } }
        public Gun Fists { get { return this[nameof(Fists)].As<Gun>(); } set { this["Fists"] = value; } }
        public Object FistsClass { get { return this[nameof(FistsClass)]; } set { this[nameof(FistsClass)] = value; } }
        public Object CurrentWeaponClass { get { return this[nameof(CurrentWeaponClass)]; } set { this[nameof(CurrentWeaponClass)] = value; } }
        public Object WeaponAttachPoint { get { return this[nameof(WeaponAttachPoint)]; } set { this[nameof(WeaponAttachPoint)] = value; } }
        public Object GrendadeAttachPoint { get { return this[nameof(GrendadeAttachPoint)]; } set { this[nameof(GrendadeAttachPoint)] = value; } }
        public Object portalLauncherClass { get { return this[nameof(portalLauncherClass)]; } set { this[nameof(portalLauncherClass)] = value; } }
        public PortalLauncher PortalLauncher { get { return this[nameof(PortalLauncher)].As<PortalLauncher>(); } set { this["PortalLauncher"] = value; } }
        public Object PortalLauncherAttachPoint { get { return this[nameof(PortalLauncherAttachPoint)]; } set { this[nameof(PortalLauncherAttachPoint)] = value; } }
        public SceneComponent FirstPersonArmsRoot { get { return this[nameof(FirstPersonArmsRoot)].As<SceneComponent>(); } set { this["FirstPersonArmsRoot"] = value; } }
        public SkeletalMeshComponent Mesh1P { get { return this[nameof(Mesh1P)].As<SkeletalMeshComponent>(); } set { this["Mesh1P"] = value; } }
        public SkeletalMeshComponent Jetpack { get { return this[nameof(Jetpack)].As<SkeletalMeshComponent>(); } set { this["Jetpack"] = value; } }
        public Object JetpackFlameMeshes { get { return this[nameof(JetpackFlameMeshes)]; } set { this[nameof(JetpackFlameMeshes)] = value; } }
        public int FriendlyStencilValue { get { return this[nameof(FriendlyStencilValue)].GetValue<int>(); } set { this[nameof(FriendlyStencilValue)].SetValue<int>(value); } }
        public int EnemyStencilValue { get { return this[nameof(EnemyStencilValue)].GetValue<int>(); } set { this[nameof(EnemyStencilValue)].SetValue<int>(value); } }
        public int AlphaTeamStencilValue { get { return this[nameof(AlphaTeamStencilValue)].GetValue<int>(); } set { this[nameof(AlphaTeamStencilValue)].SetValue<int>(value); } }
        public int BravoTeamStencilValue { get { return this[nameof(BravoTeamStencilValue)].GetValue<int>(); } set { this[nameof(BravoTeamStencilValue)].SetValue<int>(value); } }
        public LinearColor BlueOutlineColor { get { return this[nameof(BlueOutlineColor)].As<LinearColor>(); } set { this["BlueOutlineColor"] = value; } }
        public LinearColor RedOutlineColor { get { return this[nameof(RedOutlineColor)].As<LinearColor>(); } set { this["RedOutlineColor"] = value; } }
        public float ColorIntensity3P { get { return this[nameof(ColorIntensity3P)].GetValue<float>(); } set { this[nameof(ColorIntensity3P)].SetValue<float>(value); } }
        public float ColorIntensity1P { get { return this[nameof(ColorIntensity1P)].GetValue<float>(); } set { this[nameof(ColorIntensity1P)].SetValue<float>(value); } }
        public MaterialInstance EnemyCharacterMaterialOverride { get { return this[nameof(EnemyCharacterMaterialOverride)].As<MaterialInstance>(); } set { this["EnemyCharacterMaterialOverride"] = value; } }
        public CustomizationId EnemyCharacterCustomizationOverride { get { return this[nameof(EnemyCharacterCustomizationOverride)].As<CustomizationId>(); } set { this["EnemyCharacterCustomizationOverride"] = value; } }
        public AnimSequence EmoteSequenceCurrentlyPlayingInMenu { get { return this[nameof(EmoteSequenceCurrentlyPlayingInMenu)].As<AnimSequence>(); } set { this["EmoteSequenceCurrentlyPlayingInMenu"] = value; } }
        public float SprayRange { get { return this[nameof(SprayRange)].GetValue<float>(); } set { this[nameof(SprayRange)].SetValue<float>(value); } }
        public float SprayLifetime { get { return this[nameof(SprayLifetime)].GetValue<float>(); } set { this[nameof(SprayLifetime)].SetValue<float>(value); } }
        public float TimeBetweenSprays { get { return this[nameof(TimeBetweenSprays)].GetValue<float>(); } set { this[nameof(TimeBetweenSprays)].SetValue<float>(value); } }
        public Array<SavedPosition> SavedPositions { get { return new Array<SavedPosition>(this[nameof(SavedPositions)].Address); } }
        public bool bIsSprinting { get { return this[nameof(bIsSprinting)].Flag; } set { this[nameof(bIsSprinting)].Flag = value; } }
        public Object SprintCamShake { get { return this[nameof(SprintCamShake)]; } set { this[nameof(SprintCamShake)] = value; } }
        public float SprintingSpeedModifier { get { return this[nameof(SprintingSpeedModifier)].GetValue<float>(); } set { this[nameof(SprintingSpeedModifier)].SetValue<float>(value); } }
        public PortalWarsTeabagZone TeabagZone { get { return this[nameof(TeabagZone)].As<PortalWarsTeabagZone>(); } set { this["TeabagZone"] = value; } }
        public float CrouchCameraSpeed { get { return this[nameof(CrouchCameraSpeed)].GetValue<float>(); } set { this[nameof(CrouchCameraSpeed)].SetValue<float>(value); } }
        public AkAudioEvent CrouchEvent { get { return this[nameof(CrouchEvent)].As<AkAudioEvent>(); } set { this["CrouchEvent"] = value; } }
        public AkAudioEvent UncrouchEvent { get { return this[nameof(UncrouchEvent)].As<AkAudioEvent>(); } set { this["UncrouchEvent"] = value; } }
        public float BaseTurnRate { get { return this[nameof(BaseTurnRate)].GetValue<float>(); } set { this[nameof(BaseTurnRate)].SetValue<float>(value); } }
        public float BaseLookUpRate { get { return this[nameof(BaseLookUpRate)].GetValue<float>(); } set { this[nameof(BaseLookUpRate)].SetValue<float>(value); } }
        public float ControllerMaxAccelMultiplier { get { return this[nameof(ControllerMaxAccelMultiplier)].GetValue<float>(); } set { this[nameof(ControllerMaxAccelMultiplier)].SetValue<float>(value); } }
        public Controller OwnerOfLastPortalUsed { get { return this[nameof(OwnerOfLastPortalUsed)].As<Controller>(); } set { this["OwnerOfLastPortalUsed"] = value; } }
        public float rotateToUprightSpeed { get { return this[nameof(rotateToUprightSpeed)].GetValue<float>(); } set { this[nameof(rotateToUprightSpeed)].SetValue<float>(value); } }
        public byte DoRep_collisionProfile { get { return this[nameof(DoRep_collisionProfile)].GetValue<byte>(); } set { this[nameof(DoRep_collisionProfile)].SetValue<byte>(value); } }
        public AkAudioEvent TeleportEvent { get { return this[nameof(TeleportEvent)].As<AkAudioEvent>(); } set { this["TeleportEvent"] = value; } }
        public AkAudioEvent LocalPlayerTeleportEvent { get { return this[nameof(LocalPlayerTeleportEvent)].As<AkAudioEvent>(); } set { this["LocalPlayerTeleportEvent"] = value; } }
        public GrenadeLauncher GrenadeLauncher { get { return this[nameof(GrenadeLauncher)].As<GrenadeLauncher>(); } set { this["GrenadeLauncher"] = value; } }
        public Object GrenadeLauncherClass { get { return this[nameof(GrenadeLauncherClass)]; } set { this[nameof(GrenadeLauncherClass)] = value; } }
        public AkAudioEvent ThrowGrenadeEvent { get { return this[nameof(ThrowGrenadeEvent)].As<AkAudioEvent>(); } set { this["ThrowGrenadeEvent"] = value; } }
        public IgnoreMovementCorrections IgnoreServerCorrections { get { return this[nameof(IgnoreServerCorrections)].As<IgnoreMovementCorrections>(); } set { this["IgnoreServerCorrections"] = value; } }
        public float MeleeApplyDmgRange { get { return this[nameof(MeleeApplyDmgRange)].GetValue<float>(); } set { this[nameof(MeleeApplyDmgRange)].SetValue<float>(value); } }
        public float MeleeApplyDmgRangeXY { get { return this[nameof(MeleeApplyDmgRangeXY)].GetValue<float>(); } set { this[nameof(MeleeApplyDmgRangeXY)].SetValue<float>(value); } }
        public float MeleeApplyDmgAngle { get { return this[nameof(MeleeApplyDmgAngle)].GetValue<float>(); } set { this[nameof(MeleeApplyDmgAngle)].SetValue<float>(value); } }
        public float MeleeRange { get { return this[nameof(MeleeRange)].GetValue<float>(); } set { this[nameof(MeleeRange)].SetValue<float>(value); } }
        public float TimeBetweenMelee { get { return this[nameof(TimeBetweenMelee)].GetValue<float>(); } set { this[nameof(TimeBetweenMelee)].SetValue<float>(value); } }
        public float MeleeConeHalfAngle { get { return this[nameof(MeleeConeHalfAngle)].GetValue<float>(); } set { this[nameof(MeleeConeHalfAngle)].SetValue<float>(value); } }
        public float MeleeMaxRotationAngle { get { return this[nameof(MeleeMaxRotationAngle)].GetValue<float>(); } set { this[nameof(MeleeMaxRotationAngle)].SetValue<float>(value); } }
        public Object MeleeDamageType { get { return this[nameof(MeleeDamageType)]; } set { this[nameof(MeleeDamageType)] = value; } }
        public Object MeleeHitCameraShake { get { return this[nameof(MeleeHitCameraShake)]; } set { this[nameof(MeleeHitCameraShake)] = value; } }
        public Object MeleeCameraShake { get { return this[nameof(MeleeCameraShake)]; } set { this[nameof(MeleeCameraShake)] = value; } }
        public bool bIsThrusting { get { return this[nameof(bIsThrusting)].Flag; } set { this[nameof(bIsThrusting)].Flag = value; } }
        public float thrustAmountPerTick { get { return this[nameof(thrustAmountPerTick)].GetValue<float>(); } set { this[nameof(thrustAmountPerTick)].SetValue<float>(value); } }
        public float thrusterVelocityThreshhold { get { return this[nameof(thrusterVelocityThreshhold)].GetValue<float>(); } set { this[nameof(thrusterVelocityThreshhold)].SetValue<float>(value); } }
        public float thrusterRechargeDelay { get { return this[nameof(thrusterRechargeDelay)].GetValue<float>(); } set { this[nameof(thrusterRechargeDelay)].SetValue<float>(value); } }
        public float thrusterTotalTime { get { return this[nameof(thrusterTotalTime)].GetValue<float>(); } set { this[nameof(thrusterTotalTime)].SetValue<float>(value); } }
        public float thrusterCurrentTime { get { return this[nameof(thrusterCurrentTime)].GetValue<float>(); } set { this[nameof(thrusterCurrentTime)].SetValue<float>(value); } }
        public AkAudioEvent JetPackStartEvent { get { return this[nameof(JetPackStartEvent)].As<AkAudioEvent>(); } set { this["JetPackStartEvent"] = value; } }
        public AkAudioEvent JetPackEndEvent { get { return this[nameof(JetPackEndEvent)].As<AkAudioEvent>(); } set { this["JetPackEndEvent"] = value; } }
        public AnimSequence JetpackOpenAnimation { get { return this[nameof(JetpackOpenAnimation)].As<AnimSequence>(); } set { this["JetpackOpenAnimation"] = value; } }
        public AnimSequence JetpackIdleAnimation { get { return this[nameof(JetpackIdleAnimation)].As<AnimSequence>(); } set { this["JetpackIdleAnimation"] = value; } }
        public bool bIsZooming { get { return this[nameof(bIsZooming)].Flag; } set { this[nameof(bIsZooming)].Flag = value; } }
        public float maxTimeOutOfBounds { get { return this[nameof(maxTimeOutOfBounds)].GetValue<float>(); } set { this[nameof(maxTimeOutOfBounds)].SetValue<float>(value); } }
        public float curTimeOutOfBounds { get { return this[nameof(curTimeOutOfBounds)].GetValue<float>(); } set { this[nameof(curTimeOutOfBounds)].SetValue<float>(value); } }
        public AkAudioEvent OutOfBoundsStartEvent { get { return this[nameof(OutOfBoundsStartEvent)].As<AkAudioEvent>(); } set { this["OutOfBoundsStartEvent"] = value; } }
        public AkAudioEvent OutofBoundsEndEvent { get { return this[nameof(OutofBoundsEndEvent)].As<AkAudioEvent>(); } set { this["OutofBoundsEndEvent"] = value; } }
        public PortalWarsAnimInstanceV2 Animation { get { return this[nameof(Animation)].As<PortalWarsAnimInstanceV2>(); } set { this["Animation"] = value; } }
        public AkAudioEvent DeathEvent { get { return this[nameof(DeathEvent)].As<AkAudioEvent>(); } set { this["DeathEvent"] = value; } }
        public AkAudioEvent RespawnEvent { get { return this[nameof(RespawnEvent)].As<AkAudioEvent>(); } set { this["RespawnEvent"] = value; } }
        public AkAudioEvent SprayEvent { get { return this[nameof(SprayEvent)].As<AkAudioEvent>(); } set { this["SprayEvent"] = value; } }
        public AkAudioEvent Footstep3pEvent { get { return this[nameof(Footstep3pEvent)].As<AkAudioEvent>(); } set { this["Footstep3pEvent"] = value; } }
        public AkAudioEvent Footstep1pEvent { get { return this[nameof(Footstep1pEvent)].As<AkAudioEvent>(); } set { this["Footstep1pEvent"] = value; } }
        public AkAudioEvent Land3pEvent { get { return this[nameof(Land3pEvent)].As<AkAudioEvent>(); } set { this["Land3pEvent"] = value; } }
        public AkAudioEvent Land1pEvent { get { return this[nameof(Land1pEvent)].As<AkAudioEvent>(); } set { this["Land1pEvent"] = value; } }
        public AkAudioEvent Jump3pEvent { get { return this[nameof(Jump3pEvent)].As<AkAudioEvent>(); } set { this["Jump3pEvent"] = value; } }
        public AkAudioEvent Jump1pEvent { get { return this[nameof(Jump1pEvent)].As<AkAudioEvent>(); } set { this["Jump1pEvent"] = value; } }
        public PortalWarsAkComponent AkFirstPerson { get { return this[nameof(AkFirstPerson)].As<PortalWarsAkComponent>(); } set { this["AkFirstPerson"] = value; } }
        public PortalWarsAkComponent AkThirdPerson { get { return this[nameof(AkThirdPerson)].As<PortalWarsAkComponent>(); } set { this["AkThirdPerson"] = value; } }
        public PortalWarsAkComponent AkFoot { get { return this[nameof(AkFoot)].As<PortalWarsAkComponent>(); } set { this["AkFoot"] = value; } }
        public PortalWarsAkComponent AkJetPack { get { return this[nameof(AkJetPack)].As<PortalWarsAkComponent>(); } set { this["AkJetPack"] = value; } }
        public PortalWarsAkComponent AkGunLocation { get { return this[nameof(AkGunLocation)].As<PortalWarsAkComponent>(); } set { this["AkGunLocation"] = value; } }
        public PortalWarsAkComponent AkMoveable { get { return this[nameof(AkMoveable)].As<PortalWarsAkComponent>(); } set { this["AkMoveable"] = value; } }
        public AkAudioEvent RespawnCountdownEvent { get { return this[nameof(RespawnCountdownEvent)].As<AkAudioEvent>(); } set { this["RespawnCountdownEvent"] = value; } }
        public AkAudioEvent RespawnCountdownStopEvent { get { return this[nameof(RespawnCountdownStopEvent)].As<AkAudioEvent>(); } set { this["RespawnCountdownStopEvent"] = value; } }
        public float FootstepLoudnessForBots { get { return this[nameof(FootstepLoudnessForBots)].GetValue<float>(); } set { this[nameof(FootstepLoudnessForBots)].SetValue<float>(value); } }
        public float ThrusterLoudnessForBots { get { return this[nameof(ThrusterLoudnessForBots)].GetValue<float>(); } set { this[nameof(ThrusterLoudnessForBots)].SetValue<float>(value); } }
        public PortalWarsIndicatorWidget NameIndicatorWidget { get { return this[nameof(NameIndicatorWidget)].As<PortalWarsIndicatorWidget>(); } set { this["NameIndicatorWidget"] = value; } }
        public PortalWarsRadarMarkerWidget RadarMarkerWidget { get { return this[nameof(RadarMarkerWidget)].As<PortalWarsRadarMarkerWidget>(); } set { this["RadarMarkerWidget"] = value; } }
        public PortalWarsPlayerState LastPlayerState { get { return this[nameof(LastPlayerState)].As<PortalWarsPlayerState>(); } set { this["LastPlayerState"] = value; } }
        public ushort RemotePitch { get { return this[nameof(RemotePitch)].GetValue<ushort>(); } set { this[nameof(RemotePitch)].SetValue<ushort>(value); } }
        public ushort RemoteYaw { get { return this[nameof(RemoteYaw)].GetValue<ushort>(); } set { this[nameof(RemoteYaw)].SetValue<ushort>(value); } }
        public ushort RemoteRoll { get { return this[nameof(RemoteRoll)].GetValue<ushort>(); } set { this[nameof(RemoteRoll)].SetValue<ushort>(value); } }
        public void UpdateSkins() { Invoke(nameof(UpdateSkins)); }
        public void updateCollisionProfiles() { Invoke(nameof(updateCollisionProfiles)); }
        public void StopEmoteInMenu() { Invoke(nameof(StopEmoteInMenu)); }
        public void StopEmote() { Invoke(nameof(StopEmote)); }
        public void SpawnSpray_Multicast(Vector_NetQuantize Location, Rotator Rotation) { Invoke(nameof(SpawnSpray_Multicast), Location, Rotation); }
        public void ServerTeleport(Transform_NetQuantize CharacterTransform_world, Vector_NetQuantize NewVel, Quat NewControlRotation, Portal PortalUsed) { Invoke(nameof(ServerTeleport), CharacterTransform_world, NewVel, NewControlRotation, PortalUsed); }
        public void ServerStartMelee(PortalWarsCharacter InEnemyToMelee, Vector_NetQuantize InVelocity) { Invoke(nameof(ServerStartMelee), InEnemyToMelee, InVelocity); }
        public void ServerSpawnSpray(Vector_NetQuantize Location, Rotator Rotation) { Invoke(nameof(ServerSpawnSpray), Location, Rotation); }
        public void ServerSetZooming(bool bNewZooming) { Invoke(nameof(ServerSetZooming), bNewZooming); }
        public void ServerSetOverlappingPortalCollisionProfiles() { Invoke(nameof(ServerSetOverlappingPortalCollisionProfiles)); }
        public void ServerSetDefaultCollisionProfiles() { Invoke(nameof(ServerSetDefaultCollisionProfiles)); }
        public void ServerRequestSuicide() { Invoke(nameof(ServerRequestSuicide)); }
        public void ServerPlayEmote() { Invoke(nameof(ServerPlayEmote)); }
        public void ServerInterruptEmote() { Invoke(nameof(ServerInterruptEmote)); }
        public void ServerHandleTeabagging(Array<PortalWarsCharacter> deadBodies) { Invoke(nameof(ServerHandleTeabagging), deadBodies); }
        public void ServerFinishMelee(Vector_NetQuantize100 EndingLocation) { Invoke(nameof(ServerFinishMelee), EndingLocation); }
        public void ServerEquipWeapon(Gun NewWeapon) { Invoke(nameof(ServerEquipWeapon), NewWeapon); }
        public void ServerAttemptManualPickup(PortalWarsGunPickup GunPickup, Vector_NetQuantize CurrentWeaponLocation, Vector_NetQuantizeNormal CurrentWeaponRotation) { Invoke(nameof(ServerAttemptManualPickup), GunPickup, CurrentWeaponLocation, CurrentWeaponRotation); }
        public void ServerApplyMeleeDamage(PortalWarsCharacter EnemyToDamage) { Invoke(nameof(ServerApplyMeleeDamage), EnemyToDamage); }
        public void RequestSuicide() { Invoke(nameof(RequestSuicide)); }
        public void PlayMeleeCameraShake() { Invoke(nameof(PlayMeleeCameraShake)); }
        public void PlayEmoteInMenu_Internal() { Invoke(nameof(PlayEmoteInMenu_Internal)); }
        public void PlayEmote_Multicast() { Invoke(nameof(PlayEmote_Multicast)); }
        public void OnSpray() { Invoke(nameof(OnSpray)); }
        public void OnReplayCameraModeChanged(EReplayCameraMode NewReplayCameraMode) { Invoke(nameof(OnReplayCameraModeChanged), NewReplayCameraMode); }
        public void OnRep_PortalGun() { Invoke(nameof(OnRep_PortalGun)); }
        public void OnRep_LastCausedHitInfo() { Invoke(nameof(OnRep_LastCausedHitInfo)); }
        public void OnRep_IsZooming() { Invoke(nameof(OnRep_IsZooming)); }
        public void OnRep_IsThrusting() { Invoke(nameof(OnRep_IsThrusting)); }
        public void OnRep_IsSprinting() { Invoke(nameof(OnRep_IsSprinting)); }
        public void OnRep_Inventory() { Invoke(nameof(OnRep_Inventory)); }
        public void OnRep_IgnoreServerCorrections() { Invoke(nameof(OnRep_IgnoreServerCorrections)); }
        public void OnRep_Health() { Invoke(nameof(OnRep_Health)); }
        public void OnRep_GrenadeLauncher() { Invoke(nameof(OnRep_GrenadeLauncher)); }
        public void OnRep_CurTimeOutOfBounds() { Invoke(nameof(OnRep_CurTimeOutOfBounds)); }
        public void OnRep_CurrentWeapon(Gun LastWeapon) { Invoke(nameof(OnRep_CurrentWeapon), LastWeapon); }
        public void OnKillcamStarted() { Invoke(nameof(OnKillcamStarted)); }
        public void OnKillcamEnded() { Invoke(nameof(OnKillcamEnded)); }
        public void OnGlobalVisionChanged() { Invoke(nameof(OnGlobalVisionChanged)); }
        public void OnGameConfigUpdated() { Invoke(nameof(OnGameConfigUpdated)); }
        public void OnDeath() { Invoke(nameof(OnDeath)); }
        public void OnComponentHit(PrimitiveComponent HitComp, Actor OtherActor, PrimitiveComponent OtherComp, Vector NormalImpulse, HitResult Hit) { Invoke(nameof(OnComponentHit), HitComp, OtherActor, OtherComp, NormalImpulse, Hit); }
        public void MoveAndPostToMoveableAk(AkAudioEvent AkEvent, Vector NewLocation) { Invoke(nameof(MoveAndPostToMoveableAk), AkEvent, NewLocation); }
        public bool IsZooming() { return Invoke<bool>(nameof(IsZooming)); }
        public bool IsThirdPerson() { return Invoke<bool>(nameof(IsThirdPerson)); }
        public bool IsSprinting() { return Invoke<bool>(nameof(IsSprinting)); }
        public bool IsRecentlyRendered(float Threshold) { return Invoke<bool>(nameof(IsRecentlyRendered), Threshold); }
        public bool IsLocallyViewed() { return Invoke<bool>(nameof(IsLocallyViewed)); }
        public bool IsFirstPerson() { return Invoke<bool>(nameof(IsFirstPerson)); }
        public bool IsFiring() { return Invoke<bool>(nameof(IsFiring)); }
        public bool IsEnemyFor(PortalWarsCharacter Character) { return Invoke<bool>(nameof(IsEnemyFor), Character); }
        public bool IsDead() { return Invoke<bool>(nameof(IsDead)); }
        public bool IsAlive() { return Invoke<bool>(nameof(IsAlive)); }
        public void InterruptEmote_Multicast() { Invoke(nameof(InterruptEmote_Multicast)); }
        public Gun GetWeapon() { return Invoke<Gun>(nameof(GetWeapon)); }
        public byte GetTeamNum() { return Invoke<byte>(nameof(GetTeamNum)); }
        public float GetSprintingSpeedModifier() { return Invoke<float>(nameof(GetSprintingSpeedModifier)); }
        public Gun GetSecondaryWeapon() { return Invoke<Gun>(nameof(GetSecondaryWeapon)); }
        public SkeletalMeshComponent getMesh1P() { return Invoke<SkeletalMeshComponent>(nameof(getMesh1P)); }
        public PortalWarsAkComponent GetAkComponent(Object AkName) { return Invoke<PortalWarsAkComponent>(nameof(GetAkComponent), AkName); }
        public Rotator GetAimOffsets() { return Invoke<Rotator>(nameof(GetAimOffsets)); }
        public void DestroyPortals() { Invoke(nameof(DestroyPortals)); }
        public void DelayedServerFinishMelee() { Invoke(nameof(DelayedServerFinishMelee)); }
        public void ClientNotifyAlive(Controller C) { Invoke(nameof(ClientNotifyAlive), C); }
        public void ClientFailedPickupAttempt() { Invoke(nameof(ClientFailedPickupAttempt)); }
        public void ClientEquipWeapon(Gun NewWeapon) { Invoke(nameof(ClientEquipWeapon), NewWeapon); }
        public void ClientDropSpecialItem(SpecialItem SpecialItem) { Invoke(nameof(ClientDropSpecialItem), SpecialItem); }
        public void CheatSuicide() { Invoke(nameof(CheatSuicide)); }
        public void CheatShootAll() { Invoke(nameof(CheatShootAll)); }
        public void CheatProjectiles() { Invoke(nameof(CheatProjectiles)); }
        public void CheatPickup() { Invoke(nameof(CheatPickup)); }
        public void CheatMelee() { Invoke(nameof(CheatMelee)); }
        public void CheatAutoPickup() { Invoke(nameof(CheatAutoPickup)); }
        public void applyShotgunPointImpulsesToCorpseMulticast(Array<PWPointDamageEvent> DamageEvents) { Invoke(nameof(applyShotgunPointImpulsesToCorpseMulticast), DamageEvents); }
        public void applyRadialImpulseToCorpseMulticast(PWRadialDamageEvent RadialDamageEvent) { Invoke(nameof(applyRadialImpulseToCorpseMulticast), RadialDamageEvent); }
        public void applyPointImpulseToCorpseMulticast(PWPointDamageEvent PointDamageEvent) { Invoke(nameof(applyPointImpulseToCorpseMulticast), PointDamageEvent); }
    }
    public class PortalWarsBot : PortalWarsCharacter
    {
        public PortalWarsBot(ulong addr) : base(addr) { }
        public BehaviorTree BotBehavior { get { return this[nameof(BotBehavior)].As<BehaviorTree>(); } set { this["BotBehavior"] = value; } }
        public bool bUseNavRecovery { get { return this[nameof(bUseNavRecovery)].Flag; } set { this[nameof(bUseNavRecovery)].Flag = value; } }
        public ENavRecoveryType NavRecoveryType { get { return (ENavRecoveryType)this[nameof(NavRecoveryType)].GetValue<int>(); } set { this[nameof(NavRecoveryType)].SetValue<int>((int)value); } }
        public NavRecoverySettings NavRecoverySettingsOffMesh { get { return this[nameof(NavRecoverySettingsOffMesh)].As<NavRecoverySettings>(); } set { this["NavRecoverySettingsOffMesh"] = value; } }
        public NavRecoverySettings NavRecoverySettingsOnIslands { get { return this[nameof(NavRecoverySettingsOnIslands)].As<NavRecoverySettings>(); } set { this["NavRecoverySettingsOnIslands"] = value; } }
        public float NavRecoveryMaxLaunchSize { get { return this[nameof(NavRecoveryMaxLaunchSize)].GetValue<float>(); } set { this[nameof(NavRecoveryMaxLaunchSize)].SetValue<float>(value); } }
        public float NavRecoveryMinJumpArc { get { return this[nameof(NavRecoveryMinJumpArc)].GetValue<float>(); } set { this[nameof(NavRecoveryMinJumpArc)].SetValue<float>(value); } }
        public float NavRecoveryMaxJumpArc { get { return this[nameof(NavRecoveryMaxJumpArc)].GetValue<float>(); } set { this[nameof(NavRecoveryMaxJumpArc)].SetValue<float>(value); } }
        public Vector NavRecoveryTestExtent { get { return this[nameof(NavRecoveryTestExtent)].As<Vector>(); } set { this["NavRecoveryTestExtent"] = value; } }
        public float StuckCheckInterval { get { return this[nameof(StuckCheckInterval)].GetValue<float>(); } set { this[nameof(StuckCheckInterval)].SetValue<float>(value); } }
        public float StuckDistanceTolerance { get { return this[nameof(StuckDistanceTolerance)].GetValue<float>(); } set { this[nameof(StuckDistanceTolerance)].SetValue<float>(value); } }
        public float WeaponSelectionFrequency { get { return this[nameof(WeaponSelectionFrequency)].GetValue<float>(); } set { this[nameof(WeaponSelectionFrequency)].SetValue<float>(value); } }
        public float WeaponSelectionCooldown { get { return this[nameof(WeaponSelectionCooldown)].GetValue<float>(); } set { this[nameof(WeaponSelectionCooldown)].SetValue<float>(value); } }
        public BotDebugInfo DebugInfo { get { return this[nameof(DebugInfo)].As<BotDebugInfo>(); } set { this["DebugInfo"] = value; } }
        public void StopWeaponFire() { Invoke(nameof(StopWeaponFire)); }
        public void StartWeaponFire() { Invoke(nameof(StartWeaponFire)); }
    }
    public class PortalWarsCharMovementComponent : CharacterMovementComponent
    {
        public PortalWarsCharMovementComponent(ulong addr) : base(addr) { }
        public PortalWarsCharacter PWCharOwner { get { return this[nameof(PWCharOwner)].As<PortalWarsCharacter>(); } set { this["PWCharOwner"] = value; } }
    }
    public class PortalWarsBotMovementComponent : PortalWarsCharMovementComponent
    {
        public PortalWarsBotMovementComponent(ulong addr) : base(addr) { }
    }
    public class PortalWarsTxnDialogWidget : PortalWarsDialogWidget
    {
        public PortalWarsTxnDialogWidget(ulong addr) : base(addr) { }
        public WidgetSwitcher TransactionSwitcher { get { return this[nameof(TransactionSwitcher)].As<WidgetSwitcher>(); } set { this["TransactionSwitcher"] = value; } }
        public PortalWarsButtonWidget ConfirmButton { get { return this[nameof(ConfirmButton)].As<PortalWarsButtonWidget>(); } set { this["ConfirmButton"] = value; } }
        public TextBlock ProcessingText { get { return this[nameof(ProcessingText)].As<TextBlock>(); } set { this["ProcessingText"] = value; } }
        public TextBlock SuccessText { get { return this[nameof(SuccessText)].As<TextBlock>(); } set { this["SuccessText"] = value; } }
        public void OnTransactionTimedOut() { Invoke(nameof(OnTransactionTimedOut)); }
        public void OnTransactionFailed(ErrorInfo ErrorInfo) { Invoke(nameof(OnTransactionFailed), ErrorInfo); }
        public void OnTransactionCompletedParams(bool bWasSuccessful, ErrorInfo ErrorInfo) { Invoke(nameof(OnTransactionCompletedParams), bWasSuccessful, ErrorInfo); }
        public void OnTransactionCompleted() { Invoke(nameof(OnTransactionCompleted)); }
        public void OnConfirmButtonSelected() { Invoke(nameof(OnConfirmButtonSelected)); }
        public Object GetSuccessText() { return Invoke<Object>(nameof(GetSuccessText)); }
        public Object GetProcessingText() { return Invoke<Object>(nameof(GetProcessingText)); }
        public bool GetConfirmButtonEnabled() { return Invoke<bool>(nameof(GetConfirmButtonEnabled)); }
    }
    public class PortalWarsBPPurchaseDialogWidget : PortalWarsTxnDialogWidget
    {
        public PortalWarsBPPurchaseDialogWidget(ulong addr) : base(addr) { }
        public PanelWidget RewardsPanel { get { return this[nameof(RewardsPanel)].As<PanelWidget>(); } set { this["RewardsPanel"] = value; } }
        public Object RewardEntryWidgetClass { get { return this[nameof(RewardEntryWidgetClass)]; } set { this[nameof(RewardEntryWidgetClass)] = value; } }
        public PortalWarsButtonWidget BuyPremiumButton { get { return this[nameof(BuyPremiumButton)].As<PortalWarsButtonWidget>(); } set { this["BuyPremiumButton"] = value; } }
        public PortalWarsButtonWidget BuyBundleButton { get { return this[nameof(BuyBundleButton)].As<PortalWarsButtonWidget>(); } set { this["BuyBundleButton"] = value; } }
        public PortalWarsButtonWidget BuyLevelsButton { get { return this[nameof(BuyLevelsButton)].As<PortalWarsButtonWidget>(); } set { this["BuyLevelsButton"] = value; } }
        public WidgetSwitcher ActionSwitcher { get { return this[nameof(ActionSwitcher)].As<WidgetSwitcher>(); } set { this["ActionSwitcher"] = value; } }
        public PortalWarsButtonWidget ViewBattlePassButton { get { return this[nameof(ViewBattlePassButton)].As<PortalWarsButtonWidget>(); } set { this["ViewBattlePassButton"] = value; } }
        public void OnViewBattlePassClicked() { Invoke(nameof(OnViewBattlePassClicked)); }
        public void OnBuyPremiumButtonClicked() { Invoke(nameof(OnBuyPremiumButtonClicked)); }
        public void OnBuyLevelsButtonClicked() { Invoke(nameof(OnBuyLevelsButtonClicked)); }
        public void OnBuyBundleButtonClicked() { Invoke(nameof(OnBuyBundleButtonClicked)); }
    }
    public class PortalWarsPurchaseButtonWidget : PortalWarsEntryWidget
    {
        public PortalWarsPurchaseButtonWidget(ulong addr) : base(addr) { }
        public bool bGoToStoreIfNotEnough { get { return this[nameof(bGoToStoreIfNotEnough)].Flag; } set { this[nameof(bGoToStoreIfNotEnough)].Flag = value; } }
        public WidgetSwitcher PurchaseSwitcher { get { return this[nameof(PurchaseSwitcher)].As<WidgetSwitcher>(); } set { this["PurchaseSwitcher"] = value; } }
        public TextBlock CurrencyText { get { return this[nameof(CurrencyText)].As<TextBlock>(); } set { this["CurrencyText"] = value; } }
        public Object GetCurrencyCostText() { return Invoke<Object>(nameof(GetCurrencyCostText)); }
    }
    public class PortalWarsRedeemableButtonWidget : PortalWarsPurchaseButtonWidget
    {
        public PortalWarsRedeemableButtonWidget(ulong addr) : base(addr) { }
        public Image DisplayImage { get { return this[nameof(DisplayImage)].As<Image>(); } set { this["DisplayImage"] = value; } }
        public TextBlock SubtitleText { get { return this[nameof(SubtitleText)].As<TextBlock>(); } set { this["SubtitleText"] = value; } }
        public int RedeemableID { get { return this[nameof(RedeemableID)].GetValue<int>(); } set { this[nameof(RedeemableID)].SetValue<int>(value); } }
    }
    public class PortalWarsBPRedeemableButton : PortalWarsRedeemableButtonWidget
    {
        public PortalWarsBPRedeemableButton(ulong addr) : base(addr) { }
        public bool bChangeBasedOnUser { get { return this[nameof(bChangeBasedOnUser)].Flag; } set { this[nameof(bChangeBasedOnUser)].Flag = value; } }
        public bool bOpenPurchaseDialogWhenClicked { get { return this[nameof(bOpenPurchaseDialogWhenClicked)].Flag; } set { this[nameof(bOpenPurchaseDialogWhenClicked)].Flag = value; } }
        public Object PurchaseDialogWidgetClass { get { return this[nameof(PurchaseDialogWidgetClass)]; } set { this[nameof(PurchaseDialogWidgetClass)] = value; } }
        public void InitUserInfo() { Invoke(nameof(InitUserInfo)); }
    }
    public class PortalWarsButton : Button
    {
        public PortalWarsButton(ulong addr) : base(addr) { }
        public Object OnDoubleClicked { get { return this[nameof(OnDoubleClicked)]; } set { this[nameof(OnDoubleClicked)] = value; } }
        public bool bDebounce { get { return this[nameof(bDebounce)].Flag; } set { this[nameof(bDebounce)].Flag = value; } }
        public float DebounceTime { get { return this[nameof(DebounceTime)].GetValue<float>(); } set { this[nameof(DebounceTime)].SetValue<float>(value); } }
        public AkAudioEvent PressedEvent { get { return this[nameof(PressedEvent)].As<AkAudioEvent>(); } set { this["PressedEvent"] = value; } }
        public AkAudioEvent HoveredEvent { get { return this[nameof(HoveredEvent)].As<AkAudioEvent>(); } set { this["HoveredEvent"] = value; } }
    }
    public class PortalWarsCancelButtonWidget : PortalWarsButtonWidget
    {
        public PortalWarsCancelButtonWidget(ulong addr) : base(addr) { }
        public Image RankIcon { get { return this[nameof(RankIcon)].As<Image>(); } set { this["RankIcon"] = value; } }
        public Widget RankRoot { get { return this[nameof(RankRoot)].As<Widget>(); } set { this["RankRoot"] = value; } }
        public TextBlock QueryTitleText { get { return this[nameof(QueryTitleText)].As<TextBlock>(); } set { this["QueryTitleText"] = value; } }
        public TextBlock QueryDescriptionText { get { return this[nameof(QueryDescriptionText)].As<TextBlock>(); } set { this["QueryDescriptionText"] = value; } }
        public void OnRankIconLoaded() { Invoke(nameof(OnRankIconLoaded)); }
        public void OnClientSessionStateChanged() { Invoke(nameof(OnClientSessionStateChanged)); }
        public Object GetSessionQueryTitleText() { return Invoke<Object>(nameof(GetSessionQueryTitleText)); }
        public Object GetSessionQueryDescriptionText() { return Invoke<Object>(nameof(GetSessionQueryDescriptionText)); }
        public ESlateVisibility GetRankIconVisibility() { return Invoke<ESlateVisibility>(nameof(GetRankIconVisibility)); }
        public Texture2D GetRankIcon() { return Invoke<Texture2D>(nameof(GetRankIcon)); }
    }
    public class PortalWarsCareerWidget : PortalWarsMenuWidget
    {
        public PortalWarsCareerWidget(ulong addr) : base(addr) { }
        public PortalWarsMenuWidget StatsWidget { get { return this[nameof(StatsWidget)].As<PortalWarsMenuWidget>(); } set { this["StatsWidget"] = value; } }
        public PortalWarsButtonWidget StatsButton { get { return this[nameof(StatsButton)].As<PortalWarsButtonWidget>(); } set { this["StatsButton"] = value; } }
        public PortalWarsMenuWidget LeaderboardsWidget { get { return this[nameof(LeaderboardsWidget)].As<PortalWarsMenuWidget>(); } set { this["LeaderboardsWidget"] = value; } }
        public PortalWarsButtonWidget LeaderboardsButton { get { return this[nameof(LeaderboardsButton)].As<PortalWarsButtonWidget>(); } set { this["LeaderboardsButton"] = value; } }
        public PortalWarsMenuWidget ReplaysWidget { get { return this[nameof(ReplaysWidget)].As<PortalWarsMenuWidget>(); } set { this["ReplaysWidget"] = value; } }
        public PortalWarsButtonWidget ReplaysButton { get { return this[nameof(ReplaysButton)].As<PortalWarsButtonWidget>(); } set { this["ReplaysButton"] = value; } }
        public void GoToStatsState() { Invoke(nameof(GoToStatsState)); }
        public void GoToReplaysState() { Invoke(nameof(GoToReplaysState)); }
        public void GoToMainState() { Invoke(nameof(GoToMainState)); }
        public void GoToLeaderboardsState() { Invoke(nameof(GoToLeaderboardsState)); }
    }
    public class PortalWarsChallengeButtonWidget : PortalWarsEntryWidget
    {
        public PortalWarsChallengeButtonWidget(ulong addr) : base(addr) { }
        public EChallengeType ChallengeType { get { return (EChallengeType)this[nameof(ChallengeType)].GetValue<int>(); } set { this[nameof(ChallengeType)].SetValue<int>((int)value); } }
        public int ChallengeGroupId { get { return this[nameof(ChallengeGroupId)].GetValue<int>(); } set { this[nameof(ChallengeGroupId)].SetValue<int>(value); } }
        public TextBlock ChallengeProgressText { get { return this[nameof(ChallengeProgressText)].As<TextBlock>(); } set { this["ChallengeProgressText"] = value; } }
        public ProgressBar ChallengeProgressBar { get { return this[nameof(ChallengeProgressBar)].As<ProgressBar>(); } set { this["ChallengeProgressBar"] = value; } }
        public WidgetSwitcher CompleteIndicatorSwitcher { get { return this[nameof(CompleteIndicatorSwitcher)].As<WidgetSwitcher>(); } set { this["CompleteIndicatorSwitcher"] = value; } }
        public PortalWarsClaimChallengeIndicatorWidget ClaimIndicator { get { return this[nameof(ClaimIndicator)].As<PortalWarsClaimChallengeIndicatorWidget>(); } set { this["ClaimIndicator"] = value; } }
        public TextBlock TimeDescriptionText { get { return this[nameof(TimeDescriptionText)].As<TextBlock>(); } set { this["TimeDescriptionText"] = value; } }
        public TextBlock NoteText { get { return this[nameof(NoteText)].As<TextBlock>(); } set { this["NoteText"] = value; } }
        public Widget NoteRoot { get { return this[nameof(NoteRoot)].As<Widget>(); } set { this["NoteRoot"] = value; } }
        public Image ThumbnailImage { get { return this[nameof(ThumbnailImage)].As<Image>(); } set { this["ThumbnailImage"] = value; } }
        public Texture2D DefaultImage { get { return this[nameof(DefaultImage)].As<Texture2D>(); } set { this["DefaultImage"] = value; } }
        public void UpdateTimeText() { Invoke(nameof(UpdateTimeText)); }
        public ESlateVisibility GetNoteTextVisibility() { return Invoke<ESlateVisibility>(nameof(GetNoteTextVisibility)); }
        public Object GetNoteText() { return Invoke<Object>(nameof(GetNoteText)); }
    }
    public class PortalWarsChallengeEntryWidget : PortalWarsRewardEntryWidget
    {
        public PortalWarsChallengeEntryWidget(ulong addr) : base(addr) { }
        public Widget HoveredIndicator { get { return this[nameof(HoveredIndicator)].As<Widget>(); } set { this["HoveredIndicator"] = value; } }
        public TextBlock ValueText { get { return this[nameof(ValueText)].As<TextBlock>(); } set { this["ValueText"] = value; } }
        public ProgressBar ChallengeProgressBar { get { return this[nameof(ChallengeProgressBar)].As<ProgressBar>(); } set { this["ChallengeProgressBar"] = value; } }
        public Image CompletedImage { get { return this[nameof(CompletedImage)].As<Image>(); } set { this["CompletedImage"] = value; } }
        public PanelWidget StarPanel { get { return this[nameof(StarPanel)].As<PanelWidget>(); } set { this["StarPanel"] = value; } }
        public Texture2D IncompleteStarTexture { get { return this[nameof(IncompleteStarTexture)].As<Texture2D>(); } set { this["IncompleteStarTexture"] = value; } }
        public Texture2D CompleteStarTexture { get { return this[nameof(CompleteStarTexture)].As<Texture2D>(); } set { this["CompleteStarTexture"] = value; } }
        public WidgetSwitcher ChallengeBackgroundSwitcher { get { return this[nameof(ChallengeBackgroundSwitcher)].As<WidgetSwitcher>(); } set { this["ChallengeBackgroundSwitcher"] = value; } }
        public PortalWarsButtonWidget ActionButton { get { return this[nameof(ActionButton)].As<PortalWarsButtonWidget>(); } set { this["ActionButton"] = value; } }
        public WidgetSwitcher ActionSwitcher { get { return this[nameof(ActionSwitcher)].As<WidgetSwitcher>(); } set { this["ActionSwitcher"] = value; } }
        public WidgetAnimation CompletedAnimation { get { return this[nameof(CompletedAnimation)].As<WidgetAnimation>(); } set { this["CompletedAnimation"] = value; } }
        public AkAudioEvent ChallengeCompleteEvent { get { return this[nameof(ChallengeCompleteEvent)].As<AkAudioEvent>(); } set { this["ChallengeCompleteEvent"] = value; } }
        public Object OnClaimButtonClickedDelegate { get { return this[nameof(OnClaimButtonClickedDelegate)]; } set { this[nameof(OnClaimButtonClickedDelegate)] = value; } }
        public Object OnViewButtonClickedDelegate { get { return this[nameof(OnViewButtonClickedDelegate)]; } set { this[nameof(OnViewButtonClickedDelegate)] = value; } }
        public Object OnInspectButtonClickedDelegate { get { return this[nameof(OnInspectButtonClickedDelegate)]; } set { this[nameof(OnInspectButtonClickedDelegate)] = value; } }
        public Widget InspectIndicator { get { return this[nameof(InspectIndicator)].As<Widget>(); } set { this["InspectIndicator"] = value; } }
        public Widget PremiumRequiredRoot { get { return this[nameof(PremiumRequiredRoot)].As<Widget>(); } set { this["PremiumRequiredRoot"] = value; } }
        public bool bIsFeatured { get { return this[nameof(bIsFeatured)].Flag; } set { this[nameof(bIsFeatured)].Flag = value; } }
        public Image FeaturedBackground { get { return this[nameof(FeaturedBackground)].As<Image>(); } set { this["FeaturedBackground"] = value; } }
        public Object FeaturedBackgroundTextures { get { return this[nameof(FeaturedBackgroundTextures)]; } set { this[nameof(FeaturedBackgroundTextures)] = value; } }
        public void OnActionButtonClicked() { Invoke(nameof(OnActionButtonClicked)); }
        public Object GetValueText() { return Invoke<Object>(nameof(GetValueText)); }
        public Object GetTitleText() { return Invoke<Object>(nameof(GetTitleText)); }
        public float GetProgressPercent() { return Invoke<float>(nameof(GetProgressPercent)); }
        public ESlateVisibility GetCompletedVisibility() { return Invoke<ESlateVisibility>(nameof(GetCompletedVisibility)); }
    }
    public class PortalWarsChallengeCompleteEntry : PortalWarsChallengeEntryWidget
    {
        public PortalWarsChallengeCompleteEntry(ulong addr) : base(addr) { }
        public AkComponent AkComp { get { return this[nameof(AkComp)].As<AkComponent>(); } set { this["AkComp"] = value; } }
        public AkAudioEvent ProgressSFXLoop { get { return this[nameof(ProgressSFXLoop)].As<AkAudioEvent>(); } set { this["ProgressSFXLoop"] = value; } }
        public AkAudioEvent ProgressSFXStopLoop { get { return this[nameof(ProgressSFXStopLoop)].As<AkAudioEvent>(); } set { this["ProgressSFXStopLoop"] = value; } }
        public void OnProgressAnimationStarted() { Invoke(nameof(OnProgressAnimationStarted)); }
        public void OnProgressAnimationEnded() { Invoke(nameof(OnProgressAnimationEnded)); }
        public void BroadcastAnimationComplete() { Invoke(nameof(BroadcastAnimationComplete)); }
    }
    public class PortalWarsChallengeDialogWidget : PortalWarsDialogWidget
    {
        public PortalWarsChallengeDialogWidget(ulong addr) : base(addr) { }
        public Object ChallengeEntryWidgetClass { get { return this[nameof(ChallengeEntryWidgetClass)]; } set { this[nameof(ChallengeEntryWidgetClass)] = value; } }
        public Object CompletedChallengeEntryWidgetClass { get { return this[nameof(CompletedChallengeEntryWidgetClass)]; } set { this[nameof(CompletedChallengeEntryWidgetClass)] = value; } }
        public PanelWidget EntriesPanel { get { return this[nameof(EntriesPanel)].As<PanelWidget>(); } set { this["EntriesPanel"] = value; } }
        public Array<PortalWarsChallengeEntryWidget> ChallengeEntries { get { return new Array<PortalWarsChallengeEntryWidget>(this[nameof(ChallengeEntries)].Address); } }
        public void RefreshEntries() { Invoke(nameof(RefreshEntries)); }
        public void ProcessNextChallengeUpdate() { Invoke(nameof(ProcessNextChallengeUpdate)); }
    }
    public class PortalWarsChallengePanelWidget : PortalWarsUserWidget
    {
        public PortalWarsChallengePanelWidget(ulong addr) : base(addr) { }
        public PanelWidget EntriesPanel { get { return this[nameof(EntriesPanel)].As<PanelWidget>(); } set { this["EntriesPanel"] = value; } }
        public Object ChallengeEntryWidgetClass { get { return this[nameof(ChallengeEntryWidgetClass)]; } set { this[nameof(ChallengeEntryWidgetClass)] = value; } }
        public Widget AlmostThereRoot { get { return this[nameof(AlmostThereRoot)].As<Widget>(); } set { this["AlmostThereRoot"] = value; } }
        public PanelWidget AlmostTherePanel { get { return this[nameof(AlmostTherePanel)].As<PanelWidget>(); } set { this["AlmostTherePanel"] = value; } }
        public TextBlock ChallengesDisabledText { get { return this[nameof(ChallengesDisabledText)].As<TextBlock>(); } set { this["ChallengesDisabledText"] = value; } }
        public Overlay ChallengesDisabledRoot { get { return this[nameof(ChallengesDisabledRoot)].As<Overlay>(); } set { this["ChallengesDisabledRoot"] = value; } }
        public PortalWarsButtonWidget ChallengesButton { get { return this[nameof(ChallengesButton)].As<PortalWarsButtonWidget>(); } set { this["ChallengesButton"] = value; } }
        public TextBlock TimeDescriptionText { get { return this[nameof(TimeDescriptionText)].As<TextBlock>(); } set { this["TimeDescriptionText"] = value; } }
        public void UpdateTimeText() { Invoke(nameof(UpdateTimeText)); }
        public void OnProgressionUpdate() { Invoke(nameof(OnProgressionUpdate)); }
        public void OnChallengesButtonClicked() { Invoke(nameof(OnChallengesButtonClicked)); }
        public ESlateVisibility GetChallengesDisabledVisibility() { return Invoke<ESlateVisibility>(nameof(GetChallengesDisabledVisibility)); }
        public Object GetChallengesDisabledText() { return Invoke<Object>(nameof(GetChallengesDisabledText)); }
        public Object GetChallengesButtonTitleText() { return Invoke<Object>(nameof(GetChallengesButtonTitleText)); }
        public bool GetChallengesButtonEnabled() { return Invoke<bool>(nameof(GetChallengesButtonEnabled)); }
    }
    public class PortalWarsChallengesInspectWidget : PortalWarsInspectWidget
    {
        public PortalWarsChallengesInspectWidget(ulong addr) : base(addr) { }
        public Widget ItemsRoot { get { return this[nameof(ItemsRoot)].As<Widget>(); } set { this["ItemsRoot"] = value; } }
        public PortalWarsCustomScrollWidget ItemsPanel { get { return this[nameof(ItemsPanel)].As<PortalWarsCustomScrollWidget>(); } set { this["ItemsPanel"] = value; } }
        public Object ItemEntryWidgetClass { get { return this[nameof(ItemEntryWidgetClass)]; } set { this[nameof(ItemEntryWidgetClass)] = value; } }
        public PortalWarsChallengeEntryWidget ChallengeEntry { get { return this[nameof(ChallengeEntry)].As<PortalWarsChallengeEntryWidget>(); } set { this["ChallengeEntry"] = value; } }
        public void RefreshChallenge() { Invoke(nameof(RefreshChallenge)); }
        public void OnItemEntrySelected(PortalWarsEntryWidget Entry) { Invoke(nameof(OnItemEntrySelected), Entry); }
        public void OnItemEntryScrolledTo(Widget Widget) { Invoke(nameof(OnItemEntryScrolledTo), Widget); }
    }
    public class PortalWarsChallengesSubWidget : PortalWarsMenuWidget
    {
        public PortalWarsChallengesSubWidget(ulong addr) : base(addr) { }
        public Object ChallengeEntryWidgetClass { get { return this[nameof(ChallengeEntryWidgetClass)]; } set { this[nameof(ChallengeEntryWidgetClass)] = value; } }
        public Object FeaturedChallengeEntryWidgetClass { get { return this[nameof(FeaturedChallengeEntryWidgetClass)]; } set { this[nameof(FeaturedChallengeEntryWidgetClass)] = value; } }
        public Object BuyPremiumDialogWidgetClass { get { return this[nameof(BuyPremiumDialogWidgetClass)]; } set { this[nameof(BuyPremiumDialogWidgetClass)] = value; } }
        public PanelWidget EntriesPanel { get { return this[nameof(EntriesPanel)].As<PanelWidget>(); } set { this["EntriesPanel"] = value; } }
        public PanelWidget PremiumEntriesPanel { get { return this[nameof(PremiumEntriesPanel)].As<PanelWidget>(); } set { this["PremiumEntriesPanel"] = value; } }
        public PanelWidget FeaturedEntriesPanel { get { return this[nameof(FeaturedEntriesPanel)].As<PanelWidget>(); } set { this["FeaturedEntriesPanel"] = value; } }
        public PortalWarsChallengesInspectWidget InspectWidget { get { return this[nameof(InspectWidget)].As<PortalWarsChallengesInspectWidget>(); } set { this["InspectWidget"] = value; } }
        public TextBlock TitleText { get { return this[nameof(TitleText)].As<TextBlock>(); } set { this["TitleText"] = value; } }
        public TextBlock TimeDescriptionText { get { return this[nameof(TimeDescriptionText)].As<TextBlock>(); } set { this["TimeDescriptionText"] = value; } }
        public PortalWarsButtonWidget BuyPremiumButton { get { return this[nameof(BuyPremiumButton)].As<PortalWarsButtonWidget>(); } set { this["BuyPremiumButton"] = value; } }
        public EChallengeType ChallengeType { get { return (EChallengeType)this[nameof(ChallengeType)].GetValue<int>(); } set { this[nameof(ChallengeType)].SetValue<int>((int)value); } }
        public int GroupId { get { return this[nameof(GroupId)].GetValue<int>(); } set { this[nameof(GroupId)].SetValue<int>(value); } }
        public void UpdateTimeText() { Invoke(nameof(UpdateTimeText)); }
        public void RefreshPremiumButton() { Invoke(nameof(RefreshPremiumButton)); }
        public void RefreshNewItems() { Invoke(nameof(RefreshNewItems)); }
        public void OnViewButtonClicked(PortalWarsEntryWidget Entry) { Invoke(nameof(OnViewButtonClicked), Entry); }
        public void OnInspectButtonClicked(PortalWarsEntryWidget Entry) { Invoke(nameof(OnInspectButtonClicked), Entry); }
        public void OnClaimChallengeComplete(bool bWasSuccessful, ErrorInfo ErrorInfo) { Invoke(nameof(OnClaimChallengeComplete), bWasSuccessful, ErrorInfo); }
        public void OnClaimButtonClicked(PortalWarsEntryWidget Entry) { Invoke(nameof(OnClaimButtonClicked), Entry); }
        public void OnChallengesUpdate() { Invoke(nameof(OnChallengesUpdate)); }
        public void OnBuyPremiumButtonClicked() { Invoke(nameof(OnBuyPremiumButtonClicked)); }
        public void GoToPhase(byte NewPhase) { Invoke(nameof(GoToPhase), NewPhase); }
        public Object GetTitleText() { return Invoke<Object>(nameof(GetTitleText)); }
        public ESlateVisibility GetTimeVisibility() { return Invoke<ESlateVisibility>(nameof(GetTimeVisibility)); }
        public Object GetTimeDescriptionText() { return Invoke<Object>(nameof(GetTimeDescriptionText)); }
    }
    public class PortalWarsChallengesWidget : PortalWarsMenuWidget
    {
        public PortalWarsChallengesWidget(ulong addr) : base(addr) { }
        public PortalWarsChallengesSubWidget InspectWidget { get { return this[nameof(InspectWidget)].As<PortalWarsChallengesSubWidget>(); } set { this["InspectWidget"] = value; } }
        public PanelWidget WeaponPanel { get { return this[nameof(WeaponPanel)].As<PanelWidget>(); } set { this["WeaponPanel"] = value; } }
        public Object WeaponChallengeButtonWidgetClass { get { return this[nameof(WeaponChallengeButtonWidgetClass)]; } set { this[nameof(WeaponChallengeButtonWidgetClass)] = value; } }
        public Object ChallengeInspectWidgetClasses { get { return this[nameof(ChallengeInspectWidgetClasses)]; } set { this[nameof(ChallengeInspectWidgetClasses)] = value; } }
        public void OnChallengeButtonSelected(PortalWarsEntryWidget Widget) { Invoke(nameof(OnChallengeButtonSelected), Widget); }
        public void GoToMainState() { Invoke(nameof(GoToMainState)); }
        public void GoToInspectState() { Invoke(nameof(GoToInspectState)); }
    }
    public class PortalWarsChatEntryWidget : UserWidget
    {
        public PortalWarsChatEntryWidget(ulong addr) : base(addr) { }
        public TextBlock PlayerNameText { get { return this[nameof(PlayerNameText)].As<TextBlock>(); } set { this["PlayerNameText"] = value; } }
        public Image AvatarImage { get { return this[nameof(AvatarImage)].As<Image>(); } set { this["AvatarImage"] = value; } }
        public Border AvatarBorder { get { return this[nameof(AvatarBorder)].As<Border>(); } set { this["AvatarBorder"] = value; } }
        public TextBlock ChatText { get { return this[nameof(ChatText)].As<TextBlock>(); } set { this["ChatText"] = value; } }
        public TextChatData ChatData { get { return this[nameof(ChatData)].As<TextChatData>(); } set { this["ChatData"] = value; } }
        public void UpdatePlayerInfo() { Invoke(nameof(UpdatePlayerInfo)); }
        public Object GetPlayerNameText() { return Invoke<Object>(nameof(GetPlayerNameText)); }
        public Texture GetPlayerAvatar() { return Invoke<Texture>(nameof(GetPlayerAvatar)); }
        public Object GetChatText() { return Invoke<Object>(nameof(GetChatText)); }
    }
    public class PortalWarsChatWidget : PortalWarsUserWidget
    {
        public PortalWarsChatWidget(ulong addr) : base(addr) { }
        public Widget InputRoot { get { return this[nameof(InputRoot)].As<Widget>(); } set { this["InputRoot"] = value; } }
        public Widget ChatRoot { get { return this[nameof(ChatRoot)].As<Widget>(); } set { this["ChatRoot"] = value; } }
        public TextBlock ChatTypeText { get { return this[nameof(ChatTypeText)].As<TextBlock>(); } set { this["ChatTypeText"] = value; } }
        public LinearColor GeneralChatColor { get { return this[nameof(GeneralChatColor)].As<LinearColor>(); } set { this["GeneralChatColor"] = value; } }
        public LinearColor TeamChatColor { get { return this[nameof(TeamChatColor)].As<LinearColor>(); } set { this["TeamChatColor"] = value; } }
        public EditableText ChatInputBox { get { return this[nameof(ChatInputBox)].As<EditableText>(); } set { this["ChatInputBox"] = value; } }
        public ScrollBox ChatLogPanel { get { return this[nameof(ChatLogPanel)].As<ScrollBox>(); } set { this["ChatLogPanel"] = value; } }
        public Object ChatTextWidgetClass { get { return this[nameof(ChatTextWidgetClass)]; } set { this[nameof(ChatTextWidgetClass)] = value; } }
        public bool bCanCycleChannels { get { return this[nameof(bCanCycleChannels)].Flag; } set { this[nameof(bCanCycleChannels)].Flag = value; } }
        public float TimeToDisplay { get { return this[nameof(TimeToDisplay)].GetValue<float>(); } set { this[nameof(TimeToDisplay)].SetValue<float>(value); } }
        public int NumMaxMessages { get { return this[nameof(NumMaxMessages)].GetValue<int>(); } set { this[nameof(NumMaxMessages)].SetValue<int>(value); } }
        public int MessageCharacterLimit { get { return this[nameof(MessageCharacterLimit)].GetValue<int>(); } set { this[nameof(MessageCharacterLimit)].SetValue<int>(value); } }
        public void ShowChat() { Invoke(nameof(ShowChat)); }
        public void OnChatTextChanged(Object Text) { Invoke(nameof(OnChatTextChanged), Text); }
        public void OnChatInputCommitted(Object Text, byte CommitMethod) { Invoke(nameof(OnChatInputCommitted), Text, CommitMethod); }
        public void HideChat() { Invoke(nameof(HideChat)); }
    }
    public class PortalWarsCheckBox : CheckBox
    {
        public PortalWarsCheckBox(ulong addr) : base(addr) { }
        public AkAudioEvent CheckedEvent { get { return this[nameof(CheckedEvent)].As<AkAudioEvent>(); } set { this["CheckedEvent"] = value; } }
        public AkAudioEvent UncheckedEvent { get { return this[nameof(UncheckedEvent)].As<AkAudioEvent>(); } set { this["UncheckedEvent"] = value; } }
        public AkAudioEvent HoveredEvent { get { return this[nameof(HoveredEvent)].As<AkAudioEvent>(); } set { this["HoveredEvent"] = value; } }
    }
    public class PortalWarsInputWidget : PortalWarsUserWidget
    {
        public PortalWarsInputWidget(ulong addr) : base(addr) { }
        public Object Title { get { return this[nameof(Title)]; } set { this[nameof(Title)] = value; } }
        public TextBlock TitleText { get { return this[nameof(TitleText)].As<TextBlock>(); } set { this["TitleText"] = value; } }
        public LinearColor TitleDefaultColor { get { return this[nameof(TitleDefaultColor)].As<LinearColor>(); } set { this["TitleDefaultColor"] = value; } }
        public LinearColor TitleHoveredColor { get { return this[nameof(TitleHoveredColor)].As<LinearColor>(); } set { this["TitleHoveredColor"] = value; } }
        public TextBlock ValueText { get { return this[nameof(ValueText)].As<TextBlock>(); } set { this["ValueText"] = value; } }
        public LinearColor ValueDefaultColor { get { return this[nameof(ValueDefaultColor)].As<LinearColor>(); } set { this["ValueDefaultColor"] = value; } }
        public LinearColor ValueHoveredColor { get { return this[nameof(ValueHoveredColor)].As<LinearColor>(); } set { this["ValueHoveredColor"] = value; } }
        public Object OnValueChangedDelegate { get { return this[nameof(OnValueChangedDelegate)]; } set { this[nameof(OnValueChangedDelegate)] = value; } }
        public Widget HoveredIndicator { get { return this[nameof(HoveredIndicator)].As<Widget>(); } set { this["HoveredIndicator"] = value; } }
        public Image BackgroundImage { get { return this[nameof(BackgroundImage)].As<Image>(); } set { this["BackgroundImage"] = value; } }
        public Texture2D DefaultBackgroundImage { get { return this[nameof(DefaultBackgroundImage)].As<Texture2D>(); } set { this["DefaultBackgroundImage"] = value; } }
        public Texture2D HoveredBackgroundImage { get { return this[nameof(HoveredBackgroundImage)].As<Texture2D>(); } set { this["HoveredBackgroundImage"] = value; } }
        public Widget ValueRoot { get { return this[nameof(ValueRoot)].As<Widget>(); } set { this["ValueRoot"] = value; } }
        public bool bAdminOnly { get { return this[nameof(bAdminOnly)].Flag; } set { this[nameof(bAdminOnly)].Flag = value; } }
        public bool bCustomOnly { get { return this[nameof(bCustomOnly)].Flag; } set { this[nameof(bCustomOnly)].Flag = value; } }
        public AkAudioEvent ValueChangedEvent { get { return this[nameof(ValueChangedEvent)].As<AkAudioEvent>(); } set { this["ValueChangedEvent"] = value; } }
        public AkAudioEvent HoveredEvent { get { return this[nameof(HoveredEvent)].As<AkAudioEvent>(); } set { this["HoveredEvent"] = value; } }
        public void OnValueChanged() { Invoke(nameof(OnValueChanged)); }
        public void OnAdminReceived() { Invoke(nameof(OnAdminReceived)); }
        public bool IsEnabled() { return Invoke<bool>(nameof(IsEnabled)); }
        public void InitPlayerState() { Invoke(nameof(InitPlayerState)); }
        public ESlateVisibility GetInputVisibility() { return Invoke<ESlateVisibility>(nameof(GetInputVisibility)); }
    }
    public class PortalWarsCheckBoxWidget : PortalWarsInputWidget
    {
        public PortalWarsCheckBoxWidget(ulong addr) : base(addr) { }
        public PortalWarsCheckBox CheckBox { get { return this[nameof(CheckBox)].As<PortalWarsCheckBox>(); } set { this["CheckBox"] = value; } }
        public void OnCheckedStateChanged(bool bIsChecked) { Invoke(nameof(OnCheckedStateChanged), bIsChecked); }
    }
    public class PortalWarsCheckInDialogWidget : PortalWarsTxnDialogWidget
    {
        public PortalWarsCheckInDialogWidget(ulong addr) : base(addr) { }
        public TextBlock CurrencyText { get { return this[nameof(CurrencyText)].As<TextBlock>(); } set { this["CurrencyText"] = value; } }
        public Widget CurrencyRoot { get { return this[nameof(CurrencyRoot)].As<Widget>(); } set { this["CurrencyRoot"] = value; } }
        public TextBlock ActionTitleText { get { return this[nameof(ActionTitleText)].As<TextBlock>(); } set { this["ActionTitleText"] = value; } }
        public PortalWarsCheckInRewardWidget CheckInReward { get { return this[nameof(CheckInReward)].As<PortalWarsCheckInRewardWidget>(); } set { this["CheckInReward"] = value; } }
        public void RefreshRewards() { Invoke(nameof(RefreshRewards)); }
        public ESlateVisibility GetCurrencyVisibility() { return Invoke<ESlateVisibility>(nameof(GetCurrencyVisibility)); }
        public Object GetCurrencyText() { return Invoke<Object>(nameof(GetCurrencyText)); }
        public Object GetActionTitleText() { return Invoke<Object>(nameof(GetActionTitleText)); }
    }
    public class PortalWarsCheckInRewardWidget : PortalWarsRewardEntryWidget
    {
        public PortalWarsCheckInRewardWidget(ulong addr) : base(addr) { }
        public TextBlock DayText { get { return this[nameof(DayText)].As<TextBlock>(); } set { this["DayText"] = value; } }
        public WidgetSwitcher RewardBackgroundSwitcher { get { return this[nameof(RewardBackgroundSwitcher)].As<WidgetSwitcher>(); } set { this["RewardBackgroundSwitcher"] = value; } }
        public Widget MissedIndicator { get { return this[nameof(MissedIndicator)].As<Widget>(); } set { this["MissedIndicator"] = value; } }
        public WidgetAnimation CompletedAnimation { get { return this[nameof(CompletedAnimation)].As<WidgetAnimation>(); } set { this["CompletedAnimation"] = value; } }
        public AkAudioEvent CompleteEvent { get { return this[nameof(CompleteEvent)].As<AkAudioEvent>(); } set { this["CompleteEvent"] = value; } }
        public Object GetDayText() { return Invoke<Object>(nameof(GetDayText)); }
    }
    public class PortalWarsCheckListWidget : PortalWarsInputWidget
    {
        public PortalWarsCheckListWidget(ulong addr) : base(addr) { }
        public Array<Object> DefaultOptions { get { return new Array<Object>(this[nameof(DefaultOptions)].Address); } }
        public PanelWidget CheckBoxPanel { get { return this[nameof(CheckBoxPanel)].As<PanelWidget>(); } set { this["CheckBoxPanel"] = value; } }
        public Object CheckBoxWidgetClass { get { return this[nameof(CheckBoxWidgetClass)]; } set { this[nameof(CheckBoxWidgetClass)] = value; } }
    }
    public class PortalWarsChunkInstallWidget : PortalWarsUserWidget
    {
        public PortalWarsChunkInstallWidget(ulong addr) : base(addr) { }
        public ProgressBar DownloadProgressBar { get { return this[nameof(DownloadProgressBar)].As<ProgressBar>(); } set { this["DownloadProgressBar"] = value; } }
    }
    public class PortalWarsClaimChallengeIndicatorWidget : UserWidget
    {
        public PortalWarsClaimChallengeIndicatorWidget(ulong addr) : base(addr) { }
        public TextBlock ClaimText { get { return this[nameof(ClaimText)].As<TextBlock>(); } set { this["ClaimText"] = value; } }
        public void RefreshWidget() { Invoke(nameof(RefreshWidget)); }
    }
    public class PortalWarsColorPickerWidget : PortalWarsInputWidget
    {
        public PortalWarsColorPickerWidget(ulong addr) : base(addr) { }
        public PortalWarsSpinSliderWidget RedSlider { get { return this[nameof(RedSlider)].As<PortalWarsSpinSliderWidget>(); } set { this["RedSlider"] = value; } }
        public PortalWarsSpinSliderWidget GreenSlider { get { return this[nameof(GreenSlider)].As<PortalWarsSpinSliderWidget>(); } set { this["GreenSlider"] = value; } }
        public PortalWarsSpinSliderWidget BlueSlider { get { return this[nameof(BlueSlider)].As<PortalWarsSpinSliderWidget>(); } set { this["BlueSlider"] = value; } }
        public Widget SliderRoot { get { return this[nameof(SliderRoot)].As<Widget>(); } set { this["SliderRoot"] = value; } }
        public CheckBox SliderToggle { get { return this[nameof(SliderToggle)].As<CheckBox>(); } set { this["SliderToggle"] = value; } }
        public void OnSliderToggleStateChanged(bool bIsChecked) { Invoke(nameof(OnSliderToggleStateChanged), bIsChecked); }
        public ESlateVisibility GetSliderVisibility() { return Invoke<ESlateVisibility>(nameof(GetSliderVisibility)); }
        public LinearColor GetColor() { return Invoke<LinearColor>(nameof(GetColor)); }
    }
    public class PortalWarsComboBoxString : ComboBoxString
    {
        public PortalWarsComboBoxString(ulong addr) : base(addr) { }
        public AkAudioEvent PressedEvent { get { return this[nameof(PressedEvent)].As<AkAudioEvent>(); } set { this["PressedEvent"] = value; } }
        public AkAudioEvent SelectionChangedEvent { get { return this[nameof(SelectionChangedEvent)].As<AkAudioEvent>(); } set { this["SelectionChangedEvent"] = value; } }
    }
    public class PortalWarsControllerPresetWidget : PortalWarsUserWidget
    {
        public PortalWarsControllerPresetWidget(ulong addr) : base(addr) { }
        public Object OnSwapToCustomBindings { get { return this[nameof(OnSwapToCustomBindings)]; } set { this[nameof(OnSwapToCustomBindings)] = value; } }
        public PortalWarsGamepadBindingWidget FaceButtonBottomBinding { get { return this[nameof(FaceButtonBottomBinding)].As<PortalWarsGamepadBindingWidget>(); } set { this["FaceButtonBottomBinding"] = value; } }
        public PortalWarsGamepadBindingWidget FaceButtonTopBinding { get { return this[nameof(FaceButtonTopBinding)].As<PortalWarsGamepadBindingWidget>(); } set { this["FaceButtonTopBinding"] = value; } }
        public PortalWarsGamepadBindingWidget FaceButtonRightBinding { get { return this[nameof(FaceButtonRightBinding)].As<PortalWarsGamepadBindingWidget>(); } set { this["FaceButtonRightBinding"] = value; } }
        public PortalWarsGamepadBindingWidget FaceButtonLeftBinding { get { return this[nameof(FaceButtonLeftBinding)].As<PortalWarsGamepadBindingWidget>(); } set { this["FaceButtonLeftBinding"] = value; } }
        public PortalWarsGamepadBindingWidget RightShoulderBinding { get { return this[nameof(RightShoulderBinding)].As<PortalWarsGamepadBindingWidget>(); } set { this["RightShoulderBinding"] = value; } }
        public PortalWarsGamepadBindingWidget LeftShoulderBinding { get { return this[nameof(LeftShoulderBinding)].As<PortalWarsGamepadBindingWidget>(); } set { this["LeftShoulderBinding"] = value; } }
        public PortalWarsGamepadBindingWidget RightTriggerBinding { get { return this[nameof(RightTriggerBinding)].As<PortalWarsGamepadBindingWidget>(); } set { this["RightTriggerBinding"] = value; } }
        public PortalWarsGamepadBindingWidget LeftTriggerBinding { get { return this[nameof(LeftTriggerBinding)].As<PortalWarsGamepadBindingWidget>(); } set { this["LeftTriggerBinding"] = value; } }
        public PortalWarsGamepadBindingWidget DPadUpBinding { get { return this[nameof(DPadUpBinding)].As<PortalWarsGamepadBindingWidget>(); } set { this["DPadUpBinding"] = value; } }
        public PortalWarsGamepadBindingWidget DPadDownBinding { get { return this[nameof(DPadDownBinding)].As<PortalWarsGamepadBindingWidget>(); } set { this["DPadDownBinding"] = value; } }
        public PortalWarsGamepadBindingWidget DPadRightBinding { get { return this[nameof(DPadRightBinding)].As<PortalWarsGamepadBindingWidget>(); } set { this["DPadRightBinding"] = value; } }
        public PortalWarsGamepadBindingWidget DPadLeftBinding { get { return this[nameof(DPadLeftBinding)].As<PortalWarsGamepadBindingWidget>(); } set { this["DPadLeftBinding"] = value; } }
        public TextBlock SpecialRightText { get { return this[nameof(SpecialRightText)].As<TextBlock>(); } set { this["SpecialRightText"] = value; } }
        public PortalWarsGamepadBindingWidget SpecialLeftBinding { get { return this[nameof(SpecialLeftBinding)].As<PortalWarsGamepadBindingWidget>(); } set { this["SpecialLeftBinding"] = value; } }
        public TextBlock LeftStickText { get { return this[nameof(LeftStickText)].As<TextBlock>(); } set { this["LeftStickText"] = value; } }
        public PortalWarsGamepadBindingWidget LeftStickDownBinding { get { return this[nameof(LeftStickDownBinding)].As<PortalWarsGamepadBindingWidget>(); } set { this["LeftStickDownBinding"] = value; } }
        public TextBlock RightStickText { get { return this[nameof(RightStickText)].As<TextBlock>(); } set { this["RightStickText"] = value; } }
        public PortalWarsGamepadBindingWidget RightStickDownBinding { get { return this[nameof(RightStickDownBinding)].As<PortalWarsGamepadBindingWidget>(); } set { this["RightStickDownBinding"] = value; } }
        public void RebindGamepadKey(Key KeyToBind, Object ChosenAction, bool bToggle) { Invoke(nameof(RebindGamepadKey), KeyToBind, ChosenAction, bToggle); }
        public Object GetSpecialRightText() { return Invoke<Object>(nameof(GetSpecialRightText)); }
        public Object GetSpecialLeftText() { return Invoke<Object>(nameof(GetSpecialLeftText)); }
        public Object GetRightTriggerText() { return Invoke<Object>(nameof(GetRightTriggerText)); }
        public Object GetRightStickText() { return Invoke<Object>(nameof(GetRightStickText)); }
        public Object GetRightStickDownText() { return Invoke<Object>(nameof(GetRightStickDownText)); }
        public Object GetRightShoulderText() { return Invoke<Object>(nameof(GetRightShoulderText)); }
        public Object GetLeftTriggerText() { return Invoke<Object>(nameof(GetLeftTriggerText)); }
        public Object GetLeftStickText() { return Invoke<Object>(nameof(GetLeftStickText)); }
        public Object GetLeftStickDownText() { return Invoke<Object>(nameof(GetLeftStickDownText)); }
        public Object GetLeftShoulderText() { return Invoke<Object>(nameof(GetLeftShoulderText)); }
        public Object GetFaceButtonTopText() { return Invoke<Object>(nameof(GetFaceButtonTopText)); }
        public Object GetFaceButtonRightText() { return Invoke<Object>(nameof(GetFaceButtonRightText)); }
        public Object GetFaceButtonLeftText() { return Invoke<Object>(nameof(GetFaceButtonLeftText)); }
        public Object GetFaceButtonBottomText() { return Invoke<Object>(nameof(GetFaceButtonBottomText)); }
        public Object GetDPadUpText() { return Invoke<Object>(nameof(GetDPadUpText)); }
        public Object GetDPadRightText() { return Invoke<Object>(nameof(GetDPadRightText)); }
        public Object GetDPadLeftText() { return Invoke<Object>(nameof(GetDPadLeftText)); }
        public Object GetDPadDownText() { return Invoke<Object>(nameof(GetDPadDownText)); }
    }
    public class PortalWarsControlSettings : Object
    {
        public PortalWarsControlSettings(ulong addr) : base(addr) { }
    }
    public class PortalWarsControlSettingsWidget : PortalWarsSettingsSubWidget
    {
        public PortalWarsControlSettingsWidget(ulong addr) : base(addr) { }
        public PortalWarsSettingsSubWidget SettingsMenu { get { return this[nameof(SettingsMenu)].As<PortalWarsSettingsSubWidget>(); } set { this["SettingsMenu"] = value; } }
        public PortalWarsSettingsSubWidget ControlsMenu { get { return this[nameof(ControlsMenu)].As<PortalWarsSettingsSubWidget>(); } set { this["ControlsMenu"] = value; } }
    }
    public class PortalWarsCopyButtonWidget : PortalWarsButtonWidget
    {
        public PortalWarsCopyButtonWidget(ulong addr) : base(addr) { }
        public float TimeToDisplayCopiedText { get { return this[nameof(TimeToDisplayCopiedText)].GetValue<float>(); } set { this[nameof(TimeToDisplayCopiedText)].SetValue<float>(value); } }
        public void ResetTitleText() { Invoke(nameof(ResetTitleText)); }
    }
    public class PortalWarsCountdownWidget : UserWidget
    {
        public PortalWarsCountdownWidget(ulong addr) : base(addr) { }
        public TextBlock CountdownText { get { return this[nameof(CountdownText)].As<TextBlock>(); } set { this["CountdownText"] = value; } }
        public WidgetAnimation CountdownAnimation { get { return this[nameof(CountdownAnimation)].As<WidgetAnimation>(); } set { this["CountdownAnimation"] = value; } }
        public TextBlock MapNameText { get { return this[nameof(MapNameText)].As<TextBlock>(); } set { this["MapNameText"] = value; } }
        public TextBlock GameModeNameText { get { return this[nameof(GameModeNameText)].As<TextBlock>(); } set { this["GameModeNameText"] = value; } }
        public TextBlock GameModeDescriptionText { get { return this[nameof(GameModeDescriptionText)].As<TextBlock>(); } set { this["GameModeDescriptionText"] = value; } }
        public TextBlock ScoreText { get { return this[nameof(ScoreText)].As<TextBlock>(); } set { this["ScoreText"] = value; } }
        public TextBlock MinutesText { get { return this[nameof(MinutesText)].As<TextBlock>(); } set { this["MinutesText"] = value; } }
        public TextBlock SeparatorText { get { return this[nameof(SeparatorText)].As<TextBlock>(); } set { this["SeparatorText"] = value; } }
        public void OnGameConfigReceived() { Invoke(nameof(OnGameConfigReceived)); }
        public void NotifyCountdownUpdate(int TimeRemaining) { Invoke(nameof(NotifyCountdownUpdate), TimeRemaining); }
        public void NotifyCountdownStarted() { Invoke(nameof(NotifyCountdownStarted)); }
        public Object GetScoreText() { return Invoke<Object>(nameof(GetScoreText)); }
        public Object GetMinutesText() { return Invoke<Object>(nameof(GetMinutesText)); }
        public Object GetMapNameText() { return Invoke<Object>(nameof(GetMapNameText)); }
        public Object GetGameModeNameText() { return Invoke<Object>(nameof(GetGameModeNameText)); }
        public Object GetGameModeDescriptionText() { return Invoke<Object>(nameof(GetGameModeDescriptionText)); }
    }
    public class PortalWarsCrosshairSelectWidget : PortalWarsInputWidget
    {
        public PortalWarsCrosshairSelectWidget(ulong addr) : base(addr) { }
        public PortalWarsReticleWidget ReticleWidget { get { return this[nameof(ReticleWidget)].As<PortalWarsReticleWidget>(); } set { this["ReticleWidget"] = value; } }
        public PortalWarsComboBoxString CrosshairComboBox { get { return this[nameof(CrosshairComboBox)].As<PortalWarsComboBoxString>(); } set { this["CrosshairComboBox"] = value; } }
        public int WeaponID { get { return this[nameof(WeaponID)].GetValue<int>(); } set { this[nameof(WeaponID)].SetValue<int>(value); } }
        public void OnCrosshairSelectionChanged(Object SelectedItem, byte SelectionType) { Invoke(nameof(OnCrosshairSelectionChanged), SelectedItem, SelectionType); }
    }
    public class PortalWarsCrowd : Actor
    {
        public PortalWarsCrowd(ulong addr) : base(addr) { }
        public PortalWarsAkComponent AkComp { get { return this[nameof(AkComp)].As<PortalWarsAkComponent>(); } set { this["AkComp"] = value; } }
        public AkAudioEvent ReactionEvent { get { return this[nameof(ReactionEvent)].As<AkAudioEvent>(); } set { this["ReactionEvent"] = value; } }
        public AkAudioEvent DisappointedEvent { get { return this[nameof(DisappointedEvent)].As<AkAudioEvent>(); } set { this["DisappointedEvent"] = value; } }
        public AkAudioEvent LaughEvent { get { return this[nameof(LaughEvent)].As<AkAudioEvent>(); } set { this["LaughEvent"] = value; } }
        public AkAudioEvent BooEvent { get { return this[nameof(BooEvent)].As<AkAudioEvent>(); } set { this["BooEvent"] = value; } }
        public AkAudioEvent WinRoundEvent { get { return this[nameof(WinRoundEvent)].As<AkAudioEvent>(); } set { this["WinRoundEvent"] = value; } }
        public AkAudioEvent WinMatchEvent { get { return this[nameof(WinMatchEvent)].As<AkAudioEvent>(); } set { this["WinMatchEvent"] = value; } }
        public AkAudioEvent LoseRoundEvent { get { return this[nameof(LoseRoundEvent)].As<AkAudioEvent>(); } set { this["LoseRoundEvent"] = value; } }
        public Array<AkAudioEvent> KillstreakEvents { get { return new Array<AkAudioEvent>(this[nameof(KillstreakEvents)].Address); } }
        public float DisappointmentThreshold { get { return this[nameof(DisappointmentThreshold)].GetValue<float>(); } set { this[nameof(DisappointmentThreshold)].SetValue<float>(value); } }
        public float DefaultExcitementMultiplier { get { return this[nameof(DefaultExcitementMultiplier)].GetValue<float>(); } set { this[nameof(DefaultExcitementMultiplier)].SetValue<float>(value); } }
        public float MatchPointMultiplier { get { return this[nameof(MatchPointMultiplier)].GetValue<float>(); } set { this[nameof(MatchPointMultiplier)].SetValue<float>(value); } }
        public float MultikillMultiplier { get { return this[nameof(MultikillMultiplier)].GetValue<float>(); } set { this[nameof(MultikillMultiplier)].SetValue<float>(value); } }
        public float KillstreakDenominator { get { return this[nameof(KillstreakDenominator)].GetValue<float>(); } set { this[nameof(KillstreakDenominator)].SetValue<float>(value); } }
    }
    public class PortalWarsCrowdManager : CrowdManager
    {
        public PortalWarsCrowdManager(ulong addr) : base(addr) { }
    }
    public class PortalWarsGameMode : PortalWarsBaseGameMode
    {
        public PortalWarsGameMode(ulong addr) : base(addr) { }
        public Actor LastStartSpot { get { return this[nameof(LastStartSpot)].As<Actor>(); } set { this["LastStartSpot"] = value; } }
        public int KillScore { get { return this[nameof(KillScore)].GetValue<int>(); } set { this[nameof(KillScore)].SetValue<int>(value); } }
        public int AssistScore { get { return this[nameof(AssistScore)].GetValue<int>(); } set { this[nameof(AssistScore)].SetValue<int>(value); } }
        public int DeathScore { get { return this[nameof(DeathScore)].GetValue<int>(); } set { this[nameof(DeathScore)].SetValue<int>(value); } }
        public int SuicideScore { get { return this[nameof(SuicideScore)].GetValue<int>(); } set { this[nameof(SuicideScore)].SetValue<int>(value); } }
        public int FriendlyFireScore { get { return this[nameof(FriendlyFireScore)].GetValue<int>(); } set { this[nameof(FriendlyFireScore)].SetValue<int>(value); } }
        public int TeabagScore { get { return this[nameof(TeabagScore)].GetValue<int>(); } set { this[nameof(TeabagScore)].SetValue<int>(value); } }
        public Array<Object> DefaultInventoryClasses { get { return new Array<Object>(this[nameof(DefaultInventoryClasses)].Address); } }
        public bool bAllowReplayRecording { get { return this[nameof(bAllowReplayRecording)].Flag; } set { this[nameof(bAllowReplayRecording)].Flag = value; } }
        public bool bObjectiveGame { get { return this[nameof(bObjectiveGame)].Flag; } set { this[nameof(bObjectiveGame)].Flag = value; } }
        public Array<Object> RelevantStats { get { return new Array<Object>(this[nameof(RelevantStats)].Address); } }
        public bool IsWinner(PortalWarsPlayerState PlayerState) { return Invoke<bool>(nameof(IsWinner), PlayerState); }
        public bool IsTie(PortalWarsPlayerState PlayerState) { return Invoke<bool>(nameof(IsTie), PlayerState); }
        public int GetPlacement(PortalWarsPlayerState PlayerState) { return Invoke<int>(nameof(GetPlacement), PlayerState); }
        public void ForceEndMatch() { Invoke(nameof(ForceEndMatch)); }
    }
    public class PortalWarsCTF : PortalWarsGameMode
    {
        public PortalWarsCTF(ulong addr) : base(addr) { }
    }
    public class PortalWarsGameState : PortalWarsBaseGameState
    {
        public PortalWarsGameState(ulong addr) : base(addr) { }
        public AnnouncerInterface AnnouncerInterface { get { return this[nameof(AnnouncerInterface)].As<AnnouncerInterface>(); } set { this["AnnouncerInterface"] = value; } }
        public PortalWarsCustomAntiCheat AntiCheat { get { return this[nameof(AntiCheat)].As<PortalWarsCustomAntiCheat>(); } set { this["AntiCheat"] = value; } }
        public bool bTeamGame { get { return this[nameof(bTeamGame)].Flag; } set { this[nameof(bTeamGame)].Flag = value; } }
        public Array<int> TeamScores { get { return new Array<int>(this[nameof(TeamScores)].Address); } }
        public Array<PortalWarsPickup> Pickups { get { return new Array<PortalWarsPickup>(this[nameof(Pickups)].Address); } }
        public Array<OutOfBoundsVolume> OOBVolumes { get { return new Array<OutOfBoundsVolume>(this[nameof(OOBVolumes)].Address); } }
        public PortalWarsCrowd Crowd { get { return this[nameof(Crowd)].As<PortalWarsCrowd>(); } set { this["Crowd"] = value; } }
        public Array<Portal> Portals { get { return new Array<Portal>(this[nameof(Portals)].Address); } }
        public void OnRep_TeamGame() { Invoke(nameof(OnRep_TeamGame)); }
        public void OnRep_Score() { Invoke(nameof(OnRep_Score)); }
        public bool AreEnemyPlayers(PortalWarsCharacter PS1, PortalWarsCharacter PS2) { return Invoke<bool>(nameof(AreEnemyPlayers), PS1, PS2); }
        public bool AreEnemies(PortalWarsPlayerState PS1, PortalWarsPlayerState PS2) { return Invoke<bool>(nameof(AreEnemies), PS1, PS2); }
    }
    public class PortalWarsCTFGameState : PortalWarsGameState
    {
        public PortalWarsCTFGameState(ulong addr) : base(addr) { }
        public Actor AlphaFlag { get { return this[nameof(AlphaFlag)].As<Actor>(); } set { this["AlphaFlag"] = value; } }
        public Actor BravoFlag { get { return this[nameof(BravoFlag)].As<Actor>(); } set { this["BravoFlag"] = value; } }
        public EFlagState AlphaFlagState { get { return (EFlagState)this[nameof(AlphaFlagState)].GetValue<int>(); } set { this[nameof(AlphaFlagState)].SetValue<int>((int)value); } }
        public EFlagState BravoFlagState { get { return (EFlagState)this[nameof(BravoFlagState)].GetValue<int>(); } set { this[nameof(BravoFlagState)].SetValue<int>((int)value); } }
        public float CapturedFlagRespawnTime { get { return this[nameof(CapturedFlagRespawnTime)].GetValue<float>(); } set { this[nameof(CapturedFlagRespawnTime)].SetValue<float>(value); } }
        public void SpawnFlag(byte TeamNum) { Invoke(nameof(SpawnFlag), TeamNum); }
        public void OnRep_BravoFlagState(EFlagState PrevState) { Invoke(nameof(OnRep_BravoFlagState), PrevState); }
        public void OnRep_BravoFlag() { Invoke(nameof(OnRep_BravoFlag)); }
        public void OnRep_AlphaFlagState(EFlagState PrevState) { Invoke(nameof(OnRep_AlphaFlagState), PrevState); }
        public void OnRep_AlphaFlag() { Invoke(nameof(OnRep_AlphaFlag)); }
    }
    public class PortalWarsHUD : HUD
    {
        public PortalWarsHUD(ulong addr) : base(addr) { }
        public PortalWarsRootHUDWidget RootWidget { get { return this[nameof(RootWidget)].As<PortalWarsRootHUDWidget>(); } set { this["RootWidget"] = value; } }
        public Object RootWidgetClass { get { return this[nameof(RootWidgetClass)]; } set { this[nameof(RootWidgetClass)] = value; } }
        public bool bIsCharacterAlive { get { return this[nameof(bIsCharacterAlive)].Flag; } set { this[nameof(bIsCharacterAlive)].Flag = value; } }
        public PortalWarsHUDWidget HUDWidget { get { return this[nameof(HUDWidget)].As<PortalWarsHUDWidget>(); } set { this["HUDWidget"] = value; } }
        public Object HUDWidgetClass { get { return this[nameof(HUDWidgetClass)]; } set { this[nameof(HUDWidgetClass)] = value; } }
        public PortalWarsScoreboardWidget ScoreboardWidget { get { return this[nameof(ScoreboardWidget)].As<PortalWarsScoreboardWidget>(); } set { this["ScoreboardWidget"] = value; } }
        public Object ScoreboardWidgetClass { get { return this[nameof(ScoreboardWidgetClass)]; } set { this[nameof(ScoreboardWidgetClass)] = value; } }
        public PortalWarsEmoteWheelWidget EmoteWheelWidget { get { return this[nameof(EmoteWheelWidget)].As<PortalWarsEmoteWheelWidget>(); } set { this["EmoteWheelWidget"] = value; } }
        public Object EmoteWheelWidgetClass { get { return this[nameof(EmoteWheelWidgetClass)]; } set { this[nameof(EmoteWheelWidgetClass)] = value; } }
        public bool AimingAtEnemy { get { return this[nameof(AimingAtEnemy)].Flag; } set { this[nameof(AimingAtEnemy)].Flag = value; } }
        public PortalWarsChatWidget ChatWidget { get { return this[nameof(ChatWidget)].As<PortalWarsChatWidget>(); } set { this["ChatWidget"] = value; } }
        public Object ChatWidgetClass { get { return this[nameof(ChatWidgetClass)]; } set { this[nameof(ChatWidgetClass)] = value; } }
        public PortalWarsCountdownWidget CountdownWidget { get { return this[nameof(CountdownWidget)].As<PortalWarsCountdownWidget>(); } set { this["CountdownWidget"] = value; } }
        public Object CountdownWidgetClass { get { return this[nameof(CountdownWidgetClass)]; } set { this[nameof(CountdownWidgetClass)] = value; } }
        public PortalWarsMatchResultWidget MatchResultWidget { get { return this[nameof(MatchResultWidget)].As<PortalWarsMatchResultWidget>(); } set { this["MatchResultWidget"] = value; } }
        public Object MatchResultWidgetClass { get { return this[nameof(MatchResultWidgetClass)]; } set { this[nameof(MatchResultWidgetClass)] = value; } }
        public UserWidget MatchCancelledWidget { get { return this[nameof(MatchCancelledWidget)].As<UserWidget>(); } set { this["MatchCancelledWidget"] = value; } }
        public Object MatchCancelledWidgetClass { get { return this[nameof(MatchCancelledWidgetClass)]; } set { this[nameof(MatchCancelledWidgetClass)] = value; } }
        public AkAudioEvent PreGameCountdownEvent { get { return this[nameof(PreGameCountdownEvent)].As<AkAudioEvent>(); } set { this["PreGameCountdownEvent"] = value; } }
        public PortalWarsJoinInProgressWidget JoinInProgressWidget { get { return this[nameof(JoinInProgressWidget)].As<PortalWarsJoinInProgressWidget>(); } set { this["JoinInProgressWidget"] = value; } }
        public Object JoinInProgressWidgetClass { get { return this[nameof(JoinInProgressWidgetClass)]; } set { this[nameof(JoinInProgressWidgetClass)] = value; } }
        public PortalWarsKillcamWidget KillcamWidget { get { return this[nameof(KillcamWidget)].As<PortalWarsKillcamWidget>(); } set { this["KillcamWidget"] = value; } }
        public Object KillcamWidgetClass { get { return this[nameof(KillcamWidgetClass)]; } set { this[nameof(KillcamWidgetClass)] = value; } }
        public PWKillcamTransitionWidget KillcamTransitionWidget { get { return this[nameof(KillcamTransitionWidget)].As<PWKillcamTransitionWidget>(); } set { this["KillcamTransitionWidget"] = value; } }
        public Object KillcamTransitionWidgetClass { get { return this[nameof(KillcamTransitionWidgetClass)]; } set { this[nameof(KillcamTransitionWidgetClass)] = value; } }
        public PortalWarsScreenFadeWidget ScreenFadeWidget { get { return this[nameof(ScreenFadeWidget)].As<PortalWarsScreenFadeWidget>(); } set { this["ScreenFadeWidget"] = value; } }
        public Object ScreenFadeWidgetClass { get { return this[nameof(ScreenFadeWidgetClass)]; } set { this[nameof(ScreenFadeWidgetClass)] = value; } }
        public PWVoiceNotifications VoiceNotificationWidget { get { return this[nameof(VoiceNotificationWidget)].As<PWVoiceNotifications>(); } set { this["VoiceNotificationWidget"] = value; } }
        public Object VoiceNotificationWidgetClass { get { return this[nameof(VoiceNotificationWidgetClass)]; } set { this[nameof(VoiceNotificationWidgetClass)] = value; } }
        public void UpdateChat(TextChatData InData) { Invoke(nameof(UpdateChat), InData); }
        public void ShowScoreboardWidget() { Invoke(nameof(ShowScoreboardWidget)); }
        public void ShowMatchResultWidget() { Invoke(nameof(ShowMatchResultWidget)); }
        public void ShowMatchCancelledWidget() { Invoke(nameof(ShowMatchCancelledWidget)); }
        public void ShowHUDWidget() { Invoke(nameof(ShowHUDWidget)); }
        public void ShowFullScoreboard() { Invoke(nameof(ShowFullScoreboard)); }
        public void ShowFullEmoteWheel() { Invoke(nameof(ShowFullEmoteWheel)); }
        public void ShowEmoteWheelWidget() { Invoke(nameof(ShowEmoteWheelWidget)); }
        public void ShowCountdownWidget() { Invoke(nameof(ShowCountdownWidget)); }
        public void SetMatchResult(bool bIsWinner, bool bIsTie, int Placement) { Invoke(nameof(SetMatchResult), bIsWinner, bIsTie, Placement); }
        public void RemoveScoreboardWidget() { Invoke(nameof(RemoveScoreboardWidget)); }
        public void RemoveMatchResultWidget() { Invoke(nameof(RemoveMatchResultWidget)); }
        public void RemoveMatchCancelledWidget() { Invoke(nameof(RemoveMatchCancelledWidget)); }
        public void RemoveHUDWidget() { Invoke(nameof(RemoveHUDWidget)); }
        public void RemoveEmoteWheelWidget() { Invoke(nameof(RemoveEmoteWheelWidget)); }
        public void RemoveCountdownWidget() { Invoke(nameof(RemoveCountdownWidget)); }
        public void ReceivedMedal(Object MedalName) { Invoke(nameof(ReceivedMedal), MedalName); }
        public void PerformEmoteWheelTask() { Invoke(nameof(PerformEmoteWheelTask)); }
        public void OpenChat() { Invoke(nameof(OpenChat)); }
        public void HideScoreboardWidget() { Invoke(nameof(HideScoreboardWidget)); }
        public void HideHUDWidget() { Invoke(nameof(HideHUDWidget)); }
        public void HideFullScoreboard() { Invoke(nameof(HideFullScoreboard)); }
        public void HideFullEmoteWheel() { Invoke(nameof(HideFullEmoteWheel)); }
        public void HideEmoteWheelWidget() { Invoke(nameof(HideEmoteWheelWidget)); }
    }
    public class PortalWarsCTFHUD : PortalWarsHUD
    {
        public PortalWarsCTFHUD(ulong addr) : base(addr) { }
        public PortalWarsFlagIndicatorWidget AlphaTeamIndicator { get { return this[nameof(AlphaTeamIndicator)].As<PortalWarsFlagIndicatorWidget>(); } set { this["AlphaTeamIndicator"] = value; } }
        public PortalWarsFlagIndicatorWidget BravoTeamIndicator { get { return this[nameof(BravoTeamIndicator)].As<PortalWarsFlagIndicatorWidget>(); } set { this["BravoTeamIndicator"] = value; } }
        public Object FlagIndicatorWidgetClass { get { return this[nameof(FlagIndicatorWidgetClass)]; } set { this[nameof(FlagIndicatorWidgetClass)] = value; } }
        public Object FlagCaptureZoneWidgetClass { get { return this[nameof(FlagCaptureZoneWidgetClass)]; } set { this[nameof(FlagCaptureZoneWidgetClass)] = value; } }
        public PortalWarsCTFHUDOverlayWidget CTFHUDOverlayWidget { get { return this[nameof(CTFHUDOverlayWidget)].As<PortalWarsCTFHUDOverlayWidget>(); } set { this["CTFHUDOverlayWidget"] = value; } }
        public Object CTFHUDOverlayWidgetClass { get { return this[nameof(CTFHUDOverlayWidgetClass)]; } set { this[nameof(CTFHUDOverlayWidgetClass)] = value; } }
    }
    public class PortalWarsCTFHUDOverlayWidget : UserWidget
    {
        public PortalWarsCTFHUDOverlayWidget(ulong addr) : base(addr) { }
        public PortalWarsFlagResetStatusWidget FlagResetStatus { get { return this[nameof(FlagResetStatus)].As<PortalWarsFlagResetStatusWidget>(); } set { this["FlagResetStatus"] = value; } }
    }
    public class PortalWarsPlayerState : PlayerState
    {
        public PortalWarsPlayerState(ulong addr) : base(addr) { }
        public byte TeamNum { get { return this[nameof(TeamNum)].GetValue<byte>(); } set { this[nameof(TeamNum)].SetValue<byte>(value); } }
        public byte KillStreak { get { return this[nameof(KillStreak)].GetValue<byte>(); } set { this[nameof(KillStreak)].SetValue<byte>(value); } }
        public byte MultiKillCounter { get { return this[nameof(MultiKillCounter)].GetValue<byte>(); } set { this[nameof(MultiKillCounter)].SetValue<byte>(value); } }
        public Object DamagePlayers { get { return this[nameof(DamagePlayers)]; } set { this[nameof(DamagePlayers)] = value; } }
        public PlayerStatsInfo_InDepth PlayerStats { get { return this[nameof(PlayerStats)].As<PlayerStatsInfo_InDepth>(); } set { this["PlayerStats"] = value; } }
        public EndGamePlayerInfo PostGameStats { get { return this[nameof(PostGameStats)].As<EndGamePlayerInfo>(); } set { this["PostGameStats"] = value; } }
        public bool bIsAdmin { get { return this[nameof(bIsAdmin)].Flag; } set { this[nameof(bIsAdmin)].Flag = value; } }
        public Array<CustomizationId> PlayerCustomizations { get { return new Array<CustomizationId>(this[nameof(PlayerCustomizations)].Address); } }
        public Array<Object> CachedCustomizationObjects { get { return new Array<Object>(this[nameof(CachedCustomizationObjects)].Address); } }
        public Texture PlayerAvatar { get { return this[nameof(PlayerAvatar)].As<Texture>(); } set { this["PlayerAvatar"] = value; } }
        public Texture SavedPlayerAvatar { get { return this[nameof(SavedPlayerAvatar)].As<Texture>(); } set { this["SavedPlayerAvatar"] = value; } }
        public Texture SavedBotAvatar { get { return this[nameof(SavedBotAvatar)].As<Texture>(); } set { this["SavedBotAvatar"] = value; } }
        public Array<UserRankInfo> PlayerRanks { get { return new Array<UserRankInfo>(this[nameof(PlayerRanks)].Address); } }
        public UserProgressionInfo Progression { get { return this[nameof(Progression)].As<UserProgressionInfo>(); } set { this["Progression"] = value; } }
        public UserDailyStreakInfo DailyStreak { get { return this[nameof(DailyStreak)].As<UserDailyStreakInfo>(); } set { this["DailyStreak"] = value; } }
        public bool bHideNames { get { return this[nameof(bHideNames)].Flag; } set { this[nameof(bHideNames)].Flag = value; } }
        public bool bAnonymousMode { get { return this[nameof(bAnonymousMode)].Flag; } set { this[nameof(bAnonymousMode)].Flag = value; } }
        public bool bPartyChatOnly { get { return this[nameof(bPartyChatOnly)].Flag; } set { this[nameof(bPartyChatOnly)].Flag = value; } }
        public PortalWarsCharacter CachedCharacter { get { return this[nameof(CachedCharacter)].As<PortalWarsCharacter>(); } set { this["CachedCharacter"] = value; } }
        public bool bQuitter { get { return this[nameof(bQuitter)].Flag; } set { this[nameof(bQuitter)].Flag = value; } }
        public int InactiveTime { get { return this[nameof(InactiveTime)].GetValue<int>(); } set { this[nameof(InactiveTime)].SetValue<int>(value); } }
        public bool bJoinedInProgress { get { return this[nameof(bJoinedInProgress)].Flag; } set { this[nameof(bJoinedInProgress)].Flag = value; } }
        public bool bIsFlagged { get { return this[nameof(bIsFlagged)].Flag; } set { this[nameof(bIsFlagged)].Flag = value; } }
        public bool bIsReadyForNextMatch { get { return this[nameof(bIsReadyForNextMatch)].Flag; } set { this[nameof(bIsReadyForNextMatch)].Flag = value; } }
        public BotProfileData DefaultProfile { get { return this[nameof(DefaultProfile)].As<BotProfileData>(); } set { this["DefaultProfile"] = value; } }
        public float SimulatedFOV { get { return this[nameof(SimulatedFOV)].GetValue<float>(); } set { this[nameof(SimulatedFOV)].SetValue<float>(value); } }
        public void SetTeamNum(byte NewTeamNumber) { Invoke(nameof(SetTeamNum), NewTeamNumber); }
        public void SetPlayerAvatar(Texture avatar) { Invoke(nameof(SetPlayerAvatar), avatar); }
        public void OnRep_Team() { Invoke(nameof(OnRep_Team)); }
        public void OnRep_ReadyForNextMatch() { Invoke(nameof(OnRep_ReadyForNextMatch)); }
        public void OnRep_Ranks() { Invoke(nameof(OnRep_Ranks)); }
        public void OnRep_Progression() { Invoke(nameof(OnRep_Progression)); }
        public void OnRep_PlayerStats() { Invoke(nameof(OnRep_PlayerStats)); }
        public void OnRep_PlayerCustomizations() { Invoke(nameof(OnRep_PlayerCustomizations)); }
        public void OnRep_PartyChatOnly() { Invoke(nameof(OnRep_PartyChatOnly)); }
        public void OnRep_MultiKillCounter(byte OldMultiKillCounter) { Invoke(nameof(OnRep_MultiKillCounter), OldMultiKillCounter); }
        public void OnRep_KillStreak(byte OldKillStreak) { Invoke(nameof(OnRep_KillStreak), OldKillStreak); }
        public void OnRep_JoinedInProgress() { Invoke(nameof(OnRep_JoinedInProgress)); }
        public void OnRep_IsFlagged() { Invoke(nameof(OnRep_IsFlagged)); }
        public void OnRep_IsAdmin() { Invoke(nameof(OnRep_IsAdmin)); }
        public void OnRep_DefaultProfile() { Invoke(nameof(OnRep_DefaultProfile)); }
        public void OnRep_DailyStreak() { Invoke(nameof(OnRep_DailyStreak)); }
        public void OnRep_AnonymousMode() { Invoke(nameof(OnRep_AnonymousMode)); }
        public void OnPlayerAvatarLoaded(Texture avatar) { Invoke(nameof(OnPlayerAvatarLoaded), avatar); }
        public void OnDefaultAvatarLoaded() { Invoke(nameof(OnDefaultAvatarLoaded)); }
        public void OnCustomizationsLoaded() { Invoke(nameof(OnCustomizationsLoaded)); }
        public void LoadPlayerAvatar() { Invoke(nameof(LoadPlayerAvatar)); }
        public byte GetTeamNum() { return Invoke<byte>(nameof(GetTeamNum)); }
        public Object GetShortPlayerName() { return Invoke<Object>(nameof(GetShortPlayerName)); }
        public void ClientTriggerEvents(Array<Object> EventNames) { Invoke(nameof(ClientTriggerEvents), EventNames); }
        public void ClientTriggerEvent(Object EventName) { Invoke(nameof(ClientTriggerEvent), EventName); }
        public void ClientReconnected() { Invoke(nameof(ClientReconnected)); }
        public void ClientReceivedMedals(Array<Object> MedalNames) { Invoke(nameof(ClientReceivedMedals), MedalNames); }
        public void ClientReceivedMedal(Object MedalName) { Invoke(nameof(ClientReceivedMedal), MedalName); }
        public void BroadcastDeath_Multicast(PortalWarsPlayerState KillerPlayerState, DamageType KillerDamageType, PortalWarsPlayerState KilledPlayerState, bool bIsHeadshot, bool bThruPortal, float KillerLastTeleportTime, Array<PortalWarsPlayerState> DamagePlayerStates, Array<float> DamagePlayerDamages) { Invoke(nameof(BroadcastDeath_Multicast), KillerPlayerState, KillerDamageType, KilledPlayerState, bIsHeadshot, bThruPortal, KillerLastTeleportTime, DamagePlayerStates, DamagePlayerDamages); }
    }
    public class PortalWarsCTFPlayerState : PortalWarsPlayerState
    {
        public PortalWarsCTFPlayerState(ulong addr) : base(addr) { }
    }
    public class PortalWarsCurrencyPurchaseDialog : PortalWarsTxnDialogWidget
    {
        public PortalWarsCurrencyPurchaseDialog(ulong addr) : base(addr) { }
        public PortalWarsPriceEntryWidget PriceEntry { get { return this[nameof(PriceEntry)].As<PortalWarsPriceEntryWidget>(); } set { this["PriceEntry"] = value; } }
        public TextBlock DescriptionText { get { return this[nameof(DescriptionText)].As<TextBlock>(); } set { this["DescriptionText"] = value; } }
        public Widget BonusHeader { get { return this[nameof(BonusHeader)].As<Widget>(); } set { this["BonusHeader"] = value; } }
        public TextBlock WarningText { get { return this[nameof(WarningText)].As<TextBlock>(); } set { this["WarningText"] = value; } }
        public PortalWarsTextInputWidget CreatorCode { get { return this[nameof(CreatorCode)].As<PortalWarsTextInputWidget>(); } set { this["CreatorCode"] = value; } }
        public PortalWarsCurrencyStoreEntry CurrencyEntry { get { return this[nameof(CurrencyEntry)].As<PortalWarsCurrencyStoreEntry>(); } set { this["CurrencyEntry"] = value; } }
        public ESlateVisibility GetWarningTextVisibility() { return Invoke<ESlateVisibility>(nameof(GetWarningTextVisibility)); }
        public Object GetWarningText() { return Invoke<Object>(nameof(GetWarningText)); }
        public ESlateVisibility GetBonusVisibility() { return Invoke<ESlateVisibility>(nameof(GetBonusVisibility)); }
    }
    public class PortalWarsCurrencyStoreEntry : PortalWarsEntryWidget
    {
        public PortalWarsCurrencyStoreEntry(ulong addr) : base(addr) { }
        public TextBlock CurrencyText { get { return this[nameof(CurrencyText)].As<TextBlock>(); } set { this["CurrencyText"] = value; } }
        public Image DisplayImage { get { return this[nameof(DisplayImage)].As<Image>(); } set { this["DisplayImage"] = value; } }
        public int PurchasableId { get { return this[nameof(PurchasableId)].GetValue<int>(); } set { this[nameof(PurchasableId)].SetValue<int>(value); } }
        public LinearColor DefaultSubtitleColor { get { return this[nameof(DefaultSubtitleColor)].As<LinearColor>(); } set { this["DefaultSubtitleColor"] = value; } }
        public LinearColor HoveredSubtitleColor { get { return this[nameof(HoveredSubtitleColor)].As<LinearColor>(); } set { this["HoveredSubtitleColor"] = value; } }
        public bool bIsFeatured { get { return this[nameof(bIsFeatured)].Flag; } set { this[nameof(bIsFeatured)].Flag = value; } }
        public Object GetTitleText() { return Invoke<Object>(nameof(GetTitleText)); }
    }
    public class PortalWarsItemShopSectionWidget : PortalWarsUserWidget
    {
        public PortalWarsItemShopSectionWidget(ulong addr) : base(addr) { }
        public TextBlock TitleText { get { return this[nameof(TitleText)].As<TextBlock>(); } set { this["TitleText"] = value; } }
        public TextBlock ExpiresInText { get { return this[nameof(ExpiresInText)].As<TextBlock>(); } set { this["ExpiresInText"] = value; } }
        public Object OnItemEntrySelected { get { return this[nameof(OnItemEntrySelected)]; } set { this[nameof(OnItemEntrySelected)] = value; } }
        public Object ItemShopEntryWidgetClasses { get { return this[nameof(ItemShopEntryWidgetClasses)]; } set { this[nameof(ItemShopEntryWidgetClasses)] = value; } }
        public WrapBox ItemsPanel { get { return this[nameof(ItemsPanel)].As<WrapBox>(); } set { this["ItemsPanel"] = value; } }
        public Widget LeftSeparator { get { return this[nameof(LeftSeparator)].As<Widget>(); } set { this["LeftSeparator"] = value; } }
        public Widget RightSeparator { get { return this[nameof(RightSeparator)].As<Widget>(); } set { this["RightSeparator"] = value; } }
        public void RefreshSeparators() { Invoke(nameof(RefreshSeparators)); }
        public void OnEntrySelected(PortalWarsEntryWidget Entry) { Invoke(nameof(OnEntrySelected), Entry); }
        public Object GetTitleText() { return Invoke<Object>(nameof(GetTitleText)); }
        public Object GetExpiresInText() { return Invoke<Object>(nameof(GetExpiresInText)); }
    }
    public class PortalWarsCurrencyStoreWidget : PortalWarsItemShopSectionWidget
    {
        public PortalWarsCurrencyStoreWidget(ulong addr) : base(addr) { }
        public PortalWarsButtonWidget RetryButton { get { return this[nameof(RetryButton)].As<PortalWarsButtonWidget>(); } set { this["RetryButton"] = value; } }
        public WidgetSwitcher StoreSwitcher { get { return this[nameof(StoreSwitcher)].As<WidgetSwitcher>(); } set { this["StoreSwitcher"] = value; } }
        public Array<PortalWarsCurrencyStoreEntry> StoreEntries { get { return new Array<PortalWarsCurrencyStoreEntry>(this[nameof(StoreEntries)].Address); } }
        public Object CurrencyDialogWidgetClass { get { return this[nameof(CurrencyDialogWidgetClass)]; } set { this[nameof(CurrencyDialogWidgetClass)] = value; } }
        public void QueryItemOffers() { Invoke(nameof(QueryItemOffers)); }
    }
    public class PortalWarsCustomAntiCheat : Object
    {
        public PortalWarsCustomAntiCheat(ulong addr) : base(addr) { }
        public Object PlayerViolations { get { return this[nameof(PlayerViolations)]; } set { this[nameof(PlayerViolations)] = value; } }
    }
    public class PortalWarsCustomGameWidget : PortalWarsMenuWidget
    {
        public PortalWarsCustomGameWidget(ulong addr) : base(addr) { }
        public PortalWarsHostMenuWidget HostWidget { get { return this[nameof(HostWidget)].As<PortalWarsHostMenuWidget>(); } set { this["HostWidget"] = value; } }
        public PortalWarsServerBrowserWidget BrowserWidget { get { return this[nameof(BrowserWidget)].As<PortalWarsServerBrowserWidget>(); } set { this["BrowserWidget"] = value; } }
        public bool bUseLAN { get { return this[nameof(bUseLAN)].Flag; } set { this[nameof(bUseLAN)].Flag = value; } }
        public void GoToHostState() { Invoke(nameof(GoToHostState)); }
        public void GoToErrorState() { Invoke(nameof(GoToErrorState)); }
        public void GoToBrowserState() { Invoke(nameof(GoToBrowserState)); }
    }
    public class PortalWarsLobbyWidget : PortalWarsUserWidget
    {
        public PortalWarsLobbyWidget(ulong addr) : base(addr) { }
        public PortalWarsButtonWidget PrevGameStatsButton { get { return this[nameof(PrevGameStatsButton)].As<PortalWarsButtonWidget>(); } set { this["PrevGameStatsButton"] = value; } }
        public Object PostGameStatsWidgetClass { get { return this[nameof(PostGameStatsWidgetClass)]; } set { this[nameof(PostGameStatsWidgetClass)] = value; } }
        public PortalWarsButtonWidget EmoteButton { get { return this[nameof(EmoteButton)].As<PortalWarsButtonWidget>(); } set { this["EmoteButton"] = value; } }
        public PortalWarsButtonWidget SwitchWeaponButton { get { return this[nameof(SwitchWeaponButton)].As<PortalWarsButtonWidget>(); } set { this["SwitchWeaponButton"] = value; } }
        public PortalWarsChatWidget LobbyChat { get { return this[nameof(LobbyChat)].As<PortalWarsChatWidget>(); } set { this["LobbyChat"] = value; } }
        public PanelWidget PlayersPanel { get { return this[nameof(PlayersPanel)].As<PanelWidget>(); } set { this["PlayersPanel"] = value; } }
        public Object LobbyPlayerWidgetClass { get { return this[nameof(LobbyPlayerWidgetClass)]; } set { this[nameof(LobbyPlayerWidgetClass)] = value; } }
        public PortalWarsButtonWidget SaveReplayButton { get { return this[nameof(SaveReplayButton)].As<PortalWarsButtonWidget>(); } set { this["SaveReplayButton"] = value; } }
        public void RefreshSaveReplayButton() { Invoke(nameof(RefreshSaveReplayButton)); }
        public void PopulatePlayersList() { Invoke(nameof(PopulatePlayersList)); }
        public void OnSwitchWeaponButtonClicked() { Invoke(nameof(OnSwitchWeaponButtonClicked)); }
        public void OnSaveReplayButtonClicked() { Invoke(nameof(OnSaveReplayButtonClicked)); }
        public void OnPrevGameStatsUpdated() { Invoke(nameof(OnPrevGameStatsUpdated)); }
        public void OnPrevGameStatsButtonClicked() { Invoke(nameof(OnPrevGameStatsButtonClicked)); }
        public void OnPlayerRemoved(PlayerState PlayerState) { Invoke(nameof(OnPlayerRemoved), PlayerState); }
        public void OnPlayerAdded(PlayerState PlayerState) { Invoke(nameof(OnPlayerAdded), PlayerState); }
        public void OnEmoteButtonClicked() { Invoke(nameof(OnEmoteButtonClicked)); }
        public void HideSpectatorButtons() { Invoke(nameof(HideSpectatorButtons)); }
        public bool GetSaveReplayButtonEnabled() { return Invoke<bool>(nameof(GetSaveReplayButtonEnabled)); }
        public ESlateVisibility GetPrevGameVisibility() { return Invoke<ESlateVisibility>(nameof(GetPrevGameVisibility)); }
    }
    public class PortalWarsCustomLobbyWidget : PortalWarsLobbyWidget
    {
        public PortalWarsCustomLobbyWidget(ulong addr) : base(addr) { }
        public PortalWarsTeamSelectWidget TeamSelector { get { return this[nameof(TeamSelector)].As<PortalWarsTeamSelectWidget>(); } set { this["TeamSelector"] = value; } }
        public PortalWarsButtonWidget StartGameButton { get { return this[nameof(StartGameButton)].As<PortalWarsButtonWidget>(); } set { this["StartGameButton"] = value; } }
        public PortalWarsButtonWidget InviteButton { get { return this[nameof(InviteButton)].As<PortalWarsButtonWidget>(); } set { this["InviteButton"] = value; } }
        public Object InviteDialogWidgetClass { get { return this[nameof(InviteDialogWidgetClass)]; } set { this[nameof(InviteDialogWidgetClass)] = value; } }
        public PanelWidget SettingsPanel { get { return this[nameof(SettingsPanel)].As<PanelWidget>(); } set { this["SettingsPanel"] = value; } }
        public PortalWarsGlobalCarouselWidget MapSelector { get { return this[nameof(MapSelector)].As<PortalWarsGlobalCarouselWidget>(); } set { this["MapSelector"] = value; } }
        public PortalWarsGlobalCarouselWidget ModeSelector { get { return this[nameof(ModeSelector)].As<PortalWarsGlobalCarouselWidget>(); } set { this["ModeSelector"] = value; } }
        public PortalWarsNumericCarouselWidget ScoreLimitSelector { get { return this[nameof(ScoreLimitSelector)].As<PortalWarsNumericCarouselWidget>(); } set { this["ScoreLimitSelector"] = value; } }
        public PortalWarsNumericCarouselWidget TimeLimitSelector { get { return this[nameof(TimeLimitSelector)].As<PortalWarsNumericCarouselWidget>(); } set { this["TimeLimitSelector"] = value; } }
        public PortalWarsNumericCarouselWidget RespawnTimeSelector { get { return this[nameof(RespawnTimeSelector)].As<PortalWarsNumericCarouselWidget>(); } set { this["RespawnTimeSelector"] = value; } }
        public PortalWarsGlobalCarouselWidget PrimaryWeaponSelector { get { return this[nameof(PrimaryWeaponSelector)].As<PortalWarsGlobalCarouselWidget>(); } set { this["PrimaryWeaponSelector"] = value; } }
        public PortalWarsGlobalCarouselWidget SecondaryWeaponSelector { get { return this[nameof(SecondaryWeaponSelector)].As<PortalWarsGlobalCarouselWidget>(); } set { this["SecondaryWeaponSelector"] = value; } }
        public PortalWarsCheckBoxWidget PickupsEnabledCheckBox { get { return this[nameof(PickupsEnabledCheckBox)].As<PortalWarsCheckBoxWidget>(); } set { this["PickupsEnabledCheckBox"] = value; } }
        public PortalWarsCheckBoxWidget BotsEnabledCheckBox { get { return this[nameof(BotsEnabledCheckBox)].As<PortalWarsCheckBoxWidget>(); } set { this["BotsEnabledCheckBox"] = value; } }
        public PortalWarsDifficultySelectWidget BotDifficultySelector { get { return this[nameof(BotDifficultySelector)].As<PortalWarsDifficultySelectWidget>(); } set { this["BotDifficultySelector"] = value; } }
        public PortalWarsCheckBoxWidget BoundariesEnabledCheckBox { get { return this[nameof(BoundariesEnabledCheckBox)].As<PortalWarsCheckBoxWidget>(); } set { this["BoundariesEnabledCheckBox"] = value; } }
        public PortalWarsCheckBoxWidget RadarEnabledCheckBox { get { return this[nameof(RadarEnabledCheckBox)].As<PortalWarsCheckBoxWidget>(); } set { this["RadarEnabledCheckBox"] = value; } }
        public PortalWarsCheckBoxWidget JetpackEnabledCheckBox { get { return this[nameof(JetpackEnabledCheckBox)].As<PortalWarsCheckBoxWidget>(); } set { this["JetpackEnabledCheckBox"] = value; } }
        public PortalWarsCheckBoxWidget SprintEnabledCheckBox { get { return this[nameof(SprintEnabledCheckBox)].As<PortalWarsCheckBoxWidget>(); } set { this["SprintEnabledCheckBox"] = value; } }
        public PortalWarsCheckBoxWidget PortalGunEnabledCheckBox { get { return this[nameof(PortalGunEnabledCheckBox)].As<PortalWarsCheckBoxWidget>(); } set { this["PortalGunEnabledCheckBox"] = value; } }
        public PortalWarsCheckBoxWidget HeadshotsOnlyCheckBox { get { return this[nameof(HeadshotsOnlyCheckBox)].As<PortalWarsCheckBoxWidget>(); } set { this["HeadshotsOnlyCheckBox"] = value; } }
        public PortalWarsCheckBoxWidget BigHeadModeCheckBox { get { return this[nameof(BigHeadModeCheckBox)].As<PortalWarsCheckBoxWidget>(); } set { this["BigHeadModeCheckBox"] = value; } }
        public PortalWarsCheckBoxWidget UnlimitedAmmoCheckBox { get { return this[nameof(UnlimitedAmmoCheckBox)].As<PortalWarsCheckBoxWidget>(); } set { this["UnlimitedAmmoCheckBox"] = value; } }
        public PortalWarsCheckBoxWidget UnlimitedClipSizeCheckBox { get { return this[nameof(UnlimitedClipSizeCheckBox)].As<PortalWarsCheckBoxWidget>(); } set { this["UnlimitedClipSizeCheckBox"] = value; } }
        public PortalWarsCheckBoxWidget RandomHillsEnabledCheckBox { get { return this[nameof(RandomHillsEnabledCheckBox)].As<PortalWarsCheckBoxWidget>(); } set { this["RandomHillsEnabledCheckBox"] = value; } }
        public PortalWarsCheckBoxWidget KillcamEnabledCheckBox { get { return this[nameof(KillcamEnabledCheckBox)].As<PortalWarsCheckBoxWidget>(); } set { this["KillcamEnabledCheckBox"] = value; } }
        public PortalWarsCheckBoxWidget RandomWeaponsCheckBox { get { return this[nameof(RandomWeaponsCheckBox)].As<PortalWarsCheckBoxWidget>(); } set { this["RandomWeaponsCheckBox"] = value; } }
        public PortalWarsDecimalCarouselWidget WalkSpeedModifier { get { return this[nameof(WalkSpeedModifier)].As<PortalWarsDecimalCarouselWidget>(); } set { this["WalkSpeedModifier"] = value; } }
        public PortalWarsDecimalCarouselWidget JumpHeightModifier { get { return this[nameof(JumpHeightModifier)].As<PortalWarsDecimalCarouselWidget>(); } set { this["JumpHeightModifier"] = value; } }
        public PortalWarsDecimalCarouselWidget GravityModifier { get { return this[nameof(GravityModifier)].As<PortalWarsDecimalCarouselWidget>(); } set { this["GravityModifier"] = value; } }
        public PortalWarsDecimalCarouselWidget JetpackFuelModifier { get { return this[nameof(JetpackFuelModifier)].As<PortalWarsDecimalCarouselWidget>(); } set { this["JetpackFuelModifier"] = value; } }
        public PortalWarsDecimalCarouselWidget JetpackBoostModifier { get { return this[nameof(JetpackBoostModifier)].As<PortalWarsDecimalCarouselWidget>(); } set { this["JetpackBoostModifier"] = value; } }
        public PortalWarsDecimalCarouselWidget MeleeDmgModifier { get { return this[nameof(MeleeDmgModifier)].As<PortalWarsDecimalCarouselWidget>(); } set { this["MeleeDmgModifier"] = value; } }
        public PortalWarsDecimalCarouselWidget HealthModifier { get { return this[nameof(HealthModifier)].As<PortalWarsDecimalCarouselWidget>(); } set { this["HealthModifier"] = value; } }
        public WidgetAnimation OpenSettingsAnimation { get { return this[nameof(OpenSettingsAnimation)].As<WidgetAnimation>(); } set { this["OpenSettingsAnimation"] = value; } }
        public PortalWarsButtonWidget MatchOptionsButton { get { return this[nameof(MatchOptionsButton)].As<PortalWarsButtonWidget>(); } set { this["MatchOptionsButton"] = value; } }
        public void UpdateTeam(int TeamNum) { Invoke(nameof(UpdateTeam), TeamNum); }
        public void UpdateGameConfig() { Invoke(nameof(UpdateGameConfig)); }
        public void OnUnlimitedAmmoChanged() { Invoke(nameof(OnUnlimitedAmmoChanged)); }
        public void OnTeamUpdated() { Invoke(nameof(OnTeamUpdated)); }
        public void OnSecondaryWeaponChanged(bool bNext) { Invoke(nameof(OnSecondaryWeaponChanged), bNext); }
        public void OnPrimaryWeaponChanged(bool bNext) { Invoke(nameof(OnPrimaryWeaponChanged), bNext); }
        public void OnPlayerArrayUpdated(PlayerState PS) { Invoke(nameof(OnPlayerArrayUpdated), PS); }
        public void OnModeSelectionChanged() { Invoke(nameof(OnModeSelectionChanged)); }
        public void OnMatchOptionsButtonClicked() { Invoke(nameof(OnMatchOptionsButtonClicked)); }
        public void OnInviteButtonClicked() { Invoke(nameof(OnInviteButtonClicked)); }
        public void OnGameConfigUpdated() { Invoke(nameof(OnGameConfigUpdated)); }
        public void OnAdminReceived() { Invoke(nameof(OnAdminReceived)); }
        public void LaunchGame() { Invoke(nameof(LaunchGame)); }
        public void InitPlayerState() { Invoke(nameof(InitPlayerState)); }
        public ESlateVisibility GetTeamSelectVisibility() { return Invoke<ESlateVisibility>(nameof(GetTeamSelectVisibility)); }
        public ESlateVisibility GetRandomHillsVisibility() { return Invoke<ESlateVisibility>(nameof(GetRandomHillsVisibility)); }
        public ESlateVisibility GetBotsVisibility() { return Invoke<ESlateVisibility>(nameof(GetBotsVisibility)); }
        public ESlateVisibility GetAdminVisibility() { return Invoke<ESlateVisibility>(nameof(GetAdminVisibility)); }
    }
    public class PortalWarsCustomScrollWidget : PortalWarsUserWidget
    {
        public PortalWarsCustomScrollWidget(ulong addr) : base(addr) { }
        public Array<Object> ChildWidgetIds { get { return new Array<Object>(this[nameof(ChildWidgetIds)].Address); } }
        public Object ChildWidgets { get { return this[nameof(ChildWidgets)]; } set { this[nameof(ChildWidgets)] = value; } }
        public Object ChildWidgetClass { get { return this[nameof(ChildWidgetClass)]; } set { this[nameof(ChildWidgetClass)] = value; } }
        public float ScrollDuration { get { return this[nameof(ScrollDuration)].GetValue<float>(); } set { this[nameof(ScrollDuration)].SetValue<float>(value); } }
        public float ScrollDurationDelta { get { return this[nameof(ScrollDurationDelta)].GetValue<float>(); } set { this[nameof(ScrollDurationDelta)].SetValue<float>(value); } }
        public float MinScrollDuration { get { return this[nameof(MinScrollDuration)].GetValue<float>(); } set { this[nameof(MinScrollDuration)].SetValue<float>(value); } }
        public bool bFadeLeftEdge { get { return this[nameof(bFadeLeftEdge)].Flag; } set { this[nameof(bFadeLeftEdge)].Flag = value; } }
        public bool bFadeRightEdge { get { return this[nameof(bFadeRightEdge)].Flag; } set { this[nameof(bFadeRightEdge)].Flag = value; } }
        public float EdgeOpacity { get { return this[nameof(EdgeOpacity)].GetValue<float>(); } set { this[nameof(EdgeOpacity)].SetValue<float>(value); } }
        public float InnerEdgeOpacity { get { return this[nameof(InnerEdgeOpacity)].GetValue<float>(); } set { this[nameof(InnerEdgeOpacity)].SetValue<float>(value); } }
        public bool bWrapAround { get { return this[nameof(bWrapAround)].Flag; } set { this[nameof(bWrapAround)].Flag = value; } }
        public EScrollCenterLocation ScrollCenterLocation { get { return (EScrollCenterLocation)this[nameof(ScrollCenterLocation)].GetValue<int>(); } set { this[nameof(ScrollCenterLocation)].SetValue<int>((int)value); } }
        public int DesiredNumVisible { get { return this[nameof(DesiredNumVisible)].GetValue<int>(); } set { this[nameof(DesiredNumVisible)].SetValue<int>(value); } }
        public PanelWidget ChildPanel { get { return this[nameof(ChildPanel)].As<PanelWidget>(); } set { this["ChildPanel"] = value; } }
        public byte ChildHorizontalAlignment { get { return this[nameof(ChildHorizontalAlignment)].GetValue<byte>(); } set { this[nameof(ChildHorizontalAlignment)].SetValue<byte>(value); } }
        public byte ChildVerticalAlignment { get { return this[nameof(ChildVerticalAlignment)].GetValue<byte>(); } set { this[nameof(ChildVerticalAlignment)].SetValue<byte>(value); } }
        public PortalWarsButton PrevButton { get { return this[nameof(PrevButton)].As<PortalWarsButton>(); } set { this["PrevButton"] = value; } }
        public PortalWarsButton NextButton { get { return this[nameof(NextButton)].As<PortalWarsButton>(); } set { this["NextButton"] = value; } }
        public WidgetSwitcher ScrollSwitcher { get { return this[nameof(ScrollSwitcher)].As<WidgetSwitcher>(); } set { this["ScrollSwitcher"] = value; } }
        public ScrollBox ScrollBox { get { return this[nameof(ScrollBox)].As<ScrollBox>(); } set { this["ScrollBox"] = value; } }
        public void ScrollToPrev() { Invoke(nameof(ScrollToPrev)); }
        public void ScrollToNext() { Invoke(nameof(ScrollToNext)); }
    }
    public class PortalWarsDailyCheckInWidget : PortalWarsMenuWidget
    {
        public PortalWarsDailyCheckInWidget(ulong addr) : base(addr) { }
        public PanelWidget RewardPanel { get { return this[nameof(RewardPanel)].As<PanelWidget>(); } set { this["RewardPanel"] = value; } }
        public PortalWarsCheckInRewardWidget Day7Reward { get { return this[nameof(Day7Reward)].As<PortalWarsCheckInRewardWidget>(); } set { this["Day7Reward"] = value; } }
        public WidgetSwitcher ActionSwitcher { get { return this[nameof(ActionSwitcher)].As<WidgetSwitcher>(); } set { this["ActionSwitcher"] = value; } }
        public PortalWarsButtonWidget ClaimButton { get { return this[nameof(ClaimButton)].As<PortalWarsButtonWidget>(); } set { this["ClaimButton"] = value; } }
        public PortalWarsRedeemableButtonWidget RepairButton { get { return this[nameof(RepairButton)].As<PortalWarsRedeemableButtonWidget>(); } set { this["RepairButton"] = value; } }
        public Object CheckInDialogWidgetClass { get { return this[nameof(CheckInDialogWidgetClass)]; } set { this[nameof(CheckInDialogWidgetClass)] = value; } }
        public TextBlock CurrentDayText { get { return this[nameof(CurrentDayText)].As<TextBlock>(); } set { this["CurrentDayText"] = value; } }
        public void RefreshEntries() { Invoke(nameof(RefreshEntries)); }
        public void OnRepairButtonClicked() { Invoke(nameof(OnRepairButtonClicked)); }
        public void OnClaimCheckinComplete(bool bWasSuccessful, ErrorInfo ErrorInfo) { Invoke(nameof(OnClaimCheckinComplete), bWasSuccessful, ErrorInfo); }
        public void OnClaimButtonClicked() { Invoke(nameof(OnClaimButtonClicked)); }
        public void OnCheckInUpdate() { Invoke(nameof(OnCheckInUpdate)); }
        public Object GetCurrentWeekText() { return Invoke<Object>(nameof(GetCurrentWeekText)); }
        public Object GetCurrentDayText() { return Invoke<Object>(nameof(GetCurrentDayText)); }
    }
    public class PortalWarsDailyPlayStreakWidget : PortalWarsMenuWidget
    {
        public PortalWarsDailyPlayStreakWidget(ulong addr) : base(addr) { }
        public PanelWidget RewardPanel { get { return this[nameof(RewardPanel)].As<PanelWidget>(); } set { this["RewardPanel"] = value; } }
        public Object PlayStreakRewardWidgetClass { get { return this[nameof(PlayStreakRewardWidgetClass)]; } set { this[nameof(PlayStreakRewardWidgetClass)] = value; } }
        public PortalWarsProgressionIconWidget StreakIcon { get { return this[nameof(StreakIcon)].As<PortalWarsProgressionIconWidget>(); } set { this["StreakIcon"] = value; } }
        public TextBlock PlayStreakBoostText { get { return this[nameof(PlayStreakBoostText)].As<TextBlock>(); } set { this["PlayStreakBoostText"] = value; } }
        public TextBlock PlayStreakPromptText { get { return this[nameof(PlayStreakPromptText)].As<TextBlock>(); } set { this["PlayStreakPromptText"] = value; } }
        public TextBlock RepairStreakText { get { return this[nameof(RepairStreakText)].As<TextBlock>(); } set { this["RepairStreakText"] = value; } }
        public WidgetSwitcher ActionSwitcher { get { return this[nameof(ActionSwitcher)].As<WidgetSwitcher>(); } set { this["ActionSwitcher"] = value; } }
        public PortalWarsRedeemableButtonWidget RepairButton { get { return this[nameof(RepairButton)].As<PortalWarsRedeemableButtonWidget>(); } set { this["RepairButton"] = value; } }
        public Object PlayStreakDialogWidgetClass { get { return this[nameof(PlayStreakDialogWidgetClass)]; } set { this[nameof(PlayStreakDialogWidgetClass)] = value; } }
        public void RefreshEntries() { Invoke(nameof(RefreshEntries)); }
        public void OnRepairButtonClicked() { Invoke(nameof(OnRepairButtonClicked)); }
        public void OnPlayStreakUpdate() { Invoke(nameof(OnPlayStreakUpdate)); }
        public Object GetRepairStreakText() { return Invoke<Object>(nameof(GetRepairStreakText)); }
        public Object GetPlayStreakPromptText() { return Invoke<Object>(nameof(GetPlayStreakPromptText)); }
        public Object GetPlayStreakBoostText() { return Invoke<Object>(nameof(GetPlayStreakBoostText)); }
    }
    public class PortalWarsDamageIndicatorWidget : UserWidget
    {
        public PortalWarsDamageIndicatorWidget(ulong addr) : base(addr) { }
        public Image HitImage { get { return this[nameof(HitImage)].As<Image>(); } set { this["HitImage"] = value; } }
        public MaterialInterface ThruPortalMaterial { get { return this[nameof(ThruPortalMaterial)].As<MaterialInterface>(); } set { this["ThruPortalMaterial"] = value; } }
    }
    public class PortalWarsDamageNumberEntryWidget : UserWidget
    {
        public PortalWarsDamageNumberEntryWidget(ulong addr) : base(addr) { }
        public WidgetAnimation FadeInAnimation { get { return this[nameof(FadeInAnimation)].As<WidgetAnimation>(); } set { this["FadeInAnimation"] = value; } }
        public WidgetAnimation FadeOutAnimation { get { return this[nameof(FadeOutAnimation)].As<WidgetAnimation>(); } set { this["FadeOutAnimation"] = value; } }
        public TextBlock DamageText { get { return this[nameof(DamageText)].As<TextBlock>(); } set { this["DamageText"] = value; } }
        public LinearColor GetDamageColor() { return Invoke<LinearColor>(nameof(GetDamageColor)); }
    }
    public class PortalWarsDamageType : DamageType
    {
        public PortalWarsDamageType(ulong addr) : base(addr) { }
        public Texture2D KillIcon { get { return this[nameof(KillIcon)].As<Texture2D>(); } set { this["KillIcon"] = value; } }
        public ForceFeedbackEffect HitForceFeedback { get { return this[nameof(HitForceFeedback)].As<ForceFeedbackEffect>(); } set { this["HitForceFeedback"] = value; } }
        public ForceFeedbackEffect KilledForceFeedback { get { return this[nameof(KilledForceFeedback)].As<ForceFeedbackEffect>(); } set { this["KilledForceFeedback"] = value; } }
        public Object Weapon { get { return this[nameof(Weapon)]; } set { this[nameof(Weapon)] = value; } }
    }
    public class PortalWarsInputCarouselWidget : PortalWarsInputWidget
    {
        public PortalWarsInputCarouselWidget(ulong addr) : base(addr) { }
        public Button LeftButton { get { return this[nameof(LeftButton)].As<Button>(); } set { this["LeftButton"] = value; } }
        public Button RightButton { get { return this[nameof(RightButton)].As<Button>(); } set { this["RightButton"] = value; } }
        public PortalWarsButtonWidget LeftGamepadButton { get { return this[nameof(LeftGamepadButton)].As<PortalWarsButtonWidget>(); } set { this["LeftGamepadButton"] = value; } }
        public PortalWarsButtonWidget RightGamepadButton { get { return this[nameof(RightGamepadButton)].As<PortalWarsButtonWidget>(); } set { this["RightGamepadButton"] = value; } }
        public Object OnCarouselValueChangedDelegate { get { return this[nameof(OnCarouselValueChangedDelegate)]; } set { this[nameof(OnCarouselValueChangedDelegate)] = value; } }
        public WidgetSwitcher ConsoleSwitcher { get { return this[nameof(ConsoleSwitcher)].As<WidgetSwitcher>(); } set { this["ConsoleSwitcher"] = value; } }
        public void OnPrevValue() { Invoke(nameof(OnPrevValue)); }
        public void OnNextValue() { Invoke(nameof(OnNextValue)); }
    }
    public class PortalWarsDecimalCarouselWidget : PortalWarsInputCarouselWidget
    {
        public PortalWarsDecimalCarouselWidget(ulong addr) : base(addr) { }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
        public float MinValue { get { return this[nameof(MinValue)].GetValue<float>(); } set { this[nameof(MinValue)].SetValue<float>(value); } }
        public float MaxValue { get { return this[nameof(MaxValue)].GetValue<float>(); } set { this[nameof(MaxValue)].SetValue<float>(value); } }
        public float StepSize { get { return this[nameof(StepSize)].GetValue<float>(); } set { this[nameof(StepSize)].SetValue<float>(value); } }
        public SpinBox SpinBox { get { return this[nameof(SpinBox)].As<SpinBox>(); } set { this["SpinBox"] = value; } }
        public void OnSpinBoxValueCommitted(float NewValue, byte CommitType) { Invoke(nameof(OnSpinBoxValueCommitted), NewValue, CommitType); }
    }
    public class PortalWarsNumericCarouselWidget : PortalWarsInputCarouselWidget
    {
        public PortalWarsNumericCarouselWidget(ulong addr) : base(addr) { }
        public int Value { get { return this[nameof(Value)].GetValue<int>(); } set { this[nameof(Value)].SetValue<int>(value); } }
        public int MinValue { get { return this[nameof(MinValue)].GetValue<int>(); } set { this[nameof(MinValue)].SetValue<int>(value); } }
        public int MaxValue { get { return this[nameof(MaxValue)].GetValue<int>(); } set { this[nameof(MaxValue)].SetValue<int>(value); } }
        public int StepSize { get { return this[nameof(StepSize)].GetValue<int>(); } set { this[nameof(StepSize)].SetValue<int>(value); } }
        public bool bAllowWrap { get { return this[nameof(bAllowWrap)].Flag; } set { this[nameof(bAllowWrap)].Flag = value; } }
        public TextBlock ConsoleValueText { get { return this[nameof(ConsoleValueText)].As<TextBlock>(); } set { this["ConsoleValueText"] = value; } }
        public IntegerSpinBox SpinBox { get { return this[nameof(SpinBox)].As<IntegerSpinBox>(); } set { this["SpinBox"] = value; } }
        public bool bDisplayAsTime { get { return this[nameof(bDisplayAsTime)].Flag; } set { this[nameof(bDisplayAsTime)].Flag = value; } }
        public void OnSpinBoxValueCommitted(int NewValue, byte CommitType) { Invoke(nameof(OnSpinBoxValueCommitted), NewValue, CommitType); }
    }
    public class PortalWarsDifficultySelectWidget : PortalWarsNumericCarouselWidget
    {
        public PortalWarsDifficultySelectWidget(ulong addr) : base(addr) { }
    }
    public class PortalWarsDiscardSettingsDialog : PortalWarsDialogWidget
    {
        public PortalWarsDiscardSettingsDialog(ulong addr) : base(addr) { }
        public PortalWarsButtonWidget AcceptButton { get { return this[nameof(AcceptButton)].As<PortalWarsButtonWidget>(); } set { this["AcceptButton"] = value; } }
        public void OnAcceptButtonClicked() { Invoke(nameof(OnAcceptButtonClicked)); }
    }
    public class PortalWarsDiscordRpcUtils : Object
    {
        public PortalWarsDiscordRpcUtils(ulong addr) : base(addr) { }
        public void OnConnect() { Invoke(nameof(OnConnect)); }
    }
    public class PortalWarsDOMControlledHillWidget : UserWidget
    {
        public PortalWarsDOMControlledHillWidget(ulong addr) : base(addr) { }
        public TextBlock HillLetterText { get { return this[nameof(HillLetterText)].As<TextBlock>(); } set { this["HillLetterText"] = value; } }
        public Image HillImage { get { return this[nameof(HillImage)].As<Image>(); } set { this["HillImage"] = value; } }
        public float PaddingBetweenEntries { get { return this[nameof(PaddingBetweenEntries)].GetValue<float>(); } set { this[nameof(PaddingBetweenEntries)].SetValue<float>(value); } }
    }
    public class PortalWarsDOMGameState : PortalWarsGameState
    {
        public PortalWarsDOMGameState(ulong addr) : base(addr) { }
        public Array<DominationHill> Hills { get { return new Array<DominationHill>(this[nameof(Hills)].Address); } }
    }
    public class PortalWarsIndicatorWidget : UserWidget
    {
        public PortalWarsIndicatorWidget(ulong addr) : base(addr) { }
        public float UpdateInterval { get { return this[nameof(UpdateInterval)].GetValue<float>(); } set { this[nameof(UpdateInterval)].SetValue<float>(value); } }
        public float EdgePercentage { get { return this[nameof(EdgePercentage)].GetValue<float>(); } set { this[nameof(EdgePercentage)].SetValue<float>(value); } }
        public WidgetSwitcher IndicatorSwitcher { get { return this[nameof(IndicatorSwitcher)].As<WidgetSwitcher>(); } set { this["IndicatorSwitcher"] = value; } }
    }
    public class PortalWarsHillIndicatorWidget : PortalWarsIndicatorWidget
    {
        public PortalWarsHillIndicatorWidget(ulong addr) : base(addr) { }
        public Widget Pointer { get { return this[nameof(Pointer)].As<Widget>(); } set { this["Pointer"] = value; } }
        public TextBlock OnScreenNameText { get { return this[nameof(OnScreenNameText)].As<TextBlock>(); } set { this["OnScreenNameText"] = value; } }
        public TextBlock OffScreenNameText { get { return this[nameof(OffScreenNameText)].As<TextBlock>(); } set { this["OffScreenNameText"] = value; } }
        public Texture2D NeutralBackground { get { return this[nameof(NeutralBackground)].As<Texture2D>(); } set { this["NeutralBackground"] = value; } }
        public Texture2D RedBackground { get { return this[nameof(RedBackground)].As<Texture2D>(); } set { this["RedBackground"] = value; } }
        public Texture2D BlueBackground { get { return this[nameof(BlueBackground)].As<Texture2D>(); } set { this["BlueBackground"] = value; } }
        public void SetControllingTeam(int NewControllingTeam) { Invoke(nameof(SetControllingTeam), NewControllingTeam); }
        public Texture2D GetIndicatorBackground() { return Invoke<Texture2D>(nameof(GetIndicatorBackground)); }
        public Object GetHillName() { return Invoke<Object>(nameof(GetHillName)); }
    }
    public class PortalWarsDOMHillIndicator : PortalWarsHillIndicatorWidget
    {
        public PortalWarsDOMHillIndicator(ulong addr) : base(addr) { }
        public float DisplayCaptureProgress { get { return this[nameof(DisplayCaptureProgress)].GetValue<float>(); } set { this[nameof(DisplayCaptureProgress)].SetValue<float>(value); } }
        public ProgressBar OnScreenProgressBar { get { return this[nameof(OnScreenProgressBar)].As<ProgressBar>(); } set { this["OnScreenProgressBar"] = value; } }
        public ProgressBar OffScreenProgressBar { get { return this[nameof(OffScreenProgressBar)].As<ProgressBar>(); } set { this["OffScreenProgressBar"] = value; } }
    }
    public class PortalWarsDOMHillStatusWidget : UserWidget
    {
        public PortalWarsDOMHillStatusWidget(ulong addr) : base(addr) { }
        public ProgressBar HillProgressBar { get { return this[nameof(HillProgressBar)].As<ProgressBar>(); } set { this["HillProgressBar"] = value; } }
        public Image OutlineImage { get { return this[nameof(OutlineImage)].As<Image>(); } set { this["OutlineImage"] = value; } }
        public TextBlock HillLetterText { get { return this[nameof(HillLetterText)].As<TextBlock>(); } set { this["HillLetterText"] = value; } }
        public TextBlock HillStatusText { get { return this[nameof(HillStatusText)].As<TextBlock>(); } set { this["HillStatusText"] = value; } }
        public HorizontalBox RootHorizontalBox { get { return this[nameof(RootHorizontalBox)].As<HorizontalBox>(); } set { this["RootHorizontalBox"] = value; } }
        public WidgetAnimation RotateAnimation { get { return this[nameof(RotateAnimation)].As<WidgetAnimation>(); } set { this["RotateAnimation"] = value; } }
        public Texture2D BlueHillImage { get { return this[nameof(BlueHillImage)].As<Texture2D>(); } set { this["BlueHillImage"] = value; } }
        public Texture2D WhiteHillImage { get { return this[nameof(WhiteHillImage)].As<Texture2D>(); } set { this["WhiteHillImage"] = value; } }
        public Texture2D RedHillImage { get { return this[nameof(RedHillImage)].As<Texture2D>(); } set { this["RedHillImage"] = value; } }
        public Texture2D BlueFillImage { get { return this[nameof(BlueFillImage)].As<Texture2D>(); } set { this["BlueFillImage"] = value; } }
        public Texture2D RedFillImage { get { return this[nameof(RedFillImage)].As<Texture2D>(); } set { this["RedFillImage"] = value; } }
    }
    public class PortalWarsDOMHUD : PortalWarsHUD
    {
        public PortalWarsDOMHUD(ulong addr) : base(addr) { }
        public Object HillIndicatorWidgetClass { get { return this[nameof(HillIndicatorWidgetClass)]; } set { this[nameof(HillIndicatorWidgetClass)] = value; } }
        public PortalWarsDOMHUDOverlayWidget DOMHUDOverlayWidget { get { return this[nameof(DOMHUDOverlayWidget)].As<PortalWarsDOMHUDOverlayWidget>(); } set { this["DOMHUDOverlayWidget"] = value; } }
        public Object DOMHUDOverlayWidgetClass { get { return this[nameof(DOMHUDOverlayWidgetClass)]; } set { this[nameof(DOMHUDOverlayWidgetClass)] = value; } }
    }
    public class PortalWarsDOMHUDOverlayWidget : UserWidget
    {
        public PortalWarsDOMHUDOverlayWidget(ulong addr) : base(addr) { }
        public PortalWarsDOMHillStatusWidget DOMHillStatus { get { return this[nameof(DOMHillStatus)].As<PortalWarsDOMHillStatusWidget>(); } set { this["DOMHillStatus"] = value; } }
        public HorizontalBox TopHills { get { return this[nameof(TopHills)].As<HorizontalBox>(); } set { this["TopHills"] = value; } }
        public HorizontalBox BottomHills { get { return this[nameof(BottomHills)].As<HorizontalBox>(); } set { this["BottomHills"] = value; } }
        public Object ControlledHillWidgetClass { get { return this[nameof(ControlledHillWidgetClass)]; } set { this[nameof(ControlledHillWidgetClass)] = value; } }
    }
    public class PortalWarsDomination : PortalWarsGameMode
    {
        public PortalWarsDomination(ulong addr) : base(addr) { }
        public int HillTeamScore { get { return this[nameof(HillTeamScore)].GetValue<int>(); } set { this[nameof(HillTeamScore)].SetValue<int>(value); } }
        public int HillCaptureScore { get { return this[nameof(HillCaptureScore)].GetValue<int>(); } set { this[nameof(HillCaptureScore)].SetValue<int>(value); } }
        public int HillNeutralizeScore { get { return this[nameof(HillNeutralizeScore)].GetValue<int>(); } set { this[nameof(HillNeutralizeScore)].SetValue<int>(value); } }
    }
    public class PortalWarsDOMPlayerState : PortalWarsPlayerState
    {
        public PortalWarsDOMPlayerState(ulong addr) : base(addr) { }
    }
    public class PortalWarsDropdownWidget : PortalWarsInputWidget
    {
        public PortalWarsDropdownWidget(ulong addr) : base(addr) { }
        public Array<Object> DefaultOptions { get { return new Array<Object>(this[nameof(DefaultOptions)].Address); } }
        public int DefaultIndex { get { return this[nameof(DefaultIndex)].GetValue<int>(); } set { this[nameof(DefaultIndex)].SetValue<int>(value); } }
        public ComboBoxString ComboBox { get { return this[nameof(ComboBox)].As<ComboBoxString>(); } set { this["ComboBox"] = value; } }
        public void OnSelectionChanged(Object SelectedItem, byte SelectionType) { Invoke(nameof(OnSelectionChanged), SelectedItem, SelectionType); }
    }
    public class PortalWarsDropIndicatorWidget : UserWidget
    {
        public PortalWarsDropIndicatorWidget(ulong addr) : base(addr) { }
        public TextBlock DropsText { get { return this[nameof(DropsText)].As<TextBlock>(); } set { this["DropsText"] = value; } }
        public bool bHideWhenEmpty { get { return this[nameof(bHideWhenEmpty)].Flag; } set { this[nameof(bHideWhenEmpty)].Flag = value; } }
        public void RefreshWidget() { Invoke(nameof(RefreshWidget)); }
    }
    public class PortalWarsDropsMenuWidget : PortalWarsMenuWidget
    {
        public PortalWarsDropsMenuWidget(ulong addr) : base(addr) { }
        public TextBlock DropsText { get { return this[nameof(DropsText)].As<TextBlock>(); } set { this["DropsText"] = value; } }
        public PortalWarsButtonWidget OpenButton { get { return this[nameof(OpenButton)].As<PortalWarsButtonWidget>(); } set { this["OpenButton"] = value; } }
        public WidgetSwitcher ActionSwitcher { get { return this[nameof(ActionSwitcher)].As<WidgetSwitcher>(); } set { this["ActionSwitcher"] = value; } }
        public void RefreshWidget() { Invoke(nameof(RefreshWidget)); }
        public void OnOpenButtonClicked() { Invoke(nameof(OnOpenButtonClicked)); }
    }
    public class PortalWarsDummy : PortalWarsCharacter
    {
        public PortalWarsDummy(ulong addr) : base(addr) { }
    }
    public class PortalWarsDummyAIController : AIController
    {
        public PortalWarsDummyAIController(ulong addr) : base(addr) { }
    }
    public class PortalWarsEmoteWheelSpinnerWidget : UserWidget
    {
        public PortalWarsEmoteWheelSpinnerWidget(ulong addr) : base(addr) { }
    }
    public class PortalWarsEmoteWheelWedgeWidget : UserWidget
    {
        public PortalWarsEmoteWheelWedgeWidget(ulong addr) : base(addr) { }
        public Image ActionIcon { get { return this[nameof(ActionIcon)].As<Image>(); } set { this["ActionIcon"] = value; } }
        public TextBlock ActionText { get { return this[nameof(ActionText)].As<TextBlock>(); } set { this["ActionText"] = value; } }
        public EWedgeType WedgeType { get { return (EWedgeType)this[nameof(WedgeType)].GetValue<int>(); } set { this[nameof(WedgeType)].SetValue<int>((int)value); } }
        public Texture WeaponInspectTexture { get { return this[nameof(WeaponInspectTexture)].As<Texture>(); } set { this["WeaponInspectTexture"] = value; } }
        public float StartAngle { get { return this[nameof(StartAngle)].GetValue<float>(); } set { this[nameof(StartAngle)].SetValue<float>(value); } }
        public float EndAngle { get { return this[nameof(EndAngle)].GetValue<float>(); } set { this[nameof(EndAngle)].SetValue<float>(value); } }
        public Image WedgeImage { get { return this[nameof(WedgeImage)].As<Image>(); } set { this["WedgeImage"] = value; } }
        public Texture InactiveTexture { get { return this[nameof(InactiveTexture)].As<Texture>(); } set { this["InactiveTexture"] = value; } }
        public Texture ActiveTexture { get { return this[nameof(ActiveTexture)].As<Texture>(); } set { this["ActiveTexture"] = value; } }
        public void RefreshWidget() { Invoke(nameof(RefreshWidget)); }
        public Object GetActionText() { return Invoke<Object>(nameof(GetActionText)); }
    }
    public class PortalWarsEmoteWheelWidget : PortalWarsUserWidget
    {
        public PortalWarsEmoteWheelWidget(ulong addr) : base(addr) { }
        public CanvasPanel EmoteWheelRoot { get { return this[nameof(EmoteWheelRoot)].As<CanvasPanel>(); } set { this["EmoteWheelRoot"] = value; } }
        public float SpinnerDistance { get { return this[nameof(SpinnerDistance)].GetValue<float>(); } set { this[nameof(SpinnerDistance)].SetValue<float>(value); } }
        public float MinSelectDistance { get { return this[nameof(MinSelectDistance)].GetValue<float>(); } set { this[nameof(MinSelectDistance)].SetValue<float>(value); } }
        public PortalWarsEmoteWheelSpinnerWidget EmoteWheelSpinner { get { return this[nameof(EmoteWheelSpinner)].As<PortalWarsEmoteWheelSpinnerWidget>(); } set { this["EmoteWheelSpinner"] = value; } }
        public Array<PortalWarsEmoteWheelWedgeWidget> Wedges { get { return new Array<PortalWarsEmoteWheelWedgeWidget>(this[nameof(Wedges)].Address); } }
        public PortalWarsEmoteWheelWedgeWidget SelectedWedge { get { return this[nameof(SelectedWedge)].As<PortalWarsEmoteWheelWedgeWidget>(); } set { this["SelectedWedge"] = value; } }
        public PortalWarsEmoteWheelWedgeWidget PrevSelectedWedge { get { return this[nameof(PrevSelectedWedge)].As<PortalWarsEmoteWheelWedgeWidget>(); } set { this["PrevSelectedWedge"] = value; } }
        public AkAudioEvent ClosedEvent { get { return this[nameof(ClosedEvent)].As<AkAudioEvent>(); } set { this["ClosedEvent"] = value; } }
        public AkAudioEvent HoveredEvent { get { return this[nameof(HoveredEvent)].As<AkAudioEvent>(); } set { this["HoveredEvent"] = value; } }
        public void RefreshControllerLocation() { Invoke(nameof(RefreshControllerLocation)); }
    }
    public class PortalWarsEnvironmentActor : Actor
    {
        public PortalWarsEnvironmentActor(ulong addr) : base(addr) { }
        public void EditorInit() { Invoke(nameof(EditorInit)); }
    }
    public class PortalWarsMenuSelectWidget : PortalWarsDialogWidget
    {
        public PortalWarsMenuSelectWidget(ulong addr) : base(addr) { }
        public TextBlock HoveredEntryText { get { return this[nameof(HoveredEntryText)].As<TextBlock>(); } set { this["HoveredEntryText"] = value; } }
        public Widget HoveredEntryRoot { get { return this[nameof(HoveredEntryRoot)].As<Widget>(); } set { this["HoveredEntryRoot"] = value; } }
        public PanelWidget NavPanel { get { return this[nameof(NavPanel)].As<PanelWidget>(); } set { this["NavPanel"] = value; } }
        public void OnEntryUnhovered(PortalWarsEntryWidget Entry) { Invoke(nameof(OnEntryUnhovered), Entry); }
        public void OnEntryHovered(PortalWarsEntryWidget Entry) { Invoke(nameof(OnEntryHovered), Entry); }
        public ESlateVisibility GetHoveredEntryVisibility() { return Invoke<ESlateVisibility>(nameof(GetHoveredEntryVisibility)); }
        public Object GetHoveredEntryText() { return Invoke<Object>(nameof(GetHoveredEntryText)); }
    }
    public class PortalWarsEscapeMenuWidget : PortalWarsMenuSelectWidget
    {
        public PortalWarsEscapeMenuWidget(ulong addr) : base(addr) { }
        public PortalWarsButtonWidget RewardCenterButton { get { return this[nameof(RewardCenterButton)].As<PortalWarsButtonWidget>(); } set { this["RewardCenterButton"] = value; } }
        public PortalWarsButtonWidget SettingsButton { get { return this[nameof(SettingsButton)].As<PortalWarsButtonWidget>(); } set { this["SettingsButton"] = value; } }
        public PortalWarsButtonWidget RedeemCodeButton { get { return this[nameof(RedeemCodeButton)].As<PortalWarsButtonWidget>(); } set { this["RedeemCodeButton"] = value; } }
        public PortalWarsButtonWidget SwitchProfileButton { get { return this[nameof(SwitchProfileButton)].As<PortalWarsButtonWidget>(); } set { this["SwitchProfileButton"] = value; } }
        public PortalWarsButtonWidget LeavePartyButton { get { return this[nameof(LeavePartyButton)].As<PortalWarsButtonWidget>(); } set { this["LeavePartyButton"] = value; } }
        public PortalWarsButtonWidget ExitButton { get { return this[nameof(ExitButton)].As<PortalWarsButtonWidget>(); } set { this["ExitButton"] = value; } }
        public Object SettingsDialogWidgetClass { get { return this[nameof(SettingsDialogWidgetClass)]; } set { this[nameof(SettingsDialogWidgetClass)] = value; } }
        public Object RedeemKeyDialogWidgetClass { get { return this[nameof(RedeemKeyDialogWidgetClass)]; } set { this[nameof(RedeemKeyDialogWidgetClass)] = value; } }
        public Object QuitGameDialogWidgetClass { get { return this[nameof(QuitGameDialogWidgetClass)]; } set { this[nameof(QuitGameDialogWidgetClass)] = value; } }
        public void OnSettingsButtonClicked() { Invoke(nameof(OnSettingsButtonClicked)); }
        public void OnRewardCenterButtonClicked() { Invoke(nameof(OnRewardCenterButtonClicked)); }
        public void OnRedeemButtonClicked() { Invoke(nameof(OnRedeemButtonClicked)); }
        public void OnProfileSwitchedClicked() { Invoke(nameof(OnProfileSwitchedClicked)); }
        public void OnPartyUpdate() { Invoke(nameof(OnPartyUpdate)); }
        public void OnLeavePartyButtonClicked() { Invoke(nameof(OnLeavePartyButtonClicked)); }
        public void OnExitButtonClicked() { Invoke(nameof(OnExitButtonClicked)); }
    }
    public class PortalWarsFiesta : PortalWarsGameMode
    {
        public PortalWarsFiesta(ulong addr) : base(addr) { }
    }
    public class PortalWarsFlagIndicatorWidget : PortalWarsIndicatorWidget
    {
        public PortalWarsFlagIndicatorWidget(ulong addr) : base(addr) { }
        public Widget Pointer { get { return this[nameof(Pointer)].As<Widget>(); } set { this["Pointer"] = value; } }
        public Texture2D NeutralBackground { get { return this[nameof(NeutralBackground)].As<Texture2D>(); } set { this["NeutralBackground"] = value; } }
        public Texture2D RedBackground { get { return this[nameof(RedBackground)].As<Texture2D>(); } set { this["RedBackground"] = value; } }
        public Texture2D BlueBackground { get { return this[nameof(BlueBackground)].As<Texture2D>(); } set { this["BlueBackground"] = value; } }
        public ProgressBar OnScreenProgressBar { get { return this[nameof(OnScreenProgressBar)].As<ProgressBar>(); } set { this["OnScreenProgressBar"] = value; } }
        public ProgressBar OffScreenProgressBar { get { return this[nameof(OffScreenProgressBar)].As<ProgressBar>(); } set { this["OffScreenProgressBar"] = value; } }
        public float DisplayResetProgress { get { return this[nameof(DisplayResetProgress)].GetValue<float>(); } set { this[nameof(DisplayResetProgress)].SetValue<float>(value); } }
        public void SetControllingTeam(int NewControllingTeam) { Invoke(nameof(SetControllingTeam), NewControllingTeam); }
        public void InitIndicatorBackground() { Invoke(nameof(InitIndicatorBackground)); }
        public Texture2D GetIndicatorBackground() { return Invoke<Texture2D>(nameof(GetIndicatorBackground)); }
    }
    public class PortalWarsFlagResetStatusWidget : UserWidget
    {
        public PortalWarsFlagResetStatusWidget(ulong addr) : base(addr) { }
        public ProgressBar FlagProgressBar { get { return this[nameof(FlagProgressBar)].As<ProgressBar>(); } set { this["FlagProgressBar"] = value; } }
        public Image OutlineImage { get { return this[nameof(OutlineImage)].As<Image>(); } set { this["OutlineImage"] = value; } }
        public WidgetAnimation RotateAnimation { get { return this[nameof(RotateAnimation)].As<WidgetAnimation>(); } set { this["RotateAnimation"] = value; } }
        public Texture2D BlueOutlineImage { get { return this[nameof(BlueOutlineImage)].As<Texture2D>(); } set { this["BlueOutlineImage"] = value; } }
        public Texture2D RedOutlineImage { get { return this[nameof(RedOutlineImage)].As<Texture2D>(); } set { this["RedOutlineImage"] = value; } }
        public Texture2D BlueFillImage { get { return this[nameof(BlueFillImage)].As<Texture2D>(); } set { this["BlueFillImage"] = value; } }
        public Texture2D RedFillImage { get { return this[nameof(RedFillImage)].As<Texture2D>(); } set { this["RedFillImage"] = value; } }
    }
    public class PortalWarsFlagZoneIndicator : PortalWarsIndicatorWidget
    {
        public PortalWarsFlagZoneIndicator(ulong addr) : base(addr) { }
        public Widget Pointer { get { return this[nameof(Pointer)].As<Widget>(); } set { this["Pointer"] = value; } }
    }
    public class PortalWarsForcedTeleportTrigger : TriggerBox
    {
        public PortalWarsForcedTeleportTrigger(ulong addr) : base(addr) { }
        public PortalWall TargetPortalWall { get { return this[nameof(TargetPortalWall)].As<PortalWall>(); } set { this["TargetPortalWall"] = value; } }
        public void EndOverlap(PrimitiveComponent OverlappedComponent, Actor OtherActor, PrimitiveComponent OtherComp, int OtherBodyIndex) { Invoke(nameof(EndOverlap), OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex); }
        public void BeginOverlap(PrimitiveComponent OverlappedComponent, Actor OtherActor, PrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, HitResult SweepResult) { Invoke(nameof(BeginOverlap), OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult); }
    }
    public class PortalWarsFriendRequestDialog : PortalWarsTxnDialogWidget
    {
        public PortalWarsFriendRequestDialog(ulong addr) : base(addr) { }
    }
    public class PortalWarsPlayerEntryWidget : PortalWarsEntryWidget
    {
        public PortalWarsPlayerEntryWidget(ulong addr) : base(addr) { }
        public TextBlock PlayerNameText { get { return this[nameof(PlayerNameText)].As<TextBlock>(); } set { this["PlayerNameText"] = value; } }
        public Widget NameRoot { get { return this[nameof(NameRoot)].As<Widget>(); } set { this["NameRoot"] = value; } }
        public Image PlayerAvatar { get { return this[nameof(PlayerAvatar)].As<Image>(); } set { this["PlayerAvatar"] = value; } }
        public Texture CachedPlayerAvatar { get { return this[nameof(CachedPlayerAvatar)].As<Texture>(); } set { this["CachedPlayerAvatar"] = value; } }
        public Widget VoiceIndicator { get { return this[nameof(VoiceIndicator)].As<Widget>(); } set { this["VoiceIndicator"] = value; } }
        public WidgetSwitcher VoiceSwitcher { get { return this[nameof(VoiceSwitcher)].As<WidgetSwitcher>(); } set { this["VoiceSwitcher"] = value; } }
        public WidgetSwitcher MuteSwitcher { get { return this[nameof(MuteSwitcher)].As<WidgetSwitcher>(); } set { this["MuteSwitcher"] = value; } }
        public bool bShowVoiceIndicator { get { return this[nameof(bShowVoiceIndicator)].Flag; } set { this[nameof(bShowVoiceIndicator)].Flag = value; } }
        public float UpdateInterval { get { return this[nameof(UpdateInterval)].GetValue<float>(); } set { this[nameof(UpdateInterval)].SetValue<float>(value); } }
        public WidgetSwitcher BackgroundSwitcher { get { return this[nameof(BackgroundSwitcher)].As<WidgetSwitcher>(); } set { this["BackgroundSwitcher"] = value; } }
        public TextBlock PresenceText { get { return this[nameof(PresenceText)].As<TextBlock>(); } set { this["PresenceText"] = value; } }
        public Widget RankRoot { get { return this[nameof(RankRoot)].As<Widget>(); } set { this["RankRoot"] = value; } }
        public Image RankImage { get { return this[nameof(RankImage)].As<Image>(); } set { this["RankImage"] = value; } }
        public PortalWarsProgressionIconWidget StreakIcon { get { return this[nameof(StreakIcon)].As<PortalWarsProgressionIconWidget>(); } set { this["StreakIcon"] = value; } }
        public PortalWarsProgressionIconWidget LevelIcon { get { return this[nameof(LevelIcon)].As<PortalWarsProgressionIconWidget>(); } set { this["LevelIcon"] = value; } }
        public CanvasPanel IconsRoot { get { return this[nameof(IconsRoot)].As<CanvasPanel>(); } set { this["IconsRoot"] = value; } }
        public bool bShowIcons { get { return this[nameof(bShowIcons)].Flag; } set { this[nameof(bShowIcons)].Flag = value; } }
        public bool bCompactIcons { get { return this[nameof(bCompactIcons)].Flag; } set { this[nameof(bCompactIcons)].Flag = value; } }
        public WidgetAnimation CompactIconsAnimation { get { return this[nameof(CompactIconsAnimation)].As<WidgetAnimation>(); } set { this["CompactIconsAnimation"] = value; } }
        public WidgetAnimation SocialIconsAnimation { get { return this[nameof(SocialIconsAnimation)].As<WidgetAnimation>(); } set { this["SocialIconsAnimation"] = value; } }
        public PanelWidget NameTagPanel { get { return this[nameof(NameTagPanel)].As<PanelWidget>(); } set { this["NameTagPanel"] = value; } }
        public Object NameTagWidgetClass { get { return this[nameof(NameTagWidgetClass)]; } set { this[nameof(NameTagWidgetClass)] = value; } }
        public Image PlayerBanner { get { return this[nameof(PlayerBanner)].As<Image>(); } set { this["PlayerBanner"] = value; } }
        public bool bInitLocalPlayer { get { return this[nameof(bInitLocalPlayer)].Flag; } set { this[nameof(bInitLocalPlayer)].Flag = value; } }
        public void UpdateUserRank() { Invoke(nameof(UpdateUserRank)); }
        public void UpdatePresenceText() { Invoke(nameof(UpdatePresenceText)); }
        public void UpdatePlayerName() { Invoke(nameof(UpdatePlayerName)); }
        public void UpdatePlayerBanner() { Invoke(nameof(UpdatePlayerBanner)); }
        public void UpdatePlayerAvatar() { Invoke(nameof(UpdatePlayerAvatar)); }
        public void UpdateNameTags() { Invoke(nameof(UpdateNameTags)); }
        public void UpdateMuteIndicator() { Invoke(nameof(UpdateMuteIndicator)); }
        public void SetPlayerName(Object InName) { Invoke(nameof(SetPlayerName), InName); }
        public void SetPlayerAvatar(Texture InAvatar) { Invoke(nameof(SetPlayerAvatar), InAvatar); }
        public void RefreshPlayerStateInfo() { Invoke(nameof(RefreshPlayerStateInfo)); }
        public void RefreshLocalPlayerInfo() { Invoke(nameof(RefreshLocalPlayerInfo)); }
        public void OnPlayerNameSanitized(bool bSuccess, Object InSanitizedName) { Invoke(nameof(OnPlayerNameSanitized), bSuccess, InSanitizedName); }
        public void OnBotAvatarLoaded() { Invoke(nameof(OnBotAvatarLoaded)); }
        public ESlateVisibility GetRankVisibility() { return Invoke<ESlateVisibility>(nameof(GetRankVisibility)); }
        public Object GetPresenceText() { return Invoke<Object>(nameof(GetPresenceText)); }
        public Object GetPlayerName() { return Invoke<Object>(nameof(GetPlayerName)); }
        public Texture GetPlayerAvatar() { return Invoke<Texture>(nameof(GetPlayerAvatar)); }
    }
    public class PortalWarsNotificationEntryWidget : PortalWarsPlayerEntryWidget
    {
        public PortalWarsNotificationEntryWidget(ulong addr) : base(addr) { }
        public Widget ButtonRoot { get { return this[nameof(ButtonRoot)].As<Widget>(); } set { this["ButtonRoot"] = value; } }
        public PortalWarsButtonWidget AcceptButton { get { return this[nameof(AcceptButton)].As<PortalWarsButtonWidget>(); } set { this["AcceptButton"] = value; } }
        public PortalWarsButtonWidget DeclineButton { get { return this[nameof(DeclineButton)].As<PortalWarsButtonWidget>(); } set { this["DeclineButton"] = value; } }
        public PortalWarsButtonWidget ViewButton { get { return this[nameof(ViewButton)].As<PortalWarsButtonWidget>(); } set { this["ViewButton"] = value; } }
        public WidgetSwitcher SelectedSwitcher { get { return this[nameof(SelectedSwitcher)].As<WidgetSwitcher>(); } set { this["SelectedSwitcher"] = value; } }
        public TextBlock DescriptionText { get { return this[nameof(DescriptionText)].As<TextBlock>(); } set { this["DescriptionText"] = value; } }
        public float MaxLifetime { get { return this[nameof(MaxLifetime)].GetValue<float>(); } set { this[nameof(MaxLifetime)].SetValue<float>(value); } }
        public ProgressBar LifetimeProgressBar { get { return this[nameof(LifetimeProgressBar)].As<ProgressBar>(); } set { this["LifetimeProgressBar"] = value; } }
        public void OnViewButtonClicked() { Invoke(nameof(OnViewButtonClicked)); }
        public void OnDeclineButtonClicked() { Invoke(nameof(OnDeclineButtonClicked)); }
        public void OnAcceptButtonClicked() { Invoke(nameof(OnAcceptButtonClicked)); }
    }
    public class PortalWarsFriendRequestEntry : PortalWarsNotificationEntryWidget
    {
        public PortalWarsFriendRequestEntry(ulong addr) : base(addr) { }
    }
    public class PortalWarsFriendsListSubWidget : PortalWarsMenuWidget
    {
        public PortalWarsFriendsListSubWidget(ulong addr) : base(addr) { }
        public PortalWarsButtonWidget RefreshButton { get { return this[nameof(RefreshButton)].As<PortalWarsButtonWidget>(); } set { this["RefreshButton"] = value; } }
        public PanelWidget InGamePanel { get { return this[nameof(InGamePanel)].As<PanelWidget>(); } set { this["InGamePanel"] = value; } }
        public PanelWidget OnlinePanel { get { return this[nameof(OnlinePanel)].As<PanelWidget>(); } set { this["OnlinePanel"] = value; } }
        public PanelWidget OfflinePanel { get { return this[nameof(OfflinePanel)].As<PanelWidget>(); } set { this["OfflinePanel"] = value; } }
        public Widget OnlineRoot { get { return this[nameof(OnlineRoot)].As<Widget>(); } set { this["OnlineRoot"] = value; } }
        public Object PlayerEntryWidgetClass { get { return this[nameof(PlayerEntryWidgetClass)]; } set { this[nameof(PlayerEntryWidgetClass)] = value; } }
        public Object PlayerActionsWidgetClass { get { return this[nameof(PlayerActionsWidgetClass)]; } set { this[nameof(PlayerActionsWidgetClass)] = value; } }
        public TextBlock ErrorText { get { return this[nameof(ErrorText)].As<TextBlock>(); } set { this["ErrorText"] = value; } }
        public bool bPlatformFriendsList { get { return this[nameof(bPlatformFriendsList)].Flag; } set { this[nameof(bPlatformFriendsList)].Flag = value; } }
        public void RefreshWidget() { Invoke(nameof(RefreshWidget)); }
        public void RefreshPlayersList() { Invoke(nameof(RefreshPlayersList)); }
        public void RefreshEntries() { Invoke(nameof(RefreshEntries)); }
        public void OnPrivelegesUpdated() { Invoke(nameof(OnPrivelegesUpdated)); }
        public void OnPlayerEntrySelected(PortalWarsEntryWidget Entry) { Invoke(nameof(OnPlayerEntrySelected), Entry); }
        public bool GetRefreshButtonEnabled() { return Invoke<bool>(nameof(GetRefreshButtonEnabled)); }
        public void DelayedRefreshPlayersList() { Invoke(nameof(DelayedRefreshPlayersList)); }
    }
    public class PortalWarsFriendsListWidget : PortalWarsMenuWidget
    {
        public PortalWarsFriendsListWidget(ulong addr) : base(addr) { }
        public void GoToPlatformFriendsState() { Invoke(nameof(GoToPlatformFriendsState)); }
        public void GoToFriendsState() { Invoke(nameof(GoToFriendsState)); }
    }
    public class PortalWarsGameConfigWidget : UserWidget
    {
        public PortalWarsGameConfigWidget(ulong addr) : base(addr) { }
        public TextBlock MapNameText { get { return this[nameof(MapNameText)].As<TextBlock>(); } set { this["MapNameText"] = value; } }
        public TextBlock ModeNameText { get { return this[nameof(ModeNameText)].As<TextBlock>(); } set { this["ModeNameText"] = value; } }
        public TextBlock ScoreLimitText { get { return this[nameof(ScoreLimitText)].As<TextBlock>(); } set { this["ScoreLimitText"] = value; } }
        public TextBlock MatchTimeText { get { return this[nameof(MatchTimeText)].As<TextBlock>(); } set { this["MatchTimeText"] = value; } }
        public TextBlock MaxPlayersText { get { return this[nameof(MaxPlayersText)].As<TextBlock>(); } set { this["MaxPlayersText"] = value; } }
        public void InitGameConfig() { Invoke(nameof(InitGameConfig)); }
        public Object GetScoreLimitText() { return Invoke<Object>(nameof(GetScoreLimitText)); }
        public Object GetModeName() { return Invoke<Object>(nameof(GetModeName)); }
        public Object GetMaxPlayersText() { return Invoke<Object>(nameof(GetMaxPlayersText)); }
        public Object GetMatchTimeText() { return Invoke<Object>(nameof(GetMatchTimeText)); }
        public Object GetMapName() { return Invoke<Object>(nameof(GetMapName)); }
    }
    public class PortalWarsGameEngine : GameEngine
    {
        public PortalWarsGameEngine(ulong addr) : base(addr) { }
    }
    public class PortalWarsGameInstance : GameInstance
    {
        public PortalWarsGameInstance(ulong addr) : base(addr) { }
        public bool bMovieWillAutocompleteWhenLoadFinishes { get { return this[nameof(bMovieWillAutocompleteWhenLoadFinishes)].Flag; } set { this[nameof(bMovieWillAutocompleteWhenLoadFinishes)].Flag = value; } }
        public PortalWarsLoadingScreenWidget LoadingScreenWidget { get { return this[nameof(LoadingScreenWidget)].As<PortalWarsLoadingScreenWidget>(); } set { this["LoadingScreenWidget"] = value; } }
        public Object LoadingScreenWidgetClass { get { return this[nameof(LoadingScreenWidgetClass)]; } set { this[nameof(LoadingScreenWidgetClass)] = value; } }
        public GameConfig GameSettings { get { return this[nameof(GameSettings)].As<GameConfig>(); } set { this["GameSettings"] = value; } }
        public void ShowLoadingScreen() { Invoke(nameof(ShowLoadingScreen)); }
        public void PreLoadMap(Object MapName) { Invoke(nameof(PreLoadMap), MapName); }
        public void OnPostLoadMap(World InLoadedWorld) { Invoke(nameof(OnPostLoadMap), InLoadedWorld); }
        public void HideLoadingScreen() { Invoke(nameof(HideLoadingScreen)); }
        public void HandleTravelFailure(World World, byte FailureType, Object ErrorString) { Invoke(nameof(HandleTravelFailure), World, FailureType, ErrorString); }
        public void HandleNetworkFailure(World World, NetDriver NetDriver, byte FailureType, Object ErrorString) { Invoke(nameof(HandleNetworkFailure), World, NetDriver, FailureType, ErrorString); }
        public void DisconnectFromServer() { Invoke(nameof(DisconnectFromServer)); }
        public void DisconnectFromBackend() { Invoke(nameof(DisconnectFromBackend)); }
        public void Crash() { Invoke(nameof(Crash)); }
    }
    public class PortalWarsGameModeInfoWidget : UserWidget
    {
        public PortalWarsGameModeInfoWidget(ulong addr) : base(addr) { }
        public TextBlock DisplayNameText { get { return this[nameof(DisplayNameText)].As<TextBlock>(); } set { this["DisplayNameText"] = value; } }
        public TextBlock DescriptionText { get { return this[nameof(DescriptionText)].As<TextBlock>(); } set { this["DescriptionText"] = value; } }
        public Image DisplayImage { get { return this[nameof(DisplayImage)].As<Image>(); } set { this["DisplayImage"] = value; } }
        public Image IconImage { get { return this[nameof(IconImage)].As<Image>(); } set { this["IconImage"] = value; } }
        public TextBlock MaxPartySizeText { get { return this[nameof(MaxPartySizeText)].As<TextBlock>(); } set { this["MaxPartySizeText"] = value; } }
        public TextBlock PlayersText { get { return this[nameof(PlayersText)].As<TextBlock>(); } set { this["PlayersText"] = value; } }
        public TextBlock ScoreLimitText { get { return this[nameof(ScoreLimitText)].As<TextBlock>(); } set { this["ScoreLimitText"] = value; } }
    }
    public class PortalWarsGamepadBindingActionWidget : PortalWarsUserWidget
    {
        public PortalWarsGamepadBindingActionWidget(ulong addr) : base(addr) { }
        public PortalWarsButton ActionButton { get { return this[nameof(ActionButton)].As<PortalWarsButton>(); } set { this["ActionButton"] = value; } }
        public TextBlock ActionText { get { return this[nameof(ActionText)].As<TextBlock>(); } set { this["ActionText"] = value; } }
        public Image ButtonBackground { get { return this[nameof(ButtonBackground)].As<Image>(); } set { this["ButtonBackground"] = value; } }
        public Image ButtonIcon { get { return this[nameof(ButtonIcon)].As<Image>(); } set { this["ButtonIcon"] = value; } }
        public Object OnActionSelected { get { return this[nameof(OnActionSelected)]; } set { this[nameof(OnActionSelected)] = value; } }
        public SlateColor StandardTextColor { get { return this[nameof(StandardTextColor)].As<SlateColor>(); } set { this["StandardTextColor"] = value; } }
        public SlateColor ActiveTextColor { get { return this[nameof(ActiveTextColor)].As<SlateColor>(); } set { this["ActiveTextColor"] = value; } }
        public LinearColor StandardBackgroundColor { get { return this[nameof(StandardBackgroundColor)].As<LinearColor>(); } set { this["StandardBackgroundColor"] = value; } }
        public LinearColor ActiveBackgroundColor { get { return this[nameof(ActiveBackgroundColor)].As<LinearColor>(); } set { this["ActiveBackgroundColor"] = value; } }
        public void OnUnhovered() { Invoke(nameof(OnUnhovered)); }
        public void OnReleased() { Invoke(nameof(OnReleased)); }
        public void OnHovered() { Invoke(nameof(OnHovered)); }
    }
    public class PortalWarsGamepadBindingCategoryWidget : UserWidget
    {
        public PortalWarsGamepadBindingCategoryWidget(ulong addr) : base(addr) { }
        public TextBlock CategoryText { get { return this[nameof(CategoryText)].As<TextBlock>(); } set { this["CategoryText"] = value; } }
    }
    public class PortalWarsGamepadBindingCustomizeButtonWidget : PortalWarsUserWidget
    {
        public PortalWarsGamepadBindingCustomizeButtonWidget(ulong addr) : base(addr) { }
        public Object OnCustomizeGamepadBinds { get { return this[nameof(OnCustomizeGamepadBinds)]; } set { this[nameof(OnCustomizeGamepadBinds)] = value; } }
        public PortalWarsButton CustomizeButton { get { return this[nameof(CustomizeButton)].As<PortalWarsButton>(); } set { this["CustomizeButton"] = value; } }
        public TextBlock ValueText { get { return this[nameof(ValueText)].As<TextBlock>(); } set { this["ValueText"] = value; } }
        public Widget HoveredIndicator { get { return this[nameof(HoveredIndicator)].As<Widget>(); } set { this["HoveredIndicator"] = value; } }
        public SlateColor StandardColor { get { return this[nameof(StandardColor)].As<SlateColor>(); } set { this["StandardColor"] = value; } }
        public SlateColor ActiveColor { get { return this[nameof(ActiveColor)].As<SlateColor>(); } set { this["ActiveColor"] = value; } }
        public void OnUnhovered() { Invoke(nameof(OnUnhovered)); }
        public void OnPressed() { Invoke(nameof(OnPressed)); }
        public void OnHovered() { Invoke(nameof(OnHovered)); }
    }
    public class PortalWarsGamepadBindingMissingDialogWidget : PortalWarsDialogWidget
    {
        public PortalWarsGamepadBindingMissingDialogWidget(ulong addr) : base(addr) { }
        public Object OnWarningButtonClickedDelegate { get { return this[nameof(OnWarningButtonClickedDelegate)]; } set { this[nameof(OnWarningButtonClickedDelegate)] = value; } }
        public PortalWarsButtonWidget AcceptButton { get { return this[nameof(AcceptButton)].As<PortalWarsButtonWidget>(); } set { this["AcceptButton"] = value; } }
        public TextBlock TitleText { get { return this[nameof(TitleText)].As<TextBlock>(); } set { this["TitleText"] = value; } }
        public TextBlock SubtitleText { get { return this[nameof(SubtitleText)].As<TextBlock>(); } set { this["SubtitleText"] = value; } }
        public TextBlock MissingText { get { return this[nameof(MissingText)].As<TextBlock>(); } set { this["MissingText"] = value; } }
        public void OnAcceptButtonClicked() { Invoke(nameof(OnAcceptButtonClicked)); }
    }
    public class PortalWarsGamepadBindingOverlayWidget : PortalWarsDialogWidget
    {
        public PortalWarsGamepadBindingOverlayWidget(ulong addr) : base(addr) { }
        public Object OnActionSelected { get { return this[nameof(OnActionSelected)]; } set { this[nameof(OnActionSelected)] = value; } }
        public TextBlock CurrentAction { get { return this[nameof(CurrentAction)].As<TextBlock>(); } set { this["CurrentAction"] = value; } }
        public PanelWidget ActionPanel { get { return this[nameof(ActionPanel)].As<PanelWidget>(); } set { this["ActionPanel"] = value; } }
        public Image CurrentBinding { get { return this[nameof(CurrentBinding)].As<Image>(); } set { this["CurrentBinding"] = value; } }
        public Object CategoryClass { get { return this[nameof(CategoryClass)]; } set { this[nameof(CategoryClass)] = value; } }
        public Object ActionClass { get { return this[nameof(ActionClass)]; } set { this[nameof(ActionClass)] = value; } }
        public Array<GamepadBindingCategory> BindingCategories { get { return new Array<GamepadBindingCategory>(this[nameof(BindingCategories)].Address); } }
        public void ReceivedAction(Object ChosenAction, bool bToggle) { Invoke(nameof(ReceivedAction), ChosenAction, bToggle); }
    }
    public class PortalWarsGamepadBindingRestoreDialogWidget : PortalWarsDialogWidget
    {
        public PortalWarsGamepadBindingRestoreDialogWidget(ulong addr) : base(addr) { }
        public Object OnAcceptButtonClickedDelegate { get { return this[nameof(OnAcceptButtonClickedDelegate)]; } set { this[nameof(OnAcceptButtonClickedDelegate)] = value; } }
        public PortalWarsTextCarouselWidget ControllerPreset { get { return this[nameof(ControllerPreset)].As<PortalWarsTextCarouselWidget>(); } set { this["ControllerPreset"] = value; } }
        public PortalWarsButtonWidget AcceptButton { get { return this[nameof(AcceptButton)].As<PortalWarsButtonWidget>(); } set { this["AcceptButton"] = value; } }
        public void OnAcceptButtonClicked() { Invoke(nameof(OnAcceptButtonClicked)); }
    }
    public class PortalWarsGamepadBindingWidget : PortalWarsUserWidget
    {
        public PortalWarsGamepadBindingWidget(ulong addr) : base(addr) { }
        public Object OnGamepadKeyBound { get { return this[nameof(OnGamepadKeyBound)]; } set { this[nameof(OnGamepadKeyBound)] = value; } }
        public PortalWarsButton BindingButton { get { return this[nameof(BindingButton)].As<PortalWarsButton>(); } set { this["BindingButton"] = value; } }
        public TextBlock BindingText { get { return this[nameof(BindingText)].As<TextBlock>(); } set { this["BindingText"] = value; } }
        public Image ButtonBackground { get { return this[nameof(ButtonBackground)].As<Image>(); } set { this["ButtonBackground"] = value; } }
        public Widget ButtonIconBox { get { return this[nameof(ButtonIconBox)].As<Widget>(); } set { this["ButtonIconBox"] = value; } }
        public Widget HoveredIndicator { get { return this[nameof(HoveredIndicator)].As<Widget>(); } set { this["HoveredIndicator"] = value; } }
        public SlateColor StandardColor { get { return this[nameof(StandardColor)].As<SlateColor>(); } set { this["StandardColor"] = value; } }
        public SlateColor ActiveColor { get { return this[nameof(ActiveColor)].As<SlateColor>(); } set { this["ActiveColor"] = value; } }
        public Object BindingOverlayClass { get { return this[nameof(BindingOverlayClass)]; } set { this[nameof(BindingOverlayClass)] = value; } }
        public void ReceivedAction(Object ChosenAction, bool bToggle) { Invoke(nameof(ReceivedAction), ChosenAction, bToggle); }
        public void OpenOverlay() { Invoke(nameof(OpenOverlay)); }
        public void OnUnhovered() { Invoke(nameof(OnUnhovered)); }
        public void OnHovered() { Invoke(nameof(OnHovered)); }
        public void CloseOverlay() { Invoke(nameof(CloseOverlay)); }
    }
    public class PortalWarsGamepadReconnectWidget : PortalWarsDialogWidget
    {
        public PortalWarsGamepadReconnectWidget(ulong addr) : base(addr) { }
        public void OnUserAdded(int ControllerId) { Invoke(nameof(OnUserAdded), ControllerId); }
    }
    public class PortalWarsGamepadSelectWidget : PortalWarsSettingsSubWidget
    {
        public PortalWarsGamepadSelectWidget(ulong addr) : base(addr) { }
        public PortalWarsTextCarouselWidget GameplayPreset { get { return this[nameof(GameplayPreset)].As<PortalWarsTextCarouselWidget>(); } set { this["GameplayPreset"] = value; } }
        public WidgetSwitcher ControllerSwitcher { get { return this[nameof(ControllerSwitcher)].As<WidgetSwitcher>(); } set { this["ControllerSwitcher"] = value; } }
        public PortalWarsControllerPresetWidget XboxButtonLayout { get { return this[nameof(XboxButtonLayout)].As<PortalWarsControllerPresetWidget>(); } set { this["XboxButtonLayout"] = value; } }
        public PortalWarsControllerPresetWidget PS4ButtonLayout { get { return this[nameof(PS4ButtonLayout)].As<PortalWarsControllerPresetWidget>(); } set { this["PS4ButtonLayout"] = value; } }
        public Object BindingWarningDialogClass { get { return this[nameof(BindingWarningDialogClass)]; } set { this[nameof(BindingWarningDialogClass)] = value; } }
        public Object BindingDefaultsDialogClass { get { return this[nameof(BindingDefaultsDialogClass)]; } set { this[nameof(BindingDefaultsDialogClass)] = value; } }
        public PortalWarsGamepadBindingCustomizeButtonWidget CustomizeButton { get { return this[nameof(CustomizeButton)].As<PortalWarsGamepadBindingCustomizeButtonWidget>(); } set { this["CustomizeButton"] = value; } }
        public void SwapToCustomBindings() { Invoke(nameof(SwapToCustomBindings)); }
        public void RefreshPresetWidgets() { Invoke(nameof(RefreshPresetWidgets)); }
        public void OnWarningDismissed() { Invoke(nameof(OnWarningDismissed)); }
        public void FocusCustomBindings() { Invoke(nameof(FocusCustomBindings)); }
    }
    public class PortalWarsGamepadSettingsWidget : PortalWarsSettingsSubWidget
    {
        public PortalWarsGamepadSettingsWidget(ulong addr) : base(addr) { }
        public PortalWarsSpinSliderWidget ControllerHorSens { get { return this[nameof(ControllerHorSens)].As<PortalWarsSpinSliderWidget>(); } set { this["ControllerHorSens"] = value; } }
        public PortalWarsSpinSliderWidget ControllerVertSens { get { return this[nameof(ControllerVertSens)].As<PortalWarsSpinSliderWidget>(); } set { this["ControllerVertSens"] = value; } }
        public PortalWarsSpinSliderWidget ControllerAccelSens { get { return this[nameof(ControllerAccelSens)].As<PortalWarsSpinSliderWidget>(); } set { this["ControllerAccelSens"] = value; } }
        public PortalWarsSpinSliderWidget ControllerZoomMult { get { return this[nameof(ControllerZoomMult)].As<PortalWarsSpinSliderWidget>(); } set { this["ControllerZoomMult"] = value; } }
        public PortalWarsSpinSliderWidget ControllerInnerDeadzone { get { return this[nameof(ControllerInnerDeadzone)].As<PortalWarsSpinSliderWidget>(); } set { this["ControllerInnerDeadzone"] = value; } }
        public PortalWarsSpinSliderWidget ControllerOuterDeadzone { get { return this[nameof(ControllerOuterDeadzone)].As<PortalWarsSpinSliderWidget>(); } set { this["ControllerOuterDeadzone"] = value; } }
        public PortalWarsCheckBoxWidget ControllerInvertLook { get { return this[nameof(ControllerInvertLook)].As<PortalWarsCheckBoxWidget>(); } set { this["ControllerInvertLook"] = value; } }
        public PortalWarsCheckBoxWidget ControllerVibration { get { return this[nameof(ControllerVibration)].As<PortalWarsCheckBoxWidget>(); } set { this["ControllerVibration"] = value; } }
    }
    public class PortalWarsGameplaySettingsWidget : PortalWarsSettingsSubWidget
    {
        public PortalWarsGameplaySettingsWidget(ulong addr) : base(addr) { }
        public PortalWarsCheckBoxWidget Blood { get { return this[nameof(Blood)].As<PortalWarsCheckBoxWidget>(); } set { this["Blood"] = value; } }
        public PortalWarsDropdownWidget Killcam { get { return this[nameof(Killcam)].As<PortalWarsDropdownWidget>(); } set { this["Killcam"] = value; } }
        public PortalWarsDropdownWidget InputDevice { get { return this[nameof(InputDevice)].As<PortalWarsDropdownWidget>(); } set { this["InputDevice"] = value; } }
    }
    public class PortalWarsGameplayStatics : BlueprintFunctionLibrary
    {
        public PortalWarsGameplayStatics(ulong addr) : base(addr) { }
        public Rotator StandardizeRotator(Rotator InRotator) { return Invoke<Rotator>(nameof(StandardizeRotator), InRotator); }
        public Rotator SlerpRInterpTo(Rotator Current, Rotator Target, float DeltaTime, float InterpSpeed) { return Invoke<Rotator>(nameof(SlerpRInterpTo), Current, Target, DeltaTime, InterpSpeed); }
        public Quat SlerpInterpTo(Quat Current, Quat Target, float DeltaTime, float InterpSpeed) { return Invoke<Quat>(nameof(SlerpInterpTo), Current, Target, DeltaTime, InterpSpeed); }
        public Rotator Slerp(Rotator A, Rotator B, float Alpha) { return Invoke<Rotator>(nameof(Slerp), A, B, Alpha); }
        public float RadiansBetweenVectors(Vector Vector1, Vector Vector2) { return Invoke<float>(nameof(RadiansBetweenVectors), Vector1, Vector2); }
        public AkComponent PWSpawnAkComponentAtLocation(World TheWorld, AkAudioEvent AkEvent, Actor SourceActor, AkAuxBus EarlyReflectionsBus, Vector Location, Rotator Orientation, bool AutoPost, Object EventName, Object EarlyReflectionsBusName, bool AutoDestroy) { return Invoke<AkComponent>(nameof(PWSpawnAkComponentAtLocation), TheWorld, AkEvent, SourceActor, EarlyReflectionsBus, Location, Orientation, AutoPost, EventName, EarlyReflectionsBusName, AutoDestroy); }
        public void PWSetGlobalRTPCValue(Object RTPCName, float Value) { Invoke(nameof(PWSetGlobalRTPCValue), RTPCName, Value); }
        public void PWPlayWwiseEventOnAkComponentWithDelay(World TheWorld, AkAudioEvent EventToPlay, PortalWarsAkComponent AkComponent, float Delay, byte RepType, bool bUseSpatialAudio) { Invoke(nameof(PWPlayWwiseEventOnAkComponentWithDelay), TheWorld, EventToPlay, AkComponent, Delay, RepType, bUseSpatialAudio); }
        public void PWPlayWwiseEventOnAkComponent(World TheWorld, AkAudioEvent EventToPlay, PortalWarsAkComponent AkComponent, byte RepType, bool bUseSpatialAudio) { Invoke(nameof(PWPlayWwiseEventOnAkComponent), TheWorld, EventToPlay, AkComponent, RepType, bUseSpatialAudio); }
        public void PWPlayWwiseEventAtLocationWithDelay(World TheWorld, AkAudioEvent EventToPlay, Actor SourceActor, Vector SoundLocation, Rotator SoundRotation, float Delay, byte RepType, bool bUseSpatialAudio) { Invoke(nameof(PWPlayWwiseEventAtLocationWithDelay), TheWorld, EventToPlay, SourceActor, SoundLocation, SoundRotation, Delay, RepType, bUseSpatialAudio); }
        public void PWPlayWwiseEventAtLocation(World TheWorld, AkAudioEvent EventToPlay, Actor SourceActor, Vector SoundLocation, Rotator SoundRotation, byte RepType, bool bUseSpatialAudio) { Invoke(nameof(PWPlayWwiseEventAtLocation), TheWorld, EventToPlay, SourceActor, SoundLocation, SoundRotation, RepType, bUseSpatialAudio); }
        public bool IsWithEditor() { return Invoke<bool>(nameof(IsWithEditor)); }
        public bool IsPlayingTutorial(Object WorldContextObject) { return Invoke<bool>(nameof(IsPlayingTutorial), WorldContextObject); }
        public bool IsPlayingReplay(Object WorldContextObject) { return Invoke<bool>(nameof(IsPlayingReplay), WorldContextObject); }
        public bool IsPlayingRange(Object WorldContextObject) { return Invoke<bool>(nameof(IsPlayingRange), WorldContextObject); }
        public bool IsPlayingRace(Object WorldContextObject) { return Invoke<bool>(nameof(IsPlayingRace), WorldContextObject); }
        public bool IsPlayerStateFullyReplicatedForPlayer(PortalWarsPlayerState PS) { return Invoke<bool>(nameof(IsPlayerStateFullyReplicatedForPlayer), PS); }
        public bool IsLocalPlayerStateFullyReplicated(Object WorldContextObject) { return Invoke<bool>(nameof(IsLocalPlayerStateFullyReplicated), WorldContextObject); }
        public bool IsLocalPlayerSpectating(Object WorldContextObject) { return Invoke<bool>(nameof(IsLocalPlayerSpectating), WorldContextObject); }
        public bool IsLocalPlayerInGlobalVision(Object WorldContextObject) { return Invoke<bool>(nameof(IsLocalPlayerInGlobalVision), WorldContextObject); }
        public bool IsLocalPlayerInFreeCam(Object WorldContextObject) { return Invoke<bool>(nameof(IsLocalPlayerInFreeCam), WorldContextObject); }
        public bool IsLocalPlayerFlagged(Object WorldContextObject) { return Invoke<bool>(nameof(IsLocalPlayerFlagged), WorldContextObject); }
        public bool IsLocalPlayerAdmin(Object WorldContextObject) { return Invoke<bool>(nameof(IsLocalPlayerAdmin), WorldContextObject); }
        public bool IsLANMatch(Object WorldContextObject) { return Invoke<bool>(nameof(IsLANMatch), WorldContextObject); }
        public bool IsInWaitingArea(Object WorldContextObject) { return Invoke<bool>(nameof(IsInWaitingArea), WorldContextObject); }
        public bool IsInRaceLobby(Object WorldContextObject) { return Invoke<bool>(nameof(IsInRaceLobby), WorldContextObject); }
        public bool IsInMainMenu(Object WorldContextObject) { return Invoke<bool>(nameof(IsInMainMenu), WorldContextObject); }
        public bool IsInLobby(Object WorldContextObject) { return Invoke<bool>(nameof(IsInLobby), WorldContextObject); }
        public bool IsInCustomGame(Object WorldContextObject) { return Invoke<bool>(nameof(IsInCustomGame), WorldContextObject); }
        public bool IsEnemyTeamNum(byte TeamNum, Object WorldContextObject) { return Invoke<bool>(nameof(IsEnemyTeamNum), TeamNum, WorldContextObject); }
        public bool IsCharacterOverlappingComponent(Character Character, SceneComponent Component, Vector BoxExtent) { return Invoke<bool>(nameof(IsCharacterOverlappingComponent), Character, Component, BoxExtent); }
        public bool IsAnyCharacterOverlappingComponent(Object WorldContextObject, SceneComponent Component, Vector BoxExtent) { return Invoke<bool>(nameof(IsAnyCharacterOverlappingComponent), WorldContextObject, Component, BoxExtent); }
        public Object GetTeamNameForTeam(byte TeamNum) { return Invoke<Object>(nameof(GetTeamNameForTeam), TeamNum); }
        public PortalWarsSaveGame GetSaveGameForLocalPlayer(LocalPlayer LocalPlayer) { return Invoke<PortalWarsSaveGame>(nameof(GetSaveGameForLocalPlayer), LocalPlayer); }
        public PortalWarsGameUserSettings GetPortalWarsGameSettings() { return Invoke<PortalWarsGameUserSettings>(nameof(GetPortalWarsGameSettings)); }
        public PortalWarsPlayerState GetPlayerStateFromUniqueId(Object WorldContextObject, Object PlayerIdString, bool bSearchInactive) { return Invoke<PortalWarsPlayerState>(nameof(GetPlayerStateFromUniqueId), WorldContextObject, PlayerIdString, bSearchInactive); }
        public Object GetPlayerName(PortalWarsCharacter Character) { return Invoke<Object>(nameof(GetPlayerName), Character); }
        public Texture2D GetMouseKeyIconForAction(LocalPlayer LocalPlayer, Object InAction) { return Invoke<Texture2D>(nameof(GetMouseKeyIconForAction), LocalPlayer, InAction); }
        public byte GetLocalTeamNum(Object WorldContextObject) { return Invoke<byte>(nameof(GetLocalTeamNum), WorldContextObject); }
        public PortalWarsPlayerState GetLocalPlayerState(Object WorldContextObject) { return Invoke<PortalWarsPlayerState>(nameof(GetLocalPlayerState), WorldContextObject); }
        public int GetLocalPlayerControllerId(Object WorldContextObject) { return Invoke<int>(nameof(GetLocalPlayerControllerId), WorldContextObject); }
        public Key GetKeyForAction(LocalPlayer LocalPlayer, Object InAction) { return Invoke<Key>(nameof(GetKeyForAction), LocalPlayer, InAction); }
        public Object GetKeyDisplayNameForAction(LocalPlayer LocalPlayer, Object InAction, bool bLongDispayName) { return Invoke<Object>(nameof(GetKeyDisplayNameForAction), LocalPlayer, InAction, bLongDispayName); }
        public bool GetGameVersion(Object OutGameVersion) { return Invoke<bool>(nameof(GetGameVersion), OutGameVersion); }
        public Texture2D GetGamepadKeyIconForAction(LocalPlayer LocalPlayer, Object InAction) { return Invoke<Texture2D>(nameof(GetGamepadKeyIconForAction), LocalPlayer, InAction); }
        public Key GetGamepadKeyForAction(LocalPlayer LocalPlayer, Object InAction) { return Invoke<Key>(nameof(GetGamepadKeyForAction), LocalPlayer, InAction); }
        public float DegreesBetweenVectors(Vector Vector1, Vector Vector2) { return Invoke<float>(nameof(DegreesBetweenVectors), Vector1, Vector2); }
        public int CompareVersionNumbers(Object v1, Object v2) { return Invoke<int>(nameof(CompareVersionNumbers), v1, v2); }
        public bool CheckAimDistToEnemy(PlayerController From, Vector ToLocation, float Tolerance) { return Invoke<bool>(nameof(CheckAimDistToEnemy), From, ToLocation, Tolerance); }
        public bool AreEnemiesPS(PlayerState PS1, PlayerState PS2) { return Invoke<bool>(nameof(AreEnemiesPS), PS1, PS2); }
        public bool AreEnemiesPawn(Pawn Player1, Pawn Player2) { return Invoke<bool>(nameof(AreEnemiesPawn), Player1, Player2); }
        public bool ApplyRadialDamageWithFalloff(Object WorldContextObject, float BaseDamage, float MinimumDamage, Vector Origin, float DamageInnerRadius, float DamageOuterRadius, float DamageFalloff, Object DamageTypeClass, Array<Actor> IgnoreActors, Array<Vector> AltVisibilityOrigins, Actor DamageCauser, Controller InstigatedByController, byte DamagePreventionChannel, bool bShotThruPortal, Gun Weapon) { return Invoke<bool>(nameof(ApplyRadialDamageWithFalloff), WorldContextObject, BaseDamage, MinimumDamage, Origin, DamageInnerRadius, DamageOuterRadius, DamageFalloff, DamageTypeClass, IgnoreActors, AltVisibilityOrigins, DamageCauser, InstigatedByController, DamagePreventionChannel, bShotThruPortal, Weapon); }
        public bool ApplyRadialDamage(Object WorldContextObject, float BaseDamage, Vector Origin, float DamageInnerRadius, float DamageOuterRadius, Object DamageTypeClass, Array<Actor> IgnoreActors, Array<Vector> AltVisibilityOrigins, Actor DamageCauser, Controller InstigatedByController, float DamageFalloff, float MinimumDamage, byte DamagePreventionChannel, bool bShotThruPortal, Gun Weapon) { return Invoke<bool>(nameof(ApplyRadialDamage), WorldContextObject, BaseDamage, Origin, DamageInnerRadius, DamageOuterRadius, DamageTypeClass, IgnoreActors, AltVisibilityOrigins, DamageCauser, InstigatedByController, DamageFalloff, MinimumDamage, DamagePreventionChannel, bShotThruPortal, Weapon); }
    }
    public class PortalWarsGameSession : GameSession
    {
        public PortalWarsGameSession(ulong addr) : base(addr) { }
    }
    public class PortalWarsGameSessionReconnectDialog : PortalWarsDialogWidget
    {
        public PortalWarsGameSessionReconnectDialog(ulong addr) : base(addr) { }
        public PortalWarsButtonWidget ReconnectButton { get { return this[nameof(ReconnectButton)].As<PortalWarsButtonWidget>(); } set { this["ReconnectButton"] = value; } }
        public WidgetSwitcher ReconnectSwitcher { get { return this[nameof(ReconnectSwitcher)].As<WidgetSwitcher>(); } set { this["ReconnectSwitcher"] = value; } }
        public void OnReconnectButtonClicked() { Invoke(nameof(OnReconnectButtonClicked)); }
    }
    public class PortalWarsGameUserSettings : GameUserSettings
    {
        public PortalWarsGameUserSettings(ulong addr) : base(addr) { }
        public bool bHasRunAutoCalibration { get { return this[nameof(bHasRunAutoCalibration)].Flag; } set { this[nameof(bHasRunAutoCalibration)].Flag = value; } }
        public int PortalQuality { get { return this[nameof(PortalQuality)].GetValue<int>(); } set { this[nameof(PortalQuality)].SetValue<int>(value); } }
        public int PortalFrameRate { get { return this[nameof(PortalFrameRate)].GetValue<int>(); } set { this[nameof(PortalFrameRate)].SetValue<int>(value); } }
    }
    public class PortalWarsGameViewportClient : GameViewportClient
    {
        public PortalWarsGameViewportClient(ulong addr) : base(addr) { }
    }
    public class PortalWarsGateIndicatorWidget : PortalWarsIndicatorWidget
    {
        public PortalWarsGateIndicatorWidget(ulong addr) : base(addr) { }
        public Widget Pointer { get { return this[nameof(Pointer)].As<Widget>(); } set { this["Pointer"] = value; } }
        public Vector Offset { get { return this[nameof(Offset)].As<Vector>(); } set { this["Offset"] = value; } }
    }
    public class PortalWarsGG : PortalWarsGameMode
    {
        public PortalWarsGG(ulong addr) : base(addr) { }
        public Array<Object> WeaponClasses { get { return new Array<Object>(this[nameof(WeaponClasses)].Address); } }
        public bool bHumiliationEnabled { get { return this[nameof(bHumiliationEnabled)].Flag; } set { this[nameof(bHumiliationEnabled)].Flag = value; } }
    }
    public class PortalWarsGGGunStatusWidget : PortalWarsUserWidget
    {
        public PortalWarsGGGunStatusWidget(ulong addr) : base(addr) { }
        public RichTextBlock CurrentWeaponText { get { return this[nameof(CurrentWeaponText)].As<RichTextBlock>(); } set { this["CurrentWeaponText"] = value; } }
        public Image NextWeaponImage { get { return this[nameof(NextWeaponImage)].As<Image>(); } set { this["NextWeaponImage"] = value; } }
        public SizeBox IconSizeBox { get { return this[nameof(IconSizeBox)].As<SizeBox>(); } set { this["IconSizeBox"] = value; } }
        public HorizontalBox NextWeaponHorizontalBox { get { return this[nameof(NextWeaponHorizontalBox)].As<HorizontalBox>(); } set { this["NextWeaponHorizontalBox"] = value; } }
        public LinearColor WeaponColor { get { return this[nameof(WeaponColor)].As<LinearColor>(); } set { this["WeaponColor"] = value; } }
        public PortalWarsGG DefaultGameMode { get { return this[nameof(DefaultGameMode)].As<PortalWarsGG>(); } set { this["DefaultGameMode"] = value; } }
    }
    public class PortalWarsGGHUD : PortalWarsHUD
    {
        public PortalWarsGGHUD(ulong addr) : base(addr) { }
        public PortalWarsGGHUDOverlayWidget GGHUDOverlayWidget { get { return this[nameof(GGHUDOverlayWidget)].As<PortalWarsGGHUDOverlayWidget>(); } set { this["GGHUDOverlayWidget"] = value; } }
        public Object GGHUDOverlayWidgetClass { get { return this[nameof(GGHUDOverlayWidgetClass)]; } set { this[nameof(GGHUDOverlayWidgetClass)] = value; } }
    }
    public class PortalWarsGGHUDOverlayWidget : UserWidget
    {
        public PortalWarsGGHUDOverlayWidget(ulong addr) : base(addr) { }
        public PortalWarsGGGunStatusWidget GunStatus { get { return this[nameof(GunStatus)].As<PortalWarsGGGunStatusWidget>(); } set { this["GunStatus"] = value; } }
        public PortalWarsGGNotificationWidget GunGameNotification { get { return this[nameof(GunGameNotification)].As<PortalWarsGGNotificationWidget>(); } set { this["GunGameNotification"] = value; } }
    }
    public class PortalWarsGGNotificationWidget : UserWidget
    {
        public PortalWarsGGNotificationWidget(ulong addr) : base(addr) { }
        public Image KillImage { get { return this[nameof(KillImage)].As<Image>(); } set { this["KillImage"] = value; } }
        public HorizontalBox RootHorizontalBox { get { return this[nameof(RootHorizontalBox)].As<HorizontalBox>(); } set { this["RootHorizontalBox"] = value; } }
        public Texture2D BlueKillImage { get { return this[nameof(BlueKillImage)].As<Texture2D>(); } set { this["BlueKillImage"] = value; } }
    }
    public class PortalWarsGGPlayerState : PortalWarsPlayerState
    {
        public PortalWarsGGPlayerState(ulong addr) : base(addr) { }
        public byte CurrentWeaponIndex { get { return this[nameof(CurrentWeaponIndex)].GetValue<byte>(); } set { this[nameof(CurrentWeaponIndex)].SetValue<byte>(value); } }
        public void OnRep_CurrentWeaponIndex() { Invoke(nameof(OnRep_CurrentWeaponIndex)); }
    }
    public class PortalWarsGlobalCarouselWidget : PortalWarsInputCarouselWidget
    {
        public PortalWarsGlobalCarouselWidget(ulong addr) : base(addr) { }
        public Image DisplayImage { get { return this[nameof(DisplayImage)].As<Image>(); } set { this["DisplayImage"] = value; } }
        public void OnDisplayImageLoaded() { Invoke(nameof(OnDisplayImageLoaded)); }
        public Object GetDisplayName() { return Invoke<Object>(nameof(GetDisplayName)); }
        public Texture2D GetDisplayImage() { return Invoke<Texture2D>(nameof(GetDisplayImage)); }
    }
    public class PortalWarsGoalIndicatorWidget : PortalWarsIndicatorWidget
    {
        public PortalWarsGoalIndicatorWidget(ulong addr) : base(addr) { }
        public Widget Pointer { get { return this[nameof(Pointer)].As<Widget>(); } set { this["Pointer"] = value; } }
        public Vector StandardOffset { get { return this[nameof(StandardOffset)].As<Vector>(); } set { this["StandardOffset"] = value; } }
        public Vector DummyPlayerOffset { get { return this[nameof(DummyPlayerOffset)].As<Vector>(); } set { this["DummyPlayerOffset"] = value; } }
        public Vector PortalWallOffset { get { return this[nameof(PortalWallOffset)].As<Vector>(); } set { this["PortalWallOffset"] = value; } }
    }
    public class PortalWarsGoodSky : Actor
    {
        public PortalWarsGoodSky(ulong addr) : base(addr) { }
        public void EditorInit() { Invoke(nameof(EditorInit)); }
    }
    public class PortalWarsGrenadePickup : PortalWarsPickup
    {
        public PortalWarsGrenadePickup(ulong addr) : base(addr) { }
    }
    public class PortalWarsGunPickupZone : PortalWarsGunPickup
    {
        public PortalWarsGunPickupZone(ulong addr) : base(addr) { }
        public float AmmoClips { get { return this[nameof(AmmoClips)].GetValue<float>(); } set { this[nameof(AmmoClips)].SetValue<float>(value); } }
        public bool bIsActive { get { return this[nameof(bIsActive)].Flag; } set { this[nameof(bIsActive)].Flag = value; } }
        public int TimeToSpawn { get { return this[nameof(TimeToSpawn)].GetValue<int>(); } set { this[nameof(TimeToSpawn)].SetValue<int>(value); } }
        public int ReplicatedTimeToSpawn { get { return this[nameof(ReplicatedTimeToSpawn)].GetValue<int>(); } set { this[nameof(ReplicatedTimeToSpawn)].SetValue<int>(value); } }
        public int TimeBetweenSpawns { get { return this[nameof(TimeBetweenSpawns)].GetValue<int>(); } set { this[nameof(TimeBetweenSpawns)].SetValue<int>(value); } }
        public SkeletalMeshComponent PickupPlatformMesh { get { return this[nameof(PickupPlatformMesh)].As<SkeletalMeshComponent>(); } set { this["PickupPlatformMesh"] = value; } }
        public AnimMontage PlatformOpenMontage { get { return this[nameof(PlatformOpenMontage)].As<AnimMontage>(); } set { this["PlatformOpenMontage"] = value; } }
        public AnimMontage PlatformCloseMontage { get { return this[nameof(PlatformCloseMontage)].As<AnimMontage>(); } set { this["PlatformCloseMontage"] = value; } }
        public ParticleSystemComponent PickupGlow { get { return this[nameof(PickupGlow)].As<ParticleSystemComponent>(); } set { this["PickupGlow"] = value; } }
        public MaterialInterface InactiveMaterial { get { return this[nameof(InactiveMaterial)].As<MaterialInterface>(); } set { this["InactiveMaterial"] = value; } }
        public Array<MaterialInterface> ActiveMaterials { get { return new Array<MaterialInterface>(this[nameof(ActiveMaterials)].Address); } }
        public PortalWarsPickupZoneIndicator PickupIndicatorWidget { get { return this[nameof(PickupIndicatorWidget)].As<PortalWarsPickupZoneIndicator>(); } set { this["PickupIndicatorWidget"] = value; } }
        public PortalWarsAkComponent AkComponent { get { return this[nameof(AkComponent)].As<PortalWarsAkComponent>(); } set { this["AkComponent"] = value; } }
        public AkAudioEvent PlayAmbientLoopEvent { get { return this[nameof(PlayAmbientLoopEvent)].As<AkAudioEvent>(); } set { this["PlayAmbientLoopEvent"] = value; } }
        public AkAudioEvent StopAmbientLoopEvent { get { return this[nameof(StopAmbientLoopEvent)].As<AkAudioEvent>(); } set { this["StopAmbientLoopEvent"] = value; } }
        public bool bHidePickupPlatform { get { return this[nameof(bHidePickupPlatform)].Flag; } set { this[nameof(bHidePickupPlatform)].Flag = value; } }
        public void OnRep_TimeToSpawn() { Invoke(nameof(OnRep_TimeToSpawn)); }
        public void OnRep_IsActive() { Invoke(nameof(OnRep_IsActive)); }
    }
    public class PortalWarsGrenadePickupZone : PortalWarsGunPickupZone
    {
        public PortalWarsGrenadePickupZone(ulong addr) : base(addr) { }
        public Object GrenadeName { get { return this[nameof(GrenadeName)]; } set { this[nameof(GrenadeName)] = value; } }
        public AkAudioEvent PickupEvent { get { return this[nameof(PickupEvent)].As<AkAudioEvent>(); } set { this["PickupEvent"] = value; } }
    }
    public class PortalWarsHappyHourDialogWidget : PortalWarsDialogWidget
    {
        public PortalWarsHappyHourDialogWidget(ulong addr) : base(addr) { }
        public Object GetHappyHourText() { return Invoke<Object>(nameof(GetHappyHourText)); }
    }
    public class PortalWarsHappyHourStatusWidget : UserWidget
    {
        public PortalWarsHappyHourStatusWidget(ulong addr) : base(addr) { }
        public TextBlock HappyHourText { get { return this[nameof(HappyHourText)].As<TextBlock>(); } set { this["HappyHourText"] = value; } }
        public TextBlock TimeRemainingText { get { return this[nameof(TimeRemainingText)].As<TextBlock>(); } set { this["TimeRemainingText"] = value; } }
        public WidgetSwitcher StatusSwitcher { get { return this[nameof(StatusSwitcher)].As<WidgetSwitcher>(); } set { this["StatusSwitcher"] = value; } }
        public void UpdateWidget() { Invoke(nameof(UpdateWidget)); }
        public bool IsHappyHourLive() { return Invoke<bool>(nameof(IsHappyHourLive)); }
        public Object GetTimeRemainingText() { return Invoke<Object>(nameof(GetTimeRemainingText)); }
        public Object GetHappyHourText() { return Invoke<Object>(nameof(GetHappyHourText)); }
    }
    public class PortalWarsHealthWidget : UserWidget
    {
        public PortalWarsHealthWidget(ulong addr) : base(addr) { }
        public TextBlock HealthText { get { return this[nameof(HealthText)].As<TextBlock>(); } set { this["HealthText"] = value; } }
        public ProgressBar HealthBar { get { return this[nameof(HealthBar)].As<ProgressBar>(); } set { this["HealthBar"] = value; } }
        public SizeBox HealthBarSizeBox { get { return this[nameof(HealthBarSizeBox)].As<SizeBox>(); } set { this["HealthBarSizeBox"] = value; } }
        public ProgressBar DamageHealthBar { get { return this[nameof(DamageHealthBar)].As<ProgressBar>(); } set { this["DamageHealthBar"] = value; } }
        public Widget DamageIndicator { get { return this[nameof(DamageIndicator)].As<Widget>(); } set { this["DamageIndicator"] = value; } }
    }
    public class PortalWarsHostMenuWidget : PortalWarsMenuWidget
    {
        public PortalWarsHostMenuWidget(ulong addr) : base(addr) { }
        public PortalWarsButtonWidget HostButton { get { return this[nameof(HostButton)].As<PortalWarsButtonWidget>(); } set { this["HostButton"] = value; } }
        public PortalWarsRadioGroupWidget RegionRadioGroup { get { return this[nameof(RegionRadioGroup)].As<PortalWarsRadioGroupWidget>(); } set { this["RegionRadioGroup"] = value; } }
        public PortalWarsTextInputWidget ServerName { get { return this[nameof(ServerName)].As<PortalWarsTextInputWidget>(); } set { this["ServerName"] = value; } }
        public PortalWarsTextInputWidget ServerPassword { get { return this[nameof(ServerPassword)].As<PortalWarsTextInputWidget>(); } set { this["ServerPassword"] = value; } }
        public PortalWarsCheckBoxWidget PrivateCheckBox { get { return this[nameof(PrivateCheckBox)].As<PortalWarsCheckBoxWidget>(); } set { this["PrivateCheckBox"] = value; } }
        public PortalWarsNumericCarouselWidget MaxPlayersInput { get { return this[nameof(MaxPlayersInput)].As<PortalWarsNumericCarouselWidget>(); } set { this["MaxPlayersInput"] = value; } }
        public PortalWarsRadioGroupWidget TypeRadioGroup { get { return this[nameof(TypeRadioGroup)].As<PortalWarsRadioGroupWidget>(); } set { this["TypeRadioGroup"] = value; } }
        public PortalWarsGameInstance GameInstanceRef { get { return this[nameof(GameInstanceRef)].As<PortalWarsGameInstance>(); } set { this["GameInstanceRef"] = value; } }
        public void OnServerPasswordValueChanged() { Invoke(nameof(OnServerPasswordValueChanged)); }
        public void OnServerNameValueChanged() { Invoke(nameof(OnServerNameValueChanged)); }
        public void OnRegionSelectionChanged() { Invoke(nameof(OnRegionSelectionChanged)); }
        public void OnPrivateCheckBoxValueChanged() { Invoke(nameof(OnPrivateCheckBoxValueChanged)); }
        public void HostGame() { Invoke(nameof(HostGame)); }
        public ESlateVisibility GetPrivateVisibility() { return Invoke<ESlateVisibility>(nameof(GetPrivateVisibility)); }
        public bool GetHostButtonEnabled() { return Invoke<bool>(nameof(GetHostButtonEnabled)); }
    }
    public class PortalWarsHUDWidget : UserWidget
    {
        public PortalWarsHUDWidget(ulong addr) : base(addr) { }
        public PortalWarsHealthWidget Health { get { return this[nameof(Health)].As<PortalWarsHealthWidget>(); } set { this["Health"] = value; } }
        public Image LowHealthOverlay { get { return this[nameof(LowHealthOverlay)].As<Image>(); } set { this["LowHealthOverlay"] = value; } }
        public Overlay JetpackOverlay { get { return this[nameof(JetpackOverlay)].As<Overlay>(); } set { this["JetpackOverlay"] = value; } }
        public CanvasPanel JetpackCanvas { get { return this[nameof(JetpackCanvas)].As<CanvasPanel>(); } set { this["JetpackCanvas"] = value; } }
        public ProgressBar JetpackProgressBar { get { return this[nameof(JetpackProgressBar)].As<ProgressBar>(); } set { this["JetpackProgressBar"] = value; } }
        public CanvasPanel IndicatorPanel { get { return this[nameof(IndicatorPanel)].As<CanvasPanel>(); } set { this["IndicatorPanel"] = value; } }
        public Object NameIndicatorWidgetClass { get { return this[nameof(NameIndicatorWidgetClass)]; } set { this[nameof(NameIndicatorWidgetClass)] = value; } }
        public Object PortalIndicatorWidgetClass { get { return this[nameof(PortalIndicatorWidgetClass)]; } set { this[nameof(PortalIndicatorWidgetClass)] = value; } }
        public Object PickupIndicatorZoneClass { get { return this[nameof(PickupIndicatorZoneClass)]; } set { this[nameof(PickupIndicatorZoneClass)] = value; } }
        public PortalWarsPickupWidget PickupWidget { get { return this[nameof(PickupWidget)].As<PortalWarsPickupWidget>(); } set { this["PickupWidget"] = value; } }
        public Overlay DamageIndicatorOverlay { get { return this[nameof(DamageIndicatorOverlay)].As<Overlay>(); } set { this["DamageIndicatorOverlay"] = value; } }
        public Object DamageIndicatorWidgetClass { get { return this[nameof(DamageIndicatorWidgetClass)]; } set { this[nameof(DamageIndicatorWidgetClass)] = value; } }
        public PortalWarsReticleWidget Reticle { get { return this[nameof(Reticle)].As<PortalWarsReticleWidget>(); } set { this["Reticle"] = value; } }
        public PortalWarsRadarWidget Radar { get { return this[nameof(Radar)].As<PortalWarsRadarWidget>(); } set { this["Radar"] = value; } }
        public PortalWarsRespawnWidget RespawnTimer { get { return this[nameof(RespawnTimer)].As<PortalWarsRespawnWidget>(); } set { this["RespawnTimer"] = value; } }
        public Object DamageNumberEntryWidgetClass { get { return this[nameof(DamageNumberEntryWidgetClass)]; } set { this[nameof(DamageNumberEntryWidgetClass)] = value; } }
        public int MaxDamageNumberEntries { get { return this[nameof(MaxDamageNumberEntries)].GetValue<int>(); } set { this[nameof(MaxDamageNumberEntries)].SetValue<int>(value); } }
        public float DamageNumberEntryDisplayTime { get { return this[nameof(DamageNumberEntryDisplayTime)].GetValue<float>(); } set { this[nameof(DamageNumberEntryDisplayTime)].SetValue<float>(value); } }
        public PanelWidget DamageNumbersPanel { get { return this[nameof(DamageNumbersPanel)].As<PanelWidget>(); } set { this["DamageNumbersPanel"] = value; } }
        public PanelWidget KillStack { get { return this[nameof(KillStack)].As<PanelWidget>(); } set { this["KillStack"] = value; } }
        public Object KillStackEntryWidgetClass { get { return this[nameof(KillStackEntryWidgetClass)]; } set { this[nameof(KillStackEntryWidgetClass)] = value; } }
        public int MaxKillStackEntries { get { return this[nameof(MaxKillStackEntries)].GetValue<int>(); } set { this[nameof(MaxKillStackEntries)].SetValue<int>(value); } }
        public float KillStackEntryDisplayTime { get { return this[nameof(KillStackEntryDisplayTime)].GetValue<float>(); } set { this[nameof(KillStackEntryDisplayTime)].SetValue<float>(value); } }
        public PanelWidget KillFeed { get { return this[nameof(KillFeed)].As<PanelWidget>(); } set { this["KillFeed"] = value; } }
        public Object KillFeedEntryWidgetClass { get { return this[nameof(KillFeedEntryWidgetClass)]; } set { this[nameof(KillFeedEntryWidgetClass)] = value; } }
        public int MaxKillFeedEntries { get { return this[nameof(MaxKillFeedEntries)].GetValue<int>(); } set { this[nameof(MaxKillFeedEntries)].SetValue<int>(value); } }
        public float KillFeedEntryDisplayTime { get { return this[nameof(KillFeedEntryDisplayTime)].GetValue<float>(); } set { this[nameof(KillFeedEntryDisplayTime)].SetValue<float>(value); } }
        public PortalWarsKilledByBannerWidget KilledByBanner { get { return this[nameof(KilledByBanner)].As<PortalWarsKilledByBannerWidget>(); } set { this["KilledByBanner"] = value; } }
        public PortalWarsLowAmmoIndicatorWidget LowAmmoIndicator { get { return this[nameof(LowAmmoIndicator)].As<PortalWarsLowAmmoIndicatorWidget>(); } set { this["LowAmmoIndicator"] = value; } }
        public TextBlock SpectatingWhileDeadName { get { return this[nameof(SpectatingWhileDeadName)].As<TextBlock>(); } set { this["SpectatingWhileDeadName"] = value; } }
        public PortalWarsOutOfBoundsWidget OutOfBounds { get { return this[nameof(OutOfBounds)].As<PortalWarsOutOfBoundsWidget>(); } set { this["OutOfBounds"] = value; } }
        public PortalWarsInventoryWidget Inventory { get { return this[nameof(Inventory)].As<PortalWarsInventoryWidget>(); } set { this["Inventory"] = value; } }
        public PortalWarsMedalsWidget Medals { get { return this[nameof(Medals)].As<PortalWarsMedalsWidget>(); } set { this["Medals"] = value; } }
        public TextBlock SubtitleTextBlock { get { return this[nameof(SubtitleTextBlock)].As<TextBlock>(); } set { this["SubtitleTextBlock"] = value; } }
        public float SubtitleDisplayTime { get { return this[nameof(SubtitleDisplayTime)].GetValue<float>(); } set { this[nameof(SubtitleDisplayTime)].SetValue<float>(value); } }
        public Widget ScorePanel { get { return this[nameof(ScorePanel)].As<Widget>(); } set { this["ScorePanel"] = value; } }
        public Widget WaitingAreaIndicator { get { return this[nameof(WaitingAreaIndicator)].As<Widget>(); } set { this["WaitingAreaIndicator"] = value; } }
        public void ShowSubtitle() { Invoke(nameof(ShowSubtitle)); }
        public void ProcessKill(PortalWarsPlayerState KillerPlayerState, PortalWarsPlayerState KilledPlayerState, DamageType KillerDamageType, bool bIsHeadshot, float DamageDealt) { Invoke(nameof(ProcessKill), KillerPlayerState, KilledPlayerState, KillerDamageType, bIsHeadshot, DamageDealt); }
        public void HideSubtitle() { Invoke(nameof(HideSubtitle)); }
        public ESlateVisibility GetRadarVisibility() { return Invoke<ESlateVisibility>(nameof(GetRadarVisibility)); }
        public LinearColor GetLowHealthOpacity() { return Invoke<LinearColor>(nameof(GetLowHealthOpacity)); }
        public ESlateVisibility GetJetpackVisibility() { return Invoke<ESlateVisibility>(nameof(GetJetpackVisibility)); }
        public float GetJetpackPercent() { return Invoke<float>(nameof(GetJetpackPercent)); }
    }
    public class PortalWarsIKAnimInstance : AnimInstance
    {
        public PortalWarsIKAnimInstance(ulong addr) : base(addr) { }
        public PortalWarsCharacter Character { get { return this[nameof(Character)].As<PortalWarsCharacter>(); } set { this["Character"] = value; } }
        public Rotator IKRootRotation { get { return this[nameof(IKRootRotation)].As<Rotator>(); } set { this["IKRootRotation"] = value; } }
        public Vector IKRootTranslation { get { return this[nameof(IKRootTranslation)].As<Vector>(); } set { this["IKRootTranslation"] = value; } }
        public Vector RootTranslation { get { return this[nameof(RootTranslation)].As<Vector>(); } set { this["RootTranslation"] = value; } }
        public bool bIsMoving { get { return this[nameof(bIsMoving)].Flag; } set { this[nameof(bIsMoving)].Flag = value; } }
        public float MoveSpeed { get { return this[nameof(MoveSpeed)].GetValue<float>(); } set { this[nameof(MoveSpeed)].SetValue<float>(value); } }
        public bool bIsFalling { get { return this[nameof(bIsFalling)].Flag; } set { this[nameof(bIsFalling)].Flag = value; } }
    }
    public class PortalWarsInputDecoratorWidget : PortalWarsUserWidget
    {
        public PortalWarsInputDecoratorWidget(ulong addr) : base(addr) { }
        public PanelWidget MainPanel { get { return this[nameof(MainPanel)].As<PanelWidget>(); } set { this["MainPanel"] = value; } }
        public Object RichText { get { return this[nameof(RichText)]; } set { this[nameof(RichText)] = value; } }
        public Array<Object> InputActions { get { return new Array<Object>(this[nameof(InputActions)].Address); } }
        public bool KeyboardBrackets { get { return this[nameof(KeyboardBrackets)].Flag; } set { this[nameof(KeyboardBrackets)].Flag = value; } }
        public Vector2D IconSize { get { return this[nameof(IconSize)].As<Vector2D>(); } set { this["IconSize"] = value; } }
        public DataTable TextStyleSet { get { return this[nameof(TextStyleSet)].As<DataTable>(); } set { this["TextStyleSet"] = value; } }
        public void RefreshWidget() { Invoke(nameof(RefreshWidget)); }
    }
    public class PortalWarsInspectItemWidget : UserWidget
    {
        public PortalWarsInspectItemWidget(ulong addr) : base(addr) { }
        public Image PreviewImage { get { return this[nameof(PreviewImage)].As<Image>(); } set { this["PreviewImage"] = value; } }
        public MaterialInterface PreviewMaterialBase { get { return this[nameof(PreviewMaterialBase)].As<MaterialInterface>(); } set { this["PreviewMaterialBase"] = value; } }
        public PortalWarsPlayerEntryWidget PlayerEntry { get { return this[nameof(PlayerEntry)].As<PortalWarsPlayerEntryWidget>(); } set { this["PlayerEntry"] = value; } }
        public WidgetSwitcher InspectSwitcher { get { return this[nameof(InspectSwitcher)].As<WidgetSwitcher>(); } set { this["InspectSwitcher"] = value; } }
        public WidgetAnimation FadeInAnimation { get { return this[nameof(FadeInAnimation)].As<WidgetAnimation>(); } set { this["FadeInAnimation"] = value; } }
        public WidgetAnimation FadeOutAnimation { get { return this[nameof(FadeOutAnimation)].As<WidgetAnimation>(); } set { this["FadeOutAnimation"] = value; } }
    }
    public class PortalWarsIntroVideoWidget : PortalWarsDialogWidget
    {
        public PortalWarsIntroVideoWidget(ulong addr) : base(addr) { }
        public MediaPlayer MediaPlayer { get { return this[nameof(MediaPlayer)].As<MediaPlayer>(); } set { this["MediaPlayer"] = value; } }
        public MediaSource MediaSource { get { return this[nameof(MediaSource)].As<MediaSource>(); } set { this["MediaSource"] = value; } }
        public void OnMediaOpenFailed(Object FailedUrl) { Invoke(nameof(OnMediaOpenFailed), FailedUrl); }
    }
    public class PortalWarsInventoryWidget : PortalWarsUserWidget
    {
        public PortalWarsInventoryWidget(ulong addr) : base(addr) { }
        public TextBlock CurrentAmmoText { get { return this[nameof(CurrentAmmoText)].As<TextBlock>(); } set { this["CurrentAmmoText"] = value; } }
        public TextBlock ReserveAmmoText { get { return this[nameof(ReserveAmmoText)].As<TextBlock>(); } set { this["ReserveAmmoText"] = value; } }
        public TextBlock NumGrenadesText { get { return this[nameof(NumGrenadesText)].As<TextBlock>(); } set { this["NumGrenadesText"] = value; } }
        public Widget SecondaryRoot { get { return this[nameof(SecondaryRoot)].As<Widget>(); } set { this["SecondaryRoot"] = value; } }
        public TextBlock PrimaryWeaponNameText { get { return this[nameof(PrimaryWeaponNameText)].As<TextBlock>(); } set { this["PrimaryWeaponNameText"] = value; } }
        public TextBlock SecondaryWeaponNameText { get { return this[nameof(SecondaryWeaponNameText)].As<TextBlock>(); } set { this["SecondaryWeaponNameText"] = value; } }
        public Image PrimaryWeaponImage { get { return this[nameof(PrimaryWeaponImage)].As<Image>(); } set { this["PrimaryWeaponImage"] = value; } }
        public Image SecondaryWeaponImage { get { return this[nameof(SecondaryWeaponImage)].As<Image>(); } set { this["SecondaryWeaponImage"] = value; } }
        public SizeBox PrimaryWeaponImageSizeBox { get { return this[nameof(PrimaryWeaponImageSizeBox)].As<SizeBox>(); } set { this["PrimaryWeaponImageSizeBox"] = value; } }
        public SizeBox SecondaryWeaponImageSizeBox { get { return this[nameof(SecondaryWeaponImageSizeBox)].As<SizeBox>(); } set { this["SecondaryWeaponImageSizeBox"] = value; } }
    }
    public class PortalWarsInviteEntryWidget : PortalWarsNotificationEntryWidget
    {
        public PortalWarsInviteEntryWidget(ulong addr) : base(addr) { }
        public void OnPendingInvitesUpdated() { Invoke(nameof(OnPendingInvitesUpdated)); }
    }
    public class PortalWarsInviteManager : Object
    {
        public PortalWarsInviteManager(ulong addr) : base(addr) { }
        public Object AcceptDialogWidgetClass { get { return this[nameof(AcceptDialogWidgetClass)]; } set { this[nameof(AcceptDialogWidgetClass)] = value; } }
        public void OnMainMenu() { Invoke(nameof(OnMainMenu)); }
    }
    public class PortalWarsInviteMenuWidget : PortalWarsMenuWidget
    {
        public PortalWarsInviteMenuWidget(ulong addr) : base(addr) { }
        public Object InviteEntryWidgetClass { get { return this[nameof(InviteEntryWidgetClass)]; } set { this[nameof(InviteEntryWidgetClass)] = value; } }
        public PanelWidget NotificationPanel { get { return this[nameof(NotificationPanel)].As<PanelWidget>(); } set { this["NotificationPanel"] = value; } }
        public WidgetSwitcher NotificationSwitcher { get { return this[nameof(NotificationSwitcher)].As<WidgetSwitcher>(); } set { this["NotificationSwitcher"] = value; } }
        public void RefreshInviteEntries() { Invoke(nameof(RefreshInviteEntries)); }
    }
    public class PortalWarsItemPurchaseDialog : PortalWarsTxnDialogWidget
    {
        public PortalWarsItemPurchaseDialog(ulong addr) : base(addr) { }
    }
    public class PortalWarsItemShopEntry : PortalWarsEntryWidget
    {
        public PortalWarsItemShopEntry(ulong addr) : base(addr) { }
        public TextBlock SubtitleText { get { return this[nameof(SubtitleText)].As<TextBlock>(); } set { this["SubtitleText"] = value; } }
        public Image DisplayImage { get { return this[nameof(DisplayImage)].As<Image>(); } set { this["DisplayImage"] = value; } }
        public Image RarityIcon { get { return this[nameof(RarityIcon)].As<Image>(); } set { this["RarityIcon"] = value; } }
        public Image RarityBG { get { return this[nameof(RarityBG)].As<Image>(); } set { this["RarityBG"] = value; } }
        public Image RarityBorder { get { return this[nameof(RarityBorder)].As<Image>(); } set { this["RarityBorder"] = value; } }
        public Image RarityScrim { get { return this[nameof(RarityScrim)].As<Image>(); } set { this["RarityScrim"] = value; } }
        public Object RarityBackgrounds { get { return this[nameof(RarityBackgrounds)]; } set { this[nameof(RarityBackgrounds)] = value; } }
        public Object RarityScrims { get { return this[nameof(RarityScrims)]; } set { this[nameof(RarityScrims)] = value; } }
        public Object RarityTitleColors { get { return this[nameof(RarityTitleColors)]; } set { this[nameof(RarityTitleColors)] = value; } }
        public Object RarityBorderColors { get { return this[nameof(RarityBorderColors)]; } set { this[nameof(RarityBorderColors)] = value; } }
        public WidgetSwitcher OwnedSwitcher { get { return this[nameof(OwnedSwitcher)].As<WidgetSwitcher>(); } set { this["OwnedSwitcher"] = value; } }
        public LinearColor DefaultSubtitleColor { get { return this[nameof(DefaultSubtitleColor)].As<LinearColor>(); } set { this["DefaultSubtitleColor"] = value; } }
        public LinearColor HoveredSubtitleColor { get { return this[nameof(HoveredSubtitleColor)].As<LinearColor>(); } set { this["HoveredSubtitleColor"] = value; } }
        public Object ThumbnailPaddings { get { return this[nameof(ThumbnailPaddings)]; } set { this[nameof(ThumbnailPaddings)] = value; } }
        public Object RenderAngles { get { return this[nameof(RenderAngles)]; } set { this[nameof(RenderAngles)] = value; } }
        public void RefreshNewState() { Invoke(nameof(RefreshNewState)); }
        public Object GetTitleText() { return Invoke<Object>(nameof(GetTitleText)); }
        public Object GetSubtitleText() { return Invoke<Object>(nameof(GetSubtitleText)); }
        public Texture2D GetRarityScrim() { return Invoke<Texture2D>(nameof(GetRarityScrim)); }
        public Texture2D GetRarityIcon() { return Invoke<Texture2D>(nameof(GetRarityIcon)); }
        public LinearColor GetRarityColor() { return Invoke<LinearColor>(nameof(GetRarityColor)); }
        public LinearColor GetRarityBorderColor() { return Invoke<LinearColor>(nameof(GetRarityBorderColor)); }
        public Texture2D GetRarityBG() { return Invoke<Texture2D>(nameof(GetRarityBG)); }
    }
    public class PortalWarsItemShopInspectWidget : PortalWarsInspectWidget
    {
        public PortalWarsItemShopInspectWidget(ulong addr) : base(addr) { }
        public Widget ItemsRoot { get { return this[nameof(ItemsRoot)].As<Widget>(); } set { this["ItemsRoot"] = value; } }
        public PortalWarsCustomScrollWidget ItemsPanel { get { return this[nameof(ItemsPanel)].As<PortalWarsCustomScrollWidget>(); } set { this["ItemsPanel"] = value; } }
        public Object ItemEntryWidgetClass { get { return this[nameof(ItemEntryWidgetClass)]; } set { this[nameof(ItemEntryWidgetClass)] = value; } }
        public PortalWarsItemShopPurchasePanel PurchasePanel { get { return this[nameof(PurchasePanel)].As<PortalWarsItemShopPurchasePanel>(); } set { this["PurchasePanel"] = value; } }
        public PortalWarsItemShopPurchasePanel IndividualPurchasePanel { get { return this[nameof(IndividualPurchasePanel)].As<PortalWarsItemShopPurchasePanel>(); } set { this["IndividualPurchasePanel"] = value; } }
        public Widget PurchasableDescriptionRoot { get { return this[nameof(PurchasableDescriptionRoot)].As<Widget>(); } set { this["PurchasableDescriptionRoot"] = value; } }
        public TextBlock PurchasableDescriptionText { get { return this[nameof(PurchasableDescriptionText)].As<TextBlock>(); } set { this["PurchasableDescriptionText"] = value; } }
        public Object PurchaseDialogWidgetClass { get { return this[nameof(PurchaseDialogWidgetClass)]; } set { this[nameof(PurchaseDialogWidgetClass)] = value; } }
        public void UpdatePurchaseState() { Invoke(nameof(UpdatePurchaseState)); }
        public void OnPurchaseButtonClicked() { Invoke(nameof(OnPurchaseButtonClicked)); }
        public void OnItemEntrySelected(PortalWarsEntryWidget Entry) { Invoke(nameof(OnItemEntrySelected), Entry); }
        public void OnItemEntryScrolledTo(Widget Widget) { Invoke(nameof(OnItemEntryScrolledTo), Widget); }
        public void OnIndividualPurchaseButtonClicked() { Invoke(nameof(OnIndividualPurchaseButtonClicked)); }
        public ESlateVisibility GetItemsVisibility() { return Invoke<ESlateVisibility>(nameof(GetItemsVisibility)); }
    }
    public class PortalWarsItemShopPurchasePanel : PortalWarsUserWidget
    {
        public PortalWarsItemShopPurchasePanel(ulong addr) : base(addr) { }
        public TextBlock TitleText { get { return this[nameof(TitleText)].As<TextBlock>(); } set { this["TitleText"] = value; } }
        public TextBlock ItemTitleText { get { return this[nameof(ItemTitleText)].As<TextBlock>(); } set { this["ItemTitleText"] = value; } }
        public TextBlock ItemSubtitleText { get { return this[nameof(ItemSubtitleText)].As<TextBlock>(); } set { this["ItemSubtitleText"] = value; } }
        public PortalWarsItemShopEntry ItemShopEntry { get { return this[nameof(ItemShopEntry)].As<PortalWarsItemShopEntry>(); } set { this["ItemShopEntry"] = value; } }
        public WidgetSwitcher OwnedSwitcher { get { return this[nameof(OwnedSwitcher)].As<WidgetSwitcher>(); } set { this["OwnedSwitcher"] = value; } }
        public PortalWarsPurchaseButtonWidget PurchaseButton { get { return this[nameof(PurchaseButton)].As<PortalWarsPurchaseButtonWidget>(); } set { this["PurchaseButton"] = value; } }
        public Key GamepadKey { get { return this[nameof(GamepadKey)].As<Key>(); } set { this["GamepadKey"] = value; } }
        public void RefreshWidget() { Invoke(nameof(RefreshWidget)); }
        public void OnPurchaseButtonClicked() { Invoke(nameof(OnPurchaseButtonClicked)); }
        public Object GetTitleText() { return Invoke<Object>(nameof(GetTitleText)); }
        public Object GetItemTitleText() { return Invoke<Object>(nameof(GetItemTitleText)); }
        public Object GetItemSubtitleText() { return Invoke<Object>(nameof(GetItemSubtitleText)); }
    }
    public class PortalWarsItemShopWidget : PortalWarsMenuWidget
    {
        public PortalWarsItemShopWidget(ulong addr) : base(addr) { }
        public Object ItemShopSectionWidgetClass { get { return this[nameof(ItemShopSectionWidgetClass)]; } set { this[nameof(ItemShopSectionWidgetClass)] = value; } }
        public PortalWarsItemShopSectionWidget BattlePassSection { get { return this[nameof(BattlePassSection)].As<PortalWarsItemShopSectionWidget>(); } set { this["BattlePassSection"] = value; } }
        public Object BattlePassSectionWidgetClass { get { return this[nameof(BattlePassSectionWidgetClass)]; } set { this[nameof(BattlePassSectionWidgetClass)] = value; } }
        public PortalWarsItemShopSectionWidget CurrencySection { get { return this[nameof(CurrencySection)].As<PortalWarsItemShopSectionWidget>(); } set { this["CurrencySection"] = value; } }
        public Object CurrencySectionWidgetClass { get { return this[nameof(CurrencySectionWidgetClass)]; } set { this[nameof(CurrencySectionWidgetClass)] = value; } }
        public PortalWarsNavBarWidget ScrollNavBar { get { return this[nameof(ScrollNavBar)].As<PortalWarsNavBarWidget>(); } set { this["ScrollNavBar"] = value; } }
        public ScrollBox ItemsPanel { get { return this[nameof(ItemsPanel)].As<ScrollBox>(); } set { this["ItemsPanel"] = value; } }
        public Button PreviousButton { get { return this[nameof(PreviousButton)].As<Button>(); } set { this["PreviousButton"] = value; } }
        public Button NextButton { get { return this[nameof(NextButton)].As<Button>(); } set { this["NextButton"] = value; } }
        public PortalWarsItemShopInspectWidget InspectWidget { get { return this[nameof(InspectWidget)].As<PortalWarsItemShopInspectWidget>(); } set { this["InspectWidget"] = value; } }
        public void RefreshButtons() { Invoke(nameof(RefreshButtons)); }
        public void OnUserScrolled(float CurrentOffset) { Invoke(nameof(OnUserScrolled), CurrentOffset); }
        public void OnProgressionUpdate() { Invoke(nameof(OnProgressionUpdate)); }
        public void OnPreviousButtonClicked() { Invoke(nameof(OnPreviousButtonClicked)); }
        public void OnNextButtonClicked() { Invoke(nameof(OnNextButtonClicked)); }
        public void OnEntrySelected(PortalWarsEntryWidget Entry) { Invoke(nameof(OnEntrySelected), Entry); }
        public void InitEntries() { Invoke(nameof(InitEntries)); }
        public void GoToScrollState(byte NewState) { Invoke(nameof(GoToScrollState), NewState); }
        public void GoToMainState() { Invoke(nameof(GoToMainState)); }
        public void GoToInspectState() { Invoke(nameof(GoToInspectState)); }
        public PortalWarsItemShopSectionWidget GetSectionWidgetForState(int State) { return Invoke<PortalWarsItemShopSectionWidget>(nameof(GetSectionWidgetForState), State); }
    }
    public class PortalWarsJoinInProgressWidget : UserWidget
    {
        public PortalWarsJoinInProgressWidget(ulong addr) : base(addr) { }
        public WidgetAnimation FadeOutAnimation { get { return this[nameof(FadeOutAnimation)].As<WidgetAnimation>(); } set { this["FadeOutAnimation"] = value; } }
        public float TimeBeforeFadingOut { get { return this[nameof(TimeBeforeFadingOut)].GetValue<float>(); } set { this[nameof(TimeBeforeFadingOut)].SetValue<float>(value); } }
        public void PlayFadeOutAnimation() { Invoke(nameof(PlayFadeOutAnimation)); }
    }
    public class PortalWarsJoinServerDialogWidget : PortalWarsDialogWidget
    {
        public PortalWarsJoinServerDialogWidget(ulong addr) : base(addr) { }
        public WidgetSwitcher JoinSwitcher { get { return this[nameof(JoinSwitcher)].As<WidgetSwitcher>(); } set { this["JoinSwitcher"] = value; } }
        public TextBlock DisabledText { get { return this[nameof(DisabledText)].As<TextBlock>(); } set { this["DisabledText"] = value; } }
        public PortalWarsButtonWidget JoinButton { get { return this[nameof(JoinButton)].As<PortalWarsButtonWidget>(); } set { this["JoinButton"] = value; } }
        public TextBlock JoinDisabledText { get { return this[nameof(JoinDisabledText)].As<TextBlock>(); } set { this["JoinDisabledText"] = value; } }
        public PortalWarsButtonWidget SpectateButton { get { return this[nameof(SpectateButton)].As<PortalWarsButtonWidget>(); } set { this["SpectateButton"] = value; } }
        public TextBlock SpectateDisabledText { get { return this[nameof(SpectateDisabledText)].As<TextBlock>(); } set { this["SpectateDisabledText"] = value; } }
        public PortalWarsTextInputWidget PasswordInput { get { return this[nameof(PasswordInput)].As<PortalWarsTextInputWidget>(); } set { this["PasswordInput"] = value; } }
        public PortalWarsServerEntryWidget ServerEntry { get { return this[nameof(ServerEntry)].As<PortalWarsServerEntryWidget>(); } set { this["ServerEntry"] = value; } }
        public void UpdateButtons() { Invoke(nameof(UpdateButtons)); }
        public void SpectateServer() { Invoke(nameof(SpectateServer)); }
        public void RefreshWidget() { Invoke(nameof(RefreshWidget)); }
        public void OnPasswordTextChanged() { Invoke(nameof(OnPasswordTextChanged)); }
        public void JoinServer() { Invoke(nameof(JoinServer)); }
        public bool GetSpectateEnabled() { return Invoke<bool>(nameof(GetSpectateEnabled)); }
        public Object GetSpectateDisabledText() { return Invoke<Object>(nameof(GetSpectateDisabledText)); }
        public ESlateVisibility GetPasswordVisibility() { return Invoke<ESlateVisibility>(nameof(GetPasswordVisibility)); }
        public bool GetJoinEnabled() { return Invoke<bool>(nameof(GetJoinEnabled)); }
        public Object GetJoinDisabledText() { return Invoke<Object>(nameof(GetJoinDisabledText)); }
    }
    public class PortalWarsKeybindOverlayWidget : PortalWarsDialogWidget
    {
        public PortalWarsKeybindOverlayWidget(ulong addr) : base(addr) { }
        public TextBlock TitleText { get { return this[nameof(TitleText)].As<TextBlock>(); } set { this["TitleText"] = value; } }
    }
    public class PortalWarsKeybindSettingsWidget : PortalWarsSettingsSubWidget
    {
        public PortalWarsKeybindSettingsWidget(ulong addr) : base(addr) { }
        public Array<PortalWarsKeybindWidget> KeybindItems { get { return new Array<PortalWarsKeybindWidget>(this[nameof(KeybindItems)].Address); } }
        public Widget WarningRoot { get { return this[nameof(WarningRoot)].As<Widget>(); } set { this["WarningRoot"] = value; } }
        public TextBlock WarningText { get { return this[nameof(WarningText)].As<TextBlock>(); } set { this["WarningText"] = value; } }
        public void OnSecondaryKeyBound(PortalWarsKeybindWidget Widget) { Invoke(nameof(OnSecondaryKeyBound), Widget); }
        public void OnPrimaryKeyBound(PortalWarsKeybindWidget Widget) { Invoke(nameof(OnPrimaryKeyBound), Widget); }
        public void OnFailedKeyBound(PortalWarsKeybindWidget Widget, Object Reason) { Invoke(nameof(OnFailedKeyBound), Widget, Reason); }
        public ESlateVisibility GetWarningVisibility() { return Invoke<ESlateVisibility>(nameof(GetWarningVisibility)); }
    }
    public class PortalWarsKeybindWidget : PortalWarsInputWidget
    {
        public PortalWarsKeybindWidget(ulong addr) : base(addr) { }
        public Button PrimaryButton { get { return this[nameof(PrimaryButton)].As<Button>(); } set { this["PrimaryButton"] = value; } }
        public Button SecondaryButton { get { return this[nameof(SecondaryButton)].As<Button>(); } set { this["SecondaryButton"] = value; } }
        public TextBlock PrimaryText { get { return this[nameof(PrimaryText)].As<TextBlock>(); } set { this["PrimaryText"] = value; } }
        public TextBlock SecondaryText { get { return this[nameof(SecondaryText)].As<TextBlock>(); } set { this["SecondaryText"] = value; } }
        public Object KeybindOverlayClass { get { return this[nameof(KeybindOverlayClass)]; } set { this[nameof(KeybindOverlayClass)] = value; } }
        public Object KeyBindAction { get { return this[nameof(KeyBindAction)]; } set { this[nameof(KeyBindAction)] = value; } }
        public void OnSecondaryKeyPressed(Key Key) { Invoke(nameof(OnSecondaryKeyPressed), Key); }
        public void OnSecondaryButtonUnhovered() { Invoke(nameof(OnSecondaryButtonUnhovered)); }
        public void OnSecondaryButtonPressed() { Invoke(nameof(OnSecondaryButtonPressed)); }
        public void OnSecondaryButtonHovered() { Invoke(nameof(OnSecondaryButtonHovered)); }
        public void OnPrimaryKeyPressed(Key Key) { Invoke(nameof(OnPrimaryKeyPressed), Key); }
        public void OnPrimaryButtonUnhovered() { Invoke(nameof(OnPrimaryButtonUnhovered)); }
        public void OnPrimaryButtonPressed() { Invoke(nameof(OnPrimaryButtonPressed)); }
        public void OnPrimaryButtonHovered() { Invoke(nameof(OnPrimaryButtonHovered)); }
        public Object GetSecondaryKeyText() { return Invoke<Object>(nameof(GetSecondaryKeyText)); }
        public Object GetPrimaryKeyText() { return Invoke<Object>(nameof(GetPrimaryKeyText)); }
    }
    public class PortalWarsKillcam : Object
    {
        public PortalWarsKillcam(ulong addr) : base(addr) { }
        public DemoNetDriver DemoNetDriver { get { return this[nameof(DemoNetDriver)].As<DemoNetDriver>(); } set { this["DemoNetDriver"] = value; } }
        public PortalWarsPlayerController OwningPlayerController { get { return this[nameof(OwningPlayerController)].As<PortalWarsPlayerController>(); } set { this["OwningPlayerController"] = value; } }
        public void WarmupTick() { Invoke(nameof(WarmupTick)); }
    }
    public class PortalWarsKillcamHeaderWidget : UserWidget
    {
        public PortalWarsKillcamHeaderWidget(ulong addr) : base(addr) { }
        public WidgetAnimation BlinkAnimation { get { return this[nameof(BlinkAnimation)].As<WidgetAnimation>(); } set { this["BlinkAnimation"] = value; } }
        public TextBlock TimerText { get { return this[nameof(TimerText)].As<TextBlock>(); } set { this["TimerText"] = value; } }
    }
    public class PortalWarsKillcamKilledByWidget : UserWidget
    {
        public PortalWarsKillcamKilledByWidget(ulong addr) : base(addr) { }
        public TextBlock NameText { get { return this[nameof(NameText)].As<TextBlock>(); } set { this["NameText"] = value; } }
        public Image AvatarImage { get { return this[nameof(AvatarImage)].As<Image>(); } set { this["AvatarImage"] = value; } }
        public Image RankImage { get { return this[nameof(RankImage)].As<Image>(); } set { this["RankImage"] = value; } }
        public Image WeaponImage { get { return this[nameof(WeaponImage)].As<Image>(); } set { this["WeaponImage"] = value; } }
        public float WeaponImageMaxWidth { get { return this[nameof(WeaponImageMaxWidth)].GetValue<float>(); } set { this[nameof(WeaponImageMaxWidth)].SetValue<float>(value); } }
        public void OnRankImageLoaded() { Invoke(nameof(OnRankImageLoaded)); }
    }
    public class PortalWarsKillcamWidget : UserWidget
    {
        public PortalWarsKillcamWidget(ulong addr) : base(addr) { }
        public PortalWarsKillcamKilledByWidget KilledBy { get { return this[nameof(KilledBy)].As<PortalWarsKillcamKilledByWidget>(); } set { this["KilledBy"] = value; } }
    }
    public class PortalWarsKilledByBannerWidget : UserWidget
    {
        public PortalWarsKilledByBannerWidget(ulong addr) : base(addr) { }
        public Overlay BannerOverlay { get { return this[nameof(BannerOverlay)].As<Overlay>(); } set { this["BannerOverlay"] = value; } }
        public TextBlock KilledByText { get { return this[nameof(KilledByText)].As<TextBlock>(); } set { this["KilledByText"] = value; } }
        public TextBlock HealthText { get { return this[nameof(HealthText)].As<TextBlock>(); } set { this["HealthText"] = value; } }
        public WidgetAnimation FadeOutAnimation { get { return this[nameof(FadeOutAnimation)].As<WidgetAnimation>(); } set { this["FadeOutAnimation"] = value; } }
    }
    public class PortalWarsKillFeedEntryWidget : UserWidget
    {
        public PortalWarsKillFeedEntryWidget(ulong addr) : base(addr) { }
        public TextBlock KillerNameText { get { return this[nameof(KillerNameText)].As<TextBlock>(); } set { this["KillerNameText"] = value; } }
        public TextBlock VictimNameText { get { return this[nameof(VictimNameText)].As<TextBlock>(); } set { this["VictimNameText"] = value; } }
        public SizeBox IconSizeBox { get { return this[nameof(IconSizeBox)].As<SizeBox>(); } set { this["IconSizeBox"] = value; } }
        public Image KillIcon { get { return this[nameof(KillIcon)].As<Image>(); } set { this["KillIcon"] = value; } }
        public Image HeadshotIcon { get { return this[nameof(HeadshotIcon)].As<Image>(); } set { this["HeadshotIcon"] = value; } }
        public LinearColor FriendlyTeamColor { get { return this[nameof(FriendlyTeamColor)].As<LinearColor>(); } set { this["FriendlyTeamColor"] = value; } }
        public LinearColor EnemyTeamColor { get { return this[nameof(EnemyTeamColor)].As<LinearColor>(); } set { this["EnemyTeamColor"] = value; } }
        public LinearColor OwnColor { get { return this[nameof(OwnColor)].As<LinearColor>(); } set { this["OwnColor"] = value; } }
        public LinearColor DefaultColor { get { return this[nameof(DefaultColor)].As<LinearColor>(); } set { this["DefaultColor"] = value; } }
        public LinearColor AlphaTeamColor { get { return this[nameof(AlphaTeamColor)].As<LinearColor>(); } set { this["AlphaTeamColor"] = value; } }
        public LinearColor BravoTeamColor { get { return this[nameof(BravoTeamColor)].As<LinearColor>(); } set { this["BravoTeamColor"] = value; } }
    }
    public class PortalWarsKillStackEntryWidget : UserWidget
    {
        public PortalWarsKillStackEntryWidget(ulong addr) : base(addr) { }
        public WidgetAnimation FadeInAnimation { get { return this[nameof(FadeInAnimation)].As<WidgetAnimation>(); } set { this["FadeInAnimation"] = value; } }
        public WidgetAnimation FadeOutAnimation { get { return this[nameof(FadeOutAnimation)].As<WidgetAnimation>(); } set { this["FadeOutAnimation"] = value; } }
        public RichTextBlock KilledText { get { return this[nameof(KilledText)].As<RichTextBlock>(); } set { this["KilledText"] = value; } }
        public TextBlock DamageText { get { return this[nameof(DamageText)].As<TextBlock>(); } set { this["DamageText"] = value; } }
    }
    public class PortalWarsKOTH : PortalWarsGameMode
    {
        public PortalWarsKOTH(ulong addr) : base(addr) { }
        public PortalWarsKOTHHill ActiveHill { get { return this[nameof(ActiveHill)].As<PortalWarsKOTHHill>(); } set { this["ActiveHill"] = value; } }
        public PortalWarsKOTHHill NextHill { get { return this[nameof(NextHill)].As<PortalWarsKOTHHill>(); } set { this["NextHill"] = value; } }
        public PortalWarsKOTHGameState KOTHGameState { get { return this[nameof(KOTHGameState)].As<PortalWarsKOTHGameState>(); } set { this["KOTHGameState"] = value; } }
        public int HillScore { get { return this[nameof(HillScore)].GetValue<int>(); } set { this[nameof(HillScore)].SetValue<int>(value); } }
        public int HillTime { get { return this[nameof(HillTime)].GetValue<int>(); } set { this[nameof(HillTime)].SetValue<int>(value); } }
        public int NextHillTime { get { return this[nameof(NextHillTime)].GetValue<int>(); } set { this[nameof(NextHillTime)].SetValue<int>(value); } }
        public Array<PortalWarsKOTHHill> Hills { get { return new Array<PortalWarsKOTHHill>(this[nameof(Hills)].Address); } }
    }
    public class PortalWarsKOTHGameState : PortalWarsGameState
    {
        public PortalWarsKOTHGameState(ulong addr) : base(addr) { }
        public PortalWarsKOTHHill ActiveHill { get { return this[nameof(ActiveHill)].As<PortalWarsKOTHHill>(); } set { this["ActiveHill"] = value; } }
        public PortalWarsKOTHHill NextHill { get { return this[nameof(NextHill)].As<PortalWarsKOTHHill>(); } set { this["NextHill"] = value; } }
        public void OnRepNextHill() { Invoke(nameof(OnRepNextHill)); }
        public void OnRepHill(PortalWarsKOTHHill PrevHill) { Invoke(nameof(OnRepHill), PrevHill); }
    }
    public class PortalWarsKOTHHill : Actor
    {
        public PortalWarsKOTHHill(ulong addr) : base(addr) { }
        public int HillTimeRemaining { get { return this[nameof(HillTimeRemaining)].GetValue<int>(); } set { this[nameof(HillTimeRemaining)].SetValue<int>(value); } }
        public EKOTHHillState HillState { get { return (EKOTHHillState)this[nameof(HillState)].GetValue<int>(); } set { this[nameof(HillState)].SetValue<int>((int)value); } }
        public bool bIsInitialHill { get { return this[nameof(bIsInitialHill)].Flag; } set { this[nameof(bIsInitialHill)].Flag = value; } }
        public int Order { get { return this[nameof(Order)].GetValue<int>(); } set { this[nameof(Order)].SetValue<int>(value); } }
        public LinearColor DefaultHillColor { get { return this[nameof(DefaultHillColor)].As<LinearColor>(); } set { this["DefaultHillColor"] = value; } }
        public LinearColor FriendlyTeamHillColor { get { return this[nameof(FriendlyTeamHillColor)].As<LinearColor>(); } set { this["FriendlyTeamHillColor"] = value; } }
        public LinearColor EnemyTeamHillColor { get { return this[nameof(EnemyTeamHillColor)].As<LinearColor>(); } set { this["EnemyTeamHillColor"] = value; } }
        public LinearColor AlphaTeamHillColor { get { return this[nameof(AlphaTeamHillColor)].As<LinearColor>(); } set { this["AlphaTeamHillColor"] = value; } }
        public LinearColor BravoTeamHillColor { get { return this[nameof(BravoTeamHillColor)].As<LinearColor>(); } set { this["BravoTeamHillColor"] = value; } }
        public SceneComponent reachableLocComponent { get { return this[nameof(reachableLocComponent)].As<SceneComponent>(); } set { this["reachableLocComponent"] = value; } }
        public bool bIsActive { get { return this[nameof(bIsActive)].Flag; } set { this[nameof(bIsActive)].Flag = value; } }
        public StaticMeshComponent Mesh { get { return this[nameof(Mesh)].As<StaticMeshComponent>(); } set { this["Mesh"] = value; } }
        public StaticMeshComponent OverlapMesh { get { return this[nameof(OverlapMesh)].As<StaticMeshComponent>(); } set { this["OverlapMesh"] = value; } }
        public void OnRep_IsActive() { Invoke(nameof(OnRep_IsActive)); }
        public void OnRep_HillState(EKOTHHillState PrevState) { Invoke(nameof(OnRep_HillState), PrevState); }
        public int GetControllingTeam() { return Invoke<int>(nameof(GetControllingTeam)); }
    }
    public class PortalWarsKOTHHillIndicator : PortalWarsHillIndicatorWidget
    {
        public PortalWarsKOTHHillIndicator(ulong addr) : base(addr) { }
        public Image OnScreenBackgroundImage { get { return this[nameof(OnScreenBackgroundImage)].As<Image>(); } set { this["OnScreenBackgroundImage"] = value; } }
        public Image OffScreenBackgroundImage { get { return this[nameof(OffScreenBackgroundImage)].As<Image>(); } set { this["OffScreenBackgroundImage"] = value; } }
        public TextBlock OnScreenTimeText { get { return this[nameof(OnScreenTimeText)].As<TextBlock>(); } set { this["OnScreenTimeText"] = value; } }
        public TextBlock OffScreenTimeText { get { return this[nameof(OffScreenTimeText)].As<TextBlock>(); } set { this["OffScreenTimeText"] = value; } }
        public Object GetHillTimeRemaining() { return Invoke<Object>(nameof(GetHillTimeRemaining)); }
    }
    public class PortalWarsKOTHHillStatusWidget : UserWidget
    {
        public PortalWarsKOTHHillStatusWidget(ulong addr) : base(addr) { }
        public Image HillImage { get { return this[nameof(HillImage)].As<Image>(); } set { this["HillImage"] = value; } }
        public TextBlock TimeRemainingText { get { return this[nameof(TimeRemainingText)].As<TextBlock>(); } set { this["TimeRemainingText"] = value; } }
        public TextBlock HillStatusText { get { return this[nameof(HillStatusText)].As<TextBlock>(); } set { this["HillStatusText"] = value; } }
        public HorizontalBox RootHorizontalBox { get { return this[nameof(RootHorizontalBox)].As<HorizontalBox>(); } set { this["RootHorizontalBox"] = value; } }
        public Texture2D ContestedHillTexture { get { return this[nameof(ContestedHillTexture)].As<Texture2D>(); } set { this["ContestedHillTexture"] = value; } }
        public Texture2D ControlledHillTexture { get { return this[nameof(ControlledHillTexture)].As<Texture2D>(); } set { this["ControlledHillTexture"] = value; } }
        public Texture2D RedControlledHillTexture { get { return this[nameof(RedControlledHillTexture)].As<Texture2D>(); } set { this["RedControlledHillTexture"] = value; } }
    }
    public class PortalWarsKOTHHUD : PortalWarsHUD
    {
        public PortalWarsKOTHHUD(ulong addr) : base(addr) { }
        public PortalWarsKOTHHillIndicator HillIndicator { get { return this[nameof(HillIndicator)].As<PortalWarsKOTHHillIndicator>(); } set { this["HillIndicator"] = value; } }
        public PortalWarsKOTHHillIndicator NextHillIndicator { get { return this[nameof(NextHillIndicator)].As<PortalWarsKOTHHillIndicator>(); } set { this["NextHillIndicator"] = value; } }
        public Object HillIndicatorWidgetClass { get { return this[nameof(HillIndicatorWidgetClass)]; } set { this[nameof(HillIndicatorWidgetClass)] = value; } }
        public PortalWarsKOTHHUDOverlayWidget KOTHHUDOverlayWidget { get { return this[nameof(KOTHHUDOverlayWidget)].As<PortalWarsKOTHHUDOverlayWidget>(); } set { this["KOTHHUDOverlayWidget"] = value; } }
        public Object KOTHHUDOverlayWidgetClass { get { return this[nameof(KOTHHUDOverlayWidgetClass)]; } set { this[nameof(KOTHHUDOverlayWidgetClass)] = value; } }
    }
    public class PortalWarsKOTHHUDOverlayWidget : UserWidget
    {
        public PortalWarsKOTHHUDOverlayWidget(ulong addr) : base(addr) { }
        public PortalWarsKOTHHillStatusWidget KOTHHillStatus { get { return this[nameof(KOTHHillStatus)].As<PortalWarsKOTHHillStatusWidget>(); } set { this["KOTHHillStatus"] = value; } }
    }
    public class PortalWarsKOTHPlayerState : PortalWarsPlayerState
    {
        public PortalWarsKOTHPlayerState(ulong addr) : base(addr) { }
        public bool bIsOnHill { get { return this[nameof(bIsOnHill)].Flag; } set { this[nameof(bIsOnHill)].Flag = value; } }
        public void OnRep_IsOnHill() { Invoke(nameof(OnRep_IsOnHill)); }
    }
    public class PortalWarsLeaderboardEntryWidget : PortalWarsPlayerEntryWidget
    {
        public PortalWarsLeaderboardEntryWidget(ulong addr) : base(addr) { }
        public TextBlock PositionText { get { return this[nameof(PositionText)].As<TextBlock>(); } set { this["PositionText"] = value; } }
        public Image PositionImage { get { return this[nameof(PositionImage)].As<Image>(); } set { this["PositionImage"] = value; } }
        public WidgetSwitcher PositionSwitcher { get { return this[nameof(PositionSwitcher)].As<WidgetSwitcher>(); } set { this["PositionSwitcher"] = value; } }
        public Object PositionImages { get { return this[nameof(PositionImages)]; } set { this[nameof(PositionImages)] = value; } }
        public ButtonStyle DefaultButtonStyle { get { return this[nameof(DefaultButtonStyle)].As<ButtonStyle>(); } set { this["DefaultButtonStyle"] = value; } }
        public ButtonStyle PlacementButtonStyle { get { return this[nameof(PlacementButtonStyle)].As<ButtonStyle>(); } set { this["PlacementButtonStyle"] = value; } }
        public Object GetPositionText() { return Invoke<Object>(nameof(GetPositionText)); }
        public Texture2D GetPositionImage() { return Invoke<Texture2D>(nameof(GetPositionImage)); }
        public ButtonStyle GetButtonStyle() { return Invoke<ButtonStyle>(nameof(GetButtonStyle)); }
    }
    public class PortalWarsLeaderboardsWidget : PortalWarsMenuWidget
    {
        public PortalWarsLeaderboardsWidget(ulong addr) : base(addr) { }
        public PortalWarsMenuWidget RankLeaderboardWidget { get { return this[nameof(RankLeaderboardWidget)].As<PortalWarsMenuWidget>(); } set { this["RankLeaderboardWidget"] = value; } }
    }
    public class PortalWarsLimitedTimeOfferDialogWidget : PortalWarsDialogWidget
    {
        public PortalWarsLimitedTimeOfferDialogWidget(ulong addr) : base(addr) { }
        public PortalWarsButtonWidget ViewButton { get { return this[nameof(ViewButton)].As<PortalWarsButtonWidget>(); } set { this["ViewButton"] = value; } }
        public PortalWarsItemShopSectionWidget ItemShopSection { get { return this[nameof(ItemShopSection)].As<PortalWarsItemShopSectionWidget>(); } set { this["ItemShopSection"] = value; } }
        public TextBlock TitleText { get { return this[nameof(TitleText)].As<TextBlock>(); } set { this["TitleText"] = value; } }
        public TextBlock ExpiresInText { get { return this[nameof(ExpiresInText)].As<TextBlock>(); } set { this["ExpiresInText"] = value; } }
        public void OnViewButtonClicked() { Invoke(nameof(OnViewButtonClicked)); }
        public void OnItemEntrySelected(PortalWarsEntryWidget Entry) { Invoke(nameof(OnItemEntrySelected), Entry); }
    }
    public class PortalWarsLineupAnimInstance : AnimInstance
    {
        public PortalWarsLineupAnimInstance(ulong addr) : base(addr) { }
        public PortalWarsLineUpCharacter Character { get { return this[nameof(Character)].As<PortalWarsLineUpCharacter>(); } set { this["Character"] = value; } }
        public bool bIsPlayingEmote { get { return this[nameof(bIsPlayingEmote)].Flag; } set { this[nameof(bIsPlayingEmote)].Flag = value; } }
        public AnimSequence EmoteAnimSequence { get { return this[nameof(EmoteAnimSequence)].As<AnimSequence>(); } set { this["EmoteAnimSequence"] = value; } }
    }
    public class PortalWarsLineUpCharacter : Actor
    {
        public PortalWarsLineUpCharacter(ulong addr) : base(addr) { }
        public PortalWarsPlayerState PlayerState { get { return this[nameof(PlayerState)].As<PortalWarsPlayerState>(); } set { this["PlayerState"] = value; } }
        public EndGamePlayerInfo PlayerInfo { get { return this[nameof(PlayerInfo)].As<EndGamePlayerInfo>(); } set { this["PlayerInfo"] = value; } }
        public AnimSequence EmoteSequence { get { return this[nameof(EmoteSequence)].As<AnimSequence>(); } set { this["EmoteSequence"] = value; } }
        public Object PlayerEntryWidgetClass { get { return this[nameof(PlayerEntryWidgetClass)]; } set { this[nameof(PlayerEntryWidgetClass)] = value; } }
        public ECustomizationType CurrentWeaponType { get { return (ECustomizationType)this[nameof(CurrentWeaponType)].GetValue<int>(); } set { this[nameof(CurrentWeaponType)].SetValue<int>((int)value); } }
        public float MinWeaponPosePlayRate { get { return this[nameof(MinWeaponPosePlayRate)].GetValue<float>(); } set { this[nameof(MinWeaponPosePlayRate)].SetValue<float>(value); } }
        public float MaxWeaponPosePlayRate { get { return this[nameof(MaxWeaponPosePlayRate)].GetValue<float>(); } set { this[nameof(MaxWeaponPosePlayRate)].SetValue<float>(value); } }
        public SceneComponent SceneRoot { get { return this[nameof(SceneRoot)].As<SceneComponent>(); } set { this["SceneRoot"] = value; } }
        public SkeletalMeshComponent Suit { get { return this[nameof(Suit)].As<SkeletalMeshComponent>(); } set { this["Suit"] = value; } }
        public SkeletalMeshComponent Jetpack { get { return this[nameof(Jetpack)].As<SkeletalMeshComponent>(); } set { this["Jetpack"] = value; } }
        public StaticMeshComponent PortalGun { get { return this[nameof(PortalGun)].As<StaticMeshComponent>(); } set { this["PortalGun"] = value; } }
        public WidgetComponent Name { get { return this[nameof(Name)].As<WidgetComponent>(); } set { this["Name"] = value; } }
        public MaterialInstance DefaultMaterial { get { return this[nameof(DefaultMaterial)].As<MaterialInstance>(); } set { this["DefaultMaterial"] = value; } }
        public StaticMeshComponent Weapon { get { return this[nameof(Weapon)].As<StaticMeshComponent>(); } set { this["Weapon"] = value; } }
        public void UpdateSkins() { Invoke(nameof(UpdateSkins)); }
        public void PlayEmote_Multicast() { Invoke(nameof(PlayEmote_Multicast)); }
        public void OnWeaponPoseLoaded() { Invoke(nameof(OnWeaponPoseLoaded)); }
        public void OnRep_PlayerState() { Invoke(nameof(OnRep_PlayerState)); }
        public void OnRep_PlayerInfo() { Invoke(nameof(OnRep_PlayerInfo)); }
        public void OnRep_CurrentWeaponType() { Invoke(nameof(OnRep_CurrentWeaponType)); }
        public void OnPlayerCustomizationsSet() { Invoke(nameof(OnPlayerCustomizationsSet)); }
        public void OnEmoteFinished() { Invoke(nameof(OnEmoteFinished)); }
    }
    public class PortalWarsLoadingScreenWidget : PortalWarsUserWidget
    {
        public PortalWarsLoadingScreenWidget(ulong addr) : base(addr) { }
        public RichTextBlock TipRichTextBlock { get { return this[nameof(TipRichTextBlock)].As<RichTextBlock>(); } set { this["TipRichTextBlock"] = value; } }
    }
    public class PortalWarsLobbyGameMode : PortalWarsBaseGameMode
    {
        public PortalWarsLobbyGameMode(ulong addr) : base(addr) { }
        public Array<PortalWarsLobbyPlayerStart> PlayerStarts { get { return new Array<PortalWarsLobbyPlayerStart>(this[nameof(PlayerStarts)].Address); } }
        public Array<PortalWarsLineUpCharacter> LineUpCharacters { get { return new Array<PortalWarsLineUpCharacter>(this[nameof(LineUpCharacters)].Address); } }
        public Object LineUpCharacterClass { get { return this[nameof(LineUpCharacterClass)]; } set { this[nameof(LineUpCharacterClass)] = value; } }
        public CameraActor LobbyCam { get { return this[nameof(LobbyCam)].As<CameraActor>(); } set { this["LobbyCam"] = value; } }
    }
    public class PortalWarsLobbyGameState : PortalWarsBaseGameState
    {
        public PortalWarsLobbyGameState(ulong addr) : base(addr) { }
        public MatchSummaryInfo PrevGameData { get { return this[nameof(PrevGameData)].As<MatchSummaryInfo>(); } set { this["PrevGameData"] = value; } }
        public StaticMeshActor TVScreen { get { return this[nameof(TVScreen)].As<StaticMeshActor>(); } set { this["TVScreen"] = value; } }
        public void UpdateTVScreen() { Invoke(nameof(UpdateTVScreen)); }
        public void OnRep_PrevGameData() { Invoke(nameof(OnRep_PrevGameData)); }
    }
    public class PortalWarsPlayerController : PortalWarsBasePlayerController
    {
        public PortalWarsPlayerController(ulong addr) : base(addr) { }
        public Portal leftPortal { get { return this[nameof(leftPortal)].As<Portal>(); } set { this["leftPortal"] = value; } }
        public Portal rightPortal { get { return this[nameof(rightPortal)].As<Portal>(); } set { this["rightPortal"] = value; } }
        public PortalSceneCapture2D leftPortalSceneCapture { get { return this[nameof(leftPortalSceneCapture)].As<PortalSceneCapture2D>(); } set { this["leftPortalSceneCapture"] = value; } }
        public PortalSceneCapture2D rightPortalSceneCapture { get { return this[nameof(rightPortalSceneCapture)].As<PortalSceneCapture2D>(); } set { this["rightPortalSceneCapture"] = value; } }
        public Object portalSceneCaptureClass { get { return this[nameof(portalSceneCaptureClass)]; } set { this[nameof(portalSceneCaptureClass)] = value; } }
        public TextureRenderTarget2D leftPortalRenderTarget { get { return this[nameof(leftPortalRenderTarget)].As<TextureRenderTarget2D>(); } set { this["leftPortalRenderTarget"] = value; } }
        public TextureRenderTarget2D rightPortalRenderTarget { get { return this[nameof(rightPortalRenderTarget)].As<TextureRenderTarget2D>(); } set { this["rightPortalRenderTarget"] = value; } }
        public PortalWarsDialogWidget PauseMenu { get { return this[nameof(PauseMenu)].As<PortalWarsDialogWidget>(); } set { this["PauseMenu"] = value; } }
        public Object PauseMenuWidgetClass { get { return this[nameof(PauseMenuWidgetClass)]; } set { this[nameof(PauseMenuWidgetClass)] = value; } }
        public float PredictionFudgeFactor { get { return this[nameof(PredictionFudgeFactor)].GetValue<float>(); } set { this[nameof(PredictionFudgeFactor)].SetValue<float>(value); } }
        public float MaxPredictionPing { get { return this[nameof(MaxPredictionPing)].GetValue<float>(); } set { this[nameof(MaxPredictionPing)].SetValue<float>(value); } }
        public float MaxMeleePredictionPing { get { return this[nameof(MaxMeleePredictionPing)].GetValue<float>(); } set { this[nameof(MaxMeleePredictionPing)].SetValue<float>(value); } }
        public Array<ActorOriginAndExtent> actorOriginAndExtentList { get { return new Array<ActorOriginAndExtent>(this[nameof(actorOriginAndExtentList)].Address); } }
        public PortalWarsKillcam Killcam { get { return this[nameof(Killcam)].As<PortalWarsKillcam>(); } set { this["Killcam"] = value; } }
        public Material OutlinePPMaterial { get { return this[nameof(OutlinePPMaterial)].As<Material>(); } set { this["OutlinePPMaterial"] = value; } }
        public void ServerSpawnPickup(Object pickupClassName) { Invoke(nameof(ServerSpawnPickup), pickupClassName); }
        public void ServerSlomo(float TimeDilation) { Invoke(nameof(ServerSlomo), TimeDilation); }
        public void ServerSetPartyChatOnly(bool bPartyChatOnly) { Invoke(nameof(ServerSetPartyChatOnly), bPartyChatOnly); }
        public void ServerSetFOV(float FOV) { Invoke(nameof(ServerSetFOV), FOV); }
        public void ServerSetAnonymousMode(bool bAnonymousMode) { Invoke(nameof(ServerSetAnonymousMode), bAnonymousMode); }
        public void ServerRequestReturnToMainMenu() { Invoke(nameof(ServerRequestReturnToMainMenu)); }
        public void ServerReceiveRanks(Array<UserRankInfo> PlayerRanks) { Invoke(nameof(ServerReceiveRanks), PlayerRanks); }
        public void ServerReceiveProgression(UserProgressionInfo UserProgression) { Invoke(nameof(ServerReceiveProgression), UserProgression); }
        public void ServerReceiveDailyStreak(UserDailyStreakInfo DailyStreak) { Invoke(nameof(ServerReceiveDailyStreak), DailyStreak); }
        public void ServerReceiveCustomizations(Array<CustomizationId> ChosenCustomizations) { Invoke(nameof(ServerReceiveCustomizations), ChosenCustomizations); }
        public void ServerKickPlayer(PlayerState PlayerStateToKick) { Invoke(nameof(ServerKickPlayer), PlayerStateToKick); }
        public void ServerEndMatch() { Invoke(nameof(ServerEndMatch)); }
        public void ServerEnableGodMode() { Invoke(nameof(ServerEnableGodMode)); }
        public void ServerBroadcastChatMessage(TextChatData InData) { Invoke(nameof(ServerBroadcastChatMessage), InData); }
        public void SendRanksToServer() { Invoke(nameof(SendRanksToServer)); }
        public void SendCustomizationsToServer() { Invoke(nameof(SendCustomizationsToServer)); }
        public bool ProjectWorldLocationToScreenCustom(Vector WorldLocation, Vector2D ScreenLocation, bool bPlayerViewportRelative) { return Invoke<bool>(nameof(ProjectWorldLocationToScreenCustom), WorldLocation, ScreenLocation, bPlayerViewportRelative); }
        public void PlayEmote() { Invoke(nameof(PlayEmote)); }
        public void OnPauseMenuClosed() { Invoke(nameof(OnPauseMenuClosed)); }
        public int GetTeamNum() { return Invoke<int>(nameof(GetTeamNum)); }
        public void ClientUpdateChat(TextChatData InData) { Invoke(nameof(ClientUpdateChat), InData); }
        public void ClientSetSpectatorCamera(Vector CameraLocation, Rotator CameraRotation) { Invoke(nameof(ClientSetSpectatorCamera), CameraLocation, CameraRotation); }
        public void ClientSetRoundResult(int WinningTeamNum, bool bIsTie, int Placement) { Invoke(nameof(ClientSetRoundResult), WinningTeamNum, bIsTie, Placement); }
        public void ClientSetMatchResult(int WinningTeamNum, bool bIsTie, int Placement) { Invoke(nameof(ClientSetMatchResult), WinningTeamNum, bIsTie, Placement); }
        public void ClientNotifyTeammateTeabagConfirmed() { Invoke(nameof(ClientNotifyTeammateTeabagConfirmed)); }
        public void ClientNotifyTeabagDenied() { Invoke(nameof(ClientNotifyTeabagDenied)); }
        public void ClientNotifyTeabagConfirmed() { Invoke(nameof(ClientNotifyTeabagConfirmed)); }
        public void ClientNotifyEnemyDeniedTeabag() { Invoke(nameof(ClientNotifyEnemyDeniedTeabag)); }
        public void ClientNotifyDamageTaken(Vector_NetQuantize HitLocation, bool bThruPortal) { Invoke(nameof(ClientNotifyDamageTaken), HitLocation, bThruPortal); }
        public void ClientNotifyCountdown(int CountdownTime) { Invoke(nameof(ClientNotifyCountdown), CountdownTime); }
        public void ClientNotifyCausedHit(Pawn DamagedPawn, float DamageDealt, EPWHitType HitType) { Invoke(nameof(ClientNotifyCausedHit), DamagedPawn, DamageDealt, HitType); }
        public void ClientNotifyAlive() { Invoke(nameof(ClientNotifyAlive)); }
        public void ClientHearAkEventAtLocation(AkAudioEvent EventToPost, Vector_NetQuantize SoundLocation, Rotator SoundRotation, bool bUseSpatialAudio) { Invoke(nameof(ClientHearAkEventAtLocation), EventToPost, SoundLocation, SoundRotation, bUseSpatialAudio); }
        public void ClientHearAkEvent(AkAudioEvent EventToPost, PortalWarsAkComponent AkComponent, bool bUseSpatialAudio) { Invoke(nameof(ClientHearAkEvent), EventToPost, AkComponent, bUseSpatialAudio); }
        public void ClientGenericInitialization() { Invoke(nameof(ClientGenericInitialization)); }
        public void ClientGameStarted() { Invoke(nameof(ClientGameStarted)); }
        public void ClientCountdownStarted() { Invoke(nameof(ClientCountdownStarted)); }
        public void CheatSpawnPickup(Object pickupClassName) { Invoke(nameof(CheatSpawnPickup), pickupClassName); }
        public void CheatSlowmo(float TimeDilation) { Invoke(nameof(CheatSlowmo), TimeDilation); }
        public void CheatShootThroughWalls() { Invoke(nameof(CheatShootThroughWalls)); }
        public void CheatRespawn() { Invoke(nameof(CheatRespawn)); }
        public void CheatGodMode() { Invoke(nameof(CheatGodMode)); }
        public void CheatESP() { Invoke(nameof(CheatESP)); }
    }
    public class PortalWarsLobbyPlayerController : PortalWarsPlayerController
    {
        public PortalWarsLobbyPlayerController(ulong addr) : base(addr) { }
        public PortalWarsLobbyWidget LobbyMenuWidget { get { return this[nameof(LobbyMenuWidget)].As<PortalWarsLobbyWidget>(); } set { this["LobbyMenuWidget"] = value; } }
        public Object LobbyMenuWidgetClass { get { return this[nameof(LobbyMenuWidgetClass)]; } set { this[nameof(LobbyMenuWidgetClass)] = value; } }
        public void ServerUpdateTeam(byte TeamNum) { Invoke(nameof(ServerUpdateTeam), TeamNum); }
        public void ServerSetGameConfig(GameConfig GameConfig) { Invoke(nameof(ServerSetGameConfig), GameConfig); }
        public void ServerPlayEmoteLineup(PortalWarsLineUpCharacter InLineUpCharacter) { Invoke(nameof(ServerPlayEmoteLineup), InLineUpCharacter); }
        public void ServerLaunchGame() { Invoke(nameof(ServerLaunchGame)); }
        public void ServerEquipPreviousWeapon(PortalWarsLineUpCharacter InLineUpCharacter) { Invoke(nameof(ServerEquipPreviousWeapon), InLineUpCharacter); }
        public void ServerEquipNextWeapon(PortalWarsLineUpCharacter InLineUpCharacter) { Invoke(nameof(ServerEquipNextWeapon), InLineUpCharacter); }
    }
    public class PortalWarsLobbyPlayerEntryWidget : PortalWarsPlayerEntryWidget
    {
        public PortalWarsLobbyPlayerEntryWidget(ulong addr) : base(addr) { }
        public Widget AdminIndicator { get { return this[nameof(AdminIndicator)].As<Widget>(); } set { this["AdminIndicator"] = value; } }
        public Widget SpectatorIndicator { get { return this[nameof(SpectatorIndicator)].As<Widget>(); } set { this["SpectatorIndicator"] = value; } }
        public PortalWarsPlayerEntryWidget PlayerEntry { get { return this[nameof(PlayerEntry)].As<PortalWarsPlayerEntryWidget>(); } set { this["PlayerEntry"] = value; } }
        public Border TeamBorder { get { return this[nameof(TeamBorder)].As<Border>(); } set { this["TeamBorder"] = value; } }
        public Image TeamImage { get { return this[nameof(TeamImage)].As<Image>(); } set { this["TeamImage"] = value; } }
        public void UpdateTeamColor() { Invoke(nameof(UpdateTeamColor)); }
        public void UpdateSpectatorIndicator() { Invoke(nameof(UpdateSpectatorIndicator)); }
        public void UpdateAdminIndicator() { Invoke(nameof(UpdateAdminIndicator)); }
        public ESlateVisibility LobbyAdminVisibility() { return Invoke<ESlateVisibility>(nameof(LobbyAdminVisibility)); }
        public void InitGameState() { Invoke(nameof(InitGameState)); }
        public ESlateVisibility GetSpectatorIndicatorVisibility() { return Invoke<ESlateVisibility>(nameof(GetSpectatorIndicatorVisibility)); }
    }
    public class PortalWarsLobbyPlayerStart : PlayerStart
    {
        public PortalWarsLobbyPlayerStart(ulong addr) : base(addr) { }
        public int SpawnOrder { get { return this[nameof(SpawnOrder)].GetValue<int>(); } set { this[nameof(SpawnOrder)].SetValue<int>(value); } }
        public byte TeamIndex { get { return this[nameof(TeamIndex)].GetValue<byte>(); } set { this[nameof(TeamIndex)].SetValue<byte>(value); } }
    }
    public class PortalWarsLocalizationHelpers : BlueprintFunctionLibrary
    {
        public PortalWarsLocalizationHelpers(ulong addr) : base(addr) { }
        public Object GetTextFromStringTable(Object StringTable, Object Key) { return Invoke<Object>(nameof(GetTextFromStringTable), StringTable, Key); }
        public Object GetStatText(Object StatName) { return Invoke<Object>(nameof(GetStatText), StatName); }
        public Object GetErrorText(ErrorInfo ErrorInfo) { return Invoke<Object>(nameof(GetErrorText), ErrorInfo); }
    }
    public class PortalWarsLocalPlayer : LocalPlayer
    {
        public PortalWarsLocalPlayer(ulong addr) : base(addr) { }
        public Texture PlayerAvatar { get { return this[nameof(PlayerAvatar)].As<Texture>(); } set { this["PlayerAvatar"] = value; } }
        public Array<Object> CachedCustomizationObjects { get { return new Array<Object>(this[nameof(CachedCustomizationObjects)].Address); } }
        public PortalWarsNotificationManager NotificationManager { get { return this[nameof(NotificationManager)].As<PortalWarsNotificationManager>(); } set { this["NotificationManager"] = value; } }
        public Object NotificationManagerClass { get { return this[nameof(NotificationManagerClass)]; } set { this[nameof(NotificationManagerClass)] = value; } }
        public PortalWarsInviteManager InviteManager { get { return this[nameof(InviteManager)].As<PortalWarsInviteManager>(); } set { this["InviteManager"] = value; } }
        public Object InviteManagerClass { get { return this[nameof(InviteManagerClass)]; } set { this[nameof(InviteManagerClass)] = value; } }
        public PortalWarsDialogWidget ControllerDisconnectedWidget { get { return this[nameof(ControllerDisconnectedWidget)].As<PortalWarsDialogWidget>(); } set { this["ControllerDisconnectedWidget"] = value; } }
        public Object ControllerDisconnectWidgetClass { get { return this[nameof(ControllerDisconnectWidgetClass)]; } set { this[nameof(ControllerDisconnectWidgetClass)] = value; } }
        public PortalWarsSaveGame UserSaveGameData { get { return this[nameof(UserSaveGameData)].As<PortalWarsSaveGame>(); } set { this["UserSaveGameData"] = value; } }
        public void SetPlayerAvatar(Texture avatar) { Invoke(nameof(SetPlayerAvatar), avatar); }
        public void OnUserCustomizationsUpdate() { Invoke(nameof(OnUserCustomizationsUpdate)); }
        public void OnUserChosenCustomizationsUpdate() { Invoke(nameof(OnUserChosenCustomizationsUpdate)); }
        public void OnDialogClosed(PortalWarsDialogWidget Dialog) { Invoke(nameof(OnDialogClosed), Dialog); }
        public void OnCustomizationsLoaded() { Invoke(nameof(OnCustomizationsLoaded)); }
        public void OnControllerDisconnectedWidgetClosed() { Invoke(nameof(OnControllerDisconnectedWidgetClosed)); }
        public void LoadUserSaveGame() { Invoke(nameof(LoadUserSaveGame)); }
        public PortalWarsSaveGame GetUserSaveGame() { return Invoke<PortalWarsSaveGame>(nameof(GetUserSaveGame)); }
    }
    public class PortalWarsLockerButtonWidget : PortalWarsEntryWidget
    {
        public PortalWarsLockerButtonWidget(ulong addr) : base(addr) { }
        public ECustomizationType CustomizationType { get { return (ECustomizationType)this[nameof(CustomizationType)].GetValue<int>(); } set { this[nameof(CustomizationType)].SetValue<int>((int)value); } }
        public TextBlock EquippedText { get { return this[nameof(EquippedText)].As<TextBlock>(); } set { this["EquippedText"] = value; } }
        public Image ThumbnailImage { get { return this[nameof(ThumbnailImage)].As<Image>(); } set { this["ThumbnailImage"] = value; } }
        public Texture2D DefaultImage { get { return this[nameof(DefaultImage)].As<Texture2D>(); } set { this["DefaultImage"] = value; } }
        public Object GetEquippedTitleText() { return Invoke<Object>(nameof(GetEquippedTitleText)); }
    }
    public class PortalWarsLockerEntryWidget : PortalWarsEntryWidget
    {
        public PortalWarsLockerEntryWidget(ulong addr) : base(addr) { }
        public TextBlock DisplayNameText { get { return this[nameof(DisplayNameText)].As<TextBlock>(); } set { this["DisplayNameText"] = value; } }
        public Image DisplayImage { get { return this[nameof(DisplayImage)].As<Image>(); } set { this["DisplayImage"] = value; } }
        public WidgetSwitcher ThumbnailSwitcher { get { return this[nameof(ThumbnailSwitcher)].As<WidgetSwitcher>(); } set { this["ThumbnailSwitcher"] = value; } }
        public Border NameTagBorder { get { return this[nameof(NameTagBorder)].As<Border>(); } set { this["NameTagBorder"] = value; } }
        public Image RarityIcon { get { return this[nameof(RarityIcon)].As<Image>(); } set { this["RarityIcon"] = value; } }
        public Widget EquippedIndicator { get { return this[nameof(EquippedIndicator)].As<Widget>(); } set { this["EquippedIndicator"] = value; } }
        public Widget LockedRoot { get { return this[nameof(LockedRoot)].As<Widget>(); } set { this["LockedRoot"] = value; } }
        public WidgetSwitcher BackgroundSwitcher { get { return this[nameof(BackgroundSwitcher)].As<WidgetSwitcher>(); } set { this["BackgroundSwitcher"] = value; } }
        public WidgetAnimation SelectedAnimation { get { return this[nameof(SelectedAnimation)].As<WidgetAnimation>(); } set { this["SelectedAnimation"] = value; } }
        public TextBlock NumSkinsText { get { return this[nameof(NumSkinsText)].As<TextBlock>(); } set { this["NumSkinsText"] = value; } }
        public PortalWarsLockerSubWidget ParentWidget { get { return this[nameof(ParentWidget)].As<PortalWarsLockerSubWidget>(); } set { this["ParentWidget"] = value; } }
        public PanelWidget DebugPanel { get { return this[nameof(DebugPanel)].As<PanelWidget>(); } set { this["DebugPanel"] = value; } }
        public TextBlock IdText { get { return this[nameof(IdText)].As<TextBlock>(); } set { this["IdText"] = value; } }
        public TextBlock AvailabilityText { get { return this[nameof(AvailabilityText)].As<TextBlock>(); } set { this["AvailabilityText"] = value; } }
        public Texture2D GetRarityIcon() { return Invoke<Texture2D>(nameof(GetRarityIcon)); }
        public Object GetNumSkinsText() { return Invoke<Object>(nameof(GetNumSkinsText)); }
        public ESlateVisibility GetDisplayNameVisibility() { return Invoke<ESlateVisibility>(nameof(GetDisplayNameVisibility)); }
        public Object GetDisplayNameText() { return Invoke<Object>(nameof(GetDisplayNameText)); }
    }
    public class PortalWarsLockerSubWidget : PortalWarsInspectWidget
    {
        public PortalWarsLockerSubWidget(ulong addr) : base(addr) { }
        public Object HorizontalItemEntryWidgetClass { get { return this[nameof(HorizontalItemEntryWidgetClass)]; } set { this[nameof(HorizontalItemEntryWidgetClass)] = value; } }
        public Object VerticalItemEntryWidgetClass { get { return this[nameof(VerticalItemEntryWidgetClass)]; } set { this[nameof(VerticalItemEntryWidgetClass)] = value; } }
        public Object ItemEntryWidgetClassOverrides { get { return this[nameof(ItemEntryWidgetClassOverrides)]; } set { this[nameof(ItemEntryWidgetClassOverrides)] = value; } }
        public Object ParentEntryWidgetClass { get { return this[nameof(ParentEntryWidgetClass)]; } set { this[nameof(ParentEntryWidgetClass)] = value; } }
        public PortalWarsCustomScrollWidget ParentPanel { get { return this[nameof(ParentPanel)].As<PortalWarsCustomScrollWidget>(); } set { this["ParentPanel"] = value; } }
        public PortalWarsCustomScrollWidget ItemsPanel { get { return this[nameof(ItemsPanel)].As<PortalWarsCustomScrollWidget>(); } set { this["ItemsPanel"] = value; } }
        public Object ParentCustomizations { get { return this[nameof(ParentCustomizations)]; } set { this[nameof(ParentCustomizations)] = value; } }
        public Object ItemCustomizations { get { return this[nameof(ItemCustomizations)]; } set { this[nameof(ItemCustomizations)] = value; } }
        public TextBlock ParentSubtitleText { get { return this[nameof(ParentSubtitleText)].As<TextBlock>(); } set { this["ParentSubtitleText"] = value; } }
        public PortalWarsChallengeEntryWidget ChallengeEntry { get { return this[nameof(ChallengeEntry)].As<PortalWarsChallengeEntryWidget>(); } set { this["ChallengeEntry"] = value; } }
        public Widget ChallengeRoot { get { return this[nameof(ChallengeRoot)].As<Widget>(); } set { this["ChallengeRoot"] = value; } }
        public PortalWarsButtonWidget ViewButton { get { return this[nameof(ViewButton)].As<PortalWarsButtonWidget>(); } set { this["ViewButton"] = value; } }
        public RichTextBlock TipRichTextBlock { get { return this[nameof(TipRichTextBlock)].As<RichTextBlock>(); } set { this["TipRichTextBlock"] = value; } }
        public void RefreshNewItems() { Invoke(nameof(RefreshNewItems)); }
        public void OnViewButtonClicked() { Invoke(nameof(OnViewButtonClicked)); }
        public void OnPrevParentEntry() { Invoke(nameof(OnPrevParentEntry)); }
        public void OnParentEntrySelected(PortalWarsEntryWidget Entry) { Invoke(nameof(OnParentEntrySelected), Entry); }
        public void OnParentEntryScrolledTo(Widget Widget) { Invoke(nameof(OnParentEntryScrolledTo), Widget); }
        public void OnNextParentEntry() { Invoke(nameof(OnNextParentEntry)); }
        public void OnItemEntrySelected(PortalWarsEntryWidget Entry) { Invoke(nameof(OnItemEntrySelected), Entry); }
        public void OnItemEntryScrolledTo(Widget Widget) { Invoke(nameof(OnItemEntryScrolledTo), Widget); }
        public void OnItemEntryDoubleClicked(PortalWarsEntryWidget Entry) { Invoke(nameof(OnItemEntryDoubleClicked), Entry); }
        public void InitParentEntries() { Invoke(nameof(InitParentEntries)); }
        public void InitItemEntries() { Invoke(nameof(InitItemEntries)); }
        public Widget GetParentEntryWidget(Object WidgetId) { return Invoke<Widget>(nameof(GetParentEntryWidget), WidgetId); }
        public Widget GetItemEntryWidget(Object WidgetId) { return Invoke<Widget>(nameof(GetItemEntryWidget), WidgetId); }
    }
    public class PortalWarsLockerWidget : PortalWarsMenuWidget
    {
        public PortalWarsLockerWidget(ulong addr) : base(addr) { }
        public PortalWarsLockerSubWidget InspectWidget { get { return this[nameof(InspectWidget)].As<PortalWarsLockerSubWidget>(); } set { this["InspectWidget"] = value; } }
        public void OnLockerButtonSelected(PortalWarsEntryWidget Widget) { Invoke(nameof(OnLockerButtonSelected), Widget); }
        public void GoToMainState() { Invoke(nameof(GoToMainState)); }
        public void GoToInspectState() { Invoke(nameof(GoToInspectState)); }
    }
    public class PortalWarsLoginMenuWidget : PortalWarsUserWidget
    {
        public PortalWarsLoginMenuWidget(ulong addr) : base(addr) { }
        public TextBlock ConnectText { get { return this[nameof(ConnectText)].As<TextBlock>(); } set { this["ConnectText"] = value; } }
        public TextBlock ErrorText { get { return this[nameof(ErrorText)].As<TextBlock>(); } set { this["ErrorText"] = value; } }
        public TextBlock ErrorTitleText { get { return this[nameof(ErrorTitleText)].As<TextBlock>(); } set { this["ErrorTitleText"] = value; } }
        public TextBlock VersionText { get { return this[nameof(VersionText)].As<TextBlock>(); } set { this["VersionText"] = value; } }
        public PortalWarsButtonWidget StartButton { get { return this[nameof(StartButton)].As<PortalWarsButtonWidget>(); } set { this["StartButton"] = value; } }
        public PortalWarsButtonWidget RetryButton { get { return this[nameof(RetryButton)].As<PortalWarsButtonWidget>(); } set { this["RetryButton"] = value; } }
        public PortalWarsButtonWidget QuitButton { get { return this[nameof(QuitButton)].As<PortalWarsButtonWidget>(); } set { this["QuitButton"] = value; } }
        public WidgetSwitcher RetrySwitcher { get { return this[nameof(RetrySwitcher)].As<WidgetSwitcher>(); } set { this["RetrySwitcher"] = value; } }
        public WidgetSwitcher LoginSwitcher { get { return this[nameof(LoginSwitcher)].As<WidgetSwitcher>(); } set { this["LoginSwitcher"] = value; } }
        public void StartLoginFlow() { Invoke(nameof(StartLoginFlow)); }
        public void OnUserAdded(int ControllerId) { Invoke(nameof(OnUserAdded), ControllerId); }
        public void OnQuitButtonClicked() { Invoke(nameof(OnQuitButtonClicked)); }
        public void GoToState(ELoginMenuState NewState) { Invoke(nameof(GoToState), NewState); }
        public Object GetVersionText() { return Invoke<Object>(nameof(GetVersionText)); }
        public void DelayedLogin() { Invoke(nameof(DelayedLogin)); }
    }
    public class PortalWarsLootboxWidget : PortalWarsInspectWidget
    {
        public PortalWarsLootboxWidget(ulong addr) : base(addr) { }
        public Object RaritySounds { get { return this[nameof(RaritySounds)]; } set { this[nameof(RaritySounds)] = value; } }
        public PortalWarsButtonWidget OpenButton { get { return this[nameof(OpenButton)].As<PortalWarsButtonWidget>(); } set { this["OpenButton"] = value; } }
        public Widget OpenRoot { get { return this[nameof(OpenRoot)].As<Widget>(); } set { this["OpenRoot"] = value; } }
        public PortalWarsButtonWidget CatchButton { get { return this[nameof(CatchButton)].As<PortalWarsButtonWidget>(); } set { this["CatchButton"] = value; } }
        public Widget CatchRoot { get { return this[nameof(CatchRoot)].As<Widget>(); } set { this["CatchRoot"] = value; } }
        public AkAudioEvent LootboxSequenceStartEvent { get { return this[nameof(LootboxSequenceStartEvent)].As<AkAudioEvent>(); } set { this["LootboxSequenceStartEvent"] = value; } }
        public AkAudioEvent LootboxSequenceEndEvent { get { return this[nameof(LootboxSequenceEndEvent)].As<AkAudioEvent>(); } set { this["LootboxSequenceEndEvent"] = value; } }
        public AkAudioEvent LootboxSequenceStopEvent { get { return this[nameof(LootboxSequenceStopEvent)].As<AkAudioEvent>(); } set { this["LootboxSequenceStopEvent"] = value; } }
        public void OnStartLootboxSequenceCompleted() { Invoke(nameof(OnStartLootboxSequenceCompleted)); }
        public void OnOpenButtonClicked() { Invoke(nameof(OnOpenButtonClicked)); }
        public void OnLootboxSequenceCompleted() { Invoke(nameof(OnLootboxSequenceCompleted)); }
        public void OnLoopLootboxSequenceCompleted() { Invoke(nameof(OnLoopLootboxSequenceCompleted)); }
        public void OnCatchButtonClicked() { Invoke(nameof(OnCatchButtonClicked)); }
        public void GoToMainState() { Invoke(nameof(GoToMainState)); }
    }
    public class PortalWarsLowAmmoIndicatorWidget : UserWidget
    {
        public PortalWarsLowAmmoIndicatorWidget(ulong addr) : base(addr) { }
        public WidgetAnimation WarningFlashAnimation { get { return this[nameof(WarningFlashAnimation)].As<WidgetAnimation>(); } set { this["WarningFlashAnimation"] = value; } }
        public TextBlock AmmoText { get { return this[nameof(AmmoText)].As<TextBlock>(); } set { this["AmmoText"] = value; } }
        public PortalWarsInputDecoratorWidget ActionInput { get { return this[nameof(ActionInput)].As<PortalWarsInputDecoratorWidget>(); } set { this["ActionInput"] = value; } }
    }
    public class PortalWarsMainMenuWidget : PortalWarsMenuWidget
    {
        public PortalWarsMainMenuWidget(ulong addr) : base(addr) { }
        public PortalWarsMenuWidget PlayMenu { get { return this[nameof(PlayMenu)].As<PortalWarsMenuWidget>(); } set { this["PlayMenu"] = value; } }
        public PortalWarsMenuWidget BattlePassMenu { get { return this[nameof(BattlePassMenu)].As<PortalWarsMenuWidget>(); } set { this["BattlePassMenu"] = value; } }
        public PortalWarsMenuWidget ReferralPassMenu { get { return this[nameof(ReferralPassMenu)].As<PortalWarsMenuWidget>(); } set { this["ReferralPassMenu"] = value; } }
        public PortalWarsMenuWidget LockerMenu { get { return this[nameof(LockerMenu)].As<PortalWarsMenuWidget>(); } set { this["LockerMenu"] = value; } }
        public PortalWarsMenuWidget CareerMenu { get { return this[nameof(CareerMenu)].As<PortalWarsMenuWidget>(); } set { this["CareerMenu"] = value; } }
        public PortalWarsMenuWidget ItemShopMenu { get { return this[nameof(ItemShopMenu)].As<PortalWarsMenuWidget>(); } set { this["ItemShopMenu"] = value; } }
        public PortalWarsMenuWidget TrainingMenu { get { return this[nameof(TrainingMenu)].As<PortalWarsMenuWidget>(); } set { this["TrainingMenu"] = value; } }
        public PortalWarsMenuWidget ChallengesMenu { get { return this[nameof(ChallengesMenu)].As<PortalWarsMenuWidget>(); } set { this["ChallengesMenu"] = value; } }
        public PortalWarsMenuWidget RewardCenterMenu { get { return this[nameof(RewardCenterMenu)].As<PortalWarsMenuWidget>(); } set { this["RewardCenterMenu"] = value; } }
        public PortalWarsMenuWidget SocialMenu { get { return this[nameof(SocialMenu)].As<PortalWarsMenuWidget>(); } set { this["SocialMenu"] = value; } }
        public PortalWarsMenuWidget LootboxMenu { get { return this[nameof(LootboxMenu)].As<PortalWarsMenuWidget>(); } set { this["LootboxMenu"] = value; } }
        public Object MenuSelectDialogWidgetClass { get { return this[nameof(MenuSelectDialogWidgetClass)]; } set { this[nameof(MenuSelectDialogWidgetClass)] = value; } }
        public void OpenSelectMenu() { Invoke(nameof(OpenSelectMenu)); }
        public void OnStoreUpdate() { Invoke(nameof(OnStoreUpdate)); }
        public void OnCustomizationsUpdate() { Invoke(nameof(OnCustomizationsUpdate)); }
        public void OnChallengesUpdate() { Invoke(nameof(OnChallengesUpdate)); }
        public void GoToTrainingState() { Invoke(nameof(GoToTrainingState)); }
        public void GoToSocialState() { Invoke(nameof(GoToSocialState)); }
        public void GoToRewardCenterState() { Invoke(nameof(GoToRewardCenterState)); }
        public void GoToReferralPassState() { Invoke(nameof(GoToReferralPassState)); }
        public void GoToPlayState() { Invoke(nameof(GoToPlayState)); }
        public void GoToLootboxState() { Invoke(nameof(GoToLootboxState)); }
        public void GoToLockerState() { Invoke(nameof(GoToLockerState)); }
        public void GoToItemShopState() { Invoke(nameof(GoToItemShopState)); }
        public void GoToChallengesState() { Invoke(nameof(GoToChallengesState)); }
        public void GoToCareerState() { Invoke(nameof(GoToCareerState)); }
        public void GoToBattlePassState() { Invoke(nameof(GoToBattlePassState)); }
    }
    public class PortalWarsMatchCanceledWidget : UserWidget
    {
        public PortalWarsMatchCanceledWidget(ulong addr) : base(addr) { }
        public TextBlock CountdownText { get { return this[nameof(CountdownText)].As<TextBlock>(); } set { this["CountdownText"] = value; } }
        public Object GetLeavingMapText() { return Invoke<Object>(nameof(GetLeavingMapText)); }
    }
    public class PortalWarsMatchResultWidget : UserWidget
    {
        public PortalWarsMatchResultWidget(ulong addr) : base(addr) { }
        public TextBlock TitleText { get { return this[nameof(TitleText)].As<TextBlock>(); } set { this["TitleText"] = value; } }
        public Image LeftStarImage { get { return this[nameof(LeftStarImage)].As<Image>(); } set { this["LeftStarImage"] = value; } }
        public Image RightStarImage { get { return this[nameof(RightStarImage)].As<Image>(); } set { this["RightStarImage"] = value; } }
        public Image TopBorderImage { get { return this[nameof(TopBorderImage)].As<Image>(); } set { this["TopBorderImage"] = value; } }
        public Image BottomBorderImage { get { return this[nameof(BottomBorderImage)].As<Image>(); } set { this["BottomBorderImage"] = value; } }
        public WidgetAnimation FadeInAnimation { get { return this[nameof(FadeInAnimation)].As<WidgetAnimation>(); } set { this["FadeInAnimation"] = value; } }
        public Object GetTitleText() { return Invoke<Object>(nameof(GetTitleText)); }
    }
    public class PortalWarsMedalEntryWidget : UserWidget
    {
        public PortalWarsMedalEntryWidget(ulong addr) : base(addr) { }
        public Widget ContentRoot { get { return this[nameof(ContentRoot)].As<Widget>(); } set { this["ContentRoot"] = value; } }
        public TextBlock LabelText { get { return this[nameof(LabelText)].As<TextBlock>(); } set { this["LabelText"] = value; } }
        public Image MedalImage { get { return this[nameof(MedalImage)].As<Image>(); } set { this["MedalImage"] = value; } }
        public WidgetAnimation FadeInAnimation { get { return this[nameof(FadeInAnimation)].As<WidgetAnimation>(); } set { this["FadeInAnimation"] = value; } }
        public WidgetAnimation FadeInToMiddleAnimation { get { return this[nameof(FadeInToMiddleAnimation)].As<WidgetAnimation>(); } set { this["FadeInToMiddleAnimation"] = value; } }
        public WidgetAnimation FadeOutAnimation { get { return this[nameof(FadeOutAnimation)].As<WidgetAnimation>(); } set { this["FadeOutAnimation"] = value; } }
        public WidgetAnimation SlideToLeftAnimation { get { return this[nameof(SlideToLeftAnimation)].As<WidgetAnimation>(); } set { this["SlideToLeftAnimation"] = value; } }
        public WidgetAnimation SlideToMiddleAnimation { get { return this[nameof(SlideToMiddleAnimation)].As<WidgetAnimation>(); } set { this["SlideToMiddleAnimation"] = value; } }
        public float LifeTime { get { return this[nameof(LifeTime)].GetValue<float>(); } set { this[nameof(LifeTime)].SetValue<float>(value); } }
        public WidgetTransform LeftTransfrom { get { return this[nameof(LeftTransfrom)].As<WidgetTransform>(); } set { this["LeftTransfrom"] = value; } }
        public WidgetTransform MiddleTransform { get { return this[nameof(MiddleTransform)].As<WidgetTransform>(); } set { this["MiddleTransform"] = value; } }
        public WidgetTransform RightTransform { get { return this[nameof(RightTransform)].As<WidgetTransform>(); } set { this["RightTransform"] = value; } }
        public void UpdateStyle_Internal() { Invoke(nameof(UpdateStyle_Internal)); }
    }
    public class PortalWarsMedalsWidget : UserWidget
    {
        public PortalWarsMedalsWidget(ulong addr) : base(addr) { }
        public PanelWidget MedalsPanel { get { return this[nameof(MedalsPanel)].As<PanelWidget>(); } set { this["MedalsPanel"] = value; } }
        public Object MedalEntryWidgetClass { get { return this[nameof(MedalEntryWidgetClass)]; } set { this[nameof(MedalEntryWidgetClass)] = value; } }
        public Array<PortalWarsMedalEntryWidget> MedalQueue { get { return new Array<PortalWarsMedalEntryWidget>(this[nameof(MedalQueue)].Address); } }
        public void ProcessMedal() { Invoke(nameof(ProcessMedal)); }
        public void OnMedalRemoved() { Invoke(nameof(OnMedalRemoved)); }
        public void FinishShiftingMedals() { Invoke(nameof(FinishShiftingMedals)); }
    }
    public class PortalWarsMediaSoundActor : Actor
    {
        public PortalWarsMediaSoundActor(ulong addr) : base(addr) { }
        public MediaSoundComponent MediaSoundComponent { get { return this[nameof(MediaSoundComponent)].As<MediaSoundComponent>(); } set { this["MediaSoundComponent"] = value; } }
        public float VolumeMultiplier { get { return this[nameof(VolumeMultiplier)].GetValue<float>(); } set { this[nameof(VolumeMultiplier)].SetValue<float>(value); } }
    }
    public class PortalWarsMeleeDmgType : PortalWarsDamageType
    {
        public PortalWarsMeleeDmgType(ulong addr) : base(addr) { }
    }
    public class PortalWarsMenuCarouselWidget : PortalWarsUserWidget
    {
        public PortalWarsMenuCarouselWidget(ulong addr) : base(addr) { }
        public PanelWidget EntryPanel { get { return this[nameof(EntryPanel)].As<PanelWidget>(); } set { this["EntryPanel"] = value; } }
        public Array<PortalWarsEntryWidget> CarouselEntries { get { return new Array<PortalWarsEntryWidget>(this[nameof(CarouselEntries)].Address); } }
        public Widget IndicatorRoot { get { return this[nameof(IndicatorRoot)].As<Widget>(); } set { this["IndicatorRoot"] = value; } }
        public PanelWidget IndicatorPanel { get { return this[nameof(IndicatorPanel)].As<PanelWidget>(); } set { this["IndicatorPanel"] = value; } }
        public Object IndicatorWidgetClass { get { return this[nameof(IndicatorWidgetClass)]; } set { this[nameof(IndicatorWidgetClass)] = value; } }
        public LinearColor DefaultIndicatorColor { get { return this[nameof(DefaultIndicatorColor)].As<LinearColor>(); } set { this["DefaultIndicatorColor"] = value; } }
        public LinearColor ActiveIndicatorColor { get { return this[nameof(ActiveIndicatorColor)].As<LinearColor>(); } set { this["ActiveIndicatorColor"] = value; } }
        public float EntryDisplayTime { get { return this[nameof(EntryDisplayTime)].GetValue<float>(); } set { this[nameof(EntryDisplayTime)].SetValue<float>(value); } }
        public void RefreshEntries() { Invoke(nameof(RefreshEntries)); }
        public void OnNextEntry() { Invoke(nameof(OnNextEntry)); }
    }
    public class PortalWarsMessageDialogWidget : PortalWarsDialogWidget
    {
        public PortalWarsMessageDialogWidget(ulong addr) : base(addr) { }
        public TextBlock TitleText { get { return this[nameof(TitleText)].As<TextBlock>(); } set { this["TitleText"] = value; } }
        public TextBlock MessageText { get { return this[nameof(MessageText)].As<TextBlock>(); } set { this["MessageText"] = value; } }
    }
    public class PortalWarsMKBSettingsWidget : PortalWarsSettingsSubWidget
    {
        public PortalWarsMKBSettingsWidget(ulong addr) : base(addr) { }
        public PortalWarsSpinSliderWidget MouseHorSens { get { return this[nameof(MouseHorSens)].As<PortalWarsSpinSliderWidget>(); } set { this["MouseHorSens"] = value; } }
        public PortalWarsSpinSliderWidget MouseVertSens { get { return this[nameof(MouseVertSens)].As<PortalWarsSpinSliderWidget>(); } set { this["MouseVertSens"] = value; } }
        public PortalWarsSpinSliderWidget MouseZoomMult { get { return this[nameof(MouseZoomMult)].As<PortalWarsSpinSliderWidget>(); } set { this["MouseZoomMult"] = value; } }
        public PortalWarsCheckBoxWidget MouseInvertLook { get { return this[nameof(MouseInvertLook)].As<PortalWarsCheckBoxWidget>(); } set { this["MouseInvertLook"] = value; } }
        public PortalWarsCheckBoxWidget MouseSmoothing { get { return this[nameof(MouseSmoothing)].As<PortalWarsCheckBoxWidget>(); } set { this["MouseSmoothing"] = value; } }
        public PortalWarsCheckBoxWidget ToggleCrouch { get { return this[nameof(ToggleCrouch)].As<PortalWarsCheckBoxWidget>(); } set { this["ToggleCrouch"] = value; } }
        public PortalWarsCheckBoxWidget ToggleSprint { get { return this[nameof(ToggleSprint)].As<PortalWarsCheckBoxWidget>(); } set { this["ToggleSprint"] = value; } }
        public PortalWarsCheckBoxWidget ToggleZoom { get { return this[nameof(ToggleZoom)].As<PortalWarsCheckBoxWidget>(); } set { this["ToggleZoom"] = value; } }
    }
    public class PortalWarsNameIndicatorWidget : PortalWarsIndicatorWidget
    {
        public PortalWarsNameIndicatorWidget(ulong addr) : base(addr) { }
        public TextBlock FriendlyPlayerNameText { get { return this[nameof(FriendlyPlayerNameText)].As<TextBlock>(); } set { this["FriendlyPlayerNameText"] = value; } }
        public TextBlock EnemyPlayerNameText { get { return this[nameof(EnemyPlayerNameText)].As<TextBlock>(); } set { this["EnemyPlayerNameText"] = value; } }
        public Widget BlueEnemyIndicator { get { return this[nameof(BlueEnemyIndicator)].As<Widget>(); } set { this["BlueEnemyIndicator"] = value; } }
        public Widget RedEnemyIndicator { get { return this[nameof(RedEnemyIndicator)].As<Widget>(); } set { this["RedEnemyIndicator"] = value; } }
        public Widget FriendlyDeathMarker { get { return this[nameof(FriendlyDeathMarker)].As<Widget>(); } set { this["FriendlyDeathMarker"] = value; } }
        public Widget EnemyDeathMarker { get { return this[nameof(EnemyDeathMarker)].As<Widget>(); } set { this["EnemyDeathMarker"] = value; } }
        public WidgetSwitcher NameSwitcher { get { return this[nameof(NameSwitcher)].As<WidgetSwitcher>(); } set { this["NameSwitcher"] = value; } }
        public void OnReplayFocusChanged(PlayerState PlayerState) { Invoke(nameof(OnReplayFocusChanged), PlayerState); }
        public void OnReplayCameraModeChanged(EReplayCameraMode ReplayCameraMode) { Invoke(nameof(OnReplayCameraModeChanged), ReplayCameraMode); }
        public void InitPlayerInfo() { Invoke(nameof(InitPlayerInfo)); }
        public ESlateVisibility GetEnemyVisibility() { return Invoke<ESlateVisibility>(nameof(GetEnemyVisibility)); }
        public ESlateVisibility GetDeathVisibility() { return Invoke<ESlateVisibility>(nameof(GetDeathVisibility)); }
    }
    public class PortalWarsNameTagWidget : UserWidget
    {
        public PortalWarsNameTagWidget(ulong addr) : base(addr) { }
        public TextBlock NameTagText { get { return this[nameof(NameTagText)].As<TextBlock>(); } set { this["NameTagText"] = value; } }
    }
    public class PortalWarsNavBarWidget : PortalWarsUserWidget
    {
        public PortalWarsNavBarWidget(ulong addr) : base(addr) { }
        public Object OnNavBarStateChanged { get { return this[nameof(OnNavBarStateChanged)]; } set { this[nameof(OnNavBarStateChanged)] = value; } }
        public byte CurrentState { get { return this[nameof(CurrentState)].GetValue<byte>(); } set { this[nameof(CurrentState)].SetValue<byte>(value); } }
        public Array<NavBarItem> ItemArray { get { return new Array<NavBarItem>(this[nameof(ItemArray)].Address); } }
        public Margin ItemPadding { get { return this[nameof(ItemPadding)].As<Margin>(); } set { this["ItemPadding"] = value; } }
        public PanelWidget ButtonPanel { get { return this[nameof(ButtonPanel)].As<PanelWidget>(); } set { this["ButtonPanel"] = value; } }
        public Object NavButtonWidgetClass { get { return this[nameof(NavButtonWidgetClass)]; } set { this[nameof(NavButtonWidgetClass)] = value; } }
        public Object NavSubHeaderWidgetClass { get { return this[nameof(NavSubHeaderWidgetClass)]; } set { this[nameof(NavSubHeaderWidgetClass)] = value; } }
        public bool bSelectOnControllerHover { get { return this[nameof(bSelectOnControllerHover)].Flag; } set { this[nameof(bSelectOnControllerHover)].Flag = value; } }
        public Array<PortalWarsNavButtonWidget> ButtonArray { get { return new Array<PortalWarsNavButtonWidget>(this[nameof(ButtonArray)].Address); } }
        public LinearColor NewColor { get { return this[nameof(NewColor)].As<LinearColor>(); } set { this["NewColor"] = value; } }
        public PortalWarsButtonWidget PrevGamepadButton { get { return this[nameof(PrevGamepadButton)].As<PortalWarsButtonWidget>(); } set { this["PrevGamepadButton"] = value; } }
        public PortalWarsButtonWidget NextGamepadButton { get { return this[nameof(NextGamepadButton)].As<PortalWarsButtonWidget>(); } set { this["NextGamepadButton"] = value; } }
        public Key PrevGamepadKey { get { return this[nameof(PrevGamepadKey)].As<Key>(); } set { this["PrevGamepadKey"] = value; } }
        public Key NextGamepadKey { get { return this[nameof(NextGamepadKey)].As<Key>(); } set { this["NextGamepadKey"] = value; } }
        public AkAudioEvent TabNextEvent { get { return this[nameof(TabNextEvent)].As<AkAudioEvent>(); } set { this["TabNextEvent"] = value; } }
        public AkAudioEvent TabPrevEvent { get { return this[nameof(TabPrevEvent)].As<AkAudioEvent>(); } set { this["TabPrevEvent"] = value; } }
        public void OnNavButtonSelected(PortalWarsEntryWidget Entry) { Invoke(nameof(OnNavButtonSelected), Entry); }
        public void GoToPrevState() { Invoke(nameof(GoToPrevState)); }
        public void GoToNextState() { Invoke(nameof(GoToNextState)); }
    }
    public class PortalWarsNavButtonWidget : PortalWarsEntryWidget
    {
        public PortalWarsNavButtonWidget(ulong addr) : base(addr) { }
        public LinearColor NewColor { get { return this[nameof(NewColor)].As<LinearColor>(); } set { this["NewColor"] = value; } }
    }
    public class PortalWarsNavigationSystem : NavigationSystemV1
    {
        public PortalWarsNavigationSystem(ulong addr) : base(addr) { }
    }
    public class PortalWarsNavLink_Jump : NavLinkProxy
    {
        public PortalWarsNavLink_Jump(ulong addr) : base(addr) { }
        public bool shouldSprint { get { return this[nameof(shouldSprint)].Flag; } set { this[nameof(shouldSprint)].Flag = value; } }
        public float CooldownTime { get { return this[nameof(CooldownTime)].GetValue<float>(); } set { this[nameof(CooldownTime)].SetValue<float>(value); } }
        public void OnStateChanged(NavLinkCustomComponent NavLinkComp, Array<Object> NotifyList) { Invoke(nameof(OnStateChanged), NavLinkComp, NotifyList); }
        public void JumpLinkReached(Object PathingAgent, Vector DestPoint) { Invoke(nameof(JumpLinkReached), PathingAgent, DestPoint); }
    }
    public class PortalWarsNetworkInfoWidget : UserWidget
    {
        public PortalWarsNetworkInfoWidget(ulong addr) : base(addr) { }
        public TextBlock Ping { get { return this[nameof(Ping)].As<TextBlock>(); } set { this["Ping"] = value; } }
        public TextBlock InBytes { get { return this[nameof(InBytes)].As<TextBlock>(); } set { this["InBytes"] = value; } }
        public TextBlock InPackets { get { return this[nameof(InPackets)].As<TextBlock>(); } set { this["InPackets"] = value; } }
        public TextBlock InPacketLoss { get { return this[nameof(InPacketLoss)].As<TextBlock>(); } set { this["InPacketLoss"] = value; } }
        public TextBlock OutBytes { get { return this[nameof(OutBytes)].As<TextBlock>(); } set { this["OutBytes"] = value; } }
        public TextBlock OutPackets { get { return this[nameof(OutPackets)].As<TextBlock>(); } set { this["OutPackets"] = value; } }
        public TextBlock OutPacketLoss { get { return this[nameof(OutPacketLoss)].As<TextBlock>(); } set { this["OutPacketLoss"] = value; } }
        public TextBlock FPS { get { return this[nameof(FPS)].As<TextBlock>(); } set { this["FPS"] = value; } }
        public HorizontalBox NetInfoHorizontalBox { get { return this[nameof(NetInfoHorizontalBox)].As<HorizontalBox>(); } set { this["NetInfoHorizontalBox"] = value; } }
    }
    public class PortalWarsNeutralCTFGameState : PortalWarsGameState
    {
        public PortalWarsNeutralCTFGameState(ulong addr) : base(addr) { }
        public Actor Flag { get { return this[nameof(Flag)].As<Actor>(); } set { this["Flag"] = value; } }
        public EFlagState FlagState { get { return (EFlagState)this[nameof(FlagState)].GetValue<int>(); } set { this[nameof(FlagState)].SetValue<int>((int)value); } }
        public float CapturedFlagRespawnTime { get { return this[nameof(CapturedFlagRespawnTime)].GetValue<float>(); } set { this[nameof(CapturedFlagRespawnTime)].SetValue<float>(value); } }
        public void SpawnFlag() { Invoke(nameof(SpawnFlag)); }
        public void OnRep_FlagState(EFlagState PrevState) { Invoke(nameof(OnRep_FlagState), PrevState); }
        public void OnRep_Flag() { Invoke(nameof(OnRep_Flag)); }
    }
    public class PortalWarsNeutralCTFHUD : PortalWarsHUD
    {
        public PortalWarsNeutralCTFHUD(ulong addr) : base(addr) { }
        public PortalWarsFlagIndicatorWidget TeamIndicator { get { return this[nameof(TeamIndicator)].As<PortalWarsFlagIndicatorWidget>(); } set { this["TeamIndicator"] = value; } }
        public Object FlagIndicatorWidgetClass { get { return this[nameof(FlagIndicatorWidgetClass)]; } set { this[nameof(FlagIndicatorWidgetClass)] = value; } }
        public Object FlagCaptureZoneWidgetClass { get { return this[nameof(FlagCaptureZoneWidgetClass)]; } set { this[nameof(FlagCaptureZoneWidgetClass)] = value; } }
        public PortalWarsCTFHUDOverlayWidget CTFHUDOverlayWidget { get { return this[nameof(CTFHUDOverlayWidget)].As<PortalWarsCTFHUDOverlayWidget>(); } set { this["CTFHUDOverlayWidget"] = value; } }
        public Object CTFHUDOverlayWidgetClass { get { return this[nameof(CTFHUDOverlayWidgetClass)]; } set { this[nameof(CTFHUDOverlayWidgetClass)] = value; } }
    }
    public class PortalWarsNewsFeedEntryWidget : PortalWarsEntryWidget
    {
        public PortalWarsNewsFeedEntryWidget(ulong addr) : base(addr) { }
        public TextBlock DescriptionText { get { return this[nameof(DescriptionText)].As<TextBlock>(); } set { this["DescriptionText"] = value; } }
        public Image NewsImage { get { return this[nameof(NewsImage)].As<Image>(); } set { this["NewsImage"] = value; } }
        public void OnActionButtonClicked() { Invoke(nameof(OnActionButtonClicked)); }
        public Object GetTitleText() { return Invoke<Object>(nameof(GetTitleText)); }
        public Object GetDescriptionText() { return Invoke<Object>(nameof(GetDescriptionText)); }
        public Object GetActionTitleText() { return Invoke<Object>(nameof(GetActionTitleText)); }
    }
    public class PortalWarsNewsFeedWidget : PortalWarsMenuCarouselWidget
    {
        public PortalWarsNewsFeedWidget(ulong addr) : base(addr) { }
        public PortalWarsButtonWidget ActionButton { get { return this[nameof(ActionButton)].As<PortalWarsButtonWidget>(); } set { this["ActionButton"] = value; } }
        public Widget NewsFeedRoot { get { return this[nameof(NewsFeedRoot)].As<Widget>(); } set { this["NewsFeedRoot"] = value; } }
        public Object NewsFeedEntryWidgetClass { get { return this[nameof(NewsFeedEntryWidgetClass)]; } set { this[nameof(NewsFeedEntryWidgetClass)] = value; } }
        public void RefreshWidget() { Invoke(nameof(RefreshWidget)); }
        public void OnActionButtonClicked() { Invoke(nameof(OnActionButtonClicked)); }
    }
    public class PortalWarsNotificationManager : Object
    {
        public PortalWarsNotificationManager(ulong addr) : base(addr) { }
        public Object MessageDialogWidgetClass { get { return this[nameof(MessageDialogWidgetClass)]; } set { this[nameof(MessageDialogWidgetClass)] = value; } }
        public Object RewardReceivedWidgetClass { get { return this[nameof(RewardReceivedWidgetClass)]; } set { this[nameof(RewardReceivedWidgetClass)] = value; } }
        public Object ChallengeDialogWidgetClass { get { return this[nameof(ChallengeDialogWidgetClass)]; } set { this[nameof(ChallengeDialogWidgetClass)] = value; } }
        public Object StreakIncreaseWidgetClass { get { return this[nameof(StreakIncreaseWidgetClass)]; } set { this[nameof(StreakIncreaseWidgetClass)] = value; } }
        public Object UnlockDialogWidgetClass { get { return this[nameof(UnlockDialogWidgetClass)]; } set { this[nameof(UnlockDialogWidgetClass)] = value; } }
        public Object ProgressionDialogWidgetClass { get { return this[nameof(ProgressionDialogWidgetClass)]; } set { this[nameof(ProgressionDialogWidgetClass)] = value; } }
        public Object BattlePassPurchaseDialogWidgetClass { get { return this[nameof(BattlePassPurchaseDialogWidgetClass)]; } set { this[nameof(BattlePassPurchaseDialogWidgetClass)] = value; } }
        public Object HappyHourWidgetClass { get { return this[nameof(HappyHourWidgetClass)]; } set { this[nameof(HappyHourWidgetClass)] = value; } }
        public Object PlaylistActiveWidgetClass { get { return this[nameof(PlaylistActiveWidgetClass)]; } set { this[nameof(PlaylistActiveWidgetClass)] = value; } }
        public Object GameSessionReconnectWidgetClass { get { return this[nameof(GameSessionReconnectWidgetClass)]; } set { this[nameof(GameSessionReconnectWidgetClass)] = value; } }
        public Object LimitedTimeOfferWidgetClass { get { return this[nameof(LimitedTimeOfferWidgetClass)]; } set { this[nameof(LimitedTimeOfferWidgetClass)] = value; } }
        public Object PostGameOverviewWidgetClass { get { return this[nameof(PostGameOverviewWidgetClass)]; } set { this[nameof(PostGameOverviewWidgetClass)] = value; } }
        public Object RankUpdateWidgetClass { get { return this[nameof(RankUpdateWidgetClass)]; } set { this[nameof(RankUpdateWidgetClass)] = value; } }
        public Array<PortalWarsDialogWidget> DialogObjects { get { return new Array<PortalWarsDialogWidget>(this[nameof(DialogObjects)].Address); } }
        public void ShowBattlePassPurchaseDialog() { Invoke(nameof(ShowBattlePassPurchaseDialog)); }
        public void QueueError(ErrorInfo ErrorInfo) { Invoke(nameof(QueueError), ErrorInfo); }
        public void OpenNoticeDialog(ErrorInfo ErrorInfo) { Invoke(nameof(OpenNoticeDialog), ErrorInfo); }
        public void OpenErrorDialog(ErrorInfo ErrorInfo) { Invoke(nameof(OpenErrorDialog), ErrorInfo); }
        public void OnSessionQueryError(ErrorInfo ErrorInfo) { Invoke(nameof(OnSessionQueryError), ErrorInfo); }
        public void OnRewardsReceived(Object Type, Array<RewardData> Rewards) { Invoke(nameof(OnRewardsReceived), Type, Rewards); }
        public void OnRankUpdate(UserRankUpdate Data) { Invoke(nameof(OnRankUpdate), Data); }
        public void OnProgressionUpdate(UserProgressionUpdate Data) { Invoke(nameof(OnProgressionUpdate), Data); }
        public void OnProgressionMatchUpdate(UserProgressionUpdate Data) { Invoke(nameof(OnProgressionMatchUpdate), Data); }
        public void OnPostGameStats(Array<UserPostGameStat> Data) { Invoke(nameof(OnPostGameStats), Data); }
        public void OnPlaylistActiveUpdate(Object PlaylistType) { Invoke(nameof(OnPlaylistActiveUpdate), PlaylistType); }
        public void OnPartyError(ErrorInfo ErrorInfo) { Invoke(nameof(OnPartyError), ErrorInfo); }
        public void OnLimitedTimeOfferReceived(StoreCategoryInfo LimitedTimeOffer) { Invoke(nameof(OnLimitedTimeOfferReceived), LimitedTimeOffer); }
        public void OnHappyHourStatusUpdate() { Invoke(nameof(OnHappyHourStatusUpdate)); }
        public void OnGameSessionReconnectAvailable(Object GameSessionId, float DurationMs) { Invoke(nameof(OnGameSessionReconnectAvailable), GameSessionId, DurationMs); }
        public void OnDailyPlayStreakIncreased(UserDailyStreakInfo Data) { Invoke(nameof(OnDailyPlayStreakIncreased), Data); }
        public void OnChallengesUpdated(Array<UserChallengeUpdate> Challenges) { Invoke(nameof(OnChallengesUpdated), Challenges); }
        public PortalWarsRewardReceivedWidget GetRewardReceivedWidgetForType(Object TypeString) { return Invoke<PortalWarsRewardReceivedWidget>(nameof(GetRewardReceivedWidgetForType), TypeString); }
        public PortalWarsPostGameOverviewWidget GetPostGameOverviewWidget() { return Invoke<PortalWarsPostGameOverviewWidget>(nameof(GetPostGameOverviewWidget)); }
        public PortalWarsChallengeDialogWidget GetChallengeDialogWidget() { return Invoke<PortalWarsChallengeDialogWidget>(nameof(GetChallengeDialogWidget)); }
    }
    public class PortalWarsNotificationOverlayWidget : PortalWarsUserWidget
    {
        public PortalWarsNotificationOverlayWidget(ulong addr) : base(addr) { }
        public Object InviteEntryWidgetClass { get { return this[nameof(InviteEntryWidgetClass)]; } set { this[nameof(InviteEntryWidgetClass)] = value; } }
        public Object RequestEntryWidgetClass { get { return this[nameof(RequestEntryWidgetClass)]; } set { this[nameof(RequestEntryWidgetClass)] = value; } }
        public Object ChunkInstallWidgetClass { get { return this[nameof(ChunkInstallWidgetClass)]; } set { this[nameof(ChunkInstallWidgetClass)] = value; } }
        public PanelWidget MessagePanel { get { return this[nameof(MessagePanel)].As<PanelWidget>(); } set { this["MessagePanel"] = value; } }
        public PanelWidget NotificationPanel { get { return this[nameof(NotificationPanel)].As<PanelWidget>(); } set { this["NotificationPanel"] = value; } }
        public void OnInviteRecieved(InviteInfo Invite) { Invoke(nameof(OnInviteRecieved), Invite); }
        public void OnFriendRequestReceived(FriendRequestInfo Request) { Invoke(nameof(OnFriendRequestReceived), Request); }
        public void OnFriendRequestAccepted(FriendRequestInfo Request) { Invoke(nameof(OnFriendRequestAccepted), Request); }
        public void CheckChunkIntallStatus() { Invoke(nameof(CheckChunkIntallStatus)); }
    }
    public class PortalWarsNvidiaHighlightsUtils : Object
    {
        public PortalWarsNvidiaHighlightsUtils(ulong addr) : base(addr) { }
    }
    public class PortalWarsOddball : PortalWarsGameMode
    {
        public PortalWarsOddball(ulong addr) : base(addr) { }
    }
    public class PortalWarsOddballGameState : PortalWarsGameState
    {
        public PortalWarsOddballGameState(ulong addr) : base(addr) { }
        public Actor Oddball { get { return this[nameof(Oddball)].As<Actor>(); } set { this["Oddball"] = value; } }
        public EBallState OddballState { get { return (EBallState)this[nameof(OddballState)].GetValue<int>(); } set { this[nameof(OddballState)].SetValue<int>((int)value); } }
        public void OnRep_OddballState(EBallState PrevBallState) { Invoke(nameof(OnRep_OddballState), PrevBallState); }
        public void OnRep_Oddball() { Invoke(nameof(OnRep_Oddball)); }
    }
    public class PortalWarsOddballHUD : PortalWarsHUD
    {
        public PortalWarsOddballHUD(ulong addr) : base(addr) { }
        public PortalWarsOddballIndicator BallIndicator { get { return this[nameof(BallIndicator)].As<PortalWarsOddballIndicator>(); } set { this["BallIndicator"] = value; } }
        public Object BallIndicatorWidgetClass { get { return this[nameof(BallIndicatorWidgetClass)]; } set { this[nameof(BallIndicatorWidgetClass)] = value; } }
    }
    public class PortalWarsOddballIndicator : PortalWarsIndicatorWidget
    {
        public PortalWarsOddballIndicator(ulong addr) : base(addr) { }
        public Widget Pointer { get { return this[nameof(Pointer)].As<Widget>(); } set { this["Pointer"] = value; } }
        public Image OnScreenBackgroundImage { get { return this[nameof(OnScreenBackgroundImage)].As<Image>(); } set { this["OnScreenBackgroundImage"] = value; } }
        public Image OffScreenBackgroundImage { get { return this[nameof(OffScreenBackgroundImage)].As<Image>(); } set { this["OffScreenBackgroundImage"] = value; } }
        public Texture2D NeutralBackground { get { return this[nameof(NeutralBackground)].As<Texture2D>(); } set { this["NeutralBackground"] = value; } }
        public Texture2D RedBackground { get { return this[nameof(RedBackground)].As<Texture2D>(); } set { this["RedBackground"] = value; } }
        public Texture2D BlueBackground { get { return this[nameof(BlueBackground)].As<Texture2D>(); } set { this["BlueBackground"] = value; } }
        public void SetControllingTeam(int NewControllingTeam) { Invoke(nameof(SetControllingTeam), NewControllingTeam); }
        public Texture2D GetIndicatorBackground() { return Invoke<Texture2D>(nameof(GetIndicatorBackground)); }
    }
    public class PortalWarsOITC : PortalWarsGameMode
    {
        public PortalWarsOITC(ulong addr) : base(addr) { }
        public bool bAllowAmmoStacking { get { return this[nameof(bAllowAmmoStacking)].Flag; } set { this[nameof(bAllowAmmoStacking)].Flag = value; } }
        public bool bMeleeRequiredForAmmoStacking { get { return this[nameof(bMeleeRequiredForAmmoStacking)].Flag; } set { this[nameof(bMeleeRequiredForAmmoStacking)].Flag = value; } }
        public int MaxAmmo { get { return this[nameof(MaxAmmo)].GetValue<int>(); } set { this[nameof(MaxAmmo)].SetValue<int>(value); } }
    }
    public class PortalWarsOnlineSessionClient : OnlineSessionClient
    {
        public PortalWarsOnlineSessionClient(ulong addr) : base(addr) { }
        public void OnReturnToMainMenu() { Invoke(nameof(OnReturnToMainMenu)); }
    }
    public class PortalWarsOutOfBoundsWidget : UserWidget
    {
        public PortalWarsOutOfBoundsWidget(ulong addr) : base(addr) { }
        public CanvasPanel OutOfBoundsPanel { get { return this[nameof(OutOfBoundsPanel)].As<CanvasPanel>(); } set { this["OutOfBoundsPanel"] = value; } }
        public TextBlock CountdownText { get { return this[nameof(CountdownText)].As<TextBlock>(); } set { this["CountdownText"] = value; } }
    }
    public class PortalWarsOverwolfUtils : Object
    {
        public PortalWarsOverwolfUtils(ulong addr) : base(addr) { }
    }
    public class PortalWarsPartyEntryWidget : PortalWarsPlayerEntryWidget
    {
        public PortalWarsPartyEntryWidget(ulong addr) : base(addr) { }
        public PortalWarsPlayerEntryWidget PlayerEntry { get { return this[nameof(PlayerEntry)].As<PortalWarsPlayerEntryWidget>(); } set { this["PlayerEntry"] = value; } }
        public Widget LeaderIndicator { get { return this[nameof(LeaderIndicator)].As<Widget>(); } set { this["LeaderIndicator"] = value; } }
        public WidgetSwitcher EntrySwitcher { get { return this[nameof(EntrySwitcher)].As<WidgetSwitcher>(); } set { this["EntrySwitcher"] = value; } }
        public Object OnInviteButtonClickedDelegate { get { return this[nameof(OnInviteButtonClickedDelegate)]; } set { this[nameof(OnInviteButtonClickedDelegate)] = value; } }
        public Button InviteButton { get { return this[nameof(InviteButton)].As<Button>(); } set { this["InviteButton"] = value; } }
        public Widget InviteRoot { get { return this[nameof(InviteRoot)].As<Widget>(); } set { this["InviteRoot"] = value; } }
        public void OnUnhovered_BP() { Invoke(nameof(OnUnhovered_BP)); }
        public void OnInviteButtonClicked() { Invoke(nameof(OnInviteButtonClicked)); }
        public void OnHovered_BP() { Invoke(nameof(OnHovered_BP)); }
        public void OnEndHoverCharacter(PrimitiveComponent TouchedComponent) { Invoke(nameof(OnEndHoverCharacter), TouchedComponent); }
        public void OnBeginHoverCharacter(PrimitiveComponent TouchedComponent) { Invoke(nameof(OnBeginHoverCharacter), TouchedComponent); }
        public ESlateVisibility GetLeaderVisibility() { return Invoke<ESlateVisibility>(nameof(GetLeaderVisibility)); }
        public ESlateVisibility GetInviteVisibility() { return Invoke<ESlateVisibility>(nameof(GetInviteVisibility)); }
        public bool CanInviteToParty() { return Invoke<bool>(nameof(CanInviteToParty)); }
    }
    public class PortalWarsPartyInspectWidget : PortalWarsMenuSelectWidget
    {
        public PortalWarsPartyInspectWidget(ulong addr) : base(addr) { }
        public PortalWarsButtonWidget MuteButton { get { return this[nameof(MuteButton)].As<PortalWarsButtonWidget>(); } set { this["MuteButton"] = value; } }
        public PortalWarsButtonWidget PromoteButton { get { return this[nameof(PromoteButton)].As<PortalWarsButtonWidget>(); } set { this["PromoteButton"] = value; } }
        public PortalWarsButtonWidget KickButton { get { return this[nameof(KickButton)].As<PortalWarsButtonWidget>(); } set { this["KickButton"] = value; } }
        public PortalWarsButtonWidget ViewProfileButton { get { return this[nameof(ViewProfileButton)].As<PortalWarsButtonWidget>(); } set { this["ViewProfileButton"] = value; } }
        public PortalWarsPlayerEntryWidget PlayerEntry { get { return this[nameof(PlayerEntry)].As<PortalWarsPlayerEntryWidget>(); } set { this["PlayerEntry"] = value; } }
        public PortalWarsStatsEntryWidget Stats { get { return this[nameof(Stats)].As<PortalWarsStatsEntryWidget>(); } set { this["Stats"] = value; } }
        public void ViewProfile() { Invoke(nameof(ViewProfile)); }
        public void RefreshWidget() { Invoke(nameof(RefreshWidget)); }
        public void PromoteToLeader() { Invoke(nameof(PromoteToLeader)); }
        public void KickFromParty() { Invoke(nameof(KickFromParty)); }
        public ESlateVisibility GetLeaderOptionsVisibility() { return Invoke<ESlateVisibility>(nameof(GetLeaderOptionsVisibility)); }
    }
    public class PortalWarsPartyWidget : PortalWarsUserWidget
    {
        public PortalWarsPartyWidget(ulong addr) : base(addr) { }
        public Object PartyEntryWidgetClass { get { return this[nameof(PartyEntryWidgetClass)]; } set { this[nameof(PartyEntryWidgetClass)] = value; } }
        public Object PartyInspectWidgetClass { get { return this[nameof(PartyInspectWidgetClass)]; } set { this[nameof(PartyInspectWidgetClass)] = value; } }
        public CanvasPanel ItemsPanel { get { return this[nameof(ItemsPanel)].As<CanvasPanel>(); } set { this["ItemsPanel"] = value; } }
        public void OnPartyUpdate() { Invoke(nameof(OnPartyUpdate)); }
        public void OnMouseClicked() { Invoke(nameof(OnMouseClicked)); }
        public void OnInviteSelected() { Invoke(nameof(OnInviteSelected)); }
        public void OnEntrySelected(PortalWarsEntryWidget Entry) { Invoke(nameof(OnEntrySelected), Entry); }
    }
    public class PortalWarsPathFollowingComponent : PathFollowingComponent
    {
        public PortalWarsPathFollowingComponent(ulong addr) : base(addr) { }
        public CharacterMovementComponent CharacterMoveComp { get { return this[nameof(CharacterMoveComp)].As<CharacterMovementComponent>(); } set { this["CharacterMoveComp"] = value; } }
    }
    public class PortalWarsPauseMenuWidget : PortalWarsMenuSelectWidget
    {
        public PortalWarsPauseMenuWidget(ulong addr) : base(addr) { }
        public PortalWarsButtonWidget ResumeButton { get { return this[nameof(ResumeButton)].As<PortalWarsButtonWidget>(); } set { this["ResumeButton"] = value; } }
        public PortalWarsButtonWidget SettingsButton { get { return this[nameof(SettingsButton)].As<PortalWarsButtonWidget>(); } set { this["SettingsButton"] = value; } }
        public PortalWarsButtonWidget PlayersButton { get { return this[nameof(PlayersButton)].As<PortalWarsButtonWidget>(); } set { this["PlayersButton"] = value; } }
        public PortalWarsButtonWidget ExitButton { get { return this[nameof(ExitButton)].As<PortalWarsButtonWidget>(); } set { this["ExitButton"] = value; } }
        public PortalWarsButtonWidget EndMatchButton { get { return this[nameof(EndMatchButton)].As<PortalWarsButtonWidget>(); } set { this["EndMatchButton"] = value; } }
        public PortalWarsButtonWidget RestartRaceButton { get { return this[nameof(RestartRaceButton)].As<PortalWarsButtonWidget>(); } set { this["RestartRaceButton"] = value; } }
        public PortalWarsButtonWidget RestartStageButton { get { return this[nameof(RestartStageButton)].As<PortalWarsButtonWidget>(); } set { this["RestartStageButton"] = value; } }
        public void OnRestartStageButtonClicked() { Invoke(nameof(OnRestartStageButtonClicked)); }
        public void OnRestartRaceButtonClicked() { Invoke(nameof(OnRestartRaceButtonClicked)); }
        public void OnPauseActionPressed() { Invoke(nameof(OnPauseActionPressed)); }
        public void OnEndMatchButtonClicked() { Invoke(nameof(OnEndMatchButtonClicked)); }
        public void GoToSettingsState() { Invoke(nameof(GoToSettingsState)); }
        public void GoToQuitState() { Invoke(nameof(GoToQuitState)); }
        public void GoToPlayersState() { Invoke(nameof(GoToPlayersState)); }
        public void GoToMainState() { Invoke(nameof(GoToMainState)); }
        public ESlateVisibility GetRestartStageVisibility() { return Invoke<ESlateVisibility>(nameof(GetRestartStageVisibility)); }
        public ESlateVisibility GetRestartRaceVisibility() { return Invoke<ESlateVisibility>(nameof(GetRestartRaceVisibility)); }
        public ESlateVisibility GetPlayersButtonVisibility() { return Invoke<ESlateVisibility>(nameof(GetPlayersButtonVisibility)); }
        public ESlateVisibility GetExitButtonVisibility() { return Invoke<ESlateVisibility>(nameof(GetExitButtonVisibility)); }
        public bool GetExitButtonEnabled() { return Invoke<bool>(nameof(GetExitButtonEnabled)); }
        public ESlateVisibility GetEndMatchButtonVisibility() { return Invoke<ESlateVisibility>(nameof(GetEndMatchButtonVisibility)); }
    }
    public class PortalWarsPausePlayersMenuWidget : PortalWarsMenuWidget
    {
        public PortalWarsPausePlayersMenuWidget(ulong addr) : base(addr) { }
        public Object PlayerEntryWidgetClass { get { return this[nameof(PlayerEntryWidgetClass)]; } set { this[nameof(PlayerEntryWidgetClass)] = value; } }
        public PanelWidget PlayersPanel { get { return this[nameof(PlayersPanel)].As<PanelWidget>(); } set { this["PlayersPanel"] = value; } }
        public Object PlayerActionsWidgetClass { get { return this[nameof(PlayerActionsWidgetClass)]; } set { this[nameof(PlayerActionsWidgetClass)] = value; } }
        public void OnPlayerEntrySelected(PortalWarsEntryWidget Entry) { Invoke(nameof(OnPlayerEntrySelected), Entry); }
        public void OnPlayerArrayChanged(PlayerState PlayerState) { Invoke(nameof(OnPlayerArrayChanged), PlayerState); }
    }
    public class PortalWarsPickupIndicatorWidget : PortalWarsIndicatorWidget
    {
        public PortalWarsPickupIndicatorWidget(ulong addr) : base(addr) { }
        public TextBlock PickupNameText { get { return this[nameof(PickupNameText)].As<TextBlock>(); } set { this["PickupNameText"] = value; } }
        public Object GetPickupNameText() { return Invoke<Object>(nameof(GetPickupNameText)); }
        public Object GetActionKey() { return Invoke<Object>(nameof(GetActionKey)); }
    }
    public class PortalWarsPickupWidget : PortalWarsUserWidget
    {
        public PortalWarsPickupWidget(ulong addr) : base(addr) { }
        public Widget Root { get { return this[nameof(Root)].As<Widget>(); } set { this["Root"] = value; } }
        public Image PickupImage { get { return this[nameof(PickupImage)].As<Image>(); } set { this["PickupImage"] = value; } }
        public TextBlock PickupText { get { return this[nameof(PickupText)].As<TextBlock>(); } set { this["PickupText"] = value; } }
        public RichTextBlock ActionText { get { return this[nameof(ActionText)].As<RichTextBlock>(); } set { this["ActionText"] = value; } }
        public WidgetAnimation FadeInAnimation { get { return this[nameof(FadeInAnimation)].As<WidgetAnimation>(); } set { this["FadeInAnimation"] = value; } }
        public WidgetSwitcher ConsoleSwitcher { get { return this[nameof(ConsoleSwitcher)].As<WidgetSwitcher>(); } set { this["ConsoleSwitcher"] = value; } }
        public RichTextBlock ConsoleActionText { get { return this[nameof(ConsoleActionText)].As<RichTextBlock>(); } set { this["ConsoleActionText"] = value; } }
        public Image ConsoleActionImage { get { return this[nameof(ConsoleActionImage)].As<Image>(); } set { this["ConsoleActionImage"] = value; } }
        public PortalWarsProgressRadialWidget ProgressRadial { get { return this[nameof(ProgressRadial)].As<PortalWarsProgressRadialWidget>(); } set { this["ProgressRadial"] = value; } }
    }
    public class PortalWarsPickupZoneAnimInstance : AnimInstance
    {
        public PortalWarsPickupZoneAnimInstance(ulong addr) : base(addr) { }
        public bool bIsActive { get { return this[nameof(bIsActive)].Flag; } set { this[nameof(bIsActive)].Flag = value; } }
        public PortalWarsGunPickupZone PickupZone { get { return this[nameof(PickupZone)].As<PortalWarsGunPickupZone>(); } set { this["PickupZone"] = value; } }
    }
    public class PortalWarsPickupZoneIndicator : PortalWarsPickupIndicatorWidget
    {
        public PortalWarsPickupZoneIndicator(ulong addr) : base(addr) { }
        public TextBlock TimeText { get { return this[nameof(TimeText)].As<TextBlock>(); } set { this["TimeText"] = value; } }
        public ESlateVisibility GetTimeVisibility() { return Invoke<ESlateVisibility>(nameof(GetTimeVisibility)); }
        public Object GetTimeRemainingText() { return Invoke<Object>(nameof(GetTimeRemainingText)); }
    }
    public class PortalWarsPlayButtonWidget : PortalWarsButtonWidget
    {
        public PortalWarsPlayButtonWidget(ulong addr) : base(addr) { }
        public TextBlock ButtonText { get { return this[nameof(ButtonText)].As<TextBlock>(); } set { this["ButtonText"] = value; } }
    }
    public class PortalWarsPlayerActionsWidget : PortalWarsMenuSelectWidget
    {
        public PortalWarsPlayerActionsWidget(ulong addr) : base(addr) { }
        public PortalWarsReportPlayerWidget ReportMenu { get { return this[nameof(ReportMenu)].As<PortalWarsReportPlayerWidget>(); } set { this["ReportMenu"] = value; } }
        public PortalWarsButtonWidget ReportButton { get { return this[nameof(ReportButton)].As<PortalWarsButtonWidget>(); } set { this["ReportButton"] = value; } }
        public PortalWarsButtonWidget ViewProfileButton { get { return this[nameof(ViewProfileButton)].As<PortalWarsButtonWidget>(); } set { this["ViewProfileButton"] = value; } }
        public float ResetInviteDelay { get { return this[nameof(ResetInviteDelay)].GetValue<float>(); } set { this[nameof(ResetInviteDelay)].SetValue<float>(value); } }
        public PortalWarsButtonWidget PartyInviteButton { get { return this[nameof(PartyInviteButton)].As<PortalWarsButtonWidget>(); } set { this["PartyInviteButton"] = value; } }
        public PortalWarsButtonWidget GameInviteButton { get { return this[nameof(GameInviteButton)].As<PortalWarsButtonWidget>(); } set { this["GameInviteButton"] = value; } }
        public float ResetFriendDelay { get { return this[nameof(ResetFriendDelay)].GetValue<float>(); } set { this[nameof(ResetFriendDelay)].SetValue<float>(value); } }
        public PortalWarsButtonWidget AddFriendButton { get { return this[nameof(AddFriendButton)].As<PortalWarsButtonWidget>(); } set { this["AddFriendButton"] = value; } }
        public PortalWarsButtonWidget RemoveFriendButton { get { return this[nameof(RemoveFriendButton)].As<PortalWarsButtonWidget>(); } set { this["RemoveFriendButton"] = value; } }
        public float ResetBlockDelay { get { return this[nameof(ResetBlockDelay)].GetValue<float>(); } set { this[nameof(ResetBlockDelay)].SetValue<float>(value); } }
        public PortalWarsButtonWidget BlockButton { get { return this[nameof(BlockButton)].As<PortalWarsButtonWidget>(); } set { this["BlockButton"] = value; } }
        public PortalWarsButtonWidget UnblockButton { get { return this[nameof(UnblockButton)].As<PortalWarsButtonWidget>(); } set { this["UnblockButton"] = value; } }
        public PortalWarsButtonWidget MuteButton { get { return this[nameof(MuteButton)].As<PortalWarsButtonWidget>(); } set { this["MuteButton"] = value; } }
        public PortalWarsButtonWidget KickButton { get { return this[nameof(KickButton)].As<PortalWarsButtonWidget>(); } set { this["KickButton"] = value; } }
        public PortalWarsPlayerEntryWidget PlayerEntry { get { return this[nameof(PlayerEntry)].As<PortalWarsPlayerEntryWidget>(); } set { this["PlayerEntry"] = value; } }
        public void RefreshMuteButton() { Invoke(nameof(RefreshMuteButton)); }
        public void RefreshInviteButtons() { Invoke(nameof(RefreshInviteButtons)); }
        public void RefreshFriendButtons() { Invoke(nameof(RefreshFriendButtons)); }
        public void RefreshBlockButtons() { Invoke(nameof(RefreshBlockButtons)); }
        public void OnViewProfileButtonClicked() { Invoke(nameof(OnViewProfileButtonClicked)); }
        public void OnUnblockButtonClicked() { Invoke(nameof(OnUnblockButtonClicked)); }
        public void OnRemoveFriendButtonClicked() { Invoke(nameof(OnRemoveFriendButtonClicked)); }
        public void OnPartyInviteButtonClicked() { Invoke(nameof(OnPartyInviteButtonClicked)); }
        public void OnMuteButtonClicked() { Invoke(nameof(OnMuteButtonClicked)); }
        public void OnKickButtonClicked() { Invoke(nameof(OnKickButtonClicked)); }
        public void OnGameInviteButtonClicked() { Invoke(nameof(OnGameInviteButtonClicked)); }
        public void OnFriendsListUpdate(int LocalUserNum, bool bWasSuccessful, Object ListName, Object ErrorStr) { Invoke(nameof(OnFriendsListUpdate), LocalUserNum, bWasSuccessful, ListName, ErrorStr); }
        public void OnBlockButtonClicked() { Invoke(nameof(OnBlockButtonClicked)); }
        public void OnAddFriendButtonClicked() { Invoke(nameof(OnAddFriendButtonClicked)); }
        public void GoToReportState() { Invoke(nameof(GoToReportState)); }
        public void GoToMainState() { Invoke(nameof(GoToMainState)); }
        public ESlateVisibility GetViewProfileButtonVisibility() { return Invoke<ESlateVisibility>(nameof(GetViewProfileButtonVisibility)); }
        public bool GetViewProfileButtonEnabled() { return Invoke<bool>(nameof(GetViewProfileButtonEnabled)); }
        public ESlateVisibility GetUnblockButtonVisibility() { return Invoke<ESlateVisibility>(nameof(GetUnblockButtonVisibility)); }
        public bool GetUnblockButtonEnabled() { return Invoke<bool>(nameof(GetUnblockButtonEnabled)); }
        public ESlateVisibility GetReportButtonVisibility() { return Invoke<ESlateVisibility>(nameof(GetReportButtonVisibility)); }
        public bool GetReportButtonEnabled() { return Invoke<bool>(nameof(GetReportButtonEnabled)); }
        public ESlateVisibility GetRemoveFriendButtonVisibility() { return Invoke<ESlateVisibility>(nameof(GetRemoveFriendButtonVisibility)); }
        public bool GetRemoveFriendButtonEnabled() { return Invoke<bool>(nameof(GetRemoveFriendButtonEnabled)); }
        public ESlateVisibility GetPartyInviteButtonVisibility() { return Invoke<ESlateVisibility>(nameof(GetPartyInviteButtonVisibility)); }
        public bool GetPartyInviteButtonEnabled() { return Invoke<bool>(nameof(GetPartyInviteButtonEnabled)); }
        public ESlateVisibility GetMuteButtonVisibility() { return Invoke<ESlateVisibility>(nameof(GetMuteButtonVisibility)); }
        public bool GetMuteButtonEnabled() { return Invoke<bool>(nameof(GetMuteButtonEnabled)); }
        public ESlateVisibility GetKickButtonVisibility() { return Invoke<ESlateVisibility>(nameof(GetKickButtonVisibility)); }
        public bool GetKickButtonEnabled() { return Invoke<bool>(nameof(GetKickButtonEnabled)); }
        public ESlateVisibility GetGameInviteButtonVisibility() { return Invoke<ESlateVisibility>(nameof(GetGameInviteButtonVisibility)); }
        public bool GetGameInviteButtonEnabled() { return Invoke<bool>(nameof(GetGameInviteButtonEnabled)); }
        public ESlateVisibility GetBlockButtonVisibility() { return Invoke<ESlateVisibility>(nameof(GetBlockButtonVisibility)); }
        public bool GetBlockButtonEnabled() { return Invoke<bool>(nameof(GetBlockButtonEnabled)); }
        public ESlateVisibility GetAddFriendButtonVisibility() { return Invoke<ESlateVisibility>(nameof(GetAddFriendButtonVisibility)); }
        public bool GetAddFriendButtonEnabled() { return Invoke<bool>(nameof(GetAddFriendButtonEnabled)); }
    }
    public class PortalWarsPlayerCameraManager : PlayerCameraManager
    {
        public PortalWarsPlayerCameraManager(ulong addr) : base(addr) { }
    }
    public class PortalWarsPlayerCardWidget : PortalWarsCareerProgressWidget
    {
        public PortalWarsPlayerCardWidget(ulong addr) : base(addr) { }
        public TextBlock AlloyText { get { return this[nameof(AlloyText)].As<TextBlock>(); } set { this["AlloyText"] = value; } }
        public TextBlock CurrencyText { get { return this[nameof(CurrencyText)].As<TextBlock>(); } set { this["CurrencyText"] = value; } }
        public TextBlock StreakText { get { return this[nameof(StreakText)].As<TextBlock>(); } set { this["StreakText"] = value; } }
        public Widget StreakRepairIndicator { get { return this[nameof(StreakRepairIndicator)].As<Widget>(); } set { this["StreakRepairIndicator"] = value; } }
        public Widget NotificationIndicator { get { return this[nameof(NotificationIndicator)].As<Widget>(); } set { this["NotificationIndicator"] = value; } }
        public PortalWarsButtonWidget SettingsButton { get { return this[nameof(SettingsButton)].As<PortalWarsButtonWidget>(); } set { this["SettingsButton"] = value; } }
        public PortalWarsButtonWidget NotificationButton { get { return this[nameof(NotificationButton)].As<PortalWarsButtonWidget>(); } set { this["NotificationButton"] = value; } }
        public Button CurrencyButton { get { return this[nameof(CurrencyButton)].As<Button>(); } set { this["CurrencyButton"] = value; } }
        public Button LockerButton { get { return this[nameof(LockerButton)].As<Button>(); } set { this["LockerButton"] = value; } }
        public Button CareerButton { get { return this[nameof(CareerButton)].As<Button>(); } set { this["CareerButton"] = value; } }
        public Button PlayStreakButton { get { return this[nameof(PlayStreakButton)].As<Button>(); } set { this["PlayStreakButton"] = value; } }
        public void OnSettingsButtonClicked() { Invoke(nameof(OnSettingsButtonClicked)); }
        public void OnPlayStreakButtonClicked() { Invoke(nameof(OnPlayStreakButtonClicked)); }
        public void OnNotificationButtonClicked() { Invoke(nameof(OnNotificationButtonClicked)); }
        public void OnLockerButtonClicked() { Invoke(nameof(OnLockerButtonClicked)); }
        public void OnCurrencyButtonClicked() { Invoke(nameof(OnCurrencyButtonClicked)); }
        public void OnCareerButtonClicked() { Invoke(nameof(OnCareerButtonClicked)); }
        public Object GetStreakText() { return Invoke<Object>(nameof(GetStreakText)); }
        public ESlateVisibility GetRepairIndicatorVisibility() { return Invoke<ESlateVisibility>(nameof(GetRepairIndicatorVisibility)); }
        public ESlateVisibility GetNotificationIndicatorVisibility() { return Invoke<ESlateVisibility>(nameof(GetNotificationIndicatorVisibility)); }
        public Object GetCurrencyText() { return Invoke<Object>(nameof(GetCurrencyText)); }
        public Object GetAlloyText() { return Invoke<Object>(nameof(GetAlloyText)); }
    }
    public class PortalWarsPlayerInput : PlayerInput
    {
        public PortalWarsPlayerInput(ulong addr) : base(addr) { }
    }
    public class PortalWarsPlaylistActiveDialog : PortalWarsDialogWidget
    {
        public PortalWarsPlaylistActiveDialog(ulong addr) : base(addr) { }
        public TextBlock TitleText { get { return this[nameof(TitleText)].As<TextBlock>(); } set { this["TitleText"] = value; } }
        public TextBlock DescriptionText { get { return this[nameof(DescriptionText)].As<TextBlock>(); } set { this["DescriptionText"] = value; } }
        public TextBlock XPBoostText { get { return this[nameof(XPBoostText)].As<TextBlock>(); } set { this["XPBoostText"] = value; } }
        public PortalWarsButtonWidget QueueButton { get { return this[nameof(QueueButton)].As<PortalWarsButtonWidget>(); } set { this["QueueButton"] = value; } }
        public void OnQueueButtonClicked() { Invoke(nameof(OnQueueButtonClicked)); }
        public Object GetXPBoostText() { return Invoke<Object>(nameof(GetXPBoostText)); }
        public Object GetTitleText() { return Invoke<Object>(nameof(GetTitleText)); }
        public bool GetQueueButtonEnabled() { return Invoke<bool>(nameof(GetQueueButtonEnabled)); }
        public Object GetDescriptionText() { return Invoke<Object>(nameof(GetDescriptionText)); }
    }
    public class PortalWarsPlaylistEntryWidget : PortalWarsEntryWidget
    {
        public PortalWarsPlaylistEntryWidget(ulong addr) : base(addr) { }
        public TextBlock TitleText2 { get { return this[nameof(TitleText2)].As<TextBlock>(); } set { this["TitleText2"] = value; } }
        public TextBlock DescriptionText { get { return this[nameof(DescriptionText)].As<TextBlock>(); } set { this["DescriptionText"] = value; } }
        public Image DisplayImage { get { return this[nameof(DisplayImage)].As<Image>(); } set { this["DisplayImage"] = value; } }
        public Image IconImage { get { return this[nameof(IconImage)].As<Image>(); } set { this["IconImage"] = value; } }
        public Image PlayIcon { get { return this[nameof(PlayIcon)].As<Image>(); } set { this["PlayIcon"] = value; } }
        public Widget SelectedIndicator { get { return this[nameof(SelectedIndicator)].As<Widget>(); } set { this["SelectedIndicator"] = value; } }
        public Widget RankRoot { get { return this[nameof(RankRoot)].As<Widget>(); } set { this["RankRoot"] = value; } }
        public Image RankImage { get { return this[nameof(RankImage)].As<Image>(); } set { this["RankImage"] = value; } }
        public TextBlock RankXPText { get { return this[nameof(RankXPText)].As<TextBlock>(); } set { this["RankXPText"] = value; } }
        public TextBlock NoteText { get { return this[nameof(NoteText)].As<TextBlock>(); } set { this["NoteText"] = value; } }
        public Widget NoteRoot { get { return this[nameof(NoteRoot)].As<Widget>(); } set { this["NoteRoot"] = value; } }
        public Widget XPBoostIndicator { get { return this[nameof(XPBoostIndicator)].As<Widget>(); } set { this["XPBoostIndicator"] = value; } }
        public TextBlock XPBoostText { get { return this[nameof(XPBoostText)].As<TextBlock>(); } set { this["XPBoostText"] = value; } }
        public byte HorizontalAlignment { get { return this[nameof(HorizontalAlignment)].GetValue<byte>(); } set { this[nameof(HorizontalAlignment)].SetValue<byte>(value); } }
        public bool bIsPreviewOnly { get { return this[nameof(bIsPreviewOnly)].Flag; } set { this[nameof(bIsPreviewOnly)].Flag = value; } }
        public WidgetSwitcher ScrimSwitcher { get { return this[nameof(ScrimSwitcher)].As<WidgetSwitcher>(); } set { this["ScrimSwitcher"] = value; } }
        public WidgetSwitcher ShadowSwitcher { get { return this[nameof(ShadowSwitcher)].As<WidgetSwitcher>(); } set { this["ShadowSwitcher"] = value; } }
        public AkAudioEvent OpenModeSelectEvent { get { return this[nameof(OpenModeSelectEvent)].As<AkAudioEvent>(); } set { this["OpenModeSelectEvent"] = value; } }
        public Object GetXPBoostText() { return Invoke<Object>(nameof(GetXPBoostText)); }
        public ESlateVisibility GetXPBoostIndicatorVisibility() { return Invoke<ESlateVisibility>(nameof(GetXPBoostIndicatorVisibility)); }
        public Object GetTitleText() { return Invoke<Object>(nameof(GetTitleText)); }
        public Object GetRankXPText() { return Invoke<Object>(nameof(GetRankXPText)); }
        public ESlateVisibility GetRankVisibility() { return Invoke<ESlateVisibility>(nameof(GetRankVisibility)); }
        public Texture2D GetRankIcon() { return Invoke<Texture2D>(nameof(GetRankIcon)); }
        public ESlateVisibility GetNoteTextVisibility() { return Invoke<ESlateVisibility>(nameof(GetNoteTextVisibility)); }
        public Object GetNoteText() { return Invoke<Object>(nameof(GetNoteText)); }
        public Object GetDescriptionText() { return Invoke<Object>(nameof(GetDescriptionText)); }
    }
    public class PortalWarsPlaylistGameModeEntry : PortalWarsEntryWidget
    {
        public PortalWarsPlaylistGameModeEntry(ulong addr) : base(addr) { }
        public TextBlock NoteText { get { return this[nameof(NoteText)].As<TextBlock>(); } set { this["NoteText"] = value; } }
        public ButtonStyle DefaultButtonStyle { get { return this[nameof(DefaultButtonStyle)].As<ButtonStyle>(); } set { this["DefaultButtonStyle"] = value; } }
        public ButtonStyle SelectedButtonStyle { get { return this[nameof(SelectedButtonStyle)].As<ButtonStyle>(); } set { this["SelectedButtonStyle"] = value; } }
        public Object GetTitleText() { return Invoke<Object>(nameof(GetTitleText)); }
        public ESlateVisibility GetNoteTextVisibility() { return Invoke<ESlateVisibility>(nameof(GetNoteTextVisibility)); }
        public Object GetNoteText() { return Invoke<Object>(nameof(GetNoteText)); }
        public ButtonStyle GetButtonStyle() { return Invoke<ButtonStyle>(nameof(GetButtonStyle)); }
    }
    public class PortalWarsPlaylistGameModeSelect : PortalWarsMenuWidget
    {
        public PortalWarsPlaylistGameModeSelect(ulong addr) : base(addr) { }
        public Object GameModeEntryWidgetClass { get { return this[nameof(GameModeEntryWidgetClass)]; } set { this[nameof(GameModeEntryWidgetClass)] = value; } }
        public PanelWidget ModesPanel { get { return this[nameof(ModesPanel)].As<PanelWidget>(); } set { this["ModesPanel"] = value; } }
        public Widget FeaturedModesRoot { get { return this[nameof(FeaturedModesRoot)].As<Widget>(); } set { this["FeaturedModesRoot"] = value; } }
        public PanelWidget FeaturedModesPanel { get { return this[nameof(FeaturedModesPanel)].As<PanelWidget>(); } set { this["FeaturedModesPanel"] = value; } }
        public PortalWarsPlaylistEntryWidget PlaylistEntry { get { return this[nameof(PlaylistEntry)].As<PortalWarsPlaylistEntryWidget>(); } set { this["PlaylistEntry"] = value; } }
        public PortalWarsGameModeInfoWidget GameModeInfo { get { return this[nameof(GameModeInfo)].As<PortalWarsGameModeInfoWidget>(); } set { this["GameModeInfo"] = value; } }
        public PortalWarsButtonWidget PlayButton { get { return this[nameof(PlayButton)].As<PortalWarsButtonWidget>(); } set { this["PlayButton"] = value; } }
        public TextBlock NoteText { get { return this[nameof(NoteText)].As<TextBlock>(); } set { this["NoteText"] = value; } }
        public void RefreshGameModes() { Invoke(nameof(RefreshGameModes)); }
        public void OnPlayButtonClicked() { Invoke(nameof(OnPlayButtonClicked)); }
        public void OnGameModeEntryHovered(PortalWarsEntryWidget Entry) { Invoke(nameof(OnGameModeEntryHovered), Entry); }
    }
    public class PortalWarsPlaylistSelectWidget : PortalWarsMenuWidget
    {
        public PortalWarsPlaylistSelectWidget(ulong addr) : base(addr) { }
        public PortalWarsPlaylistGameModeSelect GameModeSelectMenu { get { return this[nameof(GameModeSelectMenu)].As<PortalWarsPlaylistGameModeSelect>(); } set { this["GameModeSelectMenu"] = value; } }
        public Object PlaylistEntryWidgetClass { get { return this[nameof(PlaylistEntryWidgetClass)]; } set { this[nameof(PlaylistEntryWidgetClass)] = value; } }
        public PanelWidget PlaylistPanel { get { return this[nameof(PlaylistPanel)].As<PanelWidget>(); } set { this["PlaylistPanel"] = value; } }
        public TextBlock NoteText { get { return this[nameof(NoteText)].As<TextBlock>(); } set { this["NoteText"] = value; } }
        public Widget NoteRoot { get { return this[nameof(NoteRoot)].As<Widget>(); } set { this["NoteRoot"] = value; } }
        public void RefreshPlaylists() { Invoke(nameof(RefreshPlaylists)); }
        public void RefreshNoteText() { Invoke(nameof(RefreshNoteText)); }
        public void OnPlaylistEntrySelected(PortalWarsEntryWidget Entry) { Invoke(nameof(OnPlaylistEntrySelected), Entry); }
        public void OnPlaylistCustomizeSelected(PortalWarsEntryWidget Entry) { Invoke(nameof(OnPlaylistCustomizeSelected), Entry); }
        public void GoToSelectionState() { Invoke(nameof(GoToSelectionState)); }
        public void GoToMainState() { Invoke(nameof(GoToMainState)); }
    }
    public class PortalWarsPlaySelectionWidget : PortalWarsMenuWidget
    {
        public PortalWarsPlaySelectionWidget(ulong addr) : base(addr) { }
        public PortalWarsMenuWidget OnlineWidget { get { return this[nameof(OnlineWidget)].As<PortalWarsMenuWidget>(); } set { this["OnlineWidget"] = value; } }
        public PortalWarsMenuWidget CustomWidget { get { return this[nameof(CustomWidget)].As<PortalWarsMenuWidget>(); } set { this["CustomWidget"] = value; } }
    }
    public class PortalWarsPlayStreakDialogWidget : PortalWarsTxnDialogWidget
    {
        public PortalWarsPlayStreakDialogWidget(ulong addr) : base(addr) { }
        public TextBlock CurrencyText { get { return this[nameof(CurrencyText)].As<TextBlock>(); } set { this["CurrencyText"] = value; } }
        public PortalWarsPlayStreakRewardWidget PlayStreakReward { get { return this[nameof(PlayStreakReward)].As<PortalWarsPlayStreakRewardWidget>(); } set { this["PlayStreakReward"] = value; } }
        public void RefreshRewards() { Invoke(nameof(RefreshRewards)); }
        public Object GetCurrencyText() { return Invoke<Object>(nameof(GetCurrencyText)); }
    }
    public class PortalWarsPlayStreakRewardWidget : PortalWarsRewardEntryWidget
    {
        public PortalWarsPlayStreakRewardWidget(ulong addr) : base(addr) { }
        public PortalWarsProgressionIconWidget StreakIcon { get { return this[nameof(StreakIcon)].As<PortalWarsProgressionIconWidget>(); } set { this["StreakIcon"] = value; } }
        public Image SeparatorImage { get { return this[nameof(SeparatorImage)].As<Image>(); } set { this["SeparatorImage"] = value; } }
        public Image SeparatorImageComplete { get { return this[nameof(SeparatorImageComplete)].As<Image>(); } set { this["SeparatorImageComplete"] = value; } }
        public Image SeparatorImageMissed { get { return this[nameof(SeparatorImageMissed)].As<Image>(); } set { this["SeparatorImageMissed"] = value; } }
        public Widget RewardPanel { get { return this[nameof(RewardPanel)].As<Widget>(); } set { this["RewardPanel"] = value; } }
        public WidgetSwitcher RewardBackgroundSwitcher { get { return this[nameof(RewardBackgroundSwitcher)].As<WidgetSwitcher>(); } set { this["RewardBackgroundSwitcher"] = value; } }
        public Widget TodayPanel { get { return this[nameof(TodayPanel)].As<Widget>(); } set { this["TodayPanel"] = value; } }
        public ESlateVisibility GetSeparatorVisibility() { return Invoke<ESlateVisibility>(nameof(GetSeparatorVisibility)); }
    }
    public class PortalWarsPlayWidget : PortalWarsMenuWidget
    {
        public PortalWarsPlayWidget(ulong addr) : base(addr) { }
        public PortalWarsMenuWidget SelectionWidget { get { return this[nameof(SelectionWidget)].As<PortalWarsMenuWidget>(); } set { this["SelectionWidget"] = value; } }
        public PortalWarsChallengePanelWidget ChallengePanel { get { return this[nameof(ChallengePanel)].As<PortalWarsChallengePanelWidget>(); } set { this["ChallengePanel"] = value; } }
        public PortalWarsPartyWidget PartyWidget { get { return this[nameof(PartyWidget)].As<PortalWarsPartyWidget>(); } set { this["PartyWidget"] = value; } }
        public WidgetSwitcher PlaySwitcher { get { return this[nameof(PlaySwitcher)].As<WidgetSwitcher>(); } set { this["PlaySwitcher"] = value; } }
        public PortalWarsButtonWidget PlayButton { get { return this[nameof(PlayButton)].As<PortalWarsButtonWidget>(); } set { this["PlayButton"] = value; } }
        public PortalWarsButtonWidget CancelButton { get { return this[nameof(CancelButton)].As<PortalWarsButtonWidget>(); } set { this["CancelButton"] = value; } }
        public PortalWarsButtonWidget RewardCenterButton { get { return this[nameof(RewardCenterButton)].As<PortalWarsButtonWidget>(); } set { this["RewardCenterButton"] = value; } }
        public PortalWarsGameInstance GameInstanceRef { get { return this[nameof(GameInstanceRef)].As<PortalWarsGameInstance>(); } set { this["GameInstanceRef"] = value; } }
        public void OnRewardCenterButtonClicked() { Invoke(nameof(OnRewardCenterButtonClicked)); }
        public void OnPartyUpdate() { Invoke(nameof(OnPartyUpdate)); }
        public void OnClientSessionStateChanged() { Invoke(nameof(OnClientSessionStateChanged)); }
        public void GoToSelectionState() { Invoke(nameof(GoToSelectionState)); }
        public void GoToMainState() { Invoke(nameof(GoToMainState)); }
        public void CancelMatchmaking() { Invoke(nameof(CancelMatchmaking)); }
    }
    public class PortalWarsPortalDmgType : PortalWarsDamageType
    {
        public PortalWarsPortalDmgType(ulong addr) : base(addr) { }
    }
    public class PortalWarsPortalIndicatorWidget : PortalWarsIndicatorWidget
    {
        public PortalWarsPortalIndicatorWidget(ulong addr) : base(addr) { }
        public Widget Pointer { get { return this[nameof(Pointer)].As<Widget>(); } set { this["Pointer"] = value; } }
        public Image OnScreenIndicatorImage { get { return this[nameof(OnScreenIndicatorImage)].As<Image>(); } set { this["OnScreenIndicatorImage"] = value; } }
        public Image OffScreenIndicatorImage { get { return this[nameof(OffScreenIndicatorImage)].As<Image>(); } set { this["OffScreenIndicatorImage"] = value; } }
        public Image Scrim { get { return this[nameof(Scrim)].As<Image>(); } set { this["Scrim"] = value; } }
        public Texture2D LeftPortalIndicatorImage { get { return this[nameof(LeftPortalIndicatorImage)].As<Texture2D>(); } set { this["LeftPortalIndicatorImage"] = value; } }
        public Texture2D RightPortalIndicatorImage { get { return this[nameof(RightPortalIndicatorImage)].As<Texture2D>(); } set { this["RightPortalIndicatorImage"] = value; } }
        public Texture2D LeftPortalScrimImage { get { return this[nameof(LeftPortalScrimImage)].As<Texture2D>(); } set { this["LeftPortalScrimImage"] = value; } }
        public Texture2D RightPortalScrimImage { get { return this[nameof(RightPortalScrimImage)].As<Texture2D>(); } set { this["RightPortalScrimImage"] = value; } }
        public Texture2D GetScrimImage() { return Invoke<Texture2D>(nameof(GetScrimImage)); }
        public Texture2D GetIndicatorImage() { return Invoke<Texture2D>(nameof(GetIndicatorImage)); }
    }
    public class PortalWarsPostGameCardWidget : UserWidget
    {
        public PortalWarsPostGameCardWidget(ulong addr) : base(addr) { }
        public TextBlock ValueText { get { return this[nameof(ValueText)].As<TextBlock>(); } set { this["ValueText"] = value; } }
        public TextBlock TypeText { get { return this[nameof(TypeText)].As<TextBlock>(); } set { this["TypeText"] = value; } }
        public LinearColor DefaultTypeColor { get { return this[nameof(DefaultTypeColor)].As<LinearColor>(); } set { this["DefaultTypeColor"] = value; } }
        public LinearColor GoldTypeColor { get { return this[nameof(GoldTypeColor)].As<LinearColor>(); } set { this["GoldTypeColor"] = value; } }
        public TextBlock LifetimeAvgText { get { return this[nameof(LifetimeAvgText)].As<TextBlock>(); } set { this["LifetimeAvgText"] = value; } }
        public LinearColor DefaultLifetimeAvgColor { get { return this[nameof(DefaultLifetimeAvgColor)].As<LinearColor>(); } set { this["DefaultLifetimeAvgColor"] = value; } }
        public LinearColor IncreaseLifetimeAvgColor { get { return this[nameof(IncreaseLifetimeAvgColor)].As<LinearColor>(); } set { this["IncreaseLifetimeAvgColor"] = value; } }
        public LinearColor GoldLifetimeAvgColor { get { return this[nameof(GoldLifetimeAvgColor)].As<LinearColor>(); } set { this["GoldLifetimeAvgColor"] = value; } }
        public Image BackgroundImage { get { return this[nameof(BackgroundImage)].As<Image>(); } set { this["BackgroundImage"] = value; } }
        public Texture2D DefaultBackgroundImage { get { return this[nameof(DefaultBackgroundImage)].As<Texture2D>(); } set { this["DefaultBackgroundImage"] = value; } }
        public Texture2D IncreaseBackgroundImage { get { return this[nameof(IncreaseBackgroundImage)].As<Texture2D>(); } set { this["IncreaseBackgroundImage"] = value; } }
        public Texture2D GoldBackgroundImage { get { return this[nameof(GoldBackgroundImage)].As<Texture2D>(); } set { this["GoldBackgroundImage"] = value; } }
        public Image MedalImage { get { return this[nameof(MedalImage)].As<Image>(); } set { this["MedalImage"] = value; } }
        public Object MedalImages { get { return this[nameof(MedalImages)]; } set { this[nameof(MedalImages)] = value; } }
        public Image IncreaseIcon { get { return this[nameof(IncreaseIcon)].As<Image>(); } set { this["IncreaseIcon"] = value; } }
        public Texture2D DefaultIncreaseImage { get { return this[nameof(DefaultIncreaseImage)].As<Texture2D>(); } set { this["DefaultIncreaseImage"] = value; } }
        public Texture2D GoldIncreaseImage { get { return this[nameof(GoldIncreaseImage)].As<Texture2D>(); } set { this["GoldIncreaseImage"] = value; } }
        public Object OnFadeInAnimationCompleted { get { return this[nameof(OnFadeInAnimationCompleted)]; } set { this[nameof(OnFadeInAnimationCompleted)] = value; } }
        public Object OnSecondaryAnimationCompleted { get { return this[nameof(OnSecondaryAnimationCompleted)]; } set { this[nameof(OnSecondaryAnimationCompleted)] = value; } }
        public WidgetAnimation FadeInAnimation { get { return this[nameof(FadeInAnimation)].As<WidgetAnimation>(); } set { this["FadeInAnimation"] = value; } }
        public WidgetAnimation MedalAnimation { get { return this[nameof(MedalAnimation)].As<WidgetAnimation>(); } set { this["MedalAnimation"] = value; } }
        public WidgetAnimation IncreaseAnimation { get { return this[nameof(IncreaseAnimation)].As<WidgetAnimation>(); } set { this["IncreaseAnimation"] = value; } }
        public AkAudioEvent FadeInEvent { get { return this[nameof(FadeInEvent)].As<AkAudioEvent>(); } set { this["FadeInEvent"] = value; } }
        public AkAudioEvent IncreaseEvent { get { return this[nameof(IncreaseEvent)].As<AkAudioEvent>(); } set { this["IncreaseEvent"] = value; } }
        public Object MedalEvents { get { return this[nameof(MedalEvents)]; } set { this[nameof(MedalEvents)] = value; } }
        public Widget RootWidget { get { return this[nameof(RootWidget)].As<Widget>(); } set { this["RootWidget"] = value; } }
        public void PlaySecondaryAnimation() { Invoke(nameof(PlaySecondaryAnimation)); }
        public void PlayFadeInAnimation() { Invoke(nameof(PlayFadeInAnimation)); }
        public Object GetValueText() { return Invoke<Object>(nameof(GetValueText)); }
        public Object GetTypeText() { return Invoke<Object>(nameof(GetTypeText)); }
        public LinearColor GetTypeColor() { return Invoke<LinearColor>(nameof(GetTypeColor)); }
        public ESlateVisibility GetMedalVisibility() { return Invoke<ESlateVisibility>(nameof(GetMedalVisibility)); }
        public Texture2D GetMedalImage() { return Invoke<Texture2D>(nameof(GetMedalImage)); }
        public ESlateVisibility GetLifetimeAvgVisibility() { return Invoke<ESlateVisibility>(nameof(GetLifetimeAvgVisibility)); }
        public Object GetLifetimeAvgText() { return Invoke<Object>(nameof(GetLifetimeAvgText)); }
        public LinearColor GetLifetimeAvgColor() { return Invoke<LinearColor>(nameof(GetLifetimeAvgColor)); }
        public ESlateVisibility GetIncreaseIconVisibility() { return Invoke<ESlateVisibility>(nameof(GetIncreaseIconVisibility)); }
        public Texture2D GetIncreaseIcon() { return Invoke<Texture2D>(nameof(GetIncreaseIcon)); }
        public Texture2D GetBackgroundImage() { return Invoke<Texture2D>(nameof(GetBackgroundImage)); }
    }
    public class PortalWarsPostGameLobbyWidget : PortalWarsLobbyWidget
    {
        public PortalWarsPostGameLobbyWidget(ulong addr) : base(addr) { }
        public Widget PrevGameRoot { get { return this[nameof(PrevGameRoot)].As<Widget>(); } set { this["PrevGameRoot"] = value; } }
        public TextBlock MapNameText { get { return this[nameof(MapNameText)].As<TextBlock>(); } set { this["MapNameText"] = value; } }
        public TextBlock ModeNameText { get { return this[nameof(ModeNameText)].As<TextBlock>(); } set { this["ModeNameText"] = value; } }
        public WidgetSwitcher ScoreSwitcher { get { return this[nameof(ScoreSwitcher)].As<WidgetSwitcher>(); } set { this["ScoreSwitcher"] = value; } }
        public TextBlock AlphaScoreText { get { return this[nameof(AlphaScoreText)].As<TextBlock>(); } set { this["AlphaScoreText"] = value; } }
        public TextBlock BravoScoreText { get { return this[nameof(BravoScoreText)].As<TextBlock>(); } set { this["BravoScoreText"] = value; } }
        public TextBlock WinnerNameText { get { return this[nameof(WinnerNameText)].As<TextBlock>(); } set { this["WinnerNameText"] = value; } }
        public TextBlock WinnerScoreText { get { return this[nameof(WinnerScoreText)].As<TextBlock>(); } set { this["WinnerScoreText"] = value; } }
        public TextBlock TimerText { get { return this[nameof(TimerText)].As<TextBlock>(); } set { this["TimerText"] = value; } }
        public Widget TimerRoot { get { return this[nameof(TimerRoot)].As<Widget>(); } set { this["TimerRoot"] = value; } }
        public PortalWarsButtonWidget RequeueButton { get { return this[nameof(RequeueButton)].As<PortalWarsButtonWidget>(); } set { this["RequeueButton"] = value; } }
        public PortalWarsButtonWidget ReadyButton { get { return this[nameof(ReadyButton)].As<PortalWarsButtonWidget>(); } set { this["ReadyButton"] = value; } }
        public PortalWarsButtonWidget ItemShopButton { get { return this[nameof(ItemShopButton)].As<PortalWarsButtonWidget>(); } set { this["ItemShopButton"] = value; } }
        public TextBlock ActionText { get { return this[nameof(ActionText)].As<TextBlock>(); } set { this["ActionText"] = value; } }
        public WidgetSwitcher TimerSwitcher { get { return this[nameof(TimerSwitcher)].As<WidgetSwitcher>(); } set { this["TimerSwitcher"] = value; } }
        public void RefreshWidget() { Invoke(nameof(RefreshWidget)); }
        public void RefreshRequeueButton() { Invoke(nameof(RefreshRequeueButton)); }
        public void RefreshReadyButton() { Invoke(nameof(RefreshReadyButton)); }
        public void RefreshItemShopButton() { Invoke(nameof(RefreshItemShopButton)); }
        public void OnRequeueButtonClicked() { Invoke(nameof(OnRequeueButtonClicked)); }
        public void OnReadyButtonClicked() { Invoke(nameof(OnReadyButtonClicked)); }
        public void OnItemShopButtonClicked() { Invoke(nameof(OnItemShopButtonClicked)); }
        public void InitPrevGameInfo() { Invoke(nameof(InitPrevGameInfo)); }
        public void InitPlayerState() { Invoke(nameof(InitPlayerState)); }
        public Object GetWinnerScoreText() { return Invoke<Object>(nameof(GetWinnerScoreText)); }
        public Object GetWinnerNameText() { return Invoke<Object>(nameof(GetWinnerNameText)); }
        public ESlateVisibility GetTimerVisibility() { return Invoke<ESlateVisibility>(nameof(GetTimerVisibility)); }
        public Object GetTimerText() { return Invoke<Object>(nameof(GetTimerText)); }
        public bool GetRequeueButtonEnabled() { return Invoke<bool>(nameof(GetRequeueButtonEnabled)); }
        public bool GetReadyButtonEnabled() { return Invoke<bool>(nameof(GetReadyButtonEnabled)); }
        public Object GetModeNameText() { return Invoke<Object>(nameof(GetModeNameText)); }
        public Object GetMapNameText() { return Invoke<Object>(nameof(GetMapNameText)); }
        public bool GetItemShopButtonEnabled() { return Invoke<bool>(nameof(GetItemShopButtonEnabled)); }
        public Object GetBravoScoreText() { return Invoke<Object>(nameof(GetBravoScoreText)); }
        public Object GetAlphaScoreText() { return Invoke<Object>(nameof(GetAlphaScoreText)); }
    }
    public class PortalWarsPostGameMode : PortalWarsLobbyGameMode
    {
        public PortalWarsPostGameMode(ulong addr) : base(addr) { }
    }
    public class PortalWarsPostGameOverviewWidget : PortalWarsDialogWidget
    {
        public PortalWarsPostGameOverviewWidget(ulong addr) : base(addr) { }
        public PanelWidget CardPanel { get { return this[nameof(CardPanel)].As<PanelWidget>(); } set { this["CardPanel"] = value; } }
        public Object PostGameCardWidgetClass { get { return this[nameof(PostGameCardWidgetClass)]; } set { this[nameof(PostGameCardWidgetClass)] = value; } }
        public PortalWarsXPUpdateWidget XPUpdateWidget { get { return this[nameof(XPUpdateWidget)].As<PortalWarsXPUpdateWidget>(); } set { this["XPUpdateWidget"] = value; } }
        public PanelWidget XpBoostPanel { get { return this[nameof(XpBoostPanel)].As<PanelWidget>(); } set { this["XpBoostPanel"] = value; } }
        public Object XpBoostEntryWidgetClass { get { return this[nameof(XpBoostEntryWidgetClass)]; } set { this[nameof(XpBoostEntryWidgetClass)] = value; } }
        public void StartXpAnimation() { Invoke(nameof(StartXpAnimation)); }
        public void ProcessNextBoostAllocation() { Invoke(nameof(ProcessNextBoostAllocation)); }
        public void InitCards() { Invoke(nameof(InitCards)); }
    }
    public class PortalWarsPostGamePlayerEntry : PortalWarsUserWidget
    {
        public PortalWarsPostGamePlayerEntry(ulong addr) : base(addr) { }
        public TextBlock PlayerNameText { get { return this[nameof(PlayerNameText)].As<TextBlock>(); } set { this["PlayerNameText"] = value; } }
        public TextBlock PlayerScoreText { get { return this[nameof(PlayerScoreText)].As<TextBlock>(); } set { this["PlayerScoreText"] = value; } }
        public TextBlock PlayerKillsText { get { return this[nameof(PlayerKillsText)].As<TextBlock>(); } set { this["PlayerKillsText"] = value; } }
        public TextBlock PlayerDeathsText { get { return this[nameof(PlayerDeathsText)].As<TextBlock>(); } set { this["PlayerDeathsText"] = value; } }
        public TextBlock PlayerDamageDealtText { get { return this[nameof(PlayerDamageDealtText)].As<TextBlock>(); } set { this["PlayerDamageDealtText"] = value; } }
        public Border NameBorder { get { return this[nameof(NameBorder)].As<Border>(); } set { this["NameBorder"] = value; } }
        public LinearColor AlphaTeamColor { get { return this[nameof(AlphaTeamColor)].As<LinearColor>(); } set { this["AlphaTeamColor"] = value; } }
        public LinearColor BravoTeamColor { get { return this[nameof(BravoTeamColor)].As<LinearColor>(); } set { this["BravoTeamColor"] = value; } }
        public LinearColor NoTeamColor { get { return this[nameof(NoTeamColor)].As<LinearColor>(); } set { this["NoTeamColor"] = value; } }
        public Border StatBorder { get { return this[nameof(StatBorder)].As<Border>(); } set { this["StatBorder"] = value; } }
        public Object GetPlayerScore() { return Invoke<Object>(nameof(GetPlayerScore)); }
        public Object GetPlayerName() { return Invoke<Object>(nameof(GetPlayerName)); }
        public Object GetPlayerKills() { return Invoke<Object>(nameof(GetPlayerKills)); }
        public Object GetPlayerDeaths() { return Invoke<Object>(nameof(GetPlayerDeaths)); }
        public Object GetDamageDealt() { return Invoke<Object>(nameof(GetDamageDealt)); }
    }
    public class PortalWarsPostGameState : PortalWarsLobbyGameState
    {
        public PortalWarsPostGameState(ulong addr) : base(addr) { }
        public bool bIsContinuousLobby { get { return this[nameof(bIsContinuousLobby)].Flag; } set { this[nameof(bIsContinuousLobby)].Flag = value; } }
    }
    public class PortalWarsPostGameStatsWidget : PortalWarsDialogWidget
    {
        public PortalWarsPostGameStatsWidget(ulong addr) : base(addr) { }
        public PanelWidget PlayersPanel { get { return this[nameof(PlayersPanel)].As<PanelWidget>(); } set { this["PlayersPanel"] = value; } }
        public PanelWidget AlphaTeamPanel { get { return this[nameof(AlphaTeamPanel)].As<PanelWidget>(); } set { this["AlphaTeamPanel"] = value; } }
        public PanelWidget BravoTeamPanel { get { return this[nameof(BravoTeamPanel)].As<PanelWidget>(); } set { this["BravoTeamPanel"] = value; } }
        public TextBlock AlphaTeamScoreText { get { return this[nameof(AlphaTeamScoreText)].As<TextBlock>(); } set { this["AlphaTeamScoreText"] = value; } }
        public TextBlock BravoTeamScoreText { get { return this[nameof(BravoTeamScoreText)].As<TextBlock>(); } set { this["BravoTeamScoreText"] = value; } }
        public Widget TeamRoot { get { return this[nameof(TeamRoot)].As<Widget>(); } set { this["TeamRoot"] = value; } }
        public Widget FFARoot { get { return this[nameof(FFARoot)].As<Widget>(); } set { this["FFARoot"] = value; } }
        public Object PlayerEntryWidgetClass { get { return this[nameof(PlayerEntryWidgetClass)]; } set { this[nameof(PlayerEntryWidgetClass)] = value; } }
        public ESlateVisibility GetTeamVisibility() { return Invoke<ESlateVisibility>(nameof(GetTeamVisibility)); }
        public ESlateVisibility GetFFAVisibility() { return Invoke<ESlateVisibility>(nameof(GetFFAVisibility)); }
        public Object GetBravoTeamScoreText() { return Invoke<Object>(nameof(GetBravoTeamScoreText)); }
        public Object GetAlphaTeamScoreText() { return Invoke<Object>(nameof(GetAlphaTeamScoreText)); }
    }
    public class PortalWarsPostPlayerController : PortalWarsLobbyPlayerController
    {
        public PortalWarsPostPlayerController(ulong addr) : base(addr) { }
        public void ServerReadyForNextMatch(bool InIsReady) { Invoke(nameof(ServerReadyForNextMatch), InIsReady); }
        public void OnClientSessionStateChanged() { Invoke(nameof(OnClientSessionStateChanged)); }
        public void ClientRequeueMatchmaking() { Invoke(nameof(ClientRequeueMatchmaking)); }
        public void ClientNotifyContinueLobbyCompleted(bool bWasSuccessful, ErrorInfo ErrorInfo) { Invoke(nameof(ClientNotifyContinueLobbyCompleted), bWasSuccessful, ErrorInfo); }
    }
    public class PortalWarsPriceEntryWidget : UserWidget
    {
        public PortalWarsPriceEntryWidget(ulong addr) : base(addr) { }
        public TextBlock PriceText { get { return this[nameof(PriceText)].As<TextBlock>(); } set { this["PriceText"] = value; } }
        public Widget Strikethrough { get { return this[nameof(Strikethrough)].As<Widget>(); } set { this["Strikethrough"] = value; } }
        public Image PremiumImage { get { return this[nameof(PremiumImage)].As<Image>(); } set { this["PremiumImage"] = value; } }
        public Widget CurrencyIcon { get { return this[nameof(CurrencyIcon)].As<Widget>(); } set { this["CurrencyIcon"] = value; } }
        public Object PremiumImages { get { return this[nameof(PremiumImages)]; } set { this[nameof(PremiumImages)] = value; } }
    }
    public class PortalWarsPriceWidget : UserWidget
    {
        public PortalWarsPriceWidget(ulong addr) : base(addr) { }
        public PanelWidget PricePanel { get { return this[nameof(PricePanel)].As<PanelWidget>(); } set { this["PricePanel"] = value; } }
        public Object PriceEntryWidgetClass { get { return this[nameof(PriceEntryWidgetClass)]; } set { this[nameof(PriceEntryWidgetClass)] = value; } }
        public Widget DiscountRoot { get { return this[nameof(DiscountRoot)].As<Widget>(); } set { this["DiscountRoot"] = value; } }
        public RichTextBlock DiscountText { get { return this[nameof(DiscountText)].As<RichTextBlock>(); } set { this["DiscountText"] = value; } }
        public bool bShowDiscounts { get { return this[nameof(bShowDiscounts)].Flag; } set { this[nameof(bShowDiscounts)].Flag = value; } }
    }
    public class PortalWarsPrivacySettingsWidget : PortalWarsSettingsSubWidget
    {
        public PortalWarsPrivacySettingsWidget(ulong addr) : base(addr) { }
        public PortalWarsCheckBoxWidget CrossPlay { get { return this[nameof(CrossPlay)].As<PortalWarsCheckBoxWidget>(); } set { this["CrossPlay"] = value; } }
        public PortalWarsCheckBoxWidget AnonymousMode { get { return this[nameof(AnonymousMode)].As<PortalWarsCheckBoxWidget>(); } set { this["AnonymousMode"] = value; } }
        public PortalWarsCheckBoxWidget HideNames { get { return this[nameof(HideNames)].As<PortalWarsCheckBoxWidget>(); } set { this["HideNames"] = value; } }
        public PortalWarsCheckBoxWidget PartyChatOnly { get { return this[nameof(PartyChatOnly)].As<PortalWarsCheckBoxWidget>(); } set { this["PartyChatOnly"] = value; } }
        public void RefreshCrossplaySetting() { Invoke(nameof(RefreshCrossplaySetting)); }
        public void OnCrossplayValueChanged() { Invoke(nameof(OnCrossplayValueChanged)); }
    }
    public class PortalWarsProgressionIconWidget : UserWidget
    {
        public PortalWarsProgressionIconWidget(ulong addr) : base(addr) { }
        public Image IconImage { get { return this[nameof(IconImage)].As<Image>(); } set { this["IconImage"] = value; } }
        public TextBlock NumberText { get { return this[nameof(NumberText)].As<TextBlock>(); } set { this["NumberText"] = value; } }
    }
    public class PortalWarsProgressionUpdateDialogWidget : PortalWarsDialogWidget
    {
        public PortalWarsProgressionUpdateDialogWidget(ulong addr) : base(addr) { }
        public PortalWarsXPUpdateWidget XPUpdateWidget { get { return this[nameof(XPUpdateWidget)].As<PortalWarsXPUpdateWidget>(); } set { this["XPUpdateWidget"] = value; } }
    }
    public class PortalWarsProgressRadialWidget : UserWidget
    {
        public PortalWarsProgressRadialWidget(ulong addr) : base(addr) { }
        public Image ProgressImage { get { return this[nameof(ProgressImage)].As<Image>(); } set { this["ProgressImage"] = value; } }
        public float LineHardness { get { return this[nameof(LineHardness)].GetValue<float>(); } set { this[nameof(LineHardness)].SetValue<float>(value); } }
        public float LineWidth { get { return this[nameof(LineWidth)].GetValue<float>(); } set { this[nameof(LineWidth)].SetValue<float>(value); } }
        public float Radius { get { return this[nameof(Radius)].GetValue<float>(); } set { this[nameof(Radius)].SetValue<float>(value); } }
        public float Percent { get { return this[nameof(Percent)].GetValue<float>(); } set { this[nameof(Percent)].SetValue<float>(value); } }
        public void SetPercent(float InPercent) { Invoke(nameof(SetPercent), InPercent); }
        public float GetPercent() { return Invoke<float>(nameof(GetPercent)); }
    }
    public class PortalWarsQuitMenuWidget : PortalWarsMenuWidget
    {
        public PortalWarsQuitMenuWidget(ulong addr) : base(addr) { }
        public PortalWarsButtonWidget QuitButton { get { return this[nameof(QuitButton)].As<PortalWarsButtonWidget>(); } set { this["QuitButton"] = value; } }
        public Widget WarningRoot { get { return this[nameof(WarningRoot)].As<Widget>(); } set { this["WarningRoot"] = value; } }
        public PortalWarsCheckBoxWidget AcceptWarningCheckBox { get { return this[nameof(AcceptWarningCheckBox)].As<PortalWarsCheckBoxWidget>(); } set { this["AcceptWarningCheckBox"] = value; } }
        public PortalWarsButtonWidget AcceptWarningButton { get { return this[nameof(AcceptWarningButton)].As<PortalWarsButtonWidget>(); } set { this["AcceptWarningButton"] = value; } }
        public void OnQuitButtonClicked() { Invoke(nameof(OnQuitButtonClicked)); }
        public void OnAcceptWarningButtonClicked() { Invoke(nameof(OnAcceptWarningButtonClicked)); }
        public void OnAcceptCheckBoxValueChanged() { Invoke(nameof(OnAcceptCheckBoxValueChanged)); }
        public ESlateVisibility GetWarningMessageVisibility() { return Invoke<ESlateVisibility>(nameof(GetWarningMessageVisibility)); }
        public bool GetQuitButtonEnabled() { return Invoke<bool>(nameof(GetQuitButtonEnabled)); }
    }
    public class PortalWarsRaceCharacter : PortalWarsCharacter
    {
        public PortalWarsRaceCharacter(ulong addr) : base(addr) { }
    }
    public class PortalWarsRaceGameMode : PortalWarsGameMode
    {
        public PortalWarsRaceGameMode(ulong addr) : base(addr) { }
        public AkAudioEvent NewRecordEvent { get { return this[nameof(NewRecordEvent)].As<AkAudioEvent>(); } set { this["NewRecordEvent"] = value; } }
        public void InitRace() { Invoke(nameof(InitRace)); }
    }
    public class PortalWarsRaceGameState : PortalWarsGameState
    {
        public PortalWarsRaceGameState(ulong addr) : base(addr) { }
    }
    public class PortalWarsRaceGate : Actor
    {
        public PortalWarsRaceGate(ulong addr) : base(addr) { }
        public PortalWarsAkComponent AkComp { get { return this[nameof(AkComp)].As<PortalWarsAkComponent>(); } set { this["AkComp"] = value; } }
        public SceneComponent RootScene { get { return this[nameof(RootScene)].As<SceneComponent>(); } set { this["RootScene"] = value; } }
        public StaticMeshComponent GateMesh { get { return this[nameof(GateMesh)].As<StaticMeshComponent>(); } set { this["GateMesh"] = value; } }
        public SphereComponent SphereCollision { get { return this[nameof(SphereCollision)].As<SphereComponent>(); } set { this["SphereCollision"] = value; } }
        public ParticleSystemComponent ParticleSystem { get { return this[nameof(ParticleSystem)].As<ParticleSystemComponent>(); } set { this["ParticleSystem"] = value; } }
        public MaterialInterface CurrentGateMaterial { get { return this[nameof(CurrentGateMaterial)].As<MaterialInterface>(); } set { this["CurrentGateMaterial"] = value; } }
        public MaterialInterface CurrentGateSecondMaterial { get { return this[nameof(CurrentGateSecondMaterial)].As<MaterialInterface>(); } set { this["CurrentGateSecondMaterial"] = value; } }
        public MaterialInterface NextGateMaterial { get { return this[nameof(NextGateMaterial)].As<MaterialInterface>(); } set { this["NextGateMaterial"] = value; } }
        public MaterialInterface NextGateSecondMaterial { get { return this[nameof(NextGateSecondMaterial)].As<MaterialInterface>(); } set { this["NextGateSecondMaterial"] = value; } }
        public AkAudioEvent SuccessEvent { get { return this[nameof(SuccessEvent)].As<AkAudioEvent>(); } set { this["SuccessEvent"] = value; } }
        public AkAudioEvent PlayAmbientLoopEvent { get { return this[nameof(PlayAmbientLoopEvent)].As<AkAudioEvent>(); } set { this["PlayAmbientLoopEvent"] = value; } }
        public AkAudioEvent StopAmbientLoopEvent { get { return this[nameof(StopAmbientLoopEvent)].As<AkAudioEvent>(); } set { this["StopAmbientLoopEvent"] = value; } }
        public byte Order { get { return this[nameof(Order)].GetValue<byte>(); } set { this[nameof(Order)].SetValue<byte>(value); } }
        public void OnOverlap(PrimitiveComponent OverlappedComponent, Actor OtherActor, PrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, HitResult SweepResult) { Invoke(nameof(OnOverlap), OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult); }
    }
    public class PortalWarsRaceHUD : PortalWarsHUD
    {
        public PortalWarsRaceHUD(ulong addr) : base(addr) { }
        public PortalWarsRaceHUDOverlay RaceHUDOverlayWidget { get { return this[nameof(RaceHUDOverlayWidget)].As<PortalWarsRaceHUDOverlay>(); } set { this["RaceHUDOverlayWidget"] = value; } }
        public Object RaceHUDOverlayWidgetClass { get { return this[nameof(RaceHUDOverlayWidgetClass)]; } set { this[nameof(RaceHUDOverlayWidgetClass)] = value; } }
        public Object GateIndicatorWidgetClass { get { return this[nameof(GateIndicatorWidgetClass)]; } set { this[nameof(GateIndicatorWidgetClass)] = value; } }
    }
    public class PortalWarsRaceHUDOverlay : UserWidget
    {
        public PortalWarsRaceHUDOverlay(ulong addr) : base(addr) { }
        public RaceBookmarkWidget BookmarkWidget { get { return this[nameof(BookmarkWidget)].As<RaceBookmarkWidget>(); } set { this["BookmarkWidget"] = value; } }
        public TextBlock CurrentGateNumText { get { return this[nameof(CurrentGateNumText)].As<TextBlock>(); } set { this["CurrentGateNumText"] = value; } }
        public TextBlock MapNameText { get { return this[nameof(MapNameText)].As<TextBlock>(); } set { this["MapNameText"] = value; } }
        public TextBlock CurrentTimeText { get { return this[nameof(CurrentTimeText)].As<TextBlock>(); } set { this["CurrentTimeText"] = value; } }
        public TextBlock RecordHolderNameText { get { return this[nameof(RecordHolderNameText)].As<TextBlock>(); } set { this["RecordHolderNameText"] = value; } }
        public TextBlock RecordTimeText { get { return this[nameof(RecordTimeText)].As<TextBlock>(); } set { this["RecordTimeText"] = value; } }
        public Widget RaceRoot { get { return this[nameof(RaceRoot)].As<Widget>(); } set { this["RaceRoot"] = value; } }
        public void SetRecordHolderName(Object InName) { Invoke(nameof(SetRecordHolderName), InName); }
        public Object GetRecordTimeText() { return Invoke<Object>(nameof(GetRecordTimeText)); }
        public Object GetMapNameText() { return Invoke<Object>(nameof(GetMapNameText)); }
        public Object GetCurrentTimeText() { return Invoke<Object>(nameof(GetCurrentTimeText)); }
        public Object GetCurrentGateNumText() { return Invoke<Object>(nameof(GetCurrentGateNumText)); }
    }
    public class PortalWarsRaceLeaderboardEntry : PortalWarsLeaderboardEntryWidget
    {
        public PortalWarsRaceLeaderboardEntry(ulong addr) : base(addr) { }
        public TextBlock TimeText { get { return this[nameof(TimeText)].As<TextBlock>(); } set { this["TimeText"] = value; } }
        public Object GetTimeText() { return Invoke<Object>(nameof(GetTimeText)); }
    }
    public class PortalWarsRaceLeaderboardWidget : PortalWarsUserWidget
    {
        public PortalWarsRaceLeaderboardWidget(ulong addr) : base(addr) { }
        public Object LeaderboardEntryWidgetClass { get { return this[nameof(LeaderboardEntryWidgetClass)]; } set { this[nameof(LeaderboardEntryWidgetClass)] = value; } }
        public PanelWidget LeaderboardPanel { get { return this[nameof(LeaderboardPanel)].As<PanelWidget>(); } set { this["LeaderboardPanel"] = value; } }
        public TextBlock TypeText { get { return this[nameof(TypeText)].As<TextBlock>(); } set { this["TypeText"] = value; } }
        public ComboBoxString TypeComboBox { get { return this[nameof(TypeComboBox)].As<ComboBoxString>(); } set { this["TypeComboBox"] = value; } }
        public TextBlock MapNameText { get { return this[nameof(MapNameText)].As<TextBlock>(); } set { this["MapNameText"] = value; } }
        public UserWidget ParentWidget { get { return this[nameof(ParentWidget)].As<UserWidget>(); } set { this["ParentWidget"] = value; } }
        public void RefreshLeaderboard() { Invoke(nameof(RefreshLeaderboard)); }
        public void OnTypeSelectionChanged(Object SelectedItem, byte SelectionType) { Invoke(nameof(OnTypeSelectionChanged), SelectedItem, SelectionType); }
        public Object GetSelectedTypeText() { return Invoke<Object>(nameof(GetSelectedTypeText)); }
        public Object GetMapNameText() { return Invoke<Object>(nameof(GetMapNameText)); }
    }
    public class PortalWarsRaceLobbyGameMode : PortalWarsLobbyGameMode
    {
        public PortalWarsRaceLobbyGameMode(ulong addr) : base(addr) { }
        public Object RaceGameModeAlias { get { return this[nameof(RaceGameModeAlias)]; } set { this[nameof(RaceGameModeAlias)] = value; } }
    }
    public class PortalWarsRaceLobbyWidget : PortalWarsCustomLobbyWidget
    {
        public PortalWarsRaceLobbyWidget(ulong addr) : base(addr) { }
        public PortalWarsRaceLeaderboardWidget RaceLeaderboard { get { return this[nameof(RaceLeaderboard)].As<PortalWarsRaceLeaderboardWidget>(); } set { this["RaceLeaderboard"] = value; } }
        public PortalWarsButtonWidget SwitchLeaderboardButton { get { return this[nameof(SwitchLeaderboardButton)].As<PortalWarsButtonWidget>(); } set { this["SwitchLeaderboardButton"] = value; } }
        public PortalWarsButtonWidget ToggleCrossPlayButton { get { return this[nameof(ToggleCrossPlayButton)].As<PortalWarsButtonWidget>(); } set { this["ToggleCrossPlayButton"] = value; } }
        public void OnToggleCrossPlayButtonClicked() { Invoke(nameof(OnToggleCrossPlayButtonClicked)); }
        public void OnSwitchLeaderboardButtonClicked() { Invoke(nameof(OnSwitchLeaderboardButtonClicked)); }
        public void OnPrivacySettingsUpdated() { Invoke(nameof(OnPrivacySettingsUpdated)); }
    }
    public class PortalWarsRaceMatchResultWidget : PortalWarsMatchResultWidget
    {
        public PortalWarsRaceMatchResultWidget(ulong addr) : base(addr) { }
        public TextBlock FinalTimeText { get { return this[nameof(FinalTimeText)].As<TextBlock>(); } set { this["FinalTimeText"] = value; } }
        public TextBlock MapNameText { get { return this[nameof(MapNameText)].As<TextBlock>(); } set { this["MapNameText"] = value; } }
        public Object GetMapNameText() { return Invoke<Object>(nameof(GetMapNameText)); }
        public Object GetFinalTimeText() { return Invoke<Object>(nameof(GetFinalTimeText)); }
    }
    public class PortalWarsRacePlayerController : PortalWarsPlayerController
    {
        public PortalWarsRacePlayerController(ulong addr) : base(addr) { }
    }
    public class PortalWarsRacePlayerStart : PlayerStart
    {
        public PortalWarsRacePlayerStart(ulong addr) : base(addr) { }
    }
    public class PortalWarsScoreboardWidget : UserWidget
    {
        public PortalWarsScoreboardWidget(ulong addr) : base(addr) { }
        public TextBlock MapNameText { get { return this[nameof(MapNameText)].As<TextBlock>(); } set { this["MapNameText"] = value; } }
        public TextBlock GameModeText { get { return this[nameof(GameModeText)].As<TextBlock>(); } set { this["GameModeText"] = value; } }
        public TextBlock TimeRemainingText { get { return this[nameof(TimeRemainingText)].As<TextBlock>(); } set { this["TimeRemainingText"] = value; } }
        public TextBlock LeftNameText { get { return this[nameof(LeftNameText)].As<TextBlock>(); } set { this["LeftNameText"] = value; } }
        public TextBlock RightNameText { get { return this[nameof(RightNameText)].As<TextBlock>(); } set { this["RightNameText"] = value; } }
        public TextBlock LeftScoreText { get { return this[nameof(LeftScoreText)].As<TextBlock>(); } set { this["LeftScoreText"] = value; } }
        public TextBlock RightScoreText { get { return this[nameof(RightScoreText)].As<TextBlock>(); } set { this["RightScoreText"] = value; } }
        public Widget ScoreRoot { get { return this[nameof(ScoreRoot)].As<Widget>(); } set { this["ScoreRoot"] = value; } }
        public Widget TeamRoot { get { return this[nameof(TeamRoot)].As<Widget>(); } set { this["TeamRoot"] = value; } }
        public PanelWidget LeftTeamPanel { get { return this[nameof(LeftTeamPanel)].As<PanelWidget>(); } set { this["LeftTeamPanel"] = value; } }
        public PanelWidget RightTeamPanel { get { return this[nameof(RightTeamPanel)].As<PanelWidget>(); } set { this["RightTeamPanel"] = value; } }
        public Widget FFARoot { get { return this[nameof(FFARoot)].As<Widget>(); } set { this["FFARoot"] = value; } }
        public PanelWidget PlayersPanel { get { return this[nameof(PlayersPanel)].As<PanelWidget>(); } set { this["PlayersPanel"] = value; } }
        public Widget StatsRoot { get { return this[nameof(StatsRoot)].As<Widget>(); } set { this["StatsRoot"] = value; } }
        public PanelWidget StatsPanel { get { return this[nameof(StatsPanel)].As<PanelWidget>(); } set { this["StatsPanel"] = value; } }
        public Object ScoreboardStatWidgetClass { get { return this[nameof(ScoreboardStatWidgetClass)]; } set { this[nameof(ScoreboardStatWidgetClass)] = value; } }
        public Widget ScoreboardRoot { get { return this[nameof(ScoreboardRoot)].As<Widget>(); } set { this["ScoreboardRoot"] = value; } }
        public Object ScoreboardPlayerWidgetClass { get { return this[nameof(ScoreboardPlayerWidgetClass)]; } set { this[nameof(ScoreboardPlayerWidgetClass)] = value; } }
        public ESlateVisibility GetTeamVisibility() { return Invoke<ESlateVisibility>(nameof(GetTeamVisibility)); }
        public ESlateVisibility GetStatsVisibility() { return Invoke<ESlateVisibility>(nameof(GetStatsVisibility)); }
        public ESlateVisibility GetScoreVisibility() { return Invoke<ESlateVisibility>(nameof(GetScoreVisibility)); }
        public ESlateVisibility GetFFAVisibility() { return Invoke<ESlateVisibility>(nameof(GetFFAVisibility)); }
    }
    public class PortalWarsRaceScoreboardWidget : PortalWarsScoreboardWidget
    {
        public PortalWarsRaceScoreboardWidget(ulong addr) : base(addr) { }
        public TextBlock PlayerNameText { get { return this[nameof(PlayerNameText)].As<TextBlock>(); } set { this["PlayerNameText"] = value; } }
        public TextBlock CurrentTimeText { get { return this[nameof(CurrentTimeText)].As<TextBlock>(); } set { this["CurrentTimeText"] = value; } }
        public TextBlock RecordHolderNameText { get { return this[nameof(RecordHolderNameText)].As<TextBlock>(); } set { this["RecordHolderNameText"] = value; } }
        public TextBlock RecordTimeText { get { return this[nameof(RecordTimeText)].As<TextBlock>(); } set { this["RecordTimeText"] = value; } }
        public void SetRecordHolderName(Object InName) { Invoke(nameof(SetRecordHolderName), InName); }
        public Object GetRecordTimeText() { return Invoke<Object>(nameof(GetRecordTimeText)); }
        public Object GetCurrentTimeText() { return Invoke<Object>(nameof(GetCurrentTimeText)); }
    }
    public class PortalWarsRadarMarkerWidget : PortalWarsIndicatorWidget
    {
        public PortalWarsRadarMarkerWidget(ulong addr) : base(addr) { }
        public WidgetSwitcher MarkerSwitcher { get { return this[nameof(MarkerSwitcher)].As<WidgetSwitcher>(); } set { this["MarkerSwitcher"] = value; } }
        public float ZOffsetTrigger { get { return this[nameof(ZOffsetTrigger)].GetValue<float>(); } set { this[nameof(ZOffsetTrigger)].SetValue<float>(value); } }
        public Image AboveImage { get { return this[nameof(AboveImage)].As<Image>(); } set { this["AboveImage"] = value; } }
        public Image BelowImage { get { return this[nameof(BelowImage)].As<Image>(); } set { this["BelowImage"] = value; } }
        public void InitPlayerInfo() { Invoke(nameof(InitPlayerInfo)); }
    }
    public class PortalWarsRadarWidget : UserWidget
    {
        public PortalWarsRadarWidget(ulong addr) : base(addr) { }
        public Object RadarMarkerWidgetClass { get { return this[nameof(RadarMarkerWidgetClass)]; } set { this[nameof(RadarMarkerWidgetClass)] = value; } }
        public float RadarRadius { get { return this[nameof(RadarRadius)].GetValue<float>(); } set { this[nameof(RadarRadius)].SetValue<float>(value); } }
        public CanvasPanel RadarPanel { get { return this[nameof(RadarPanel)].As<CanvasPanel>(); } set { this["RadarPanel"] = value; } }
        public WidgetSwitcher Quadrant1Switcher { get { return this[nameof(Quadrant1Switcher)].As<WidgetSwitcher>(); } set { this["Quadrant1Switcher"] = value; } }
        public WidgetSwitcher Quadrant2Switcher { get { return this[nameof(Quadrant2Switcher)].As<WidgetSwitcher>(); } set { this["Quadrant2Switcher"] = value; } }
        public WidgetSwitcher Quadrant3Switcher { get { return this[nameof(Quadrant3Switcher)].As<WidgetSwitcher>(); } set { this["Quadrant3Switcher"] = value; } }
        public WidgetSwitcher Quadrant4Switcher { get { return this[nameof(Quadrant4Switcher)].As<WidgetSwitcher>(); } set { this["Quadrant4Switcher"] = value; } }
    }
    public class PortalWarsRadioGroupWidget : PortalWarsInputWidget
    {
        public PortalWarsRadioGroupWidget(ulong addr) : base(addr) { }
        public Array<Object> DefaultOptions { get { return new Array<Object>(this[nameof(DefaultOptions)].Address); } }
        public int DefaultIndex { get { return this[nameof(DefaultIndex)].GetValue<int>(); } set { this[nameof(DefaultIndex)].SetValue<int>(value); } }
        public PanelWidget RadioGroupPanel { get { return this[nameof(RadioGroupPanel)].As<PanelWidget>(); } set { this["RadioGroupPanel"] = value; } }
        public Object RadioButtonWidgetClass { get { return this[nameof(RadioButtonWidgetClass)]; } set { this[nameof(RadioButtonWidgetClass)] = value; } }
        public void OnEntrySelected(PortalWarsEntryWidget Entry) { Invoke(nameof(OnEntrySelected), Entry); }
    }
    public class PortalWarsRange : PortalWarsGameMode
    {
        public PortalWarsRange(ulong addr) : base(addr) { }
    }
    public class PortalWarsRangeGameState : PortalWarsGameState
    {
        public PortalWarsRangeGameState(ulong addr) : base(addr) { }
    }
    public class PortalWarsRangeHUD : PortalWarsHUD
    {
        public PortalWarsRangeHUD(ulong addr) : base(addr) { }
    }
    public class PortalWarsRankLeaderboardEntry : PortalWarsLeaderboardEntryWidget
    {
        public PortalWarsRankLeaderboardEntry(ulong addr) : base(addr) { }
        public TextBlock RankXPText { get { return this[nameof(RankXPText)].As<TextBlock>(); } set { this["RankXPText"] = value; } }
    }
    public class PortalWarsRankLeaderboardWidget : PortalWarsMenuWidget
    {
        public PortalWarsRankLeaderboardWidget(ulong addr) : base(addr) { }
        public TextBlock PlaylistText { get { return this[nameof(PlaylistText)].As<TextBlock>(); } set { this["PlaylistText"] = value; } }
        public PortalWarsButtonWidget ChangePlaylistButton { get { return this[nameof(ChangePlaylistButton)].As<PortalWarsButtonWidget>(); } set { this["ChangePlaylistButton"] = value; } }
        public PortalWarsButtonWidget ToggleCrossPlayButton { get { return this[nameof(ToggleCrossPlayButton)].As<PortalWarsButtonWidget>(); } set { this["ToggleCrossPlayButton"] = value; } }
        public ComboBoxString PlaylistComboBox { get { return this[nameof(PlaylistComboBox)].As<ComboBoxString>(); } set { this["PlaylistComboBox"] = value; } }
        public Array<int> PlaylistIDs { get { return new Array<int>(this[nameof(PlaylistIDs)].Address); } }
        public Object LeaderboardEntryWidgetClass { get { return this[nameof(LeaderboardEntryWidgetClass)]; } set { this[nameof(LeaderboardEntryWidgetClass)] = value; } }
        public PanelWidget LeaderboardPanel { get { return this[nameof(LeaderboardPanel)].As<PanelWidget>(); } set { this["LeaderboardPanel"] = value; } }
        public void RefreshLeaderboard() { Invoke(nameof(RefreshLeaderboard)); }
        public void OnToggleCrossPlayClicked() { Invoke(nameof(OnToggleCrossPlayClicked)); }
        public void OnPrivacySettingsUpdated() { Invoke(nameof(OnPrivacySettingsUpdated)); }
        public void OnPlaylistSelectionChanged(Object SelectedItem, byte SelectionType) { Invoke(nameof(OnPlaylistSelectionChanged), SelectedItem, SelectionType); }
        public void OnChangePlaylistClicked() { Invoke(nameof(OnChangePlaylistClicked)); }
        public Object GetSelectedPlaylistText() { return Invoke<Object>(nameof(GetSelectedPlaylistText)); }
    }
    public class PortalWarsRankListEntryWidget : UserWidget
    {
        public PortalWarsRankListEntryWidget(ulong addr) : base(addr) { }
        public TextBlock RankNameText { get { return this[nameof(RankNameText)].As<TextBlock>(); } set { this["RankNameText"] = value; } }
        public TextBlock RankXPText { get { return this[nameof(RankXPText)].As<TextBlock>(); } set { this["RankXPText"] = value; } }
        public Image RankIcon { get { return this[nameof(RankIcon)].As<Image>(); } set { this["RankIcon"] = value; } }
        public Object GetRankXPText() { return Invoke<Object>(nameof(GetRankXPText)); }
        public Object GetRankNameText() { return Invoke<Object>(nameof(GetRankNameText)); }
    }
    public class PortalWarsRankListWidget : UserWidget
    {
        public PortalWarsRankListWidget(ulong addr) : base(addr) { }
        public Object RankEntryWidget { get { return this[nameof(RankEntryWidget)]; } set { this[nameof(RankEntryWidget)] = value; } }
        public VerticalBox ItemsPanel { get { return this[nameof(ItemsPanel)].As<VerticalBox>(); } set { this["ItemsPanel"] = value; } }
    }
    public class PortalWarsRankUpdateWidget : PortalWarsDialogWidget
    {
        public PortalWarsRankUpdateWidget(ulong addr) : base(addr) { }
        public WidgetAnimation RankUpAnimation { get { return this[nameof(RankUpAnimation)].As<WidgetAnimation>(); } set { this["RankUpAnimation"] = value; } }
        public WidgetAnimation RankDownAnimation { get { return this[nameof(RankDownAnimation)].As<WidgetAnimation>(); } set { this["RankDownAnimation"] = value; } }
        public WidgetAnimation RankSameAnimation { get { return this[nameof(RankSameAnimation)].As<WidgetAnimation>(); } set { this["RankSameAnimation"] = value; } }
        public Image PrevRankIcon { get { return this[nameof(PrevRankIcon)].As<Image>(); } set { this["PrevRankIcon"] = value; } }
        public Image NewRankIcon { get { return this[nameof(NewRankIcon)].As<Image>(); } set { this["NewRankIcon"] = value; } }
        public TextBlock RankNameText { get { return this[nameof(RankNameText)].As<TextBlock>(); } set { this["RankNameText"] = value; } }
        public TextBlock RankXPText { get { return this[nameof(RankXPText)].As<TextBlock>(); } set { this["RankXPText"] = value; } }
        public WidgetSwitcher IndicatorSwitcher { get { return this[nameof(IndicatorSwitcher)].As<WidgetSwitcher>(); } set { this["IndicatorSwitcher"] = value; } }
        public AkAudioEvent RankUpEvent { get { return this[nameof(RankUpEvent)].As<AkAudioEvent>(); } set { this["RankUpEvent"] = value; } }
        public AkAudioEvent RankDownEvent { get { return this[nameof(RankDownEvent)].As<AkAudioEvent>(); } set { this["RankDownEvent"] = value; } }
        public void PlayRankUpSound() { Invoke(nameof(PlayRankUpSound)); }
        public void PlayRankDownSound() { Invoke(nameof(PlayRankDownSound)); }
        public Object GetRankXPText() { return Invoke<Object>(nameof(GetRankXPText)); }
        public Object GetRankNameText() { return Invoke<Object>(nameof(GetRankNameText)); }
    }
    public class PortalWarsRecentPlayersWidget : PortalWarsMenuWidget
    {
        public PortalWarsRecentPlayersWidget(ulong addr) : base(addr) { }
        public PortalWarsButtonWidget RefreshButton { get { return this[nameof(RefreshButton)].As<PortalWarsButtonWidget>(); } set { this["RefreshButton"] = value; } }
        public PanelWidget RecentPlayersPanel { get { return this[nameof(RecentPlayersPanel)].As<PanelWidget>(); } set { this["RecentPlayersPanel"] = value; } }
        public Object PlayerEntryWidgetClass { get { return this[nameof(PlayerEntryWidgetClass)]; } set { this[nameof(PlayerEntryWidgetClass)] = value; } }
        public Object PlayerActionsWidgetClass { get { return this[nameof(PlayerActionsWidgetClass)]; } set { this[nameof(PlayerActionsWidgetClass)] = value; } }
        public TextBlock ErrorText { get { return this[nameof(ErrorText)].As<TextBlock>(); } set { this["ErrorText"] = value; } }
        public void RefreshPlayersList() { Invoke(nameof(RefreshPlayersList)); }
        public void OnPlayerEntrySelected(PortalWarsEntryWidget Entry) { Invoke(nameof(OnPlayerEntrySelected), Entry); }
        public bool GetRefreshButtonEnabled() { return Invoke<bool>(nameof(GetRefreshButtonEnabled)); }
        public void DelayedRefreshPlayersList() { Invoke(nameof(DelayedRefreshPlayersList)); }
    }
    public class PortalWarsRedeemKeyDialogWidget : PortalWarsTxnDialogWidget
    {
        public PortalWarsRedeemKeyDialogWidget(ulong addr) : base(addr) { }
        public EditableTextBox KeyInput { get { return this[nameof(KeyInput)].As<EditableTextBox>(); } set { this["KeyInput"] = value; } }
        public void OnKeyInputChanged(Object newText) { Invoke(nameof(OnKeyInputChanged), newText); }
    }
    public class PortalWarsReferFriendDialog : PortalWarsTxnDialogWidget
    {
        public PortalWarsReferFriendDialog(ulong addr) : base(addr) { }
    }
    public class PortalWarsReferFriendWidget : PortalWarsMenuWidget
    {
        public PortalWarsReferFriendWidget(ulong addr) : base(addr) { }
        public TextBlock ReferralCodeText { get { return this[nameof(ReferralCodeText)].As<TextBlock>(); } set { this["ReferralCodeText"] = value; } }
        public TextBlock ReferralScoreText { get { return this[nameof(ReferralScoreText)].As<TextBlock>(); } set { this["ReferralScoreText"] = value; } }
        public RichTextBlock NextReferralText { get { return this[nameof(NextReferralText)].As<RichTextBlock>(); } set { this["NextReferralText"] = value; } }
        public PortalWarsButtonWidget ReferralPassButton { get { return this[nameof(ReferralPassButton)].As<PortalWarsButtonWidget>(); } set { this["ReferralPassButton"] = value; } }
        public EditableTextBox ReferralCodeInput { get { return this[nameof(ReferralCodeInput)].As<EditableTextBox>(); } set { this["ReferralCodeInput"] = value; } }
        public PortalWarsRewardEntryWidget NextRewardPreview { get { return this[nameof(NextRewardPreview)].As<PortalWarsRewardEntryWidget>(); } set { this["NextRewardPreview"] = value; } }
        public PortalWarsButtonWidget CopyButton { get { return this[nameof(CopyButton)].As<PortalWarsButtonWidget>(); } set { this["CopyButton"] = value; } }
        public PortalWarsButtonWidget ConfirmButton { get { return this[nameof(ConfirmButton)].As<PortalWarsButtonWidget>(); } set { this["ConfirmButton"] = value; } }
        public WidgetSwitcher BottomWidgetSwitcher { get { return this[nameof(BottomWidgetSwitcher)].As<WidgetSwitcher>(); } set { this["BottomWidgetSwitcher"] = value; } }
        public TextBlock CodeAcceptedText { get { return this[nameof(CodeAcceptedText)].As<TextBlock>(); } set { this["CodeAcceptedText"] = value; } }
        public WidgetSwitcher ReferWidgetSwitcher { get { return this[nameof(ReferWidgetSwitcher)].As<WidgetSwitcher>(); } set { this["ReferWidgetSwitcher"] = value; } }
        public RichTextBlock NoteRichText { get { return this[nameof(NoteRichText)].As<RichTextBlock>(); } set { this["NoteRichText"] = value; } }
        public Object SubmitDialogWidgetClass { get { return this[nameof(SubmitDialogWidgetClass)]; } set { this[nameof(SubmitDialogWidgetClass)] = value; } }
        public void OnReferralPassButtonClicked() { Invoke(nameof(OnReferralPassButtonClicked)); }
        public void OnReferralCodeTextChanged(Object newText) { Invoke(nameof(OnReferralCodeTextChanged), newText); }
        public void OnReferFriendUpdate() { Invoke(nameof(OnReferFriendUpdate)); }
        public void OnCopyButtonClicked() { Invoke(nameof(OnCopyButtonClicked)); }
        public void OnConfirmButtonClicked() { Invoke(nameof(OnConfirmButtonClicked)); }
    }
    public class PortalWarsReferralPassEntryWidget : PortalWarsRewardPassEntryWidget
    {
        public PortalWarsReferralPassEntryWidget(ulong addr) : base(addr) { }
    }
    public class PortalWarsReferralPassWidget : PortalWarsRewardPassWidget
    {
        public PortalWarsReferralPassWidget(ulong addr) : base(addr) { }
        public RichTextBlock NextRewardRichText { get { return this[nameof(NextRewardRichText)].As<RichTextBlock>(); } set { this["NextRewardRichText"] = value; } }
    }
    public class PortalWarsRenameReplayDialogWidget : PortalWarsTxnDialogWidget
    {
        public PortalWarsRenameReplayDialogWidget(ulong addr) : base(addr) { }
        public PortalWarsTextInputWidget NameInput { get { return this[nameof(NameInput)].As<PortalWarsTextInputWidget>(); } set { this["NameInput"] = value; } }
        public void OnNameValueChanged() { Invoke(nameof(OnNameValueChanged)); }
    }
    public class PortalWarsReplayEntryWidget : PortalWarsEntryWidget
    {
        public PortalWarsReplayEntryWidget(ulong addr) : base(addr) { }
        public TextBlock NameText { get { return this[nameof(NameText)].As<TextBlock>(); } set { this["NameText"] = value; } }
        public TextBlock DateText { get { return this[nameof(DateText)].As<TextBlock>(); } set { this["DateText"] = value; } }
        public TextBlock LengthText { get { return this[nameof(LengthText)].As<TextBlock>(); } set { this["LengthText"] = value; } }
        public TextBlock MapText { get { return this[nameof(MapText)].As<TextBlock>(); } set { this["MapText"] = value; } }
        public TextBlock ModeText { get { return this[nameof(ModeText)].As<TextBlock>(); } set { this["ModeText"] = value; } }
        public Image MapImage { get { return this[nameof(MapImage)].As<Image>(); } set { this["MapImage"] = value; } }
        public TextBlock ScoreText { get { return this[nameof(ScoreText)].As<TextBlock>(); } set { this["ScoreText"] = value; } }
        public TextBlock KillsText { get { return this[nameof(KillsText)].As<TextBlock>(); } set { this["KillsText"] = value; } }
        public TextBlock DeathsText { get { return this[nameof(DeathsText)].As<TextBlock>(); } set { this["DeathsText"] = value; } }
        public LinearColor WinScoreColor { get { return this[nameof(WinScoreColor)].As<LinearColor>(); } set { this["WinScoreColor"] = value; } }
        public LinearColor LossScoreColor { get { return this[nameof(LossScoreColor)].As<LinearColor>(); } set { this["LossScoreColor"] = value; } }
        public LinearColor TieScoreColor { get { return this[nameof(TieScoreColor)].As<LinearColor>(); } set { this["TieScoreColor"] = value; } }
        public WidgetSwitcher BackgroundSwitcher { get { return this[nameof(BackgroundSwitcher)].As<WidgetSwitcher>(); } set { this["BackgroundSwitcher"] = value; } }
        public PortalWarsReplaysWidget ParentWidget { get { return this[nameof(ParentWidget)].As<PortalWarsReplaysWidget>(); } set { this["ParentWidget"] = value; } }
        public Object GetReplayLengthText() { return Invoke<Object>(nameof(GetReplayLengthText)); }
        public Object GetReplayDateText() { return Invoke<Object>(nameof(GetReplayDateText)); }
    }
    public class PortalWarsReplayHUDOverlayWidget : PortalWarsUserWidget
    {
        public PortalWarsReplayHUDOverlayWidget(ulong addr) : base(addr) { }
        public PanelWidget LeftPlayerPanel { get { return this[nameof(LeftPlayerPanel)].As<PanelWidget>(); } set { this["LeftPlayerPanel"] = value; } }
        public PanelWidget RightPlayerPanel { get { return this[nameof(RightPlayerPanel)].As<PanelWidget>(); } set { this["RightPlayerPanel"] = value; } }
        public Object LeftPlayerWidgetClass { get { return this[nameof(LeftPlayerWidgetClass)]; } set { this[nameof(LeftPlayerWidgetClass)] = value; } }
        public Object RightPlayerWidgetClass { get { return this[nameof(RightPlayerWidgetClass)]; } set { this[nameof(RightPlayerWidgetClass)] = value; } }
        public Image TeamIndicator { get { return this[nameof(TeamIndicator)].As<Image>(); } set { this["TeamIndicator"] = value; } }
        public Widget CameraModeRoot { get { return this[nameof(CameraModeRoot)].As<Widget>(); } set { this["CameraModeRoot"] = value; } }
        public TextBlock CameraModeText { get { return this[nameof(CameraModeText)].As<TextBlock>(); } set { this["CameraModeText"] = value; } }
        public PortalWarsButtonWidget CameraModeButton { get { return this[nameof(CameraModeButton)].As<PortalWarsButtonWidget>(); } set { this["CameraModeButton"] = value; } }
        public ComboBoxString CameraModeComboBox { get { return this[nameof(CameraModeComboBox)].As<ComboBoxString>(); } set { this["CameraModeComboBox"] = value; } }
        public Widget PlayRateRoot { get { return this[nameof(PlayRateRoot)].As<Widget>(); } set { this["PlayRateRoot"] = value; } }
        public TextBlock PlayRateText { get { return this[nameof(PlayRateText)].As<TextBlock>(); } set { this["PlayRateText"] = value; } }
        public PortalWarsButtonWidget PlayRateIncreaseButton { get { return this[nameof(PlayRateIncreaseButton)].As<PortalWarsButtonWidget>(); } set { this["PlayRateIncreaseButton"] = value; } }
        public PortalWarsButtonWidget PlayRateDecreaseButton { get { return this[nameof(PlayRateDecreaseButton)].As<PortalWarsButtonWidget>(); } set { this["PlayRateDecreaseButton"] = value; } }
        public ComboBoxString PlayRateComboBox { get { return this[nameof(PlayRateComboBox)].As<ComboBoxString>(); } set { this["PlayRateComboBox"] = value; } }
        public TextBlock CurrentTimeText { get { return this[nameof(CurrentTimeText)].As<TextBlock>(); } set { this["CurrentTimeText"] = value; } }
        public TextBlock TotalTimeText { get { return this[nameof(TotalTimeText)].As<TextBlock>(); } set { this["TotalTimeText"] = value; } }
        public Slider TimeSlider { get { return this[nameof(TimeSlider)].As<Slider>(); } set { this["TimeSlider"] = value; } }
        public ProgressBar TimeProgressBar { get { return this[nameof(TimeProgressBar)].As<ProgressBar>(); } set { this["TimeProgressBar"] = value; } }
        public PortalWarsButtonWidget PlayButton { get { return this[nameof(PlayButton)].As<PortalWarsButtonWidget>(); } set { this["PlayButton"] = value; } }
        public PortalWarsButtonWidget JumpBackButton { get { return this[nameof(JumpBackButton)].As<PortalWarsButtonWidget>(); } set { this["JumpBackButton"] = value; } }
        public PortalWarsButtonWidget JumpForwardButton { get { return this[nameof(JumpForwardButton)].As<PortalWarsButtonWidget>(); } set { this["JumpForwardButton"] = value; } }
        public PortalWarsButtonWidget PlayOneFrameButton { get { return this[nameof(PlayOneFrameButton)].As<PortalWarsButtonWidget>(); } set { this["PlayOneFrameButton"] = value; } }
        public UserWidget LoadingScreen { get { return this[nameof(LoadingScreen)].As<UserWidget>(); } set { this["LoadingScreen"] = value; } }
        public Widget ReplayRoot { get { return this[nameof(ReplayRoot)].As<Widget>(); } set { this["ReplayRoot"] = value; } }
        public void ToggleReplayPausedState() { Invoke(nameof(ToggleReplayPausedState)); }
        public void RefreshPlayButton_BP(bool bIsPlaying) { Invoke(nameof(RefreshPlayButton_BP), bIsPlaying); }
        public void PlayOneFrame() { Invoke(nameof(PlayOneFrame)); }
        public void OnTimeValueChanged(float InValue) { Invoke(nameof(OnTimeValueChanged), InValue); }
        public void OnTimeMouseCaptureEnd() { Invoke(nameof(OnTimeMouseCaptureEnd)); }
        public void OnTimeMouseCaptureBegin() { Invoke(nameof(OnTimeMouseCaptureBegin)); }
        public void OnReplayCameraModeChanged(EReplayCameraMode NewReplayCameraMode) { Invoke(nameof(OnReplayCameraModeChanged), NewReplayCameraMode); }
        public void OnPlayRateSelectionChanged(Object SelectedItem, byte SelectionType) { Invoke(nameof(OnPlayRateSelectionChanged), SelectedItem, SelectionType); }
        public void OnPlayerListChanged(Array<PlayerState> NewPlayerList) { Invoke(nameof(OnPlayerListChanged), NewPlayerList); }
        public void OnFocusedPlayerChanged(PlayerState NewFocusedPlayer) { Invoke(nameof(OnFocusedPlayerChanged), NewFocusedPlayer); }
        public void OnCameraModeSelectionChanged(Object SelectedItem, byte SelectionType) { Invoke(nameof(OnCameraModeSelectionChanged), SelectedItem, SelectionType); }
        public void JumpForward() { Invoke(nameof(JumpForward)); }
        public void JumpBack() { Invoke(nameof(JumpBack)); }
        public void IncreasePlayRate() { Invoke(nameof(IncreasePlayRate)); }
        public void GoToNextCameraMode() { Invoke(nameof(GoToNextCameraMode)); }
        public void DecreasePlayRate() { Invoke(nameof(DecreasePlayRate)); }
    }
    public class PortalWarsScoreboardPlayerWidget : PortalWarsUserWidget
    {
        public PortalWarsScoreboardPlayerWidget(ulong addr) : base(addr) { }
        public Image BackgroundImage { get { return this[nameof(BackgroundImage)].As<Image>(); } set { this["BackgroundImage"] = value; } }
        public Texture2D BlueBackgroundImage { get { return this[nameof(BlueBackgroundImage)].As<Texture2D>(); } set { this["BlueBackgroundImage"] = value; } }
        public Texture2D RedBackgroundImage { get { return this[nameof(RedBackgroundImage)].As<Texture2D>(); } set { this["RedBackgroundImage"] = value; } }
        public Texture2D SelfBackgroundImage { get { return this[nameof(SelfBackgroundImage)].As<Texture2D>(); } set { this["SelfBackgroundImage"] = value; } }
        public Image ArmorCustomizationImage { get { return this[nameof(ArmorCustomizationImage)].As<Image>(); } set { this["ArmorCustomizationImage"] = value; } }
        public TextBlock ScoreText { get { return this[nameof(ScoreText)].As<TextBlock>(); } set { this["ScoreText"] = value; } }
        public TextBlock KillsText { get { return this[nameof(KillsText)].As<TextBlock>(); } set { this["KillsText"] = value; } }
        public TextBlock DeathsText { get { return this[nameof(DeathsText)].As<TextBlock>(); } set { this["DeathsText"] = value; } }
        public TextBlock DamageText { get { return this[nameof(DamageText)].As<TextBlock>(); } set { this["DamageText"] = value; } }
        public Widget StatsRoot { get { return this[nameof(StatsRoot)].As<Widget>(); } set { this["StatsRoot"] = value; } }
        public Image PrimaryWeaponImage { get { return this[nameof(PrimaryWeaponImage)].As<Image>(); } set { this["PrimaryWeaponImage"] = value; } }
        public Image SecondaryWeaponImage { get { return this[nameof(SecondaryWeaponImage)].As<Image>(); } set { this["SecondaryWeaponImage"] = value; } }
        public Widget InventoryPanel { get { return this[nameof(InventoryPanel)].As<Widget>(); } set { this["InventoryPanel"] = value; } }
        public SizeBox PrimaryWeaponImageSizeBox { get { return this[nameof(PrimaryWeaponImageSizeBox)].As<SizeBox>(); } set { this["PrimaryWeaponImageSizeBox"] = value; } }
        public SizeBox SecondaryWeaponImageSizeBox { get { return this[nameof(SecondaryWeaponImageSizeBox)].As<SizeBox>(); } set { this["SecondaryWeaponImageSizeBox"] = value; } }
        public TextBlock RespawnTimeText { get { return this[nameof(RespawnTimeText)].As<TextBlock>(); } set { this["RespawnTimeText"] = value; } }
        public Widget DeathRoot { get { return this[nameof(DeathRoot)].As<Widget>(); } set { this["DeathRoot"] = value; } }
        public Widget PlayerRoot { get { return this[nameof(PlayerRoot)].As<Widget>(); } set { this["PlayerRoot"] = value; } }
        public PortalWarsPlayerEntryWidget PlayerEntry { get { return this[nameof(PlayerEntry)].As<PortalWarsPlayerEntryWidget>(); } set { this["PlayerEntry"] = value; } }
        public Texture2D GetSecondaryWeaponImage() { return Invoke<Texture2D>(nameof(GetSecondaryWeaponImage)); }
        public Object GetRespawnTimeText() { return Invoke<Object>(nameof(GetRespawnTimeText)); }
        public Texture2D GetPrimaryWeaponImage() { return Invoke<Texture2D>(nameof(GetPrimaryWeaponImage)); }
        public Object GetPlayerScoreText() { return Invoke<Object>(nameof(GetPlayerScoreText)); }
        public Object GetPlayerKillsText() { return Invoke<Object>(nameof(GetPlayerKillsText)); }
        public Object GetPlayerDeathsText() { return Invoke<Object>(nameof(GetPlayerDeathsText)); }
        public Object GetPlayerDamageText() { return Invoke<Object>(nameof(GetPlayerDamageText)); }
        public ESlateVisibility GetInventoryVisibility() { return Invoke<ESlateVisibility>(nameof(GetInventoryVisibility)); }
        public ESlateVisibility GetDeathVisibility() { return Invoke<ESlateVisibility>(nameof(GetDeathVisibility)); }
        public Texture2D GetBackgroundImage() { return Invoke<Texture2D>(nameof(GetBackgroundImage)); }
        public Object GetArmorCustomizationThumbnail() { return Invoke<Object>(nameof(GetArmorCustomizationThumbnail)); }
    }
    public class PortalWarsReplayPlayerWidget : PortalWarsScoreboardPlayerWidget
    {
        public PortalWarsReplayPlayerWidget(ulong addr) : base(addr) { }
        public Texture2D BlueSelectedBackgroundImage { get { return this[nameof(BlueSelectedBackgroundImage)].As<Texture2D>(); } set { this["BlueSelectedBackgroundImage"] = value; } }
        public Texture2D RedSelectedBackgroundImage { get { return this[nameof(RedSelectedBackgroundImage)].As<Texture2D>(); } set { this["RedSelectedBackgroundImage"] = value; } }
        public ProgressBar HealthBar { get { return this[nameof(HealthBar)].As<ProgressBar>(); } set { this["HealthBar"] = value; } }
        public TextBlock PlayerNameText { get { return this[nameof(PlayerNameText)].As<TextBlock>(); } set { this["PlayerNameText"] = value; } }
        public Button Button { get { return this[nameof(Button)].As<Button>(); } set { this["Button"] = value; } }
        public void UpdatePlayerNameText() { Invoke(nameof(UpdatePlayerNameText)); }
        public void OnReplayCameraModeChanged(EReplayCameraMode NewReplayCameraMode) { Invoke(nameof(OnReplayCameraModeChanged), NewReplayCameraMode); }
        public void OnFocusedPlayerChanged(PlayerState NewFocusedPlayer) { Invoke(nameof(OnFocusedPlayerChanged), NewFocusedPlayer); }
        public void OnButtonClicked() { Invoke(nameof(OnButtonClicked)); }
    }
    public class PortalWarsReplaysWidget : PortalWarsMenuWidget
    {
        public PortalWarsReplaysWidget(ulong addr) : base(addr) { }
        public Object ReplayEntryWidgetClass { get { return this[nameof(ReplayEntryWidgetClass)]; } set { this[nameof(ReplayEntryWidgetClass)] = value; } }
        public PanelWidget ReplayList { get { return this[nameof(ReplayList)].As<PanelWidget>(); } set { this["ReplayList"] = value; } }
        public PortalWarsReplayEntryWidget PreviewReplayEntry { get { return this[nameof(PreviewReplayEntry)].As<PortalWarsReplayEntryWidget>(); } set { this["PreviewReplayEntry"] = value; } }
        public PortalWarsButtonWidget PlayButton { get { return this[nameof(PlayButton)].As<PortalWarsButtonWidget>(); } set { this["PlayButton"] = value; } }
        public PortalWarsButtonWidget DeleteButton { get { return this[nameof(DeleteButton)].As<PortalWarsButtonWidget>(); } set { this["DeleteButton"] = value; } }
        public PortalWarsButtonWidget RenameButton { get { return this[nameof(RenameButton)].As<PortalWarsButtonWidget>(); } set { this["RenameButton"] = value; } }
        public PortalWarsButtonWidget OpenFolderButton { get { return this[nameof(OpenFolderButton)].As<PortalWarsButtonWidget>(); } set { this["OpenFolderButton"] = value; } }
        public Object RenameReplayDialogWidgetClass { get { return this[nameof(RenameReplayDialogWidgetClass)]; } set { this[nameof(RenameReplayDialogWidgetClass)] = value; } }
        public void RenameSelectedReplay() { Invoke(nameof(RenameSelectedReplay)); }
        public void RefreshPlayButton() { Invoke(nameof(RefreshPlayButton)); }
        public void PlaySelectedReplay() { Invoke(nameof(PlaySelectedReplay)); }
        public void OpenReplayFolder() { Invoke(nameof(OpenReplayFolder)); }
        public void OnReplayEntrySelected(PortalWarsEntryWidget Entry) { Invoke(nameof(OnReplayEntrySelected), Entry); }
        public ESlateVisibility GetSelectedVisibility() { return Invoke<ESlateVisibility>(nameof(GetSelectedVisibility)); }
        public bool GetPlayButtonEnabled() { return Invoke<bool>(nameof(GetPlayButtonEnabled)); }
        public void DeleteSelectedReplay() { Invoke(nameof(DeleteSelectedReplay)); }
    }
    public class PortalWarsReportPlayerWidget : PortalWarsMenuWidget
    {
        public PortalWarsReportPlayerWidget(ulong addr) : base(addr) { }
        public PortalWarsButtonWidget ReportButton { get { return this[nameof(ReportButton)].As<PortalWarsButtonWidget>(); } set { this["ReportButton"] = value; } }
        public PortalWarsDropdownWidget ReportCategoryDropdown { get { return this[nameof(ReportCategoryDropdown)].As<PortalWarsDropdownWidget>(); } set { this["ReportCategoryDropdown"] = value; } }
        public PortalWarsTextInputWidget ReportDescription { get { return this[nameof(ReportDescription)].As<PortalWarsTextInputWidget>(); } set { this["ReportDescription"] = value; } }
        public TextBlock ReportTitleText { get { return this[nameof(ReportTitleText)].As<TextBlock>(); } set { this["ReportTitleText"] = value; } }
        public PortalWarsPlayerEntryWidget PlayerEntry { get { return this[nameof(PlayerEntry)].As<PortalWarsPlayerEntryWidget>(); } set { this["PlayerEntry"] = value; } }
        public void OnReportButtonClicked() { Invoke(nameof(OnReportButtonClicked)); }
        public Object GetReportTitleText() { return Invoke<Object>(nameof(GetReportTitleText)); }
    }
    public class PortalWarsRespawnWidget : UserWidget
    {
        public PortalWarsRespawnWidget(ulong addr) : base(addr) { }
        public TextBlock RespawnText { get { return this[nameof(RespawnText)].As<TextBlock>(); } set { this["RespawnText"] = value; } }
    }
    public class PortalWarsReticleWidget : UserWidget
    {
        public PortalWarsReticleWidget(ulong addr) : base(addr) { }
        public float HitMarkerDisplayTime { get { return this[nameof(HitMarkerDisplayTime)].GetValue<float>(); } set { this[nameof(HitMarkerDisplayTime)].SetValue<float>(value); } }
        public Gun EquippedWeapon { get { return this[nameof(EquippedWeapon)].As<Gun>(); } set { this["EquippedWeapon"] = value; } }
        public ReticleData CurrentReticleData { get { return this[nameof(CurrentReticleData)].As<ReticleData>(); } set { this["CurrentReticleData"] = value; } }
        public CanvasPanel ReticlePanel { get { return this[nameof(ReticlePanel)].As<CanvasPanel>(); } set { this["ReticlePanel"] = value; } }
        public WidgetSwitcher ReticleSwitcher { get { return this[nameof(ReticleSwitcher)].As<WidgetSwitcher>(); } set { this["ReticleSwitcher"] = value; } }
        public Border ReticleBorder { get { return this[nameof(ReticleBorder)].As<Border>(); } set { this["ReticleBorder"] = value; } }
        public CanvasPanel ReticleCanvas { get { return this[nameof(ReticleCanvas)].As<CanvasPanel>(); } set { this["ReticleCanvas"] = value; } }
        public Image OuterCircle { get { return this[nameof(OuterCircle)].As<Image>(); } set { this["OuterCircle"] = value; } }
        public Image InnerCircle { get { return this[nameof(InnerCircle)].As<Image>(); } set { this["InnerCircle"] = value; } }
        public Image dot { get { return this[nameof(dot)].As<Image>(); } set { this["dot"] = value; } }
        public CanvasPanel CrosshairWrapper { get { return this[nameof(CrosshairWrapper)].As<CanvasPanel>(); } set { this["CrosshairWrapper"] = value; } }
        public Image CrosshairRight { get { return this[nameof(CrosshairRight)].As<Image>(); } set { this["CrosshairRight"] = value; } }
        public Image CrosshairLeft { get { return this[nameof(CrosshairLeft)].As<Image>(); } set { this["CrosshairLeft"] = value; } }
        public Image CrosshairTop { get { return this[nameof(CrosshairTop)].As<Image>(); } set { this["CrosshairTop"] = value; } }
        public Image CrosshairBottom { get { return this[nameof(CrosshairBottom)].As<Image>(); } set { this["CrosshairBottom"] = value; } }
        public WidgetSwitcher MarkerSwitcher { get { return this[nameof(MarkerSwitcher)].As<WidgetSwitcher>(); } set { this["MarkerSwitcher"] = value; } }
        public Image HitMarker { get { return this[nameof(HitMarker)].As<Image>(); } set { this["HitMarker"] = value; } }
        public Image HeadshotMarker { get { return this[nameof(HeadshotMarker)].As<Image>(); } set { this["HeadshotMarker"] = value; } }
        public Image KillMarker { get { return this[nameof(KillMarker)].As<Image>(); } set { this["KillMarker"] = value; } }
        public Image ZoomImage { get { return this[nameof(ZoomImage)].As<Image>(); } set { this["ZoomImage"] = value; } }
        public CanvasPanel ChargePanel { get { return this[nameof(ChargePanel)].As<CanvasPanel>(); } set { this["ChargePanel"] = value; } }
        public ProgressBar OverheatProgressBar { get { return this[nameof(OverheatProgressBar)].As<ProgressBar>(); } set { this["OverheatProgressBar"] = value; } }
        public Image SprintCrosshair { get { return this[nameof(SprintCrosshair)].As<Image>(); } set { this["SprintCrosshair"] = value; } }
        public float ChargeUpdateInterval { get { return this[nameof(ChargeUpdateInterval)].GetValue<float>(); } set { this[nameof(ChargeUpdateInterval)].SetValue<float>(value); } }
        public LinearColor ReticleBaseColor { get { return this[nameof(ReticleBaseColor)].As<LinearColor>(); } set { this["ReticleBaseColor"] = value; } }
        public LinearColor ReticleAimColor { get { return this[nameof(ReticleAimColor)].As<LinearColor>(); } set { this["ReticleAimColor"] = value; } }
        public float HitSoundDelayTime { get { return this[nameof(HitSoundDelayTime)].GetValue<float>(); } set { this[nameof(HitSoundDelayTime)].SetValue<float>(value); } }
        public AkAudioEvent HitEnemyEvent { get { return this[nameof(HitEnemyEvent)].As<AkAudioEvent>(); } set { this["HitEnemyEvent"] = value; } }
        public AkAudioEvent HeadshotEnemyEvent { get { return this[nameof(HeadshotEnemyEvent)].As<AkAudioEvent>(); } set { this["HeadshotEnemyEvent"] = value; } }
        public AkAudioEvent KillEnemyEvent { get { return this[nameof(KillEnemyEvent)].As<AkAudioEvent>(); } set { this["KillEnemyEvent"] = value; } }
        public AkAudioEvent AssistKillEnemyEvent { get { return this[nameof(AssistKillEnemyEvent)].As<AkAudioEvent>(); } set { this["AssistKillEnemyEvent"] = value; } }
        public bool bPreviewOnly { get { return this[nameof(bPreviewOnly)].Flag; } set { this[nameof(bPreviewOnly)].Flag = value; } }
        public void UpdateReticle() { Invoke(nameof(UpdateReticle)); }
        public ESlateVisibility GetChargeVisibility() { return Invoke<ESlateVisibility>(nameof(GetChargeVisibility)); }
        public float GetChargeProgress() { return Invoke<float>(nameof(GetChargeProgress)); }
    }
    public class PortalWarsRewardCenterWidget : PortalWarsMenuWidget
    {
        public PortalWarsRewardCenterWidget(ulong addr) : base(addr) { }
    }
    public class PortalWarsRewardReceivedEntry : PortalWarsRewardEntryWidget
    {
        public PortalWarsRewardReceivedEntry(ulong addr) : base(addr) { }
        public TextBlock RewardReceivedTypeText { get { return this[nameof(RewardReceivedTypeText)].As<TextBlock>(); } set { this["RewardReceivedTypeText"] = value; } }
        public Widget LockedRoot { get { return this[nameof(LockedRoot)].As<Widget>(); } set { this["LockedRoot"] = value; } }
        public AkAudioEvent RewardReceivedEvent { get { return this[nameof(RewardReceivedEvent)].As<AkAudioEvent>(); } set { this["RewardReceivedEvent"] = value; } }
        public void PlayRewardSound() { Invoke(nameof(PlayRewardSound)); }
    }
    public class PortalWarsRewardReceivedWidget : PortalWarsDialogWidget
    {
        public PortalWarsRewardReceivedWidget(ulong addr) : base(addr) { }
        public Array<PortalWarsRewardEntryWidget> RewardEntries { get { return new Array<PortalWarsRewardEntryWidget>(this[nameof(RewardEntries)].Address); } }
        public Object RewardEntryWidgetClass { get { return this[nameof(RewardEntryWidgetClass)]; } set { this[nameof(RewardEntryWidgetClass)] = value; } }
        public PanelWidget EntryPanel { get { return this[nameof(EntryPanel)].As<PanelWidget>(); } set { this["EntryPanel"] = value; } }
        public PortalWarsButtonWidget PremiumPurchaseButton { get { return this[nameof(PremiumPurchaseButton)].As<PortalWarsButtonWidget>(); } set { this["PremiumPurchaseButton"] = value; } }
        public PortalWarsInspectWidget InspectWidget { get { return this[nameof(InspectWidget)].As<PortalWarsInspectWidget>(); } set { this["InspectWidget"] = value; } }
        public TextBlock TitleText { get { return this[nameof(TitleText)].As<TextBlock>(); } set { this["TitleText"] = value; } }
        public void ShowNextReward() { Invoke(nameof(ShowNextReward)); }
        public void SetRewardType(ERewardReceivedType InType) { Invoke(nameof(SetRewardType), InType); }
        public void OnRewardEntrySelected(PortalWarsEntryWidget Entry) { Invoke(nameof(OnRewardEntrySelected), Entry); }
        public bool GetPurchasePremiumEnabled() { return Invoke<bool>(nameof(GetPurchasePremiumEnabled)); }
        public ESlateVisibility GetPremiumVisibility() { return Invoke<ESlateVisibility>(nameof(GetPremiumVisibility)); }
    }
    public class PortalWarsRootHUDWidget : PortalWarsUserWidget
    {
        public PortalWarsRootHUDWidget(ulong addr) : base(addr) { }
        public CanvasPanel RootWidget { get { return this[nameof(RootWidget)].As<CanvasPanel>(); } set { this["RootWidget"] = value; } }
    }
    public class PortalWarsRoundCountdownWidget : PortalWarsCountdownWidget
    {
        public PortalWarsRoundCountdownWidget(ulong addr) : base(addr) { }
        public TextBlock RoundText { get { return this[nameof(RoundText)].As<TextBlock>(); } set { this["RoundText"] = value; } }
        public TextBlock MatchPointText { get { return this[nameof(MatchPointText)].As<TextBlock>(); } set { this["MatchPointText"] = value; } }
    }
    public class PortalWarsRoundGameMode : PortalWarsGameMode
    {
        public PortalWarsRoundGameMode(ulong addr) : base(addr) { }
    }
    public class PortalWarsRoundGameState : PortalWarsGameState
    {
        public PortalWarsRoundGameState(ulong addr) : base(addr) { }
        public int CurrentRound { get { return this[nameof(CurrentRound)].GetValue<int>(); } set { this[nameof(CurrentRound)].SetValue<int>(value); } }
        public int ReplicatedElapsedServerTime { get { return this[nameof(ReplicatedElapsedServerTime)].GetValue<int>(); } set { this[nameof(ReplicatedElapsedServerTime)].SetValue<int>(value); } }
        public Array<int> TeamRoundScores { get { return new Array<int>(this[nameof(TeamRoundScores)].Address); } }
        public Array<int> RoundWinners { get { return new Array<int>(this[nameof(RoundWinners)].Address); } }
        public CameraActor IntermissionCam { get { return this[nameof(IntermissionCam)].As<CameraActor>(); } set { this["IntermissionCam"] = value; } }
        public void OnRep_RoundScore() { Invoke(nameof(OnRep_RoundScore)); }
        public void OnRep_ElapsedServerTime() { Invoke(nameof(OnRep_ElapsedServerTime)); }
        public void OnRep_CurrentRound() { Invoke(nameof(OnRep_CurrentRound)); }
    }
    public class PortalWarsRoundHUD : PortalWarsHUD
    {
        public PortalWarsRoundHUD(ulong addr) : base(addr) { }
        public PortalWarsRoundResultWidget RoundResultWidget { get { return this[nameof(RoundResultWidget)].As<PortalWarsRoundResultWidget>(); } set { this["RoundResultWidget"] = value; } }
        public Object RoundResultWidgetClass { get { return this[nameof(RoundResultWidgetClass)]; } set { this[nameof(RoundResultWidgetClass)] = value; } }
        public PortalWarsRoundIntermissionWidget RoundIntermissionWidget { get { return this[nameof(RoundIntermissionWidget)].As<PortalWarsRoundIntermissionWidget>(); } set { this["RoundIntermissionWidget"] = value; } }
        public Object RoundIntermissionWidgetClass { get { return this[nameof(RoundIntermissionWidgetClass)]; } set { this[nameof(RoundIntermissionWidgetClass)] = value; } }
        public PortalWarsRoundHUDOverlayWidget RoundHUDOverlayWidget { get { return this[nameof(RoundHUDOverlayWidget)].As<PortalWarsRoundHUDOverlayWidget>(); } set { this["RoundHUDOverlayWidget"] = value; } }
        public Object RoundHUDOverlayWidgetClass { get { return this[nameof(RoundHUDOverlayWidgetClass)]; } set { this[nameof(RoundHUDOverlayWidgetClass)] = value; } }
        public Object PlayerStatusWidgetClass { get { return this[nameof(PlayerStatusWidgetClass)]; } set { this[nameof(PlayerStatusWidgetClass)] = value; } }
    }
    public class PortalWarsRoundHUDOverlayWidget : UserWidget
    {
        public PortalWarsRoundHUDOverlayWidget(ulong addr) : base(addr) { }
        public HorizontalBox TopPlayerStatusHorizontalBox { get { return this[nameof(TopPlayerStatusHorizontalBox)].As<HorizontalBox>(); } set { this["TopPlayerStatusHorizontalBox"] = value; } }
        public HorizontalBox BottomPlayerStatusHorizontalBox { get { return this[nameof(BottomPlayerStatusHorizontalBox)].As<HorizontalBox>(); } set { this["BottomPlayerStatusHorizontalBox"] = value; } }
        public void OnPlayerListChanged(Array<PlayerState> NewPlayerList) { Invoke(nameof(OnPlayerListChanged), NewPlayerList); }
    }
    public class PortalWarsRoundIntermissionWidget : UserWidget
    {
        public PortalWarsRoundIntermissionWidget(ulong addr) : base(addr) { }
        public TextBlock NumRoundsText { get { return this[nameof(NumRoundsText)].As<TextBlock>(); } set { this["NumRoundsText"] = value; } }
        public TextBlock CurrentRoundText { get { return this[nameof(CurrentRoundText)].As<TextBlock>(); } set { this["CurrentRoundText"] = value; } }
        public RichTextBlock RoundWinnerText { get { return this[nameof(RoundWinnerText)].As<RichTextBlock>(); } set { this["RoundWinnerText"] = value; } }
        public Image LeftStarImage { get { return this[nameof(LeftStarImage)].As<Image>(); } set { this["LeftStarImage"] = value; } }
        public Image RightStarImage { get { return this[nameof(RightStarImage)].As<Image>(); } set { this["RightStarImage"] = value; } }
        public TextBlock CountdownText { get { return this[nameof(CountdownText)].As<TextBlock>(); } set { this["CountdownText"] = value; } }
    }
    public class PortalWarsRoundPlayerStatusWidget : UserWidget
    {
        public PortalWarsRoundPlayerStatusWidget(ulong addr) : base(addr) { }
        public Image BackgroundImage { get { return this[nameof(BackgroundImage)].As<Image>(); } set { this["BackgroundImage"] = value; } }
        public Texture2D RedPlayerImage { get { return this[nameof(RedPlayerImage)].As<Texture2D>(); } set { this["RedPlayerImage"] = value; } }
        public Texture2D BluePlayerImage { get { return this[nameof(BluePlayerImage)].As<Texture2D>(); } set { this["BluePlayerImage"] = value; } }
        public Texture2D DeadPlayerImage { get { return this[nameof(DeadPlayerImage)].As<Texture2D>(); } set { this["DeadPlayerImage"] = value; } }
        public float PaddingBetweenEntries { get { return this[nameof(PaddingBetweenEntries)].GetValue<float>(); } set { this[nameof(PaddingBetweenEntries)].SetValue<float>(value); } }
    }
    public class PortalWarsRoundResultWidget : UserWidget
    {
        public PortalWarsRoundResultWidget(ulong addr) : base(addr) { }
        public TextBlock TitleText { get { return this[nameof(TitleText)].As<TextBlock>(); } set { this["TitleText"] = value; } }
        public Image LeftStarImage { get { return this[nameof(LeftStarImage)].As<Image>(); } set { this["LeftStarImage"] = value; } }
        public Image RightStarImage { get { return this[nameof(RightStarImage)].As<Image>(); } set { this["RightStarImage"] = value; } }
        public Image TopBorderImage { get { return this[nameof(TopBorderImage)].As<Image>(); } set { this["TopBorderImage"] = value; } }
        public Image BottomBorderImage { get { return this[nameof(BottomBorderImage)].As<Image>(); } set { this["BottomBorderImage"] = value; } }
        public WidgetAnimation FadeInAnimation { get { return this[nameof(FadeInAnimation)].As<WidgetAnimation>(); } set { this["FadeInAnimation"] = value; } }
        public Object GetTitleText() { return Invoke<Object>(nameof(GetTitleText)); }
    }
    public class PortalWarsRoundScoreboardEntryWidget : UserWidget
    {
        public PortalWarsRoundScoreboardEntryWidget(ulong addr) : base(addr) { }
        public TextBlock RoundNumText { get { return this[nameof(RoundNumText)].As<TextBlock>(); } set { this["RoundNumText"] = value; } }
        public Image TopResultImage { get { return this[nameof(TopResultImage)].As<Image>(); } set { this["TopResultImage"] = value; } }
        public Image BottomResultImage { get { return this[nameof(BottomResultImage)].As<Image>(); } set { this["BottomResultImage"] = value; } }
        public Image SeparatorImage { get { return this[nameof(SeparatorImage)].As<Image>(); } set { this["SeparatorImage"] = value; } }
        public TextBlock CurrentRoundNumText { get { return this[nameof(CurrentRoundNumText)].As<TextBlock>(); } set { this["CurrentRoundNumText"] = value; } }
        public WidgetSwitcher RoundWidgetSwitcher { get { return this[nameof(RoundWidgetSwitcher)].As<WidgetSwitcher>(); } set { this["RoundWidgetSwitcher"] = value; } }
        public Image CurrentRoundBackgroundImage { get { return this[nameof(CurrentRoundBackgroundImage)].As<Image>(); } set { this["CurrentRoundBackgroundImage"] = value; } }
        public Texture2D RoundWinBlue { get { return this[nameof(RoundWinBlue)].As<Texture2D>(); } set { this["RoundWinBlue"] = value; } }
        public Texture2D RoundWinRed { get { return this[nameof(RoundWinRed)].As<Texture2D>(); } set { this["RoundWinRed"] = value; } }
        public Texture2D RoundLoss { get { return this[nameof(RoundLoss)].As<Texture2D>(); } set { this["RoundLoss"] = value; } }
        public Texture2D RoundUnplayed { get { return this[nameof(RoundUnplayed)].As<Texture2D>(); } set { this["RoundUnplayed"] = value; } }
        public Texture2D RoundCurrent { get { return this[nameof(RoundCurrent)].As<Texture2D>(); } set { this["RoundCurrent"] = value; } }
        public float PaddingBetweenEntries { get { return this[nameof(PaddingBetweenEntries)].GetValue<float>(); } set { this[nameof(PaddingBetweenEntries)].SetValue<float>(value); } }
    }
    public class PortalWarsRoundScoreboardWidget : UserWidget
    {
        public PortalWarsRoundScoreboardWidget(ulong addr) : base(addr) { }
        public TextBlock TopNameText { get { return this[nameof(TopNameText)].As<TextBlock>(); } set { this["TopNameText"] = value; } }
        public TextBlock BottomNameText { get { return this[nameof(BottomNameText)].As<TextBlock>(); } set { this["BottomNameText"] = value; } }
        public TextBlock TopScoreText { get { return this[nameof(TopScoreText)].As<TextBlock>(); } set { this["TopScoreText"] = value; } }
        public TextBlock BottomScoreText { get { return this[nameof(BottomScoreText)].As<TextBlock>(); } set { this["BottomScoreText"] = value; } }
        public HorizontalBox RoundEntries { get { return this[nameof(RoundEntries)].As<HorizontalBox>(); } set { this["RoundEntries"] = value; } }
        public Object RoundEntryWidgetClass { get { return this[nameof(RoundEntryWidgetClass)]; } set { this[nameof(RoundEntryWidgetClass)] = value; } }
        public bool bExpandEntries { get { return this[nameof(bExpandEntries)].Flag; } set { this[nameof(bExpandEntries)].Flag = value; } }
    }
    public class PortalWarsSaveGame : SaveGame
    {
        public PortalWarsSaveGame(ulong addr) : base(addr) { }
        public float FOV { get { return this[nameof(FOV)].GetValue<float>(); } set { this[nameof(FOV)].SetValue<float>(value); } }
        public int ColorblindMode { get { return this[nameof(ColorblindMode)].GetValue<int>(); } set { this[nameof(ColorblindMode)].SetValue<int>(value); } }
        public float ColorblindModeIntensity { get { return this[nameof(ColorblindModeIntensity)].GetValue<float>(); } set { this[nameof(ColorblindModeIntensity)].SetValue<float>(value); } }
        public float MasterVolume { get { return this[nameof(MasterVolume)].GetValue<float>(); } set { this[nameof(MasterVolume)].SetValue<float>(value); } }
        public float MusicVolume { get { return this[nameof(MusicVolume)].GetValue<float>(); } set { this[nameof(MusicVolume)].SetValue<float>(value); } }
        public float GameplayVolume { get { return this[nameof(GameplayVolume)].GetValue<float>(); } set { this[nameof(GameplayVolume)].SetValue<float>(value); } }
        public float AnnouncerVolume { get { return this[nameof(AnnouncerVolume)].GetValue<float>(); } set { this[nameof(AnnouncerVolume)].SetValue<float>(value); } }
        public float AmbientVolume { get { return this[nameof(AmbientVolume)].GetValue<float>(); } set { this[nameof(AmbientVolume)].SetValue<float>(value); } }
        public float VOIPVolume { get { return this[nameof(VOIPVolume)].GetValue<float>(); } set { this[nameof(VOIPVolume)].SetValue<float>(value); } }
        public bool bOpenMic { get { return this[nameof(bOpenMic)].Flag; } set { this[nameof(bOpenMic)].Flag = value; } }
        public bool bProximityEnabled { get { return this[nameof(bProximityEnabled)].Flag; } set { this[nameof(bProximityEnabled)].Flag = value; } }
        public Object VoiceChatInputDevice { get { return this[nameof(VoiceChatInputDevice)]; } set { this[nameof(VoiceChatInputDevice)] = value; } }
        public Object VoiceChatOutputDevice { get { return this[nameof(VoiceChatOutputDevice)]; } set { this[nameof(VoiceChatOutputDevice)] = value; } }
        public bool bMuteWhileMinimized { get { return this[nameof(bMuteWhileMinimized)].Flag; } set { this[nameof(bMuteWhileMinimized)].Flag = value; } }
        public bool ToggleCrouch { get { return this[nameof(ToggleCrouch)].Flag; } set { this[nameof(ToggleCrouch)].Flag = value; } }
        public bool ToggleZoom { get { return this[nameof(ToggleZoom)].Flag; } set { this[nameof(ToggleZoom)].Flag = value; } }
        public bool ToggleSprint { get { return this[nameof(ToggleSprint)].Flag; } set { this[nameof(ToggleSprint)].Flag = value; } }
        public float HorizontalMouseSensitivity { get { return this[nameof(HorizontalMouseSensitivity)].GetValue<float>(); } set { this[nameof(HorizontalMouseSensitivity)].SetValue<float>(value); } }
        public float VerticalMouseSensitivity { get { return this[nameof(VerticalMouseSensitivity)].GetValue<float>(); } set { this[nameof(VerticalMouseSensitivity)].SetValue<float>(value); } }
        public float MouseZoomSensitivityMultiplier { get { return this[nameof(MouseZoomSensitivityMultiplier)].GetValue<float>(); } set { this[nameof(MouseZoomSensitivityMultiplier)].SetValue<float>(value); } }
        public bool MouseInverted { get { return this[nameof(MouseInverted)].Flag; } set { this[nameof(MouseInverted)].Flag = value; } }
        public bool EnableMouseSmoothing { get { return this[nameof(EnableMouseSmoothing)].Flag; } set { this[nameof(EnableMouseSmoothing)].Flag = value; } }
        public Array<KeyConfigurationInfo> KeyBindings { get { return new Array<KeyConfigurationInfo>(this[nameof(KeyBindings)].Address); } }
        public float HorizontalControllerSensitivity { get { return this[nameof(HorizontalControllerSensitivity)].GetValue<float>(); } set { this[nameof(HorizontalControllerSensitivity)].SetValue<float>(value); } }
        public float VerticalControllerSensitivity { get { return this[nameof(VerticalControllerSensitivity)].GetValue<float>(); } set { this[nameof(VerticalControllerSensitivity)].SetValue<float>(value); } }
        public float ControllerAccelerationSensitivity { get { return this[nameof(ControllerAccelerationSensitivity)].GetValue<float>(); } set { this[nameof(ControllerAccelerationSensitivity)].SetValue<float>(value); } }
        public float ControllerZoomSensitivityMultiplier { get { return this[nameof(ControllerZoomSensitivityMultiplier)].GetValue<float>(); } set { this[nameof(ControllerZoomSensitivityMultiplier)].SetValue<float>(value); } }
        public float ControllerInnerDeadzone { get { return this[nameof(ControllerInnerDeadzone)].GetValue<float>(); } set { this[nameof(ControllerInnerDeadzone)].SetValue<float>(value); } }
        public float ControllerOuterDeadzone { get { return this[nameof(ControllerOuterDeadzone)].GetValue<float>(); } set { this[nameof(ControllerOuterDeadzone)].SetValue<float>(value); } }
        public bool ControllerInverted { get { return this[nameof(ControllerInverted)].Flag; } set { this[nameof(ControllerInverted)].Flag = value; } }
        public bool ControllerVibrationEnabled { get { return this[nameof(ControllerVibrationEnabled)].Flag; } set { this[nameof(ControllerVibrationEnabled)].Flag = value; } }
        public int ControllerGameplayPreset { get { return this[nameof(ControllerGameplayPreset)].GetValue<int>(); } set { this[nameof(ControllerGameplayPreset)].SetValue<int>(value); } }
        public ControllerKeybindPreset CustomControllerBindings { get { return this[nameof(CustomControllerBindings)].As<ControllerKeybindPreset>(); } set { this["CustomControllerBindings"] = value; } }
        public bool ShouldShowBlood { get { return this[nameof(ShouldShowBlood)].Flag; } set { this[nameof(ShouldShowBlood)].Flag = value; } }
        public int PlayKillcamMode { get { return this[nameof(PlayKillcamMode)].GetValue<int>(); } set { this[nameof(PlayKillcamMode)].SetValue<int>(value); } }
        public bool ShouldPlayKillcam { get { return this[nameof(ShouldPlayKillcam)].Flag; } set { this[nameof(ShouldPlayKillcam)].Flag = value; } }
        public bool ShouldRecordReplay { get { return this[nameof(ShouldRecordReplay)].Flag; } set { this[nameof(ShouldRecordReplay)].Flag = value; } }
        public int InputDevice { get { return this[nameof(InputDevice)].GetValue<int>(); } set { this[nameof(InputDevice)].SetValue<int>(value); } }
        public bool ShowFPS { get { return this[nameof(ShowFPS)].Flag; } set { this[nameof(ShowFPS)].Flag = value; } }
        public bool ShowPing { get { return this[nameof(ShowPing)].Flag; } set { this[nameof(ShowPing)].Flag = value; } }
        public bool ShowNetInfo { get { return this[nameof(ShowNetInfo)].Flag; } set { this[nameof(ShowNetInfo)].Flag = value; } }
        public bool ShowSubtitles { get { return this[nameof(ShowSubtitles)].Flag; } set { this[nameof(ShowSubtitles)].Flag = value; } }
        public bool ShowDamageNumbers { get { return this[nameof(ShowDamageNumbers)].Flag; } set { this[nameof(ShowDamageNumbers)].Flag = value; } }
        public bool ShowLowAmmo { get { return this[nameof(ShowLowAmmo)].Flag; } set { this[nameof(ShowLowAmmo)].Flag = value; } }
        public bool ShowSprintCrosshair { get { return this[nameof(ShowSprintCrosshair)].Flag; } set { this[nameof(ShowSprintCrosshair)].Flag = value; } }
        public Object CustomCrosshairs { get { return this[nameof(CustomCrosshairs)]; } set { this[nameof(CustomCrosshairs)] = value; } }
        public LinearColor CustomCrosshairColor { get { return this[nameof(CustomCrosshairColor)].As<LinearColor>(); } set { this["CustomCrosshairColor"] = value; } }
        public LinearColor EnemyCustomCrosshairColor { get { return this[nameof(EnemyCustomCrosshairColor)].As<LinearColor>(); } set { this["EnemyCustomCrosshairColor"] = value; } }
        public bool WantsToCrossPlay { get { return this[nameof(WantsToCrossPlay)].Flag; } set { this[nameof(WantsToCrossPlay)].Flag = value; } }
        public bool bAnonymousMode { get { return this[nameof(bAnonymousMode)].Flag; } set { this[nameof(bAnonymousMode)].Flag = value; } }
        public bool bHideNames { get { return this[nameof(bHideNames)].Flag; } set { this[nameof(bHideNames)].Flag = value; } }
        public bool bPartyChatOnly { get { return this[nameof(bPartyChatOnly)].Flag; } set { this[nameof(bPartyChatOnly)].Flag = value; } }
        public bool bHasCompletedTutorial { get { return this[nameof(bHasCompletedTutorial)].Flag; } set { this[nameof(bHasCompletedTutorial)].Flag = value; } }
        public int TutorialStageID { get { return this[nameof(TutorialStageID)].GetValue<int>(); } set { this[nameof(TutorialStageID)].SetValue<int>(value); } }
        public bool bHasWatchedIntroVideo { get { return this[nameof(bHasWatchedIntroVideo)].Flag; } set { this[nameof(bHasWatchedIntroVideo)].Flag = value; } }
        public bool bHasSeenBattlePassDialog { get { return this[nameof(bHasSeenBattlePassDialog)].Flag; } set { this[nameof(bHasSeenBattlePassDialog)].Flag = value; } }
        public Array<CustomizationId> EquippedCustomizations { get { return new Array<CustomizationId>(this[nameof(EquippedCustomizations)].Address); } }
        public Array<CustomizationId> ViewedCustomizations { get { return new Array<CustomizationId>(this[nameof(ViewedCustomizations)].Address); } }
        public Array<StoreItemInfo> ViewedStoreItems { get { return new Array<StoreItemInfo>(this[nameof(ViewedStoreItems)].Address); } }
        public Array<Object> ViewedLimitedTimeOffers { get { return new Array<Object>(this[nameof(ViewedLimitedTimeOffers)].Address); } }
        public Array<ChallengeData> ViewedChallenges { get { return new Array<ChallengeData>(this[nameof(ViewedChallenges)].Address); } }
        public Array<Object> MuteList { get { return new Array<Object>(this[nameof(MuteList)].Address); } }
        public DateTime LastLoginTime { get { return this[nameof(LastLoginTime)].As<DateTime>(); } set { this["LastLoginTime"] = value; } }
        public Object LoginAuthToken { get { return this[nameof(LoginAuthToken)]; } set { this[nameof(LoginAuthToken)] = value; } }
        public int PreferredMatchmakingRegionID { get { return this[nameof(PreferredMatchmakingRegionID)].GetValue<int>(); } set { this[nameof(PreferredMatchmakingRegionID)].SetValue<int>(value); } }
        public int PreferredCustomRegionID { get { return this[nameof(PreferredCustomRegionID)].GetValue<int>(); } set { this[nameof(PreferredCustomRegionID)].SetValue<int>(value); } }
        public Object PlaylistPreferences { get { return this[nameof(PlaylistPreferences)]; } set { this[nameof(PlaylistPreferences)] = value; } }
        public Object LastGameVersion { get { return this[nameof(LastGameVersion)]; } set { this[nameof(LastGameVersion)] = value; } }
    }
    public class PortalWarsScoreboardStatEntry : PortalWarsUserWidget
    {
        public PortalWarsScoreboardStatEntry(ulong addr) : base(addr) { }
        public TextBlock StatValueText { get { return this[nameof(StatValueText)].As<TextBlock>(); } set { this["StatValueText"] = value; } }
        public TextBlock StatNameText { get { return this[nameof(StatNameText)].As<TextBlock>(); } set { this["StatNameText"] = value; } }
        public Object MedalColors { get { return this[nameof(MedalColors)]; } set { this[nameof(MedalColors)] = value; } }
        public Image MedalImage { get { return this[nameof(MedalImage)].As<Image>(); } set { this["MedalImage"] = value; } }
        public SizeBox MedalImageSizeBox { get { return this[nameof(MedalImageSizeBox)].As<SizeBox>(); } set { this["MedalImageSizeBox"] = value; } }
        public Object MedalImages { get { return this[nameof(MedalImages)]; } set { this[nameof(MedalImages)] = value; } }
        public Texture2D DefaultMedalImage { get { return this[nameof(DefaultMedalImage)].As<Texture2D>(); } set { this["DefaultMedalImage"] = value; } }
        public Object GetStatValueText() { return Invoke<Object>(nameof(GetStatValueText)); }
        public Object GetStatNameText() { return Invoke<Object>(nameof(GetStatNameText)); }
        public Texture2D GetMedalImage() { return Invoke<Texture2D>(nameof(GetMedalImage)); }
        public LinearColor GetMedalColor() { return Invoke<LinearColor>(nameof(GetMedalColor)); }
    }
    public class PortalWarsScreenFadeWidget : UserWidget
    {
        public PortalWarsScreenFadeWidget(ulong addr) : base(addr) { }
        public WidgetAnimation FadeInAnimation { get { return this[nameof(FadeInAnimation)].As<WidgetAnimation>(); } set { this["FadeInAnimation"] = value; } }
        public WidgetAnimation FadeOutAnimation { get { return this[nameof(FadeOutAnimation)].As<WidgetAnimation>(); } set { this["FadeOutAnimation"] = value; } }
        public Image FadeImage { get { return this[nameof(FadeImage)].As<Image>(); } set { this["FadeImage"] = value; } }
        public void PlayFadeOutAnimation() { Invoke(nameof(PlayFadeOutAnimation)); }
        public void PlayFadeInAnimation() { Invoke(nameof(PlayFadeInAnimation)); }
    }
    public class PortalWarsScrollBox : ScrollBox
    {
        public PortalWarsScrollBox(ulong addr) : base(addr) { }
        public bool bAllowGamepadRightStickScrolling { get { return this[nameof(bAllowGamepadRightStickScrolling)].Flag; } set { this[nameof(bAllowGamepadRightStickScrolling)].Flag = value; } }
        public float GamepadScrollSpeed { get { return this[nameof(GamepadScrollSpeed)].GetValue<float>(); } set { this[nameof(GamepadScrollSpeed)].SetValue<float>(value); } }
    }
    public class PortalWarsSeasonRewardsWidget : UserWidget
    {
        public PortalWarsSeasonRewardsWidget(ulong addr) : base(addr) { }
        public HorizontalBox GamesPanel { get { return this[nameof(GamesPanel)].As<HorizontalBox>(); } set { this["GamesPanel"] = value; } }
        public Image RankIcon { get { return this[nameof(RankIcon)].As<Image>(); } set { this["RankIcon"] = value; } }
        public TextBlock RankText { get { return this[nameof(RankText)].As<TextBlock>(); } set { this["RankText"] = value; } }
        public RichTextBlock WinsText { get { return this[nameof(WinsText)].As<RichTextBlock>(); } set { this["WinsText"] = value; } }
        public Texture2D IncompleteImage { get { return this[nameof(IncompleteImage)].As<Texture2D>(); } set { this["IncompleteImage"] = value; } }
        public Texture2D CompleteImage { get { return this[nameof(CompleteImage)].As<Texture2D>(); } set { this["CompleteImage"] = value; } }
        public Texture2D SeparatorImage { get { return this[nameof(SeparatorImage)].As<Texture2D>(); } set { this["SeparatorImage"] = value; } }
        public void RefreshWidget() { Invoke(nameof(RefreshWidget)); }
    }
    public class PortalWarsServerBrowserWidget : PortalWarsMenuWidget
    {
        public PortalWarsServerBrowserWidget(ulong addr) : base(addr) { }
        public Object ServerEntryWidgetClass { get { return this[nameof(ServerEntryWidgetClass)]; } set { this[nameof(ServerEntryWidgetClass)] = value; } }
        public PanelWidget ServerList { get { return this[nameof(ServerList)].As<PanelWidget>(); } set { this["ServerList"] = value; } }
        public PortalWarsNumericCarouselWidget PaginatorCarousel { get { return this[nameof(PaginatorCarousel)].As<PortalWarsNumericCarouselWidget>(); } set { this["PaginatorCarousel"] = value; } }
        public int NumEntriesPerPage { get { return this[nameof(NumEntriesPerPage)].GetValue<int>(); } set { this[nameof(NumEntriesPerPage)].SetValue<int>(value); } }
        public PortalWarsButtonWidget RefreshButton { get { return this[nameof(RefreshButton)].As<PortalWarsButtonWidget>(); } set { this["RefreshButton"] = value; } }
        public Object OnCreateButtonClickedDelegate { get { return this[nameof(OnCreateButtonClickedDelegate)]; } set { this[nameof(OnCreateButtonClickedDelegate)] = value; } }
        public PortalWarsButtonWidget CreateButton { get { return this[nameof(CreateButton)].As<PortalWarsButtonWidget>(); } set { this["CreateButton"] = value; } }
        public PortalWarsServerEntryWidget PreviewServerEntry { get { return this[nameof(PreviewServerEntry)].As<PortalWarsServerEntryWidget>(); } set { this["PreviewServerEntry"] = value; } }
        public PortalWarsButtonWidget JoinButton { get { return this[nameof(JoinButton)].As<PortalWarsButtonWidget>(); } set { this["JoinButton"] = value; } }
        public Object JoinServerDialogWidgetClass { get { return this[nameof(JoinServerDialogWidgetClass)]; } set { this[nameof(JoinServerDialogWidgetClass)] = value; } }
        public int MaxVisibleEntries { get { return this[nameof(MaxVisibleEntries)].GetValue<int>(); } set { this[nameof(MaxVisibleEntries)].SetValue<int>(value); } }
        public void OnServerEntrySelected(PortalWarsEntryWidget Entry) { Invoke(nameof(OnServerEntrySelected), Entry); }
        public void OnLoadPage() { Invoke(nameof(OnLoadPage)); }
        public void OnJoinButtonClicked() { Invoke(nameof(OnJoinButtonClicked)); }
        public void OnCreateButtonClicked() { Invoke(nameof(OnCreateButtonClicked)); }
        public ESlateVisibility GetSelectedVisibility() { return Invoke<ESlateVisibility>(nameof(GetSelectedVisibility)); }
        public bool GetSearchButtonEnabled() { return Invoke<bool>(nameof(GetSearchButtonEnabled)); }
        public void FindServers() { Invoke(nameof(FindServers)); }
        public void DelayedFindServers() { Invoke(nameof(DelayedFindServers)); }
    }
    public class PortalWarsServerEntryWidget : PortalWarsEntryWidget
    {
        public PortalWarsServerEntryWidget(ulong addr) : base(addr) { }
        public TextBlock ServerNameText { get { return this[nameof(ServerNameText)].As<TextBlock>(); } set { this["ServerNameText"] = value; } }
        public TextBlock ServerTypeText { get { return this[nameof(ServerTypeText)].As<TextBlock>(); } set { this["ServerTypeText"] = value; } }
        public TextBlock MapText { get { return this[nameof(MapText)].As<TextBlock>(); } set { this["MapText"] = value; } }
        public Image MapImage { get { return this[nameof(MapImage)].As<Image>(); } set { this["MapImage"] = value; } }
        public TextBlock ModeText { get { return this[nameof(ModeText)].As<TextBlock>(); } set { this["ModeText"] = value; } }
        public TextBlock RegionText { get { return this[nameof(RegionText)].As<TextBlock>(); } set { this["RegionText"] = value; } }
        public Widget PrivateRoot { get { return this[nameof(PrivateRoot)].As<Widget>(); } set { this["PrivateRoot"] = value; } }
        public Image PrivateImage { get { return this[nameof(PrivateImage)].As<Image>(); } set { this["PrivateImage"] = value; } }
        public TextBlock PlayersText { get { return this[nameof(PlayersText)].As<TextBlock>(); } set { this["PlayersText"] = value; } }
        public TextBlock SpectatorsText { get { return this[nameof(SpectatorsText)].As<TextBlock>(); } set { this["SpectatorsText"] = value; } }
        public Widget CrossPlayIndicator { get { return this[nameof(CrossPlayIndicator)].As<Widget>(); } set { this["CrossPlayIndicator"] = value; } }
        public PanelWidget CreatedByPanel { get { return this[nameof(CreatedByPanel)].As<PanelWidget>(); } set { this["CreatedByPanel"] = value; } }
        public Object CreatedByEntryWidgetClass { get { return this[nameof(CreatedByEntryWidgetClass)]; } set { this[nameof(CreatedByEntryWidgetClass)] = value; } }
        public WidgetSwitcher BackgroundSwitcher { get { return this[nameof(BackgroundSwitcher)].As<WidgetSwitcher>(); } set { this["BackgroundSwitcher"] = value; } }
        public void UpdateCreatedByEntry() { Invoke(nameof(UpdateCreatedByEntry)); }
        public bool IsPrivateServer() { return Invoke<bool>(nameof(IsPrivateServer)); }
        public bool IsLANServer() { return Invoke<bool>(nameof(IsLANServer)); }
        public Object GetVisibilityText() { return Invoke<Object>(nameof(GetVisibilityText)); }
        public Object GetSpectatorsText() { return Invoke<Object>(nameof(GetSpectatorsText)); }
        public Object GetServerType() { return Invoke<Object>(nameof(GetServerType)); }
        public Object GetServerPassword() { return Invoke<Object>(nameof(GetServerPassword)); }
        public Object GetServerName() { return Invoke<Object>(nameof(GetServerName)); }
        public Object GetRegionName() { return Invoke<Object>(nameof(GetRegionName)); }
        public ESlateVisibility GetPrivateVisibility() { return Invoke<ESlateVisibility>(nameof(GetPrivateVisibility)); }
        public Object GetPlayersText() { return Invoke<Object>(nameof(GetPlayersText)); }
        public Object GetModeName() { return Invoke<Object>(nameof(GetModeName)); }
        public Object GetMapName() { return Invoke<Object>(nameof(GetMapName)); }
        public ESlateVisibility GetCrossPlayVisibility() { return Invoke<ESlateVisibility>(nameof(GetCrossPlayVisibility)); }
    }
    public class PortalWarsServerFiltersWidget : PortalWarsMenuWidget
    {
        public PortalWarsServerFiltersWidget(ulong addr) : base(addr) { }
        public PortalWarsTextInputWidget NameFilter { get { return this[nameof(NameFilter)].As<PortalWarsTextInputWidget>(); } set { this["NameFilter"] = value; } }
        public PortalWarsCheckListWidget TypeChecklist { get { return this[nameof(TypeChecklist)].As<PortalWarsCheckListWidget>(); } set { this["TypeChecklist"] = value; } }
        public PortalWarsCheckListWidget ModeChecklist { get { return this[nameof(ModeChecklist)].As<PortalWarsCheckListWidget>(); } set { this["ModeChecklist"] = value; } }
        public PortalWarsCheckListWidget RegionChecklist { get { return this[nameof(RegionChecklist)].As<PortalWarsCheckListWidget>(); } set { this["RegionChecklist"] = value; } }
        public PortalWarsCheckListWidget VisibilityChecklist { get { return this[nameof(VisibilityChecklist)].As<PortalWarsCheckListWidget>(); } set { this["VisibilityChecklist"] = value; } }
    }
    public class PortalWarsSettingsMenuWidget : PortalWarsMenuWidget
    {
        public PortalWarsSettingsMenuWidget(ulong addr) : base(addr) { }
        public Array<Object> Widgets { get { return new Array<Object>(this[nameof(Widgets)].Address); } }
        public Array<Object> ConsoleWidgets { get { return new Array<Object>(this[nameof(ConsoleWidgets)].Address); } }
    }
    public class PortalWarsTakedown : PortalWarsRoundGameMode
    {
        public PortalWarsTakedown(ulong addr) : base(addr) { }
        public PortalWarsTakedownGameState TakedownGameState { get { return this[nameof(TakedownGameState)].As<PortalWarsTakedownGameState>(); } set { this["TakedownGameState"] = value; } }
        public int RespawnChangePerKill { get { return this[nameof(RespawnChangePerKill)].GetValue<int>(); } set { this[nameof(RespawnChangePerKill)].SetValue<int>(value); } }
        public int RespawnChangePerDeath { get { return this[nameof(RespawnChangePerDeath)].GetValue<int>(); } set { this[nameof(RespawnChangePerDeath)].SetValue<int>(value); } }
        public int MinRespawnTime { get { return this[nameof(MinRespawnTime)].GetValue<int>(); } set { this[nameof(MinRespawnTime)].SetValue<int>(value); } }
        public int MaxRespawnTime { get { return this[nameof(MaxRespawnTime)].GetValue<int>(); } set { this[nameof(MaxRespawnTime)].SetValue<int>(value); } }
        public int FinalKillScore { get { return this[nameof(FinalKillScore)].GetValue<int>(); } set { this[nameof(FinalKillScore)].SetValue<int>(value); } }
    }
    public class PortalWarsShowdown : PortalWarsTakedown
    {
        public PortalWarsShowdown(ulong addr) : base(addr) { }
    }
    public class PortalWarsTakedownGameState : PortalWarsRoundGameState
    {
        public PortalWarsTakedownGameState(ulong addr) : base(addr) { }
    }
    public class PortalWarsShowdownGameState : PortalWarsTakedownGameState
    {
        public PortalWarsShowdownGameState(ulong addr) : base(addr) { }
    }
    public class PortalWarsSocialInviteWidget : PortalWarsMenuWidget
    {
        public PortalWarsSocialInviteWidget(ulong addr) : base(addr) { }
    }
    public class PortalWarsSocialPlayerEntry : PortalWarsPlayerEntryWidget
    {
        public PortalWarsSocialPlayerEntry(ulong addr) : base(addr) { }
        public WidgetSwitcher OnlineSwitcher { get { return this[nameof(OnlineSwitcher)].As<WidgetSwitcher>(); } set { this["OnlineSwitcher"] = value; } }
    }
    public class PortalWarsSpinSliderWidget : PortalWarsInputWidget
    {
        public PortalWarsSpinSliderWidget(ulong addr) : base(addr) { }
        public SpinBox InputBox { get { return this[nameof(InputBox)].As<SpinBox>(); } set { this["InputBox"] = value; } }
        public Slider InputSlider { get { return this[nameof(InputSlider)].As<Slider>(); } set { this["InputSlider"] = value; } }
        public ProgressBar BackgroundFillBar { get { return this[nameof(BackgroundFillBar)].As<ProgressBar>(); } set { this["BackgroundFillBar"] = value; } }
        public float MinValue { get { return this[nameof(MinValue)].GetValue<float>(); } set { this[nameof(MinValue)].SetValue<float>(value); } }
        public float MaxValue { get { return this[nameof(MaxValue)].GetValue<float>(); } set { this[nameof(MaxValue)].SetValue<float>(value); } }
        public float ValueMultiplier { get { return this[nameof(ValueMultiplier)].GetValue<float>(); } set { this[nameof(ValueMultiplier)].SetValue<float>(value); } }
        public float StepSize { get { return this[nameof(StepSize)].GetValue<float>(); } set { this[nameof(StepSize)].SetValue<float>(value); } }
        public int MaxFractionalDigits { get { return this[nameof(MaxFractionalDigits)].GetValue<int>(); } set { this[nameof(MaxFractionalDigits)].SetValue<int>(value); } }
        public bool bCommitValueOnScrub { get { return this[nameof(bCommitValueOnScrub)].Flag; } set { this[nameof(bCommitValueOnScrub)].Flag = value; } }
        public LinearColor SliderDefaultColor { get { return this[nameof(SliderDefaultColor)].As<LinearColor>(); } set { this["SliderDefaultColor"] = value; } }
        public LinearColor SliderHoveredColor { get { return this[nameof(SliderHoveredColor)].As<LinearColor>(); } set { this["SliderHoveredColor"] = value; } }
        public Texture2D SpinDefaultBackgroundImage { get { return this[nameof(SpinDefaultBackgroundImage)].As<Texture2D>(); } set { this["SpinDefaultBackgroundImage"] = value; } }
        public Texture2D SpinHoveredBackgroundImage { get { return this[nameof(SpinHoveredBackgroundImage)].As<Texture2D>(); } set { this["SpinHoveredBackgroundImage"] = value; } }
        public void OnInputSliderValueChanged(float NewValue) { Invoke(nameof(OnInputSliderValueChanged), NewValue); }
        public void OnInputBoxValueCommitted(float NewValue, byte CommitType) { Invoke(nameof(OnInputBoxValueCommitted), NewValue, CommitType); }
        public void OnInputBoxValueChanged(float NewValue) { Invoke(nameof(OnInputBoxValueChanged), NewValue); }
    }
    public class PortalWarsSplineRoad : Actor
    {
        public PortalWarsSplineRoad(ulong addr) : base(addr) { }
        public void EditorInit() { Invoke(nameof(EditorInit)); }
    }
    public class PortalWarsStatsEntryWidget : PortalWarsUserWidget
    {
        public PortalWarsStatsEntryWidget(ulong addr) : base(addr) { }
        public TextBlock GamesWonText { get { return this[nameof(GamesWonText)].As<TextBlock>(); } set { this["GamesWonText"] = value; } }
        public TextBlock GamesPlayedText { get { return this[nameof(GamesPlayedText)].As<TextBlock>(); } set { this["GamesPlayedText"] = value; } }
        public TextBlock KillsText { get { return this[nameof(KillsText)].As<TextBlock>(); } set { this["KillsText"] = value; } }
        public TextBlock AssistsText { get { return this[nameof(AssistsText)].As<TextBlock>(); } set { this["AssistsText"] = value; } }
        public TextBlock DeathsText { get { return this[nameof(DeathsText)].As<TextBlock>(); } set { this["DeathsText"] = value; } }
        public TextBlock KdText { get { return this[nameof(KdText)].As<TextBlock>(); } set { this["KdText"] = value; } }
        public TextBlock KadText { get { return this[nameof(KadText)].As<TextBlock>(); } set { this["KadText"] = value; } }
        public TextBlock SuicidesText { get { return this[nameof(SuicidesText)].As<TextBlock>(); } set { this["SuicidesText"] = value; } }
        public TextBlock TeabagsText { get { return this[nameof(TeabagsText)].As<TextBlock>(); } set { this["TeabagsText"] = value; } }
        public TextBlock MeleeKillsText { get { return this[nameof(MeleeKillsText)].As<TextBlock>(); } set { this["MeleeKillsText"] = value; } }
        public TextBlock PortalKillsText { get { return this[nameof(PortalKillsText)].As<TextBlock>(); } set { this["PortalKillsText"] = value; } }
        public TextBlock KillsThruPortalText { get { return this[nameof(KillsThruPortalText)].As<TextBlock>(); } set { this["KillsThruPortalText"] = value; } }
        public TextBlock DoubleKillsText { get { return this[nameof(DoubleKillsText)].As<TextBlock>(); } set { this["DoubleKillsText"] = value; } }
        public TextBlock TripleKillsText { get { return this[nameof(TripleKillsText)].As<TextBlock>(); } set { this["TripleKillsText"] = value; } }
        public TextBlock QuadKillsText { get { return this[nameof(QuadKillsText)].As<TextBlock>(); } set { this["QuadKillsText"] = value; } }
        public TextBlock QuintKillsText { get { return this[nameof(QuintKillsText)].As<TextBlock>(); } set { this["QuintKillsText"] = value; } }
        public TextBlock KillStreak1Text { get { return this[nameof(KillStreak1Text)].As<TextBlock>(); } set { this["KillStreak1Text"] = value; } }
        public TextBlock KillStreak2Text { get { return this[nameof(KillStreak2Text)].As<TextBlock>(); } set { this["KillStreak2Text"] = value; } }
        public TextBlock KillStreak3Text { get { return this[nameof(KillStreak3Text)].As<TextBlock>(); } set { this["KillStreak3Text"] = value; } }
        public TextBlock KillStreak4Text { get { return this[nameof(KillStreak4Text)].As<TextBlock>(); } set { this["KillStreak4Text"] = value; } }
        public TextBlock KillStreak5Text { get { return this[nameof(KillStreak5Text)].As<TextBlock>(); } set { this["KillStreak5Text"] = value; } }
        public TextBlock KillStreak6Text { get { return this[nameof(KillStreak6Text)].As<TextBlock>(); } set { this["KillStreak6Text"] = value; } }
        public TextBlock DamageDealtText { get { return this[nameof(DamageDealtText)].As<TextBlock>(); } set { this["DamageDealtText"] = value; } }
        public bool bUseGoldStyle { get { return this[nameof(bUseGoldStyle)].Flag; } set { this[nameof(bUseGoldStyle)].Flag = value; } }
        public Image BackgroundImage { get { return this[nameof(BackgroundImage)].As<Image>(); } set { this["BackgroundImage"] = value; } }
        public Texture2D DefaultBackgroundImage { get { return this[nameof(DefaultBackgroundImage)].As<Texture2D>(); } set { this["DefaultBackgroundImage"] = value; } }
        public Texture2D GoldBackgroundImage { get { return this[nameof(GoldBackgroundImage)].As<Texture2D>(); } set { this["GoldBackgroundImage"] = value; } }
        public LinearColor DefaultFeatureTextColor { get { return this[nameof(DefaultFeatureTextColor)].As<LinearColor>(); } set { this["DefaultFeatureTextColor"] = value; } }
        public LinearColor GoldFeatureTextColor { get { return this[nameof(GoldFeatureTextColor)].As<LinearColor>(); } set { this["GoldFeatureTextColor"] = value; } }
        public LinearColor DefaultTitleTextColor { get { return this[nameof(DefaultTitleTextColor)].As<LinearColor>(); } set { this["DefaultTitleTextColor"] = value; } }
        public LinearColor GoldTitleTextColor { get { return this[nameof(GoldTitleTextColor)].As<LinearColor>(); } set { this["GoldTitleTextColor"] = value; } }
        public LinearColor DefaultSmallTitleTextColor { get { return this[nameof(DefaultSmallTitleTextColor)].As<LinearColor>(); } set { this["DefaultSmallTitleTextColor"] = value; } }
        public LinearColor GoldSmallTitleTextColor { get { return this[nameof(GoldSmallTitleTextColor)].As<LinearColor>(); } set { this["GoldSmallTitleTextColor"] = value; } }
        public Object GetTripleKillsText() { return Invoke<Object>(nameof(GetTripleKillsText)); }
        public Object GetTeabagsText() { return Invoke<Object>(nameof(GetTeabagsText)); }
        public Object GetSuicidesText() { return Invoke<Object>(nameof(GetSuicidesText)); }
        public Object GetQuintKillsText() { return Invoke<Object>(nameof(GetQuintKillsText)); }
        public Object GetQuadKillsText() { return Invoke<Object>(nameof(GetQuadKillsText)); }
        public Object GetPortalKillsText() { return Invoke<Object>(nameof(GetPortalKillsText)); }
        public Object GetMeleeKillsText() { return Invoke<Object>(nameof(GetMeleeKillsText)); }
        public Object GetKillStreak6Text() { return Invoke<Object>(nameof(GetKillStreak6Text)); }
        public Object GetKillStreak5Text() { return Invoke<Object>(nameof(GetKillStreak5Text)); }
        public Object GetKillStreak4Text() { return Invoke<Object>(nameof(GetKillStreak4Text)); }
        public Object GetKillStreak3Text() { return Invoke<Object>(nameof(GetKillStreak3Text)); }
        public Object GetKillStreak2Text() { return Invoke<Object>(nameof(GetKillStreak2Text)); }
        public Object GetKillStreak1Text() { return Invoke<Object>(nameof(GetKillStreak1Text)); }
        public Object GetKillsThruPortalText() { return Invoke<Object>(nameof(GetKillsThruPortalText)); }
        public Object GetKillsText() { return Invoke<Object>(nameof(GetKillsText)); }
        public Object GetKdText() { return Invoke<Object>(nameof(GetKdText)); }
        public Object GetKadText() { return Invoke<Object>(nameof(GetKadText)); }
        public Object GetGamesWonText() { return Invoke<Object>(nameof(GetGamesWonText)); }
        public Object GetGamesPlayedText() { return Invoke<Object>(nameof(GetGamesPlayedText)); }
        public Object GetDoubleKillsText() { return Invoke<Object>(nameof(GetDoubleKillsText)); }
        public Object GetDeathsText() { return Invoke<Object>(nameof(GetDeathsText)); }
        public Object GetDamageDealtText() { return Invoke<Object>(nameof(GetDamageDealtText)); }
        public Object GetAssistsText() { return Invoke<Object>(nameof(GetAssistsText)); }
    }
    public class PortalWarsStatsOverviewWidget : PortalWarsMenuWidget
    {
        public PortalWarsStatsOverviewWidget(ulong addr) : base(addr) { }
        public PortalWarsCareerProgressWidget CareerProgress { get { return this[nameof(CareerProgress)].As<PortalWarsCareerProgressWidget>(); } set { this["CareerProgress"] = value; } }
        public PortalWarsStatsEntryWidget TotalStats { get { return this[nameof(TotalStats)].As<PortalWarsStatsEntryWidget>(); } set { this["TotalStats"] = value; } }
        public PortalWarsStatsEntryWidget SeasonStats { get { return this[nameof(SeasonStats)].As<PortalWarsStatsEntryWidget>(); } set { this["SeasonStats"] = value; } }
        public TextBlock SeasonText { get { return this[nameof(SeasonText)].As<TextBlock>(); } set { this["SeasonText"] = value; } }
        public PortalWarsButtonWidget ChangeSeasonButton { get { return this[nameof(ChangeSeasonButton)].As<PortalWarsButtonWidget>(); } set { this["ChangeSeasonButton"] = value; } }
        public ComboBoxString SeasonComboBox { get { return this[nameof(SeasonComboBox)].As<ComboBoxString>(); } set { this["SeasonComboBox"] = value; } }
        public void OnUserInfoUpdate() { Invoke(nameof(OnUserInfoUpdate)); }
        public void OnSeasonSelectionChanged(Object SelectedItem, byte SelectionType) { Invoke(nameof(OnSeasonSelectionChanged), SelectedItem, SelectionType); }
        public void OnChangeSeasonClicked() { Invoke(nameof(OnChangeSeasonClicked)); }
        public Object GetSeasonText() { return Invoke<Object>(nameof(GetSeasonText)); }
    }
    public class PortalWarsStatsPlaylistWidget : PortalWarsMenuWidget
    {
        public PortalWarsStatsPlaylistWidget(ulong addr) : base(addr) { }
        public PortalWarsStatsEntryWidget TotalStats { get { return this[nameof(TotalStats)].As<PortalWarsStatsEntryWidget>(); } set { this["TotalStats"] = value; } }
        public TextBlock PlayerNameText { get { return this[nameof(PlayerNameText)].As<TextBlock>(); } set { this["PlayerNameText"] = value; } }
        public Image AvatarImage { get { return this[nameof(AvatarImage)].As<Image>(); } set { this["AvatarImage"] = value; } }
        public TextBlock RankNameText { get { return this[nameof(RankNameText)].As<TextBlock>(); } set { this["RankNameText"] = value; } }
        public Image RankIcon { get { return this[nameof(RankIcon)].As<Image>(); } set { this["RankIcon"] = value; } }
        public TextBlock RankXPText { get { return this[nameof(RankXPText)].As<TextBlock>(); } set { this["RankXPText"] = value; } }
        public Widget RankRoot { get { return this[nameof(RankRoot)].As<Widget>(); } set { this["RankRoot"] = value; } }
        public TextBlock PlaylistText { get { return this[nameof(PlaylistText)].As<TextBlock>(); } set { this["PlaylistText"] = value; } }
        public PortalWarsButtonWidget ChangePlaylistButton { get { return this[nameof(ChangePlaylistButton)].As<PortalWarsButtonWidget>(); } set { this["ChangePlaylistButton"] = value; } }
        public ComboBoxString PlaylistComboBox { get { return this[nameof(PlaylistComboBox)].As<ComboBoxString>(); } set { this["PlaylistComboBox"] = value; } }
        public Array<int> PlaylistIDs { get { return new Array<int>(this[nameof(PlaylistIDs)].Address); } }
        public void SetAvatar(Texture2D InAvatar) { Invoke(nameof(SetAvatar), InAvatar); }
        public void OnUserInfoUpdate() { Invoke(nameof(OnUserInfoUpdate)); }
        public void OnPlaylistSelectionChanged(Object SelectedItem, byte SelectionType) { Invoke(nameof(OnPlaylistSelectionChanged), SelectedItem, SelectionType); }
        public void OnChangePlaylistClicked() { Invoke(nameof(OnChangePlaylistClicked)); }
        public Object GetSelectedPlaylistText() { return Invoke<Object>(nameof(GetSelectedPlaylistText)); }
        public Object GetRankXP() { return Invoke<Object>(nameof(GetRankXP)); }
        public Object GetRankName() { return Invoke<Object>(nameof(GetRankName)); }
        public ESlateVisibility GetRankedVisibility() { return Invoke<ESlateVisibility>(nameof(GetRankedVisibility)); }
    }
    public class PortalWarsStatsWidget : PortalWarsMenuWidget
    {
        public PortalWarsStatsWidget(ulong addr) : base(addr) { }
        public PortalWarsMenuWidget OverviewWidget { get { return this[nameof(OverviewWidget)].As<PortalWarsMenuWidget>(); } set { this["OverviewWidget"] = value; } }
        public PortalWarsMenuWidget SocialWidget { get { return this[nameof(SocialWidget)].As<PortalWarsMenuWidget>(); } set { this["SocialWidget"] = value; } }
        public PortalWarsMenuWidget RankedWidget { get { return this[nameof(RankedWidget)].As<PortalWarsMenuWidget>(); } set { this["RankedWidget"] = value; } }
    }
    public class PortalWarsStreakIncreaseWidget : PortalWarsDialogWidget
    {
        public PortalWarsStreakIncreaseWidget(ulong addr) : base(addr) { }
        public PortalWarsPlayStreakRewardWidget RewardEntry { get { return this[nameof(RewardEntry)].As<PortalWarsPlayStreakRewardWidget>(); } set { this["RewardEntry"] = value; } }
        public Widget RepairRoot { get { return this[nameof(RepairRoot)].As<Widget>(); } set { this["RepairRoot"] = value; } }
        public TextBlock RepairStreakText { get { return this[nameof(RepairStreakText)].As<TextBlock>(); } set { this["RepairStreakText"] = value; } }
        public PortalWarsRedeemableButtonWidget RepairButton { get { return this[nameof(RepairButton)].As<PortalWarsRedeemableButtonWidget>(); } set { this["RepairButton"] = value; } }
        public Object PlayStreakDialogWidgetClass { get { return this[nameof(PlayStreakDialogWidgetClass)]; } set { this[nameof(PlayStreakDialogWidgetClass)] = value; } }
        public AkAudioEvent StreakIncreasedEvent { get { return this[nameof(StreakIncreasedEvent)].As<AkAudioEvent>(); } set { this["StreakIncreasedEvent"] = value; } }
        public void PlayStreakIncreasedSound() { Invoke(nameof(PlayStreakIncreasedSound)); }
        public void OnRepairButtonClicked() { Invoke(nameof(OnRepairButtonClicked)); }
        public ESlateVisibility GetRepairVisibility() { return Invoke<ESlateVisibility>(nameof(GetRepairVisibility)); }
        public Object GetRepairStreakText() { return Invoke<Object>(nameof(GetRepairStreakText)); }
    }
    public class PortalWarsSuicideDmgType : PortalWarsDamageType
    {
        public PortalWarsSuicideDmgType(ulong addr) : base(addr) { }
    }
    public class PortalWarsTakedownHUD : PortalWarsRoundHUD
    {
        public PortalWarsTakedownHUD(ulong addr) : base(addr) { }
        public PortalWarsTakedownHUDOverlayWidget TakedownHUDOverlayWidget { get { return this[nameof(TakedownHUDOverlayWidget)].As<PortalWarsTakedownHUDOverlayWidget>(); } set { this["TakedownHUDOverlayWidget"] = value; } }
    }
    public class PortalWarsTakedownHUDOverlayWidget : PortalWarsRoundHUDOverlayWidget
    {
        public PortalWarsTakedownHUDOverlayWidget(ulong addr) : base(addr) { }
        public PortalWarsTakedownNotificationWidget TakedownNotification { get { return this[nameof(TakedownNotification)].As<PortalWarsTakedownNotificationWidget>(); } set { this["TakedownNotification"] = value; } }
    }
    public class PortalWarsTakedownNotificationWidget : UserWidget
    {
        public PortalWarsTakedownNotificationWidget(ulong addr) : base(addr) { }
        public Image TeamImage { get { return this[nameof(TeamImage)].As<Image>(); } set { this["TeamImage"] = value; } }
        public HorizontalBox RootHorizontalBox { get { return this[nameof(RootHorizontalBox)].As<HorizontalBox>(); } set { this["RootHorizontalBox"] = value; } }
        public TextBlock NotificationText { get { return this[nameof(NotificationText)].As<TextBlock>(); } set { this["NotificationText"] = value; } }
        public TextBlock TimeText { get { return this[nameof(TimeText)].As<TextBlock>(); } set { this["TimeText"] = value; } }
        public TextBlock OneOnOneTimeText { get { return this[nameof(OneOnOneTimeText)].As<TextBlock>(); } set { this["OneOnOneTimeText"] = value; } }
        public WidgetSwitcher TimeWidgetSwitcher { get { return this[nameof(TimeWidgetSwitcher)].As<WidgetSwitcher>(); } set { this["TimeWidgetSwitcher"] = value; } }
        public WidgetAnimation FadeOutAnimation { get { return this[nameof(FadeOutAnimation)].As<WidgetAnimation>(); } set { this["FadeOutAnimation"] = value; } }
        public Texture2D BlueLastManStanding { get { return this[nameof(BlueLastManStanding)].As<Texture2D>(); } set { this["BlueLastManStanding"] = value; } }
        public Texture2D RedLastManStanding { get { return this[nameof(RedLastManStanding)].As<Texture2D>(); } set { this["RedLastManStanding"] = value; } }
        public Texture2D BothLastManStanding { get { return this[nameof(BothLastManStanding)].As<Texture2D>(); } set { this["BothLastManStanding"] = value; } }
    }
    public class PortalWarsTakedownPlayerState : PortalWarsPlayerState
    {
        public PortalWarsTakedownPlayerState(ulong addr) : base(addr) { }
        public byte RespawnTime { get { return this[nameof(RespawnTime)].GetValue<byte>(); } set { this[nameof(RespawnTime)].SetValue<byte>(value); } }
        public void OnRep_RespawnTime() { Invoke(nameof(OnRep_RespawnTime)); }
    }
    public class PortalWarsTakedownPlayerStatusWidget : PortalWarsRoundPlayerStatusWidget
    {
        public PortalWarsTakedownPlayerStatusWidget(ulong addr) : base(addr) { }
        public TextBlock RespawnTimeText { get { return this[nameof(RespawnTimeText)].As<TextBlock>(); } set { this["RespawnTimeText"] = value; } }
    }
    public class PortalWarsTakedownVIP : PortalWarsTakedown
    {
        public PortalWarsTakedownVIP(ulong addr) : base(addr) { }
        public Array<Object> VIPDefaultInventoryClasses { get { return new Array<Object>(this[nameof(VIPDefaultInventoryClasses)].Address); } }
        public PortalWarsTakedownVIPGameState TakedownVIPGameState { get { return this[nameof(TakedownVIPGameState)].As<PortalWarsTakedownVIPGameState>(); } set { this["TakedownVIPGameState"] = value; } }
        public int VIPKillScore { get { return this[nameof(VIPKillScore)].GetValue<int>(); } set { this[nameof(VIPKillScore)].SetValue<int>(value); } }
    }
    public class PortalWarsTakedownVIPGameState : PortalWarsTakedownGameState
    {
        public PortalWarsTakedownVIPGameState(ulong addr) : base(addr) { }
        public PortalWarsPlayerState SurvivingVIP { get { return this[nameof(SurvivingVIP)].As<PortalWarsPlayerState>(); } set { this["SurvivingVIP"] = value; } }
        public Object VIPs { get { return this[nameof(VIPs)]; } set { this[nameof(VIPs)] = value; } }
    }
    public class PortalWarsTakedownVIPHUD : PortalWarsTakedownHUD
    {
        public PortalWarsTakedownVIPHUD(ulong addr) : base(addr) { }
        public PortalWarsVIPHUDOverlayWidget VIPHUDOverlayWidget { get { return this[nameof(VIPHUDOverlayWidget)].As<PortalWarsVIPHUDOverlayWidget>(); } set { this["VIPHUDOverlayWidget"] = value; } }
        public Object VIPHUDOverlayWidgetClass { get { return this[nameof(VIPHUDOverlayWidgetClass)]; } set { this[nameof(VIPHUDOverlayWidgetClass)] = value; } }
        public Object VIPNameIndicatorWidgetClass { get { return this[nameof(VIPNameIndicatorWidgetClass)]; } set { this[nameof(VIPNameIndicatorWidgetClass)] = value; } }
        public AkAudioEvent VipAlertEvent { get { return this[nameof(VipAlertEvent)].As<AkAudioEvent>(); } set { this["VipAlertEvent"] = value; } }
    }
    public class PortalWarsTakedownVIPPlayerState : PortalWarsTakedownPlayerState
    {
        public PortalWarsTakedownVIPPlayerState(ulong addr) : base(addr) { }
        public bool bIsVIP { get { return this[nameof(bIsVIP)].Flag; } set { this[nameof(bIsVIP)].Flag = value; } }
        public void OnRep_IsVIP() { Invoke(nameof(OnRep_IsVIP)); }
    }
    public class PortalWarsTakedownVIPPlayerStatusWidget : PortalWarsTakedownPlayerStatusWidget
    {
        public PortalWarsTakedownVIPPlayerStatusWidget(ulong addr) : base(addr) { }
        public Image VIPImage { get { return this[nameof(VIPImage)].As<Image>(); } set { this["VIPImage"] = value; } }
    }
    public class PortalWarsTeabagConfirmed : PortalWarsGameMode
    {
        public PortalWarsTeabagConfirmed(ulong addr) : base(addr) { }
        public Object TeabagZoneClass { get { return this[nameof(TeabagZoneClass)]; } set { this[nameof(TeabagZoneClass)] = value; } }
    }
    public class PortalWarsTeabagZone : Actor
    {
        public PortalWarsTeabagZone(ulong addr) : base(addr) { }
        public PlayerState KilledPlayerState { get { return this[nameof(KilledPlayerState)].As<PlayerState>(); } set { this["KilledPlayerState"] = value; } }
        public PortalWarsCharacter KilledCharacter { get { return this[nameof(KilledCharacter)].As<PortalWarsCharacter>(); } set { this["KilledCharacter"] = value; } }
        public StaticMeshComponent TeabagMesh { get { return this[nameof(TeabagMesh)].As<StaticMeshComponent>(); } set { this["TeabagMesh"] = value; } }
        public void OnRep_PlayerState() { Invoke(nameof(OnRep_PlayerState)); }
        public void ChangeMeshColor() { Invoke(nameof(ChangeMeshColor)); }
    }
    public class PortalWarsTeamSelectWidget : PortalWarsInputCarouselWidget
    {
        public PortalWarsTeamSelectWidget(ulong addr) : base(addr) { }
        public int Value { get { return this[nameof(Value)].GetValue<int>(); } set { this[nameof(Value)].SetValue<int>(value); } }
        public Object OnTeamChangedDelegate { get { return this[nameof(OnTeamChangedDelegate)]; } set { this[nameof(OnTeamChangedDelegate)] = value; } }
    }
    public class PortalWarsTeamStart : PlayerStart
    {
        public PortalWarsTeamStart(ulong addr) : base(addr) { }
        public int SpawnTeam { get { return this[nameof(SpawnTeam)].GetValue<int>(); } set { this[nameof(SpawnTeam)].SetValue<int>(value); } }
        public bool bNotForPlayers { get { return this[nameof(bNotForPlayers)].Flag; } set { this[nameof(bNotForPlayers)].Flag = value; } }
        public bool bNotForBots { get { return this[nameof(bNotForBots)].Flag; } set { this[nameof(bNotForBots)].Flag = value; } }
        public bool bInitialSpawn { get { return this[nameof(bInitialSpawn)].Flag; } set { this[nameof(bInitialSpawn)].Flag = value; } }
    }
    public class PortalWarsTextCarouselWidget : PortalWarsInputCarouselWidget
    {
        public PortalWarsTextCarouselWidget(ulong addr) : base(addr) { }
    }
    public class PortalWarsTextInputWidget : PortalWarsInputWidget
    {
        public PortalWarsTextInputWidget(ulong addr) : base(addr) { }
        public EditableTextBox TextBox { get { return this[nameof(TextBox)].As<EditableTextBox>(); } set { this["TextBox"] = value; } }
        public MultiLineEditableTextBox MultiLineTextBox { get { return this[nameof(MultiLineTextBox)].As<MultiLineEditableTextBox>(); } set { this["MultiLineTextBox"] = value; } }
        public Object HintText { get { return this[nameof(HintText)]; } set { this[nameof(HintText)] = value; } }
        public bool bIsPassword { get { return this[nameof(bIsPassword)].Flag; } set { this[nameof(bIsPassword)].Flag = value; } }
        public int MaxTextLength { get { return this[nameof(MaxTextLength)].GetValue<int>(); } set { this[nameof(MaxTextLength)].SetValue<int>(value); } }
        public void OnTextChanged(Object newText) { Invoke(nameof(OnTextChanged), newText); }
    }
    public class PortalWarsTrainingWidget : PortalWarsMenuWidget
    {
        public PortalWarsTrainingWidget(ulong addr) : base(addr) { }
        public PortalWarsButtonWidget TutorialButton { get { return this[nameof(TutorialButton)].As<PortalWarsButtonWidget>(); } set { this["TutorialButton"] = value; } }
        public PortalWarsButtonWidget RaceButton { get { return this[nameof(RaceButton)].As<PortalWarsButtonWidget>(); } set { this["RaceButton"] = value; } }
        public PortalWarsButtonWidget RangeButton { get { return this[nameof(RangeButton)].As<PortalWarsButtonWidget>(); } set { this["RangeButton"] = value; } }
        public void OnTutorialButtonClicked() { Invoke(nameof(OnTutorialButtonClicked)); }
        public void OnRangeButtonClicked() { Invoke(nameof(OnRangeButtonClicked)); }
        public void OnRaceButtonClicked() { Invoke(nameof(OnRaceButtonClicked)); }
    }
    public class PortalWarsTutorialBookmarkWidget : UserWidget
    {
        public PortalWarsTutorialBookmarkWidget(ulong addr) : base(addr) { }
        public HorizontalBox MarksHorizontalBox { get { return this[nameof(MarksHorizontalBox)].As<HorizontalBox>(); } set { this["MarksHorizontalBox"] = value; } }
        public Texture2D CurrentMarkTexture { get { return this[nameof(CurrentMarkTexture)].As<Texture2D>(); } set { this["CurrentMarkTexture"] = value; } }
        public Texture2D IncompleteMarkTexture { get { return this[nameof(IncompleteMarkTexture)].As<Texture2D>(); } set { this["IncompleteMarkTexture"] = value; } }
        public Texture2D CompleteMarkTexture { get { return this[nameof(CompleteMarkTexture)].As<Texture2D>(); } set { this["CompleteMarkTexture"] = value; } }
    }
    public class PortalWarsTutorialCharacter : PortalWarsCharacter
    {
        public PortalWarsTutorialCharacter(ulong addr) : base(addr) { }
        public int StageID { get { return this[nameof(StageID)].GetValue<int>(); } set { this[nameof(StageID)].SetValue<int>(value); } }
        public int GoalID { get { return this[nameof(GoalID)].GetValue<int>(); } set { this[nameof(GoalID)].SetValue<int>(value); } }
        public Array<PortalWarsTutorialGoal> Goals { get { return new Array<PortalWarsTutorialGoal>(this[nameof(Goals)].Address); } }
        public int HiddenUntilGoal { get { return this[nameof(HiddenUntilGoal)].GetValue<int>(); } set { this[nameof(HiddenUntilGoal)].SetValue<int>(value); } }
        public Array<PortalWall> PortalWalls { get { return new Array<PortalWall>(this[nameof(PortalWalls)].Address); } }
    }
    public class PortalWarsTutorialGameMode : PortalWarsGameMode
    {
        public PortalWarsTutorialGameMode(ulong addr) : base(addr) { }
        public Array<DefaultInventoryClass> TutorialDefaultInventoryClasses { get { return new Array<DefaultInventoryClass>(this[nameof(TutorialDefaultInventoryClasses)].Address); } }
    }
    public class PortalWarsTutorialGoal : Actor
    {
        public PortalWarsTutorialGoal(ulong addr) : base(addr) { }
        public int StageID { get { return this[nameof(StageID)].GetValue<int>(); } set { this[nameof(StageID)].SetValue<int>(value); } }
        public int GoalID { get { return this[nameof(GoalID)].GetValue<int>(); } set { this[nameof(GoalID)].SetValue<int>(value); } }
        public bool bIsLastGoal { get { return this[nameof(bIsLastGoal)].Flag; } set { this[nameof(bIsLastGoal)].Flag = value; } }
        public bool bCompleteLinkedGoal { get { return this[nameof(bCompleteLinkedGoal)].Flag; } set { this[nameof(bCompleteLinkedGoal)].Flag = value; } }
        public bool bIsGlobal { get { return this[nameof(bIsGlobal)].Flag; } set { this[nameof(bIsGlobal)].Flag = value; } }
        public EGoalType GoalType { get { return (EGoalType)this[nameof(GoalType)].GetValue<int>(); } set { this[nameof(GoalType)].SetValue<int>((int)value); } }
        public SphereComponent OverlapComp { get { return this[nameof(OverlapComp)].As<SphereComponent>(); } set { this["OverlapComp"] = value; } }
        public bool bHideEffects { get { return this[nameof(bHideEffects)].Flag; } set { this[nameof(bHideEffects)].Flag = value; } }
        public SceneComponent EffectRootComp { get { return this[nameof(EffectRootComp)].As<SceneComponent>(); } set { this["EffectRootComp"] = value; } }
        public ParticleSystemComponent ParticleComp { get { return this[nameof(ParticleComp)].As<ParticleSystemComponent>(); } set { this["ParticleComp"] = value; } }
        public StaticMeshComponent RingMesh1 { get { return this[nameof(RingMesh1)].As<StaticMeshComponent>(); } set { this["RingMesh1"] = value; } }
        public StaticMeshComponent RingMesh2 { get { return this[nameof(RingMesh2)].As<StaticMeshComponent>(); } set { this["RingMesh2"] = value; } }
        public StaticMeshComponent RingMesh3 { get { return this[nameof(RingMesh3)].As<StaticMeshComponent>(); } set { this["RingMesh3"] = value; } }
        public StaticMeshComponent RingMesh4 { get { return this[nameof(RingMesh4)].As<StaticMeshComponent>(); } set { this["RingMesh4"] = value; } }
        public SpotLightComponent SpotLightComp { get { return this[nameof(SpotLightComp)].As<SpotLightComponent>(); } set { this["SpotLightComp"] = value; } }
        public Array<StaticMeshActor> Blocks { get { return new Array<StaticMeshActor>(this[nameof(Blocks)].Address); } }
        public MaterialInstance SuccessMaterialRings { get { return this[nameof(SuccessMaterialRings)].As<MaterialInstance>(); } set { this["SuccessMaterialRings"] = value; } }
        public MaterialInstance SuccessMaterialBlocks { get { return this[nameof(SuccessMaterialBlocks)].As<MaterialInstance>(); } set { this["SuccessMaterialBlocks"] = value; } }
        public ParticleSystem SuccessParticleSystem { get { return this[nameof(SuccessParticleSystem)].As<ParticleSystem>(); } set { this["SuccessParticleSystem"] = value; } }
        public Color SuccessLightColor { get { return this[nameof(SuccessLightColor)].As<Color>(); } set { this["SuccessLightColor"] = value; } }
        public MaterialInstance DefaultMaterialBlocks { get { return this[nameof(DefaultMaterialBlocks)].As<MaterialInstance>(); } set { this["DefaultMaterialBlocks"] = value; } }
        public MaterialInstance DefaultMaterialBlocksGlow { get { return this[nameof(DefaultMaterialBlocksGlow)].As<MaterialInstance>(); } set { this["DefaultMaterialBlocksGlow"] = value; } }
        public MaterialInstance DefaultMaterialBlocksFloor { get { return this[nameof(DefaultMaterialBlocksFloor)].As<MaterialInstance>(); } set { this["DefaultMaterialBlocksFloor"] = value; } }
        public PortalWarsAkComponent AkComp { get { return this[nameof(AkComp)].As<PortalWarsAkComponent>(); } set { this["AkComp"] = value; } }
        public AkAudioEvent SuccessEvent { get { return this[nameof(SuccessEvent)].As<AkAudioEvent>(); } set { this["SuccessEvent"] = value; } }
        public AkAudioEvent StartAmbientLoopEvent { get { return this[nameof(StartAmbientLoopEvent)].As<AkAudioEvent>(); } set { this["StartAmbientLoopEvent"] = value; } }
        public AkAudioEvent StopAmbientLoopEvent { get { return this[nameof(StopAmbientLoopEvent)].As<AkAudioEvent>(); } set { this["StopAmbientLoopEvent"] = value; } }
        public void OnOverlap(PrimitiveComponent OverlappedComponent, Actor OtherActor, PrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, HitResult SweepResult) { Invoke(nameof(OnOverlap), OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult); }
    }
    public class PortalWarsTutorialHUD : PortalWarsHUD
    {
        public PortalWarsTutorialHUD(ulong addr) : base(addr) { }
        public PWTutorialHUDOverlayWidget TutorialHUDOverlayWidget { get { return this[nameof(TutorialHUDOverlayWidget)].As<PWTutorialHUDOverlayWidget>(); } set { this["TutorialHUDOverlayWidget"] = value; } }
        public Object TutorialHUDOverlayWidgetClass { get { return this[nameof(TutorialHUDOverlayWidgetClass)]; } set { this[nameof(TutorialHUDOverlayWidgetClass)] = value; } }
        public Object GoalIndicatorWidgetClass { get { return this[nameof(GoalIndicatorWidgetClass)]; } set { this[nameof(GoalIndicatorWidgetClass)] = value; } }
    }
    public class PortalWarsTutorialStepsWidget : UserWidget
    {
        public PortalWarsTutorialStepsWidget(ulong addr) : base(addr) { }
        public Array<PWTutorialStepEntryWidget> StepWidgets { get { return new Array<PWTutorialStepEntryWidget>(this[nameof(StepWidgets)].Address); } }
        public PanelWidget CurrentStepPanel { get { return this[nameof(CurrentStepPanel)].As<PanelWidget>(); } set { this["CurrentStepPanel"] = value; } }
        public PanelWidget CompletedStepPanel { get { return this[nameof(CompletedStepPanel)].As<PanelWidget>(); } set { this["CompletedStepPanel"] = value; } }
        public Widget CompletedIndicator { get { return this[nameof(CompletedIndicator)].As<Widget>(); } set { this["CompletedIndicator"] = value; } }
        public Object StepEntryWidgetClass { get { return this[nameof(StepEntryWidgetClass)]; } set { this[nameof(StepEntryWidgetClass)] = value; } }
    }
    public class PortalWarsTutorialVideoReminderWidget : PortalWarsUserWidget
    {
        public PortalWarsTutorialVideoReminderWidget(ulong addr) : base(addr) { }
        public WidgetAnimation FadeInAnimation { get { return this[nameof(FadeInAnimation)].As<WidgetAnimation>(); } set { this["FadeInAnimation"] = value; } }
        public WidgetAnimation FadeOutAnimation { get { return this[nameof(FadeOutAnimation)].As<WidgetAnimation>(); } set { this["FadeOutAnimation"] = value; } }
        public void ShowWidget() { Invoke(nameof(ShowWidget)); }
        public void HideWidget() { Invoke(nameof(HideWidget)); }
    }
    public class PortalWarsTutorialVideoWidget : PortalWarsUserWidget
    {
        public PortalWarsTutorialVideoWidget(ulong addr) : base(addr) { }
        public MediaPlayer TutorialMediaPlayer { get { return this[nameof(TutorialMediaPlayer)].As<MediaPlayer>(); } set { this["TutorialMediaPlayer"] = value; } }
        public Object TutorialMediaSoundActorClass { get { return this[nameof(TutorialMediaSoundActorClass)]; } set { this[nameof(TutorialMediaSoundActorClass)] = value; } }
        public Actor TutorialMediaSoundActor { get { return this[nameof(TutorialMediaSoundActor)].As<Actor>(); } set { this["TutorialMediaSoundActor"] = value; } }
        public Object SubtitleText { get { return this[nameof(SubtitleText)]; } set { this[nameof(SubtitleText)] = value; } }
        public TextBlock ToggleVideoText { get { return this[nameof(ToggleVideoText)].As<TextBlock>(); } set { this["ToggleVideoText"] = value; } }
        public TextBlock Subtitles { get { return this[nameof(Subtitles)].As<TextBlock>(); } set { this["Subtitles"] = value; } }
        public void PlayVideoInternal(int StageID) { Invoke(nameof(PlayVideoInternal), StageID); }
        public void OnVideoCompleted() { Invoke(nameof(OnVideoCompleted)); }
        public void OnMediaOpenFailed(Object FailedUrl) { Invoke(nameof(OnMediaOpenFailed), FailedUrl); }
    }
    public class PortalWarsUIHelpers : BlueprintFunctionLibrary
    {
        public PortalWarsUIHelpers(ulong addr) : base(addr) { }
    }
    public class PortalWarsUISettingsWidget : PortalWarsSettingsSubWidget
    {
        public PortalWarsUISettingsWidget(ulong addr) : base(addr) { }
        public PortalWarsCheckBoxWidget FPS { get { return this[nameof(FPS)].As<PortalWarsCheckBoxWidget>(); } set { this["FPS"] = value; } }
        public PortalWarsCheckBoxWidget Ping { get { return this[nameof(Ping)].As<PortalWarsCheckBoxWidget>(); } set { this["Ping"] = value; } }
        public PortalWarsCheckBoxWidget NetInfo { get { return this[nameof(NetInfo)].As<PortalWarsCheckBoxWidget>(); } set { this["NetInfo"] = value; } }
        public PortalWarsCheckBoxWidget Subtitles { get { return this[nameof(Subtitles)].As<PortalWarsCheckBoxWidget>(); } set { this["Subtitles"] = value; } }
        public PortalWarsCheckBoxWidget DamageNumbers { get { return this[nameof(DamageNumbers)].As<PortalWarsCheckBoxWidget>(); } set { this["DamageNumbers"] = value; } }
        public PortalWarsCheckBoxWidget LowAmmo { get { return this[nameof(LowAmmo)].As<PortalWarsCheckBoxWidget>(); } set { this["LowAmmo"] = value; } }
        public PortalWarsColorPickerWidget CrosshairColor { get { return this[nameof(CrosshairColor)].As<PortalWarsColorPickerWidget>(); } set { this["CrosshairColor"] = value; } }
        public PortalWarsColorPickerWidget EnemyCrosshairColor { get { return this[nameof(EnemyCrosshairColor)].As<PortalWarsColorPickerWidget>(); } set { this["EnemyCrosshairColor"] = value; } }
        public PanelWidget CrosshairPanel { get { return this[nameof(CrosshairPanel)].As<PanelWidget>(); } set { this["CrosshairPanel"] = value; } }
        public PortalWarsCheckBoxWidget SprintCrosshair { get { return this[nameof(SprintCrosshair)].As<PortalWarsCheckBoxWidget>(); } set { this["SprintCrosshair"] = value; } }
    }
    public class PortalWarsUltraDynamicSky : Actor
    {
        public PortalWarsUltraDynamicSky(ulong addr) : base(addr) { }
        public void EditorInit() { Invoke(nameof(EditorInit)); }
    }
    public class PortalWarsUnlockDialogWidget : PortalWarsDialogWidget
    {
        public PortalWarsUnlockDialogWidget(ulong addr) : base(addr) { }
        public TextBlock TitleText { get { return this[nameof(TitleText)].As<TextBlock>(); } set { this["TitleText"] = value; } }
        public TextBlock MessageText { get { return this[nameof(MessageText)].As<TextBlock>(); } set { this["MessageText"] = value; } }
        public Image MedalImage { get { return this[nameof(MedalImage)].As<Image>(); } set { this["MedalImage"] = value; } }
        public Image UnlockImage { get { return this[nameof(UnlockImage)].As<Image>(); } set { this["UnlockImage"] = value; } }
        public Image IconImage { get { return this[nameof(IconImage)].As<Image>(); } set { this["IconImage"] = value; } }
        public VerticalBox NotesVerticalBox { get { return this[nameof(NotesVerticalBox)].As<VerticalBox>(); } set { this["NotesVerticalBox"] = value; } }
        public PortalWarsButtonWidget QueueButton { get { return this[nameof(QueueButton)].As<PortalWarsButtonWidget>(); } set { this["QueueButton"] = value; } }
        public PortalWarsButtonWidget ViewButton { get { return this[nameof(ViewButton)].As<PortalWarsButtonWidget>(); } set { this["ViewButton"] = value; } }
        public WidgetSwitcher ButtonWidgetSwitcher { get { return this[nameof(ButtonWidgetSwitcher)].As<WidgetSwitcher>(); } set { this["ButtonWidgetSwitcher"] = value; } }
        public Object NoteEntryWidgetClass { get { return this[nameof(NoteEntryWidgetClass)]; } set { this[nameof(NoteEntryWidgetClass)] = value; } }
        public float PaddingBetweenNoteEntries { get { return this[nameof(PaddingBetweenNoteEntries)].GetValue<float>(); } set { this[nameof(PaddingBetweenNoteEntries)].SetValue<float>(value); } }
        public AkAudioEvent UnlockEvent { get { return this[nameof(UnlockEvent)].As<AkAudioEvent>(); } set { this["UnlockEvent"] = value; } }
        public void PlayUnlockSound() { Invoke(nameof(PlayUnlockSound)); }
        public void OnViewButtonClicked() { Invoke(nameof(OnViewButtonClicked)); }
        public void OnQueueButtonClicked() { Invoke(nameof(OnQueueButtonClicked)); }
    }
    public class PortalWarsUnlockNoteEntryWidget : UserWidget
    {
        public PortalWarsUnlockNoteEntryWidget(ulong addr) : base(addr) { }
        public TextBlock NoteText { get { return this[nameof(NoteText)].As<TextBlock>(); } set { this["NoteText"] = value; } }
        public Image BulletImage { get { return this[nameof(BulletImage)].As<Image>(); } set { this["BulletImage"] = value; } }
        public SlateColor ImportantColor { get { return this[nameof(ImportantColor)].As<SlateColor>(); } set { this["ImportantColor"] = value; } }
    }
    public class PortalWarsVideoSettingsWidget : PortalWarsSettingsSubWidget
    {
        public PortalWarsVideoSettingsWidget(ulong addr) : base(addr) { }
        public PortalWarsDropdownWidget DisplayMode { get { return this[nameof(DisplayMode)].As<PortalWarsDropdownWidget>(); } set { this["DisplayMode"] = value; } }
        public PortalWarsDropdownWidget Resolution { get { return this[nameof(Resolution)].As<PortalWarsDropdownWidget>(); } set { this["Resolution"] = value; } }
        public PortalWarsSpinSliderWidget ResolutionScale { get { return this[nameof(ResolutionScale)].As<PortalWarsSpinSliderWidget>(); } set { this["ResolutionScale"] = value; } }
        public PortalWarsSpinSliderWidget FOV { get { return this[nameof(FOV)].As<PortalWarsSpinSliderWidget>(); } set { this["FOV"] = value; } }
        public PortalWarsCheckBoxWidget VSync { get { return this[nameof(VSync)].As<PortalWarsCheckBoxWidget>(); } set { this["VSync"] = value; } }
        public PortalWarsDropdownWidget ViewDistance { get { return this[nameof(ViewDistance)].As<PortalWarsDropdownWidget>(); } set { this["ViewDistance"] = value; } }
        public PortalWarsDropdownWidget PostProcess { get { return this[nameof(PostProcess)].As<PortalWarsDropdownWidget>(); } set { this["PostProcess"] = value; } }
        public PortalWarsDropdownWidget Shadows { get { return this[nameof(Shadows)].As<PortalWarsDropdownWidget>(); } set { this["Shadows"] = value; } }
        public PortalWarsDropdownWidget Textures { get { return this[nameof(Textures)].As<PortalWarsDropdownWidget>(); } set { this["Textures"] = value; } }
        public PortalWarsDropdownWidget Effects { get { return this[nameof(Effects)].As<PortalWarsDropdownWidget>(); } set { this["Effects"] = value; } }
        public PortalWarsDropdownWidget AntiAliasing { get { return this[nameof(AntiAliasing)].As<PortalWarsDropdownWidget>(); } set { this["AntiAliasing"] = value; } }
        public PortalWarsDropdownWidget PortalQuality { get { return this[nameof(PortalQuality)].As<PortalWarsDropdownWidget>(); } set { this["PortalQuality"] = value; } }
        public PortalWarsDropdownWidget PortalFrameRate { get { return this[nameof(PortalFrameRate)].As<PortalWarsDropdownWidget>(); } set { this["PortalFrameRate"] = value; } }
        public PortalWarsSpinSliderWidget FrameRateLimit { get { return this[nameof(FrameRateLimit)].As<PortalWarsSpinSliderWidget>(); } set { this["FrameRateLimit"] = value; } }
        public PortalWarsDropdownWidget ColorblindMode { get { return this[nameof(ColorblindMode)].As<PortalWarsDropdownWidget>(); } set { this["ColorblindMode"] = value; } }
        public PortalWarsSpinSliderWidget ColorblindModeIntensity { get { return this[nameof(ColorblindModeIntensity)].As<PortalWarsSpinSliderWidget>(); } set { this["ColorblindModeIntensity"] = value; } }
    }
    public class PortalWarsVIP : PortalWarsGameMode
    {
        public PortalWarsVIP(ulong addr) : base(addr) { }
        public Array<Object> VIPDefaultInventoryClasses { get { return new Array<Object>(this[nameof(VIPDefaultInventoryClasses)].Address); } }
        public int VIPKillScore { get { return this[nameof(VIPKillScore)].GetValue<int>(); } set { this[nameof(VIPKillScore)].SetValue<int>(value); } }
        public int VIPSuicideScore { get { return this[nameof(VIPSuicideScore)].GetValue<int>(); } set { this[nameof(VIPSuicideScore)].SetValue<int>(value); } }
    }
    public class PortalWarsVIPGameState : PortalWarsGameState
    {
        public PortalWarsVIPGameState(ulong addr) : base(addr) { }
        public Object VIPs { get { return this[nameof(VIPs)]; } set { this[nameof(VIPs)] = value; } }
        public Object PreviousVIPs { get { return this[nameof(PreviousVIPs)]; } set { this[nameof(PreviousVIPs)] = value; } }
    }
    public class PortalWarsVIPHUD : PortalWarsHUD
    {
        public PortalWarsVIPHUD(ulong addr) : base(addr) { }
        public PortalWarsVIPHUDOverlayWidget VIPHUDOverlayWidget { get { return this[nameof(VIPHUDOverlayWidget)].As<PortalWarsVIPHUDOverlayWidget>(); } set { this["VIPHUDOverlayWidget"] = value; } }
        public Object VIPHUDOverlayWidgetClass { get { return this[nameof(VIPHUDOverlayWidgetClass)]; } set { this[nameof(VIPHUDOverlayWidgetClass)] = value; } }
        public Object VIPNameIndicatorWidgetClass { get { return this[nameof(VIPNameIndicatorWidgetClass)]; } set { this[nameof(VIPNameIndicatorWidgetClass)] = value; } }
        public AkAudioEvent VipAlertEvent { get { return this[nameof(VipAlertEvent)].As<AkAudioEvent>(); } set { this["VipAlertEvent"] = value; } }
    }
    public class PortalWarsVIPHUDOverlayWidget : UserWidget
    {
        public PortalWarsVIPHUDOverlayWidget(ulong addr) : base(addr) { }
        public float TimeBeforeFading { get { return this[nameof(TimeBeforeFading)].GetValue<float>(); } set { this[nameof(TimeBeforeFading)].SetValue<float>(value); } }
        public float SpectatorShowPopupMaxTimeAlive { get { return this[nameof(SpectatorShowPopupMaxTimeAlive)].GetValue<float>(); } set { this[nameof(SpectatorShowPopupMaxTimeAlive)].SetValue<float>(value); } }
        public WidgetAnimation FadeOutAnimation { get { return this[nameof(FadeOutAnimation)].As<WidgetAnimation>(); } set { this["FadeOutAnimation"] = value; } }
        public ScaleBox NoticeScaleBox { get { return this[nameof(NoticeScaleBox)].As<ScaleBox>(); } set { this["NoticeScaleBox"] = value; } }
        public ScaleBox BannerScaleBox { get { return this[nameof(BannerScaleBox)].As<ScaleBox>(); } set { this["BannerScaleBox"] = value; } }
        public CanvasPanel RootCanvas { get { return this[nameof(RootCanvas)].As<CanvasPanel>(); } set { this["RootCanvas"] = value; } }
        public void PlayFadeAnimation() { Invoke(nameof(PlayFadeAnimation)); }
    }
    public class PortalWarsVIPNameIndicatorWidget : PortalWarsNameIndicatorWidget
    {
        public PortalWarsVIPNameIndicatorWidget(ulong addr) : base(addr) { }
        public Widget Pointer { get { return this[nameof(Pointer)].As<Widget>(); } set { this["Pointer"] = value; } }
        public SizeBox OffscreenSizeBox { get { return this[nameof(OffscreenSizeBox)].As<SizeBox>(); } set { this["OffscreenSizeBox"] = value; } }
    }
    public class PortalWarsVIPPlayerState : PortalWarsPlayerState
    {
        public PortalWarsVIPPlayerState(ulong addr) : base(addr) { }
        public VIPInfo VIPInfo { get { return this[nameof(VIPInfo)].As<VIPInfo>(); } set { this["VIPInfo"] = value; } }
        public void OnRep_IsVIP() { Invoke(nameof(OnRep_IsVIP)); }
    }
    public class PortalWarsVoteEntryWidget : PortalWarsEntryWidget
    {
        public PortalWarsVoteEntryWidget(ulong addr) : base(addr) { }
        public TextBlock MapNameText { get { return this[nameof(MapNameText)].As<TextBlock>(); } set { this["MapNameText"] = value; } }
        public Image MapImage { get { return this[nameof(MapImage)].As<Image>(); } set { this["MapImage"] = value; } }
        public Texture2D DefaultImage { get { return this[nameof(DefaultImage)].As<Texture2D>(); } set { this["DefaultImage"] = value; } }
        public TextBlock ModeNameText { get { return this[nameof(ModeNameText)].As<TextBlock>(); } set { this["ModeNameText"] = value; } }
        public TextBlock NumVotesText { get { return this[nameof(NumVotesText)].As<TextBlock>(); } set { this["NumVotesText"] = value; } }
        public TextBlock VotesText { get { return this[nameof(VotesText)].As<TextBlock>(); } set { this["VotesText"] = value; } }
        public Widget VotedIndicator { get { return this[nameof(VotedIndicator)].As<Widget>(); } set { this["VotedIndicator"] = value; } }
        public WidgetAnimation VotedAnimation { get { return this[nameof(VotedAnimation)].As<WidgetAnimation>(); } set { this["VotedAnimation"] = value; } }
        public ButtonStyle DefaultButtonStyle { get { return this[nameof(DefaultButtonStyle)].As<ButtonStyle>(); } set { this["DefaultButtonStyle"] = value; } }
        public ButtonStyle SelectedButtonStyle { get { return this[nameof(SelectedButtonStyle)].As<ButtonStyle>(); } set { this["SelectedButtonStyle"] = value; } }
        public Image FadeScrim { get { return this[nameof(FadeScrim)].As<Image>(); } set { this["FadeScrim"] = value; } }
        public Texture2D DefaultFadeScrim { get { return this[nameof(DefaultFadeScrim)].As<Texture2D>(); } set { this["DefaultFadeScrim"] = value; } }
        public Texture2D SelectedFadeScrim { get { return this[nameof(SelectedFadeScrim)].As<Texture2D>(); } set { this["SelectedFadeScrim"] = value; } }
        public void OnVotesUpdated() { Invoke(nameof(OnVotesUpdated)); }
        public void InitModeData() { Invoke(nameof(InitModeData)); }
        public void InitMapData() { Invoke(nameof(InitMapData)); }
        public Object GetVotesText() { return Invoke<Object>(nameof(GetVotesText)); }
        public Object GetNumVotesText() { return Invoke<Object>(nameof(GetNumVotesText)); }
    }
    public class PortalWarsVoteInfo : Info
    {
        public PortalWarsVoteInfo(ulong addr) : base(addr) { }
        public VoteOption VoteOption { get { return this[nameof(VoteOption)].As<VoteOption>(); } set { this["VoteOption"] = value; } }
        public Array<PortalWarsPlayerState> Voters { get { return new Array<PortalWarsPlayerState>(this[nameof(Voters)].Address); } }
        public void OnRep_Voters() { Invoke(nameof(OnRep_Voters)); }
    }
    public class PortalWarsVotingGameMode : PortalWarsLobbyGameMode
    {
        public PortalWarsVotingGameMode(ulong addr) : base(addr) { }
        public void CreateBotDelayed(PendingBotInfo BotInfo) { Invoke(nameof(CreateBotDelayed), BotInfo); }
    }
    public class PortalWarsVotingGameState : PortalWarsLobbyGameState
    {
        public PortalWarsVotingGameState(ulong addr) : base(addr) { }
        public Array<PortalWarsVoteInfo> VoteInfoList { get { return new Array<PortalWarsVoteInfo>(this[nameof(VoteInfoList)].Address); } }
        public void OnRep_VoteList() { Invoke(nameof(OnRep_VoteList)); }
    }
    public class PortalWarsVotingMenuWidget : PortalWarsLobbyWidget
    {
        public PortalWarsVotingMenuWidget(ulong addr) : base(addr) { }
        public PanelWidget VotePanel { get { return this[nameof(VotePanel)].As<PanelWidget>(); } set { this["VotePanel"] = value; } }
        public Object VoteEntryWidgetClass { get { return this[nameof(VoteEntryWidgetClass)]; } set { this[nameof(VoteEntryWidgetClass)] = value; } }
        public RichTextBlock RemainingTimeText { get { return this[nameof(RemainingTimeText)].As<RichTextBlock>(); } set { this["RemainingTimeText"] = value; } }
        public TextBlock StateDescriptionText { get { return this[nameof(StateDescriptionText)].As<TextBlock>(); } set { this["StateDescriptionText"] = value; } }
        public Widget VoteRoot { get { return this[nameof(VoteRoot)].As<Widget>(); } set { this["VoteRoot"] = value; } }
        public Widget GameRoot { get { return this[nameof(GameRoot)].As<Widget>(); } set { this["GameRoot"] = value; } }
        public WidgetSwitcher VoteWidgetSwitcher { get { return this[nameof(VoteWidgetSwitcher)].As<WidgetSwitcher>(); } set { this["VoteWidgetSwitcher"] = value; } }
        public Widget ModeRoot { get { return this[nameof(ModeRoot)].As<Widget>(); } set { this["ModeRoot"] = value; } }
        public TextBlock ModeText { get { return this[nameof(ModeText)].As<TextBlock>(); } set { this["ModeText"] = value; } }
        public void OnMatchStateChanged() { Invoke(nameof(OnMatchStateChanged)); }
        public Object GetStateDescriptionText() { return Invoke<Object>(nameof(GetStateDescriptionText)); }
        public Object GetRemainingTimeText() { return Invoke<Object>(nameof(GetRemainingTimeText)); }
    }
    public class PortalWarsVotingPlayerController : PortalWarsLobbyPlayerController
    {
        public PortalWarsVotingPlayerController(ulong addr) : base(addr) { }
        public void ServerVote(PortalWarsVoteInfo VoteInfo) { Invoke(nameof(ServerVote), VoteInfo); }
    }
    public class PortalWarsWaitingAreaHUDWidget : UserWidget
    {
        public PortalWarsWaitingAreaHUDWidget(ulong addr) : base(addr) { }
        public TextBlock SessionQueryTitleText { get { return this[nameof(SessionQueryTitleText)].As<TextBlock>(); } set { this["SessionQueryTitleText"] = value; } }
        public Widget WaitingAreaPanel { get { return this[nameof(WaitingAreaPanel)].As<Widget>(); } set { this["WaitingAreaPanel"] = value; } }
        public PortalWarsGameInstance GameInstanceRef { get { return this[nameof(GameInstanceRef)].As<PortalWarsGameInstance>(); } set { this["GameInstanceRef"] = value; } }
        public void OnClientSessionStateChanged() { Invoke(nameof(OnClientSessionStateChanged)); }
        public ESlateVisibility GetWaitingAreaPanelVisibility() { return Invoke<ESlateVisibility>(nameof(GetWaitingAreaPanelVisibility)); }
    }
    public class PortalWarsWidgetSwitcher : WidgetSwitcher
    {
        public PortalWarsWidgetSwitcher(ulong addr) : base(addr) { }
        public Array<Object> Widgets { get { return new Array<Object>(this[nameof(Widgets)].Address); } }
    }
    public class PortalWarsWorldSettings : WorldSettings
    {
        public PortalWarsWorldSettings(ulong addr) : base(addr) { }
    }
    public class PortalWarsXPUpdateEntryWidget : PortalWarsEntryWidget
    {
        public PortalWarsXPUpdateEntryWidget(ulong addr) : base(addr) { }
        public TextBlock XPText { get { return this[nameof(XPText)].As<TextBlock>(); } set { this["XPText"] = value; } }
        public WidgetAnimation FadeUpAnimation { get { return this[nameof(FadeUpAnimation)].As<WidgetAnimation>(); } set { this["FadeUpAnimation"] = value; } }
        public AkAudioEvent PopupEvent { get { return this[nameof(PopupEvent)].As<AkAudioEvent>(); } set { this["PopupEvent"] = value; } }
        public Object GetXPText() { return Invoke<Object>(nameof(GetXPText)); }
        public Object GetTitle() { return Invoke<Object>(nameof(GetTitle)); }
    }
    public class PortalWarsXPUpdateWidget : UserWidget
    {
        public PortalWarsXPUpdateWidget(ulong addr) : base(addr) { }
        public TextBlock PlayerNameText { get { return this[nameof(PlayerNameText)].As<TextBlock>(); } set { this["PlayerNameText"] = value; } }
        public Image AvatarImage { get { return this[nameof(AvatarImage)].As<Image>(); } set { this["AvatarImage"] = value; } }
        public PortalWarsProgressionIconWidget ProgressionLevelIcon { get { return this[nameof(ProgressionLevelIcon)].As<PortalWarsProgressionIconWidget>(); } set { this["ProgressionLevelIcon"] = value; } }
        public ProgressBar ProgressionProgressBar { get { return this[nameof(ProgressionProgressBar)].As<ProgressBar>(); } set { this["ProgressionProgressBar"] = value; } }
        public ProgressBar ProgressionTargetProgressBar { get { return this[nameof(ProgressionTargetProgressBar)].As<ProgressBar>(); } set { this["ProgressionTargetProgressBar"] = value; } }
        public TextBlock ProgressionLevelProgressText { get { return this[nameof(ProgressionLevelProgressText)].As<TextBlock>(); } set { this["ProgressionLevelProgressText"] = value; } }
        public TextBlock ProgressionLevelTotalText { get { return this[nameof(ProgressionLevelTotalText)].As<TextBlock>(); } set { this["ProgressionLevelTotalText"] = value; } }
        public Widget ProgressionProgressRoot { get { return this[nameof(ProgressionProgressRoot)].As<Widget>(); } set { this["ProgressionProgressRoot"] = value; } }
        public PortalWarsProgressionIconWidget BattlePassLevelIcon { get { return this[nameof(BattlePassLevelIcon)].As<PortalWarsProgressionIconWidget>(); } set { this["BattlePassLevelIcon"] = value; } }
        public ProgressBar BattlePassProgressBar { get { return this[nameof(BattlePassProgressBar)].As<ProgressBar>(); } set { this["BattlePassProgressBar"] = value; } }
        public ProgressBar BattlePassTargetProgressBar { get { return this[nameof(BattlePassTargetProgressBar)].As<ProgressBar>(); } set { this["BattlePassTargetProgressBar"] = value; } }
        public TextBlock BattlePassLevelProgressText { get { return this[nameof(BattlePassLevelProgressText)].As<TextBlock>(); } set { this["BattlePassLevelProgressText"] = value; } }
        public TextBlock BattlePassLevelTotalText { get { return this[nameof(BattlePassLevelTotalText)].As<TextBlock>(); } set { this["BattlePassLevelTotalText"] = value; } }
        public Widget BattlePassProgressRoot { get { return this[nameof(BattlePassProgressRoot)].As<Widget>(); } set { this["BattlePassProgressRoot"] = value; } }
        public Object XPEntryWidgetClass { get { return this[nameof(XPEntryWidgetClass)]; } set { this[nameof(XPEntryWidgetClass)] = value; } }
        public PanelWidget AllocationPanel { get { return this[nameof(AllocationPanel)].As<PanelWidget>(); } set { this["AllocationPanel"] = value; } }
        public TextBlock TotalXPText { get { return this[nameof(TotalXPText)].As<TextBlock>(); } set { this["TotalXPText"] = value; } }
        public AkComponent AkComp { get { return this[nameof(AkComp)].As<AkComponent>(); } set { this["AkComp"] = value; } }
        public AkAudioEvent ExpSFXLoop { get { return this[nameof(ExpSFXLoop)].As<AkAudioEvent>(); } set { this["ExpSFXLoop"] = value; } }
        public AkAudioEvent ExpSFXStopLoop { get { return this[nameof(ExpSFXStopLoop)].As<AkAudioEvent>(); } set { this["ExpSFXStopLoop"] = value; } }
        public AkAudioEvent ExpLevelUpEvent { get { return this[nameof(ExpLevelUpEvent)].As<AkAudioEvent>(); } set { this["ExpLevelUpEvent"] = value; } }
        public void OnXPAnimationStarted() { Invoke(nameof(OnXPAnimationStarted)); }
        public void OnXPAnimationEnded() { Invoke(nameof(OnXPAnimationEnded)); }
        public Object GetTotalXP() { return Invoke<Object>(nameof(GetTotalXP)); }
        public Object GetProgressionTotalText() { return Invoke<Object>(nameof(GetProgressionTotalText)); }
        public Object GetProgressionProgressText() { return Invoke<Object>(nameof(GetProgressionProgressText)); }
        public ESlateVisibility GetProgressionMaxLevelVisibility() { return Invoke<ESlateVisibility>(nameof(GetProgressionMaxLevelVisibility)); }
        public float GetProgressionLevelUpProgress() { return Invoke<float>(nameof(GetProgressionLevelUpProgress)); }
        public int GetDisplayedProgressionLevel() { return Invoke<int>(nameof(GetDisplayedProgressionLevel)); }
        public int GetDisplayedBattlePassLevel() { return Invoke<int>(nameof(GetDisplayedBattlePassLevel)); }
        public Object GetBattlePassTotalText() { return Invoke<Object>(nameof(GetBattlePassTotalText)); }
        public Object GetBattlePassProgressText() { return Invoke<Object>(nameof(GetBattlePassProgressText)); }
        public ESlateVisibility GetBattlePassMaxLevelVisibility() { return Invoke<ESlateVisibility>(nameof(GetBattlePassMaxLevelVisibility)); }
        public float GetBattlePassLevelUpProgress() { return Invoke<float>(nameof(GetBattlePassLevelUpProgress)); }
    }
    public class PreviewItem : Actor
    {
        public PreviewItem(ulong addr) : base(addr) { }
        public SceneCaptureComponent2D SceneCaptureComponent { get { return this[nameof(SceneCaptureComponent)].As<SceneCaptureComponent2D>(); } set { this["SceneCaptureComponent"] = value; } }
        public Object SceneCaptureTransforms { get { return this[nameof(SceneCaptureTransforms)]; } set { this[nameof(SceneCaptureTransforms)] = value; } }
        public Object SceneCaptureRewardTransforms { get { return this[nameof(SceneCaptureRewardTransforms)]; } set { this[nameof(SceneCaptureRewardTransforms)] = value; } }
        public SceneComponent SceneRoot { get { return this[nameof(SceneRoot)].As<SceneComponent>(); } set { this["SceneRoot"] = value; } }
        public SceneComponent CustomizationSceneComponent { get { return this[nameof(CustomizationSceneComponent)].As<SceneComponent>(); } set { this["CustomizationSceneComponent"] = value; } }
        public SkeletalMeshComponent Suit { get { return this[nameof(Suit)].As<SkeletalMeshComponent>(); } set { this["Suit"] = value; } }
        public SkeletalMeshComponent JetpackAttached { get { return this[nameof(JetpackAttached)].As<SkeletalMeshComponent>(); } set { this["JetpackAttached"] = value; } }
        public Array<StaticMeshComponent> JetpackFlameMeshes { get { return new Array<StaticMeshComponent>(this[nameof(JetpackFlameMeshes)].Address); } }
        public SkeletalMeshComponent JetpackAlone { get { return this[nameof(JetpackAlone)].As<SkeletalMeshComponent>(); } set { this["JetpackAlone"] = value; } }
        public StaticMeshComponent PortalGun { get { return this[nameof(PortalGun)].As<StaticMeshComponent>(); } set { this["PortalGun"] = value; } }
        public StaticMeshComponent PortalGunStandalone { get { return this[nameof(PortalGunStandalone)].As<StaticMeshComponent>(); } set { this["PortalGunStandalone"] = value; } }
        public AnimSequence DefaultAnim { get { return this[nameof(DefaultAnim)].As<AnimSequence>(); } set { this["DefaultAnim"] = value; } }
        public StaticMeshComponent Weapon { get { return this[nameof(Weapon)].As<StaticMeshComponent>(); } set { this["Weapon"] = value; } }
        public StaticMeshComponent Portal { get { return this[nameof(Portal)].As<StaticMeshComponent>(); } set { this["Portal"] = value; } }
        public StaticMeshComponent PortalInside { get { return this[nameof(PortalInside)].As<StaticMeshComponent>(); } set { this["PortalInside"] = value; } }
        public StaticMeshComponent PortalFrameBase { get { return this[nameof(PortalFrameBase)].As<StaticMeshComponent>(); } set { this["PortalFrameBase"] = value; } }
        public StaticMeshComponent SprayMesh { get { return this[nameof(SprayMesh)].As<StaticMeshComponent>(); } set { this["SprayMesh"] = value; } }
        public DecalComponent SprayDecal { get { return this[nameof(SprayDecal)].As<DecalComponent>(); } set { this["SprayDecal"] = value; } }
        public StaticMeshComponent XPMesh { get { return this[nameof(XPMesh)].As<StaticMeshComponent>(); } set { this["XPMesh"] = value; } }
        public StaticMeshComponent CurrencyMesh { get { return this[nameof(CurrencyMesh)].As<StaticMeshComponent>(); } set { this["CurrencyMesh"] = value; } }
        public StaticMeshComponent DropMesh { get { return this[nameof(DropMesh)].As<StaticMeshComponent>(); } set { this["DropMesh"] = value; } }
        public AnimSequence JetpackOpenAnimation { get { return this[nameof(JetpackOpenAnimation)].As<AnimSequence>(); } set { this["JetpackOpenAnimation"] = value; } }
        public AnimSequence JetpackIdleAnimation { get { return this[nameof(JetpackIdleAnimation)].As<AnimSequence>(); } set { this["JetpackIdleAnimation"] = value; } }
        public void UpdateRenderTargetQuality() { Invoke(nameof(UpdateRenderTargetQuality)); }
        public void OnCustomizationsLoaded() { Invoke(nameof(OnCustomizationsLoaded)); }
    }
    public class PWKillcamTransitionWidget : UserWidget
    {
        public PWKillcamTransitionWidget(ulong addr) : base(addr) { }
        public WidgetAnimation FadeInAnimation { get { return this[nameof(FadeInAnimation)].As<WidgetAnimation>(); } set { this["FadeInAnimation"] = value; } }
        public WidgetAnimation FadeOutAnimation { get { return this[nameof(FadeOutAnimation)].As<WidgetAnimation>(); } set { this["FadeOutAnimation"] = value; } }
        public void PlayFadeOutAnimation() { Invoke(nameof(PlayFadeOutAnimation)); }
        public void PlayFadeInAnimation() { Invoke(nameof(PlayFadeInAnimation)); }
    }
    public class PWProjectileMovementComponent : ProjectileMovementComponent
    {
        public PWProjectileMovementComponent(ulong addr) : base(addr) { }
        public Array<PrimitiveComponent> AddlUpdatedComponents { get { return new Array<PrimitiveComponent>(this[nameof(AddlUpdatedComponents)].Address); } }
    }
    public class PWReplayPlayerCameraManager : PortalWarsPlayerCameraManager
    {
        public PWReplayPlayerCameraManager(ulong addr) : base(addr) { }
    }
    public class PWReplayPlayerController : PortalWarsPlayerController
    {
        public PWReplayPlayerController(ulong addr) : base(addr) { }
        public PlayerState ReplayPlayerState { get { return this[nameof(ReplayPlayerState)].As<PlayerState>(); } set { this["ReplayPlayerState"] = value; } }
        public PortalWarsReplayHUDOverlayWidget ReplayHUDWidget { get { return this[nameof(ReplayHUDWidget)].As<PortalWarsReplayHUDOverlayWidget>(); } set { this["ReplayHUDWidget"] = value; } }
        public Object ReplayHUDWidgetClass { get { return this[nameof(ReplayHUDWidgetClass)]; } set { this[nameof(ReplayHUDWidgetClass)] = value; } }
        public SpringArmComponent CameraBoom { get { return this[nameof(CameraBoom)].As<SpringArmComponent>(); } set { this["CameraBoom"] = value; } }
        public CameraComponent FollowCamera { get { return this[nameof(FollowCamera)].As<CameraComponent>(); } set { this["FollowCamera"] = value; } }
        public LinearColor AlphaTeamColor { get { return this[nameof(AlphaTeamColor)].As<LinearColor>(); } set { this["AlphaTeamColor"] = value; } }
        public LinearColor BravoTeamColor { get { return this[nameof(BravoTeamColor)].As<LinearColor>(); } set { this["BravoTeamColor"] = value; } }
        public void ToggleReplayUI() { Invoke(nameof(ToggleReplayUI)); }
        public void ToggleGlobalVision() { Invoke(nameof(ToggleGlobalVision)); }
        public void SetReplayPlayerFocus(PlayerState NewFocusedPlayer) { Invoke(nameof(SetReplayPlayerFocus), NewFocusedPlayer); }
        public void SetPlayerFocusByNumber(int PlayerIndex) { Invoke(nameof(SetPlayerFocusByNumber), PlayerIndex); }
        public void RePause(bool bWasSuccessful) { Invoke(nameof(RePause), bWasSuccessful); }
        public void OnGoTimeComplete(bool bWasSuccessful) { Invoke(nameof(OnGoTimeComplete), bWasSuccessful); }
        public void OnDemoRecordingComplete(World World) { Invoke(nameof(OnDemoRecordingComplete), World); }
        public void OnDemoFinishedPlayback(World World) { Invoke(nameof(OnDemoFinishedPlayback), World); }
        public void NextCameraMode() { Invoke(nameof(NextCameraMode)); }
        public PlayerState GetReplayPlayerFocus() { return Invoke<PlayerState>(nameof(GetReplayPlayerFocus)); }
        public void FocusPreviousPlayer() { Invoke(nameof(FocusPreviousPlayer)); }
        public void FocusPlayer8() { Invoke(nameof(FocusPlayer8)); }
        public void FocusPlayer7() { Invoke(nameof(FocusPlayer7)); }
        public void FocusPlayer6() { Invoke(nameof(FocusPlayer6)); }
        public void FocusPlayer5() { Invoke(nameof(FocusPlayer5)); }
        public void FocusPlayer4() { Invoke(nameof(FocusPlayer4)); }
        public void FocusPlayer3() { Invoke(nameof(FocusPlayer3)); }
        public void FocusPlayer2() { Invoke(nameof(FocusPlayer2)); }
        public void FocusPlayer1() { Invoke(nameof(FocusPlayer1)); }
        public void FocusNextPlayer() { Invoke(nameof(FocusNextPlayer)); }
    }
    public class PWRichTextBlockButtonDecorator : RichTextBlockDecorator
    {
        public PWRichTextBlockButtonDecorator(ulong addr) : base(addr) { }
    }
    public class PWRichTextBlockInputDecorator : RichTextBlockDecorator
    {
        public PWRichTextBlockInputDecorator(ulong addr) : base(addr) { }
    }
    public class PWRichTextBlockKeyDecorator : RichTextBlockDecorator
    {
        public PWRichTextBlockKeyDecorator(ulong addr) : base(addr) { }
    }
    public class PWSpectatorPawn : SpectatorPawn
    {
        public PWSpectatorPawn(ulong addr) : base(addr) { }
        public float TimeToReachMaxAccel { get { return this[nameof(TimeToReachMaxAccel)].GetValue<float>(); } set { this[nameof(TimeToReachMaxAccel)].SetValue<float>(value); } }
        public float ControllerMaxAccelMultiplier { get { return this[nameof(ControllerMaxAccelMultiplier)].GetValue<float>(); } set { this[nameof(ControllerMaxAccelMultiplier)].SetValue<float>(value); } }
        public PortalWarsAkComponent AkComponent { get { return this[nameof(AkComponent)].As<PortalWarsAkComponent>(); } set { this["AkComponent"] = value; } }
    }
    public class PWTutorialHUDOverlayWidget : UserWidget
    {
        public PWTutorialHUDOverlayWidget(ulong addr) : base(addr) { }
        public TextBlock StageNameText { get { return this[nameof(StageNameText)].As<TextBlock>(); } set { this["StageNameText"] = value; } }
        public TextBlock StageNumText { get { return this[nameof(StageNumText)].As<TextBlock>(); } set { this["StageNumText"] = value; } }
        public TextBlock GrenadeText { get { return this[nameof(GrenadeText)].As<TextBlock>(); } set { this["GrenadeText"] = value; } }
        public PortalWarsTutorialBookmarkWidget TutorialBookmark { get { return this[nameof(TutorialBookmark)].As<PortalWarsTutorialBookmarkWidget>(); } set { this["TutorialBookmark"] = value; } }
        public PortalWarsTutorialStepsWidget TutorialSteps { get { return this[nameof(TutorialSteps)].As<PortalWarsTutorialStepsWidget>(); } set { this["TutorialSteps"] = value; } }
        public PortalWarsTutorialVideoWidget TutorialVideo { get { return this[nameof(TutorialVideo)].As<PortalWarsTutorialVideoWidget>(); } set { this["TutorialVideo"] = value; } }
        public WidgetAnimation ExpandVideoAnimation { get { return this[nameof(ExpandVideoAnimation)].As<WidgetAnimation>(); } set { this["ExpandVideoAnimation"] = value; } }
        public BackgroundBlur VideoBackgroundBlur { get { return this[nameof(VideoBackgroundBlur)].As<BackgroundBlur>(); } set { this["VideoBackgroundBlur"] = value; } }
        public PanelWidget StepPopupPanel { get { return this[nameof(StepPopupPanel)].As<PanelWidget>(); } set { this["StepPopupPanel"] = value; } }
        public Object StepPopUpWidgetClass { get { return this[nameof(StepPopUpWidgetClass)]; } set { this[nameof(StepPopUpWidgetClass)] = value; } }
        public WidgetAnimation StepPopupAnimation { get { return this[nameof(StepPopupAnimation)].As<WidgetAnimation>(); } set { this["StepPopupAnimation"] = value; } }
        public TextBlock InputDeviceText { get { return this[nameof(InputDeviceText)].As<TextBlock>(); } set { this["InputDeviceText"] = value; } }
        public WidgetAnimation ShowDeviceLockAnimation { get { return this[nameof(ShowDeviceLockAnimation)].As<WidgetAnimation>(); } set { this["ShowDeviceLockAnimation"] = value; } }
        public WidgetAnimation HideDeviceLockAnimation { get { return this[nameof(HideDeviceLockAnimation)].As<WidgetAnimation>(); } set { this["HideDeviceLockAnimation"] = value; } }
        public PortalWarsTutorialVideoReminderWidget TutorialVideoReminder { get { return this[nameof(TutorialVideoReminder)].As<PortalWarsTutorialVideoReminderWidget>(); } set { this["TutorialVideoReminder"] = value; } }
        public void PlayStepPopupAnimation() { Invoke(nameof(PlayStepPopupAnimation)); }
        public void OnStepLoaded(TutorialStepData StepData) { Invoke(nameof(OnStepLoaded), StepData); }
    }
    public class PWTutorialPlayerController : PortalWarsPlayerController
    {
        public PWTutorialPlayerController(ulong addr) : base(addr) { }
        public float TimeBetweenStages { get { return this[nameof(TimeBetweenStages)].GetValue<float>(); } set { this[nameof(TimeBetweenStages)].SetValue<float>(value); } }
        public float TimeBeforeFreezingPlayer { get { return this[nameof(TimeBeforeFreezingPlayer)].GetValue<float>(); } set { this[nameof(TimeBeforeFreezingPlayer)].SetValue<float>(value); } }
        public float TimeBeforeUnfreezingPlayer { get { return this[nameof(TimeBeforeUnfreezingPlayer)].GetValue<float>(); } set { this[nameof(TimeBeforeUnfreezingPlayer)].SetValue<float>(value); } }
        public float TimeBeforeReturningToMainMenu { get { return this[nameof(TimeBeforeReturningToMainMenu)].GetValue<float>(); } set { this[nameof(TimeBeforeReturningToMainMenu)].SetValue<float>(value); } }
        public float TimeBeforePlayingTutorialCompleteVideo { get { return this[nameof(TimeBeforePlayingTutorialCompleteVideo)].GetValue<float>(); } set { this[nameof(TimeBeforePlayingTutorialCompleteVideo)].SetValue<float>(value); } }
        public Vector PlayableArea1 { get { return this[nameof(PlayableArea1)].As<Vector>(); } set { this["PlayableArea1"] = value; } }
        public Vector PlayableArea2 { get { return this[nameof(PlayableArea2)].As<Vector>(); } set { this["PlayableArea2"] = value; } }
        public Vector PlayableAreaLoc1 { get { return this[nameof(PlayableAreaLoc1)].As<Vector>(); } set { this["PlayableAreaLoc1"] = value; } }
        public Vector PlayableAreaLoc2 { get { return this[nameof(PlayableAreaLoc2)].As<Vector>(); } set { this["PlayableAreaLoc2"] = value; } }
        public MaterialParameterCollection FloorMPC { get { return this[nameof(FloorMPC)].As<MaterialParameterCollection>(); } set { this["FloorMPC"] = value; } }
        public float FloorRevealStep { get { return this[nameof(FloorRevealStep)].GetValue<float>(); } set { this[nameof(FloorRevealStep)].SetValue<float>(value); } }
        public Array<float> SideRevealMax { get { return new Array<float>(this[nameof(SideRevealMax)].Address); } }
        public float RevealMax { get { return this[nameof(RevealMax)].GetValue<float>(); } set { this[nameof(RevealMax)].SetValue<float>(value); } }
        public void RestartStageViaInput() { Invoke(nameof(RestartStageViaInput)); }
        public void OnResetFloorEffect() { Invoke(nameof(OnResetFloorEffect)); }
        public void OnPlayFloorEffect() { Invoke(nameof(OnPlayFloorEffect)); }
    }
    public class PWTutorialStepEntryWidget : PortalWarsUserWidget
    {
        public PWTutorialStepEntryWidget(ulong addr) : base(addr) { }
        public TextBlock DescriptionText { get { return this[nameof(DescriptionText)].As<TextBlock>(); } set { this["DescriptionText"] = value; } }
        public PortalWarsInputDecoratorWidget InputDecorator { get { return this[nameof(InputDecorator)].As<PortalWarsInputDecoratorWidget>(); } set { this["InputDecorator"] = value; } }
        public WidgetSwitcher CompletedSwitcher { get { return this[nameof(CompletedSwitcher)].As<WidgetSwitcher>(); } set { this["CompletedSwitcher"] = value; } }
    }
    public class PWVoiceNotificationItem : UserWidget
    {
        public PWVoiceNotificationItem(ulong addr) : base(addr) { }
        public SizeBox Root { get { return this[nameof(Root)].As<SizeBox>(); } set { this["Root"] = value; } }
        public TextBlock PlayerNameText { get { return this[nameof(PlayerNameText)].As<TextBlock>(); } set { this["PlayerNameText"] = value; } }
    }
    public class PWVoiceNotifications : UserWidget
    {
        public PWVoiceNotifications(ulong addr) : base(addr) { }
        public VerticalBox PlayersVerticalBox { get { return this[nameof(PlayersVerticalBox)].As<VerticalBox>(); } set { this["PlayersVerticalBox"] = value; } }
        public Object VoiceNotificationItemClass { get { return this[nameof(VoiceNotificationItemClass)]; } set { this[nameof(VoiceNotificationItemClass)] = value; } }
        public void OnPlayerArrayChanged(PlayerState StateChanged) { Invoke(nameof(OnPlayerArrayChanged), StateChanged); }
        public void Init() { Invoke(nameof(Init)); }
    }
    public class RaceBookmarkWidget : UserWidget
    {
        public RaceBookmarkWidget(ulong addr) : base(addr) { }
        public HorizontalBox MarksHorizontalBox { get { return this[nameof(MarksHorizontalBox)].As<HorizontalBox>(); } set { this["MarksHorizontalBox"] = value; } }
        public Texture2D CurrentMarkTexture { get { return this[nameof(CurrentMarkTexture)].As<Texture2D>(); } set { this["CurrentMarkTexture"] = value; } }
        public Texture2D IncompleteMarkTexture { get { return this[nameof(IncompleteMarkTexture)].As<Texture2D>(); } set { this["IncompleteMarkTexture"] = value; } }
        public Texture2D CompleteMarkTexture { get { return this[nameof(CompleteMarkTexture)].As<Texture2D>(); } set { this["CompleteMarkTexture"] = value; } }
    }
    public class RailGun : MultiKillGun
    {
        public RailGun(ulong addr) : base(addr) { }
        public WeaponAnimMontage ChargeAnim { get { return this[nameof(ChargeAnim)].As<WeaponAnimMontage>(); } set { this["ChargeAnim"] = value; } }
        public WeaponAnimMontage DischargeAnim { get { return this[nameof(DischargeAnim)].As<WeaponAnimMontage>(); } set { this["DischargeAnim"] = value; } }
        public AkAudioEvent ChargeStartEvent { get { return this[nameof(ChargeStartEvent)].As<AkAudioEvent>(); } set { this["ChargeStartEvent"] = value; } }
        public AkAudioEvent ChargeStopEvent { get { return this[nameof(ChargeStopEvent)].As<AkAudioEvent>(); } set { this["ChargeStopEvent"] = value; } }
        public AkAudioEvent DischargeEvent { get { return this[nameof(DischargeEvent)].As<AkAudioEvent>(); } set { this["DischargeEvent"] = value; } }
        public ParticleSystem ChargeFX_1P { get { return this[nameof(ChargeFX_1P)].As<ParticleSystem>(); } set { this["ChargeFX_1P"] = value; } }
        public ParticleSystem ChargeFX_3P { get { return this[nameof(ChargeFX_3P)].As<ParticleSystem>(); } set { this["ChargeFX_3P"] = value; } }
        public ParticleSystemComponent ChargePSC_1P { get { return this[nameof(ChargePSC_1P)].As<ParticleSystemComponent>(); } set { this["ChargePSC_1P"] = value; } }
        public ParticleSystemComponent ChargePSC_3P { get { return this[nameof(ChargePSC_3P)].As<ParticleSystemComponent>(); } set { this["ChargePSC_3P"] = value; } }
        public float timeToCharge { get { return this[nameof(timeToCharge)].GetValue<float>(); } set { this[nameof(timeToCharge)].SetValue<float>(value); } }
        public float BatteryPercentagePerShot { get { return this[nameof(BatteryPercentagePerShot)].GetValue<float>(); } set { this[nameof(BatteryPercentagePerShot)].SetValue<float>(value); } }
        public AmmoCounterWidgetComponent ChargeCounter { get { return this[nameof(ChargeCounter)].As<AmmoCounterWidgetComponent>(); } set { this["ChargeCounter"] = value; } }
    }
    public class RocketLauncher : ProjectileGun
    {
        public RocketLauncher(ulong addr) : base(addr) { }
        public RocketStateSpecificMontages EquipAnims { get { return this[nameof(EquipAnims)].As<RocketStateSpecificMontages>(); } set { this["EquipAnims"] = value; } }
        public RocketStateSpecificMontages FireAnims { get { return this[nameof(FireAnims)].As<RocketStateSpecificMontages>(); } set { this["FireAnims"] = value; } }
        public Array<WeaponAnimMontage> RocketMeleeEmptyAnims { get { return new Array<WeaponAnimMontage>(this[nameof(RocketMeleeEmptyAnims)].Address); } }
        public Array<WeaponAnimMontage> RocketMeleeFullAnims { get { return new Array<WeaponAnimMontage>(this[nameof(RocketMeleeFullAnims)].Address); } }
        public RocketStateSpecificMontages ThrowGrenadeAnims { get { return this[nameof(ThrowGrenadeAnims)].As<RocketStateSpecificMontages>(); } set { this["ThrowGrenadeAnims"] = value; } }
        public RocketStateSpecificMontages FirePortalAnims { get { return this[nameof(FirePortalAnims)].As<RocketStateSpecificMontages>(); } set { this["FirePortalAnims"] = value; } }
        public RocketStateSpecificMontages SprintFirePortalAnims { get { return this[nameof(SprintFirePortalAnims)].As<RocketStateSpecificMontages>(); } set { this["SprintFirePortalAnims"] = value; } }
        public RocketStateSpecificMontages ClosePortalAnims { get { return this[nameof(ClosePortalAnims)].As<RocketStateSpecificMontages>(); } set { this["ClosePortalAnims"] = value; } }
        public RocketStateSpecificMontages SprintClosePortalAnims { get { return this[nameof(SprintClosePortalAnims)].As<RocketStateSpecificMontages>(); } set { this["SprintClosePortalAnims"] = value; } }
        public RocketStateSpecificMontages InspectWeaponAnims { get { return this[nameof(InspectWeaponAnims)].As<RocketStateSpecificMontages>(); } set { this["InspectWeaponAnims"] = value; } }
        public RocketStateSpecificMontages ReloadStartAnims { get { return this[nameof(ReloadStartAnims)].As<RocketStateSpecificMontages>(); } set { this["ReloadStartAnims"] = value; } }
        public RocketStateSpecificMontages ReloadInsertAnims { get { return this[nameof(ReloadInsertAnims)].As<RocketStateSpecificMontages>(); } set { this["ReloadInsertAnims"] = value; } }
        public RocketStateSpecificMontages ReloadStopAnims { get { return this[nameof(ReloadStopAnims)].As<RocketStateSpecificMontages>(); } set { this["ReloadStopAnims"] = value; } }
        public WeaponAnimList EmptyAnimations { get { return this[nameof(EmptyAnimations)].As<WeaponAnimList>(); } set { this["EmptyAnimations"] = value; } }
        public WeaponAnimList FullAnimations { get { return this[nameof(FullAnimations)].As<WeaponAnimList>(); } set { this["FullAnimations"] = value; } }
        public void ReloadWeapon_Multicast(bool ShouldInsert) { Invoke(nameof(ReloadWeapon_Multicast), ShouldInsert); }
    }
    public class ScoreboardComponent : CullableActor
    {
        public ScoreboardComponent(ulong addr) : base(addr) { }
        public Array<Object> TextArray { get { return new Array<Object>(this[nameof(TextArray)].Address); } }
        public MaterialInterface TextMaterial { get { return this[nameof(TextMaterial)].As<MaterialInterface>(); } set { this["TextMaterial"] = value; } }
        public DataTable FontTable { get { return this[nameof(FontTable)].As<DataTable>(); } set { this["FontTable"] = value; } }
        public Array<StaticMesh> AlwaysLoadedCharacterMeshes { get { return new Array<StaticMesh>(this[nameof(AlwaysLoadedCharacterMeshes)].Address); } }
        public float FieldWidth { get { return this[nameof(FieldWidth)].GetValue<float>(); } set { this[nameof(FieldWidth)].SetValue<float>(value); } }
        public float SpaceWidth { get { return this[nameof(SpaceWidth)].GetValue<float>(); } set { this[nameof(SpaceWidth)].SetValue<float>(value); } }
        public float Kerning { get { return this[nameof(Kerning)].GetValue<float>(); } set { this[nameof(Kerning)].SetValue<float>(value); } }
        public float LineHeight { get { return this[nameof(LineHeight)].GetValue<float>(); } set { this[nameof(LineHeight)].SetValue<float>(value); } }
        public ETextAlignment TextAlignment { get { return (ETextAlignment)this[nameof(TextAlignment)].GetValue<int>(); } set { this[nameof(TextAlignment)].SetValue<int>((int)value); } }
        public Array<StaticMeshComponent> CharacterMeshComponents { get { return new Array<StaticMeshComponent>(this[nameof(CharacterMeshComponents)].Address); } }
        public void UpdateComponent() { Invoke(nameof(UpdateComponent)); }
        public void SpawnText() { Invoke(nameof(SpawnText)); }
    }
    public class ScoreboardNameComponent : ScoreboardComponent
    {
        public ScoreboardNameComponent(ulong addr) : base(addr) { }
        public byte Index { get { return this[nameof(Index)].GetValue<byte>(); } set { this[nameof(Index)].SetValue<byte>(value); } }
    }
    public class ScoreboardScoreComponent : ScoreboardComponent
    {
        public ScoreboardScoreComponent(ulong addr) : base(addr) { }
        public byte Index { get { return this[nameof(Index)].GetValue<byte>(); } set { this[nameof(Index)].SetValue<byte>(value); } }
    }
    public class ScoreboardTimeComponent : ScoreboardComponent
    {
        public ScoreboardTimeComponent(ulong addr) : base(addr) { }
    }
    public class Shotgun : LineTraceGun
    {
        public Shotgun(ulong addr) : base(addr) { }
        public int numPelletsPerShell { get { return this[nameof(numPelletsPerShell)].GetValue<int>(); } set { this[nameof(numPelletsPerShell)].SetValue<int>(value); } }
        public WeaponAnimMontage ReloadStartAnim { get { return this[nameof(ReloadStartAnim)].As<WeaponAnimMontage>(); } set { this["ReloadStartAnim"] = value; } }
        public WeaponAnimMontage ReloadInsertAnim { get { return this[nameof(ReloadInsertAnim)].As<WeaponAnimMontage>(); } set { this["ReloadInsertAnim"] = value; } }
        public WeaponAnimMontage ReloadStopAnim { get { return this[nameof(ReloadStopAnim)].As<WeaponAnimMontage>(); } set { this["ReloadStopAnim"] = value; } }
        public Object characterHitsMap { get { return this[nameof(characterHitsMap)]; } set { this[nameof(characterHitsMap)] = value; } }
        public void ServerProcessHits(Array<LineTraceHitResult> HitResults, Array<LineTraceInfo> bulletTracesPacked) { Invoke(nameof(ServerProcessHits), HitResults, bulletTracesPacked); }
        public void ReloadWeapon_Multicast(bool ShouldInsert) { Invoke(nameof(ReloadWeapon_Multicast), ShouldInsert); }
    }
    public class SMG : LineTraceGun
    {
        public SMG(ulong addr) : base(addr) { }
    }
    public class SniperRifle : MultiKillGun
    {
        public SniperRifle(ulong addr) : base(addr) { }
    }
    public class SprintCameraShakePattern : MatineeCameraShakePattern
    {
        public SprintCameraShakePattern(ulong addr) : base(addr) { }
    }
    public class TBCPortalWarsAIController : PortalWarsAIController
    {
        public TBCPortalWarsAIController(ulong addr) : base(addr) { }
    }
    public class TeleportableInterface : Interface
    {
        public TeleportableInterface(ulong addr) : base(addr) { }
    }
    public class VIPPortalWarsAIController : PortalWarsAIController
    {
        public VIPPortalWarsAIController(ulong addr) : base(addr) { }
    }
    public class VivoxChannel : Object
    {
        public VivoxChannel(ulong addr) : base(addr) { }
    }
    public class VivoxSubsystem : LocalPlayerSubsystem
    {
        public VivoxSubsystem(ulong addr) : base(addr) { }
        public Array<VivoxChannel> Channels { get { return new Array<VivoxChannel>(this[nameof(Channels)].Address); } }
    }
    public enum EReplayCameraMode : int
    {
        Free = 0,
        FirstPerson = 1,
        ThirdPerson = 2,
        Max = 3,
    }
    public enum EDOMHillState : int
    {
        None = 0,
        Uncontrolled = 1,
        AlphaTeamControls = 2,
        BravoTeamControls = 3,
        EDOMHillState_MAX = 4,
    }
    public enum EFlagState : int
    {
        None = 0,
        AtSpawn = 1,
        Dropped = 2,
        Taken = 3,
        Captured = 4,
        EFlagState_MAX = 5,
    }
    public enum EFuzzyHedge : int
    {
        None = 0,
        Fairly = 1,
        Very = 2,
        EFuzzyHedge_MAX = 3,
    }
    public enum EFuzzyDesirability : int
    {
        Undesirable = 0,
        Desirable = 1,
        VeryDesirable = 2,
        EFuzzyDesirability_MAX = 3,
    }
    public enum EFuzzyConfig : int
    {
        Close_High = 0,
        Close_Okay = 1,
        Close_Low = 2,
        Medium_High = 3,
        Medium_Okay = 4,
        Medium_Low = 5,
        Far_High = 6,
        Far_Okay = 7,
        Far_Low = 8,
        MAX = 9,
    }
    public enum EAmmoType : int
    {
        None = 0,
        Bullet = 1,
        Battery = 2,
        EAmmoType_MAX = 3,
    }
    public enum EWeaponState : int
    {
        NotEquipped = 0,
        UnEquipping = 1,
        Equipping = 2,
        Idle = 3,
        Firing = 4,
        Reloading = 5,
        Meleeing = 6,
        Throwing = 7,
        FiringPortal = 8,
        ClosingPortal = 9,
        Inspecting = 10,
        EWeaponState_MAX = 11,
    }
    public enum EMainMenuState : int
    {
        None = 0,
        Login = 1,
        Menu = 2,
        EMainMenuState_MAX = 3,
    }
    public enum ENavAreaFlag : int
    {
        Default = 0,
        Jump = 1,
        ENavAreaFlag_MAX = 2,
    }
    public enum EPortalScreenSize : int
    {
        None = 0,
        Near = 1,
        Medium = 2,
        Far = 3,
        EPortalScreenSize_MAX = 4,
    }
    public enum EAddFriendsState : int
    {
        Enabled = 0,
        Disabled = 1,
        EAddFriendsState_MAX = 2,
    }
    public enum EFocusGoal : int
    {
        Enemy = 0,
        EnemyLastLocation = 1,
        Path = 2,
        Override = 3,
        EFocusGoal_MAX = 4,
    }
    public enum EAnimationType : int
    {
        FPP = 0,
        TPP = 1,
        EAnimationType_MAX = 2,
    }
    public enum EMovementDirection : int
    {
        N = 0,
        E = 1,
        W = 2,
        S = 3,
        EMovementDirection_MAX = 4,
    }
    public enum EWeaponType : int
    {
        AssaultRifle = 0,
        BattleRifle = 1,
        Pistol = 2,
        PlasmaRifle = 3,
        RailGun = 4,
        RocketLauncher = 5,
        Shotgun = 6,
        SMG = 7,
        Sniper = 8,
        Oddball = 9,
        Flag = 10,
        Fists = 11,
        Bat = 12,
        DMR = 13,
        EWeaponType_MAX = 14,
    }
    public enum EMovementType : int
    {
        Crouching = 0,
        Walking = 1,
        Running = 2,
        Landing = 3,
        EMovementType_MAX = 4,
    }
    public enum EPWSoundClass : int
    {
        Master = 0,
        Music = 1,
        Gameplay = 2,
        Announcer = 3,
        VOIP = 4,
        Ambiance = 5,
        MAX = 6,
    }
    public enum EInputMode : int
    {
        None = 0,
        UIOnly = 1,
        GameAndUI = 2,
        GameOnly = 3,
        EInputMode_MAX = 4,
    }
    public enum EBlockedPlayersState : int
    {
        Succeeded = 0,
        Searching = 1,
        Failed = 2,
        EBlockedPlayersState_MAX = 3,
    }
    public enum ENavRecoveryType : int
    {
        OffNavMesh = 0,
        OnNavMeshIsland = 1,
        ENavRecoveryType_MAX = 2,
    }
    public enum EBattlePassPurchaseType : int
    {
        Premium = 0,
        PremiumBundle = 1,
        Levels = 2,
        EBattlePassPurchaseType_MAX = 3,
    }
    public enum ECareerMenuState : int
    {
        Main = 0,
        Stats = 1,
        Leaderboards = 2,
        Replays = 3,
        ECareerMenuState_MAX = 4,
    }
    public enum EChallengesSubMenuState : int
    {
        Main = 0,
        Inspect = 1,
        EChallengesSubMenuState_MAX = 2,
    }
    public enum EChallengeMenuState : int
    {
        Main = 0,
        Inspect = 1,
        EChallengeMenuState_MAX = 2,
    }
    public enum ECheckInType : int
    {
        Claim = 0,
        Repair = 1,
        ECheckInType_MAX = 2,
    }
    public enum EControlCategory : int
    {
        Global = 0,
        Player = 1,
        Spectator = 2,
        Tutorial = 3,
        Killcam = 4,
        EControlCategory_MAX = 5,
    }
    public enum EControlSettingsMenuState : int
    {
        Settings = 0,
        Controls = 1,
        EControlSettingsMenuState_MAX = 2,
    }
    public enum ECurrencyStoreState : int
    {
        Full = 0,
        Loading = 1,
        Empty = 2,
        ECurrencyStoreState_MAX = 3,
    }
    public enum EReportCategory : int
    {
        Cheating = 0,
        Exploiting = 1,
        Profile = 2,
        VerbalAbuse = 3,
        Scamming = 4,
        Spamming = 5,
        Other = 6,
        EReportCategory_MAX = 7,
    }
    public enum ECheatViolationType : int
    {
        MAX = 0,
    }
    public enum ECustomGameMenuState : int
    {
        Browser = 0,
        Host = 1,
        Error = 2,
        ECustomGameMenuState_MAX = 3,
    }
    public enum EScrollCenterLocation : int
    {
        TopOrLeft = 0,
        Center = 1,
        EScrollCenterLocation_MAX = 2,
    }
    public enum EWedgeType : int
    {
        Emote = 0,
        Spray = 1,
        InspectWeapon = 2,
        EWedgeType_MAX = 3,
    }
    public enum EFriendRequestDialogType : int
    {
        AddFriendCode = 0,
        AddFriendId = 1,
        AcceptFriendRequest = 2,
        DeclineFriendRequest = 3,
        EFriendRequestDialogType_MAX = 4,
    }
    public enum EFriendsListState : int
    {
        Succeeded = 0,
        Searching = 1,
        Failed = 2,
        EFriendsListState_MAX = 3,
    }
    public enum EFriendsListMenuState : int
    {
        PlatformFriends = 0,
        Friends = 1,
        EFriendsListMenuState_MAX = 2,
    }
    public enum ESoundReplicationType : int
    {
        SRT_All = 0,
        SRT_AllButOwner = 1,
        SRT_OwnerOnly = 2,
        SRT_IfSourceNotReplicated = 3,
        SRT_None = 4,
        SRT_MAX = 5,
    }
    public enum EFFAScoreState : int
    {
        None = 0,
        Tie = 1,
        Losing = 2,
        Winning = 3,
        EFFAScoreState_MAX = 4,
    }
    public enum ETeamScoreState : int
    {
        None = 0,
        Tie = 1,
        AlphaTeamLeads = 2,
        BravoTeamLeads = 3,
        ETeamScoreState_MAX = 4,
    }
    public enum EItemShopMenuState : int
    {
        Main = 0,
        Inspect = 1,
        EItemShopMenuState_MAX = 2,
    }
    public enum EKOTHHillState : int
    {
        None = 0,
        Uncontrolled = 1,
        Contested = 2,
        AlphaTeamControls = 3,
        BravoTeamControls = 4,
        EKOTHHillState_MAX = 5,
    }
    public enum ELeaderboardsMenuState : int
    {
        Ranked = 0,
        ELeaderboardsMenuState_MAX = 1,
    }
    public enum ELockerMenuState : int
    {
        Main = 0,
        Inspect = 1,
        ELockerMenuState_MAX = 2,
    }
    public enum ELoginMenuState : int
    {
        Welcome = 0,
        Connecting = 1,
        Error = 2,
        ELoginMenuState_MAX = 3,
    }
    public enum ELootboxMenuState : int
    {
        Main = 0,
        Opening = 1,
        ELootboxMenuState_MAX = 2,
    }
    public enum EMainMenuWidgetState : int
    {
        Play = 0,
        BattlePass = 1,
        Challenges = 2,
        Locker = 3,
        Career = 4,
        Training = 5,
        ItemShop = 6,
        RewardCenter = 7,
        Social = 8,
        ReferralPass = 9,
        Lootbox = 10,
        None = 11,
        EMainMenuWidgetState_MAX = 12,
    }
    public enum EMessageType : int
    {
        Error = 0,
        Notice = 1,
        EMessageType_MAX = 2,
    }
    public enum EBallState : int
    {
        None = 0,
        AtSpawn = 1,
        Dropped = 2,
        Controlled = 3,
        AlphaTeamControls = 4,
        BravoTeamControls = 5,
        EBallState_MAX = 6,
    }
    public enum EOnlineSessionClientState : int
    {
        None = 0,
        CreatingCustom = 1,
        JoiningCustom = 2,
        Matchmaking = 3,
        WaitingArea = 4,
        Playing = 5,
        EOnlineSessionClientState_MAX = 6,
    }
    public enum EPauseMenuState : int
    {
        Main = 0,
        Settings = 1,
        Players = 2,
        Quit = 3,
        EPauseMenuState_MAX = 4,
    }
    public enum EPlayerActionsMenuState : int
    {
        Main = 0,
        Report = 1,
        EPlayerActionsMenuState_MAX = 2,
    }
    public enum EPlaylistSelectState : int
    {
        Main = 0,
        GameModeSelection = 1,
        EPlaylistSelectState_MAX = 2,
    }
    public enum EPlaySelectionMenuState : int
    {
        Online = 0,
        Custom = 1,
        EPlaySelectionMenuState_MAX = 2,
    }
    public enum EPlayMenuState : int
    {
        Main = 0,
        Selection = 1,
        EPlayMenuState_MAX = 2,
    }
    public enum EPriceType : int
    {
        Normal = 0,
        Discounted = 1,
        Original = 2,
        Premium = 3,
        EPriceType_MAX = 4,
    }
    public enum ERaceLeaderboardType : int
    {
        Global = 0,
        Friends = 1,
        ERaceLeaderboardType_MAX = 2,
    }
    public enum ERecentPlayersState : int
    {
        Succeeded = 0,
        Searching = 1,
        Failed = 2,
        ERecentPlayersState_MAX = 3,
    }
    public enum ERewardCenterMenuState : int
    {
        ReferFriend = 0,
        DailyCheckIn = 1,
        DailyPlayStreak = 2,
        Drops = 3,
        ERewardCenterMenuState_MAX = 4,
    }
    public enum ERewardReceivedType : int
    {
        Drops = 0,
        Challenges = 1,
        BattlePass = 2,
        ReferralPass = 3,
        ERewardReceivedType_MAX = 4,
    }
    public enum ERewardReceivedState : int
    {
        Rewards = 0,
        Inspect = 1,
        ERewardReceivedState_MAX = 2,
    }
    public enum EServerBrowserState : int
    {
        None = 0,
        Searching = 1,
        Succeeded = 2,
        Failed = 3,
        EServerBrowserState_MAX = 4,
    }
    public enum ESettingsMenuState : int
    {
        Video = 0,
        Gameplay = 1,
        Gamepad = 3,
        Audio = 4,
        UI = 5,
        Privacy = 6,
        ESettingsMenuState_MAX = 7,
    }
    public enum EInviteMenuState : int
    {
        Friends = 0,
        RecentPlayers = 1,
        AddFriends = 2,
        Invites = 3,
        BlockedPlayers = 4,
        EInviteMenuState_MAX = 5,
    }
    public enum EStatsMenuState : int
    {
        Overview = 0,
        Social = 1,
        Ranked = 2,
        EStatsMenuState_MAX = 3,
    }
    public enum ETakedownState : int
    {
        Default = 0,
        OneAllyLeft = 1,
        OneEnemyLeft = 2,
        OneOnOne = 3,
        ETakedownState_MAX = 4,
    }
    public enum EGoalType : int
    {
        Overlap = 0,
        Kill = 1,
        Melee = 2,
        EMP = 3,
        Teleport = 4,
        Link = 5,
        SpawnPortal = 6,
        Pickup = 7,
        ClosePortal = 8,
        TeamChat = 9,
        ProxChat = 10,
        Emote = 11,
        EmoteWheel = 12,
        EGoalType_MAX = 13,
    }
    public enum ETxnDialogState : int
    {
        Confirmation = 0,
        Processing = 1,
        Success = 2,
        Fail = 3,
        ETxnDialogState_MAX = 4,
    }
    public enum ECommunicationType : int
    {
        Voice = 0,
        Text = 1,
        ECommunicationType_MAX = 2,
    }
    public enum EBodyPart : int
    {
        Torso = 0,
        Head = 1,
        Feet = 2,
        EBodyPart_MAX = 3,
    }
    public enum EHitDirection : int
    {
        F = 0,
        FL = 1,
        FR = 2,
        B = 3,
        BL = 4,
        BR = 5,
        L = 6,
        R = 7,
        EHitDirection_MAX = 8,
    }
    public enum EPWHitType : int
    {
        Normal = 0,
        Headshot = 1,
        Death = 2,
        EPWHitType_MAX = 3,
    }
    public enum EChatType : int
    {
        General = 0,
        Team = 1,
        EChatType_MAX = 2,
    }
    public enum EWidgetPlatformVisibility : int
    {
        AllPlatforms = 0,
        PCOnly = 1,
        ConsoleOnly = 2,
        EWidgetPlatformVisibility_MAX = 3,
    }
    public enum EItemPreviewType : int
    {
        Inspect = 0,
        Locker = 1,
        Lootbox = 2,
        EItemPreviewType_MAX = 3,
    }
    public enum EScoreboardType : int
    {
        Name = 0,
        Score = 1,
        Timer = 2,
        EScoreboardType_MAX = 3,
    }
    public enum ETextAlignment : int
    {
        Left = 0,
        Center = 1,
        Right = 2,
        ETextAlignment_MAX = 3,
    }
    public enum PTTKey : int
    {
        PTTTeamChannel = 0,
        PTTAreaChannel = 1,
        PTTKey_MAX = 2,
    }
    public enum EVoiceChannelType : int
    {
        Party = 0,
        Lobby = 1,
        Team = 2,
        Proximity = 3,
        EVoiceChannelType_MAX = 4,
    }
    public class BurstLineTraceGunData : Object
    {
        public BurstLineTraceGunData(ulong addr) : base(addr) { }
        public int NumberOfBurstShots { get { return this[nameof(NumberOfBurstShots)].GetValue<int>(); } set { this[nameof(NumberOfBurstShots)].SetValue<int>(value); } }
        public float TimeBetweenBurstShots { get { return this[nameof(TimeBetweenBurstShots)].GetValue<float>(); } set { this[nameof(TimeBetweenBurstShots)].SetValue<float>(value); } }
    }
    public class Transform_NetQuantize : Transform
    {
        public Transform_NetQuantize(ulong addr) : base(addr) { }
    }
    public class WeaponData : Object
    {
        public WeaponData(ulong addr) : base(addr) { }
        public int MaxAmmo { get { return this[nameof(MaxAmmo)].GetValue<int>(); } set { this[nameof(MaxAmmo)].SetValue<int>(value); } }
        public int AmmoPerClip { get { return this[nameof(AmmoPerClip)].GetValue<int>(); } set { this[nameof(AmmoPerClip)].SetValue<int>(value); } }
        public int InitialClips { get { return this[nameof(InitialClips)].GetValue<int>(); } set { this[nameof(InitialClips)].SetValue<int>(value); } }
        public EAmmoType AmmoType { get { return (EAmmoType)this[nameof(AmmoType)].GetValue<int>(); } set { this[nameof(AmmoType)].SetValue<int>((int)value); } }
        public float TimeBetweenShots { get { return this[nameof(TimeBetweenShots)].GetValue<float>(); } set { this[nameof(TimeBetweenShots)].SetValue<float>(value); } }
        public bool bIsSingleShot { get { return this[nameof(bIsSingleShot)].Flag; } set { this[nameof(bIsSingleShot)].Flag = value; } }
        public float NoAnimReloadDuration { get { return this[nameof(NoAnimReloadDuration)].GetValue<float>(); } set { this[nameof(NoAnimReloadDuration)].SetValue<float>(value); } }
        public bool CanZoom { get { return this[nameof(CanZoom)].Flag; } set { this[nameof(CanZoom)].Flag = value; } }
        public float ZoomFOV { get { return this[nameof(ZoomFOV)].GetValue<float>(); } set { this[nameof(ZoomFOV)].SetValue<float>(value); } }
        public bool CanSwapForSameWeapon { get { return this[nameof(CanSwapForSameWeapon)].Flag; } set { this[nameof(CanSwapForSameWeapon)].Flag = value; } }
        public float MeleeDamage { get { return this[nameof(MeleeDamage)].GetValue<float>(); } set { this[nameof(MeleeDamage)].SetValue<float>(value); } }
    }
    public class AutoAimData : Object
    {
        public AutoAimData(ulong addr) : base(addr) { }
        public float AutoAimRadius { get { return this[nameof(AutoAimRadius)].GetValue<float>(); } set { this[nameof(AutoAimRadius)].SetValue<float>(value); } }
        public float AutoAimRadiusZoomed { get { return this[nameof(AutoAimRadiusZoomed)].GetValue<float>(); } set { this[nameof(AutoAimRadiusZoomed)].SetValue<float>(value); } }
        public float AutoAimMaxRadiusMultiplier { get { return this[nameof(AutoAimMaxRadiusMultiplier)].GetValue<float>(); } set { this[nameof(AutoAimMaxRadiusMultiplier)].SetValue<float>(value); } }
        public float AutoAimMaxRadiusAutoScale { get { return this[nameof(AutoAimMaxRadiusAutoScale)].GetValue<float>(); } set { this[nameof(AutoAimMaxRadiusAutoScale)].SetValue<float>(value); } }
        public float AutoAimMinRadiusRange { get { return this[nameof(AutoAimMinRadiusRange)].GetValue<float>(); } set { this[nameof(AutoAimMinRadiusRange)].SetValue<float>(value); } }
        public float AutoAimMaxRadiusRange { get { return this[nameof(AutoAimMaxRadiusRange)].GetValue<float>(); } set { this[nameof(AutoAimMaxRadiusRange)].SetValue<float>(value); } }
        public float AutoAimRange { get { return this[nameof(AutoAimRange)].GetValue<float>(); } set { this[nameof(AutoAimRange)].SetValue<float>(value); } }
        public float MagnetismRange { get { return this[nameof(MagnetismRange)].GetValue<float>(); } set { this[nameof(MagnetismRange)].SetValue<float>(value); } }
        public float MagnetismAngle { get { return this[nameof(MagnetismAngle)].GetValue<float>(); } set { this[nameof(MagnetismAngle)].SetValue<float>(value); } }
        public bool ShouldUseMagnetism { get { return this[nameof(ShouldUseMagnetism)].Flag; } set { this[nameof(ShouldUseMagnetism)].Flag = value; } }
        public bool bDynamicAutoAimRadius { get { return this[nameof(bDynamicAutoAimRadius)].Flag; } set { this[nameof(bDynamicAutoAimRadius)].Flag = value; } }
    }
    public class RecoilData : Object
    {
        public RecoilData(ulong addr) : base(addr) { }
        public float recoilRiseTime { get { return this[nameof(recoilRiseTime)].GetValue<float>(); } set { this[nameof(recoilRiseTime)].SetValue<float>(value); } }
        public float recoilTotalTime { get { return this[nameof(recoilTotalTime)].GetValue<float>(); } set { this[nameof(recoilTotalTime)].SetValue<float>(value); } }
        public float verticalRecoilAmount { get { return this[nameof(verticalRecoilAmount)].GetValue<float>(); } set { this[nameof(verticalRecoilAmount)].SetValue<float>(value); } }
        public float horizontalRecoilAmount { get { return this[nameof(horizontalRecoilAmount)].GetValue<float>(); } set { this[nameof(horizontalRecoilAmount)].SetValue<float>(value); } }
        public float recoilKick { get { return this[nameof(recoilKick)].GetValue<float>(); } set { this[nameof(recoilKick)].SetValue<float>(value); } }
        public float visualRecoil { get { return this[nameof(visualRecoil)].GetValue<float>(); } set { this[nameof(visualRecoil)].SetValue<float>(value); } }
    }
    public class FuzzyConfig : Object
    {
        public FuzzyConfig(ulong addr) : base(addr) { }
        public EFuzzyDesirability Desirability { get { return (EFuzzyDesirability)this[nameof(Desirability)].GetValue<int>(); } set { this[nameof(Desirability)].SetValue<int>((int)value); } }
        public EFuzzyHedge Hedge { get { return (EFuzzyHedge)this[nameof(Hedge)].GetValue<int>(); } set { this[nameof(Hedge)].SetValue<int>((int)value); } }
    }
    public class LineTraceGunData : Object
    {
        public LineTraceGunData(ulong addr) : base(addr) { }
        public float WeaponSpread { get { return this[nameof(WeaponSpread)].GetValue<float>(); } set { this[nameof(WeaponSpread)].SetValue<float>(value); } }
        public float WeaponSpreadZoomed { get { return this[nameof(WeaponSpreadZoomed)].GetValue<float>(); } set { this[nameof(WeaponSpreadZoomed)].SetValue<float>(value); } }
        public float FiringSpreadIncrement { get { return this[nameof(FiringSpreadIncrement)].GetValue<float>(); } set { this[nameof(FiringSpreadIncrement)].SetValue<float>(value); } }
        public float FiringSpreadIncrementZoomed { get { return this[nameof(FiringSpreadIncrementZoomed)].GetValue<float>(); } set { this[nameof(FiringSpreadIncrementZoomed)].SetValue<float>(value); } }
        public float FiringSpreadMax { get { return this[nameof(FiringSpreadMax)].GetValue<float>(); } set { this[nameof(FiringSpreadMax)].SetValue<float>(value); } }
        public float FiringSpreadMaxZoomed { get { return this[nameof(FiringSpreadMaxZoomed)].GetValue<float>(); } set { this[nameof(FiringSpreadMaxZoomed)].SetValue<float>(value); } }
        public Array<Vector2D> SpreadPattern { get { return new Array<Vector2D>(this[nameof(SpreadPattern)].Address); } }
        public float WeaponRange { get { return this[nameof(WeaponRange)].GetValue<float>(); } set { this[nameof(WeaponRange)].SetValue<float>(value); } }
        public float damageDropOffDistance1 { get { return this[nameof(damageDropOffDistance1)].GetValue<float>(); } set { this[nameof(damageDropOffDistance1)].SetValue<float>(value); } }
        public float damageDropOffDistance2 { get { return this[nameof(damageDropOffDistance2)].GetValue<float>(); } set { this[nameof(damageDropOffDistance2)].SetValue<float>(value); } }
        public float damageDropOffModifier { get { return this[nameof(damageDropOffModifier)].GetValue<float>(); } set { this[nameof(damageDropOffModifier)].SetValue<float>(value); } }
        public float HitDamage { get { return this[nameof(HitDamage)].GetValue<float>(); } set { this[nameof(HitDamage)].SetValue<float>(value); } }
        public float HeadShotDamage { get { return this[nameof(HeadShotDamage)].GetValue<float>(); } set { this[nameof(HeadShotDamage)].SetValue<float>(value); } }
        public Object DamageType { get { return this[nameof(DamageType)]; } set { this[nameof(DamageType)] = value; } }
        public float ClientSideHitLeeway { get { return this[nameof(ClientSideHitLeeway)].GetValue<float>(); } set { this[nameof(ClientSideHitLeeway)].SetValue<float>(value); } }
        public float AllowedViewDotHitDir { get { return this[nameof(AllowedViewDotHitDir)].GetValue<float>(); } set { this[nameof(AllowedViewDotHitDir)].SetValue<float>(value); } }
    }
    public class Bunch : Object
    {
        public Bunch(ulong addr) : base(addr) { }
    }
    public class EnemyInfo : Object
    {
        public EnemyInfo(ulong addr) : base(addr) { }
        public float LastSeenTime { get { return this[nameof(LastSeenTime)].GetValue<float>(); } set { this[nameof(LastSeenTime)].SetValue<float>(value); } }
        public float FirstSeenTime { get { return this[nameof(FirstSeenTime)].GetValue<float>(); } set { this[nameof(FirstSeenTime)].SetValue<float>(value); } }
        public Vector LastSeenLocation { get { return this[nameof(LastSeenLocation)].As<Vector>(); } set { this["LastSeenLocation"] = value; } }
        public bool bHasLoS { get { return this[nameof(bHasLoS)].Flag; } set { this[nameof(bHasLoS)].Flag = value; } }
        public Object Character { get { return this[nameof(Character)]; } set { this[nameof(Character)] = value; } }
        public float Threat { get { return this[nameof(Threat)].GetValue<float>(); } set { this[nameof(Threat)].SetValue<float>(value); } }
        public bool bHasLoSViaPortal { get { return this[nameof(bHasLoSViaPortal)].Flag; } set { this[nameof(bHasLoSViaPortal)].Flag = value; } }
        public Vector LastSeenLocationVirtual { get { return this[nameof(LastSeenLocationVirtual)].As<Vector>(); } set { this["LastSeenLocationVirtual"] = value; } }
        public Object Portal { get { return this[nameof(Portal)]; } set { this[nameof(Portal)] = value; } }
        public bool bSensedFromDamage { get { return this[nameof(bSensedFromDamage)].Flag; } set { this[nameof(bSensedFromDamage)].Flag = value; } }
        public bool bHasBeenFocused { get { return this[nameof(bHasBeenFocused)].Flag; } set { this[nameof(bHasBeenFocused)].Flag = value; } }
    }
    public class BotDebugInfo : Object
    {
        public BotDebugInfo(ulong addr) : base(addr) { }
        public Object Tree { get { return this[nameof(Tree)]; } set { this[nameof(Tree)] = value; } }
        public Object Task { get { return this[nameof(Task)]; } set { this[nameof(Task)] = value; } }
        public PortalWarsCharacter Enemy { get { return this[nameof(Enemy)].As<PortalWarsCharacter>(); } set { this["Enemy"] = value; } }
        public EFocusGoal FocusGoal { get { return (EFocusGoal)this[nameof(FocusGoal)].GetValue<int>(); } set { this[nameof(FocusGoal)].SetValue<int>((int)value); } }
        public EnemyInfo EnemyInfo { get { return this[nameof(EnemyInfo)].As<EnemyInfo>(); } set { this["EnemyInfo"] = value; } }
        public Array<EnemyInfo> SeenEnemies { get { return new Array<EnemyInfo>(this[nameof(SeenEnemies)].Address); } }
        public float Difficulty { get { return this[nameof(Difficulty)].GetValue<float>(); } set { this[nameof(Difficulty)].SetValue<float>(value); } }
        public bool bWantsToFire { get { return this[nameof(bWantsToFire)].Flag; } set { this[nameof(bWantsToFire)].Flag = value; } }
        public float TrackingOffsetError { get { return this[nameof(TrackingOffsetError)].GetValue<float>(); } set { this[nameof(TrackingOffsetError)].SetValue<float>(value); } }
        public float TrackingPredictionError { get { return this[nameof(TrackingPredictionError)].GetValue<float>(); } set { this[nameof(TrackingPredictionError)].SetValue<float>(value); } }
        public Object ChosenPickup { get { return this[nameof(ChosenPickup)]; } set { this[nameof(ChosenPickup)] = value; } }
        public bool bHeardSound { get { return this[nameof(bHeardSound)].Flag; } set { this[nameof(bHeardSound)].Flag = value; } }
        public Object HeardSoundInstigator { get { return this[nameof(HeardSoundInstigator)]; } set { this[nameof(HeardSoundInstigator)] = value; } }
        public bool bIsAdaptive { get { return this[nameof(bIsAdaptive)].Flag; } set { this[nameof(bIsAdaptive)].Flag = value; } }
        public bool bIsBrainOn { get { return this[nameof(bIsBrainOn)].Flag; } set { this[nameof(bIsBrainOn)].Flag = value; } }
        public float RotationRate { get { return this[nameof(RotationRate)].GetValue<float>(); } set { this[nameof(RotationRate)].SetValue<float>(value); } }
        public Vector FocalPoint { get { return this[nameof(FocalPoint)].As<Vector>(); } set { this["FocalPoint"] = value; } }
        public Array<Vector> FocusPriorities { get { return new Array<Vector>(this[nameof(FocusPriorities)].Address); } }
        public float FOV { get { return this[nameof(FOV)].GetValue<float>(); } set { this[nameof(FOV)].SetValue<float>(value); } }
        public float BulletScale { get { return this[nameof(BulletScale)].GetValue<float>(); } set { this[nameof(BulletScale)].SetValue<float>(value); } }
        public float DifficultyFromTarget { get { return this[nameof(DifficultyFromTarget)].GetValue<float>(); } set { this[nameof(DifficultyFromTarget)].SetValue<float>(value); } }
        public int EnemyRank { get { return this[nameof(EnemyRank)].GetValue<int>(); } set { this[nameof(EnemyRank)].SetValue<int>(value); } }
        public bool bUsingAdaptiveDifficulty { get { return this[nameof(bUsingAdaptiveDifficulty)].Flag; } set { this[nameof(bUsingAdaptiveDifficulty)].Flag = value; } }
        public int NumBlacklistedPickups { get { return this[nameof(NumBlacklistedPickups)].GetValue<int>(); } set { this[nameof(NumBlacklistedPickups)].SetValue<int>(value); } }
        public float EnemyMeleeTime { get { return this[nameof(EnemyMeleeTime)].GetValue<float>(); } set { this[nameof(EnemyMeleeTime)].SetValue<float>(value); } }
        public Array<float> WeaponScores { get { return new Array<float>(this[nameof(WeaponScores)].Address); } }
        public bool bIsSprinting { get { return this[nameof(bIsSprinting)].Flag; } set { this[nameof(bIsSprinting)].Flag = value; } }
        public EWeaponState WeaponState { get { return (EWeaponState)this[nameof(WeaponState)].GetValue<int>(); } set { this[nameof(WeaponState)].SetValue<int>((int)value); } }
    }
    public class NavRecoverySettings : Object
    {
        public NavRecoverySettings(ulong addr) : base(addr) { }
        public int FailureCountUntilRecovery { get { return this[nameof(FailureCountUntilRecovery)].GetValue<int>(); } set { this[nameof(FailureCountUntilRecovery)].SetValue<int>(value); } }
        public float FailureTimeUntilRecovery { get { return this[nameof(FailureTimeUntilRecovery)].GetValue<float>(); } set { this[nameof(FailureTimeUntilRecovery)].SetValue<float>(value); } }
        public float MaxRecoveryAttemptTime { get { return this[nameof(MaxRecoveryAttemptTime)].GetValue<float>(); } set { this[nameof(MaxRecoveryAttemptTime)].SetValue<float>(value); } }
        public float SearchInnerRadius { get { return this[nameof(SearchInnerRadius)].GetValue<float>(); } set { this[nameof(SearchInnerRadius)].SetValue<float>(value); } }
        public float SearchOuterRadius { get { return this[nameof(SearchOuterRadius)].GetValue<float>(); } set { this[nameof(SearchOuterRadius)].SetValue<float>(value); } }
        public float InnerSearchRadiusGrowthRate { get { return this[nameof(InnerSearchRadiusGrowthRate)].GetValue<float>(); } set { this[nameof(InnerSearchRadiusGrowthRate)].SetValue<float>(value); } }
        public float OuterSearchRadiusGrowthRate { get { return this[nameof(OuterSearchRadiusGrowthRate)].GetValue<float>(); } set { this[nameof(OuterSearchRadiusGrowthRate)].SetValue<float>(value); } }
        public float NavFailureTimeBeforeShrinkExtent { get { return this[nameof(NavFailureTimeBeforeShrinkExtent)].GetValue<float>(); } set { this[nameof(NavFailureTimeBeforeShrinkExtent)].SetValue<float>(value); } }
        public int NavRecoverySkipFrames { get { return this[nameof(NavRecoverySkipFrames)].GetValue<int>(); } set { this[nameof(NavRecoverySkipFrames)].SetValue<int>(value); } }
    }
    public class IgnoreMovementCorrections : Object
    {
        public IgnoreMovementCorrections(ulong addr) : base(addr) { }
        public bool bIgnoreServerCorrections { get { return this[nameof(bIgnoreServerCorrections)].Flag; } set { this[nameof(bIgnoreServerCorrections)].Flag = value; } }
        public byte ForceRep { get { return this[nameof(ForceRep)].GetValue<byte>(); } set { this[nameof(ForceRep)].SetValue<byte>(value); } }
    }
    public class SavedPosition : Object
    {
        public SavedPosition(ulong addr) : base(addr) { }
    }
    public class ControllerKeybindPreset : Object
    {
        public ControllerKeybindPreset(ulong addr) : base(addr) { }
        public Object PresetName { get { return this[nameof(PresetName)]; } set { this[nameof(PresetName)] = value; } }
        public Object Controls { get { return this[nameof(Controls)]; } set { this[nameof(Controls)] = value; } }
        public bool bToggleSprint { get { return this[nameof(bToggleSprint)].Flag; } set { this[nameof(bToggleSprint)].Flag = value; } }
        public bool bToggleZoom { get { return this[nameof(bToggleZoom)].Flag; } set { this[nameof(bToggleZoom)].Flag = value; } }
        public bool bToggleCrouch { get { return this[nameof(bToggleCrouch)].Flag; } set { this[nameof(bToggleCrouch)].Flag = value; } }
    }
    public class KeyConfigurationInfo : Object
    {
        public KeyConfigurationInfo(ulong addr) : base(addr) { }
        public Object GameActionTag { get { return this[nameof(GameActionTag)]; } set { this[nameof(GameActionTag)] = value; } }
        public EControlCategory Category { get { return (EControlCategory)this[nameof(Category)].GetValue<int>(); } set { this[nameof(Category)].SetValue<int>((int)value); } }
        public Object MenuText { get { return this[nameof(MenuText)]; } set { this[nameof(MenuText)] = value; } }
        public Key PrimaryKey { get { return this[nameof(PrimaryKey)].As<Key>(); } set { this["PrimaryKey"] = value; } }
        public Key SecondaryKey { get { return this[nameof(SecondaryKey)].As<Key>(); } set { this["SecondaryKey"] = value; } }
        public Key GamepadKey { get { return this[nameof(GamepadKey)].As<Key>(); } set { this["GamepadKey"] = value; } }
        public Array<InputActionKeyMapping> ActionMappings { get { return new Array<InputActionKeyMapping>(this[nameof(ActionMappings)].Address); } }
        public Array<InputAxisKeyMapping> AxisMappings { get { return new Array<InputAxisKeyMapping>(this[nameof(AxisMappings)].Address); } }
    }
    public class CheatViolations : Object
    {
        public CheatViolations(ulong addr) : base(addr) { }
        public Array<int> Counts { get { return new Array<int>(this[nameof(Counts)].Address); } }
    }
    public class PWRadialDamageEvent : RadialDamageEvent
    {
        public PWRadialDamageEvent(ulong addr) : base(addr) { }
        public bool bThruPortal { get { return this[nameof(bThruPortal)].Flag; } set { this[nameof(bThruPortal)].Flag = value; } }
        public Gun MeleeWeapon { get { return this[nameof(MeleeWeapon)].As<Gun>(); } set { this["MeleeWeapon"] = value; } }
        public int ShotNumber { get { return this[nameof(ShotNumber)].GetValue<int>(); } set { this[nameof(ShotNumber)].SetValue<int>(value); } }
    }
    public class PWPointDamageEvent : PointDamageEvent
    {
        public PWPointDamageEvent(ulong addr) : base(addr) { }
        public bool bThruPortal { get { return this[nameof(bThruPortal)].Flag; } set { this[nameof(bThruPortal)].Flag = value; } }
        public int ShotNumber { get { return this[nameof(ShotNumber)].GetValue<int>(); } set { this[nameof(ShotNumber)].SetValue<int>(value); } }
    }
    public class GamepadBindingCategory : Object
    {
        public GamepadBindingCategory(ulong addr) : base(addr) { }
        public Object CategoryName { get { return this[nameof(CategoryName)]; } set { this[nameof(CategoryName)] = value; } }
        public Array<Object> GamepadBindingActions { get { return new Array<Object>(this[nameof(GamepadBindingActions)].Address); } }
    }
    public class PendingInvite : InviteInfo
    {
        public PendingInvite(ulong addr) : base(addr) { }
        public double ExpireTime { get { return this[nameof(ExpireTime)].GetValue<double>(); } set { this[nameof(ExpireTime)].SetValue<double>(value); } }
    }
    public class NavBarItem : Object
    {
        public NavBarItem(ulong addr) : base(addr) { }
        public Object Title { get { return this[nameof(Title)]; } set { this[nameof(Title)] = value; } }
        public bool bSectionHeader { get { return this[nameof(bSectionHeader)].Flag; } set { this[nameof(bSectionHeader)].Flag = value; } }
        public EWidgetPlatformVisibility PlatformVisibility { get { return (EWidgetPlatformVisibility)this[nameof(PlatformVisibility)].GetValue<int>(); } set { this[nameof(PlatformVisibility)].SetValue<int>((int)value); } }
    }
    public class ActorOriginAndExtent : Object
    {
        public ActorOriginAndExtent(ulong addr) : base(addr) { }
        public Actor Actor { get { return this[nameof(Actor)].As<Actor>(); } set { this["Actor"] = value; } }
    }
    public class RewardPassEntryData : Object
    {
        public RewardPassEntryData(ulong addr) : base(addr) { }
        public RewardData RewardData { get { return this[nameof(RewardData)].As<RewardData>(); } set { this["RewardData"] = value; } }
        public int Level { get { return this[nameof(Level)].GetValue<int>(); } set { this[nameof(Level)].SetValue<int>(value); } }
        public bool bIsPremium { get { return this[nameof(bIsPremium)].Flag; } set { this[nameof(bIsPremium)].Flag = value; } }
    }
    public class PlaylistPreference : Object
    {
        public PlaylistPreference(ulong addr) : base(addr) { }
        public Array<Object> UnselectedGameModes { get { return new Array<Object>(this[nameof(UnselectedGameModes)].Address); } }
    }
    public class DefaultInventoryClass : Object
    {
        public DefaultInventoryClass(ulong addr) : base(addr) { }
        public Array<Object> DefaultInventoryClasses { get { return new Array<Object>(this[nameof(DefaultInventoryClasses)].Address); } }
    }
    public class PortalHistory : Object
    {
        public PortalHistory(ulong addr) : base(addr) { }
    }
    public class WeaponAnimList : Object
    {
        public WeaponAnimList(ulong addr) : base(addr) { }
        public WeaponBlendSpace1D WalkBlendSpace { get { return this[nameof(WalkBlendSpace)].As<WeaponBlendSpace1D>(); } set { this["WalkBlendSpace"] = value; } }
        public WeaponBlendSpace1D LeanBlendSpace { get { return this[nameof(LeanBlendSpace)].As<WeaponBlendSpace1D>(); } set { this["LeanBlendSpace"] = value; } }
        public WeaponAnimSequence SprintAnim { get { return this[nameof(SprintAnim)].As<WeaponAnimSequence>(); } set { this["SprintAnim"] = value; } }
        public WeaponAnimSequence JumpStartAnim { get { return this[nameof(JumpStartAnim)].As<WeaponAnimSequence>(); } set { this["JumpStartAnim"] = value; } }
        public WeaponAnimSequence JumpLoopAnim { get { return this[nameof(JumpLoopAnim)].As<WeaponAnimSequence>(); } set { this["JumpLoopAnim"] = value; } }
        public WeaponAnimSequence JumpEndAnim { get { return this[nameof(JumpEndAnim)].As<WeaponAnimSequence>(); } set { this["JumpEndAnim"] = value; } }
    }
    public class WeaponAnimSequence : Object
    {
        public WeaponAnimSequence(ulong addr) : base(addr) { }
        public AnimSequence FPP { get { return this[nameof(FPP)].As<AnimSequence>(); } set { this["FPP"] = value; } }
        public AnimSequence TPP { get { return this[nameof(TPP)].As<AnimSequence>(); } set { this["TPP"] = value; } }
    }
    public class WeaponBlendSpace1D : Object
    {
        public WeaponBlendSpace1D(ulong addr) : base(addr) { }
        public BlendSpace1D FPP { get { return this[nameof(FPP)].As<BlendSpace1D>(); } set { this["FPP"] = value; } }
        public BlendSpace1D TPP { get { return this[nameof(TPP)].As<BlendSpace1D>(); } set { this["TPP"] = value; } }
    }
    public class WeaponAnimMontage : Object
    {
        public WeaponAnimMontage(ulong addr) : base(addr) { }
        public AnimMontage FPP { get { return this[nameof(FPP)].As<AnimMontage>(); } set { this["FPP"] = value; } }
        public AnimMontage TPP { get { return this[nameof(TPP)].As<AnimMontage>(); } set { this["TPP"] = value; } }
    }
    public class HitInfo : Object
    {
        public HitInfo(ulong addr) : base(addr) { }
        public byte ActualDamage { get { return this[nameof(ActualDamage)].GetValue<byte>(); } set { this[nameof(ActualDamage)].SetValue<byte>(value); } }
        public DamageEvent DamageEvent { get { return this[nameof(DamageEvent)].As<DamageEvent>(); } set { this["DamageEvent"] = value; } }
        public EHitDirection HitDirection { get { return (EHitDirection)this[nameof(HitDirection)].GetValue<int>(); } set { this[nameof(HitDirection)].SetValue<int>((int)value); } }
        public EBodyPart BodyPart { get { return (EBodyPart)this[nameof(BodyPart)].GetValue<int>(); } set { this[nameof(BodyPart)].SetValue<int>((int)value); } }
        public Object HitPawn { get { return this[nameof(HitPawn)]; } set { this[nameof(HitPawn)] = value; } }
        public EPWHitType HitType { get { return (EPWHitType)this[nameof(HitType)].GetValue<int>(); } set { this[nameof(HitType)].SetValue<int>((int)value); } }
        public Vector_NetQuantize DamageOrigin { get { return this[nameof(DamageOrigin)].As<Vector_NetQuantize>(); } set { this["DamageOrigin"] = value; } }
        public bool bIsThroughPortal { get { return this[nameof(bIsThroughPortal)].Flag; } set { this[nameof(bIsThroughPortal)].Flag = value; } }
        public byte EnsureReplicationByte { get { return this[nameof(EnsureReplicationByte)].GetValue<byte>(); } set { this[nameof(EnsureReplicationByte)].SetValue<byte>(value); } }
    }
    public class LineTraceHitResult : Object
    {
        public LineTraceHitResult(ulong addr) : base(addr) { }
        public bool bBlockingHit { get { return this[nameof(bBlockingHit)].Flag; } set { this[nameof(bBlockingHit)].Flag = value; } }
        public bool bShotThruPortal { get { return this[nameof(bShotThruPortal)].Flag; } set { this[nameof(bShotThruPortal)].Flag = value; } }
        public float Distance { get { return this[nameof(Distance)].GetValue<float>(); } set { this[nameof(Distance)].SetValue<float>(value); } }
        public Vector_NetQuantize ImpactPoint { get { return this[nameof(ImpactPoint)].As<Vector_NetQuantize>(); } set { this["ImpactPoint"] = value; } }
        public Vector_NetQuantizeNormal ImpactNormal { get { return this[nameof(ImpactNormal)].As<Vector_NetQuantizeNormal>(); } set { this["ImpactNormal"] = value; } }
        public Vector_NetQuantize TraceStart { get { return this[nameof(TraceStart)].As<Vector_NetQuantize>(); } set { this["TraceStart"] = value; } }
        public Vector_NetQuantize TraceEnd { get { return this[nameof(TraceEnd)].As<Vector_NetQuantize>(); } set { this["TraceEnd"] = value; } }
        public Object Actor { get { return this[nameof(Actor)]; } set { this[nameof(Actor)] = value; } }
        public Object BoneName { get { return this[nameof(BoneName)]; } set { this[nameof(BoneName)] = value; } }
    }
    public class LineTraceInfo : Object
    {
        public LineTraceInfo(ulong addr) : base(addr) { }
        public Vector_NetQuantize StartTrace { get { return this[nameof(StartTrace)].As<Vector_NetQuantize>(); } set { this["StartTrace"] = value; } }
        public Vector_NetQuantize EndTrace { get { return this[nameof(EndTrace)].As<Vector_NetQuantize>(); } set { this["EndTrace"] = value; } }
    }
    public class AutoAimQueryParams : Object
    {
        public AutoAimQueryParams(ulong addr) : base(addr) { }
        public float AutoAimRange { get { return this[nameof(AutoAimRange)].GetValue<float>(); } set { this[nameof(AutoAimRange)].SetValue<float>(value); } }
        public float AutoAimSphereRadius { get { return this[nameof(AutoAimSphereRadius)].GetValue<float>(); } set { this[nameof(AutoAimSphereRadius)].SetValue<float>(value); } }
        public float AutoAimMaxSphereRadiusMultiplier { get { return this[nameof(AutoAimMaxSphereRadiusMultiplier)].GetValue<float>(); } set { this[nameof(AutoAimMaxSphereRadiusMultiplier)].SetValue<float>(value); } }
        public float AutoAimMaxRadiusAutoScale { get { return this[nameof(AutoAimMaxRadiusAutoScale)].GetValue<float>(); } set { this[nameof(AutoAimMaxRadiusAutoScale)].SetValue<float>(value); } }
        public float AutoAimMinRadiusRange { get { return this[nameof(AutoAimMinRadiusRange)].GetValue<float>(); } set { this[nameof(AutoAimMinRadiusRange)].SetValue<float>(value); } }
        public float AutoAimMaxRadiusRange { get { return this[nameof(AutoAimMaxRadiusRange)].GetValue<float>(); } set { this[nameof(AutoAimMaxRadiusRange)].SetValue<float>(value); } }
        public bool bDynamicAutoAimRadius { get { return this[nameof(bDynamicAutoAimRadius)].Flag; } set { this[nameof(bDynamicAutoAimRadius)].Flag = value; } }
        public bool bDoAutoAim { get { return this[nameof(bDoAutoAim)].Flag; } set { this[nameof(bDoAutoAim)].Flag = value; } }
    }
    public class DecalData : Object
    {
        public DecalData(ulong addr) : base(addr) { }
        public Material DecalMaterial { get { return this[nameof(DecalMaterial)].As<Material>(); } set { this["DecalMaterial"] = value; } }
        public float DecalSize { get { return this[nameof(DecalSize)].GetValue<float>(); } set { this[nameof(DecalSize)].SetValue<float>(value); } }
        public float LifeSpan { get { return this[nameof(LifeSpan)].GetValue<float>(); } set { this[nameof(LifeSpan)].SetValue<float>(value); } }
    }
    public class TextChatData : Object
    {
        public TextChatData(ulong addr) : base(addr) { }
        public Object SenderName { get { return this[nameof(SenderName)]; } set { this[nameof(SenderName)] = value; } }
        public UniqueNetIdRepl SenderID { get { return this[nameof(SenderID)].As<UniqueNetIdRepl>(); } set { this["SenderID"] = value; } }
        public Object SenderText { get { return this[nameof(SenderText)]; } set { this[nameof(SenderText)] = value; } }
        public Object NiceText { get { return this[nameof(NiceText)]; } set { this[nameof(NiceText)] = value; } }
        public EChatType ChatType { get { return (EChatType)this[nameof(ChatType)].GetValue<int>(); } set { this[nameof(ChatType)].SetValue<int>((int)value); } }
    }
    public class VIPInfo : Object
    {
        public VIPInfo(ulong addr) : base(addr) { }
        public bool bIsVIP { get { return this[nameof(bIsVIP)].Flag; } set { this[nameof(bIsVIP)].Flag = value; } }
        public byte CharacterID { get { return this[nameof(CharacterID)].GetValue<byte>(); } set { this[nameof(CharacterID)].SetValue<byte>(value); } }
    }
    public class PendingBotInfo : Object
    {
        public PendingBotInfo(ulong addr) : base(addr) { }
        public int BotId { get { return this[nameof(BotId)].GetValue<int>(); } set { this[nameof(BotId)].SetValue<int>(value); } }
        public byte DesiredTeamNum { get { return this[nameof(DesiredTeamNum)].GetValue<byte>(); } set { this[nameof(DesiredTeamNum)].SetValue<byte>(value); } }
        public TimerHandle CreationTimerHandle { get { return this[nameof(CreationTimerHandle)].As<TimerHandle>(); } set { this["CreationTimerHandle"] = value; } }
    }
    public class VoteOption : Object
    {
        public VoteOption(ulong addr) : base(addr) { }
        public Object MapName { get { return this[nameof(MapName)]; } set { this[nameof(MapName)] = value; } }
        public Object ModeAlias { get { return this[nameof(ModeAlias)]; } set { this[nameof(ModeAlias)] = value; } }
        public bool bIsRandom { get { return this[nameof(bIsRandom)].Flag; } set { this[nameof(bIsRandom)].Flag = value; } }
        public bool bHideMode { get { return this[nameof(bHideMode)].Flag; } set { this[nameof(bHideMode)].Flag = value; } }
    }
    public class ProjectileWeaponData : Object
    {
        public ProjectileWeaponData(ulong addr) : base(addr) { }
        public Object ProjectileClass { get { return this[nameof(ProjectileClass)]; } set { this[nameof(ProjectileClass)] = value; } }
        public float ProjectileLife { get { return this[nameof(ProjectileLife)].GetValue<float>(); } set { this[nameof(ProjectileLife)].SetValue<float>(value); } }
        public float ExplosionDamage { get { return this[nameof(ExplosionDamage)].GetValue<float>(); } set { this[nameof(ExplosionDamage)].SetValue<float>(value); } }
        public float DamageFalloff { get { return this[nameof(DamageFalloff)].GetValue<float>(); } set { this[nameof(DamageFalloff)].SetValue<float>(value); } }
        public float MinimumDamage { get { return this[nameof(MinimumDamage)].GetValue<float>(); } set { this[nameof(MinimumDamage)].SetValue<float>(value); } }
        public Object DamageType { get { return this[nameof(DamageType)]; } set { this[nameof(DamageType)] = value; } }
    }
    public class RocketStateSpecificMontages : Object
    {
        public RocketStateSpecificMontages(ulong addr) : base(addr) { }
        public WeaponAnimMontage EmptyMontage { get { return this[nameof(EmptyMontage)].As<WeaponAnimMontage>(); } set { this["EmptyMontage"] = value; } }
        public WeaponAnimMontage FullMontage { get { return this[nameof(FullMontage)].As<WeaponAnimMontage>(); } set { this["FullMontage"] = value; } }
    }
    public class FontMeshData : TableRowBase
    {
        public FontMeshData(ulong addr) : base(addr) { }
        public Object Character { get { return this[nameof(Character)]; } set { this[nameof(Character)] = value; } }
        public Object Mesh { get { return this[nameof(Mesh)]; } set { this[nameof(Mesh)] = value; } }
    }
    public class DamageEvents : Object
    {
        public DamageEvents(ulong addr) : base(addr) { }
        public Array<PWPointDamageEvent> dmgEvents { get { return new Array<PWPointDamageEvent>(this[nameof(dmgEvents)].Address); } }
    }
}
