using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategory']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCCategory", DoNotGenerateAcw=true)]
	public partial class BCCategory : global::Com.Bluecats.Sdk.BCCategoryApi, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategory']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr customValues_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategory']/field[@name='customValues']"
		[Register ("customValues")]
		protected IList<Com.Bluecats.Sdk.BCCustomValue> CustomValues {
			get {
				if (customValues_jfieldId == IntPtr.Zero)
					customValues_jfieldId = JNIEnv.GetFieldID (class_ref, "customValues", "[Lcom/bluecats/sdk/BCCustomValue;");
				return global::Android.Runtime.JavaArray<global::Com.Bluecats.Sdk.BCCustomValue>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, customValues_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (customValues_jfieldId == IntPtr.Zero)
					customValues_jfieldId = JNIEnv.GetFieldID (class_ref, "customValues", "[Lcom/bluecats/sdk/BCCustomValue;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Bluecats.Sdk.BCCustomValue>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, customValues_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategory.BCCategoryType']"
		[global::Android.Runtime.Register ("com/bluecats/sdk/BCCategory$BCCategoryType", DoNotGenerateAcw=true)]
		public sealed partial class BCCategoryType : global::Java.Lang.Enum {


			static IntPtr BC_CATEGORY_TYPE_BLUECATS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategory.BCCategoryType']/field[@name='BC_CATEGORY_TYPE_BLUECATS']"
			[Register ("BC_CATEGORY_TYPE_BLUECATS")]
			public static global::Com.Bluecats.Sdk.BCCategory.BCCategoryType BcCategoryTypeBluecats {
				get {
					if (BC_CATEGORY_TYPE_BLUECATS_jfieldId == IntPtr.Zero)
						BC_CATEGORY_TYPE_BLUECATS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_CATEGORY_TYPE_BLUECATS", "Lcom/bluecats/sdk/BCCategory$BCCategoryType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_CATEGORY_TYPE_BLUECATS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategory.BCCategoryType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_CATEGORY_TYPE_TEAM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategory.BCCategoryType']/field[@name='BC_CATEGORY_TYPE_TEAM']"
			[Register ("BC_CATEGORY_TYPE_TEAM")]
			public static global::Com.Bluecats.Sdk.BCCategory.BCCategoryType BcCategoryTypeTeam {
				get {
					if (BC_CATEGORY_TYPE_TEAM_jfieldId == IntPtr.Zero)
						BC_CATEGORY_TYPE_TEAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_CATEGORY_TYPE_TEAM", "Lcom/bluecats/sdk/BCCategory$BCCategoryType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_CATEGORY_TYPE_TEAM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategory.BCCategoryType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_CATEGORY_TYPE_UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategory.BCCategoryType']/field[@name='BC_CATEGORY_TYPE_UNKNOWN']"
			[Register ("BC_CATEGORY_TYPE_UNKNOWN")]
			public static global::Com.Bluecats.Sdk.BCCategory.BCCategoryType BcCategoryTypeUnknown {
				get {
					if (BC_CATEGORY_TYPE_UNKNOWN_jfieldId == IntPtr.Zero)
						BC_CATEGORY_TYPE_UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_CATEGORY_TYPE_UNKNOWN", "Lcom/bluecats/sdk/BCCategory$BCCategoryType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_CATEGORY_TYPE_UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategory.BCCategoryType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bluecats/sdk/BCCategory$BCCategoryType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BCCategoryType); }
			}

			internal BCCategoryType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getDisplayName;
			public unsafe string DisplayName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategory.BCCategoryType']/method[@name='getDisplayName' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategory.BCCategoryType']/method[@name='getValue' and count(parameter)=0]"
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

			static IntPtr id_getCategoryType_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategory.BCCategoryType']/method[@name='getCategoryType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getCategoryType", "(I)Lcom/bluecats/sdk/BCCategory$BCCategoryType;", "")]
			public static unsafe global::Com.Bluecats.Sdk.BCCategory.BCCategoryType GetCategoryType (int value)
			{
				if (id_getCategoryType_I == IntPtr.Zero)
					id_getCategoryType_I = JNIEnv.GetStaticMethodID (class_ref, "getCategoryType", "(I)Lcom/bluecats/sdk/BCCategory$BCCategoryType;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategory.BCCategoryType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCategoryType_I, __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategory.BCCategoryType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCCategory$BCCategoryType;", "")]
			public static unsafe global::Com.Bluecats.Sdk.BCCategory.BCCategoryType ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCCategory$BCCategoryType;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Com.Bluecats.Sdk.BCCategory.BCCategoryType __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategory.BCCategoryType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategory.BCCategoryType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bluecats/sdk/BCCategory$BCCategoryType;", "")]
			public static unsafe global::Com.Bluecats.Sdk.BCCategory.BCCategoryType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bluecats/sdk/BCCategory$BCCategoryType;");
				try {
					return (global::Com.Bluecats.Sdk.BCCategory.BCCategoryType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCCategory.BCCategoryType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCCategory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCCategory); }
		}

		protected BCCategory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategory']/constructor[@name='BCCategory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCCategory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCCategory)) {
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

		static Delegate cb_getCategoryType;
#pragma warning disable 0169
		static Delegate GetGetCategoryTypeHandler ()
		{
			if (cb_getCategoryType == null)
				cb_getCategoryType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCategoryType);
			return cb_getCategoryType;
		}

		static IntPtr n_GetCategoryType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCCategory __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CategoryType);
		}
#pragma warning restore 0169

		static IntPtr id_getCategoryType;
		public virtual unsafe global::Com.Bluecats.Sdk.BCCategory.BCCategoryType CategoryType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategory']/method[@name='getCategoryType' and count(parameter)=0]"
			[Register ("getCategoryType", "()Lcom/bluecats/sdk/BCCategory$BCCategoryType;", "GetGetCategoryTypeHandler")]
			get {
				if (id_getCategoryType == IntPtr.Zero)
					id_getCategoryType = JNIEnv.GetMethodID (class_ref, "getCategoryType", "()Lcom/bluecats/sdk/BCCategory$BCCategoryType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategory.BCCategoryType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCategoryType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategory.BCCategoryType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCategoryType", "()Lcom/bluecats/sdk/BCCategory$BCCategoryType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
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
			global::Com.Bluecats.Sdk.BCCategory __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCCategory __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CategoryTypeID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCategoryTypeID;
		static IntPtr id_setCategoryTypeID_I;
		public virtual unsafe int CategoryTypeID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategory']/method[@name='getCategoryTypeID' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategory']/method[@name='setCategoryTypeID' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Bluecats.Sdk.BCCategory __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCCategory __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Name = value;
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		static IntPtr id_setName_Ljava_lang_String_;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategory']/method[@name='getName' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategory']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bluecats.Sdk.BCCategory __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategory']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_getCustomValues;
#pragma warning disable 0169
		static Delegate GetGetCustomValuesHandler ()
		{
			if (cb_getCustomValues == null)
				cb_getCustomValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomValues);
			return cb_getCustomValues;
		}

		static IntPtr n_GetCustomValues (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCCategory __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCustomValues ());
		}
#pragma warning restore 0169

		static IntPtr id_getCustomValues;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategory']/method[@name='getCustomValues' and count(parameter)=0]"
		[Register ("getCustomValues", "()[Lcom/bluecats/sdk/BCCustomValue;", "GetGetCustomValuesHandler")]
		public virtual unsafe global::Com.Bluecats.Sdk.BCCustomValue[] GetCustomValues ()
		{
			if (id_getCustomValues == IntPtr.Zero)
				id_getCustomValues = JNIEnv.GetMethodID (class_ref, "getCustomValues", "()[Lcom/bluecats/sdk/BCCustomValue;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Com.Bluecats.Sdk.BCCustomValue[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCustomValues), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCCustomValue));
				else
					return (global::Com.Bluecats.Sdk.BCCustomValue[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCustomValues", "()[Lcom/bluecats/sdk/BCCustomValue;")), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCCustomValue));
			} finally {
			}
		}

		static Delegate cb_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_;
#pragma warning disable 0169
		static Delegate GetSetCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_Handler ()
		{
			if (cb_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_ == null)
				cb_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_);
			return cb_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_;
		}

		static void n_SetCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCCategory __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCCustomValue[] value = (global::Com.Bluecats.Sdk.BCCustomValue[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Bluecats.Sdk.BCCustomValue));
			__this.SetCustomValues (value);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		static IntPtr id_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategory']/method[@name='setCustomValues' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCCustomValue[]']]"
		[Register ("setCustomValues", "([Lcom/bluecats/sdk/BCCustomValue;)V", "GetSetCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_Handler")]
		public virtual unsafe void SetCustomValues (global::Com.Bluecats.Sdk.BCCustomValue[] value)
		{
			if (id_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_ == IntPtr.Zero)
				id_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_ = JNIEnv.GetMethodID (class_ref, "setCustomValues", "([Lcom/bluecats/sdk/BCCustomValue;)V");
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomValues", "([Lcom/bluecats/sdk/BCCustomValue;)V"), __args);
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
			global::Com.Bluecats.Sdk.BCCategory __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategory']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
