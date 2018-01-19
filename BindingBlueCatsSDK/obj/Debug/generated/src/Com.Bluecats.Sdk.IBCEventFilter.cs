using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='IBCEventFilter']"
	[Register ("com/bluecats/sdk/IBCEventFilter", "", "Com.Bluecats.Sdk.IBCEventFilterInvoker")]
	public partial interface IBCEventFilter : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='IBCEventFilter']/method[@name='filterBeaconsForEvent' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCEventFilterContext']]"
		[Register ("filterBeaconsForEvent", "(Lcom/bluecats/sdk/BCEventFilterContext;)Ljava/util/List;", "GetFilterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_Handler:Com.Bluecats.Sdk.IBCEventFilterInvoker, BindingBlueCatsSDK")]
		global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> FilterBeaconsForEvent (global::Com.Bluecats.Sdk.BCEventFilterContext p0);

	}

	[global::Android.Runtime.Register ("com/bluecats/sdk/IBCEventFilter", DoNotGenerateAcw=true)]
	internal class IBCEventFilterInvoker : global::Java.Lang.Object, IBCEventFilter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bluecats/sdk/IBCEventFilter");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBCEventFilterInvoker); }
		}

		IntPtr class_ref;

		public static IBCEventFilter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBCEventFilter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bluecats.sdk.IBCEventFilter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBCEventFilterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_;
#pragma warning disable 0169
		static Delegate GetFilterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_Handler ()
		{
			if (cb_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_ == null)
				cb_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FilterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_);
			return cb_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_;
		}

		static IntPtr n_FilterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCEventFilter __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCEventFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCEventFilterContext p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilterContext> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.ToLocalJniHandle (__this.FilterBeaconsForEvent (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_;
		public unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> FilterBeaconsForEvent (global::Com.Bluecats.Sdk.BCEventFilterContext p0)
		{
			if (id_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_ == IntPtr.Zero)
				id_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_ = JNIEnv.GetMethodID (class_ref, "filterBeaconsForEvent", "(Lcom/bluecats/sdk/BCEventFilterContext;)Ljava/util/List;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> __ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
