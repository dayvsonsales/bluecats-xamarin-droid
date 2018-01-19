using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCTeamCallback']"
	[Register ("com/bluecats/sdk/BCTeamCallback", "", "Com.Bluecats.Sdk.IBCTeamCallbackInvoker")]
	public partial interface IBCTeamCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCTeamCallback']/method[@name='onDidCreateApp' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCApp']]"
		[Register ("onDidCreateApp", "(Lcom/bluecats/sdk/BCApp;)V", "GetOnDidCreateApp_Lcom_bluecats_sdk_BCApp_Handler:Com.Bluecats.Sdk.IBCTeamCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidCreateApp (global::Com.Bluecats.Sdk.IBCApp p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCTeamCallback']/method[@name='onDidCreateCategories' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCCategory&gt;']]"
		[Register ("onDidCreateCategories", "(Ljava/util/List;)V", "GetOnDidCreateCategories_Ljava_util_List_Handler:Com.Bluecats.Sdk.IBCTeamCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidCreateCategories (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCCategory> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCTeamCallback']/method[@name='onDidCreateCategory' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCCategory']]"
		[Register ("onDidCreateCategory", "(Lcom/bluecats/sdk/BCCategory;)V", "GetOnDidCreateCategory_Lcom_bluecats_sdk_BCCategory_Handler:Com.Bluecats.Sdk.IBCTeamCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidCreateCategory (global::Com.Bluecats.Sdk.BCCategory p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCTeamCallback']/method[@name='onDidCreateSite' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCSite']]"
		[Register ("onDidCreateSite", "(Lcom/bluecats/sdk/BCSite;)V", "GetOnDidCreateSite_Lcom_bluecats_sdk_BCSite_Handler:Com.Bluecats.Sdk.IBCTeamCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidCreateSite (global::Com.Bluecats.Sdk.IBCSite p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCTeamCallback']/method[@name='onDidDeleteApp' and count(parameter)=0]"
		[Register ("onDidDeleteApp", "()V", "GetOnDidDeleteAppHandler:Com.Bluecats.Sdk.IBCTeamCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidDeleteApp ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCTeamCallback']/method[@name='onDidDeleteCategory' and count(parameter)=0]"
		[Register ("onDidDeleteCategory", "()V", "GetOnDidDeleteCategoryHandler:Com.Bluecats.Sdk.IBCTeamCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidDeleteCategory ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCTeamCallback']/method[@name='onDidDeleteSite' and count(parameter)=0]"
		[Register ("onDidDeleteSite", "()V", "GetOnDidDeleteSiteHandler:Com.Bluecats.Sdk.IBCTeamCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidDeleteSite ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCTeamCallback']/method[@name='onDidFailWithError' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCError']]"
		[Register ("onDidFailWithError", "(Lcom/bluecats/sdk/BCError;)V", "GetOnDidFailWithError_Lcom_bluecats_sdk_BCError_Handler:Com.Bluecats.Sdk.IBCTeamCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidFailWithError (global::Com.Bluecats.Sdk.BCError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCTeamCallback']/method[@name='onDidLoadAlerts' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCAlert&gt;']]"
		[Register ("onDidLoadAlerts", "(Ljava/util/List;)V", "GetOnDidLoadAlerts_Ljava_util_List_Handler:Com.Bluecats.Sdk.IBCTeamCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidLoadAlerts (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCAlert> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCTeamCallback']/method[@name='onDidLoadApps' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCApp&gt;']]"
		[Register ("onDidLoadApps", "(Ljava/util/List;)V", "GetOnDidLoadApps_Ljava_util_List_Handler:Com.Bluecats.Sdk.IBCTeamCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidLoadApps (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCApp> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCTeamCallback']/method[@name='onDidLoadBeaconRegions' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCBeaconRegion&gt;']]"
		[Register ("onDidLoadBeaconRegions", "(Ljava/util/List;)V", "GetOnDidLoadBeaconRegions_Ljava_util_List_Handler:Com.Bluecats.Sdk.IBCTeamCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidLoadBeaconRegions (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCBeaconRegion> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCTeamCallback']/method[@name='onDidLoadBeacons' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCBeacon&gt;']]"
		[Register ("onDidLoadBeacons", "(Ljava/util/List;)V", "GetOnDidLoadBeacons_Ljava_util_List_Handler:Com.Bluecats.Sdk.IBCTeamCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidLoadBeacons (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCTeamCallback']/method[@name='onDidLoadCategories' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCCategory&gt;']]"
		[Register ("onDidLoadCategories", "(Ljava/util/List;)V", "GetOnDidLoadCategories_Ljava_util_List_Handler:Com.Bluecats.Sdk.IBCTeamCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidLoadCategories (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCCategory> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCTeamCallback']/method[@name='onDidLoadSites' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCSite&gt;']]"
		[Register ("onDidLoadSites", "(Ljava/util/List;)V", "GetOnDidLoadSites_Ljava_util_List_Handler:Com.Bluecats.Sdk.IBCTeamCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidLoadSites (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCSite> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCTeamCallback']/method[@name='onDidLoadTeamInsights' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCTeamInsights']]"
		[Register ("onDidLoadTeamInsights", "(Lcom/bluecats/sdk/BCTeamInsights;)V", "GetOnDidLoadTeamInsights_Lcom_bluecats_sdk_BCTeamInsights_Handler:Com.Bluecats.Sdk.IBCTeamCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidLoadTeamInsights (global::Com.Bluecats.Sdk.BCTeamInsights p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCTeamCallback']/method[@name='onDidLoadTeamInvites' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCTeamInvite&gt;']]"
		[Register ("onDidLoadTeamInvites", "(Ljava/util/List;)V", "GetOnDidLoadTeamInvites_Ljava_util_List_Handler:Com.Bluecats.Sdk.IBCTeamCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidLoadTeamInvites (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCTeamInvite> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCTeamCallback']/method[@name='onDidLoadTeammates' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCPerson&gt;']]"
		[Register ("onDidLoadTeammates", "(Ljava/util/List;)V", "GetOnDidLoadTeammates_Ljava_util_List_Handler:Com.Bluecats.Sdk.IBCTeamCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidLoadTeammates (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCPerson> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCTeamCallback']/method[@name='onDidSendTeamInvite' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCTeamInvite']]"
		[Register ("onDidSendTeamInvite", "(Lcom/bluecats/sdk/BCTeamInvite;)V", "GetOnDidSendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_Handler:Com.Bluecats.Sdk.IBCTeamCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidSendTeamInvite (global::Com.Bluecats.Sdk.BCTeamInvite p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCTeamCallback']/method[@name='onDidUpdateTeam' and count(parameter)=0]"
		[Register ("onDidUpdateTeam", "()V", "GetOnDidUpdateTeamHandler:Com.Bluecats.Sdk.IBCTeamCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidUpdateTeam ();

	}

	[global::Android.Runtime.Register ("com/bluecats/sdk/BCTeamCallback", DoNotGenerateAcw=true)]
	internal class IBCTeamCallbackInvoker : global::Java.Lang.Object, IBCTeamCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bluecats/sdk/BCTeamCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBCTeamCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBCTeamCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBCTeamCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bluecats.sdk.BCTeamCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBCTeamCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDidCreateApp_Lcom_bluecats_sdk_BCApp_;
#pragma warning disable 0169
		static Delegate GetOnDidCreateApp_Lcom_bluecats_sdk_BCApp_Handler ()
		{
			if (cb_onDidCreateApp_Lcom_bluecats_sdk_BCApp_ == null)
				cb_onDidCreateApp_Lcom_bluecats_sdk_BCApp_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidCreateApp_Lcom_bluecats_sdk_BCApp_);
			return cb_onDidCreateApp_Lcom_bluecats_sdk_BCApp_;
		}

		static void n_OnDidCreateApp_Lcom_bluecats_sdk_BCApp_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCTeamCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCApp p0 = (global::Com.Bluecats.Sdk.IBCApp)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidCreateApp (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidCreateApp_Lcom_bluecats_sdk_BCApp_;
		public unsafe void OnDidCreateApp (global::Com.Bluecats.Sdk.IBCApp p0)
		{
			if (id_onDidCreateApp_Lcom_bluecats_sdk_BCApp_ == IntPtr.Zero)
				id_onDidCreateApp_Lcom_bluecats_sdk_BCApp_ = JNIEnv.GetMethodID (class_ref, "onDidCreateApp", "(Lcom/bluecats/sdk/BCApp;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidCreateApp_Lcom_bluecats_sdk_BCApp_, __args);
		}

		static Delegate cb_onDidCreateCategories_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnDidCreateCategories_Ljava_util_List_Handler ()
		{
			if (cb_onDidCreateCategories_Ljava_util_List_ == null)
				cb_onDidCreateCategories_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidCreateCategories_Ljava_util_List_);
			return cb_onDidCreateCategories_Ljava_util_List_;
		}

		static void n_OnDidCreateCategories_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCTeamCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCCategory>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidCreateCategories (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidCreateCategories_Ljava_util_List_;
		public unsafe void OnDidCreateCategories (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCCategory> p0)
		{
			if (id_onDidCreateCategories_Ljava_util_List_ == IntPtr.Zero)
				id_onDidCreateCategories_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onDidCreateCategories", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCCategory>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidCreateCategories_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onDidCreateCategory_Lcom_bluecats_sdk_BCCategory_;
#pragma warning disable 0169
		static Delegate GetOnDidCreateCategory_Lcom_bluecats_sdk_BCCategory_Handler ()
		{
			if (cb_onDidCreateCategory_Lcom_bluecats_sdk_BCCategory_ == null)
				cb_onDidCreateCategory_Lcom_bluecats_sdk_BCCategory_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidCreateCategory_Lcom_bluecats_sdk_BCCategory_);
			return cb_onDidCreateCategory_Lcom_bluecats_sdk_BCCategory_;
		}

		static void n_OnDidCreateCategory_Lcom_bluecats_sdk_BCCategory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCTeamCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCCategory p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategory> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidCreateCategory (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidCreateCategory_Lcom_bluecats_sdk_BCCategory_;
		public unsafe void OnDidCreateCategory (global::Com.Bluecats.Sdk.BCCategory p0)
		{
			if (id_onDidCreateCategory_Lcom_bluecats_sdk_BCCategory_ == IntPtr.Zero)
				id_onDidCreateCategory_Lcom_bluecats_sdk_BCCategory_ = JNIEnv.GetMethodID (class_ref, "onDidCreateCategory", "(Lcom/bluecats/sdk/BCCategory;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidCreateCategory_Lcom_bluecats_sdk_BCCategory_, __args);
		}

		static Delegate cb_onDidCreateSite_Lcom_bluecats_sdk_BCSite_;
#pragma warning disable 0169
		static Delegate GetOnDidCreateSite_Lcom_bluecats_sdk_BCSite_Handler ()
		{
			if (cb_onDidCreateSite_Lcom_bluecats_sdk_BCSite_ == null)
				cb_onDidCreateSite_Lcom_bluecats_sdk_BCSite_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidCreateSite_Lcom_bluecats_sdk_BCSite_);
			return cb_onDidCreateSite_Lcom_bluecats_sdk_BCSite_;
		}

		static void n_OnDidCreateSite_Lcom_bluecats_sdk_BCSite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCTeamCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite p0 = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidCreateSite (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidCreateSite_Lcom_bluecats_sdk_BCSite_;
		public unsafe void OnDidCreateSite (global::Com.Bluecats.Sdk.IBCSite p0)
		{
			if (id_onDidCreateSite_Lcom_bluecats_sdk_BCSite_ == IntPtr.Zero)
				id_onDidCreateSite_Lcom_bluecats_sdk_BCSite_ = JNIEnv.GetMethodID (class_ref, "onDidCreateSite", "(Lcom/bluecats/sdk/BCSite;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidCreateSite_Lcom_bluecats_sdk_BCSite_, __args);
		}

		static Delegate cb_onDidDeleteApp;
#pragma warning disable 0169
		static Delegate GetOnDidDeleteAppHandler ()
		{
			if (cb_onDidDeleteApp == null)
				cb_onDidDeleteApp = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDidDeleteApp);
			return cb_onDidDeleteApp;
		}

		static void n_OnDidDeleteApp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCTeamCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDidDeleteApp ();
		}
#pragma warning restore 0169

		IntPtr id_onDidDeleteApp;
		public unsafe void OnDidDeleteApp ()
		{
			if (id_onDidDeleteApp == IntPtr.Zero)
				id_onDidDeleteApp = JNIEnv.GetMethodID (class_ref, "onDidDeleteApp", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidDeleteApp);
		}

		static Delegate cb_onDidDeleteCategory;
#pragma warning disable 0169
		static Delegate GetOnDidDeleteCategoryHandler ()
		{
			if (cb_onDidDeleteCategory == null)
				cb_onDidDeleteCategory = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDidDeleteCategory);
			return cb_onDidDeleteCategory;
		}

		static void n_OnDidDeleteCategory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCTeamCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDidDeleteCategory ();
		}
#pragma warning restore 0169

		IntPtr id_onDidDeleteCategory;
		public unsafe void OnDidDeleteCategory ()
		{
			if (id_onDidDeleteCategory == IntPtr.Zero)
				id_onDidDeleteCategory = JNIEnv.GetMethodID (class_ref, "onDidDeleteCategory", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidDeleteCategory);
		}

		static Delegate cb_onDidDeleteSite;
#pragma warning disable 0169
		static Delegate GetOnDidDeleteSiteHandler ()
		{
			if (cb_onDidDeleteSite == null)
				cb_onDidDeleteSite = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDidDeleteSite);
			return cb_onDidDeleteSite;
		}

		static void n_OnDidDeleteSite (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCTeamCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDidDeleteSite ();
		}
#pragma warning restore 0169

		IntPtr id_onDidDeleteSite;
		public unsafe void OnDidDeleteSite ()
		{
			if (id_onDidDeleteSite == IntPtr.Zero)
				id_onDidDeleteSite = JNIEnv.GetMethodID (class_ref, "onDidDeleteSite", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidDeleteSite);
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
			global::Com.Bluecats.Sdk.IBCTeamCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onDidLoadAlerts_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnDidLoadAlerts_Ljava_util_List_Handler ()
		{
			if (cb_onDidLoadAlerts_Ljava_util_List_ == null)
				cb_onDidLoadAlerts_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidLoadAlerts_Ljava_util_List_);
			return cb_onDidLoadAlerts_Ljava_util_List_;
		}

		static void n_OnDidLoadAlerts_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCTeamCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCAlert>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidLoadAlerts (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidLoadAlerts_Ljava_util_List_;
		public unsafe void OnDidLoadAlerts (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCAlert> p0)
		{
			if (id_onDidLoadAlerts_Ljava_util_List_ == IntPtr.Zero)
				id_onDidLoadAlerts_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onDidLoadAlerts", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCAlert>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidLoadAlerts_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onDidLoadApps_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnDidLoadApps_Ljava_util_List_Handler ()
		{
			if (cb_onDidLoadApps_Ljava_util_List_ == null)
				cb_onDidLoadApps_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidLoadApps_Ljava_util_List_);
			return cb_onDidLoadApps_Ljava_util_List_;
		}

		static void n_OnDidLoadApps_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCTeamCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCApp>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidLoadApps (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidLoadApps_Ljava_util_List_;
		public unsafe void OnDidLoadApps (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCApp> p0)
		{
			if (id_onDidLoadApps_Ljava_util_List_ == IntPtr.Zero)
				id_onDidLoadApps_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onDidLoadApps", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCApp>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidLoadApps_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onDidLoadBeaconRegions_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnDidLoadBeaconRegions_Ljava_util_List_Handler ()
		{
			if (cb_onDidLoadBeaconRegions_Ljava_util_List_ == null)
				cb_onDidLoadBeaconRegions_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidLoadBeaconRegions_Ljava_util_List_);
			return cb_onDidLoadBeaconRegions_Ljava_util_List_;
		}

		static void n_OnDidLoadBeaconRegions_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCTeamCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCBeaconRegion>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidLoadBeaconRegions (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidLoadBeaconRegions_Ljava_util_List_;
		public unsafe void OnDidLoadBeaconRegions (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCBeaconRegion> p0)
		{
			if (id_onDidLoadBeaconRegions_Ljava_util_List_ == IntPtr.Zero)
				id_onDidLoadBeaconRegions_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onDidLoadBeaconRegions", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCBeaconRegion>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidLoadBeaconRegions_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Bluecats.Sdk.IBCTeamCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.IBCTeamCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onDidLoadSites_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnDidLoadSites_Ljava_util_List_Handler ()
		{
			if (cb_onDidLoadSites_Ljava_util_List_ == null)
				cb_onDidLoadSites_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidLoadSites_Ljava_util_List_);
			return cb_onDidLoadSites_Ljava_util_List_;
		}

		static void n_OnDidLoadSites_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCTeamCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCSite>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidLoadSites (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidLoadSites_Ljava_util_List_;
		public unsafe void OnDidLoadSites (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCSite> p0)
		{
			if (id_onDidLoadSites_Ljava_util_List_ == IntPtr.Zero)
				id_onDidLoadSites_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onDidLoadSites", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCSite>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidLoadSites_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onDidLoadTeamInsights_Lcom_bluecats_sdk_BCTeamInsights_;
#pragma warning disable 0169
		static Delegate GetOnDidLoadTeamInsights_Lcom_bluecats_sdk_BCTeamInsights_Handler ()
		{
			if (cb_onDidLoadTeamInsights_Lcom_bluecats_sdk_BCTeamInsights_ == null)
				cb_onDidLoadTeamInsights_Lcom_bluecats_sdk_BCTeamInsights_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidLoadTeamInsights_Lcom_bluecats_sdk_BCTeamInsights_);
			return cb_onDidLoadTeamInsights_Lcom_bluecats_sdk_BCTeamInsights_;
		}

		static void n_OnDidLoadTeamInsights_Lcom_bluecats_sdk_BCTeamInsights_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCTeamCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCTeamInsights p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamInsights> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidLoadTeamInsights (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidLoadTeamInsights_Lcom_bluecats_sdk_BCTeamInsights_;
		public unsafe void OnDidLoadTeamInsights (global::Com.Bluecats.Sdk.BCTeamInsights p0)
		{
			if (id_onDidLoadTeamInsights_Lcom_bluecats_sdk_BCTeamInsights_ == IntPtr.Zero)
				id_onDidLoadTeamInsights_Lcom_bluecats_sdk_BCTeamInsights_ = JNIEnv.GetMethodID (class_ref, "onDidLoadTeamInsights", "(Lcom/bluecats/sdk/BCTeamInsights;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidLoadTeamInsights_Lcom_bluecats_sdk_BCTeamInsights_, __args);
		}

		static Delegate cb_onDidLoadTeamInvites_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnDidLoadTeamInvites_Ljava_util_List_Handler ()
		{
			if (cb_onDidLoadTeamInvites_Ljava_util_List_ == null)
				cb_onDidLoadTeamInvites_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidLoadTeamInvites_Ljava_util_List_);
			return cb_onDidLoadTeamInvites_Ljava_util_List_;
		}

		static void n_OnDidLoadTeamInvites_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCTeamCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCTeamInvite>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidLoadTeamInvites (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidLoadTeamInvites_Ljava_util_List_;
		public unsafe void OnDidLoadTeamInvites (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCTeamInvite> p0)
		{
			if (id_onDidLoadTeamInvites_Ljava_util_List_ == IntPtr.Zero)
				id_onDidLoadTeamInvites_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onDidLoadTeamInvites", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCTeamInvite>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidLoadTeamInvites_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onDidLoadTeammates_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnDidLoadTeammates_Ljava_util_List_Handler ()
		{
			if (cb_onDidLoadTeammates_Ljava_util_List_ == null)
				cb_onDidLoadTeammates_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidLoadTeammates_Ljava_util_List_);
			return cb_onDidLoadTeammates_Ljava_util_List_;
		}

		static void n_OnDidLoadTeammates_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCTeamCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCPerson>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidLoadTeammates (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidLoadTeammates_Ljava_util_List_;
		public unsafe void OnDidLoadTeammates (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCPerson> p0)
		{
			if (id_onDidLoadTeammates_Ljava_util_List_ == IntPtr.Zero)
				id_onDidLoadTeammates_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onDidLoadTeammates", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCPerson>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidLoadTeammates_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onDidSendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_;
#pragma warning disable 0169
		static Delegate GetOnDidSendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_Handler ()
		{
			if (cb_onDidSendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_ == null)
				cb_onDidSendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidSendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_);
			return cb_onDidSendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_;
		}

		static void n_OnDidSendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCTeamCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCTeamInvite p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamInvite> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidSendTeamInvite (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidSendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_;
		public unsafe void OnDidSendTeamInvite (global::Com.Bluecats.Sdk.BCTeamInvite p0)
		{
			if (id_onDidSendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_ == IntPtr.Zero)
				id_onDidSendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_ = JNIEnv.GetMethodID (class_ref, "onDidSendTeamInvite", "(Lcom/bluecats/sdk/BCTeamInvite;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidSendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_, __args);
		}

		static Delegate cb_onDidUpdateTeam;
#pragma warning disable 0169
		static Delegate GetOnDidUpdateTeamHandler ()
		{
			if (cb_onDidUpdateTeam == null)
				cb_onDidUpdateTeam = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDidUpdateTeam);
			return cb_onDidUpdateTeam;
		}

		static void n_OnDidUpdateTeam (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCTeamCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDidUpdateTeam ();
		}
#pragma warning restore 0169

		IntPtr id_onDidUpdateTeam;
		public unsafe void OnDidUpdateTeam ()
		{
			if (id_onDidUpdateTeam == IntPtr.Zero)
				id_onDidUpdateTeam = JNIEnv.GetMethodID (class_ref, "onDidUpdateTeam", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidUpdateTeam);
		}

	}

}
