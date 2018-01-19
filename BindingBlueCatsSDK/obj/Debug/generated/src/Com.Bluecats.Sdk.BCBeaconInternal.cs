using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCBeaconInternal", DoNotGenerateAcw=true)]
	public sealed partial class BCBeaconInternal : global::Com.Bluecats.Sdk.BCBeaconUpdates, global::Android.OS.IParcelable, global::Com.Bluecats.Sdk.IBCBeacon {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: com.bluecats.sdk.BCBeacon

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/field[@name='BC_SETTINGS_UPDATE_AUTH_KEY_KEY']"
			[Register ("BC_SETTINGS_UPDATE_AUTH_KEY_KEY")]
			public const string BcSettingsUpdateAuthKeyKey = (string) "BC_SETTINGS_UPDATE_AUTH_KEY_KEY";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/field[@name='BC_SETTINGS_UPDATE_BEACON_MODE_ID_KEY']"
			[Register ("BC_SETTINGS_UPDATE_BEACON_MODE_ID_KEY")]
			public const string BcSettingsUpdateBeaconModeIdKey = (string) "BC_SETTINGS_UPDATE_BEACON_MODE_ID_KEY";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/field[@name='BC_SETTINGS_UPDATE_BLUETOOTH_ADDRESS_KEY']"
			[Register ("BC_SETTINGS_UPDATE_BLUETOOTH_ADDRESS_KEY")]
			public const string BcSettingsUpdateBluetoothAddressKey = (string) "BC_SETTINGS_UPDATE_BLUETOOTH_ADDRESS_KEY";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/field[@name='BC_SETTINGS_UPDATE_CURRENT_PASSCODE_KEY']"
			[Register ("BC_SETTINGS_UPDATE_CURRENT_PASSCODE_KEY")]
			public const string BcSettingsUpdateCurrentPasscodeKey = (string) "BC_SETTINGS_UPDATE_CURRENT_PASSCODE_KEY";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/field[@name='BC_SETTINGS_UPDATE_EDDYSTONE_INSTANCE_ID_KEY']"
			[Register ("BC_SETTINGS_UPDATE_EDDYSTONE_INSTANCE_ID_KEY")]
			public const string BcSettingsUpdateEddystoneInstanceIdKey = (string) "BC_SETTINGS_UPDATE_EDDYSTONE_INSTANCE_ID_KEY";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/field[@name='BC_SETTINGS_UPDATE_EDDYSTONE_NAMESPACE_ID_KEY']"
			[Register ("BC_SETTINGS_UPDATE_EDDYSTONE_NAMESPACE_ID_KEY")]
			public const string BcSettingsUpdateEddystoneNamespaceIdKey = (string) "BC_SETTINGS_UPDATE_EDDYSTONE_NAMESPACE_ID_KEY";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/field[@name='BC_SETTINGS_UPDATE_EDDYSTONE_URL_KEY']"
			[Register ("BC_SETTINGS_UPDATE_EDDYSTONE_URL_KEY")]
			public const string BcSettingsUpdateEddystoneUrlKey = (string) "BC_SETTINGS_UPDATE_EDDYSTONE_URL_KEY";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/field[@name='BC_SETTINGS_UPDATE_LOCAL_NAME_SHORT_KEY']"
			[Register ("BC_SETTINGS_UPDATE_LOCAL_NAME_SHORT_KEY")]
			public const string BcSettingsUpdateLocalNameShortKey = (string) "BC_SETTINGS_UPDATE_LOCAL_NAME_SHORT_KEY";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/field[@name='BC_SETTINGS_UPDATE_LOUDNESS_LEVEL_KEY']"
			[Register ("BC_SETTINGS_UPDATE_LOUDNESS_LEVEL_KEY")]
			public const string BcSettingsUpdateLoudnessLevelKey = (string) "BC_SETTINGS_UPDATE_LOUDNESS_LEVEL_KEY";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/field[@name='BC_SETTINGS_UPDATE_MAJOR_KEY']"
			[Register ("BC_SETTINGS_UPDATE_MAJOR_KEY")]
			public const string BcSettingsUpdateMajorKey = (string) "BC_SETTINGS_UPDATE_MAJOR_KEY";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/field[@name='BC_SETTINGS_UPDATE_MEASURED_POWER_KEY']"
			[Register ("BC_SETTINGS_UPDATE_MEASURED_POWER_KEY")]
			public const string BcSettingsUpdateMeasuredPowerKey = (string) "BC_SETTINGS_UPDATE_MEASURED_POWER_KEY";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/field[@name='BC_SETTINGS_UPDATE_MINOR_KEY']"
			[Register ("BC_SETTINGS_UPDATE_MINOR_KEY")]
			public const string BcSettingsUpdateMinorKey = (string) "BC_SETTINGS_UPDATE_MINOR_KEY";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/field[@name='BC_SETTINGS_UPDATE_NEW_PASSCODE_KEY']"
			[Register ("BC_SETTINGS_UPDATE_NEW_PASSCODE_KEY")]
			public const string BcSettingsUpdateNewPasscodeKey = (string) "BC_SETTINGS_UPDATE_NEW_PASSCODE_KEY";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/field[@name='BC_SETTINGS_UPDATE_PRIVACY_DURATION_KEY']"
			[Register ("BC_SETTINGS_UPDATE_PRIVACY_DURATION_KEY")]
			public const string BcSettingsUpdatePrivacyDurationKey = (string) "BC_SETTINGS_UPDATE_PRIVACY_DURATION_KEY";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/field[@name='BC_SETTINGS_UPDATE_PROXIMITY_UUID_STRING_KEY']"
			[Register ("BC_SETTINGS_UPDATE_PROXIMITY_UUID_STRING_KEY")]
			public const string BcSettingsUpdateProximityUuidStringKey = (string) "BC_SETTINGS_UPDATE_PROXIMITY_UUID_STRING_KEY";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/field[@name='BC_SETTINGS_UPDATE_REGION_ID_KEY']"
			[Register ("BC_SETTINGS_UPDATE_REGION_ID_KEY")]
			public const string BcSettingsUpdateRegionIdKey = (string) "BC_SETTINGS_UPDATE_REGION_ID_KEY";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/field[@name='BC_SETTINGS_UPDATE_SECURITY_TYPE_KEY']"
			[Register ("BC_SETTINGS_UPDATE_SECURITY_TYPE_KEY")]
			public const string BcSettingsUpdateSecurityTypeKey = (string) "BC_SETTINGS_UPDATE_SECURITY_TYPE_KEY";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/field[@name='BC_SETTINGS_UPDATE_TARGET_SPEED_IN_MILLISECONDS_KEY']"
			[Register ("BC_SETTINGS_UPDATE_TARGET_SPEED_IN_MILLISECONDS_KEY")]
			public const string BcSettingsUpdateTargetSpeedInMillisecondsKey = (string) "BC_SETTINGS_UPDATE_TARGET_SPEED_IN_MILLISECONDS_KEY";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/field[@name='BC_SETTINGS_UPDATE_VERSION_KEY']"
			[Register ("BC_SETTINGS_UPDATE_VERSION_KEY")]
			public const string BcSettingsUpdateVersionKey = (string) "BC_SETTINGS_UPDATE_VERSION_KEY";
		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCBeaconInternal", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCBeaconInternal); }
		}

		internal BCBeaconInternal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/constructor[@name='BCBeaconInternal' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCBeaconInternal ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCBeaconInternal)) {
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

		static IntPtr id_getAccuracy;
		static IntPtr id_setAccuracy_Ljava_lang_Double_;
		public unsafe global::Java.Lang.Double Accuracy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getAccuracy' and count(parameter)=0]"
			[Register ("getAccuracy", "()Ljava/lang/Double;", "GetGetAccuracyHandler")]
			get {
				if (id_getAccuracy == IntPtr.Zero)
					id_getAccuracy = JNIEnv.GetMethodID (class_ref, "getAccuracy", "()Ljava/lang/Double;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccuracy), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setAccuracy' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setAccuracy", "(Ljava/lang/Double;)V", "GetSetAccuracy_Ljava_lang_Double_Handler")]
			set {
				if (id_setAccuracy_Ljava_lang_Double_ == IntPtr.Zero)
					id_setAccuracy_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setAccuracy", "(Ljava/lang/Double;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAccuracy_Ljava_lang_Double_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getBatteryStatus;
		static IntPtr id_setBatteryStatus_Lcom_bluecats_sdk_BCBatteryStatus_;
		public unsafe global::Com.Bluecats.Sdk.BCBatteryStatus BatteryStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getBatteryStatus' and count(parameter)=0]"
			[Register ("getBatteryStatus", "()Lcom/bluecats/sdk/BCBatteryStatus;", "GetGetBatteryStatusHandler")]
			get {
				if (id_getBatteryStatus == IntPtr.Zero)
					id_getBatteryStatus = JNIEnv.GetMethodID (class_ref, "getBatteryStatus", "()Lcom/bluecats/sdk/BCBatteryStatus;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBatteryStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBatteryStatus), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setBatteryStatus' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBatteryStatus']]"
			[Register ("setBatteryStatus", "(Lcom/bluecats/sdk/BCBatteryStatus;)V", "GetSetBatteryStatus_Lcom_bluecats_sdk_BCBatteryStatus_Handler")]
			set {
				if (id_setBatteryStatus_Lcom_bluecats_sdk_BCBatteryStatus_ == IntPtr.Zero)
					id_setBatteryStatus_Lcom_bluecats_sdk_BCBatteryStatus_ = JNIEnv.GetMethodID (class_ref, "setBatteryStatus", "(Lcom/bluecats/sdk/BCBatteryStatus;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBatteryStatus_Lcom_bluecats_sdk_BCBatteryStatus_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getBeaconMode;
		static IntPtr id_setBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_;
		public unsafe global::Com.Bluecats.Sdk.BCBeaconMode BeaconMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getBeaconMode' and count(parameter)=0]"
			[Register ("getBeaconMode", "()Lcom/bluecats/sdk/BCBeaconMode;", "GetGetBeaconModeHandler")]
			get {
				if (id_getBeaconMode == IntPtr.Zero)
					id_getBeaconMode = JNIEnv.GetMethodID (class_ref, "getBeaconMode", "()Lcom/bluecats/sdk/BCBeaconMode;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconMode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconMode), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setBeaconMode' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconMode']]"
			[Register ("setBeaconMode", "(Lcom/bluecats/sdk/BCBeaconMode;)V", "GetSetBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_Handler")]
			set {
				if (id_setBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_ == IntPtr.Zero)
					id_setBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_ = JNIEnv.GetMethodID (class_ref, "setBeaconMode", "(Lcom/bluecats/sdk/BCBeaconMode;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getBeaconModeFromBlueCatsAdData;
		public unsafe global::Com.Bluecats.Sdk.BCBeaconMode BeaconModeFromBlueCatsAdData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getBeaconModeFromBlueCatsAdData' and count(parameter)=0]"
			[Register ("getBeaconModeFromBlueCatsAdData", "()Lcom/bluecats/sdk/BCBeaconMode;", "GetGetBeaconModeFromBlueCatsAdDataHandler")]
			get {
				if (id_getBeaconModeFromBlueCatsAdData == IntPtr.Zero)
					id_getBeaconModeFromBlueCatsAdData = JNIEnv.GetMethodID (class_ref, "getBeaconModeFromBlueCatsAdData", "()Lcom/bluecats/sdk/BCBeaconMode;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconMode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconModeFromBlueCatsAdData), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getBeaconRegion;
		static IntPtr id_setBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_;
		public unsafe global::Com.Bluecats.Sdk.BCBeaconRegion BeaconRegion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getBeaconRegion' and count(parameter)=0]"
			[Register ("getBeaconRegion", "()Lcom/bluecats/sdk/BCBeaconRegion;", "GetGetBeaconRegionHandler")]
			get {
				if (id_getBeaconRegion == IntPtr.Zero)
					id_getBeaconRegion = JNIEnv.GetMethodID (class_ref, "getBeaconRegion", "()Lcom/bluecats/sdk/BCBeaconRegion;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconRegion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setBeaconRegion' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconRegion']]"
			[Register ("setBeaconRegion", "(Lcom/bluecats/sdk/BCBeaconRegion;)V", "GetSetBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_Handler")]
			set {
				if (id_setBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_ == IntPtr.Zero)
					id_setBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_ = JNIEnv.GetMethodID (class_ref, "setBeaconRegion", "(Lcom/bluecats/sdk/BCBeaconRegion;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getBluetoothAddress;
		static IntPtr id_setBluetoothAddress_Ljava_lang_String_;
		public unsafe string BluetoothAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getBluetoothAddress' and count(parameter)=0]"
			[Register ("getBluetoothAddress", "()Ljava/lang/String;", "GetGetBluetoothAddressHandler")]
			get {
				if (id_getBluetoothAddress == IntPtr.Zero)
					id_getBluetoothAddress = JNIEnv.GetMethodID (class_ref, "getBluetoothAddress", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBluetoothAddress), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setBluetoothAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBluetoothAddress", "(Ljava/lang/String;)V", "GetSetBluetoothAddress_Ljava_lang_String_Handler")]
			set {
				if (id_setBluetoothAddress_Ljava_lang_String_ == IntPtr.Zero)
					id_setBluetoothAddress_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBluetoothAddress", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBluetoothAddress_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getCacheIdentifier;
		static IntPtr id_setCacheIdentifier_Ljava_lang_String_;
		public unsafe string CacheIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getCacheIdentifier' and count(parameter)=0]"
			[Register ("getCacheIdentifier", "()Ljava/lang/String;", "GetGetCacheIdentifierHandler")]
			get {
				if (id_getCacheIdentifier == IntPtr.Zero)
					id_getCacheIdentifier = JNIEnv.GetMethodID (class_ref, "getCacheIdentifier", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCacheIdentifier), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setCacheIdentifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCacheIdentifier", "(Ljava/lang/String;)V", "GetSetCacheIdentifier_Ljava_lang_String_Handler")]
			set {
				if (id_setCacheIdentifier_Ljava_lang_String_ == IntPtr.Zero)
					id_setCacheIdentifier_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCacheIdentifier", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCacheIdentifier_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getCachedAt;
		static IntPtr id_setCachedAt_Ljava_util_Date_;
		public unsafe global::Java.Util.Date CachedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getCachedAt' and count(parameter)=0]"
			[Register ("getCachedAt", "()Ljava/util/Date;", "GetGetCachedAtHandler")]
			get {
				if (id_getCachedAt == IntPtr.Zero)
					id_getCachedAt = JNIEnv.GetMethodID (class_ref, "getCachedAt", "()Ljava/util/Date;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedAt), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setCachedAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setCachedAt", "(Ljava/util/Date;)V", "GetSetCachedAt_Ljava_util_Date_Handler")]
			set {
				if (id_setCachedAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setCachedAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setCachedAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCachedAt_Ljava_util_Date_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getCreatedAt;
		static IntPtr id_setCreatedAt_Ljava_util_Date_;
		public unsafe global::Java.Util.Date CreatedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getCreatedAt' and count(parameter)=0]"
			[Register ("getCreatedAt", "()Ljava/util/Date;", "GetGetCreatedAtHandler")]
			get {
				if (id_getCreatedAt == IntPtr.Zero)
					id_getCreatedAt = JNIEnv.GetMethodID (class_ref, "getCreatedAt", "()Ljava/util/Date;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCreatedAt), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setCreatedAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setCreatedAt", "(Ljava/util/Date;)V", "GetSetCreatedAt_Ljava_util_Date_Handler")]
			set {
				if (id_setCreatedAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setCreatedAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setCreatedAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCreatedAt_Ljava_util_Date_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getEddystone;
		static IntPtr id_setEddystone_Lcom_bluecats_sdk_BCEddystone_;
		public unsafe global::Com.Bluecats.Sdk.BCEddystone Eddystone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getEddystone' and count(parameter)=0]"
			[Register ("getEddystone", "()Lcom/bluecats/sdk/BCEddystone;", "GetGetEddystoneHandler")]
			get {
				if (id_getEddystone == IntPtr.Zero)
					id_getEddystone = JNIEnv.GetMethodID (class_ref, "getEddystone", "()Lcom/bluecats/sdk/BCEddystone;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEddystone> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEddystone), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setEddystone' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCEddystone']]"
			[Register ("setEddystone", "(Lcom/bluecats/sdk/BCEddystone;)V", "GetSetEddystone_Lcom_bluecats_sdk_BCEddystone_Handler")]
			set {
				if (id_setEddystone_Lcom_bluecats_sdk_BCEddystone_ == IntPtr.Zero)
					id_setEddystone_Lcom_bluecats_sdk_BCEddystone_ = JNIEnv.GetMethodID (class_ref, "setEddystone", "(Lcom/bluecats/sdk/BCEddystone;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEddystone_Lcom_bluecats_sdk_BCEddystone_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getFeatureBitMask;
		static IntPtr id_setFeatureBitMask_Ljava_lang_Integer_;
		public unsafe global::Java.Lang.Integer FeatureBitMask {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getFeatureBitMask' and count(parameter)=0]"
			[Register ("getFeatureBitMask", "()Ljava/lang/Integer;", "GetGetFeatureBitMaskHandler")]
			get {
				if (id_getFeatureBitMask == IntPtr.Zero)
					id_getFeatureBitMask = JNIEnv.GetMethodID (class_ref, "getFeatureBitMask", "()Ljava/lang/Integer;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFeatureBitMask), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setFeatureBitMask' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setFeatureBitMask", "(Ljava/lang/Integer;)V", "GetSetFeatureBitMask_Ljava_lang_Integer_Handler")]
			set {
				if (id_setFeatureBitMask_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setFeatureBitMask_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setFeatureBitMask", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFeatureBitMask_Ljava_lang_Integer_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getFirstRangedAt;
		static IntPtr id_setFirstRangedAt_Ljava_util_Date_;
		public unsafe global::Java.Util.Date FirstRangedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getFirstRangedAt' and count(parameter)=0]"
			[Register ("getFirstRangedAt", "()Ljava/util/Date;", "GetGetFirstRangedAtHandler")]
			get {
				if (id_getFirstRangedAt == IntPtr.Zero)
					id_getFirstRangedAt = JNIEnv.GetMethodID (class_ref, "getFirstRangedAt", "()Ljava/util/Date;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFirstRangedAt), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setFirstRangedAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setFirstRangedAt", "(Ljava/util/Date;)V", "GetSetFirstRangedAt_Ljava_util_Date_Handler")]
			set {
				if (id_setFirstRangedAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setFirstRangedAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setFirstRangedAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFirstRangedAt_Ljava_util_Date_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getIBeaconKey;
		public unsafe string IBeaconKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getIBeaconKey' and count(parameter)=0]"
			[Register ("getIBeaconKey", "()Ljava/lang/String;", "GetGetIBeaconKeyHandler")]
			get {
				if (id_getIBeaconKey == IntPtr.Zero)
					id_getIBeaconKey = JNIEnv.GetMethodID (class_ref, "getIBeaconKey", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIBeaconKey), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isSynced;
		public unsafe bool IsSynced {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='isSynced' and count(parameter)=0]"
			[Register ("isSynced", "()Z", "GetIsSyncedHandler")]
			get {
				if (id_isSynced == IntPtr.Zero)
					id_isSynced = JNIEnv.GetMethodID (class_ref, "isSynced", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSynced);
				} finally {
				}
			}
		}

		static IntPtr id_isSyncedOrRestored;
		public unsafe bool IsSyncedOrRestored {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='isSyncedOrRestored' and count(parameter)=0]"
			[Register ("isSyncedOrRestored", "()Z", "GetIsSyncedOrRestoredHandler")]
			get {
				if (id_isSyncedOrRestored == IntPtr.Zero)
					id_isSyncedOrRestored = JNIEnv.GetMethodID (class_ref, "isSyncedOrRestored", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSyncedOrRestored);
				} finally {
				}
			}
		}

		static IntPtr id_getLastRangedAt;
		static IntPtr id_setLastRangedAt_Ljava_util_Date_;
		public unsafe global::Java.Util.Date LastRangedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getLastRangedAt' and count(parameter)=0]"
			[Register ("getLastRangedAt", "()Ljava/util/Date;", "GetGetLastRangedAtHandler")]
			get {
				if (id_getLastRangedAt == IntPtr.Zero)
					id_getLastRangedAt = JNIEnv.GetMethodID (class_ref, "getLastRangedAt", "()Ljava/util/Date;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastRangedAt), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setLastRangedAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setLastRangedAt", "(Ljava/util/Date;)V", "GetSetLastRangedAt_Ljava_util_Date_Handler")]
			set {
				if (id_setLastRangedAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setLastRangedAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setLastRangedAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastRangedAt_Ljava_util_Date_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getMapPoint;
		static IntPtr id_setMapPoint_Lcom_bluecats_sdk_BCMapPoint_;
		public unsafe global::Com.Bluecats.Sdk.BCMapPoint MapPoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getMapPoint' and count(parameter)=0]"
			[Register ("getMapPoint", "()Lcom/bluecats/sdk/BCMapPoint;", "GetGetMapPointHandler")]
			get {
				if (id_getMapPoint == IntPtr.Zero)
					id_getMapPoint = JNIEnv.GetMethodID (class_ref, "getMapPoint", "()Lcom/bluecats/sdk/BCMapPoint;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMapPoint> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMapPoint), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setMapPoint' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCMapPoint']]"
			[Register ("setMapPoint", "(Lcom/bluecats/sdk/BCMapPoint;)V", "GetSetMapPoint_Lcom_bluecats_sdk_BCMapPoint_Handler")]
			set {
				if (id_setMapPoint_Lcom_bluecats_sdk_BCMapPoint_ == IntPtr.Zero)
					id_setMapPoint_Lcom_bluecats_sdk_BCMapPoint_ = JNIEnv.GetMethodID (class_ref, "setMapPoint", "(Lcom/bluecats/sdk/BCMapPoint;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMapPoint_Lcom_bluecats_sdk_BCMapPoint_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getMeasuredPowerAt1Meter;
		static IntPtr id_setMeasuredPowerAt1Meter_Ljava_lang_Integer_;
		public unsafe global::Java.Lang.Integer MeasuredPowerAt1Meter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getMeasuredPowerAt1Meter' and count(parameter)=0]"
			[Register ("getMeasuredPowerAt1Meter", "()Ljava/lang/Integer;", "GetGetMeasuredPowerAt1MeterHandler")]
			get {
				if (id_getMeasuredPowerAt1Meter == IntPtr.Zero)
					id_getMeasuredPowerAt1Meter = JNIEnv.GetMethodID (class_ref, "getMeasuredPowerAt1Meter", "()Ljava/lang/Integer;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMeasuredPowerAt1Meter), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setMeasuredPowerAt1Meter' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setMeasuredPowerAt1Meter", "(Ljava/lang/Integer;)V", "GetSetMeasuredPowerAt1Meter_Ljava_lang_Integer_Handler")]
			set {
				if (id_setMeasuredPowerAt1Meter_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setMeasuredPowerAt1Meter_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setMeasuredPowerAt1Meter", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMeasuredPowerAt1Meter_Ljava_lang_Integer_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getMessage;
		static IntPtr id_setMessage_Ljava_lang_String_;
		public unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMessage", "(Ljava/lang/String;)V", "GetSetMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessage_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getModifiedAt;
		static IntPtr id_setModifiedAt_Ljava_util_Date_;
		public unsafe global::Java.Util.Date ModifiedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getModifiedAt' and count(parameter)=0]"
			[Register ("getModifiedAt", "()Ljava/util/Date;", "GetGetModifiedAtHandler")]
			get {
				if (id_getModifiedAt == IntPtr.Zero)
					id_getModifiedAt = JNIEnv.GetMethodID (class_ref, "getModifiedAt", "()Ljava/util/Date;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getModifiedAt), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setModifiedAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setModifiedAt", "(Ljava/util/Date;)V", "GetSetModifiedAt_Ljava_util_Date_Handler")]
			set {
				if (id_setModifiedAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setModifiedAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setModifiedAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setModifiedAt_Ljava_util_Date_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getName;
		static IntPtr id_setName_Ljava_lang_String_;
		public unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
					id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setName_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getNetworkAccess;
		static IntPtr id_setNetworkAccess_Lcom_bluecats_sdk_BCNetworkAccess_;
		public unsafe global::Com.Bluecats.Sdk.BCNetworkAccess NetworkAccess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getNetworkAccess' and count(parameter)=0]"
			[Register ("getNetworkAccess", "()Lcom/bluecats/sdk/BCNetworkAccess;", "GetGetNetworkAccessHandler")]
			get {
				if (id_getNetworkAccess == IntPtr.Zero)
					id_getNetworkAccess = JNIEnv.GetMethodID (class_ref, "getNetworkAccess", "()Lcom/bluecats/sdk/BCNetworkAccess;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCNetworkAccess> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNetworkAccess), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setNetworkAccess' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCNetworkAccess']]"
			[Register ("setNetworkAccess", "(Lcom/bluecats/sdk/BCNetworkAccess;)V", "GetSetNetworkAccess_Lcom_bluecats_sdk_BCNetworkAccess_Handler")]
			set {
				if (id_setNetworkAccess_Lcom_bluecats_sdk_BCNetworkAccess_ == IntPtr.Zero)
					id_setNetworkAccess_Lcom_bluecats_sdk_BCNetworkAccess_ = JNIEnv.GetMethodID (class_ref, "setNetworkAccess", "(Lcom/bluecats/sdk/BCNetworkAccess;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNetworkAccess_Lcom_bluecats_sdk_BCNetworkAccess_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getProximity;
		static IntPtr id_setProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_;
		public unsafe global::Com.Bluecats.Sdk.BCBeaconBCProximity Proximity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getProximity' and count(parameter)=0]"
			[Register ("getProximity", "()Lcom/bluecats/sdk/BCBeacon$BCProximity;", "GetGetProximityHandler")]
			get {
				if (id_getProximity == IntPtr.Zero)
					id_getProximity = JNIEnv.GetMethodID (class_ref, "getProximity", "()Lcom/bluecats/sdk/BCBeacon$BCProximity;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCProximity> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProximity), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setProximity' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeacon.BCProximity']]"
			[Register ("setProximity", "(Lcom/bluecats/sdk/BCBeacon$BCProximity;)V", "GetSetProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_Handler")]
			set {
				if (id_setProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ == IntPtr.Zero)
					id_setProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ = JNIEnv.GetMethodID (class_ref, "setProximity", "(Lcom/bluecats/sdk/BCBeacon$BCProximity;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getRSSI;
		static IntPtr id_setRSSI_Ljava_lang_Integer_;
		public unsafe global::Java.Lang.Integer RSSI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getRSSI' and count(parameter)=0]"
			[Register ("getRSSI", "()Ljava/lang/Integer;", "GetGetRSSIHandler")]
			get {
				if (id_getRSSI == IntPtr.Zero)
					id_getRSSI = JNIEnv.GetMethodID (class_ref, "getRSSI", "()Ljava/lang/Integer;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRSSI), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setRSSI' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setRSSI", "(Ljava/lang/Integer;)V", "GetSetRSSI_Ljava_lang_Integer_Handler")]
			set {
				if (id_setRSSI_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setRSSI_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setRSSI", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRSSI_Ljava_lang_Integer_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getSerialNumber;
		static IntPtr id_setSerialNumber_Ljava_lang_String_;
		public unsafe string SerialNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getSerialNumber' and count(parameter)=0]"
			[Register ("getSerialNumber", "()Ljava/lang/String;", "GetGetSerialNumberHandler")]
			get {
				if (id_getSerialNumber == IntPtr.Zero)
					id_getSerialNumber = JNIEnv.GetMethodID (class_ref, "getSerialNumber", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSerialNumber), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setSerialNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSerialNumber", "(Ljava/lang/String;)V", "GetSetSerialNumber_Ljava_lang_String_Handler")]
			set {
				if (id_setSerialNumber_Ljava_lang_String_ == IntPtr.Zero)
					id_setSerialNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSerialNumber", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSerialNumber_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getSyncedAt;
		static IntPtr id_setSyncedAt_Ljava_util_Date_;
		public unsafe global::Java.Util.Date SyncedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getSyncedAt' and count(parameter)=0]"
			[Register ("getSyncedAt", "()Ljava/util/Date;", "GetGetSyncedAtHandler")]
			get {
				if (id_getSyncedAt == IntPtr.Zero)
					id_getSyncedAt = JNIEnv.GetMethodID (class_ref, "getSyncedAt", "()Ljava/util/Date;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSyncedAt), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setSyncedAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setSyncedAt", "(Ljava/util/Date;)V", "GetSetSyncedAt_Ljava_util_Date_Handler")]
			set {
				if (id_setSyncedAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setSyncedAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setSyncedAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSyncedAt_Ljava_util_Date_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getUptime;
		static IntPtr id_setUptime_Ljava_lang_String_;
		public unsafe string Uptime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getUptime' and count(parameter)=0]"
			[Register ("getUptime", "()Ljava/lang/String;", "GetGetUptimeHandler")]
			get {
				if (id_getUptime == IntPtr.Zero)
					id_getUptime = JNIEnv.GetMethodID (class_ref, "getUptime", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUptime), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setUptime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUptime", "(Ljava/lang/String;)V", "GetSetUptime_Ljava_lang_String_Handler")]
			set {
				if (id_setUptime_Ljava_lang_String_ == IntPtr.Zero)
					id_setUptime_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUptime", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUptime_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getWireframeURLString;
		static IntPtr id_setWireframeURLString_Ljava_lang_String_;
		public unsafe string WireframeURLString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getWireframeURLString' and count(parameter)=0]"
			[Register ("getWireframeURLString", "()Ljava/lang/String;", "GetGetWireframeURLStringHandler")]
			get {
				if (id_getWireframeURLString == IntPtr.Zero)
					id_getWireframeURLString = JNIEnv.GetMethodID (class_ref, "getWireframeURLString", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWireframeURLString), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setWireframeURLString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setWireframeURLString", "(Ljava/lang/String;)V", "GetSetWireframeURLString_Ljava_lang_String_Handler")]
			set {
				if (id_setWireframeURLString_Ljava_lang_String_ == IntPtr.Zero)
					id_setWireframeURLString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setWireframeURLString", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWireframeURLString_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_copy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='copy' and count(parameter)=0]"
		[Register ("copy", "()Ljava/lang/Object;", "")]
		public unsafe global::Com.Bluecats.Sdk.IBCBeacon Copy ()
		{
			if (id_copy == IntPtr.Zero)
				id_copy = JNIEnv.GetMethodID (class_ref, "copy", "()Ljava/lang/Object;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_copy), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_copyApiPropertiesFromBeacon_Lcom_bluecats_sdk_BCBeacon_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='copyApiPropertiesFromBeacon' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeacon']]"
		[Register ("copyApiPropertiesFromBeacon", "(Lcom/bluecats/sdk/BCBeacon;)V", "")]
		public unsafe void CopyApiPropertiesFromBeacon (global::Com.Bluecats.Sdk.IBCBeacon beacon2)
		{
			if (id_copyApiPropertiesFromBeacon_Lcom_bluecats_sdk_BCBeacon_ == IntPtr.Zero)
				id_copyApiPropertiesFromBeacon_Lcom_bluecats_sdk_BCBeacon_ = JNIEnv.GetMethodID (class_ref, "copyApiPropertiesFromBeacon", "(Lcom/bluecats/sdk/BCBeacon;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (beacon2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_copyApiPropertiesFromBeacon_Lcom_bluecats_sdk_BCBeacon_, __args);
			} finally {
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
			} finally {
			}
		}

		static IntPtr id_getProximityFromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='getProximityFromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getProximityFromString", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCBeacon$BCProximity;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCBeaconBCProximity GetProximityFromString (string value)
		{
			if (id_getProximityFromString_Ljava_lang_String_ == IntPtr.Zero)
				id_getProximityFromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getProximityFromString", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCBeacon$BCProximity;");
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				global::Com.Bluecats.Sdk.BCBeaconBCProximity __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCProximity> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getProximityFromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr id_requestDataArrayFromBeaconEndpoint_Lcom_bluecats_sdk_BCBeaconUpdates_BCBeaconEndpoint_Ljava_util_List_Lcom_bluecats_sdk_BCBeaconCommandCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='requestDataArrayFromBeaconEndpoint' and count(parameter)=3 and parameter[1][@type='com.bluecats.sdk.BCBeaconUpdates.BCBeaconEndpoint'] and parameter[2][@type='java.util.List&lt;java.nio.ByteBuffer&gt;'] and parameter[3][@type='com.bluecats.sdk.BCBeaconCommandCallback']]"
		[Register ("requestDataArrayFromBeaconEndpoint", "(Lcom/bluecats/sdk/BCBeaconUpdates$BCBeaconEndpoint;Ljava/util/List;Lcom/bluecats/sdk/BCBeaconCommandCallback;)V", "")]
		public unsafe void RequestDataArrayFromBeaconEndpoint (global::Com.Bluecats.Sdk.BCBeaconUpdates.BCBeaconEndpoint beaconEndpoint, global::System.Collections.Generic.IList<global::Java.Nio.ByteBuffer> reqDatas, global::Com.Bluecats.Sdk.IBCBeaconCommandCallback cb)
		{
			if (id_requestDataArrayFromBeaconEndpoint_Lcom_bluecats_sdk_BCBeaconUpdates_BCBeaconEndpoint_Ljava_util_List_Lcom_bluecats_sdk_BCBeaconCommandCallback_ == IntPtr.Zero)
				id_requestDataArrayFromBeaconEndpoint_Lcom_bluecats_sdk_BCBeaconUpdates_BCBeaconEndpoint_Ljava_util_List_Lcom_bluecats_sdk_BCBeaconCommandCallback_ = JNIEnv.GetMethodID (class_ref, "requestDataArrayFromBeaconEndpoint", "(Lcom/bluecats/sdk/BCBeaconUpdates$BCBeaconEndpoint;Ljava/util/List;Lcom/bluecats/sdk/BCBeaconCommandCallback;)V");
			IntPtr native_reqDatas = global::Android.Runtime.JavaList<global::Java.Nio.ByteBuffer>.ToLocalJniHandle (reqDatas);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (beaconEndpoint);
				__args [1] = new JValue (native_reqDatas);
				__args [2] = new JValue (cb);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestDataArrayFromBeaconEndpoint_Lcom_bluecats_sdk_BCBeaconUpdates_BCBeaconEndpoint_Ljava_util_List_Lcom_bluecats_sdk_BCBeaconCommandCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_reqDatas);
			}
		}

		static IntPtr id_requestDataForLasso_Ljava_util_List_Lcom_bluecats_sdk_BCBeaconCommandCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='requestDataForLasso' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.nio.ByteBuffer&gt;'] and parameter[2][@type='com.bluecats.sdk.BCBeaconCommandCallback']]"
		[Register ("requestDataForLasso", "(Ljava/util/List;Lcom/bluecats/sdk/BCBeaconCommandCallback;)V", "")]
		public unsafe void RequestDataForLasso (global::System.Collections.Generic.IList<global::Java.Nio.ByteBuffer> reqDatas, global::Com.Bluecats.Sdk.IBCBeaconCommandCallback cb)
		{
			if (id_requestDataForLasso_Ljava_util_List_Lcom_bluecats_sdk_BCBeaconCommandCallback_ == IntPtr.Zero)
				id_requestDataForLasso_Ljava_util_List_Lcom_bluecats_sdk_BCBeaconCommandCallback_ = JNIEnv.GetMethodID (class_ref, "requestDataForLasso", "(Ljava/util/List;Lcom/bluecats/sdk/BCBeaconCommandCallback;)V");
			IntPtr native_reqDatas = global::Android.Runtime.JavaList<global::Java.Nio.ByteBuffer>.ToLocalJniHandle (reqDatas);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_reqDatas);
				__args [1] = new JValue (cb);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestDataForLasso_Ljava_util_List_Lcom_bluecats_sdk_BCBeaconCommandCallback_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_reqDatas);
			}
		}

		static IntPtr id_setBluetoothAddressUpperCase;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='setBluetoothAddressUpperCase' and count(parameter)=0]"
		[Register ("setBluetoothAddressUpperCase", "()V", "")]
		public unsafe void SetBluetoothAddressUpperCase ()
		{
			if (id_setBluetoothAddressUpperCase == IntPtr.Zero)
				id_setBluetoothAddressUpperCase = JNIEnv.GetMethodID (class_ref, "setBluetoothAddressUpperCase", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBluetoothAddressUpperCase);
			} finally {
			}
		}

		static IntPtr id_updateBeacon_Lcom_bluecats_sdk_BCBeacon_Lcom_bluecats_sdk_BCBeaconCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='updateBeacon' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCBeacon'] and parameter[2][@type='com.bluecats.sdk.BCBeaconCallback']]"
		[Register ("updateBeacon", "(Lcom/bluecats/sdk/BCBeacon;Lcom/bluecats/sdk/BCBeaconCallback;)V", "")]
		public unsafe void UpdateBeacon (global::Com.Bluecats.Sdk.IBCBeacon beacon, global::Com.Bluecats.Sdk.IBCBeaconCallback @callback)
		{
			if (id_updateBeacon_Lcom_bluecats_sdk_BCBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ == IntPtr.Zero)
				id_updateBeacon_Lcom_bluecats_sdk_BCBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ = JNIEnv.GetMethodID (class_ref, "updateBeacon", "(Lcom/bluecats/sdk/BCBeacon;Lcom/bluecats/sdk/BCBeaconCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (beacon);
				__args [1] = new JValue (@callback);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateBeacon_Lcom_bluecats_sdk_BCBeacon_Lcom_bluecats_sdk_BCBeaconCallback_, __args);
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInternal']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dest);
				__args [1] = new JValue ((int) flags);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			} finally {
			}
		}

	}
}
