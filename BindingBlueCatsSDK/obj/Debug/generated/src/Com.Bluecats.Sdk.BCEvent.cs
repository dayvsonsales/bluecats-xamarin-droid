using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCEvent", DoNotGenerateAcw=true)]
	public partial class BCEvent : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/bluecats/sdk/BCEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCEvent); }
		}

		protected BCEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/constructor[@name='BCEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCEvent ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCEvent)) {
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

		static Delegate cb_getAccuracy;
#pragma warning disable 0169
		static Delegate GetGetAccuracyHandler ()
		{
			if (cb_getAccuracy == null)
				cb_getAccuracy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccuracy);
			return cb_getAccuracy;
		}

		static IntPtr n_GetAccuracy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Accuracy);
		}
#pragma warning restore 0169

		static Delegate cb_setAccuracy_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetAccuracy_Ljava_lang_Double_Handler ()
		{
			if (cb_setAccuracy_Ljava_lang_Double_ == null)
				cb_setAccuracy_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAccuracy_Ljava_lang_Double_);
			return cb_setAccuracy_Ljava_lang_Double_;
		}

		static void n_SetAccuracy_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double value = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Accuracy = value;
		}
#pragma warning restore 0169

		static IntPtr id_getAccuracy;
		static IntPtr id_setAccuracy_Ljava_lang_Double_;
		public virtual unsafe global::Java.Lang.Double Accuracy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getAccuracy' and count(parameter)=0]"
			[Register ("getAccuracy", "()Ljava/lang/Double;", "GetGetAccuracyHandler")]
			get {
				if (id_getAccuracy == IntPtr.Zero)
					id_getAccuracy = JNIEnv.GetMethodID (class_ref, "getAccuracy", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccuracy), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccuracy", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setAccuracy' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setAccuracy", "(Ljava/lang/Double;)V", "GetSetAccuracy_Ljava_lang_Double_Handler")]
			set {
				if (id_setAccuracy_Ljava_lang_Double_ == IntPtr.Zero)
					id_setAccuracy_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setAccuracy", "(Ljava/lang/Double;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAccuracy_Ljava_lang_Double_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAccuracy", "(Ljava/lang/Double;)V"), __args);
				} finally {
				}
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
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AppUserIdentifier = value;
		}
#pragma warning restore 0169

		static IntPtr id_getAppUserIdentifier;
		static IntPtr id_setAppUserIdentifier_Ljava_lang_String_;
		public virtual unsafe string AppUserIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getAppUserIdentifier' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setAppUserIdentifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetBeaconID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.BeaconID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconID;
		static IntPtr id_setBeaconID_Ljava_lang_String_;
		public virtual unsafe string BeaconID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getBeaconID' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setBeaconID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getBeaconName;
#pragma warning disable 0169
		static Delegate GetGetBeaconNameHandler ()
		{
			if (cb_getBeaconName == null)
				cb_getBeaconName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeaconName);
			return cb_getBeaconName;
		}

		static IntPtr n_GetBeaconName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BeaconName);
		}
#pragma warning restore 0169

		static Delegate cb_setBeaconName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBeaconName_Ljava_lang_String_Handler ()
		{
			if (cb_setBeaconName_Ljava_lang_String_ == null)
				cb_setBeaconName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBeaconName_Ljava_lang_String_);
			return cb_setBeaconName_Ljava_lang_String_;
		}

		static void n_SetBeaconName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.BeaconName = value;
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconName;
		static IntPtr id_setBeaconName_Ljava_lang_String_;
		public virtual unsafe string BeaconName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getBeaconName' and count(parameter)=0]"
			[Register ("getBeaconName", "()Ljava/lang/String;", "GetGetBeaconNameHandler")]
			get {
				if (id_getBeaconName == IntPtr.Zero)
					id_getBeaconName = JNIEnv.GetMethodID (class_ref, "getBeaconName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeaconName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setBeaconName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBeaconName", "(Ljava/lang/String;)V", "GetSetBeaconName_Ljava_lang_String_Handler")]
			set {
				if (id_setBeaconName_Ljava_lang_String_ == IntPtr.Zero)
					id_setBeaconName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBeaconName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeaconName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBeaconName", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.BeganAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getBeganAt;
		static IntPtr id_setBeganAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date BeganAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getBeganAt' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setBeganAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
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
				cb_getBeganInBackground = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeganInBackground);
			return cb_getBeganInBackground;
		}

		static IntPtr n_GetBeganInBackground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BeganInBackground);
		}
#pragma warning restore 0169

		static Delegate cb_setBeganInBackground_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetBeganInBackground_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setBeganInBackground_Ljava_lang_Boolean_ == null)
				cb_setBeganInBackground_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBeganInBackground_Ljava_lang_Boolean_);
			return cb_setBeganInBackground_Ljava_lang_Boolean_;
		}

		static void n_SetBeganInBackground_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean value = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.BeganInBackground = value;
		}
#pragma warning restore 0169

		static IntPtr id_getBeganInBackground;
		static IntPtr id_setBeganInBackground_Ljava_lang_Boolean_;
		public virtual unsafe global::Java.Lang.Boolean BeganInBackground {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getBeganInBackground' and count(parameter)=0]"
			[Register ("getBeganInBackground", "()Ljava/lang/Boolean;", "GetGetBeganInBackgroundHandler")]
			get {
				if (id_getBeganInBackground == IntPtr.Zero)
					id_getBeganInBackground = JNIEnv.GetMethodID (class_ref, "getBeganInBackground", "()Ljava/lang/Boolean;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeganInBackground), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeganInBackground", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setBeganInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setBeganInBackground", "(Ljava/lang/Boolean;)V", "GetSetBeganInBackground_Ljava_lang_Boolean_Handler")]
			set {
				if (id_setBeganInBackground_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_setBeganInBackground_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setBeganInBackground", "(Ljava/lang/Boolean;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeganInBackground_Ljava_lang_Boolean_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBeganInBackground", "(Ljava/lang/Boolean;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCategoryID;
#pragma warning disable 0169
		static Delegate GetGetCategoryIDHandler ()
		{
			if (cb_getCategoryID == null)
				cb_getCategoryID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCategoryID);
			return cb_getCategoryID;
		}

		static IntPtr n_GetCategoryID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CategoryID);
		}
#pragma warning restore 0169

		static Delegate cb_setCategoryID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCategoryID_Ljava_lang_String_Handler ()
		{
			if (cb_setCategoryID_Ljava_lang_String_ == null)
				cb_setCategoryID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCategoryID_Ljava_lang_String_);
			return cb_setCategoryID_Ljava_lang_String_;
		}

		static void n_SetCategoryID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.CategoryID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCategoryID;
		static IntPtr id_setCategoryID_Ljava_lang_String_;
		public virtual unsafe string CategoryID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getCategoryID' and count(parameter)=0]"
			[Register ("getCategoryID", "()Ljava/lang/String;", "GetGetCategoryIDHandler")]
			get {
				if (id_getCategoryID == IntPtr.Zero)
					id_getCategoryID = JNIEnv.GetMethodID (class_ref, "getCategoryID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCategoryID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCategoryID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setCategoryID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCategoryID", "(Ljava/lang/String;)V", "GetSetCategoryID_Ljava_lang_String_Handler")]
			set {
				if (id_setCategoryID_Ljava_lang_String_ == IntPtr.Zero)
					id_setCategoryID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCategoryID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCategoryID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCategoryID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCategoryName;
#pragma warning disable 0169
		static Delegate GetGetCategoryNameHandler ()
		{
			if (cb_getCategoryName == null)
				cb_getCategoryName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCategoryName);
			return cb_getCategoryName;
		}

		static IntPtr n_GetCategoryName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CategoryName);
		}
#pragma warning restore 0169

		static Delegate cb_setCategoryName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCategoryName_Ljava_lang_String_Handler ()
		{
			if (cb_setCategoryName_Ljava_lang_String_ == null)
				cb_setCategoryName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCategoryName_Ljava_lang_String_);
			return cb_setCategoryName_Ljava_lang_String_;
		}

		static void n_SetCategoryName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.CategoryName = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCategoryName;
		static IntPtr id_setCategoryName_Ljava_lang_String_;
		public virtual unsafe string CategoryName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getCategoryName' and count(parameter)=0]"
			[Register ("getCategoryName", "()Ljava/lang/String;", "GetGetCategoryNameHandler")]
			get {
				if (id_getCategoryName == IntPtr.Zero)
					id_getCategoryName = JNIEnv.GetMethodID (class_ref, "getCategoryName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCategoryName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCategoryName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setCategoryName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCategoryName", "(Ljava/lang/String;)V", "GetSetCategoryName_Ljava_lang_String_Handler")]
			set {
				if (id_setCategoryName_Ljava_lang_String_ == IntPtr.Zero)
					id_setCategoryName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCategoryName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCategoryName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCategoryName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCustomDeviceIdentifier;
#pragma warning disable 0169
		static Delegate GetGetCustomDeviceIdentifierHandler ()
		{
			if (cb_getCustomDeviceIdentifier == null)
				cb_getCustomDeviceIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomDeviceIdentifier);
			return cb_getCustomDeviceIdentifier;
		}

		static IntPtr n_GetCustomDeviceIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CustomDeviceIdentifier);
		}
#pragma warning restore 0169

		static Delegate cb_setCustomDeviceIdentifier_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCustomDeviceIdentifier_Ljava_lang_String_Handler ()
		{
			if (cb_setCustomDeviceIdentifier_Ljava_lang_String_ == null)
				cb_setCustomDeviceIdentifier_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomDeviceIdentifier_Ljava_lang_String_);
			return cb_setCustomDeviceIdentifier_Ljava_lang_String_;
		}

		static void n_SetCustomDeviceIdentifier_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.CustomDeviceIdentifier = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCustomDeviceIdentifier;
		static IntPtr id_setCustomDeviceIdentifier_Ljava_lang_String_;
		public virtual unsafe string CustomDeviceIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getCustomDeviceIdentifier' and count(parameter)=0]"
			[Register ("getCustomDeviceIdentifier", "()Ljava/lang/String;", "GetGetCustomDeviceIdentifierHandler")]
			get {
				if (id_getCustomDeviceIdentifier == IntPtr.Zero)
					id_getCustomDeviceIdentifier = JNIEnv.GetMethodID (class_ref, "getCustomDeviceIdentifier", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCustomDeviceIdentifier), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCustomDeviceIdentifier", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setCustomDeviceIdentifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCustomDeviceIdentifier", "(Ljava/lang/String;)V", "GetSetCustomDeviceIdentifier_Ljava_lang_String_Handler")]
			set {
				if (id_setCustomDeviceIdentifier_Ljava_lang_String_ == IntPtr.Zero)
					id_setCustomDeviceIdentifier_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCustomDeviceIdentifier", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCustomDeviceIdentifier_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomDeviceIdentifier", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.DeviceUUID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceUUID;
		static IntPtr id_setDeviceUUID_Ljava_lang_String_;
		public virtual unsafe string DeviceUUID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getDeviceUUID' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setDeviceUUID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.EndedAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getEndedAt;
		static IntPtr id_setEndedAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date EndedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getEndedAt' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setEndedAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
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
				cb_getEndedInBackground = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndedInBackground);
			return cb_getEndedInBackground;
		}

		static IntPtr n_GetEndedInBackground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EndedInBackground);
		}
#pragma warning restore 0169

		static Delegate cb_setEndedInBackground_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetEndedInBackground_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setEndedInBackground_Ljava_lang_Boolean_ == null)
				cb_setEndedInBackground_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEndedInBackground_Ljava_lang_Boolean_);
			return cb_setEndedInBackground_Ljava_lang_Boolean_;
		}

		static void n_SetEndedInBackground_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean value = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.EndedInBackground = value;
		}
#pragma warning restore 0169

		static IntPtr id_getEndedInBackground;
		static IntPtr id_setEndedInBackground_Ljava_lang_Boolean_;
		public virtual unsafe global::Java.Lang.Boolean EndedInBackground {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getEndedInBackground' and count(parameter)=0]"
			[Register ("getEndedInBackground", "()Ljava/lang/Boolean;", "GetGetEndedInBackgroundHandler")]
			get {
				if (id_getEndedInBackground == IntPtr.Zero)
					id_getEndedInBackground = JNIEnv.GetMethodID (class_ref, "getEndedInBackground", "()Ljava/lang/Boolean;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEndedInBackground), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEndedInBackground", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setEndedInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setEndedInBackground", "(Ljava/lang/Boolean;)V", "GetSetEndedInBackground_Ljava_lang_Boolean_Handler")]
			set {
				if (id_setEndedInBackground_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_setEndedInBackground_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setEndedInBackground", "(Ljava/lang/Boolean;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEndedInBackground_Ljava_lang_Boolean_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEndedInBackground", "(Ljava/lang/Boolean;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEventID;
#pragma warning disable 0169
		static Delegate GetGetEventIDHandler ()
		{
			if (cb_getEventID == null)
				cb_getEventID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventID);
			return cb_getEventID;
		}

		static IntPtr n_GetEventID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EventID);
		}
#pragma warning restore 0169

		static Delegate cb_setEventID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEventID_Ljava_lang_String_Handler ()
		{
			if (cb_setEventID_Ljava_lang_String_ == null)
				cb_setEventID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEventID_Ljava_lang_String_);
			return cb_setEventID_Ljava_lang_String_;
		}

		static void n_SetEventID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.EventID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getEventID;
		static IntPtr id_setEventID_Ljava_lang_String_;
		public virtual unsafe string EventID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getEventID' and count(parameter)=0]"
			[Register ("getEventID", "()Ljava/lang/String;", "GetGetEventIDHandler")]
			get {
				if (id_getEventID == IntPtr.Zero)
					id_getEventID = JNIEnv.GetMethodID (class_ref, "getEventID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEventID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEventID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setEventID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEventID", "(Ljava/lang/String;)V", "GetSetEventID_Ljava_lang_String_Handler")]
			set {
				if (id_setEventID_Ljava_lang_String_ == IntPtr.Zero)
					id_setEventID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEventID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEventID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEventID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEventIdentifier;
#pragma warning disable 0169
		static Delegate GetGetEventIdentifierHandler ()
		{
			if (cb_getEventIdentifier == null)
				cb_getEventIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventIdentifier);
			return cb_getEventIdentifier;
		}

		static IntPtr n_GetEventIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EventIdentifier);
		}
#pragma warning restore 0169

		static Delegate cb_setEventIdentifier_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEventIdentifier_Ljava_lang_String_Handler ()
		{
			if (cb_setEventIdentifier_Ljava_lang_String_ == null)
				cb_setEventIdentifier_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEventIdentifier_Ljava_lang_String_);
			return cb_setEventIdentifier_Ljava_lang_String_;
		}

		static void n_SetEventIdentifier_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.EventIdentifier = value;
		}
#pragma warning restore 0169

		static IntPtr id_getEventIdentifier;
		static IntPtr id_setEventIdentifier_Ljava_lang_String_;
		public virtual unsafe string EventIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getEventIdentifier' and count(parameter)=0]"
			[Register ("getEventIdentifier", "()Ljava/lang/String;", "GetGetEventIdentifierHandler")]
			get {
				if (id_getEventIdentifier == IntPtr.Zero)
					id_getEventIdentifier = JNIEnv.GetMethodID (class_ref, "getEventIdentifier", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEventIdentifier), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEventIdentifier", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setEventIdentifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEventIdentifier", "(Ljava/lang/String;)V", "GetSetEventIdentifier_Ljava_lang_String_Handler")]
			set {
				if (id_setEventIdentifier_Ljava_lang_String_ == IntPtr.Zero)
					id_setEventIdentifier_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEventIdentifier", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEventIdentifier_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEventIdentifier", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEventName;
#pragma warning disable 0169
		static Delegate GetGetEventNameHandler ()
		{
			if (cb_getEventName == null)
				cb_getEventName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventName);
			return cb_getEventName;
		}

		static IntPtr n_GetEventName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EventName);
		}
#pragma warning restore 0169

		static Delegate cb_setEventName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEventName_Ljava_lang_String_Handler ()
		{
			if (cb_setEventName_Ljava_lang_String_ == null)
				cb_setEventName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEventName_Ljava_lang_String_);
			return cb_setEventName_Ljava_lang_String_;
		}

		static void n_SetEventName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.EventName = value;
		}
#pragma warning restore 0169

		static IntPtr id_getEventName;
		static IntPtr id_setEventName_Ljava_lang_String_;
		public virtual unsafe string EventName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getEventName' and count(parameter)=0]"
			[Register ("getEventName", "()Ljava/lang/String;", "GetGetEventNameHandler")]
			get {
				if (id_getEventName == IntPtr.Zero)
					id_getEventName = JNIEnv.GetMethodID (class_ref, "getEventName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEventName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEventName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setEventName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEventName", "(Ljava/lang/String;)V", "GetSetEventName_Ljava_lang_String_Handler")]
			set {
				if (id_setEventName_Ljava_lang_String_ == IntPtr.Zero)
					id_setEventName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEventName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEventName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEventName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.LastPostedAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getLastPostedAt;
		static IntPtr id_setLastPostedAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date LastPostedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getLastPostedAt' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setLastPostedAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
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

		static Delegate cb_getMapID;
#pragma warning disable 0169
		static Delegate GetGetMapIDHandler ()
		{
			if (cb_getMapID == null)
				cb_getMapID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapID);
			return cb_getMapID;
		}

		static IntPtr n_GetMapID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MapID);
		}
#pragma warning restore 0169

		static Delegate cb_setMapID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMapID_Ljava_lang_String_Handler ()
		{
			if (cb_setMapID_Ljava_lang_String_ == null)
				cb_setMapID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMapID_Ljava_lang_String_);
			return cb_setMapID_Ljava_lang_String_;
		}

		static void n_SetMapID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.MapID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getMapID;
		static IntPtr id_setMapID_Ljava_lang_String_;
		public virtual unsafe string MapID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getMapID' and count(parameter)=0]"
			[Register ("getMapID", "()Ljava/lang/String;", "GetGetMapIDHandler")]
			get {
				if (id_getMapID == IntPtr.Zero)
					id_getMapID = JNIEnv.GetMethodID (class_ref, "getMapID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMapID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMapID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setMapID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMapID", "(Ljava/lang/String;)V", "GetSetMapID_Ljava_lang_String_Handler")]
			set {
				if (id_setMapID_Ljava_lang_String_ == IntPtr.Zero)
					id_setMapID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMapID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMapID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMapID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMapX;
#pragma warning disable 0169
		static Delegate GetGetMapXHandler ()
		{
			if (cb_getMapX == null)
				cb_getMapX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapX);
			return cb_getMapX;
		}

		static IntPtr n_GetMapX (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MapX);
		}
#pragma warning restore 0169

		static Delegate cb_setMapX_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetMapX_Ljava_lang_Double_Handler ()
		{
			if (cb_setMapX_Ljava_lang_Double_ == null)
				cb_setMapX_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMapX_Ljava_lang_Double_);
			return cb_setMapX_Ljava_lang_Double_;
		}

		static void n_SetMapX_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double value = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.MapX = value;
		}
#pragma warning restore 0169

		static IntPtr id_getMapX;
		static IntPtr id_setMapX_Ljava_lang_Double_;
		public virtual unsafe global::Java.Lang.Double MapX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getMapX' and count(parameter)=0]"
			[Register ("getMapX", "()Ljava/lang/Double;", "GetGetMapXHandler")]
			get {
				if (id_getMapX == IntPtr.Zero)
					id_getMapX = JNIEnv.GetMethodID (class_ref, "getMapX", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMapX), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMapX", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setMapX' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setMapX", "(Ljava/lang/Double;)V", "GetSetMapX_Ljava_lang_Double_Handler")]
			set {
				if (id_setMapX_Ljava_lang_Double_ == IntPtr.Zero)
					id_setMapX_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setMapX", "(Ljava/lang/Double;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMapX_Ljava_lang_Double_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMapX", "(Ljava/lang/Double;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMapY;
#pragma warning disable 0169
		static Delegate GetGetMapYHandler ()
		{
			if (cb_getMapY == null)
				cb_getMapY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapY);
			return cb_getMapY;
		}

		static IntPtr n_GetMapY (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MapY);
		}
#pragma warning restore 0169

		static Delegate cb_setMapY_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetMapY_Ljava_lang_Double_Handler ()
		{
			if (cb_setMapY_Ljava_lang_Double_ == null)
				cb_setMapY_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMapY_Ljava_lang_Double_);
			return cb_setMapY_Ljava_lang_Double_;
		}

		static void n_SetMapY_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double value = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.MapY = value;
		}
#pragma warning restore 0169

		static IntPtr id_getMapY;
		static IntPtr id_setMapY_Ljava_lang_Double_;
		public virtual unsafe global::Java.Lang.Double MapY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getMapY' and count(parameter)=0]"
			[Register ("getMapY", "()Ljava/lang/Double;", "GetGetMapYHandler")]
			get {
				if (id_getMapY == IntPtr.Zero)
					id_getMapY = JNIEnv.GetMethodID (class_ref, "getMapY", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMapY), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMapY", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setMapY' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setMapY", "(Ljava/lang/Double;)V", "GetSetMapY_Ljava_lang_Double_Handler")]
			set {
				if (id_setMapY_Ljava_lang_Double_ == IntPtr.Zero)
					id_setMapY_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setMapY", "(Ljava/lang/Double;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMapY_Ljava_lang_Double_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMapY", "(Ljava/lang/Double;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRSSI;
#pragma warning disable 0169
		static Delegate GetGetRSSIHandler ()
		{
			if (cb_getRSSI == null)
				cb_getRSSI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRSSI);
			return cb_getRSSI;
		}

		static IntPtr n_GetRSSI (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RSSI);
		}
#pragma warning restore 0169

		static Delegate cb_setRSSI_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetRSSI_Ljava_lang_Integer_Handler ()
		{
			if (cb_setRSSI_Ljava_lang_Integer_ == null)
				cb_setRSSI_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRSSI_Ljava_lang_Integer_);
			return cb_setRSSI_Ljava_lang_Integer_;
		}

		static void n_SetRSSI_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.RSSI = value;
		}
#pragma warning restore 0169

		static IntPtr id_getRSSI;
		static IntPtr id_setRSSI_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer RSSI {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getRSSI' and count(parameter)=0]"
			[Register ("getRSSI", "()Ljava/lang/Integer;", "GetGetRSSIHandler")]
			get {
				if (id_getRSSI == IntPtr.Zero)
					id_getRSSI = JNIEnv.GetMethodID (class_ref, "getRSSI", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRSSI), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRSSI", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setRSSI' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setRSSI", "(Ljava/lang/Integer;)V", "GetSetRSSI_Ljava_lang_Integer_Handler")]
			set {
				if (id_setRSSI_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setRSSI_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setRSSI", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRSSI_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRSSI", "(Ljava/lang/Integer;)V"), __args);
				} finally {
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
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SessionUUID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getSessionUUID;
		static IntPtr id_setSessionUUID_Ljava_lang_String_;
		public virtual unsafe string SessionUUID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getSessionUUID' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setSessionUUID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SiteID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getSiteID;
		static IntPtr id_setSiteID_Ljava_lang_String_;
		public virtual unsafe string SiteID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getSiteID' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setSiteID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getSiteName;
#pragma warning disable 0169
		static Delegate GetGetSiteNameHandler ()
		{
			if (cb_getSiteName == null)
				cb_getSiteName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSiteName);
			return cb_getSiteName;
		}

		static IntPtr n_GetSiteName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SiteName);
		}
#pragma warning restore 0169

		static Delegate cb_setSiteName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSiteName_Ljava_lang_String_Handler ()
		{
			if (cb_setSiteName_Ljava_lang_String_ == null)
				cb_setSiteName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSiteName_Ljava_lang_String_);
			return cb_setSiteName_Ljava_lang_String_;
		}

		static void n_SetSiteName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SiteName = value;
		}
#pragma warning restore 0169

		static IntPtr id_getSiteName;
		static IntPtr id_setSiteName_Ljava_lang_String_;
		public virtual unsafe string SiteName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getSiteName' and count(parameter)=0]"
			[Register ("getSiteName", "()Ljava/lang/String;", "GetGetSiteNameHandler")]
			get {
				if (id_getSiteName == IntPtr.Zero)
					id_getSiteName = JNIEnv.GetMethodID (class_ref, "getSiteName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSiteName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSiteName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setSiteName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSiteName", "(Ljava/lang/String;)V", "GetSetSiteName_Ljava_lang_String_Handler")]
			set {
				if (id_setSiteName_Ljava_lang_String_ == IntPtr.Zero)
					id_setSiteName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSiteName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSiteName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSiteName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getValue1;
#pragma warning disable 0169
		static Delegate GetGetValue1Handler ()
		{
			if (cb_getValue1 == null)
				cb_getValue1 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue1);
			return cb_getValue1;
		}

		static IntPtr n_GetValue1 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value1);
		}
#pragma warning restore 0169

		static Delegate cb_setValue1_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValue1_Ljava_lang_String_Handler ()
		{
			if (cb_setValue1_Ljava_lang_String_ == null)
				cb_setValue1_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValue1_Ljava_lang_String_);
			return cb_setValue1_Ljava_lang_String_;
		}

		static void n_SetValue1_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Value1 = value;
		}
#pragma warning restore 0169

		static IntPtr id_getValue1;
		static IntPtr id_setValue1_Ljava_lang_String_;
		public virtual unsafe string Value1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getValue1' and count(parameter)=0]"
			[Register ("getValue1", "()Ljava/lang/String;", "GetGetValue1Handler")]
			get {
				if (id_getValue1 == IntPtr.Zero)
					id_getValue1 = JNIEnv.GetMethodID (class_ref, "getValue1", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue1), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue1", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setValue1' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setValue1", "(Ljava/lang/String;)V", "GetSetValue1_Ljava_lang_String_Handler")]
			set {
				if (id_setValue1_Ljava_lang_String_ == IntPtr.Zero)
					id_setValue1_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setValue1", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValue1_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue1", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getValue2;
#pragma warning disable 0169
		static Delegate GetGetValue2Handler ()
		{
			if (cb_getValue2 == null)
				cb_getValue2 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue2);
			return cb_getValue2;
		}

		static IntPtr n_GetValue2 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value2);
		}
#pragma warning restore 0169

		static Delegate cb_setValue2_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValue2_Ljava_lang_String_Handler ()
		{
			if (cb_setValue2_Ljava_lang_String_ == null)
				cb_setValue2_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValue2_Ljava_lang_String_);
			return cb_setValue2_Ljava_lang_String_;
		}

		static void n_SetValue2_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Value2 = value;
		}
#pragma warning restore 0169

		static IntPtr id_getValue2;
		static IntPtr id_setValue2_Ljava_lang_String_;
		public virtual unsafe string Value2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getValue2' and count(parameter)=0]"
			[Register ("getValue2", "()Ljava/lang/String;", "GetGetValue2Handler")]
			get {
				if (id_getValue2 == IntPtr.Zero)
					id_getValue2 = JNIEnv.GetMethodID (class_ref, "getValue2", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue2), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue2", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setValue2' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setValue2", "(Ljava/lang/String;)V", "GetSetValue2_Ljava_lang_String_Handler")]
			set {
				if (id_setValue2_Ljava_lang_String_ == IntPtr.Zero)
					id_setValue2_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setValue2", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValue2_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue2", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getValue3;
#pragma warning disable 0169
		static Delegate GetGetValue3Handler ()
		{
			if (cb_getValue3 == null)
				cb_getValue3 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValue3);
			return cb_getValue3;
		}

		static IntPtr n_GetValue3 (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Value3);
		}
#pragma warning restore 0169

		static Delegate cb_setValue3_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValue3_Ljava_lang_String_Handler ()
		{
			if (cb_setValue3_Ljava_lang_String_ == null)
				cb_setValue3_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValue3_Ljava_lang_String_);
			return cb_setValue3_Ljava_lang_String_;
		}

		static void n_SetValue3_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Value3 = value;
		}
#pragma warning restore 0169

		static IntPtr id_getValue3;
		static IntPtr id_setValue3_Ljava_lang_String_;
		public virtual unsafe string Value3 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getValue3' and count(parameter)=0]"
			[Register ("getValue3", "()Ljava/lang/String;", "GetGetValue3Handler")]
			get {
				if (id_getValue3 == IntPtr.Zero)
					id_getValue3 = JNIEnv.GetMethodID (class_ref, "getValue3", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue3), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValue3", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='setValue3' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setValue3", "(Ljava/lang/String;)V", "GetSetValue3_Ljava_lang_String_Handler")]
			set {
				if (id_setValue3_Ljava_lang_String_ == IntPtr.Zero)
					id_setValue3_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setValue3", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValue3_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValue3", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='describeContents' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getNumberOfVisitsForSelection' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]']]"
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

		static IntPtr id_getStoredEventsForSelection_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='getStoredEventsForSelection' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("getStoredEventsForSelection", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCEvent> GetStoredEventsForSelection (string selection, string[] selectionArgs)
		{
			if (id_getStoredEventsForSelection_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_getStoredEventsForSelection_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getStoredEventsForSelection", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_selection = JNIEnv.NewString (selection);
			IntPtr native_selectionArgs = JNIEnv.NewArray (selectionArgs);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_selection);
				__args [1] = new JValue (native_selectionArgs);
				global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCEvent> __ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCEvent>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStoredEventsForSelection_Ljava_lang_String_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_selection);
				if (selectionArgs != null) {
					JNIEnv.CopyArray (native_selectionArgs, selectionArgs);
					JNIEnv.DeleteLocalRef (native_selectionArgs);
				}
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
			global::Com.Bluecats.Sdk.BCEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEvent']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
