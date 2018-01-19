using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSiteCallback']"
	[Register ("com/bluecats/sdk/BCSiteCallback", "", "Com.Bluecats.Sdk.IBCSiteCallbackInvoker")]
	public partial interface IBCSiteCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSiteCallback']/method[@name='onDidFailWithError' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCError']]"
		[Register ("onDidFailWithError", "(Lcom/bluecats/sdk/BCError;)V", "GetOnDidFailWithError_Lcom_bluecats_sdk_BCError_Handler:Com.Bluecats.Sdk.IBCSiteCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidFailWithError (global::Com.Bluecats.Sdk.BCError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSiteCallback']/method[@name='onDidLoadBeacons' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCBeacon&gt;']]"
		[Register ("onDidLoadBeacons", "(Ljava/util/List;)V", "GetOnDidLoadBeacons_Ljava_util_List_Handler:Com.Bluecats.Sdk.IBCSiteCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidLoadBeacons (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSiteCallback']/method[@name='onDidLoadCategories' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCCategory&gt;']]"
		[Register ("onDidLoadCategories", "(Ljava/util/List;)V", "GetOnDidLoadCategories_Ljava_util_List_Handler:Com.Bluecats.Sdk.IBCSiteCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidLoadCategories (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCCategory> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSiteCallback']/method[@name='onDidLoadSiteInsights' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCSiteInsights']]"
		[Register ("onDidLoadSiteInsights", "(Lcom/bluecats/sdk/BCSiteInsights;)V", "GetOnDidLoadSiteInsights_Lcom_bluecats_sdk_BCSiteInsights_Handler:Com.Bluecats.Sdk.IBCSiteCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidLoadSiteInsights (global::Com.Bluecats.Sdk.BCSiteInsights p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSiteCallback']/method[@name='onDidSwitchToTeam' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCSite']]"
		[Register ("onDidSwitchToTeam", "(Lcom/bluecats/sdk/BCSite;)V", "GetOnDidSwitchToTeam_Lcom_bluecats_sdk_BCSite_Handler:Com.Bluecats.Sdk.IBCSiteCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidSwitchToTeam (global::Com.Bluecats.Sdk.IBCSite p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCSiteCallback']/method[@name='onDidUpdateSite' and count(parameter)=0]"
		[Register ("onDidUpdateSite", "()V", "GetOnDidUpdateSiteHandler:Com.Bluecats.Sdk.IBCSiteCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidUpdateSite ();

	}

	[global::Android.Runtime.Register ("com/bluecats/sdk/BCSiteCallback", DoNotGenerateAcw=true)]
	internal class IBCSiteCallbackInvoker : global::Java.Lang.Object, IBCSiteCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bluecats/sdk/BCSiteCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBCSiteCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBCSiteCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBCSiteCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bluecats.sdk.BCSiteCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBCSiteCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Com.Bluecats.Sdk.IBCSiteCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSiteCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.IBCSiteCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSiteCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onDidLoadCategories_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnDidLoadCategories_Ljava_util_List_Handler ()
		{
			if (cb_onDidLoadCategories_Ljava_util_List_ == null)
				cb_onDidLoadCategories_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidLoadCategories_Ljava_util_List_);
			return cb_onDidLoadCategories_Ljava_util_List_;
		}

		static void n_OnDidLoadCategories_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCSiteCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSiteCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCCategory>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidLoadCategories (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidLoadCategories_Ljava_util_List_;
		public unsafe void OnDidLoadCategories (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCCategory> p0)
		{
			if (id_onDidLoadCategories_Ljava_util_List_ == IntPtr.Zero)
				id_onDidLoadCategories_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onDidLoadCategories", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCCategory>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidLoadCategories_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onDidLoadSiteInsights_Lcom_bluecats_sdk_BCSiteInsights_;
#pragma warning disable 0169
		static Delegate GetOnDidLoadSiteInsights_Lcom_bluecats_sdk_BCSiteInsights_Handler ()
		{
			if (cb_onDidLoadSiteInsights_Lcom_bluecats_sdk_BCSiteInsights_ == null)
				cb_onDidLoadSiteInsights_Lcom_bluecats_sdk_BCSiteInsights_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidLoadSiteInsights_Lcom_bluecats_sdk_BCSiteInsights_);
			return cb_onDidLoadSiteInsights_Lcom_bluecats_sdk_BCSiteInsights_;
		}

		static void n_OnDidLoadSiteInsights_Lcom_bluecats_sdk_BCSiteInsights_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCSiteCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSiteCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCSiteInsights p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteInsights> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidLoadSiteInsights (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidLoadSiteInsights_Lcom_bluecats_sdk_BCSiteInsights_;
		public unsafe void OnDidLoadSiteInsights (global::Com.Bluecats.Sdk.BCSiteInsights p0)
		{
			if (id_onDidLoadSiteInsights_Lcom_bluecats_sdk_BCSiteInsights_ == IntPtr.Zero)
				id_onDidLoadSiteInsights_Lcom_bluecats_sdk_BCSiteInsights_ = JNIEnv.GetMethodID (class_ref, "onDidLoadSiteInsights", "(Lcom/bluecats/sdk/BCSiteInsights;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidLoadSiteInsights_Lcom_bluecats_sdk_BCSiteInsights_, __args);
		}

		static Delegate cb_onDidSwitchToTeam_Lcom_bluecats_sdk_BCSite_;
#pragma warning disable 0169
		static Delegate GetOnDidSwitchToTeam_Lcom_bluecats_sdk_BCSite_Handler ()
		{
			if (cb_onDidSwitchToTeam_Lcom_bluecats_sdk_BCSite_ == null)
				cb_onDidSwitchToTeam_Lcom_bluecats_sdk_BCSite_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidSwitchToTeam_Lcom_bluecats_sdk_BCSite_);
			return cb_onDidSwitchToTeam_Lcom_bluecats_sdk_BCSite_;
		}

		static void n_OnDidSwitchToTeam_Lcom_bluecats_sdk_BCSite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCSiteCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSiteCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite p0 = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidSwitchToTeam (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidSwitchToTeam_Lcom_bluecats_sdk_BCSite_;
		public unsafe void OnDidSwitchToTeam (global::Com.Bluecats.Sdk.IBCSite p0)
		{
			if (id_onDidSwitchToTeam_Lcom_bluecats_sdk_BCSite_ == IntPtr.Zero)
				id_onDidSwitchToTeam_Lcom_bluecats_sdk_BCSite_ = JNIEnv.GetMethodID (class_ref, "onDidSwitchToTeam", "(Lcom/bluecats/sdk/BCSite;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidSwitchToTeam_Lcom_bluecats_sdk_BCSite_, __args);
		}

		static Delegate cb_onDidUpdateSite;
#pragma warning disable 0169
		static Delegate GetOnDidUpdateSiteHandler ()
		{
			if (cb_onDidUpdateSite == null)
				cb_onDidUpdateSite = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDidUpdateSite);
			return cb_onDidUpdateSite;
		}

		static void n_OnDidUpdateSite (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCSiteCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSiteCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDidUpdateSite ();
		}
#pragma warning restore 0169

		IntPtr id_onDidUpdateSite;
		public unsafe void OnDidUpdateSite ()
		{
			if (id_onDidUpdateSite == IntPtr.Zero)
				id_onDidUpdateSite = JNIEnv.GetMethodID (class_ref, "onDidUpdateSite", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidUpdateSite);
		}

	}

}
