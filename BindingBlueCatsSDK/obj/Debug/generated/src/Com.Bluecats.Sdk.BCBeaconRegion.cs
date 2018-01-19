using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCBeaconRegion", DoNotGenerateAcw=true)]
	public partial class BCBeaconRegion : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/bluecats/sdk/BCBeaconRegion", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCBeaconRegion); }
		}

		protected BCBeaconRegion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/constructor[@name='BCBeaconRegion' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCBeaconRegion ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCBeaconRegion)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/constructor[@name='BCBeaconRegion' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;)V", "")]
		public unsafe BCBeaconRegion (string _proximityUUIDString, global::Java.Lang.Integer _major, string _identifier)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__proximityUUIDString = JNIEnv.NewString (_proximityUUIDString);
			IntPtr native__identifier = JNIEnv.NewString (_identifier);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native__proximityUUIDString);
				__args [1] = new JValue (_major);
				__args [2] = new JValue (native__identifier);
				if (((object) this).GetType () != typeof (BCBeaconRegion)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__proximityUUIDString);
				JNIEnv.DeleteLocalRef (native__identifier);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/constructor[@name='BCBeaconRegion' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe BCBeaconRegion (string _proximityUUIDString, string _identifier)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__proximityUUIDString = JNIEnv.NewString (_proximityUUIDString);
			IntPtr native__identifier = JNIEnv.NewString (_identifier);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native__proximityUUIDString);
				__args [1] = new JValue (native__identifier);
				if (((object) this).GetType () != typeof (BCBeaconRegion)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__proximityUUIDString);
				JNIEnv.DeleteLocalRef (native__identifier);
			}
		}

		static Delegate cb_getCachedAt;
#pragma warning disable 0169
		static Delegate GetGetCachedAtHandler ()
		{
			if (cb_getCachedAt == null)
				cb_getCachedAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedAt);
			return cb_getCachedAt;
		}

		static IntPtr n_GetCachedAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CachedAt);
		}
#pragma warning restore 0169

		static Delegate cb_setCachedAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetCachedAt_Ljava_util_Date_Handler ()
		{
			if (cb_setCachedAt_Ljava_util_Date_ == null)
				cb_setCachedAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCachedAt_Ljava_util_Date_);
			return cb_setCachedAt_Ljava_util_Date_;
		}

		static void n_SetCachedAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.CachedAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCachedAt;
		static IntPtr id_setCachedAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date CachedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='getCachedAt' and count(parameter)=0]"
			[Register ("getCachedAt", "()Ljava/util/Date;", "GetGetCachedAtHandler")]
			get {
				if (id_getCachedAt == IntPtr.Zero)
					id_getCachedAt = JNIEnv.GetMethodID (class_ref, "getCachedAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='setCachedAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setCachedAt", "(Ljava/util/Date;)V", "GetSetCachedAt_Ljava_util_Date_Handler")]
			set {
				if (id_setCachedAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setCachedAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setCachedAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCachedAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCachedAt", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static Delegate cb_setId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetId_Ljava_lang_String_Handler ()
		{
			if (cb_setId_Ljava_lang_String_ == null)
				cb_setId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetId_Ljava_lang_String_);
			return cb_setId_Ljava_lang_String_;
		}

		static void n_SetId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			__this.Id = id;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_Ljava_lang_String_;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setId", "(Ljava/lang/String;)V", "GetSetId_Ljava_lang_String_Handler")]
			set {
				if (id_setId_Ljava_lang_String_ == IntPtr.Zero)
					id_setId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getIdentifier;
#pragma warning disable 0169
		static Delegate GetGetIdentifierHandler ()
		{
			if (cb_getIdentifier == null)
				cb_getIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIdentifier);
			return cb_getIdentifier;
		}

		static IntPtr n_GetIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Identifier);
		}
#pragma warning restore 0169

		static Delegate cb_setIdentifier_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIdentifier_Ljava_lang_String_Handler ()
		{
			if (cb_setIdentifier_Ljava_lang_String_ == null)
				cb_setIdentifier_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIdentifier_Ljava_lang_String_);
			return cb_setIdentifier_Ljava_lang_String_;
		}

		static void n_SetIdentifier_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Identifier = value;
		}
#pragma warning restore 0169

		static IntPtr id_getIdentifier;
		static IntPtr id_setIdentifier_Ljava_lang_String_;
		public virtual unsafe string Identifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='getIdentifier' and count(parameter)=0]"
			[Register ("getIdentifier", "()Ljava/lang/String;", "GetGetIdentifierHandler")]
			get {
				if (id_getIdentifier == IntPtr.Zero)
					id_getIdentifier = JNIEnv.GetMethodID (class_ref, "getIdentifier", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIdentifier), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIdentifier", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='setIdentifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIdentifier", "(Ljava/lang/String;)V", "GetSetIdentifier_Ljava_lang_String_Handler")]
			set {
				if (id_setIdentifier_Ljava_lang_String_ == IntPtr.Zero)
					id_setIdentifier_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setIdentifier", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIdentifier_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIdentifier", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getKeepAliveMajor;
#pragma warning disable 0169
		static Delegate GetGetKeepAliveMajorHandler ()
		{
			if (cb_getKeepAliveMajor == null)
				cb_getKeepAliveMajor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKeepAliveMajor);
			return cb_getKeepAliveMajor;
		}

		static IntPtr n_GetKeepAliveMajor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.KeepAliveMajor);
		}
#pragma warning restore 0169

		static Delegate cb_setKeepAliveMajor_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetKeepAliveMajor_Ljava_lang_Integer_Handler ()
		{
			if (cb_setKeepAliveMajor_Ljava_lang_Integer_ == null)
				cb_setKeepAliveMajor_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetKeepAliveMajor_Ljava_lang_Integer_);
			return cb_setKeepAliveMajor_Ljava_lang_Integer_;
		}

		static void n_SetKeepAliveMajor_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.KeepAliveMajor = value;
		}
#pragma warning restore 0169

		static IntPtr id_getKeepAliveMajor;
		static IntPtr id_setKeepAliveMajor_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer KeepAliveMajor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='getKeepAliveMajor' and count(parameter)=0]"
			[Register ("getKeepAliveMajor", "()Ljava/lang/Integer;", "GetGetKeepAliveMajorHandler")]
			get {
				if (id_getKeepAliveMajor == IntPtr.Zero)
					id_getKeepAliveMajor = JNIEnv.GetMethodID (class_ref, "getKeepAliveMajor", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKeepAliveMajor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeepAliveMajor", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='setKeepAliveMajor' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setKeepAliveMajor", "(Ljava/lang/Integer;)V", "GetSetKeepAliveMajor_Ljava_lang_Integer_Handler")]
			set {
				if (id_setKeepAliveMajor_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setKeepAliveMajor_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setKeepAliveMajor", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setKeepAliveMajor_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKeepAliveMajor", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getKeepAliveMinor;
#pragma warning disable 0169
		static Delegate GetGetKeepAliveMinorHandler ()
		{
			if (cb_getKeepAliveMinor == null)
				cb_getKeepAliveMinor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKeepAliveMinor);
			return cb_getKeepAliveMinor;
		}

		static IntPtr n_GetKeepAliveMinor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.KeepAliveMinor);
		}
#pragma warning restore 0169

		static Delegate cb_setKeepAliveMinor_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetKeepAliveMinor_Ljava_lang_Integer_Handler ()
		{
			if (cb_setKeepAliveMinor_Ljava_lang_Integer_ == null)
				cb_setKeepAliveMinor_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetKeepAliveMinor_Ljava_lang_Integer_);
			return cb_setKeepAliveMinor_Ljava_lang_Integer_;
		}

		static void n_SetKeepAliveMinor_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.KeepAliveMinor = value;
		}
#pragma warning restore 0169

		static IntPtr id_getKeepAliveMinor;
		static IntPtr id_setKeepAliveMinor_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer KeepAliveMinor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='getKeepAliveMinor' and count(parameter)=0]"
			[Register ("getKeepAliveMinor", "()Ljava/lang/Integer;", "GetGetKeepAliveMinorHandler")]
			get {
				if (id_getKeepAliveMinor == IntPtr.Zero)
					id_getKeepAliveMinor = JNIEnv.GetMethodID (class_ref, "getKeepAliveMinor", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKeepAliveMinor), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeepAliveMinor", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='setKeepAliveMinor' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setKeepAliveMinor", "(Ljava/lang/Integer;)V", "GetSetKeepAliveMinor_Ljava_lang_Integer_Handler")]
			set {
				if (id_setKeepAliveMinor_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setKeepAliveMinor_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setKeepAliveMinor", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setKeepAliveMinor_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKeepAliveMinor", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getKeepAliveProximityUUID;
#pragma warning disable 0169
		static Delegate GetGetKeepAliveProximityUUIDHandler ()
		{
			if (cb_getKeepAliveProximityUUID == null)
				cb_getKeepAliveProximityUUID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKeepAliveProximityUUID);
			return cb_getKeepAliveProximityUUID;
		}

		static IntPtr n_GetKeepAliveProximityUUID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.KeepAliveProximityUUID);
		}
#pragma warning restore 0169

		static Delegate cb_setKeepAliveProximityUUID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetKeepAliveProximityUUID_Ljava_lang_String_Handler ()
		{
			if (cb_setKeepAliveProximityUUID_Ljava_lang_String_ == null)
				cb_setKeepAliveProximityUUID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetKeepAliveProximityUUID_Ljava_lang_String_);
			return cb_setKeepAliveProximityUUID_Ljava_lang_String_;
		}

		static void n_SetKeepAliveProximityUUID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.KeepAliveProximityUUID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getKeepAliveProximityUUID;
		static IntPtr id_setKeepAliveProximityUUID_Ljava_lang_String_;
		public virtual unsafe string KeepAliveProximityUUID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='getKeepAliveProximityUUID' and count(parameter)=0]"
			[Register ("getKeepAliveProximityUUID", "()Ljava/lang/String;", "GetGetKeepAliveProximityUUIDHandler")]
			get {
				if (id_getKeepAliveProximityUUID == IntPtr.Zero)
					id_getKeepAliveProximityUUID = JNIEnv.GetMethodID (class_ref, "getKeepAliveProximityUUID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKeepAliveProximityUUID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeepAliveProximityUUID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='setKeepAliveProximityUUID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setKeepAliveProximityUUID", "(Ljava/lang/String;)V", "GetSetKeepAliveProximityUUID_Ljava_lang_String_Handler")]
			set {
				if (id_setKeepAliveProximityUUID_Ljava_lang_String_ == IntPtr.Zero)
					id_setKeepAliveProximityUUID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setKeepAliveProximityUUID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setKeepAliveProximityUUID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKeepAliveProximityUUID", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Major = value;
		}
#pragma warning restore 0169

		static IntPtr id_getMajor;
		static IntPtr id_setMajor_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Major {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='getMajor' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='setMajor' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
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
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Minor = value;
		}
#pragma warning restore 0169

		static IntPtr id_getMinor;
		static IntPtr id_setMinor_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Minor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='getMinor' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='setMinor' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
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

		static Delegate cb_getMonitorOnly;
#pragma warning disable 0169
		static Delegate GetGetMonitorOnlyHandler ()
		{
			if (cb_getMonitorOnly == null)
				cb_getMonitorOnly = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetMonitorOnly);
			return cb_getMonitorOnly;
		}

		static bool n_GetMonitorOnly (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MonitorOnly;
		}
#pragma warning restore 0169

		static Delegate cb_setMonitorOnly_Z;
#pragma warning disable 0169
		static Delegate GetSetMonitorOnly_ZHandler ()
		{
			if (cb_setMonitorOnly_Z == null)
				cb_setMonitorOnly_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMonitorOnly_Z);
			return cb_setMonitorOnly_Z;
		}

		static void n_SetMonitorOnly_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MonitorOnly = value;
		}
#pragma warning restore 0169

		static IntPtr id_getMonitorOnly;
		static IntPtr id_setMonitorOnly_Z;
		public virtual unsafe bool MonitorOnly {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='getMonitorOnly' and count(parameter)=0]"
			[Register ("getMonitorOnly", "()Z", "GetGetMonitorOnlyHandler")]
			get {
				if (id_getMonitorOnly == IntPtr.Zero)
					id_getMonitorOnly = JNIEnv.GetMethodID (class_ref, "getMonitorOnly", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getMonitorOnly);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMonitorOnly", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='setMonitorOnly' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMonitorOnly", "(Z)V", "GetSetMonitorOnly_ZHandler")]
			set {
				if (id_setMonitorOnly_Z == IntPtr.Zero)
					id_setMonitorOnly_Z = JNIEnv.GetMethodID (class_ref, "setMonitorOnly", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMonitorOnly_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMonitorOnly", "(Z)V"), __args);
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
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Name = value;
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		static IntPtr id_setName_Ljava_lang_String_;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='getName' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getNamespaceID;
#pragma warning disable 0169
		static Delegate GetGetNamespaceIDHandler ()
		{
			if (cb_getNamespaceID == null)
				cb_getNamespaceID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNamespaceID);
			return cb_getNamespaceID;
		}

		static IntPtr n_GetNamespaceID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NamespaceID);
		}
#pragma warning restore 0169

		static Delegate cb_setNamespaceID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNamespaceID_Ljava_lang_String_Handler ()
		{
			if (cb_setNamespaceID_Ljava_lang_String_ == null)
				cb_setNamespaceID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNamespaceID_Ljava_lang_String_);
			return cb_setNamespaceID_Ljava_lang_String_;
		}

		static void n_SetNamespaceID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.NamespaceID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getNamespaceID;
		static IntPtr id_setNamespaceID_Ljava_lang_String_;
		public virtual unsafe string NamespaceID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='getNamespaceID' and count(parameter)=0]"
			[Register ("getNamespaceID", "()Ljava/lang/String;", "GetGetNamespaceIDHandler")]
			get {
				if (id_getNamespaceID == IntPtr.Zero)
					id_getNamespaceID = JNIEnv.GetMethodID (class_ref, "getNamespaceID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNamespaceID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNamespaceID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='setNamespaceID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNamespaceID", "(Ljava/lang/String;)V", "GetSetNamespaceID_Ljava_lang_String_Handler")]
			set {
				if (id_setNamespaceID_Ljava_lang_String_ == IntPtr.Zero)
					id_setNamespaceID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNamespaceID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNamespaceID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNamespaceID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.ProximityUUIDString = value;
		}
#pragma warning restore 0169

		static IntPtr id_getProximityUUIDString;
		static IntPtr id_setProximityUUIDString_Ljava_lang_String_;
		public virtual unsafe string ProximityUUIDString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='getProximityUUIDString' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='setProximityUUIDString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetTeamID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_teamID)
		{
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string teamID = JNIEnv.GetString (native_teamID, JniHandleOwnership.DoNotTransfer);
			__this.TeamID = teamID;
		}
#pragma warning restore 0169

		static IntPtr id_getTeamID;
		static IntPtr id_setTeamID_Ljava_lang_String_;
		public virtual unsafe string TeamID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='getTeamID' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='setTeamID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_isAppManaged;
#pragma warning disable 0169
		static Delegate GetIsAppManagedHandler ()
		{
			if (cb_isAppManaged == null)
				cb_isAppManaged = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_IsAppManaged);
			return cb_isAppManaged;
		}

		static IntPtr n_IsAppManaged (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsAppManaged ());
		}
#pragma warning restore 0169

		static IntPtr id_isAppManaged;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='isAppManaged' and count(parameter)=0]"
		[Register ("isAppManaged", "()Ljava/lang/Boolean;", "GetIsAppManagedHandler")]
		public virtual unsafe global::Java.Lang.Boolean IsAppManaged ()
		{
			if (id_isAppManaged == IntPtr.Zero)
				id_isAppManaged = JNIEnv.GetMethodID (class_ref, "isAppManaged", "()Ljava/lang/Boolean;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_isAppManaged), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAppManaged", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setIsAppManaged_Z;
#pragma warning disable 0169
		static Delegate GetSetIsAppManaged_ZHandler ()
		{
			if (cb_setIsAppManaged_Z == null)
				cb_setIsAppManaged_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIsAppManaged_Z);
			return cb_setIsAppManaged_Z;
		}

		static void n_SetIsAppManaged_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIsAppManaged (value);
		}
#pragma warning restore 0169

		static IntPtr id_setIsAppManaged_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='setIsAppManaged' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIsAppManaged", "(Z)V", "GetSetIsAppManaged_ZHandler")]
		public virtual unsafe void SetIsAppManaged (bool value)
		{
			if (id_setIsAppManaged_Z == IntPtr.Zero)
				id_setIsAppManaged_Z = JNIEnv.GetMethodID (class_ref, "setIsAppManaged", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIsAppManaged_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIsAppManaged", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setKeepAliveProximityUUIDStringUpperCase;
#pragma warning disable 0169
		static Delegate GetSetKeepAliveProximityUUIDStringUpperCaseHandler ()
		{
			if (cb_setKeepAliveProximityUUIDStringUpperCase == null)
				cb_setKeepAliveProximityUUIDStringUpperCase = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetKeepAliveProximityUUIDStringUpperCase);
			return cb_setKeepAliveProximityUUIDStringUpperCase;
		}

		static void n_SetKeepAliveProximityUUIDStringUpperCase (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetKeepAliveProximityUUIDStringUpperCase ();
		}
#pragma warning restore 0169

		static IntPtr id_setKeepAliveProximityUUIDStringUpperCase;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='setKeepAliveProximityUUIDStringUpperCase' and count(parameter)=0]"
		[Register ("setKeepAliveProximityUUIDStringUpperCase", "()V", "GetSetKeepAliveProximityUUIDStringUpperCaseHandler")]
		public virtual unsafe void SetKeepAliveProximityUUIDStringUpperCase ()
		{
			if (id_setKeepAliveProximityUUIDStringUpperCase == IntPtr.Zero)
				id_setKeepAliveProximityUUIDStringUpperCase = JNIEnv.GetMethodID (class_ref, "setKeepAliveProximityUUIDStringUpperCase", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setKeepAliveProximityUUIDStringUpperCase);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKeepAliveProximityUUIDStringUpperCase", "()V"));
			} finally {
			}
		}

		static Delegate cb_setProximityUUIDStringUpperCase;
#pragma warning disable 0169
		static Delegate GetSetProximityUUIDStringUpperCaseHandler ()
		{
			if (cb_setProximityUUIDStringUpperCase == null)
				cb_setProximityUUIDStringUpperCase = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetProximityUUIDStringUpperCase);
			return cb_setProximityUUIDStringUpperCase;
		}

		static void n_SetProximityUUIDStringUpperCase (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetProximityUUIDStringUpperCase ();
		}
#pragma warning restore 0169

		static IntPtr id_setProximityUUIDStringUpperCase;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='setProximityUUIDStringUpperCase' and count(parameter)=0]"
		[Register ("setProximityUUIDStringUpperCase", "()V", "GetSetProximityUUIDStringUpperCaseHandler")]
		public virtual unsafe void SetProximityUUIDStringUpperCase ()
		{
			if (id_setProximityUUIDStringUpperCase == IntPtr.Zero)
				id_setProximityUUIDStringUpperCase = JNIEnv.GetMethodID (class_ref, "setProximityUUIDStringUpperCase", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setProximityUUIDStringUpperCase);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProximityUUIDStringUpperCase", "()V"));
			} finally {
			}
		}

		static Delegate cb_supportsBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_;
#pragma warning disable 0169
		static Delegate GetSupportsBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_Handler ()
		{
			if (cb_supportsBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_ == null)
				cb_supportsBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SupportsBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_);
			return cb_supportsBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_;
		}

		static bool n_SupportsBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_beaconMode)
		{
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconMode beaconMode = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconMode> (native_beaconMode, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SupportsBeaconMode (beaconMode);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_supportsBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='supportsBeaconMode' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconMode']]"
		[Register ("supportsBeaconMode", "(Lcom/bluecats/sdk/BCBeaconMode;)Z", "GetSupportsBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_Handler")]
		public virtual unsafe bool SupportsBeaconMode (global::Com.Bluecats.Sdk.BCBeaconMode beaconMode)
		{
			if (id_supportsBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_ == IntPtr.Zero)
				id_supportsBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_ = JNIEnv.GetMethodID (class_ref, "supportsBeaconMode", "(Lcom/bluecats/sdk/BCBeaconMode;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (beaconMode);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_supportsBeaconMode_Lcom_bluecats_sdk_BCBeaconMode_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "supportsBeaconMode", "(Lcom/bluecats/sdk/BCBeaconMode;)Z"), __args);
				return __ret;
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
			global::Com.Bluecats.Sdk.BCBeaconRegion __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconRegion> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconRegion']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
