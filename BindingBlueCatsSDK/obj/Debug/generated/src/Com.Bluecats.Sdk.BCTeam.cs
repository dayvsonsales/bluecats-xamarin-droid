using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCTeam", DoNotGenerateAcw=true)]
	public partial class BCTeam : global::Com.Bluecats.Sdk.BCTeamApi, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/bluecats/sdk/BCTeam", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCTeam); }
		}

		protected BCTeam (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/constructor[@name='BCTeam' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCTeam ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCTeam)) {
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

		static Delegate cb_getAppCount;
#pragma warning disable 0169
		static Delegate GetGetAppCountHandler ()
		{
			if (cb_getAppCount == null)
				cb_getAppCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppCount);
			return cb_getAppCount;
		}

		static IntPtr n_GetAppCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeam __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AppCount);
		}
#pragma warning restore 0169

		static Delegate cb_setAppCount_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetAppCount_Ljava_lang_Integer_Handler ()
		{
			if (cb_setAppCount_Ljava_lang_Integer_ == null)
				cb_setAppCount_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppCount_Ljava_lang_Integer_);
			return cb_setAppCount_Ljava_lang_Integer_;
		}

		static void n_SetAppCount_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCTeam __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AppCount = value;
		}
#pragma warning restore 0169

		static IntPtr id_getAppCount;
		static IntPtr id_setAppCount_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer AppCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/method[@name='getAppCount' and count(parameter)=0]"
			[Register ("getAppCount", "()Ljava/lang/Integer;", "GetGetAppCountHandler")]
			get {
				if (id_getAppCount == IntPtr.Zero)
					id_getAppCount = JNIEnv.GetMethodID (class_ref, "getAppCount", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppCount), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppCount", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/method[@name='setAppCount' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setAppCount", "(Ljava/lang/Integer;)V", "GetSetAppCount_Ljava_lang_Integer_Handler")]
			set {
				if (id_setAppCount_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setAppCount_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setAppCount", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppCount_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppCount", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBeaconCount;
#pragma warning disable 0169
		static Delegate GetGetBeaconCountHandler ()
		{
			if (cb_getBeaconCount == null)
				cb_getBeaconCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeaconCount);
			return cb_getBeaconCount;
		}

		static IntPtr n_GetBeaconCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeam __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BeaconCount);
		}
#pragma warning restore 0169

		static Delegate cb_setBeaconCount_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetBeaconCount_Ljava_lang_Integer_Handler ()
		{
			if (cb_setBeaconCount_Ljava_lang_Integer_ == null)
				cb_setBeaconCount_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBeaconCount_Ljava_lang_Integer_);
			return cb_setBeaconCount_Ljava_lang_Integer_;
		}

		static void n_SetBeaconCount_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCTeam __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.BeaconCount = value;
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconCount;
		static IntPtr id_setBeaconCount_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer BeaconCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/method[@name='getBeaconCount' and count(parameter)=0]"
			[Register ("getBeaconCount", "()Ljava/lang/Integer;", "GetGetBeaconCountHandler")]
			get {
				if (id_getBeaconCount == IntPtr.Zero)
					id_getBeaconCount = JNIEnv.GetMethodID (class_ref, "getBeaconCount", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconCount), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeaconCount", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/method[@name='setBeaconCount' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setBeaconCount", "(Ljava/lang/Integer;)V", "GetSetBeaconCount_Ljava_lang_Integer_Handler")]
			set {
				if (id_setBeaconCount_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setBeaconCount_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setBeaconCount", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeaconCount_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBeaconCount", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCategoryCount;
#pragma warning disable 0169
		static Delegate GetGetCategoryCountHandler ()
		{
			if (cb_getCategoryCount == null)
				cb_getCategoryCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCategoryCount);
			return cb_getCategoryCount;
		}

		static IntPtr n_GetCategoryCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeam __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CategoryCount);
		}
#pragma warning restore 0169

		static Delegate cb_setCategoryCount_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetCategoryCount_Ljava_lang_Integer_Handler ()
		{
			if (cb_setCategoryCount_Ljava_lang_Integer_ == null)
				cb_setCategoryCount_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCategoryCount_Ljava_lang_Integer_);
			return cb_setCategoryCount_Ljava_lang_Integer_;
		}

		static void n_SetCategoryCount_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCTeam __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.CategoryCount = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCategoryCount;
		static IntPtr id_setCategoryCount_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer CategoryCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/method[@name='getCategoryCount' and count(parameter)=0]"
			[Register ("getCategoryCount", "()Ljava/lang/Integer;", "GetGetCategoryCountHandler")]
			get {
				if (id_getCategoryCount == IntPtr.Zero)
					id_getCategoryCount = JNIEnv.GetMethodID (class_ref, "getCategoryCount", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCategoryCount), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCategoryCount", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/method[@name='setCategoryCount' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setCategoryCount", "(Ljava/lang/Integer;)V", "GetSetCategoryCount_Ljava_lang_Integer_Handler")]
			set {
				if (id_setCategoryCount_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setCategoryCount_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setCategoryCount", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCategoryCount_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCategoryCount", "(Ljava/lang/Integer;)V"), __args);
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
			global::Com.Bluecats.Sdk.BCTeam __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetCreatedAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCTeam __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.CreatedAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCreatedAt;
		static IntPtr id_setCreatedAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date CreatedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/method[@name='getCreatedAt' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/method[@name='setCreatedAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
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
			global::Com.Bluecats.Sdk.BCTeam __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCTeam __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Name = value;
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		static IntPtr id_setName_Ljava_lang_String_;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/method[@name='getName' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getOwner;
#pragma warning disable 0169
		static Delegate GetGetOwnerHandler ()
		{
			if (cb_getOwner == null)
				cb_getOwner = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOwner);
			return cb_getOwner;
		}

		static IntPtr n_GetOwner (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeam __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Owner);
		}
#pragma warning restore 0169

		static Delegate cb_setOwner_Lcom_bluecats_sdk_BCPerson_;
#pragma warning disable 0169
		static Delegate GetSetOwner_Lcom_bluecats_sdk_BCPerson_Handler ()
		{
			if (cb_setOwner_Lcom_bluecats_sdk_BCPerson_ == null)
				cb_setOwner_Lcom_bluecats_sdk_BCPerson_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOwner_Lcom_bluecats_sdk_BCPerson_);
			return cb_setOwner_Lcom_bluecats_sdk_BCPerson_;
		}

		static void n_SetOwner_Lcom_bluecats_sdk_BCPerson_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCTeam __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCPerson value = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPerson> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Owner = value;
		}
#pragma warning restore 0169

		static IntPtr id_getOwner;
		static IntPtr id_setOwner_Lcom_bluecats_sdk_BCPerson_;
		public virtual unsafe global::Com.Bluecats.Sdk.BCPerson Owner {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/method[@name='getOwner' and count(parameter)=0]"
			[Register ("getOwner", "()Lcom/bluecats/sdk/BCPerson;", "GetGetOwnerHandler")]
			get {
				if (id_getOwner == IntPtr.Zero)
					id_getOwner = JNIEnv.GetMethodID (class_ref, "getOwner", "()Lcom/bluecats/sdk/BCPerson;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPerson> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOwner), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPerson> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOwner", "()Lcom/bluecats/sdk/BCPerson;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/method[@name='setOwner' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCPerson']]"
			[Register ("setOwner", "(Lcom/bluecats/sdk/BCPerson;)V", "GetSetOwner_Lcom_bluecats_sdk_BCPerson_Handler")]
			set {
				if (id_setOwner_Lcom_bluecats_sdk_BCPerson_ == IntPtr.Zero)
					id_setOwner_Lcom_bluecats_sdk_BCPerson_ = JNIEnv.GetMethodID (class_ref, "setOwner", "(Lcom/bluecats/sdk/BCPerson;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOwner_Lcom_bluecats_sdk_BCPerson_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOwner", "(Lcom/bluecats/sdk/BCPerson;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTeamRole;
#pragma warning disable 0169
		static Delegate GetGetTeamRoleHandler ()
		{
			if (cb_getTeamRole == null)
				cb_getTeamRole = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTeamRole);
			return cb_getTeamRole;
		}

		static IntPtr n_GetTeamRole (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeam __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TeamRole);
		}
#pragma warning restore 0169

		static Delegate cb_setTeamRole_Lcom_bluecats_sdk_BCTeamRole_;
#pragma warning disable 0169
		static Delegate GetSetTeamRole_Lcom_bluecats_sdk_BCTeamRole_Handler ()
		{
			if (cb_setTeamRole_Lcom_bluecats_sdk_BCTeamRole_ == null)
				cb_setTeamRole_Lcom_bluecats_sdk_BCTeamRole_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTeamRole_Lcom_bluecats_sdk_BCTeamRole_);
			return cb_setTeamRole_Lcom_bluecats_sdk_BCTeamRole_;
		}

		static void n_SetTeamRole_Lcom_bluecats_sdk_BCTeamRole_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCTeam __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCTeamRole value = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamRole> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.TeamRole = value;
		}
#pragma warning restore 0169

		static IntPtr id_getTeamRole;
		static IntPtr id_setTeamRole_Lcom_bluecats_sdk_BCTeamRole_;
		public virtual unsafe global::Com.Bluecats.Sdk.BCTeamRole TeamRole {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/method[@name='getTeamRole' and count(parameter)=0]"
			[Register ("getTeamRole", "()Lcom/bluecats/sdk/BCTeamRole;", "GetGetTeamRoleHandler")]
			get {
				if (id_getTeamRole == IntPtr.Zero)
					id_getTeamRole = JNIEnv.GetMethodID (class_ref, "getTeamRole", "()Lcom/bluecats/sdk/BCTeamRole;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamRole> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTeamRole), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamRole> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTeamRole", "()Lcom/bluecats/sdk/BCTeamRole;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/method[@name='setTeamRole' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCTeamRole']]"
			[Register ("setTeamRole", "(Lcom/bluecats/sdk/BCTeamRole;)V", "GetSetTeamRole_Lcom_bluecats_sdk_BCTeamRole_Handler")]
			set {
				if (id_setTeamRole_Lcom_bluecats_sdk_BCTeamRole_ == IntPtr.Zero)
					id_setTeamRole_Lcom_bluecats_sdk_BCTeamRole_ = JNIEnv.GetMethodID (class_ref, "setTeamRole", "(Lcom/bluecats/sdk/BCTeamRole;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTeamRole_Lcom_bluecats_sdk_BCTeamRole_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTeamRole", "(Lcom/bluecats/sdk/BCTeamRole;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTeammateCount;
#pragma warning disable 0169
		static Delegate GetGetTeammateCountHandler ()
		{
			if (cb_getTeammateCount == null)
				cb_getTeammateCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTeammateCount);
			return cb_getTeammateCount;
		}

		static IntPtr n_GetTeammateCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeam __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TeammateCount);
		}
#pragma warning restore 0169

		static Delegate cb_setTeammateCount_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetTeammateCount_Ljava_lang_Integer_Handler ()
		{
			if (cb_setTeammateCount_Ljava_lang_Integer_ == null)
				cb_setTeammateCount_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTeammateCount_Ljava_lang_Integer_);
			return cb_setTeammateCount_Ljava_lang_Integer_;
		}

		static void n_SetTeammateCount_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCTeam __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.TeammateCount = value;
		}
#pragma warning restore 0169

		static IntPtr id_getTeammateCount;
		static IntPtr id_setTeammateCount_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer TeammateCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/method[@name='getTeammateCount' and count(parameter)=0]"
			[Register ("getTeammateCount", "()Ljava/lang/Integer;", "GetGetTeammateCountHandler")]
			get {
				if (id_getTeammateCount == IntPtr.Zero)
					id_getTeammateCount = JNIEnv.GetMethodID (class_ref, "getTeammateCount", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTeammateCount), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTeammateCount", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/method[@name='setTeammateCount' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setTeammateCount", "(Ljava/lang/Integer;)V", "GetSetTeammateCount_Ljava_lang_Integer_Handler")]
			set {
				if (id_setTeammateCount_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setTeammateCount_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setTeammateCount", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTeammateCount_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTeammateCount", "(Ljava/lang/Integer;)V"), __args);
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
			global::Com.Bluecats.Sdk.BCTeam __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_getBeaconRegions;
#pragma warning disable 0169
		static Delegate GetGetBeaconRegionsHandler ()
		{
			if (cb_getBeaconRegions == null)
				cb_getBeaconRegions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeaconRegions);
			return cb_getBeaconRegions;
		}

		static IntPtr n_GetBeaconRegions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeam __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBeaconRegions ());
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconRegions;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/method[@name='getBeaconRegions' and count(parameter)=0]"
		[Register ("getBeaconRegions", "()[Lcom/bluecats/sdk/BCBeaconRegion;", "GetGetBeaconRegionsHandler")]
		public virtual unsafe global::Com.Bluecats.Sdk.BCBeaconRegion[] GetBeaconRegions ()
		{
			if (id_getBeaconRegions == IntPtr.Zero)
				id_getBeaconRegions = JNIEnv.GetMethodID (class_ref, "getBeaconRegions", "()[Lcom/bluecats/sdk/BCBeaconRegion;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Com.Bluecats.Sdk.BCBeaconRegion[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconRegions), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCBeaconRegion));
				else
					return (global::Com.Bluecats.Sdk.BCBeaconRegion[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeaconRegions", "()[Lcom/bluecats/sdk/BCBeaconRegion;")), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCBeaconRegion));
			} finally {
			}
		}

		static Delegate cb_getRecentAlerts;
#pragma warning disable 0169
		static Delegate GetGetRecentAlertsHandler ()
		{
			if (cb_getRecentAlerts == null)
				cb_getRecentAlerts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRecentAlerts);
			return cb_getRecentAlerts;
		}

		static IntPtr n_GetRecentAlerts (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeam __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRecentAlerts ());
		}
#pragma warning restore 0169

		static IntPtr id_getRecentAlerts;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/method[@name='getRecentAlerts' and count(parameter)=0]"
		[Register ("getRecentAlerts", "()[Lcom/bluecats/sdk/BCAlert;", "GetGetRecentAlertsHandler")]
		public virtual unsafe global::Com.Bluecats.Sdk.BCAlert[] GetRecentAlerts ()
		{
			if (id_getRecentAlerts == IntPtr.Zero)
				id_getRecentAlerts = JNIEnv.GetMethodID (class_ref, "getRecentAlerts", "()[Lcom/bluecats/sdk/BCAlert;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Com.Bluecats.Sdk.BCAlert[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRecentAlerts), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCAlert));
				else
					return (global::Com.Bluecats.Sdk.BCAlert[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRecentAlerts", "()[Lcom/bluecats/sdk/BCAlert;")), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCAlert));
			} finally {
			}
		}

		static Delegate cb_setBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_;
#pragma warning disable 0169
		static Delegate GetSetBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_Handler ()
		{
			if (cb_setBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_ == null)
				cb_setBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_);
			return cb_setBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_;
		}

		static void n_SetBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCTeam __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconRegion[] value = (global::Com.Bluecats.Sdk.BCBeaconRegion[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Bluecats.Sdk.BCBeaconRegion));
			__this.SetBeaconRegions (value);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		static IntPtr id_setBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/method[@name='setBeaconRegions' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconRegion[]']]"
		[Register ("setBeaconRegions", "([Lcom/bluecats/sdk/BCBeaconRegion;)V", "GetSetBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_Handler")]
		public virtual unsafe void SetBeaconRegions (global::Com.Bluecats.Sdk.BCBeaconRegion[] value)
		{
			if (id_setBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_ == IntPtr.Zero)
				id_setBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_ = JNIEnv.GetMethodID (class_ref, "setBeaconRegions", "([Lcom/bluecats/sdk/BCBeaconRegion;)V");
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBeaconRegions", "([Lcom/bluecats/sdk/BCBeaconRegion;)V"), __args);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_setRecentAlerts_arrayLcom_bluecats_sdk_BCAlert_;
#pragma warning disable 0169
		static Delegate GetSetRecentAlerts_arrayLcom_bluecats_sdk_BCAlert_Handler ()
		{
			if (cb_setRecentAlerts_arrayLcom_bluecats_sdk_BCAlert_ == null)
				cb_setRecentAlerts_arrayLcom_bluecats_sdk_BCAlert_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRecentAlerts_arrayLcom_bluecats_sdk_BCAlert_);
			return cb_setRecentAlerts_arrayLcom_bluecats_sdk_BCAlert_;
		}

		static void n_SetRecentAlerts_arrayLcom_bluecats_sdk_BCAlert_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCTeam __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCAlert[] value = (global::Com.Bluecats.Sdk.BCAlert[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Bluecats.Sdk.BCAlert));
			__this.SetRecentAlerts (value);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		static IntPtr id_setRecentAlerts_arrayLcom_bluecats_sdk_BCAlert_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/method[@name='setRecentAlerts' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCAlert[]']]"
		[Register ("setRecentAlerts", "([Lcom/bluecats/sdk/BCAlert;)V", "GetSetRecentAlerts_arrayLcom_bluecats_sdk_BCAlert_Handler")]
		public virtual unsafe void SetRecentAlerts (global::Com.Bluecats.Sdk.BCAlert[] value)
		{
			if (id_setRecentAlerts_arrayLcom_bluecats_sdk_BCAlert_ == IntPtr.Zero)
				id_setRecentAlerts_arrayLcom_bluecats_sdk_BCAlert_ = JNIEnv.GetMethodID (class_ref, "setRecentAlerts", "([Lcom/bluecats/sdk/BCAlert;)V");
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRecentAlerts_arrayLcom_bluecats_sdk_BCAlert_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRecentAlerts", "([Lcom/bluecats/sdk/BCAlert;)V"), __args);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Bluecats.Sdk.BCTeam __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeam']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
