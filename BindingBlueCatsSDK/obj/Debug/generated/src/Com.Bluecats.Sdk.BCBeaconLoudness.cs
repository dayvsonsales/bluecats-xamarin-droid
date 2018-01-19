using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCBeaconLoudness", DoNotGenerateAcw=true)]
	public partial class BCBeaconLoudness : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness.BCLoudness']"
		[global::Android.Runtime.Register ("com/bluecats/sdk/BCBeaconLoudness$BCLoudness", DoNotGenerateAcw=true)]
		public sealed partial class BCLoudness : global::Java.Lang.Enum {


			static IntPtr BC_LOUDNESS_MUTTER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness.BCLoudness']/field[@name='BC_LOUDNESS_MUTTER']"
			[Register ("BC_LOUDNESS_MUTTER")]
			public static global::Com.Bluecats.Sdk.BCBeaconLoudness.BCLoudness BcLoudnessMutter {
				get {
					if (BC_LOUDNESS_MUTTER_jfieldId == IntPtr.Zero)
						BC_LOUDNESS_MUTTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_LOUDNESS_MUTTER", "Lcom/bluecats/sdk/BCBeaconLoudness$BCLoudness;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_LOUDNESS_MUTTER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconLoudness.BCLoudness> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_LOUDNESS_SCREAM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness.BCLoudness']/field[@name='BC_LOUDNESS_SCREAM']"
			[Register ("BC_LOUDNESS_SCREAM")]
			public static global::Com.Bluecats.Sdk.BCBeaconLoudness.BCLoudness BcLoudnessScream {
				get {
					if (BC_LOUDNESS_SCREAM_jfieldId == IntPtr.Zero)
						BC_LOUDNESS_SCREAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_LOUDNESS_SCREAM", "Lcom/bluecats/sdk/BCBeaconLoudness$BCLoudness;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_LOUDNESS_SCREAM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconLoudness.BCLoudness> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_LOUDNESS_SHOUT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness.BCLoudness']/field[@name='BC_LOUDNESS_SHOUT']"
			[Register ("BC_LOUDNESS_SHOUT")]
			public static global::Com.Bluecats.Sdk.BCBeaconLoudness.BCLoudness BcLoudnessShout {
				get {
					if (BC_LOUDNESS_SHOUT_jfieldId == IntPtr.Zero)
						BC_LOUDNESS_SHOUT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_LOUDNESS_SHOUT", "Lcom/bluecats/sdk/BCBeaconLoudness$BCLoudness;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_LOUDNESS_SHOUT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconLoudness.BCLoudness> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_LOUDNESS_TALK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness.BCLoudness']/field[@name='BC_LOUDNESS_TALK']"
			[Register ("BC_LOUDNESS_TALK")]
			public static global::Com.Bluecats.Sdk.BCBeaconLoudness.BCLoudness BcLoudnessTalk {
				get {
					if (BC_LOUDNESS_TALK_jfieldId == IntPtr.Zero)
						BC_LOUDNESS_TALK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_LOUDNESS_TALK", "Lcom/bluecats/sdk/BCBeaconLoudness$BCLoudness;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_LOUDNESS_TALK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconLoudness.BCLoudness> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_LOUDNESS_WHISPER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness.BCLoudness']/field[@name='BC_LOUDNESS_WHISPER']"
			[Register ("BC_LOUDNESS_WHISPER")]
			public static global::Com.Bluecats.Sdk.BCBeaconLoudness.BCLoudness BcLoudnessWhisper {
				get {
					if (BC_LOUDNESS_WHISPER_jfieldId == IntPtr.Zero)
						BC_LOUDNESS_WHISPER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_LOUDNESS_WHISPER", "Lcom/bluecats/sdk/BCBeaconLoudness$BCLoudness;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_LOUDNESS_WHISPER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconLoudness.BCLoudness> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bluecats/sdk/BCBeaconLoudness$BCLoudness", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BCLoudness); }
			}

			internal BCLoudness (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getDisplayName;
			public unsafe string DisplayName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness.BCLoudness']/method[@name='getDisplayName' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness.BCLoudness']/method[@name='getValue' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness.BCLoudness']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCBeaconLoudness$BCLoudness;", "")]
			public static unsafe global::Com.Bluecats.Sdk.BCBeaconLoudness.BCLoudness ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCBeaconLoudness$BCLoudness;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Com.Bluecats.Sdk.BCBeaconLoudness.BCLoudness __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconLoudness.BCLoudness> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness.BCLoudness']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bluecats/sdk/BCBeaconLoudness$BCLoudness;", "")]
			public static unsafe global::Com.Bluecats.Sdk.BCBeaconLoudness.BCLoudness[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bluecats/sdk/BCBeaconLoudness$BCLoudness;");
				try {
					return (global::Com.Bluecats.Sdk.BCBeaconLoudness.BCLoudness[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCBeaconLoudness.BCLoudness));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCBeaconLoudness", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCBeaconLoudness); }
		}

		protected BCBeaconLoudness (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness']/constructor[@name='BCBeaconLoudness' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCBeaconLoudness ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCBeaconLoudness)) {
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

		static Delegate cb_getBeaconLoudnessID;
#pragma warning disable 0169
		static Delegate GetGetBeaconLoudnessIDHandler ()
		{
			if (cb_getBeaconLoudnessID == null)
				cb_getBeaconLoudnessID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBeaconLoudnessID);
			return cb_getBeaconLoudnessID;
		}

		static int n_GetBeaconLoudnessID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconLoudness __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconLoudness> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BeaconLoudnessID;
		}
#pragma warning restore 0169

		static Delegate cb_setBeaconLoudnessID_I;
#pragma warning disable 0169
		static Delegate GetSetBeaconLoudnessID_IHandler ()
		{
			if (cb_setBeaconLoudnessID_I == null)
				cb_setBeaconLoudnessID_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBeaconLoudnessID_I);
			return cb_setBeaconLoudnessID_I;
		}

		static void n_SetBeaconLoudnessID_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Bluecats.Sdk.BCBeaconLoudness __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconLoudness> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BeaconLoudnessID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconLoudnessID;
		static IntPtr id_setBeaconLoudnessID_I;
		public virtual unsafe int BeaconLoudnessID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness']/method[@name='getBeaconLoudnessID' and count(parameter)=0]"
			[Register ("getBeaconLoudnessID", "()I", "GetGetBeaconLoudnessIDHandler")]
			get {
				if (id_getBeaconLoudnessID == IntPtr.Zero)
					id_getBeaconLoudnessID = JNIEnv.GetMethodID (class_ref, "getBeaconLoudnessID", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconLoudnessID);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeaconLoudnessID", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness']/method[@name='setBeaconLoudnessID' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBeaconLoudnessID", "(I)V", "GetSetBeaconLoudnessID_IHandler")]
			set {
				if (id_setBeaconLoudnessID_I == IntPtr.Zero)
					id_setBeaconLoudnessID_I = JNIEnv.GetMethodID (class_ref, "setBeaconLoudnessID", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeaconLoudnessID_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBeaconLoudnessID", "(I)V"), __args);
				} finally {
				}
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
			global::Com.Bluecats.Sdk.BCBeaconLoudness __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconLoudness> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCBeaconLoudness __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconLoudness> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.DisplayName = value;
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayName;
		static IntPtr id_setDisplayName_Ljava_lang_String_;
		public virtual unsafe string DisplayName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness']/method[@name='getDisplayName' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness']/method[@name='setDisplayName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getLevel;
#pragma warning disable 0169
		static Delegate GetGetLevelHandler ()
		{
			if (cb_getLevel == null)
				cb_getLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLevel);
			return cb_getLevel;
		}

		static int n_GetLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconLoudness __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconLoudness> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Level;
		}
#pragma warning restore 0169

		static Delegate cb_setLevel_I;
#pragma warning disable 0169
		static Delegate GetSetLevel_IHandler ()
		{
			if (cb_setLevel_I == null)
				cb_setLevel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLevel_I);
			return cb_setLevel_I;
		}

		static void n_SetLevel_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Bluecats.Sdk.BCBeaconLoudness __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconLoudness> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Level = value;
		}
#pragma warning restore 0169

		static IntPtr id_getLevel;
		static IntPtr id_setLevel_I;
		public virtual unsafe int Level {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness']/method[@name='getLevel' and count(parameter)=0]"
			[Register ("getLevel", "()I", "GetGetLevelHandler")]
			get {
				if (id_getLevel == IntPtr.Zero)
					id_getLevel = JNIEnv.GetMethodID (class_ref, "getLevel", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLevel);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLevel", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness']/method[@name='setLevel' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLevel", "(I)V", "GetSetLevel_IHandler")]
			set {
				if (id_setLevel_I == IntPtr.Zero)
					id_setLevel_I = JNIEnv.GetMethodID (class_ref, "setLevel", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLevel_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLevel", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMeasuredPowerAt1Meter;
#pragma warning disable 0169
		static Delegate GetGetMeasuredPowerAt1MeterHandler ()
		{
			if (cb_getMeasuredPowerAt1Meter == null)
				cb_getMeasuredPowerAt1Meter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMeasuredPowerAt1Meter);
			return cb_getMeasuredPowerAt1Meter;
		}

		static int n_GetMeasuredPowerAt1Meter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCBeaconLoudness __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconLoudness> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MeasuredPowerAt1Meter;
		}
#pragma warning restore 0169

		static Delegate cb_setMeasuredPowerAt1Meter_I;
#pragma warning disable 0169
		static Delegate GetSetMeasuredPowerAt1Meter_IHandler ()
		{
			if (cb_setMeasuredPowerAt1Meter_I == null)
				cb_setMeasuredPowerAt1Meter_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMeasuredPowerAt1Meter_I);
			return cb_setMeasuredPowerAt1Meter_I;
		}

		static void n_SetMeasuredPowerAt1Meter_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Bluecats.Sdk.BCBeaconLoudness __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconLoudness> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MeasuredPowerAt1Meter = value;
		}
#pragma warning restore 0169

		static IntPtr id_getMeasuredPowerAt1Meter;
		static IntPtr id_setMeasuredPowerAt1Meter_I;
		public virtual unsafe int MeasuredPowerAt1Meter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness']/method[@name='getMeasuredPowerAt1Meter' and count(parameter)=0]"
			[Register ("getMeasuredPowerAt1Meter", "()I", "GetGetMeasuredPowerAt1MeterHandler")]
			get {
				if (id_getMeasuredPowerAt1Meter == IntPtr.Zero)
					id_getMeasuredPowerAt1Meter = JNIEnv.GetMethodID (class_ref, "getMeasuredPowerAt1Meter", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMeasuredPowerAt1Meter);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMeasuredPowerAt1Meter", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness']/method[@name='setMeasuredPowerAt1Meter' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMeasuredPowerAt1Meter", "(I)V", "GetSetMeasuredPowerAt1Meter_IHandler")]
			set {
				if (id_setMeasuredPowerAt1Meter_I == IntPtr.Zero)
					id_setMeasuredPowerAt1Meter_I = JNIEnv.GetMethodID (class_ref, "setMeasuredPowerAt1Meter", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMeasuredPowerAt1Meter_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMeasuredPowerAt1Meter", "(I)V"), __args);
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
			global::Com.Bluecats.Sdk.BCBeaconLoudness __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconLoudness> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCBeaconLoudness __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconLoudness> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Name = value;
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		static IntPtr id_setName_Ljava_lang_String_;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness']/method[@name='getName' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bluecats.Sdk.BCBeaconLoudness __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconLoudness> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Bluecats.Sdk.BCBeaconLoudness __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconLoudness> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCBeaconLoudness']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
