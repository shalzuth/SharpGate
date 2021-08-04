using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.PacketHandlerSDK;
namespace SDK.Script.OnlineServicesSDK
{
    public class DummyEncryptionComponentFactory : HandlerComponentFactory
    {
        public DummyEncryptionComponentFactory(ulong addr) : base(addr) { }
    }
    public class EmptyResponseArgs : Object
    {
        public EmptyResponseArgs(ulong addr) : base(addr) { }
    }
    public class EmptyRequestArgs : Object
    {
        public EmptyRequestArgs(ulong addr) : base(addr) { }
    }
    public class SocketOpenData : Object
    {
        public SocketOpenData(ulong addr) : base(addr) { }
        public Object sid { get { return this[nameof(sid)]; } set { this[nameof(sid)] = value; } }
        public int PingInterval { get { return this[nameof(PingInterval)].GetValue<int>(); } set { this[nameof(PingInterval)].SetValue<int>(value); } }
        public int PingTimeout { get { return this[nameof(PingTimeout)].GetValue<int>(); } set { this[nameof(PingTimeout)].SetValue<int>(value); } }
    }
}
