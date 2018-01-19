using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCEventFilterCallback']"
	[Register ("com/bluecats/sdk/BCEventFilterCallback", "", "Com.Bluecats.Sdk.IBCEventFilterCallbackInvoker")]
	public partial interface IBCEventFilterCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCEventFilterCallback']/method[@name='filterBeaconsForEvent' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCEventFilterContext'] and parameter[2][@type='java.util.Map&lt;java.lang.Object, java.lang.Object&gt;']]"
		[Register ("filterBeaconsForEvent", "(Lcom/bluecats/sdk/BCEventFilterContext;Ljava/util/Map;)Ljava/util/List;", "GetFilterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_Ljava_util_Map_Handler:Com.Bluecats.Sdk.IBCEventFilterCallbackInvoker, BindingBlueCatsSDK")]
		global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> FilterBeaconsForEvent (global::Com.Bluecats.Sdk.BCEventFilterContext p0, global::System.Collections.Generic.IDictionary<global::Java.Lang.Object, global::Java.Lang.Object> p1);

	}

	[global::Android.Runtime.Register ("com/bluecats/sdk/BCEventFilterCallback", DoNotGenerateAcw=true)]
	internal class IBCEventFilterCallbackInvoker : global::Java.Lang.Object, IBCEventFilterCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bluecats/sdk/BCEventFilterCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBCEventFilterCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBCEventFilterCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBCEventFilterCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bluecats.sdk.BCEventFilterCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBCEventFilterCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetFilterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_Ljava_util_Map_Handler ()
		{
			if (cb_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_Ljava_util_Map_ == null)
				cb_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_FilterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_Ljava_util_Map_);
			return cb_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_Ljava_util_Map_;
		}

		static IntPtr n_FilterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bluecats.Sdk.IBCEventFilterCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCEventFilterCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCEventFilterContext p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilterContext> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<global::Java.Lang.Object, global::Java.Lang.Object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.ToLocalJniHandle (__this.FilterBeaconsForEvent (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_Ljava_util_Map_;
		public unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> FilterBeaconsForEvent (global::Com.Bluecats.Sdk.BCEventFilterContext p0, global::System.Collections.Generic.IDictionary<global::Java.Lang.Object, global::Java.Lang.Object> p1)
		{
			if (id_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_Ljava_util_Map_ == IntPtr.Zero)
				id_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "filterBeaconsForEvent", "(Lcom/bluecats/sdk/BCEventFilterContext;Ljava/util/Map;)Ljava/util/List;");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<global::Java.Lang.Object, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> __ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

}
