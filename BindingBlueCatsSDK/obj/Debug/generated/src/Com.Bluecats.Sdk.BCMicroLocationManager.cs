using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCMicroLocationManager", DoNotGenerateAcw=true)]
	public partial class BCMicroLocationManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/field[@name='TAG']"
		[Register ("TAG")]
		protected const string Tag = (string) "BCMicroLocationManager";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCMicroLocationManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCMicroLocationManager); }
		}

		protected BCMicroLocationManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Bluecats.Sdk.BCMicroLocationManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/bluecats/sdk/BCMicroLocationManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/bluecats/sdk/BCMicroLocationManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocationManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isLocationServicesEnabled;
#pragma warning disable 0169
		static Delegate GetIsLocationServicesEnabledHandler ()
		{
			if (cb_isLocationServicesEnabled == null)
				cb_isLocationServicesEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLocationServicesEnabled);
			return cb_isLocationServicesEnabled;
		}

		static bool n_IsLocationServicesEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMicroLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLocationServicesEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isLocationServicesEnabled;
		public virtual unsafe bool IsLocationServicesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/method[@name='isLocationServicesEnabled' and count(parameter)=0]"
			[Register ("isLocationServicesEnabled", "()Z", "GetIsLocationServicesEnabledHandler")]
			get {
				if (id_isLocationServicesEnabled == IntPtr.Zero)
					id_isLocationServicesEnabled = JNIEnv.GetMethodID (class_ref, "isLocationServicesEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLocationServicesEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLocationServicesEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isMicroLocationUpdatingAvailable;
#pragma warning disable 0169
		static Delegate GetIsMicroLocationUpdatingAvailableHandler ()
		{
			if (cb_isMicroLocationUpdatingAvailable == null)
				cb_isMicroLocationUpdatingAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMicroLocationUpdatingAvailable);
			return cb_isMicroLocationUpdatingAvailable;
		}

		static bool n_IsMicroLocationUpdatingAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMicroLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMicroLocationUpdatingAvailable;
		}
#pragma warning restore 0169

		static IntPtr id_isMicroLocationUpdatingAvailable;
		public virtual unsafe bool IsMicroLocationUpdatingAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/method[@name='isMicroLocationUpdatingAvailable' and count(parameter)=0]"
			[Register ("isMicroLocationUpdatingAvailable", "()Z", "GetIsMicroLocationUpdatingAvailableHandler")]
			get {
				if (id_isMicroLocationUpdatingAvailable == IntPtr.Zero)
					id_isMicroLocationUpdatingAvailable = JNIEnv.GetMethodID (class_ref, "isMicroLocationUpdatingAvailable", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMicroLocationUpdatingAvailable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMicroLocationUpdatingAvailable", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isUpdatingMicroLocation;
#pragma warning disable 0169
		static Delegate GetIsUpdatingMicroLocationHandler ()
		{
			if (cb_isUpdatingMicroLocation == null)
				cb_isUpdatingMicroLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUpdatingMicroLocation);
			return cb_isUpdatingMicroLocation;
		}

		static bool n_IsUpdatingMicroLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMicroLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUpdatingMicroLocation;
		}
#pragma warning restore 0169

		static Delegate cb_setIsUpdatingMicroLocation_Z;
#pragma warning disable 0169
		static Delegate GetSetIsUpdatingMicroLocation_ZHandler ()
		{
			if (cb_setIsUpdatingMicroLocation_Z == null)
				cb_setIsUpdatingMicroLocation_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsUpdatingMicroLocation_Z);
			return cb_setIsUpdatingMicroLocation_Z;
		}

		static void n_SetIsUpdatingMicroLocation_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::Com.Bluecats.Sdk.BCMicroLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsUpdatingMicroLocation = value;
		}
#pragma warning restore 0169

		static IntPtr id_isUpdatingMicroLocation;
		static IntPtr id_setIsUpdatingMicroLocation_Z;
		public virtual unsafe bool IsUpdatingMicroLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/method[@name='isUpdatingMicroLocation' and count(parameter)=0]"
			[Register ("isUpdatingMicroLocation", "()Z", "GetIsUpdatingMicroLocationHandler")]
			get {
				if (id_isUpdatingMicroLocation == IntPtr.Zero)
					id_isUpdatingMicroLocation = JNIEnv.GetMethodID (class_ref, "isUpdatingMicroLocation", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUpdatingMicroLocation);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUpdatingMicroLocation", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/method[@name='setIsUpdatingMicroLocation' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsUpdatingMicroLocation", "(Z)V", "GetSetIsUpdatingMicroLocation_ZHandler")]
			set {
				if (id_setIsUpdatingMicroLocation_Z == IntPtr.Zero)
					id_setIsUpdatingMicroLocation_Z = JNIEnv.GetMethodID (class_ref, "setIsUpdatingMicroLocation", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIsUpdatingMicroLocation_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsUpdatingMicroLocation", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isUpdatingMicroLocationOnlyOnProximityChanges;
#pragma warning disable 0169
		static Delegate GetIsUpdatingMicroLocationOnlyOnProximityChangesHandler ()
		{
			if (cb_isUpdatingMicroLocationOnlyOnProximityChanges == null)
				cb_isUpdatingMicroLocationOnlyOnProximityChanges = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUpdatingMicroLocationOnlyOnProximityChanges);
			return cb_isUpdatingMicroLocationOnlyOnProximityChanges;
		}

		static bool n_IsUpdatingMicroLocationOnlyOnProximityChanges (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMicroLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUpdatingMicroLocationOnlyOnProximityChanges;
		}
#pragma warning restore 0169

		static Delegate cb_setIsUpdatingMicroLocationOnlyOnProximityChanges_Z;
#pragma warning disable 0169
		static Delegate GetSetIsUpdatingMicroLocationOnlyOnProximityChanges_ZHandler ()
		{
			if (cb_setIsUpdatingMicroLocationOnlyOnProximityChanges_Z == null)
				cb_setIsUpdatingMicroLocationOnlyOnProximityChanges_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsUpdatingMicroLocationOnlyOnProximityChanges_Z);
			return cb_setIsUpdatingMicroLocationOnlyOnProximityChanges_Z;
		}

		static void n_SetIsUpdatingMicroLocationOnlyOnProximityChanges_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::Com.Bluecats.Sdk.BCMicroLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsUpdatingMicroLocationOnlyOnProximityChanges = value;
		}
#pragma warning restore 0169

		static IntPtr id_isUpdatingMicroLocationOnlyOnProximityChanges;
		static IntPtr id_setIsUpdatingMicroLocationOnlyOnProximityChanges_Z;
		public virtual unsafe bool IsUpdatingMicroLocationOnlyOnProximityChanges {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/method[@name='isUpdatingMicroLocationOnlyOnProximityChanges' and count(parameter)=0]"
			[Register ("isUpdatingMicroLocationOnlyOnProximityChanges", "()Z", "GetIsUpdatingMicroLocationOnlyOnProximityChangesHandler")]
			get {
				if (id_isUpdatingMicroLocationOnlyOnProximityChanges == IntPtr.Zero)
					id_isUpdatingMicroLocationOnlyOnProximityChanges = JNIEnv.GetMethodID (class_ref, "isUpdatingMicroLocationOnlyOnProximityChanges", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUpdatingMicroLocationOnlyOnProximityChanges);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUpdatingMicroLocationOnlyOnProximityChanges", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/method[@name='setIsUpdatingMicroLocationOnlyOnProximityChanges' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsUpdatingMicroLocationOnlyOnProximityChanges", "(Z)V", "GetSetIsUpdatingMicroLocationOnlyOnProximityChanges_ZHandler")]
			set {
				if (id_setIsUpdatingMicroLocationOnlyOnProximityChanges_Z == IntPtr.Zero)
					id_setIsUpdatingMicroLocationOnlyOnProximityChanges_Z = JNIEnv.GetMethodID (class_ref, "setIsUpdatingMicroLocationOnlyOnProximityChanges", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIsUpdatingMicroLocationOnlyOnProximityChanges_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsUpdatingMicroLocationOnlyOnProximityChanges", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLocation;
#pragma warning disable 0169
		static Delegate GetGetLocationHandler ()
		{
			if (cb_getLocation == null)
				cb_getLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocation);
			return cb_getLocation;
		}

		static IntPtr n_GetLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMicroLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Location);
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		public virtual unsafe global::Android.Locations.Location Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Landroid/location/Location;", "GetGetLocationHandler")]
			get {
				if (id_getLocation == IntPtr.Zero)
					id_getLocation = JNIEnv.GetMethodID (class_ref, "getLocation", "()Landroid/location/Location;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocation", "()Landroid/location/Location;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMicroLocation;
#pragma warning disable 0169
		static Delegate GetGetMicroLocationHandler ()
		{
			if (cb_getMicroLocation == null)
				cb_getMicroLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMicroLocation);
			return cb_getMicroLocation;
		}

		static IntPtr n_GetMicroLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMicroLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MicroLocation);
		}
#pragma warning restore 0169

		static IntPtr id_getMicroLocation;
		public virtual unsafe global::Com.Bluecats.Sdk.BCMicroLocation MicroLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/method[@name='getMicroLocation' and count(parameter)=0]"
			[Register ("getMicroLocation", "()Lcom/bluecats/sdk/BCMicroLocation;", "GetGetMicroLocationHandler")]
			get {
				if (id_getMicroLocation == IntPtr.Zero)
					id_getMicroLocation = JNIEnv.GetMethodID (class_ref, "getMicroLocation", "()Lcom/bluecats/sdk/BCMicroLocation;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMicroLocation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocation> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMicroLocation", "()Lcom/bluecats/sdk/BCMicroLocation;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMonitoredSites;
#pragma warning disable 0169
		static Delegate GetGetMonitoredSitesHandler ()
		{
			if (cb_getMonitoredSites == null)
				cb_getMonitoredSites = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMonitoredSites);
			return cb_getMonitoredSites;
		}

		static IntPtr n_GetMonitoredSites (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMicroLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Bluecats.Sdk.IBCSite>.ToLocalJniHandle (__this.MonitoredSites);
		}
#pragma warning restore 0169

		static IntPtr id_getMonitoredSites;
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Bluecats.Sdk.IBCSite> MonitoredSites {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/method[@name='getMonitoredSites' and count(parameter)=0]"
			[Register ("getMonitoredSites", "()Ljava/util/Set;", "GetGetMonitoredSitesHandler")]
			get {
				if (id_getMonitoredSites == IntPtr.Zero)
					id_getMonitoredSites = JNIEnv.GetMethodID (class_ref, "getMonitoredSites", "()Ljava/util/Set;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet<global::Com.Bluecats.Sdk.IBCSite>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMonitoredSites), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet<global::Com.Bluecats.Sdk.IBCSite>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMonitoredSites", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNearbySites;
#pragma warning disable 0169
		static Delegate GetGetNearbySitesHandler ()
		{
			if (cb_getNearbySites == null)
				cb_getNearbySites = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNearbySites);
			return cb_getNearbySites;
		}

		static IntPtr n_GetNearbySites (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMicroLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Bluecats.Sdk.IBCSite>.ToLocalJniHandle (__this.NearbySites);
		}
#pragma warning restore 0169

		static IntPtr id_getNearbySites;
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Bluecats.Sdk.IBCSite> NearbySites {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/method[@name='getNearbySites' and count(parameter)=0]"
			[Register ("getNearbySites", "()Ljava/util/Set;", "GetGetNearbySitesHandler")]
			get {
				if (id_getNearbySites == IntPtr.Zero)
					id_getNearbySites = JNIEnv.GetMethodID (class_ref, "getNearbySites", "()Ljava/util/Set;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet<global::Com.Bluecats.Sdk.IBCSite>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNearbySites), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet<global::Com.Bluecats.Sdk.IBCSite>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNearbySites", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRangedSites;
#pragma warning disable 0169
		static Delegate GetGetRangedSitesHandler ()
		{
			if (cb_getRangedSites == null)
				cb_getRangedSites = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRangedSites);
			return cb_getRangedSites;
		}

		static IntPtr n_GetRangedSites (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMicroLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Bluecats.Sdk.IBCSite>.ToLocalJniHandle (__this.RangedSites);
		}
#pragma warning restore 0169

		static IntPtr id_getRangedSites;
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Bluecats.Sdk.IBCSite> RangedSites {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/method[@name='getRangedSites' and count(parameter)=0]"
			[Register ("getRangedSites", "()Ljava/util/Set;", "GetGetRangedSitesHandler")]
			get {
				if (id_getRangedSites == IntPtr.Zero)
					id_getRangedSites = JNIEnv.GetMethodID (class_ref, "getRangedSites", "()Ljava/util/Set;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet<global::Com.Bluecats.Sdk.IBCSite>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRangedSites), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet<global::Com.Bluecats.Sdk.IBCSite>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRangedSites", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isMonitoringSite_Lcom_bluecats_sdk_BCSite_;
#pragma warning disable 0169
		static Delegate GetIsMonitoringSite_Lcom_bluecats_sdk_BCSite_Handler ()
		{
			if (cb_isMonitoringSite_Lcom_bluecats_sdk_BCSite_ == null)
				cb_isMonitoringSite_Lcom_bluecats_sdk_BCSite_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsMonitoringSite_Lcom_bluecats_sdk_BCSite_);
			return cb_isMonitoringSite_Lcom_bluecats_sdk_BCSite_;
		}

		static bool n_IsMonitoringSite_Lcom_bluecats_sdk_BCSite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_site)
		{
			global::Com.Bluecats.Sdk.BCMicroLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite site = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_site, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsMonitoringSite (site);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isMonitoringSite_Lcom_bluecats_sdk_BCSite_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/method[@name='isMonitoringSite' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCSite']]"
		[Register ("isMonitoringSite", "(Lcom/bluecats/sdk/BCSite;)Z", "GetIsMonitoringSite_Lcom_bluecats_sdk_BCSite_Handler")]
		public virtual unsafe bool IsMonitoringSite (global::Com.Bluecats.Sdk.IBCSite site)
		{
			if (id_isMonitoringSite_Lcom_bluecats_sdk_BCSite_ == IntPtr.Zero)
				id_isMonitoringSite_Lcom_bluecats_sdk_BCSite_ = JNIEnv.GetMethodID (class_ref, "isMonitoringSite", "(Lcom/bluecats/sdk/BCSite;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (site);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMonitoringSite_Lcom_bluecats_sdk_BCSite_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMonitoringSite", "(Lcom/bluecats/sdk/BCSite;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newInstance;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/bluecats/sdk/BCMicroLocationManager;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCMicroLocationManager NewInstance ()
		{
			if (id_newInstance == IntPtr.Zero)
				id_newInstance = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "()Lcom/bluecats/sdk/BCMicroLocationManager;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocationManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDistanceFilter_D;
#pragma warning disable 0169
		static Delegate GetSetDistanceFilter_DHandler ()
		{
			if (cb_setDistanceFilter_D == null)
				cb_setDistanceFilter_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetDistanceFilter_D);
			return cb_setDistanceFilter_D;
		}

		static void n_SetDistanceFilter_D (IntPtr jnienv, IntPtr native__this, double distanceFilter)
		{
			global::Com.Bluecats.Sdk.BCMicroLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDistanceFilter (distanceFilter);
		}
#pragma warning restore 0169

		static IntPtr id_setDistanceFilter_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/method[@name='setDistanceFilter' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setDistanceFilter", "(D)V", "GetSetDistanceFilter_DHandler")]
		public virtual unsafe void SetDistanceFilter (double distanceFilter)
		{
			if (id_setDistanceFilter_D == IntPtr.Zero)
				id_setDistanceFilter_D = JNIEnv.GetMethodID (class_ref, "setDistanceFilter", "(D)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (distanceFilter);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDistanceFilter_D, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDistanceFilter", "(D)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startMonitoringSite_Lcom_bluecats_sdk_BCSite_;
#pragma warning disable 0169
		static Delegate GetStartMonitoringSite_Lcom_bluecats_sdk_BCSite_Handler ()
		{
			if (cb_startMonitoringSite_Lcom_bluecats_sdk_BCSite_ == null)
				cb_startMonitoringSite_Lcom_bluecats_sdk_BCSite_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartMonitoringSite_Lcom_bluecats_sdk_BCSite_);
			return cb_startMonitoringSite_Lcom_bluecats_sdk_BCSite_;
		}

		static void n_StartMonitoringSite_Lcom_bluecats_sdk_BCSite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_site)
		{
			global::Com.Bluecats.Sdk.BCMicroLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite site = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_site, JniHandleOwnership.DoNotTransfer);
			__this.StartMonitoringSite (site);
		}
#pragma warning restore 0169

		static IntPtr id_startMonitoringSite_Lcom_bluecats_sdk_BCSite_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/method[@name='startMonitoringSite' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCSite']]"
		[Register ("startMonitoringSite", "(Lcom/bluecats/sdk/BCSite;)V", "GetStartMonitoringSite_Lcom_bluecats_sdk_BCSite_Handler")]
		public virtual unsafe void StartMonitoringSite (global::Com.Bluecats.Sdk.IBCSite site)
		{
			if (id_startMonitoringSite_Lcom_bluecats_sdk_BCSite_ == IntPtr.Zero)
				id_startMonitoringSite_Lcom_bluecats_sdk_BCSite_ = JNIEnv.GetMethodID (class_ref, "startMonitoringSite", "(Lcom/bluecats/sdk/BCSite;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (site);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startMonitoringSite_Lcom_bluecats_sdk_BCSite_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startMonitoringSite", "(Lcom/bluecats/sdk/BCSite;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_;
#pragma warning disable 0169
		static Delegate GetStartRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_Handler ()
		{
			if (cb_startRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_ == null)
				cb_startRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_StartRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_);
			return cb_startRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_;
		}

		static void n_StartRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_site, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCMicroLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite site = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_site, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback @callback = (global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.StartRangingBeaconsInSite (site, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_startRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/method[@name='startRangingBeaconsInSite' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCSite'] and parameter[2][@type='com.bluecats.sdk.BCMicroLocationManagerCallback']]"
		[Register ("startRangingBeaconsInSite", "(Lcom/bluecats/sdk/BCSite;Lcom/bluecats/sdk/BCMicroLocationManagerCallback;)V", "GetStartRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_Handler")]
		public virtual unsafe void StartRangingBeaconsInSite (global::Com.Bluecats.Sdk.IBCSite site, global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback @callback)
		{
			if (id_startRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_ == IntPtr.Zero)
				id_startRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_ = JNIEnv.GetMethodID (class_ref, "startRangingBeaconsInSite", "(Lcom/bluecats/sdk/BCSite;Lcom/bluecats/sdk/BCMicroLocationManagerCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (site);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startRangingBeaconsInSite", "(Lcom/bluecats/sdk/BCSite;Lcom/bluecats/sdk/BCMicroLocationManagerCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_startUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_;
#pragma warning disable 0169
		static Delegate GetStartUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_Handler ()
		{
			if (cb_startUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_ == null)
				cb_startUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_);
			return cb_startUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_;
		}

		static void n_StartUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCMicroLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback @callback = (global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.StartUpdatingMicroLocation (@callback);
		}
#pragma warning restore 0169

		static IntPtr id_startUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/method[@name='startUpdatingMicroLocation' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCMicroLocationManagerCallback']]"
		[Register ("startUpdatingMicroLocation", "(Lcom/bluecats/sdk/BCMicroLocationManagerCallback;)V", "GetStartUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_Handler")]
		public virtual unsafe void StartUpdatingMicroLocation (global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback @callback)
		{
			if (id_startUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_ == IntPtr.Zero)
				id_startUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_ = JNIEnv.GetMethodID (class_ref, "startUpdatingMicroLocation", "(Lcom/bluecats/sdk/BCMicroLocationManagerCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startUpdatingMicroLocation", "(Lcom/bluecats/sdk/BCMicroLocationManagerCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_stopMonitoringAllSites;
#pragma warning disable 0169
		static Delegate GetStopMonitoringAllSitesHandler ()
		{
			if (cb_stopMonitoringAllSites == null)
				cb_stopMonitoringAllSites = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopMonitoringAllSites);
			return cb_stopMonitoringAllSites;
		}

		static void n_StopMonitoringAllSites (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMicroLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopMonitoringAllSites ();
		}
#pragma warning restore 0169

		static IntPtr id_stopMonitoringAllSites;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/method[@name='stopMonitoringAllSites' and count(parameter)=0]"
		[Register ("stopMonitoringAllSites", "()V", "GetStopMonitoringAllSitesHandler")]
		public virtual unsafe void StopMonitoringAllSites ()
		{
			if (id_stopMonitoringAllSites == IntPtr.Zero)
				id_stopMonitoringAllSites = JNIEnv.GetMethodID (class_ref, "stopMonitoringAllSites", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopMonitoringAllSites);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopMonitoringAllSites", "()V"));
			} finally {
			}
		}

		static Delegate cb_stopMonitoringSite_Lcom_bluecats_sdk_BCSite_;
#pragma warning disable 0169
		static Delegate GetStopMonitoringSite_Lcom_bluecats_sdk_BCSite_Handler ()
		{
			if (cb_stopMonitoringSite_Lcom_bluecats_sdk_BCSite_ == null)
				cb_stopMonitoringSite_Lcom_bluecats_sdk_BCSite_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StopMonitoringSite_Lcom_bluecats_sdk_BCSite_);
			return cb_stopMonitoringSite_Lcom_bluecats_sdk_BCSite_;
		}

		static void n_StopMonitoringSite_Lcom_bluecats_sdk_BCSite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_site)
		{
			global::Com.Bluecats.Sdk.BCMicroLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite site = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_site, JniHandleOwnership.DoNotTransfer);
			__this.StopMonitoringSite (site);
		}
#pragma warning restore 0169

		static IntPtr id_stopMonitoringSite_Lcom_bluecats_sdk_BCSite_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/method[@name='stopMonitoringSite' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCSite']]"
		[Register ("stopMonitoringSite", "(Lcom/bluecats/sdk/BCSite;)V", "GetStopMonitoringSite_Lcom_bluecats_sdk_BCSite_Handler")]
		public virtual unsafe void StopMonitoringSite (global::Com.Bluecats.Sdk.IBCSite site)
		{
			if (id_stopMonitoringSite_Lcom_bluecats_sdk_BCSite_ == IntPtr.Zero)
				id_stopMonitoringSite_Lcom_bluecats_sdk_BCSite_ = JNIEnv.GetMethodID (class_ref, "stopMonitoringSite", "(Lcom/bluecats/sdk/BCSite;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (site);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopMonitoringSite_Lcom_bluecats_sdk_BCSite_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopMonitoringSite", "(Lcom/bluecats/sdk/BCSite;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_stopRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_;
#pragma warning disable 0169
		static Delegate GetStopRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_Handler ()
		{
			if (cb_stopRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_ == null)
				cb_stopRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_StopRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_);
			return cb_stopRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_;
		}

		static void n_StopRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_site, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCMicroLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite site = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_site, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback @callback = (global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.StopRangingBeaconsInSite (site, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_stopRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/method[@name='stopRangingBeaconsInSite' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCSite'] and parameter[2][@type='com.bluecats.sdk.BCMicroLocationManagerCallback']]"
		[Register ("stopRangingBeaconsInSite", "(Lcom/bluecats/sdk/BCSite;Lcom/bluecats/sdk/BCMicroLocationManagerCallback;)V", "GetStopRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_Handler")]
		public virtual unsafe void StopRangingBeaconsInSite (global::Com.Bluecats.Sdk.IBCSite site, global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback @callback)
		{
			if (id_stopRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_ == IntPtr.Zero)
				id_stopRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_ = JNIEnv.GetMethodID (class_ref, "stopRangingBeaconsInSite", "(Lcom/bluecats/sdk/BCSite;Lcom/bluecats/sdk/BCMicroLocationManagerCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (site);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopRangingBeaconsInSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopRangingBeaconsInSite", "(Lcom/bluecats/sdk/BCSite;Lcom/bluecats/sdk/BCMicroLocationManagerCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_stopUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_;
#pragma warning disable 0169
		static Delegate GetStopUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_Handler ()
		{
			if (cb_stopUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_ == null)
				cb_stopUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StopUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_);
			return cb_stopUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_;
		}

		static void n_StopUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCMicroLocationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback @callback = (global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.StopUpdatingMicroLocation (@callback);
		}
#pragma warning restore 0169

		static IntPtr id_stopUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/method[@name='stopUpdatingMicroLocation' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCMicroLocationManagerCallback']]"
		[Register ("stopUpdatingMicroLocation", "(Lcom/bluecats/sdk/BCMicroLocationManagerCallback;)V", "GetStopUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_Handler")]
		public virtual unsafe void StopUpdatingMicroLocation (global::Com.Bluecats.Sdk.IBCMicroLocationManagerCallback @callback)
		{
			if (id_stopUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_ == IntPtr.Zero)
				id_stopUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_ = JNIEnv.GetMethodID (class_ref, "stopUpdatingMicroLocation", "(Lcom/bluecats/sdk/BCMicroLocationManagerCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopUpdatingMicroLocation_Lcom_bluecats_sdk_BCMicroLocationManagerCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopUpdatingMicroLocation", "(Lcom/bluecats/sdk/BCMicroLocationManagerCallback;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_stringForSiteState_Lcom_bluecats_sdk_BCSite_BCSiteState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocationManager']/method[@name='stringForSiteState' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCSite.BCSiteState']]"
		[Register ("stringForSiteState", "(Lcom/bluecats/sdk/BCSite$BCSiteState;)Ljava/lang/String;", "")]
		public static unsafe string StringForSiteState (global::Com.Bluecats.Sdk.BCSiteBCSiteState state)
		{
			if (id_stringForSiteState_Lcom_bluecats_sdk_BCSite_BCSiteState_ == IntPtr.Zero)
				id_stringForSiteState_Lcom_bluecats_sdk_BCSite_BCSiteState_ = JNIEnv.GetStaticMethodID (class_ref, "stringForSiteState", "(Lcom/bluecats/sdk/BCSite$BCSiteState;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (state);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_stringForSiteState_Lcom_bluecats_sdk_BCSite_BCSiteState_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
