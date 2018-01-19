using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCBeaconApi", DoNotGenerateAcw=true)]
	public partial class BCBeaconApi : global::Java.Lang.Object {


		static IntPtr categories_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/field[@name='categories']"
		[Register ("categories")]
		protected IList<Com.Bluecats.Sdk.BCCategory> Categories {
			get {
				if (categories_jfieldId == IntPtr.Zero)
					categories_jfieldId = JNIEnv.GetFieldID (class_ref, "categories", "[Lcom/bluecats/sdk/BCCategory;");
				return global::Android.Runtime.JavaArray<global::Com.Bluecats.Sdk.BCCategory>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, categories_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (categories_jfieldId == IntPtr.Zero)
					categories_jfieldId = JNIEnv.GetFieldID (class_ref, "categories", "[Lcom/bluecats/sdk/BCCategory;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Bluecats.Sdk.BCCategory>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, categories_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr customValues_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/field[@name='customValues']"
		[Register ("customValues")]
		protected IList<Com.Bluecats.Sdk.BCCustomValue> CustomValues {
			get {
				if (customValues_jfieldId == IntPtr.Zero)
					customValues_jfieldId = JNIEnv.GetFieldID (class_ref, "customValues", "[Lcom/bluecats/sdk/BCCustomValue;");
				return global::Android.Runtime.JavaArray<global::Com.Bluecats.Sdk.BCCustomValue>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, customValues_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (customValues_jfieldId == IntPtr.Zero)
					customValues_jfieldId = JNIEnv.GetFieldID (class_ref, "customValues", "[Lcom/bluecats/sdk/BCCustomValue;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Bluecats.Sdk.BCCustomValue>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, customValues_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/field[@name='id']"
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

		static IntPtr mBeaconCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/field[@name='mBeaconCallback']"
		[Register ("mBeaconCallback")]
		protected global::Com.Bluecats.Sdk.IBCBeaconCallback MBeaconCallback {
			get {
				if (mBeaconCallback_jfieldId == IntPtr.Zero)
					mBeaconCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mBeaconCallback", "Lcom/bluecats/sdk/BCBeaconCallback;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mBeaconCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mBeaconCallback_jfieldId == IntPtr.Zero)
					mBeaconCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mBeaconCallback", "Lcom/bluecats/sdk/BCBeaconCallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mBeaconCallback_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCBeaconApi", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCBeaconApi); }
		}

		protected BCBeaconApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/constructor[@name='BCBeaconApi' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCBeaconApi ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCBeaconApi)) {
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
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetBeaconID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.BeaconID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconID;
		static IntPtr id_setBeaconID_Ljava_lang_String_;
		public virtual unsafe string BeaconID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='getBeaconID' and count(parameter)=0]"
			[Register ("getBeaconID", "()Ljava/lang/String;", "GetGetBeaconIDHandler")]
			get {
				if (id_getBeaconID == IntPtr.Zero)
					id_getBeaconID = JNIEnv.GetMethodID (class_ref, "getBeaconID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeaconID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='setBeaconID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBeaconID", "(Ljava/lang/String;)V", "GetSetBeaconID_Ljava_lang_String_Handler")]
			set {
				if (id_setBeaconID_Ljava_lang_String_ == IntPtr.Zero)
					id_setBeaconID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBeaconID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeaconID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBeaconID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBeaconVersionPaginator;
#pragma warning disable 0169
		static Delegate GetGetBeaconVersionPaginatorHandler ()
		{
			if (cb_getBeaconVersionPaginator == null)
				cb_getBeaconVersionPaginator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeaconVersionPaginator);
			return cb_getBeaconVersionPaginator;
		}

		static IntPtr n_GetBeaconVersionPaginator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BeaconVersionPaginator);
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconVersionPaginator;
		public virtual unsafe global::Java.Lang.Object BeaconVersionPaginator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='getBeaconVersionPaginator' and count(parameter)=0]"
			[Register ("getBeaconVersionPaginator", "()Ljava/lang/Object;", "GetGetBeaconVersionPaginatorHandler")]
			get {
				if (id_getBeaconVersionPaginator == IntPtr.Zero)
					id_getBeaconVersionPaginator = JNIEnv.GetMethodID (class_ref, "getBeaconVersionPaginator", "()Ljava/lang/Object;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconVersionPaginator), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeaconVersionPaginator", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Site);
		}
#pragma warning restore 0169

		static Delegate cb_setSite_Lcom_bluecats_sdk_BCSite_;
#pragma warning disable 0169
		static Delegate GetSetSite_Lcom_bluecats_sdk_BCSite_Handler ()
		{
			if (cb_setSite_Lcom_bluecats_sdk_BCSite_ == null)
				cb_setSite_Lcom_bluecats_sdk_BCSite_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSite_Lcom_bluecats_sdk_BCSite_);
			return cb_setSite_Lcom_bluecats_sdk_BCSite_;
		}

		static void n_SetSite_Lcom_bluecats_sdk_BCSite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite value = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Site = value;
		}
#pragma warning restore 0169

		static IntPtr id_getSite;
		static IntPtr id_setSite_Lcom_bluecats_sdk_BCSite_;
		public virtual unsafe global::Com.Bluecats.Sdk.IBCSite Site {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='getSite' and count(parameter)=0]"
			[Register ("getSite", "()Lcom/bluecats/sdk/BCSite;", "GetGetSiteHandler")]
			get {
				if (id_getSite == IntPtr.Zero)
					id_getSite = JNIEnv.GetMethodID (class_ref, "getSite", "()Lcom/bluecats/sdk/BCSite;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSite), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSite", "()Lcom/bluecats/sdk/BCSite;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='setSite' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCSite']]"
			[Register ("setSite", "(Lcom/bluecats/sdk/BCSite;)V", "GetSetSite_Lcom_bluecats_sdk_BCSite_Handler")]
			set {
				if (id_setSite_Lcom_bluecats_sdk_BCSite_ == IntPtr.Zero)
					id_setSite_Lcom_bluecats_sdk_BCSite_ = JNIEnv.GetMethodID (class_ref, "setSite", "(Lcom/bluecats/sdk/BCSite;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSite_Lcom_bluecats_sdk_BCSite_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSite", "(Lcom/bluecats/sdk/BCSite;)V"), __args);
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
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SiteID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getSiteID;
		static IntPtr id_setSiteID_Ljava_lang_String_;
		public virtual unsafe string SiteID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='getSiteID' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='setSiteID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SiteName);
		}
#pragma warning restore 0169

		static Delegate cb_setSiteName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSiteName_Ljava_lang_String_Handler ()
		{
			if (cb_setSiteName_Ljava_lang_String_ == null)
				cb_setSiteName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSiteName_Ljava_lang_String_);
			return cb_setSiteName_Ljava_lang_String_;
		}

		static void n_SetSiteName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SiteName = value;
		}
#pragma warning restore 0169

		static IntPtr id_getSiteName;
		static IntPtr id_setSiteName_Ljava_lang_String_;
		public virtual unsafe string SiteName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='getSiteName' and count(parameter)=0]"
			[Register ("getSiteName", "()Ljava/lang/String;", "GetGetSiteNameHandler")]
			get {
				if (id_getSiteName == IntPtr.Zero)
					id_getSiteName = JNIEnv.GetMethodID (class_ref, "getSiteName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSiteName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSiteName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='setSiteName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSiteName", "(Ljava/lang/String;)V", "GetSetSiteName_Ljava_lang_String_Handler")]
			set {
				if (id_setSiteName_Ljava_lang_String_ == IntPtr.Zero)
					id_setSiteName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSiteName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSiteName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSiteName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.TeamID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getTeamID;
		static IntPtr id_setTeamID_Ljava_lang_String_;
		public virtual unsafe string TeamID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='getTeamID' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='setTeamID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_confirmBeaconUpdateWithStatusData_arrayBLcom_bluecats_sdk_BCBeaconCallback_;
#pragma warning disable 0169
		static Delegate GetConfirmBeaconUpdateWithStatusData_arrayBLcom_bluecats_sdk_BCBeaconCallback_Handler ()
		{
			if (cb_confirmBeaconUpdateWithStatusData_arrayBLcom_bluecats_sdk_BCBeaconCallback_ == null)
				cb_confirmBeaconUpdateWithStatusData_arrayBLcom_bluecats_sdk_BCBeaconCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ConfirmBeaconUpdateWithStatusData_arrayBLcom_bluecats_sdk_BCBeaconCallback_);
			return cb_confirmBeaconUpdateWithStatusData_arrayBLcom_bluecats_sdk_BCBeaconCallback_;
		}

		static void n_ConfirmBeaconUpdateWithStatusData_arrayBLcom_bluecats_sdk_BCBeaconCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_status, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] status = (byte[]) JNIEnv.GetArray (native_status, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.Bluecats.Sdk.IBCBeaconCallback @callback = (global::Com.Bluecats.Sdk.IBCBeaconCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.ConfirmBeaconUpdateWithStatusData (status, @callback);
			if (status != null)
				JNIEnv.CopyArray (status, native_status);
		}
#pragma warning restore 0169

		static IntPtr id_confirmBeaconUpdateWithStatusData_arrayBLcom_bluecats_sdk_BCBeaconCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='confirmBeaconUpdateWithStatusData' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.bluecats.sdk.BCBeaconCallback']]"
		[Register ("confirmBeaconUpdateWithStatusData", "([BLcom/bluecats/sdk/BCBeaconCallback;)V", "GetConfirmBeaconUpdateWithStatusData_arrayBLcom_bluecats_sdk_BCBeaconCallback_Handler")]
		public virtual unsafe void ConfirmBeaconUpdateWithStatusData (byte[] status, global::Com.Bluecats.Sdk.IBCBeaconCallback @callback)
		{
			if (id_confirmBeaconUpdateWithStatusData_arrayBLcom_bluecats_sdk_BCBeaconCallback_ == IntPtr.Zero)
				id_confirmBeaconUpdateWithStatusData_arrayBLcom_bluecats_sdk_BCBeaconCallback_ = JNIEnv.GetMethodID (class_ref, "confirmBeaconUpdateWithStatusData", "([BLcom/bluecats/sdk/BCBeaconCallback;)V");
			IntPtr native_status = JNIEnv.NewArray (status);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_status);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_confirmBeaconUpdateWithStatusData_arrayBLcom_bluecats_sdk_BCBeaconCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "confirmBeaconUpdateWithStatusData", "([BLcom/bluecats/sdk/BCBeaconCallback;)V"), __args);
			} finally {
				if (status != null) {
					JNIEnv.CopyArray (native_status, status);
					JNIEnv.DeleteLocalRef (native_status);
				}
			}
		}

		static Delegate cb_confirmBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_;
#pragma warning disable 0169
		static Delegate GetConfirmBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_Handler ()
		{
			if (cb_confirmBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_ == null)
				cb_confirmBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ConfirmBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_);
			return cb_confirmBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_;
		}

		static void n_ConfirmBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_version, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer version = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_version, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeaconCallback @callback = (global::Com.Bluecats.Sdk.IBCBeaconCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.ConfirmBeaconVersion (version, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_confirmBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='confirmBeaconVersion' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='com.bluecats.sdk.BCBeaconCallback']]"
		[Register ("confirmBeaconVersion", "(Ljava/lang/Integer;Lcom/bluecats/sdk/BCBeaconCallback;)V", "GetConfirmBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_Handler")]
		public virtual unsafe void ConfirmBeaconVersion (global::Java.Lang.Integer version, global::Com.Bluecats.Sdk.IBCBeaconCallback @callback)
		{
			if (id_confirmBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_ == IntPtr.Zero)
				id_confirmBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_ = JNIEnv.GetMethodID (class_ref, "confirmBeaconVersion", "(Ljava/lang/Integer;Lcom/bluecats/sdk/BCBeaconCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (version);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_confirmBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "confirmBeaconVersion", "(Ljava/lang/Integer;Lcom/bluecats/sdk/BCBeaconCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getBeaconInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCBeaconCallback_;
#pragma warning disable 0169
		static Delegate GetGetBeaconInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCBeaconCallback_Handler ()
		{
			if (cb_getBeaconInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCBeaconCallback_ == null)
				cb_getBeaconInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCBeaconCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr>) n_GetBeaconInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCBeaconCallback_);
			return cb_getBeaconInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCBeaconCallback_;
		}

		static void n_GetBeaconInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCBeaconCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_endDate, IntPtr native_period, long duration, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date endDate = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_endDate, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod period = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod> (native_period, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeaconCallback @callback = (global::Com.Bluecats.Sdk.IBCBeaconCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetBeaconInsightsForEndDate (endDate, period, duration, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCBeaconCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='getBeaconInsightsForEndDate' and count(parameter)=4 and parameter[1][@type='java.util.Date'] and parameter[2][@type='com.bluecats.sdk.BCInsights.BCInsightsPeriod'] and parameter[3][@type='long'] and parameter[4][@type='com.bluecats.sdk.BCBeaconCallback']]"
		[Register ("getBeaconInsightsForEndDate", "(Ljava/util/Date;Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;JLcom/bluecats/sdk/BCBeaconCallback;)V", "GetGetBeaconInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCBeaconCallback_Handler")]
		public virtual unsafe void GetBeaconInsightsForEndDate (global::Java.Util.Date endDate, global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod period, long duration, global::Com.Bluecats.Sdk.IBCBeaconCallback @callback)
		{
			if (id_getBeaconInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCBeaconCallback_ == IntPtr.Zero)
				id_getBeaconInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCBeaconCallback_ = JNIEnv.GetMethodID (class_ref, "getBeaconInsightsForEndDate", "(Ljava/util/Date;Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;JLcom/bluecats/sdk/BCBeaconCallback;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (endDate);
				__args [1] = new JValue (period);
				__args [2] = new JValue (duration);
				__args [3] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCBeaconCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeaconInsightsForEndDate", "(Ljava/util/Date;Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;JLcom/bluecats/sdk/BCBeaconCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_Handler ()
		{
			if (cb_getBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ == null)
				cb_getBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_);
			return cb_getBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_;
		}

		static void n_GetBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback, IntPtr native_param)
		{
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeaconCallback @callback = (global::Com.Bluecats.Sdk.IBCBeaconCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			var param = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_param, JniHandleOwnership.DoNotTransfer);
			__this.GetBeaconLoudnessesFromApi (@callback, param);
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='getBeaconLoudnessesFromApi' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCBeaconCallback'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("getBeaconLoudnessesFromApi", "(Lcom/bluecats/sdk/BCBeaconCallback;Ljava/util/Map;)V", "GetGetBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_Handler")]
		public virtual unsafe void GetBeaconLoudnessesFromApi (global::Com.Bluecats.Sdk.IBCBeaconCallback @callback, global::System.Collections.Generic.IDictionary<string, string> param)
		{
			if (id_getBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ == IntPtr.Zero)
				id_getBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getBeaconLoudnessesFromApi", "(Lcom/bluecats/sdk/BCBeaconCallback;Ljava/util/Map;)V");
			IntPtr native_param = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (param);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@callback);
				__args [1] = new JValue (native_param);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconLoudnessesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeaconLoudnessesFromApi", "(Lcom/bluecats/sdk/BCBeaconCallback;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_param);
			}
		}

		static Delegate cb_getBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_Handler ()
		{
			if (cb_getBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ == null)
				cb_getBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_);
			return cb_getBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_;
		}

		static void n_GetBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback, IntPtr native_param)
		{
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeaconCallback @callback = (global::Com.Bluecats.Sdk.IBCBeaconCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			var param = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_param, JniHandleOwnership.DoNotTransfer);
			__this.GetBeaconModesFromApi (@callback, param);
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='getBeaconModesFromApi' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCBeaconCallback'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("getBeaconModesFromApi", "(Lcom/bluecats/sdk/BCBeaconCallback;Ljava/util/Map;)V", "GetGetBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_Handler")]
		public virtual unsafe void GetBeaconModesFromApi (global::Com.Bluecats.Sdk.IBCBeaconCallback @callback, global::System.Collections.Generic.IDictionary<string, string> param)
		{
			if (id_getBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ == IntPtr.Zero)
				id_getBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getBeaconModesFromApi", "(Lcom/bluecats/sdk/BCBeaconCallback;Ljava/util/Map;)V");
			IntPtr native_param = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (param);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@callback);
				__args [1] = new JValue (native_param);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconModesFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeaconModesFromApi", "(Lcom/bluecats/sdk/BCBeaconCallback;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_param);
			}
		}

		static Delegate cb_getBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_;
#pragma warning disable 0169
		static Delegate GetGetBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Handler ()
		{
			if (cb_getBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_ == null)
				cb_getBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_);
			return cb_getBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_;
		}

		static void n_GetBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeaconCallback @callback = (global::Com.Bluecats.Sdk.IBCBeaconCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetBeaconRegionsInTeamFromApi (@callback);
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='getBeaconRegionsInTeamFromApi' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconCallback']]"
		[Register ("getBeaconRegionsInTeamFromApi", "(Lcom/bluecats/sdk/BCBeaconCallback;)V", "GetGetBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Handler")]
		public virtual unsafe void GetBeaconRegionsInTeamFromApi (global::Com.Bluecats.Sdk.IBCBeaconCallback @callback)
		{
			if (id_getBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_ == IntPtr.Zero)
				id_getBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_ = JNIEnv.GetMethodID (class_ref, "getBeaconRegionsInTeamFromApi", "(Lcom/bluecats/sdk/BCBeaconCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconRegionsInTeamFromApi_Lcom_bluecats_sdk_BCBeaconCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeaconRegionsInTeamFromApi", "(Lcom/bluecats/sdk/BCBeaconCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_Handler ()
		{
			if (cb_getBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ == null)
				cb_getBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_);
			return cb_getBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_;
		}

		static void n_GetBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback, IntPtr native_param)
		{
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeaconCallback @callback = (global::Com.Bluecats.Sdk.IBCBeaconCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			var param = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_param, JniHandleOwnership.DoNotTransfer);
			__this.GetBeaconTargetSpeedsFromApi (@callback, param);
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='getBeaconTargetSpeedsFromApi' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCBeaconCallback'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("getBeaconTargetSpeedsFromApi", "(Lcom/bluecats/sdk/BCBeaconCallback;Ljava/util/Map;)V", "GetGetBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_Handler")]
		public virtual unsafe void GetBeaconTargetSpeedsFromApi (global::Com.Bluecats.Sdk.IBCBeaconCallback @callback, global::System.Collections.Generic.IDictionary<string, string> param)
		{
			if (id_getBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ == IntPtr.Zero)
				id_getBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getBeaconTargetSpeedsFromApi", "(Lcom/bluecats/sdk/BCBeaconCallback;Ljava/util/Map;)V");
			IntPtr native_param = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (param);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (@callback);
				__args [1] = new JValue (native_param);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconTargetSpeedsFromApi_Lcom_bluecats_sdk_BCBeaconCallback_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeaconTargetSpeedsFromApi", "(Lcom/bluecats/sdk/BCBeaconCallback;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_param);
			}
		}

		static Delegate cb_getBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_;
#pragma warning disable 0169
		static Delegate GetGetBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_Handler ()
		{
			if (cb_getBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_ == null)
				cb_getBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_);
			return cb_getBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_;
		}

		static void n_GetBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_version, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer version = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_version, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeaconCallback @callback = (global::Com.Bluecats.Sdk.IBCBeaconCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetBeaconVersion (version, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='getBeaconVersion' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='com.bluecats.sdk.BCBeaconCallback']]"
		[Register ("getBeaconVersion", "(Ljava/lang/Integer;Lcom/bluecats/sdk/BCBeaconCallback;)V", "GetGetBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_Handler")]
		public virtual unsafe void GetBeaconVersion (global::Java.Lang.Integer version, global::Com.Bluecats.Sdk.IBCBeaconCallback @callback)
		{
			if (id_getBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_ == IntPtr.Zero)
				id_getBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_ = JNIEnv.GetMethodID (class_ref, "getBeaconVersion", "(Ljava/lang/Integer;Lcom/bluecats/sdk/BCBeaconCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (version);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconVersion_Ljava_lang_Integer_Lcom_bluecats_sdk_BCBeaconCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeaconVersion", "(Ljava/lang/Integer;Lcom/bluecats/sdk/BCBeaconCallback;)V"), __args);
			} finally {
			}
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
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCategories ());
		}
#pragma warning restore 0169

		static IntPtr id_getCategories;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='getCategories' and count(parameter)=0]"
		[Register ("getCategories", "()[Lcom/bluecats/sdk/BCCategory;", "GetGetCategoriesHandler")]
		public virtual unsafe global::Com.Bluecats.Sdk.BCCategory[] GetCategories ()
		{
			if (id_getCategories == IntPtr.Zero)
				id_getCategories = JNIEnv.GetMethodID (class_ref, "getCategories", "()[Lcom/bluecats/sdk/BCCategory;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Com.Bluecats.Sdk.BCCategory[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCategories), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCCategory));
				else
					return (global::Com.Bluecats.Sdk.BCCategory[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCategories", "()[Lcom/bluecats/sdk/BCCategory;")), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCCategory));
			} finally {
			}
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
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCustomValues ());
		}
#pragma warning restore 0169

		static IntPtr id_getCustomValues;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='getCustomValues' and count(parameter)=0]"
		[Register ("getCustomValues", "()[Lcom/bluecats/sdk/BCCustomValue;", "GetGetCustomValuesHandler")]
		public virtual unsafe global::Com.Bluecats.Sdk.BCCustomValue[] GetCustomValues ()
		{
			if (id_getCustomValues == IntPtr.Zero)
				id_getCustomValues = JNIEnv.GetMethodID (class_ref, "getCustomValues", "()[Lcom/bluecats/sdk/BCCustomValue;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Com.Bluecats.Sdk.BCCustomValue[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCustomValues), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCCustomValue));
				else
					return (global::Com.Bluecats.Sdk.BCCustomValue[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCustomValues", "()[Lcom/bluecats/sdk/BCCustomValue;")), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCCustomValue));
			} finally {
			}
		}

		static Delegate cb_getLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_;
#pragma warning disable 0169
		static Delegate GetGetLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_Handler ()
		{
			if (cb_getLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ == null)
				cb_getLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_);
			return cb_getLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_;
		}

		static void n_GetLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeaconCallback @callback = (global::Com.Bluecats.Sdk.IBCBeaconCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetLatestBeacon (@callback);
		}
#pragma warning restore 0169

		static IntPtr id_getLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='getLatestBeacon' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconCallback']]"
		[Register ("getLatestBeacon", "(Lcom/bluecats/sdk/BCBeaconCallback;)V", "GetGetLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_Handler")]
		public virtual unsafe void GetLatestBeacon (global::Com.Bluecats.Sdk.IBCBeaconCallback @callback)
		{
			if (id_getLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ == IntPtr.Zero)
				id_getLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ = JNIEnv.GetMethodID (class_ref, "getLatestBeacon", "(Lcom/bluecats/sdk/BCBeaconCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getLatestBeacon_Lcom_bluecats_sdk_BCBeaconCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatestBeacon", "(Lcom/bluecats/sdk/BCBeaconCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getLatestBeaconSettings_Lcom_bluecats_sdk_BCBeaconCallback_;
#pragma warning disable 0169
		static Delegate GetGetLatestBeaconSettings_Lcom_bluecats_sdk_BCBeaconCallback_Handler ()
		{
			if (cb_getLatestBeaconSettings_Lcom_bluecats_sdk_BCBeaconCallback_ == null)
				cb_getLatestBeaconSettings_Lcom_bluecats_sdk_BCBeaconCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetLatestBeaconSettings_Lcom_bluecats_sdk_BCBeaconCallback_);
			return cb_getLatestBeaconSettings_Lcom_bluecats_sdk_BCBeaconCallback_;
		}

		static void n_GetLatestBeaconSettings_Lcom_bluecats_sdk_BCBeaconCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeaconCallback @callback = (global::Com.Bluecats.Sdk.IBCBeaconCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetLatestBeaconSettings (@callback);
		}
#pragma warning restore 0169

		static IntPtr id_getLatestBeaconSettings_Lcom_bluecats_sdk_BCBeaconCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='getLatestBeaconSettings' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconCallback']]"
		[Register ("getLatestBeaconSettings", "(Lcom/bluecats/sdk/BCBeaconCallback;)V", "GetGetLatestBeaconSettings_Lcom_bluecats_sdk_BCBeaconCallback_Handler")]
		public virtual unsafe void GetLatestBeaconSettings (global::Com.Bluecats.Sdk.IBCBeaconCallback @callback)
		{
			if (id_getLatestBeaconSettings_Lcom_bluecats_sdk_BCBeaconCallback_ == IntPtr.Zero)
				id_getLatestBeaconSettings_Lcom_bluecats_sdk_BCBeaconCallback_ = JNIEnv.GetMethodID (class_ref, "getLatestBeaconSettings", "(Lcom/bluecats/sdk/BCBeaconCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getLatestBeaconSettings_Lcom_bluecats_sdk_BCBeaconCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatestBeaconSettings", "(Lcom/bluecats/sdk/BCBeaconCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_;
#pragma warning disable 0169
		static Delegate GetGetLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_Handler ()
		{
			if (cb_getLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_ == null)
				cb_getLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_);
			return cb_getLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_;
		}

		static void n_GetLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeaconCallback @callback = (global::Com.Bluecats.Sdk.IBCBeaconCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetLatestBeaconVersion (@callback);
		}
#pragma warning restore 0169

		static IntPtr id_getLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='getLatestBeaconVersion' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconCallback']]"
		[Register ("getLatestBeaconVersion", "(Lcom/bluecats/sdk/BCBeaconCallback;)V", "GetGetLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_Handler")]
		public virtual unsafe void GetLatestBeaconVersion (global::Com.Bluecats.Sdk.IBCBeaconCallback @callback)
		{
			if (id_getLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_ == IntPtr.Zero)
				id_getLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_ = JNIEnv.GetMethodID (class_ref, "getLatestBeaconVersion", "(Lcom/bluecats/sdk/BCBeaconCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatestBeaconVersion", "(Lcom/bluecats/sdk/BCBeaconCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_moveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_;
#pragma warning disable 0169
		static Delegate GetMoveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_Handler ()
		{
			if (cb_moveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_ == null)
				cb_moveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_MoveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_);
			return cb_moveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_;
		}

		static void n_MoveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_toTeam, IntPtr native_toSite, bool keepCategories, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCTeam toTeam = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (native_toTeam, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite toSite = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_toSite, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeaconCallback @callback = (global::Com.Bluecats.Sdk.IBCBeaconCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.MoveBeaconToTeam (toTeam, toSite, keepCategories, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_moveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='moveBeaconToTeam' and count(parameter)=4 and parameter[1][@type='com.bluecats.sdk.BCTeam'] and parameter[2][@type='com.bluecats.sdk.BCSite'] and parameter[3][@type='boolean'] and parameter[4][@type='com.bluecats.sdk.BCBeaconCallback']]"
		[Register ("moveBeaconToTeam", "(Lcom/bluecats/sdk/BCTeam;Lcom/bluecats/sdk/BCSite;ZLcom/bluecats/sdk/BCBeaconCallback;)V", "GetMoveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_Handler")]
		public virtual unsafe void MoveBeaconToTeam (global::Com.Bluecats.Sdk.BCTeam toTeam, global::Com.Bluecats.Sdk.IBCSite toSite, bool keepCategories, global::Com.Bluecats.Sdk.IBCBeaconCallback @callback)
		{
			if (id_moveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_ == IntPtr.Zero)
				id_moveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_ = JNIEnv.GetMethodID (class_ref, "moveBeaconToTeam", "(Lcom/bluecats/sdk/BCTeam;Lcom/bluecats/sdk/BCSite;ZLcom/bluecats/sdk/BCBeaconCallback;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (toTeam);
				__args [1] = new JValue (toSite);
				__args [2] = new JValue (keepCategories);
				__args [3] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_moveBeaconToTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCSite_ZLcom_bluecats_sdk_BCBeaconCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "moveBeaconToTeam", "(Lcom/bluecats/sdk/BCTeam;Lcom/bluecats/sdk/BCSite;ZLcom/bluecats/sdk/BCBeaconCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_refreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_;
#pragma warning disable 0169
		static Delegate GetRefreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_Handler ()
		{
			if (cb_refreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ == null)
				cb_refreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RefreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_);
			return cb_refreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_;
		}

		static void n_RefreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeaconCallback @callback = (global::Com.Bluecats.Sdk.IBCBeaconCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.RefreshBeacon (@callback);
		}
#pragma warning restore 0169

		static IntPtr id_refreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='refreshBeacon' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconCallback']]"
		[Register ("refreshBeacon", "(Lcom/bluecats/sdk/BCBeaconCallback;)V", "GetRefreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_Handler")]
		public virtual unsafe void RefreshBeacon (global::Com.Bluecats.Sdk.IBCBeaconCallback @callback)
		{
			if (id_refreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ == IntPtr.Zero)
				id_refreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_ = JNIEnv.GetMethodID (class_ref, "refreshBeacon", "(Lcom/bluecats/sdk/BCBeaconCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_refreshBeacon_Lcom_bluecats_sdk_BCBeaconCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "refreshBeacon", "(Lcom/bluecats/sdk/BCBeaconCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCategories_arrayLcom_bluecats_sdk_BCCategory_;
#pragma warning disable 0169
		static Delegate GetSetCategories_arrayLcom_bluecats_sdk_BCCategory_Handler ()
		{
			if (cb_setCategories_arrayLcom_bluecats_sdk_BCCategory_ == null)
				cb_setCategories_arrayLcom_bluecats_sdk_BCCategory_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCategories_arrayLcom_bluecats_sdk_BCCategory_);
			return cb_setCategories_arrayLcom_bluecats_sdk_BCCategory_;
		}

		static void n_SetCategories_arrayLcom_bluecats_sdk_BCCategory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCCategory[] value = (global::Com.Bluecats.Sdk.BCCategory[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Bluecats.Sdk.BCCategory));
			__this.SetCategories (value);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		static IntPtr id_setCategories_arrayLcom_bluecats_sdk_BCCategory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='setCategories' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCCategory[]']]"
		[Register ("setCategories", "([Lcom/bluecats/sdk/BCCategory;)V", "GetSetCategories_arrayLcom_bluecats_sdk_BCCategory_Handler")]
		public virtual unsafe void SetCategories (global::Com.Bluecats.Sdk.BCCategory[] value)
		{
			if (id_setCategories_arrayLcom_bluecats_sdk_BCCategory_ == IntPtr.Zero)
				id_setCategories_arrayLcom_bluecats_sdk_BCCategory_ = JNIEnv.GetMethodID (class_ref, "setCategories", "([Lcom/bluecats/sdk/BCCategory;)V");
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCategories_arrayLcom_bluecats_sdk_BCCategory_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCategories", "([Lcom/bluecats/sdk/BCCategory;)V"), __args);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
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

		static void n_SetCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCCustomValue[] value = (global::Com.Bluecats.Sdk.BCCustomValue[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Bluecats.Sdk.BCCustomValue));
			__this.SetCustomValues (value);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		static IntPtr id_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconApi']/method[@name='setCustomValues' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCCustomValue[]']]"
		[Register ("setCustomValues", "([Lcom/bluecats/sdk/BCCustomValue;)V", "GetSetCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_Handler")]
		public virtual unsafe void SetCustomValues (global::Com.Bluecats.Sdk.BCCustomValue[] value)
		{
			if (id_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_ == IntPtr.Zero)
				id_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_ = JNIEnv.GetMethodID (class_ref, "setCustomValues", "([Lcom/bluecats/sdk/BCCustomValue;)V");
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomValues", "([Lcom/bluecats/sdk/BCCustomValue;)V"), __args);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
