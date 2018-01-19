using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLassoManager']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCLassoManager", DoNotGenerateAcw=true)]
	public partial class BCLassoManager : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLassoManager.LassoDataType']"
		[global::Android.Runtime.Register ("com/bluecats/sdk/BCLassoManager$LassoDataType", DoNotGenerateAcw=true)]
		public sealed partial class LassoDataType : global::Java.Lang.Enum {


			static IntPtr LASSO_DATA_TYPE_ASCII_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLassoManager.LassoDataType']/field[@name='LASSO_DATA_TYPE_ASCII']"
			[Register ("LASSO_DATA_TYPE_ASCII")]
			public static global::Com.Bluecats.Sdk.BCLassoManager.LassoDataType LassoDataTypeAscii {
				get {
					if (LASSO_DATA_TYPE_ASCII_jfieldId == IntPtr.Zero)
						LASSO_DATA_TYPE_ASCII_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LASSO_DATA_TYPE_ASCII", "Lcom/bluecats/sdk/BCLassoManager$LassoDataType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LASSO_DATA_TYPE_ASCII_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLassoManager.LassoDataType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LASSO_DATA_TYPE_DATA_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLassoManager.LassoDataType']/field[@name='LASSO_DATA_TYPE_DATA']"
			[Register ("LASSO_DATA_TYPE_DATA")]
			public static global::Com.Bluecats.Sdk.BCLassoManager.LassoDataType LassoDataTypeData {
				get {
					if (LASSO_DATA_TYPE_DATA_jfieldId == IntPtr.Zero)
						LASSO_DATA_TYPE_DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LASSO_DATA_TYPE_DATA", "Lcom/bluecats/sdk/BCLassoManager$LassoDataType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LASSO_DATA_TYPE_DATA_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLassoManager.LassoDataType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LASSO_DATA_TYPE_DATE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLassoManager.LassoDataType']/field[@name='LASSO_DATA_TYPE_DATE']"
			[Register ("LASSO_DATA_TYPE_DATE")]
			public static global::Com.Bluecats.Sdk.BCLassoManager.LassoDataType LassoDataTypeDate {
				get {
					if (LASSO_DATA_TYPE_DATE_jfieldId == IntPtr.Zero)
						LASSO_DATA_TYPE_DATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LASSO_DATA_TYPE_DATE", "Lcom/bluecats/sdk/BCLassoManager$LassoDataType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LASSO_DATA_TYPE_DATE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLassoManager.LassoDataType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LASSO_DATA_TYPE_INTEGER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLassoManager.LassoDataType']/field[@name='LASSO_DATA_TYPE_INTEGER']"
			[Register ("LASSO_DATA_TYPE_INTEGER")]
			public static global::Com.Bluecats.Sdk.BCLassoManager.LassoDataType LassoDataTypeInteger {
				get {
					if (LASSO_DATA_TYPE_INTEGER_jfieldId == IntPtr.Zero)
						LASSO_DATA_TYPE_INTEGER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LASSO_DATA_TYPE_INTEGER", "Lcom/bluecats/sdk/BCLassoManager$LassoDataType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LASSO_DATA_TYPE_INTEGER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLassoManager.LassoDataType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bluecats/sdk/BCLassoManager$LassoDataType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LassoDataType); }
			}

			internal LassoDataType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLassoManager.LassoDataType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCLassoManager$LassoDataType;", "")]
			public static unsafe global::Com.Bluecats.Sdk.BCLassoManager.LassoDataType ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCLassoManager$LassoDataType;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Com.Bluecats.Sdk.BCLassoManager.LassoDataType __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLassoManager.LassoDataType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLassoManager.LassoDataType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bluecats/sdk/BCLassoManager$LassoDataType;", "")]
			public static unsafe global::Com.Bluecats.Sdk.BCLassoManager.LassoDataType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bluecats/sdk/BCLassoManager$LassoDataType;");
				try {
					return (global::Com.Bluecats.Sdk.BCLassoManager.LassoDataType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCLassoManager.LassoDataType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCLassoManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCLassoManager); }
		}

		protected BCLassoManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Bluecats.Sdk.BCLassoManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLassoManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/bluecats/sdk/BCLassoManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/bluecats/sdk/BCLassoManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLassoManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addLassoKeys_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddLassoKeys_Ljava_util_List_Handler ()
		{
			if (cb_addLassoKeys_Ljava_util_List_ == null)
				cb_addLassoKeys_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddLassoKeys_Ljava_util_List_);
			return cb_addLassoKeys_Ljava_util_List_;
		}

		static void n_AddLassoKeys_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lassoKeys)
		{
			global::Com.Bluecats.Sdk.BCLassoManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLassoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var lassoKeys = global::Android.Runtime.JavaList<string>.FromJniHandle (native_lassoKeys, JniHandleOwnership.DoNotTransfer);
			__this.AddLassoKeys (lassoKeys);
		}
#pragma warning restore 0169

		static IntPtr id_addLassoKeys_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLassoManager']/method[@name='addLassoKeys' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("addLassoKeys", "(Ljava/util/List;)V", "GetAddLassoKeys_Ljava_util_List_Handler")]
		public virtual unsafe void AddLassoKeys (global::System.Collections.Generic.IList<string> lassoKeys)
		{
			if (id_addLassoKeys_Ljava_util_List_ == IntPtr.Zero)
				id_addLassoKeys_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addLassoKeys", "(Ljava/util/List;)V");
			IntPtr native_lassoKeys = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (lassoKeys);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_lassoKeys);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addLassoKeys_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addLassoKeys", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_lassoKeys);
			}
		}

		static Delegate cb_registerLassoManagerCallback_Lcom_bluecats_sdk_BCLassoManagerCallback_;
#pragma warning disable 0169
		static Delegate GetRegisterLassoManagerCallback_Lcom_bluecats_sdk_BCLassoManagerCallback_Handler ()
		{
			if (cb_registerLassoManagerCallback_Lcom_bluecats_sdk_BCLassoManagerCallback_ == null)
				cb_registerLassoManagerCallback_Lcom_bluecats_sdk_BCLassoManagerCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterLassoManagerCallback_Lcom_bluecats_sdk_BCLassoManagerCallback_);
			return cb_registerLassoManagerCallback_Lcom_bluecats_sdk_BCLassoManagerCallback_;
		}

		static void n_RegisterLassoManagerCallback_Lcom_bluecats_sdk_BCLassoManagerCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCLassoManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLassoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCLassoManagerCallback @callback = (global::Com.Bluecats.Sdk.IBCLassoManagerCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCLassoManagerCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.RegisterLassoManagerCallback (@callback);
		}
#pragma warning restore 0169

		static IntPtr id_registerLassoManagerCallback_Lcom_bluecats_sdk_BCLassoManagerCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLassoManager']/method[@name='registerLassoManagerCallback' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCLassoManagerCallback']]"
		[Register ("registerLassoManagerCallback", "(Lcom/bluecats/sdk/BCLassoManagerCallback;)V", "GetRegisterLassoManagerCallback_Lcom_bluecats_sdk_BCLassoManagerCallback_Handler")]
		public virtual unsafe void RegisterLassoManagerCallback (global::Com.Bluecats.Sdk.IBCLassoManagerCallback @callback)
		{
			if (id_registerLassoManagerCallback_Lcom_bluecats_sdk_BCLassoManagerCallback_ == IntPtr.Zero)
				id_registerLassoManagerCallback_Lcom_bluecats_sdk_BCLassoManagerCallback_ = JNIEnv.GetMethodID (class_ref, "registerLassoManagerCallback", "(Lcom/bluecats/sdk/BCLassoManagerCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerLassoManagerCallback_Lcom_bluecats_sdk_BCLassoManagerCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerLassoManagerCallback", "(Lcom/bluecats/sdk/BCLassoManagerCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeLassoKeys_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetRemoveLassoKeys_Ljava_util_List_Handler ()
		{
			if (cb_removeLassoKeys_Ljava_util_List_ == null)
				cb_removeLassoKeys_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveLassoKeys_Ljava_util_List_);
			return cb_removeLassoKeys_Ljava_util_List_;
		}

		static void n_RemoveLassoKeys_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lassoKeys)
		{
			global::Com.Bluecats.Sdk.BCLassoManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLassoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var lassoKeys = global::Android.Runtime.JavaList<string>.FromJniHandle (native_lassoKeys, JniHandleOwnership.DoNotTransfer);
			__this.RemoveLassoKeys (lassoKeys);
		}
#pragma warning restore 0169

		static IntPtr id_removeLassoKeys_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLassoManager']/method[@name='removeLassoKeys' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("removeLassoKeys", "(Ljava/util/List;)V", "GetRemoveLassoKeys_Ljava_util_List_Handler")]
		public virtual unsafe void RemoveLassoKeys (global::System.Collections.Generic.IList<string> lassoKeys)
		{
			if (id_removeLassoKeys_Ljava_util_List_ == IntPtr.Zero)
				id_removeLassoKeys_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "removeLassoKeys", "(Ljava/util/List;)V");
			IntPtr native_lassoKeys = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (lassoKeys);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_lassoKeys);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeLassoKeys_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeLassoKeys", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_lassoKeys);
			}
		}

		static Delegate cb_setEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetEnabled_ZHandler ()
		{
			if (cb_setEnabled_Z == null)
				cb_setEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEnabled_Z);
			return cb_setEnabled_Z;
		}

		static void n_SetEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Com.Bluecats.Sdk.BCLassoManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLassoManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetEnabled (enabled);
		}
#pragma warning restore 0169

		static IntPtr id_setEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLassoManager']/method[@name='setEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnabled", "(Z)V", "GetSetEnabled_ZHandler")]
		public virtual unsafe void SetEnabled (bool enabled)
		{
			if (id_setEnabled_Z == IntPtr.Zero)
				id_setEnabled_Z = JNIEnv.GetMethodID (class_ref, "setEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (enabled);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEnabled_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnabled", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
