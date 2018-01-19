using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteSyncResult']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCSiteSyncResult", DoNotGenerateAcw=true)]
	public partial class BCSiteSyncResult : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCSiteSyncResult", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCSiteSyncResult); }
		}

		protected BCSiteSyncResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteSyncResult']/constructor[@name='BCSiteSyncResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCSiteSyncResult ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCSiteSyncResult)) {
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

		static Delegate cb_getHttpStatusCode;
#pragma warning disable 0169
		static Delegate GetGetHttpStatusCodeHandler ()
		{
			if (cb_getHttpStatusCode == null)
				cb_getHttpStatusCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHttpStatusCode);
			return cb_getHttpStatusCode;
		}

		static int n_GetHttpStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCSiteSyncResult __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteSyncResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HttpStatusCode;
		}
#pragma warning restore 0169

		static Delegate cb_setHttpStatusCode_I;
#pragma warning disable 0169
		static Delegate GetSetHttpStatusCode_IHandler ()
		{
			if (cb_setHttpStatusCode_I == null)
				cb_setHttpStatusCode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHttpStatusCode_I);
			return cb_setHttpStatusCode_I;
		}

		static void n_SetHttpStatusCode_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Bluecats.Sdk.BCSiteSyncResult __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteSyncResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HttpStatusCode = value;
		}
#pragma warning restore 0169

		static IntPtr id_getHttpStatusCode;
		static IntPtr id_setHttpStatusCode_I;
		public virtual unsafe int HttpStatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteSyncResult']/method[@name='getHttpStatusCode' and count(parameter)=0]"
			[Register ("getHttpStatusCode", "()I", "GetGetHttpStatusCodeHandler")]
			get {
				if (id_getHttpStatusCode == IntPtr.Zero)
					id_getHttpStatusCode = JNIEnv.GetMethodID (class_ref, "getHttpStatusCode", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHttpStatusCode);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHttpStatusCode", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteSyncResult']/method[@name='setHttpStatusCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHttpStatusCode", "(I)V", "GetSetHttpStatusCode_IHandler")]
			set {
				if (id_setHttpStatusCode_I == IntPtr.Zero)
					id_setHttpStatusCode_I = JNIEnv.GetMethodID (class_ref, "setHttpStatusCode", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHttpStatusCode_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHttpStatusCode", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isIncludingLatestForApp;
#pragma warning disable 0169
		static Delegate GetIsIncludingLatestForAppHandler ()
		{
			if (cb_isIncludingLatestForApp == null)
				cb_isIncludingLatestForApp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsIncludingLatestForApp);
			return cb_isIncludingLatestForApp;
		}

		static bool n_IsIncludingLatestForApp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCSiteSyncResult __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteSyncResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIncludingLatestForApp;
		}
#pragma warning restore 0169

		static IntPtr id_isIncludingLatestForApp;
		public virtual unsafe bool IsIncludingLatestForApp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteSyncResult']/method[@name='isIncludingLatestForApp' and count(parameter)=0]"
			[Register ("isIncludingLatestForApp", "()Z", "GetIsIncludingLatestForAppHandler")]
			get {
				if (id_isIncludingLatestForApp == IntPtr.Zero)
					id_isIncludingLatestForApp = JNIEnv.GetMethodID (class_ref, "isIncludingLatestForApp", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isIncludingLatestForApp);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isIncludingLatestForApp", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getModifiedAfter;
#pragma warning disable 0169
		static Delegate GetGetModifiedAfterHandler ()
		{
			if (cb_getModifiedAfter == null)
				cb_getModifiedAfter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetModifiedAfter);
			return cb_getModifiedAfter;
		}

		static IntPtr n_GetModifiedAfter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCSiteSyncResult __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteSyncResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ModifiedAfter);
		}
#pragma warning restore 0169

		static Delegate cb_setModifiedAfter_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetModifiedAfter_Ljava_util_Date_Handler ()
		{
			if (cb_setModifiedAfter_Ljava_util_Date_ == null)
				cb_setModifiedAfter_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetModifiedAfter_Ljava_util_Date_);
			return cb_setModifiedAfter_Ljava_util_Date_;
		}

		static void n_SetModifiedAfter_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCSiteSyncResult __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteSyncResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.ModifiedAfter = value;
		}
#pragma warning restore 0169

		static IntPtr id_getModifiedAfter;
		static IntPtr id_setModifiedAfter_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date ModifiedAfter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteSyncResult']/method[@name='getModifiedAfter' and count(parameter)=0]"
			[Register ("getModifiedAfter", "()Ljava/util/Date;", "GetGetModifiedAfterHandler")]
			get {
				if (id_getModifiedAfter == IntPtr.Zero)
					id_getModifiedAfter = JNIEnv.GetMethodID (class_ref, "getModifiedAfter", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getModifiedAfter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getModifiedAfter", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteSyncResult']/method[@name='setModifiedAfter' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setModifiedAfter", "(Ljava/util/Date;)V", "GetSetModifiedAfter_Ljava_util_Date_Handler")]
			set {
				if (id_setModifiedAfter_Ljava_util_Date_ == IntPtr.Zero)
					id_setModifiedAfter_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setModifiedAfter", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setModifiedAfter_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setModifiedAfter", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
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
			global::Com.Bluecats.Sdk.BCSiteSyncResult __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteSyncResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetSiteID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCSiteSyncResult __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteSyncResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SiteID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getSiteID;
		static IntPtr id_setSiteID_Ljava_lang_String_;
		public virtual unsafe string SiteID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteSyncResult']/method[@name='getSiteID' and count(parameter)=0]"
			[Register ("getSiteID", "()Ljava/lang/String;", "GetGetSiteIDHandler")]
			get {
				if (id_getSiteID == IntPtr.Zero)
					id_getSiteID = JNIEnv.GetMethodID (class_ref, "getSiteID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSiteID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSiteID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteSyncResult']/method[@name='setSiteID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSiteID", "(Ljava/lang/String;)V", "GetSetSiteID_Ljava_lang_String_Handler")]
			set {
				if (id_setSiteID_Ljava_lang_String_ == IntPtr.Zero)
					id_setSiteID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSiteID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSiteID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSiteID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSites;
#pragma warning disable 0169
		static Delegate GetGetSitesHandler ()
		{
			if (cb_getSites == null)
				cb_getSites = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSites);
			return cb_getSites;
		}

		static IntPtr n_GetSites (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCSiteSyncResult __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteSyncResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCSiteInternal>.ToLocalJniHandle (__this.Sites);
		}
#pragma warning restore 0169

		static Delegate cb_setSites_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetSites_Ljava_util_List_Handler ()
		{
			if (cb_setSites_Ljava_util_List_ == null)
				cb_setSites_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSites_Ljava_util_List_);
			return cb_setSites_Ljava_util_List_;
		}

		static void n_SetSites_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCSiteSyncResult __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteSyncResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCSiteInternal>.FromJniHandle (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Sites = value;
		}
#pragma warning restore 0169

		static IntPtr id_getSites;
		static IntPtr id_setSites_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCSiteInternal> Sites {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteSyncResult']/method[@name='getSites' and count(parameter)=0]"
			[Register ("getSites", "()Ljava/util/List;", "GetGetSitesHandler")]
			get {
				if (id_getSites == IntPtr.Zero)
					id_getSites = JNIEnv.GetMethodID (class_ref, "getSites", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCSiteInternal>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSites), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCSiteInternal>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSites", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteSyncResult']/method[@name='setSites' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCSiteInternal&gt;']]"
			[Register ("setSites", "(Ljava/util/List;)V", "GetSetSites_Ljava_util_List_Handler")]
			set {
				if (id_setSites_Ljava_util_List_ == IntPtr.Zero)
					id_setSites_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setSites", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCSiteInternal>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSites_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSites", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_setIsIncludeLatestForApp_Z;
#pragma warning disable 0169
		static Delegate GetSetIsIncludeLatestForApp_ZHandler ()
		{
			if (cb_setIsIncludeLatestForApp_Z == null)
				cb_setIsIncludeLatestForApp_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsIncludeLatestForApp_Z);
			return cb_setIsIncludeLatestForApp_Z;
		}

		static void n_SetIsIncludeLatestForApp_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::Com.Bluecats.Sdk.BCSiteSyncResult __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteSyncResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIsIncludeLatestForApp (value);
		}
#pragma warning restore 0169

		static IntPtr id_setIsIncludeLatestForApp_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteSyncResult']/method[@name='setIsIncludeLatestForApp' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIsIncludeLatestForApp", "(Z)V", "GetSetIsIncludeLatestForApp_ZHandler")]
		public virtual unsafe void SetIsIncludeLatestForApp (bool value)
		{
			if (id_setIsIncludeLatestForApp_Z == IntPtr.Zero)
				id_setIsIncludeLatestForApp_Z = JNIEnv.GetMethodID (class_ref, "setIsIncludeLatestForApp", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIsIncludeLatestForApp_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsIncludeLatestForApp", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
