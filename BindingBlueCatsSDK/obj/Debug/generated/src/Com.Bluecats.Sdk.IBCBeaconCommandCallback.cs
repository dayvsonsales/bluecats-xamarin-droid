using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	[Register ("com/bluecats/sdk/BCBeaconCommandCallback", DoNotGenerateAcw=true)]
	public abstract class BCBeaconCommandCallback : Java.Lang.Object {

		internal BCBeaconCommandCallback ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeaconCommandCallback']/field[@name='PROGRESS_TYPE_FIRMWARE']"
		[Register ("PROGRESS_TYPE_FIRMWARE")]
		public const int ProgressTypeFirmware = (int) 257;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeaconCommandCallback']/field[@name='PROGRESS_TYPE_OVERALL']"
		[Register ("PROGRESS_TYPE_OVERALL")]
		public const int ProgressTypeOverall = (int) 256;
	}

	[Register ("com/bluecats/sdk/BCBeaconCommandCallback", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'BCBeaconCommandCallback' type. This type will be removed in a future release.")]
	public abstract class BCBeaconCommandCallbackConsts : BCBeaconCommandCallback {

		private BCBeaconCommandCallbackConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeaconCommandCallback']"
	[Register ("com/bluecats/sdk/BCBeaconCommandCallback", "", "Com.Bluecats.Sdk.IBCBeaconCommandCallbackInvoker")]
	public partial interface IBCBeaconCommandCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeaconCommandCallback']/method[@name='onDidComplete' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCError']]"
		[Register ("onDidComplete", "(Lcom/bluecats/sdk/BCError;)V", "GetOnDidComplete_Lcom_bluecats_sdk_BCError_Handler:Com.Bluecats.Sdk.IBCBeaconCommandCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidComplete (global::Com.Bluecats.Sdk.BCError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeaconCommandCallback']/method[@name='onDidResponseData' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.nio.ByteBuffer&gt;']]"
		[Register ("onDidResponseData", "(Ljava/util/List;)V", "GetOnDidResponseData_Ljava_util_List_Handler:Com.Bluecats.Sdk.IBCBeaconCommandCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidResponseData (global::System.Collections.Generic.IList<global::Java.Nio.ByteBuffer> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeaconCommandCallback']/method[@name='onDidUpdateProgress' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onDidUpdateProgress", "(IILjava/lang/String;)V", "GetOnDidUpdateProgress_IILjava_lang_String_Handler:Com.Bluecats.Sdk.IBCBeaconCommandCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidUpdateProgress (int p0, int p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeaconCommandCallback']/method[@name='onDidUpdateStatus' and count(parameter)=0]"
		[Register ("onDidUpdateStatus", "()V", "GetOnDidUpdateStatusHandler:Com.Bluecats.Sdk.IBCBeaconCommandCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidUpdateStatus ();

	}

	[global::Android.Runtime.Register ("com/bluecats/sdk/BCBeaconCommandCallback", DoNotGenerateAcw=true)]
	internal class IBCBeaconCommandCallbackInvoker : global::Java.Lang.Object, IBCBeaconCommandCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bluecats/sdk/BCBeaconCommandCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBCBeaconCommandCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBCBeaconCommandCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBCBeaconCommandCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bluecats.sdk.BCBeaconCommandCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBCBeaconCommandCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDidComplete_Lcom_bluecats_sdk_BCError_;
#pragma warning disable 0169
		static Delegate GetOnDidComplete_Lcom_bluecats_sdk_BCError_Handler ()
		{
			if (cb_onDidComplete_Lcom_bluecats_sdk_BCError_ == null)
				cb_onDidComplete_Lcom_bluecats_sdk_BCError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidComplete_Lcom_bluecats_sdk_BCError_);
			return cb_onDidComplete_Lcom_bluecats_sdk_BCError_;
		}

		static void n_OnDidComplete_Lcom_bluecats_sdk_BCError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeaconCommandCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCommandCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCError p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidComplete (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidComplete_Lcom_bluecats_sdk_BCError_;
		public unsafe void OnDidComplete (global::Com.Bluecats.Sdk.BCError p0)
		{
			if (id_onDidComplete_Lcom_bluecats_sdk_BCError_ == IntPtr.Zero)
				id_onDidComplete_Lcom_bluecats_sdk_BCError_ = JNIEnv.GetMethodID (class_ref, "onDidComplete", "(Lcom/bluecats/sdk/BCError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidComplete_Lcom_bluecats_sdk_BCError_, __args);
		}

		static Delegate cb_onDidResponseData_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnDidResponseData_Ljava_util_List_Handler ()
		{
			if (cb_onDidResponseData_Ljava_util_List_ == null)
				cb_onDidResponseData_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidResponseData_Ljava_util_List_);
			return cb_onDidResponseData_Ljava_util_List_;
		}

		static void n_OnDidResponseData_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeaconCommandCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCommandCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Java.Nio.ByteBuffer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidResponseData (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidResponseData_Ljava_util_List_;
		public unsafe void OnDidResponseData (global::System.Collections.Generic.IList<global::Java.Nio.ByteBuffer> p0)
		{
			if (id_onDidResponseData_Ljava_util_List_ == IntPtr.Zero)
				id_onDidResponseData_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onDidResponseData", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Nio.ByteBuffer>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidResponseData_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onDidUpdateProgress_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnDidUpdateProgress_IILjava_lang_String_Handler ()
		{
			if (cb_onDidUpdateProgress_IILjava_lang_String_ == null)
				cb_onDidUpdateProgress_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_OnDidUpdateProgress_IILjava_lang_String_);
			return cb_onDidUpdateProgress_IILjava_lang_String_;
		}

		static void n_OnDidUpdateProgress_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Com.Bluecats.Sdk.IBCBeaconCommandCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCommandCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnDidUpdateProgress (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onDidUpdateProgress_IILjava_lang_String_;
		public unsafe void OnDidUpdateProgress (int p0, int p1, string p2)
		{
			if (id_onDidUpdateProgress_IILjava_lang_String_ == IntPtr.Zero)
				id_onDidUpdateProgress_IILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onDidUpdateProgress", "(IILjava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidUpdateProgress_IILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_onDidUpdateStatus;
#pragma warning disable 0169
		static Delegate GetOnDidUpdateStatusHandler ()
		{
			if (cb_onDidUpdateStatus == null)
				cb_onDidUpdateStatus = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDidUpdateStatus);
			return cb_onDidUpdateStatus;
		}

		static void n_OnDidUpdateStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeaconCommandCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCommandCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDidUpdateStatus ();
		}
#pragma warning restore 0169

		IntPtr id_onDidUpdateStatus;
		public unsafe void OnDidUpdateStatus ()
		{
			if (id_onDidUpdateStatus == IntPtr.Zero)
				id_onDidUpdateStatus = JNIEnv.GetMethodID (class_ref, "onDidUpdateStatus", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidUpdateStatus);
		}

	}

}
