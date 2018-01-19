using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTargetSpeed']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCTargetSpeed", DoNotGenerateAcw=true)]
	public partial class BCTargetSpeed : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTargetSpeed']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTargetSpeed.BCSpeed']"
		[global::Android.Runtime.Register ("com/bluecats/sdk/BCTargetSpeed$BCSpeed", DoNotGenerateAcw=true)]
		public sealed partial class BCSpeed : global::Java.Lang.Enum {


			static IntPtr BC_SPEED_JOG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTargetSpeed.BCSpeed']/field[@name='BC_SPEED_JOG']"
			[Register ("BC_SPEED_JOG")]
			public static global::Com.Bluecats.Sdk.BCTargetSpeed.BCSpeed BcSpeedJog {
				get {
					if (BC_SPEED_JOG_jfieldId == IntPtr.Zero)
						BC_SPEED_JOG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_SPEED_JOG", "Lcom/bluecats/sdk/BCTargetSpeed$BCSpeed;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_SPEED_JOG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTargetSpeed.BCSpeed> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_SPEED_RUN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTargetSpeed.BCSpeed']/field[@name='BC_SPEED_RUN']"
			[Register ("BC_SPEED_RUN")]
			public static global::Com.Bluecats.Sdk.BCTargetSpeed.BCSpeed BcSpeedRun {
				get {
					if (BC_SPEED_RUN_jfieldId == IntPtr.Zero)
						BC_SPEED_RUN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_SPEED_RUN", "Lcom/bluecats/sdk/BCTargetSpeed$BCSpeed;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_SPEED_RUN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTargetSpeed.BCSpeed> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_SPEED_SIT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTargetSpeed.BCSpeed']/field[@name='BC_SPEED_SIT']"
			[Register ("BC_SPEED_SIT")]
			public static global::Com.Bluecats.Sdk.BCTargetSpeed.BCSpeed BcSpeedSit {
				get {
					if (BC_SPEED_SIT_jfieldId == IntPtr.Zero)
						BC_SPEED_SIT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_SPEED_SIT", "Lcom/bluecats/sdk/BCTargetSpeed$BCSpeed;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_SPEED_SIT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTargetSpeed.BCSpeed> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_SPEED_STROLL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTargetSpeed.BCSpeed']/field[@name='BC_SPEED_STROLL']"
			[Register ("BC_SPEED_STROLL")]
			public static global::Com.Bluecats.Sdk.BCTargetSpeed.BCSpeed BcSpeedStroll {
				get {
					if (BC_SPEED_STROLL_jfieldId == IntPtr.Zero)
						BC_SPEED_STROLL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_SPEED_STROLL", "Lcom/bluecats/sdk/BCTargetSpeed$BCSpeed;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_SPEED_STROLL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTargetSpeed.BCSpeed> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_SPEED_WALK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTargetSpeed.BCSpeed']/field[@name='BC_SPEED_WALK']"
			[Register ("BC_SPEED_WALK")]
			public static global::Com.Bluecats.Sdk.BCTargetSpeed.BCSpeed BcSpeedWalk {
				get {
					if (BC_SPEED_WALK_jfieldId == IntPtr.Zero)
						BC_SPEED_WALK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_SPEED_WALK", "Lcom/bluecats/sdk/BCTargetSpeed$BCSpeed;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_SPEED_WALK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTargetSpeed.BCSpeed> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bluecats/sdk/BCTargetSpeed$BCSpeed", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BCSpeed); }
			}

			internal BCSpeed (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getDisplayName;
			public unsafe string DisplayName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTargetSpeed.BCSpeed']/method[@name='getDisplayName' and count(parameter)=0]"
				[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler")]
				get {
					if (id_getDisplayName == IntPtr.Zero)
						id_getDisplayName = JNIEnv.GetMethodID (class_ref, "getDisplayName", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayName), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_getValue;
			public unsafe int Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTargetSpeed.BCSpeed']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()I", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
					try {
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getValue);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTargetSpeed.BCSpeed']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCTargetSpeed$BCSpeed;", "")]
			public static unsafe global::Com.Bluecats.Sdk.BCTargetSpeed.BCSpeed ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCTargetSpeed$BCSpeed;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Com.Bluecats.Sdk.BCTargetSpeed.BCSpeed __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTargetSpeed.BCSpeed> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTargetSpeed.BCSpeed']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bluecats/sdk/BCTargetSpeed$BCSpeed;", "")]
			public static unsafe global::Com.Bluecats.Sdk.BCTargetSpeed.BCSpeed[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bluecats/sdk/BCTargetSpeed$BCSpeed;");
				try {
					return (global::Com.Bluecats.Sdk.BCTargetSpeed.BCSpeed[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCTargetSpeed.BCSpeed));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCTargetSpeed", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCTargetSpeed); }
		}

		protected BCTargetSpeed (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTargetSpeed']/constructor[@name='BCTargetSpeed' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCTargetSpeed ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCTargetSpeed)) {
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

		static Delegate cb_getDisplayName;
#pragma warning disable 0169
		static Delegate GetGetDisplayNameHandler ()
		{
			if (cb_getDisplayName == null)
				cb_getDisplayName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayName);
			return cb_getDisplayName;
		}

		static IntPtr n_GetDisplayName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTargetSpeed __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTargetSpeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DisplayName);
		}
#pragma warning restore 0169

		static Delegate cb_setDisplayName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDisplayName_Ljava_lang_String_Handler ()
		{
			if (cb_setDisplayName_Ljava_lang_String_ == null)
				cb_setDisplayName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDisplayName_Ljava_lang_String_);
			return cb_setDisplayName_Ljava_lang_String_;
		}

		static void n_SetDisplayName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCTargetSpeed __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTargetSpeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.DisplayName = value;
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayName;
		static IntPtr id_setDisplayName_Ljava_lang_String_;
		public virtual unsafe string DisplayName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTargetSpeed']/method[@name='getDisplayName' and count(parameter)=0]"
			[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler")]
			get {
				if (id_getDisplayName == IntPtr.Zero)
					id_getDisplayName = JNIEnv.GetMethodID (class_ref, "getDisplayName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTargetSpeed']/method[@name='setDisplayName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDisplayName", "(Ljava/lang/String;)V", "GetSetDisplayName_Ljava_lang_String_Handler")]
			set {
				if (id_setDisplayName_Ljava_lang_String_ == IntPtr.Zero)
					id_setDisplayName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDisplayName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDisplayName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMilliseconds;
#pragma warning disable 0169
		static Delegate GetGetMillisecondsHandler ()
		{
			if (cb_getMilliseconds == null)
				cb_getMilliseconds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMilliseconds);
			return cb_getMilliseconds;
		}

		static int n_GetMilliseconds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTargetSpeed __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTargetSpeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Milliseconds;
		}
#pragma warning restore 0169

		static Delegate cb_setMilliseconds_I;
#pragma warning disable 0169
		static Delegate GetSetMilliseconds_IHandler ()
		{
			if (cb_setMilliseconds_I == null)
				cb_setMilliseconds_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMilliseconds_I);
			return cb_setMilliseconds_I;
		}

		static void n_SetMilliseconds_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Bluecats.Sdk.BCTargetSpeed __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTargetSpeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Milliseconds = value;
		}
#pragma warning restore 0169

		static IntPtr id_getMilliseconds;
		static IntPtr id_setMilliseconds_I;
		public virtual unsafe int Milliseconds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTargetSpeed']/method[@name='getMilliseconds' and count(parameter)=0]"
			[Register ("getMilliseconds", "()I", "GetGetMillisecondsHandler")]
			get {
				if (id_getMilliseconds == IntPtr.Zero)
					id_getMilliseconds = JNIEnv.GetMethodID (class_ref, "getMilliseconds", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMilliseconds);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMilliseconds", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTargetSpeed']/method[@name='setMilliseconds' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMilliseconds", "(I)V", "GetSetMilliseconds_IHandler")]
			set {
				if (id_setMilliseconds_I == IntPtr.Zero)
					id_setMilliseconds_I = JNIEnv.GetMethodID (class_ref, "setMilliseconds", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMilliseconds_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMilliseconds", "(I)V"), __args);
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
			global::Com.Bluecats.Sdk.BCTargetSpeed __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTargetSpeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCTargetSpeed __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTargetSpeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Name = value;
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		static IntPtr id_setName_Ljava_lang_String_;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTargetSpeed']/method[@name='getName' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTargetSpeed']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getTargetSpeedID;
#pragma warning disable 0169
		static Delegate GetGetTargetSpeedIDHandler ()
		{
			if (cb_getTargetSpeedID == null)
				cb_getTargetSpeedID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTargetSpeedID);
			return cb_getTargetSpeedID;
		}

		static int n_GetTargetSpeedID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTargetSpeed __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTargetSpeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TargetSpeedID;
		}
#pragma warning restore 0169

		static Delegate cb_setTargetSpeedID_I;
#pragma warning disable 0169
		static Delegate GetSetTargetSpeedID_IHandler ()
		{
			if (cb_setTargetSpeedID_I == null)
				cb_setTargetSpeedID_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTargetSpeedID_I);
			return cb_setTargetSpeedID_I;
		}

		static void n_SetTargetSpeedID_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Bluecats.Sdk.BCTargetSpeed __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTargetSpeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TargetSpeedID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getTargetSpeedID;
		static IntPtr id_setTargetSpeedID_I;
		public virtual unsafe int TargetSpeedID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTargetSpeed']/method[@name='getTargetSpeedID' and count(parameter)=0]"
			[Register ("getTargetSpeedID", "()I", "GetGetTargetSpeedIDHandler")]
			get {
				if (id_getTargetSpeedID == IntPtr.Zero)
					id_getTargetSpeedID = JNIEnv.GetMethodID (class_ref, "getTargetSpeedID", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTargetSpeedID);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTargetSpeedID", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTargetSpeed']/method[@name='setTargetSpeedID' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTargetSpeedID", "(I)V", "GetSetTargetSpeedID_IHandler")]
			set {
				if (id_setTargetSpeedID_I == IntPtr.Zero)
					id_setTargetSpeedID_I = JNIEnv.GetMethodID (class_ref, "setTargetSpeedID", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTargetSpeedID_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTargetSpeedID", "(I)V"), __args);
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
			global::Com.Bluecats.Sdk.BCTargetSpeed __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTargetSpeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTargetSpeed']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Bluecats.Sdk.BCTargetSpeed __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTargetSpeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTargetSpeed']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
