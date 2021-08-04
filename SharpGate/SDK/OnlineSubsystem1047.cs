using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.PortalWarsGlobalsSDK;
namespace SDK.Script.OnlineSubsystem1047SDK
{
    public enum EPlaylistGameModeType : int
    {
        Standard = 0,
        Featured = 1,
        EPlaylistGameModeType_MAX = 2,
    }
    public enum EFriendRequestType : int
    {
        Incoming = 0,
        Outgoing = 1,
        EFriendRequestType_MAX = 2,
    }
    public enum EStoreSectionType : int
    {
        Small = 0,
        Medium = 1,
        Big = 2,
        Featured = 3,
        EStoreSectionType_MAX = 4,
    }
    public enum EStoreItemType : int
    {
        Customization = 0,
        Bundle = 1,
        EStoreItemType_MAX = 2,
    }
    public class InviteInfo : Object
    {
        public InviteInfo(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public Object Type { get { return this[nameof(Type)]; } set { this[nameof(Type)] = value; } }
        public Object EncodedCompositePlatformId { get { return this[nameof(EncodedCompositePlatformId)]; } set { this[nameof(EncodedCompositePlatformId)] = value; } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
    }
    public class ReportPlayerRequestArgs : Object
    {
        public ReportPlayerRequestArgs(ulong addr) : base(addr) { }
        public Object EncodedCompositeUserId { get { return this[nameof(EncodedCompositeUserId)]; } set { this[nameof(EncodedCompositeUserId)] = value; } }
        public Object EncodedCompositePlatformUserId { get { return this[nameof(EncodedCompositePlatformUserId)]; } set { this[nameof(EncodedCompositePlatformUserId)] = value; } }
        public Object Category { get { return this[nameof(Category)]; } set { this[nameof(Category)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public Object GameSessionId { get { return this[nameof(GameSessionId)]; } set { this[nameof(GameSessionId)] = value; } }
    }
    public class SendClientLogsRequestArgs : Object
    {
        public SendClientLogsRequestArgs(ulong addr) : base(addr) { }
        public Object MetaData { get { return this[nameof(MetaData)]; } set { this[nameof(MetaData)] = value; } }
        public Object Logs { get { return this[nameof(Logs)]; } set { this[nameof(Logs)] = value; } }
    }
    public class RankLevelNotificationData : Object
    {
        public RankLevelNotificationData(ulong addr) : base(addr) { }
        public Object PlaylistType { get { return this[nameof(PlaylistType)]; } set { this[nameof(PlaylistType)] = value; } }
        public int RatingBefore { get { return this[nameof(RatingBefore)].GetValue<int>(); } set { this[nameof(RatingBefore)].SetValue<int>(value); } }
        public int RatingAfter { get { return this[nameof(RatingAfter)].GetValue<int>(); } set { this[nameof(RatingAfter)].SetValue<int>(value); } }
        public int LevelBefore { get { return this[nameof(LevelBefore)].GetValue<int>(); } set { this[nameof(LevelBefore)].SetValue<int>(value); } }
        public int LevelAfter { get { return this[nameof(LevelAfter)].GetValue<int>(); } set { this[nameof(LevelAfter)].SetValue<int>(value); } }
    }
    public class RewardNotificationData : Object
    {
        public RewardNotificationData(ulong addr) : base(addr) { }
        public Object Reason { get { return this[nameof(Reason)]; } set { this[nameof(Reason)] = value; } }
        public Array<RewardData> Rewards { get { return new Array<RewardData>(this[nameof(Rewards)].Address); } }
    }
    public class ItemShopMenuData : Object
    {
        public ItemShopMenuData(ulong addr) : base(addr) { }
        public Object ItemId { get { return this[nameof(ItemId)]; } set { this[nameof(ItemId)] = value; } }
    }
    public class TutorialStageCompletedData : Object
    {
        public TutorialStageCompletedData(ulong addr) : base(addr) { }
        public int Level { get { return this[nameof(Level)].GetValue<int>(); } set { this[nameof(Level)].SetValue<int>(value); } }
    }
    public class TutorialStartedData : Object
    {
        public TutorialStartedData(ulong addr) : base(addr) { }
        public bool IsAutomaticStart { get { return this[nameof(IsAutomaticStart)].Flag; } set { this[nameof(IsAutomaticStart)].Flag = value; } }
    }
    public class GetVivoxTokenResponseArgs : Object
    {
        public GetVivoxTokenResponseArgs(ulong addr) : base(addr) { }
        public bool Success { get { return this[nameof(Success)].Flag; } set { this[nameof(Success)].Flag = value; } }
        public ErrorInfo ErrorInfo { get { return this[nameof(ErrorInfo)].As<ErrorInfo>(); } set { this["ErrorInfo"] = value; } }
        public Object Uri { get { return this[nameof(Uri)]; } set { this[nameof(Uri)] = value; } }
        public Object Token { get { return this[nameof(Token)]; } set { this[nameof(Token)] = value; } }
    }
    public class GetVivoxTokenRequestArgs : Object
    {
        public GetVivoxTokenRequestArgs(ulong addr) : base(addr) { }
        public Object Type { get { return this[nameof(Type)]; } set { this[nameof(Type)] = value; } }
        public int Team { get { return this[nameof(Team)].GetValue<int>(); } set { this[nameof(Team)].SetValue<int>(value); } }
    }
    public class FinishRaceCourseRequestArgs : Object
    {
        public FinishRaceCourseRequestArgs(ulong addr) : base(addr) { }
        public Object Map { get { return this[nameof(Map)]; } set { this[nameof(Map)] = value; } }
        public int TimeMs { get { return this[nameof(TimeMs)].GetValue<int>(); } set { this[nameof(TimeMs)].SetValue<int>(value); } }
    }
    public class GetRaceCourseResultsResponseArgs : Object
    {
        public GetRaceCourseResultsResponseArgs(ulong addr) : base(addr) { }
        public UserRaceCourseInfo User { get { return this[nameof(User)].As<UserRaceCourseInfo>(); } set { this["User"] = value; } }
        public Array<UserRaceCourseInfo> Friends { get { return new Array<UserRaceCourseInfo>(this[nameof(Friends)].Address); } }
    }
    public class UserRaceCourseInfo : UserInfo
    {
        public UserRaceCourseInfo(ulong addr) : base(addr) { }
        public Array<RaceCourseResult> RaceCourseResults { get { return new Array<RaceCourseResult>(this[nameof(RaceCourseResults)].Address); } }
    }
    public class RaceCourseResult : Object
    {
        public RaceCourseResult(ulong addr) : base(addr) { }
        public Object Map { get { return this[nameof(Map)]; } set { this[nameof(Map)] = value; } }
        public int BestTimeMs { get { return this[nameof(BestTimeMs)].GetValue<int>(); } set { this[nameof(BestTimeMs)].SetValue<int>(value); } }
    }
    public class GetRaceCourseResultsRequestArgs : Object
    {
        public GetRaceCourseResultsRequestArgs(ulong addr) : base(addr) { }
        public Array<Object> EncodedCompositePlatformIds { get { return new Array<Object>(this[nameof(EncodedCompositePlatformIds)].Address); } }
    }
    public class OpenLootboxResponseArgs : Object
    {
        public OpenLootboxResponseArgs(ulong addr) : base(addr) { }
        public Array<LootboxItemInfo> LootboxContents { get { return new Array<LootboxItemInfo>(this[nameof(LootboxContents)].Address); } }
    }
    public class LootboxItemInfo : Object
    {
        public LootboxItemInfo(ulong addr) : base(addr) { }
        public int CustomizationKey { get { return this[nameof(CustomizationKey)].GetValue<int>(); } set { this[nameof(CustomizationKey)].SetValue<int>(value); } }
        public int CustomizationValue { get { return this[nameof(CustomizationValue)].GetValue<int>(); } set { this[nameof(CustomizationValue)].SetValue<int>(value); } }
        public bool Duplicate { get { return this[nameof(Duplicate)].Flag; } set { this[nameof(Duplicate)].Flag = value; } }
        public int CustomizationRarity { get { return this[nameof(CustomizationRarity)].GetValue<int>(); } set { this[nameof(CustomizationRarity)].SetValue<int>(value); } }
    }
    public class RedeemDlcKeyRequestArgs : Object
    {
        public RedeemDlcKeyRequestArgs(ulong addr) : base(addr) { }
        public Object Key { get { return this[nameof(Key)]; } set { this[nameof(Key)] = value; } }
    }
    public class RedeemItemRequestArgs : Object
    {
        public RedeemItemRequestArgs(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
    }
    public class RedeemBattlePassLevelsRequestArgs : Object
    {
        public RedeemBattlePassLevelsRequestArgs(ulong addr) : base(addr) { }
        public int NumLevels { get { return this[nameof(NumLevels)].GetValue<int>(); } set { this[nameof(NumLevels)].SetValue<int>(value); } }
    }
    public class RedeemBattlePassPremiumRequestArgs : Object
    {
        public RedeemBattlePassPremiumRequestArgs(ulong addr) : base(addr) { }
        public bool IsBundle { get { return this[nameof(IsBundle)].Flag; } set { this[nameof(IsBundle)].Flag = value; } }
    }
    public class FinalizeTransactionRequestArgs : Object
    {
        public FinalizeTransactionRequestArgs(ulong addr) : base(addr) { }
        public Object TransactionId { get { return this[nameof(TransactionId)]; } set { this[nameof(TransactionId)] = value; } }
        public int PurchasableId { get { return this[nameof(PurchasableId)].GetValue<int>(); } set { this[nameof(PurchasableId)].SetValue<int>(value); } }
        public Object CreatorCode { get { return this[nameof(CreatorCode)]; } set { this[nameof(CreatorCode)] = value; } }
        public int Price { get { return this[nameof(Price)].GetValue<int>(); } set { this[nameof(Price)].SetValue<int>(value); } }
        public Object CurrencyCode { get { return this[nameof(CurrencyCode)]; } set { this[nameof(CurrencyCode)] = value; } }
    }
    public class ReturnToMenuRequestArgs : Object
    {
        public ReturnToMenuRequestArgs(ulong addr) : base(addr) { }
        public Object GameSessionId { get { return this[nameof(GameSessionId)]; } set { this[nameof(GameSessionId)] = value; } }
    }
    public class SendInviteRequestArgs : InviteInfo
    {
        public SendInviteRequestArgs(ulong addr) : base(addr) { }
    }
    public class AcceptInviteRequestArgs : InviteInfo
    {
        public AcceptInviteRequestArgs(ulong addr) : base(addr) { }
    }
    public class GameSessionConfigArgs : Object
    {
        public GameSessionConfigArgs(ulong addr) : base(addr) { }
        public Object GameSessionId { get { return this[nameof(GameSessionId)]; } set { this[nameof(GameSessionId)] = value; } }
        public Object PlatformSessionID { get { return this[nameof(PlatformSessionID)]; } set { this[nameof(PlatformSessionID)] = value; } }
        public Object Ip { get { return this[nameof(Ip)]; } set { this[nameof(Ip)] = value; } }
        public int Port { get { return this[nameof(Port)].GetValue<int>(); } set { this[nameof(Port)].SetValue<int>(value); } }
        public Object EncryptionKey { get { return this[nameof(EncryptionKey)]; } set { this[nameof(EncryptionKey)] = value; } }
        public bool IsCrossplay { get { return this[nameof(IsCrossplay)].Flag; } set { this[nameof(IsCrossplay)].Flag = value; } }
    }
    public class GameSessionReconnectResponseArgs : GameSessionConfigArgs
    {
        public GameSessionReconnectResponseArgs(ulong addr) : base(addr) { }
    }
    public class GameSessionReconnectRequestArgs : Object
    {
        public GameSessionReconnectRequestArgs(ulong addr) : base(addr) { }
        public Object GameSessionId { get { return this[nameof(GameSessionId)]; } set { this[nameof(GameSessionId)] = value; } }
        public bool IsReconnect { get { return this[nameof(IsReconnect)].Flag; } set { this[nameof(IsReconnect)].Flag = value; } }
    }
    public class FindCustomGamesResponseArgs : Object
    {
        public FindCustomGamesResponseArgs(ulong addr) : base(addr) { }
        public Array<CustomGameResponseInfo> Sessions { get { return new Array<CustomGameResponseInfo>(this[nameof(Sessions)].Address); } }
    }
    public class CustomGameResponseInfo : Object
    {
        public CustomGameResponseInfo(ulong addr) : base(addr) { }
        public Object GameSessionId { get { return this[nameof(GameSessionId)]; } set { this[nameof(GameSessionId)] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object Password { get { return this[nameof(Password)]; } set { this[nameof(Password)] = value; } }
        public Object ServerType { get { return this[nameof(ServerType)]; } set { this[nameof(ServerType)] = value; } }
        public Object Region { get { return this[nameof(Region)]; } set { this[nameof(Region)] = value; } }
        public int PlayerCount { get { return this[nameof(PlayerCount)].GetValue<int>(); } set { this[nameof(PlayerCount)].SetValue<int>(value); } }
        public int MaxPlayerCount { get { return this[nameof(MaxPlayerCount)].GetValue<int>(); } set { this[nameof(MaxPlayerCount)].SetValue<int>(value); } }
        public int SpectatorCount { get { return this[nameof(SpectatorCount)].GetValue<int>(); } set { this[nameof(SpectatorCount)].SetValue<int>(value); } }
        public int MaxSpectatorCount { get { return this[nameof(MaxSpectatorCount)].GetValue<int>(); } set { this[nameof(MaxSpectatorCount)].SetValue<int>(value); } }
        public Object Map { get { return this[nameof(Map)]; } set { this[nameof(Map)] = value; } }
        public Object Mode { get { return this[nameof(Mode)]; } set { this[nameof(Mode)] = value; } }
        public Object GroupName { get { return this[nameof(GroupName)]; } set { this[nameof(GroupName)] = value; } }
        public bool IsCrossplay { get { return this[nameof(IsCrossplay)].Flag; } set { this[nameof(IsCrossplay)].Flag = value; } }
        public UserInfo CreatedBy { get { return this[nameof(CreatedBy)].As<UserInfo>(); } set { this["CreatedBy"] = value; } }
    }
    public class JoinCustomGameRequestArgs : Object
    {
        public JoinCustomGameRequestArgs(ulong addr) : base(addr) { }
        public Object GameSessionId { get { return this[nameof(GameSessionId)]; } set { this[nameof(GameSessionId)] = value; } }
        public Object Password { get { return this[nameof(Password)]; } set { this[nameof(Password)] = value; } }
        public bool AsSpectator { get { return this[nameof(AsSpectator)].Flag; } set { this[nameof(AsSpectator)].Flag = value; } }
    }
    public class CreateCustomGameRequestArgs : Object
    {
        public CreateCustomGameRequestArgs(ulong addr) : base(addr) { }
        public Object ServerType { get { return this[nameof(ServerType)]; } set { this[nameof(ServerType)] = value; } }
        public Object GameMode { get { return this[nameof(GameMode)]; } set { this[nameof(GameMode)] = value; } }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object Region { get { return this[nameof(Region)]; } set { this[nameof(Region)] = value; } }
        public Object Password { get { return this[nameof(Password)]; } set { this[nameof(Password)] = value; } }
        public int MaxPlayers { get { return this[nameof(MaxPlayers)].GetValue<int>(); } set { this[nameof(MaxPlayers)].SetValue<int>(value); } }
        public bool IsCrossplay { get { return this[nameof(IsCrossplay)].Flag; } set { this[nameof(IsCrossplay)].Flag = value; } }
    }
    public class CancelMatchmakingRequestArgs : Object
    {
        public CancelMatchmakingRequestArgs(ulong addr) : base(addr) { }
        public Object MatchmakingTicketID { get { return this[nameof(MatchmakingTicketID)]; } set { this[nameof(MatchmakingTicketID)] = value; } }
    }
    public class StartMatchmakingRequestArgs : Object
    {
        public StartMatchmakingRequestArgs(ulong addr) : base(addr) { }
        public Array<MatchmakingPlaylistInfo> Playlists { get { return new Array<MatchmakingPlaylistInfo>(this[nameof(Playlists)].Address); } }
        public Object Region { get { return this[nameof(Region)]; } set { this[nameof(Region)] = value; } }
        public bool IsCrossplay { get { return this[nameof(IsCrossplay)].Flag; } set { this[nameof(IsCrossplay)].Flag = value; } }
        public Object QueueReason { get { return this[nameof(QueueReason)]; } set { this[nameof(QueueReason)] = value; } }
        public Array<PingToRegionInfo> Pings { get { return new Array<PingToRegionInfo>(this[nameof(Pings)].Address); } }
    }
    public class MatchmakingPlaylistInfo : Object
    {
        public MatchmakingPlaylistInfo(ulong addr) : base(addr) { }
        public Object Type { get { return this[nameof(Type)]; } set { this[nameof(Type)] = value; } }
        public Array<Object> GameModes { get { return new Array<Object>(this[nameof(GameModes)].Address); } }
    }
    public class BlockActionRequestArgs : Object
    {
        public BlockActionRequestArgs(ulong addr) : base(addr) { }
        public Object EncodedCompositeUserId { get { return this[nameof(EncodedCompositeUserId)]; } set { this[nameof(EncodedCompositeUserId)] = value; } }
        public Object EncodedCompositePlatformId { get { return this[nameof(EncodedCompositePlatformId)]; } set { this[nameof(EncodedCompositePlatformId)] = value; } }
    }
    public class FriendRequestActionRequestArgs : Object
    {
        public FriendRequestActionRequestArgs(ulong addr) : base(addr) { }
        public Object EncodedCompositeUserId { get { return this[nameof(EncodedCompositeUserId)]; } set { this[nameof(EncodedCompositeUserId)] = value; } }
    }
    public class FriendRequestRequestArgs : Object
    {
        public FriendRequestRequestArgs(ulong addr) : base(addr) { }
        public Object EncodedCompositePlatformId { get { return this[nameof(EncodedCompositePlatformId)]; } set { this[nameof(EncodedCompositePlatformId)] = value; } }
        public Object FriendId { get { return this[nameof(FriendId)]; } set { this[nameof(FriendId)] = value; } }
    }
    public class GetBlockedPlayersResponseArgs : Object
    {
        public GetBlockedPlayersResponseArgs(ulong addr) : base(addr) { }
        public Array<FriendUserInfo> BlockedUsers { get { return new Array<FriendUserInfo>(this[nameof(BlockedUsers)].Address); } }
    }
    public class FriendUserInfo : UserInfo
    {
        public FriendUserInfo(ulong addr) : base(addr) { }
        public bool IsOnline { get { return this[nameof(IsOnline)].Flag; } set { this[nameof(IsOnline)].Flag = value; } }
    }
    public class GetRecentPlayersResponseArgs : Object
    {
        public GetRecentPlayersResponseArgs(ulong addr) : base(addr) { }
        public Array<RecentPlayerInfo> RecentlyEncounteredUsers { get { return new Array<RecentPlayerInfo>(this[nameof(RecentlyEncounteredUsers)].Address); } }
    }
    public class RecentPlayerInfo : FriendUserInfo
    {
        public RecentPlayerInfo(ulong addr) : base(addr) { }
        public long EncounteredAt { get { return this[nameof(EncounteredAt)].GetValue<long>(); } set { this[nameof(EncounteredAt)].SetValue<long>(value); } }
    }
    public class GetFriendsResponseArgs : Object
    {
        public GetFriendsResponseArgs(ulong addr) : base(addr) { }
        public Array<FriendUserInfo> Friends { get { return new Array<FriendUserInfo>(this[nameof(Friends)].Address); } }
    }
    public class PromotePartyMemberRequestArgs : Object
    {
        public PromotePartyMemberRequestArgs(ulong addr) : base(addr) { }
        public Object EncodedCompositeUserId { get { return this[nameof(EncodedCompositeUserId)]; } set { this[nameof(EncodedCompositeUserId)] = value; } }
    }
    public class KickPartyMemberRequestArgs : Object
    {
        public KickPartyMemberRequestArgs(ulong addr) : base(addr) { }
        public Object EncodedCompositeUserId { get { return this[nameof(EncodedCompositeUserId)]; } set { this[nameof(EncodedCompositeUserId)] = value; } }
    }
    public class OpenDropResponseArgs : Object
    {
        public OpenDropResponseArgs(ulong addr) : base(addr) { }
        public CustomizationId Customization { get { return this[nameof(Customization)].As<CustomizationId>(); } set { this["Customization"] = value; } }
    }
    public class ClaimChallengeRequestArgs : Object
    {
        public ClaimChallengeRequestArgs(ulong addr) : base(addr) { }
        public EChallengeType ChallengeType { get { return (EChallengeType)this[nameof(ChallengeType)].GetValue<int>(); } set { this[nameof(ChallengeType)].SetValue<int>((int)value); } }
        public int ChallengeId { get { return this[nameof(ChallengeId)].GetValue<int>(); } set { this[nameof(ChallengeId)].SetValue<int>(value); } }
    }
    public class RedeemReferFriendCodeRequestArgs : Object
    {
        public RedeemReferFriendCodeRequestArgs(ulong addr) : base(addr) { }
        public Object ReferralCode { get { return this[nameof(ReferralCode)]; } set { this[nameof(ReferralCode)] = value; } }
    }
    public class UpdateUserLocationDataRequestArgs : Object
    {
        public UpdateUserLocationDataRequestArgs(ulong addr) : base(addr) { }
        public Array<PingToRegionInfo> Pings { get { return new Array<PingToRegionInfo>(this[nameof(Pings)].Address); } }
    }
    public class UpdateChosenCustomizationsRequestArgs : Object
    {
        public UpdateChosenCustomizationsRequestArgs(ulong addr) : base(addr) { }
        public Array<CustomizationId> ChosenCustomizations { get { return new Array<CustomizationId>(this[nameof(ChosenCustomizations)].Address); } }
    }
    public class HeartbeatResponseArgs : Object
    {
        public HeartbeatResponseArgs(ulong addr) : base(addr) { }
        public int RefreshInMs { get { return this[nameof(RefreshInMs)].GetValue<int>(); } set { this[nameof(RefreshInMs)].SetValue<int>(value); } }
    }
    public class RefreshAuthTokenResponseArgs : Object
    {
        public RefreshAuthTokenResponseArgs(ulong addr) : base(addr) { }
        public Object AuthToken { get { return this[nameof(AuthToken)]; } set { this[nameof(AuthToken)] = value; } }
        public long RefreshInMs { get { return this[nameof(RefreshInMs)].GetValue<long>(); } set { this[nameof(RefreshInMs)].SetValue<long>(value); } }
    }
    public class RefreshAuthTokenRequestArgs : Object
    {
        public RefreshAuthTokenRequestArgs(ulong addr) : base(addr) { }
        public Object PlatformAuthToken { get { return this[nameof(PlatformAuthToken)]; } set { this[nameof(PlatformAuthToken)] = value; } }
    }
    public class GetAuthTokenResponseArgs : Object
    {
        public GetAuthTokenResponseArgs(ulong addr) : base(addr) { }
        public Object AuthToken { get { return this[nameof(AuthToken)]; } set { this[nameof(AuthToken)] = value; } }
        public Object userId { get { return this[nameof(userId)]; } set { this[nameof(userId)] = value; } }
        public long RefreshInMs { get { return this[nameof(RefreshInMs)].GetValue<long>(); } set { this[nameof(RefreshInMs)].SetValue<long>(value); } }
    }
    public class GetAuthTokenRequestArgs : Object
    {
        public GetAuthTokenRequestArgs(ulong addr) : base(addr) { }
        public Object Platform { get { return this[nameof(Platform)]; } set { this[nameof(Platform)] = value; } }
        public Object PlatformAuthToken { get { return this[nameof(PlatformAuthToken)]; } set { this[nameof(PlatformAuthToken)] = value; } }
        public Object PlatformTitleId { get { return this[nameof(PlatformTitleId)]; } set { this[nameof(PlatformTitleId)] = value; } }
        public Object PlatformEnvironment { get { return this[nameof(PlatformEnvironment)]; } set { this[nameof(PlatformEnvironment)] = value; } }
        public Object PlatformOs { get { return this[nameof(PlatformOs)]; } set { this[nameof(PlatformOs)] = value; } }
        public Object AuthToken { get { return this[nameof(AuthToken)]; } set { this[nameof(AuthToken)] = value; } }
        public int TimeDifferenceFromUTC { get { return this[nameof(TimeDifferenceFromUTC)].GetValue<int>(); } set { this[nameof(TimeDifferenceFromUTC)].SetValue<int>(value); } }
    }
    public class GetServerStatusResponseArgs : Object
    {
        public GetServerStatusResponseArgs(ulong addr) : base(addr) { }
        public bool IsLive { get { return this[nameof(IsLive)].Flag; } set { this[nameof(IsLive)].Flag = value; } }
        public Object ErrorCode { get { return this[nameof(ErrorCode)]; } set { this[nameof(ErrorCode)] = value; } }
        public Object ErrorText { get { return this[nameof(ErrorText)]; } set { this[nameof(ErrorText)] = value; } }
        public int RetryInMs { get { return this[nameof(RetryInMs)].GetValue<int>(); } set { this[nameof(RetryInMs)].SetValue<int>(value); } }
    }
    public class GetServerStatusRequestArgs : Object
    {
        public GetServerStatusRequestArgs(ulong addr) : base(addr) { }
        public Object EncodedCompositePlatformId { get { return this[nameof(EncodedCompositePlatformId)]; } set { this[nameof(EncodedCompositePlatformId)] = value; } }
    }
    public class PlaylistStatusInfo : Object
    {
        public PlaylistStatusInfo(ulong addr) : base(addr) { }
        public Object PlaylistType { get { return this[nameof(PlaylistType)]; } set { this[nameof(PlaylistType)] = value; } }
        public int MaxPartySize { get { return this[nameof(MaxPartySize)].GetValue<int>(); } set { this[nameof(MaxPartySize)].SetValue<int>(value); } }
        public bool IsActive { get { return this[nameof(IsActive)].Flag; } set { this[nameof(IsActive)].Flag = value; } }
        public long StartAtMs { get { return this[nameof(StartAtMs)].GetValue<long>(); } set { this[nameof(StartAtMs)].SetValue<long>(value); } }
        public long EndAtMs { get { return this[nameof(EndAtMs)].GetValue<long>(); } set { this[nameof(EndAtMs)].SetValue<long>(value); } }
        public int XpBoostPercentage { get { return this[nameof(XpBoostPercentage)].GetValue<int>(); } set { this[nameof(XpBoostPercentage)].SetValue<int>(value); } }
        public int MinProgressionLevel { get { return this[nameof(MinProgressionLevel)].GetValue<int>(); } set { this[nameof(MinProgressionLevel)].SetValue<int>(value); } }
        public Array<PlaylistGameModeInfo> GameModes { get { return new Array<PlaylistGameModeInfo>(this[nameof(GameModes)].Address); } }
        public int MinNumGameModesToSelect { get { return this[nameof(MinNumGameModesToSelect)].GetValue<int>(); } set { this[nameof(MinNumGameModesToSelect)].SetValue<int>(value); } }
    }
    public class PlaylistGameModeInfo : Object
    {
        public PlaylistGameModeInfo(ulong addr) : base(addr) { }
        public Object GameMode { get { return this[nameof(GameMode)]; } set { this[nameof(GameMode)] = value; } }
        public EPlaylistGameModeType Type { get { return (EPlaylistGameModeType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public int MaxPartySize { get { return this[nameof(MaxPartySize)].GetValue<int>(); } set { this[nameof(MaxPartySize)].SetValue<int>(value); } }
        public long EndAtMs { get { return this[nameof(EndAtMs)].GetValue<long>(); } set { this[nameof(EndAtMs)].SetValue<long>(value); } }
        public int MinProgressionLevel { get { return this[nameof(MinProgressionLevel)].GetValue<int>(); } set { this[nameof(MinProgressionLevel)].SetValue<int>(value); } }
    }
    public class NewsFeedInfo : Object
    {
        public NewsFeedInfo(ulong addr) : base(addr) { }
        public Object Title { get { return this[nameof(Title)]; } set { this[nameof(Title)] = value; } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public Object ImageUrl { get { return this[nameof(ImageUrl)]; } set { this[nameof(ImageUrl)] = value; } }
        public Object ActionType { get { return this[nameof(ActionType)]; } set { this[nameof(ActionType)] = value; } }
        public Object ActionTitle { get { return this[nameof(ActionTitle)]; } set { this[nameof(ActionTitle)] = value; } }
        public Object ActionValue { get { return this[nameof(ActionValue)]; } set { this[nameof(ActionValue)] = value; } }
    }
    public class RaceLeaderboardInfo : Object
    {
        public RaceLeaderboardInfo(ulong addr) : base(addr) { }
        public Object Map { get { return this[nameof(Map)]; } set { this[nameof(Map)] = value; } }
        public Array<RaceLeaderboardPlayerInfo> Leaders { get { return new Array<RaceLeaderboardPlayerInfo>(this[nameof(Leaders)].Address); } }
        public Array<RacePlatformLeaderboardInfo> PlatformLeaders { get { return new Array<RacePlatformLeaderboardInfo>(this[nameof(PlatformLeaders)].Address); } }
    }
    public class RacePlatformLeaderboardInfo : Object
    {
        public RacePlatformLeaderboardInfo(ulong addr) : base(addr) { }
        public Object Platform { get { return this[nameof(Platform)]; } set { this[nameof(Platform)] = value; } }
        public Array<RaceLeaderboardPlayerInfo> Leaders { get { return new Array<RaceLeaderboardPlayerInfo>(this[nameof(Leaders)].Address); } }
    }
    public class LeaderboardPlayerInfo : UserInfo
    {
        public LeaderboardPlayerInfo(ulong addr) : base(addr) { }
    }
    public class RaceLeaderboardPlayerInfo : LeaderboardPlayerInfo
    {
        public RaceLeaderboardPlayerInfo(ulong addr) : base(addr) { }
        public int TimeMs { get { return this[nameof(TimeMs)].GetValue<int>(); } set { this[nameof(TimeMs)].SetValue<int>(value); } }
    }
    public class RankLeaderboardInfo : Object
    {
        public RankLeaderboardInfo(ulong addr) : base(addr) { }
        public Object PlaylistType { get { return this[nameof(PlaylistType)]; } set { this[nameof(PlaylistType)] = value; } }
        public Array<RankLeaderboardPlayerInfo> Leaders { get { return new Array<RankLeaderboardPlayerInfo>(this[nameof(Leaders)].Address); } }
        public Array<RankPlatformLeaderboardInfo> PlatformLeaders { get { return new Array<RankPlatformLeaderboardInfo>(this[nameof(PlatformLeaders)].Address); } }
    }
    public class RankPlatformLeaderboardInfo : Object
    {
        public RankPlatformLeaderboardInfo(ulong addr) : base(addr) { }
        public Object Platform { get { return this[nameof(Platform)]; } set { this[nameof(Platform)] = value; } }
        public Array<RankLeaderboardPlayerInfo> Leaders { get { return new Array<RankLeaderboardPlayerInfo>(this[nameof(Leaders)].Address); } }
    }
    public class RankLeaderboardPlayerInfo : LeaderboardPlayerInfo
    {
        public RankLeaderboardPlayerInfo(ulong addr) : base(addr) { }
        public int RankXP { get { return this[nameof(RankXP)].GetValue<int>(); } set { this[nameof(RankXP)].SetValue<int>(value); } }
    }
    public class NoticeStatus : Object
    {
        public NoticeStatus(ulong addr) : base(addr) { }
        public Object NoticeCode { get { return this[nameof(NoticeCode)]; } set { this[nameof(NoticeCode)] = value; } }
        public Array<ErrorData> NoticeData { get { return new Array<ErrorData>(this[nameof(NoticeData)].Address); } }
        public long ExpirationTimeMs { get { return this[nameof(ExpirationTimeMs)].GetValue<long>(); } set { this[nameof(ExpirationTimeMs)].SetValue<long>(value); } }
    }
    public class FriendRequestInfo : UserInfo
    {
        public FriendRequestInfo(ulong addr) : base(addr) { }
        public long InvitedAt { get { return this[nameof(InvitedAt)].GetValue<long>(); } set { this[nameof(InvitedAt)].SetValue<long>(value); } }
        public EFriendRequestType Type { get { return (EFriendRequestType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
    }
    public class PartyUserInfo : UserInfo
    {
        public PartyUserInfo(ulong addr) : base(addr) { }
        public Array<UserRankInfo> UserRanks { get { return new Array<UserRankInfo>(this[nameof(UserRanks)].Address); } }
        public UserStatsInfo UserStats { get { return this[nameof(UserStats)].As<UserStatsInfo>(); } set { this["UserStats"] = value; } }
        public Array<CustomizationId> UserChosenCustomizations { get { return new Array<CustomizationId>(this[nameof(UserChosenCustomizations)].Address); } }
        public UserProgressionInfo UserProgression { get { return this[nameof(UserProgression)].As<UserProgressionInfo>(); } set { this["UserProgression"] = value; } }
        public UserDailyStreakInfo DailyPlayStreak { get { return this[nameof(DailyPlayStreak)].As<UserDailyStreakInfo>(); } set { this["DailyPlayStreak"] = value; } }
        public bool IsLeader { get { return this[nameof(IsLeader)].Flag; } set { this[nameof(IsLeader)].Flag = value; } }
    }
    public class StoreCategoryInfo : Object
    {
        public StoreCategoryInfo(ulong addr) : base(addr) { }
        public Object Title { get { return this[nameof(Title)]; } set { this[nameof(Title)] = value; } }
        public Array<StoreSectionInfo> Sections { get { return new Array<StoreSectionInfo>(this[nameof(Sections)].Address); } }
    }
    public class StoreSectionInfo : Object
    {
        public StoreSectionInfo(ulong addr) : base(addr) { }
        public Object Title { get { return this[nameof(Title)]; } set { this[nameof(Title)] = value; } }
        public EStoreSectionType Type { get { return (EStoreSectionType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public long ExpirationTimeMs { get { return this[nameof(ExpirationTimeMs)].GetValue<long>(); } set { this[nameof(ExpirationTimeMs)].SetValue<long>(value); } }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public Array<Object> Items { get { return new Array<Object>(this[nameof(Items)].Address); } }
    }
    public class StoreItemInfo : Object
    {
        public StoreItemInfo(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public int CurrencyCost { get { return this[nameof(CurrencyCost)].GetValue<int>(); } set { this[nameof(CurrencyCost)].SetValue<int>(value); } }
        public EStoreItemType ItemType { get { return (EStoreItemType)this[nameof(ItemType)].GetValue<int>(); } set { this[nameof(ItemType)].SetValue<int>((int)value); } }
        public int PurchasableId { get { return this[nameof(PurchasableId)].GetValue<int>(); } set { this[nameof(PurchasableId)].SetValue<int>(value); } }
    }
    public class StoreBundleItemInfo : StoreItemInfo
    {
        public StoreBundleItemInfo(ulong addr) : base(addr) { }
        public Object Title { get { return this[nameof(Title)]; } set { this[nameof(Title)] = value; } }
        public Object ImageUrl { get { return this[nameof(ImageUrl)]; } set { this[nameof(ImageUrl)] = value; } }
        public Object Rarity { get { return this[nameof(Rarity)]; } set { this[nameof(Rarity)] = value; } }
        public Array<Object> Items { get { return new Array<Object>(this[nameof(Items)].Address); } }
    }
    public class StoreCustomizationItemInfo : StoreItemInfo
    {
        public StoreCustomizationItemInfo(ulong addr) : base(addr) { }
        public CustomizationId Customization { get { return this[nameof(Customization)].As<CustomizationId>(); } set { this["Customization"] = value; } }
    }
    public class UserChallengeUpdate : Object
    {
        public UserChallengeUpdate(ulong addr) : base(addr) { }
        public EChallengeType Type { get { return (EChallengeType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int PrevValue { get { return this[nameof(PrevValue)].GetValue<int>(); } set { this[nameof(PrevValue)].SetValue<int>(value); } }
        public int NewValue { get { return this[nameof(NewValue)].GetValue<int>(); } set { this[nameof(NewValue)].SetValue<int>(value); } }
        public bool bJustCompleted { get { return this[nameof(bJustCompleted)].Flag; } set { this[nameof(bJustCompleted)].Flag = value; } }
    }
    public class UserRankUpdate : Object
    {
        public UserRankUpdate(ulong addr) : base(addr) { }
        public Object RankType { get { return this[nameof(RankType)]; } set { this[nameof(RankType)] = value; } }
        public UserRankInfo PrevRank { get { return this[nameof(PrevRank)].As<UserRankInfo>(); } set { this["PrevRank"] = value; } }
        public UserRankInfo NewRank { get { return this[nameof(NewRank)].As<UserRankInfo>(); } set { this["NewRank"] = value; } }
    }
    public class UserProgressionUpdate : Object
    {
        public UserProgressionUpdate(ulong addr) : base(addr) { }
        public Array<XPAllocation> XpAllocations { get { return new Array<XPAllocation>(this[nameof(XpAllocations)].Address); } }
        public bool IsPostGame { get { return this[nameof(IsPostGame)].Flag; } set { this[nameof(IsPostGame)].Flag = value; } }
        public UserProgressionInfo PrevProgression { get { return this[nameof(PrevProgression)].As<UserProgressionInfo>(); } set { this["PrevProgression"] = value; } }
        public UserProgressionInfo NewProgression { get { return this[nameof(NewProgression)].As<UserProgressionInfo>(); } set { this["NewProgression"] = value; } }
        public UserBattlePassProgressionInfo PrevBattlePassProgression { get { return this[nameof(PrevBattlePassProgression)].As<UserBattlePassProgressionInfo>(); } set { this["PrevBattlePassProgression"] = value; } }
        public UserBattlePassProgressionInfo NewBattlePassProgression { get { return this[nameof(NewBattlePassProgression)].As<UserBattlePassProgressionInfo>(); } set { this["NewBattlePassProgression"] = value; } }
    }
    public class UserPostGameStat : Object
    {
        public UserPostGameStat(ulong addr) : base(addr) { }
        public Object StatName { get { return this[nameof(StatName)]; } set { this[nameof(StatName)] = value; } }
        public Object Unit { get { return this[nameof(Unit)]; } set { this[nameof(Unit)] = value; } }
        public float Value { get { return this[nameof(Value)].GetValue<float>(); } set { this[nameof(Value)].SetValue<float>(value); } }
        public float LifetimeAvg { get { return this[nameof(LifetimeAvg)].GetValue<float>(); } set { this[nameof(LifetimeAvg)].SetValue<float>(value); } }
        public float ImprovementPercentage { get { return this[nameof(ImprovementPercentage)].GetValue<float>(); } set { this[nameof(ImprovementPercentage)].SetValue<float>(value); } }
        public int Placement { get { return this[nameof(Placement)].GetValue<int>(); } set { this[nameof(Placement)].SetValue<int>(value); } }
    }
    public class RequestClientLogsEventArgs : Object
    {
        public RequestClientLogsEventArgs(ulong addr) : base(addr) { }
        public Object MetaData { get { return this[nameof(MetaData)]; } set { this[nameof(MetaData)] = value; } }
    }
    public class RaceLeaderboardUpdateEventArgs : Object
    {
        public RaceLeaderboardUpdateEventArgs(ulong addr) : base(addr) { }
        public Array<RaceLeaderboardInfo> Leaderboards { get { return new Array<RaceLeaderboardInfo>(this[nameof(Leaderboards)].Address); } }
    }
    public class RankLeaderboardUpdateEventArgs : Object
    {
        public RankLeaderboardUpdateEventArgs(ulong addr) : base(addr) { }
        public Array<RankLeaderboardInfo> Leaderboards { get { return new Array<RankLeaderboardInfo>(this[nameof(Leaderboards)].Address); } }
    }
    public class NewsFeedUpdateEventArgs : Object
    {
        public NewsFeedUpdateEventArgs(ulong addr) : base(addr) { }
        public Array<NewsFeedInfo> NewsFeedEntries { get { return new Array<NewsFeedInfo>(this[nameof(NewsFeedEntries)].Address); } }
    }
    public class HappyHourStatusUpdateEventArgs : Object
    {
        public HappyHourStatusUpdateEventArgs(ulong addr) : base(addr) { }
        public long StartTimeMs { get { return this[nameof(StartTimeMs)].GetValue<long>(); } set { this[nameof(StartTimeMs)].SetValue<long>(value); } }
        public long EndTimeMs { get { return this[nameof(EndTimeMs)].GetValue<long>(); } set { this[nameof(EndTimeMs)].SetValue<long>(value); } }
    }
    public class PlaylistStatusUpdateEventArgs : Object
    {
        public PlaylistStatusUpdateEventArgs(ulong addr) : base(addr) { }
        public Array<PlaylistStatusInfo> Playlists { get { return new Array<PlaylistStatusInfo>(this[nameof(Playlists)].Address); } }
    }
    public class UserLimitedTimeOfferUpdateEventArgs : Object
    {
        public UserLimitedTimeOfferUpdateEventArgs(ulong addr) : base(addr) { }
        public StoreCategoryInfo LimitedTimeOfferCategory { get { return this[nameof(LimitedTimeOfferCategory)].As<StoreCategoryInfo>(); } set { this["LimitedTimeOfferCategory"] = value; } }
    }
    public class StoreUpdateEventArgs : Object
    {
        public StoreUpdateEventArgs(ulong addr) : base(addr) { }
        public Array<StoreCategoryInfo> Categories { get { return new Array<StoreCategoryInfo>(this[nameof(Categories)].Address); } }
    }
    public class UserInviteEventArgs : InviteInfo
    {
        public UserInviteEventArgs(ulong addr) : base(addr) { }
    }
    public class GameSessionReconnectAvailableEventArgs : Object
    {
        public GameSessionReconnectAvailableEventArgs(ulong addr) : base(addr) { }
        public Object GameSessionId { get { return this[nameof(GameSessionId)]; } set { this[nameof(GameSessionId)] = value; } }
        public float DurationMs { get { return this[nameof(DurationMs)].GetValue<float>(); } set { this[nameof(DurationMs)].SetValue<float>(value); } }
    }
    public class CustomGameFailedEventArgs : Object
    {
        public CustomGameFailedEventArgs(ulong addr) : base(addr) { }
        public ErrorInfo ErrorInfo { get { return this[nameof(ErrorInfo)].As<ErrorInfo>(); } set { this["ErrorInfo"] = value; } }
    }
    public class CustomGameJoinedEventArgs : GameSessionConfigArgs
    {
        public CustomGameJoinedEventArgs(ulong addr) : base(addr) { }
        public bool AsSpectator { get { return this[nameof(AsSpectator)].Flag; } set { this[nameof(AsSpectator)].Flag = value; } }
    }
    public class WaitingAreaFailedEventArgs : Object
    {
        public WaitingAreaFailedEventArgs(ulong addr) : base(addr) { }
        public ErrorInfo ErrorInfo { get { return this[nameof(ErrorInfo)].As<ErrorInfo>(); } set { this["ErrorInfo"] = value; } }
    }
    public class WaitingAreaJoinedEventArgs : GameSessionConfigArgs
    {
        public WaitingAreaJoinedEventArgs(ulong addr) : base(addr) { }
    }
    public class MatchmakingFailedEventArgs : Object
    {
        public MatchmakingFailedEventArgs(ulong addr) : base(addr) { }
        public ErrorInfo ErrorInfo { get { return this[nameof(ErrorInfo)].As<ErrorInfo>(); } set { this["ErrorInfo"] = value; } }
    }
    public class MatchmakingCompletedEventArgs : GameSessionConfigArgs
    {
        public MatchmakingCompletedEventArgs(ulong addr) : base(addr) { }
    }
    public class MatchmakingCanceledEventArgs : Object
    {
        public MatchmakingCanceledEventArgs(ulong addr) : base(addr) { }
    }
    public class MatchmakingStartedEventArgs : Object
    {
        public MatchmakingStartedEventArgs(ulong addr) : base(addr) { }
        public Array<MatchmakingPlaylistInfo> Playlists { get { return new Array<MatchmakingPlaylistInfo>(this[nameof(Playlists)].Address); } }
        public Object MatchmakingTicketID { get { return this[nameof(MatchmakingTicketID)]; } set { this[nameof(MatchmakingTicketID)] = value; } }
    }
    public class FriendRequestAcceptedEventArgs : FriendRequestInfo
    {
        public FriendRequestAcceptedEventArgs(ulong addr) : base(addr) { }
    }
    public class FriendRequestEventArgs : FriendRequestInfo
    {
        public FriendRequestEventArgs(ulong addr) : base(addr) { }
    }
    public class UserFriendRequestsUpdateEventArgs : Object
    {
        public UserFriendRequestsUpdateEventArgs(ulong addr) : base(addr) { }
        public Array<FriendRequestInfo> IncomingFriendRequests { get { return new Array<FriendRequestInfo>(this[nameof(IncomingFriendRequests)].Address); } }
        public Array<FriendRequestInfo> OutgoingFriendRequests { get { return new Array<FriendRequestInfo>(this[nameof(OutgoingFriendRequests)].Address); } }
    }
    public class PartyUpdateEventArgs : Object
    {
        public PartyUpdateEventArgs(ulong addr) : base(addr) { }
        public Object partyId { get { return this[nameof(partyId)]; } set { this[nameof(partyId)] = value; } }
        public Object PlatformSessionID { get { return this[nameof(PlatformSessionID)]; } set { this[nameof(PlatformSessionID)] = value; } }
        public Array<PartyUserInfo> Players { get { return new Array<PartyUserInfo>(this[nameof(Players)].Address); } }
    }
    public class UserAchievementsUnlockedEventArgs : Object
    {
        public UserAchievementsUnlockedEventArgs(ulong addr) : base(addr) { }
        public Array<int> Achievements { get { return new Array<int>(this[nameof(Achievements)].Address); } }
    }
    public class SeasonChallengesUpdateEventArgs : Object
    {
        public SeasonChallengesUpdateEventArgs(ulong addr) : base(addr) { }
        public long ExpirationTimeMs { get { return this[nameof(ExpirationTimeMs)].GetValue<long>(); } set { this[nameof(ExpirationTimeMs)].SetValue<long>(value); } }
        public int CurrentPhase { get { return this[nameof(CurrentPhase)].GetValue<int>(); } set { this[nameof(CurrentPhase)].SetValue<int>(value); } }
    }
    public class WeeklyChallengesUpdateEventArgs : Object
    {
        public WeeklyChallengesUpdateEventArgs(ulong addr) : base(addr) { }
        public long ExpirationTimeMs { get { return this[nameof(ExpirationTimeMs)].GetValue<long>(); } set { this[nameof(ExpirationTimeMs)].SetValue<long>(value); } }
        public int CurrentPhase { get { return this[nameof(CurrentPhase)].GetValue<int>(); } set { this[nameof(CurrentPhase)].SetValue<int>(value); } }
    }
    public class DailyChallengesUpdateEventArgs : Object
    {
        public DailyChallengesUpdateEventArgs(ulong addr) : base(addr) { }
        public long ExpirationTimeMs { get { return this[nameof(ExpirationTimeMs)].GetValue<long>(); } set { this[nameof(ExpirationTimeMs)].SetValue<long>(value); } }
        public Array<int> DailyChallenges { get { return new Array<int>(this[nameof(DailyChallenges)].Address); } }
    }
    public class UserAlertEventArgs : Object
    {
        public UserAlertEventArgs(ulong addr) : base(addr) { }
        public Object AlertCode { get { return this[nameof(AlertCode)]; } set { this[nameof(AlertCode)] = value; } }
        public Array<ErrorData> AlertData { get { return new Array<ErrorData>(this[nameof(AlertData)].Address); } }
    }
    public class UserFriendIdUpdateEventArgs : Object
    {
        public UserFriendIdUpdateEventArgs(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
    }
    public class UserReferralsUpdateEventArgs : Object
    {
        public UserReferralsUpdateEventArgs(ulong addr) : base(addr) { }
        public UserReferFriendInfo Referrals { get { return this[nameof(Referrals)].As<UserReferFriendInfo>(); } set { this["Referrals"] = value; } }
    }
    public class UserPostGameStatsEventArgs : Object
    {
        public UserPostGameStatsEventArgs(ulong addr) : base(addr) { }
        public Array<UserPostGameStat> PostGameStats { get { return new Array<UserPostGameStat>(this[nameof(PostGameStats)].Address); } }
    }
    public class UserProgressionUpdateEventArgs : Object
    {
        public UserProgressionUpdateEventArgs(ulong addr) : base(addr) { }
        public UserProgressionInfo Progression { get { return this[nameof(Progression)].As<UserProgressionInfo>(); } set { this["Progression"] = value; } }
        public UserBattlePassProgressionInfo BattlePassProgression { get { return this[nameof(BattlePassProgression)].As<UserBattlePassProgressionInfo>(); } set { this["BattlePassProgression"] = value; } }
        public Array<XPAllocation> XpAllocations { get { return new Array<XPAllocation>(this[nameof(XpAllocations)].Address); } }
        public bool IsPostGame { get { return this[nameof(IsPostGame)].Flag; } set { this[nameof(IsPostGame)].Flag = value; } }
    }
    public class UserSeasonRewardsUpdateEventArgs : UserSeasonRewardInfo
    {
        public UserSeasonRewardsUpdateEventArgs(ulong addr) : base(addr) { }
    }
    public class UserDailyPlayStreakUpdateEventArgs : Object
    {
        public UserDailyPlayStreakUpdateEventArgs(ulong addr) : base(addr) { }
        public UserDailyStreakInfo DailyPlayStreak { get { return this[nameof(DailyPlayStreak)].As<UserDailyStreakInfo>(); } set { this["DailyPlayStreak"] = value; } }
    }
    public class UserDailyCheckInUpdateEventArgs : Object
    {
        public UserDailyCheckInUpdateEventArgs(ulong addr) : base(addr) { }
        public UserDailyCheckInInfo DailyCheckIn { get { return this[nameof(DailyCheckIn)].As<UserDailyCheckInInfo>(); } set { this["DailyCheckIn"] = value; } }
    }
    public class UserRewardsEventArgs : Object
    {
        public UserRewardsEventArgs(ulong addr) : base(addr) { }
        public Object Type { get { return this[nameof(Type)]; } set { this[nameof(Type)] = value; } }
        public Array<RewardData> Rewards { get { return new Array<RewardData>(this[nameof(Rewards)].Address); } }
    }
    public class UserChallengesUpdateEventArgs : Object
    {
        public UserChallengesUpdateEventArgs(ulong addr) : base(addr) { }
        public UserChallengesInfo Daily { get { return this[nameof(Daily)].As<UserChallengesInfo>(); } set { this["Daily"] = value; } }
        public UserChallengesInfo Weekly { get { return this[nameof(Weekly)].As<UserChallengesInfo>(); } set { this["Weekly"] = value; } }
        public UserChallengesInfo Season { get { return this[nameof(Season)].As<UserChallengesInfo>(); } set { this["Season"] = value; } }
        public UserChallengesInfo Weapon { get { return this[nameof(Weapon)].As<UserChallengesInfo>(); } set { this["Weapon"] = value; } }
    }
    public class UserDropsUpdateEventArgs : Object
    {
        public UserDropsUpdateEventArgs(ulong addr) : base(addr) { }
        public int Count { get { return this[nameof(Count)].GetValue<int>(); } set { this[nameof(Count)].SetValue<int>(value); } }
    }
    public class UserCurrencyUpdateEventArgs : Object
    {
        public UserCurrencyUpdateEventArgs(ulong addr) : base(addr) { }
        public int Currency { get { return this[nameof(Currency)].GetValue<int>(); } set { this[nameof(Currency)].SetValue<int>(value); } }
        public int SecondaryCurrency { get { return this[nameof(SecondaryCurrency)].GetValue<int>(); } set { this[nameof(SecondaryCurrency)].SetValue<int>(value); } }
    }
    public class UserChosenCustomizationsUpdateEventArgs : Object
    {
        public UserChosenCustomizationsUpdateEventArgs(ulong addr) : base(addr) { }
        public Array<CustomizationId> ChosenCustomizations { get { return new Array<CustomizationId>(this[nameof(ChosenCustomizations)].Address); } }
    }
    public class UserCustomizationsUpdateEventArgs : Object
    {
        public UserCustomizationsUpdateEventArgs(ulong addr) : base(addr) { }
        public Array<UnlockedCustomizations> Customizations { get { return new Array<UnlockedCustomizations>(this[nameof(Customizations)].Address); } }
    }
    public class UnlockedCustomizations : Object
    {
        public UnlockedCustomizations(ulong addr) : base(addr) { }
        public ECustomizationType CustomizationType { get { return (ECustomizationType)this[nameof(CustomizationType)].GetValue<int>(); } set { this[nameof(CustomizationType)].SetValue<int>((int)value); } }
        public Array<Object> CustomizationValues { get { return new Array<Object>(this[nameof(CustomizationValues)].Address); } }
    }
    public class UserRanksUpdateEventArgs : Object
    {
        public UserRanksUpdateEventArgs(ulong addr) : base(addr) { }
        public Array<UserRankInfo> Ranks { get { return new Array<UserRankInfo>(this[nameof(Ranks)].Address); } }
    }
    public class UserStatsUpdateEventArgs : Object
    {
        public UserStatsUpdateEventArgs(ulong addr) : base(addr) { }
        public UserStatsInfo Overall { get { return this[nameof(Overall)].As<UserStatsInfo>(); } set { this["Overall"] = value; } }
        public Object Seasons { get { return this[nameof(Seasons)]; } set { this[nameof(Seasons)] = value; } }
    }
    public class UserSessionUpdateEventArgs : Object
    {
        public UserSessionUpdateEventArgs(ulong addr) : base(addr) { }
        public Object SessionId { get { return this[nameof(SessionId)]; } set { this[nameof(SessionId)] = value; } }
    }
    public class ReloginEventArgs : Object
    {
        public ReloginEventArgs(ulong addr) : base(addr) { }
        public Object Reason { get { return this[nameof(Reason)]; } set { this[nameof(Reason)] = value; } }
    }
    public class PostLoginEventArgs : Object
    {
        public PostLoginEventArgs(ulong addr) : base(addr) { }
    }
}
