using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCLocalNotificationManagerCallback']"
	[Register ("com/bluecats/sdk/BCLocalNotificationManagerCallback", "", "Com.Bluecats.Sdk.IBCLocalNotificationManagerCallbackInvoker")]
	public partial interface IBCLocalNotificationManagerCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCLocalNotificationManagerCallback']/method[@name='onDidNotify' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onDidNotify", "(I)V", "GetOnDidNotify_IHandler:Com.Bluecats.Sdk.IBCLocalNotificationManagerCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidNotify (int p0);

	}

	[global::Android.Runtime.Register ("com/bluecats/sdk/BCLocalNotificationManagerCallback", DoNotGenerateAcw=true)]
	internal class IBCLocalNotificationManagerCallbackInvoker : global::Java.Lang.Object, IBCLocalNotificationManagerCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bluecats/sdk/BCLocalNotificationManagerCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBCLocalNotificationManagerCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBCLocalNotificationManagerCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBCLocalNotificationManagerCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bluecats.sdk.BCLocalNotificationManagerCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBCLocalNotificationManagerCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDidNotify_I;
#pragma warning disable 0169
		static Delegate GetOnDidNotify_IHandler ()
		{
			if (cb_onDidNotify_I == null)
				cb_onDidNotify_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnDidNotify_I);
			return cb_onDidNotify_I;
		}

		static void n_OnDidNotify_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bluecats.Sdk.IBCLocalNotificationManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCLocalNotificationManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDidNotify (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidNotify_I;
		public unsafe void OnDidNotify (int p0)
		{
			if (id_onDidNotify_I == IntPtr.Zero)
				id_onDidNotify_I = JNIEnv.GetMethodID (class_ref, "onDidNotify", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidNotify_I, __args);
		}

	}

}
