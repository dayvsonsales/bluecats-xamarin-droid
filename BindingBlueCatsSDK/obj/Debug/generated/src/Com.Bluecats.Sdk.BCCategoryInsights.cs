using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategoryInsights']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCCategoryInsights", DoNotGenerateAcw=true)]
	public partial class BCCategoryInsights : global::Com.Bluecats.Sdk.BCInsights {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategoryInsights']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/bluecats/sdk/BCCategoryInsights", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCCategoryInsights); }
		}

		protected BCCategoryInsights (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategoryInsights']/constructor[@name='BCCategoryInsights' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCCategoryInsights ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCCategoryInsights)) {
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
			global::Com.Bluecats.Sdk.BCCategoryInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategoryInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCCategoryInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategoryInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.CategoryID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCategoryID;
		static IntPtr id_setCategoryID_Ljava_lang_String_;
		public virtual unsafe string CategoryID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategoryInsights']/method[@name='getCategoryID' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategoryInsights']/method[@name='setCategoryID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bluecats.Sdk.BCCategoryInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategoryInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCCategoryInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategoryInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.CategoryName = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCategoryName;
		static IntPtr id_setCategoryName_Ljava_lang_String_;
		public virtual unsafe string CategoryName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategoryInsights']/method[@name='getCategoryName' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategoryInsights']/method[@name='setCategoryName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getCategoryTypeID;
#pragma warning disable 0169
		static Delegate GetGetCategoryTypeIDHandler ()
		{
			if (cb_getCategoryTypeID == null)
				cb_getCategoryTypeID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCategoryTypeID);
			return cb_getCategoryTypeID;
		}

		static int n_GetCategoryTypeID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCCategoryInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategoryInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CategoryTypeID;
		}
#pragma warning restore 0169

		static Delegate cb_setCategoryTypeID_I;
#pragma warning disable 0169
		static Delegate GetSetCategoryTypeID_IHandler ()
		{
			if (cb_setCategoryTypeID_I == null)
				cb_setCategoryTypeID_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCategoryTypeID_I);
			return cb_setCategoryTypeID_I;
		}

		static void n_SetCategoryTypeID_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Bluecats.Sdk.BCCategoryInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategoryInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CategoryTypeID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCategoryTypeID;
		static IntPtr id_setCategoryTypeID_I;
		public virtual unsafe int CategoryTypeID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategoryInsights']/method[@name='getCategoryTypeID' and count(parameter)=0]"
			[Register ("getCategoryTypeID", "()I", "GetGetCategoryTypeIDHandler")]
			get {
				if (id_getCategoryTypeID == IntPtr.Zero)
					id_getCategoryTypeID = JNIEnv.GetMethodID (class_ref, "getCategoryTypeID", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCategoryTypeID);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCategoryTypeID", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategoryInsights']/method[@name='setCategoryTypeID' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCategoryTypeID", "(I)V", "GetSetCategoryTypeID_IHandler")]
			set {
				if (id_setCategoryTypeID_I == IntPtr.Zero)
					id_setCategoryTypeID_I = JNIEnv.GetMethodID (class_ref, "setCategoryTypeID", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCategoryTypeID_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCategoryTypeID", "(I)V"), __args);
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
			global::Com.Bluecats.Sdk.BCCategoryInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategoryInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCCategoryInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategoryInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.TeamID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getTeamID;
		static IntPtr id_setTeamID_Ljava_lang_String_;
		public virtual unsafe string TeamID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategoryInsights']/method[@name='getTeamID' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategoryInsights']/method[@name='setTeamID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

	}
}
