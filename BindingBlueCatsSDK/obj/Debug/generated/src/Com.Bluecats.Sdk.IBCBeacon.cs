using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCBeaconState']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCBeacon$BCBeaconState", DoNotGenerateAcw=true)]
	public sealed partial class BCBeaconBCBeaconState : global::Java.Lang.Enum {


		static IntPtr BC_BEACON_STATE_INSIDE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCBeaconState']/field[@name='BC_BEACON_STATE_INSIDE']"
		[Register ("BC_BEACON_STATE_INSIDE")]
		public static global::Com.Bluecats.Sdk.BCBeaconBCBeaconState BcBeaconStateInside {
			get {
				if (BC_BEACON_STATE_INSIDE_jfieldId == IntPtr.Zero)
					BC_BEACON_STATE_INSIDE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_BEACON_STATE_INSIDE", "Lcom/bluecats/sdk/BCBeacon$BCBeaconState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_BEACON_STATE_INSIDE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCBeaconState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BC_BEACON_STATE_OUTSIDE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCBeaconState']/field[@name='BC_BEACON_STATE_OUTSIDE']"
		[Register ("BC_BEACON_STATE_OUTSIDE")]
		public static global::Com.Bluecats.Sdk.BCBeaconBCBeaconState BcBeaconStateOutside {
			get {
				if (BC_BEACON_STATE_OUTSIDE_jfieldId == IntPtr.Zero)
					BC_BEACON_STATE_OUTSIDE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_BEACON_STATE_OUTSIDE", "Lcom/bluecats/sdk/BCBeacon$BCBeaconState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_BEACON_STATE_OUTSIDE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCBeaconState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BC_BEACON_STATE_UNKNOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCBeaconState']/field[@name='BC_BEACON_STATE_UNKNOWN']"
		[Register ("BC_BEACON_STATE_UNKNOWN")]
		public static global::Com.Bluecats.Sdk.BCBeaconBCBeaconState BcBeaconStateUnknown {
			get {
				if (BC_BEACON_STATE_UNKNOWN_jfieldId == IntPtr.Zero)
					BC_BEACON_STATE_UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_BEACON_STATE_UNKNOWN", "Lcom/bluecats/sdk/BCBeacon$BCBeaconState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_BEACON_STATE_UNKNOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCBeaconState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCBeacon$BCBeaconState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCBeaconBCBeaconState); }
		}

		internal BCBeaconBCBeaconState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getName;
		public unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCBeaconState']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getValue;
		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCBeaconState']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getValue);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCBeaconState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCBeacon$BCBeaconState;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCBeaconBCBeaconState ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCBeacon$BCBeaconState;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Bluecats.Sdk.BCBeaconBCBeaconState __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCBeaconState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCBeaconState']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/bluecats/sdk/BCBeacon$BCBeaconState;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCBeaconBCBeaconState[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bluecats/sdk/BCBeacon$BCBeaconState;");
			try {
				return (global::Com.Bluecats.Sdk.BCBeaconBCBeaconState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCBeaconBCBeaconState));
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCProximity']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCBeacon$BCProximity", DoNotGenerateAcw=true)]
	public sealed partial class BCBeaconBCProximity : global::Java.Lang.Enum {


		static IntPtr BC_PROXIMITY_FAR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCProximity']/field[@name='BC_PROXIMITY_FAR']"
		[Register ("BC_PROXIMITY_FAR")]
		public static global::Com.Bluecats.Sdk.BCBeaconBCProximity BcProximityFar {
			get {
				if (BC_PROXIMITY_FAR_jfieldId == IntPtr.Zero)
					BC_PROXIMITY_FAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_PROXIMITY_FAR", "Lcom/bluecats/sdk/BCBeacon$BCProximity;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_PROXIMITY_FAR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCProximity> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BC_PROXIMITY_IMMEDIATE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCProximity']/field[@name='BC_PROXIMITY_IMMEDIATE']"
		[Register ("BC_PROXIMITY_IMMEDIATE")]
		public static global::Com.Bluecats.Sdk.BCBeaconBCProximity BcProximityImmediate {
			get {
				if (BC_PROXIMITY_IMMEDIATE_jfieldId == IntPtr.Zero)
					BC_PROXIMITY_IMMEDIATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_PROXIMITY_IMMEDIATE", "Lcom/bluecats/sdk/BCBeacon$BCProximity;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_PROXIMITY_IMMEDIATE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCProximity> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BC_PROXIMITY_NEAR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCProximity']/field[@name='BC_PROXIMITY_NEAR']"
		[Register ("BC_PROXIMITY_NEAR")]
		public static global::Com.Bluecats.Sdk.BCBeaconBCProximity BcProximityNear {
			get {
				if (BC_PROXIMITY_NEAR_jfieldId == IntPtr.Zero)
					BC_PROXIMITY_NEAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_PROXIMITY_NEAR", "Lcom/bluecats/sdk/BCBeacon$BCProximity;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_PROXIMITY_NEAR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCProximity> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BC_PROXIMITY_UNKNOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCProximity']/field[@name='BC_PROXIMITY_UNKNOWN']"
		[Register ("BC_PROXIMITY_UNKNOWN")]
		public static global::Com.Bluecats.Sdk.BCBeaconBCProximity BcProximityUnknown {
			get {
				if (BC_PROXIMITY_UNKNOWN_jfieldId == IntPtr.Zero)
					BC_PROXIMITY_UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_PROXIMITY_UNKNOWN", "Lcom/bluecats/sdk/BCBeacon$BCProximity;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_PROXIMITY_UNKNOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCProximity> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCBeacon$BCProximity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCBeaconBCProximity); }
		}

		internal BCBeaconBCProximity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getValue;
		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCProximity']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getValue);
				} finally {
				}
			}
		}

		static IntPtr id_getDisplayName_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCProximity']/method[@name='getDisplayName' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getDisplayName", "(Z)Ljava/lang/String;", "")]
		public unsafe string GetDisplayName (bool abbreviated)
		{
			if (id_getDisplayName_Z == IntPtr.Zero)
				id_getDisplayName_Z = JNIEnv.GetMethodID (class_ref, "getDisplayName", "(Z)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (abbreviated);
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayName_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCProximity']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCBeacon$BCProximity;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCBeaconBCProximity ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCBeacon$BCProximity;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Bluecats.Sdk.BCBeaconBCProximity __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCProximity> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCProximity']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/bluecats/sdk/BCBeacon$BCProximity;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCBeaconBCProximity[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bluecats/sdk/BCBeacon$BCProximity;");
			try {
				return (global::Com.Bluecats.Sdk.BCBeaconBCProximity[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCBeaconBCProximity));
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCSyncStatus']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCBeacon$BCSyncStatus", DoNotGenerateAcw=true)]
	public sealed partial class BCBeaconBCSyncStatus : global::Java.Lang.Enum {


		static IntPtr BC_SYNC_STATUS_ACCESS_SYNCED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCSyncStatus']/field[@name='BC_SYNC_STATUS_ACCESS_SYNCED']"
		[Register ("BC_SYNC_STATUS_ACCESS_SYNCED")]
		public static global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus BcSyncStatusAccessSynced {
			get {
				if (BC_SYNC_STATUS_ACCESS_SYNCED_jfieldId == IntPtr.Zero)
					BC_SYNC_STATUS_ACCESS_SYNCED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_SYNC_STATUS_ACCESS_SYNCED", "Lcom/bluecats/sdk/BCBeacon$BCSyncStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_SYNC_STATUS_ACCESS_SYNCED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BC_SYNC_STATUS_EXPIRED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCSyncStatus']/field[@name='BC_SYNC_STATUS_EXPIRED']"
		[Register ("BC_SYNC_STATUS_EXPIRED")]
		public static global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus BcSyncStatusExpired {
			get {
				if (BC_SYNC_STATUS_EXPIRED_jfieldId == IntPtr.Zero)
					BC_SYNC_STATUS_EXPIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_SYNC_STATUS_EXPIRED", "Lcom/bluecats/sdk/BCBeacon$BCSyncStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_SYNC_STATUS_EXPIRED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BC_SYNC_STATUS_NOT_SYNCED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCSyncStatus']/field[@name='BC_SYNC_STATUS_NOT_SYNCED']"
		[Register ("BC_SYNC_STATUS_NOT_SYNCED")]
		public static global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus BcSyncStatusNotSynced {
			get {
				if (BC_SYNC_STATUS_NOT_SYNCED_jfieldId == IntPtr.Zero)
					BC_SYNC_STATUS_NOT_SYNCED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_SYNC_STATUS_NOT_SYNCED", "Lcom/bluecats/sdk/BCBeacon$BCSyncStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_SYNC_STATUS_NOT_SYNCED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BC_SYNC_STATUS_RESTORED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCSyncStatus']/field[@name='BC_SYNC_STATUS_RESTORED']"
		[Register ("BC_SYNC_STATUS_RESTORED")]
		public static global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus BcSyncStatusRestored {
			get {
				if (BC_SYNC_STATUS_RESTORED_jfieldId == IntPtr.Zero)
					BC_SYNC_STATUS_RESTORED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_SYNC_STATUS_RESTORED", "Lcom/bluecats/sdk/BCBeacon$BCSyncStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_SYNC_STATUS_RESTORED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BC_SYNC_STATUS_SYNCED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCSyncStatus']/field[@name='BC_SYNC_STATUS_SYNCED']"
		[Register ("BC_SYNC_STATUS_SYNCED")]
		public static global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus BcSyncStatusSynced {
			get {
				if (BC_SYNC_STATUS_SYNCED_jfieldId == IntPtr.Zero)
					BC_SYNC_STATUS_SYNCED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_SYNC_STATUS_SYNCED", "Lcom/bluecats/sdk/BCBeacon$BCSyncStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_SYNC_STATUS_SYNCED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BC_SYNC_STATUS_UNAUTHORIZED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCSyncStatus']/field[@name='BC_SYNC_STATUS_UNAUTHORIZED']"
		[Register ("BC_SYNC_STATUS_UNAUTHORIZED")]
		public static global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus BcSyncStatusUnauthorized {
			get {
				if (BC_SYNC_STATUS_UNAUTHORIZED_jfieldId == IntPtr.Zero)
					BC_SYNC_STATUS_UNAUTHORIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_SYNC_STATUS_UNAUTHORIZED", "Lcom/bluecats/sdk/BCBeacon$BCSyncStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_SYNC_STATUS_UNAUTHORIZED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCBeacon$BCSyncStatus", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCBeaconBCSyncStatus); }
		}

		internal BCBeaconBCSyncStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDisplayName;
		public unsafe string DisplayName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCSyncStatus']/method[@name='getDisplayName' and count(parameter)=0]"
			[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler")]
			get {
				if (id_getDisplayName == IntPtr.Zero)
					id_getDisplayName = JNIEnv.GetMethodID (class_ref, "getDisplayName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getValue;
		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCSyncStatus']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getValue);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCSyncStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCBeacon$BCSyncStatus;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCBeacon$BCSyncStatus;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCSyncStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/bluecats/sdk/BCBeacon$BCSyncStatus;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bluecats/sdk/BCBeacon$BCSyncStatus;");
			try {
				return (global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus));
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCVerificationStatus']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCBeacon$BCVerificationStatus", DoNotGenerateAcw=true)]
	public sealed partial class BCBeaconBCVerificationStatus : global::Java.Lang.Enum {


		static IntPtr BC_VERIFICATION_STATUS_DETECTED_ATTACK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCVerificationStatus']/field[@name='BC_VERIFICATION_STATUS_DETECTED_ATTACK']"
		[Register ("BC_VERIFICATION_STATUS_DETECTED_ATTACK")]
		public static global::Com.Bluecats.Sdk.BCBeaconBCVerificationStatus BcVerificationStatusDetectedAttack {
			get {
				if (BC_VERIFICATION_STATUS_DETECTED_ATTACK_jfieldId == IntPtr.Zero)
					BC_VERIFICATION_STATUS_DETECTED_ATTACK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_VERIFICATION_STATUS_DETECTED_ATTACK", "Lcom/bluecats/sdk/BCBeacon$BCVerificationStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_VERIFICATION_STATUS_DETECTED_ATTACK_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCVerificationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BC_VERIFICATION_STATUS_NOT_VERIFIED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCVerificationStatus']/field[@name='BC_VERIFICATION_STATUS_NOT_VERIFIED']"
		[Register ("BC_VERIFICATION_STATUS_NOT_VERIFIED")]
		public static global::Com.Bluecats.Sdk.BCBeaconBCVerificationStatus BcVerificationStatusNotVerified {
			get {
				if (BC_VERIFICATION_STATUS_NOT_VERIFIED_jfieldId == IntPtr.Zero)
					BC_VERIFICATION_STATUS_NOT_VERIFIED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_VERIFICATION_STATUS_NOT_VERIFIED", "Lcom/bluecats/sdk/BCBeacon$BCVerificationStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_VERIFICATION_STATUS_NOT_VERIFIED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCVerificationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BC_VERIFICATION_STATUS_VERIFIED_VIA_BLUECATS_IBEACON_AD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCVerificationStatus']/field[@name='BC_VERIFICATION_STATUS_VERIFIED_VIA_BLUECATS_IBEACON_AD']"
		[Register ("BC_VERIFICATION_STATUS_VERIFIED_VIA_BLUECATS_IBEACON_AD")]
		public static global::Com.Bluecats.Sdk.BCBeaconBCVerificationStatus BcVerificationStatusVerifiedViaBluecatsIbeaconAd {
			get {
				if (BC_VERIFICATION_STATUS_VERIFIED_VIA_BLUECATS_IBEACON_AD_jfieldId == IntPtr.Zero)
					BC_VERIFICATION_STATUS_VERIFIED_VIA_BLUECATS_IBEACON_AD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_VERIFICATION_STATUS_VERIFIED_VIA_BLUECATS_IBEACON_AD", "Lcom/bluecats/sdk/BCBeacon$BCVerificationStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_VERIFICATION_STATUS_VERIFIED_VIA_BLUECATS_IBEACON_AD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCVerificationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BC_VERIFICATION_STATUS_VERIFIED_VIA_BLUECATS_SECURE_AD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCVerificationStatus']/field[@name='BC_VERIFICATION_STATUS_VERIFIED_VIA_BLUECATS_SECURE_AD']"
		[Register ("BC_VERIFICATION_STATUS_VERIFIED_VIA_BLUECATS_SECURE_AD")]
		public static global::Com.Bluecats.Sdk.BCBeaconBCVerificationStatus BcVerificationStatusVerifiedViaBluecatsSecureAd {
			get {
				if (BC_VERIFICATION_STATUS_VERIFIED_VIA_BLUECATS_SECURE_AD_jfieldId == IntPtr.Zero)
					BC_VERIFICATION_STATUS_VERIFIED_VIA_BLUECATS_SECURE_AD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_VERIFICATION_STATUS_VERIFIED_VIA_BLUECATS_SECURE_AD", "Lcom/bluecats/sdk/BCBeacon$BCVerificationStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_VERIFICATION_STATUS_VERIFIED_VIA_BLUECATS_SECURE_AD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCVerificationStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCBeacon$BCVerificationStatus", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCBeaconBCVerificationStatus); }
		}

		internal BCBeaconBCVerificationStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDisplayName;
		public unsafe string DisplayName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCVerificationStatus']/method[@name='getDisplayName' and count(parameter)=0]"
			[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler")]
			get {
				if (id_getDisplayName == IntPtr.Zero)
					id_getDisplayName = JNIEnv.GetMethodID (class_ref, "getDisplayName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getValue;
		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCVerificationStatus']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "GetGetValueHandler")]
			get {
				if (id_getValue == IntPtr.Zero)
					id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getValue);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCVerificationStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCBeacon$BCVerificationStatus;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCBeaconBCVerificationStatus ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCBeacon$BCVerificationStatus;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Bluecats.Sdk.BCBeaconBCVerificationStatus __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCVerificationStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeacon.BCVerificationStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/bluecats/sdk/BCBeacon$BCVerificationStatus;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCBeaconBCVerificationStatus[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bluecats/sdk/BCBeacon$BCVerificationStatus;");
			try {
				return (global::Com.Bluecats.Sdk.BCBeaconBCVerificationStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCBeaconBCVerificationStatus));
			} finally {
			}
		}

	}

	[Register ("com/bluecats/sdk/BCBeacon", DoNotGenerateAcw=true)]
	public abstract class BCBeacon : Java.Lang.Object {

		internal BCBeacon ()
		{
		}

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

		// The following are fields from: android.os.Parcelable

		// The following are fields from: Android.Runtime.IJavaObject

		// The following are fields from: System.IDisposable
	}

	[Register ("com/bluecats/sdk/BCBeacon", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'BCBeacon' type. This type will be removed in a future release.")]
	public abstract class BCBeaconConsts : BCBeacon {

		private BCBeaconConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']"
	[Register ("com/bluecats/sdk/BCBeacon", "", "Com.Bluecats.Sdk.IBCBeaconInvoker")]
	public partial interface IBCBeacon : global::Android.OS.IParcelable {

		global::Java.Lang.Double Accuracy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getAccuracy' and count(parameter)=0]"
			[Register ("getAccuracy", "()Ljava/lang/Double;", "GetGetAccuracyHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='setAccuracy' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setAccuracy", "(Ljava/lang/Double;)V", "GetSetAccuracy_Ljava_lang_Double_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] set;
		}

		global::Java.Lang.Integer BatteryLevelFromBCAdData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getBatteryLevelFromBCAdData' and count(parameter)=0]"
			[Register ("getBatteryLevelFromBCAdData", "()Ljava/lang/Integer;", "GetGetBatteryLevelFromBCAdDataHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		global::Com.Bluecats.Sdk.BCBatteryStatus BatteryStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getBatteryStatus' and count(parameter)=0]"
			[Register ("getBatteryStatus", "()Lcom/bluecats/sdk/BCBatteryStatus;", "GetGetBatteryStatusHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		string BeaconID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getBeaconID' and count(parameter)=0]"
			[Register ("getBeaconID", "()Ljava/lang/String;", "GetGetBeaconIDHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='setBeaconID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBeaconID", "(Ljava/lang/String;)V", "GetSetBeaconID_Ljava_lang_String_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] set;
		}

		global::Com.Bluecats.Sdk.BCBeaconLoudness BeaconLoudness {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getBeaconLoudness' and count(parameter)=0]"
			[Register ("getBeaconLoudness", "()Lcom/bluecats/sdk/BCBeaconLoudness;", "GetGetBeaconLoudnessHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='setBeaconLoudness' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconLoudness']]"
			[Register ("setBeaconLoudness", "(Lcom/bluecats/sdk/BCBeaconLoudness;)V", "GetSetBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] set;
		}

		global::Com.Bluecats.Sdk.BCBeaconMode BeaconMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getBeaconMode' and count(parameter)=0]"
			[Register ("getBeaconMode", "()Lcom/bluecats/sdk/BCBeaconMode;", "GetGetBeaconModeHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='setBeaconMode' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconMode']]"
			[Register ("setBeaconMode", "(Lcom/bluecats/sdk/BCBeaconMode;)V", "GetSetBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] set;
		}

		global::Com.Bluecats.Sdk.BCBeaconMode BeaconModeFromBlueCatsAdData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getBeaconModeFromBlueCatsAdData' and count(parameter)=0]"
			[Register ("getBeaconModeFromBlueCatsAdData", "()Lcom/bluecats/sdk/BCBeaconMode;", "GetGetBeaconModeFromBlueCatsAdDataHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		global::Com.Bluecats.Sdk.BCBeaconRegion BeaconRegion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getBeaconRegion' and count(parameter)=0]"
			[Register ("getBeaconRegion", "()Lcom/bluecats/sdk/BCBeaconRegion;", "GetGetBeaconRegionHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='setBeaconRegion' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconRegion']]"
			[Register ("setBeaconRegion", "(Lcom/bluecats/sdk/BCBeaconRegion;)V", "GetSetBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] set;
		}

		string BluetoothAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getBluetoothAddress' and count(parameter)=0]"
			[Register ("getBluetoothAddress", "()Ljava/lang/String;", "GetGetBluetoothAddressHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		string CacheIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getCacheIdentifier' and count(parameter)=0]"
			[Register ("getCacheIdentifier", "()Ljava/lang/String;", "GetGetCacheIdentifierHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		global::Java.Util.Date CachedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getCachedAt' and count(parameter)=0]"
			[Register ("getCachedAt", "()Ljava/util/Date;", "GetGetCachedAtHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		global::Com.Bluecats.Sdk.BCEddystone Eddystone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getEddystone' and count(parameter)=0]"
			[Register ("getEddystone", "()Lcom/bluecats/sdk/BCEddystone;", "GetGetEddystoneHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='setEddystone' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCEddystone']]"
			[Register ("setEddystone", "(Lcom/bluecats/sdk/BCEddystone;)V", "GetSetEddystone_Lcom_bluecats_sdk_BCEddystone_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] set;
		}

		string FirmwareVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getFirmwareVersion' and count(parameter)=0]"
			[Register ("getFirmwareVersion", "()Ljava/lang/String;", "GetGetFirmwareVersionHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		bool HasDiscoveredEddystoneTelemetryFrame {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='hasDiscoveredEddystoneTelemetryFrame' and count(parameter)=0]"
			[Register ("hasDiscoveredEddystoneTelemetryFrame", "()Z", "GetHasDiscoveredEddystoneTelemetryFrameHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		bool HasDiscoveredEddystoneUIDFrame {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='hasDiscoveredEddystoneUIDFrame' and count(parameter)=0]"
			[Register ("hasDiscoveredEddystoneUIDFrame", "()Z", "GetHasDiscoveredEddystoneUIDFrameHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		bool HasDiscoveredEddystoneURLFrame {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='hasDiscoveredEddystoneURLFrame' and count(parameter)=0]"
			[Register ("hasDiscoveredEddystoneURLFrame", "()Z", "GetHasDiscoveredEddystoneURLFrameHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		bool IsBlueCat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='isBlueCat' and count(parameter)=0]"
			[Register ("isBlueCat", "()Z", "GetIsBlueCatHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		bool IsDiscovered {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='isDiscovered' and count(parameter)=0]"
			[Register ("isDiscovered", "()Z", "GetIsDiscoveredHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		bool IsEddystone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='isEddystone' and count(parameter)=0]"
			[Register ("isEddystone", "()Z", "GetIsEddystoneHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		bool IsIBeacon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='isIBeacon' and count(parameter)=0]"
			[Register ("isIBeacon", "()Z", "GetIsIBeaconHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		bool IsNewBorn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='isNewBorn' and count(parameter)=0]"
			[Register ("isNewBorn", "()Z", "GetIsNewBornHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		bool IsSecure {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='isSecure' and count(parameter)=0]"
			[Register ("isSecure", "()Z", "GetIsSecureHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		bool IsSyncedOrRestored {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='isSyncedOrRestored' and count(parameter)=0]"
			[Register ("isSyncedOrRestored", "()Z", "GetIsSyncedOrRestoredHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		global::Java.Lang.Integer LastKnownBatteryLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getLastKnownBatteryLevel' and count(parameter)=0]"
			[Register ("getLastKnownBatteryLevel", "()Ljava/lang/Integer;", "GetGetLastKnownBatteryLevelHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		global::Java.Util.Date LastRangedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getLastRangedAt' and count(parameter)=0]"
			[Register ("getLastRangedAt", "()Ljava/util/Date;", "GetGetLastRangedAtHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		string LatestFirmwareVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getLatestFirmwareVersion' and count(parameter)=0]"
			[Register ("getLatestFirmwareVersion", "()Ljava/lang/String;", "GetGetLatestFirmwareVersionHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		string LocalName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getLocalName' and count(parameter)=0]"
			[Register ("getLocalName", "()Ljava/lang/String;", "GetGetLocalNameHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		global::Java.Lang.Integer Major {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getMajor' and count(parameter)=0]"
			[Register ("getMajor", "()Ljava/lang/Integer;", "GetGetMajorHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='setMajor' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setMajor", "(Ljava/lang/Integer;)V", "GetSetMajor_Ljava_lang_Integer_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] set;
		}

		global::Com.Bluecats.Sdk.BCMapPoint MapPoint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getMapPoint' and count(parameter)=0]"
			[Register ("getMapPoint", "()Lcom/bluecats/sdk/BCMapPoint;", "GetGetMapPointHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		global::Java.Lang.Integer MeasuredPowerAt1Meter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getMeasuredPowerAt1Meter' and count(parameter)=0]"
			[Register ("getMeasuredPowerAt1Meter", "()Ljava/lang/Integer;", "GetGetMeasuredPowerAt1MeterHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='setMeasuredPowerAt1Meter' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setMeasuredPowerAt1Meter", "(Ljava/lang/Integer;)V", "GetSetMeasuredPowerAt1Meter_Ljava_lang_Integer_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] set;
		}

		string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		global::Java.Lang.Integer Minor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getMinor' and count(parameter)=0]"
			[Register ("getMinor", "()Ljava/lang/Integer;", "GetGetMinorHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='setMinor' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setMinor", "(Ljava/lang/Integer;)V", "GetSetMinor_Ljava_lang_Integer_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] set;
		}

		string ModelNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getModelNumber' and count(parameter)=0]"
			[Register ("getModelNumber", "()Ljava/lang/String;", "GetGetModelNumberHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] set;
		}

		string PendingVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getPendingVersion' and count(parameter)=0]"
			[Register ("getPendingVersion", "()Ljava/lang/String;", "GetGetPendingVersionHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		global::Java.Lang.Integer PrivacyDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getPrivacyDuration' and count(parameter)=0]"
			[Register ("getPrivacyDuration", "()Ljava/lang/Integer;", "GetGetPrivacyDurationHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='setPrivacyDuration' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setPrivacyDuration", "(Ljava/lang/Integer;)V", "GetSetPrivacyDuration_Ljava_lang_Integer_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] set;
		}

		global::Com.Bluecats.Sdk.BCBeaconBCProximity Proximity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getProximity' and count(parameter)=0]"
			[Register ("getProximity", "()Lcom/bluecats/sdk/BCBeacon$BCProximity;", "GetGetProximityHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='setProximity' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeacon.BCProximity']]"
			[Register ("setProximity", "(Lcom/bluecats/sdk/BCBeacon$BCProximity;)V", "GetSetProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] set;
		}

		string ProximityUUIDString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getProximityUUIDString' and count(parameter)=0]"
			[Register ("getProximityUUIDString", "()Ljava/lang/String;", "GetGetProximityUUIDStringHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='setProximityUUIDString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProximityUUIDString", "(Ljava/lang/String;)V", "GetSetProximityUUIDString_Ljava_lang_String_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] set;
		}

		global::Java.Lang.Integer RSSI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getRSSI' and count(parameter)=0]"
			[Register ("getRSSI", "()Ljava/lang/Integer;", "GetGetRSSIHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='setRSSI' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setRSSI", "(Ljava/lang/Integer;)V", "GetSetRSSI_Ljava_lang_Integer_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] set;
		}

		string SerialNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getSerialNumber' and count(parameter)=0]"
			[Register ("getSerialNumber", "()Ljava/lang/String;", "GetGetSerialNumberHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		global::Com.Bluecats.Sdk.IBCSite Site {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getSite' and count(parameter)=0]"
			[Register ("getSite", "()Lcom/bluecats/sdk/BCSite;", "GetGetSiteHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		string SiteID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getSiteID' and count(parameter)=0]"
			[Register ("getSiteID", "()Ljava/lang/String;", "GetGetSiteIDHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		string SiteName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getSiteName' and count(parameter)=0]"
			[Register ("getSiteName", "()Ljava/lang/String;", "GetGetSiteNameHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus SyncStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getSyncStatus' and count(parameter)=0]"
			[Register ("getSyncStatus", "()Lcom/bluecats/sdk/BCBeacon$BCSyncStatus;", "GetGetSyncStatusHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		global::Java.Util.Date SyncedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getSyncedAt' and count(parameter)=0]"
			[Register ("getSyncedAt", "()Ljava/util/Date;", "GetGetSyncedAtHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		global::Com.Bluecats.Sdk.BCTargetSpeed TargetSpeed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getTargetSpeed' and count(parameter)=0]"
			[Register ("getTargetSpeed", "()Lcom/bluecats/sdk/BCTargetSpeed;", "GetGetTargetSpeedHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='setTargetSpeed' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCTargetSpeed']]"
			[Register ("setTargetSpeed", "(Lcom/bluecats/sdk/BCTargetSpeed;)V", "GetSetTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] set;
		}

		string TeamID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getTeamID' and count(parameter)=0]"
			[Register ("getTeamID", "()Ljava/lang/String;", "GetGetTeamIDHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		string Uptime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getUptime' and count(parameter)=0]"
			[Register ("getUptime", "()Ljava/lang/String;", "GetGetUptimeHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		global::Com.Bluecats.Sdk.BCBeaconBCVerificationStatus VerificationStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getVerificationStatus' and count(parameter)=0]"
			[Register ("getVerificationStatus", "()Lcom/bluecats/sdk/BCBeacon$BCVerificationStatus;", "GetGetVerificationStatusHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		global::Java.Util.Date VerifiedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getVerifiedAt' and count(parameter)=0]"
			[Register ("getVerifiedAt", "()Ljava/util/Date;", "GetGetVerifiedAtHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='setVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVersion", "(Ljava/lang/String;)V", "GetSetVersion_Ljava_lang_String_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] set;
		}

		string WireframeURLString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getWireframeURLString' and count(parameter)=0]"
			[Register ("getWireframeURLString", "()Ljava/lang/String;", "GetGetWireframeURLStringHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='copy' and count(parameter)=0]"
		[Register ("copy", "()Lcom/bluecats/sdk/BCBeacon;", "GetCopyHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")]
		global::Com.Bluecats.Sdk.IBCBeacon Copy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='copyApiPropertiesFromBeacon' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeacon']]"
		[Register ("copyApiPropertiesFromBeacon", "(Lcom/bluecats/sdk/BCBeacon;)V", "GetCopyApiPropertiesFromBeacon_Lcom_bluecats_sdk_BCBeacon_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")]
		void CopyApiPropertiesFromBeacon (global::Com.Bluecats.Sdk.IBCBeacon p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getBeaconLoudnessesFromApi' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCBeaconCallback'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("getBeaconLoudnessesFromApi", "(Lcom/bluecats/sdk/BCBeaconCallback;Ljava/util/Map;)V", "GetGetBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")]
		void GetBeaconLoudnessesFromApi (global::Com.Bluecats.Sdk.IBCBeaconCallback p0, global::System.Collections.Generic.IDictionary<string, string> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getBeaconModesFromApi' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCBeaconCallback'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("getBeaconModesFromApi", "(Lcom/bluecats/sdk/BCBeaconCallback;Ljava/util/Map;)V", "GetGetBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")]
		void GetBeaconModesFromApi (global::Com.Bluecats.Sdk.IBCBeaconCallback p0, global::System.Collections.Generic.IDictionary<string, string> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getBeaconRegionsInTeamFromApi' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconCallback']]"
		[Register ("getBeaconRegionsInTeamFromApi", "(Lcom/bluecats/sdk/BCBeaconCallback;)V", "GetGetBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")]
		void GetBeaconRegionsInTeamFromApi (global::Com.Bluecats.Sdk.IBCBeaconCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getBeaconTargetSpeedsFromApi' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCBeaconCallback'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("getBeaconTargetSpeedsFromApi", "(Lcom/bluecats/sdk/BCBeaconCallback;Ljava/util/Map;)V", "GetGetBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")]
		void GetBeaconTargetSpeedsFromApi (global::Com.Bluecats.Sdk.IBCBeaconCallback p0, global::System.Collections.Generic.IDictionary<string, string> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getBeaconVersion' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='com.bluecats.sdk.BCBeaconCallback']]"
		[Register ("getBeaconVersion", "(Ljava/lang/Integer;Lcom/bluecats/sdk/BCBeaconCallback;)V", "GetGetBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")]
		void GetBeaconVersion (global::Java.Lang.Integer p0, global::Com.Bluecats.Sdk.IBCBeaconCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getCategories' and count(parameter)=0]"
		[Register ("getCategories", "()[Lcom/bluecats/sdk/BCCategory;", "GetGetCategoriesHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")]
		global::Com.Bluecats.Sdk.BCCategory[] GetCategories ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getCustomValues' and count(parameter)=0]"
		[Register ("getCustomValues", "()[Lcom/bluecats/sdk/BCCustomValue;", "GetGetCustomValuesHandler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")]
		global::Com.Bluecats.Sdk.BCCustomValue[] GetCustomValues ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getLatestBeacon' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconCallback']]"
		[Register ("getLatestBeacon", "(Lcom/bluecats/sdk/BCBeaconCallback;)V", "GetGetLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")]
		void GetLatestBeacon (global::Com.Bluecats.Sdk.IBCBeaconCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='getLatestBeaconVersion' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconCallback']]"
		[Register ("getLatestBeaconVersion", "(Lcom/bluecats/sdk/BCBeaconCallback;)V", "GetGetLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")]
		void GetLatestBeaconVersion (global::Com.Bluecats.Sdk.IBCBeaconCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='moveBeaconToTeam' and count(parameter)=4 and parameter[1][@type='com.bluecats.sdk.BCTeam'] and parameter[2][@type='com.bluecats.sdk.BCSite'] and parameter[3][@type='boolean'] and parameter[4][@type='com.bluecats.sdk.BCBeaconCallback']]"
		[Register ("moveBeaconToTeam", "(Lcom/bluecats/sdk/BCTeam;Lcom/bluecats/sdk/BCSite;ZLcom/bluecats/sdk/BCBeaconCallback;)V", "GetMoveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")]
		void MoveBeaconToTeam (global::Com.Bluecats.Sdk.BCTeam p0, global::Com.Bluecats.Sdk.IBCSite p1, bool p2, global::Com.Bluecats.Sdk.IBCBeaconCallback p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='refreshBeacon' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconCallback']]"
		[Register ("refreshBeacon", "(Lcom/bluecats/sdk/BCBeaconCallback;)V", "GetRefreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")]
		void RefreshBeacon (global::Com.Bluecats.Sdk.IBCBeaconCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='setCategories' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCCategory[]']]"
		[Register ("setCategories", "([Lcom/bluecats/sdk/BCCategory;)V", "GetSetCategories_arrayLcom_bluecats_sdk_BCCategory_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")]
		void SetCategories (global::Com.Bluecats.Sdk.BCCategory[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='setCustomValues' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCCustomValue[]']]"
		[Register ("setCustomValues", "([Lcom/bluecats/sdk/BCCustomValue;)V", "GetSetCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")]
		void SetCustomValues (global::Com.Bluecats.Sdk.BCCustomValue[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeacon']/method[@name='updateBeacon' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCBeacon'] and parameter[2][@type='com.bluecats.sdk.BCBeaconCallback']]"
		[Register ("updateBeacon", "(Lcom/bluecats/sdk/BCBeacon;Lcom/bluecats/sdk/BCBeaconCallback;)V", "GetUpdateBeacon_Lcom_bluecats_sdk_BCBeacon_Lcom_bluecats_sdk_BCBeaconCallback_Handler:Com.Bluecats.Sdk.IBCBeaconInvoker, BindingBlueCatsSDK")]
		void UpdateBeacon (global::Com.Bluecats.Sdk.IBCBeacon p0, global::Com.Bluecats.Sdk.IBCBeaconCallback p1);

	}

	[global::Android.Runtime.Register ("com/bluecats/sdk/BCBeacon", DoNotGenerateAcw=true)]
	internal class IBCBeaconInvoker : global::Java.Lang.Object, IBCBeacon {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bluecats/sdk/BCBeacon");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBCBeaconInvoker); }
		}

		IntPtr class_ref;

		public static IBCBeacon GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBCBeacon> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bluecats.sdk.BCBeacon"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBCBeaconInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAccuracy;
#pragma warning disable 0169
		static Delegate GetGetAccuracyHandler ()
		{
			if (cb_getAccuracy == null)
				cb_getAccuracy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccuracy);
			return cb_getAccuracy;
		}

		static IntPtr n_GetAccuracy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Accuracy);
		}
#pragma warning restore 0169

		static Delegate cb_setAccuracy_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetAccuracy_Ljava_lang_Double_Handler ()
		{
			if (cb_setAccuracy_Ljava_lang_Double_ == null)
				cb_setAccuracy_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAccuracy_Ljava_lang_Double_);
			return cb_setAccuracy_Ljava_lang_Double_;
		}

		static void n_SetAccuracy_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Accuracy = p0;
		}
#pragma warning restore 0169

		IntPtr id_getAccuracy;
		IntPtr id_setAccuracy_Ljava_lang_Double_;
		public unsafe global::Java.Lang.Double Accuracy {
			get {
				if (id_getAccuracy == IntPtr.Zero)
					id_getAccuracy = JNIEnv.GetMethodID (class_ref, "getAccuracy", "()Ljava/lang/Double;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccuracy), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setAccuracy_Ljava_lang_Double_ == IntPtr.Zero)
					id_setAccuracy_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setAccuracy", "(Ljava/lang/Double;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAccuracy_Ljava_lang_Double_, __args);
			}
		}

		static Delegate cb_getBatteryLevelFromBCAdData;
#pragma warning disable 0169
		static Delegate GetGetBatteryLevelFromBCAdDataHandler ()
		{
			if (cb_getBatteryLevelFromBCAdData == null)
				cb_getBatteryLevelFromBCAdData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBatteryLevelFromBCAdData);
			return cb_getBatteryLevelFromBCAdData;
		}

		static IntPtr n_GetBatteryLevelFromBCAdData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BatteryLevelFromBCAdData);
		}
#pragma warning restore 0169

		IntPtr id_getBatteryLevelFromBCAdData;
		public unsafe global::Java.Lang.Integer BatteryLevelFromBCAdData {
			get {
				if (id_getBatteryLevelFromBCAdData == IntPtr.Zero)
					id_getBatteryLevelFromBCAdData = JNIEnv.GetMethodID (class_ref, "getBatteryLevelFromBCAdData", "()Ljava/lang/Integer;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBatteryLevelFromBCAdData), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getBatteryStatus;
#pragma warning disable 0169
		static Delegate GetGetBatteryStatusHandler ()
		{
			if (cb_getBatteryStatus == null)
				cb_getBatteryStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBatteryStatus);
			return cb_getBatteryStatus;
		}

		static IntPtr n_GetBatteryStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BatteryStatus);
		}
#pragma warning restore 0169

		IntPtr id_getBatteryStatus;
		public unsafe global::Com.Bluecats.Sdk.BCBatteryStatus BatteryStatus {
			get {
				if (id_getBatteryStatus == IntPtr.Zero)
					id_getBatteryStatus = JNIEnv.GetMethodID (class_ref, "getBatteryStatus", "()Lcom/bluecats/sdk/BCBatteryStatus;");
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBatteryStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBatteryStatus), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getBeaconID;
#pragma warning disable 0169
		static Delegate GetGetBeaconIDHandler ()
		{
			if (cb_getBeaconID == null)
				cb_getBeaconID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeaconID);
			return cb_getBeaconID;
		}

		static IntPtr n_GetBeaconID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BeaconID);
		}
#pragma warning restore 0169

		static Delegate cb_setBeaconID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBeaconID_Ljava_lang_String_Handler ()
		{
			if (cb_setBeaconID_Ljava_lang_String_ == null)
				cb_setBeaconID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBeaconID_Ljava_lang_String_);
			return cb_setBeaconID_Ljava_lang_String_;
		}

		static void n_SetBeaconID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BeaconID = p0;
		}
#pragma warning restore 0169

		IntPtr id_getBeaconID;
		IntPtr id_setBeaconID_Ljava_lang_String_;
		public unsafe string BeaconID {
			get {
				if (id_getBeaconID == IntPtr.Zero)
					id_getBeaconID = JNIEnv.GetMethodID (class_ref, "getBeaconID", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconID), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setBeaconID_Ljava_lang_String_ == IntPtr.Zero)
					id_setBeaconID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBeaconID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeaconID_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getBeaconLoudness;
#pragma warning disable 0169
		static Delegate GetGetBeaconLoudnessHandler ()
		{
			if (cb_getBeaconLoudness == null)
				cb_getBeaconLoudness = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeaconLoudness);
			return cb_getBeaconLoudness;
		}

		static IntPtr n_GetBeaconLoudness (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BeaconLoudness);
		}
#pragma warning restore 0169

		static Delegate cb_setBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_;
#pragma warning disable 0169
		static Delegate GetSetBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_Handler ()
		{
			if (cb_setBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_ == null)
				cb_setBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_);
			return cb_setBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_;
		}

		static void n_SetBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconLoudness p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconLoudness> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BeaconLoudness = p0;
		}
#pragma warning restore 0169

		IntPtr id_getBeaconLoudness;
		IntPtr id_setBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_;
		public unsafe global::Com.Bluecats.Sdk.BCBeaconLoudness BeaconLoudness {
			get {
				if (id_getBeaconLoudness == IntPtr.Zero)
					id_getBeaconLoudness = JNIEnv.GetMethodID (class_ref, "getBeaconLoudness", "()Lcom/bluecats/sdk/BCBeaconLoudness;");
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconLoudness> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconLoudness), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_ == IntPtr.Zero)
					id_setBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_ = JNIEnv.GetMethodID (class_ref, "setBeaconLoudness", "(Lcom/bluecats/sdk/BCBeaconLoudness;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_, __args);
			}
		}

		static Delegate cb_getBeaconMode;
#pragma warning disable 0169
		static Delegate GetGetBeaconModeHandler ()
		{
			if (cb_getBeaconMode == null)
				cb_getBeaconMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeaconMode);
			return cb_getBeaconMode;
		}

		static IntPtr n_GetBeaconMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BeaconMode);
		}
#pragma warning restore 0169

		static Delegate cb_setBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_;
#pragma warning disable 0169
		static Delegate GetSetBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_Handler ()
		{
			if (cb_setBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_ == null)
				cb_setBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_);
			return cb_setBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_;
		}

		static void n_SetBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconMode p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BeaconMode = p0;
		}
#pragma warning restore 0169

		IntPtr id_getBeaconMode;
		IntPtr id_setBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_;
		public unsafe global::Com.Bluecats.Sdk.BCBeaconMode BeaconMode {
			get {
				if (id_getBeaconMode == IntPtr.Zero)
					id_getBeaconMode = JNIEnv.GetMethodID (class_ref, "getBeaconMode", "()Lcom/bluecats/sdk/BCBeaconMode;");
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconMode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconMode), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_ == IntPtr.Zero)
					id_setBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_ = JNIEnv.GetMethodID (class_ref, "setBeaconMode", "(Lcom/bluecats/sdk/BCBeaconMode;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_, __args);
			}
		}

		static Delegate cb_getBeaconModeFromBlueCatsAdData;
#pragma warning disable 0169
		static Delegate GetGetBeaconModeFromBlueCatsAdDataHandler ()
		{
			if (cb_getBeaconModeFromBlueCatsAdData == null)
				cb_getBeaconModeFromBlueCatsAdData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeaconModeFromBlueCatsAdData);
			return cb_getBeaconModeFromBlueCatsAdData;
		}

		static IntPtr n_GetBeaconModeFromBlueCatsAdData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BeaconModeFromBlueCatsAdData);
		}
#pragma warning restore 0169

		IntPtr id_getBeaconModeFromBlueCatsAdData;
		public unsafe global::Com.Bluecats.Sdk.BCBeaconMode BeaconModeFromBlueCatsAdData {
			get {
				if (id_getBeaconModeFromBlueCatsAdData == IntPtr.Zero)
					id_getBeaconModeFromBlueCatsAdData = JNIEnv.GetMethodID (class_ref, "getBeaconModeFromBlueCatsAdData", "()Lcom/bluecats/sdk/BCBeaconMode;");
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconMode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconModeFromBlueCatsAdData), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getBeaconRegion;
#pragma warning disable 0169
		static Delegate GetGetBeaconRegionHandler ()
		{
			if (cb_getBeaconRegion == null)
				cb_getBeaconRegion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeaconRegion);
			return cb_getBeaconRegion;
		}

		static IntPtr n_GetBeaconRegion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BeaconRegion);
		}
#pragma warning restore 0169

		static Delegate cb_setBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_;
#pragma warning disable 0169
		static Delegate GetSetBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_Handler ()
		{
			if (cb_setBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_ == null)
				cb_setBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_);
			return cb_setBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_;
		}

		static void n_SetBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconRegion p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BeaconRegion = p0;
		}
#pragma warning restore 0169

		IntPtr id_getBeaconRegion;
		IntPtr id_setBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_;
		public unsafe global::Com.Bluecats.Sdk.BCBeaconRegion BeaconRegion {
			get {
				if (id_getBeaconRegion == IntPtr.Zero)
					id_getBeaconRegion = JNIEnv.GetMethodID (class_ref, "getBeaconRegion", "()Lcom/bluecats/sdk/BCBeaconRegion;");
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconRegion), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_ == IntPtr.Zero)
					id_setBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_ = JNIEnv.GetMethodID (class_ref, "setBeaconRegion", "(Lcom/bluecats/sdk/BCBeaconRegion;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_, __args);
			}
		}

		static Delegate cb_getBluetoothAddress;
#pragma warning disable 0169
		static Delegate GetGetBluetoothAddressHandler ()
		{
			if (cb_getBluetoothAddress == null)
				cb_getBluetoothAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBluetoothAddress);
			return cb_getBluetoothAddress;
		}

		static IntPtr n_GetBluetoothAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BluetoothAddress);
		}
#pragma warning restore 0169

		IntPtr id_getBluetoothAddress;
		public unsafe string BluetoothAddress {
			get {
				if (id_getBluetoothAddress == IntPtr.Zero)
					id_getBluetoothAddress = JNIEnv.GetMethodID (class_ref, "getBluetoothAddress", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBluetoothAddress), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCacheIdentifier;
#pragma warning disable 0169
		static Delegate GetGetCacheIdentifierHandler ()
		{
			if (cb_getCacheIdentifier == null)
				cb_getCacheIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCacheIdentifier);
			return cb_getCacheIdentifier;
		}

		static IntPtr n_GetCacheIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CacheIdentifier);
		}
#pragma warning restore 0169

		IntPtr id_getCacheIdentifier;
		public unsafe string CacheIdentifier {
			get {
				if (id_getCacheIdentifier == IntPtr.Zero)
					id_getCacheIdentifier = JNIEnv.GetMethodID (class_ref, "getCacheIdentifier", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCacheIdentifier), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCachedAt;
#pragma warning disable 0169
		static Delegate GetGetCachedAtHandler ()
		{
			if (cb_getCachedAt == null)
				cb_getCachedAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedAt);
			return cb_getCachedAt;
		}

		static IntPtr n_GetCachedAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CachedAt);
		}
#pragma warning restore 0169

		IntPtr id_getCachedAt;
		public unsafe global::Java.Util.Date CachedAt {
			get {
				if (id_getCachedAt == IntPtr.Zero)
					id_getCachedAt = JNIEnv.GetMethodID (class_ref, "getCachedAt", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedAt), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getEddystone;
#pragma warning disable 0169
		static Delegate GetGetEddystoneHandler ()
		{
			if (cb_getEddystone == null)
				cb_getEddystone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEddystone);
			return cb_getEddystone;
		}

		static IntPtr n_GetEddystone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Eddystone);
		}
#pragma warning restore 0169

		static Delegate cb_setEddystone_Lcom_bluecats_sdk_BCEddystone_;
#pragma warning disable 0169
		static Delegate GetSetEddystone_Lcom_bluecats_sdk_BCEddystone_Handler ()
		{
			if (cb_setEddystone_Lcom_bluecats_sdk_BCEddystone_ == null)
				cb_setEddystone_Lcom_bluecats_sdk_BCEddystone_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEddystone_Lcom_bluecats_sdk_BCEddystone_);
			return cb_setEddystone_Lcom_bluecats_sdk_BCEddystone_;
		}

		static void n_SetEddystone_Lcom_bluecats_sdk_BCEddystone_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCEddystone p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEddystone> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Eddystone = p0;
		}
#pragma warning restore 0169

		IntPtr id_getEddystone;
		IntPtr id_setEddystone_Lcom_bluecats_sdk_BCEddystone_;
		public unsafe global::Com.Bluecats.Sdk.BCEddystone Eddystone {
			get {
				if (id_getEddystone == IntPtr.Zero)
					id_getEddystone = JNIEnv.GetMethodID (class_ref, "getEddystone", "()Lcom/bluecats/sdk/BCEddystone;");
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEddystone> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEddystone), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setEddystone_Lcom_bluecats_sdk_BCEddystone_ == IntPtr.Zero)
					id_setEddystone_Lcom_bluecats_sdk_BCEddystone_ = JNIEnv.GetMethodID (class_ref, "setEddystone", "(Lcom/bluecats/sdk/BCEddystone;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEddystone_Lcom_bluecats_sdk_BCEddystone_, __args);
			}
		}

		static Delegate cb_getFirmwareVersion;
#pragma warning disable 0169
		static Delegate GetGetFirmwareVersionHandler ()
		{
			if (cb_getFirmwareVersion == null)
				cb_getFirmwareVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFirmwareVersion);
			return cb_getFirmwareVersion;
		}

		static IntPtr n_GetFirmwareVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FirmwareVersion);
		}
#pragma warning restore 0169

		IntPtr id_getFirmwareVersion;
		public unsafe string FirmwareVersion {
			get {
				if (id_getFirmwareVersion == IntPtr.Zero)
					id_getFirmwareVersion = JNIEnv.GetMethodID (class_ref, "getFirmwareVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFirmwareVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_hasDiscoveredEddystoneTelemetryFrame;
#pragma warning disable 0169
		static Delegate GetHasDiscoveredEddystoneTelemetryFrameHandler ()
		{
			if (cb_hasDiscoveredEddystoneTelemetryFrame == null)
				cb_hasDiscoveredEddystoneTelemetryFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasDiscoveredEddystoneTelemetryFrame);
			return cb_hasDiscoveredEddystoneTelemetryFrame;
		}

		static bool n_HasDiscoveredEddystoneTelemetryFrame (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasDiscoveredEddystoneTelemetryFrame;
		}
#pragma warning restore 0169

		IntPtr id_hasDiscoveredEddystoneTelemetryFrame;
		public unsafe bool HasDiscoveredEddystoneTelemetryFrame {
			get {
				if (id_hasDiscoveredEddystoneTelemetryFrame == IntPtr.Zero)
					id_hasDiscoveredEddystoneTelemetryFrame = JNIEnv.GetMethodID (class_ref, "hasDiscoveredEddystoneTelemetryFrame", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasDiscoveredEddystoneTelemetryFrame);
			}
		}

		static Delegate cb_hasDiscoveredEddystoneUIDFrame;
#pragma warning disable 0169
		static Delegate GetHasDiscoveredEddystoneUIDFrameHandler ()
		{
			if (cb_hasDiscoveredEddystoneUIDFrame == null)
				cb_hasDiscoveredEddystoneUIDFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasDiscoveredEddystoneUIDFrame);
			return cb_hasDiscoveredEddystoneUIDFrame;
		}

		static bool n_HasDiscoveredEddystoneUIDFrame (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasDiscoveredEddystoneUIDFrame;
		}
#pragma warning restore 0169

		IntPtr id_hasDiscoveredEddystoneUIDFrame;
		public unsafe bool HasDiscoveredEddystoneUIDFrame {
			get {
				if (id_hasDiscoveredEddystoneUIDFrame == IntPtr.Zero)
					id_hasDiscoveredEddystoneUIDFrame = JNIEnv.GetMethodID (class_ref, "hasDiscoveredEddystoneUIDFrame", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasDiscoveredEddystoneUIDFrame);
			}
		}

		static Delegate cb_hasDiscoveredEddystoneURLFrame;
#pragma warning disable 0169
		static Delegate GetHasDiscoveredEddystoneURLFrameHandler ()
		{
			if (cb_hasDiscoveredEddystoneURLFrame == null)
				cb_hasDiscoveredEddystoneURLFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasDiscoveredEddystoneURLFrame);
			return cb_hasDiscoveredEddystoneURLFrame;
		}

		static bool n_HasDiscoveredEddystoneURLFrame (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasDiscoveredEddystoneURLFrame;
		}
#pragma warning restore 0169

		IntPtr id_hasDiscoveredEddystoneURLFrame;
		public unsafe bool HasDiscoveredEddystoneURLFrame {
			get {
				if (id_hasDiscoveredEddystoneURLFrame == IntPtr.Zero)
					id_hasDiscoveredEddystoneURLFrame = JNIEnv.GetMethodID (class_ref, "hasDiscoveredEddystoneURLFrame", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasDiscoveredEddystoneURLFrame);
			}
		}

		static Delegate cb_isBlueCat;
#pragma warning disable 0169
		static Delegate GetIsBlueCatHandler ()
		{
			if (cb_isBlueCat == null)
				cb_isBlueCat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBlueCat);
			return cb_isBlueCat;
		}

		static bool n_IsBlueCat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBlueCat;
		}
#pragma warning restore 0169

		IntPtr id_isBlueCat;
		public unsafe bool IsBlueCat {
			get {
				if (id_isBlueCat == IntPtr.Zero)
					id_isBlueCat = JNIEnv.GetMethodID (class_ref, "isBlueCat", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBlueCat);
			}
		}

		static Delegate cb_isDiscovered;
#pragma warning disable 0169
		static Delegate GetIsDiscoveredHandler ()
		{
			if (cb_isDiscovered == null)
				cb_isDiscovered = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDiscovered);
			return cb_isDiscovered;
		}

		static bool n_IsDiscovered (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDiscovered;
		}
#pragma warning restore 0169

		IntPtr id_isDiscovered;
		public unsafe bool IsDiscovered {
			get {
				if (id_isDiscovered == IntPtr.Zero)
					id_isDiscovered = JNIEnv.GetMethodID (class_ref, "isDiscovered", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDiscovered);
			}
		}

		static Delegate cb_isEddystone;
#pragma warning disable 0169
		static Delegate GetIsEddystoneHandler ()
		{
			if (cb_isEddystone == null)
				cb_isEddystone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEddystone);
			return cb_isEddystone;
		}

		static bool n_IsEddystone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEddystone;
		}
#pragma warning restore 0169

		IntPtr id_isEddystone;
		public unsafe bool IsEddystone {
			get {
				if (id_isEddystone == IntPtr.Zero)
					id_isEddystone = JNIEnv.GetMethodID (class_ref, "isEddystone", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEddystone);
			}
		}

		static Delegate cb_isIBeacon;
#pragma warning disable 0169
		static Delegate GetIsIBeaconHandler ()
		{
			if (cb_isIBeacon == null)
				cb_isIBeacon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsIBeacon);
			return cb_isIBeacon;
		}

		static bool n_IsIBeacon (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIBeacon;
		}
#pragma warning restore 0169

		IntPtr id_isIBeacon;
		public unsafe bool IsIBeacon {
			get {
				if (id_isIBeacon == IntPtr.Zero)
					id_isIBeacon = JNIEnv.GetMethodID (class_ref, "isIBeacon", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isIBeacon);
			}
		}

		static Delegate cb_isNewBorn;
#pragma warning disable 0169
		static Delegate GetIsNewBornHandler ()
		{
			if (cb_isNewBorn == null)
				cb_isNewBorn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNewBorn);
			return cb_isNewBorn;
		}

		static bool n_IsNewBorn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNewBorn;
		}
#pragma warning restore 0169

		IntPtr id_isNewBorn;
		public unsafe bool IsNewBorn {
			get {
				if (id_isNewBorn == IntPtr.Zero)
					id_isNewBorn = JNIEnv.GetMethodID (class_ref, "isNewBorn", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNewBorn);
			}
		}

		static Delegate cb_isSecure;
#pragma warning disable 0169
		static Delegate GetIsSecureHandler ()
		{
			if (cb_isSecure == null)
				cb_isSecure = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSecure);
			return cb_isSecure;
		}

		static bool n_IsSecure (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSecure;
		}
#pragma warning restore 0169

		IntPtr id_isSecure;
		public unsafe bool IsSecure {
			get {
				if (id_isSecure == IntPtr.Zero)
					id_isSecure = JNIEnv.GetMethodID (class_ref, "isSecure", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSecure);
			}
		}

		static Delegate cb_isSyncedOrRestored;
#pragma warning disable 0169
		static Delegate GetIsSyncedOrRestoredHandler ()
		{
			if (cb_isSyncedOrRestored == null)
				cb_isSyncedOrRestored = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSyncedOrRestored);
			return cb_isSyncedOrRestored;
		}

		static bool n_IsSyncedOrRestored (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSyncedOrRestored;
		}
#pragma warning restore 0169

		IntPtr id_isSyncedOrRestored;
		public unsafe bool IsSyncedOrRestored {
			get {
				if (id_isSyncedOrRestored == IntPtr.Zero)
					id_isSyncedOrRestored = JNIEnv.GetMethodID (class_ref, "isSyncedOrRestored", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSyncedOrRestored);
			}
		}

		static Delegate cb_getLastKnownBatteryLevel;
#pragma warning disable 0169
		static Delegate GetGetLastKnownBatteryLevelHandler ()
		{
			if (cb_getLastKnownBatteryLevel == null)
				cb_getLastKnownBatteryLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastKnownBatteryLevel);
			return cb_getLastKnownBatteryLevel;
		}

		static IntPtr n_GetLastKnownBatteryLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastKnownBatteryLevel);
		}
#pragma warning restore 0169

		IntPtr id_getLastKnownBatteryLevel;
		public unsafe global::Java.Lang.Integer LastKnownBatteryLevel {
			get {
				if (id_getLastKnownBatteryLevel == IntPtr.Zero)
					id_getLastKnownBatteryLevel = JNIEnv.GetMethodID (class_ref, "getLastKnownBatteryLevel", "()Ljava/lang/Integer;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastKnownBatteryLevel), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLastRangedAt;
#pragma warning disable 0169
		static Delegate GetGetLastRangedAtHandler ()
		{
			if (cb_getLastRangedAt == null)
				cb_getLastRangedAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastRangedAt);
			return cb_getLastRangedAt;
		}

		static IntPtr n_GetLastRangedAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastRangedAt);
		}
#pragma warning restore 0169

		IntPtr id_getLastRangedAt;
		public unsafe global::Java.Util.Date LastRangedAt {
			get {
				if (id_getLastRangedAt == IntPtr.Zero)
					id_getLastRangedAt = JNIEnv.GetMethodID (class_ref, "getLastRangedAt", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastRangedAt), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLatestFirmwareVersion;
#pragma warning disable 0169
		static Delegate GetGetLatestFirmwareVersionHandler ()
		{
			if (cb_getLatestFirmwareVersion == null)
				cb_getLatestFirmwareVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLatestFirmwareVersion);
			return cb_getLatestFirmwareVersion;
		}

		static IntPtr n_GetLatestFirmwareVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LatestFirmwareVersion);
		}
#pragma warning restore 0169

		IntPtr id_getLatestFirmwareVersion;
		public unsafe string LatestFirmwareVersion {
			get {
				if (id_getLatestFirmwareVersion == IntPtr.Zero)
					id_getLatestFirmwareVersion = JNIEnv.GetMethodID (class_ref, "getLatestFirmwareVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLatestFirmwareVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLocalName;
#pragma warning disable 0169
		static Delegate GetGetLocalNameHandler ()
		{
			if (cb_getLocalName == null)
				cb_getLocalName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocalName);
			return cb_getLocalName;
		}

		static IntPtr n_GetLocalName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocalName);
		}
#pragma warning restore 0169

		IntPtr id_getLocalName;
		public unsafe string LocalName {
			get {
				if (id_getLocalName == IntPtr.Zero)
					id_getLocalName = JNIEnv.GetMethodID (class_ref, "getLocalName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocalName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMajor;
#pragma warning disable 0169
		static Delegate GetGetMajorHandler ()
		{
			if (cb_getMajor == null)
				cb_getMajor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMajor);
			return cb_getMajor;
		}

		static IntPtr n_GetMajor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Major);
		}
#pragma warning restore 0169

		static Delegate cb_setMajor_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetMajor_Ljava_lang_Integer_Handler ()
		{
			if (cb_setMajor_Ljava_lang_Integer_ == null)
				cb_setMajor_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMajor_Ljava_lang_Integer_);
			return cb_setMajor_Ljava_lang_Integer_;
		}

		static void n_SetMajor_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Major = p0;
		}
#pragma warning restore 0169

		IntPtr id_getMajor;
		IntPtr id_setMajor_Ljava_lang_Integer_;
		public unsafe global::Java.Lang.Integer Major {
			get {
				if (id_getMajor == IntPtr.Zero)
					id_getMajor = JNIEnv.GetMethodID (class_ref, "getMajor", "()Ljava/lang/Integer;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMajor), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setMajor_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setMajor_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setMajor", "(Ljava/lang/Integer;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMajor_Ljava_lang_Integer_, __args);
			}
		}

		static Delegate cb_getMapPoint;
#pragma warning disable 0169
		static Delegate GetGetMapPointHandler ()
		{
			if (cb_getMapPoint == null)
				cb_getMapPoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapPoint);
			return cb_getMapPoint;
		}

		static IntPtr n_GetMapPoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MapPoint);
		}
#pragma warning restore 0169

		IntPtr id_getMapPoint;
		public unsafe global::Com.Bluecats.Sdk.BCMapPoint MapPoint {
			get {
				if (id_getMapPoint == IntPtr.Zero)
					id_getMapPoint = JNIEnv.GetMethodID (class_ref, "getMapPoint", "()Lcom/bluecats/sdk/BCMapPoint;");
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMapPoint> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMapPoint), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMeasuredPowerAt1Meter;
#pragma warning disable 0169
		static Delegate GetGetMeasuredPowerAt1MeterHandler ()
		{
			if (cb_getMeasuredPowerAt1Meter == null)
				cb_getMeasuredPowerAt1Meter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMeasuredPowerAt1Meter);
			return cb_getMeasuredPowerAt1Meter;
		}

		static IntPtr n_GetMeasuredPowerAt1Meter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MeasuredPowerAt1Meter);
		}
#pragma warning restore 0169

		static Delegate cb_setMeasuredPowerAt1Meter_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetMeasuredPowerAt1Meter_Ljava_lang_Integer_Handler ()
		{
			if (cb_setMeasuredPowerAt1Meter_Ljava_lang_Integer_ == null)
				cb_setMeasuredPowerAt1Meter_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMeasuredPowerAt1Meter_Ljava_lang_Integer_);
			return cb_setMeasuredPowerAt1Meter_Ljava_lang_Integer_;
		}

		static void n_SetMeasuredPowerAt1Meter_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MeasuredPowerAt1Meter = p0;
		}
#pragma warning restore 0169

		IntPtr id_getMeasuredPowerAt1Meter;
		IntPtr id_setMeasuredPowerAt1Meter_Ljava_lang_Integer_;
		public unsafe global::Java.Lang.Integer MeasuredPowerAt1Meter {
			get {
				if (id_getMeasuredPowerAt1Meter == IntPtr.Zero)
					id_getMeasuredPowerAt1Meter = JNIEnv.GetMethodID (class_ref, "getMeasuredPowerAt1Meter", "()Ljava/lang/Integer;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMeasuredPowerAt1Meter), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setMeasuredPowerAt1Meter_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setMeasuredPowerAt1Meter_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setMeasuredPowerAt1Meter", "(Ljava/lang/Integer;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMeasuredPowerAt1Meter_Ljava_lang_Integer_, __args);
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		IntPtr id_getMessage;
		public unsafe string Message {
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMinor;
#pragma warning disable 0169
		static Delegate GetGetMinorHandler ()
		{
			if (cb_getMinor == null)
				cb_getMinor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMinor);
			return cb_getMinor;
		}

		static IntPtr n_GetMinor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Minor);
		}
#pragma warning restore 0169

		static Delegate cb_setMinor_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetMinor_Ljava_lang_Integer_Handler ()
		{
			if (cb_setMinor_Ljava_lang_Integer_ == null)
				cb_setMinor_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMinor_Ljava_lang_Integer_);
			return cb_setMinor_Ljava_lang_Integer_;
		}

		static void n_SetMinor_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Minor = p0;
		}
#pragma warning restore 0169

		IntPtr id_getMinor;
		IntPtr id_setMinor_Ljava_lang_Integer_;
		public unsafe global::Java.Lang.Integer Minor {
			get {
				if (id_getMinor == IntPtr.Zero)
					id_getMinor = JNIEnv.GetMethodID (class_ref, "getMinor", "()Ljava/lang/Integer;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMinor), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setMinor_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setMinor_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setMinor", "(Ljava/lang/Integer;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMinor_Ljava_lang_Integer_, __args);
			}
		}

		static Delegate cb_getModelNumber;
#pragma warning disable 0169
		static Delegate GetGetModelNumberHandler ()
		{
			if (cb_getModelNumber == null)
				cb_getModelNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetModelNumber);
			return cb_getModelNumber;
		}

		static IntPtr n_GetModelNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ModelNumber);
		}
#pragma warning restore 0169

		IntPtr id_getModelNumber;
		public unsafe string ModelNumber {
			get {
				if (id_getModelNumber == IntPtr.Zero)
					id_getModelNumber = JNIEnv.GetMethodID (class_ref, "getModelNumber", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getModelNumber), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Name = p0;
		}
#pragma warning restore 0169

		IntPtr id_getName;
		IntPtr id_setName_Ljava_lang_String_;
		public unsafe string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
					id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setName_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getPendingVersion;
#pragma warning disable 0169
		static Delegate GetGetPendingVersionHandler ()
		{
			if (cb_getPendingVersion == null)
				cb_getPendingVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPendingVersion);
			return cb_getPendingVersion;
		}

		static IntPtr n_GetPendingVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PendingVersion);
		}
#pragma warning restore 0169

		IntPtr id_getPendingVersion;
		public unsafe string PendingVersion {
			get {
				if (id_getPendingVersion == IntPtr.Zero)
					id_getPendingVersion = JNIEnv.GetMethodID (class_ref, "getPendingVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPendingVersion), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getPrivacyDuration;
#pragma warning disable 0169
		static Delegate GetGetPrivacyDurationHandler ()
		{
			if (cb_getPrivacyDuration == null)
				cb_getPrivacyDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrivacyDuration);
			return cb_getPrivacyDuration;
		}

		static IntPtr n_GetPrivacyDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PrivacyDuration);
		}
#pragma warning restore 0169

		static Delegate cb_setPrivacyDuration_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetPrivacyDuration_Ljava_lang_Integer_Handler ()
		{
			if (cb_setPrivacyDuration_Ljava_lang_Integer_ == null)
				cb_setPrivacyDuration_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPrivacyDuration_Ljava_lang_Integer_);
			return cb_setPrivacyDuration_Ljava_lang_Integer_;
		}

		static void n_SetPrivacyDuration_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PrivacyDuration = p0;
		}
#pragma warning restore 0169

		IntPtr id_getPrivacyDuration;
		IntPtr id_setPrivacyDuration_Ljava_lang_Integer_;
		public unsafe global::Java.Lang.Integer PrivacyDuration {
			get {
				if (id_getPrivacyDuration == IntPtr.Zero)
					id_getPrivacyDuration = JNIEnv.GetMethodID (class_ref, "getPrivacyDuration", "()Ljava/lang/Integer;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrivacyDuration), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setPrivacyDuration_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setPrivacyDuration_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setPrivacyDuration", "(Ljava/lang/Integer;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPrivacyDuration_Ljava_lang_Integer_, __args);
			}
		}

		static Delegate cb_getProximity;
#pragma warning disable 0169
		static Delegate GetGetProximityHandler ()
		{
			if (cb_getProximity == null)
				cb_getProximity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProximity);
			return cb_getProximity;
		}

		static IntPtr n_GetProximity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Proximity);
		}
#pragma warning restore 0169

		static Delegate cb_setProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_;
#pragma warning disable 0169
		static Delegate GetSetProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_Handler ()
		{
			if (cb_setProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ == null)
				cb_setProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_);
			return cb_setProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_;
		}

		static void n_SetProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconBCProximity p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCProximity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Proximity = p0;
		}
#pragma warning restore 0169

		IntPtr id_getProximity;
		IntPtr id_setProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_;
		public unsafe global::Com.Bluecats.Sdk.BCBeaconBCProximity Proximity {
			get {
				if (id_getProximity == IntPtr.Zero)
					id_getProximity = JNIEnv.GetMethodID (class_ref, "getProximity", "()Lcom/bluecats/sdk/BCBeacon$BCProximity;");
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCProximity> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProximity), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ == IntPtr.Zero)
					id_setProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ = JNIEnv.GetMethodID (class_ref, "setProximity", "(Lcom/bluecats/sdk/BCBeacon$BCProximity;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_, __args);
			}
		}

		static Delegate cb_getProximityUUIDString;
#pragma warning disable 0169
		static Delegate GetGetProximityUUIDStringHandler ()
		{
			if (cb_getProximityUUIDString == null)
				cb_getProximityUUIDString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProximityUUIDString);
			return cb_getProximityUUIDString;
		}

		static IntPtr n_GetProximityUUIDString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProximityUUIDString);
		}
#pragma warning restore 0169

		static Delegate cb_setProximityUUIDString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProximityUUIDString_Ljava_lang_String_Handler ()
		{
			if (cb_setProximityUUIDString_Ljava_lang_String_ == null)
				cb_setProximityUUIDString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProximityUUIDString_Ljava_lang_String_);
			return cb_setProximityUUIDString_Ljava_lang_String_;
		}

		static void n_SetProximityUUIDString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProximityUUIDString = p0;
		}
#pragma warning restore 0169

		IntPtr id_getProximityUUIDString;
		IntPtr id_setProximityUUIDString_Ljava_lang_String_;
		public unsafe string ProximityUUIDString {
			get {
				if (id_getProximityUUIDString == IntPtr.Zero)
					id_getProximityUUIDString = JNIEnv.GetMethodID (class_ref, "getProximityUUIDString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProximityUUIDString), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setProximityUUIDString_Ljava_lang_String_ == IntPtr.Zero)
					id_setProximityUUIDString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setProximityUUIDString", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setProximityUUIDString_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getRSSI;
#pragma warning disable 0169
		static Delegate GetGetRSSIHandler ()
		{
			if (cb_getRSSI == null)
				cb_getRSSI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRSSI);
			return cb_getRSSI;
		}

		static IntPtr n_GetRSSI (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RSSI);
		}
#pragma warning restore 0169

		static Delegate cb_setRSSI_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetRSSI_Ljava_lang_Integer_Handler ()
		{
			if (cb_setRSSI_Ljava_lang_Integer_ == null)
				cb_setRSSI_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRSSI_Ljava_lang_Integer_);
			return cb_setRSSI_Ljava_lang_Integer_;
		}

		static void n_SetRSSI_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RSSI = p0;
		}
#pragma warning restore 0169

		IntPtr id_getRSSI;
		IntPtr id_setRSSI_Ljava_lang_Integer_;
		public unsafe global::Java.Lang.Integer RSSI {
			get {
				if (id_getRSSI == IntPtr.Zero)
					id_getRSSI = JNIEnv.GetMethodID (class_ref, "getRSSI", "()Ljava/lang/Integer;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRSSI), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setRSSI_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setRSSI_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setRSSI", "(Ljava/lang/Integer;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRSSI_Ljava_lang_Integer_, __args);
			}
		}

		static Delegate cb_getSerialNumber;
#pragma warning disable 0169
		static Delegate GetGetSerialNumberHandler ()
		{
			if (cb_getSerialNumber == null)
				cb_getSerialNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSerialNumber);
			return cb_getSerialNumber;
		}

		static IntPtr n_GetSerialNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SerialNumber);
		}
#pragma warning restore 0169

		IntPtr id_getSerialNumber;
		public unsafe string SerialNumber {
			get {
				if (id_getSerialNumber == IntPtr.Zero)
					id_getSerialNumber = JNIEnv.GetMethodID (class_ref, "getSerialNumber", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSerialNumber), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSite;
#pragma warning disable 0169
		static Delegate GetGetSiteHandler ()
		{
			if (cb_getSite == null)
				cb_getSite = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSite);
			return cb_getSite;
		}

		static IntPtr n_GetSite (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Site);
		}
#pragma warning restore 0169

		IntPtr id_getSite;
		public unsafe global::Com.Bluecats.Sdk.IBCSite Site {
			get {
				if (id_getSite == IntPtr.Zero)
					id_getSite = JNIEnv.GetMethodID (class_ref, "getSite", "()Lcom/bluecats/sdk/BCSite;");
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSite), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSiteID;
#pragma warning disable 0169
		static Delegate GetGetSiteIDHandler ()
		{
			if (cb_getSiteID == null)
				cb_getSiteID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSiteID);
			return cb_getSiteID;
		}

		static IntPtr n_GetSiteID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SiteID);
		}
#pragma warning restore 0169

		IntPtr id_getSiteID;
		public unsafe string SiteID {
			get {
				if (id_getSiteID == IntPtr.Zero)
					id_getSiteID = JNIEnv.GetMethodID (class_ref, "getSiteID", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSiteID), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSiteName;
#pragma warning disable 0169
		static Delegate GetGetSiteNameHandler ()
		{
			if (cb_getSiteName == null)
				cb_getSiteName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSiteName);
			return cb_getSiteName;
		}

		static IntPtr n_GetSiteName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SiteName);
		}
#pragma warning restore 0169

		IntPtr id_getSiteName;
		public unsafe string SiteName {
			get {
				if (id_getSiteName == IntPtr.Zero)
					id_getSiteName = JNIEnv.GetMethodID (class_ref, "getSiteName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSiteName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSyncStatus;
#pragma warning disable 0169
		static Delegate GetGetSyncStatusHandler ()
		{
			if (cb_getSyncStatus == null)
				cb_getSyncStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSyncStatus);
			return cb_getSyncStatus;
		}

		static IntPtr n_GetSyncStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SyncStatus);
		}
#pragma warning restore 0169

		IntPtr id_getSyncStatus;
		public unsafe global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus SyncStatus {
			get {
				if (id_getSyncStatus == IntPtr.Zero)
					id_getSyncStatus = JNIEnv.GetMethodID (class_ref, "getSyncStatus", "()Lcom/bluecats/sdk/BCBeacon$BCSyncStatus;");
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSyncStatus), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSyncedAt;
#pragma warning disable 0169
		static Delegate GetGetSyncedAtHandler ()
		{
			if (cb_getSyncedAt == null)
				cb_getSyncedAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSyncedAt);
			return cb_getSyncedAt;
		}

		static IntPtr n_GetSyncedAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SyncedAt);
		}
#pragma warning restore 0169

		IntPtr id_getSyncedAt;
		public unsafe global::Java.Util.Date SyncedAt {
			get {
				if (id_getSyncedAt == IntPtr.Zero)
					id_getSyncedAt = JNIEnv.GetMethodID (class_ref, "getSyncedAt", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSyncedAt), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTargetSpeed;
#pragma warning disable 0169
		static Delegate GetGetTargetSpeedHandler ()
		{
			if (cb_getTargetSpeed == null)
				cb_getTargetSpeed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTargetSpeed);
			return cb_getTargetSpeed;
		}

		static IntPtr n_GetTargetSpeed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TargetSpeed);
		}
#pragma warning restore 0169

		static Delegate cb_setTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_;
#pragma warning disable 0169
		static Delegate GetSetTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_Handler ()
		{
			if (cb_setTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_ == null)
				cb_setTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_);
			return cb_setTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_;
		}

		static void n_SetTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCTargetSpeed p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTargetSpeed> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TargetSpeed = p0;
		}
#pragma warning restore 0169

		IntPtr id_getTargetSpeed;
		IntPtr id_setTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_;
		public unsafe global::Com.Bluecats.Sdk.BCTargetSpeed TargetSpeed {
			get {
				if (id_getTargetSpeed == IntPtr.Zero)
					id_getTargetSpeed = JNIEnv.GetMethodID (class_ref, "getTargetSpeed", "()Lcom/bluecats/sdk/BCTargetSpeed;");
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTargetSpeed> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTargetSpeed), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_ == IntPtr.Zero)
					id_setTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_ = JNIEnv.GetMethodID (class_ref, "setTargetSpeed", "(Lcom/bluecats/sdk/BCTargetSpeed;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_, __args);
			}
		}

		static Delegate cb_getTeamID;
#pragma warning disable 0169
		static Delegate GetGetTeamIDHandler ()
		{
			if (cb_getTeamID == null)
				cb_getTeamID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTeamID);
			return cb_getTeamID;
		}

		static IntPtr n_GetTeamID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TeamID);
		}
#pragma warning restore 0169

		IntPtr id_getTeamID;
		public unsafe string TeamID {
			get {
				if (id_getTeamID == IntPtr.Zero)
					id_getTeamID = JNIEnv.GetMethodID (class_ref, "getTeamID", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTeamID), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUptime;
#pragma warning disable 0169
		static Delegate GetGetUptimeHandler ()
		{
			if (cb_getUptime == null)
				cb_getUptime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUptime);
			return cb_getUptime;
		}

		static IntPtr n_GetUptime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Uptime);
		}
#pragma warning restore 0169

		IntPtr id_getUptime;
		public unsafe string Uptime {
			get {
				if (id_getUptime == IntPtr.Zero)
					id_getUptime = JNIEnv.GetMethodID (class_ref, "getUptime", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUptime), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getVerificationStatus;
#pragma warning disable 0169
		static Delegate GetGetVerificationStatusHandler ()
		{
			if (cb_getVerificationStatus == null)
				cb_getVerificationStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVerificationStatus);
			return cb_getVerificationStatus;
		}

		static IntPtr n_GetVerificationStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VerificationStatus);
		}
#pragma warning restore 0169

		IntPtr id_getVerificationStatus;
		public unsafe global::Com.Bluecats.Sdk.BCBeaconBCVerificationStatus VerificationStatus {
			get {
				if (id_getVerificationStatus == IntPtr.Zero)
					id_getVerificationStatus = JNIEnv.GetMethodID (class_ref, "getVerificationStatus", "()Lcom/bluecats/sdk/BCBeacon$BCVerificationStatus;");
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCVerificationStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVerificationStatus), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getVerifiedAt;
#pragma warning disable 0169
		static Delegate GetGetVerifiedAtHandler ()
		{
			if (cb_getVerifiedAt == null)
				cb_getVerifiedAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVerifiedAt);
			return cb_getVerifiedAt;
		}

		static IntPtr n_GetVerifiedAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VerifiedAt);
		}
#pragma warning restore 0169

		IntPtr id_getVerifiedAt;
		public unsafe global::Java.Util.Date VerifiedAt {
			get {
				if (id_getVerifiedAt == IntPtr.Zero)
					id_getVerifiedAt = JNIEnv.GetMethodID (class_ref, "getVerifiedAt", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVerifiedAt), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersion);
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		static Delegate cb_setVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setVersion_Ljava_lang_String_ == null)
				cb_setVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVersion_Ljava_lang_String_);
			return cb_setVersion_Ljava_lang_String_;
		}

		static void n_SetVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Version = p0;
		}
#pragma warning restore 0169

		IntPtr id_getVersion;
		IntPtr id_setVersion_Ljava_lang_String_;
		public unsafe string Version {
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVersion), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setVersion_Ljava_lang_String_ == IntPtr.Zero)
					id_setVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setVersion", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVersion_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getWireframeURLString;
#pragma warning disable 0169
		static Delegate GetGetWireframeURLStringHandler ()
		{
			if (cb_getWireframeURLString == null)
				cb_getWireframeURLString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWireframeURLString);
			return cb_getWireframeURLString;
		}

		static IntPtr n_GetWireframeURLString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.WireframeURLString);
		}
#pragma warning restore 0169

		IntPtr id_getWireframeURLString;
		public unsafe string WireframeURLString {
			get {
				if (id_getWireframeURLString == IntPtr.Zero)
					id_getWireframeURLString = JNIEnv.GetMethodID (class_ref, "getWireframeURLString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getWireframeURLString), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_copy;
#pragma warning disable 0169
		static Delegate GetCopyHandler ()
		{
			if (cb_copy == null)
				cb_copy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Copy);
			return cb_copy;
		}

		static IntPtr n_Copy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Copy ());
		}
#pragma warning restore 0169

		IntPtr id_copy;
		public unsafe global::Com.Bluecats.Sdk.IBCBeacon Copy ()
		{
			if (id_copy == IntPtr.Zero)
				id_copy = JNIEnv.GetMethodID (class_ref, "copy", "()Lcom/bluecats/sdk/BCBeacon;");
			return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_copy), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_copyApiPropertiesFromBeacon_Lcom_bluecats_sdk_BCBeacon_;
#pragma warning disable 0169
		static Delegate GetCopyApiPropertiesFromBeacon_Lcom_bluecats_sdk_BCBeacon_Handler ()
		{
			if (cb_copyApiPropertiesFromBeacon_Lcom_bluecats_sdk_BCBeacon_ == null)
				cb_copyApiPropertiesFromBeacon_Lcom_bluecats_sdk_BCBeacon_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CopyApiPropertiesFromBeacon_Lcom_bluecats_sdk_BCBeacon_);
			return cb_copyApiPropertiesFromBeacon_Lcom_bluecats_sdk_BCBeacon_;
		}

		static void n_CopyApiPropertiesFromBeacon_Lcom_bluecats_sdk_BCBeacon_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeacon p0 = (global::Com.Bluecats.Sdk.IBCBeacon)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CopyApiPropertiesFromBeacon (p0);
		}
#pragma warning restore 0169

		IntPtr id_copyApiPropertiesFromBeacon_Lcom_bluecats_sdk_BCBeacon_;
		public unsafe void CopyApiPropertiesFromBeacon (global::Com.Bluecats.Sdk.IBCBeacon p0)
		{
			if (id_copyApiPropertiesFromBeacon_Lcom_bluecats_sdk_BCBeacon_ == IntPtr.Zero)
				id_copyApiPropertiesFromBeacon_Lcom_bluecats_sdk_BCBeacon_ = JNIEnv.GetMethodID (class_ref, "copyApiPropertiesFromBeacon", "(Lcom/bluecats/sdk/BCBeacon;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_copyApiPropertiesFromBeacon_Lcom_bluecats_sdk_BCBeacon_, __args);
		}

		static Delegate cb_getBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_Handler ()
		{
			if (cb_getBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ == null)
				cb_getBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_);
			return cb_getBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_;
		}

		static void n_GetBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeaconCallback p0 = (global::Com.Bluecats.Sdk.IBCBeaconCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetBeaconLoudnessesFromApi (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_;
		public unsafe void GetBeaconLoudnessesFromApi (global::Com.Bluecats.Sdk.IBCBeaconCallback p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_getBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ == IntPtr.Zero)
				id_getBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getBeaconLoudnessesFromApi", "(Lcom/bluecats/sdk/BCBeaconCallback;Ljava/util/Map;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_Handler ()
		{
			if (cb_getBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ == null)
				cb_getBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_);
			return cb_getBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_;
		}

		static void n_GetBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeaconCallback p0 = (global::Com.Bluecats.Sdk.IBCBeaconCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetBeaconModesFromApi (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_;
		public unsafe void GetBeaconModesFromApi (global::Com.Bluecats.Sdk.IBCBeaconCallback p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_getBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ == IntPtr.Zero)
				id_getBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getBeaconModesFromApi", "(Lcom/bluecats/sdk/BCBeaconCallback;Ljava/util/Map;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_;
#pragma warning disable 0169
		static Delegate GetGetBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Handler ()
		{
			if (cb_getBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_ == null)
				cb_getBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_);
			return cb_getBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_;
		}

		static void n_GetBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeaconCallback p0 = (global::Com.Bluecats.Sdk.IBCBeaconCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetBeaconRegionsInTeamFromApi (p0);
		}
#pragma warning restore 0169

		IntPtr id_getBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_;
		public unsafe void GetBeaconRegionsInTeamFromApi (global::Com.Bluecats.Sdk.IBCBeaconCallback p0)
		{
			if (id_getBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_ == IntPtr.Zero)
				id_getBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_ = JNIEnv.GetMethodID (class_ref, "getBeaconRegionsInTeamFromApi", "(Lcom/bluecats/sdk/BCBeaconCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_, __args);
		}

		static Delegate cb_getBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_Handler ()
		{
			if (cb_getBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ == null)
				cb_getBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_);
			return cb_getBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_;
		}

		static void n_GetBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeaconCallback p0 = (global::Com.Bluecats.Sdk.IBCBeaconCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetBeaconTargetSpeedsFromApi (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_;
		public unsafe void GetBeaconTargetSpeedsFromApi (global::Com.Bluecats.Sdk.IBCBeaconCallback p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_getBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ == IntPtr.Zero)
				id_getBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getBeaconTargetSpeedsFromApi", "(Lcom/bluecats/sdk/BCBeaconCallback;Ljava/util/Map;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_;
#pragma warning disable 0169
		static Delegate GetGetBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_Handler ()
		{
			if (cb_getBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_ == null)
				cb_getBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_);
			return cb_getBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_;
		}

		static void n_GetBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeaconCallback p1 = (global::Com.Bluecats.Sdk.IBCBeaconCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetBeaconVersion (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_;
		public unsafe void GetBeaconVersion (global::Java.Lang.Integer p0, global::Com.Bluecats.Sdk.IBCBeaconCallback p1)
		{
			if (id_getBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_ == IntPtr.Zero)
				id_getBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_ = JNIEnv.GetMethodID (class_ref, "getBeaconVersion", "(Ljava/lang/Integer;Lcom/bluecats/sdk/BCBeaconCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_, __args);
		}

		static Delegate cb_getCategories;
#pragma warning disable 0169
		static Delegate GetGetCategoriesHandler ()
		{
			if (cb_getCategories == null)
				cb_getCategories = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCategories);
			return cb_getCategories;
		}

		static IntPtr n_GetCategories (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCategories ());
		}
#pragma warning restore 0169

		IntPtr id_getCategories;
		public unsafe global::Com.Bluecats.Sdk.BCCategory[] GetCategories ()
		{
			if (id_getCategories == IntPtr.Zero)
				id_getCategories = JNIEnv.GetMethodID (class_ref, "getCategories", "()[Lcom/bluecats/sdk/BCCategory;");
			return (global::Com.Bluecats.Sdk.BCCategory[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCategories), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCCategory));
		}

		static Delegate cb_getCustomValues;
#pragma warning disable 0169
		static Delegate GetGetCustomValuesHandler ()
		{
			if (cb_getCustomValues == null)
				cb_getCustomValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomValues);
			return cb_getCustomValues;
		}

		static IntPtr n_GetCustomValues (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCustomValues ());
		}
#pragma warning restore 0169

		IntPtr id_getCustomValues;
		public unsafe global::Com.Bluecats.Sdk.BCCustomValue[] GetCustomValues ()
		{
			if (id_getCustomValues == IntPtr.Zero)
				id_getCustomValues = JNIEnv.GetMethodID (class_ref, "getCustomValues", "()[Lcom/bluecats/sdk/BCCustomValue;");
			return (global::Com.Bluecats.Sdk.BCCustomValue[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCustomValues), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCCustomValue));
		}

		static Delegate cb_getLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_;
#pragma warning disable 0169
		static Delegate GetGetLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_Handler ()
		{
			if (cb_getLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ == null)
				cb_getLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_);
			return cb_getLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_;
		}

		static void n_GetLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeaconCallback p0 = (global::Com.Bluecats.Sdk.IBCBeaconCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetLatestBeacon (p0);
		}
#pragma warning restore 0169

		IntPtr id_getLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_;
		public unsafe void GetLatestBeacon (global::Com.Bluecats.Sdk.IBCBeaconCallback p0)
		{
			if (id_getLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ == IntPtr.Zero)
				id_getLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ = JNIEnv.GetMethodID (class_ref, "getLatestBeacon", "(Lcom/bluecats/sdk/BCBeaconCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_, __args);
		}

		static Delegate cb_getLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_;
#pragma warning disable 0169
		static Delegate GetGetLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_Handler ()
		{
			if (cb_getLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_ == null)
				cb_getLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_);
			return cb_getLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_;
		}

		static void n_GetLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeaconCallback p0 = (global::Com.Bluecats.Sdk.IBCBeaconCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetLatestBeaconVersion (p0);
		}
#pragma warning restore 0169

		IntPtr id_getLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_;
		public unsafe void GetLatestBeaconVersion (global::Com.Bluecats.Sdk.IBCBeaconCallback p0)
		{
			if (id_getLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_ == IntPtr.Zero)
				id_getLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_ = JNIEnv.GetMethodID (class_ref, "getLatestBeaconVersion", "(Lcom/bluecats/sdk/BCBeaconCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_, __args);
		}

		static Delegate cb_moveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_;
#pragma warning disable 0169
		static Delegate GetMoveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_Handler ()
		{
			if (cb_moveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_ == null)
				cb_moveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_MoveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_);
			return cb_moveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_;
		}

		static void n_MoveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2, IntPtr native_p3)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCTeam p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite p1 = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeaconCallback p3 = (global::Com.Bluecats.Sdk.IBCBeaconCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.MoveBeaconToTeam (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_moveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_;
		public unsafe void MoveBeaconToTeam (global::Com.Bluecats.Sdk.BCTeam p0, global::Com.Bluecats.Sdk.IBCSite p1, bool p2, global::Com.Bluecats.Sdk.IBCBeaconCallback p3)
		{
			if (id_moveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_ == IntPtr.Zero)
				id_moveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_ = JNIEnv.GetMethodID (class_ref, "moveBeaconToTeam", "(Lcom/bluecats/sdk/BCTeam;Lcom/bluecats/sdk/BCSite;ZLcom/bluecats/sdk/BCBeaconCallback;)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_moveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_, __args);
		}

		static Delegate cb_refreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_;
#pragma warning disable 0169
		static Delegate GetRefreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_Handler ()
		{
			if (cb_refreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ == null)
				cb_refreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RefreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_);
			return cb_refreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_;
		}

		static void n_RefreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeaconCallback p0 = (global::Com.Bluecats.Sdk.IBCBeaconCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RefreshBeacon (p0);
		}
#pragma warning restore 0169

		IntPtr id_refreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_;
		public unsafe void RefreshBeacon (global::Com.Bluecats.Sdk.IBCBeaconCallback p0)
		{
			if (id_refreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ == IntPtr.Zero)
				id_refreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ = JNIEnv.GetMethodID (class_ref, "refreshBeacon", "(Lcom/bluecats/sdk/BCBeaconCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_refreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_, __args);
		}

		static Delegate cb_setCategories_arrayLcom_bluecats_sdk_BCCategory_;
#pragma warning disable 0169
		static Delegate GetSetCategories_arrayLcom_bluecats_sdk_BCCategory_Handler ()
		{
			if (cb_setCategories_arrayLcom_bluecats_sdk_BCCategory_ == null)
				cb_setCategories_arrayLcom_bluecats_sdk_BCCategory_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCategories_arrayLcom_bluecats_sdk_BCCategory_);
			return cb_setCategories_arrayLcom_bluecats_sdk_BCCategory_;
		}

		static void n_SetCategories_arrayLcom_bluecats_sdk_BCCategory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCCategory[] p0 = (global::Com.Bluecats.Sdk.BCCategory[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Bluecats.Sdk.BCCategory));
			__this.SetCategories (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_setCategories_arrayLcom_bluecats_sdk_BCCategory_;
		public unsafe void SetCategories (global::Com.Bluecats.Sdk.BCCategory[] p0)
		{
			if (id_setCategories_arrayLcom_bluecats_sdk_BCCategory_ == IntPtr.Zero)
				id_setCategories_arrayLcom_bluecats_sdk_BCCategory_ = JNIEnv.GetMethodID (class_ref, "setCategories", "([Lcom/bluecats/sdk/BCCategory;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCategories_arrayLcom_bluecats_sdk_BCCategory_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_;
#pragma warning disable 0169
		static Delegate GetSetCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_Handler ()
		{
			if (cb_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_ == null)
				cb_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_);
			return cb_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_;
		}

		static void n_SetCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCCustomValue[] p0 = (global::Com.Bluecats.Sdk.BCCustomValue[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Bluecats.Sdk.BCCustomValue));
			__this.SetCustomValues (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_;
		public unsafe void SetCustomValues (global::Com.Bluecats.Sdk.BCCustomValue[] p0)
		{
			if (id_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_ == IntPtr.Zero)
				id_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_ = JNIEnv.GetMethodID (class_ref, "setCustomValues", "([Lcom/bluecats/sdk/BCCustomValue;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateBeacon_Lcom_bluecats_sdk_BCBeacon_Lcom_bluecats_sdk_BCBeaconCallback_;
#pragma warning disable 0169
		static Delegate GetUpdateBeacon_Lcom_bluecats_sdk_BCBeacon_Lcom_bluecats_sdk_BCBeaconCallback_Handler ()
		{
			if (cb_updateBeacon_Lcom_bluecats_sdk_BCBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ == null)
				cb_updateBeacon_Lcom_bluecats_sdk_BCBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateBeacon_Lcom_bluecats_sdk_BCBeacon_Lcom_bluecats_sdk_BCBeaconCallback_);
			return cb_updateBeacon_Lcom_bluecats_sdk_BCBeacon_Lcom_bluecats_sdk_BCBeaconCallback_;
		}

		static void n_UpdateBeacon_Lcom_bluecats_sdk_BCBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeacon p0 = (global::Com.Bluecats.Sdk.IBCBeacon)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeaconCallback p1 = (global::Com.Bluecats.Sdk.IBCBeaconCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateBeacon (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_updateBeacon_Lcom_bluecats_sdk_BCBeacon_Lcom_bluecats_sdk_BCBeaconCallback_;
		public unsafe void UpdateBeacon (global::Com.Bluecats.Sdk.IBCBeacon p0, global::Com.Bluecats.Sdk.IBCBeaconCallback p1)
		{
			if (id_updateBeacon_Lcom_bluecats_sdk_BCBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ == IntPtr.Zero)
				id_updateBeacon_Lcom_bluecats_sdk_BCBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ = JNIEnv.GetMethodID (class_ref, "updateBeacon", "(Lcom/bluecats/sdk/BCBeacon;Lcom/bluecats/sdk/BCBeaconCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateBeacon_Lcom_bluecats_sdk_BCBeacon_Lcom_bluecats_sdk_BCBeaconCallback_, __args);
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		IntPtr id_describeContents;
		public unsafe global::System.Int32 DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.Bluecats.Sdk.IBCBeacon __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		public unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (dest);
			__args [1] = new JValue ((int) flags);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
		}

	}

}
