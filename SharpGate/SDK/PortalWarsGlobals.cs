using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
using SDK.Script.InputCoreSDK;
namespace SDK.Script.PortalWarsGlobalsSDK
{
    public class PortalWarsDebugHelpers : BlueprintFunctionLibrary
    {
        public PortalWarsDebugHelpers(ulong addr) : base(addr) { }
    }
    public class PortalWarsGlobals : Object
    {
        public PortalWarsGlobals(ulong addr) : base(addr) { }
        public Object CustomizationTypeText { get { return this[nameof(CustomizationTypeText)]; } set { this[nameof(CustomizationTypeText)] = value; } }
        public Object CustomizationCategoryText { get { return this[nameof(CustomizationCategoryText)]; } set { this[nameof(CustomizationCategoryText)] = value; } }
        public Object CustomizationRarityText { get { return this[nameof(CustomizationRarityText)]; } set { this[nameof(CustomizationRarityText)] = value; } }
        public Object CustomizationRarityColor { get { return this[nameof(CustomizationRarityColor)]; } set { this[nameof(CustomizationRarityColor)] = value; } }
        public Object CustomizationRarityIcons { get { return this[nameof(CustomizationRarityIcons)]; } set { this[nameof(CustomizationRarityIcons)] = value; } }
        public Array<ECustomizationType> WeaponCustomizationTypes { get { return new Array<ECustomizationType>(this[nameof(WeaponCustomizationTypes)].Address); } }
        public Object CustomizationTables { get { return this[nameof(CustomizationTables)]; } set { this[nameof(CustomizationTables)] = value; } }
        public DataTable MasterSkinTable { get { return this[nameof(MasterSkinTable)].As<DataTable>(); } set { this["MasterSkinTable"] = value; } }
        public Object CustomizationThumbnailTables { get { return this[nameof(CustomizationThumbnailTables)]; } set { this[nameof(CustomizationThumbnailTables)] = value; } }
        public MaterialInterface SprayDecalMaterial { get { return this[nameof(SprayDecalMaterial)].As<MaterialInterface>(); } set { this["SprayDecalMaterial"] = value; } }
        public DataTable TextureSets { get { return this[nameof(TextureSets)].As<DataTable>(); } set { this["TextureSets"] = value; } }
        public DataTable Weapons { get { return this[nameof(Weapons)].As<DataTable>(); } set { this["Weapons"] = value; } }
        public DataTable Maps { get { return this[nameof(Maps)].As<DataTable>(); } set { this["Maps"] = value; } }
        public DataTable GameModes { get { return this[nameof(GameModes)].As<DataTable>(); } set { this["GameModes"] = value; } }
        public DataTable Medals { get { return this[nameof(Medals)].As<DataTable>(); } set { this["Medals"] = value; } }
        public Object ChallengeTables { get { return this[nameof(ChallengeTables)]; } set { this[nameof(ChallengeTables)] = value; } }
        public DataTable CheckInRewards { get { return this[nameof(CheckInRewards)].As<DataTable>(); } set { this["CheckInRewards"] = value; } }
        public DataTable PlayStreakRewards { get { return this[nameof(PlayStreakRewards)].As<DataTable>(); } set { this["PlayStreakRewards"] = value; } }
        public DataTable PlayStreakIcons { get { return this[nameof(PlayStreakIcons)].As<DataTable>(); } set { this["PlayStreakIcons"] = value; } }
        public DataTable Progression { get { return this[nameof(Progression)].As<DataTable>(); } set { this["Progression"] = value; } }
        public DataTable ProgressionIcons { get { return this[nameof(ProgressionIcons)].As<DataTable>(); } set { this["ProgressionIcons"] = value; } }
        public DataTable BattlePass { get { return this[nameof(BattlePass)].As<DataTable>(); } set { this["BattlePass"] = value; } }
        public DataTable ReferralPass { get { return this[nameof(ReferralPass)].As<DataTable>(); } set { this["ReferralPass"] = value; } }
        public Object RewardIcons { get { return this[nameof(RewardIcons)]; } set { this[nameof(RewardIcons)] = value; } }
        public DataTable Unlocks { get { return this[nameof(Unlocks)].As<DataTable>(); } set { this["Unlocks"] = value; } }
        public DataTable Ranks { get { return this[nameof(Ranks)].As<DataTable>(); } set { this["Ranks"] = value; } }
        public DataTable RankDivisions { get { return this[nameof(RankDivisions)].As<DataTable>(); } set { this["RankDivisions"] = value; } }
        public DataTable Playlists { get { return this[nameof(Playlists)].As<DataTable>(); } set { this["Playlists"] = value; } }
        public DataTable Regions { get { return this[nameof(Regions)].As<DataTable>(); } set { this["Regions"] = value; } }
        public DataTable MicroTxnPurchasables { get { return this[nameof(MicroTxnPurchasables)].As<DataTable>(); } set { this["MicroTxnPurchasables"] = value; } }
        public DataTable Redeemables { get { return this[nameof(Redeemables)].As<DataTable>(); } set { this["Redeemables"] = value; } }
        public DataTable Announcer { get { return this[nameof(Announcer)].As<DataTable>(); } set { this["Announcer"] = value; } }
        public DataTable BotProfiles { get { return this[nameof(BotProfiles)].As<DataTable>(); } set { this["BotProfiles"] = value; } }
        public DataTable CustomBotProfiles { get { return this[nameof(CustomBotProfiles)].As<DataTable>(); } set { this["CustomBotProfiles"] = value; } }
        public DataTable BannedWords { get { return this[nameof(BannedWords)].As<DataTable>(); } set { this["BannedWords"] = value; } }
        public DataTable NiceTexts { get { return this[nameof(NiceTexts)].As<DataTable>(); } set { this["NiceTexts"] = value; } }
        public DataTable WeaponReticles { get { return this[nameof(WeaponReticles)].As<DataTable>(); } set { this["WeaponReticles"] = value; } }
        public DataTable CustomReticles { get { return this[nameof(CustomReticles)].As<DataTable>(); } set { this["CustomReticles"] = value; } }
        public Texture2D DefaultAvatar { get { return this[nameof(DefaultAvatar)].As<Texture2D>(); } set { this["DefaultAvatar"] = value; } }
        public Object PlatformAvatars { get { return this[nameof(PlatformAvatars)]; } set { this[nameof(PlatformAvatars)] = value; } }
        public DataTable Tutorial { get { return this[nameof(Tutorial)].As<DataTable>(); } set { this["Tutorial"] = value; } }
        public DataTable XboxButtons { get { return this[nameof(XboxButtons)].As<DataTable>(); } set { this["XboxButtons"] = value; } }
        public DataTable PlayStationButtons { get { return this[nameof(PlayStationButtons)].As<DataTable>(); } set { this["PlayStationButtons"] = value; } }
        public DataTable MouseButtons { get { return this[nameof(MouseButtons)].As<DataTable>(); } set { this["MouseButtons"] = value; } }
        public DataTable Tips { get { return this[nameof(Tips)].As<DataTable>(); } set { this["Tips"] = value; } }
        public DataTable LockerTips { get { return this[nameof(LockerTips)].As<DataTable>(); } set { this["LockerTips"] = value; } }
        public DataTable WeaponPoses { get { return this[nameof(WeaponPoses)].As<DataTable>(); } set { this["WeaponPoses"] = value; } }
        public Array<Object> AlwaysLoadedSoundBanks { get { return new Array<Object>(this[nameof(AlwaysLoadedSoundBanks)].Address); } }
    }
    public class ErrorInfo : Object
    {
        public ErrorInfo(ulong addr) : base(addr) { }
        public Object ErrorCode { get { return this[nameof(ErrorCode)]; } set { this[nameof(ErrorCode)] = value; } }
        public Array<ErrorData> ErrorData { get { return new Array<ErrorData>(this[nameof(ErrorData)].Address); } }
        public Object ErrorText { get { return this[nameof(ErrorText)]; } set { this[nameof(ErrorText)] = value; } }
        public Object Code { get { return this[nameof(Code)]; } set { this[nameof(Code)] = value; } }
        public Object Message { get { return this[nameof(Message)]; } set { this[nameof(Message)] = value; } }
    }
    public class ErrorData : Object
    {
        public ErrorData(ulong addr) : base(addr) { }
        public Array<Object> Data { get { return new Array<Object>(this[nameof(Data)].Address); } }
    }
    public enum ECustomizationAvailability : int
    {
        Normal = 0,
        Default = 1,
        Challenge = 2,
        Reward = 3,
        Store = 4,
        Partner = 5,
        Streamer = 6,
        DLC = 7,
        VIP = 8,
        CreatorCode = 9,
        BattlePass = 10,
        ReferralPass = 11,
        Reserved = 12,
        Developer = 13,
        Decommissioned = 14,
        ECustomizationAvailability_MAX = 15,
    }
    public enum ECustomizationRarity : int
    {
        None = 0,
        Common = 1,
        Rare = 2,
        Epic = 3,
        Legendary = 4,
        ECustomizationRarity_MAX = 5,
    }
    public enum ECustomizationType : int
    {
        None = 0,
        Armor = 1,
        Jetpack = 2,
        PortalGun = 3,
        AssaultRifle = 4,
        Bat = 5,
        BattleRifle = 6,
        DMR = 7,
        Pistol = 8,
        PlasmaRifle = 9,
        Railgun = 10,
        RocketLauncher = 11,
        Shotgun = 12,
        SMG = 13,
        Sniper = 14,
        Oddball = 15,
        Portal = 16,
        Spray = 17,
        Emote = 18,
        NameTag = 19,
        Banner = 20,
        MAX = 21,
    }
    public enum EBotDifficulty : int
    {
        Easy = 0,
        Medium = 1,
        Hard = 2,
        EBotDifficulty_MAX = 3,
    }
    public enum EPurchasableType : int
    {
        Currency = 0,
        LimitedTimeOffer = 1,
        EPurchasableType_MAX = 2,
    }
    public enum EUnlockType : int
    {
        Playlist = 0,
        Challenges = 1,
        EUnlockType_MAX = 2,
    }
    public enum EChallengeType : int
    {
        None = 0,
        Daily = 1,
        Weekly = 2,
        Weapon = 3,
        Season = 4,
        Featured = 5,
        MAX = 6,
    }
    public enum ERewardType : int
    {
        None = 0,
        Customization = 1,
        XP = 2,
        XPBoost = 3,
        DoubleXP = 4,
        Currency = 5,
        Drop = 6,
        ERewardType_MAX = 7,
    }
    public enum ERegionSelectability : int
    {
        Matchmaking = 0,
        Custom = 1,
        MAX = 2,
    }
    public enum EVotingPriority : int
    {
        Normal = 0,
        High = 1,
        EVotingPriority_MAX = 2,
    }
    public enum EPlaylistType : int
    {
        Unranked = 0,
        Ranked = 1,
        Featured = 2,
        EPlaylistType_MAX = 3,
    }
    public enum EMapSelectability : int
    {
        None = 0,
        Default = 1,
        Race = 2,
        QA = 3,
        MAX = 4,
    }
    public enum EGameModeSelectability : int
    {
        None = 0,
        Custom = 1,
        Standard = 2,
        Hardcore = 3,
        MAX = 4,
    }
    public enum EServerType : int
    {
        LAN = 0,
        Unranked = 1,
        Ranked = 2,
        Custom = 3,
        Standard = 4,
        Simulation = 5,
        WaitingArea = 6,
        EServerType_MAX = 7,
    }
    public class RewardData : Object
    {
        public RewardData(ulong addr) : base(addr) { }
        public ERewardType RewardType { get { return (ERewardType)this[nameof(RewardType)].GetValue<int>(); } set { this[nameof(RewardType)].SetValue<int>((int)value); } }
        public int RewardValue { get { return this[nameof(RewardValue)].GetValue<int>(); } set { this[nameof(RewardValue)].SetValue<int>(value); } }
        public CustomizationId Customization { get { return this[nameof(Customization)].As<CustomizationId>(); } set { this["Customization"] = value; } }
        public bool IsLocked { get { return this[nameof(IsLocked)].Flag; } set { this[nameof(IsLocked)].Flag = value; } }
    }
    public class CustomizationId : Object
    {
        public CustomizationId(ulong addr) : base(addr) { }
        public ECustomizationType CustomizationType { get { return (ECustomizationType)this[nameof(CustomizationType)].GetValue<int>(); } set { this[nameof(CustomizationType)].SetValue<int>((int)value); } }
        public Object CustomizationValue { get { return this[nameof(CustomizationValue)]; } set { this[nameof(CustomizationValue)] = value; } }
    }
    public class ThumbnailData : TableRowBase
    {
        public ThumbnailData(ulong addr) : base(addr) { }
        public Object DisplayImageFeatured { get { return this[nameof(DisplayImageFeatured)]; } set { this[nameof(DisplayImageFeatured)] = value; } }
        public Object DisplayImage { get { return this[nameof(DisplayImage)]; } set { this[nameof(DisplayImage)] = value; } }
    }
    public class SkinTextureSetData : TableRowBase
    {
        public SkinTextureSetData(ulong addr) : base(addr) { }
        public ECustomizationType CustomizationType { get { return (ECustomizationType)this[nameof(CustomizationType)].GetValue<int>(); } set { this[nameof(CustomizationType)].SetValue<int>((int)value); } }
        public Object MeshName { get { return this[nameof(MeshName)]; } set { this[nameof(MeshName)] = value; } }
        public Object TextureSetName { get { return this[nameof(TextureSetName)]; } set { this[nameof(TextureSetName)] = value; } }
        public Array<SkinSlotTextureInfo> Slots { get { return new Array<SkinSlotTextureInfo>(this[nameof(Slots)].Address); } }
    }
    public class SkinSlotTextureInfo : Object
    {
        public SkinSlotTextureInfo(ulong addr) : base(addr) { }
        public Object SlotName { get { return this[nameof(SlotName)]; } set { this[nameof(SlotName)] = value; } }
        public Object Textures { get { return this[nameof(Textures)]; } set { this[nameof(Textures)] = value; } }
    }
    public class PWTableRowBase : TableRowBase
    {
        public PWTableRowBase(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
        public Object DisplayImage { get { return this[nameof(DisplayImage)]; } set { this[nameof(DisplayImage)] = value; } }
        public Object DisplayImageSmall { get { return this[nameof(DisplayImageSmall)]; } set { this[nameof(DisplayImageSmall)] = value; } }
    }
    public class CustomizationItem : PWTableRowBase
    {
        public CustomizationItem(ulong addr) : base(addr) { }
        public ECustomizationType CustomizationType { get { return (ECustomizationType)this[nameof(CustomizationType)].GetValue<int>(); } set { this[nameof(CustomizationType)].SetValue<int>((int)value); } }
        public AvailabilityInfo Availability { get { return this[nameof(Availability)].As<AvailabilityInfo>(); } set { this["Availability"] = value; } }
        public ECustomizationRarity Rarity { get { return (ECustomizationRarity)this[nameof(Rarity)].GetValue<int>(); } set { this[nameof(Rarity)].SetValue<int>((int)value); } }
    }
    public class AvailabilityInfo : Object
    {
        public AvailabilityInfo(ulong addr) : base(addr) { }
        public ECustomizationAvailability Availability { get { return (ECustomizationAvailability)this[nameof(Availability)].GetValue<int>(); } set { this[nameof(Availability)].SetValue<int>((int)value); } }
        public Object AvailabilityInfo_value { get { return this[nameof(AvailabilityInfo)]; } set { this[nameof(AvailabilityInfo)] = value; } }
    }
    public class NameTagCustomizationItem : CustomizationItem
    {
        public NameTagCustomizationItem(ulong addr) : base(addr) { }
        public LinearColor TextColor { get { return this[nameof(TextColor)].As<LinearColor>(); } set { this["TextColor"] = value; } }
    }
    public class EmoteCustomizationItem : CustomizationItem
    {
        public EmoteCustomizationItem(ulong addr) : base(addr) { }
        public Object AnimationSequence { get { return this[nameof(AnimationSequence)]; } set { this[nameof(AnimationSequence)] = value; } }
    }
    public class SprayCustomizationItem : CustomizationItem
    {
        public SprayCustomizationItem(ulong addr) : base(addr) { }
        public Object Texture { get { return this[nameof(Texture)]; } set { this[nameof(Texture)] = value; } }
    }
    public class MeshItem : CustomizationItem
    {
        public MeshItem(ulong addr) : base(addr) { }
        public Object DefaultMaterialInstance { get { return this[nameof(DefaultMaterialInstance)]; } set { this[nameof(DefaultMaterialInstance)] = value; } }
        public Object DefaultSkinName { get { return this[nameof(DefaultSkinName)]; } set { this[nameof(DefaultSkinName)] = value; } }
        public bool CompatibleWithAllSkins { get { return this[nameof(CompatibleWithAllSkins)].Flag; } set { this[nameof(CompatibleWithAllSkins)].Flag = value; } }
    }
    public class WeaponMeshItem : MeshItem
    {
        public WeaponMeshItem(ulong addr) : base(addr) { }
        public Object Mesh1P { get { return this[nameof(Mesh1P)]; } set { this[nameof(Mesh1P)] = value; } }
        public Object Mesh3P { get { return this[nameof(Mesh3P)]; } set { this[nameof(Mesh3P)] = value; } }
        public Object AmmoCounterSocketName { get { return this[nameof(AmmoCounterSocketName)]; } set { this[nameof(AmmoCounterSocketName)] = value; } }
    }
    public class PortalGunMeshItem : WeaponMeshItem
    {
        public PortalGunMeshItem(ulong addr) : base(addr) { }
        public Object FireAnimation { get { return this[nameof(FireAnimation)]; } set { this[nameof(FireAnimation)] = value; } }
    }
    public class JetpackMeshItem : MeshItem
    {
        public JetpackMeshItem(ulong addr) : base(addr) { }
        public Object Mesh { get { return this[nameof(Mesh)]; } set { this[nameof(Mesh)] = value; } }
        public Object IdleAnimation { get { return this[nameof(IdleAnimation)]; } set { this[nameof(IdleAnimation)] = value; } }
        public Object OpenAnimation { get { return this[nameof(OpenAnimation)]; } set { this[nameof(OpenAnimation)] = value; } }
        public Array<Object> FlameMeshes { get { return new Array<Object>(this[nameof(FlameMeshes)].Address); } }
    }
    public class PortalCustomizationItem : CustomizationItem
    {
        public PortalCustomizationItem(ulong addr) : base(addr) { }
        public Object Mesh { get { return this[nameof(Mesh)]; } set { this[nameof(Mesh)] = value; } }
        public Object MaterialInstance { get { return this[nameof(MaterialInstance)]; } set { this[nameof(MaterialInstance)] = value; } }
        public Object RingMesh { get { return this[nameof(RingMesh)]; } set { this[nameof(RingMesh)] = value; } }
        public Object RingMaterialInstance { get { return this[nameof(RingMaterialInstance)]; } set { this[nameof(RingMaterialInstance)] = value; } }
    }
    public class SuitMeshItem : MeshItem
    {
        public SuitMeshItem(ulong addr) : base(addr) { }
        public Object Mesh3P { get { return this[nameof(Mesh3P)]; } set { this[nameof(Mesh3P)] = value; } }
        public Object Mesh1P { get { return this[nameof(Mesh1P)]; } set { this[nameof(Mesh1P)] = value; } }
        public float JetpackOffset { get { return this[nameof(JetpackOffset)].GetValue<float>(); } set { this[nameof(JetpackOffset)].SetValue<float>(value); } }
        public float PortalGunOffset { get { return this[nameof(PortalGunOffset)].GetValue<float>(); } set { this[nameof(PortalGunOffset)].SetValue<float>(value); } }
        public SuitPreviewAnim PreviewAnimation { get { return this[nameof(PreviewAnimation)].As<SuitPreviewAnim>(); } set { this["PreviewAnimation"] = value; } }
        public Object PreviewMaterialInstance { get { return this[nameof(PreviewMaterialInstance)]; } set { this[nameof(PreviewMaterialInstance)] = value; } }
    }
    public class SuitPreviewAnim : Object
    {
        public SuitPreviewAnim(ulong addr) : base(addr) { }
        public Object Animation { get { return this[nameof(Animation)]; } set { this[nameof(Animation)] = value; } }
        public float PreviewTime { get { return this[nameof(PreviewTime)].GetValue<float>(); } set { this[nameof(PreviewTime)].SetValue<float>(value); } }
    }
    public class Skin : PWTableRowBase
    {
        public Skin(ulong addr) : base(addr) { }
        public Object MaterialInstance { get { return this[nameof(MaterialInstance)]; } set { this[nameof(MaterialInstance)] = value; } }
        public bool CompatibleWithAll { get { return this[nameof(CompatibleWithAll)].Flag; } set { this[nameof(CompatibleWithAll)].Flag = value; } }
        public Array<SkinCompatibilityInfo> Compatibles { get { return new Array<SkinCompatibilityInfo>(this[nameof(Compatibles)].Address); } }
        public Array<SkinCompatibilityInfo> Incompatibles { get { return new Array<SkinCompatibilityInfo>(this[nameof(Incompatibles)].Address); } }
        public ECustomizationRarity Rarity { get { return (ECustomizationRarity)this[nameof(Rarity)].GetValue<int>(); } set { this[nameof(Rarity)].SetValue<int>((int)value); } }
        public Object RarityOverrides { get { return this[nameof(RarityOverrides)]; } set { this[nameof(RarityOverrides)] = value; } }
        public AvailabilityInfo Availability { get { return this[nameof(Availability)].As<AvailabilityInfo>(); } set { this["Availability"] = value; } }
        public Array<AvailabilityOverride> AvailabilityOverrides { get { return new Array<AvailabilityOverride>(this[nameof(AvailabilityOverrides)].Address); } }
        public Array<SkinTextureSetOverride> TextureSetOverrides { get { return new Array<SkinTextureSetOverride>(this[nameof(TextureSetOverrides)].Address); } }
    }
    public class SkinTextureSetOverride : Object
    {
        public SkinTextureSetOverride(ulong addr) : base(addr) { }
        public ECustomizationType CustomizationType { get { return (ECustomizationType)this[nameof(CustomizationType)].GetValue<int>(); } set { this[nameof(CustomizationType)].SetValue<int>((int)value); } }
        public Array<Object> Meshes { get { return new Array<Object>(this[nameof(Meshes)].Address); } }
        public Object TextureSet { get { return this[nameof(TextureSet)]; } set { this[nameof(TextureSet)] = value; } }
    }
    public class AvailabilityOverride : Object
    {
        public AvailabilityOverride(ulong addr) : base(addr) { }
        public ECustomizationType CustomizationType { get { return (ECustomizationType)this[nameof(CustomizationType)].GetValue<int>(); } set { this[nameof(CustomizationType)].SetValue<int>((int)value); } }
        public Array<Object> Meshes { get { return new Array<Object>(this[nameof(Meshes)].Address); } }
        public AvailabilityInfo Availability { get { return this[nameof(Availability)].As<AvailabilityInfo>(); } set { this["Availability"] = value; } }
    }
    public class SkinCompatibilityInfo : Object
    {
        public SkinCompatibilityInfo(ulong addr) : base(addr) { }
        public ECustomizationType CustomizationType { get { return (ECustomizationType)this[nameof(CustomizationType)].GetValue<int>(); } set { this[nameof(CustomizationType)].SetValue<int>((int)value); } }
        public Array<Object> Meshes { get { return new Array<Object>(this[nameof(Meshes)].Address); } }
    }
    public class TextureTableRow : TableRowBase
    {
        public TextureTableRow(ulong addr) : base(addr) { }
        public Object Texture { get { return this[nameof(Texture)]; } set { this[nameof(Texture)] = value; } }
    }
    public class StringTableRow : TableRowBase
    {
        public StringTableRow(ulong addr) : base(addr) { }
        public Object String { get { return this[nameof(String)]; } set { this[nameof(String)] = value; } }
    }
    public class TextTableRow : TableRowBase
    {
        public TextTableRow(ulong addr) : base(addr) { }
        public Object Text { get { return this[nameof(Text)]; } set { this[nameof(Text)] = value; } }
    }
    public class ScoreConfig : Object
    {
        public ScoreConfig(ulong addr) : base(addr) { }
        public int MinScore { get { return this[nameof(MinScore)].GetValue<int>(); } set { this[nameof(MinScore)].SetValue<int>(value); } }
        public int MaxScore { get { return this[nameof(MaxScore)].GetValue<int>(); } set { this[nameof(MaxScore)].SetValue<int>(value); } }
        public int ScoreStep { get { return this[nameof(ScoreStep)].GetValue<int>(); } set { this[nameof(ScoreStep)].SetValue<int>(value); } }
    }
    public class GameConfig : Object
    {
        public GameConfig(ulong addr) : base(addr) { }
        public Object MapName { get { return this[nameof(MapName)]; } set { this[nameof(MapName)] = value; } }
        public Object GameModeAlias { get { return this[nameof(GameModeAlias)]; } set { this[nameof(GameModeAlias)] = value; } }
        public GameModeConfig GameModeConfig { get { return this[nameof(GameModeConfig)].As<GameModeConfig>(); } set { this["GameModeConfig"] = value; } }
        public int MatchTime { get { return this[nameof(MatchTime)].GetValue<int>(); } set { this[nameof(MatchTime)].SetValue<int>(value); } }
        public bool BotsEnabled { get { return this[nameof(BotsEnabled)].Flag; } set { this[nameof(BotsEnabled)].Flag = value; } }
        public EBotDifficulty BotDifficulty { get { return (EBotDifficulty)this[nameof(BotDifficulty)].GetValue<int>(); } set { this[nameof(BotDifficulty)].SetValue<int>((int)value); } }
    }
    public class GameModeConfig : Object
    {
        public GameModeConfig(ulong addr) : base(addr) { }
        public bool TeamGame { get { return this[nameof(TeamGame)].Flag; } set { this[nameof(TeamGame)].Flag = value; } }
        public byte NumTeams { get { return this[nameof(NumTeams)].GetValue<byte>(); } set { this[nameof(NumTeams)].SetValue<byte>(value); } }
        public int ScoreLimit { get { return this[nameof(ScoreLimit)].GetValue<int>(); } set { this[nameof(ScoreLimit)].SetValue<int>(value); } }
        public int RespawnTime { get { return this[nameof(RespawnTime)].GetValue<int>(); } set { this[nameof(RespawnTime)].SetValue<int>(value); } }
        public Array<int> DefaultInventoryIDs { get { return new Array<int>(this[nameof(DefaultInventoryIDs)].Address); } }
        public bool PickupsEnabled { get { return this[nameof(PickupsEnabled)].Flag; } set { this[nameof(PickupsEnabled)].Flag = value; } }
        public Array<PickupConfigOverride> PickupOverrides { get { return new Array<PickupConfigOverride>(this[nameof(PickupOverrides)].Address); } }
        public bool ShouldDropWeaponPickups { get { return this[nameof(ShouldDropWeaponPickups)].Flag; } set { this[nameof(ShouldDropWeaponPickups)].Flag = value; } }
        public bool ShouldShowRadar { get { return this[nameof(ShouldShowRadar)].Flag; } set { this[nameof(ShouldShowRadar)].Flag = value; } }
        public bool KillcamEnabled { get { return this[nameof(KillcamEnabled)].Flag; } set { this[nameof(KillcamEnabled)].Flag = value; } }
        public bool SpectateAlliesWhenDead { get { return this[nameof(SpectateAlliesWhenDead)].Flag; } set { this[nameof(SpectateAlliesWhenDead)].Flag = value; } }
        public GameModeModifiers Modifiers { get { return this[nameof(Modifiers)].As<GameModeModifiers>(); } set { this["Modifiers"] = value; } }
        public bool RandomWeapons { get { return this[nameof(RandomWeapons)].Flag; } set { this[nameof(RandomWeapons)].Flag = value; } }
        public bool MeleeHeavyMode { get { return this[nameof(MeleeHeavyMode)].Flag; } set { this[nameof(MeleeHeavyMode)].Flag = value; } }
        public KOTHConfig KOTHConfig { get { return this[nameof(KOTHConfig)].As<KOTHConfig>(); } set { this["KOTHConfig"] = value; } }
        public VIPConfig VIPConfig { get { return this[nameof(VIPConfig)].As<VIPConfig>(); } set { this["VIPConfig"] = value; } }
        public RoundConfig RoundConfig { get { return this[nameof(RoundConfig)].As<RoundConfig>(); } set { this["RoundConfig"] = value; } }
    }
    public class RoundConfig : Object
    {
        public RoundConfig(ulong addr) : base(addr) { }
        public bool bUseRoundTimer { get { return this[nameof(bUseRoundTimer)].Flag; } set { this[nameof(bUseRoundTimer)].Flag = value; } }
        public bool bUseRoundScoreLimit { get { return this[nameof(bUseRoundScoreLimit)].Flag; } set { this[nameof(bUseRoundScoreLimit)].Flag = value; } }
        public int RoundScoreLimit { get { return this[nameof(RoundScoreLimit)].GetValue<int>(); } set { this[nameof(RoundScoreLimit)].SetValue<int>(value); } }
        public int RoundTimeLimit { get { return this[nameof(RoundTimeLimit)].GetValue<int>(); } set { this[nameof(RoundTimeLimit)].SetValue<int>(value); } }
        public bool bRandomWeapons { get { return this[nameof(bRandomWeapons)].Flag; } set { this[nameof(bRandomWeapons)].Flag = value; } }
        public bool bRespawningDisabled { get { return this[nameof(bRespawningDisabled)].Flag; } set { this[nameof(bRespawningDisabled)].Flag = value; } }
    }
    public class VIPConfig : Object
    {
        public VIPConfig(ulong addr) : base(addr) { }
        public Array<int> DefaultInventoryIDs { get { return new Array<int>(this[nameof(DefaultInventoryIDs)].Address); } }
        public float VIPWalkSpeedModifier { get { return this[nameof(VIPWalkSpeedModifier)].GetValue<float>(); } set { this[nameof(VIPWalkSpeedModifier)].SetValue<float>(value); } }
    }
    public class KOTHConfig : Object
    {
        public KOTHConfig(ulong addr) : base(addr) { }
        public bool RandomHillsEnabled { get { return this[nameof(RandomHillsEnabled)].Flag; } set { this[nameof(RandomHillsEnabled)].Flag = value; } }
    }
    public class GameModeModifiers : Object
    {
        public GameModeModifiers(ulong addr) : base(addr) { }
        public bool EnableBoundaries { get { return this[nameof(EnableBoundaries)].Flag; } set { this[nameof(EnableBoundaries)].Flag = value; } }
        public bool EnableJetpack { get { return this[nameof(EnableJetpack)].Flag; } set { this[nameof(EnableJetpack)].Flag = value; } }
        public bool EnableSprint { get { return this[nameof(EnableSprint)].Flag; } set { this[nameof(EnableSprint)].Flag = value; } }
        public bool EnablePortalGun { get { return this[nameof(EnablePortalGun)].Flag; } set { this[nameof(EnablePortalGun)].Flag = value; } }
        public bool UnlimitedAmmo { get { return this[nameof(UnlimitedAmmo)].Flag; } set { this[nameof(UnlimitedAmmo)].Flag = value; } }
        public bool UnlimitedClipSize { get { return this[nameof(UnlimitedClipSize)].Flag; } set { this[nameof(UnlimitedClipSize)].Flag = value; } }
        public bool HeadshotsOnly { get { return this[nameof(HeadshotsOnly)].Flag; } set { this[nameof(HeadshotsOnly)].Flag = value; } }
        public bool BigHeadMode { get { return this[nameof(BigHeadMode)].Flag; } set { this[nameof(BigHeadMode)].Flag = value; } }
        public float WalkSpeedModifier { get { return this[nameof(WalkSpeedModifier)].GetValue<float>(); } set { this[nameof(WalkSpeedModifier)].SetValue<float>(value); } }
        public float JumpHeightModifier { get { return this[nameof(JumpHeightModifier)].GetValue<float>(); } set { this[nameof(JumpHeightModifier)].SetValue<float>(value); } }
        public float GravityModifier { get { return this[nameof(GravityModifier)].GetValue<float>(); } set { this[nameof(GravityModifier)].SetValue<float>(value); } }
        public float ThrusterPackFuelModifier { get { return this[nameof(ThrusterPackFuelModifier)].GetValue<float>(); } set { this[nameof(ThrusterPackFuelModifier)].SetValue<float>(value); } }
        public float ThrusterPackBoostModifier { get { return this[nameof(ThrusterPackBoostModifier)].GetValue<float>(); } set { this[nameof(ThrusterPackBoostModifier)].SetValue<float>(value); } }
        public float MeleeDmgModifier { get { return this[nameof(MeleeDmgModifier)].GetValue<float>(); } set { this[nameof(MeleeDmgModifier)].SetValue<float>(value); } }
        public float HealthModifier { get { return this[nameof(HealthModifier)].GetValue<float>(); } set { this[nameof(HealthModifier)].SetValue<float>(value); } }
    }
    public class PickupConfigOverride : Object
    {
        public PickupConfigOverride(ulong addr) : base(addr) { }
        public int WeaponID { get { return this[nameof(WeaponID)].GetValue<int>(); } set { this[nameof(WeaponID)].SetValue<int>(value); } }
        public bool IsEnabled { get { return this[nameof(IsEnabled)].Flag; } set { this[nameof(IsEnabled)].Flag = value; } }
        public bool OverrideClips { get { return this[nameof(OverrideClips)].Flag; } set { this[nameof(OverrideClips)].Flag = value; } }
        public float AmmoClips { get { return this[nameof(AmmoClips)].GetValue<float>(); } set { this[nameof(AmmoClips)].SetValue<float>(value); } }
        public bool OverrideSpawnTime { get { return this[nameof(OverrideSpawnTime)].Flag; } set { this[nameof(OverrideSpawnTime)].Flag = value; } }
        public int TimeBetweenSpawns { get { return this[nameof(TimeBetweenSpawns)].GetValue<int>(); } set { this[nameof(TimeBetweenSpawns)].SetValue<int>(value); } }
    }
    public class WeaponPoseData : TableRowBase
    {
        public WeaponPoseData(ulong addr) : base(addr) { }
        public ECustomizationType WeaponType { get { return (ECustomizationType)this[nameof(WeaponType)].GetValue<int>(); } set { this[nameof(WeaponType)].SetValue<int>((int)value); } }
        public Object Animation { get { return this[nameof(Animation)]; } set { this[nameof(Animation)] = value; } }
    }
    public class TipData : TextTableRow
    {
        public TipData(ulong addr) : base(addr) { }
        public bool KeyboardOnly { get { return this[nameof(KeyboardOnly)].Flag; } set { this[nameof(KeyboardOnly)].Flag = value; } }
    }
    public class MouseButtonData : TableRowBase
    {
        public MouseButtonData(ulong addr) : base(addr) { }
        public Key Key { get { return this[nameof(Key)].As<Key>(); } set { this["Key"] = value; } }
        public Texture2D Icon { get { return this[nameof(Icon)].As<Texture2D>(); } set { this["Icon"] = value; } }
    }
    public class GamepadButtonData : TableRowBase
    {
        public GamepadButtonData(ulong addr) : base(addr) { }
        public Key Key { get { return this[nameof(Key)].As<Key>(); } set { this["Key"] = value; } }
        public Texture2D Icon { get { return this[nameof(Icon)].As<Texture2D>(); } set { this["Icon"] = value; } }
    }
    public class TutorialStageData : PWTableRowBase
    {
        public TutorialStageData(ulong addr) : base(addr) { }
        public Array<TutorialStepData> Steps { get { return new Array<TutorialStepData>(this[nameof(Steps)].Address); } }
        public VideoInfo VideoInfo { get { return this[nameof(VideoInfo)].As<VideoInfo>(); } set { this["VideoInfo"] = value; } }
    }
    public class VideoInfo : Object
    {
        public VideoInfo(ulong addr) : base(addr) { }
        public Object MediaSource { get { return this[nameof(MediaSource)]; } set { this[nameof(MediaSource)] = value; } }
        public Array<SubtitleInfo> Subtitles { get { return new Array<SubtitleInfo>(this[nameof(Subtitles)].Address); } }
    }
    public class SubtitleInfo : Object
    {
        public SubtitleInfo(ulong addr) : base(addr) { }
        public int StartTimeSeconds { get { return this[nameof(StartTimeSeconds)].GetValue<int>(); } set { this[nameof(StartTimeSeconds)].SetValue<int>(value); } }
        public int EndTimeSeconds { get { return this[nameof(EndTimeSeconds)].GetValue<int>(); } set { this[nameof(EndTimeSeconds)].SetValue<int>(value); } }
        public Object TableKey { get { return this[nameof(TableKey)]; } set { this[nameof(TableKey)] = value; } }
    }
    public class TutorialStepData : Object
    {
        public TutorialStepData(ulong addr) : base(addr) { }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public Array<Object> InputActions { get { return new Array<Object>(this[nameof(InputActions)].Address); } }
        public int GoalID { get { return this[nameof(GoalID)].GetValue<int>(); } set { this[nameof(GoalID)].SetValue<int>(value); } }
    }
    public class BotProfileData : PWTableRowBase
    {
        public BotProfileData(ulong addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public Object avatar { get { return this[nameof(avatar)]; } set { this[nameof(avatar)] = value; } }
        public Object AvatarPath { get { return this[nameof(AvatarPath)]; } set { this[nameof(AvatarPath)] = value; } }
    }
    public class RedeemableData : PWTableRowBase
    {
        public RedeemableData(ulong addr) : base(addr) { }
        public Object Subtitle { get { return this[nameof(Subtitle)]; } set { this[nameof(Subtitle)] = value; } }
        public int CurrencyCost { get { return this[nameof(CurrencyCost)].GetValue<int>(); } set { this[nameof(CurrencyCost)].SetValue<int>(value); } }
        public int Amount { get { return this[nameof(Amount)].GetValue<int>(); } set { this[nameof(Amount)].SetValue<int>(value); } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
    }
    public class MicroTxnPurchasable : PWTableRowBase
    {
        public MicroTxnPurchasable(ulong addr) : base(addr) { }
        public EPurchasableType Type { get { return (EPurchasableType)this[nameof(Type)].GetValue<int>(); } set { this[nameof(Type)].SetValue<int>((int)value); } }
        public Array<RewardData> Rewards { get { return new Array<RewardData>(this[nameof(Rewards)].Address); } }
        public Object PlatformProductIds { get { return this[nameof(PlatformProductIds)]; } set { this[nameof(PlatformProductIds)] = value; } }
    }
    public class RankData : PWTableRowBase
    {
        public RankData(ulong addr) : base(addr) { }
        public int RankDownXP { get { return this[nameof(RankDownXP)].GetValue<int>(); } set { this[nameof(RankDownXP)].SetValue<int>(value); } }
        public int RankUpXP { get { return this[nameof(RankUpXP)].GetValue<int>(); } set { this[nameof(RankUpXP)].SetValue<int>(value); } }
    }
    public class StreakIconData : PWTableRowBase
    {
        public StreakIconData(ulong addr) : base(addr) { }
        public int Streak { get { return this[nameof(Streak)].GetValue<int>(); } set { this[nameof(Streak)].SetValue<int>(value); } }
    }
    public class ProgressionIconData : PWTableRowBase
    {
        public ProgressionIconData(ulong addr) : base(addr) { }
        public int Level { get { return this[nameof(Level)].GetValue<int>(); } set { this[nameof(Level)].SetValue<int>(value); } }
    }
    public class UnlockData : PWTableRowBase
    {
        public UnlockData(ulong addr) : base(addr) { }
        public EUnlockType UnlockType { get { return (EUnlockType)this[nameof(UnlockType)].GetValue<int>(); } set { this[nameof(UnlockType)].SetValue<int>((int)value); } }
        public Object PlaylistName { get { return this[nameof(PlaylistName)]; } set { this[nameof(PlaylistName)] = value; } }
        public Object IconImage { get { return this[nameof(IconImage)]; } set { this[nameof(IconImage)] = value; } }
        public Object MedalImage { get { return this[nameof(MedalImage)]; } set { this[nameof(MedalImage)] = value; } }
        public Object MessageText { get { return this[nameof(MessageText)]; } set { this[nameof(MessageText)] = value; } }
        public Array<UnlockNoteData> Notes { get { return new Array<UnlockNoteData>(this[nameof(Notes)].Address); } }
    }
    public class UnlockNoteData : Object
    {
        public UnlockNoteData(ulong addr) : base(addr) { }
        public Object Text { get { return this[nameof(Text)]; } set { this[nameof(Text)] = value; } }
        public bool bIsImportant { get { return this[nameof(bIsImportant)].Flag; } set { this[nameof(bIsImportant)].Flag = value; } }
    }
    public class PlayStreakData : PWTableRowBase
    {
        public PlayStreakData(ulong addr) : base(addr) { }
        public RewardData Reward { get { return this[nameof(Reward)].As<RewardData>(); } set { this["Reward"] = value; } }
    }
    public class CheckInData : PWTableRowBase
    {
        public CheckInData(ulong addr) : base(addr) { }
        public Array<RewardData> Rewards { get { return new Array<RewardData>(this[nameof(Rewards)].Address); } }
    }
    public class ChallengeData : PWTableRowBase
    {
        public ChallengeData(ulong addr) : base(addr) { }
        public EChallengeType ChallengeType { get { return (EChallengeType)this[nameof(ChallengeType)].GetValue<int>(); } set { this[nameof(ChallengeType)].SetValue<int>((int)value); } }
        public int TargetValue { get { return this[nameof(TargetValue)].GetValue<int>(); } set { this[nameof(TargetValue)].SetValue<int>(value); } }
        public RewardData Reward { get { return this[nameof(Reward)].As<RewardData>(); } set { this["Reward"] = value; } }
        public int GroupId { get { return this[nameof(GroupId)].GetValue<int>(); } set { this[nameof(GroupId)].SetValue<int>(value); } }
        public bool IsPremium { get { return this[nameof(IsPremium)].Flag; } set { this[nameof(IsPremium)].Flag = value; } }
        public Object GroupName { get { return this[nameof(GroupName)]; } set { this[nameof(GroupName)] = value; } }
        public Object StatType { get { return this[nameof(StatType)]; } set { this[nameof(StatType)] = value; } }
        public Array<Object> ExcludedPlaylists { get { return new Array<Object>(this[nameof(ExcludedPlaylists)].Address); } }
    }
    public class RewardPassData : PWTableRowBase
    {
        public RewardPassData(ulong addr) : base(addr) { }
        public int MinXP { get { return this[nameof(MinXP)].GetValue<int>(); } set { this[nameof(MinXP)].SetValue<int>(value); } }
        public int MaxXP { get { return this[nameof(MaxXP)].GetValue<int>(); } set { this[nameof(MaxXP)].SetValue<int>(value); } }
        public Array<RewardData> FreeRewards { get { return new Array<RewardData>(this[nameof(FreeRewards)].Address); } }
        public Array<RewardData> PremiumRewards { get { return new Array<RewardData>(this[nameof(PremiumRewards)].Address); } }
    }
    public class ProgressionData : PWTableRowBase
    {
        public ProgressionData(ulong addr) : base(addr) { }
        public int XPDifference { get { return this[nameof(XPDifference)].GetValue<int>(); } set { this[nameof(XPDifference)].SetValue<int>(value); } }
        public int LevelUpXP { get { return this[nameof(LevelUpXP)].GetValue<int>(); } set { this[nameof(LevelUpXP)].SetValue<int>(value); } }
        public RewardData Reward { get { return this[nameof(Reward)].As<RewardData>(); } set { this["Reward"] = value; } }
    }
    public class RegionData : PWTableRowBase
    {
        public RegionData(ulong addr) : base(addr) { }
        public Object PingURL { get { return this[nameof(PingURL)]; } set { this[nameof(PingURL)] = value; } }
        public Object InternalName { get { return this[nameof(InternalName)]; } set { this[nameof(InternalName)] = value; } }
        public Array<ERegionSelectability> Selectability { get { return new Array<ERegionSelectability>(this[nameof(Selectability)].Address); } }
    }
    public class PlaylistData : PWTableRowBase
    {
        public PlaylistData(ulong addr) : base(addr) { }
        public Object InternalName { get { return this[nameof(InternalName)]; } set { this[nameof(InternalName)] = value; } }
        public EPlaylistType PlaylistType { get { return (EPlaylistType)this[nameof(PlaylistType)].GetValue<int>(); } set { this[nameof(PlaylistType)].SetValue<int>((int)value); } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public Object IconImage { get { return this[nameof(IconImage)]; } set { this[nameof(IconImage)] = value; } }
    }
    public class CustomReticleData : PWTableRowBase
    {
        public CustomReticleData(ulong addr) : base(addr) { }
        public ReticleData ReticleData { get { return this[nameof(ReticleData)].As<ReticleData>(); } set { this["ReticleData"] = value; } }
    }
    public class ReticleData : Object
    {
        public ReticleData(ulong addr) : base(addr) { }
        public bool ShouldShowOuterCircle { get { return this[nameof(ShouldShowOuterCircle)].Flag; } set { this[nameof(ShouldShowOuterCircle)].Flag = value; } }
        public Texture2D OuterCircleImage { get { return this[nameof(OuterCircleImage)].As<Texture2D>(); } set { this["OuterCircleImage"] = value; } }
        public float OuterCircleRadius { get { return this[nameof(OuterCircleRadius)].GetValue<float>(); } set { this[nameof(OuterCircleRadius)].SetValue<float>(value); } }
        public bool ShouldShowInnerCircle { get { return this[nameof(ShouldShowInnerCircle)].Flag; } set { this[nameof(ShouldShowInnerCircle)].Flag = value; } }
        public Texture2D InnerCircleImage { get { return this[nameof(InnerCircleImage)].As<Texture2D>(); } set { this["InnerCircleImage"] = value; } }
        public float InnerCircleRadius { get { return this[nameof(InnerCircleRadius)].GetValue<float>(); } set { this[nameof(InnerCircleRadius)].SetValue<float>(value); } }
        public bool ShouldShowDot { get { return this[nameof(ShouldShowDot)].Flag; } set { this[nameof(ShouldShowDot)].Flag = value; } }
        public bool ShouldShowCrosshair { get { return this[nameof(ShouldShowCrosshair)].Flag; } set { this[nameof(ShouldShowCrosshair)].Flag = value; } }
        public Texture2D CrosshairBarImage { get { return this[nameof(CrosshairBarImage)].As<Texture2D>(); } set { this["CrosshairBarImage"] = value; } }
        public Vector2D CrosshairIndSize { get { return this[nameof(CrosshairIndSize)].As<Vector2D>(); } set { this["CrosshairIndSize"] = value; } }
        public float CrosshairOffset { get { return this[nameof(CrosshairOffset)].GetValue<float>(); } set { this[nameof(CrosshairOffset)].SetValue<float>(value); } }
        public Texture2D ZoomImage { get { return this[nameof(ZoomImage)].As<Texture2D>(); } set { this["ZoomImage"] = value; } }
        public Texture2D HitMarkerImage { get { return this[nameof(HitMarkerImage)].As<Texture2D>(); } set { this["HitMarkerImage"] = value; } }
        public Texture2D HeadshotMarkerImage { get { return this[nameof(HeadshotMarkerImage)].As<Texture2D>(); } set { this["HeadshotMarkerImage"] = value; } }
        public Texture2D KillMarkerImage { get { return this[nameof(KillMarkerImage)].As<Texture2D>(); } set { this["KillMarkerImage"] = value; } }
        public float HitMarkerScale { get { return this[nameof(HitMarkerScale)].GetValue<float>(); } set { this[nameof(HitMarkerScale)].SetValue<float>(value); } }
        public float ReticleOpacity { get { return this[nameof(ReticleOpacity)].GetValue<float>(); } set { this[nameof(ReticleOpacity)].SetValue<float>(value); } }
        public float ReticleScale { get { return this[nameof(ReticleScale)].GetValue<float>(); } set { this[nameof(ReticleScale)].SetValue<float>(value); } }
        public LinearColor ReticleColor { get { return this[nameof(ReticleColor)].As<LinearColor>(); } set { this["ReticleColor"] = value; } }
    }
    public class AnnouncerEvent : TableRowBase
    {
        public AnnouncerEvent(ulong addr) : base(addr) { }
        public Object EventName { get { return this[nameof(EventName)]; } set { this[nameof(EventName)] = value; } }
        public Object SubtitleText { get { return this[nameof(SubtitleText)]; } set { this[nameof(SubtitleText)] = value; } }
    }
    public class MedalData : PWTableRowBase
    {
        public MedalData(ulong addr) : base(addr) { }
        public Object SoundName { get { return this[nameof(SoundName)]; } set { this[nameof(SoundName)] = value; } }
    }
    public class WeaponMetadata : PWTableRowBase
    {
        public WeaponMetadata(ulong addr) : base(addr) { }
        public Object DefaultClass { get { return this[nameof(DefaultClass)]; } set { this[nameof(DefaultClass)] = value; } }
        public int CrosshairWeaponID { get { return this[nameof(CrosshairWeaponID)].GetValue<int>(); } set { this[nameof(CrosshairWeaponID)].SetValue<int>(value); } }
        public Object ShortDisplayName { get { return this[nameof(ShortDisplayName)]; } set { this[nameof(ShortDisplayName)] = value; } }
    }
    public class MapData : PWTableRowBase
    {
        public MapData(ulong addr) : base(addr) { }
        public Object MapName { get { return this[nameof(MapName)]; } set { this[nameof(MapName)] = value; } }
        public Array<EMapSelectability> Selectability { get { return new Array<EMapSelectability>(this[nameof(Selectability)].Address); } }
    }
    public class GameModeData : PWTableRowBase
    {
        public GameModeData(ulong addr) : base(addr) { }
        public Object DefaultClass { get { return this[nameof(DefaultClass)]; } set { this[nameof(DefaultClass)] = value; } }
        public Object Alias { get { return this[nameof(Alias)]; } set { this[nameof(Alias)] = value; } }
        public GameModeConfig Config { get { return this[nameof(Config)].As<GameModeConfig>(); } set { this["Config"] = value; } }
        public ScoreConfig ScoreConfig { get { return this[nameof(ScoreConfig)].As<ScoreConfig>(); } set { this["ScoreConfig"] = value; } }
        public int MatchTime { get { return this[nameof(MatchTime)].GetValue<int>(); } set { this[nameof(MatchTime)].SetValue<int>(value); } }
        public Object Description { get { return this[nameof(Description)]; } set { this[nameof(Description)] = value; } }
        public Object ScoreFormatText { get { return this[nameof(ScoreFormatText)]; } set { this[nameof(ScoreFormatText)] = value; } }
        public Object SoundName { get { return this[nameof(SoundName)]; } set { this[nameof(SoundName)] = value; } }
        public int MaxPlayers { get { return this[nameof(MaxPlayers)].GetValue<int>(); } set { this[nameof(MaxPlayers)].SetValue<int>(value); } }
        public Array<int> CompatibleWeaponIDs { get { return new Array<int>(this[nameof(CompatibleWeaponIDs)].Address); } }
        public Array<EGameModeSelectability> Selectability { get { return new Array<EGameModeSelectability>(this[nameof(Selectability)].Address); } }
        public Object IconImage { get { return this[nameof(IconImage)]; } set { this[nameof(IconImage)] = value; } }
    }
    public class MatchSummaryInfo : Object
    {
        public MatchSummaryInfo(ulong addr) : base(addr) { }
        public GameModeConfig GameConfig { get { return this[nameof(GameConfig)].As<GameModeConfig>(); } set { this["GameConfig"] = value; } }
        public Object Map { get { return this[nameof(Map)]; } set { this[nameof(Map)] = value; } }
        public Array<MatchSummaryScoreInfo> Scores { get { return new Array<MatchSummaryScoreInfo>(this[nameof(Scores)].Address); } }
        public Array<EndGamePlayerInfo> Users { get { return new Array<EndGamePlayerInfo>(this[nameof(Users)].Address); } }
        public bool bTeamGame { get { return this[nameof(bTeamGame)].Flag; } set { this[nameof(bTeamGame)].Flag = value; } }
        public Object Mode { get { return this[nameof(Mode)]; } set { this[nameof(Mode)] = value; } }
    }
    public class EndGamePlayerInfo : Object
    {
        public EndGamePlayerInfo(ulong addr) : base(addr) { }
        public Object EncodedCompositeUserId { get { return this[nameof(EncodedCompositeUserId)]; } set { this[nameof(EncodedCompositeUserId)] = value; } }
        public int Team { get { return this[nameof(Team)].GetValue<int>(); } set { this[nameof(Team)].SetValue<int>(value); } }
        public Array<CustomizationId> Customizations { get { return new Array<CustomizationId>(this[nameof(Customizations)].Address); } }
        public PlayerStatsInfo_MatchSummary Stats { get { return this[nameof(Stats)].As<PlayerStatsInfo_MatchSummary>(); } set { this["Stats"] = value; } }
        public bool bQuitter { get { return this[nameof(bQuitter)].Flag; } set { this[nameof(bQuitter)].Flag = value; } }
        public Object PlayerName { get { return this[nameof(PlayerName)]; } set { this[nameof(PlayerName)] = value; } }
        public UserRankInfo PlaylistRank { get { return this[nameof(PlaylistRank)].As<UserRankInfo>(); } set { this["PlaylistRank"] = value; } }
        public UserProgressionInfo Progression { get { return this[nameof(Progression)].As<UserProgressionInfo>(); } set { this["Progression"] = value; } }
        public UserDailyStreakInfo DailyStreak { get { return this[nameof(DailyStreak)].As<UserDailyStreakInfo>(); } set { this["DailyStreak"] = value; } }
        public bool bIsABot { get { return this[nameof(bIsABot)].Flag; } set { this[nameof(bIsABot)].Flag = value; } }
        public BotProfileData BotProfile { get { return this[nameof(BotProfile)].As<BotProfileData>(); } set { this["BotProfile"] = value; } }
    }
    public class UserDailyStreakInfo : Object
    {
        public UserDailyStreakInfo(ulong addr) : base(addr) { }
        public bool HasPlayedToday { get { return this[nameof(HasPlayedToday)].Flag; } set { this[nameof(HasPlayedToday)].Flag = value; } }
        public int Value { get { return this[nameof(Value)].GetValue<int>(); } set { this[nameof(Value)].SetValue<int>(value); } }
        public int BoostPercentage { get { return this[nameof(BoostPercentage)].GetValue<int>(); } set { this[nameof(BoostPercentage)].SetValue<int>(value); } }
        public int PreviousValue { get { return this[nameof(PreviousValue)].GetValue<int>(); } set { this[nameof(PreviousValue)].SetValue<int>(value); } }
        public long PreviousValueExpiresAtMs { get { return this[nameof(PreviousValueExpiresAtMs)].GetValue<long>(); } set { this[nameof(PreviousValueExpiresAtMs)].SetValue<long>(value); } }
        public bool HasBeenReceived { get { return this[nameof(HasBeenReceived)].Flag; } set { this[nameof(HasBeenReceived)].Flag = value; } }
    }
    public class UserProgressionInfo : Object
    {
        public UserProgressionInfo(ulong addr) : base(addr) { }
        public int Xp { get { return this[nameof(Xp)].GetValue<int>(); } set { this[nameof(Xp)].SetValue<int>(value); } }
        public int Level { get { return this[nameof(Level)].GetValue<int>(); } set { this[nameof(Level)].SetValue<int>(value); } }
    }
    public class UserRankInfo : Object
    {
        public UserRankInfo(ulong addr) : base(addr) { }
        public Object RankType { get { return this[nameof(RankType)]; } set { this[nameof(RankType)] = value; } }
        public int RankLevel { get { return this[nameof(RankLevel)].GetValue<int>(); } set { this[nameof(RankLevel)].SetValue<int>(value); } }
        public int RankXP { get { return this[nameof(RankXP)].GetValue<int>(); } set { this[nameof(RankXP)].SetValue<int>(value); } }
        public int PlacementGamesPlayedCount { get { return this[nameof(PlacementGamesPlayedCount)].GetValue<int>(); } set { this[nameof(PlacementGamesPlayedCount)].SetValue<int>(value); } }
        public int PlacementGamesPlayedTotal { get { return this[nameof(PlacementGamesPlayedTotal)].GetValue<int>(); } set { this[nameof(PlacementGamesPlayedTotal)].SetValue<int>(value); } }
    }
    public class PlayerStatsInfo : Object
    {
        public PlayerStatsInfo(ulong addr) : base(addr) { }
        public int Kills { get { return this[nameof(Kills)].GetValue<int>(); } set { this[nameof(Kills)].SetValue<int>(value); } }
        public int Assists { get { return this[nameof(Assists)].GetValue<int>(); } set { this[nameof(Assists)].SetValue<int>(value); } }
        public int Deaths { get { return this[nameof(Deaths)].GetValue<int>(); } set { this[nameof(Deaths)].SetValue<int>(value); } }
        public int Suicides { get { return this[nameof(Suicides)].GetValue<int>(); } set { this[nameof(Suicides)].SetValue<int>(value); } }
        public int HeadshotKills { get { return this[nameof(HeadshotKills)].GetValue<int>(); } set { this[nameof(HeadshotKills)].SetValue<int>(value); } }
        public int Teabags { get { return this[nameof(Teabags)].GetValue<int>(); } set { this[nameof(Teabags)].SetValue<int>(value); } }
        public int MeleeKills { get { return this[nameof(MeleeKills)].GetValue<int>(); } set { this[nameof(MeleeKills)].SetValue<int>(value); } }
        public int PortalKills { get { return this[nameof(PortalKills)].GetValue<int>(); } set { this[nameof(PortalKills)].SetValue<int>(value); } }
        public int KillsThruPortal { get { return this[nameof(KillsThruPortal)].GetValue<int>(); } set { this[nameof(KillsThruPortal)].SetValue<int>(value); } }
        public int DoubleKills { get { return this[nameof(DoubleKills)].GetValue<int>(); } set { this[nameof(DoubleKills)].SetValue<int>(value); } }
        public int TripleKills { get { return this[nameof(TripleKills)].GetValue<int>(); } set { this[nameof(TripleKills)].SetValue<int>(value); } }
        public int QuadKills { get { return this[nameof(QuadKills)].GetValue<int>(); } set { this[nameof(QuadKills)].SetValue<int>(value); } }
        public int QuintKills { get { return this[nameof(QuintKills)].GetValue<int>(); } set { this[nameof(QuintKills)].SetValue<int>(value); } }
        public int SexKills { get { return this[nameof(SexKills)].GetValue<int>(); } set { this[nameof(SexKills)].SetValue<int>(value); } }
        public int Killstreak1 { get { return this[nameof(Killstreak1)].GetValue<int>(); } set { this[nameof(Killstreak1)].SetValue<int>(value); } }
        public int Killstreak2 { get { return this[nameof(Killstreak2)].GetValue<int>(); } set { this[nameof(Killstreak2)].SetValue<int>(value); } }
        public int Killstreak3 { get { return this[nameof(Killstreak3)].GetValue<int>(); } set { this[nameof(Killstreak3)].SetValue<int>(value); } }
        public int Killstreak4 { get { return this[nameof(Killstreak4)].GetValue<int>(); } set { this[nameof(Killstreak4)].SetValue<int>(value); } }
        public int Killstreak5 { get { return this[nameof(Killstreak5)].GetValue<int>(); } set { this[nameof(Killstreak5)].SetValue<int>(value); } }
        public int Killstreak6 { get { return this[nameof(Killstreak6)].GetValue<int>(); } set { this[nameof(Killstreak6)].SetValue<int>(value); } }
        public int DamageDealt { get { return this[nameof(DamageDealt)].GetValue<int>(); } set { this[nameof(DamageDealt)].SetValue<int>(value); } }
        public int EmoteCount { get { return this[nameof(EmoteCount)].GetValue<int>(); } set { this[nameof(EmoteCount)].SetValue<int>(value); } }
        public Array<WeaponStats> Weapons { get { return new Array<WeaponStats>(this[nameof(Weapons)].Address); } }
    }
    public class WeaponStats : Object
    {
        public WeaponStats(ulong addr) : base(addr) { }
        public Object Name { get { return this[nameof(Name)]; } set { this[nameof(Name)] = value; } }
        public int Kills { get { return this[nameof(Kills)].GetValue<int>(); } set { this[nameof(Kills)].SetValue<int>(value); } }
        public int ShotsFired { get { return this[nameof(ShotsFired)].GetValue<int>(); } set { this[nameof(ShotsFired)].SetValue<int>(value); } }
        public int ShotsLanded { get { return this[nameof(ShotsLanded)].GetValue<int>(); } set { this[nameof(ShotsLanded)].SetValue<int>(value); } }
        public int HeadshotsLanded { get { return this[nameof(HeadshotsLanded)].GetValue<int>(); } set { this[nameof(HeadshotsLanded)].SetValue<int>(value); } }
        public int HeadshotKills { get { return this[nameof(HeadshotKills)].GetValue<int>(); } set { this[nameof(HeadshotKills)].SetValue<int>(value); } }
        public int KillsThruPortal { get { return this[nameof(KillsThruPortal)].GetValue<int>(); } set { this[nameof(KillsThruPortal)].SetValue<int>(value); } }
        public int MeleeKills { get { return this[nameof(MeleeKills)].GetValue<int>(); } set { this[nameof(MeleeKills)].SetValue<int>(value); } }
        public int Collaterals { get { return this[nameof(Collaterals)].GetValue<int>(); } set { this[nameof(Collaterals)].SetValue<int>(value); } }
        public int PossessionSecs { get { return this[nameof(PossessionSecs)].GetValue<int>(); } set { this[nameof(PossessionSecs)].SetValue<int>(value); } }
        public int DamageDealt { get { return this[nameof(DamageDealt)].GetValue<int>(); } set { this[nameof(DamageDealt)].SetValue<int>(value); } }
        public int DoubleKills { get { return this[nameof(DoubleKills)].GetValue<int>(); } set { this[nameof(DoubleKills)].SetValue<int>(value); } }
        public int TripleKills { get { return this[nameof(TripleKills)].GetValue<int>(); } set { this[nameof(TripleKills)].SetValue<int>(value); } }
        public int QuadKills { get { return this[nameof(QuadKills)].GetValue<int>(); } set { this[nameof(QuadKills)].SetValue<int>(value); } }
        public int QuintKills { get { return this[nameof(QuintKills)].GetValue<int>(); } set { this[nameof(QuintKills)].SetValue<int>(value); } }
        public int SexKills { get { return this[nameof(SexKills)].GetValue<int>(); } set { this[nameof(SexKills)].SetValue<int>(value); } }
        public int MaxKillsWithSinglePickup { get { return this[nameof(MaxKillsWithSinglePickup)].GetValue<int>(); } set { this[nameof(MaxKillsWithSinglePickup)].SetValue<int>(value); } }
    }
    public class PlayerStatsInfo_InDepth : PlayerStatsInfo
    {
        public PlayerStatsInfo_InDepth(ulong addr) : base(addr) { }
        public int EnemyPortalsDestroyed { get { return this[nameof(EnemyPortalsDestroyed)].GetValue<int>(); } set { this[nameof(EnemyPortalsDestroyed)].SetValue<int>(value); } }
        public int AllyPortalsEntered { get { return this[nameof(AllyPortalsEntered)].GetValue<int>(); } set { this[nameof(AllyPortalsEntered)].SetValue<int>(value); } }
        public int EnemyPortalsEntered { get { return this[nameof(EnemyPortalsEntered)].GetValue<int>(); } set { this[nameof(EnemyPortalsEntered)].SetValue<int>(value); } }
        public int OwnPortalsEntered { get { return this[nameof(OwnPortalsEntered)].GetValue<int>(); } set { this[nameof(OwnPortalsEntered)].SetValue<int>(value); } }
        public int PortalsSpawned { get { return this[nameof(PortalsSpawned)].GetValue<int>(); } set { this[nameof(PortalsSpawned)].SetValue<int>(value); } }
        public int DistancePortaled { get { return this[nameof(DistancePortaled)].GetValue<int>(); } set { this[nameof(DistancePortaled)].SetValue<int>(value); } }
        public int HighestConsecutiveKills { get { return this[nameof(HighestConsecutiveKills)].GetValue<int>(); } set { this[nameof(HighestConsecutiveKills)].SetValue<int>(value); } }
        public int HillsCaptured { get { return this[nameof(HillsCaptured)].GetValue<int>(); } set { this[nameof(HillsCaptured)].SetValue<int>(value); } }
        public int HillsNeutralized { get { return this[nameof(HillsNeutralized)].GetValue<int>(); } set { this[nameof(HillsNeutralized)].SetValue<int>(value); } }
        public int KillsOnHill { get { return this[nameof(KillsOnHill)].GetValue<int>(); } set { this[nameof(KillsOnHill)].SetValue<int>(value); } }
        public int EnemyKillsOnHill { get { return this[nameof(EnemyKillsOnHill)].GetValue<int>(); } set { this[nameof(EnemyKillsOnHill)].SetValue<int>(value); } }
        public int FlagsPickedUp { get { return this[nameof(FlagsPickedUp)].GetValue<int>(); } set { this[nameof(FlagsPickedUp)].SetValue<int>(value); } }
        public int FlagsReturned { get { return this[nameof(FlagsReturned)].GetValue<int>(); } set { this[nameof(FlagsReturned)].SetValue<int>(value); } }
        public int FlagKills { get { return this[nameof(FlagKills)].GetValue<int>(); } set { this[nameof(FlagKills)].SetValue<int>(value); } }
        public int FlagCarrierKills { get { return this[nameof(FlagCarrierKills)].GetValue<int>(); } set { this[nameof(FlagCarrierKills)].SetValue<int>(value); } }
        public int OddballsPickedUp { get { return this[nameof(OddballsPickedUp)].GetValue<int>(); } set { this[nameof(OddballsPickedUp)].SetValue<int>(value); } }
        public int OddballKills { get { return this[nameof(OddballKills)].GetValue<int>(); } set { this[nameof(OddballKills)].SetValue<int>(value); } }
        public int OddballCarrierKills { get { return this[nameof(OddballCarrierKills)].GetValue<int>(); } set { this[nameof(OddballCarrierKills)].SetValue<int>(value); } }
        public int VIPKills { get { return this[nameof(VIPKills)].GetValue<int>(); } set { this[nameof(VIPKills)].SetValue<int>(value); } }
        public int KillsAsVIP { get { return this[nameof(KillsAsVIP)].GetValue<int>(); } set { this[nameof(KillsAsVIP)].SetValue<int>(value); } }
        public int TeabagsDenied { get { return this[nameof(TeabagsDenied)].GetValue<int>(); } set { this[nameof(TeabagsDenied)].SetValue<int>(value); } }
        public int FirstBloods { get { return this[nameof(FirstBloods)].GetValue<int>(); } set { this[nameof(FirstBloods)].SetValue<int>(value); } }
        public int RevengeKills { get { return this[nameof(RevengeKills)].GetValue<int>(); } set { this[nameof(RevengeKills)].SetValue<int>(value); } }
        public int KingSlayers { get { return this[nameof(KingSlayers)].GetValue<int>(); } set { this[nameof(KingSlayers)].SetValue<int>(value); } }
    }
    public class PlayerStatsInfo_MatchSummary : PlayerStatsInfo_InDepth
    {
        public PlayerStatsInfo_MatchSummary(ulong addr) : base(addr) { }
        public int Points { get { return this[nameof(Points)].GetValue<int>(); } set { this[nameof(Points)].SetValue<int>(value); } }
        public int TimePlayed { get { return this[nameof(TimePlayed)].GetValue<int>(); } set { this[nameof(TimePlayed)].SetValue<int>(value); } }
        public float AdaptiveDifficultyAverage { get { return this[nameof(AdaptiveDifficultyAverage)].GetValue<float>(); } set { this[nameof(AdaptiveDifficultyAverage)].SetValue<float>(value); } }
    }
    public class MatchSummaryScoreInfo : Object
    {
        public MatchSummaryScoreInfo(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int Points { get { return this[nameof(Points)].GetValue<int>(); } set { this[nameof(Points)].SetValue<int>(value); } }
    }
    public class PlayerStateInfo : Object
    {
        public PlayerStateInfo(ulong addr) : base(addr) { }
        public Object EncodedCompositeUserId { get { return this[nameof(EncodedCompositeUserId)]; } set { this[nameof(EncodedCompositeUserId)] = value; } }
        public int Team { get { return this[nameof(Team)].GetValue<int>(); } set { this[nameof(Team)].SetValue<int>(value); } }
        public bool IsSpectator { get { return this[nameof(IsSpectator)].Flag; } set { this[nameof(IsSpectator)].Flag = value; } }
        public bool IsFlagged { get { return this[nameof(IsFlagged)].Flag; } set { this[nameof(IsFlagged)].Flag = value; } }
    }
    public class PlayerStatsInfo_Career : PlayerStatsInfo
    {
        public PlayerStatsInfo_Career(ulong addr) : base(addr) { }
        public int GamesPlayed { get { return this[nameof(GamesPlayed)].GetValue<int>(); } set { this[nameof(GamesPlayed)].SetValue<int>(value); } }
        public int GamesWon { get { return this[nameof(GamesWon)].GetValue<int>(); } set { this[nameof(GamesWon)].SetValue<int>(value); } }
    }
    public class PingToRegionInfo : Object
    {
        public PingToRegionInfo(ulong addr) : base(addr) { }
        public Object Region { get { return this[nameof(Region)]; } set { this[nameof(Region)] = value; } }
        public int PingMs { get { return this[nameof(PingMs)].GetValue<int>(); } set { this[nameof(PingMs)].SetValue<int>(value); } }
    }
    public class UserReferFriendInfo : Object
    {
        public UserReferFriendInfo(ulong addr) : base(addr) { }
        public Object Code { get { return this[nameof(Code)]; } set { this[nameof(Code)] = value; } }
        public bool CanBeReferred { get { return this[nameof(CanBeReferred)].Flag; } set { this[nameof(CanBeReferred)].Flag = value; } }
        public int PassLevel { get { return this[nameof(PassLevel)].GetValue<int>(); } set { this[nameof(PassLevel)].SetValue<int>(value); } }
        public Object ReferralCode { get { return this[nameof(ReferralCode)]; } set { this[nameof(ReferralCode)] = value; } }
    }
    public class UserStatsInfo : Object
    {
        public UserStatsInfo(ulong addr) : base(addr) { }
        public PlayerStatsInfo_Career TotalStats { get { return this[nameof(TotalStats)].As<PlayerStatsInfo_Career>(); } set { this["TotalStats"] = value; } }
        public Array<PlaylistStats> Playlists { get { return new Array<PlaylistStats>(this[nameof(Playlists)].Address); } }
    }
    public class PlaylistStats : Object
    {
        public PlaylistStats(ulong addr) : base(addr) { }
        public Object PlaylistType { get { return this[nameof(PlaylistType)]; } set { this[nameof(PlaylistType)] = value; } }
        public PlayerStatsInfo_Career PlaylistStats_value { get { return this[nameof(PlaylistStats)].As<PlayerStatsInfo_Career>(); } set { this["PlaylistStats"] = value; } }
    }
    public class XPAllocation : Object
    {
        public XPAllocation(ulong addr) : base(addr) { }
        public Object Key { get { return this[nameof(Key)]; } set { this[nameof(Key)] = value; } }
        public int Value { get { return this[nameof(Value)].GetValue<int>(); } set { this[nameof(Value)].SetValue<int>(value); } }
    }
    public class UserSeasonRewardInfo : Object
    {
        public UserSeasonRewardInfo(ulong addr) : base(addr) { }
        public int Level { get { return this[nameof(Level)].GetValue<int>(); } set { this[nameof(Level)].SetValue<int>(value); } }
        public int WinCount { get { return this[nameof(WinCount)].GetValue<int>(); } set { this[nameof(WinCount)].SetValue<int>(value); } }
    }
    public class UserBattlePassProgressionInfo : Object
    {
        public UserBattlePassProgressionInfo(ulong addr) : base(addr) { }
        public int Xp { get { return this[nameof(Xp)].GetValue<int>(); } set { this[nameof(Xp)].SetValue<int>(value); } }
        public int Level { get { return this[nameof(Level)].GetValue<int>(); } set { this[nameof(Level)].SetValue<int>(value); } }
        public bool OwnsPremium { get { return this[nameof(OwnsPremium)].Flag; } set { this[nameof(OwnsPremium)].Flag = value; } }
    }
    public class UserDailyCheckInInfo : Object
    {
        public UserDailyCheckInInfo(ulong addr) : base(addr) { }
        public int DayOfWeek { get { return this[nameof(DayOfWeek)].GetValue<int>(); } set { this[nameof(DayOfWeek)].SetValue<int>(value); } }
        public int DaysClaimedCount { get { return this[nameof(DaysClaimedCount)].GetValue<int>(); } set { this[nameof(DaysClaimedCount)].SetValue<int>(value); } }
        public int DaysMissedCount { get { return this[nameof(DaysMissedCount)].GetValue<int>(); } set { this[nameof(DaysMissedCount)].SetValue<int>(value); } }
        public long WeekStartsAtMs { get { return this[nameof(WeekStartsAtMs)].GetValue<long>(); } set { this[nameof(WeekStartsAtMs)].SetValue<long>(value); } }
        public long WeekExpiresAtMs { get { return this[nameof(WeekExpiresAtMs)].GetValue<long>(); } set { this[nameof(WeekExpiresAtMs)].SetValue<long>(value); } }
    }
    public class UserChallengesInfo : Object
    {
        public UserChallengesInfo(ulong addr) : base(addr) { }
        public Array<UserChallengeInfo> Challenges { get { return new Array<UserChallengeInfo>(this[nameof(Challenges)].Address); } }
    }
    public class UserChallengeInfo : Object
    {
        public UserChallengeInfo(ulong addr) : base(addr) { }
        public int ID { get { return this[nameof(ID)].GetValue<int>(); } set { this[nameof(ID)].SetValue<int>(value); } }
        public int CurrentValue { get { return this[nameof(CurrentValue)].GetValue<int>(); } set { this[nameof(CurrentValue)].SetValue<int>(value); } }
        public bool IsComplete { get { return this[nameof(IsComplete)].Flag; } set { this[nameof(IsComplete)].Flag = value; } }
        public bool IsClaimed { get { return this[nameof(IsClaimed)].Flag; } set { this[nameof(IsClaimed)].Flag = value; } }
    }
    public class UserInfo : Object
    {
        public UserInfo(ulong addr) : base(addr) { }
        public Object EncodedCompositeUserId { get { return this[nameof(EncodedCompositeUserId)]; } set { this[nameof(EncodedCompositeUserId)] = value; } }
        public Object DisplayName { get { return this[nameof(DisplayName)]; } set { this[nameof(DisplayName)] = value; } }
    }
}
