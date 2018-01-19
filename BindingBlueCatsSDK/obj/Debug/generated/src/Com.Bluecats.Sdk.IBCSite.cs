using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSite.BCSiteState']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCSite$BCSiteState", DoNotGenerateAcw=true)]
	public sealed partial class BCSiteBCSiteState : global::Java.Lang.Enum {


		static IntPtr BC_SITE_STATE_INSIDE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSite.BCSiteState']/field[@name='BC_SITE_STATE_INSIDE']"
		[Register ("BC_SITE_STATE_INSIDE")]
		public static global::Com.Bluecats.Sdk.BCSiteBCSiteState BcSiteStateInside {
			get {
				if (BC_SITE_STATE_INSIDE_jfieldId == IntPtr.Zero)
					BC_SITE_STATE_INSIDE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_SITE_STATE_INSIDE", "Lcom/bluecats/sdk/BCSite$BCSiteState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_SITE_STATE_INSIDE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteBCSiteState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BC_SITE_STATE_OUTSIDE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSite.BCSiteState']/field[@name='BC_SITE_STATE_OUTSIDE']"
		[Register ("BC_SITE_STATE_OUTSIDE")]
		public static global::Com.Bluecats.Sdk.BCSiteBCSiteState BcSiteStateOutside {
			get {
				if (BC_SITE_STATE_OUTSIDE_jfieldId == IntPtr.Zero)
					BC_SITE_STATE_OUTSIDE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_SITE_STATE_OUTSIDE", "Lcom/bluecats/sdk/BCSite$BCSiteState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_SITE_STATE_OUTSIDE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteBCSiteState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BC_SITE_STATE_UNKNOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSite.BCSiteState']/field[@name='BC_SITE_STATE_UNKNOWN']"
		[Register ("BC_SITE_STATE_UNKNOWN")]
		public static global::Com.Bluecats.Sdk.BCSiteBCSiteState BcSiteStateUnknown {
			get {
				if (BC_SITE_STATE_UNKNOWN_jfieldId == IntPtr.Zero)
					BC_SITE_STATE_UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_SITE_STATE_UNKNOWN", "Lcom/bluecats/sdk/BCSite$BCSiteState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_SITE_STATE_UNKNOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteBCSiteState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCSite$BCSiteState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCSiteBCSiteState); }
		}

		internal BCSiteBCSiteState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDisplayName_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSite.BCSiteState']/method[@name='getDisplayName' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSite.BCSiteState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCSite$BCSiteState;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCSiteBCSiteState ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCSite$BCSiteState;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::Com.Bluecats.Sdk.BCSiteBCSiteState __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteBCSiteState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSite.BCSiteState']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/bluecats/sdk/BCSite$BCSiteState;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCSiteBCSiteState[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bluecats/sdk/BCSite$BCSiteState;");
			try {
				return (global::Com.Bluecats.Sdk.BCSiteBCSiteState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCSiteBCSiteState));
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']"
	[Register ("com/bluecats/sdk/BCSite", "", "Com.Bluecats.Sdk.IBCSiteInvoker")]
	public partial interface IBCSite : global::Android.OS.IParcelable {

		global::Com.Bluecats.Sdk.BCAddress Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='getAddress' and count(parameter)=0]"
			[Register ("getAddress", "()Lcom/bluecats/sdk/BCAddress;", "GetGetAddressHandler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='setAddress' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCAddress']]"
			[Register ("setAddress", "(Lcom/bluecats/sdk/BCAddress;)V", "GetSetAddress_Lcom_bluecats_sdk_BCAddress_Handler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")] set;
		}

		int BeaconCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='getBeaconCount' and count(parameter)=0]"
			[Register ("getBeaconCount", "()I", "GetGetBeaconCountHandler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='setBeaconCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBeaconCount", "(I)V", "GetSetBeaconCount_IHandler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")] set;
		}

		global::Java.Util.Date CachedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='getCachedAt' and count(parameter)=0]"
			[Register ("getCachedAt", "()Ljava/util/Date;", "GetGetCachedAtHandler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")] get;
		}

		global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> CachedBeacons {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='getCachedBeacons' and count(parameter)=0]"
			[Register ("getCachedBeacons", "()Ljava/util/List;", "GetGetCachedBeaconsHandler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")] get;
		}

		global::Java.Util.Date CreatedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='getCreatedAt' and count(parameter)=0]"
			[Register ("getCreatedAt", "()Ljava/util/Date;", "GetGetCreatedAtHandler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")] get;
		}

		bool IsSyncedOrRestored {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='isSyncedOrRestored' and count(parameter)=0]"
			[Register ("isSyncedOrRestored", "()Z", "GetIsSyncedOrRestoredHandler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")] get;
		}

		global::Android.Locations.Location Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Landroid/location/Location;", "GetGetLocationHandler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")] get;
		}

		global::Java.Util.Date ModifiedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='getModifiedAt' and count(parameter)=0]"
			[Register ("getModifiedAt", "()Ljava/util/Date;", "GetGetModifiedAtHandler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")] get;
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")] set;
		}

		string Notes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='getNotes' and count(parameter)=0]"
			[Register ("getNotes", "()Ljava/lang/String;", "GetGetNotesHandler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='setNotes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNotes", "(Ljava/lang/String;)V", "GetSetNotes_Ljava_lang_String_Handler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")] set;
		}

		global::Com.Bluecats.Sdk.BCSiteAccessType SiteAccessType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='getSiteAccessType' and count(parameter)=0]"
			[Register ("getSiteAccessType", "()Lcom/bluecats/sdk/BCSiteAccessType;", "GetGetSiteAccessTypeHandler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='setSiteAccessType' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCSiteAccessType']]"
			[Register ("setSiteAccessType", "(Lcom/bluecats/sdk/BCSiteAccessType;)V", "GetSetSiteAccessType_Lcom_bluecats_sdk_BCSiteAccessType_Handler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")] set;
		}

		string SiteID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='getSiteID' and count(parameter)=0]"
			[Register ("getSiteID", "()Ljava/lang/String;", "GetGetSiteIDHandler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='setSiteID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSiteID", "(Ljava/lang/String;)V", "GetSetSiteID_Ljava_lang_String_Handler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")] set;
		}

		global::Com.Bluecats.Sdk.BCBeaconBCSyncStatus SyncStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='getSyncStatus' and count(parameter)=0]"
			[Register ("getSyncStatus", "()Lcom/bluecats/sdk/BCBeacon$BCSyncStatus;", "GetGetSyncStatusHandler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")] get;
		}

		global::Java.Util.Date SyncedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='getSyncedAt' and count(parameter)=0]"
			[Register ("getSyncedAt", "()Ljava/util/Date;", "GetGetSyncedAtHandler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")] get;
		}

		string TeamID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='getTeamID' and count(parameter)=0]"
			[Register ("getTeamID", "()Ljava/lang/String;", "GetGetTeamIDHandler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='setTeamID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTeamID", "(Ljava/lang/String;)V", "GetSetTeamID_Ljava_lang_String_Handler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='copy' and count(parameter)=0]"
		[Register ("copy", "()Lcom/bluecats/sdk/BCSite;", "GetCopyHandler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")]
		global::Com.Bluecats.Sdk.IBCSite Copy ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='getBeacons' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.bluecats.sdk.BCSiteCallback']]"
		[Register ("getBeacons", "(ZLcom/bluecats/sdk/BCSiteCallback;)V", "GetGetBeacons_ZLcom_bluecats_sdk_BCSiteCallback_Handler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")]
		void GetBeacons (bool p0, global::Com.Bluecats.Sdk.IBCSiteCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='getCategories' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.bluecats.sdk.BCSiteCallback']]"
		[Register ("getCategories", "(ZLcom/bluecats/sdk/BCSiteCallback;)V", "GetGetCategories_ZLcom_bluecats_sdk_BCSiteCallback_Handler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")]
		void GetCategories (bool p0, global::Com.Bluecats.Sdk.IBCSiteCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='getCustomValues' and count(parameter)=0]"
		[Register ("getCustomValues", "()[Lcom/bluecats/sdk/BCCustomValue;", "GetGetCustomValuesHandler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")]
		global::Com.Bluecats.Sdk.BCCustomValue[] GetCustomValues ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='getMaps' and count(parameter)=0]"
		[Register ("getMaps", "()[Lcom/bluecats/sdk/BCMap;", "GetGetMapsHandler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")]
		global::Com.Bluecats.Sdk.BCMap[] GetMaps ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='setCustomValues' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCCustomValue[]']]"
		[Register ("setCustomValues", "([Lcom/bluecats/sdk/BCCustomValue;)V", "GetSetCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_Handler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")]
		void SetCustomValues (global::Com.Bluecats.Sdk.BCCustomValue[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSite']/method[@name='updateSite' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCSite'] and parameter[2][@type='com.bluecats.sdk.BCSiteCallback']]"
		[Register ("updateSite", "(Lcom/bluecats/sdk/BCSite;Lcom/bluecats/sdk/BCSiteCallback;)V", "GetUpdateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_Handler:Com.Bluecats.Sdk.IBCSiteInvoker, BindingBlueCatsSDK")]
		void UpdateSite (global::Com.Bluecats.Sdk.IBCSite p0, global::Com.Bluecats.Sdk.IBCSiteCallback p1);

	}

	[global::Android.Runtime.Register ("com/bluecats/sdk/BCSite", DoNotGenerateAcw=true)]
	internal class IBCSiteInvoker : global::Java.Lang.Object, IBCSite {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bluecats/sdk/BCSite");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBCSiteInvoker); }
		}

		IntPtr class_ref;

		public static IBCSite GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBCSite> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bluecats.sdk.BCSite"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBCSiteInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAddress;
#pragma warning disable 0169
		static Delegate GetGetAddressHandler ()
		{
			if (cb_getAddress == null)
				cb_getAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddress);
			return cb_getAddress;
		}

		static IntPtr n_GetAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Address);
		}
#pragma warning restore 0169

		static Delegate cb_setAddress_Lcom_bluecats_sdk_BCAddress_;
#pragma warning disable 0169
		static Delegate GetSetAddress_Lcom_bluecats_sdk_BCAddress_Handler ()
		{
			if (cb_setAddress_Lcom_bluecats_sdk_BCAddress_ == null)
				cb_setAddress_Lcom_bluecats_sdk_BCAddress_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAddress_Lcom_bluecats_sdk_BCAddress_);
			return cb_setAddress_Lcom_bluecats_sdk_BCAddress_;
		}

		static void n_SetAddress_Lcom_bluecats_sdk_BCAddress_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCAddress p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Address = p0;
		}
#pragma warning restore 0169

		IntPtr id_getAddress;
		IntPtr id_setAddress_Lcom_bluecats_sdk_BCAddress_;
		public unsafe global::Com.Bluecats.Sdk.BCAddress Address {
			get {
				if (id_getAddress == IntPtr.Zero)
					id_getAddress = JNIEnv.GetMethodID (class_ref, "getAddress", "()Lcom/bluecats/sdk/BCAddress;");
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAddress), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setAddress_Lcom_bluecats_sdk_BCAddress_ == IntPtr.Zero)
					id_setAddress_Lcom_bluecats_sdk_BCAddress_ = JNIEnv.GetMethodID (class_ref, "setAddress", "(Lcom/bluecats/sdk/BCAddress;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAddress_Lcom_bluecats_sdk_BCAddress_, __args);
			}
		}

		static Delegate cb_getBeaconCount;
#pragma warning disable 0169
		static Delegate GetGetBeaconCountHandler ()
		{
			if (cb_getBeaconCount == null)
				cb_getBeaconCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBeaconCount);
			return cb_getBeaconCount;
		}

		static int n_GetBeaconCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BeaconCount;
		}
#pragma warning restore 0169

		static Delegate cb_setBeaconCount_I;
#pragma warning disable 0169
		static Delegate GetSetBeaconCount_IHandler ()
		{
			if (cb_setBeaconCount_I == null)
				cb_setBeaconCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBeaconCount_I);
			return cb_setBeaconCount_I;
		}

		static void n_SetBeaconCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BeaconCount = p0;
		}
#pragma warning restore 0169

		IntPtr id_getBeaconCount;
		IntPtr id_setBeaconCount_I;
		public unsafe int BeaconCount {
			get {
				if (id_getBeaconCount == IntPtr.Zero)
					id_getBeaconCount = JNIEnv.GetMethodID (class_ref, "getBeaconCount", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconCount);
			}
			set {
				if (id_setBeaconCount_I == IntPtr.Zero)
					id_setBeaconCount_I = JNIEnv.GetMethodID (class_ref, "setBeaconCount", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeaconCount_I, __args);
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
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getCachedBeacons;
#pragma warning disable 0169
		static Delegate GetGetCachedBeaconsHandler ()
		{
			if (cb_getCachedBeacons == null)
				cb_getCachedBeacons = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedBeacons);
			return cb_getCachedBeacons;
		}

		static IntPtr n_GetCachedBeacons (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.ToLocalJniHandle (__this.CachedBeacons);
		}
#pragma warning restore 0169

		IntPtr id_getCachedBeacons;
		public unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> CachedBeacons {
			get {
				if (id_getCachedBeacons == IntPtr.Zero)
					id_getCachedBeacons = JNIEnv.GetMethodID (class_ref, "getCachedBeacons", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedBeacons), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCreatedAt;
#pragma warning disable 0169
		static Delegate GetGetCreatedAtHandler ()
		{
			if (cb_getCreatedAt == null)
				cb_getCreatedAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreatedAt);
			return cb_getCreatedAt;
		}

		static IntPtr n_GetCreatedAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreatedAt);
		}
#pragma warning restore 0169

		IntPtr id_getCreatedAt;
		public unsafe global::Java.Util.Date CreatedAt {
			get {
				if (id_getCreatedAt == IntPtr.Zero)
					id_getCreatedAt = JNIEnv.GetMethodID (class_ref, "getCreatedAt", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCreatedAt), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getLocation;
#pragma warning disable 0169
		static Delegate GetGetLocationHandler ()
		{
			if (cb_getLocation == null)
				cb_getLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocation);
			return cb_getLocation;
		}

		static IntPtr n_GetLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Location);
		}
#pragma warning restore 0169

		IntPtr id_getLocation;
		public unsafe global::Android.Locations.Location Location {
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Landroid/location/Location;");
				return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getModifiedAt;
#pragma warning disable 0169
		static Delegate GetGetModifiedAtHandler ()
		{
			if (cb_getModifiedAt == null)
				cb_getModifiedAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetModifiedAt);
			return cb_getModifiedAt;
		}

		static IntPtr n_GetModifiedAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ModifiedAt);
		}
#pragma warning restore 0169

		IntPtr id_getModifiedAt;
		public unsafe global::Java.Util.Date ModifiedAt {
			get {
				if (id_getModifiedAt == IntPtr.Zero)
					id_getModifiedAt = JNIEnv.GetMethodID (class_ref, "getModifiedAt", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getModifiedAt), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getNotes;
#pragma warning disable 0169
		static Delegate GetGetNotesHandler ()
		{
			if (cb_getNotes == null)
				cb_getNotes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotes);
			return cb_getNotes;
		}

		static IntPtr n_GetNotes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Notes);
		}
#pragma warning restore 0169

		static Delegate cb_setNotes_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNotes_Ljava_lang_String_Handler ()
		{
			if (cb_setNotes_Ljava_lang_String_ == null)
				cb_setNotes_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNotes_Ljava_lang_String_);
			return cb_setNotes_Ljava_lang_String_;
		}

		static void n_SetNotes_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Notes = p0;
		}
#pragma warning restore 0169

		IntPtr id_getNotes;
		IntPtr id_setNotes_Ljava_lang_String_;
		public unsafe string Notes {
			get {
				if (id_getNotes == IntPtr.Zero)
					id_getNotes = JNIEnv.GetMethodID (class_ref, "getNotes", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNotes), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setNotes_Ljava_lang_String_ == IntPtr.Zero)
					id_setNotes_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNotes", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotes_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getSiteAccessType;
#pragma warning disable 0169
		static Delegate GetGetSiteAccessTypeHandler ()
		{
			if (cb_getSiteAccessType == null)
				cb_getSiteAccessType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSiteAccessType);
			return cb_getSiteAccessType;
		}

		static IntPtr n_GetSiteAccessType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SiteAccessType);
		}
#pragma warning restore 0169

		static Delegate cb_setSiteAccessType_Lcom_bluecats_sdk_BCSiteAccessType_;
#pragma warning disable 0169
		static Delegate GetSetSiteAccessType_Lcom_bluecats_sdk_BCSiteAccessType_Handler ()
		{
			if (cb_setSiteAccessType_Lcom_bluecats_sdk_BCSiteAccessType_ == null)
				cb_setSiteAccessType_Lcom_bluecats_sdk_BCSiteAccessType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSiteAccessType_Lcom_bluecats_sdk_BCSiteAccessType_);
			return cb_setSiteAccessType_Lcom_bluecats_sdk_BCSiteAccessType_;
		}

		static void n_SetSiteAccessType_Lcom_bluecats_sdk_BCSiteAccessType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCSiteAccessType p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteAccessType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SiteAccessType = p0;
		}
#pragma warning restore 0169

		IntPtr id_getSiteAccessType;
		IntPtr id_setSiteAccessType_Lcom_bluecats_sdk_BCSiteAccessType_;
		public unsafe global::Com.Bluecats.Sdk.BCSiteAccessType SiteAccessType {
			get {
				if (id_getSiteAccessType == IntPtr.Zero)
					id_getSiteAccessType = JNIEnv.GetMethodID (class_ref, "getSiteAccessType", "()Lcom/bluecats/sdk/BCSiteAccessType;");
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteAccessType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSiteAccessType), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setSiteAccessType_Lcom_bluecats_sdk_BCSiteAccessType_ == IntPtr.Zero)
					id_setSiteAccessType_Lcom_bluecats_sdk_BCSiteAccessType_ = JNIEnv.GetMethodID (class_ref, "setSiteAccessType", "(Lcom/bluecats/sdk/BCSiteAccessType;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSiteAccessType_Lcom_bluecats_sdk_BCSiteAccessType_, __args);
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
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SiteID);
		}
#pragma warning restore 0169

		static Delegate cb_setSiteID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSiteID_Ljava_lang_String_Handler ()
		{
			if (cb_setSiteID_Ljava_lang_String_ == null)
				cb_setSiteID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSiteID_Ljava_lang_String_);
			return cb_setSiteID_Ljava_lang_String_;
		}

		static void n_SetSiteID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SiteID = p0;
		}
#pragma warning restore 0169

		IntPtr id_getSiteID;
		IntPtr id_setSiteID_Ljava_lang_String_;
		public unsafe string SiteID {
			get {
				if (id_getSiteID == IntPtr.Zero)
					id_getSiteID = JNIEnv.GetMethodID (class_ref, "getSiteID", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSiteID), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setSiteID_Ljava_lang_String_ == IntPtr.Zero)
					id_setSiteID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSiteID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSiteID_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TeamID);
		}
#pragma warning restore 0169

		static Delegate cb_setTeamID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTeamID_Ljava_lang_String_Handler ()
		{
			if (cb_setTeamID_Ljava_lang_String_ == null)
				cb_setTeamID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTeamID_Ljava_lang_String_);
			return cb_setTeamID_Ljava_lang_String_;
		}

		static void n_SetTeamID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TeamID = p0;
		}
#pragma warning restore 0169

		IntPtr id_getTeamID;
		IntPtr id_setTeamID_Ljava_lang_String_;
		public unsafe string TeamID {
			get {
				if (id_getTeamID == IntPtr.Zero)
					id_getTeamID = JNIEnv.GetMethodID (class_ref, "getTeamID", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTeamID), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setTeamID_Ljava_lang_String_ == IntPtr.Zero)
					id_setTeamID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTeamID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTeamID_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Copy ());
		}
#pragma warning restore 0169

		IntPtr id_copy;
		public unsafe global::Com.Bluecats.Sdk.IBCSite Copy ()
		{
			if (id_copy == IntPtr.Zero)
				id_copy = JNIEnv.GetMethodID (class_ref, "copy", "()Lcom/bluecats/sdk/BCSite;");
			return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_copy), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getBeacons_ZLcom_bluecats_sdk_BCSiteCallback_;
#pragma warning disable 0169
		static Delegate GetGetBeacons_ZLcom_bluecats_sdk_BCSiteCallback_Handler ()
		{
			if (cb_getBeacons_ZLcom_bluecats_sdk_BCSiteCallback_ == null)
				cb_getBeacons_ZLcom_bluecats_sdk_BCSiteCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_GetBeacons_ZLcom_bluecats_sdk_BCSiteCallback_);
			return cb_getBeacons_ZLcom_bluecats_sdk_BCSiteCallback_;
		}

		static void n_GetBeacons_ZLcom_bluecats_sdk_BCSiteCallback_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSiteCallback p1 = (global::Com.Bluecats.Sdk.IBCSiteCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSiteCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetBeacons (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getBeacons_ZLcom_bluecats_sdk_BCSiteCallback_;
		public unsafe void GetBeacons (bool p0, global::Com.Bluecats.Sdk.IBCSiteCallback p1)
		{
			if (id_getBeacons_ZLcom_bluecats_sdk_BCSiteCallback_ == IntPtr.Zero)
				id_getBeacons_ZLcom_bluecats_sdk_BCSiteCallback_ = JNIEnv.GetMethodID (class_ref, "getBeacons", "(ZLcom/bluecats/sdk/BCSiteCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getBeacons_ZLcom_bluecats_sdk_BCSiteCallback_, __args);
		}

		static Delegate cb_getCategories_ZLcom_bluecats_sdk_BCSiteCallback_;
#pragma warning disable 0169
		static Delegate GetGetCategories_ZLcom_bluecats_sdk_BCSiteCallback_Handler ()
		{
			if (cb_getCategories_ZLcom_bluecats_sdk_BCSiteCallback_ == null)
				cb_getCategories_ZLcom_bluecats_sdk_BCSiteCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_GetCategories_ZLcom_bluecats_sdk_BCSiteCallback_);
			return cb_getCategories_ZLcom_bluecats_sdk_BCSiteCallback_;
		}

		static void n_GetCategories_ZLcom_bluecats_sdk_BCSiteCallback_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSiteCallback p1 = (global::Com.Bluecats.Sdk.IBCSiteCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSiteCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetCategories (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getCategories_ZLcom_bluecats_sdk_BCSiteCallback_;
		public unsafe void GetCategories (bool p0, global::Com.Bluecats.Sdk.IBCSiteCallback p1)
		{
			if (id_getCategories_ZLcom_bluecats_sdk_BCSiteCallback_ == IntPtr.Zero)
				id_getCategories_ZLcom_bluecats_sdk_BCSiteCallback_ = JNIEnv.GetMethodID (class_ref, "getCategories", "(ZLcom/bluecats/sdk/BCSiteCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getCategories_ZLcom_bluecats_sdk_BCSiteCallback_, __args);
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
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getMaps;
#pragma warning disable 0169
		static Delegate GetGetMapsHandler ()
		{
			if (cb_getMaps == null)
				cb_getMaps = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMaps);
			return cb_getMaps;
		}

		static IntPtr n_GetMaps (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetMaps ());
		}
#pragma warning restore 0169

		IntPtr id_getMaps;
		public unsafe global::Com.Bluecats.Sdk.BCMap[] GetMaps ()
		{
			if (id_getMaps == IntPtr.Zero)
				id_getMaps = JNIEnv.GetMethodID (class_ref, "getMaps", "()[Lcom/bluecats/sdk/BCMap;");
			return (global::Com.Bluecats.Sdk.BCMap[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMaps), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCMap));
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
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_updateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_;
#pragma warning disable 0169
		static Delegate GetUpdateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_Handler ()
		{
			if (cb_updateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_ == null)
				cb_updateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_);
			return cb_updateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_;
		}

		static void n_UpdateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite p0 = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSiteCallback p1 = (global::Com.Bluecats.Sdk.IBCSiteCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSiteCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateSite (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_updateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_;
		public unsafe void UpdateSite (global::Com.Bluecats.Sdk.IBCSite p0, global::Com.Bluecats.Sdk.IBCSiteCallback p1)
		{
			if (id_updateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_ == IntPtr.Zero)
				id_updateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_ = JNIEnv.GetMethodID (class_ref, "updateSite", "(Lcom/bluecats/sdk/BCSite;Lcom/bluecats/sdk/BCSiteCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_, __args);
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
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.IBCSite __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
