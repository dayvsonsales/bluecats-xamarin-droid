using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCError']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCError", DoNotGenerateAcw=true)]
	public partial class BCError : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCError", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCError); }
		}

		protected BCError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCError']/constructor[@name='BCError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe BCError (int statusCode, string message)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (statusCode);
				__args [1] = new JValue (native_message);
				if (((object) this).GetType () != typeof (BCError)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(ILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(ILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_ == IntPtr.Zero)
					id_ctor_ILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_ILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static IntPtr id_ctor_ILjava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCError']/constructor[@name='BCError' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register (".ctor", "(ILjava/lang/String;Ljava/util/Map;)V", "")]
		public unsafe BCError (int statusCode, string message, global::System.Collections.Generic.IDictionary<string, string> userInfo)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString (message);
			IntPtr native_userInfo = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (userInfo);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (statusCode);
				__args [1] = new JValue (native_message);
				__args [2] = new JValue (native_userInfo);
				if (((object) this).GetType () != typeof (BCError)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(ILjava/lang/String;Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(ILjava/lang/String;Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_ILjava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_ILjava_lang_String_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				JNIEnv.DeleteLocalRef (native_userInfo);
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCError __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		static Delegate cb_setMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setMessage_Ljava_lang_String_ == null)
				cb_setMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessage_Ljava_lang_String_);
			return cb_setMessage_Ljava_lang_String_;
		}

		static void n_SetMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCError __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Message = value;
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		static IntPtr id_setMessage_Ljava_lang_String_;
		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCError']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCError']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMessage", "(Ljava/lang/String;)V", "GetSetMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getStatusCode;
#pragma warning disable 0169
		static Delegate GetGetStatusCodeHandler ()
		{
			if (cb_getStatusCode == null)
				cb_getStatusCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStatusCode);
			return cb_getStatusCode;
		}

		static int n_GetStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCError __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StatusCode;
		}
#pragma warning restore 0169

		static Delegate cb_setStatusCode_I;
#pragma warning disable 0169
		static Delegate GetSetStatusCode_IHandler ()
		{
			if (cb_setStatusCode_I == null)
				cb_setStatusCode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStatusCode_I);
			return cb_setStatusCode_I;
		}

		static void n_SetStatusCode_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Bluecats.Sdk.BCError __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StatusCode = value;
		}
#pragma warning restore 0169

		static IntPtr id_getStatusCode;
		static IntPtr id_setStatusCode_I;
		public virtual unsafe int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCError']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "GetGetStatusCodeHandler")]
			get {
				if (id_getStatusCode == IntPtr.Zero)
					id_getStatusCode = JNIEnv.GetMethodID (class_ref, "getStatusCode", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getStatusCode);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatusCode", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCError']/method[@name='setStatusCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStatusCode", "(I)V", "GetSetStatusCode_IHandler")]
			set {
				if (id_setStatusCode_I == IntPtr.Zero)
					id_setStatusCode_I = JNIEnv.GetMethodID (class_ref, "setStatusCode", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStatusCode_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatusCode", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUserInfo;
#pragma warning disable 0169
		static Delegate GetGetUserInfoHandler ()
		{
			if (cb_getUserInfo == null)
				cb_getUserInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserInfo);
			return cb_getUserInfo;
		}

		static IntPtr n_GetUserInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCError __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.UserInfo);
		}
#pragma warning restore 0169

		static Delegate cb_setUserInfo_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetUserInfo_Ljava_util_Map_Handler ()
		{
			if (cb_setUserInfo_Ljava_util_Map_ == null)
				cb_setUserInfo_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserInfo_Ljava_util_Map_);
			return cb_setUserInfo_Ljava_util_Map_;
		}

		static void n_SetUserInfo_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCError __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCError> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_value, JniHandleOwnership.DoNotTransfer);
			__this.UserInfo = value;
		}
#pragma warning restore 0169

		static IntPtr id_getUserInfo;
		static IntPtr id_setUserInfo_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> UserInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCError']/method[@name='getUserInfo' and count(parameter)=0]"
			[Register ("getUserInfo", "()Ljava/util/Map;", "GetGetUserInfoHandler")]
			get {
				if (id_getUserInfo == IntPtr.Zero)
					id_getUserInfo = JNIEnv.GetMethodID (class_ref, "getUserInfo", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserInfo), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserInfo", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCError']/method[@name='setUserInfo' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setUserInfo", "(Ljava/util/Map;)V", "GetSetUserInfo_Ljava_util_Map_Handler")]
			set {
				if (id_setUserInfo_Ljava_util_Map_ == IntPtr.Zero)
					id_setUserInfo_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setUserInfo", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserInfo_Ljava_util_Map_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserInfo", "(Ljava/util/Map;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
