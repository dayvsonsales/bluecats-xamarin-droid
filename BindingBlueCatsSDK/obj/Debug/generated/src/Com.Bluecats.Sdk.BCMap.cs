using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCMap", DoNotGenerateAcw=true)]
	public partial class BCMap : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/bluecats/sdk/BCMap", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCMap); }
		}

		protected BCMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/constructor[@name='BCMap' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCMap ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCMap)) {
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
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.CreatedAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCreatedAt;
		static IntPtr id_setCreatedAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date CreatedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='getCreatedAt' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='setCreatedAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
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

		static Delegate cb_getCreatedBy;
#pragma warning disable 0169
		static Delegate GetGetCreatedByHandler ()
		{
			if (cb_getCreatedBy == null)
				cb_getCreatedBy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreatedBy);
			return cb_getCreatedBy;
		}

		static IntPtr n_GetCreatedBy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreatedBy);
		}
#pragma warning restore 0169

		static Delegate cb_setCreatedBy_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCreatedBy_Ljava_lang_String_Handler ()
		{
			if (cb_setCreatedBy_Ljava_lang_String_ == null)
				cb_setCreatedBy_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCreatedBy_Ljava_lang_String_);
			return cb_setCreatedBy_Ljava_lang_String_;
		}

		static void n_SetCreatedBy_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.CreatedBy = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCreatedBy;
		static IntPtr id_setCreatedBy_Ljava_lang_String_;
		public virtual unsafe string CreatedBy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='getCreatedBy' and count(parameter)=0]"
			[Register ("getCreatedBy", "()Ljava/lang/String;", "GetGetCreatedByHandler")]
			get {
				if (id_getCreatedBy == IntPtr.Zero)
					id_getCreatedBy = JNIEnv.GetMethodID (class_ref, "getCreatedBy", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCreatedBy), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreatedBy", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='setCreatedBy' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCreatedBy", "(Ljava/lang/String;)V", "GetSetCreatedBy_Ljava_lang_String_Handler")]
			set {
				if (id_setCreatedBy_Ljava_lang_String_ == IntPtr.Zero)
					id_setCreatedBy_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCreatedBy", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCreatedBy_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCreatedBy", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.MapID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getMapID;
		static IntPtr id_setMapID_Ljava_lang_String_;
		public virtual unsafe string MapID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='getMapID' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='setMapID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getMapPointCount;
#pragma warning disable 0169
		static Delegate GetGetMapPointCountHandler ()
		{
			if (cb_getMapPointCount == null)
				cb_getMapPointCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMapPointCount);
			return cb_getMapPointCount;
		}

		static int n_GetMapPointCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MapPointCount;
		}
#pragma warning restore 0169

		static Delegate cb_setMapPointCount_I;
#pragma warning disable 0169
		static Delegate GetSetMapPointCount_IHandler ()
		{
			if (cb_setMapPointCount_I == null)
				cb_setMapPointCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMapPointCount_I);
			return cb_setMapPointCount_I;
		}

		static void n_SetMapPointCount_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MapPointCount = value;
		}
#pragma warning restore 0169

		static IntPtr id_getMapPointCount;
		static IntPtr id_setMapPointCount_I;
		public virtual unsafe int MapPointCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='getMapPointCount' and count(parameter)=0]"
			[Register ("getMapPointCount", "()I", "GetGetMapPointCountHandler")]
			get {
				if (id_getMapPointCount == IntPtr.Zero)
					id_getMapPointCount = JNIEnv.GetMethodID (class_ref, "getMapPointCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMapPointCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMapPointCount", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='setMapPointCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMapPointCount", "(I)V", "GetSetMapPointCount_IHandler")]
			set {
				if (id_setMapPointCount_I == IntPtr.Zero)
					id_setMapPointCount_I = JNIEnv.GetMethodID (class_ref, "setMapPointCount", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMapPointCount_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMapPointCount", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMapResource;
#pragma warning disable 0169
		static Delegate GetGetMapResourceHandler ()
		{
			if (cb_getMapResource == null)
				cb_getMapResource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapResource);
			return cb_getMapResource;
		}

		static IntPtr n_GetMapResource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MapResource);
		}
#pragma warning restore 0169

		static Delegate cb_setMapResource_Lcom_bluecats_sdk_BCResource_;
#pragma warning disable 0169
		static Delegate GetSetMapResource_Lcom_bluecats_sdk_BCResource_Handler ()
		{
			if (cb_setMapResource_Lcom_bluecats_sdk_BCResource_ == null)
				cb_setMapResource_Lcom_bluecats_sdk_BCResource_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMapResource_Lcom_bluecats_sdk_BCResource_);
			return cb_setMapResource_Lcom_bluecats_sdk_BCResource_;
		}

		static void n_SetMapResource_Lcom_bluecats_sdk_BCResource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCResource value = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCResource> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.MapResource = value;
		}
#pragma warning restore 0169

		static IntPtr id_getMapResource;
		static IntPtr id_setMapResource_Lcom_bluecats_sdk_BCResource_;
		public virtual unsafe global::Com.Bluecats.Sdk.BCResource MapResource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='getMapResource' and count(parameter)=0]"
			[Register ("getMapResource", "()Lcom/bluecats/sdk/BCResource;", "GetGetMapResourceHandler")]
			get {
				if (id_getMapResource == IntPtr.Zero)
					id_getMapResource = JNIEnv.GetMethodID (class_ref, "getMapResource", "()Lcom/bluecats/sdk/BCResource;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCResource> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMapResource), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCResource> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMapResource", "()Lcom/bluecats/sdk/BCResource;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='setMapResource' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCResource']]"
			[Register ("setMapResource", "(Lcom/bluecats/sdk/BCResource;)V", "GetSetMapResource_Lcom_bluecats_sdk_BCResource_Handler")]
			set {
				if (id_setMapResource_Lcom_bluecats_sdk_BCResource_ == IntPtr.Zero)
					id_setMapResource_Lcom_bluecats_sdk_BCResource_ = JNIEnv.GetMethodID (class_ref, "setMapResource", "(Lcom/bluecats/sdk/BCResource;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMapResource_Lcom_bluecats_sdk_BCResource_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMapResource", "(Lcom/bluecats/sdk/BCResource;)V"), __args);
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
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Name = value;
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		static IntPtr id_setName_Ljava_lang_String_;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='getName' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getScaleMarkerAx;
#pragma warning disable 0169
		static Delegate GetGetScaleMarkerAxHandler ()
		{
			if (cb_getScaleMarkerAx == null)
				cb_getScaleMarkerAx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScaleMarkerAx);
			return cb_getScaleMarkerAx;
		}

		static IntPtr n_GetScaleMarkerAx (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScaleMarkerAx);
		}
#pragma warning restore 0169

		static Delegate cb_setScaleMarkerAx_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetScaleMarkerAx_Ljava_lang_Double_Handler ()
		{
			if (cb_setScaleMarkerAx_Ljava_lang_Double_ == null)
				cb_setScaleMarkerAx_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScaleMarkerAx_Ljava_lang_Double_);
			return cb_setScaleMarkerAx_Ljava_lang_Double_;
		}

		static void n_SetScaleMarkerAx_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double value = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.ScaleMarkerAx = value;
		}
#pragma warning restore 0169

		static IntPtr id_getScaleMarkerAx;
		static IntPtr id_setScaleMarkerAx_Ljava_lang_Double_;
		public virtual unsafe global::Java.Lang.Double ScaleMarkerAx {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='getScaleMarkerAx' and count(parameter)=0]"
			[Register ("getScaleMarkerAx", "()Ljava/lang/Double;", "GetGetScaleMarkerAxHandler")]
			get {
				if (id_getScaleMarkerAx == IntPtr.Zero)
					id_getScaleMarkerAx = JNIEnv.GetMethodID (class_ref, "getScaleMarkerAx", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScaleMarkerAx), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScaleMarkerAx", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='setScaleMarkerAx' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setScaleMarkerAx", "(Ljava/lang/Double;)V", "GetSetScaleMarkerAx_Ljava_lang_Double_Handler")]
			set {
				if (id_setScaleMarkerAx_Ljava_lang_Double_ == IntPtr.Zero)
					id_setScaleMarkerAx_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setScaleMarkerAx", "(Ljava/lang/Double;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScaleMarkerAx_Ljava_lang_Double_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScaleMarkerAx", "(Ljava/lang/Double;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScaleMarkerAy;
#pragma warning disable 0169
		static Delegate GetGetScaleMarkerAyHandler ()
		{
			if (cb_getScaleMarkerAy == null)
				cb_getScaleMarkerAy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScaleMarkerAy);
			return cb_getScaleMarkerAy;
		}

		static IntPtr n_GetScaleMarkerAy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScaleMarkerAy);
		}
#pragma warning restore 0169

		static Delegate cb_setScaleMarkerAy_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetScaleMarkerAy_Ljava_lang_Double_Handler ()
		{
			if (cb_setScaleMarkerAy_Ljava_lang_Double_ == null)
				cb_setScaleMarkerAy_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScaleMarkerAy_Ljava_lang_Double_);
			return cb_setScaleMarkerAy_Ljava_lang_Double_;
		}

		static void n_SetScaleMarkerAy_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double value = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.ScaleMarkerAy = value;
		}
#pragma warning restore 0169

		static IntPtr id_getScaleMarkerAy;
		static IntPtr id_setScaleMarkerAy_Ljava_lang_Double_;
		public virtual unsafe global::Java.Lang.Double ScaleMarkerAy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='getScaleMarkerAy' and count(parameter)=0]"
			[Register ("getScaleMarkerAy", "()Ljava/lang/Double;", "GetGetScaleMarkerAyHandler")]
			get {
				if (id_getScaleMarkerAy == IntPtr.Zero)
					id_getScaleMarkerAy = JNIEnv.GetMethodID (class_ref, "getScaleMarkerAy", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScaleMarkerAy), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScaleMarkerAy", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='setScaleMarkerAy' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setScaleMarkerAy", "(Ljava/lang/Double;)V", "GetSetScaleMarkerAy_Ljava_lang_Double_Handler")]
			set {
				if (id_setScaleMarkerAy_Ljava_lang_Double_ == IntPtr.Zero)
					id_setScaleMarkerAy_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setScaleMarkerAy", "(Ljava/lang/Double;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScaleMarkerAy_Ljava_lang_Double_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScaleMarkerAy", "(Ljava/lang/Double;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScaleMarkerBx;
#pragma warning disable 0169
		static Delegate GetGetScaleMarkerBxHandler ()
		{
			if (cb_getScaleMarkerBx == null)
				cb_getScaleMarkerBx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScaleMarkerBx);
			return cb_getScaleMarkerBx;
		}

		static IntPtr n_GetScaleMarkerBx (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScaleMarkerBx);
		}
#pragma warning restore 0169

		static Delegate cb_setScaleMarkerBx_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetScaleMarkerBx_Ljava_lang_Double_Handler ()
		{
			if (cb_setScaleMarkerBx_Ljava_lang_Double_ == null)
				cb_setScaleMarkerBx_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScaleMarkerBx_Ljava_lang_Double_);
			return cb_setScaleMarkerBx_Ljava_lang_Double_;
		}

		static void n_SetScaleMarkerBx_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double value = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.ScaleMarkerBx = value;
		}
#pragma warning restore 0169

		static IntPtr id_getScaleMarkerBx;
		static IntPtr id_setScaleMarkerBx_Ljava_lang_Double_;
		public virtual unsafe global::Java.Lang.Double ScaleMarkerBx {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='getScaleMarkerBx' and count(parameter)=0]"
			[Register ("getScaleMarkerBx", "()Ljava/lang/Double;", "GetGetScaleMarkerBxHandler")]
			get {
				if (id_getScaleMarkerBx == IntPtr.Zero)
					id_getScaleMarkerBx = JNIEnv.GetMethodID (class_ref, "getScaleMarkerBx", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScaleMarkerBx), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScaleMarkerBx", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='setScaleMarkerBx' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setScaleMarkerBx", "(Ljava/lang/Double;)V", "GetSetScaleMarkerBx_Ljava_lang_Double_Handler")]
			set {
				if (id_setScaleMarkerBx_Ljava_lang_Double_ == IntPtr.Zero)
					id_setScaleMarkerBx_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setScaleMarkerBx", "(Ljava/lang/Double;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScaleMarkerBx_Ljava_lang_Double_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScaleMarkerBx", "(Ljava/lang/Double;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScaleMarkerBy;
#pragma warning disable 0169
		static Delegate GetGetScaleMarkerByHandler ()
		{
			if (cb_getScaleMarkerBy == null)
				cb_getScaleMarkerBy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScaleMarkerBy);
			return cb_getScaleMarkerBy;
		}

		static IntPtr n_GetScaleMarkerBy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScaleMarkerBy);
		}
#pragma warning restore 0169

		static Delegate cb_setScaleMarkerBy_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetScaleMarkerBy_Ljava_lang_Double_Handler ()
		{
			if (cb_setScaleMarkerBy_Ljava_lang_Double_ == null)
				cb_setScaleMarkerBy_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScaleMarkerBy_Ljava_lang_Double_);
			return cb_setScaleMarkerBy_Ljava_lang_Double_;
		}

		static void n_SetScaleMarkerBy_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double value = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.ScaleMarkerBy = value;
		}
#pragma warning restore 0169

		static IntPtr id_getScaleMarkerBy;
		static IntPtr id_setScaleMarkerBy_Ljava_lang_Double_;
		public virtual unsafe global::Java.Lang.Double ScaleMarkerBy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='getScaleMarkerBy' and count(parameter)=0]"
			[Register ("getScaleMarkerBy", "()Ljava/lang/Double;", "GetGetScaleMarkerByHandler")]
			get {
				if (id_getScaleMarkerBy == IntPtr.Zero)
					id_getScaleMarkerBy = JNIEnv.GetMethodID (class_ref, "getScaleMarkerBy", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScaleMarkerBy), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScaleMarkerBy", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='setScaleMarkerBy' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setScaleMarkerBy", "(Ljava/lang/Double;)V", "GetSetScaleMarkerBy_Ljava_lang_Double_Handler")]
			set {
				if (id_setScaleMarkerBy_Ljava_lang_Double_ == IntPtr.Zero)
					id_setScaleMarkerBy_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setScaleMarkerBy", "(Ljava/lang/Double;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScaleMarkerBy_Ljava_lang_Double_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScaleMarkerBy", "(Ljava/lang/Double;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScaleX;
#pragma warning disable 0169
		static Delegate GetGetScaleXHandler ()
		{
			if (cb_getScaleX == null)
				cb_getScaleX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScaleX);
			return cb_getScaleX;
		}

		static IntPtr n_GetScaleX (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScaleX);
		}
#pragma warning restore 0169

		static Delegate cb_setScaleX_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetScaleX_Ljava_lang_Double_Handler ()
		{
			if (cb_setScaleX_Ljava_lang_Double_ == null)
				cb_setScaleX_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScaleX_Ljava_lang_Double_);
			return cb_setScaleX_Ljava_lang_Double_;
		}

		static void n_SetScaleX_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double value = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.ScaleX = value;
		}
#pragma warning restore 0169

		static IntPtr id_getScaleX;
		static IntPtr id_setScaleX_Ljava_lang_Double_;
		public virtual unsafe global::Java.Lang.Double ScaleX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='getScaleX' and count(parameter)=0]"
			[Register ("getScaleX", "()Ljava/lang/Double;", "GetGetScaleXHandler")]
			get {
				if (id_getScaleX == IntPtr.Zero)
					id_getScaleX = JNIEnv.GetMethodID (class_ref, "getScaleX", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScaleX), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScaleX", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='setScaleX' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setScaleX", "(Ljava/lang/Double;)V", "GetSetScaleX_Ljava_lang_Double_Handler")]
			set {
				if (id_setScaleX_Ljava_lang_Double_ == IntPtr.Zero)
					id_setScaleX_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setScaleX", "(Ljava/lang/Double;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScaleX_Ljava_lang_Double_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScaleX", "(Ljava/lang/Double;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScaleY;
#pragma warning disable 0169
		static Delegate GetGetScaleYHandler ()
		{
			if (cb_getScaleY == null)
				cb_getScaleY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScaleY);
			return cb_getScaleY;
		}

		static IntPtr n_GetScaleY (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScaleY);
		}
#pragma warning restore 0169

		static Delegate cb_setScaleY_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetScaleY_Ljava_lang_Double_Handler ()
		{
			if (cb_setScaleY_Ljava_lang_Double_ == null)
				cb_setScaleY_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScaleY_Ljava_lang_Double_);
			return cb_setScaleY_Ljava_lang_Double_;
		}

		static void n_SetScaleY_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double value = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.ScaleY = value;
		}
#pragma warning restore 0169

		static IntPtr id_getScaleY;
		static IntPtr id_setScaleY_Ljava_lang_Double_;
		public virtual unsafe global::Java.Lang.Double ScaleY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='getScaleY' and count(parameter)=0]"
			[Register ("getScaleY", "()Ljava/lang/Double;", "GetGetScaleYHandler")]
			get {
				if (id_getScaleY == IntPtr.Zero)
					id_getScaleY = JNIEnv.GetMethodID (class_ref, "getScaleY", "()Ljava/lang/Double;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScaleY), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScaleY", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='setScaleY' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
			[Register ("setScaleY", "(Ljava/lang/Double;)V", "GetSetScaleY_Ljava_lang_Double_Handler")]
			set {
				if (id_setScaleY_Ljava_lang_Double_ == IntPtr.Zero)
					id_setScaleY_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setScaleY", "(Ljava/lang/Double;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScaleY_Ljava_lang_Double_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScaleY", "(Ljava/lang/Double;)V"), __args);
				} finally {
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
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SiteID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getSiteID;
		static IntPtr id_setSiteID_Ljava_lang_String_;
		public virtual unsafe string SiteID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='getSiteID' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='setSiteID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Bluecats.Sdk.BCMap __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMap']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
