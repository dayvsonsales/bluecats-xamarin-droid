using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BlueCatsSDK", DoNotGenerateAcw=true)]
	public partial class BlueCatsSDK : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='BC_OPTION_API_BASE_URL']"
		[Register ("BC_OPTION_API_BASE_URL")]
		public const string BcOptionApiBaseUrl = (string) "BC_OPTION_API_BASE_URL";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='BC_OPTION_BEACON_VISIT_TRACKING_ENABLED']"
		[Register ("BC_OPTION_BEACON_VISIT_TRACKING_ENABLED")]
		public const string BcOptionBeaconVisitTrackingEnabled = (string) "BC_OPTION_BEACON_VISIT_TRACKING_ENABLED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='BC_OPTION_CACHE_ALL_BEACONS_FOR_APP']"
		[Register ("BC_OPTION_CACHE_ALL_BEACONS_FOR_APP")]
		public const string BcOptionCacheAllBeaconsForApp = (string) "BC_OPTION_CACHE_ALL_BEACONS_FOR_APP";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='BC_OPTION_CACHE_REFRESH_TIME_INTERVAL_IN_MILLISECONDS']"
		[Register ("BC_OPTION_CACHE_REFRESH_TIME_INTERVAL_IN_MILLISECONDS")]
		public const string BcOptionCacheRefreshTimeIntervalInMilliseconds = (string) "BC_OPTION_CACHE_REFRESH_TIME_INTERVAL_IN_MILLISECONDS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='BC_OPTION_CACHE_SITES_NEARBY_BY_LOCATION']"
		[Register ("BC_OPTION_CACHE_SITES_NEARBY_BY_LOCATION")]
		public const string BcOptionCacheSitesNearbyByLocation = (string) "BC_OPTION_CACHE_SITES_NEARBY_BY_LOCATION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='BC_OPTION_CROWD_SOURCE_BEACON_UPDATES']"
		[Register ("BC_OPTION_CROWD_SOURCE_BEACON_UPDATES")]
		public const string BcOptionCrowdSourceBeaconUpdates = (string) "BC_OPTION_CROWD_SOURCE_BEACON_UPDATES";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='BC_OPTION_DEEP_SLEEP_WAKEUP_TIME_INTERVAL_IN_MINUTES']"
		[Register ("BC_OPTION_DEEP_SLEEP_WAKEUP_TIME_INTERVAL_IN_MINUTES")]
		public const string BcOptionDeepSleepWakeupTimeIntervalInMinutes = (string) "BC_OPTION_DEEP_SLEEP_WAKEUP_TIME_INTERVAL_IN_MINUTES";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='BC_OPTION_DISCOVER_BEACONS_NEARBY']"
		[Register ("BC_OPTION_DISCOVER_BEACONS_NEARBY")]
		public const string BcOptionDiscoverBeaconsNearby = (string) "BC_OPTION_DISCOVER_BEACONS_NEARBY";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='BC_OPTION_ENERGY_SAVER_SCAN_STRATEGY']"
		[Register ("BC_OPTION_ENERGY_SAVER_SCAN_STRATEGY")]
		public const string BcOptionEnergySaverScanStrategy = (string) "BC_OPTION_ENERGY_SAVER_SCAN_STRATEGY";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='BC_OPTION_MONITOR_ALL_AVAILABLE_REGIONS_ON_STARTUP']"
		[Register ("BC_OPTION_MONITOR_ALL_AVAILABLE_REGIONS_ON_STARTUP")]
		public const string BcOptionMonitorAllAvailableRegionsOnStartup = (string) "BC_OPTION_MONITOR_ALL_AVAILABLE_REGIONS_ON_STARTUP";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='BC_OPTION_MONITOR_BLUE_CATS_REGION_ON_STARTUP']"
		[Register ("BC_OPTION_MONITOR_BLUE_CATS_REGION_ON_STARTUP")]
		public const string BcOptionMonitorBlueCatsRegionOnStartup = (string) "BC_OPTION_MONITOR_BLUE_CATS_REGION_ON_STARTUP";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='BC_OPTION_REMOTE_CONFIGURATION_EXPIRATION_TIME_INTERVAL_IN_MILLISECONDS']"
		[Register ("BC_OPTION_REMOTE_CONFIGURATION_EXPIRATION_TIME_INTERVAL_IN_MILLISECONDS")]
		public const string BcOptionRemoteConfigurationExpirationTimeIntervalInMilliseconds = (string) "BC_OPTION_REMOTE_CONFIGURATION_EXPIRATION_TIME_INTERVAL_IN_MILLISECONDS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='BC_OPTION_REMOTE_CONFIGURATION_REFRESH_TIME_INTERVAL_IN_MILLISECONDS']"
		[Register ("BC_OPTION_REMOTE_CONFIGURATION_REFRESH_TIME_INTERVAL_IN_MILLISECONDS")]
		public const string BcOptionRemoteConfigurationRefreshTimeIntervalInMilliseconds = (string) "BC_OPTION_REMOTE_CONFIGURATION_REFRESH_TIME_INTERVAL_IN_MILLISECONDS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='BC_OPTION_USE_API']"
		[Register ("BC_OPTION_USE_API")]
		public const string BcOptionUseApi = (string) "BC_OPTION_USE_API";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='BC_OPTION_USE_LOCAL_STORAGE']"
		[Register ("BC_OPTION_USE_LOCAL_STORAGE")]
		public const string BcOptionUseLocalStorage = (string) "BC_OPTION_USE_LOCAL_STORAGE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='BC_OPTION_USE_RSSI_SMOOTHING']"
		[Register ("BC_OPTION_USE_RSSI_SMOOTHING")]
		public const string BcOptionUseRssiSmoothing = (string) "BC_OPTION_USE_RSSI_SMOOTHING";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='BC_OPTION_USE_STAGE_API']"
		[Register ("BC_OPTION_USE_STAGE_API")]
		public const string BcOptionUseStageApi = (string) "BC_OPTION_USE_STAGE_API";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='BC_SDK_GITHASH']"
		[Register ("BC_SDK_GITHASH")]
		public const string BcSdkGithash = (string) "dbc2cfe";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='BC_SDK_VERSION']"
		[Register ("BC_SDK_VERSION")]
		public const string BcSdkVersion = (string) "2.0.4";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='DBG']"
		[Register ("DBG")]
		public const bool Dbg = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='DBG_LOG_TO_FILE']"
		[Register ("DBG_LOG_TO_FILE")]
		public const bool DbgLogToFile = (bool) false;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_ALERTS']"
		[Register ("EXTRA_ALERTS")]
		public const string ExtraAlerts = (string) "BlueCatsSDK_ALERTS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_APP']"
		[Register ("EXTRA_APP")]
		public const string ExtraApp = (string) "BlueCatsSDK_APP";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_APPS']"
		[Register ("EXTRA_APPS")]
		public const string ExtraApps = (string) "BlueCatsSDK_APPS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_APP_INSIGHTS']"
		[Register ("EXTRA_APP_INSIGHTS")]
		public const string ExtraAppInsights = (string) "BlueCatsSDK_APP_INSIGHTS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_APP_TOKEN']"
		[Register ("EXTRA_APP_TOKEN")]
		public const string ExtraAppToken = (string) "BlueCatsSDK_APP_TOKEN";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_BEACON']"
		[Register ("EXTRA_BEACON")]
		public const string ExtraBeacon = (string) "BlueCatsSDK_BEACON";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_BEACONS']"
		[Register ("EXTRA_BEACONS")]
		public const string ExtraBeacons = (string) "BlueCatsSDK_BEACONS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_BEACON_FIRMWARE']"
		[Register ("EXTRA_BEACON_FIRMWARE")]
		public const string ExtraBeaconFirmware = (string) "BlueCatsSDK_BEACON_FIRMWARE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_BEACON_INSIGHTS']"
		[Register ("EXTRA_BEACON_INSIGHTS")]
		public const string ExtraBeaconInsights = (string) "BlueCatsSDK_BEACON_INSIGHTS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_BEACON_LOUDNESSES']"
		[Register ("EXTRA_BEACON_LOUDNESSES")]
		public const string ExtraBeaconLoudnesses = (string) "BlueCatsSDK_BEACON_LOUDNESSES";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_BEACON_MILK_BYTES_ARRAY']"
		[Register ("EXTRA_BEACON_MILK_BYTES_ARRAY")]
		public const string ExtraBeaconMilkBytesArray = (string) "BlueCatsSDK_EXTRA_BEACON_MILK_BYTES_ARRAY";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_BEACON_MODES']"
		[Register ("EXTRA_BEACON_MODES")]
		public const string ExtraBeaconModes = (string) "BlueCatsSDK_BEACON_MODES";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_BEACON_REGION']"
		[Register ("EXTRA_BEACON_REGION")]
		public const string ExtraBeaconRegion = (string) "BlueCatsSDK_BEACON_REGION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_BEACON_REGIONS']"
		[Register ("EXTRA_BEACON_REGIONS")]
		public const string ExtraBeaconRegions = (string) "BlueCatsSDK_BEACON_REGIONS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_BEACON_SETTINGS_BYTES_ARRAY']"
		[Register ("EXTRA_BEACON_SETTINGS_BYTES_ARRAY")]
		public const string ExtraBeaconSettingsBytesArray = (string) "BlueCatsSDK_EXTRA_BEACON_SETTINGS_BYTES_ARRAY";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_BEACON_VERSION']"
		[Register ("EXTRA_BEACON_VERSION")]
		public const string ExtraBeaconVersion = (string) "EXTRA_BEACON_VERSION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_BEACON_VISIT']"
		[Register ("EXTRA_BEACON_VISIT")]
		public const string ExtraBeaconVisit = (string) "BlueCatsSDK_BEACON_VISIT";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_BEACON_VISITS']"
		[Register ("EXTRA_BEACON_VISITS")]
		public const string ExtraBeaconVisits = (string) "BlueCatsSDK_BEACON_VISITS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_CATEGORIES']"
		[Register ("EXTRA_CATEGORIES")]
		public const string ExtraCategories = (string) "BlueCatsSDK_CATEGORIES";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_CATEGORY']"
		[Register ("EXTRA_CATEGORY")]
		public const string ExtraCategory = (string) "BlueCatsSDK_CATEGORY";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_CATEGORY_INSIGHTS']"
		[Register ("EXTRA_CATEGORY_INSIGHTS")]
		public const string ExtraCategoryInsights = (string) "BlueCatsSDK_CATEGORY_INSIGHTS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_DEVICE']"
		[Register ("EXTRA_DEVICE")]
		public const string ExtraDevice = (string) "BlueCatsSDK_DEVICE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_ERROR']"
		[Register ("EXTRA_ERROR")]
		public const string ExtraError = (string) "BlueCatsSDK_ERROR";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_EVENT']"
		[Register ("EXTRA_EVENT")]
		public const string ExtraEvent = (string) "BlueCatsSDK_EVENT";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_EVENTS']"
		[Register ("EXTRA_EVENTS")]
		public const string ExtraEvents = (string) "BlueCatsSDK_EVENTS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_FIRMWARE_HEADER_LEN']"
		[Register ("EXTRA_FIRMWARE_HEADER_LEN")]
		public const string ExtraFirmwareHeaderLen = (string) "BlueCatsSDK_EXTRA_FIRMWARE_HEADER_LEN";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_FIRMWARE_HEX_BYTES_ARRAY']"
		[Register ("EXTRA_FIRMWARE_HEX_BYTES_ARRAY")]
		public const string ExtraFirmwareHexBytesArray = (string) "BlueCatsSDK_EXTRA_FIRMWARE_HEX_BYTES_ARRAY";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_JSON_DATA']"
		[Register ("EXTRA_JSON_DATA")]
		public const string ExtraJsonData = (string) "BlueCatsSDK_JSON_DATA";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_MARKERS']"
		[Register ("EXTRA_MARKERS")]
		public const string ExtraMarkers = (string) "BlueCatsSDK_MARKERS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_MICRO_LOCATION']"
		[Register ("EXTRA_MICRO_LOCATION")]
		public const string ExtraMicroLocation = (string) "BlueCatsSDK_MICRO_LOCATION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_MICRO_LOCATIONS']"
		[Register ("EXTRA_MICRO_LOCATIONS")]
		public const string ExtraMicroLocations = (string) "BlueCatsSDK_MICRO_LOCATIONS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_OPERATION_TYPE']"
		[Register ("EXTRA_OPERATION_TYPE")]
		public const string ExtraOperationType = (string) "BlueCatsSDK_OPERATION_TYPE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_PERSON']"
		[Register ("EXTRA_PERSON")]
		public const string ExtraPerson = (string) "BlueCatsSDK_PERSON";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_PLATFORM_TYPES']"
		[Register ("EXTRA_PLATFORM_TYPES")]
		public const string ExtraPlatformTypes = (string) "BlueCatsSDK_PLATFORM_TYPES";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_RSSI']"
		[Register ("EXTRA_RSSI")]
		public const string ExtraRssi = (string) "BlueCatsSDK_RSSI";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_SCAN_RECORD']"
		[Register ("EXTRA_SCAN_RECORD")]
		public const string ExtraScanRecord = (string) "BlueCatsSDK_SCAN_RECORD";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_SITE']"
		[Register ("EXTRA_SITE")]
		public const string ExtraSite = (string) "BlueCatsSDK_SITE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_SITES']"
		[Register ("EXTRA_SITES")]
		public const string ExtraSites = (string) "BlueCatsSDK_SITES";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_SITE_ACCESS_TYPES']"
		[Register ("EXTRA_SITE_ACCESS_TYPES")]
		public const string ExtraSiteAccessTypes = (string) "BlueCatsSDK_SITE_ACCESS_TYPES";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_SITE_ID']"
		[Register ("EXTRA_SITE_ID")]
		public const string ExtraSiteId = (string) "BlueCatsSDK_SITE_ID";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_SITE_INSIGHTS']"
		[Register ("EXTRA_SITE_INSIGHTS")]
		public const string ExtraSiteInsights = (string) "BlueCatsSDK_SITE_INSIGHTS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_START_PURRING']"
		[Register ("EXTRA_START_PURRING")]
		public const string ExtraStartPurring = (string) "BlueCatsSDK_START_PURRING";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_STATUS']"
		[Register ("EXTRA_STATUS")]
		public const string ExtraStatus = (string) "BlueCatsSDK_STATUS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_TARGET_SPEEDS']"
		[Register ("EXTRA_TARGET_SPEEDS")]
		public const string ExtraTargetSpeeds = (string) "BlueCatsSDK_TARGET_SPEEDS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_TEAM']"
		[Register ("EXTRA_TEAM")]
		public const string ExtraTeam = (string) "BlueCatsSDK_TEAM";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_TEAMMATES']"
		[Register ("EXTRA_TEAMMATES")]
		public const string ExtraTeammates = (string) "BlueCatsSDK_TEAMMATES";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_TEAMS']"
		[Register ("EXTRA_TEAMS")]
		public const string ExtraTeams = (string) "BlueCatsSDK_TEAMS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_TEAM_INSIGHTS']"
		[Register ("EXTRA_TEAM_INSIGHTS")]
		public const string ExtraTeamInsights = (string) "BlueCatsSDK_TEAM_INSIGHTS";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_TEAM_INVITE']"
		[Register ("EXTRA_TEAM_INVITE")]
		public const string ExtraTeamInvite = (string) "BlueCatsSDK_TEAM_INVITE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_TEAM_INVITES']"
		[Register ("EXTRA_TEAM_INVITES")]
		public const string ExtraTeamInvites = (string) "BlueCatsSDK_TEAM_INVITES";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/field[@name='EXTRA_UUID']"
		[Register ("EXTRA_UUID")]
		public const string ExtraUuid = (string) "BlueCatsSDK_UUID";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK.BCAppTokenVerificationStatus']"
		[global::Android.Runtime.Register ("com/bluecats/sdk/BlueCatsSDK$BCAppTokenVerificationStatus", DoNotGenerateAcw=true)]
		public sealed partial class BCAppTokenVerificationStatus : global::Java.Lang.Enum {


			static IntPtr BC_APP_TOKEN_VERIFICATION_STATUS_INVALID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK.BCAppTokenVerificationStatus']/field[@name='BC_APP_TOKEN_VERIFICATION_STATUS_INVALID']"
			[Register ("BC_APP_TOKEN_VERIFICATION_STATUS_INVALID")]
			public static global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus BcAppTokenVerificationStatusInvalid {
				get {
					if (BC_APP_TOKEN_VERIFICATION_STATUS_INVALID_jfieldId == IntPtr.Zero)
						BC_APP_TOKEN_VERIFICATION_STATUS_INVALID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_APP_TOKEN_VERIFICATION_STATUS_INVALID", "Lcom/bluecats/sdk/BlueCatsSDK$BCAppTokenVerificationStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_APP_TOKEN_VERIFICATION_STATUS_INVALID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_APP_TOKEN_VERIFICATION_STATUS_NOT_PROVIDED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK.BCAppTokenVerificationStatus']/field[@name='BC_APP_TOKEN_VERIFICATION_STATUS_NOT_PROVIDED']"
			[Register ("BC_APP_TOKEN_VERIFICATION_STATUS_NOT_PROVIDED")]
			public static global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus BcAppTokenVerificationStatusNotProvided {
				get {
					if (BC_APP_TOKEN_VERIFICATION_STATUS_NOT_PROVIDED_jfieldId == IntPtr.Zero)
						BC_APP_TOKEN_VERIFICATION_STATUS_NOT_PROVIDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_APP_TOKEN_VERIFICATION_STATUS_NOT_PROVIDED", "Lcom/bluecats/sdk/BlueCatsSDK$BCAppTokenVerificationStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_APP_TOKEN_VERIFICATION_STATUS_NOT_PROVIDED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_APP_TOKEN_VERIFICATION_STATUS_NOT_VERIFIED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK.BCAppTokenVerificationStatus']/field[@name='BC_APP_TOKEN_VERIFICATION_STATUS_NOT_VERIFIED']"
			[Register ("BC_APP_TOKEN_VERIFICATION_STATUS_NOT_VERIFIED")]
			public static global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus BcAppTokenVerificationStatusNotVerified {
				get {
					if (BC_APP_TOKEN_VERIFICATION_STATUS_NOT_VERIFIED_jfieldId == IntPtr.Zero)
						BC_APP_TOKEN_VERIFICATION_STATUS_NOT_VERIFIED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_APP_TOKEN_VERIFICATION_STATUS_NOT_VERIFIED", "Lcom/bluecats/sdk/BlueCatsSDK$BCAppTokenVerificationStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_APP_TOKEN_VERIFICATION_STATUS_NOT_VERIFIED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_APP_TOKEN_VERIFICATION_STATUS_VERIFIED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK.BCAppTokenVerificationStatus']/field[@name='BC_APP_TOKEN_VERIFICATION_STATUS_VERIFIED']"
			[Register ("BC_APP_TOKEN_VERIFICATION_STATUS_VERIFIED")]
			public static global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus BcAppTokenVerificationStatusVerified {
				get {
					if (BC_APP_TOKEN_VERIFICATION_STATUS_VERIFIED_jfieldId == IntPtr.Zero)
						BC_APP_TOKEN_VERIFICATION_STATUS_VERIFIED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_APP_TOKEN_VERIFICATION_STATUS_VERIFIED", "Lcom/bluecats/sdk/BlueCatsSDK$BCAppTokenVerificationStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_APP_TOKEN_VERIFICATION_STATUS_VERIFIED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bluecats/sdk/BlueCatsSDK$BCAppTokenVerificationStatus", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BCAppTokenVerificationStatus); }
			}

			internal BCAppTokenVerificationStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK.BCAppTokenVerificationStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BlueCatsSDK$BCAppTokenVerificationStatus;", "")]
			public static unsafe global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BlueCatsSDK$BCAppTokenVerificationStatus;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK.BCAppTokenVerificationStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bluecats/sdk/BlueCatsSDK$BCAppTokenVerificationStatus;", "")]
			public static unsafe global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bluecats/sdk/BlueCatsSDK$BCAppTokenVerificationStatus;");
				try {
					return (global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK.BCStatus']"
		[global::Android.Runtime.Register ("com/bluecats/sdk/BlueCatsSDK$BCStatus", DoNotGenerateAcw=true)]
		public sealed partial class BCStatus : global::Java.Lang.Enum {


			static IntPtr BC_STATUS_NEVER_PURRED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK.BCStatus']/field[@name='BC_STATUS_NEVER_PURRED']"
			[Register ("BC_STATUS_NEVER_PURRED")]
			public static global::Com.Bluecats.Sdk.BlueCatsSDK.BCStatus BcStatusNeverPurred {
				get {
					if (BC_STATUS_NEVER_PURRED_jfieldId == IntPtr.Zero)
						BC_STATUS_NEVER_PURRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_STATUS_NEVER_PURRED", "Lcom/bluecats/sdk/BlueCatsSDK$BCStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_STATUS_NEVER_PURRED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BlueCatsSDK.BCStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_STATUS_PURRING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK.BCStatus']/field[@name='BC_STATUS_PURRING']"
			[Register ("BC_STATUS_PURRING")]
			public static global::Com.Bluecats.Sdk.BlueCatsSDK.BCStatus BcStatusPurring {
				get {
					if (BC_STATUS_PURRING_jfieldId == IntPtr.Zero)
						BC_STATUS_PURRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_STATUS_PURRING", "Lcom/bluecats/sdk/BlueCatsSDK$BCStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_STATUS_PURRING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BlueCatsSDK.BCStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_STATUS_PURRING_WITH_ERRORS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK.BCStatus']/field[@name='BC_STATUS_PURRING_WITH_ERRORS']"
			[Register ("BC_STATUS_PURRING_WITH_ERRORS")]
			public static global::Com.Bluecats.Sdk.BlueCatsSDK.BCStatus BcStatusPurringWithErrors {
				get {
					if (BC_STATUS_PURRING_WITH_ERRORS_jfieldId == IntPtr.Zero)
						BC_STATUS_PURRING_WITH_ERRORS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_STATUS_PURRING_WITH_ERRORS", "Lcom/bluecats/sdk/BlueCatsSDK$BCStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_STATUS_PURRING_WITH_ERRORS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BlueCatsSDK.BCStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_STATUS_STARTING_TO_PURR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK.BCStatus']/field[@name='BC_STATUS_STARTING_TO_PURR']"
			[Register ("BC_STATUS_STARTING_TO_PURR")]
			public static global::Com.Bluecats.Sdk.BlueCatsSDK.BCStatus BcStatusStartingToPurr {
				get {
					if (BC_STATUS_STARTING_TO_PURR_jfieldId == IntPtr.Zero)
						BC_STATUS_STARTING_TO_PURR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_STATUS_STARTING_TO_PURR", "Lcom/bluecats/sdk/BlueCatsSDK$BCStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_STATUS_STARTING_TO_PURR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BlueCatsSDK.BCStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_STATUS_STOPPED_PURRING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK.BCStatus']/field[@name='BC_STATUS_STOPPED_PURRING']"
			[Register ("BC_STATUS_STOPPED_PURRING")]
			public static global::Com.Bluecats.Sdk.BlueCatsSDK.BCStatus BcStatusStoppedPurring {
				get {
					if (BC_STATUS_STOPPED_PURRING_jfieldId == IntPtr.Zero)
						BC_STATUS_STOPPED_PURRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_STATUS_STOPPED_PURRING", "Lcom/bluecats/sdk/BlueCatsSDK$BCStatus;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_STATUS_STOPPED_PURRING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BlueCatsSDK.BCStatus> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bluecats/sdk/BlueCatsSDK$BCStatus", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BCStatus); }
			}

			internal BCStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK.BCStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BlueCatsSDK$BCStatus;", "")]
			public static unsafe global::Com.Bluecats.Sdk.BlueCatsSDK.BCStatus ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BlueCatsSDK$BCStatus;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Com.Bluecats.Sdk.BlueCatsSDK.BCStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BlueCatsSDK.BCStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK.BCStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bluecats/sdk/BlueCatsSDK$BCStatus;", "")]
			public static unsafe global::Com.Bluecats.Sdk.BlueCatsSDK.BCStatus[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bluecats/sdk/BlueCatsSDK$BCStatus;");
				try {
					return (global::Com.Bluecats.Sdk.BlueCatsSDK.BCStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BlueCatsSDK.BCStatus));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BlueCatsSDK", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BlueCatsSDK); }
		}

		protected BlueCatsSDK (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/constructor[@name='BlueCatsSDK' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BlueCatsSDK ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BlueCatsSDK)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_getAppTokenVerificationStatus;
		public static unsafe global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus AppTokenVerificationStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/method[@name='getAppTokenVerificationStatus' and count(parameter)=0]"
			[Register ("getAppTokenVerificationStatus", "()Lcom/bluecats/sdk/BlueCatsSDK$BCAppTokenVerificationStatus;", "GetGetAppTokenVerificationStatusHandler")]
			get {
				if (id_getAppTokenVerificationStatus == IntPtr.Zero)
					id_getAppTokenVerificationStatus = JNIEnv.GetStaticMethodID (class_ref, "getAppTokenVerificationStatus", "()Lcom/bluecats/sdk/BlueCatsSDK$BCAppTokenVerificationStatus;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppTokenVerificationStatus), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getApplicationContext;
		public static unsafe global::Android.Content.Context ApplicationContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/method[@name='getApplicationContext' and count(parameter)=0]"
			[Register ("getApplicationContext", "()Landroid/content/Context;", "GetGetApplicationContextHandler")]
			get {
				if (id_getApplicationContext == IntPtr.Zero)
					id_getApplicationContext = JNIEnv.GetStaticMethodID (class_ref, "getApplicationContext", "()Landroid/content/Context;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getApplicationContext), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCurrentApp;
		public static unsafe global::Com.Bluecats.Sdk.IBCApp CurrentApp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/method[@name='getCurrentApp' and count(parameter)=0]"
			[Register ("getCurrentApp", "()Lcom/bluecats/sdk/BCApp;", "GetGetCurrentAppHandler")]
			get {
				if (id_getCurrentApp == IntPtr.Zero)
					id_getCurrentApp = JNIEnv.GetStaticMethodID (class_ref, "getCurrentApp", "()Lcom/bluecats/sdk/BCApp;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCurrentApp), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isBluetoothEnabled;
		public static unsafe bool IsBluetoothEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/method[@name='isBluetoothEnabled' and count(parameter)=0]"
			[Register ("isBluetoothEnabled", "()Z", "GetIsBluetoothEnabledHandler")]
			get {
				if (id_isBluetoothEnabled == IntPtr.Zero)
					id_isBluetoothEnabled = JNIEnv.GetStaticMethodID (class_ref, "isBluetoothEnabled", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isBluetoothEnabled);
				} finally {
				}
			}
		}

		static IntPtr id_getStatus;
		public static unsafe global::Com.Bluecats.Sdk.BlueCatsSDK.BCStatus Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Lcom/bluecats/sdk/BlueCatsSDK$BCStatus;", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetStaticMethodID (class_ref, "getStatus", "()Lcom/bluecats/sdk/BlueCatsSDK$BCStatus;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BlueCatsSDK.BCStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStatus), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_createEmptyApp;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/method[@name='createEmptyApp' and count(parameter)=0]"
		[Register ("createEmptyApp", "()Lcom/bluecats/sdk/BCApp;", "")]
		public static unsafe global::Com.Bluecats.Sdk.IBCApp CreateEmptyApp ()
		{
			if (id_createEmptyApp == IntPtr.Zero)
				id_createEmptyApp = JNIEnv.GetStaticMethodID (class_ref, "createEmptyApp", "()Lcom/bluecats/sdk/BCApp;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createEmptyApp), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createEmptyBeacon;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/method[@name='createEmptyBeacon' and count(parameter)=0]"
		[Register ("createEmptyBeacon", "()Lcom/bluecats/sdk/BCBeacon;", "")]
		public static unsafe global::Com.Bluecats.Sdk.IBCBeacon CreateEmptyBeacon ()
		{
			if (id_createEmptyBeacon == IntPtr.Zero)
				id_createEmptyBeacon = JNIEnv.GetStaticMethodID (class_ref, "createEmptyBeacon", "()Lcom/bluecats/sdk/BCBeacon;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createEmptyBeacon), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createEmptySite;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/method[@name='createEmptySite' and count(parameter)=0]"
		[Register ("createEmptySite", "()Lcom/bluecats/sdk/BCSite;", "")]
		public static unsafe global::Com.Bluecats.Sdk.IBCSite CreateEmptySite ()
		{
			if (id_createEmptySite == IntPtr.Zero)
				id_createEmptySite = JNIEnv.GetStaticMethodID (class_ref, "createEmptySite", "()Lcom/bluecats/sdk/BCSite;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createEmptySite), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_didEnterBackground;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/method[@name='didEnterBackground' and count(parameter)=0]"
		[Register ("didEnterBackground", "()V", "")]
		public static unsafe void DidEnterBackground ()
		{
			if (id_didEnterBackground == IntPtr.Zero)
				id_didEnterBackground = JNIEnv.GetStaticMethodID (class_ref, "didEnterBackground", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_didEnterBackground);
			} finally {
			}
		}

		static IntPtr id_didEnterForeground;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/method[@name='didEnterForeground' and count(parameter)=0]"
		[Register ("didEnterForeground", "()V", "")]
		public static unsafe void DidEnterForeground ()
		{
			if (id_didEnterForeground == IntPtr.Zero)
				id_didEnterForeground = JNIEnv.GetStaticMethodID (class_ref, "didEnterForeground", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_didEnterForeground);
			} finally {
			}
		}

		static IntPtr id_getDeviceIdentifier_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/method[@name='getDeviceIdentifier' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getDeviceIdentifier", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetDeviceIdentifier (global::Android.Content.Context context)
		{
			if (id_getDeviceIdentifier_Landroid_content_Context_ == IntPtr.Zero)
				id_getDeviceIdentifier_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getDeviceIdentifier", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeviceIdentifier_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getInstallationIdentifier_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/method[@name='getInstallationIdentifier' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstallationIdentifier", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetInstallationIdentifier (global::Android.Content.Context context)
		{
			if (id_getInstallationIdentifier_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstallationIdentifier_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstallationIdentifier", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstallationIdentifier_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isLocationAuthorized_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/method[@name='isLocationAuthorized' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isLocationAuthorized", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsLocationAuthorized (global::Android.Content.Context context)
		{
			if (id_isLocationAuthorized_Landroid_content_Context_ == IntPtr.Zero)
				id_isLocationAuthorized_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isLocationAuthorized", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isLocationAuthorized_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isNetworkReachable_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/method[@name='isNetworkReachable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isNetworkReachable", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsNetworkReachable (global::Android.Content.Context context)
		{
			if (id_isNetworkReachable_Landroid_content_Context_ == IntPtr.Zero)
				id_isNetworkReachable_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isNetworkReachable", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNetworkReachable_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_onBLEScanResult_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/method[@name='onBLEScanResult' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("onBLEScanResult", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V", "")]
		public static unsafe void OnBLEScanResult (string deviceName, string address, int rssi, string hex)
		{
			if (id_onBLEScanResult_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ == IntPtr.Zero)
				id_onBLEScanResult_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "onBLEScanResult", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)V");
			IntPtr native_deviceName = JNIEnv.NewString (deviceName);
			IntPtr native_address = JNIEnv.NewString (address);
			IntPtr native_hex = JNIEnv.NewString (hex);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_deviceName);
				__args [1] = new JValue (native_address);
				__args [2] = new JValue (rssi);
				__args [3] = new JValue (native_hex);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onBLEScanResult_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_deviceName);
				JNIEnv.DeleteLocalRef (native_address);
				JNIEnv.DeleteLocalRef (native_hex);
			}
		}

		static IntPtr id_setAppToken_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/method[@name='setAppToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAppToken", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetAppToken (string appToken)
		{
			if (id_setAppToken_Ljava_lang_String_ == IntPtr.Zero)
				id_setAppToken_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setAppToken", "(Ljava/lang/String;)V");
			IntPtr native_appToken = JNIEnv.NewString (appToken);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_appToken);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setAppToken_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_appToken);
			}
		}

		static IntPtr id_setCredentialsWithUserName_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/method[@name='setCredentialsWithUserName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setCredentialsWithUserName", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SetCredentialsWithUserName (string userName, string password)
		{
			if (id_setCredentialsWithUserName_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setCredentialsWithUserName_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setCredentialsWithUserName", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_userName = JNIEnv.NewString (userName);
			IntPtr native_password = JNIEnv.NewString (password);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_userName);
				__args [1] = new JValue (native_password);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setCredentialsWithUserName_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_userName);
				JNIEnv.DeleteLocalRef (native_password);
			}
		}

		static IntPtr id_setDeviceIdentifier_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/method[@name='setDeviceIdentifier' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("setDeviceIdentifier", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void SetDeviceIdentifier (global::Android.Content.Context context, string userDefinedIdentifier)
		{
			if (id_setDeviceIdentifier_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_setDeviceIdentifier_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setDeviceIdentifier", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_userDefinedIdentifier = JNIEnv.NewString (userDefinedIdentifier);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_userDefinedIdentifier);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setDeviceIdentifier_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_userDefinedIdentifier);
			}
		}

		static IntPtr id_setOptions_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/method[@name='setOptions' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setOptions", "(Ljava/util/Map;)V", "")]
		public static unsafe void SetOptions (global::System.Collections.Generic.IDictionary<string, string> options)
		{
			if (id_setOptions_Ljava_util_Map_ == IntPtr.Zero)
				id_setOptions_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "setOptions", "(Ljava/util/Map;)V");
			IntPtr native_options = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (options);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_options);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setOptions_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_options);
			}
		}

		static IntPtr id_startPurring_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/method[@name='startPurring' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("startPurring", "(Landroid/content/Context;)V", "")]
		public static unsafe void StartPurring (global::Android.Content.Context context)
		{
			if (id_startPurring_Landroid_content_Context_ == IntPtr.Zero)
				id_startPurring_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "startPurring", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_startPurring_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_startPurringWithAppToken_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/method[@name='startPurringWithAppToken' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("startPurringWithAppToken", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public static unsafe void StartPurringWithAppToken (global::Android.Content.Context context, string appToken)
		{
			if (id_startPurringWithAppToken_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_startPurringWithAppToken_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "startPurringWithAppToken", "(Landroid/content/Context;Ljava/lang/String;)V");
			IntPtr native_appToken = JNIEnv.NewString (appToken);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_appToken);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_startPurringWithAppToken_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_appToken);
			}
		}

		static IntPtr id_stopPurring;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDK']/method[@name='stopPurring' and count(parameter)=0]"
		[Register ("stopPurring", "()V", "")]
		public static unsafe void StopPurring ()
		{
			if (id_stopPurring == IntPtr.Zero)
				id_stopPurring = JNIEnv.GetStaticMethodID (class_ref, "stopPurring", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_stopPurring);
			} finally {
			}
		}

	}
}
