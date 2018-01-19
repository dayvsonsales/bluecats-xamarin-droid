using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocation']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCMicroLocation", DoNotGenerateAcw=true)]
	public partial class BCMicroLocation : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocation']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCMicroLocation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCMicroLocation); }
		}

		protected BCMicroLocation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocation']/constructor[@name='BCMicroLocation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCMicroLocation ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCMicroLocation)) {
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

		static IntPtr id_ctor_Ljava_util_Set_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocation']/constructor[@name='BCMicroLocation' and count(parameter)=2 and parameter[1][@type='java.util.Set&lt;com.bluecats.sdk.BCSite&gt;'] and parameter[2][@type='java.util.List&lt;com.bluecats.sdk.BCBeacon&gt;']]"
		[Register (".ctor", "(Ljava/util/Set;Ljava/util/List;)V", "")]
		public unsafe BCMicroLocation (global::System.Collections.Generic.ICollection<global::Com.Bluecats.Sdk.IBCSite> sites, global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> beacons)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_sites = global::Android.Runtime.JavaSet<global::Com.Bluecats.Sdk.IBCSite>.ToLocalJniHandle (sites);
			IntPtr native_beacons = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.ToLocalJniHandle (beacons);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_sites);
				__args [1] = new JValue (native_beacons);
				if (((object) this).GetType () != typeof (BCMicroLocation)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/Set;Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/Set;Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_Set_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_util_Set_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Set;Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Set_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_Set_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sites);
				JNIEnv.DeleteLocalRef (native_beacons);
			}
		}

		static Delegate cb_getBeacons;
#pragma warning disable 0169
		static Delegate GetGetBeaconsHandler ()
		{
			if (cb_getBeacons == null)
				cb_getBeacons = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeacons);
			return cb_getBeacons;
		}

		static IntPtr n_GetBeacons (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMicroLocation __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.ToLocalJniHandle (__this.Beacons);
		}
#pragma warning restore 0169

		static Delegate cb_setBeacons_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetBeacons_Ljava_util_List_Handler ()
		{
			if (cb_setBeacons_Ljava_util_List_ == null)
				cb_setBeacons_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBeacons_Ljava_util_List_);
			return cb_setBeacons_Ljava_util_List_;
		}

		static void n_SetBeacons_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCMicroLocation __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Beacons = value;
		}
#pragma warning restore 0169

		static IntPtr id_getBeacons;
		static IntPtr id_setBeacons_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> Beacons {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocation']/method[@name='getBeacons' and count(parameter)=0]"
			[Register ("getBeacons", "()Ljava/util/List;", "GetGetBeaconsHandler")]
			get {
				if (id_getBeacons == IntPtr.Zero)
					id_getBeacons = JNIEnv.GetMethodID (class_ref, "getBeacons", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeacons), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeacons", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocation']/method[@name='setBeacons' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCBeacon&gt;']]"
			[Register ("setBeacons", "(Ljava/util/List;)V", "GetSetBeacons_Ljava_util_List_Handler")]
			set {
				if (id_setBeacons_Ljava_util_List_ == IntPtr.Zero)
					id_setBeacons_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setBeacons", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeacons_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBeacons", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBeaconsForSiteID;
#pragma warning disable 0169
		static Delegate GetGetBeaconsForSiteIDHandler ()
		{
			if (cb_getBeaconsForSiteID == null)
				cb_getBeaconsForSiteID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeaconsForSiteID);
			return cb_getBeaconsForSiteID;
		}

		static IntPtr n_GetBeaconsForSiteID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMicroLocation __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon>>.ToLocalJniHandle (__this.BeaconsForSiteID);
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconsForSiteID;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon>> BeaconsForSiteID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocation']/method[@name='getBeaconsForSiteID' and count(parameter)=0]"
			[Register ("getBeaconsForSiteID", "()Ljava/util/Map;", "GetGetBeaconsForSiteIDHandler")]
			get {
				if (id_getBeaconsForSiteID == IntPtr.Zero)
					id_getBeaconsForSiteID = JNIEnv.GetMethodID (class_ref, "getBeaconsForSiteID", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon>>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconsForSiteID), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon>>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeaconsForSiteID", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Bluecats.Sdk.BCMicroLocation __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Location);
		}
#pragma warning restore 0169

		static Delegate cb_setLocation_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetSetLocation_Landroid_location_Location_Handler ()
		{
			if (cb_setLocation_Landroid_location_Location_ == null)
				cb_setLocation_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocation_Landroid_location_Location_);
			return cb_setLocation_Landroid_location_Location_;
		}

		static void n_SetLocation_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCMicroLocation __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location value = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Location = value;
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		static IntPtr id_setLocation_Landroid_location_Location_;
		public virtual unsafe global::Android.Locations.Location Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocation']/method[@name='getLocation' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocation']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
			[Register ("setLocation", "(Landroid/location/Location;)V", "GetSetLocation_Landroid_location_Location_Handler")]
			set {
				if (id_setLocation_Landroid_location_Location_ == IntPtr.Zero)
					id_setLocation_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "setLocation", "(Landroid/location/Location;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocation_Landroid_location_Location_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocation", "(Landroid/location/Location;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSites;
#pragma warning disable 0169
		static Delegate GetGetSitesHandler ()
		{
			if (cb_getSites == null)
				cb_getSites = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSites);
			return cb_getSites;
		}

		static IntPtr n_GetSites (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMicroLocation __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCSite>.ToLocalJniHandle (__this.Sites);
		}
#pragma warning restore 0169

		static Delegate cb_setSites_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetSites_Ljava_util_List_Handler ()
		{
			if (cb_setSites_Ljava_util_List_ == null)
				cb_setSites_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSites_Ljava_util_List_);
			return cb_setSites_Ljava_util_List_;
		}

		static void n_SetSites_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCMicroLocation __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCSite>.FromJniHandle (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Sites = value;
		}
#pragma warning restore 0169

		static IntPtr id_getSites;
		static IntPtr id_setSites_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCSite> Sites {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocation']/method[@name='getSites' and count(parameter)=0]"
			[Register ("getSites", "()Ljava/util/List;", "GetGetSitesHandler")]
			get {
				if (id_getSites == IntPtr.Zero)
					id_getSites = JNIEnv.GetMethodID (class_ref, "getSites", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCSite>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSites), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCSite>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSites", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocation']/method[@name='setSites' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCSite&gt;']]"
			[Register ("setSites", "(Ljava/util/List;)V", "GetSetSites_Ljava_util_List_Handler")]
			set {
				if (id_setSites_Ljava_util_List_ == IntPtr.Zero)
					id_setSites_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setSites", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCSite>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSites_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSites", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTimestamp;
#pragma warning disable 0169
		static Delegate GetGetTimestampHandler ()
		{
			if (cb_getTimestamp == null)
				cb_getTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimestamp);
			return cb_getTimestamp;
		}

		static IntPtr n_GetTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMicroLocation __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Timestamp);
		}
#pragma warning restore 0169

		static Delegate cb_setTimestamp_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetTimestamp_Ljava_util_Date_Handler ()
		{
			if (cb_setTimestamp_Ljava_util_Date_ == null)
				cb_setTimestamp_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTimestamp_Ljava_util_Date_);
			return cb_setTimestamp_Ljava_util_Date_;
		}

		static void n_SetTimestamp_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCMicroLocation __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Timestamp = value;
		}
#pragma warning restore 0169

		static IntPtr id_getTimestamp;
		static IntPtr id_setTimestamp_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocation']/method[@name='getTimestamp' and count(parameter)=0]"
			[Register ("getTimestamp", "()Ljava/util/Date;", "GetGetTimestampHandler")]
			get {
				if (id_getTimestamp == IntPtr.Zero)
					id_getTimestamp = JNIEnv.GetMethodID (class_ref, "getTimestamp", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTimestamp), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimestamp", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocation']/method[@name='setTimestamp' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setTimestamp", "(Ljava/util/Date;)V", "GetSetTimestamp_Ljava_util_Date_Handler")]
			set {
				if (id_setTimestamp_Ljava_util_Date_ == IntPtr.Zero)
					id_setTimestamp_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setTimestamp", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTimestamp_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimestamp", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMicroLocation __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocation']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static Delegate cb_getBeaconsForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_;
#pragma warning disable 0169
		static Delegate GetGetBeaconsForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_Handler ()
		{
			if (cb_getBeaconsForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_ == null)
				cb_getBeaconsForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBeaconsForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_);
			return cb_getBeaconsForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_;
		}

		static IntPtr n_GetBeaconsForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_site, IntPtr native_proximity)
		{
			global::Com.Bluecats.Sdk.BCMicroLocation __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite site = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_site, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconBCProximity proximity = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCProximity> (native_proximity, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.ToLocalJniHandle (__this.GetBeaconsForSite (site, proximity));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconsForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocation']/method[@name='getBeaconsForSite' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCSite'] and parameter[2][@type='com.bluecats.sdk.BCBeacon.BCProximity']]"
		[Register ("getBeaconsForSite", "(Lcom/bluecats/sdk/BCSite;Lcom/bluecats/sdk/BCBeacon$BCProximity;)Ljava/util/List;", "GetGetBeaconsForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> GetBeaconsForSite (global::Com.Bluecats.Sdk.IBCSite site, global::Com.Bluecats.Sdk.BCBeaconBCProximity proximity)
		{
			if (id_getBeaconsForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_ == IntPtr.Zero)
				id_getBeaconsForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_ = JNIEnv.GetMethodID (class_ref, "getBeaconsForSite", "(Lcom/bluecats/sdk/BCSite;Lcom/bluecats/sdk/BCBeacon$BCProximity;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (site);
				__args [1] = new JValue (proximity);

				global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconsForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeaconsForSite", "(Lcom/bluecats/sdk/BCSite;Lcom/bluecats/sdk/BCBeacon_BCProximity;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getCategoriesForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_;
#pragma warning disable 0169
		static Delegate GetGetCategoriesForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_Handler ()
		{
			if (cb_getCategoriesForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_ == null)
				cb_getCategoriesForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCategoriesForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_);
			return cb_getCategoriesForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_;
		}

		static IntPtr n_GetCategoriesForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_site, IntPtr native_proximity)
		{
			global::Com.Bluecats.Sdk.BCMicroLocation __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite site = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_site, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconBCProximity proximity = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCProximity> (native_proximity, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCCategory>.ToLocalJniHandle (__this.GetCategoriesForSite (site, proximity));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getCategoriesForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocation']/method[@name='getCategoriesForSite' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCSite'] and parameter[2][@type='com.bluecats.sdk.BCBeacon.BCProximity']]"
		[Register ("getCategoriesForSite", "(Lcom/bluecats/sdk/BCSite;Lcom/bluecats/sdk/BCBeacon$BCProximity;)Ljava/util/List;", "GetGetCategoriesForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCCategory> GetCategoriesForSite (global::Com.Bluecats.Sdk.IBCSite site, global::Com.Bluecats.Sdk.BCBeaconBCProximity proximity)
		{
			if (id_getCategoriesForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_ == IntPtr.Zero)
				id_getCategoriesForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_ = JNIEnv.GetMethodID (class_ref, "getCategoriesForSite", "(Lcom/bluecats/sdk/BCSite;Lcom/bluecats/sdk/BCBeacon$BCProximity;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (site);
				__args [1] = new JValue (proximity);

				global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCCategory> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCCategory>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCategoriesForSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCBeacon_BCProximity_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCCategory>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCategoriesForSite", "(Lcom/bluecats/sdk/BCSite;Lcom/bluecats/sdk/BCBeacon_BCProximity;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getMapPointForSite_Lcom_bluecats_sdk_BCSite_;
#pragma warning disable 0169
		static Delegate GetGetMapPointForSite_Lcom_bluecats_sdk_BCSite_Handler ()
		{
			if (cb_getMapPointForSite_Lcom_bluecats_sdk_BCSite_ == null)
				cb_getMapPointForSite_Lcom_bluecats_sdk_BCSite_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMapPointForSite_Lcom_bluecats_sdk_BCSite_);
			return cb_getMapPointForSite_Lcom_bluecats_sdk_BCSite_;
		}

		static IntPtr n_GetMapPointForSite_Lcom_bluecats_sdk_BCSite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_site)
		{
			global::Com.Bluecats.Sdk.BCMicroLocation __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite site = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_site, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMapPointForSite (site));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMapPointForSite_Lcom_bluecats_sdk_BCSite_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocation']/method[@name='getMapPointForSite' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCSite']]"
		[Register ("getMapPointForSite", "(Lcom/bluecats/sdk/BCSite;)Lcom/bluecats/sdk/BCMapPoint;", "GetGetMapPointForSite_Lcom_bluecats_sdk_BCSite_Handler")]
		public virtual unsafe global::Com.Bluecats.Sdk.BCMapPoint GetMapPointForSite (global::Com.Bluecats.Sdk.IBCSite site)
		{
			if (id_getMapPointForSite_Lcom_bluecats_sdk_BCSite_ == IntPtr.Zero)
				id_getMapPointForSite_Lcom_bluecats_sdk_BCSite_ = JNIEnv.GetMethodID (class_ref, "getMapPointForSite", "(Lcom/bluecats/sdk/BCSite;)Lcom/bluecats/sdk/BCMapPoint;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (site);

				global::Com.Bluecats.Sdk.BCMapPoint __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMapPoint> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMapPointForSite_Lcom_bluecats_sdk_BCSite_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMapPoint> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMapPointForSite", "(Lcom/bluecats/sdk/BCSite;)Lcom/bluecats/sdk/BCMapPoint;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getSitesWithBeaconsInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_;
#pragma warning disable 0169
		static Delegate GetGetSitesWithBeaconsInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_Handler ()
		{
			if (cb_getSitesWithBeaconsInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ == null)
				cb_getSitesWithBeaconsInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSitesWithBeaconsInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_);
			return cb_getSitesWithBeaconsInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_;
		}

		static IntPtr n_GetSitesWithBeaconsInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_proximity)
		{
			global::Com.Bluecats.Sdk.BCMicroLocation __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconBCProximity proximity = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCProximity> (native_proximity, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCSite>.ToLocalJniHandle (__this.GetSitesWithBeaconsInProximity (proximity));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSitesWithBeaconsInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocation']/method[@name='getSitesWithBeaconsInProximity' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeacon.BCProximity']]"
		[Register ("getSitesWithBeaconsInProximity", "(Lcom/bluecats/sdk/BCBeacon$BCProximity;)Ljava/util/List;", "GetGetSitesWithBeaconsInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCSite> GetSitesWithBeaconsInProximity (global::Com.Bluecats.Sdk.BCBeaconBCProximity proximity)
		{
			if (id_getSitesWithBeaconsInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ == IntPtr.Zero)
				id_getSitesWithBeaconsInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ = JNIEnv.GetMethodID (class_ref, "getSitesWithBeaconsInProximity", "(Lcom/bluecats/sdk/BCBeacon$BCProximity;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (proximity);

				global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCSite> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCSite>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSitesWithBeaconsInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCSite>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSitesWithBeaconsInProximity", "(Lcom/bluecats/sdk/BCBeacon_BCProximity;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getSitesWithCategoriesInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_;
#pragma warning disable 0169
		static Delegate GetGetSitesWithCategoriesInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_Handler ()
		{
			if (cb_getSitesWithCategoriesInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ == null)
				cb_getSitesWithCategoriesInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSitesWithCategoriesInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_);
			return cb_getSitesWithCategoriesInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_;
		}

		static IntPtr n_GetSitesWithCategoriesInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_proximity)
		{
			global::Com.Bluecats.Sdk.BCMicroLocation __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconBCProximity proximity = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCProximity> (native_proximity, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCSite>.ToLocalJniHandle (__this.GetSitesWithCategoriesInProximity (proximity));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSitesWithCategoriesInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocation']/method[@name='getSitesWithCategoriesInProximity' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeacon.BCProximity']]"
		[Register ("getSitesWithCategoriesInProximity", "(Lcom/bluecats/sdk/BCBeacon$BCProximity;)Ljava/util/List;", "GetGetSitesWithCategoriesInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCSite> GetSitesWithCategoriesInProximity (global::Com.Bluecats.Sdk.BCBeaconBCProximity proximity)
		{
			if (id_getSitesWithCategoriesInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ == IntPtr.Zero)
				id_getSitesWithCategoriesInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ = JNIEnv.GetMethodID (class_ref, "getSitesWithCategoriesInProximity", "(Lcom/bluecats/sdk/BCBeacon$BCProximity;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (proximity);

				global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCSite> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCSite>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSitesWithCategoriesInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCSite>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSitesWithCategoriesInProximity", "(Lcom/bluecats/sdk/BCBeacon_BCProximity;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setBeaconsForSiteID_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetBeaconsForSiteID_Ljava_util_Map_Handler ()
		{
			if (cb_setBeaconsForSiteID_Ljava_util_Map_ == null)
				cb_setBeaconsForSiteID_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBeaconsForSiteID_Ljava_util_Map_);
			return cb_setBeaconsForSiteID_Ljava_util_Map_;
		}

		static void n_SetBeaconsForSiteID_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCMicroLocation __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCBeaconInternal>>.FromJniHandle (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SetBeaconsForSiteID (value);
		}
#pragma warning restore 0169

		static IntPtr id_setBeaconsForSiteID_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocation']/method[@name='setBeaconsForSiteID' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.util.List&lt;com.bluecats.sdk.BCBeaconInternal&gt;&gt;']]"
		[Register ("setBeaconsForSiteID", "(Ljava/util/Map;)V", "GetSetBeaconsForSiteID_Ljava_util_Map_Handler")]
		public virtual unsafe void SetBeaconsForSiteID (global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCBeaconInternal>> value)
		{
			if (id_setBeaconsForSiteID_Ljava_util_Map_ == IntPtr.Zero)
				id_setBeaconsForSiteID_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setBeaconsForSiteID", "(Ljava/util/Map;)V");
			IntPtr native_value = global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCBeaconInternal>>.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeaconsForSiteID_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBeaconsForSiteID", "(Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.Bluecats.Sdk.BCMicroLocation __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMicroLocation']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dest);
				__args [1] = new JValue ((int) flags);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
