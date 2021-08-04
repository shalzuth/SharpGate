using UnrealSharp;
using Object = UnrealSharp.UEObject;
namespace SDK.Script.DiscordRpcSDK
{
    public class DiscordRpc : Object
    {
        public DiscordRpc(ulong addr) : base(addr) { }
        public bool IsConnected { get { return this[nameof(IsConnected)].Flag; } set { this[nameof(IsConnected)].Flag = value; } }
        public Object OnConnected { get { return this[nameof(OnConnected)]; } set { this[nameof(OnConnected)] = value; } }
        public Object OnDisconnected { get { return this[nameof(OnDisconnected)]; } set { this[nameof(OnDisconnected)] = value; } }
        public Object OnErrored { get { return this[nameof(OnErrored)]; } set { this[nameof(OnErrored)] = value; } }
        public Object OnJoin { get { return this[nameof(OnJoin)]; } set { this[nameof(OnJoin)] = value; } }
        public Object OnSpectate { get { return this[nameof(OnSpectate)]; } set { this[nameof(OnSpectate)] = value; } }
        public Object OnJoinRequest { get { return this[nameof(OnJoinRequest)]; } set { this[nameof(OnJoinRequest)] = value; } }
        public DiscordRichPresence RichPresence { get { return this[nameof(RichPresence)].As<DiscordRichPresence>(); } set { this["RichPresence"] = value; } }
        public void UpdatePresence() { Invoke(nameof(UpdatePresence)); }
        public void Shutdown() { Invoke(nameof(Shutdown)); }
        public void RunCallbacks() { Invoke(nameof(RunCallbacks)); }
        public void Respond(Object userId, int Reply) { Invoke(nameof(Respond), userId, Reply); }
        public void Initialize(Object applicationId, bool autoRegister, Object optionalSteamId) { Invoke(nameof(Initialize), applicationId, autoRegister, optionalSteamId); }
        public void ClearPresence() { Invoke(nameof(ClearPresence)); }
    }
    public class DiscordUserData : Object
    {
        public DiscordUserData(ulong addr) : base(addr) { }
        public Object userId { get { return this[nameof(userId)]; } set { this[nameof(userId)] = value; } }
        public Object username { get { return this[nameof(username)]; } set { this[nameof(username)] = value; } }
        public Object discriminator { get { return this[nameof(discriminator)]; } set { this[nameof(discriminator)] = value; } }
        public Object avatar { get { return this[nameof(avatar)]; } set { this[nameof(avatar)] = value; } }
    }
    public enum EDiscordJoinResponseCodes : int
    {
        DISCORD_REPLY_NO = 0,
        DISCORD_REPLY_YES = 1,
        DISCORD_REPLY_IGNORE = 2,
        DISCORD_REPLY_MAX = 3,
    }
    public class DiscordRichPresence : Object
    {
        public DiscordRichPresence(ulong addr) : base(addr) { }
        public Object State { get { return this[nameof(State)]; } set { this[nameof(State)] = value; } }
        public Object details { get { return this[nameof(details)]; } set { this[nameof(details)] = value; } }
        public int startTimestamp { get { return this[nameof(startTimestamp)].GetValue<int>(); } set { this[nameof(startTimestamp)].SetValue<int>(value); } }
        public int endTimestamp { get { return this[nameof(endTimestamp)].GetValue<int>(); } set { this[nameof(endTimestamp)].SetValue<int>(value); } }
        public Object largeImageKey { get { return this[nameof(largeImageKey)]; } set { this[nameof(largeImageKey)] = value; } }
        public Object largeImageText { get { return this[nameof(largeImageText)]; } set { this[nameof(largeImageText)] = value; } }
        public Object smallImageKey { get { return this[nameof(smallImageKey)]; } set { this[nameof(smallImageKey)] = value; } }
        public Object smallImageText { get { return this[nameof(smallImageText)]; } set { this[nameof(smallImageText)] = value; } }
        public Object partyId { get { return this[nameof(partyId)]; } set { this[nameof(partyId)] = value; } }
        public int partySize { get { return this[nameof(partySize)].GetValue<int>(); } set { this[nameof(partySize)].SetValue<int>(value); } }
        public int partyMax { get { return this[nameof(partyMax)].GetValue<int>(); } set { this[nameof(partyMax)].SetValue<int>(value); } }
        public Object matchSecret { get { return this[nameof(matchSecret)]; } set { this[nameof(matchSecret)] = value; } }
        public Object joinSecret { get { return this[nameof(joinSecret)]; } set { this[nameof(joinSecret)] = value; } }
        public Object spectateSecret { get { return this[nameof(spectateSecret)]; } set { this[nameof(spectateSecret)] = value; } }
        public bool instance { get { return this[nameof(instance)].Flag; } set { this[nameof(instance)].Flag = value; } }
    }
}
