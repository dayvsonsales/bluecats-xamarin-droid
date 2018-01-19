using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCAppCallback']"
	[Register ("com/bluecats/sdk/BCAppCallback", "", "Com.Bluecats.Sdk.IBCAppCallbackInvoker")]
	public partial interface IBCAppCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCAppCallback']/method[@name='onDidFailWithError' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCError']]"
		[Register ("onDidFailWithError", "(Lcom/bluecats/sdk/BCError;)V", "GetOnDidFailWithError_Lcom_bluecats_sdk_BCError_Handler:Com.Bluecats.Sdk.IBCAppCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidFailWithError (global::Com.Bluecats.Sdk.BCError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCAppCallback']/method[@name='onDidGetAppToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onDidGetAppToken", "(Ljava/lang/String;)V", "GetOnDidGetAppToken_Ljava_lang_String_Handler:Com.Bluecats.Sdk.IBCAppCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidGetAppToken (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCAppCallback']/method[@name='onDidLoadAppInsights' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCAppInsights']]"
		[Register ("onDidLoadAppInsights", "(Lcom/bluecats/sdk/BCAppInsights;)V", "GetOnDidLoadAppInsights_Lcom_bluecats_sdk_BCAppInsights_Handler:Com.Bluecats.Sdk.IBCAppCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidLoadAppInsights (global::Com.Bluecats.Sdk.BCAppInsights p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCAppCallback']/method[@name='onDidLoadBeacons' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCBeacon&gt;']]"
		[Register ("onDidLoadBeacons", "(Ljava/util/List;)V", "GetOnDidLoadBeacons_Ljava_util_List_Handler:Com.Bluecats.Sdk.IBCAppCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidLoadBeacons (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCAppCallback']/method[@name='onDidLoadSites' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCSite&gt;']]"
		[Register ("onDidLoadSites", "(Ljava/util/List;)V", "GetOnDidLoadSites_Ljava_util_List_Handler:Com.Bluecats.Sdk.IBCAppCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidLoadSites (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCSite> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCAppCallback']/method[@name='onDidUpdateApp' and count(parameter)=0]"
		[Register ("onDidUpdateApp", "()V", "GetOnDidUpdateAppHandler:Com.Bluecats.Sdk.IBCAppCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidUpdateApp ();

	}

	[global::Android.Runtime.Register ("com/bluecats/sdk/BCAppCallback", DoNotGenerateAcw=true)]
	internal class IBCAppCallbackInvoker : global::Java.Lang.Object, IBCAppCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bluecats/sdk/BCAppCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBCAppCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBCAppCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBCAppCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bluecats.sdk.BCAppCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBCAppCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDidFailWithError_Lcom_bluecats_sdk_BCError_;
#pragma warning disable 0169
		static Delegate GetOnDidFailWithError_Lcom_bluecats_sdk_BCError_Handler ()
		{
			if (cb_onDidFailWithError_Lcom_bluecats_sdk_BCError_ == null)
				cb_onDidFailWithError_Lcom_bluecats_sdk_BCError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidFailWithError_Lcom_bluecats_sdk_BCError_);
			return cb_onDidFailWithError_Lcom_bluecats_sdk_BCError_;
		}

		static void n_OnDidFailWithError_Lcom_bluecats_sdk_BCError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCError p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidFailWithError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidFailWithError_Lcom_bluecats_sdk_BCError_;
		public unsafe void OnDidFailWithError (global::Com.Bluecats.Sdk.BCError p0)
		{
			if (id_onDidFailWithError_Lcom_bluecats_sdk_BCError_ == IntPtr.Zero)
				id_onDidFailWithError_Lcom_bluecats_sdk_BCError_ = JNIEnv.GetMethodID (class_ref, "onDidFailWithError", "(Lcom/bluecats/sdk/BCError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidFailWithError_Lcom_bluecats_sdk_BCError_, __args);
		}

		static Delegate cb_onDidGetAppToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnDidGetAppToken_Ljava_lang_String_Handler ()
		{
			if (cb_onDidGetAppToken_Ljava_lang_String_ == null)
				cb_onDidGetAppToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidGetAppToken_Ljava_lang_String_);
			return cb_onDidGetAppToken_Ljava_lang_String_;
		}

		static void n_OnDidGetAppToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidGetAppToken (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidGetAppToken_Ljava_lang_String_;
		public unsafe void OnDidGetAppToken (string p0)
		{
			if (id_onDidGetAppToken_Ljava_lang_String_ == IntPtr.Zero)
				id_onDidGetAppToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onDidGetAppToken", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidGetAppToken_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onDidLoadAppInsights_Lcom_bluecats_sdk_BCAppInsights_;
#pragma warning disable 0169
		static Delegate GetOnDidLoadAppInsights_Lcom_bluecats_sdk_BCAppInsights_Handler ()
		{
			if (cb_onDidLoadAppInsights_Lcom_bluecats_sdk_BCAppInsights_ == null)
				cb_onDidLoadAppInsights_Lcom_bluecats_sdk_BCAppInsights_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidLoadAppInsights_Lcom_bluecats_sdk_BCAppInsights_);
			return cb_onDidLoadAppInsights_Lcom_bluecats_sdk_BCAppInsights_;
		}

		static void n_OnDidLoadAppInsights_Lcom_bluecats_sdk_BCAppInsights_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCAppInsights p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppInsights> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidLoadAppInsights (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidLoadAppInsights_Lcom_bluecats_sdk_BCAppInsights_;
		public unsafe void OnDidLoadAppInsights (global::Com.Bluecats.Sdk.BCAppInsights p0)
		{
			if (id_onDidLoadAppInsights_Lcom_bluecats_sdk_BCAppInsights_ == IntPtr.Zero)
				id_onDidLoadAppInsights_Lcom_bluecats_sdk_BCAppInsights_ = JNIEnv.GetMethodID (class_ref, "onDidLoadAppInsights", "(Lcom/bluecats/sdk/BCAppInsights;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidLoadAppInsights_Lcom_bluecats_sdk_BCAppInsights_, __args);
		}

		static Delegate cb_onDidLoadBeacons_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnDidLoadBeacons_Ljava_util_List_Handler ()
		{
			if (cb_onDidLoadBeacons_Ljava_util_List_ == null)
				cb_onDidLoadBeacons_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidLoadBeacons_Ljava_util_List_);
			return cb_onDidLoadBeacons_Ljava_util_List_;
		}

		static void n_OnDidLoadBeacons_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidLoadBeacons (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidLoadBeacons_Ljava_util_List_;
		public unsafe void OnDidLoadBeacons (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> p0)
		{
			if (id_onDidLoadBeacons_Ljava_util_List_ == IntPtr.Zero)
				id_onDidLoadBeacons_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onDidLoadBeacons", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidLoadBeacons_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onDidLoadSites_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnDidLoadSites_Ljava_util_List_Handler ()
		{
			if (cb_onDidLoadSites_Ljava_util_List_ == null)
				cb_onDidLoadSites_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidLoadSites_Ljava_util_List_);
			return cb_onDidLoadSites_Ljava_util_List_;
		}

		static void n_OnDidLoadSites_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCSite>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidLoadSites (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidLoadSites_Ljava_util_List_;
		public unsafe void OnDidLoadSites (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCSite> p0)
		{
			if (id_onDidLoadSites_Ljava_util_List_ == IntPtr.Zero)
				id_onDidLoadSites_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onDidLoadSites", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCSite>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidLoadSites_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onDidUpdateApp;
#pragma warning disable 0169
		static Delegate GetOnDidUpdateAppHandler ()
		{
			if (cb_onDidUpdateApp == null)
				cb_onDidUpdateApp = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDidUpdateApp);
			return cb_onDidUpdateApp;
		}

		static void n_OnDidUpdateApp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCAppCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCAppCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDidUpdateApp ();
		}
#pragma warning restore 0169

		IntPtr id_onDidUpdateApp;
		public unsafe void OnDidUpdateApp ()
		{
			if (id_onDidUpdateApp == IntPtr.Zero)
				id_onDidUpdateApp = JNIEnv.GetMethodID (class_ref, "onDidUpdateApp", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidUpdateApp);
		}

	}

}
