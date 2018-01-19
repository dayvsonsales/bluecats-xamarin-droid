using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCMicroLocationManagerCallback']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[Register ("com/bluecats/sdk/BCMicroLocationManagerCallback", "", "Com.Bluecats.Sdk.IBCMicroLocationManagerCallbackInvoker")]
	public partial interface IBCMicroLocationManagerCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCMicroLocationManagerCallback']/method[@name='didBeginVisitForBeaconsWithSerialNumbers' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("didBeginVisitForBeaconsWithSerialNumbers", "(Ljava/util/List;)V", "GetDidBeginVisitForBeaconsWithSerialNumbers_Ljava_util_List_Handler:Com.Bluecats.Sdk.IBCMicroLocationManagerCallbackInvoker, BindingBlueCatsSDK")]
		void DidBeginVisitForBeaconsWithSerialNumbers (global::System.Collections.Generic.IList<string> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCMicroLocationManagerCallback']/method[@name='didEndVisitForBeaconsWithSerialNumbers' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("didEndVisitForBeaconsWithSerialNumbers", "(Ljava/util/List;)V", "GetDidEndVisitForBeaconsWithSerialNumbers_Ljava_util_List_Handler:Com.Bluecats.Sdk.IBCMicroLocationManagerCallbackInvoker, BindingBlueCatsSDK")]
		void DidEndVisitForBeaconsWithSerialNumbers (global::System.Collections.Generic.IList<string> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCMicroLocationManagerCallback']/method[@name='onDidEnterSite' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCSite']]"
		[Register ("onDidEnterSite", "(Lcom/bluecats/sdk/BCSite;)V", "GetOnDidEnterSite_Lcom_bluecats_sdk_BCSite_Handler:Com.Bluecats.Sdk.IBCMicroLocationManagerCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidEnterSite (global::Com.Bluecats.Sdk.IBCSite p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCMicroLocationManagerCallback']/method[@name='onDidExitSite' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCSite']]"
		[Register ("onDidExitSite", "(Lcom/bluecats/sdk/BCSite;)V", "GetOnDidExitSite_Lcom_bluecats_sdk_BCSite_Handler:Com.Bluecats.Sdk.IBCMicroLocationManagerCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidExitSite (global::Com.Bluecats.Sdk.IBCSite p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCMicroLocationManagerCallback']/method[@name='onDidRangeBeaconsForSiteID' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCSite'] and parameter[2][@type='java.util.List&lt;com.bluecats.sdk.BCBeacon&gt;']]"
		[Register ("onDidRangeBeaconsForSiteID", "(Lcom/bluecats/sdk/BCSite;Ljava/util/List;)V", "GetOnDidRangeBeaconsForSiteID_Lcom_bluecats_sdk_BCSite_Ljava_util_List_Handler:Com.Bluecats.Sdk.IBCMicroLocationManagerCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidRangeBeaconsForSiteID (global::Com.Bluecats.Sdk.IBCSite p0, global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCMicroLocationManagerCallback']/method[@name='onDidUpdateMicroLocation' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCMicroLocation&gt;']]"
		[Register ("onDidUpdateMicroLocation", "(Ljava/util/List;)V", "GetOnDidUpdateMicroLocation_Ljava_util_List_Handler:Com.Bluecats.Sdk.IBCMicroLocationManagerCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidUpdateMicroLocation (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCMicroLocation> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCMicroLocationManagerCallback']/method[@name='onDidUpdateNearbySites' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCSite&gt;']]"
		[Register ("onDidUpdateNearbySites", "(Ljava/util/List;)V", "GetOnDidUpdateNearbySites_Ljava_util_List_Handler:Com.Bluecats.Sdk.IBCMicroLocationManagerCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidUpdateNearbySites (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCSite> p0);

	}

	[global::Android.Runtime.Register ("com/bluecats/sdk/BCMicroLocationManagerCallback", DoNotGenerateAcw=true)]
	internal class IBCMicroLocationManagerCallbackInvoker : global::Java.Lang.Object, IBCMicroLocationManagerCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bluecats/sdk/BCMicroLocationManagerCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBCMicroLocationManagerCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBCMicroLocationManagerCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBCMicroLocationManagerCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bluecats.sdk.BCMicroLocationManagerCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBCMicroLocationManagerCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_didBeginVisitForBeaconsWithSerialNumbers_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetDidBeginVisitForBeaconsWithSerialNumbers_Ljava_util_List_Handler ()
		{
			if (cb_didBeginVisitForBeaconsWithSerialNumbers_Ljava_util_List_ == null)
				cb_didBeginVisitForBeaconsWithSerialNumbers_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DidBeginVisitForBeaconsWithSerialNumbers_Ljava_util_List_);
			return cb_didBeginVisitForBeaconsWithSerialNumbers_Ljava_util_List_;
		}

		static void n_DidBeginVisitForBeaconsWithSerialNumbers_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DidBeginVisitForBeaconsWithSerialNumbers (p0);
		}
#pragma warning restore 0169

		IntPtr id_didBeginVisitForBeaconsWithSerialNumbers_Ljava_util_List_;
		public unsafe void DidBeginVisitForBeaconsWithSerialNumbers (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_didBeginVisitForBeaconsWithSerialNumbers_Ljava_util_List_ == IntPtr.Zero)
				id_didBeginVisitForBeaconsWithSerialNumbers_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "didBeginVisitForBeaconsWithSerialNumbers", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didBeginVisitForBeaconsWithSerialNumbers_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_didEndVisitForBeaconsWithSerialNumbers_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetDidEndVisitForBeaconsWithSerialNumbers_Ljava_util_List_Handler ()
		{
			if (cb_didEndVisitForBeaconsWithSerialNumbers_Ljava_util_List_ == null)
				cb_didEndVisitForBeaconsWithSerialNumbers_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DidEndVisitForBeaconsWithSerialNumbers_Ljava_util_List_);
			return cb_didEndVisitForBeaconsWithSerialNumbers_Ljava_util_List_;
		}

		static void n_DidEndVisitForBeaconsWithSerialNumbers_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DidEndVisitForBeaconsWithSerialNumbers (p0);
		}
#pragma warning restore 0169

		IntPtr id_didEndVisitForBeaconsWithSerialNumbers_Ljava_util_List_;
		public unsafe void DidEndVisitForBeaconsWithSerialNumbers (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_didEndVisitForBeaconsWithSerialNumbers_Ljava_util_List_ == IntPtr.Zero)
				id_didEndVisitForBeaconsWithSerialNumbers_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "didEndVisitForBeaconsWithSerialNumbers", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didEndVisitForBeaconsWithSerialNumbers_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onDidEnterSite_Lcom_bluecats_sdk_BCSite_;
#pragma warning disable 0169
		static Delegate GetOnDidEnterSite_Lcom_bluecats_sdk_BCSite_Handler ()
		{
			if (cb_onDidEnterSite_Lcom_bluecats_sdk_BCSite_ == null)
				cb_onDidEnterSite_Lcom_bluecats_sdk_BCSite_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidEnterSite_Lcom_bluecats_sdk_BCSite_);
			return cb_onDidEnterSite_Lcom_bluecats_sdk_BCSite_;
		}

		static void n_OnDidEnterSite_Lcom_bluecats_sdk_BCSite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite p0 = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidEnterSite (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidEnterSite_Lcom_bluecats_sdk_BCSite_;
		public unsafe void OnDidEnterSite (global::Com.Bluecats.Sdk.IBCSite p0)
		{
			if (id_onDidEnterSite_Lcom_bluecats_sdk_BCSite_ == IntPtr.Zero)
				id_onDidEnterSite_Lcom_bluecats_sdk_BCSite_ = JNIEnv.GetMethodID (class_ref, "onDidEnterSite", "(Lcom/bluecats/sdk/BCSite;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidEnterSite_Lcom_bluecats_sdk_BCSite_, __args);
		}

		static Delegate cb_onDidExitSite_Lcom_bluecats_sdk_BCSite_;
#pragma warning disable 0169
		static Delegate GetOnDidExitSite_Lcom_bluecats_sdk_BCSite_Handler ()
		{
			if (cb_onDidExitSite_Lcom_bluecats_sdk_BCSite_ == null)
				cb_onDidExitSite_Lcom_bluecats_sdk_BCSite_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidExitSite_Lcom_bluecats_sdk_BCSite_);
			return cb_onDidExitSite_Lcom_bluecats_sdk_BCSite_;
		}

		static void n_OnDidExitSite_Lcom_bluecats_sdk_BCSite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite p0 = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidExitSite (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidExitSite_Lcom_bluecats_sdk_BCSite_;
		public unsafe void OnDidExitSite (global::Com.Bluecats.Sdk.IBCSite p0)
		{
			if (id_onDidExitSite_Lcom_bluecats_sdk_BCSite_ == IntPtr.Zero)
				id_onDidExitSite_Lcom_bluecats_sdk_BCSite_ = JNIEnv.GetMethodID (class_ref, "onDidExitSite", "(Lcom/bluecats/sdk/BCSite;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidExitSite_Lcom_bluecats_sdk_BCSite_, __args);
		}

		static Delegate cb_onDidRangeBeaconsForSiteID_Lcom_bluecats_sdk_BCSite_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnDidRangeBeaconsForSiteID_Lcom_bluecats_sdk_BCSite_Ljava_util_List_Handler ()
		{
			if (cb_onDidRangeBeaconsForSiteID_Lcom_bluecats_sdk_BCSite_Ljava_util_List_ == null)
				cb_onDidRangeBeaconsForSiteID_Lcom_bluecats_sdk_BCSite_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnDidRangeBeaconsForSiteID_Lcom_bluecats_sdk_BCSite_Ljava_util_List_);
			return cb_onDidRangeBeaconsForSiteID_Lcom_bluecats_sdk_BCSite_Ljava_util_List_;
		}

		static void n_OnDidRangeBeaconsForSiteID_Lcom_bluecats_sdk_BCSite_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite p0 = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnDidRangeBeaconsForSiteID (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onDidRangeBeaconsForSiteID_Lcom_bluecats_sdk_BCSite_Ljava_util_List_;
		public unsafe void OnDidRangeBeaconsForSiteID (global::Com.Bluecats.Sdk.IBCSite p0, global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> p1)
		{
			if (id_onDidRangeBeaconsForSiteID_Lcom_bluecats_sdk_BCSite_Ljava_util_List_ == IntPtr.Zero)
				id_onDidRangeBeaconsForSiteID_Lcom_bluecats_sdk_BCSite_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onDidRangeBeaconsForSiteID", "(Lcom/bluecats/sdk/BCSite;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidRangeBeaconsForSiteID_Lcom_bluecats_sdk_BCSite_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onDidUpdateMicroLocation_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnDidUpdateMicroLocation_Ljava_util_List_Handler ()
		{
			if (cb_onDidUpdateMicroLocation_Ljava_util_List_ == null)
				cb_onDidUpdateMicroLocation_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidUpdateMicroLocation_Ljava_util_List_);
			return cb_onDidUpdateMicroLocation_Ljava_util_List_;
		}

		static void n_OnDidUpdateMicroLocation_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCMicroLocation>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidUpdateMicroLocation (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidUpdateMicroLocation_Ljava_util_List_;
		public unsafe void OnDidUpdateMicroLocation (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCMicroLocation> p0)
		{
			if (id_onDidUpdateMicroLocation_Ljava_util_List_ == IntPtr.Zero)
				id_onDidUpdateMicroLocation_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onDidUpdateMicroLocation", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCMicroLocation>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidUpdateMicroLocation_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onDidUpdateNearbySites_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnDidUpdateNearbySites_Ljava_util_List_Handler ()
		{
			if (cb_onDidUpdateNearbySites_Ljava_util_List_ == null)
				cb_onDidUpdateNearbySites_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidUpdateNearbySites_Ljava_util_List_);
			return cb_onDidUpdateNearbySites_Ljava_util_List_;
		}

		static void n_OnDidUpdateNearbySites_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCSite>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidUpdateNearbySites (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidUpdateNearbySites_Ljava_util_List_;
		public unsafe void OnDidUpdateNearbySites (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCSite> p0)
		{
			if (id_onDidUpdateNearbySites_Ljava_util_List_ == IntPtr.Zero)
				id_onDidUpdateNearbySites_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onDidUpdateNearbySites", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCSite>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidUpdateNearbySites_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
