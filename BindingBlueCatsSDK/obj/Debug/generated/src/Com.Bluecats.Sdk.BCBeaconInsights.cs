using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInsights']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCBeaconInsights", DoNotGenerateAcw=true)]
	public partial class BCBeaconInsights : global::Com.Bluecats.Sdk.BCInsights {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInsights']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/bluecats/sdk/BCBeaconInsights", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCBeaconInsights); }
		}

		protected BCBeaconInsights (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInsights']/constructor[@name='BCBeaconInsights' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCBeaconInsights ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCBeaconInsights)) {
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
			global::Com.Bluecats.Sdk.BCBeaconInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCBeaconInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.BeaconID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconID;
		static IntPtr id_setBeaconID_Ljava_lang_String_;
		public virtual unsafe string BeaconID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInsights']/method[@name='getBeaconID' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInsights']/method[@name='setBeaconID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bluecats.Sdk.BCBeaconInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCBeaconInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.BeaconName = value;
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconName;
		static IntPtr id_setBeaconName_Ljava_lang_String_;
		public virtual unsafe string BeaconName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInsights']/method[@name='getBeaconName' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconInsights']/method[@name='setBeaconName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

	}
}
