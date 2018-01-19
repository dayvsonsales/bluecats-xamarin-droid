using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInsights']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCSiteInsights", DoNotGenerateAcw=true)]
	public partial class BCSiteInsights : global::Com.Bluecats.Sdk.BCInsights {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInsights']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/bluecats/sdk/BCSiteInsights", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCSiteInsights); }
		}

		protected BCSiteInsights (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInsights']/constructor[@name='BCSiteInsights' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCSiteInsights ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCSiteInsights)) {
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
			global::Com.Bluecats.Sdk.BCSiteInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCSiteInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SiteID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getSiteID;
		static IntPtr id_setSiteID_Ljava_lang_String_;
		public virtual unsafe string SiteID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInsights']/method[@name='getSiteID' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInsights']/method[@name='setSiteID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bluecats.Sdk.BCSiteInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCSiteInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SiteName = value;
		}
#pragma warning restore 0169

		static IntPtr id_getSiteName;
		static IntPtr id_setSiteName_Ljava_lang_String_;
		public virtual unsafe string SiteName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInsights']/method[@name='getSiteName' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteInsights']/method[@name='setSiteName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

	}
}
