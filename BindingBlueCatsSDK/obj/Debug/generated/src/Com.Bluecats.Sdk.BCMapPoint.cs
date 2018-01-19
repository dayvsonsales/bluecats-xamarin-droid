using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMapPoint']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCMapPoint", DoNotGenerateAcw=true)]
	public partial class BCMapPoint : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMapPoint']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/bluecats/sdk/BCMapPoint", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCMapPoint); }
		}

		protected BCMapPoint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMapPoint']/constructor[@name='BCMapPoint' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCMapPoint ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCMapPoint)) {
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
			global::Com.Bluecats.Sdk.BCMapPoint __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMapPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCMapPoint __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMapPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.MapID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getMapID;
		static IntPtr id_setMapID_Ljava_lang_String_;
		public virtual unsafe string MapID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMapPoint']/method[@name='getMapID' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMapPoint']/method[@name='setMapID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getMapName;
#pragma warning disable 0169
		static Delegate GetGetMapNameHandler ()
		{
			if (cb_getMapName == null)
				cb_getMapName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapName);
			return cb_getMapName;
		}

		static IntPtr n_GetMapName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMapPoint __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMapPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MapName);
		}
#pragma warning restore 0169

		static Delegate cb_setMapName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMapName_Ljava_lang_String_Handler ()
		{
			if (cb_setMapName_Ljava_lang_String_ == null)
				cb_setMapName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMapName_Ljava_lang_String_);
			return cb_setMapName_Ljava_lang_String_;
		}

		static void n_SetMapName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCMapPoint __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMapPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.MapName = value;
		}
#pragma warning restore 0169

		static IntPtr id_getMapName;
		static IntPtr id_setMapName_Ljava_lang_String_;
		public virtual unsafe string MapName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMapPoint']/method[@name='getMapName' and count(parameter)=0]"
			[Register ("getMapName", "()Ljava/lang/String;", "GetGetMapNameHandler")]
			get {
				if (id_getMapName == IntPtr.Zero)
					id_getMapName = JNIEnv.GetMethodID (class_ref, "getMapName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMapName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMapName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMapPoint']/method[@name='setMapName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMapName", "(Ljava/lang/String;)V", "GetSetMapName_Ljava_lang_String_Handler")]
			set {
				if (id_setMapName_Ljava_lang_String_ == IntPtr.Zero)
					id_setMapName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMapName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMapName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMapName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMapPointID;
#pragma warning disable 0169
		static Delegate GetGetMapPointIDHandler ()
		{
			if (cb_getMapPointID == null)
				cb_getMapPointID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapPointID);
			return cb_getMapPointID;
		}

		static IntPtr n_GetMapPointID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMapPoint __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMapPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MapPointID);
		}
#pragma warning restore 0169

		static Delegate cb_setMapPointID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMapPointID_Ljava_lang_String_Handler ()
		{
			if (cb_setMapPointID_Ljava_lang_String_ == null)
				cb_setMapPointID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMapPointID_Ljava_lang_String_);
			return cb_setMapPointID_Ljava_lang_String_;
		}

		static void n_SetMapPointID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCMapPoint __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMapPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.MapPointID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getMapPointID;
		static IntPtr id_setMapPointID_Ljava_lang_String_;
		public virtual unsafe string MapPointID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMapPoint']/method[@name='getMapPointID' and count(parameter)=0]"
			[Register ("getMapPointID", "()Ljava/lang/String;", "GetGetMapPointIDHandler")]
			get {
				if (id_getMapPointID == IntPtr.Zero)
					id_getMapPointID = JNIEnv.GetMethodID (class_ref, "getMapPointID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMapPointID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMapPointID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMapPoint']/method[@name='setMapPointID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMapPointID", "(Ljava/lang/String;)V", "GetSetMapPointID_Ljava_lang_String_Handler")]
			set {
				if (id_setMapPointID_Ljava_lang_String_ == IntPtr.Zero)
					id_setMapPointID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMapPointID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMapPointID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMapPointID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getModifiedAt;
#pragma warning disable 0169
		static Delegate GetGetModifiedAtHandler ()
		{
			if (cb_getModifiedAt == null)
				cb_getModifiedAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetModifiedAt);
			return cb_getModifiedAt;
		}

		static IntPtr n_GetModifiedAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMapPoint __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMapPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ModifiedAt);
		}
#pragma warning restore 0169

		static Delegate cb_setModifiedAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetModifiedAt_Ljava_util_Date_Handler ()
		{
			if (cb_setModifiedAt_Ljava_util_Date_ == null)
				cb_setModifiedAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetModifiedAt_Ljava_util_Date_);
			return cb_setModifiedAt_Ljava_util_Date_;
		}

		static void n_SetModifiedAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCMapPoint __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMapPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.ModifiedAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getModifiedAt;
		static IntPtr id_setModifiedAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date ModifiedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMapPoint']/method[@name='getModifiedAt' and count(parameter)=0]"
			[Register ("getModifiedAt", "()Ljava/util/Date;", "GetGetModifiedAtHandler")]
			get {
				if (id_getModifiedAt == IntPtr.Zero)
					id_getModifiedAt = JNIEnv.GetMethodID (class_ref, "getModifiedAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getModifiedAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getModifiedAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMapPoint']/method[@name='setModifiedAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setModifiedAt", "(Ljava/util/Date;)V", "GetSetModifiedAt_Ljava_util_Date_Handler")]
			set {
				if (id_setModifiedAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setModifiedAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setModifiedAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setModifiedAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setModifiedAt", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPoint;
#pragma warning disable 0169
		static Delegate GetGetPointHandler ()
		{
			if (cb_getPoint == null)
				cb_getPoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoint);
			return cb_getPoint;
		}

		static IntPtr n_GetPoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMapPoint __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMapPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Point);
		}
#pragma warning restore 0169

		static Delegate cb_setPoint_Lcom_bluecats_sdk_BCPoint_;
#pragma warning disable 0169
		static Delegate GetSetPoint_Lcom_bluecats_sdk_BCPoint_Handler ()
		{
			if (cb_setPoint_Lcom_bluecats_sdk_BCPoint_ == null)
				cb_setPoint_Lcom_bluecats_sdk_BCPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPoint_Lcom_bluecats_sdk_BCPoint_);
			return cb_setPoint_Lcom_bluecats_sdk_BCPoint_;
		}

		static void n_SetPoint_Lcom_bluecats_sdk_BCPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCMapPoint __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMapPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCPoint value = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPoint> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Point = value;
		}
#pragma warning restore 0169

		static IntPtr id_getPoint;
		static IntPtr id_setPoint_Lcom_bluecats_sdk_BCPoint_;
		public virtual unsafe global::Com.Bluecats.Sdk.BCPoint Point {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMapPoint']/method[@name='getPoint' and count(parameter)=0]"
			[Register ("getPoint", "()Lcom/bluecats/sdk/BCPoint;", "GetGetPointHandler")]
			get {
				if (id_getPoint == IntPtr.Zero)
					id_getPoint = JNIEnv.GetMethodID (class_ref, "getPoint", "()Lcom/bluecats/sdk/BCPoint;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPoint> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPoint), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPoint> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPoint", "()Lcom/bluecats/sdk/BCPoint;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMapPoint']/method[@name='setPoint' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCPoint']]"
			[Register ("setPoint", "(Lcom/bluecats/sdk/BCPoint;)V", "GetSetPoint_Lcom_bluecats_sdk_BCPoint_Handler")]
			set {
				if (id_setPoint_Lcom_bluecats_sdk_BCPoint_ == IntPtr.Zero)
					id_setPoint_Lcom_bluecats_sdk_BCPoint_ = JNIEnv.GetMethodID (class_ref, "setPoint", "(Lcom/bluecats/sdk/BCPoint;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPoint_Lcom_bluecats_sdk_BCPoint_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPoint", "(Lcom/bluecats/sdk/BCPoint;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_copy;
#pragma warning disable 0169
		static Delegate GetCopyHandler ()
		{
			if (cb_copy == null)
				cb_copy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Copy);
			return cb_copy;
		}

		static IntPtr n_Copy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCMapPoint __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMapPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Copy ());
		}
#pragma warning restore 0169

		static IntPtr id_copy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMapPoint']/method[@name='copy' and count(parameter)=0]"
		[Register ("copy", "()Lcom/bluecats/sdk/BCMapPoint;", "GetCopyHandler")]
		public virtual unsafe global::Com.Bluecats.Sdk.BCMapPoint Copy ()
		{
			if (id_copy == IntPtr.Zero)
				id_copy = JNIEnv.GetMethodID (class_ref, "copy", "()Lcom/bluecats/sdk/BCMapPoint;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMapPoint> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_copy), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMapPoint> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "copy", "()Lcom/bluecats/sdk/BCMapPoint;")), JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::Com.Bluecats.Sdk.BCMapPoint __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMapPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMapPoint']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Bluecats.Sdk.BCMapPoint __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMapPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCMapPoint']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
