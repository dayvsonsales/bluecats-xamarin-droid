using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCBeaconVersion", DoNotGenerateAcw=true)]
	public partial class BCBeaconVersion : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/bluecats/sdk/BCBeaconVersion", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCBeaconVersion); }
		}

		protected BCBeaconVersion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getBeaconID;
#pragma warning disable 0169
		static Delegate GetGetBeaconIDHandler ()
		{
			if (cb_getBeaconID == null)
				cb_getBeaconID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeaconID);
			return cb_getBeaconID;
		}

		static IntPtr n_GetBeaconID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BeaconID);
		}
#pragma warning restore 0169

		static Delegate cb_setBeaconID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBeaconID_Ljava_lang_String_Handler ()
		{
			if (cb_setBeaconID_Ljava_lang_String_ == null)
				cb_setBeaconID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBeaconID_Ljava_lang_String_);
			return cb_setBeaconID_Ljava_lang_String_;
		}

		static void n_SetBeaconID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_beaconID)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string beaconID = JNIEnv.GetString (native_beaconID, JniHandleOwnership.DoNotTransfer);
			__this.BeaconID = beaconID;
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconID;
		static IntPtr id_setBeaconID_Ljava_lang_String_;
		public virtual unsafe string BeaconID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='getBeaconID' and count(parameter)=0]"
			[Register ("getBeaconID", "()Ljava/lang/String;", "GetGetBeaconIDHandler")]
			get {
				if (id_getBeaconID == IntPtr.Zero)
					id_getBeaconID = JNIEnv.GetMethodID (class_ref, "getBeaconID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeaconID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='setBeaconID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBeaconID", "(Ljava/lang/String;)V", "GetSetBeaconID_Ljava_lang_String_Handler")]
			set {
				if (id_setBeaconID_Ljava_lang_String_ == IntPtr.Zero)
					id_setBeaconID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBeaconID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeaconID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBeaconID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBeaconLoudness;
#pragma warning disable 0169
		static Delegate GetGetBeaconLoudnessHandler ()
		{
			if (cb_getBeaconLoudness == null)
				cb_getBeaconLoudness = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeaconLoudness);
			return cb_getBeaconLoudness;
		}

		static IntPtr n_GetBeaconLoudness (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BeaconLoudness);
		}
#pragma warning restore 0169

		static Delegate cb_setBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_;
#pragma warning disable 0169
		static Delegate GetSetBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_Handler ()
		{
			if (cb_setBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_ == null)
				cb_setBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_);
			return cb_setBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_;
		}

		static void n_SetBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_ (IntPtr jnienv, IntPtr native__this, IntPtr native_beaconLoudness)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconLoudness beaconLoudness = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconLoudness> (native_beaconLoudness, JniHandleOwnership.DoNotTransfer);
			__this.BeaconLoudness = beaconLoudness;
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconLoudness;
		static IntPtr id_setBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_;
		public virtual unsafe global::Com.Bluecats.Sdk.BCBeaconLoudness BeaconLoudness {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='getBeaconLoudness' and count(parameter)=0]"
			[Register ("getBeaconLoudness", "()Lcom/bluecats/sdk/BCBeaconLoudness;", "GetGetBeaconLoudnessHandler")]
			get {
				if (id_getBeaconLoudness == IntPtr.Zero)
					id_getBeaconLoudness = JNIEnv.GetMethodID (class_ref, "getBeaconLoudness", "()Lcom/bluecats/sdk/BCBeaconLoudness;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconLoudness> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconLoudness), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconLoudness> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeaconLoudness", "()Lcom/bluecats/sdk/BCBeaconLoudness;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='setBeaconLoudness' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconLoudness']]"
			[Register ("setBeaconLoudness", "(Lcom/bluecats/sdk/BCBeaconLoudness;)V", "GetSetBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_Handler")]
			set {
				if (id_setBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_ == IntPtr.Zero)
					id_setBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_ = JNIEnv.GetMethodID (class_ref, "setBeaconLoudness", "(Lcom/bluecats/sdk/BCBeaconLoudness;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeaconLoudness_Lcom_bluecats_sdk_BCBeaconLoudness_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBeaconLoudness", "(Lcom/bluecats/sdk/BCBeaconLoudness;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBeaconMode;
#pragma warning disable 0169
		static Delegate GetGetBeaconModeHandler ()
		{
			if (cb_getBeaconMode == null)
				cb_getBeaconMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeaconMode);
			return cb_getBeaconMode;
		}

		static IntPtr n_GetBeaconMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BeaconMode);
		}
#pragma warning restore 0169

		static Delegate cb_setBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_;
#pragma warning disable 0169
		static Delegate GetSetBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_Handler ()
		{
			if (cb_setBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_ == null)
				cb_setBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_);
			return cb_setBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_;
		}

		static void n_SetBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_beaconMode)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconMode beaconMode = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconMode> (native_beaconMode, JniHandleOwnership.DoNotTransfer);
			__this.BeaconMode = beaconMode;
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconMode;
		static IntPtr id_setBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_;
		public virtual unsafe global::Com.Bluecats.Sdk.BCBeaconMode BeaconMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='getBeaconMode' and count(parameter)=0]"
			[Register ("getBeaconMode", "()Lcom/bluecats/sdk/BCBeaconMode;", "GetGetBeaconModeHandler")]
			get {
				if (id_getBeaconMode == IntPtr.Zero)
					id_getBeaconMode = JNIEnv.GetMethodID (class_ref, "getBeaconMode", "()Lcom/bluecats/sdk/BCBeaconMode;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconMode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconMode), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconMode> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeaconMode", "()Lcom/bluecats/sdk/BCBeaconMode;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='setBeaconMode' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconMode']]"
			[Register ("setBeaconMode", "(Lcom/bluecats/sdk/BCBeaconMode;)V", "GetSetBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_Handler")]
			set {
				if (id_setBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_ == IntPtr.Zero)
					id_setBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_ = JNIEnv.GetMethodID (class_ref, "setBeaconMode", "(Lcom/bluecats/sdk/BCBeaconMode;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBeaconMode", "(Lcom/bluecats/sdk/BCBeaconMode;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBeaconRegion;
#pragma warning disable 0169
		static Delegate GetGetBeaconRegionHandler ()
		{
			if (cb_getBeaconRegion == null)
				cb_getBeaconRegion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeaconRegion);
			return cb_getBeaconRegion;
		}

		static IntPtr n_GetBeaconRegion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BeaconRegion);
		}
#pragma warning restore 0169

		static Delegate cb_setBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_;
#pragma warning disable 0169
		static Delegate GetSetBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_Handler ()
		{
			if (cb_setBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_ == null)
				cb_setBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_);
			return cb_setBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_;
		}

		static void n_SetBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_ (IntPtr jnienv, IntPtr native__this, IntPtr native_beaconRegion)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconRegion beaconRegion = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (native_beaconRegion, JniHandleOwnership.DoNotTransfer);
			__this.BeaconRegion = beaconRegion;
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconRegion;
		static IntPtr id_setBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_;
		public virtual unsafe global::Com.Bluecats.Sdk.BCBeaconRegion BeaconRegion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='getBeaconRegion' and count(parameter)=0]"
			[Register ("getBeaconRegion", "()Lcom/bluecats/sdk/BCBeaconRegion;", "GetGetBeaconRegionHandler")]
			get {
				if (id_getBeaconRegion == IntPtr.Zero)
					id_getBeaconRegion = JNIEnv.GetMethodID (class_ref, "getBeaconRegion", "()Lcom/bluecats/sdk/BCBeaconRegion;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconRegion), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeaconRegion", "()Lcom/bluecats/sdk/BCBeaconRegion;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='setBeaconRegion' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconRegion']]"
			[Register ("setBeaconRegion", "(Lcom/bluecats/sdk/BCBeaconRegion;)V", "GetSetBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_Handler")]
			set {
				if (id_setBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_ == IntPtr.Zero)
					id_setBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_ = JNIEnv.GetMethodID (class_ref, "setBeaconRegion", "(Lcom/bluecats/sdk/BCBeaconRegion;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeaconRegion_Lcom_bluecats_sdk_BCBeaconRegion_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBeaconRegion", "(Lcom/bluecats/sdk/BCBeaconRegion;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getConfirmedAt;
#pragma warning disable 0169
		static Delegate GetGetConfirmedAtHandler ()
		{
			if (cb_getConfirmedAt == null)
				cb_getConfirmedAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConfirmedAt);
			return cb_getConfirmedAt;
		}

		static IntPtr n_GetConfirmedAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConfirmedAt);
		}
#pragma warning restore 0169

		static Delegate cb_setConfirmedAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetConfirmedAt_Ljava_util_Date_Handler ()
		{
			if (cb_setConfirmedAt_Ljava_util_Date_ == null)
				cb_setConfirmedAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConfirmedAt_Ljava_util_Date_);
			return cb_setConfirmedAt_Ljava_util_Date_;
		}

		static void n_SetConfirmedAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_confirmedAt)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date confirmedAt = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_confirmedAt, JniHandleOwnership.DoNotTransfer);
			__this.ConfirmedAt = confirmedAt;
		}
#pragma warning restore 0169

		static IntPtr id_getConfirmedAt;
		static IntPtr id_setConfirmedAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date ConfirmedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='getConfirmedAt' and count(parameter)=0]"
			[Register ("getConfirmedAt", "()Ljava/util/Date;", "GetGetConfirmedAtHandler")]
			get {
				if (id_getConfirmedAt == IntPtr.Zero)
					id_getConfirmedAt = JNIEnv.GetMethodID (class_ref, "getConfirmedAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConfirmedAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConfirmedAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='setConfirmedAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setConfirmedAt", "(Ljava/util/Date;)V", "GetSetConfirmedAt_Ljava_util_Date_Handler")]
			set {
				if (id_setConfirmedAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setConfirmedAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setConfirmedAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConfirmedAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConfirmedAt", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCreatedAt;
#pragma warning disable 0169
		static Delegate GetGetCreatedAtHandler ()
		{
			if (cb_getCreatedAt == null)
				cb_getCreatedAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreatedAt);
			return cb_getCreatedAt;
		}

		static IntPtr n_GetCreatedAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreatedAt);
		}
#pragma warning restore 0169

		static Delegate cb_setCreatedAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetCreatedAt_Ljava_util_Date_Handler ()
		{
			if (cb_setCreatedAt_Ljava_util_Date_ == null)
				cb_setCreatedAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCreatedAt_Ljava_util_Date_);
			return cb_setCreatedAt_Ljava_util_Date_;
		}

		static void n_SetCreatedAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_createdAt)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date createdAt = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_createdAt, JniHandleOwnership.DoNotTransfer);
			__this.CreatedAt = createdAt;
		}
#pragma warning restore 0169

		static IntPtr id_getCreatedAt;
		static IntPtr id_setCreatedAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date CreatedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='getCreatedAt' and count(parameter)=0]"
			[Register ("getCreatedAt", "()Ljava/util/Date;", "GetGetCreatedAtHandler")]
			get {
				if (id_getCreatedAt == IntPtr.Zero)
					id_getCreatedAt = JNIEnv.GetMethodID (class_ref, "getCreatedAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCreatedAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreatedAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='setCreatedAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setCreatedAt", "(Ljava/util/Date;)V", "GetSetCreatedAt_Ljava_util_Date_Handler")]
			set {
				if (id_setCreatedAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setCreatedAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setCreatedAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCreatedAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCreatedAt", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEddystone;
#pragma warning disable 0169
		static Delegate GetGetEddystoneHandler ()
		{
			if (cb_getEddystone == null)
				cb_getEddystone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEddystone);
			return cb_getEddystone;
		}

		static IntPtr n_GetEddystone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Eddystone);
		}
#pragma warning restore 0169

		static Delegate cb_setEddystone_Lcom_bluecats_sdk_BCEddystone_;
#pragma warning disable 0169
		static Delegate GetSetEddystone_Lcom_bluecats_sdk_BCEddystone_Handler ()
		{
			if (cb_setEddystone_Lcom_bluecats_sdk_BCEddystone_ == null)
				cb_setEddystone_Lcom_bluecats_sdk_BCEddystone_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEddystone_Lcom_bluecats_sdk_BCEddystone_);
			return cb_setEddystone_Lcom_bluecats_sdk_BCEddystone_;
		}

		static void n_SetEddystone_Lcom_bluecats_sdk_BCEddystone_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCEddystone value = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEddystone> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Eddystone = value;
		}
#pragma warning restore 0169

		static IntPtr id_getEddystone;
		static IntPtr id_setEddystone_Lcom_bluecats_sdk_BCEddystone_;
		public virtual unsafe global::Com.Bluecats.Sdk.BCEddystone Eddystone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='getEddystone' and count(parameter)=0]"
			[Register ("getEddystone", "()Lcom/bluecats/sdk/BCEddystone;", "GetGetEddystoneHandler")]
			get {
				if (id_getEddystone == IntPtr.Zero)
					id_getEddystone = JNIEnv.GetMethodID (class_ref, "getEddystone", "()Lcom/bluecats/sdk/BCEddystone;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEddystone> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEddystone), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEddystone> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEddystone", "()Lcom/bluecats/sdk/BCEddystone;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='setEddystone' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCEddystone']]"
			[Register ("setEddystone", "(Lcom/bluecats/sdk/BCEddystone;)V", "GetSetEddystone_Lcom_bluecats_sdk_BCEddystone_Handler")]
			set {
				if (id_setEddystone_Lcom_bluecats_sdk_BCEddystone_ == IntPtr.Zero)
					id_setEddystone_Lcom_bluecats_sdk_BCEddystone_ = JNIEnv.GetMethodID (class_ref, "setEddystone", "(Lcom/bluecats/sdk/BCEddystone;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEddystone_Lcom_bluecats_sdk_BCEddystone_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEddystone", "(Lcom/bluecats/sdk/BCEddystone;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFirmwareVersion;
#pragma warning disable 0169
		static Delegate GetGetFirmwareVersionHandler ()
		{
			if (cb_getFirmwareVersion == null)
				cb_getFirmwareVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFirmwareVersion);
			return cb_getFirmwareVersion;
		}

		static IntPtr n_GetFirmwareVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FirmwareVersion);
		}
#pragma warning restore 0169

		static Delegate cb_setFirmwareVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFirmwareVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setFirmwareVersion_Ljava_lang_String_ == null)
				cb_setFirmwareVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFirmwareVersion_Ljava_lang_String_);
			return cb_setFirmwareVersion_Ljava_lang_String_;
		}

		static void n_SetFirmwareVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_firmwareVersion)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string firmwareVersion = JNIEnv.GetString (native_firmwareVersion, JniHandleOwnership.DoNotTransfer);
			__this.FirmwareVersion = firmwareVersion;
		}
#pragma warning restore 0169

		static IntPtr id_getFirmwareVersion;
		static IntPtr id_setFirmwareVersion_Ljava_lang_String_;
		public virtual unsafe string FirmwareVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='getFirmwareVersion' and count(parameter)=0]"
			[Register ("getFirmwareVersion", "()Ljava/lang/String;", "GetGetFirmwareVersionHandler")]
			get {
				if (id_getFirmwareVersion == IntPtr.Zero)
					id_getFirmwareVersion = JNIEnv.GetMethodID (class_ref, "getFirmwareVersion", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFirmwareVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirmwareVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='setFirmwareVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFirmwareVersion", "(Ljava/lang/String;)V", "GetSetFirmwareVersion_Ljava_lang_String_Handler")]
			set {
				if (id_setFirmwareVersion_Ljava_lang_String_ == IntPtr.Zero)
					id_setFirmwareVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFirmwareVersion", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFirmwareVersion_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFirmwareVersion", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMajor;
#pragma warning disable 0169
		static Delegate GetGetMajorHandler ()
		{
			if (cb_getMajor == null)
				cb_getMajor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMajor);
			return cb_getMajor;
		}

		static IntPtr n_GetMajor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Major);
		}
#pragma warning restore 0169

		static Delegate cb_setMajor_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetMajor_Ljava_lang_Integer_Handler ()
		{
			if (cb_setMajor_Ljava_lang_Integer_ == null)
				cb_setMajor_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMajor_Ljava_lang_Integer_);
			return cb_setMajor_Ljava_lang_Integer_;
		}

		static void n_SetMajor_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_major)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer major = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_major, JniHandleOwnership.DoNotTransfer);
			__this.Major = major;
		}
#pragma warning restore 0169

		static IntPtr id_getMajor;
		static IntPtr id_setMajor_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Major {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='getMajor' and count(parameter)=0]"
			[Register ("getMajor", "()Ljava/lang/Integer;", "GetGetMajorHandler")]
			get {
				if (id_getMajor == IntPtr.Zero)
					id_getMajor = JNIEnv.GetMethodID (class_ref, "getMajor", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMajor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMajor", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='setMajor' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setMajor", "(Ljava/lang/Integer;)V", "GetSetMajor_Ljava_lang_Integer_Handler")]
			set {
				if (id_setMajor_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setMajor_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setMajor", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMajor_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMajor", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMeasuredPowerAt1Meter;
#pragma warning disable 0169
		static Delegate GetGetMeasuredPowerAt1MeterHandler ()
		{
			if (cb_getMeasuredPowerAt1Meter == null)
				cb_getMeasuredPowerAt1Meter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMeasuredPowerAt1Meter);
			return cb_getMeasuredPowerAt1Meter;
		}

		static IntPtr n_GetMeasuredPowerAt1Meter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MeasuredPowerAt1Meter);
		}
#pragma warning restore 0169

		static IntPtr id_getMeasuredPowerAt1Meter;
		public virtual unsafe global::Java.Lang.Integer MeasuredPowerAt1Meter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='getMeasuredPowerAt1Meter' and count(parameter)=0]"
			[Register ("getMeasuredPowerAt1Meter", "()Ljava/lang/Integer;", "GetGetMeasuredPowerAt1MeterHandler")]
			get {
				if (id_getMeasuredPowerAt1Meter == IntPtr.Zero)
					id_getMeasuredPowerAt1Meter = JNIEnv.GetMethodID (class_ref, "getMeasuredPowerAt1Meter", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMeasuredPowerAt1Meter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMeasuredPowerAt1Meter", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMinor;
#pragma warning disable 0169
		static Delegate GetGetMinorHandler ()
		{
			if (cb_getMinor == null)
				cb_getMinor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMinor);
			return cb_getMinor;
		}

		static IntPtr n_GetMinor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Minor);
		}
#pragma warning restore 0169

		static Delegate cb_setMinor_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetMinor_Ljava_lang_Integer_Handler ()
		{
			if (cb_setMinor_Ljava_lang_Integer_ == null)
				cb_setMinor_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMinor_Ljava_lang_Integer_);
			return cb_setMinor_Ljava_lang_Integer_;
		}

		static void n_SetMinor_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_minor)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer minor = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_minor, JniHandleOwnership.DoNotTransfer);
			__this.Minor = minor;
		}
#pragma warning restore 0169

		static IntPtr id_getMinor;
		static IntPtr id_setMinor_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Minor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='getMinor' and count(parameter)=0]"
			[Register ("getMinor", "()Ljava/lang/Integer;", "GetGetMinorHandler")]
			get {
				if (id_getMinor == IntPtr.Zero)
					id_getMinor = JNIEnv.GetMethodID (class_ref, "getMinor", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMinor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinor", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='setMinor' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setMinor", "(Ljava/lang/Integer;)V", "GetSetMinor_Ljava_lang_Integer_Handler")]
			set {
				if (id_setMinor_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setMinor_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setMinor", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMinor_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinor", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPrivacyDuration;
#pragma warning disable 0169
		static Delegate GetGetPrivacyDurationHandler ()
		{
			if (cb_getPrivacyDuration == null)
				cb_getPrivacyDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrivacyDuration);
			return cb_getPrivacyDuration;
		}

		static IntPtr n_GetPrivacyDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PrivacyDuration);
		}
#pragma warning restore 0169

		static Delegate cb_setPrivacyDuration_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetPrivacyDuration_Ljava_lang_Integer_Handler ()
		{
			if (cb_setPrivacyDuration_Ljava_lang_Integer_ == null)
				cb_setPrivacyDuration_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPrivacyDuration_Ljava_lang_Integer_);
			return cb_setPrivacyDuration_Ljava_lang_Integer_;
		}

		static void n_SetPrivacyDuration_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_privacyDuration)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer privacyDuration = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_privacyDuration, JniHandleOwnership.DoNotTransfer);
			__this.PrivacyDuration = privacyDuration;
		}
#pragma warning restore 0169

		static IntPtr id_getPrivacyDuration;
		static IntPtr id_setPrivacyDuration_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer PrivacyDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='getPrivacyDuration' and count(parameter)=0]"
			[Register ("getPrivacyDuration", "()Ljava/lang/Integer;", "GetGetPrivacyDurationHandler")]
			get {
				if (id_getPrivacyDuration == IntPtr.Zero)
					id_getPrivacyDuration = JNIEnv.GetMethodID (class_ref, "getPrivacyDuration", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPrivacyDuration), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrivacyDuration", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='setPrivacyDuration' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setPrivacyDuration", "(Ljava/lang/Integer;)V", "GetSetPrivacyDuration_Ljava_lang_Integer_Handler")]
			set {
				if (id_setPrivacyDuration_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setPrivacyDuration_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setPrivacyDuration", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPrivacyDuration_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPrivacyDuration", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getProximityUUID;
#pragma warning disable 0169
		static Delegate GetGetProximityUUIDHandler ()
		{
			if (cb_getProximityUUID == null)
				cb_getProximityUUID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProximityUUID);
			return cb_getProximityUUID;
		}

		static IntPtr n_GetProximityUUID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProximityUUID);
		}
#pragma warning restore 0169

		static Delegate cb_setProximityUUID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProximityUUID_Ljava_lang_String_Handler ()
		{
			if (cb_setProximityUUID_Ljava_lang_String_ == null)
				cb_setProximityUUID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProximityUUID_Ljava_lang_String_);
			return cb_setProximityUUID_Ljava_lang_String_;
		}

		static void n_SetProximityUUID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_proximityUUID)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string proximityUUID = JNIEnv.GetString (native_proximityUUID, JniHandleOwnership.DoNotTransfer);
			__this.ProximityUUID = proximityUUID;
		}
#pragma warning restore 0169

		static IntPtr id_getProximityUUID;
		static IntPtr id_setProximityUUID_Ljava_lang_String_;
		public virtual unsafe string ProximityUUID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='getProximityUUID' and count(parameter)=0]"
			[Register ("getProximityUUID", "()Ljava/lang/String;", "GetGetProximityUUIDHandler")]
			get {
				if (id_getProximityUUID == IntPtr.Zero)
					id_getProximityUUID = JNIEnv.GetMethodID (class_ref, "getProximityUUID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProximityUUID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProximityUUID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='setProximityUUID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProximityUUID", "(Ljava/lang/String;)V", "GetSetProximityUUID_Ljava_lang_String_Handler")]
			set {
				if (id_setProximityUUID_Ljava_lang_String_ == IntPtr.Zero)
					id_setProximityUUID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setProximityUUID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setProximityUUID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProximityUUID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTargetSpeed;
#pragma warning disable 0169
		static Delegate GetGetTargetSpeedHandler ()
		{
			if (cb_getTargetSpeed == null)
				cb_getTargetSpeed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTargetSpeed);
			return cb_getTargetSpeed;
		}

		static IntPtr n_GetTargetSpeed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TargetSpeed);
		}
#pragma warning restore 0169

		static Delegate cb_setTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_;
#pragma warning disable 0169
		static Delegate GetSetTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_Handler ()
		{
			if (cb_setTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_ == null)
				cb_setTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_);
			return cb_setTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_;
		}

		static void n_SetTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_ (IntPtr jnienv, IntPtr native__this, IntPtr native_targetSpeed)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCTargetSpeed targetSpeed = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTargetSpeed> (native_targetSpeed, JniHandleOwnership.DoNotTransfer);
			__this.TargetSpeed = targetSpeed;
		}
#pragma warning restore 0169

		static IntPtr id_getTargetSpeed;
		static IntPtr id_setTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_;
		public virtual unsafe global::Com.Bluecats.Sdk.BCTargetSpeed TargetSpeed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='getTargetSpeed' and count(parameter)=0]"
			[Register ("getTargetSpeed", "()Lcom/bluecats/sdk/BCTargetSpeed;", "GetGetTargetSpeedHandler")]
			get {
				if (id_getTargetSpeed == IntPtr.Zero)
					id_getTargetSpeed = JNIEnv.GetMethodID (class_ref, "getTargetSpeed", "()Lcom/bluecats/sdk/BCTargetSpeed;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTargetSpeed> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTargetSpeed), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTargetSpeed> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTargetSpeed", "()Lcom/bluecats/sdk/BCTargetSpeed;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='setTargetSpeed' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCTargetSpeed']]"
			[Register ("setTargetSpeed", "(Lcom/bluecats/sdk/BCTargetSpeed;)V", "GetSetTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_Handler")]
			set {
				if (id_setTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_ == IntPtr.Zero)
					id_setTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_ = JNIEnv.GetMethodID (class_ref, "setTargetSpeed", "(Lcom/bluecats/sdk/BCTargetSpeed;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTargetSpeed_Lcom_bluecats_sdk_BCTargetSpeed_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTargetSpeed", "(Lcom/bluecats/sdk/BCTargetSpeed;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersion);
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Version);
		}
#pragma warning restore 0169

		static Delegate cb_setVersion_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetVersion_Ljava_lang_Integer_Handler ()
		{
			if (cb_setVersion_Ljava_lang_Integer_ == null)
				cb_setVersion_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVersion_Ljava_lang_Integer_);
			return cb_setVersion_Ljava_lang_Integer_;
		}

		static void n_SetVersion_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_version)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer version = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_version, JniHandleOwnership.DoNotTransfer);
			__this.Version = version;
		}
#pragma warning restore 0169

		static IntPtr id_getVersion;
		static IntPtr id_setVersion_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/Integer;", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVersion), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVersion", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='setVersion' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setVersion", "(Ljava/lang/Integer;)V", "GetSetVersion_Ljava_lang_Integer_Handler")]
			set {
				if (id_setVersion_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setVersion_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setVersion", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVersion_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVersion", "(Ljava/lang/Integer;)V"), __args);
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
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_serMeasuredPowerAt1Meter_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSerMeasuredPowerAt1Meter_Ljava_lang_Integer_Handler ()
		{
			if (cb_serMeasuredPowerAt1Meter_Ljava_lang_Integer_ == null)
				cb_serMeasuredPowerAt1Meter_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SerMeasuredPowerAt1Meter_Ljava_lang_Integer_);
			return cb_serMeasuredPowerAt1Meter_Ljava_lang_Integer_;
		}

		static void n_SerMeasuredPowerAt1Meter_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_power)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer power = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_power, JniHandleOwnership.DoNotTransfer);
			__this.SerMeasuredPowerAt1Meter (power);
		}
#pragma warning restore 0169

		static IntPtr id_serMeasuredPowerAt1Meter_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='serMeasuredPowerAt1Meter' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("serMeasuredPowerAt1Meter", "(Ljava/lang/Integer;)V", "GetSerMeasuredPowerAt1Meter_Ljava_lang_Integer_Handler")]
		public virtual unsafe void SerMeasuredPowerAt1Meter (global::Java.Lang.Integer power)
		{
			if (id_serMeasuredPowerAt1Meter_Ljava_lang_Integer_ == IntPtr.Zero)
				id_serMeasuredPowerAt1Meter_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "serMeasuredPowerAt1Meter", "(Ljava/lang/Integer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (power);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_serMeasuredPowerAt1Meter_Ljava_lang_Integer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "serMeasuredPowerAt1Meter", "(Ljava/lang/Integer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setProximityUUIDUpperCase;
#pragma warning disable 0169
		static Delegate GetSetProximityUUIDUpperCaseHandler ()
		{
			if (cb_setProximityUUIDUpperCase == null)
				cb_setProximityUUIDUpperCase = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetProximityUUIDUpperCase);
			return cb_setProximityUUIDUpperCase;
		}

		static void n_SetProximityUUIDUpperCase (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetProximityUUIDUpperCase ();
		}
#pragma warning restore 0169

		static IntPtr id_setProximityUUIDUpperCase;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='setProximityUUIDUpperCase' and count(parameter)=0]"
		[Register ("setProximityUUIDUpperCase", "()V", "GetSetProximityUUIDUpperCaseHandler")]
		public virtual unsafe void SetProximityUUIDUpperCase ()
		{
			if (id_setProximityUUIDUpperCase == IntPtr.Zero)
				id_setProximityUUIDUpperCase = JNIEnv.GetMethodID (class_ref, "setProximityUUIDUpperCase", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setProximityUUIDUpperCase);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProximityUUIDUpperCase", "()V"));
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
			global::Com.Bluecats.Sdk.BCBeaconVersion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVersion']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
