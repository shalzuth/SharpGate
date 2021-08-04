using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
namespace SDK.Script.ImgMediaEngineSDK
{
    public class ImgMediaPlaybackComponent : ActorComponent
    {
        public ImgMediaPlaybackComponent(ulong addr) : base(addr) { }
        public float Width { get { return this[nameof(Width)].GetValue<float>(); } set { this[nameof(Width)].SetValue<float>(value); } }
        public float LODBias { get { return this[nameof(LODBias)].GetValue<float>(); } set { this[nameof(LODBias)].SetValue<float>(value); } }
    }
}
