using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']"
	[Register ("com/bluecats/sdk/BCApp", "", "Com.Bluecats.Sdk.IBCAppInvoker")]
	public partial interface IBCApp : global::Android.OS.IParcelable {

		string AppID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='getAppID' and count(parameter)=0]"
			[Register ("getAppID", "()Ljava/lang/String;", "GetGetAppIDHandler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='setAppID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppID", "(Ljava/lang/String;)V", "GetSetAppID_Ljava_lang_String_Handler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")] set;
		}

		string AppIconURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='getAppIconURL' and count(parameter)=0]"
			[Register ("getAppIconURL", "()Ljava/lang/String;", "GetGetAppIconURLHandler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='setAppIconURL' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppIconURL", "(Ljava/lang/String;)V", "GetSetAppIconURL_Ljava_lang_String_Handler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")] set;
		}

		global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus AppStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='getAppStatus' and count(parameter)=0]"
			[Register ("getAppStatus", "()Lcom/bluecats/sdk/BlueCatsSDK$BCAppTokenVerificationStatus;", "GetGetAppStatusHandler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='setAppStatus' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BlueCatsSDK.BCAppTokenVerificationStatus']]"
			[Register ("setAppStatus", "(Lcom/bluecats/sdk/BlueCatsSDK$BCAppTokenVerificationStatus;)V", "GetSetAppStatus_Lcom_bluecats_sdk_BlueCatsSDK_BCAppTokenVerificationStatus_Handler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")] set;
		}

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")] set;
		}

		string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='setPackageName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPackageName", "(Ljava/lang/String;)V", "GetSetPackageName_Ljava_lang_String_Handler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")] set;
		}

		global::Com.Bluecats.Sdk.BCPlatformType PlatformType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='getPlatformType' and count(parameter)=0]"
			[Register ("getPlatformType", "()Lcom/bluecats/sdk/BCPlatformType;", "GetGetPlatformTypeHandler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='setPlatformType' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCPlatformType']]"
			[Register ("setPlatformType", "(Lcom/bluecats/sdk/BCPlatformType;)V", "GetSetPlatformType_Lcom_bluecats_sdk_BCPlatformType_Handler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")] set;
		}

		string PlayStoreURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='getPlayStoreURL' and count(parameter)=0]"
			[Register ("getPlayStoreURL", "()Ljava/lang/String;", "GetGetPlayStoreURLHandler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='setPlayStoreURL' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPlayStoreURL", "(Ljava/lang/String;)V", "GetSetPlayStoreURL_Ljava_lang_String_Handler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")] set;
		}

		global::System.Collections.Generic.IDictionary<string, string> RemoteOptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='getRemoteOptions' and count(parameter)=0]"
			[Register ("getRemoteOptions", "()Ljava/util/Map;", "GetGetRemoteOptionsHandler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")] get;
		}

		string TeamID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='getTeamID' and count(parameter)=0]"
			[Register ("getTeamID", "()Ljava/lang/String;", "GetGetTeamIDHandler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='setTeamID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTeamID", "(Ljava/lang/String;)V", "GetSetTeamID_Ljava_lang_String_Handler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")] set;
		}

		string VerificationCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='getVerificationCode' and count(parameter)=0]"
			[Register ("getVerificationCode", "()Ljava/lang/String;", "GetGetVerificationCodeHandler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='setVerificationCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVerificationCode", "(Ljava/lang/String;)V", "GetSetVerificationCode_Ljava_lang_String_Handler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")] set;
		}

		global::Java.Util.Date VerifiedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='getVerifiedAt' and count(parameter)=0]"
			[Register ("getVerifiedAt", "()Ljava/util/Date;", "GetGetVerifiedAtHandler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='setVerifiedAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setVerifiedAt", "(Ljava/util/Date;)V", "GetSetVerifiedAt_Ljava_util_Date_Handler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='copyApiPropertiesFromApp' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCApp']]"
		[Register ("copyApiPropertiesFromApp", "(Lcom/bluecats/sdk/BCApp;)V", "GetCopyApiPropertiesFromApp_Lcom_bluecats_sdk_BCApp_Handler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")]
		void CopyApiPropertiesFromApp (global::Com.Bluecats.Sdk.IBCApp p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='getAppSdkOptions' and count(parameter)=0]"
		[Register ("getAppSdkOptions", "()[Lcom/bluecats/sdk/BCAppSdkOption;", "GetGetAppSdkOptionsHandler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")]
		global::Com.Bluecats.Sdk.BCAppSdkOption[] GetAppSdkOptions ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='getAppToken' and count(parameter)=3 and parameter[1][@type='com.bluecats.sdk.BCApp'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.bluecats.sdk.BCAppCallback']]"
		[Register ("getAppToken", "(Lcom/bluecats/sdk/BCApp;Ljava/lang/String;Lcom/bluecats/sdk/BCAppCallback;)V", "GetGetAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_Handler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")]
		void GetAppToken (global::Com.Bluecats.Sdk.IBCApp p0, string p1, global::Com.Bluecats.Sdk.IBCAppCallback p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='setAppSdkOptions' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCAppSdkOption[]']]"
		[Register ("setAppSdkOptions", "([Lcom/bluecats/sdk/BCAppSdkOption;)V", "GetSetAppSdkOptions_arrayLcom_bluecats_sdk_BCAppSdkOption_Handler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")]
		void SetAppSdkOptions (global::Com.Bluecats.Sdk.BCAppSdkOption[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='updateApp' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCApp'] and parameter[2][@type='com.bluecats.sdk.BCAppCallback']]"
		[Register ("updateApp", "(Lcom/bluecats/sdk/BCApp;Lcom/bluecats/sdk/BCAppCallback;)V", "GetUpdateApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCAppCallback_Handler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")]
		void UpdateApp (global::Com.Bluecats.Sdk.IBCApp p0, global::Com.Bluecats.Sdk.IBCAppCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCApp']/method[@name='wasVerifiedWithinTimeInterval' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("wasVerifiedWithinTimeInterval", "(J)Z", "GetWasVerifiedWithinTimeInterval_JHandler:Com.Bluecats.Sdk.IBCAppInvoker, BindingBlueCatsSDK")]
		bool WasVerifiedWithinTimeInterval (long p0);

	}

	[global::Android.Runtime.Register ("com/bluecats/sdk/BCApp", DoNotGenerateAcw=true)]
	internal class IBCAppInvoker : global::Java.Lang.Object, IBCApp {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bluecats/sdk/BCApp");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBCAppInvoker); }
		}

		IntPtr class_ref;

		public static IBCApp GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBCApp> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bluecats.sdk.BCApp"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBCAppInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAppID;
#pragma warning disable 0169
		static Delegate GetGetAppIDHandler ()
		{
			if (cb_getAppID == null)
				cb_getAppID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppID);
			return cb_getAppID;
		}

		static IntPtr n_GetAppID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppID);
		}
#pragma warning restore 0169

		static Delegate cb_setAppID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppID_Ljava_lang_String_Handler ()
		{
			if (cb_setAppID_Ljava_lang_String_ == null)
				cb_setAppID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppID_Ljava_lang_String_);
			return cb_setAppID_Ljava_lang_String_;
		}

		static void n_SetAppID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppID = p0;
		}
#pragma warning restore 0169

		IntPtr id_getAppID;
		IntPtr id_setAppID_Ljava_lang_String_;
		public unsafe string AppID {
			get {
				if (id_getAppID == IntPtr.Zero)
					id_getAppID = JNIEnv.GetMethodID (class_ref, "getAppID", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppID), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setAppID_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppID_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getAppIconURL;
#pragma warning disable 0169
		static Delegate GetGetAppIconURLHandler ()
		{
			if (cb_getAppIconURL == null)
				cb_getAppIconURL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppIconURL);
			return cb_getAppIconURL;
		}

		static IntPtr n_GetAppIconURL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppIconURL);
		}
#pragma warning restore 0169

		static Delegate cb_setAppIconURL_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppIconURL_Ljava_lang_String_Handler ()
		{
			if (cb_setAppIconURL_Ljava_lang_String_ == null)
				cb_setAppIconURL_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppIconURL_Ljava_lang_String_);
			return cb_setAppIconURL_Ljava_lang_String_;
		}

		static void n_SetAppIconURL_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppIconURL = p0;
		}
#pragma warning restore 0169

		IntPtr id_getAppIconURL;
		IntPtr id_setAppIconURL_Ljava_lang_String_;
		public unsafe string AppIconURL {
			get {
				if (id_getAppIconURL == IntPtr.Zero)
					id_getAppIconURL = JNIEnv.GetMethodID (class_ref, "getAppIconURL", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppIconURL), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setAppIconURL_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppIconURL_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppIconURL", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppIconURL_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getAppStatus;
#pragma warning disable 0169
		static Delegate GetGetAppStatusHandler ()
		{
			if (cb_getAppStatus == null)
				cb_getAppStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppStatus);
			return cb_getAppStatus;
		}

		static IntPtr n_GetAppStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AppStatus);
		}
#pragma warning restore 0169

		static Delegate cb_setAppStatus_Lcom_bluecats_sdk_BlueCatsSDK_BCAppTokenVerificationStatus_;
#pragma warning disable 0169
		static Delegate GetSetAppStatus_Lcom_bluecats_sdk_BlueCatsSDK_BCAppTokenVerificationStatus_Handler ()
		{
			if (cb_setAppStatus_Lcom_bluecats_sdk_BlueCatsSDK_BCAppTokenVerificationStatus_ == null)
				cb_setAppStatus_Lcom_bluecats_sdk_BlueCatsSDK_BCAppTokenVerificationStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppStatus_Lcom_bluecats_sdk_BlueCatsSDK_BCAppTokenVerificationStatus_);
			return cb_setAppStatus_Lcom_bluecats_sdk_BlueCatsSDK_BCAppTokenVerificationStatus_;
		}

		static void n_SetAppStatus_Lcom_bluecats_sdk_BlueCatsSDK_BCAppTokenVerificationStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppStatus = p0;
		}
#pragma warning restore 0169

		IntPtr id_getAppStatus;
		IntPtr id_setAppStatus_Lcom_bluecats_sdk_BlueCatsSDK_BCAppTokenVerificationStatus_;
		public unsafe global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus AppStatus {
			get {
				if (id_getAppStatus == IntPtr.Zero)
					id_getAppStatus = JNIEnv.GetMethodID (class_ref, "getAppStatus", "()Lcom/bluecats/sdk/BlueCatsSDK$BCAppTokenVerificationStatus;");
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppStatus), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setAppStatus_Lcom_bluecats_sdk_BlueCatsSDK_BCAppTokenVerificationStatus_ == IntPtr.Zero)
					id_setAppStatus_Lcom_bluecats_sdk_BlueCatsSDK_BCAppTokenVerificationStatus_ = JNIEnv.GetMethodID (class_ref, "setAppStatus", "(Lcom/bluecats/sdk/BlueCatsSDK$BCAppTokenVerificationStatus;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppStatus_Lcom_bluecats_sdk_BlueCatsSDK_BCAppTokenVerificationStatus_, __args);
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
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getPackageName;
#pragma warning disable 0169
		static Delegate GetGetPackageNameHandler ()
		{
			if (cb_getPackageName == null)
				cb_getPackageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageName);
			return cb_getPackageName;
		}

		static IntPtr n_GetPackageName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageName);
		}
#pragma warning restore 0169

		static Delegate cb_setPackageName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPackageName_Ljava_lang_String_Handler ()
		{
			if (cb_setPackageName_Ljava_lang_String_ == null)
				cb_setPackageName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPackageName_Ljava_lang_String_);
			return cb_setPackageName_Ljava_lang_String_;
		}

		static void n_SetPackageName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PackageName = p0;
		}
#pragma warning restore 0169

		IntPtr id_getPackageName;
		IntPtr id_setPackageName_Ljava_lang_String_;
		public unsafe string PackageName {
			get {
				if (id_getPackageName == IntPtr.Zero)
					id_getPackageName = JNIEnv.GetMethodID (class_ref, "getPackageName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPackageName), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setPackageName_Ljava_lang_String_ == IntPtr.Zero)
					id_setPackageName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPackageName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPackageName_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getPlatformType;
#pragma warning disable 0169
		static Delegate GetGetPlatformTypeHandler ()
		{
			if (cb_getPlatformType == null)
				cb_getPlatformType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlatformType);
			return cb_getPlatformType;
		}

		static IntPtr n_GetPlatformType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PlatformType);
		}
#pragma warning restore 0169

		static Delegate cb_setPlatformType_Lcom_bluecats_sdk_BCPlatformType_;
#pragma warning disable 0169
		static Delegate GetSetPlatformType_Lcom_bluecats_sdk_BCPlatformType_Handler ()
		{
			if (cb_setPlatformType_Lcom_bluecats_sdk_BCPlatformType_ == null)
				cb_setPlatformType_Lcom_bluecats_sdk_BCPlatformType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlatformType_Lcom_bluecats_sdk_BCPlatformType_);
			return cb_setPlatformType_Lcom_bluecats_sdk_BCPlatformType_;
		}

		static void n_SetPlatformType_Lcom_bluecats_sdk_BCPlatformType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCPlatformType p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPlatformType> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PlatformType = p0;
		}
#pragma warning restore 0169

		IntPtr id_getPlatformType;
		IntPtr id_setPlatformType_Lcom_bluecats_sdk_BCPlatformType_;
		public unsafe global::Com.Bluecats.Sdk.BCPlatformType PlatformType {
			get {
				if (id_getPlatformType == IntPtr.Zero)
					id_getPlatformType = JNIEnv.GetMethodID (class_ref, "getPlatformType", "()Lcom/bluecats/sdk/BCPlatformType;");
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPlatformType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlatformType), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setPlatformType_Lcom_bluecats_sdk_BCPlatformType_ == IntPtr.Zero)
					id_setPlatformType_Lcom_bluecats_sdk_BCPlatformType_ = JNIEnv.GetMethodID (class_ref, "setPlatformType", "(Lcom/bluecats/sdk/BCPlatformType;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPlatformType_Lcom_bluecats_sdk_BCPlatformType_, __args);
			}
		}

		static Delegate cb_getPlayStoreURL;
#pragma warning disable 0169
		static Delegate GetGetPlayStoreURLHandler ()
		{
			if (cb_getPlayStoreURL == null)
				cb_getPlayStoreURL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlayStoreURL);
			return cb_getPlayStoreURL;
		}

		static IntPtr n_GetPlayStoreURL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PlayStoreURL);
		}
#pragma warning restore 0169

		static Delegate cb_setPlayStoreURL_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPlayStoreURL_Ljava_lang_String_Handler ()
		{
			if (cb_setPlayStoreURL_Ljava_lang_String_ == null)
				cb_setPlayStoreURL_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPlayStoreURL_Ljava_lang_String_);
			return cb_setPlayStoreURL_Ljava_lang_String_;
		}

		static void n_SetPlayStoreURL_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PlayStoreURL = p0;
		}
#pragma warning restore 0169

		IntPtr id_getPlayStoreURL;
		IntPtr id_setPlayStoreURL_Ljava_lang_String_;
		public unsafe string PlayStoreURL {
			get {
				if (id_getPlayStoreURL == IntPtr.Zero)
					id_getPlayStoreURL = JNIEnv.GetMethodID (class_ref, "getPlayStoreURL", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlayStoreURL), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setPlayStoreURL_Ljava_lang_String_ == IntPtr.Zero)
					id_setPlayStoreURL_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPlayStoreURL", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPlayStoreURL_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getRemoteOptions;
#pragma warning disable 0169
		static Delegate GetGetRemoteOptionsHandler ()
		{
			if (cb_getRemoteOptions == null)
				cb_getRemoteOptions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRemoteOptions);
			return cb_getRemoteOptions;
		}

		static IntPtr n_GetRemoteOptions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.RemoteOptions);
		}
#pragma warning restore 0169

		IntPtr id_getRemoteOptions;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> RemoteOptions {
			get {
				if (id_getRemoteOptions == IntPtr.Zero)
					id_getRemoteOptions = JNIEnv.GetMethodID (class_ref, "getRemoteOptions", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRemoteOptions), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getVerificationCode;
#pragma warning disable 0169
		static Delegate GetGetVerificationCodeHandler ()
		{
			if (cb_getVerificationCode == null)
				cb_getVerificationCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVerificationCode);
			return cb_getVerificationCode;
		}

		static IntPtr n_GetVerificationCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VerificationCode);
		}
#pragma warning restore 0169

		static Delegate cb_setVerificationCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVerificationCode_Ljava_lang_String_Handler ()
		{
			if (cb_setVerificationCode_Ljava_lang_String_ == null)
				cb_setVerificationCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVerificationCode_Ljava_lang_String_);
			return cb_setVerificationCode_Ljava_lang_String_;
		}

		static void n_SetVerificationCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VerificationCode = p0;
		}
#pragma warning restore 0169

		IntPtr id_getVerificationCode;
		IntPtr id_setVerificationCode_Ljava_lang_String_;
		public unsafe string VerificationCode {
			get {
				if (id_getVerificationCode == IntPtr.Zero)
					id_getVerificationCode = JNIEnv.GetMethodID (class_ref, "getVerificationCode", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVerificationCode), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setVerificationCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setVerificationCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setVerificationCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVerificationCode_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VerifiedAt);
		}
#pragma warning restore 0169

		static Delegate cb_setVerifiedAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetVerifiedAt_Ljava_util_Date_Handler ()
		{
			if (cb_setVerifiedAt_Ljava_util_Date_ == null)
				cb_setVerifiedAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVerifiedAt_Ljava_util_Date_);
			return cb_setVerifiedAt_Ljava_util_Date_;
		}

		static void n_SetVerifiedAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VerifiedAt = p0;
		}
#pragma warning restore 0169

		IntPtr id_getVerifiedAt;
		IntPtr id_setVerifiedAt_Ljava_util_Date_;
		public unsafe global::Java.Util.Date VerifiedAt {
			get {
				if (id_getVerifiedAt == IntPtr.Zero)
					id_getVerifiedAt = JNIEnv.GetMethodID (class_ref, "getVerifiedAt", "()Ljava/util/Date;");
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVerifiedAt), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setVerifiedAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setVerifiedAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setVerifiedAt", "(Ljava/util/Date;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVerifiedAt_Ljava_util_Date_, __args);
			}
		}

		static Delegate cb_copyApiPropertiesFromApp_Lcom_bluecats_sdk_BCApp_;
#pragma warning disable 0169
		static Delegate GetCopyApiPropertiesFromApp_Lcom_bluecats_sdk_BCApp_Handler ()
		{
			if (cb_copyApiPropertiesFromApp_Lcom_bluecats_sdk_BCApp_ == null)
				cb_copyApiPropertiesFromApp_Lcom_bluecats_sdk_BCApp_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CopyApiPropertiesFromApp_Lcom_bluecats_sdk_BCApp_);
			return cb_copyApiPropertiesFromApp_Lcom_bluecats_sdk_BCApp_;
		}

		static void n_CopyApiPropertiesFromApp_Lcom_bluecats_sdk_BCApp_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCApp p0 = (global::Com.Bluecats.Sdk.IBCApp)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CopyApiPropertiesFromApp (p0);
		}
#pragma warning restore 0169

		IntPtr id_copyApiPropertiesFromApp_Lcom_bluecats_sdk_BCApp_;
		public unsafe void CopyApiPropertiesFromApp (global::Com.Bluecats.Sdk.IBCApp p0)
		{
			if (id_copyApiPropertiesFromApp_Lcom_bluecats_sdk_BCApp_ == IntPtr.Zero)
				id_copyApiPropertiesFromApp_Lcom_bluecats_sdk_BCApp_ = JNIEnv.GetMethodID (class_ref, "copyApiPropertiesFromApp", "(Lcom/bluecats/sdk/BCApp;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_copyApiPropertiesFromApp_Lcom_bluecats_sdk_BCApp_, __args);
		}

		static Delegate cb_getAppSdkOptions;
#pragma warning disable 0169
		static Delegate GetGetAppSdkOptionsHandler ()
		{
			if (cb_getAppSdkOptions == null)
				cb_getAppSdkOptions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppSdkOptions);
			return cb_getAppSdkOptions;
		}

		static IntPtr n_GetAppSdkOptions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAppSdkOptions ());
		}
#pragma warning restore 0169

		IntPtr id_getAppSdkOptions;
		public unsafe global::Com.Bluecats.Sdk.BCAppSdkOption[] GetAppSdkOptions ()
		{
			if (id_getAppSdkOptions == IntPtr.Zero)
				id_getAppSdkOptions = JNIEnv.GetMethodID (class_ref, "getAppSdkOptions", "()[Lcom/bluecats/sdk/BCAppSdkOption;");
			return (global::Com.Bluecats.Sdk.BCAppSdkOption[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppSdkOptions), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCAppSdkOption));
		}

		static Delegate cb_getAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_;
#pragma warning disable 0169
		static Delegate GetGetAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_Handler ()
		{
			if (cb_getAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_ == null)
				cb_getAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_);
			return cb_getAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_;
		}

		static void n_GetAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCApp p0 = (global::Com.Bluecats.Sdk.IBCApp)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCAppCallback p2 = (global::Com.Bluecats.Sdk.IBCAppCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCAppCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.GetAppToken (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_getAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_;
		public unsafe void GetAppToken (global::Com.Bluecats.Sdk.IBCApp p0, string p1, global::Com.Bluecats.Sdk.IBCAppCallback p2)
		{
			if (id_getAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_ == IntPtr.Zero)
				id_getAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_ = JNIEnv.GetMethodID (class_ref, "getAppToken", "(Lcom/bluecats/sdk/BCApp;Ljava/lang/String;Lcom/bluecats/sdk/BCAppCallback;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_setAppSdkOptions_arrayLcom_bluecats_sdk_BCAppSdkOption_;
#pragma warning disable 0169
		static Delegate GetSetAppSdkOptions_arrayLcom_bluecats_sdk_BCAppSdkOption_Handler ()
		{
			if (cb_setAppSdkOptions_arrayLcom_bluecats_sdk_BCAppSdkOption_ == null)
				cb_setAppSdkOptions_arrayLcom_bluecats_sdk_BCAppSdkOption_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppSdkOptions_arrayLcom_bluecats_sdk_BCAppSdkOption_);
			return cb_setAppSdkOptions_arrayLcom_bluecats_sdk_BCAppSdkOption_;
		}

		static void n_SetAppSdkOptions_arrayLcom_bluecats_sdk_BCAppSdkOption_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCAppSdkOption[] p0 = (global::Com.Bluecats.Sdk.BCAppSdkOption[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Bluecats.Sdk.BCAppSdkOption));
			__this.SetAppSdkOptions (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_setAppSdkOptions_arrayLcom_bluecats_sdk_BCAppSdkOption_;
		public unsafe void SetAppSdkOptions (global::Com.Bluecats.Sdk.BCAppSdkOption[] p0)
		{
			if (id_setAppSdkOptions_arrayLcom_bluecats_sdk_BCAppSdkOption_ == IntPtr.Zero)
				id_setAppSdkOptions_arrayLcom_bluecats_sdk_BCAppSdkOption_ = JNIEnv.GetMethodID (class_ref, "setAppSdkOptions", "([Lcom/bluecats/sdk/BCAppSdkOption;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppSdkOptions_arrayLcom_bluecats_sdk_BCAppSdkOption_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCAppCallback_;
#pragma warning disable 0169
		static Delegate GetUpdateApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCAppCallback_Handler ()
		{
			if (cb_updateApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCAppCallback_ == null)
				cb_updateApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCAppCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCAppCallback_);
			return cb_updateApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCAppCallback_;
		}

		static void n_UpdateApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCAppCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCApp p0 = (global::Com.Bluecats.Sdk.IBCApp)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCAppCallback p1 = (global::Com.Bluecats.Sdk.IBCAppCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCAppCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateApp (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_updateApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCAppCallback_;
		public unsafe void UpdateApp (global::Com.Bluecats.Sdk.IBCApp p0, global::Com.Bluecats.Sdk.IBCAppCallback p1)
		{
			if (id_updateApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCAppCallback_ == IntPtr.Zero)
				id_updateApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCAppCallback_ = JNIEnv.GetMethodID (class_ref, "updateApp", "(Lcom/bluecats/sdk/BCApp;Lcom/bluecats/sdk/BCAppCallback;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCAppCallback_, __args);
		}

		static Delegate cb_wasVerifiedWithinTimeInterval_J;
#pragma warning disable 0169
		static Delegate GetWasVerifiedWithinTimeInterval_JHandler ()
		{
			if (cb_wasVerifiedWithinTimeInterval_J == null)
				cb_wasVerifiedWithinTimeInterval_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_WasVerifiedWithinTimeInterval_J);
			return cb_wasVerifiedWithinTimeInterval_J;
		}

		static bool n_WasVerifiedWithinTimeInterval_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WasVerifiedWithinTimeInterval (p0);
		}
#pragma warning restore 0169

		IntPtr id_wasVerifiedWithinTimeInterval_J;
		public unsafe bool WasVerifiedWithinTimeInterval (long p0)
		{
			if (id_wasVerifiedWithinTimeInterval_J == IntPtr.Zero)
				id_wasVerifiedWithinTimeInterval_J = JNIEnv.GetMethodID (class_ref, "wasVerifiedWithinTimeInterval", "(J)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_wasVerifiedWithinTimeInterval_J, __args);
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
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.IBCApp __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
