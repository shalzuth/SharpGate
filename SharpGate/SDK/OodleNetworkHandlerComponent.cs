using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
namespace SDK.Script.OodleNetworkHandlerComponentSDK
{
    public class OodleNetworkTrainerCommandlet : Commandlet
    {
        public OodleNetworkTrainerCommandlet(ulong addr) : base(addr) { }
        public bool bCompressionTest { get { return this[nameof(bCompressionTest)].Flag; } set { this[nameof(bCompressionTest)].Flag = value; } }
        public int HashTableSize { get { return this[nameof(HashTableSize)].GetValue<int>(); } set { this[nameof(HashTableSize)].SetValue<int>(value); } }
        public int DictionarySize { get { return this[nameof(DictionarySize)].GetValue<int>(); } set { this[nameof(DictionarySize)].SetValue<int>(value); } }
        public int DictionaryTrials { get { return this[nameof(DictionaryTrials)].GetValue<int>(); } set { this[nameof(DictionaryTrials)].SetValue<int>(value); } }
        public int TrialRandomness { get { return this[nameof(TrialRandomness)].GetValue<int>(); } set { this[nameof(TrialRandomness)].SetValue<int>(value); } }
        public int TrialGenerations { get { return this[nameof(TrialGenerations)].GetValue<int>(); } set { this[nameof(TrialGenerations)].SetValue<int>(value); } }
        public bool bNoTrials { get { return this[nameof(bNoTrials)].Flag; } set { this[nameof(bNoTrials)].Flag = value; } }
    }
    public enum EOodleEnableMode : int
    {
        AlwaysEnabled = 0,
        WhenCompressedPacketReceived = 1,
        EOodleEnableMode_MAX = 2,
    }
}
