using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManager']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCBeaconManager", DoNotGenerateAcw=true)]
	public partial class BCBeaconManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManager']/field[@name='TAG']"
		[Register ("TAG")]
		protected const string Tag = (string) "BCBeaconManager";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCBeaconManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCBeaconManager); }
		}

		protected BCBeaconManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManager']/constructor[@name='BCBeaconManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCBeaconManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCBeaconManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_isAttached;
#pragma warning disable 0169
		static Delegate GetIsAttachedHandler ()
		{
			if (cb_isAttached == null)
				cb_isAttached = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAttached);
			return cb_isAttached;
		}

		static bool n_IsAttached (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAttached;
		}
#pragma warning restore 0169

		static IntPtr id_isAttached;
		public virtual unsafe bool IsAttached {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManager']/method[@name='isAttached' and count(parameter)=0]"
			[Register ("isAttached", "()Z", "GetIsAttachedHandler")]
			get {
				if (id_isAttached == IntPtr.Zero)
					id_isAttached = JNIEnv.GetMethodID (class_ref, "isAttached", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAttached);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAttached", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMonitoredBeaconRegions;
#pragma warning disable 0169
		static Delegate GetGetMonitoredBeaconRegionsHandler ()
		{
			if (cb_getMonitoredBeaconRegions == null)
				cb_getMonitoredBeaconRegions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMonitoredBeaconRegions);
			return cb_getMonitoredBeaconRegions;
		}

		static IntPtr n_GetMonitoredBeaconRegions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCBeaconRegion>.ToLocalJniHandle (__this.MonitoredBeaconRegions);
		}
#pragma warning restore 0169

		static IntPtr id_getMonitoredBeaconRegions;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCBeaconRegion> MonitoredBeaconRegions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManager']/method[@name='getMonitoredBeaconRegions' and count(parameter)=0]"
			[Register ("getMonitoredBeaconRegions", "()Ljava/util/List;", "GetGetMonitoredBeaconRegionsHandler")]
			get {
				if (id_getMonitoredBeaconRegions == IntPtr.Zero)
					id_getMonitoredBeaconRegions = JNIEnv.GetMethodID (class_ref, "getMonitoredBeaconRegions", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCBeaconRegion>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMonitoredBeaconRegions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCBeaconRegion>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMonitoredBeaconRegions", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_registerCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_;
#pragma warning disable 0169
		static Delegate GetRegisterCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_Handler ()
		{
			if (cb_registerCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_ == null)
				cb_registerCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_);
			return cb_registerCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_;
		}

		static void n_RegisterCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCBeaconManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconManagerCallback @callback = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconManagerCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.RegisterCallback (@callback);
		}
#pragma warning restore 0169

		static IntPtr id_registerCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManager']/method[@name='registerCallback' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconManagerCallback']]"
		[Register ("registerCallback", "(Lcom/bluecats/sdk/BCBeaconManagerCallback;)V", "GetRegisterCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_Handler")]
		public virtual unsafe void RegisterCallback (global::Com.Bluecats.Sdk.BCBeaconManagerCallback @callback)
		{
			if (id_registerCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_ == IntPtr.Zero)
				id_registerCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_ = JNIEnv.GetMethodID (class_ref, "registerCallback", "(Lcom/bluecats/sdk/BCBeaconManagerCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerCallback", "(Lcom/bluecats/sdk/BCBeaconManagerCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_requestStateForBeacon_Lcom_bluecats_sdk_BCBeacon_;
#pragma warning disable 0169
		static Delegate GetRequestStateForBeacon_Lcom_bluecats_sdk_BCBeacon_Handler ()
		{
			if (cb_requestStateForBeacon_Lcom_bluecats_sdk_BCBeacon_ == null)
				cb_requestStateForBeacon_Lcom_bluecats_sdk_BCBeacon_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RequestStateForBeacon_Lcom_bluecats_sdk_BCBeacon_);
			return cb_requestStateForBeacon_Lcom_bluecats_sdk_BCBeacon_;
		}

		static void n_RequestStateForBeacon_Lcom_bluecats_sdk_BCBeacon_ (IntPtr jnienv, IntPtr native__this, IntPtr native_beacon)
		{
			global::Com.Bluecats.Sdk.BCBeaconManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeacon beacon = (global::Com.Bluecats.Sdk.IBCBeacon)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (native_beacon, JniHandleOwnership.DoNotTransfer);
			__this.RequestStateForBeacon (beacon);
		}
#pragma warning restore 0169

		static IntPtr id_requestStateForBeacon_Lcom_bluecats_sdk_BCBeacon_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManager']/method[@name='requestStateForBeacon' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeacon']]"
		[Register ("requestStateForBeacon", "(Lcom/bluecats/sdk/BCBeacon;)V", "GetRequestStateForBeacon_Lcom_bluecats_sdk_BCBeacon_Handler")]
		public virtual unsafe void RequestStateForBeacon (global::Com.Bluecats.Sdk.IBCBeacon beacon)
		{
			if (id_requestStateForBeacon_Lcom_bluecats_sdk_BCBeacon_ == IntPtr.Zero)
				id_requestStateForBeacon_Lcom_bluecats_sdk_BCBeacon_ = JNIEnv.GetMethodID (class_ref, "requestStateForBeacon", "(Lcom/bluecats/sdk/BCBeacon;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (beacon);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestStateForBeacon_Lcom_bluecats_sdk_BCBeacon_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestStateForBeacon", "(Lcom/bluecats/sdk/BCBeacon;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_requestStateForSite_Lcom_bluecats_sdk_BCSite_;
#pragma warning disable 0169
		static Delegate GetRequestStateForSite_Lcom_bluecats_sdk_BCSite_Handler ()
		{
			if (cb_requestStateForSite_Lcom_bluecats_sdk_BCSite_ == null)
				cb_requestStateForSite_Lcom_bluecats_sdk_BCSite_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RequestStateForSite_Lcom_bluecats_sdk_BCSite_);
			return cb_requestStateForSite_Lcom_bluecats_sdk_BCSite_;
		}

		static void n_RequestStateForSite_Lcom_bluecats_sdk_BCSite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_site)
		{
			global::Com.Bluecats.Sdk.BCBeaconManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite site = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_site, JniHandleOwnership.DoNotTransfer);
			__this.RequestStateForSite (site);
		}
#pragma warning restore 0169

		static IntPtr id_requestStateForSite_Lcom_bluecats_sdk_BCSite_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManager']/method[@name='requestStateForSite' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCSite']]"
		[Register ("requestStateForSite", "(Lcom/bluecats/sdk/BCSite;)V", "GetRequestStateForSite_Lcom_bluecats_sdk_BCSite_Handler")]
		public virtual unsafe void RequestStateForSite (global::Com.Bluecats.Sdk.IBCSite site)
		{
			if (id_requestStateForSite_Lcom_bluecats_sdk_BCSite_ == IntPtr.Zero)
				id_requestStateForSite_Lcom_bluecats_sdk_BCSite_ = JNIEnv.GetMethodID (class_ref, "requestStateForSite", "(Lcom/bluecats/sdk/BCSite;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (site);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestStateForSite_Lcom_bluecats_sdk_BCSite_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestStateForSite", "(Lcom/bluecats/sdk/BCSite;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_;
#pragma warning disable 0169
		static Delegate GetStartMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_Handler ()
		{
			if (cb_startMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_ == null)
				cb_startMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_);
			return cb_startMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_;
		}

		static void n_StartMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_ (IntPtr jnienv, IntPtr native__this, IntPtr native_beaconRegion)
		{
			global::Com.Bluecats.Sdk.BCBeaconManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconRegion beaconRegion = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (native_beaconRegion, JniHandleOwnership.DoNotTransfer);
			__this.StartMonitoringBeaconRegion (beaconRegion);
		}
#pragma warning restore 0169

		static IntPtr id_startMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManager']/method[@name='startMonitoringBeaconRegion' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconRegion']]"
		[Register ("startMonitoringBeaconRegion", "(Lcom/bluecats/sdk/BCBeaconRegion;)V", "GetStartMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_Handler")]
		public virtual unsafe void StartMonitoringBeaconRegion (global::Com.Bluecats.Sdk.BCBeaconRegion beaconRegion)
		{
			if (id_startMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_ == IntPtr.Zero)
				id_startMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_ = JNIEnv.GetMethodID (class_ref, "startMonitoringBeaconRegion", "(Lcom/bluecats/sdk/BCBeaconRegion;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (beaconRegion);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startMonitoringBeaconRegion", "(Lcom/bluecats/sdk/BCBeaconRegion;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_stopMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_;
#pragma warning disable 0169
		static Delegate GetStopMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_Handler ()
		{
			if (cb_stopMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_ == null)
				cb_stopMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StopMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_);
			return cb_stopMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_;
		}

		static void n_StopMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_ (IntPtr jnienv, IntPtr native__this, IntPtr native_beaconRegion)
		{
			global::Com.Bluecats.Sdk.BCBeaconManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconRegion beaconRegion = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (native_beaconRegion, JniHandleOwnership.DoNotTransfer);
			__this.StopMonitoringBeaconRegion (beaconRegion);
		}
#pragma warning restore 0169

		static IntPtr id_stopMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManager']/method[@name='stopMonitoringBeaconRegion' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconRegion']]"
		[Register ("stopMonitoringBeaconRegion", "(Lcom/bluecats/sdk/BCBeaconRegion;)V", "GetStopMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_Handler")]
		public virtual unsafe void StopMonitoringBeaconRegion (global::Com.Bluecats.Sdk.BCBeaconRegion beaconRegion)
		{
			if (id_stopMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_ == IntPtr.Zero)
				id_stopMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_ = JNIEnv.GetMethodID (class_ref, "stopMonitoringBeaconRegion", "(Lcom/bluecats/sdk/BCBeaconRegion;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (beaconRegion);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopMonitoringBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopMonitoringBeaconRegion", "(Lcom/bluecats/sdk/BCBeaconRegion;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_unregisterCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_;
#pragma warning disable 0169
		static Delegate GetUnregisterCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_Handler ()
		{
			if (cb_unregisterCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_ == null)
				cb_unregisterCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_);
			return cb_unregisterCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_;
		}

		static void n_UnregisterCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCBeaconManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconManagerCallback @callback = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconManagerCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterCallback (@callback);
		}
#pragma warning restore 0169

		static IntPtr id_unregisterCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManager']/method[@name='unregisterCallback' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconManagerCallback']]"
		[Register ("unregisterCallback", "(Lcom/bluecats/sdk/BCBeaconManagerCallback;)V", "GetUnregisterCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_Handler")]
		public virtual unsafe void UnregisterCallback (global::Com.Bluecats.Sdk.BCBeaconManagerCallback @callback)
		{
			if (id_unregisterCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_ == IntPtr.Zero)
				id_unregisterCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_ = JNIEnv.GetMethodID (class_ref, "unregisterCallback", "(Lcom/bluecats/sdk/BCBeaconManagerCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterCallback_Lcom_bluecats_sdk_BCBeaconManagerCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterCallback", "(Lcom/bluecats/sdk/BCBeaconManagerCallback;)V"), __args);
			} finally {
			}
		}

	}
}
