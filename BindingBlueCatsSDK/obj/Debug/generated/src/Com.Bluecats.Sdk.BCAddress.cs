using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCAddress", DoNotGenerateAcw=true)]
	public partial class BCAddress : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/bluecats/sdk/BCAddress", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCAddress); }
		}

		protected BCAddress (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/constructor[@name='BCAddress' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCAddress ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCAddress)) {
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

		static Delegate cb_getAddressID;
#pragma warning disable 0169
		static Delegate GetGetAddressIDHandler ()
		{
			if (cb_getAddressID == null)
				cb_getAddressID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddressID);
			return cb_getAddressID;
		}

		static IntPtr n_GetAddressID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAddress __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AddressID);
		}
#pragma warning restore 0169

		static Delegate cb_setAddressID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAddressID_Ljava_lang_String_Handler ()
		{
			if (cb_setAddressID_Ljava_lang_String_ == null)
				cb_setAddressID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAddressID_Ljava_lang_String_);
			return cb_setAddressID_Ljava_lang_String_;
		}

		static void n_SetAddressID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCAddress __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AddressID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getAddressID;
		static IntPtr id_setAddressID_Ljava_lang_String_;
		public virtual unsafe string AddressID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/method[@name='getAddressID' and count(parameter)=0]"
			[Register ("getAddressID", "()Ljava/lang/String;", "GetGetAddressIDHandler")]
			get {
				if (id_getAddressID == IntPtr.Zero)
					id_getAddressID = JNIEnv.GetMethodID (class_ref, "getAddressID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAddressID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAddressID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/method[@name='setAddressID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAddressID", "(Ljava/lang/String;)V", "GetSetAddressID_Ljava_lang_String_Handler")]
			set {
				if (id_setAddressID_Ljava_lang_String_ == IntPtr.Zero)
					id_setAddressID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAddressID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAddressID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAddressID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCityName;
#pragma warning disable 0169
		static Delegate GetGetCityNameHandler ()
		{
			if (cb_getCityName == null)
				cb_getCityName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCityName);
			return cb_getCityName;
		}

		static IntPtr n_GetCityName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAddress __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CityName);
		}
#pragma warning restore 0169

		static Delegate cb_setCityName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCityName_Ljava_lang_String_Handler ()
		{
			if (cb_setCityName_Ljava_lang_String_ == null)
				cb_setCityName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCityName_Ljava_lang_String_);
			return cb_setCityName_Ljava_lang_String_;
		}

		static void n_SetCityName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCAddress __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.CityName = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCityName;
		static IntPtr id_setCityName_Ljava_lang_String_;
		public virtual unsafe string CityName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/method[@name='getCityName' and count(parameter)=0]"
			[Register ("getCityName", "()Ljava/lang/String;", "GetGetCityNameHandler")]
			get {
				if (id_getCityName == IntPtr.Zero)
					id_getCityName = JNIEnv.GetMethodID (class_ref, "getCityName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCityName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCityName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/method[@name='setCityName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCityName", "(Ljava/lang/String;)V", "GetSetCityName_Ljava_lang_String_Handler")]
			set {
				if (id_setCityName_Ljava_lang_String_ == IntPtr.Zero)
					id_setCityName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCityName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCityName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCityName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCountryName;
#pragma warning disable 0169
		static Delegate GetGetCountryNameHandler ()
		{
			if (cb_getCountryName == null)
				cb_getCountryName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCountryName);
			return cb_getCountryName;
		}

		static IntPtr n_GetCountryName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAddress __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CountryName);
		}
#pragma warning restore 0169

		static Delegate cb_setCountryName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCountryName_Ljava_lang_String_Handler ()
		{
			if (cb_setCountryName_Ljava_lang_String_ == null)
				cb_setCountryName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCountryName_Ljava_lang_String_);
			return cb_setCountryName_Ljava_lang_String_;
		}

		static void n_SetCountryName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCAddress __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.CountryName = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCountryName;
		static IntPtr id_setCountryName_Ljava_lang_String_;
		public virtual unsafe string CountryName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/method[@name='getCountryName' and count(parameter)=0]"
			[Register ("getCountryName", "()Ljava/lang/String;", "GetGetCountryNameHandler")]
			get {
				if (id_getCountryName == IntPtr.Zero)
					id_getCountryName = JNIEnv.GetMethodID (class_ref, "getCountryName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCountryName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCountryName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/method[@name='setCountryName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCountryName", "(Ljava/lang/String;)V", "GetSetCountryName_Ljava_lang_String_Handler")]
			set {
				if (id_setCountryName_Ljava_lang_String_ == IntPtr.Zero)
					id_setCountryName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCountryName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCountryName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCountryName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLatitude;
#pragma warning disable 0169
		static Delegate GetGetLatitudeHandler ()
		{
			if (cb_getLatitude == null)
				cb_getLatitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLatitude);
			return cb_getLatitude;
		}

		static double n_GetLatitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAddress __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Latitude;
		}
#pragma warning restore 0169

		static Delegate cb_setLatitude_D;
#pragma warning disable 0169
		static Delegate GetSetLatitude_DHandler ()
		{
			if (cb_setLatitude_D == null)
				cb_setLatitude_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetLatitude_D);
			return cb_setLatitude_D;
		}

		static void n_SetLatitude_D (IntPtr jnienv, IntPtr native__this, double value)
		{
			global::Com.Bluecats.Sdk.BCAddress __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Latitude = value;
		}
#pragma warning restore 0169

		static IntPtr id_getLatitude;
		static IntPtr id_setLatitude_D;
		public virtual unsafe double Latitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/method[@name='getLatitude' and count(parameter)=0]"
			[Register ("getLatitude", "()D", "GetGetLatitudeHandler")]
			get {
				if (id_getLatitude == IntPtr.Zero)
					id_getLatitude = JNIEnv.GetMethodID (class_ref, "getLatitude", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getLatitude);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatitude", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/method[@name='setLatitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLatitude", "(D)V", "GetSetLatitude_DHandler")]
			set {
				if (id_setLatitude_D == IntPtr.Zero)
					id_setLatitude_D = JNIEnv.GetMethodID (class_ref, "setLatitude", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLatitude_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLatitude", "(D)V"), __args);
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
			global::Com.Bluecats.Sdk.BCAddress __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Location);
		}
#pragma warning restore 0169

		static IntPtr id_getLocation;
		public virtual unsafe global::Android.Locations.Location Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/method[@name='getLocation' and count(parameter)=0]"
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

		static Delegate cb_getLongitude;
#pragma warning disable 0169
		static Delegate GetGetLongitudeHandler ()
		{
			if (cb_getLongitude == null)
				cb_getLongitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLongitude);
			return cb_getLongitude;
		}

		static double n_GetLongitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAddress __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Longitude;
		}
#pragma warning restore 0169

		static Delegate cb_setLongitude_D;
#pragma warning disable 0169
		static Delegate GetSetLongitude_DHandler ()
		{
			if (cb_setLongitude_D == null)
				cb_setLongitude_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetLongitude_D);
			return cb_setLongitude_D;
		}

		static void n_SetLongitude_D (IntPtr jnienv, IntPtr native__this, double value)
		{
			global::Com.Bluecats.Sdk.BCAddress __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Longitude = value;
		}
#pragma warning restore 0169

		static IntPtr id_getLongitude;
		static IntPtr id_setLongitude_D;
		public virtual unsafe double Longitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/method[@name='getLongitude' and count(parameter)=0]"
			[Register ("getLongitude", "()D", "GetGetLongitudeHandler")]
			get {
				if (id_getLongitude == IntPtr.Zero)
					id_getLongitude = JNIEnv.GetMethodID (class_ref, "getLongitude", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getLongitude);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLongitude", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/method[@name='setLongitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLongitude", "(D)V", "GetSetLongitude_DHandler")]
			set {
				if (id_setLongitude_D == IntPtr.Zero)
					id_setLongitude_D = JNIEnv.GetMethodID (class_ref, "setLongitude", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLongitude_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLongitude", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPostalCode;
#pragma warning disable 0169
		static Delegate GetGetPostalCodeHandler ()
		{
			if (cb_getPostalCode == null)
				cb_getPostalCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPostalCode);
			return cb_getPostalCode;
		}

		static IntPtr n_GetPostalCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAddress __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PostalCode);
		}
#pragma warning restore 0169

		static Delegate cb_setPostalCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPostalCode_Ljava_lang_String_Handler ()
		{
			if (cb_setPostalCode_Ljava_lang_String_ == null)
				cb_setPostalCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPostalCode_Ljava_lang_String_);
			return cb_setPostalCode_Ljava_lang_String_;
		}

		static void n_SetPostalCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCAddress __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.PostalCode = value;
		}
#pragma warning restore 0169

		static IntPtr id_getPostalCode;
		static IntPtr id_setPostalCode_Ljava_lang_String_;
		public virtual unsafe string PostalCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/method[@name='getPostalCode' and count(parameter)=0]"
			[Register ("getPostalCode", "()Ljava/lang/String;", "GetGetPostalCodeHandler")]
			get {
				if (id_getPostalCode == IntPtr.Zero)
					id_getPostalCode = JNIEnv.GetMethodID (class_ref, "getPostalCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPostalCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPostalCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/method[@name='setPostalCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPostalCode", "(Ljava/lang/String;)V", "GetSetPostalCode_Ljava_lang_String_Handler")]
			set {
				if (id_setPostalCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setPostalCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPostalCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPostalCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPostalCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getStateAbbrev;
#pragma warning disable 0169
		static Delegate GetGetStateAbbrevHandler ()
		{
			if (cb_getStateAbbrev == null)
				cb_getStateAbbrev = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStateAbbrev);
			return cb_getStateAbbrev;
		}

		static IntPtr n_GetStateAbbrev (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAddress __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StateAbbrev);
		}
#pragma warning restore 0169

		static Delegate cb_setStateAbbrev_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStateAbbrev_Ljava_lang_String_Handler ()
		{
			if (cb_setStateAbbrev_Ljava_lang_String_ == null)
				cb_setStateAbbrev_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStateAbbrev_Ljava_lang_String_);
			return cb_setStateAbbrev_Ljava_lang_String_;
		}

		static void n_SetStateAbbrev_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCAddress __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.StateAbbrev = value;
		}
#pragma warning restore 0169

		static IntPtr id_getStateAbbrev;
		static IntPtr id_setStateAbbrev_Ljava_lang_String_;
		public virtual unsafe string StateAbbrev {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/method[@name='getStateAbbrev' and count(parameter)=0]"
			[Register ("getStateAbbrev", "()Ljava/lang/String;", "GetGetStateAbbrevHandler")]
			get {
				if (id_getStateAbbrev == IntPtr.Zero)
					id_getStateAbbrev = JNIEnv.GetMethodID (class_ref, "getStateAbbrev", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStateAbbrev), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStateAbbrev", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/method[@name='setStateAbbrev' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStateAbbrev", "(Ljava/lang/String;)V", "GetSetStateAbbrev_Ljava_lang_String_Handler")]
			set {
				if (id_setStateAbbrev_Ljava_lang_String_ == IntPtr.Zero)
					id_setStateAbbrev_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStateAbbrev", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStateAbbrev_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStateAbbrev", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getStreetLine1;
#pragma warning disable 0169
		static Delegate GetGetStreetLine1Handler ()
		{
			if (cb_getStreetLine1 == null)
				cb_getStreetLine1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStreetLine1);
			return cb_getStreetLine1;
		}

		static IntPtr n_GetStreetLine1 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAddress __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StreetLine1);
		}
#pragma warning restore 0169

		static Delegate cb_setStreetLine1_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStreetLine1_Ljava_lang_String_Handler ()
		{
			if (cb_setStreetLine1_Ljava_lang_String_ == null)
				cb_setStreetLine1_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStreetLine1_Ljava_lang_String_);
			return cb_setStreetLine1_Ljava_lang_String_;
		}

		static void n_SetStreetLine1_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCAddress __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.StreetLine1 = value;
		}
#pragma warning restore 0169

		static IntPtr id_getStreetLine1;
		static IntPtr id_setStreetLine1_Ljava_lang_String_;
		public virtual unsafe string StreetLine1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/method[@name='getStreetLine1' and count(parameter)=0]"
			[Register ("getStreetLine1", "()Ljava/lang/String;", "GetGetStreetLine1Handler")]
			get {
				if (id_getStreetLine1 == IntPtr.Zero)
					id_getStreetLine1 = JNIEnv.GetMethodID (class_ref, "getStreetLine1", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStreetLine1), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStreetLine1", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/method[@name='setStreetLine1' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStreetLine1", "(Ljava/lang/String;)V", "GetSetStreetLine1_Ljava_lang_String_Handler")]
			set {
				if (id_setStreetLine1_Ljava_lang_String_ == IntPtr.Zero)
					id_setStreetLine1_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStreetLine1", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStreetLine1_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStreetLine1", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getStreetLine2;
#pragma warning disable 0169
		static Delegate GetGetStreetLine2Handler ()
		{
			if (cb_getStreetLine2 == null)
				cb_getStreetLine2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStreetLine2);
			return cb_getStreetLine2;
		}

		static IntPtr n_GetStreetLine2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAddress __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StreetLine2);
		}
#pragma warning restore 0169

		static Delegate cb_setStreetLine2_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStreetLine2_Ljava_lang_String_Handler ()
		{
			if (cb_setStreetLine2_Ljava_lang_String_ == null)
				cb_setStreetLine2_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStreetLine2_Ljava_lang_String_);
			return cb_setStreetLine2_Ljava_lang_String_;
		}

		static void n_SetStreetLine2_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCAddress __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.StreetLine2 = value;
		}
#pragma warning restore 0169

		static IntPtr id_getStreetLine2;
		static IntPtr id_setStreetLine2_Ljava_lang_String_;
		public virtual unsafe string StreetLine2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/method[@name='getStreetLine2' and count(parameter)=0]"
			[Register ("getStreetLine2", "()Ljava/lang/String;", "GetGetStreetLine2Handler")]
			get {
				if (id_getStreetLine2 == IntPtr.Zero)
					id_getStreetLine2 = JNIEnv.GetMethodID (class_ref, "getStreetLine2", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStreetLine2), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStreetLine2", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/method[@name='setStreetLine2' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStreetLine2", "(Ljava/lang/String;)V", "GetSetStreetLine2_Ljava_lang_String_Handler")]
			set {
				if (id_setStreetLine2_Ljava_lang_String_ == IntPtr.Zero)
					id_setStreetLine2_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStreetLine2", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStreetLine2_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStreetLine2", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUseLatLong;
#pragma warning disable 0169
		static Delegate GetGetUseLatLongHandler ()
		{
			if (cb_getUseLatLong == null)
				cb_getUseLatLong = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetUseLatLong);
			return cb_getUseLatLong;
		}

		static bool n_GetUseLatLong (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAddress __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseLatLong;
		}
#pragma warning restore 0169

		static Delegate cb_setUseLatLong_Z;
#pragma warning disable 0169
		static Delegate GetSetUseLatLong_ZHandler ()
		{
			if (cb_setUseLatLong_Z == null)
				cb_setUseLatLong_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUseLatLong_Z);
			return cb_setUseLatLong_Z;
		}

		static void n_SetUseLatLong_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::Com.Bluecats.Sdk.BCAddress __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseLatLong = value;
		}
#pragma warning restore 0169

		static IntPtr id_getUseLatLong;
		static IntPtr id_setUseLatLong_Z;
		public virtual unsafe bool UseLatLong {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/method[@name='getUseLatLong' and count(parameter)=0]"
			[Register ("getUseLatLong", "()Z", "GetGetUseLatLongHandler")]
			get {
				if (id_getUseLatLong == IntPtr.Zero)
					id_getUseLatLong = JNIEnv.GetMethodID (class_ref, "getUseLatLong", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getUseLatLong);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUseLatLong", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/method[@name='setUseLatLong' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseLatLong", "(Z)V", "GetSetUseLatLong_ZHandler")]
			set {
				if (id_setUseLatLong_Z == IntPtr.Zero)
					id_setUseLatLong_Z = JNIEnv.GetMethodID (class_ref, "setUseLatLong", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUseLatLong_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUseLatLong", "(Z)V"), __args);
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
			global::Com.Bluecats.Sdk.BCAddress __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Bluecats.Sdk.BCAddress __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAddress> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAddress']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
