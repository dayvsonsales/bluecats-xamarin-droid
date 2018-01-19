using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCSiteInternal", DoNotGenerateAcw=true)]
	public sealed partial class BCSiteInternal : global::Com.Bluecats.Sdk.BCSiteApi, global::Android.OS.IParcelable, global::Com.Bluecats.Sdk.IBCSite {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCSiteInternal", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCSiteInternal); }
		}

		internal BCSiteInternal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/constructor[@name='BCSiteInternal' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCSiteInternal ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCSiteInternal)) {
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

		static IntPtr id_getAddress;
		static IntPtr id_setAddress_Lcom_bluecats_sdk_BCAddress_;
		public unsafe global::Com.Bluecats.Sdk.BCAddress Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='getAddress' and count(parameter)=0]"
			[Register ("getAddress", "()Lcom/bluecats/sdk/BCAddress;", "GetGetAddressHandler")]
			get {
				if (id_getAddress == IntPtr.Zero)
					id_getAddress = JNIEnv.GetMethodID (class_ref, "getAddress", "()Lcom/bluecats/sdk/BCAddress;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAddress), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='setAddress' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCAddress']]"
			[Register ("setAddress", "(Lcom/bluecats/sdk/BCAddress;)V", "GetSetAddress_Lcom_bluecats_sdk_BCAddress_Handler")]
			set {
				if (id_setAddress_Lcom_bluecats_sdk_BCAddress_ == IntPtr.Zero)
					id_setAddress_Lcom_bluecats_sdk_BCAddress_ = JNIEnv.GetMethodID (class_ref, "setAddress", "(Lcom/bluecats/sdk/BCAddress;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAddress_Lcom_bluecats_sdk_BCAddress_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getBeaconCount;
		static IntPtr id_setBeaconCount_I;
		public unsafe int BeaconCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='getBeaconCount' and count(parameter)=0]"
			[Register ("getBeaconCount", "()I", "GetGetBeaconCountHandler")]
			get {
				if (id_getBeaconCount == IntPtr.Zero)
					id_getBeaconCount = JNIEnv.GetMethodID (class_ref, "getBeaconCount", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconCount);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='setBeaconCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBeaconCount", "(I)V", "GetSetBeaconCount_IHandler")]
			set {
				if (id_setBeaconCount_I == IntPtr.Zero)
					id_setBeaconCount_I = JNIEnv.GetMethodID (class_ref, "setBeaconCount", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeaconCount_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getCachedAt;
		static IntPtr id_setCachedAt_Ljava_util_Date_;
		public unsafe global::Java.Util.Date CachedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='getCachedAt' and count(parameter)=0]"
			[Register ("getCachedAt", "()Ljava/util/Date;", "GetGetCachedAtHandler")]
			get {
				if (id_getCachedAt == IntPtr.Zero)
					id_getCachedAt = JNIEnv.GetMethodID (class_ref, "getCachedAt", "()Ljava/util/Date;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedAt), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='setCachedAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
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

		static IntPtr id_getCachedBeacons;
		public override unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> CachedBeacons {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='getCachedBeacons' and count(parameter)=0]"
			[Register ("getCachedBeacons", "()Ljava/util/List;", "GetGetCachedBeaconsHandler")]
			get {
				if (id_getCachedBeacons == IntPtr.Zero)
					id_getCachedBeacons = JNIEnv.GetMethodID (class_ref, "getCachedBeacons", "()Ljava/util/List;");
				try {
					return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedBeacons), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getCreatedAt;
		static IntPtr id_setCreatedAt_Ljava_util_Date_;
		public unsafe global::Java.Util.Date CreatedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='getCreatedAt' and count(parameter)=0]"
			[Register ("getCreatedAt", "()Ljava/util/Date;", "GetGetCreatedAtHandler")]
			get {
				if (id_getCreatedAt == IntPtr.Zero)
					id_getCreatedAt = JNIEnv.GetMethodID (class_ref, "getCreatedAt", "()Ljava/util/Date;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCreatedAt), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='setCreatedAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
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

		static IntPtr id_isSyncedOrRestored;
		public unsafe bool IsSyncedOrRestored {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='isSyncedOrRestored' and count(parameter)=0]"
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

		static IntPtr id_getLocation;
		public unsafe global::Android.Locations.Location Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Landroid/location/Location;", "GetGetLocationHandler")]
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Landroid/location/Location;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getModifiedAt;
		static IntPtr id_setModifiedAt_Ljava_util_Date_;
		public unsafe global::Java.Util.Date ModifiedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='getModifiedAt' and count(parameter)=0]"
			[Register ("getModifiedAt", "()Ljava/util/Date;", "GetGetModifiedAtHandler")]
			get {
				if (id_getModifiedAt == IntPtr.Zero)
					id_getModifiedAt = JNIEnv.GetMethodID (class_ref, "getModifiedAt", "()Ljava/util/Date;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getModifiedAt), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='setModifiedAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_getNotes;
		static IntPtr id_setNotes_Ljava_lang_String_;
		public unsafe string Notes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='getNotes' and count(parameter)=0]"
			[Register ("getNotes", "()Ljava/lang/String;", "GetGetNotesHandler")]
			get {
				if (id_getNotes == IntPtr.Zero)
					id_getNotes = JNIEnv.GetMethodID (class_ref, "getNotes", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNotes), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='setNotes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNotes", "(Ljava/lang/String;)V", "GetSetNotes_Ljava_lang_String_Handler")]
			set {
				if (id_setNotes_Ljava_lang_String_ == IntPtr.Zero)
					id_setNotes_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNotes", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotes_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getSiteAccessType;
		static IntPtr id_setSiteAccessType_Lcom_bluecats_sdk_BCSiteAccessType_;
		public unsafe global::Com.Bluecats.Sdk.BCSiteAccessType SiteAccessType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='getSiteAccessType' and count(parameter)=0]"
			[Register ("getSiteAccessType", "()Lcom/bluecats/sdk/BCSiteAccessType;", "GetGetSiteAccessTypeHandler")]
			get {
				if (id_getSiteAccessType == IntPtr.Zero)
					id_getSiteAccessType = JNIEnv.GetMethodID (class_ref, "getSiteAccessType", "()Lcom/bluecats/sdk/BCSiteAccessType;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteAccessType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSiteAccessType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='setSiteAccessType' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCSiteAccessType']]"
			[Register ("setSiteAccessType", "(Lcom/bluecats/sdk/BCSiteAccessType;)V", "GetSetSiteAccessType_Lcom_bluecats_sdk_BCSiteAccessType_Handler")]
			set {
				if (id_setSiteAccessType_Lcom_bluecats_sdk_BCSiteAccessType_ == IntPtr.Zero)
					id_setSiteAccessType_Lcom_bluecats_sdk_BCSiteAccessType_ = JNIEnv.GetMethodID (class_ref, "setSiteAccessType", "(Lcom/bluecats/sdk/BCSiteAccessType;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSiteAccessType_Lcom_bluecats_sdk_BCSiteAccessType_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getSyncStatus;
		static IntPtr id_setSyncStatus_Lcom_bluecats_sdk_BCBeacon_BCSyncStatus_;
		public unsafe global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus SyncStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='getSyncStatus' and count(parameter)=0]"
			[Register ("getSyncStatus", "()Lcom/bluecats/sdk/BCBeacon$BCSyncStatus;", "GetGetSyncStatusHandler")]
			get {
				if (id_getSyncStatus == IntPtr.Zero)
					id_getSyncStatus = JNIEnv.GetMethodID (class_ref, "getSyncStatus", "()Lcom/bluecats/sdk/BCBeacon$BCSyncStatus;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSyncStatus), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='setSyncStatus' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeacon.BCSyncStatus']]"
			[Register ("setSyncStatus", "(Lcom/bluecats/sdk/BCBeacon$BCSyncStatus;)V", "GetSetSyncStatus_Lcom_bluecats_sdk_BCBeacon_BCSyncStatus_Handler")]
			set {
				if (id_setSyncStatus_Lcom_bluecats_sdk_BCBeacon_BCSyncStatus_ == IntPtr.Zero)
					id_setSyncStatus_Lcom_bluecats_sdk_BCBeacon_BCSyncStatus_ = JNIEnv.GetMethodID (class_ref, "setSyncStatus", "(Lcom/bluecats/sdk/BCBeacon$BCSyncStatus;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSyncStatus_Lcom_bluecats_sdk_BCBeacon_BCSyncStatus_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getSyncedAt;
		static IntPtr id_setSyncedAt_Ljava_util_Date_;
		public unsafe global::Java.Util.Date SyncedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='getSyncedAt' and count(parameter)=0]"
			[Register ("getSyncedAt", "()Ljava/util/Date;", "GetGetSyncedAtHandler")]
			get {
				if (id_getSyncedAt == IntPtr.Zero)
					id_getSyncedAt = JNIEnv.GetMethodID (class_ref, "getSyncedAt", "()Ljava/util/Date;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSyncedAt), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='setSyncedAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
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

		static IntPtr id_copy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='copy' and count(parameter)=0]"
		[Register ("copy", "()Ljava/lang/Object;", "")]
		public unsafe global::Com.Bluecats.Sdk.IBCSite Copy ()
		{
			if (id_copy == IntPtr.Zero)
				id_copy = JNIEnv.GetMethodID (class_ref, "copy", "()Ljava/lang/Object;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_copy), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='describeContents' and count(parameter)=0]"
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

		static IntPtr id_description;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='description' and count(parameter)=0]"
		[Register ("description", "()Ljava/lang/String;", "")]
		public unsafe string Description ()
		{
			if (id_description == IntPtr.Zero)
				id_description = JNIEnv.GetMethodID (class_ref, "description", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_description), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getMaps;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='getMaps' and count(parameter)=0]"
		[Register ("getMaps", "()[Lcom/bluecats/sdk/BCMap;", "")]
		public unsafe global::Com.Bluecats.Sdk.BCMap[] GetMaps ()
		{
			if (id_getMaps == IntPtr.Zero)
				id_getMaps = JNIEnv.GetMethodID (class_ref, "getMaps", "()[Lcom/bluecats/sdk/BCMap;");
			try {
				return (global::Com.Bluecats.Sdk.BCMap[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMaps), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCMap));
			} finally {
			}
		}

		static IntPtr id_setMaps_arrayLcom_bluecats_sdk_BCMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='setMaps' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCMap[]']]"
		[Register ("setMaps", "([Lcom/bluecats/sdk/BCMap;)V", "")]
		public unsafe void SetMaps (global::Com.Bluecats.Sdk.BCMap[] value)
		{
			if (id_setMaps_arrayLcom_bluecats_sdk_BCMap_ == IntPtr.Zero)
				id_setMaps_arrayLcom_bluecats_sdk_BCMap_ = JNIEnv.GetMethodID (class_ref, "setMaps", "([Lcom/bluecats/sdk/BCMap;)V");
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaps_arrayLcom_bluecats_sdk_BCMap_, __args);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInternal']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
