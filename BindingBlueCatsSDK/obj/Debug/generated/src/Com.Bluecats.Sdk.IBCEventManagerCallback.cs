using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCEventManagerCallback']"
	[Register ("com/bluecats/sdk/BCEventManagerCallback", "", "Com.Bluecats.Sdk.IBCEventManagerCallbackInvoker")]
	public partial interface IBCEventManagerCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCEventManagerCallback']/method[@name='onTriggeredEvent' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCTriggeredEvent']]"
		[Register ("onTriggeredEvent", "(Lcom/bluecats/sdk/BCTriggeredEvent;)V", "GetOnTriggeredEvent_Lcom_bluecats_sdk_BCTriggeredEvent_Handler:Com.Bluecats.Sdk.IBCEventManagerCallbackInvoker, BindingBlueCatsSDK")]
		void OnTriggeredEvent (global::Com.Bluecats.Sdk.BCTriggeredEvent p0);

	}

	[global::Android.Runtime.Register ("com/bluecats/sdk/BCEventManagerCallback", DoNotGenerateAcw=true)]
	internal class IBCEventManagerCallbackInvoker : global::Java.Lang.Object, IBCEventManagerCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bluecats/sdk/BCEventManagerCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBCEventManagerCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBCEventManagerCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBCEventManagerCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bluecats.sdk.BCEventManagerCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBCEventManagerCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onTriggeredEvent_Lcom_bluecats_sdk_BCTriggeredEvent_;
#pragma warning disable 0169
		static Delegate GetOnTriggeredEvent_Lcom_bluecats_sdk_BCTriggeredEvent_Handler ()
		{
			if (cb_onTriggeredEvent_Lcom_bluecats_sdk_BCTriggeredEvent_ == null)
				cb_onTriggeredEvent_Lcom_bluecats_sdk_BCTriggeredEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnTriggeredEvent_Lcom_bluecats_sdk_BCTriggeredEvent_);
			return cb_onTriggeredEvent_Lcom_bluecats_sdk_BCTriggeredEvent_;
		}

		static void n_OnTriggeredEvent_Lcom_bluecats_sdk_BCTriggeredEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCEventManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCEventManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCTriggeredEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTriggeredEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnTriggeredEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_onTriggeredEvent_Lcom_bluecats_sdk_BCTriggeredEvent_;
		public unsafe void OnTriggeredEvent (global::Com.Bluecats.Sdk.BCTriggeredEvent p0)
		{
			if (id_onTriggeredEvent_Lcom_bluecats_sdk_BCTriggeredEvent_ == IntPtr.Zero)
				id_onTriggeredEvent_Lcom_bluecats_sdk_BCTriggeredEvent_ = JNIEnv.GetMethodID (class_ref, "onTriggeredEvent", "(Lcom/bluecats/sdk/BCTriggeredEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTriggeredEvent_Lcom_bluecats_sdk_BCTriggeredEvent_, __args);
		}

	}

}
