using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManagerCallback']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCBeaconManagerCallback", DoNotGenerateAcw=true)]
	public abstract partial class BCBeaconManagerCallback : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCBeaconManagerCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCBeaconManagerCallback); }
		}

		protected BCBeaconManagerCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManagerCallback']/constructor[@name='BCBeaconManagerCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCBeaconManagerCallback ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCBeaconManagerCallback)) {
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

		static Delegate cb_didDetermineState_Lcom_bluecats_sdk_BCBeacon_BCBeaconState_Lcom_bluecats_sdk_BCBeacon_;
#pragma warning disable 0169
		static Delegate GetDidDetermineState_Lcom_bluecats_sdk_BCBeacon_BCBeaconState_Lcom_bluecats_sdk_BCBeacon_Handler ()
		{
			if (cb_didDetermineState_Lcom_bluecats_sdk_BCBeacon_BCBeaconState_Lcom_bluecats_sdk_BCBeacon_ == null)
				cb_didDetermineState_Lcom_bluecats_sdk_BCBeacon_BCBeaconState_Lcom_bluecats_sdk_BCBeacon_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DidDetermineState_Lcom_bluecats_sdk_BCBeacon_BCBeaconState_Lcom_bluecats_sdk_BCBeacon_);
			return cb_didDetermineState_Lcom_bluecats_sdk_BCBeacon_BCBeaconState_Lcom_bluecats_sdk_BCBeacon_;
		}

		static void n_DidDetermineState_Lcom_bluecats_sdk_BCBeacon_BCBeaconState_Lcom_bluecats_sdk_BCBeacon_ (IntPtr jnienv, IntPtr native__this, IntPtr native_state, IntPtr native_forBeacon)
		{
			global::Com.Bluecats.Sdk.BCBeaconManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconBCBeaconState state = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCBeaconState> (native_state, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeacon forBeacon = (global::Com.Bluecats.Sdk.IBCBeacon)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (native_forBeacon, JniHandleOwnership.DoNotTransfer);
			__this.DidDetermineState (state, forBeacon);
		}
#pragma warning restore 0169

		static IntPtr id_didDetermineState_Lcom_bluecats_sdk_BCBeacon_BCBeaconState_Lcom_bluecats_sdk_BCBeacon_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManagerCallback']/method[@name='didDetermineState' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCBeacon.BCBeaconState'] and parameter[2][@type='com.bluecats.sdk.BCBeacon']]"
		[Register ("didDetermineState", "(Lcom/bluecats/sdk/BCBeacon$BCBeaconState;Lcom/bluecats/sdk/BCBeacon;)V", "GetDidDetermineState_Lcom_bluecats_sdk_BCBeacon_BCBeaconState_Lcom_bluecats_sdk_BCBeacon_Handler")]
		public virtual unsafe void DidDetermineState (global::Com.Bluecats.Sdk.BCBeaconBCBeaconState state, global::Com.Bluecats.Sdk.IBCBeacon forBeacon)
		{
			if (id_didDetermineState_Lcom_bluecats_sdk_BCBeacon_BCBeaconState_Lcom_bluecats_sdk_BCBeacon_ == IntPtr.Zero)
				id_didDetermineState_Lcom_bluecats_sdk_BCBeacon_BCBeaconState_Lcom_bluecats_sdk_BCBeacon_ = JNIEnv.GetMethodID (class_ref, "didDetermineState", "(Lcom/bluecats/sdk/BCBeacon$BCBeaconState;Lcom/bluecats/sdk/BCBeacon;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (state);
				__args [1] = new JValue (forBeacon);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didDetermineState_Lcom_bluecats_sdk_BCBeacon_BCBeaconState_Lcom_bluecats_sdk_BCBeacon_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "didDetermineState", "(Lcom/bluecats/sdk/BCBeacon$BCBeaconState;Lcom/bluecats/sdk/BCBeacon;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_didDetermineState_Lcom_bluecats_sdk_BCSite_BCSiteState_Lcom_bluecats_sdk_BCSite_;
#pragma warning disable 0169
		static Delegate GetDidDetermineState_Lcom_bluecats_sdk_BCSite_BCSiteState_Lcom_bluecats_sdk_BCSite_Handler ()
		{
			if (cb_didDetermineState_Lcom_bluecats_sdk_BCSite_BCSiteState_Lcom_bluecats_sdk_BCSite_ == null)
				cb_didDetermineState_Lcom_bluecats_sdk_BCSite_BCSiteState_Lcom_bluecats_sdk_BCSite_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DidDetermineState_Lcom_bluecats_sdk_BCSite_BCSiteState_Lcom_bluecats_sdk_BCSite_);
			return cb_didDetermineState_Lcom_bluecats_sdk_BCSite_BCSiteState_Lcom_bluecats_sdk_BCSite_;
		}

		static void n_DidDetermineState_Lcom_bluecats_sdk_BCSite_BCSiteState_Lcom_bluecats_sdk_BCSite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_state, IntPtr native_forSite)
		{
			global::Com.Bluecats.Sdk.BCBeaconManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCSiteBCSiteState state = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteBCSiteState> (native_state, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite forSite = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_forSite, JniHandleOwnership.DoNotTransfer);
			__this.DidDetermineState (state, forSite);
		}
#pragma warning restore 0169

		static IntPtr id_didDetermineState_Lcom_bluecats_sdk_BCSite_BCSiteState_Lcom_bluecats_sdk_BCSite_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManagerCallback']/method[@name='didDetermineState' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCSite.BCSiteState'] and parameter[2][@type='com.bluecats.sdk.BCSite']]"
		[Register ("didDetermineState", "(Lcom/bluecats/sdk/BCSite$BCSiteState;Lcom/bluecats/sdk/BCSite;)V", "GetDidDetermineState_Lcom_bluecats_sdk_BCSite_BCSiteState_Lcom_bluecats_sdk_BCSite_Handler")]
		public virtual unsafe void DidDetermineState (global::Com.Bluecats.Sdk.BCSiteBCSiteState state, global::Com.Bluecats.Sdk.IBCSite forSite)
		{
			if (id_didDetermineState_Lcom_bluecats_sdk_BCSite_BCSiteState_Lcom_bluecats_sdk_BCSite_ == IntPtr.Zero)
				id_didDetermineState_Lcom_bluecats_sdk_BCSite_BCSiteState_Lcom_bluecats_sdk_BCSite_ = JNIEnv.GetMethodID (class_ref, "didDetermineState", "(Lcom/bluecats/sdk/BCSite$BCSiteState;Lcom/bluecats/sdk/BCSite;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (state);
				__args [1] = new JValue (forSite);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didDetermineState_Lcom_bluecats_sdk_BCSite_BCSiteState_Lcom_bluecats_sdk_BCSite_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "didDetermineState", "(Lcom/bluecats/sdk/BCSite$BCSiteState;Lcom/bluecats/sdk/BCSite;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_didDiscoverEddystoneURL_Ljava_net_URL_;
#pragma warning disable 0169
		static Delegate GetDidDiscoverEddystoneURL_Ljava_net_URL_Handler ()
		{
			if (cb_didDiscoverEddystoneURL_Ljava_net_URL_ == null)
				cb_didDiscoverEddystoneURL_Ljava_net_URL_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DidDiscoverEddystoneURL_Ljava_net_URL_);
			return cb_didDiscoverEddystoneURL_Ljava_net_URL_;
		}

		static void n_DidDiscoverEddystoneURL_Ljava_net_URL_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eddystoneUrl)
		{
			global::Com.Bluecats.Sdk.BCBeaconManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.URL eddystoneUrl = global::Java.Lang.Object.GetObject<global::Java.Net.URL> (native_eddystoneUrl, JniHandleOwnership.DoNotTransfer);
			__this.DidDiscoverEddystoneURL (eddystoneUrl);
		}
#pragma warning restore 0169

		static IntPtr id_didDiscoverEddystoneURL_Ljava_net_URL_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManagerCallback']/method[@name='didDiscoverEddystoneURL' and count(parameter)=1 and parameter[1][@type='java.net.URL']]"
		[Register ("didDiscoverEddystoneURL", "(Ljava/net/URL;)V", "GetDidDiscoverEddystoneURL_Ljava_net_URL_Handler")]
		public virtual unsafe void DidDiscoverEddystoneURL (global::Java.Net.URL eddystoneUrl)
		{
			if (id_didDiscoverEddystoneURL_Ljava_net_URL_ == IntPtr.Zero)
				id_didDiscoverEddystoneURL_Ljava_net_URL_ = JNIEnv.GetMethodID (class_ref, "didDiscoverEddystoneURL", "(Ljava/net/URL;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (eddystoneUrl);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didDiscoverEddystoneURL_Ljava_net_URL_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "didDiscoverEddystoneURL", "(Ljava/net/URL;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_didEnterBeacons_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetDidEnterBeacons_Ljava_util_List_Handler ()
		{
			if (cb_didEnterBeacons_Ljava_util_List_ == null)
				cb_didEnterBeacons_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DidEnterBeacons_Ljava_util_List_);
			return cb_didEnterBeacons_Ljava_util_List_;
		}

		static void n_DidEnterBeacons_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_beacons)
		{
			global::Com.Bluecats.Sdk.BCBeaconManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var beacons = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (native_beacons, JniHandleOwnership.DoNotTransfer);
			__this.DidEnterBeacons (beacons);
		}
#pragma warning restore 0169

		static IntPtr id_didEnterBeacons_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManagerCallback']/method[@name='didEnterBeacons' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCBeacon&gt;']]"
		[Register ("didEnterBeacons", "(Ljava/util/List;)V", "GetDidEnterBeacons_Ljava_util_List_Handler")]
		public virtual unsafe void DidEnterBeacons (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> beacons)
		{
			if (id_didEnterBeacons_Ljava_util_List_ == IntPtr.Zero)
				id_didEnterBeacons_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "didEnterBeacons", "(Ljava/util/List;)V");
			IntPtr native_beacons = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.ToLocalJniHandle (beacons);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_beacons);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didEnterBeacons_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "didEnterBeacons", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_beacons);
			}
		}

		static Delegate cb_didEnterSite_Lcom_bluecats_sdk_BCSite_;
#pragma warning disable 0169
		static Delegate GetDidEnterSite_Lcom_bluecats_sdk_BCSite_Handler ()
		{
			if (cb_didEnterSite_Lcom_bluecats_sdk_BCSite_ == null)
				cb_didEnterSite_Lcom_bluecats_sdk_BCSite_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DidEnterSite_Lcom_bluecats_sdk_BCSite_);
			return cb_didEnterSite_Lcom_bluecats_sdk_BCSite_;
		}

		static void n_DidEnterSite_Lcom_bluecats_sdk_BCSite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_site)
		{
			global::Com.Bluecats.Sdk.BCBeaconManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite site = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_site, JniHandleOwnership.DoNotTransfer);
			__this.DidEnterSite (site);
		}
#pragma warning restore 0169

		static IntPtr id_didEnterSite_Lcom_bluecats_sdk_BCSite_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManagerCallback']/method[@name='didEnterSite' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCSite']]"
		[Register ("didEnterSite", "(Lcom/bluecats/sdk/BCSite;)V", "GetDidEnterSite_Lcom_bluecats_sdk_BCSite_Handler")]
		public virtual unsafe void DidEnterSite (global::Com.Bluecats.Sdk.IBCSite site)
		{
			if (id_didEnterSite_Lcom_bluecats_sdk_BCSite_ == IntPtr.Zero)
				id_didEnterSite_Lcom_bluecats_sdk_BCSite_ = JNIEnv.GetMethodID (class_ref, "didEnterSite", "(Lcom/bluecats/sdk/BCSite;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (site);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didEnterSite_Lcom_bluecats_sdk_BCSite_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "didEnterSite", "(Lcom/bluecats/sdk/BCSite;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_didExitBeacons_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetDidExitBeacons_Ljava_util_List_Handler ()
		{
			if (cb_didExitBeacons_Ljava_util_List_ == null)
				cb_didExitBeacons_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DidExitBeacons_Ljava_util_List_);
			return cb_didExitBeacons_Ljava_util_List_;
		}

		static void n_DidExitBeacons_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_beacons)
		{
			global::Com.Bluecats.Sdk.BCBeaconManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var beacons = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (native_beacons, JniHandleOwnership.DoNotTransfer);
			__this.DidExitBeacons (beacons);
		}
#pragma warning restore 0169

		static IntPtr id_didExitBeacons_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManagerCallback']/method[@name='didExitBeacons' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCBeacon&gt;']]"
		[Register ("didExitBeacons", "(Ljava/util/List;)V", "GetDidExitBeacons_Ljava_util_List_Handler")]
		public virtual unsafe void DidExitBeacons (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> beacons)
		{
			if (id_didExitBeacons_Ljava_util_List_ == IntPtr.Zero)
				id_didExitBeacons_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "didExitBeacons", "(Ljava/util/List;)V");
			IntPtr native_beacons = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.ToLocalJniHandle (beacons);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_beacons);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didExitBeacons_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "didExitBeacons", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_beacons);
			}
		}

		static Delegate cb_didExitSite_Lcom_bluecats_sdk_BCSite_;
#pragma warning disable 0169
		static Delegate GetDidExitSite_Lcom_bluecats_sdk_BCSite_Handler ()
		{
			if (cb_didExitSite_Lcom_bluecats_sdk_BCSite_ == null)
				cb_didExitSite_Lcom_bluecats_sdk_BCSite_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DidExitSite_Lcom_bluecats_sdk_BCSite_);
			return cb_didExitSite_Lcom_bluecats_sdk_BCSite_;
		}

		static void n_DidExitSite_Lcom_bluecats_sdk_BCSite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_site)
		{
			global::Com.Bluecats.Sdk.BCBeaconManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite site = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_site, JniHandleOwnership.DoNotTransfer);
			__this.DidExitSite (site);
		}
#pragma warning restore 0169

		static IntPtr id_didExitSite_Lcom_bluecats_sdk_BCSite_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManagerCallback']/method[@name='didExitSite' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCSite']]"
		[Register ("didExitSite", "(Lcom/bluecats/sdk/BCSite;)V", "GetDidExitSite_Lcom_bluecats_sdk_BCSite_Handler")]
		public virtual unsafe void DidExitSite (global::Com.Bluecats.Sdk.IBCSite site)
		{
			if (id_didExitSite_Lcom_bluecats_sdk_BCSite_ == IntPtr.Zero)
				id_didExitSite_Lcom_bluecats_sdk_BCSite_ = JNIEnv.GetMethodID (class_ref, "didExitSite", "(Lcom/bluecats/sdk/BCSite;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (site);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didExitSite_Lcom_bluecats_sdk_BCSite_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "didExitSite", "(Lcom/bluecats/sdk/BCSite;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_didRangeBeacons_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetDidRangeBeacons_Ljava_util_List_Handler ()
		{
			if (cb_didRangeBeacons_Ljava_util_List_ == null)
				cb_didRangeBeacons_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DidRangeBeacons_Ljava_util_List_);
			return cb_didRangeBeacons_Ljava_util_List_;
		}

		static void n_DidRangeBeacons_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_beacons)
		{
			global::Com.Bluecats.Sdk.BCBeaconManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var beacons = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (native_beacons, JniHandleOwnership.DoNotTransfer);
			__this.DidRangeBeacons (beacons);
		}
#pragma warning restore 0169

		static IntPtr id_didRangeBeacons_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManagerCallback']/method[@name='didRangeBeacons' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCBeacon&gt;']]"
		[Register ("didRangeBeacons", "(Ljava/util/List;)V", "GetDidRangeBeacons_Ljava_util_List_Handler")]
		public virtual unsafe void DidRangeBeacons (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> beacons)
		{
			if (id_didRangeBeacons_Ljava_util_List_ == IntPtr.Zero)
				id_didRangeBeacons_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "didRangeBeacons", "(Ljava/util/List;)V");
			IntPtr native_beacons = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.ToLocalJniHandle (beacons);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_beacons);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didRangeBeacons_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "didRangeBeacons", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_beacons);
			}
		}

		static Delegate cb_didRangeBlueCatsBeacons_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetDidRangeBlueCatsBeacons_Ljava_util_List_Handler ()
		{
			if (cb_didRangeBlueCatsBeacons_Ljava_util_List_ == null)
				cb_didRangeBlueCatsBeacons_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DidRangeBlueCatsBeacons_Ljava_util_List_);
			return cb_didRangeBlueCatsBeacons_Ljava_util_List_;
		}

		static void n_DidRangeBlueCatsBeacons_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_beacons)
		{
			global::Com.Bluecats.Sdk.BCBeaconManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var beacons = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (native_beacons, JniHandleOwnership.DoNotTransfer);
			__this.DidRangeBlueCatsBeacons (beacons);
		}
#pragma warning restore 0169

		static IntPtr id_didRangeBlueCatsBeacons_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManagerCallback']/method[@name='didRangeBlueCatsBeacons' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCBeacon&gt;']]"
		[Register ("didRangeBlueCatsBeacons", "(Ljava/util/List;)V", "GetDidRangeBlueCatsBeacons_Ljava_util_List_Handler")]
		public virtual unsafe void DidRangeBlueCatsBeacons (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> beacons)
		{
			if (id_didRangeBlueCatsBeacons_Ljava_util_List_ == IntPtr.Zero)
				id_didRangeBlueCatsBeacons_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "didRangeBlueCatsBeacons", "(Ljava/util/List;)V");
			IntPtr native_beacons = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.ToLocalJniHandle (beacons);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_beacons);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didRangeBlueCatsBeacons_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "didRangeBlueCatsBeacons", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_beacons);
			}
		}

		static Delegate cb_didRangeEddystoneBeacons_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetDidRangeEddystoneBeacons_Ljava_util_List_Handler ()
		{
			if (cb_didRangeEddystoneBeacons_Ljava_util_List_ == null)
				cb_didRangeEddystoneBeacons_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DidRangeEddystoneBeacons_Ljava_util_List_);
			return cb_didRangeEddystoneBeacons_Ljava_util_List_;
		}

		static void n_DidRangeEddystoneBeacons_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eddystoneBeacons)
		{
			global::Com.Bluecats.Sdk.BCBeaconManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var eddystoneBeacons = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (native_eddystoneBeacons, JniHandleOwnership.DoNotTransfer);
			__this.DidRangeEddystoneBeacons (eddystoneBeacons);
		}
#pragma warning restore 0169

		static IntPtr id_didRangeEddystoneBeacons_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManagerCallback']/method[@name='didRangeEddystoneBeacons' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCBeacon&gt;']]"
		[Register ("didRangeEddystoneBeacons", "(Ljava/util/List;)V", "GetDidRangeEddystoneBeacons_Ljava_util_List_Handler")]
		public virtual unsafe void DidRangeEddystoneBeacons (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> eddystoneBeacons)
		{
			if (id_didRangeEddystoneBeacons_Ljava_util_List_ == IntPtr.Zero)
				id_didRangeEddystoneBeacons_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "didRangeEddystoneBeacons", "(Ljava/util/List;)V");
			IntPtr native_eddystoneBeacons = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.ToLocalJniHandle (eddystoneBeacons);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_eddystoneBeacons);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didRangeEddystoneBeacons_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "didRangeEddystoneBeacons", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_eddystoneBeacons);
			}
		}

		static Delegate cb_didRangeIBeacons_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetDidRangeIBeacons_Ljava_util_List_Handler ()
		{
			if (cb_didRangeIBeacons_Ljava_util_List_ == null)
				cb_didRangeIBeacons_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DidRangeIBeacons_Ljava_util_List_);
			return cb_didRangeIBeacons_Ljava_util_List_;
		}

		static void n_DidRangeIBeacons_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_iBeacons)
		{
			global::Com.Bluecats.Sdk.BCBeaconManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var iBeacons = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (native_iBeacons, JniHandleOwnership.DoNotTransfer);
			__this.DidRangeIBeacons (iBeacons);
		}
#pragma warning restore 0169

		static IntPtr id_didRangeIBeacons_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManagerCallback']/method[@name='didRangeIBeacons' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCBeacon&gt;']]"
		[Register ("didRangeIBeacons", "(Ljava/util/List;)V", "GetDidRangeIBeacons_Ljava_util_List_Handler")]
		public virtual unsafe void DidRangeIBeacons (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> iBeacons)
		{
			if (id_didRangeIBeacons_Ljava_util_List_ == IntPtr.Zero)
				id_didRangeIBeacons_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "didRangeIBeacons", "(Ljava/util/List;)V");
			IntPtr native_iBeacons = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.ToLocalJniHandle (iBeacons);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_iBeacons);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didRangeIBeacons_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "didRangeIBeacons", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_iBeacons);
			}
		}

		static Delegate cb_didRangeNewbornBeacons_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetDidRangeNewbornBeacons_Ljava_util_List_Handler ()
		{
			if (cb_didRangeNewbornBeacons_Ljava_util_List_ == null)
				cb_didRangeNewbornBeacons_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DidRangeNewbornBeacons_Ljava_util_List_);
			return cb_didRangeNewbornBeacons_Ljava_util_List_;
		}

		static void n_DidRangeNewbornBeacons_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newBornBeacons)
		{
			global::Com.Bluecats.Sdk.BCBeaconManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newBornBeacons = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (native_newBornBeacons, JniHandleOwnership.DoNotTransfer);
			__this.DidRangeNewbornBeacons (newBornBeacons);
		}
#pragma warning restore 0169

		static IntPtr id_didRangeNewbornBeacons_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconManagerCallback']/method[@name='didRangeNewbornBeacons' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCBeacon&gt;']]"
		[Register ("didRangeNewbornBeacons", "(Ljava/util/List;)V", "GetDidRangeNewbornBeacons_Ljava_util_List_Handler")]
		public virtual unsafe void DidRangeNewbornBeacons (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> newBornBeacons)
		{
			if (id_didRangeNewbornBeacons_Ljava_util_List_ == IntPtr.Zero)
				id_didRangeNewbornBeacons_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "didRangeNewbornBeacons", "(Ljava/util/List;)V");
			IntPtr native_newBornBeacons = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.ToLocalJniHandle (newBornBeacons);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_newBornBeacons);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didRangeNewbornBeacons_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "didRangeNewbornBeacons", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_newBornBeacons);
			}
		}

	}

	[global::Android.Runtime.Register ("com/bluecats/sdk/BCBeaconManagerCallback", DoNotGenerateAcw=true)]
	internal partial class BCBeaconManagerCallbackInvoker : BCBeaconManagerCallback {

		public BCBeaconManagerCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCBeaconManagerCallbackInvoker); }
		}

	}

}
