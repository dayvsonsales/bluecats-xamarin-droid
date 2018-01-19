using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamInsights']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCTeamInsights", DoNotGenerateAcw=true)]
	public partial class BCTeamInsights : global::Com.Bluecats.Sdk.BCInsights {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamInsights']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/bluecats/sdk/BCTeamInsights", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCTeamInsights); }
		}

		protected BCTeamInsights (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamInsights']/constructor[@name='BCTeamInsights' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCTeamInsights ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCTeamInsights)) {
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
			global::Com.Bluecats.Sdk.BCTeamInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCTeamInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.TeamID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getTeamID;
		static IntPtr id_setTeamID_Ljava_lang_String_;
		public virtual unsafe string TeamID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamInsights']/method[@name='getTeamID' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamInsights']/method[@name='setTeamID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getTeamName;
#pragma warning disable 0169
		static Delegate GetGetTeamNameHandler ()
		{
			if (cb_getTeamName == null)
				cb_getTeamName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTeamName);
			return cb_getTeamName;
		}

		static IntPtr n_GetTeamName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeamInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TeamName);
		}
#pragma warning restore 0169

		static Delegate cb_setTeamName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTeamName_Ljava_lang_String_Handler ()
		{
			if (cb_setTeamName_Ljava_lang_String_ == null)
				cb_setTeamName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTeamName_Ljava_lang_String_);
			return cb_setTeamName_Ljava_lang_String_;
		}

		static void n_SetTeamName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCTeamInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.TeamName = value;
		}
#pragma warning restore 0169

		static IntPtr id_getTeamName;
		static IntPtr id_setTeamName_Ljava_lang_String_;
		public virtual unsafe string TeamName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamInsights']/method[@name='getTeamName' and count(parameter)=0]"
			[Register ("getTeamName", "()Ljava/lang/String;", "GetGetTeamNameHandler")]
			get {
				if (id_getTeamName == IntPtr.Zero)
					id_getTeamName = JNIEnv.GetMethodID (class_ref, "getTeamName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTeamName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTeamName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamInsights']/method[@name='setTeamName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTeamName", "(Ljava/lang/String;)V", "GetSetTeamName_Ljava_lang_String_Handler")]
			set {
				if (id_setTeamName_Ljava_lang_String_ == IntPtr.Zero)
					id_setTeamName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTeamName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTeamName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTeamName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
