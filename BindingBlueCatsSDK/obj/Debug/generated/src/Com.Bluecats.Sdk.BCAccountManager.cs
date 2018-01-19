using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCAccountManager", DoNotGenerateAcw=true)]
	public partial class BCAccountManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/field[@name='TAG']"
		[Register ("TAG")]
		protected const string Tag = (string) "BCAccountManager";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCAccountManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCAccountManager); }
		}

		protected BCAccountManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/constructor[@name='BCAccountManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCAccountManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCAccountManager)) {
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

		static Delegate cb_getAppToken;
#pragma warning disable 0169
		static Delegate GetGetAppTokenHandler ()
		{
			if (cb_getAppToken == null)
				cb_getAppToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppToken);
			return cb_getAppToken;
		}

		static IntPtr n_GetAppToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppToken);
		}
#pragma warning restore 0169

		static Delegate cb_setAppToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppToken_Ljava_lang_String_Handler ()
		{
			if (cb_setAppToken_Ljava_lang_String_ == null)
				cb_setAppToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppToken_Ljava_lang_String_);
			return cb_setAppToken_Ljava_lang_String_;
		}

		static void n_SetAppToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AppToken = value;
		}
#pragma warning restore 0169

		static IntPtr id_getAppToken;
		static IntPtr id_setAppToken_Ljava_lang_String_;
		public virtual unsafe string AppToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='getAppToken' and count(parameter)=0]"
			[Register ("getAppToken", "()Ljava/lang/String;", "GetGetAppTokenHandler")]
			get {
				if (id_getAppToken == IntPtr.Zero)
					id_getAppToken = JNIEnv.GetMethodID (class_ref, "getAppToken", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppToken), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='setAppToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppToken", "(Ljava/lang/String;)V", "GetSetAppToken_Ljava_lang_String_Handler")]
			set {
				if (id_setAppToken_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppToken", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppToken_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppToken", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAppTokenStatus;
#pragma warning disable 0169
		static Delegate GetGetAppTokenStatusHandler ()
		{
			if (cb_getAppTokenStatus == null)
				cb_getAppTokenStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppTokenStatus);
			return cb_getAppTokenStatus;
		}

		static IntPtr n_GetAppTokenStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AppTokenStatus);
		}
#pragma warning restore 0169

		static IntPtr id_getAppTokenStatus;
		public virtual unsafe global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus AppTokenStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='getAppTokenStatus' and count(parameter)=0]"
			[Register ("getAppTokenStatus", "()Lcom/bluecats/sdk/BlueCatsSDK$BCAppTokenVerificationStatus;", "GetGetAppTokenStatusHandler")]
			get {
				if (id_getAppTokenStatus == IntPtr.Zero)
					id_getAppTokenStatus = JNIEnv.GetMethodID (class_ref, "getAppTokenStatus", "()Lcom/bluecats/sdk/BlueCatsSDK$BCAppTokenVerificationStatus;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppTokenStatus), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BlueCatsSDK.BCAppTokenVerificationStatus> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppTokenStatus", "()Lcom/bluecats/sdk/BlueCatsSDK$BCAppTokenVerificationStatus;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBeaconLoudnesses;
#pragma warning disable 0169
		static Delegate GetGetBeaconLoudnessesHandler ()
		{
			if (cb_getBeaconLoudnesses == null)
				cb_getBeaconLoudnesses = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeaconLoudnesses);
			return cb_getBeaconLoudnesses;
		}

		static IntPtr n_GetBeaconLoudnesses (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCBeaconLoudness>.ToLocalJniHandle (__this.BeaconLoudnesses);
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconLoudnesses;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCBeaconLoudness> BeaconLoudnesses {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='getBeaconLoudnesses' and count(parameter)=0]"
			[Register ("getBeaconLoudnesses", "()Ljava/util/List;", "GetGetBeaconLoudnessesHandler")]
			get {
				if (id_getBeaconLoudnesses == IntPtr.Zero)
					id_getBeaconLoudnesses = JNIEnv.GetMethodID (class_ref, "getBeaconLoudnesses", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCBeaconLoudness>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconLoudnesses), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCBeaconLoudness>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeaconLoudnesses", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBeaconModes;
#pragma warning disable 0169
		static Delegate GetGetBeaconModesHandler ()
		{
			if (cb_getBeaconModes == null)
				cb_getBeaconModes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeaconModes);
			return cb_getBeaconModes;
		}

		static IntPtr n_GetBeaconModes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCBeaconMode>.ToLocalJniHandle (__this.BeaconModes);
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconModes;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCBeaconMode> BeaconModes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='getBeaconModes' and count(parameter)=0]"
			[Register ("getBeaconModes", "()Ljava/util/List;", "GetGetBeaconModesHandler")]
			get {
				if (id_getBeaconModes == IntPtr.Zero)
					id_getBeaconModes = JNIEnv.GetMethodID (class_ref, "getBeaconModes", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCBeaconMode>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconModes), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCBeaconMode>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeaconModes", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Bluecats.Sdk.BCAccountManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/bluecats/sdk/BCAccountManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/bluecats/sdk/BCAccountManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isLoggedIn;
#pragma warning disable 0169
		static Delegate GetIsLoggedInHandler ()
		{
			if (cb_isLoggedIn == null)
				cb_isLoggedIn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLoggedIn);
			return cb_isLoggedIn;
		}

		static bool n_IsLoggedIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLoggedIn;
		}
#pragma warning restore 0169

		static IntPtr id_isLoggedIn;
		public virtual unsafe bool IsLoggedIn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='isLoggedIn' and count(parameter)=0]"
			[Register ("isLoggedIn", "()Z", "GetIsLoggedInHandler")]
			get {
				if (id_isLoggedIn == IntPtr.Zero)
					id_isLoggedIn = JNIEnv.GetMethodID (class_ref, "isLoggedIn", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLoggedIn);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLoggedIn", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLoggedInPerson;
#pragma warning disable 0169
		static Delegate GetGetLoggedInPersonHandler ()
		{
			if (cb_getLoggedInPerson == null)
				cb_getLoggedInPerson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLoggedInPerson);
			return cb_getLoggedInPerson;
		}

		static IntPtr n_GetLoggedInPerson (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LoggedInPerson);
		}
#pragma warning restore 0169

		static IntPtr id_getLoggedInPerson;
		public virtual unsafe global::Com.Bluecats.Sdk.BCPerson LoggedInPerson {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='getLoggedInPerson' and count(parameter)=0]"
			[Register ("getLoggedInPerson", "()Lcom/bluecats/sdk/BCPerson;", "GetGetLoggedInPersonHandler")]
			get {
				if (id_getLoggedInPerson == IntPtr.Zero)
					id_getLoggedInPerson = JNIEnv.GetMethodID (class_ref, "getLoggedInPerson", "()Lcom/bluecats/sdk/BCPerson;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPerson> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLoggedInPerson), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPerson> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLoggedInPerson", "()Lcom/bluecats/sdk/BCPerson;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPassword;
#pragma warning disable 0169
		static Delegate GetGetPasswordHandler ()
		{
			if (cb_getPassword == null)
				cb_getPassword = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPassword);
			return cb_getPassword;
		}

		static IntPtr n_GetPassword (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Password);
		}
#pragma warning restore 0169

		static Delegate cb_setPassword_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPassword_Ljava_lang_String_Handler ()
		{
			if (cb_setPassword_Ljava_lang_String_ == null)
				cb_setPassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPassword_Ljava_lang_String_);
			return cb_setPassword_Ljava_lang_String_;
		}

		static void n_SetPassword_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Password = value;
		}
#pragma warning restore 0169

		static IntPtr id_getPassword;
		static IntPtr id_setPassword_Ljava_lang_String_;
		public virtual unsafe string Password {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='getPassword' and count(parameter)=0]"
			[Register ("getPassword", "()Ljava/lang/String;", "GetGetPasswordHandler")]
			get {
				if (id_getPassword == IntPtr.Zero)
					id_getPassword = JNIEnv.GetMethodID (class_ref, "getPassword", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPassword), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPassword", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='setPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPassword", "(Ljava/lang/String;)V", "GetSetPassword_Ljava_lang_String_Handler")]
			set {
				if (id_setPassword_Ljava_lang_String_ == IntPtr.Zero)
					id_setPassword_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPassword", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPassword_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPassword", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPlatformTypes;
#pragma warning disable 0169
		static Delegate GetGetPlatformTypesHandler ()
		{
			if (cb_getPlatformTypes == null)
				cb_getPlatformTypes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlatformTypes);
			return cb_getPlatformTypes;
		}

		static IntPtr n_GetPlatformTypes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCPlatformType>.ToLocalJniHandle (__this.PlatformTypes);
		}
#pragma warning restore 0169

		static IntPtr id_getPlatformTypes;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCPlatformType> PlatformTypes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='getPlatformTypes' and count(parameter)=0]"
			[Register ("getPlatformTypes", "()Ljava/util/List;", "GetGetPlatformTypesHandler")]
			get {
				if (id_getPlatformTypes == IntPtr.Zero)
					id_getPlatformTypes = JNIEnv.GetMethodID (class_ref, "getPlatformTypes", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCPlatformType>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlatformTypes), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCPlatformType>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlatformTypes", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSiteAccessTypes;
#pragma warning disable 0169
		static Delegate GetGetSiteAccessTypesHandler ()
		{
			if (cb_getSiteAccessTypes == null)
				cb_getSiteAccessTypes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSiteAccessTypes);
			return cb_getSiteAccessTypes;
		}

		static IntPtr n_GetSiteAccessTypes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCSiteAccessType>.ToLocalJniHandle (__this.SiteAccessTypes);
		}
#pragma warning restore 0169

		static IntPtr id_getSiteAccessTypes;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCSiteAccessType> SiteAccessTypes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='getSiteAccessTypes' and count(parameter)=0]"
			[Register ("getSiteAccessTypes", "()Ljava/util/List;", "GetGetSiteAccessTypesHandler")]
			get {
				if (id_getSiteAccessTypes == IntPtr.Zero)
					id_getSiteAccessTypes = JNIEnv.GetMethodID (class_ref, "getSiteAccessTypes", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCSiteAccessType>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSiteAccessTypes), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCSiteAccessType>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSiteAccessTypes", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTargetSpeeds;
#pragma warning disable 0169
		static Delegate GetGetTargetSpeedsHandler ()
		{
			if (cb_getTargetSpeeds == null)
				cb_getTargetSpeeds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTargetSpeeds);
			return cb_getTargetSpeeds;
		}

		static IntPtr n_GetTargetSpeeds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCTargetSpeed>.ToLocalJniHandle (__this.TargetSpeeds);
		}
#pragma warning restore 0169

		static IntPtr id_getTargetSpeeds;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCTargetSpeed> TargetSpeeds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='getTargetSpeeds' and count(parameter)=0]"
			[Register ("getTargetSpeeds", "()Ljava/util/List;", "GetGetTargetSpeedsHandler")]
			get {
				if (id_getTargetSpeeds == IntPtr.Zero)
					id_getTargetSpeeds = JNIEnv.GetMethodID (class_ref, "getTargetSpeeds", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCTargetSpeed>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTargetSpeeds), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCTargetSpeed>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTargetSpeeds", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserName;
#pragma warning disable 0169
		static Delegate GetGetUserNameHandler ()
		{
			if (cb_getUserName == null)
				cb_getUserName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserName);
			return cb_getUserName;
		}

		static IntPtr n_GetUserName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserName);
		}
#pragma warning restore 0169

		static Delegate cb_setUserName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserName_Ljava_lang_String_Handler ()
		{
			if (cb_setUserName_Ljava_lang_String_ == null)
				cb_setUserName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserName_Ljava_lang_String_);
			return cb_setUserName_Ljava_lang_String_;
		}

		static void n_SetUserName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.UserName = value;
		}
#pragma warning restore 0169

		static IntPtr id_getUserName;
		static IntPtr id_setUserName_Ljava_lang_String_;
		public virtual unsafe string UserName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='getUserName' and count(parameter)=0]"
			[Register ("getUserName", "()Ljava/lang/String;", "GetGetUserNameHandler")]
			get {
				if (id_getUserName == IntPtr.Zero)
					id_getUserName = JNIEnv.GetMethodID (class_ref, "getUserName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='setUserName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUserName", "(Ljava/lang/String;)V", "GetSetUserName_Ljava_lang_String_Handler")]
			set {
				if (id_setUserName_Ljava_lang_String_ == IntPtr.Zero)
					id_setUserName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getVerifiedApp;
#pragma warning disable 0169
		static Delegate GetGetVerifiedAppHandler ()
		{
			if (cb_getVerifiedApp == null)
				cb_getVerifiedApp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVerifiedApp);
			return cb_getVerifiedApp;
		}

		static IntPtr n_GetVerifiedApp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VerifiedApp);
		}
#pragma warning restore 0169

		static IntPtr id_getVerifiedApp;
		public virtual unsafe global::Com.Bluecats.Sdk.IBCApp VerifiedApp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='getVerifiedApp' and count(parameter)=0]"
			[Register ("getVerifiedApp", "()Lcom/bluecats/sdk/BCApp;", "GetGetVerifiedAppHandler")]
			get {
				if (id_getVerifiedApp == IntPtr.Zero)
					id_getVerifiedApp = JNIEnv.GetMethodID (class_ref, "getVerifiedApp", "()Lcom/bluecats/sdk/BCApp;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVerifiedApp), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVerifiedApp", "()Lcom/bluecats/sdk/BCApp;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_attemptAppRestoreAndVerifyWithToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAttemptAppRestoreAndVerifyWithToken_Ljava_lang_String_Handler ()
		{
			if (cb_attemptAppRestoreAndVerifyWithToken_Ljava_lang_String_ == null)
				cb_attemptAppRestoreAndVerifyWithToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AttemptAppRestoreAndVerifyWithToken_Ljava_lang_String_);
			return cb_attemptAppRestoreAndVerifyWithToken_Ljava_lang_String_;
		}

		static void n_AttemptAppRestoreAndVerifyWithToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_appToken)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string appToken = JNIEnv.GetString (native_appToken, JniHandleOwnership.DoNotTransfer);
			__this.AttemptAppRestoreAndVerifyWithToken (appToken);
		}
#pragma warning restore 0169

		static IntPtr id_attemptAppRestoreAndVerifyWithToken_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='attemptAppRestoreAndVerifyWithToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("attemptAppRestoreAndVerifyWithToken", "(Ljava/lang/String;)V", "GetAttemptAppRestoreAndVerifyWithToken_Ljava_lang_String_Handler")]
		public virtual unsafe void AttemptAppRestoreAndVerifyWithToken (string appToken)
		{
			if (id_attemptAppRestoreAndVerifyWithToken_Ljava_lang_String_ == IntPtr.Zero)
				id_attemptAppRestoreAndVerifyWithToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "attemptAppRestoreAndVerifyWithToken", "(Ljava/lang/String;)V");
			IntPtr native_appToken = JNIEnv.NewString (appToken);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_appToken);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_attemptAppRestoreAndVerifyWithToken_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "attemptAppRestoreAndVerifyWithToken", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_appToken);
			}
		}

		static Delegate cb_clearCachedApp;
#pragma warning disable 0169
		static Delegate GetClearCachedAppHandler ()
		{
			if (cb_clearCachedApp == null)
				cb_clearCachedApp = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearCachedApp);
			return cb_clearCachedApp;
		}

		static void n_ClearCachedApp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearCachedApp ();
		}
#pragma warning restore 0169

		static IntPtr id_clearCachedApp;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='clearCachedApp' and count(parameter)=0]"
		[Register ("clearCachedApp", "()V", "GetClearCachedAppHandler")]
		public virtual unsafe void ClearCachedApp ()
		{
			if (id_clearCachedApp == IntPtr.Zero)
				id_clearCachedApp = JNIEnv.GetMethodID (class_ref, "clearCachedApp", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearCachedApp);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearCachedApp", "()V"));
			} finally {
			}
		}

		static Delegate cb_loadBeaconLoudnesses;
#pragma warning disable 0169
		static Delegate GetLoadBeaconLoudnessesHandler ()
		{
			if (cb_loadBeaconLoudnesses == null)
				cb_loadBeaconLoudnesses = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LoadBeaconLoudnesses);
			return cb_loadBeaconLoudnesses;
		}

		static void n_LoadBeaconLoudnesses (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadBeaconLoudnesses ();
		}
#pragma warning restore 0169

		static IntPtr id_loadBeaconLoudnesses;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='loadBeaconLoudnesses' and count(parameter)=0]"
		[Register ("loadBeaconLoudnesses", "()V", "GetLoadBeaconLoudnessesHandler")]
		public virtual unsafe void LoadBeaconLoudnesses ()
		{
			if (id_loadBeaconLoudnesses == IntPtr.Zero)
				id_loadBeaconLoudnesses = JNIEnv.GetMethodID (class_ref, "loadBeaconLoudnesses", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadBeaconLoudnesses);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadBeaconLoudnesses", "()V"));
			} finally {
			}
		}

		static Delegate cb_loadBeaconModes;
#pragma warning disable 0169
		static Delegate GetLoadBeaconModesHandler ()
		{
			if (cb_loadBeaconModes == null)
				cb_loadBeaconModes = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LoadBeaconModes);
			return cb_loadBeaconModes;
		}

		static void n_LoadBeaconModes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadBeaconModes ();
		}
#pragma warning restore 0169

		static IntPtr id_loadBeaconModes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='loadBeaconModes' and count(parameter)=0]"
		[Register ("loadBeaconModes", "()V", "GetLoadBeaconModesHandler")]
		public virtual unsafe void LoadBeaconModes ()
		{
			if (id_loadBeaconModes == IntPtr.Zero)
				id_loadBeaconModes = JNIEnv.GetMethodID (class_ref, "loadBeaconModes", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadBeaconModes);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadBeaconModes", "()V"));
			} finally {
			}
		}

		static Delegate cb_loadBeaconWithBeaconID_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetLoadBeaconWithBeaconID_Ljava_lang_String_IHandler ()
		{
			if (cb_loadBeaconWithBeaconID_Ljava_lang_String_I == null)
				cb_loadBeaconWithBeaconID_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_LoadBeaconWithBeaconID_Ljava_lang_String_I);
			return cb_loadBeaconWithBeaconID_Ljava_lang_String_I;
		}

		static void n_LoadBeaconWithBeaconID_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_beaconID, int version)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string beaconID = JNIEnv.GetString (native_beaconID, JniHandleOwnership.DoNotTransfer);
			__this.LoadBeaconWithBeaconID (beaconID, version);
		}
#pragma warning restore 0169

		static IntPtr id_loadBeaconWithBeaconID_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='loadBeaconWithBeaconID' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("loadBeaconWithBeaconID", "(Ljava/lang/String;I)V", "GetLoadBeaconWithBeaconID_Ljava_lang_String_IHandler")]
		public virtual unsafe void LoadBeaconWithBeaconID (string beaconID, int version)
		{
			if (id_loadBeaconWithBeaconID_Ljava_lang_String_I == IntPtr.Zero)
				id_loadBeaconWithBeaconID_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "loadBeaconWithBeaconID", "(Ljava/lang/String;I)V");
			IntPtr native_beaconID = JNIEnv.NewString (beaconID);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_beaconID);
				__args [1] = new JValue (version);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadBeaconWithBeaconID_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadBeaconWithBeaconID", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_beaconID);
			}
		}

		static Delegate cb_loadPlatformTypes;
#pragma warning disable 0169
		static Delegate GetLoadPlatformTypesHandler ()
		{
			if (cb_loadPlatformTypes == null)
				cb_loadPlatformTypes = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LoadPlatformTypes);
			return cb_loadPlatformTypes;
		}

		static void n_LoadPlatformTypes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadPlatformTypes ();
		}
#pragma warning restore 0169

		static IntPtr id_loadPlatformTypes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='loadPlatformTypes' and count(parameter)=0]"
		[Register ("loadPlatformTypes", "()V", "GetLoadPlatformTypesHandler")]
		public virtual unsafe void LoadPlatformTypes ()
		{
			if (id_loadPlatformTypes == IntPtr.Zero)
				id_loadPlatformTypes = JNIEnv.GetMethodID (class_ref, "loadPlatformTypes", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadPlatformTypes);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadPlatformTypes", "()V"));
			} finally {
			}
		}

		static Delegate cb_loadSiteAccessTypes;
#pragma warning disable 0169
		static Delegate GetLoadSiteAccessTypesHandler ()
		{
			if (cb_loadSiteAccessTypes == null)
				cb_loadSiteAccessTypes = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LoadSiteAccessTypes);
			return cb_loadSiteAccessTypes;
		}

		static void n_LoadSiteAccessTypes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadSiteAccessTypes ();
		}
#pragma warning restore 0169

		static IntPtr id_loadSiteAccessTypes;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='loadSiteAccessTypes' and count(parameter)=0]"
		[Register ("loadSiteAccessTypes", "()V", "GetLoadSiteAccessTypesHandler")]
		public virtual unsafe void LoadSiteAccessTypes ()
		{
			if (id_loadSiteAccessTypes == IntPtr.Zero)
				id_loadSiteAccessTypes = JNIEnv.GetMethodID (class_ref, "loadSiteAccessTypes", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadSiteAccessTypes);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadSiteAccessTypes", "()V"));
			} finally {
			}
		}

		static Delegate cb_loadTargetSpeeds;
#pragma warning disable 0169
		static Delegate GetLoadTargetSpeedsHandler ()
		{
			if (cb_loadTargetSpeeds == null)
				cb_loadTargetSpeeds = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_LoadTargetSpeeds);
			return cb_loadTargetSpeeds;
		}

		static void n_LoadTargetSpeeds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LoadTargetSpeeds ();
		}
#pragma warning restore 0169

		static IntPtr id_loadTargetSpeeds;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='loadTargetSpeeds' and count(parameter)=0]"
		[Register ("loadTargetSpeeds", "()V", "GetLoadTargetSpeedsHandler")]
		public virtual unsafe void LoadTargetSpeeds ()
		{
			if (id_loadTargetSpeeds == IntPtr.Zero)
				id_loadTargetSpeeds = JNIEnv.GetMethodID (class_ref, "loadTargetSpeeds", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadTargetSpeeds);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadTargetSpeeds", "()V"));
			} finally {
			}
		}

		static Delegate cb_logOff_Lcom_bluecats_sdk_BCAccountManagerCallback_;
#pragma warning disable 0169
		static Delegate GetLogOff_Lcom_bluecats_sdk_BCAccountManagerCallback_Handler ()
		{
			if (cb_logOff_Lcom_bluecats_sdk_BCAccountManagerCallback_ == null)
				cb_logOff_Lcom_bluecats_sdk_BCAccountManagerCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LogOff_Lcom_bluecats_sdk_BCAccountManagerCallback_);
			return cb_logOff_Lcom_bluecats_sdk_BCAccountManagerCallback_;
		}

		static void n_LogOff_Lcom_bluecats_sdk_BCAccountManagerCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCAccountManagerCallback @callback = (global::Com.Bluecats.Sdk.IBCAccountManagerCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCAccountManagerCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.LogOff (@callback);
		}
#pragma warning restore 0169

		static IntPtr id_logOff_Lcom_bluecats_sdk_BCAccountManagerCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='logOff' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCAccountManagerCallback']]"
		[Register ("logOff", "(Lcom/bluecats/sdk/BCAccountManagerCallback;)V", "GetLogOff_Lcom_bluecats_sdk_BCAccountManagerCallback_Handler")]
		public virtual unsafe void LogOff (global::Com.Bluecats.Sdk.IBCAccountManagerCallback @callback)
		{
			if (id_logOff_Lcom_bluecats_sdk_BCAccountManagerCallback_ == IntPtr.Zero)
				id_logOff_Lcom_bluecats_sdk_BCAccountManagerCallback_ = JNIEnv.GetMethodID (class_ref, "logOff", "(Lcom/bluecats/sdk/BCAccountManagerCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logOff_Lcom_bluecats_sdk_BCAccountManagerCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logOff", "(Lcom/bluecats/sdk/BCAccountManagerCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_reloadLookupModels;
#pragma warning disable 0169
		static Delegate GetReloadLookupModelsHandler ()
		{
			if (cb_reloadLookupModels == null)
				cb_reloadLookupModels = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReloadLookupModels);
			return cb_reloadLookupModels;
		}

		static void n_ReloadLookupModels (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReloadLookupModels ();
		}
#pragma warning restore 0169

		static IntPtr id_reloadLookupModels;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='reloadLookupModels' and count(parameter)=0]"
		[Register ("reloadLookupModels", "()V", "GetReloadLookupModelsHandler")]
		public virtual unsafe void ReloadLookupModels ()
		{
			if (id_reloadLookupModels == IntPtr.Zero)
				id_reloadLookupModels = JNIEnv.GetMethodID (class_ref, "reloadLookupModels", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reloadLookupModels);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reloadLookupModels", "()V"));
			} finally {
			}
		}

		static Delegate cb_verifyAppWithToken_Ljava_lang_String_Lcom_bluecats_sdk_BCAccountManagerCallback_;
#pragma warning disable 0169
		static Delegate GetVerifyAppWithToken_Ljava_lang_String_Lcom_bluecats_sdk_BCAccountManagerCallback_Handler ()
		{
			if (cb_verifyAppWithToken_Ljava_lang_String_Lcom_bluecats_sdk_BCAccountManagerCallback_ == null)
				cb_verifyAppWithToken_Ljava_lang_String_Lcom_bluecats_sdk_BCAccountManagerCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_VerifyAppWithToken_Ljava_lang_String_Lcom_bluecats_sdk_BCAccountManagerCallback_);
			return cb_verifyAppWithToken_Ljava_lang_String_Lcom_bluecats_sdk_BCAccountManagerCallback_;
		}

		static void n_VerifyAppWithToken_Ljava_lang_String_Lcom_bluecats_sdk_BCAccountManagerCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_appToken, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string appToken = JNIEnv.GetString (native_appToken, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCAccountManagerCallback @callback = (global::Com.Bluecats.Sdk.IBCAccountManagerCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCAccountManagerCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.VerifyAppWithToken (appToken, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_verifyAppWithToken_Ljava_lang_String_Lcom_bluecats_sdk_BCAccountManagerCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='verifyAppWithToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.bluecats.sdk.BCAccountManagerCallback']]"
		[Register ("verifyAppWithToken", "(Ljava/lang/String;Lcom/bluecats/sdk/BCAccountManagerCallback;)V", "GetVerifyAppWithToken_Ljava_lang_String_Lcom_bluecats_sdk_BCAccountManagerCallback_Handler")]
		public virtual unsafe void VerifyAppWithToken (string appToken, global::Com.Bluecats.Sdk.IBCAccountManagerCallback @callback)
		{
			if (id_verifyAppWithToken_Ljava_lang_String_Lcom_bluecats_sdk_BCAccountManagerCallback_ == IntPtr.Zero)
				id_verifyAppWithToken_Ljava_lang_String_Lcom_bluecats_sdk_BCAccountManagerCallback_ = JNIEnv.GetMethodID (class_ref, "verifyAppWithToken", "(Ljava/lang/String;Lcom/bluecats/sdk/BCAccountManagerCallback;)V");
			IntPtr native_appToken = JNIEnv.NewString (appToken);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_appToken);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_verifyAppWithToken_Ljava_lang_String_Lcom_bluecats_sdk_BCAccountManagerCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "verifyAppWithToken", "(Ljava/lang/String;Lcom/bluecats/sdk/BCAccountManagerCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_appToken);
			}
		}

		static Delegate cb_verifyCredentials_Lcom_bluecats_sdk_BCAccountManagerCallback_;
#pragma warning disable 0169
		static Delegate GetVerifyCredentials_Lcom_bluecats_sdk_BCAccountManagerCallback_Handler ()
		{
			if (cb_verifyCredentials_Lcom_bluecats_sdk_BCAccountManagerCallback_ == null)
				cb_verifyCredentials_Lcom_bluecats_sdk_BCAccountManagerCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_VerifyCredentials_Lcom_bluecats_sdk_BCAccountManagerCallback_);
			return cb_verifyCredentials_Lcom_bluecats_sdk_BCAccountManagerCallback_;
		}

		static void n_VerifyCredentials_Lcom_bluecats_sdk_BCAccountManagerCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCAccountManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAccountManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCAccountManagerCallback @callback = (global::Com.Bluecats.Sdk.IBCAccountManagerCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCAccountManagerCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.VerifyCredentials (@callback);
		}
#pragma warning restore 0169

		static IntPtr id_verifyCredentials_Lcom_bluecats_sdk_BCAccountManagerCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAccountManager']/method[@name='verifyCredentials' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCAccountManagerCallback']]"
		[Register ("verifyCredentials", "(Lcom/bluecats/sdk/BCAccountManagerCallback;)V", "GetVerifyCredentials_Lcom_bluecats_sdk_BCAccountManagerCallback_Handler")]
		public virtual unsafe void VerifyCredentials (global::Com.Bluecats.Sdk.IBCAccountManagerCallback @callback)
		{
			if (id_verifyCredentials_Lcom_bluecats_sdk_BCAccountManagerCallback_ == IntPtr.Zero)
				id_verifyCredentials_Lcom_bluecats_sdk_BCAccountManagerCallback_ = JNIEnv.GetMethodID (class_ref, "verifyCredentials", "(Lcom/bluecats/sdk/BCAccountManagerCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_verifyCredentials_Lcom_bluecats_sdk_BCAccountManagerCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "verifyCredentials", "(Lcom/bluecats/sdk/BCAccountManagerCallback;)V"), __args);
			} finally {
			}
		}

	}
}
