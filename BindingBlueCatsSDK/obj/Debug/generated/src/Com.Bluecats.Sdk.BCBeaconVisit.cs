using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCBeaconVisit", DoNotGenerateAcw=true)]
	public partial class BCBeaconVisit : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/bluecats/sdk/BCBeaconVisit", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCBeaconVisit); }
		}

		protected BCBeaconVisit (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/constructor[@name='BCBeaconVisit' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCBeaconVisit ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCBeaconVisit)) {
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

		static Delegate cb_getAppUserIdentifier;
#pragma warning disable 0169
		static Delegate GetGetAppUserIdentifierHandler ()
		{
			if (cb_getAppUserIdentifier == null)
				cb_getAppUserIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppUserIdentifier);
			return cb_getAppUserIdentifier;
		}

		static IntPtr n_GetAppUserIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppUserIdentifier);
		}
#pragma warning restore 0169

		static Delegate cb_setAppUserIdentifier_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppUserIdentifier_Ljava_lang_String_Handler ()
		{
			if (cb_setAppUserIdentifier_Ljava_lang_String_ == null)
				cb_setAppUserIdentifier_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppUserIdentifier_Ljava_lang_String_);
			return cb_setAppUserIdentifier_Ljava_lang_String_;
		}

		static void n_SetAppUserIdentifier_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AppUserIdentifier = value;
		}
#pragma warning restore 0169

		static IntPtr id_getAppUserIdentifier;
		static IntPtr id_setAppUserIdentifier_Ljava_lang_String_;
		public virtual unsafe string AppUserIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getAppUserIdentifier' and count(parameter)=0]"
			[Register ("getAppUserIdentifier", "()Ljava/lang/String;", "GetGetAppUserIdentifierHandler")]
			get {
				if (id_getAppUserIdentifier == IntPtr.Zero)
					id_getAppUserIdentifier = JNIEnv.GetMethodID (class_ref, "getAppUserIdentifier", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppUserIdentifier), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppUserIdentifier", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setAppUserIdentifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppUserIdentifier", "(Ljava/lang/String;)V", "GetSetAppUserIdentifier_Ljava_lang_String_Handler")]
			set {
				if (id_setAppUserIdentifier_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppUserIdentifier_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppUserIdentifier", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppUserIdentifier_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppUserIdentifier", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBatteryLevel;
#pragma warning disable 0169
		static Delegate GetGetBatteryLevelHandler ()
		{
			if (cb_getBatteryLevel == null)
				cb_getBatteryLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBatteryLevel);
			return cb_getBatteryLevel;
		}

		static IntPtr n_GetBatteryLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BatteryLevel);
		}
#pragma warning restore 0169

		static Delegate cb_setBatteryLevel_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetBatteryLevel_Ljava_lang_Integer_Handler ()
		{
			if (cb_setBatteryLevel_Ljava_lang_Integer_ == null)
				cb_setBatteryLevel_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBatteryLevel_Ljava_lang_Integer_);
			return cb_setBatteryLevel_Ljava_lang_Integer_;
		}

		static void n_SetBatteryLevel_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.BatteryLevel = value;
		}
#pragma warning restore 0169

		static IntPtr id_getBatteryLevel;
		static IntPtr id_setBatteryLevel_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer BatteryLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getBatteryLevel' and count(parameter)=0]"
			[Register ("getBatteryLevel", "()Ljava/lang/Integer;", "GetGetBatteryLevelHandler")]
			get {
				if (id_getBatteryLevel == IntPtr.Zero)
					id_getBatteryLevel = JNIEnv.GetMethodID (class_ref, "getBatteryLevel", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBatteryLevel), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBatteryLevel", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setBatteryLevel' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setBatteryLevel", "(Ljava/lang/Integer;)V", "GetSetBatteryLevel_Ljava_lang_Integer_Handler")]
			set {
				if (id_setBatteryLevel_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setBatteryLevel_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setBatteryLevel", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBatteryLevel_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBatteryLevel", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBeaconModeID;
#pragma warning disable 0169
		static Delegate GetGetBeaconModeIDHandler ()
		{
			if (cb_getBeaconModeID == null)
				cb_getBeaconModeID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeaconModeID);
			return cb_getBeaconModeID;
		}

		static IntPtr n_GetBeaconModeID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BeaconModeID);
		}
#pragma warning restore 0169

		static Delegate cb_setBeaconModeID_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetBeaconModeID_Ljava_lang_Integer_Handler ()
		{
			if (cb_setBeaconModeID_Ljava_lang_Integer_ == null)
				cb_setBeaconModeID_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBeaconModeID_Ljava_lang_Integer_);
			return cb_setBeaconModeID_Ljava_lang_Integer_;
		}

		static void n_SetBeaconModeID_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.BeaconModeID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconModeID;
		static IntPtr id_setBeaconModeID_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer BeaconModeID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getBeaconModeID' and count(parameter)=0]"
			[Register ("getBeaconModeID", "()Ljava/lang/Integer;", "GetGetBeaconModeIDHandler")]
			get {
				if (id_getBeaconModeID == IntPtr.Zero)
					id_getBeaconModeID = JNIEnv.GetMethodID (class_ref, "getBeaconModeID", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconModeID), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeaconModeID", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setBeaconModeID' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setBeaconModeID", "(Ljava/lang/Integer;)V", "GetSetBeaconModeID_Ljava_lang_Integer_Handler")]
			set {
				if (id_setBeaconModeID_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setBeaconModeID_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setBeaconModeID", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeaconModeID_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBeaconModeID", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBeaconVisitID;
#pragma warning disable 0169
		static Delegate GetGetBeaconVisitIDHandler ()
		{
			if (cb_getBeaconVisitID == null)
				cb_getBeaconVisitID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeaconVisitID);
			return cb_getBeaconVisitID;
		}

		static IntPtr n_GetBeaconVisitID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BeaconVisitID);
		}
#pragma warning restore 0169

		static Delegate cb_setBeaconVisitID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBeaconVisitID_Ljava_lang_String_Handler ()
		{
			if (cb_setBeaconVisitID_Ljava_lang_String_ == null)
				cb_setBeaconVisitID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBeaconVisitID_Ljava_lang_String_);
			return cb_setBeaconVisitID_Ljava_lang_String_;
		}

		static void n_SetBeaconVisitID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.BeaconVisitID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconVisitID;
		static IntPtr id_setBeaconVisitID_Ljava_lang_String_;
		public virtual unsafe string BeaconVisitID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getBeaconVisitID' and count(parameter)=0]"
			[Register ("getBeaconVisitID", "()Ljava/lang/String;", "GetGetBeaconVisitIDHandler")]
			get {
				if (id_getBeaconVisitID == IntPtr.Zero)
					id_getBeaconVisitID = JNIEnv.GetMethodID (class_ref, "getBeaconVisitID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconVisitID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeaconVisitID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setBeaconVisitID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBeaconVisitID", "(Ljava/lang/String;)V", "GetSetBeaconVisitID_Ljava_lang_String_Handler")]
			set {
				if (id_setBeaconVisitID_Ljava_lang_String_ == IntPtr.Zero)
					id_setBeaconVisitID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBeaconVisitID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeaconVisitID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBeaconVisitID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBeganAt;
#pragma warning disable 0169
		static Delegate GetGetBeganAtHandler ()
		{
			if (cb_getBeganAt == null)
				cb_getBeganAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeganAt);
			return cb_getBeganAt;
		}

		static IntPtr n_GetBeganAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BeganAt);
		}
#pragma warning restore 0169

		static Delegate cb_setBeganAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetBeganAt_Ljava_util_Date_Handler ()
		{
			if (cb_setBeganAt_Ljava_util_Date_ == null)
				cb_setBeganAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBeganAt_Ljava_util_Date_);
			return cb_setBeganAt_Ljava_util_Date_;
		}

		static void n_SetBeganAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.BeganAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getBeganAt;
		static IntPtr id_setBeganAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date BeganAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getBeganAt' and count(parameter)=0]"
			[Register ("getBeganAt", "()Ljava/util/Date;", "GetGetBeganAtHandler")]
			get {
				if (id_getBeganAt == IntPtr.Zero)
					id_getBeganAt = JNIEnv.GetMethodID (class_ref, "getBeganAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeganAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeganAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setBeganAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setBeganAt", "(Ljava/util/Date;)V", "GetSetBeganAt_Ljava_util_Date_Handler")]
			set {
				if (id_setBeganAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setBeganAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setBeganAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeganAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBeganAt", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBeganInBackground;
#pragma warning disable 0169
		static Delegate GetGetBeganInBackgroundHandler ()
		{
			if (cb_getBeganInBackground == null)
				cb_getBeganInBackground = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetBeganInBackground);
			return cb_getBeganInBackground;
		}

		static bool n_GetBeganInBackground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BeganInBackground;
		}
#pragma warning restore 0169

		static Delegate cb_setBeganInBackground_Z;
#pragma warning disable 0169
		static Delegate GetSetBeganInBackground_ZHandler ()
		{
			if (cb_setBeganInBackground_Z == null)
				cb_setBeganInBackground_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetBeganInBackground_Z);
			return cb_setBeganInBackground_Z;
		}

		static void n_SetBeganInBackground_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BeganInBackground = value;
		}
#pragma warning restore 0169

		static IntPtr id_getBeganInBackground;
		static IntPtr id_setBeganInBackground_Z;
		public virtual unsafe bool BeganInBackground {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getBeganInBackground' and count(parameter)=0]"
			[Register ("getBeganInBackground", "()Z", "GetGetBeganInBackgroundHandler")]
			get {
				if (id_getBeganInBackground == IntPtr.Zero)
					id_getBeganInBackground = JNIEnv.GetMethodID (class_ref, "getBeganInBackground", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getBeganInBackground);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeganInBackground", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setBeganInBackground' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setBeganInBackground", "(Z)V", "GetSetBeganInBackground_ZHandler")]
			set {
				if (id_setBeganInBackground_Z == IntPtr.Zero)
					id_setBeganInBackground_Z = JNIEnv.GetMethodID (class_ref, "setBeganInBackground", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeganInBackground_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBeganInBackground", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBluetoothAddress;
#pragma warning disable 0169
		static Delegate GetGetBluetoothAddressHandler ()
		{
			if (cb_getBluetoothAddress == null)
				cb_getBluetoothAddress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBluetoothAddress);
			return cb_getBluetoothAddress;
		}

		static IntPtr n_GetBluetoothAddress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BluetoothAddress);
		}
#pragma warning restore 0169

		static Delegate cb_setBluetoothAddress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBluetoothAddress_Ljava_lang_String_Handler ()
		{
			if (cb_setBluetoothAddress_Ljava_lang_String_ == null)
				cb_setBluetoothAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBluetoothAddress_Ljava_lang_String_);
			return cb_setBluetoothAddress_Ljava_lang_String_;
		}

		static void n_SetBluetoothAddress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.BluetoothAddress = value;
		}
#pragma warning restore 0169

		static IntPtr id_getBluetoothAddress;
		static IntPtr id_setBluetoothAddress_Ljava_lang_String_;
		public virtual unsafe string BluetoothAddress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getBluetoothAddress' and count(parameter)=0]"
			[Register ("getBluetoothAddress", "()Ljava/lang/String;", "GetGetBluetoothAddressHandler")]
			get {
				if (id_getBluetoothAddress == IntPtr.Zero)
					id_getBluetoothAddress = JNIEnv.GetMethodID (class_ref, "getBluetoothAddress", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBluetoothAddress), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBluetoothAddress", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setBluetoothAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBluetoothAddress", "(Ljava/lang/String;)V", "GetSetBluetoothAddress_Ljava_lang_String_Handler")]
			set {
				if (id_setBluetoothAddress_Ljava_lang_String_ == IntPtr.Zero)
					id_setBluetoothAddress_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBluetoothAddress", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBluetoothAddress_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBluetoothAddress", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCDist;
#pragma warning disable 0169
		static Delegate GetGetCDistHandler ()
		{
			if (cb_getCDist == null)
				cb_getCDist = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCDist);
			return cb_getCDist;
		}

		static IntPtr n_GetCDist (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CDist);
		}
#pragma warning restore 0169

		static Delegate cb_setCDist_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetCDist_Ljava_lang_Double_Handler ()
		{
			if (cb_setCDist_Ljava_lang_Double_ == null)
				cb_setCDist_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCDist_Ljava_lang_Double_);
			return cb_setCDist_Ljava_lang_Double_;
		}

		static void n_SetCDist_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double value = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.CDist = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCDist;
		static IntPtr id_setCDist_Ljava_lang_Double_;
		public virtual unsafe global::Java.Lang.Double CDist {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getCDist' and count(parameter)=0]"
			[Register ("getCDist", "()Ljava/lang/Double;", "GetGetCDistHandler")]
			get {
				if (id_getCDist == IntPtr.Zero)
					id_getCDist = JNIEnv.GetMethodID (class_ref, "getCDist", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCDist), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCDist", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setCDist' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setCDist", "(Ljava/lang/Double;)V", "GetSetCDist_Ljava_lang_Double_Handler")]
			set {
				if (id_setCDist_Ljava_lang_Double_ == IntPtr.Zero)
					id_setCDist_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setCDist", "(Ljava/lang/Double;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCDist_Ljava_lang_Double_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCDist", "(Ljava/lang/Double;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCProx;
#pragma warning disable 0169
		static Delegate GetGetCProxHandler ()
		{
			if (cb_getCProx == null)
				cb_getCProx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCProx);
			return cb_getCProx;
		}

		static IntPtr n_GetCProx (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CProx);
		}
#pragma warning restore 0169

		static Delegate cb_setCProx_Lcom_bluecats_sdk_BCBeacon_BCProximity_;
#pragma warning disable 0169
		static Delegate GetSetCProx_Lcom_bluecats_sdk_BCBeacon_BCProximity_Handler ()
		{
			if (cb_setCProx_Lcom_bluecats_sdk_BCBeacon_BCProximity_ == null)
				cb_setCProx_Lcom_bluecats_sdk_BCBeacon_BCProximity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCProx_Lcom_bluecats_sdk_BCBeacon_BCProximity_);
			return cb_setCProx_Lcom_bluecats_sdk_BCBeacon_BCProximity_;
		}

		static void n_SetCProx_Lcom_bluecats_sdk_BCBeacon_BCProximity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cProx)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconBCProximity cProx = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCProximity> (native_cProx, JniHandleOwnership.DoNotTransfer);
			__this.CProx = cProx;
		}
#pragma warning restore 0169

		static IntPtr id_getCProx;
		static IntPtr id_setCProx_Lcom_bluecats_sdk_BCBeacon_BCProximity_;
		public virtual unsafe global::Com.Bluecats.Sdk.BCBeaconBCProximity CProx {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getCProx' and count(parameter)=0]"
			[Register ("getCProx", "()Lcom/bluecats/sdk/BCBeacon$BCProximity;", "GetGetCProxHandler")]
			get {
				if (id_getCProx == IntPtr.Zero)
					id_getCProx = JNIEnv.GetMethodID (class_ref, "getCProx", "()Lcom/bluecats/sdk/BCBeacon$BCProximity;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCProximity> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCProx), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCProximity> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCProx", "()Lcom/bluecats/sdk/BCBeacon$BCProximity;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setCProx' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeacon.BCProximity']]"
			[Register ("setCProx", "(Lcom/bluecats/sdk/BCBeacon$BCProximity;)V", "GetSetCProx_Lcom_bluecats_sdk_BCBeacon_BCProximity_Handler")]
			set {
				if (id_setCProx_Lcom_bluecats_sdk_BCBeacon_BCProximity_ == IntPtr.Zero)
					id_setCProx_Lcom_bluecats_sdk_BCBeacon_BCProximity_ = JNIEnv.GetMethodID (class_ref, "setCProx", "(Lcom/bluecats/sdk/BCBeacon$BCProximity;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCProx_Lcom_bluecats_sdk_BCBeacon_BCProximity_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCProx", "(Lcom/bluecats/sdk/BCBeacon$BCProximity;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCProxID;
#pragma warning disable 0169
		static Delegate GetGetCProxIDHandler ()
		{
			if (cb_getCProxID == null)
				cb_getCProxID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCProxID);
			return cb_getCProxID;
		}

		static IntPtr n_GetCProxID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CProxID);
		}
#pragma warning restore 0169

		static Delegate cb_setCProxID_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetCProxID_Ljava_lang_Integer_Handler ()
		{
			if (cb_setCProxID_Ljava_lang_Integer_ == null)
				cb_setCProxID_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCProxID_Ljava_lang_Integer_);
			return cb_setCProxID_Ljava_lang_Integer_;
		}

		static void n_SetCProxID_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.CProxID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCProxID;
		static IntPtr id_setCProxID_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer CProxID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getCProxID' and count(parameter)=0]"
			[Register ("getCProxID", "()Ljava/lang/Integer;", "GetGetCProxIDHandler")]
			get {
				if (id_getCProxID == IntPtr.Zero)
					id_getCProxID = JNIEnv.GetMethodID (class_ref, "getCProxID", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCProxID), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCProxID", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setCProxID' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setCProxID", "(Ljava/lang/Integer;)V", "GetSetCProxID_Ljava_lang_Integer_Handler")]
			set {
				if (id_setCProxID_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setCProxID_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setCProxID", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCProxID_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCProxID", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceUUID;
#pragma warning disable 0169
		static Delegate GetGetDeviceUUIDHandler ()
		{
			if (cb_getDeviceUUID == null)
				cb_getDeviceUUID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceUUID);
			return cb_getDeviceUUID;
		}

		static IntPtr n_GetDeviceUUID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceUUID);
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceUUID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceUUID_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceUUID_Ljava_lang_String_ == null)
				cb_setDeviceUUID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDeviceUUID_Ljava_lang_String_);
			return cb_setDeviceUUID_Ljava_lang_String_;
		}

		static void n_SetDeviceUUID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.DeviceUUID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceUUID;
		static IntPtr id_setDeviceUUID_Ljava_lang_String_;
		public virtual unsafe string DeviceUUID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getDeviceUUID' and count(parameter)=0]"
			[Register ("getDeviceUUID", "()Ljava/lang/String;", "GetGetDeviceUUIDHandler")]
			get {
				if (id_getDeviceUUID == IntPtr.Zero)
					id_getDeviceUUID = JNIEnv.GetMethodID (class_ref, "getDeviceUUID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceUUID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceUUID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setDeviceUUID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceUUID", "(Ljava/lang/String;)V", "GetSetDeviceUUID_Ljava_lang_String_Handler")]
			set {
				if (id_setDeviceUUID_Ljava_lang_String_ == IntPtr.Zero)
					id_setDeviceUUID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDeviceUUID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDeviceUUID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeviceUUID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDeviceWasClosestAt;
#pragma warning disable 0169
		static Delegate GetGetDeviceWasClosestAtHandler ()
		{
			if (cb_getDeviceWasClosestAt == null)
				cb_getDeviceWasClosestAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceWasClosestAt);
			return cb_getDeviceWasClosestAt;
		}

		static IntPtr n_GetDeviceWasClosestAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeviceWasClosestAt);
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceWasClosestAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetDeviceWasClosestAt_Ljava_util_Date_Handler ()
		{
			if (cb_setDeviceWasClosestAt_Ljava_util_Date_ == null)
				cb_setDeviceWasClosestAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDeviceWasClosestAt_Ljava_util_Date_);
			return cb_setDeviceWasClosestAt_Ljava_util_Date_;
		}

		static void n_SetDeviceWasClosestAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.DeviceWasClosestAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceWasClosestAt;
		static IntPtr id_setDeviceWasClosestAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date DeviceWasClosestAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getDeviceWasClosestAt' and count(parameter)=0]"
			[Register ("getDeviceWasClosestAt", "()Ljava/util/Date;", "GetGetDeviceWasClosestAtHandler")]
			get {
				if (id_getDeviceWasClosestAt == IntPtr.Zero)
					id_getDeviceWasClosestAt = JNIEnv.GetMethodID (class_ref, "getDeviceWasClosestAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceWasClosestAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceWasClosestAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setDeviceWasClosestAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setDeviceWasClosestAt", "(Ljava/util/Date;)V", "GetSetDeviceWasClosestAt_Ljava_util_Date_Handler")]
			set {
				if (id_setDeviceWasClosestAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setDeviceWasClosestAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setDeviceWasClosestAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDeviceWasClosestAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeviceWasClosestAt", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEndedAt;
#pragma warning disable 0169
		static Delegate GetGetEndedAtHandler ()
		{
			if (cb_getEndedAt == null)
				cb_getEndedAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndedAt);
			return cb_getEndedAt;
		}

		static IntPtr n_GetEndedAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EndedAt);
		}
#pragma warning restore 0169

		static Delegate cb_setEndedAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetEndedAt_Ljava_util_Date_Handler ()
		{
			if (cb_setEndedAt_Ljava_util_Date_ == null)
				cb_setEndedAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEndedAt_Ljava_util_Date_);
			return cb_setEndedAt_Ljava_util_Date_;
		}

		static void n_SetEndedAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.EndedAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getEndedAt;
		static IntPtr id_setEndedAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date EndedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getEndedAt' and count(parameter)=0]"
			[Register ("getEndedAt", "()Ljava/util/Date;", "GetGetEndedAtHandler")]
			get {
				if (id_getEndedAt == IntPtr.Zero)
					id_getEndedAt = JNIEnv.GetMethodID (class_ref, "getEndedAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEndedAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEndedAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setEndedAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setEndedAt", "(Ljava/util/Date;)V", "GetSetEndedAt_Ljava_util_Date_Handler")]
			set {
				if (id_setEndedAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setEndedAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setEndedAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEndedAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEndedAt", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEndedInBackground;
#pragma warning disable 0169
		static Delegate GetGetEndedInBackgroundHandler ()
		{
			if (cb_getEndedInBackground == null)
				cb_getEndedInBackground = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetEndedInBackground);
			return cb_getEndedInBackground;
		}

		static bool n_GetEndedInBackground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EndedInBackground;
		}
#pragma warning restore 0169

		static Delegate cb_setEndedInBackground_Z;
#pragma warning disable 0169
		static Delegate GetSetEndedInBackground_ZHandler ()
		{
			if (cb_setEndedInBackground_Z == null)
				cb_setEndedInBackground_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEndedInBackground_Z);
			return cb_setEndedInBackground_Z;
		}

		static void n_SetEndedInBackground_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndedInBackground = value;
		}
#pragma warning restore 0169

		static IntPtr id_getEndedInBackground;
		static IntPtr id_setEndedInBackground_Z;
		public virtual unsafe bool EndedInBackground {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getEndedInBackground' and count(parameter)=0]"
			[Register ("getEndedInBackground", "()Z", "GetGetEndedInBackgroundHandler")]
			get {
				if (id_getEndedInBackground == IntPtr.Zero)
					id_getEndedInBackground = JNIEnv.GetMethodID (class_ref, "getEndedInBackground", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getEndedInBackground);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEndedInBackground", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setEndedInBackground' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEndedInBackground", "(Z)V", "GetSetEndedInBackground_ZHandler")]
			set {
				if (id_setEndedInBackground_Z == IntPtr.Zero)
					id_setEndedInBackground_Z = JNIEnv.GetMethodID (class_ref, "setEndedInBackground", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEndedInBackground_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEndedInBackground", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEnteredCProxAt;
#pragma warning disable 0169
		static Delegate GetGetEnteredCProxAtHandler ()
		{
			if (cb_getEnteredCProxAt == null)
				cb_getEnteredCProxAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEnteredCProxAt);
			return cb_getEnteredCProxAt;
		}

		static IntPtr n_GetEnteredCProxAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EnteredCProxAt);
		}
#pragma warning restore 0169

		static Delegate cb_setEnteredCProxAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetEnteredCProxAt_Ljava_util_Date_Handler ()
		{
			if (cb_setEnteredCProxAt_Ljava_util_Date_ == null)
				cb_setEnteredCProxAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEnteredCProxAt_Ljava_util_Date_);
			return cb_setEnteredCProxAt_Ljava_util_Date_;
		}

		static void n_SetEnteredCProxAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.EnteredCProxAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getEnteredCProxAt;
		static IntPtr id_setEnteredCProxAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date EnteredCProxAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getEnteredCProxAt' and count(parameter)=0]"
			[Register ("getEnteredCProxAt", "()Ljava/util/Date;", "GetGetEnteredCProxAtHandler")]
			get {
				if (id_getEnteredCProxAt == IntPtr.Zero)
					id_getEnteredCProxAt = JNIEnv.GetMethodID (class_ref, "getEnteredCProxAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEnteredCProxAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEnteredCProxAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setEnteredCProxAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setEnteredCProxAt", "(Ljava/util/Date;)V", "GetSetEnteredCProxAt_Ljava_util_Date_Handler")]
			set {
				if (id_setEnteredCProxAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setEnteredCProxAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setEnteredCProxAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEnteredCProxAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnteredCProxAt", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getExitedCProxAt;
#pragma warning disable 0169
		static Delegate GetGetExitedCProxAtHandler ()
		{
			if (cb_getExitedCProxAt == null)
				cb_getExitedCProxAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExitedCProxAt);
			return cb_getExitedCProxAt;
		}

		static IntPtr n_GetExitedCProxAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExitedCProxAt);
		}
#pragma warning restore 0169

		static Delegate cb_setExitedCProxAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetExitedCProxAt_Ljava_util_Date_Handler ()
		{
			if (cb_setExitedCProxAt_Ljava_util_Date_ == null)
				cb_setExitedCProxAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExitedCProxAt_Ljava_util_Date_);
			return cb_setExitedCProxAt_Ljava_util_Date_;
		}

		static void n_SetExitedCProxAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.ExitedCProxAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getExitedCProxAt;
		static IntPtr id_setExitedCProxAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date ExitedCProxAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getExitedCProxAt' and count(parameter)=0]"
			[Register ("getExitedCProxAt", "()Ljava/util/Date;", "GetGetExitedCProxAtHandler")]
			get {
				if (id_getExitedCProxAt == IntPtr.Zero)
					id_getExitedCProxAt = JNIEnv.GetMethodID (class_ref, "getExitedCProxAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExitedCProxAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExitedCProxAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setExitedCProxAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setExitedCProxAt", "(Ljava/util/Date;)V", "GetSetExitedCProxAt_Ljava_util_Date_Handler")]
			set {
				if (id_setExitedCProxAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setExitedCProxAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setExitedCProxAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExitedCProxAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExitedCProxAt", "(Ljava/util/Date;)V"), __args);
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
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetFirmwareVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.FirmwareVersion = value;
		}
#pragma warning restore 0169

		static IntPtr id_getFirmwareVersion;
		static IntPtr id_setFirmwareVersion_Ljava_lang_String_;
		public virtual unsafe string FirmwareVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getFirmwareVersion' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setFirmwareVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_isCurrentlyVisiting;
#pragma warning disable 0169
		static Delegate GetIsCurrentlyVisitingHandler ()
		{
			if (cb_isCurrentlyVisiting == null)
				cb_isCurrentlyVisiting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCurrentlyVisiting);
			return cb_isCurrentlyVisiting;
		}

		static bool n_IsCurrentlyVisiting (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCurrentlyVisiting;
		}
#pragma warning restore 0169

		static Delegate cb_setIsCurrentlyVisiting_Z;
#pragma warning disable 0169
		static Delegate GetSetIsCurrentlyVisiting_ZHandler ()
		{
			if (cb_setIsCurrentlyVisiting_Z == null)
				cb_setIsCurrentlyVisiting_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsCurrentlyVisiting_Z);
			return cb_setIsCurrentlyVisiting_Z;
		}

		static void n_SetIsCurrentlyVisiting_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IsCurrentlyVisiting = value;
		}
#pragma warning restore 0169

		static IntPtr id_isCurrentlyVisiting;
		static IntPtr id_setIsCurrentlyVisiting_Z;
		public virtual unsafe bool IsCurrentlyVisiting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='isCurrentlyVisiting' and count(parameter)=0]"
			[Register ("isCurrentlyVisiting", "()Z", "GetIsCurrentlyVisitingHandler")]
			get {
				if (id_isCurrentlyVisiting == IntPtr.Zero)
					id_isCurrentlyVisiting = JNIEnv.GetMethodID (class_ref, "isCurrentlyVisiting", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCurrentlyVisiting);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCurrentlyVisiting", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setIsCurrentlyVisiting' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsCurrentlyVisiting", "(Z)V", "GetSetIsCurrentlyVisiting_ZHandler")]
			set {
				if (id_setIsCurrentlyVisiting_Z == IntPtr.Zero)
					id_setIsCurrentlyVisiting_Z = JNIEnv.GetMethodID (class_ref, "setIsCurrentlyVisiting", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIsCurrentlyVisiting_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsCurrentlyVisiting", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLastPostedAt;
#pragma warning disable 0169
		static Delegate GetGetLastPostedAtHandler ()
		{
			if (cb_getLastPostedAt == null)
				cb_getLastPostedAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastPostedAt);
			return cb_getLastPostedAt;
		}

		static IntPtr n_GetLastPostedAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastPostedAt);
		}
#pragma warning restore 0169

		static Delegate cb_setLastPostedAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetLastPostedAt_Ljava_util_Date_Handler ()
		{
			if (cb_setLastPostedAt_Ljava_util_Date_ == null)
				cb_setLastPostedAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLastPostedAt_Ljava_util_Date_);
			return cb_setLastPostedAt_Ljava_util_Date_;
		}

		static void n_SetLastPostedAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.LastPostedAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getLastPostedAt;
		static IntPtr id_setLastPostedAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date LastPostedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getLastPostedAt' and count(parameter)=0]"
			[Register ("getLastPostedAt", "()Ljava/util/Date;", "GetGetLastPostedAtHandler")]
			get {
				if (id_getLastPostedAt == IntPtr.Zero)
					id_getLastPostedAt = JNIEnv.GetMethodID (class_ref, "getLastPostedAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastPostedAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastPostedAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setLastPostedAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setLastPostedAt", "(Ljava/util/Date;)V", "GetSetLastPostedAt_Ljava_util_Date_Handler")]
			set {
				if (id_setLastPostedAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setLastPostedAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setLastPostedAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastPostedAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastPostedAt", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLastRangedAt;
#pragma warning disable 0169
		static Delegate GetGetLastRangedAtHandler ()
		{
			if (cb_getLastRangedAt == null)
				cb_getLastRangedAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastRangedAt);
			return cb_getLastRangedAt;
		}

		static IntPtr n_GetLastRangedAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastRangedAt);
		}
#pragma warning restore 0169

		static Delegate cb_setLastRangedAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetLastRangedAt_Ljava_util_Date_Handler ()
		{
			if (cb_setLastRangedAt_Ljava_util_Date_ == null)
				cb_setLastRangedAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLastRangedAt_Ljava_util_Date_);
			return cb_setLastRangedAt_Ljava_util_Date_;
		}

		static void n_SetLastRangedAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.LastRangedAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getLastRangedAt;
		static IntPtr id_setLastRangedAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date LastRangedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getLastRangedAt' and count(parameter)=0]"
			[Register ("getLastRangedAt", "()Ljava/util/Date;", "GetGetLastRangedAtHandler")]
			get {
				if (id_getLastRangedAt == IntPtr.Zero)
					id_getLastRangedAt = JNIEnv.GetMethodID (class_ref, "getLastRangedAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastRangedAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastRangedAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setLastRangedAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setLastRangedAt", "(Ljava/util/Date;)V", "GetSetLastRangedAt_Ljava_util_Date_Handler")]
			set {
				if (id_setLastRangedAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setLastRangedAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setLastRangedAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastRangedAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastRangedAt", "(Ljava/util/Date;)V"), __args);
				} finally {
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
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Latitude = value;
		}
#pragma warning restore 0169

		static IntPtr id_getLatitude;
		static IntPtr id_setLatitude_D;
		public virtual unsafe double Latitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getLatitude' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setLatitude' and count(parameter)=1 and parameter[1][@type='double']]"
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
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Longitude = value;
		}
#pragma warning restore 0169

		static IntPtr id_getLongitude;
		static IntPtr id_setLongitude_D;
		public virtual unsafe double Longitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getLongitude' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setLongitude' and count(parameter)=1 and parameter[1][@type='double']]"
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
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetMajor_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Major = value;
		}
#pragma warning restore 0169

		static IntPtr id_getMajor;
		static IntPtr id_setMajor_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Major {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getMajor' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setMajor' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
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
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetMinor_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Minor = value;
		}
#pragma warning restore 0169

		static IntPtr id_getMinor;
		static IntPtr id_setMinor_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Minor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getMinor' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setMinor' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
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

		static Delegate cb_getProximityUUIDString;
#pragma warning disable 0169
		static Delegate GetGetProximityUUIDStringHandler ()
		{
			if (cb_getProximityUUIDString == null)
				cb_getProximityUUIDString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProximityUUIDString);
			return cb_getProximityUUIDString;
		}

		static IntPtr n_GetProximityUUIDString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProximityUUIDString);
		}
#pragma warning restore 0169

		static Delegate cb_setProximityUUIDString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProximityUUIDString_Ljava_lang_String_Handler ()
		{
			if (cb_setProximityUUIDString_Ljava_lang_String_ == null)
				cb_setProximityUUIDString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProximityUUIDString_Ljava_lang_String_);
			return cb_setProximityUUIDString_Ljava_lang_String_;
		}

		static void n_SetProximityUUIDString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.ProximityUUIDString = value;
		}
#pragma warning restore 0169

		static IntPtr id_getProximityUUIDString;
		static IntPtr id_setProximityUUIDString_Ljava_lang_String_;
		public virtual unsafe string ProximityUUIDString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getProximityUUIDString' and count(parameter)=0]"
			[Register ("getProximityUUIDString", "()Ljava/lang/String;", "GetGetProximityUUIDStringHandler")]
			get {
				if (id_getProximityUUIDString == IntPtr.Zero)
					id_getProximityUUIDString = JNIEnv.GetMethodID (class_ref, "getProximityUUIDString", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProximityUUIDString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProximityUUIDString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setProximityUUIDString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProximityUUIDString", "(Ljava/lang/String;)V", "GetSetProximityUUIDString_Ljava_lang_String_Handler")]
			set {
				if (id_setProximityUUIDString_Ljava_lang_String_ == IntPtr.Zero)
					id_setProximityUUIDString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setProximityUUIDString", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setProximityUUIDString_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProximityUUIDString", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRSSIWhenCProxEntered;
#pragma warning disable 0169
		static Delegate GetGetRSSIWhenCProxEnteredHandler ()
		{
			if (cb_getRSSIWhenCProxEntered == null)
				cb_getRSSIWhenCProxEntered = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRSSIWhenCProxEntered);
			return cb_getRSSIWhenCProxEntered;
		}

		static IntPtr n_GetRSSIWhenCProxEntered (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RSSIWhenCProxEntered);
		}
#pragma warning restore 0169

		static Delegate cb_setRSSIWhenCProxEntered_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetRSSIWhenCProxEntered_Ljava_lang_Integer_Handler ()
		{
			if (cb_setRSSIWhenCProxEntered_Ljava_lang_Integer_ == null)
				cb_setRSSIWhenCProxEntered_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRSSIWhenCProxEntered_Ljava_lang_Integer_);
			return cb_setRSSIWhenCProxEntered_Ljava_lang_Integer_;
		}

		static void n_SetRSSIWhenCProxEntered_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.RSSIWhenCProxEntered = value;
		}
#pragma warning restore 0169

		static IntPtr id_getRSSIWhenCProxEntered;
		static IntPtr id_setRSSIWhenCProxEntered_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer RSSIWhenCProxEntered {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getRSSIWhenCProxEntered' and count(parameter)=0]"
			[Register ("getRSSIWhenCProxEntered", "()Ljava/lang/Integer;", "GetGetRSSIWhenCProxEnteredHandler")]
			get {
				if (id_getRSSIWhenCProxEntered == IntPtr.Zero)
					id_getRSSIWhenCProxEntered = JNIEnv.GetMethodID (class_ref, "getRSSIWhenCProxEntered", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRSSIWhenCProxEntered), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRSSIWhenCProxEntered", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setRSSIWhenCProxEntered' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setRSSIWhenCProxEntered", "(Ljava/lang/Integer;)V", "GetSetRSSIWhenCProxEntered_Ljava_lang_Integer_Handler")]
			set {
				if (id_setRSSIWhenCProxEntered_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setRSSIWhenCProxEntered_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setRSSIWhenCProxEntered", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRSSIWhenCProxEntered_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRSSIWhenCProxEntered", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRSSIWhenCProxExited;
#pragma warning disable 0169
		static Delegate GetGetRSSIWhenCProxExitedHandler ()
		{
			if (cb_getRSSIWhenCProxExited == null)
				cb_getRSSIWhenCProxExited = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRSSIWhenCProxExited);
			return cb_getRSSIWhenCProxExited;
		}

		static IntPtr n_GetRSSIWhenCProxExited (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RSSIWhenCProxExited);
		}
#pragma warning restore 0169

		static Delegate cb_setRSSIWhenCProxExited_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetRSSIWhenCProxExited_Ljava_lang_Integer_Handler ()
		{
			if (cb_setRSSIWhenCProxExited_Ljava_lang_Integer_ == null)
				cb_setRSSIWhenCProxExited_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRSSIWhenCProxExited_Ljava_lang_Integer_);
			return cb_setRSSIWhenCProxExited_Ljava_lang_Integer_;
		}

		static void n_SetRSSIWhenCProxExited_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.RSSIWhenCProxExited = value;
		}
#pragma warning restore 0169

		static IntPtr id_getRSSIWhenCProxExited;
		static IntPtr id_setRSSIWhenCProxExited_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer RSSIWhenCProxExited {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getRSSIWhenCProxExited' and count(parameter)=0]"
			[Register ("getRSSIWhenCProxExited", "()Ljava/lang/Integer;", "GetGetRSSIWhenCProxExitedHandler")]
			get {
				if (id_getRSSIWhenCProxExited == IntPtr.Zero)
					id_getRSSIWhenCProxExited = JNIEnv.GetMethodID (class_ref, "getRSSIWhenCProxExited", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRSSIWhenCProxExited), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRSSIWhenCProxExited", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setRSSIWhenCProxExited' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setRSSIWhenCProxExited", "(Ljava/lang/Integer;)V", "GetSetRSSIWhenCProxExited_Ljava_lang_Integer_Handler")]
			set {
				if (id_setRSSIWhenCProxExited_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setRSSIWhenCProxExited_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setRSSIWhenCProxExited", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRSSIWhenCProxExited_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRSSIWhenCProxExited", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRSSIWhenDeviceWasClosest;
#pragma warning disable 0169
		static Delegate GetGetRSSIWhenDeviceWasClosestHandler ()
		{
			if (cb_getRSSIWhenDeviceWasClosest == null)
				cb_getRSSIWhenDeviceWasClosest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRSSIWhenDeviceWasClosest);
			return cb_getRSSIWhenDeviceWasClosest;
		}

		static IntPtr n_GetRSSIWhenDeviceWasClosest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RSSIWhenDeviceWasClosest);
		}
#pragma warning restore 0169

		static Delegate cb_setRSSIWhenDeviceWasClosest_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetRSSIWhenDeviceWasClosest_Ljava_lang_Integer_Handler ()
		{
			if (cb_setRSSIWhenDeviceWasClosest_Ljava_lang_Integer_ == null)
				cb_setRSSIWhenDeviceWasClosest_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRSSIWhenDeviceWasClosest_Ljava_lang_Integer_);
			return cb_setRSSIWhenDeviceWasClosest_Ljava_lang_Integer_;
		}

		static void n_SetRSSIWhenDeviceWasClosest_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.RSSIWhenDeviceWasClosest = value;
		}
#pragma warning restore 0169

		static IntPtr id_getRSSIWhenDeviceWasClosest;
		static IntPtr id_setRSSIWhenDeviceWasClosest_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer RSSIWhenDeviceWasClosest {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getRSSIWhenDeviceWasClosest' and count(parameter)=0]"
			[Register ("getRSSIWhenDeviceWasClosest", "()Ljava/lang/Integer;", "GetGetRSSIWhenDeviceWasClosestHandler")]
			get {
				if (id_getRSSIWhenDeviceWasClosest == IntPtr.Zero)
					id_getRSSIWhenDeviceWasClosest = JNIEnv.GetMethodID (class_ref, "getRSSIWhenDeviceWasClosest", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRSSIWhenDeviceWasClosest), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRSSIWhenDeviceWasClosest", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setRSSIWhenDeviceWasClosest' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setRSSIWhenDeviceWasClosest", "(Ljava/lang/Integer;)V", "GetSetRSSIWhenDeviceWasClosest_Ljava_lang_Integer_Handler")]
			set {
				if (id_setRSSIWhenDeviceWasClosest_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setRSSIWhenDeviceWasClosest_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setRSSIWhenDeviceWasClosest", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRSSIWhenDeviceWasClosest_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRSSIWhenDeviceWasClosest", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRSSIWhenVisitBegan;
#pragma warning disable 0169
		static Delegate GetGetRSSIWhenVisitBeganHandler ()
		{
			if (cb_getRSSIWhenVisitBegan == null)
				cb_getRSSIWhenVisitBegan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRSSIWhenVisitBegan);
			return cb_getRSSIWhenVisitBegan;
		}

		static IntPtr n_GetRSSIWhenVisitBegan (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RSSIWhenVisitBegan);
		}
#pragma warning restore 0169

		static Delegate cb_setRSSIWhenVisitBegan_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetRSSIWhenVisitBegan_Ljava_lang_Integer_Handler ()
		{
			if (cb_setRSSIWhenVisitBegan_Ljava_lang_Integer_ == null)
				cb_setRSSIWhenVisitBegan_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRSSIWhenVisitBegan_Ljava_lang_Integer_);
			return cb_setRSSIWhenVisitBegan_Ljava_lang_Integer_;
		}

		static void n_SetRSSIWhenVisitBegan_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.RSSIWhenVisitBegan = value;
		}
#pragma warning restore 0169

		static IntPtr id_getRSSIWhenVisitBegan;
		static IntPtr id_setRSSIWhenVisitBegan_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer RSSIWhenVisitBegan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getRSSIWhenVisitBegan' and count(parameter)=0]"
			[Register ("getRSSIWhenVisitBegan", "()Ljava/lang/Integer;", "GetGetRSSIWhenVisitBeganHandler")]
			get {
				if (id_getRSSIWhenVisitBegan == IntPtr.Zero)
					id_getRSSIWhenVisitBegan = JNIEnv.GetMethodID (class_ref, "getRSSIWhenVisitBegan", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRSSIWhenVisitBegan), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRSSIWhenVisitBegan", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setRSSIWhenVisitBegan' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setRSSIWhenVisitBegan", "(Ljava/lang/Integer;)V", "GetSetRSSIWhenVisitBegan_Ljava_lang_Integer_Handler")]
			set {
				if (id_setRSSIWhenVisitBegan_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setRSSIWhenVisitBegan_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setRSSIWhenVisitBegan", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRSSIWhenVisitBegan_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRSSIWhenVisitBegan", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRSSIWhenVisitEnded;
#pragma warning disable 0169
		static Delegate GetGetRSSIWhenVisitEndedHandler ()
		{
			if (cb_getRSSIWhenVisitEnded == null)
				cb_getRSSIWhenVisitEnded = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRSSIWhenVisitEnded);
			return cb_getRSSIWhenVisitEnded;
		}

		static IntPtr n_GetRSSIWhenVisitEnded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RSSIWhenVisitEnded);
		}
#pragma warning restore 0169

		static Delegate cb_setRSSIWhenVisitEnded_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetRSSIWhenVisitEnded_Ljava_lang_Integer_Handler ()
		{
			if (cb_setRSSIWhenVisitEnded_Ljava_lang_Integer_ == null)
				cb_setRSSIWhenVisitEnded_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRSSIWhenVisitEnded_Ljava_lang_Integer_);
			return cb_setRSSIWhenVisitEnded_Ljava_lang_Integer_;
		}

		static void n_SetRSSIWhenVisitEnded_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.RSSIWhenVisitEnded = value;
		}
#pragma warning restore 0169

		static IntPtr id_getRSSIWhenVisitEnded;
		static IntPtr id_setRSSIWhenVisitEnded_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer RSSIWhenVisitEnded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getRSSIWhenVisitEnded' and count(parameter)=0]"
			[Register ("getRSSIWhenVisitEnded", "()Ljava/lang/Integer;", "GetGetRSSIWhenVisitEndedHandler")]
			get {
				if (id_getRSSIWhenVisitEnded == IntPtr.Zero)
					id_getRSSIWhenVisitEnded = JNIEnv.GetMethodID (class_ref, "getRSSIWhenVisitEnded", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRSSIWhenVisitEnded), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRSSIWhenVisitEnded", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setRSSIWhenVisitEnded' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setRSSIWhenVisitEnded", "(Ljava/lang/Integer;)V", "GetSetRSSIWhenVisitEnded_Ljava_lang_Integer_Handler")]
			set {
				if (id_setRSSIWhenVisitEnded_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setRSSIWhenVisitEnded_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setRSSIWhenVisitEnded", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRSSIWhenVisitEnded_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRSSIWhenVisitEnded", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSDKVersion;
#pragma warning disable 0169
		static Delegate GetGetSDKVersionHandler ()
		{
			if (cb_getSDKVersion == null)
				cb_getSDKVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSDKVersion);
			return cb_getSDKVersion;
		}

		static IntPtr n_GetSDKVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SDKVersion);
		}
#pragma warning restore 0169

		static Delegate cb_setSDKVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSDKVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setSDKVersion_Ljava_lang_String_ == null)
				cb_setSDKVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSDKVersion_Ljava_lang_String_);
			return cb_setSDKVersion_Ljava_lang_String_;
		}

		static void n_SetSDKVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SDKVersion = value;
		}
#pragma warning restore 0169

		static IntPtr id_getSDKVersion;
		static IntPtr id_setSDKVersion_Ljava_lang_String_;
		public virtual unsafe string SDKVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getSDKVersion' and count(parameter)=0]"
			[Register ("getSDKVersion", "()Ljava/lang/String;", "GetGetSDKVersionHandler")]
			get {
				if (id_getSDKVersion == IntPtr.Zero)
					id_getSDKVersion = JNIEnv.GetMethodID (class_ref, "getSDKVersion", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSDKVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSDKVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setSDKVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSDKVersion", "(Ljava/lang/String;)V", "GetSetSDKVersion_Ljava_lang_String_Handler")]
			set {
				if (id_setSDKVersion_Ljava_lang_String_ == IntPtr.Zero)
					id_setSDKVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSDKVersion", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSDKVersion_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSDKVersion", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSerialNumber;
#pragma warning disable 0169
		static Delegate GetGetSerialNumberHandler ()
		{
			if (cb_getSerialNumber == null)
				cb_getSerialNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSerialNumber);
			return cb_getSerialNumber;
		}

		static IntPtr n_GetSerialNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SerialNumber);
		}
#pragma warning restore 0169

		static Delegate cb_setSerialNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSerialNumber_Ljava_lang_String_Handler ()
		{
			if (cb_setSerialNumber_Ljava_lang_String_ == null)
				cb_setSerialNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSerialNumber_Ljava_lang_String_);
			return cb_setSerialNumber_Ljava_lang_String_;
		}

		static void n_SetSerialNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SerialNumber = value;
		}
#pragma warning restore 0169

		static IntPtr id_getSerialNumber;
		static IntPtr id_setSerialNumber_Ljava_lang_String_;
		public virtual unsafe string SerialNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getSerialNumber' and count(parameter)=0]"
			[Register ("getSerialNumber", "()Ljava/lang/String;", "GetGetSerialNumberHandler")]
			get {
				if (id_getSerialNumber == IntPtr.Zero)
					id_getSerialNumber = JNIEnv.GetMethodID (class_ref, "getSerialNumber", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSerialNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSerialNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setSerialNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSerialNumber", "(Ljava/lang/String;)V", "GetSetSerialNumber_Ljava_lang_String_Handler")]
			set {
				if (id_setSerialNumber_Ljava_lang_String_ == IntPtr.Zero)
					id_setSerialNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSerialNumber", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSerialNumber_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSerialNumber", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSessionUUID;
#pragma warning disable 0169
		static Delegate GetGetSessionUUIDHandler ()
		{
			if (cb_getSessionUUID == null)
				cb_getSessionUUID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSessionUUID);
			return cb_getSessionUUID;
		}

		static IntPtr n_GetSessionUUID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SessionUUID);
		}
#pragma warning restore 0169

		static Delegate cb_setSessionUUID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSessionUUID_Ljava_lang_String_Handler ()
		{
			if (cb_setSessionUUID_Ljava_lang_String_ == null)
				cb_setSessionUUID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSessionUUID_Ljava_lang_String_);
			return cb_setSessionUUID_Ljava_lang_String_;
		}

		static void n_SetSessionUUID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SessionUUID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getSessionUUID;
		static IntPtr id_setSessionUUID_Ljava_lang_String_;
		public virtual unsafe string SessionUUID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getSessionUUID' and count(parameter)=0]"
			[Register ("getSessionUUID", "()Ljava/lang/String;", "GetGetSessionUUIDHandler")]
			get {
				if (id_getSessionUUID == IntPtr.Zero)
					id_getSessionUUID = JNIEnv.GetMethodID (class_ref, "getSessionUUID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSessionUUID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSessionUUID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setSessionUUID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSessionUUID", "(Ljava/lang/String;)V", "GetSetSessionUUID_Ljava_lang_String_Handler")]
			set {
				if (id_setSessionUUID_Ljava_lang_String_ == IntPtr.Zero)
					id_setSessionUUID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSessionUUID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSessionUUID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSessionUUID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSiteID;
#pragma warning disable 0169
		static Delegate GetGetSiteIDHandler ()
		{
			if (cb_getSiteID == null)
				cb_getSiteID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSiteID);
			return cb_getSiteID;
		}

		static IntPtr n_GetSiteID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SiteID);
		}
#pragma warning restore 0169

		static Delegate cb_setSiteID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSiteID_Ljava_lang_String_Handler ()
		{
			if (cb_setSiteID_Ljava_lang_String_ == null)
				cb_setSiteID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSiteID_Ljava_lang_String_);
			return cb_setSiteID_Ljava_lang_String_;
		}

		static void n_SetSiteID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SiteID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getSiteID;
		static IntPtr id_setSiteID_Ljava_lang_String_;
		public virtual unsafe string SiteID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getSiteID' and count(parameter)=0]"
			[Register ("getSiteID", "()Ljava/lang/String;", "GetGetSiteIDHandler")]
			get {
				if (id_getSiteID == IntPtr.Zero)
					id_getSiteID = JNIEnv.GetMethodID (class_ref, "getSiteID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSiteID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSiteID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setSiteID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSiteID", "(Ljava/lang/String;)V", "GetSetSiteID_Ljava_lang_String_Handler")]
			set {
				if (id_setSiteID_Ljava_lang_String_ == IntPtr.Zero)
					id_setSiteID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSiteID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSiteID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSiteID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getVerificationStatusID;
#pragma warning disable 0169
		static Delegate GetGetVerificationStatusIDHandler ()
		{
			if (cb_getVerificationStatusID == null)
				cb_getVerificationStatusID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVerificationStatusID);
			return cb_getVerificationStatusID;
		}

		static IntPtr n_GetVerificationStatusID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VerificationStatusID);
		}
#pragma warning restore 0169

		static Delegate cb_setVerificationStatusID_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetVerificationStatusID_Ljava_lang_Integer_Handler ()
		{
			if (cb_setVerificationStatusID_Ljava_lang_Integer_ == null)
				cb_setVerificationStatusID_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVerificationStatusID_Ljava_lang_Integer_);
			return cb_setVerificationStatusID_Ljava_lang_Integer_;
		}

		static void n_SetVerificationStatusID_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.VerificationStatusID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getVerificationStatusID;
		static IntPtr id_setVerificationStatusID_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer VerificationStatusID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getVerificationStatusID' and count(parameter)=0]"
			[Register ("getVerificationStatusID", "()Ljava/lang/Integer;", "GetGetVerificationStatusIDHandler")]
			get {
				if (id_getVerificationStatusID == IntPtr.Zero)
					id_getVerificationStatusID = JNIEnv.GetMethodID (class_ref, "getVerificationStatusID", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVerificationStatusID), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVerificationStatusID", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setVerificationStatusID' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setVerificationStatusID", "(Ljava/lang/Integer;)V", "GetSetVerificationStatusID_Ljava_lang_Integer_Handler")]
			set {
				if (id_setVerificationStatusID_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setVerificationStatusID_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setVerificationStatusID", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVerificationStatusID_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVerificationStatusID", "(Ljava/lang/Integer;)V"), __args);
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
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		static Delegate cb_setVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setVersion_Ljava_lang_String_ == null)
				cb_setVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVersion_Ljava_lang_String_);
			return cb_setVersion_Ljava_lang_String_;
		}

		static void n_SetVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Version = value;
		}
#pragma warning restore 0169

		static IntPtr id_getVersion;
		static IntPtr id_setVersion_Ljava_lang_String_;
		public virtual unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVersion", "(Ljava/lang/String;)V", "GetSetVersion_Ljava_lang_String_Handler")]
			set {
				if (id_setVersion_Ljava_lang_String_ == IntPtr.Zero)
					id_setVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setVersion", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVersion_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVersion", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='describeContents' and count(parameter)=0]"
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

		static IntPtr id_getNumberOfVisitsForSelection_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getNumberOfVisitsForSelection' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("getNumberOfVisitsForSelection", "(Ljava/lang/String;[Ljava/lang/String;)I", "")]
		public static unsafe int GetNumberOfVisitsForSelection (string selection, string[] selectionArgs)
		{
			if (id_getNumberOfVisitsForSelection_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_getNumberOfVisitsForSelection_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getNumberOfVisitsForSelection", "(Ljava/lang/String;[Ljava/lang/String;)I");
			IntPtr native_selection = JNIEnv.NewString (selection);
			IntPtr native_selectionArgs = JNIEnv.NewArray (selectionArgs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_selection);
				__args [1] = new JValue (native_selectionArgs);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getNumberOfVisitsForSelection_Ljava_lang_String_arrayLjava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_selection);
				if (selectionArgs != null) {
					JNIEnv.CopyArray (native_selectionArgs, selectionArgs);
					JNIEnv.DeleteLocalRef (native_selectionArgs);
				}
			}
		}

		static IntPtr id_getStoredVisitsForSelection_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='getStoredVisitsForSelection' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("getStoredVisitsForSelection", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCBeaconVisit> GetStoredVisitsForSelection (string selection, string[] selectionArgs)
		{
			if (id_getStoredVisitsForSelection_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_getStoredVisitsForSelection_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getStoredVisitsForSelection", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_selection = JNIEnv.NewString (selection);
			IntPtr native_selectionArgs = JNIEnv.NewArray (selectionArgs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_selection);
				__args [1] = new JValue (native_selectionArgs);
				global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCBeaconVisit> __ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCBeaconVisit>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStoredVisitsForSelection_Ljava_lang_String_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_selection);
				if (selectionArgs != null) {
					JNIEnv.CopyArray (native_selectionArgs, selectionArgs);
					JNIEnv.DeleteLocalRef (native_selectionArgs);
				}
			}
		}

		static Delegate cb_setLocation_Landroid_location_Location_;
#pragma warning disable 0169
		static Delegate GetSetLocation_Landroid_location_Location_Handler ()
		{
			if (cb_setLocation_Landroid_location_Location_ == null)
				cb_setLocation_Landroid_location_Location_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocation_Landroid_location_Location_);
			return cb_setLocation_Landroid_location_Location_;
		}

		static void n_SetLocation_Landroid_location_Location_ (IntPtr jnienv, IntPtr native__this, IntPtr native_location)
		{
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Locations.Location location = global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (native_location, JniHandleOwnership.DoNotTransfer);
			__this.SetLocation (location);
		}
#pragma warning restore 0169

		static IntPtr id_setLocation_Landroid_location_Location_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='setLocation' and count(parameter)=1 and parameter[1][@type='android.location.Location']]"
		[Register ("setLocation", "(Landroid/location/Location;)V", "GetSetLocation_Landroid_location_Location_Handler")]
		public virtual unsafe void SetLocation (global::Android.Locations.Location location)
		{
			if (id_setLocation_Landroid_location_Location_ == IntPtr.Zero)
				id_setLocation_Landroid_location_Location_ = JNIEnv.GetMethodID (class_ref, "setLocation", "(Landroid/location/Location;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (location);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocation_Landroid_location_Location_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocation", "(Landroid/location/Location;)V"), __args);
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
			global::Com.Bluecats.Sdk.BCBeaconVisit __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVisit> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconVisit']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
