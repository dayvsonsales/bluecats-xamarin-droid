using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCAccountManagerCallback']"
	[Register ("com/bluecats/sdk/BCAccountManagerCallback", "", "Com.Bluecats.Sdk.IBCAccountManagerCallbackInvoker")]
	public partial interface IBCAccountManagerCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCAccountManagerCallback']/method[@name='onDidFailWithError' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCError']]"
		[Register ("onDidFailWithError", "(Lcom/bluecats/sdk/BCError;)V", "GetOnDidFailWithError_Lcom_bluecats_sdk_BCError_Handler:Com.Bluecats.Sdk.IBCAccountManagerCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidFailWithError (global::Com.Bluecats.Sdk.BCError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCAccountManagerCallback']/method[@name='onDidLogInPerson' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCPerson']]"
		[Register ("onDidLogInPerson", "(Lcom/bluecats/sdk/BCPerson;)V", "GetOnDidLogInPerson_Lcom_bluecats_sdk_BCPerson_Handler:Com.Bluecats.Sdk.IBCAccountManagerCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidLogInPerson (global::Com.Bluecats.Sdk.BCPerson p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCAccountManagerCallback']/method[@name='onDidLogOff' and count(parameter)=0]"
		[Register ("onDidLogOff", "()V", "GetOnDidLogOffHandler:Com.Bluecats.Sdk.IBCAccountManagerCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidLogOff ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCAccountManagerCallback']/method[@name='onDidVerifyApp' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCApp']]"
		[Register ("onDidVerifyApp", "(Lcom/bluecats/sdk/BCApp;)V", "GetOnDidVerifyApp_Lcom_bluecats_sdk_BCApp_Handler:Com.Bluecats.Sdk.IBCAccountManagerCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidVerifyApp (global::Com.Bluecats.Sdk.IBCApp p0);

	}

	[global::Android.Runtime.Register ("com/bluecats/sdk/BCAccountManagerCallback", DoNotGenerateAcw=true)]
	internal class IBCAccountManagerCallbackInvoker : global::Java.Lang.Object, IBCAccountManagerCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bluecats/sdk/BCAccountManagerCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBCAccountManagerCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBCAccountManagerCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBCAccountManagerCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bluecats.sdk.BCAccountManagerCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBCAccountManagerCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Com.Bluecats.Sdk.IBCAccountManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCAccountManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onDidLogInPerson_Lcom_bluecats_sdk_BCPerson_;
#pragma warning disable 0169
		static Delegate GetOnDidLogInPerson_Lcom_bluecats_sdk_BCPerson_Handler ()
		{
			if (cb_onDidLogInPerson_Lcom_bluecats_sdk_BCPerson_ == null)
				cb_onDidLogInPerson_Lcom_bluecats_sdk_BCPerson_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidLogInPerson_Lcom_bluecats_sdk_BCPerson_);
			return cb_onDidLogInPerson_Lcom_bluecats_sdk_BCPerson_;
		}

		static void n_OnDidLogInPerson_Lcom_bluecats_sdk_BCPerson_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCAccountManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCAccountManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCPerson p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPerson> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidLogInPerson (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidLogInPerson_Lcom_bluecats_sdk_BCPerson_;
		public unsafe void OnDidLogInPerson (global::Com.Bluecats.Sdk.BCPerson p0)
		{
			if (id_onDidLogInPerson_Lcom_bluecats_sdk_BCPerson_ == IntPtr.Zero)
				id_onDidLogInPerson_Lcom_bluecats_sdk_BCPerson_ = JNIEnv.GetMethodID (class_ref, "onDidLogInPerson", "(Lcom/bluecats/sdk/BCPerson;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidLogInPerson_Lcom_bluecats_sdk_BCPerson_, __args);
		}

		static Delegate cb_onDidLogOff;
#pragma warning disable 0169
		static Delegate GetOnDidLogOffHandler ()
		{
			if (cb_onDidLogOff == null)
				cb_onDidLogOff = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDidLogOff);
			return cb_onDidLogOff;
		}

		static void n_OnDidLogOff (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCAccountManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCAccountManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDidLogOff ();
		}
#pragma warning restore 0169

		IntPtr id_onDidLogOff;
		public unsafe void OnDidLogOff ()
		{
			if (id_onDidLogOff == IntPtr.Zero)
				id_onDidLogOff = JNIEnv.GetMethodID (class_ref, "onDidLogOff", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidLogOff);
		}

		static Delegate cb_onDidVerifyApp_Lcom_bluecats_sdk_BCApp_;
#pragma warning disable 0169
		static Delegate GetOnDidVerifyApp_Lcom_bluecats_sdk_BCApp_Handler ()
		{
			if (cb_onDidVerifyApp_Lcom_bluecats_sdk_BCApp_ == null)
				cb_onDidVerifyApp_Lcom_bluecats_sdk_BCApp_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidVerifyApp_Lcom_bluecats_sdk_BCApp_);
			return cb_onDidVerifyApp_Lcom_bluecats_sdk_BCApp_;
		}

		static void n_OnDidVerifyApp_Lcom_bluecats_sdk_BCApp_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCAccountManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCAccountManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCApp p0 = (global::Com.Bluecats.Sdk.IBCApp)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidVerifyApp (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidVerifyApp_Lcom_bluecats_sdk_BCApp_;
		public unsafe void OnDidVerifyApp (global::Com.Bluecats.Sdk.IBCApp p0)
		{
			if (id_onDidVerifyApp_Lcom_bluecats_sdk_BCApp_ == IntPtr.Zero)
				id_onDidVerifyApp_Lcom_bluecats_sdk_BCApp_ = JNIEnv.GetMethodID (class_ref, "onDidVerifyApp", "(Lcom/bluecats/sdk/BCApp;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidVerifyApp_Lcom_bluecats_sdk_BCApp_, __args);
		}

	}

}
