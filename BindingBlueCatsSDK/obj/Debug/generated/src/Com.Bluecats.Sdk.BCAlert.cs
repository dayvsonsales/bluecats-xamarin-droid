using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAlert']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCAlert", DoNotGenerateAcw=true)]
	public partial class BCAlert : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAlert']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/bluecats/sdk/BCAlert", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCAlert); }
		}

		protected BCAlert (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAlertID;
#pragma warning disable 0169
		static Delegate GetGetAlertIDHandler ()
		{
			if (cb_getAlertID == null)
				cb_getAlertID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAlertID);
			return cb_getAlertID;
		}

		static IntPtr n_GetAlertID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAlert __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AlertID);
		}
#pragma warning restore 0169

		static Delegate cb_setAlertID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAlertID_Ljava_lang_String_Handler ()
		{
			if (cb_setAlertID_Ljava_lang_String_ == null)
				cb_setAlertID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAlertID_Ljava_lang_String_);
			return cb_setAlertID_Ljava_lang_String_;
		}

		static void n_SetAlertID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCAlert __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AlertID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getAlertID;
		static IntPtr id_setAlertID_Ljava_lang_String_;
		public virtual unsafe string AlertID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAlert']/method[@name='getAlertID' and count(parameter)=0]"
			[Register ("getAlertID", "()Ljava/lang/String;", "GetGetAlertIDHandler")]
			get {
				if (id_getAlertID == IntPtr.Zero)
					id_getAlertID = JNIEnv.GetMethodID (class_ref, "getAlertID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAlertID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlertID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAlert']/method[@name='setAlertID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAlertID", "(Ljava/lang/String;)V", "GetSetAlertID_Ljava_lang_String_Handler")]
			set {
				if (id_setAlertID_Ljava_lang_String_ == IntPtr.Zero)
					id_setAlertID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAlertID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlertID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlertID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAlertSeverity;
#pragma warning disable 0169
		static Delegate GetGetAlertSeverityHandler ()
		{
			if (cb_getAlertSeverity == null)
				cb_getAlertSeverity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAlertSeverity);
			return cb_getAlertSeverity;
		}

		static IntPtr n_GetAlertSeverity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAlert __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AlertSeverity);
		}
#pragma warning restore 0169

		static Delegate cb_setAlertSeverity_Lcom_bluecats_sdk_BCAlertSeverity_;
#pragma warning disable 0169
		static Delegate GetSetAlertSeverity_Lcom_bluecats_sdk_BCAlertSeverity_Handler ()
		{
			if (cb_setAlertSeverity_Lcom_bluecats_sdk_BCAlertSeverity_ == null)
				cb_setAlertSeverity_Lcom_bluecats_sdk_BCAlertSeverity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAlertSeverity_Lcom_bluecats_sdk_BCAlertSeverity_);
			return cb_setAlertSeverity_Lcom_bluecats_sdk_BCAlertSeverity_;
		}

		static void n_SetAlertSeverity_Lcom_bluecats_sdk_BCAlertSeverity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCAlert __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCAlertSeverity value = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAlertSeverity> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AlertSeverity = value;
		}
#pragma warning restore 0169

		static IntPtr id_getAlertSeverity;
		static IntPtr id_setAlertSeverity_Lcom_bluecats_sdk_BCAlertSeverity_;
		public virtual unsafe global::Com.Bluecats.Sdk.BCAlertSeverity AlertSeverity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAlert']/method[@name='getAlertSeverity' and count(parameter)=0]"
			[Register ("getAlertSeverity", "()Lcom/bluecats/sdk/BCAlertSeverity;", "GetGetAlertSeverityHandler")]
			get {
				if (id_getAlertSeverity == IntPtr.Zero)
					id_getAlertSeverity = JNIEnv.GetMethodID (class_ref, "getAlertSeverity", "()Lcom/bluecats/sdk/BCAlertSeverity;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAlertSeverity> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAlertSeverity), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAlertSeverity> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlertSeverity", "()Lcom/bluecats/sdk/BCAlertSeverity;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAlert']/method[@name='setAlertSeverity' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCAlertSeverity']]"
			[Register ("setAlertSeverity", "(Lcom/bluecats/sdk/BCAlertSeverity;)V", "GetSetAlertSeverity_Lcom_bluecats_sdk_BCAlertSeverity_Handler")]
			set {
				if (id_setAlertSeverity_Lcom_bluecats_sdk_BCAlertSeverity_ == IntPtr.Zero)
					id_setAlertSeverity_Lcom_bluecats_sdk_BCAlertSeverity_ = JNIEnv.GetMethodID (class_ref, "setAlertSeverity", "(Lcom/bluecats/sdk/BCAlertSeverity;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlertSeverity_Lcom_bluecats_sdk_BCAlertSeverity_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlertSeverity", "(Lcom/bluecats/sdk/BCAlertSeverity;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAlertType;
#pragma warning disable 0169
		static Delegate GetGetAlertTypeHandler ()
		{
			if (cb_getAlertType == null)
				cb_getAlertType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAlertType);
			return cb_getAlertType;
		}

		static IntPtr n_GetAlertType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAlert __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AlertType);
		}
#pragma warning restore 0169

		static Delegate cb_setAlertType_Lcom_bluecats_sdk_BCAlertType_;
#pragma warning disable 0169
		static Delegate GetSetAlertType_Lcom_bluecats_sdk_BCAlertType_Handler ()
		{
			if (cb_setAlertType_Lcom_bluecats_sdk_BCAlertType_ == null)
				cb_setAlertType_Lcom_bluecats_sdk_BCAlertType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAlertType_Lcom_bluecats_sdk_BCAlertType_);
			return cb_setAlertType_Lcom_bluecats_sdk_BCAlertType_;
		}

		static void n_SetAlertType_Lcom_bluecats_sdk_BCAlertType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCAlert __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCAlertType value = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAlertType> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AlertType = value;
		}
#pragma warning restore 0169

		static IntPtr id_getAlertType;
		static IntPtr id_setAlertType_Lcom_bluecats_sdk_BCAlertType_;
		public virtual unsafe global::Com.Bluecats.Sdk.BCAlertType AlertType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAlert']/method[@name='getAlertType' and count(parameter)=0]"
			[Register ("getAlertType", "()Lcom/bluecats/sdk/BCAlertType;", "GetGetAlertTypeHandler")]
			get {
				if (id_getAlertType == IntPtr.Zero)
					id_getAlertType = JNIEnv.GetMethodID (class_ref, "getAlertType", "()Lcom/bluecats/sdk/BCAlertType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAlertType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAlertType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAlertType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlertType", "()Lcom/bluecats/sdk/BCAlertType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAlert']/method[@name='setAlertType' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCAlertType']]"
			[Register ("setAlertType", "(Lcom/bluecats/sdk/BCAlertType;)V", "GetSetAlertType_Lcom_bluecats_sdk_BCAlertType_Handler")]
			set {
				if (id_setAlertType_Lcom_bluecats_sdk_BCAlertType_ == IntPtr.Zero)
					id_setAlertType_Lcom_bluecats_sdk_BCAlertType_ = JNIEnv.GetMethodID (class_ref, "setAlertType", "(Lcom/bluecats/sdk/BCAlertType;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlertType_Lcom_bluecats_sdk_BCAlertType_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlertType", "(Lcom/bluecats/sdk/BCAlertType;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAlert __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		static Delegate cb_setMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setMessage_Ljava_lang_String_ == null)
				cb_setMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessage_Ljava_lang_String_);
			return cb_setMessage_Ljava_lang_String_;
		}

		static void n_SetMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCAlert __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Message = value;
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		static IntPtr id_setMessage_Ljava_lang_String_;
		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAlert']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAlert']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMessage", "(Ljava/lang/String;)V", "GetSetMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getOccurredAt;
#pragma warning disable 0169
		static Delegate GetGetOccurredAtHandler ()
		{
			if (cb_getOccurredAt == null)
				cb_getOccurredAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOccurredAt);
			return cb_getOccurredAt;
		}

		static IntPtr n_GetOccurredAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAlert __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OccurredAt);
		}
#pragma warning restore 0169

		static Delegate cb_setOccurredAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetOccurredAt_Ljava_util_Date_Handler ()
		{
			if (cb_setOccurredAt_Ljava_util_Date_ == null)
				cb_setOccurredAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOccurredAt_Ljava_util_Date_);
			return cb_setOccurredAt_Ljava_util_Date_;
		}

		static void n_SetOccurredAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCAlert __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.OccurredAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getOccurredAt;
		static IntPtr id_setOccurredAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date OccurredAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAlert']/method[@name='getOccurredAt' and count(parameter)=0]"
			[Register ("getOccurredAt", "()Ljava/util/Date;", "GetGetOccurredAtHandler")]
			get {
				if (id_getOccurredAt == IntPtr.Zero)
					id_getOccurredAt = JNIEnv.GetMethodID (class_ref, "getOccurredAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOccurredAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOccurredAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAlert']/method[@name='setOccurredAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setOccurredAt", "(Ljava/util/Date;)V", "GetSetOccurredAt_Ljava_util_Date_Handler")]
			set {
				if (id_setOccurredAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setOccurredAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setOccurredAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOccurredAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOccurredAt", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTeamID;
#pragma warning disable 0169
		static Delegate GetGetTeamIDHandler ()
		{
			if (cb_getTeamID == null)
				cb_getTeamID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTeamID);
			return cb_getTeamID;
		}

		static IntPtr n_GetTeamID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCAlert __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TeamID);
		}
#pragma warning restore 0169

		static Delegate cb_setTeamID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTeamID_Ljava_lang_String_Handler ()
		{
			if (cb_setTeamID_Ljava_lang_String_ == null)
				cb_setTeamID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTeamID_Ljava_lang_String_);
			return cb_setTeamID_Ljava_lang_String_;
		}

		static void n_SetTeamID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCAlert __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.TeamID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getTeamID;
		static IntPtr id_setTeamID_Ljava_lang_String_;
		public virtual unsafe string TeamID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAlert']/method[@name='getTeamID' and count(parameter)=0]"
			[Register ("getTeamID", "()Ljava/lang/String;", "GetGetTeamIDHandler")]
			get {
				if (id_getTeamID == IntPtr.Zero)
					id_getTeamID = JNIEnv.GetMethodID (class_ref, "getTeamID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTeamID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTeamID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAlert']/method[@name='setTeamID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTeamID", "(Ljava/lang/String;)V", "GetSetTeamID_Ljava_lang_String_Handler")]
			set {
				if (id_setTeamID_Ljava_lang_String_ == IntPtr.Zero)
					id_setTeamID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTeamID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTeamID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTeamID", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bluecats.Sdk.BCAlert __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAlert']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Bluecats.Sdk.BCAlert __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCAlert> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCAlert']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
