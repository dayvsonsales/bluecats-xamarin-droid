using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppSdkOption']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCAppSdkOption", DoNotGenerateAcw=true)]
	public partial class BCAppSdkOption : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppSdkOption']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/bluecats/sdk/BCAppSdkOption", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCAppSdkOption); }
		}

		protected BCAppSdkOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppSdkOption']/constructor[@name='BCAppSdkOption' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe BCAppSdkOption (global::Android.OS.Parcel @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@in);
				if (((object) this).GetType () != typeof (BCAppSdkOption)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Parcel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Parcel;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
					id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

		static Delegate cb_getAppSdkOptionID;
#pragma warning disable 0169
		static Delegate GetGetAppSdkOptionIDHandler ()
		{
			if (cb_getAppSdkOptionID == null)
				cb_getAppSdkOptionID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppSdkOptionID);
			return cb_getAppSdkOptionID;
		}

		static IntPtr n_GetAppSdkOptionID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAppSdkOption __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppSdkOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppSdkOptionID);
		}
#pragma warning restore 0169

		static Delegate cb_setAppSdkOptionID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppSdkOptionID_Ljava_lang_String_Handler ()
		{
			if (cb_setAppSdkOptionID_Ljava_lang_String_ == null)
				cb_setAppSdkOptionID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppSdkOptionID_Ljava_lang_String_);
			return cb_setAppSdkOptionID_Ljava_lang_String_;
		}

		static void n_SetAppSdkOptionID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			global::Com.Bluecats.Sdk.BCAppSdkOption __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppSdkOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			__this.AppSdkOptionID = id;
		}
#pragma warning restore 0169

		static IntPtr id_getAppSdkOptionID;
		static IntPtr id_setAppSdkOptionID_Ljava_lang_String_;
		public virtual unsafe string AppSdkOptionID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppSdkOption']/method[@name='getAppSdkOptionID' and count(parameter)=0]"
			[Register ("getAppSdkOptionID", "()Ljava/lang/String;", "GetGetAppSdkOptionIDHandler")]
			get {
				if (id_getAppSdkOptionID == IntPtr.Zero)
					id_getAppSdkOptionID = JNIEnv.GetMethodID (class_ref, "getAppSdkOptionID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppSdkOptionID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppSdkOptionID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppSdkOption']/method[@name='setAppSdkOptionID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppSdkOptionID", "(Ljava/lang/String;)V", "GetSetAppSdkOptionID_Ljava_lang_String_Handler")]
			set {
				if (id_setAppSdkOptionID_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppSdkOptionID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppSdkOptionID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppSdkOptionID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppSdkOptionID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getOptionKey;
#pragma warning disable 0169
		static Delegate GetGetOptionKeyHandler ()
		{
			if (cb_getOptionKey == null)
				cb_getOptionKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOptionKey);
			return cb_getOptionKey;
		}

		static IntPtr n_GetOptionKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAppSdkOption __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppSdkOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OptionKey);
		}
#pragma warning restore 0169

		static Delegate cb_setOptionKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOptionKey_Ljava_lang_String_Handler ()
		{
			if (cb_setOptionKey_Ljava_lang_String_ == null)
				cb_setOptionKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOptionKey_Ljava_lang_String_);
			return cb_setOptionKey_Ljava_lang_String_;
		}

		static void n_SetOptionKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Bluecats.Sdk.BCAppSdkOption __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppSdkOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			__this.OptionKey = key;
		}
#pragma warning restore 0169

		static IntPtr id_getOptionKey;
		static IntPtr id_setOptionKey_Ljava_lang_String_;
		public virtual unsafe string OptionKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppSdkOption']/method[@name='getOptionKey' and count(parameter)=0]"
			[Register ("getOptionKey", "()Ljava/lang/String;", "GetGetOptionKeyHandler")]
			get {
				if (id_getOptionKey == IntPtr.Zero)
					id_getOptionKey = JNIEnv.GetMethodID (class_ref, "getOptionKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOptionKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOptionKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppSdkOption']/method[@name='setOptionKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setOptionKey", "(Ljava/lang/String;)V", "GetSetOptionKey_Ljava_lang_String_Handler")]
			set {
				if (id_setOptionKey_Ljava_lang_String_ == IntPtr.Zero)
					id_setOptionKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOptionKey", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOptionKey_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOptionKey", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getOptionValue;
#pragma warning disable 0169
		static Delegate GetGetOptionValueHandler ()
		{
			if (cb_getOptionValue == null)
				cb_getOptionValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOptionValue);
			return cb_getOptionValue;
		}

		static IntPtr n_GetOptionValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAppSdkOption __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppSdkOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OptionValue);
		}
#pragma warning restore 0169

		static Delegate cb_setOptionValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOptionValue_Ljava_lang_String_Handler ()
		{
			if (cb_setOptionValue_Ljava_lang_String_ == null)
				cb_setOptionValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOptionValue_Ljava_lang_String_);
			return cb_setOptionValue_Ljava_lang_String_;
		}

		static void n_SetOptionValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCAppSdkOption __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppSdkOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OptionValue = value;
		}
#pragma warning restore 0169

		static IntPtr id_getOptionValue;
		static IntPtr id_setOptionValue_Ljava_lang_String_;
		public virtual unsafe string OptionValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppSdkOption']/method[@name='getOptionValue' and count(parameter)=0]"
			[Register ("getOptionValue", "()Ljava/lang/String;", "GetGetOptionValueHandler")]
			get {
				if (id_getOptionValue == IntPtr.Zero)
					id_getOptionValue = JNIEnv.GetMethodID (class_ref, "getOptionValue", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOptionValue), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOptionValue", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppSdkOption']/method[@name='setOptionValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setOptionValue", "(Ljava/lang/String;)V", "GetSetOptionValue_Ljava_lang_String_Handler")]
			set {
				if (id_setOptionValue_Ljava_lang_String_ == IntPtr.Zero)
					id_setOptionValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOptionValue", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOptionValue_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOptionValue", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Bluecats.Sdk.BCAppSdkOption __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppSdkOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppSdkOption']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Bluecats.Sdk.BCAppSdkOption __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAppSdkOption> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAppSdkOption']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
