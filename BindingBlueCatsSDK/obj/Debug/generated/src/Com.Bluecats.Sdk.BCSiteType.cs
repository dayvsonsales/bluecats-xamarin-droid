using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteType']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCSiteType", DoNotGenerateAcw=true)]
	public partial class BCSiteType : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteType']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/bluecats/sdk/BCSiteType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCSiteType); }
		}

		protected BCSiteType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getDisplayName;
#pragma warning disable 0169
		static Delegate GetGetDisplayNameHandler ()
		{
			if (cb_getDisplayName == null)
				cb_getDisplayName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayName);
			return cb_getDisplayName;
		}

		static IntPtr n_GetDisplayName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCSiteType __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DisplayName);
		}
#pragma warning restore 0169

		static Delegate cb_setDisplayName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDisplayName_Ljava_lang_String_Handler ()
		{
			if (cb_setDisplayName_Ljava_lang_String_ == null)
				cb_setDisplayName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDisplayName_Ljava_lang_String_);
			return cb_setDisplayName_Ljava_lang_String_;
		}

		static void n_SetDisplayName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCSiteType __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.DisplayName = value;
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayName;
		static IntPtr id_setDisplayName_Ljava_lang_String_;
		public virtual unsafe string DisplayName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteType']/method[@name='getDisplayName' and count(parameter)=0]"
			[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler")]
			get {
				if (id_getDisplayName == IntPtr.Zero)
					id_getDisplayName = JNIEnv.GetMethodID (class_ref, "getDisplayName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteType']/method[@name='setDisplayName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDisplayName", "(Ljava/lang/String;)V", "GetSetDisplayName_Ljava_lang_String_Handler")]
			set {
				if (id_setDisplayName_Ljava_lang_String_ == IntPtr.Zero)
					id_setDisplayName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDisplayName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDisplayName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCSiteType __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCSiteType __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Name = value;
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		static IntPtr id_setName_Ljava_lang_String_;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteType']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteType']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
					id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSiteTypeID;
#pragma warning disable 0169
		static Delegate GetGetSiteTypeIDHandler ()
		{
			if (cb_getSiteTypeID == null)
				cb_getSiteTypeID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSiteTypeID);
			return cb_getSiteTypeID;
		}

		static int n_GetSiteTypeID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCSiteType __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SiteTypeID;
		}
#pragma warning restore 0169

		static Delegate cb_setSiteTypeID_I;
#pragma warning disable 0169
		static Delegate GetSetSiteTypeID_IHandler ()
		{
			if (cb_setSiteTypeID_I == null)
				cb_setSiteTypeID_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSiteTypeID_I);
			return cb_setSiteTypeID_I;
		}

		static void n_SetSiteTypeID_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Bluecats.Sdk.BCSiteType __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SiteTypeID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getSiteTypeID;
		static IntPtr id_setSiteTypeID_I;
		public virtual unsafe int SiteTypeID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteType']/method[@name='getSiteTypeID' and count(parameter)=0]"
			[Register ("getSiteTypeID", "()I", "GetGetSiteTypeIDHandler")]
			get {
				if (id_getSiteTypeID == IntPtr.Zero)
					id_getSiteTypeID = JNIEnv.GetMethodID (class_ref, "getSiteTypeID", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSiteTypeID);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSiteTypeID", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteType']/method[@name='setSiteTypeID' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSiteTypeID", "(I)V", "GetSetSiteTypeID_IHandler")]
			set {
				if (id_setSiteTypeID_I == IntPtr.Zero)
					id_setSiteTypeID_I = JNIEnv.GetMethodID (class_ref, "setSiteTypeID", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSiteTypeID_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSiteTypeID", "(I)V"), __args);
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
			global::Com.Bluecats.Sdk.BCSiteType __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteType']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Bluecats.Sdk.BCSiteType __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteType']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
