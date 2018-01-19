using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCCategoryCallback']"
	[Register ("com/bluecats/sdk/BCCategoryCallback", "", "Com.Bluecats.Sdk.IBCCategoryCallbackInvoker")]
	public partial interface IBCCategoryCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCCategoryCallback']/method[@name='onDidFailWithError' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCError']]"
		[Register ("onDidFailWithError", "(Lcom/bluecats/sdk/BCError;)V", "GetOnDidFailWithError_Lcom_bluecats_sdk_BCError_Handler:Com.Bluecats.Sdk.IBCCategoryCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidFailWithError (global::Com.Bluecats.Sdk.BCError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCCategoryCallback']/method[@name='onDidLoadCategoryInsights' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCCategoryInsights']]"
		[Register ("onDidLoadCategoryInsights", "(Lcom/bluecats/sdk/BCCategoryInsights;)V", "GetOnDidLoadCategoryInsights_Lcom_bluecats_sdk_BCCategoryInsights_Handler:Com.Bluecats.Sdk.IBCCategoryCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidLoadCategoryInsights (global::Com.Bluecats.Sdk.BCCategoryInsights p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCCategoryCallback']/method[@name='onDidUpdateCategory' and count(parameter)=0]"
		[Register ("onDidUpdateCategory", "()V", "GetOnDidUpdateCategoryHandler:Com.Bluecats.Sdk.IBCCategoryCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidUpdateCategory ();

	}

	[global::Android.Runtime.Register ("com/bluecats/sdk/BCCategoryCallback", DoNotGenerateAcw=true)]
	internal class IBCCategoryCallbackInvoker : global::Java.Lang.Object, IBCCategoryCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bluecats/sdk/BCCategoryCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBCCategoryCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBCCategoryCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBCCategoryCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bluecats.sdk.BCCategoryCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBCCategoryCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Com.Bluecats.Sdk.IBCCategoryCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCCategoryCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onDidLoadCategoryInsights_Lcom_bluecats_sdk_BCCategoryInsights_;
#pragma warning disable 0169
		static Delegate GetOnDidLoadCategoryInsights_Lcom_bluecats_sdk_BCCategoryInsights_Handler ()
		{
			if (cb_onDidLoadCategoryInsights_Lcom_bluecats_sdk_BCCategoryInsights_ == null)
				cb_onDidLoadCategoryInsights_Lcom_bluecats_sdk_BCCategoryInsights_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidLoadCategoryInsights_Lcom_bluecats_sdk_BCCategoryInsights_);
			return cb_onDidLoadCategoryInsights_Lcom_bluecats_sdk_BCCategoryInsights_;
		}

		static void n_OnDidLoadCategoryInsights_Lcom_bluecats_sdk_BCCategoryInsights_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCCategoryCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCCategoryCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCCategoryInsights p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategoryInsights> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidLoadCategoryInsights (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidLoadCategoryInsights_Lcom_bluecats_sdk_BCCategoryInsights_;
		public unsafe void OnDidLoadCategoryInsights (global::Com.Bluecats.Sdk.BCCategoryInsights p0)
		{
			if (id_onDidLoadCategoryInsights_Lcom_bluecats_sdk_BCCategoryInsights_ == IntPtr.Zero)
				id_onDidLoadCategoryInsights_Lcom_bluecats_sdk_BCCategoryInsights_ = JNIEnv.GetMethodID (class_ref, "onDidLoadCategoryInsights", "(Lcom/bluecats/sdk/BCCategoryInsights;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidLoadCategoryInsights_Lcom_bluecats_sdk_BCCategoryInsights_, __args);
		}

		static Delegate cb_onDidUpdateCategory;
#pragma warning disable 0169
		static Delegate GetOnDidUpdateCategoryHandler ()
		{
			if (cb_onDidUpdateCategory == null)
				cb_onDidUpdateCategory = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDidUpdateCategory);
			return cb_onDidUpdateCategory;
		}

		static void n_OnDidUpdateCategory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCCategoryCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCCategoryCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDidUpdateCategory ();
		}
#pragma warning restore 0169

		IntPtr id_onDidUpdateCategory;
		public unsafe void OnDidUpdateCategory ()
		{
			if (id_onDidUpdateCategory == IntPtr.Zero)
				id_onDidUpdateCategory = JNIEnv.GetMethodID (class_ref, "onDidUpdateCategory", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidUpdateCategory);
		}

	}

}
