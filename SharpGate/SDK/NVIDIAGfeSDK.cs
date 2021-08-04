using UnrealSharp;
using Object = UnrealSharp.UEObject;
using SDK.Script.EngineSDK;
namespace SDK.Script.NVIDIAGfeSDKSDK
{
    public class HighlightsFunctionLibrary : BlueprintFunctionLibrary
    {
        public HighlightsFunctionLibrary(ulong addr) : base(addr) { }
        public void Poll() { Invoke(nameof(Poll)); }
        public void ChekIfHighlightsAvailable(GfeSDKCreateResponse InitProperties, bool VideoGranted, bool ScreenshotsGranted, EGfeSDKPermission Video, EGfeSDKPermission Screenshots) { Invoke(nameof(ChekIfHighlightsAvailable), InitProperties, VideoGranted, ScreenshotsGranted, Video, Screenshots); }
    }
    public class InitHighlights : BlueprintAsyncActionBase
    {
        public InitHighlights(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public InitHighlights InitHighlights_value(Object WorldContextObject, Object InGameName, bool Video, bool Screenshots) { return Invoke<InitHighlights>(nameof(InitHighlights_value), WorldContextObject, InGameName, Video, Screenshots); }
    }
    public class HighlightsConfigureAsync : BlueprintAsyncActionBase
    {
        public HighlightsConfigureAsync(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public HighlightsConfigureAsync HighlightsConfigure(Object WorldContextObject, GfeSDKHighlightConfigParams ConfigParams) { return Invoke<HighlightsConfigureAsync>(nameof(HighlightsConfigure), WorldContextObject, ConfigParams); }
    }
    public class HighlightsOpenGroupAsync : BlueprintAsyncActionBase
    {
        public HighlightsOpenGroupAsync(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public HighlightsOpenGroupAsync HighlightsOpenGroup(Object WorldContextObject, GfeSDKHighlightOpenGroupParams Params) { return Invoke<HighlightsOpenGroupAsync>(nameof(HighlightsOpenGroup), WorldContextObject, Params); }
    }
    public class HighlightsCloseGroupAsync : BlueprintAsyncActionBase
    {
        public HighlightsCloseGroupAsync(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public HighlightsCloseGroupAsync HighlightsCloseGroup(Object WorldContextObject, Object GroupId, bool DestroyHighlights) { return Invoke<HighlightsCloseGroupAsync>(nameof(HighlightsCloseGroup), WorldContextObject, GroupId, DestroyHighlights); }
    }
    public class HighlightsSetScreenshotAsync : BlueprintAsyncActionBase
    {
        public HighlightsSetScreenshotAsync(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public HighlightsSetScreenshotAsync HighlightsSetScreenshot(Object WorldContextObject, Object GroupId, Object HighlightId) { return Invoke<HighlightsSetScreenshotAsync>(nameof(HighlightsSetScreenshot), WorldContextObject, GroupId, HighlightId); }
    }
    public class HighlightsSetVideoAsync : BlueprintAsyncActionBase
    {
        public HighlightsSetVideoAsync(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public HighlightsSetVideoAsync HighlightsSetVideo(Object WorldContextObject, Object GroupId, Object HighlightId, int StartDelta, int EndDelta) { return Invoke<HighlightsSetVideoAsync>(nameof(HighlightsSetVideo), WorldContextObject, GroupId, HighlightId, StartDelta, EndDelta); }
    }
    public class HighlightsSummaryAsync : BlueprintAsyncActionBase
    {
        public HighlightsSummaryAsync(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public HighlightsSummaryAsync HighlightsOpenSummary(Object WorldContextObject, GfeSDKHighlightSummaryParams Params) { return Invoke<HighlightsSummaryAsync>(nameof(HighlightsOpenSummary), WorldContextObject, Params); }
    }
    public class HighlightsGetNumberAsync : BlueprintAsyncActionBase
    {
        public HighlightsGetNumberAsync(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public HighlightsGetNumberAsync HighlightsGetNumberOfHighlights(Object WorldContextObject, Object GroupId, EGfeSDKHighlightType TagFilter, EGfeSDKHighlightSignificance SignificanceFilter) { return Invoke<HighlightsGetNumberAsync>(nameof(HighlightsGetNumberOfHighlights), WorldContextObject, GroupId, TagFilter, SignificanceFilter); }
    }
    public class RequestPermissionsAsync : BlueprintAsyncActionBase
    {
        public RequestPermissionsAsync(ulong addr) : base(addr) { }
        public Object OnSuccess { get { return this[nameof(OnSuccess)]; } set { this[nameof(OnSuccess)] = value; } }
        public Object OnFailure { get { return this[nameof(OnFailure)]; } set { this[nameof(OnFailure)] = value; } }
        public RequestPermissionsAsync GFERequestPermissions(Object WorldContextObject, bool Video, bool Screenshots) { return Invoke<RequestPermissionsAsync>(nameof(GFERequestPermissions), WorldContextObject, Video, Screenshots); }
    }
    public enum EGfeSDKReturnCode : int
    {
        Success = 0,
        SuccessIpcOldSdk = 1,
        SuccessIpcOldGfe = 2,
        Error = 3,
        ErrorGfeVersion = 4,
        ErrorSdkVersion = 5,
        ErrorModuleNotLoaded = 6,
        ErrorWrongTimeRangeSet = 7,
        ErrorGeneric = 8,
        ErrorNotImplemented = 9,
        ErrorInvalidParameter = 10,
        ErrorNotSet = 11,
        ErrorShadowplayIRDisabled = 12,
        ErrorSDKInUse = 13,
        ErrorGroupNotFound = 14,
        ErrorFileNotFound = 15,
        ErrorHighlightsSetupFailed = 16,
        ErrorHighlightsNotConfigured = 17,
        ErrorHighlightSaveFailed = 18,
        ErrorUnexpectedException = 19,
        ErrorNoHighlights = 20,
        ErrorNoConnection = 21,
        ErrorPermissionNotGranted = 22,
        ErrorPermissionDenied = 23,
        ErrorInvalidHandle = 24,
        ErrorUnhandledException = 25,
        ErrorOutOfMemory = 26,
        ErrorLoadLibrary = 27,
        ErrorLibraryCallFailed = 28,
        ErrorIPCFailed = 29,
        ErrorConnection = 30,
        ErrorLibCallTimeout = 32,
        ErrorApplicationLookupFailed = 33,
        ErrorApplicationNotKnown = 34,
        ErrorFeatureDisabled = 35,
        ErrorAppNoOptimization = 36,
        ErrorAppSettingsRead = 37,
        ErrorAppSettingsWrite = 38,
        EGfeSDKReturnCode_MAX = 39,
    }
    public class GfeSDKCreateResponse : Object
    {
        public GfeSDKCreateResponse(ulong addr) : base(addr) { }
        public ushort VersionMajor { get { return this[nameof(VersionMajor)].GetValue<ushort>(); } set { this[nameof(VersionMajor)].SetValue<ushort>(value); } }
        public ushort VersionMinor { get { return this[nameof(VersionMinor)].GetValue<ushort>(); } set { this[nameof(VersionMinor)].SetValue<ushort>(value); } }
        public Object NVIDIAGfeVersion { get { return this[nameof(NVIDIAGfeVersion)]; } set { this[nameof(NVIDIAGfeVersion)] = value; } }
        public Object ScopePermissions { get { return this[nameof(ScopePermissions)]; } set { this[nameof(ScopePermissions)] = value; } }
    }
    public enum EGfeSDKScope : int
    {
        Highlights = 0,
        HighlightsRecordVideo = 1,
        HighlightsRecordScreenshot = 2,
        MAX = 3,
    }
    public enum EGfeSDKPermission : int
    {
        Granted = 0,
        Denied = 1,
        MustAsk = 2,
        Unknown = 3,
        MAX = 4,
    }
    public enum EGfeSDKHighlightSignificance : int
    {
        NONE = 0,
        ExtremelyBad = 1,
        VeryBad = 2,
        Bad = 4,
        Neutral = 8,
        Good = 16,
        VeryGood = 32,
        ExtremelyGood = 64,
        MAX = 128,
    }
    public enum EGfeSDKHighlightType : int
    {
        NONE = 0,
        Milestone = 1,
        Achievement = 2,
        Incident = 4,
        StateChange = 8,
        Unannounced = 16,
        MAX = 32,
    }
    public class GfeSDKHighlightSummaryParams : Object
    {
        public GfeSDKHighlightSummaryParams(ulong addr) : base(addr) { }
        public Array<GfeSDKHighlightGroupView> GroupViews { get { return new Array<GfeSDKHighlightGroupView>(this[nameof(GroupViews)].Address); } }
    }
    public class GfeSDKHighlightGroupView : Object
    {
        public GfeSDKHighlightGroupView(ulong addr) : base(addr) { }
        public Object GroupId { get { return this[nameof(GroupId)]; } set { this[nameof(GroupId)] = value; } }
        public EGfeSDKHighlightType TagsFilter { get { return (EGfeSDKHighlightType)this[nameof(TagsFilter)].GetValue<int>(); } set { this[nameof(TagsFilter)].SetValue<int>((int)value); } }
        public EGfeSDKHighlightSignificance SignificanceFilter { get { return (EGfeSDKHighlightSignificance)this[nameof(SignificanceFilter)].GetValue<int>(); } set { this[nameof(SignificanceFilter)].SetValue<int>((int)value); } }
    }
    public class GfeSDKHighlightVideoParams : Object
    {
        public GfeSDKHighlightVideoParams(ulong addr) : base(addr) { }
        public Object GroupId { get { return this[nameof(GroupId)]; } set { this[nameof(GroupId)] = value; } }
        public Object HighlightId { get { return this[nameof(HighlightId)]; } set { this[nameof(HighlightId)] = value; } }
        public int StartDelta { get { return this[nameof(StartDelta)].GetValue<int>(); } set { this[nameof(StartDelta)].SetValue<int>(value); } }
        public int EndDelta { get { return this[nameof(EndDelta)].GetValue<int>(); } set { this[nameof(EndDelta)].SetValue<int>(value); } }
    }
    public class GfeSDKHighlightScreenshotParams : Object
    {
        public GfeSDKHighlightScreenshotParams(ulong addr) : base(addr) { }
        public Object GroupId { get { return this[nameof(GroupId)]; } set { this[nameof(GroupId)] = value; } }
        public Object HighlightId { get { return this[nameof(HighlightId)]; } set { this[nameof(HighlightId)] = value; } }
    }
    public class GfeSDKHighlightCloseGroupParams : Object
    {
        public GfeSDKHighlightCloseGroupParams(ulong addr) : base(addr) { }
        public Object GroupId { get { return this[nameof(GroupId)]; } set { this[nameof(GroupId)] = value; } }
        public bool DestroyHighlights { get { return this[nameof(DestroyHighlights)].Flag; } set { this[nameof(DestroyHighlights)].Flag = value; } }
    }
    public class GfeSDKHighlightOpenGroupParams : Object
    {
        public GfeSDKHighlightOpenGroupParams(ulong addr) : base(addr) { }
        public Object GroupId { get { return this[nameof(GroupId)]; } set { this[nameof(GroupId)] = value; } }
        public Object GroupDescriptionTranslationTable { get { return this[nameof(GroupDescriptionTranslationTable)]; } set { this[nameof(GroupDescriptionTranslationTable)] = value; } }
    }
    public class GfeSDKPermissionsChangedData : Object
    {
        public GfeSDKPermissionsChangedData(ulong addr) : base(addr) { }
        public Object ScopePermissions { get { return this[nameof(ScopePermissions)]; } set { this[nameof(ScopePermissions)] = value; } }
    }
    public class GfeSDKRequestPermissionsParams : Object
    {
        public GfeSDKRequestPermissionsParams(ulong addr) : base(addr) { }
        public Array<EGfeSDKScope> Scopes { get { return new Array<EGfeSDKScope>(this[nameof(Scopes)].Address); } }
    }
    public class GfeSDKHighlightConfigParams : Object
    {
        public GfeSDKHighlightConfigParams(ulong addr) : base(addr) { }
        public Array<GfeSDKHighlightDefinition> HighlightDefinitions { get { return new Array<GfeSDKHighlightDefinition>(this[nameof(HighlightDefinitions)].Address); } }
        public Object DefaultLocale { get { return this[nameof(DefaultLocale)]; } set { this[nameof(DefaultLocale)] = value; } }
    }
    public class GfeSDKHighlightDefinition : Object
    {
        public GfeSDKHighlightDefinition(ulong addr) : base(addr) { }
        public Object ID { get { return this[nameof(ID)]; } set { this[nameof(ID)] = value; } }
        public bool UserDefaultInterest { get { return this[nameof(UserDefaultInterest)].Flag; } set { this[nameof(UserDefaultInterest)].Flag = value; } }
        public EGfeSDKHighlightType HighlightTags { get { return (EGfeSDKHighlightType)this[nameof(HighlightTags)].GetValue<int>(); } set { this[nameof(HighlightTags)].SetValue<int>((int)value); } }
        public EGfeSDKHighlightSignificance Significance { get { return (EGfeSDKHighlightSignificance)this[nameof(Significance)].GetValue<int>(); } set { this[nameof(Significance)].SetValue<int>((int)value); } }
        public Object NameTranslationTable { get { return this[nameof(NameTranslationTable)]; } set { this[nameof(NameTranslationTable)] = value; } }
    }
    public class GfeSDKCreateInputParams : Object
    {
        public GfeSDKCreateInputParams(ulong addr) : base(addr) { }
        public Object AppName { get { return this[nameof(AppName)]; } set { this[nameof(AppName)] = value; } }
        public Array<EGfeSDKScope> RequiredScopes { get { return new Array<EGfeSDKScope>(this[nameof(RequiredScopes)].Address); } }
        public bool PollForCallbacks { get { return this[nameof(PollForCallbacks)].Flag; } set { this[nameof(PollForCallbacks)].Flag = value; } }
    }
}
