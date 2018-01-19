using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCResource']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCResource", DoNotGenerateAcw=true)]
	public partial class BCResource : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCResource']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/bluecats/sdk/BCResource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCResource); }
		}

		protected BCResource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Bluecats.Sdk.BCResource __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCResource __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.CreatedAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCreatedAt;
		static IntPtr id_setCreatedAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date CreatedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCResource']/method[@name='getCreatedAt' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCResource']/method[@name='setCreatedAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
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
			global::Com.Bluecats.Sdk.BCResource __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCResource __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.CreatedBy = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCreatedBy;
		static IntPtr id_setCreatedBy_Ljava_lang_String_;
		public virtual unsafe string CreatedBy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCResource']/method[@name='getCreatedBy' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCResource']/method[@name='setCreatedBy' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getFormat;
#pragma warning disable 0169
		static Delegate GetGetFormatHandler ()
		{
			if (cb_getFormat == null)
				cb_getFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormat);
			return cb_getFormat;
		}

		static IntPtr n_GetFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCResource __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Format);
		}
#pragma warning restore 0169

		static Delegate cb_setFormat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFormat_Ljava_lang_String_Handler ()
		{
			if (cb_setFormat_Ljava_lang_String_ == null)
				cb_setFormat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFormat_Ljava_lang_String_);
			return cb_setFormat_Ljava_lang_String_;
		}

		static void n_SetFormat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCResource __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Format = value;
		}
#pragma warning restore 0169

		static IntPtr id_getFormat;
		static IntPtr id_setFormat_Ljava_lang_String_;
		public virtual unsafe string Format {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCResource']/method[@name='getFormat' and count(parameter)=0]"
			[Register ("getFormat", "()Ljava/lang/String;", "GetGetFormatHandler")]
			get {
				if (id_getFormat == IntPtr.Zero)
					id_getFormat = JNIEnv.GetMethodID (class_ref, "getFormat", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormat), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFormat", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCResource']/method[@name='setFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFormat", "(Ljava/lang/String;)V", "GetSetFormat_Ljava_lang_String_Handler")]
			set {
				if (id_setFormat_Ljava_lang_String_ == IntPtr.Zero)
					id_setFormat_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFormat", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFormat_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFormat", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPublicID;
#pragma warning disable 0169
		static Delegate GetGetPublicIDHandler ()
		{
			if (cb_getPublicID == null)
				cb_getPublicID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPublicID);
			return cb_getPublicID;
		}

		static IntPtr n_GetPublicID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCResource __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PublicID);
		}
#pragma warning restore 0169

		static Delegate cb_setPublicID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPublicID_Ljava_lang_String_Handler ()
		{
			if (cb_setPublicID_Ljava_lang_String_ == null)
				cb_setPublicID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPublicID_Ljava_lang_String_);
			return cb_setPublicID_Ljava_lang_String_;
		}

		static void n_SetPublicID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCResource __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.PublicID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getPublicID;
		static IntPtr id_setPublicID_Ljava_lang_String_;
		public virtual unsafe string PublicID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCResource']/method[@name='getPublicID' and count(parameter)=0]"
			[Register ("getPublicID", "()Ljava/lang/String;", "GetGetPublicIDHandler")]
			get {
				if (id_getPublicID == IntPtr.Zero)
					id_getPublicID = JNIEnv.GetMethodID (class_ref, "getPublicID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPublicID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPublicID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCResource']/method[@name='setPublicID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPublicID", "(Ljava/lang/String;)V", "GetSetPublicID_Ljava_lang_String_Handler")]
			set {
				if (id_setPublicID_Ljava_lang_String_ == IntPtr.Zero)
					id_setPublicID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPublicID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPublicID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPublicID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getResourceID;
#pragma warning disable 0169
		static Delegate GetGetResourceIDHandler ()
		{
			if (cb_getResourceID == null)
				cb_getResourceID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResourceID);
			return cb_getResourceID;
		}

		static IntPtr n_GetResourceID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCResource __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResourceID);
		}
#pragma warning restore 0169

		static Delegate cb_setResourceID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResourceID_Ljava_lang_String_Handler ()
		{
			if (cb_setResourceID_Ljava_lang_String_ == null)
				cb_setResourceID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResourceID_Ljava_lang_String_);
			return cb_setResourceID_Ljava_lang_String_;
		}

		static void n_SetResourceID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCResource __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.ResourceID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getResourceID;
		static IntPtr id_setResourceID_Ljava_lang_String_;
		public virtual unsafe string ResourceID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCResource']/method[@name='getResourceID' and count(parameter)=0]"
			[Register ("getResourceID", "()Ljava/lang/String;", "GetGetResourceIDHandler")]
			get {
				if (id_getResourceID == IntPtr.Zero)
					id_getResourceID = JNIEnv.GetMethodID (class_ref, "getResourceID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResourceID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResourceID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCResource']/method[@name='setResourceID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResourceID", "(Ljava/lang/String;)V", "GetSetResourceID_Ljava_lang_String_Handler")]
			set {
				if (id_setResourceID_Ljava_lang_String_ == IntPtr.Zero)
					id_setResourceID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setResourceID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResourceID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResourceID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getResourceType;
#pragma warning disable 0169
		static Delegate GetGetResourceTypeHandler ()
		{
			if (cb_getResourceType == null)
				cb_getResourceType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResourceType);
			return cb_getResourceType;
		}

		static IntPtr n_GetResourceType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCResource __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ResourceType);
		}
#pragma warning restore 0169

		static Delegate cb_setResourceType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetResourceType_Ljava_lang_String_Handler ()
		{
			if (cb_setResourceType_Ljava_lang_String_ == null)
				cb_setResourceType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResourceType_Ljava_lang_String_);
			return cb_setResourceType_Ljava_lang_String_;
		}

		static void n_SetResourceType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCResource __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.ResourceType = value;
		}
#pragma warning restore 0169

		static IntPtr id_getResourceType;
		static IntPtr id_setResourceType_Ljava_lang_String_;
		public virtual unsafe string ResourceType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCResource']/method[@name='getResourceType' and count(parameter)=0]"
			[Register ("getResourceType", "()Ljava/lang/String;", "GetGetResourceTypeHandler")]
			get {
				if (id_getResourceType == IntPtr.Zero)
					id_getResourceType = JNIEnv.GetMethodID (class_ref, "getResourceType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResourceType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResourceType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCResource']/method[@name='setResourceType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setResourceType", "(Ljava/lang/String;)V", "GetSetResourceType_Ljava_lang_String_Handler")]
			set {
				if (id_setResourceType_Ljava_lang_String_ == IntPtr.Zero)
					id_setResourceType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setResourceType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResourceType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResourceType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSecureURL;
#pragma warning disable 0169
		static Delegate GetGetSecureURLHandler ()
		{
			if (cb_getSecureURL == null)
				cb_getSecureURL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSecureURL);
			return cb_getSecureURL;
		}

		static IntPtr n_GetSecureURL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCResource __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SecureURL);
		}
#pragma warning restore 0169

		static Delegate cb_setSecureURL_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSecureURL_Ljava_lang_String_Handler ()
		{
			if (cb_setSecureURL_Ljava_lang_String_ == null)
				cb_setSecureURL_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSecureURL_Ljava_lang_String_);
			return cb_setSecureURL_Ljava_lang_String_;
		}

		static void n_SetSecureURL_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCResource __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SecureURL = value;
		}
#pragma warning restore 0169

		static IntPtr id_getSecureURL;
		static IntPtr id_setSecureURL_Ljava_lang_String_;
		public virtual unsafe string SecureURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCResource']/method[@name='getSecureURL' and count(parameter)=0]"
			[Register ("getSecureURL", "()Ljava/lang/String;", "GetGetSecureURLHandler")]
			get {
				if (id_getSecureURL == IntPtr.Zero)
					id_getSecureURL = JNIEnv.GetMethodID (class_ref, "getSecureURL", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSecureURL), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSecureURL", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCResource']/method[@name='setSecureURL' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSecureURL", "(Ljava/lang/String;)V", "GetSetSecureURL_Ljava_lang_String_Handler")]
			set {
				if (id_setSecureURL_Ljava_lang_String_ == IntPtr.Zero)
					id_setSecureURL_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSecureURL", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSecureURL_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSecureURL", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getURL;
#pragma warning disable 0169
		static Delegate GetGetURLHandler ()
		{
			if (cb_getURL == null)
				cb_getURL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetURL);
			return cb_getURL;
		}

		static IntPtr n_GetURL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCResource __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.URL);
		}
#pragma warning restore 0169

		static Delegate cb_setURL_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetURL_Ljava_lang_String_Handler ()
		{
			if (cb_setURL_Ljava_lang_String_ == null)
				cb_setURL_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetURL_Ljava_lang_String_);
			return cb_setURL_Ljava_lang_String_;
		}

		static void n_SetURL_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCResource __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.URL = value;
		}
#pragma warning restore 0169

		static IntPtr id_getURL;
		static IntPtr id_setURL_Ljava_lang_String_;
		public virtual unsafe string URL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCResource']/method[@name='getURL' and count(parameter)=0]"
			[Register ("getURL", "()Ljava/lang/String;", "GetGetURLHandler")]
			get {
				if (id_getURL == IntPtr.Zero)
					id_getURL = JNIEnv.GetMethodID (class_ref, "getURL", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getURL), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getURL", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCResource']/method[@name='setURL' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setURL", "(Ljava/lang/String;)V", "GetSetURL_Ljava_lang_String_Handler")]
			set {
				if (id_setURL_Ljava_lang_String_ == IntPtr.Zero)
					id_setURL_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setURL", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setURL_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setURL", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVersion);
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCResource __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		static Delegate cb_setVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setVersion_Ljava_lang_String_ == null)
				cb_setVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVersion_Ljava_lang_String_);
			return cb_setVersion_Ljava_lang_String_;
		}

		static void n_SetVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCResource __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Version = value;
		}
#pragma warning restore 0169

		static IntPtr id_getVersion;
		static IntPtr id_setVersion_Ljava_lang_String_;
		public virtual unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCResource']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCResource']/method[@name='setVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVersion", "(Ljava/lang/String;)V", "GetSetVersion_Ljava_lang_String_Handler")]
			set {
				if (id_setVersion_Ljava_lang_String_ == IntPtr.Zero)
					id_setVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setVersion", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVersion_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVersion", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bluecats.Sdk.BCResource __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCResource']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Bluecats.Sdk.BCResource __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCResource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCResource']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
