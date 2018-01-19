using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCZoneMonitorCallback']"
	[Register ("com/bluecats/sdk/BCZoneMonitorCallback", "", "Com.Bluecats.Sdk.IBCZoneMonitorCallbackInvoker")]
	public partial interface IBCZoneMonitorCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCZoneMonitorCallback']/method[@name='didDwellInZone' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCZone'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("didDwellInZone", "(Lcom/bluecats/sdk/BCZone;Ljava/lang/Integer;)V", "GetDidDwellInZone_Lcom_bluecats_sdk_BCZone_Ljava_lang_Integer_Handler:Com.Bluecats.Sdk.IBCZoneMonitorCallbackInvoker, BindingBlueCatsSDK")]
		void DidDwellInZone (global::Com.Bluecats.Sdk.BCZone p0, global::Java.Lang.Integer p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCZoneMonitorCallback']/method[@name='didEnterSite' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCSite']]"
		[Register ("didEnterSite", "(Lcom/bluecats/sdk/BCSite;)V", "GetDidEnterSite_Lcom_bluecats_sdk_BCSite_Handler:Com.Bluecats.Sdk.IBCZoneMonitorCallbackInvoker, BindingBlueCatsSDK")]
		void DidEnterSite (global::Com.Bluecats.Sdk.IBCSite p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCZoneMonitorCallback']/method[@name='didEnterZone' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCZone']]"
		[Register ("didEnterZone", "(Lcom/bluecats/sdk/BCZone;)V", "GetDidEnterZone_Lcom_bluecats_sdk_BCZone_Handler:Com.Bluecats.Sdk.IBCZoneMonitorCallbackInvoker, BindingBlueCatsSDK")]
		void DidEnterZone (global::Com.Bluecats.Sdk.BCZone p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCZoneMonitorCallback']/method[@name='didExitSite' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCSite']]"
		[Register ("didExitSite", "(Lcom/bluecats/sdk/BCSite;)V", "GetDidExitSite_Lcom_bluecats_sdk_BCSite_Handler:Com.Bluecats.Sdk.IBCZoneMonitorCallbackInvoker, BindingBlueCatsSDK")]
		void DidExitSite (global::Com.Bluecats.Sdk.IBCSite p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCZoneMonitorCallback']/method[@name='didExitZone' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCZone']]"
		[Register ("didExitZone", "(Lcom/bluecats/sdk/BCZone;)V", "GetDidExitZone_Lcom_bluecats_sdk_BCZone_Handler:Com.Bluecats.Sdk.IBCZoneMonitorCallbackInvoker, BindingBlueCatsSDK")]
		void DidExitZone (global::Com.Bluecats.Sdk.BCZone p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCZoneMonitorCallback']/method[@name='didRangeBeacons' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCBeacon&gt;'] and parameter[2][@type='com.bluecats.sdk.BCZone']]"
		[Register ("didRangeBeacons", "(Ljava/util/List;Lcom/bluecats/sdk/BCZone;)V", "GetDidRangeBeacons_Ljava_util_List_Lcom_bluecats_sdk_BCZone_Handler:Com.Bluecats.Sdk.IBCZoneMonitorCallbackInvoker, BindingBlueCatsSDK")]
		void DidRangeBeacons (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> p0, global::Com.Bluecats.Sdk.BCZone p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCZoneMonitorCallback']/method[@name='didReenterZone' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCZone']]"
		[Register ("didReenterZone", "(Lcom/bluecats/sdk/BCZone;)V", "GetDidReenterZone_Lcom_bluecats_sdk_BCZone_Handler:Com.Bluecats.Sdk.IBCZoneMonitorCallbackInvoker, BindingBlueCatsSDK")]
		void DidReenterZone (global::Com.Bluecats.Sdk.BCZone p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCZoneMonitorCallback']/method[@name='inZone' and count(parameter)=4 and parameter[1][@type='com.bluecats.sdk.BCZone'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("inZone", "(Lcom/bluecats/sdk/BCZone;JJJ)V", "GetInZone_Lcom_bluecats_sdk_BCZone_JJJHandler:Com.Bluecats.Sdk.IBCZoneMonitorCallbackInvoker, BindingBlueCatsSDK")]
		void InZone (global::Com.Bluecats.Sdk.BCZone p0, long p1, long p2, long p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCZoneMonitorCallback']/method[@name='willResumeMonitoringInSite' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCSite']]"
		[Register ("willResumeMonitoringInSite", "(Lcom/bluecats/sdk/BCSite;)V", "GetWillResumeMonitoringInSite_Lcom_bluecats_sdk_BCSite_Handler:Com.Bluecats.Sdk.IBCZoneMonitorCallbackInvoker, BindingBlueCatsSDK")]
		void WillResumeMonitoringInSite (global::Com.Bluecats.Sdk.IBCSite p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCZoneMonitorCallback']/method[@name='willSuspendMonitoringInSite' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCSite'] and parameter[2][@type='java.util.Date']]"
		[Register ("willSuspendMonitoringInSite", "(Lcom/bluecats/sdk/BCSite;Ljava/util/Date;)V", "GetWillSuspendMonitoringInSite_Lcom_bluecats_sdk_BCSite_Ljava_util_Date_Handler:Com.Bluecats.Sdk.IBCZoneMonitorCallbackInvoker, BindingBlueCatsSDK")]
		void WillSuspendMonitoringInSite (global::Com.Bluecats.Sdk.IBCSite p0, global::Java.Util.Date p1);

	}

	[global::Android.Runtime.Register ("com/bluecats/sdk/BCZoneMonitorCallback", DoNotGenerateAcw=true)]
	internal class IBCZoneMonitorCallbackInvoker : global::Java.Lang.Object, IBCZoneMonitorCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bluecats/sdk/BCZoneMonitorCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBCZoneMonitorCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBCZoneMonitorCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBCZoneMonitorCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bluecats.sdk.BCZoneMonitorCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBCZoneMonitorCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_didDwellInZone_Lcom_bluecats_sdk_BCZone_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetDidDwellInZone_Lcom_bluecats_sdk_BCZone_Ljava_lang_Integer_Handler ()
		{
			if (cb_didDwellInZone_Lcom_bluecats_sdk_BCZone_Ljava_lang_Integer_ == null)
				cb_didDwellInZone_Lcom_bluecats_sdk_BCZone_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DidDwellInZone_Lcom_bluecats_sdk_BCZone_Ljava_lang_Integer_);
			return cb_didDwellInZone_Lcom_bluecats_sdk_BCZone_Ljava_lang_Integer_;
		}

		static void n_DidDwellInZone_Lcom_bluecats_sdk_BCZone_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bluecats.Sdk.IBCZoneMonitorCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCZoneMonitorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCZone p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DidDwellInZone (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_didDwellInZone_Lcom_bluecats_sdk_BCZone_Ljava_lang_Integer_;
		public unsafe void DidDwellInZone (global::Com.Bluecats.Sdk.BCZone p0, global::Java.Lang.Integer p1)
		{
			if (id_didDwellInZone_Lcom_bluecats_sdk_BCZone_Ljava_lang_Integer_ == IntPtr.Zero)
				id_didDwellInZone_Lcom_bluecats_sdk_BCZone_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "didDwellInZone", "(Lcom/bluecats/sdk/BCZone;Ljava/lang/Integer;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didDwellInZone_Lcom_bluecats_sdk_BCZone_Ljava_lang_Integer_, __args);
		}

		static Delegate cb_didEnterSite_Lcom_bluecats_sdk_BCSite_;
#pragma warning disable 0169
		static Delegate GetDidEnterSite_Lcom_bluecats_sdk_BCSite_Handler ()
		{
			if (cb_didEnterSite_Lcom_bluecats_sdk_BCSite_ == null)
				cb_didEnterSite_Lcom_bluecats_sdk_BCSite_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DidEnterSite_Lcom_bluecats_sdk_BCSite_);
			return cb_didEnterSite_Lcom_bluecats_sdk_BCSite_;
		}

		static void n_DidEnterSite_Lcom_bluecats_sdk_BCSite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCZoneMonitorCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCZoneMonitorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite p0 = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DidEnterSite (p0);
		}
#pragma warning restore 0169

		IntPtr id_didEnterSite_Lcom_bluecats_sdk_BCSite_;
		public unsafe void DidEnterSite (global::Com.Bluecats.Sdk.IBCSite p0)
		{
			if (id_didEnterSite_Lcom_bluecats_sdk_BCSite_ == IntPtr.Zero)
				id_didEnterSite_Lcom_bluecats_sdk_BCSite_ = JNIEnv.GetMethodID (class_ref, "didEnterSite", "(Lcom/bluecats/sdk/BCSite;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didEnterSite_Lcom_bluecats_sdk_BCSite_, __args);
		}

		static Delegate cb_didEnterZone_Lcom_bluecats_sdk_BCZone_;
#pragma warning disable 0169
		static Delegate GetDidEnterZone_Lcom_bluecats_sdk_BCZone_Handler ()
		{
			if (cb_didEnterZone_Lcom_bluecats_sdk_BCZone_ == null)
				cb_didEnterZone_Lcom_bluecats_sdk_BCZone_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DidEnterZone_Lcom_bluecats_sdk_BCZone_);
			return cb_didEnterZone_Lcom_bluecats_sdk_BCZone_;
		}

		static void n_DidEnterZone_Lcom_bluecats_sdk_BCZone_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCZoneMonitorCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCZoneMonitorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCZone p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DidEnterZone (p0);
		}
#pragma warning restore 0169

		IntPtr id_didEnterZone_Lcom_bluecats_sdk_BCZone_;
		public unsafe void DidEnterZone (global::Com.Bluecats.Sdk.BCZone p0)
		{
			if (id_didEnterZone_Lcom_bluecats_sdk_BCZone_ == IntPtr.Zero)
				id_didEnterZone_Lcom_bluecats_sdk_BCZone_ = JNIEnv.GetMethodID (class_ref, "didEnterZone", "(Lcom/bluecats/sdk/BCZone;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didEnterZone_Lcom_bluecats_sdk_BCZone_, __args);
		}

		static Delegate cb_didExitSite_Lcom_bluecats_sdk_BCSite_;
#pragma warning disable 0169
		static Delegate GetDidExitSite_Lcom_bluecats_sdk_BCSite_Handler ()
		{
			if (cb_didExitSite_Lcom_bluecats_sdk_BCSite_ == null)
				cb_didExitSite_Lcom_bluecats_sdk_BCSite_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DidExitSite_Lcom_bluecats_sdk_BCSite_);
			return cb_didExitSite_Lcom_bluecats_sdk_BCSite_;
		}

		static void n_DidExitSite_Lcom_bluecats_sdk_BCSite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCZoneMonitorCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCZoneMonitorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite p0 = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DidExitSite (p0);
		}
#pragma warning restore 0169

		IntPtr id_didExitSite_Lcom_bluecats_sdk_BCSite_;
		public unsafe void DidExitSite (global::Com.Bluecats.Sdk.IBCSite p0)
		{
			if (id_didExitSite_Lcom_bluecats_sdk_BCSite_ == IntPtr.Zero)
				id_didExitSite_Lcom_bluecats_sdk_BCSite_ = JNIEnv.GetMethodID (class_ref, "didExitSite", "(Lcom/bluecats/sdk/BCSite;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didExitSite_Lcom_bluecats_sdk_BCSite_, __args);
		}

		static Delegate cb_didExitZone_Lcom_bluecats_sdk_BCZone_;
#pragma warning disable 0169
		static Delegate GetDidExitZone_Lcom_bluecats_sdk_BCZone_Handler ()
		{
			if (cb_didExitZone_Lcom_bluecats_sdk_BCZone_ == null)
				cb_didExitZone_Lcom_bluecats_sdk_BCZone_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DidExitZone_Lcom_bluecats_sdk_BCZone_);
			return cb_didExitZone_Lcom_bluecats_sdk_BCZone_;
		}

		static void n_DidExitZone_Lcom_bluecats_sdk_BCZone_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCZoneMonitorCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCZoneMonitorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCZone p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DidExitZone (p0);
		}
#pragma warning restore 0169

		IntPtr id_didExitZone_Lcom_bluecats_sdk_BCZone_;
		public unsafe void DidExitZone (global::Com.Bluecats.Sdk.BCZone p0)
		{
			if (id_didExitZone_Lcom_bluecats_sdk_BCZone_ == IntPtr.Zero)
				id_didExitZone_Lcom_bluecats_sdk_BCZone_ = JNIEnv.GetMethodID (class_ref, "didExitZone", "(Lcom/bluecats/sdk/BCZone;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didExitZone_Lcom_bluecats_sdk_BCZone_, __args);
		}

		static Delegate cb_didRangeBeacons_Ljava_util_List_Lcom_bluecats_sdk_BCZone_;
#pragma warning disable 0169
		static Delegate GetDidRangeBeacons_Ljava_util_List_Lcom_bluecats_sdk_BCZone_Handler ()
		{
			if (cb_didRangeBeacons_Ljava_util_List_Lcom_bluecats_sdk_BCZone_ == null)
				cb_didRangeBeacons_Ljava_util_List_Lcom_bluecats_sdk_BCZone_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DidRangeBeacons_Ljava_util_List_Lcom_bluecats_sdk_BCZone_);
			return cb_didRangeBeacons_Ljava_util_List_Lcom_bluecats_sdk_BCZone_;
		}

		static void n_DidRangeBeacons_Ljava_util_List_Lcom_bluecats_sdk_BCZone_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bluecats.Sdk.IBCZoneMonitorCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCZoneMonitorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCZone p1 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DidRangeBeacons (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_didRangeBeacons_Ljava_util_List_Lcom_bluecats_sdk_BCZone_;
		public unsafe void DidRangeBeacons (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> p0, global::Com.Bluecats.Sdk.BCZone p1)
		{
			if (id_didRangeBeacons_Ljava_util_List_Lcom_bluecats_sdk_BCZone_ == IntPtr.Zero)
				id_didRangeBeacons_Ljava_util_List_Lcom_bluecats_sdk_BCZone_ = JNIEnv.GetMethodID (class_ref, "didRangeBeacons", "(Ljava/util/List;Lcom/bluecats/sdk/BCZone;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didRangeBeacons_Ljava_util_List_Lcom_bluecats_sdk_BCZone_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_didReenterZone_Lcom_bluecats_sdk_BCZone_;
#pragma warning disable 0169
		static Delegate GetDidReenterZone_Lcom_bluecats_sdk_BCZone_Handler ()
		{
			if (cb_didReenterZone_Lcom_bluecats_sdk_BCZone_ == null)
				cb_didReenterZone_Lcom_bluecats_sdk_BCZone_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DidReenterZone_Lcom_bluecats_sdk_BCZone_);
			return cb_didReenterZone_Lcom_bluecats_sdk_BCZone_;
		}

		static void n_DidReenterZone_Lcom_bluecats_sdk_BCZone_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCZoneMonitorCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCZoneMonitorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCZone p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DidReenterZone (p0);
		}
#pragma warning restore 0169

		IntPtr id_didReenterZone_Lcom_bluecats_sdk_BCZone_;
		public unsafe void DidReenterZone (global::Com.Bluecats.Sdk.BCZone p0)
		{
			if (id_didReenterZone_Lcom_bluecats_sdk_BCZone_ == IntPtr.Zero)
				id_didReenterZone_Lcom_bluecats_sdk_BCZone_ = JNIEnv.GetMethodID (class_ref, "didReenterZone", "(Lcom/bluecats/sdk/BCZone;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didReenterZone_Lcom_bluecats_sdk_BCZone_, __args);
		}

		static Delegate cb_inZone_Lcom_bluecats_sdk_BCZone_JJJ;
#pragma warning disable 0169
		static Delegate GetInZone_Lcom_bluecats_sdk_BCZone_JJJHandler ()
		{
			if (cb_inZone_Lcom_bluecats_sdk_BCZone_JJJ == null)
				cb_inZone_Lcom_bluecats_sdk_BCZone_JJJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, long, long>) n_InZone_Lcom_bluecats_sdk_BCZone_JJJ);
			return cb_inZone_Lcom_bluecats_sdk_BCZone_JJJ;
		}

		static void n_InZone_Lcom_bluecats_sdk_BCZone_JJJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2, long p3)
		{
			global::Com.Bluecats.Sdk.IBCZoneMonitorCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCZoneMonitorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCZone p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InZone (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_inZone_Lcom_bluecats_sdk_BCZone_JJJ;
		public unsafe void InZone (global::Com.Bluecats.Sdk.BCZone p0, long p1, long p2, long p3)
		{
			if (id_inZone_Lcom_bluecats_sdk_BCZone_JJJ == IntPtr.Zero)
				id_inZone_Lcom_bluecats_sdk_BCZone_JJJ = JNIEnv.GetMethodID (class_ref, "inZone", "(Lcom/bluecats/sdk/BCZone;JJJ)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_inZone_Lcom_bluecats_sdk_BCZone_JJJ, __args);
		}

		static Delegate cb_willResumeMonitoringInSite_Lcom_bluecats_sdk_BCSite_;
#pragma warning disable 0169
		static Delegate GetWillResumeMonitoringInSite_Lcom_bluecats_sdk_BCSite_Handler ()
		{
			if (cb_willResumeMonitoringInSite_Lcom_bluecats_sdk_BCSite_ == null)
				cb_willResumeMonitoringInSite_Lcom_bluecats_sdk_BCSite_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_WillResumeMonitoringInSite_Lcom_bluecats_sdk_BCSite_);
			return cb_willResumeMonitoringInSite_Lcom_bluecats_sdk_BCSite_;
		}

		static void n_WillResumeMonitoringInSite_Lcom_bluecats_sdk_BCSite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCZoneMonitorCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCZoneMonitorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite p0 = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.WillResumeMonitoringInSite (p0);
		}
#pragma warning restore 0169

		IntPtr id_willResumeMonitoringInSite_Lcom_bluecats_sdk_BCSite_;
		public unsafe void WillResumeMonitoringInSite (global::Com.Bluecats.Sdk.IBCSite p0)
		{
			if (id_willResumeMonitoringInSite_Lcom_bluecats_sdk_BCSite_ == IntPtr.Zero)
				id_willResumeMonitoringInSite_Lcom_bluecats_sdk_BCSite_ = JNIEnv.GetMethodID (class_ref, "willResumeMonitoringInSite", "(Lcom/bluecats/sdk/BCSite;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_willResumeMonitoringInSite_Lcom_bluecats_sdk_BCSite_, __args);
		}

		static Delegate cb_willSuspendMonitoringInSite_Lcom_bluecats_sdk_BCSite_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetWillSuspendMonitoringInSite_Lcom_bluecats_sdk_BCSite_Ljava_util_Date_Handler ()
		{
			if (cb_willSuspendMonitoringInSite_Lcom_bluecats_sdk_BCSite_Ljava_util_Date_ == null)
				cb_willSuspendMonitoringInSite_Lcom_bluecats_sdk_BCSite_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_WillSuspendMonitoringInSite_Lcom_bluecats_sdk_BCSite_Ljava_util_Date_);
			return cb_willSuspendMonitoringInSite_Lcom_bluecats_sdk_BCSite_Ljava_util_Date_;
		}

		static void n_WillSuspendMonitoringInSite_Lcom_bluecats_sdk_BCSite_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bluecats.Sdk.IBCZoneMonitorCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCZoneMonitorCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite p0 = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.WillSuspendMonitoringInSite (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_willSuspendMonitoringInSite_Lcom_bluecats_sdk_BCSite_Ljava_util_Date_;
		public unsafe void WillSuspendMonitoringInSite (global::Com.Bluecats.Sdk.IBCSite p0, global::Java.Util.Date p1)
		{
			if (id_willSuspendMonitoringInSite_Lcom_bluecats_sdk_BCSite_Ljava_util_Date_ == IntPtr.Zero)
				id_willSuspendMonitoringInSite_Lcom_bluecats_sdk_BCSite_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "willSuspendMonitoringInSite", "(Lcom/bluecats/sdk/BCSite;Ljava/util/Date;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_willSuspendMonitoringInSite_Lcom_bluecats_sdk_BCSite_Ljava_util_Date_, __args);
		}

	}

}
