using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppApi']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCAppApi", DoNotGenerateAcw=true)]
	public partial class BCAppApi : global::Java.Lang.Object {


		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppApi']/field[@name='id']"
		[Register ("id")]
		protected string Id {
			get {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, id_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, id_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mAppCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppApi']/field[@name='mAppCallback']"
		[Register ("mAppCallback")]
		protected global::Com.Bluecats.Sdk.IBCAppCallback MAppCallback {
			get {
				if (mAppCallback_jfieldId == IntPtr.Zero)
					mAppCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mAppCallback", "Lcom/bluecats/sdk/BCAppCallback;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mAppCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCAppCallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mAppCallback_jfieldId == IntPtr.Zero)
					mAppCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mAppCallback", "Lcom/bluecats/sdk/BCAppCallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mAppCallback_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCAppApi", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCAppApi); }
		}

		protected BCAppApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppApi']/constructor[@name='BCAppApi' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCAppApi ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCAppApi)) {
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
			global::Com.Bluecats.Sdk.BCAppApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetAppID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCAppApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AppID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getAppID;
		static IntPtr id_setAppID_Ljava_lang_String_;
		public virtual unsafe string AppID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppApi']/method[@name='getAppID' and count(parameter)=0]"
			[Register ("getAppID", "()Ljava/lang/String;", "GetGetAppIDHandler")]
			get {
				if (id_getAppID == IntPtr.Zero)
					id_getAppID = JNIEnv.GetMethodID (class_ref, "getAppID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppApi']/method[@name='setAppID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppID", "(Ljava/lang/String;)V", "GetSetAppID_Ljava_lang_String_Handler")]
			set {
				if (id_setAppID_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
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
			global::Com.Bluecats.Sdk.BCAppApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.ToLocalJniHandle (__this.CachedBeacons);
		}
#pragma warning restore 0169

		static IntPtr id_getCachedBeacons;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> CachedBeacons {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppApi']/method[@name='getCachedBeacons' and count(parameter)=0]"
			[Register ("getCachedBeacons", "()Ljava/util/List;", "GetGetCachedBeaconsHandler")]
			get {
				if (id_getCachedBeacons == IntPtr.Zero)
					id_getCachedBeacons = JNIEnv.GetMethodID (class_ref, "getCachedBeacons", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedBeacons), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedBeacons", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCachedBeaconsAt;
#pragma warning disable 0169
		static Delegate GetGetCachedBeaconsAtHandler ()
		{
			if (cb_getCachedBeaconsAt == null)
				cb_getCachedBeaconsAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedBeaconsAt);
			return cb_getCachedBeaconsAt;
		}

		static IntPtr n_GetCachedBeaconsAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAppApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CachedBeaconsAt);
		}
#pragma warning restore 0169

		static IntPtr id_getCachedBeaconsAt;
		public virtual unsafe global::Java.Util.Date CachedBeaconsAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppApi']/method[@name='getCachedBeaconsAt' and count(parameter)=0]"
			[Register ("getCachedBeaconsAt", "()Ljava/util/Date;", "GetGetCachedBeaconsAtHandler")]
			get {
				if (id_getCachedBeaconsAt == IntPtr.Zero)
					id_getCachedBeaconsAt = JNIEnv.GetMethodID (class_ref, "getCachedBeaconsAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedBeaconsAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedBeaconsAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCachedSites;
#pragma warning disable 0169
		static Delegate GetGetCachedSitesHandler ()
		{
			if (cb_getCachedSites == null)
				cb_getCachedSites = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedSites);
			return cb_getCachedSites;
		}

		static IntPtr n_GetCachedSites (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAppApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCSiteInternal>.ToLocalJniHandle (__this.CachedSites);
		}
#pragma warning restore 0169

		static IntPtr id_getCachedSites;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCSiteInternal> CachedSites {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppApi']/method[@name='getCachedSites' and count(parameter)=0]"
			[Register ("getCachedSites", "()Ljava/util/List;", "GetGetCachedSitesHandler")]
			get {
				if (id_getCachedSites == IntPtr.Zero)
					id_getCachedSites = JNIEnv.GetMethodID (class_ref, "getCachedSites", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCSiteInternal>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedSites), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCSiteInternal>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedSites", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCachedSitesAt;
#pragma warning disable 0169
		static Delegate GetGetCachedSitesAtHandler ()
		{
			if (cb_getCachedSitesAt == null)
				cb_getCachedSitesAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedSitesAt);
			return cb_getCachedSitesAt;
		}

		static IntPtr n_GetCachedSitesAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAppApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CachedSitesAt);
		}
#pragma warning restore 0169

		static IntPtr id_getCachedSitesAt;
		public virtual unsafe global::Java.Util.Date CachedSitesAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppApi']/method[@name='getCachedSitesAt' and count(parameter)=0]"
			[Register ("getCachedSitesAt", "()Ljava/util/Date;", "GetGetCachedSitesAtHandler")]
			get {
				if (id_getCachedSitesAt == IntPtr.Zero)
					id_getCachedSitesAt = JNIEnv.GetMethodID (class_ref, "getCachedSitesAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedSitesAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedSitesAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasBeaconsCacheExpired;
#pragma warning disable 0169
		static Delegate GetHasBeaconsCacheExpiredHandler ()
		{
			if (cb_hasBeaconsCacheExpired == null)
				cb_hasBeaconsCacheExpired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasBeaconsCacheExpired);
			return cb_hasBeaconsCacheExpired;
		}

		static bool n_HasBeaconsCacheExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAppApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBeaconsCacheExpired;
		}
#pragma warning restore 0169

		static IntPtr id_hasBeaconsCacheExpired;
		public virtual unsafe bool HasBeaconsCacheExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppApi']/method[@name='hasBeaconsCacheExpired' and count(parameter)=0]"
			[Register ("hasBeaconsCacheExpired", "()Z", "GetHasBeaconsCacheExpiredHandler")]
			get {
				if (id_hasBeaconsCacheExpired == IntPtr.Zero)
					id_hasBeaconsCacheExpired = JNIEnv.GetMethodID (class_ref, "hasBeaconsCacheExpired", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasBeaconsCacheExpired);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasBeaconsCacheExpired", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_hasSitesCacheExpired;
#pragma warning disable 0169
		static Delegate GetHasSitesCacheExpiredHandler ()
		{
			if (cb_hasSitesCacheExpired == null)
				cb_hasSitesCacheExpired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasSitesCacheExpired);
			return cb_hasSitesCacheExpired;
		}

		static bool n_HasSitesCacheExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAppApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasSitesCacheExpired;
		}
#pragma warning restore 0169

		static IntPtr id_hasSitesCacheExpired;
		public virtual unsafe bool HasSitesCacheExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppApi']/method[@name='hasSitesCacheExpired' and count(parameter)=0]"
			[Register ("hasSitesCacheExpired", "()Z", "GetHasSitesCacheExpiredHandler")]
			get {
				if (id_hasSitesCacheExpired == IntPtr.Zero)
					id_hasSitesCacheExpired = JNIEnv.GetMethodID (class_ref, "hasSitesCacheExpired", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasSitesCacheExpired);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasSitesCacheExpired", "()Z"));
				} finally {
				}
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
			global::Com.Bluecats.Sdk.BCAppApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetTeamID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCAppApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.TeamID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getTeamID;
		static IntPtr id_setTeamID_Ljava_lang_String_;
		public virtual unsafe string TeamID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppApi']/method[@name='getTeamID' and count(parameter)=0]"
			[Register ("getTeamID", "()Ljava/lang/String;", "GetGetTeamIDHandler")]
			get {
				if (id_getTeamID == IntPtr.Zero)
					id_getTeamID = JNIEnv.GetMethodID (class_ref, "getTeamID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTeamID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTeamID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppApi']/method[@name='setTeamID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTeamID", "(Ljava/lang/String;)V", "GetSetTeamID_Ljava_lang_String_Handler")]
			set {
				if (id_setTeamID_Ljava_lang_String_ == IntPtr.Zero)
					id_setTeamID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTeamID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTeamID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTeamID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAppInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCAppCallback_;
#pragma warning disable 0169
		static Delegate GetGetAppInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCAppCallback_Handler ()
		{
			if (cb_getAppInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCAppCallback_ == null)
				cb_getAppInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCAppCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr>) n_GetAppInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCAppCallback_);
			return cb_getAppInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCAppCallback_;
		}

		static void n_GetAppInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCAppCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_endDate, IntPtr native_period, long duration, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCAppApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date endDate = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_endDate, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod period = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod> (native_period, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCAppCallback @callback = (global::Com.Bluecats.Sdk.IBCAppCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCAppCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetAppInsightsForEndDate (endDate, period, duration, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_getAppInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCAppCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppApi']/method[@name='getAppInsightsForEndDate' and count(parameter)=4 and parameter[1][@type='java.util.Date'] and parameter[2][@type='com.bluecats.sdk.BCInsights.BCInsightsPeriod'] and parameter[3][@type='long'] and parameter[4][@type='com.bluecats.sdk.BCAppCallback']]"
		[Register ("getAppInsightsForEndDate", "(Ljava/util/Date;Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;JLcom/bluecats/sdk/BCAppCallback;)V", "GetGetAppInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCAppCallback_Handler")]
		public virtual unsafe void GetAppInsightsForEndDate (global::Java.Util.Date endDate, global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod period, long duration, global::Com.Bluecats.Sdk.IBCAppCallback @callback)
		{
			if (id_getAppInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCAppCallback_ == IntPtr.Zero)
				id_getAppInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCAppCallback_ = JNIEnv.GetMethodID (class_ref, "getAppInsightsForEndDate", "(Ljava/util/Date;Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;JLcom/bluecats/sdk/BCAppCallback;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (endDate);
				__args [1] = new JValue (period);
				__args [2] = new JValue (duration);
				__args [3] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getAppInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCAppCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppInsightsForEndDate", "(Ljava/util/Date;Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;JLcom/bluecats/sdk/BCAppCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_;
#pragma warning disable 0169
		static Delegate GetGetAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_Handler ()
		{
			if (cb_getAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_ == null)
				cb_getAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_);
			return cb_getAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_;
		}

		static void n_GetAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_app, IntPtr native_appToken, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCAppApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCApp app = (global::Com.Bluecats.Sdk.IBCApp)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (native_app, JniHandleOwnership.DoNotTransfer);
			string appToken = JNIEnv.GetString (native_appToken, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCAppCallback @callback = (global::Com.Bluecats.Sdk.IBCAppCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCAppCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetAppToken (app, appToken, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_getAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppApi']/method[@name='getAppToken' and count(parameter)=3 and parameter[1][@type='com.bluecats.sdk.BCApp'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.bluecats.sdk.BCAppCallback']]"
		[Register ("getAppToken", "(Lcom/bluecats/sdk/BCApp;Ljava/lang/String;Lcom/bluecats/sdk/BCAppCallback;)V", "GetGetAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_Handler")]
		public virtual unsafe void GetAppToken (global::Com.Bluecats.Sdk.IBCApp app, string appToken, global::Com.Bluecats.Sdk.IBCAppCallback @callback)
		{
			if (id_getAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_ == IntPtr.Zero)
				id_getAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_ = JNIEnv.GetMethodID (class_ref, "getAppToken", "(Lcom/bluecats/sdk/BCApp;Ljava/lang/String;Lcom/bluecats/sdk/BCAppCallback;)V");
			IntPtr native_appToken = JNIEnv.NewString (appToken);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (app);
				__args [1] = new JValue (native_appToken);
				__args [2] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getAppToken_Lcom_bluecats_sdk_BCApp_Ljava_lang_String_Lcom_bluecats_sdk_BCAppCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppToken", "(Lcom/bluecats/sdk/BCApp;Ljava/lang/String;Lcom/bluecats/sdk/BCAppCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_appToken);
			}
		}

		static Delegate cb_getBeacons_ZLcom_bluecats_sdk_BCAppCallback_;
#pragma warning disable 0169
		static Delegate GetGetBeacons_ZLcom_bluecats_sdk_BCAppCallback_Handler ()
		{
			if (cb_getBeacons_ZLcom_bluecats_sdk_BCAppCallback_ == null)
				cb_getBeacons_ZLcom_bluecats_sdk_BCAppCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_GetBeacons_ZLcom_bluecats_sdk_BCAppCallback_);
			return cb_getBeacons_ZLcom_bluecats_sdk_BCAppCallback_;
		}

		static void n_GetBeacons_ZLcom_bluecats_sdk_BCAppCallback_ (IntPtr jnienv, IntPtr native__this, bool preferCached, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCAppApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCAppCallback @callback = (global::Com.Bluecats.Sdk.IBCAppCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCAppCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetBeacons (preferCached, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_getBeacons_ZLcom_bluecats_sdk_BCAppCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppApi']/method[@name='getBeacons' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.bluecats.sdk.BCAppCallback']]"
		[Register ("getBeacons", "(ZLcom/bluecats/sdk/BCAppCallback;)V", "GetGetBeacons_ZLcom_bluecats_sdk_BCAppCallback_Handler")]
		public virtual unsafe void GetBeacons (bool preferCached, global::Com.Bluecats.Sdk.IBCAppCallback @callback)
		{
			if (id_getBeacons_ZLcom_bluecats_sdk_BCAppCallback_ == IntPtr.Zero)
				id_getBeacons_ZLcom_bluecats_sdk_BCAppCallback_ = JNIEnv.GetMethodID (class_ref, "getBeacons", "(ZLcom/bluecats/sdk/BCAppCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (preferCached);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getBeacons_ZLcom_bluecats_sdk_BCAppCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeacons", "(ZLcom/bluecats/sdk/BCAppCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getSites_ZLcom_bluecats_sdk_BCAppCallback_;
#pragma warning disable 0169
		static Delegate GetGetSites_ZLcom_bluecats_sdk_BCAppCallback_Handler ()
		{
			if (cb_getSites_ZLcom_bluecats_sdk_BCAppCallback_ == null)
				cb_getSites_ZLcom_bluecats_sdk_BCAppCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_GetSites_ZLcom_bluecats_sdk_BCAppCallback_);
			return cb_getSites_ZLcom_bluecats_sdk_BCAppCallback_;
		}

		static void n_GetSites_ZLcom_bluecats_sdk_BCAppCallback_ (IntPtr jnienv, IntPtr native__this, bool preferCached, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCAppApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCAppCallback @callback = (global::Com.Bluecats.Sdk.IBCAppCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCAppCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetSites (preferCached, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_getSites_ZLcom_bluecats_sdk_BCAppCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppApi']/method[@name='getSites' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.bluecats.sdk.BCAppCallback']]"
		[Register ("getSites", "(ZLcom/bluecats/sdk/BCAppCallback;)V", "GetGetSites_ZLcom_bluecats_sdk_BCAppCallback_Handler")]
		public virtual unsafe void GetSites (bool preferCached, global::Com.Bluecats.Sdk.IBCAppCallback @callback)
		{
			if (id_getSites_ZLcom_bluecats_sdk_BCAppCallback_ == IntPtr.Zero)
				id_getSites_ZLcom_bluecats_sdk_BCAppCallback_ = JNIEnv.GetMethodID (class_ref, "getSites", "(ZLcom/bluecats/sdk/BCAppCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (preferCached);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getSites_ZLcom_bluecats_sdk_BCAppCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSites", "(ZLcom/bluecats/sdk/BCAppCallback;)V"), __args);
			} finally {
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

		static void n_UpdateApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCAppCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_app, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCAppApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCApp app = (global::Com.Bluecats.Sdk.IBCApp)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (native_app, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCAppCallback @callback = (global::Com.Bluecats.Sdk.IBCAppCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCAppCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.UpdateApp (app, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_updateApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCAppCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppApi']/method[@name='updateApp' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCApp'] and parameter[2][@type='com.bluecats.sdk.BCAppCallback']]"
		[Register ("updateApp", "(Lcom/bluecats/sdk/BCApp;Lcom/bluecats/sdk/BCAppCallback;)V", "GetUpdateApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCAppCallback_Handler")]
		public virtual unsafe void UpdateApp (global::Com.Bluecats.Sdk.IBCApp app, global::Com.Bluecats.Sdk.IBCAppCallback @callback)
		{
			if (id_updateApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCAppCallback_ == IntPtr.Zero)
				id_updateApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCAppCallback_ = JNIEnv.GetMethodID (class_ref, "updateApp", "(Lcom/bluecats/sdk/BCApp;Lcom/bluecats/sdk/BCAppCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (app);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCAppCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateApp", "(Lcom/bluecats/sdk/BCApp;Lcom/bluecats/sdk/BCAppCallback;)V"), __args);
			} finally {
			}
		}

	}
}
