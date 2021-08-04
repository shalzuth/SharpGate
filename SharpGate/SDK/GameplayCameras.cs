using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.TemplateSequenceSDK;
using SDK.Script.MovieSceneTracksSDK;
namespace SDK.Script.GameplayCamerasSDK
{
    public class TestCameraShake : CameraShakeBase
    {
        public TestCameraShake(ulong addr) : base(addr) { }
    }
    public class SimpleCameraShakePattern : CameraShakePattern
    {
        public SimpleCameraShakePattern(ulong addr) : base(addr) { }
        public float Duration { get { return this[nameof(Duration)].GetValue<float>(); } set { this[nameof(Duration)].SetValue<float>(value); } }
        public float BlendInTime { get { return this[nameof(BlendInTime)].GetValue<float>(); } set { this[nameof(BlendInTime)].SetValue<float>(value); } }
        public float BlendOutTime { get { return this[nameof(BlendOutTime)].GetValue<float>(); } set { this[nameof(BlendOutTime)].SetValue<float>(value); } }
    }
    public class ConstantCameraShakePattern : SimpleCameraShakePattern
    {
        public ConstantCameraShakePattern(ulong addr) : base(addr) { }
        public Vector LocationOffset { get { return this[nameof(LocationOffset)].As<Vector>(); } set { this["LocationOffset"] = value; } }
        public Rotator RotationOffset { get { return this[nameof(RotationOffset)].As<Rotator>(); } set { this["RotationOffset"] = value; } }
    }
    public class CompositeCameraShakePattern : CameraShakePattern
    {
        public CompositeCameraShakePattern(ulong addr) : base(addr) { }
        public Array<CameraShakePattern> ChildPatterns { get { return new Array<CameraShakePattern>(this[nameof(ChildPatterns)].Address); } }
    }
    public class DefaultCameraShakeBase : CameraShakeBase
    {
        public DefaultCameraShakeBase(ulong addr) : base(addr) { }
    }
    public class MatineeCameraShake : CameraShakeBase
    {
        public MatineeCameraShake(ulong addr) : base(addr) { }
        public float OscillationDuration { get { return this[nameof(OscillationDuration)].GetValue<float>(); } set { this[nameof(OscillationDuration)].SetValue<float>(value); } }
        public float OscillationBlendInTime { get { return this[nameof(OscillationBlendInTime)].GetValue<float>(); } set { this[nameof(OscillationBlendInTime)].SetValue<float>(value); } }
        public float OscillationBlendOutTime { get { return this[nameof(OscillationBlendOutTime)].GetValue<float>(); } set { this[nameof(OscillationBlendOutTime)].SetValue<float>(value); } }
        public ROscillator RotOscillation { get { return this[nameof(RotOscillation)].As<ROscillator>(); } set { this["RotOscillation"] = value; } }
        public VOscillator LocOscillation { get { return this[nameof(LocOscillation)].As<VOscillator>(); } set { this["LocOscillation"] = value; } }
        public FOscillator FOVOscillation { get { return this[nameof(FOVOscillation)].As<FOscillator>(); } set { this["FOVOscillation"] = value; } }
        public float AnimPlayRate { get { return this[nameof(AnimPlayRate)].GetValue<float>(); } set { this[nameof(AnimPlayRate)].SetValue<float>(value); } }
        public float AnimScale { get { return this[nameof(AnimScale)].GetValue<float>(); } set { this[nameof(AnimScale)].SetValue<float>(value); } }
        public float AnimBlendInTime { get { return this[nameof(AnimBlendInTime)].GetValue<float>(); } set { this[nameof(AnimBlendInTime)].SetValue<float>(value); } }
        public float AnimBlendOutTime { get { return this[nameof(AnimBlendOutTime)].GetValue<float>(); } set { this[nameof(AnimBlendOutTime)].SetValue<float>(value); } }
        public float RandomAnimSegmentDuration { get { return this[nameof(RandomAnimSegmentDuration)].GetValue<float>(); } set { this[nameof(RandomAnimSegmentDuration)].SetValue<float>(value); } }
        public CameraAnim Anim { get { return this[nameof(Anim)].As<CameraAnim>(); } set { this["Anim"] = value; } }
        public CameraAnimationSequence AnimSequence { get { return this[nameof(AnimSequence)].As<CameraAnimationSequence>(); } set { this["AnimSequence"] = value; } }
        public bool bRandomAnimSegment { get { return this[nameof(bRandomAnimSegment)].Flag; } set { this[nameof(bRandomAnimSegment)].Flag = value; } }
        public float OscillatorTimeRemaining { get { return this[nameof(OscillatorTimeRemaining)].GetValue<float>(); } set { this[nameof(OscillatorTimeRemaining)].SetValue<float>(value); } }
        public CameraAnimInst AnimInst { get { return this[nameof(AnimInst)].As<CameraAnimInst>(); } set { this["AnimInst"] = value; } }
        public SequenceCameraShakePattern SequenceShakePattern { get { return this[nameof(SequenceShakePattern)].As<SequenceCameraShakePattern>(); } set { this["SequenceShakePattern"] = value; } }
        public MatineeCameraShake StartMatineeCameraShakeFromSource(PlayerCameraManager PlayerCameraManager, Object ShakeClass, CameraShakeSourceComponent SourceComponent, float Scale, ECameraShakePlaySpace PlaySpace, Rotator UserPlaySpaceRot) { return Invoke<MatineeCameraShake>(nameof(StartMatineeCameraShakeFromSource), PlayerCameraManager, ShakeClass, SourceComponent, Scale, PlaySpace, UserPlaySpaceRot); }
        public MatineeCameraShake StartMatineeCameraShake(PlayerCameraManager PlayerCameraManager, Object ShakeClass, float Scale, ECameraShakePlaySpace PlaySpace, Rotator UserPlaySpaceRot) { return Invoke<MatineeCameraShake>(nameof(StartMatineeCameraShake), PlayerCameraManager, ShakeClass, Scale, PlaySpace, UserPlaySpaceRot); }
        public void ReceiveStopShake(bool bImmediately) { Invoke(nameof(ReceiveStopShake), bImmediately); }
        public void ReceivePlayShake(float Scale) { Invoke(nameof(ReceivePlayShake), Scale); }
        public bool ReceiveIsFinished() { return Invoke<bool>(nameof(ReceiveIsFinished)); }
        public void BlueprintUpdateCameraShake(float DeltaTime, float Alpha, MinimalViewInfo POV, MinimalViewInfo ModifiedPOV) { Invoke(nameof(BlueprintUpdateCameraShake), DeltaTime, Alpha, POV, ModifiedPOV); }
    }
    public class MatineeCameraShakePattern : CameraShakePattern
    {
        public MatineeCameraShakePattern(ulong addr) : base(addr) { }
    }
    public class MovieSceneMatineeCameraShakeEvaluator : MovieSceneCameraShakeEvaluator
    {
        public MovieSceneMatineeCameraShakeEvaluator(ulong addr) : base(addr) { }
    }
    public class MatineeCameraShakeFunctionLibrary : BlueprintFunctionLibrary
    {
        public MatineeCameraShakeFunctionLibrary(ulong addr) : base(addr) { }
        public MatineeCameraShake Conv_MatineeCameraShake(CameraShakeBase CameraShake) { return Invoke<MatineeCameraShake>(nameof(Conv_MatineeCameraShake), CameraShake); }
    }
    public class PerlinNoiseCameraShakePattern : SimpleCameraShakePattern
    {
        public PerlinNoiseCameraShakePattern(ulong addr) : base(addr) { }
        public float LocationAmplitudeMultiplier { get { return this[nameof(LocationAmplitudeMultiplier)].GetValue<float>(); } set { this[nameof(LocationAmplitudeMultiplier)].SetValue<float>(value); } }
        public float LocationFrequencyMultiplier { get { return this[nameof(LocationFrequencyMultiplier)].GetValue<float>(); } set { this[nameof(LocationFrequencyMultiplier)].SetValue<float>(value); } }
        public PerlinNoiseShaker X { get { return this[nameof(X)].As<PerlinNoiseShaker>(); } set { this["X"] = value; } }
        public PerlinNoiseShaker Y { get { return this[nameof(Y)].As<PerlinNoiseShaker>(); } set { this["Y"] = value; } }
        public PerlinNoiseShaker Z { get { return this[nameof(Z)].As<PerlinNoiseShaker>(); } set { this["Z"] = value; } }
        public float RotationAmplitudeMultiplier { get { return this[nameof(RotationAmplitudeMultiplier)].GetValue<float>(); } set { this[nameof(RotationAmplitudeMultiplier)].SetValue<float>(value); } }
        public float RotationFrequencyMultiplier { get { return this[nameof(RotationFrequencyMultiplier)].GetValue<float>(); } set { this[nameof(RotationFrequencyMultiplier)].SetValue<float>(value); } }
        public PerlinNoiseShaker Pitch { get { return this[nameof(Pitch)].As<PerlinNoiseShaker>(); } set { this["Pitch"] = value; } }
        public PerlinNoiseShaker Yaw { get { return this[nameof(Yaw)].As<PerlinNoiseShaker>(); } set { this["Yaw"] = value; } }
        public PerlinNoiseShaker Roll { get { return this[nameof(Roll)].As<PerlinNoiseShaker>(); } set { this["Roll"] = value; } }
        public PerlinNoiseShaker FOV { get { return this[nameof(FOV)].As<PerlinNoiseShaker>(); } set { this["FOV"] = value; } }
    }
    public class WaveOscillatorCameraShakePattern : SimpleCameraShakePattern
    {
        public WaveOscillatorCameraShakePattern(ulong addr) : base(addr) { }
        public float LocationAmplitudeMultiplier { get { return this[nameof(LocationAmplitudeMultiplier)].GetValue<float>(); } set { this[nameof(LocationAmplitudeMultiplier)].SetValue<float>(value); } }
        public float LocationFrequencyMultiplier { get { return this[nameof(LocationFrequencyMultiplier)].GetValue<float>(); } set { this[nameof(LocationFrequencyMultiplier)].SetValue<float>(value); } }
        public WaveOscillator X { get { return this[nameof(X)].As<WaveOscillator>(); } set { this["X"] = value; } }
        public WaveOscillator Y { get { return this[nameof(Y)].As<WaveOscillator>(); } set { this["Y"] = value; } }
        public WaveOscillator Z { get { return this[nameof(Z)].As<WaveOscillator>(); } set { this["Z"] = value; } }
        public float RotationAmplitudeMultiplier { get { return this[nameof(RotationAmplitudeMultiplier)].GetValue<float>(); } set { this[nameof(RotationAmplitudeMultiplier)].SetValue<float>(value); } }
        public float RotationFrequencyMultiplier { get { return this[nameof(RotationFrequencyMultiplier)].GetValue<float>(); } set { this[nameof(RotationFrequencyMultiplier)].SetValue<float>(value); } }
        public WaveOscillator Pitch { get { return this[nameof(Pitch)].As<WaveOscillator>(); } set { this["Pitch"] = value; } }
        public WaveOscillator Yaw { get { return this[nameof(Yaw)].As<WaveOscillator>(); } set { this["Yaw"] = value; } }
        public WaveOscillator Roll { get { return this[nameof(Roll)].As<WaveOscillator>(); } set { this["Roll"] = value; } }
        public WaveOscillator FOV { get { return this[nameof(FOV)].As<WaveOscillator>(); } set { this["FOV"] = value; } }
    }
    public enum EInitialOscillatorOffset : int
    {
        EOO_OffsetRandom = 0,
        EOO_OffsetZero = 1,
        EOO_MAX = 2,
    }
    public enum EOscillatorWaveform : int
    {
        SineWave = 0,
        PerlinNoise = 1,
        EOscillatorWaveform_MAX = 2,
    }
    public enum EInitialWaveOscillatorOffsetType : int
    {
        Random = 0,
        Zero = 1,
        EInitialWaveOscillatorOffsetType_MAX = 2,
    }
    public class VOscillator : Object
    {
        public VOscillator(ulong addr) : base(addr) { }
        public FOscillator X { get { return this[nameof(X)].As<FOscillator>(); } set { this["X"] = value; } }
        public FOscillator Y { get { return this[nameof(Y)].As<FOscillator>(); } set { this["Y"] = value; } }
        public FOscillator Z { get { return this[nameof(Z)].As<FOscillator>(); } set { this["Z"] = value; } }
    }
    public class FOscillator : Object
    {
        public FOscillator(ulong addr) : base(addr) { }
        public float Amplitude { get { return this[nameof(Amplitude)].GetValue<float>(); } set { this[nameof(Amplitude)].SetValue<float>(value); } }
        public float Frequency { get { return this[nameof(Frequency)].GetValue<float>(); } set { this[nameof(Frequency)].SetValue<float>(value); } }
        public byte InitialOffset { get { return this[nameof(InitialOffset)].GetValue<byte>(); } set { this[nameof(InitialOffset)].SetValue<byte>(value); } }
        public EOscillatorWaveform Waveform { get { return (EOscillatorWaveform)this[nameof(Waveform)].GetValue<int>(); } set { this[nameof(Waveform)].SetValue<int>((int)value); } }
    }
    public class ROscillator : Object
    {
        public ROscillator(ulong addr) : base(addr) { }
        public FOscillator Pitch { get { return this[nameof(Pitch)].As<FOscillator>(); } set { this["Pitch"] = value; } }
        public FOscillator Yaw { get { return this[nameof(Yaw)].As<FOscillator>(); } set { this["Yaw"] = value; } }
        public FOscillator Roll { get { return this[nameof(Roll)].As<FOscillator>(); } set { this["Roll"] = value; } }
    }
    public class PerlinNoiseShaker : Object
    {
        public PerlinNoiseShaker(ulong addr) : base(addr) { }
        public float Amplitude { get { return this[nameof(Amplitude)].GetValue<float>(); } set { this[nameof(Amplitude)].SetValue<float>(value); } }
        public float Frequency { get { return this[nameof(Frequency)].GetValue<float>(); } set { this[nameof(Frequency)].SetValue<float>(value); } }
    }
    public class WaveOscillator : Object
    {
        public WaveOscillator(ulong addr) : base(addr) { }
        public float Amplitude { get { return this[nameof(Amplitude)].GetValue<float>(); } set { this[nameof(Amplitude)].SetValue<float>(value); } }
        public float Frequency { get { return this[nameof(Frequency)].GetValue<float>(); } set { this[nameof(Frequency)].SetValue<float>(value); } }
        public EInitialWaveOscillatorOffsetType InitialOffsetType { get { return (EInitialWaveOscillatorOffsetType)this[nameof(InitialOffsetType)].GetValue<int>(); } set { this[nameof(InitialOffsetType)].SetValue<int>((int)value); } }
    }
}
