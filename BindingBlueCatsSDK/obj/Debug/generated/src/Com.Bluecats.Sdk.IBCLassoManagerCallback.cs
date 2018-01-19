using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCLassoManagerCallback']"
	[Register ("com/bluecats/sdk/BCLassoManagerCallback", "", "Com.Bluecats.Sdk.IBCLassoManagerCallbackInvoker")]
	public partial interface IBCLassoManagerCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCLassoManagerCallback']/method[@name='didEnterLasso' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCLasso']]"
		[Register ("didEnterLasso", "(Lcom/bluecats/sdk/BCLasso;)V", "GetDidEnterLasso_Lcom_bluecats_sdk_BCLasso_Handler:Com.Bluecats.Sdk.IBCLassoManagerCallbackInvoker, BindingBlueCatsSDK")]
		void DidEnterLasso (global::Com.Bluecats.Sdk.BCLasso p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCLassoManagerCallback']/method[@name='didExitLasso' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCLasso']]"
		[Register ("didExitLasso", "(Lcom/bluecats/sdk/BCLasso;)V", "GetDidExitLasso_Lcom_bluecats_sdk_BCLasso_Handler:Com.Bluecats.Sdk.IBCLassoManagerCallbackInvoker, BindingBlueCatsSDK")]
		void DidExitLasso (global::Com.Bluecats.Sdk.BCLasso p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCLassoManagerCallback']/method[@name='didLassoResponse' and count(parameter)=3 and parameter[1][@type='com.bluecats.sdk.BCLasso'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;'] and parameter[3][@type='com.bluecats.sdk.BCError']]"
		[Register ("didLassoResponse", "(Lcom/bluecats/sdk/BCLasso;Ljava/util/Map;Lcom/bluecats/sdk/BCError;)V", "GetDidLassoResponse_Lcom_bluecats_sdk_BCLasso_Ljava_util_Map_Lcom_bluecats_sdk_BCError_Handler:Com.Bluecats.Sdk.IBCLassoManagerCallbackInvoker, BindingBlueCatsSDK")]
		void DidLassoResponse (global::Com.Bluecats.Sdk.BCLasso p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1, global::Com.Bluecats.Sdk.BCError p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCLassoManagerCallback']/method[@name='didRangeLasso' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCLasso']]"
		[Register ("didRangeLasso", "(Lcom/bluecats/sdk/BCLasso;)V", "GetDidRangeLasso_Lcom_bluecats_sdk_BCLasso_Handler:Com.Bluecats.Sdk.IBCLassoManagerCallbackInvoker, BindingBlueCatsSDK")]
		void DidRangeLasso (global::Com.Bluecats.Sdk.BCLasso p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCLassoManagerCallback']/method[@name='getMappingForLasso' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCLasso']]"
		[Register ("getMappingForLasso", "(Lcom/bluecats/sdk/BCLasso;)Ljava/util/Map;", "GetGetMappingForLasso_Lcom_bluecats_sdk_BCLasso_Handler:Com.Bluecats.Sdk.IBCLassoManagerCallbackInvoker, BindingBlueCatsSDK")]
		global::System.Collections.Generic.IDictionary<string, string> GetMappingForLasso (global::Com.Bluecats.Sdk.BCLasso p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCLassoManagerCallback']/method[@name='shouldBeginRedemptionRequest' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCLasso']]"
		[Register ("shouldBeginRedemptionRequest", "(Lcom/bluecats/sdk/BCLasso;)Z", "GetShouldBeginRedemptionRequest_Lcom_bluecats_sdk_BCLasso_Handler:Com.Bluecats.Sdk.IBCLassoManagerCallbackInvoker, BindingBlueCatsSDK")]
		bool ShouldBeginRedemptionRequest (global::Com.Bluecats.Sdk.BCLasso p0);

	}

	[global::Android.Runtime.Register ("com/bluecats/sdk/BCLassoManagerCallback", DoNotGenerateAcw=true)]
	internal class IBCLassoManagerCallbackInvoker : global::Java.Lang.Object, IBCLassoManagerCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bluecats/sdk/BCLassoManagerCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBCLassoManagerCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBCLassoManagerCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBCLassoManagerCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bluecats.sdk.BCLassoManagerCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBCLassoManagerCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_didEnterLasso_Lcom_bluecats_sdk_BCLasso_;
#pragma warning disable 0169
		static Delegate GetDidEnterLasso_Lcom_bluecats_sdk_BCLasso_Handler ()
		{
			if (cb_didEnterLasso_Lcom_bluecats_sdk_BCLasso_ == null)
				cb_didEnterLasso_Lcom_bluecats_sdk_BCLasso_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DidEnterLasso_Lcom_bluecats_sdk_BCLasso_);
			return cb_didEnterLasso_Lcom_bluecats_sdk_BCLasso_;
		}

		static void n_DidEnterLasso_Lcom_bluecats_sdk_BCLasso_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCLassoManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCLassoManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCLasso p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLasso> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DidEnterLasso (p0);
		}
#pragma warning restore 0169

		IntPtr id_didEnterLasso_Lcom_bluecats_sdk_BCLasso_;
		public unsafe void DidEnterLasso (global::Com.Bluecats.Sdk.BCLasso p0)
		{
			if (id_didEnterLasso_Lcom_bluecats_sdk_BCLasso_ == IntPtr.Zero)
				id_didEnterLasso_Lcom_bluecats_sdk_BCLasso_ = JNIEnv.GetMethodID (class_ref, "didEnterLasso", "(Lcom/bluecats/sdk/BCLasso;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didEnterLasso_Lcom_bluecats_sdk_BCLasso_, __args);
		}

		static Delegate cb_didExitLasso_Lcom_bluecats_sdk_BCLasso_;
#pragma warning disable 0169
		static Delegate GetDidExitLasso_Lcom_bluecats_sdk_BCLasso_Handler ()
		{
			if (cb_didExitLasso_Lcom_bluecats_sdk_BCLasso_ == null)
				cb_didExitLasso_Lcom_bluecats_sdk_BCLasso_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DidExitLasso_Lcom_bluecats_sdk_BCLasso_);
			return cb_didExitLasso_Lcom_bluecats_sdk_BCLasso_;
		}

		static void n_DidExitLasso_Lcom_bluecats_sdk_BCLasso_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCLassoManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCLassoManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCLasso p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLasso> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DidExitLasso (p0);
		}
#pragma warning restore 0169

		IntPtr id_didExitLasso_Lcom_bluecats_sdk_BCLasso_;
		public unsafe void DidExitLasso (global::Com.Bluecats.Sdk.BCLasso p0)
		{
			if (id_didExitLasso_Lcom_bluecats_sdk_BCLasso_ == IntPtr.Zero)
				id_didExitLasso_Lcom_bluecats_sdk_BCLasso_ = JNIEnv.GetMethodID (class_ref, "didExitLasso", "(Lcom/bluecats/sdk/BCLasso;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didExitLasso_Lcom_bluecats_sdk_BCLasso_, __args);
		}

		static Delegate cb_didLassoResponse_Lcom_bluecats_sdk_BCLasso_Ljava_util_Map_Lcom_bluecats_sdk_BCError_;
#pragma warning disable 0169
		static Delegate GetDidLassoResponse_Lcom_bluecats_sdk_BCLasso_Ljava_util_Map_Lcom_bluecats_sdk_BCError_Handler ()
		{
			if (cb_didLassoResponse_Lcom_bluecats_sdk_BCLasso_Ljava_util_Map_Lcom_bluecats_sdk_BCError_ == null)
				cb_didLassoResponse_Lcom_bluecats_sdk_BCLasso_Ljava_util_Map_Lcom_bluecats_sdk_BCError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DidLassoResponse_Lcom_bluecats_sdk_BCLasso_Ljava_util_Map_Lcom_bluecats_sdk_BCError_);
			return cb_didLassoResponse_Lcom_bluecats_sdk_BCLasso_Ljava_util_Map_Lcom_bluecats_sdk_BCError_;
		}

		static void n_DidLassoResponse_Lcom_bluecats_sdk_BCLasso_Ljava_util_Map_Lcom_bluecats_sdk_BCError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Bluecats.Sdk.IBCLassoManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCLassoManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCLasso p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLasso> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCError p2 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCError> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DidLassoResponse (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_didLassoResponse_Lcom_bluecats_sdk_BCLasso_Ljava_util_Map_Lcom_bluecats_sdk_BCError_;
		public unsafe void DidLassoResponse (global::Com.Bluecats.Sdk.BCLasso p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1, global::Com.Bluecats.Sdk.BCError p2)
		{
			if (id_didLassoResponse_Lcom_bluecats_sdk_BCLasso_Ljava_util_Map_Lcom_bluecats_sdk_BCError_ == IntPtr.Zero)
				id_didLassoResponse_Lcom_bluecats_sdk_BCLasso_Ljava_util_Map_Lcom_bluecats_sdk_BCError_ = JNIEnv.GetMethodID (class_ref, "didLassoResponse", "(Lcom/bluecats/sdk/BCLasso;Ljava/util/Map;Lcom/bluecats/sdk/BCError;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didLassoResponse_Lcom_bluecats_sdk_BCLasso_Ljava_util_Map_Lcom_bluecats_sdk_BCError_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_didRangeLasso_Lcom_bluecats_sdk_BCLasso_;
#pragma warning disable 0169
		static Delegate GetDidRangeLasso_Lcom_bluecats_sdk_BCLasso_Handler ()
		{
			if (cb_didRangeLasso_Lcom_bluecats_sdk_BCLasso_ == null)
				cb_didRangeLasso_Lcom_bluecats_sdk_BCLasso_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DidRangeLasso_Lcom_bluecats_sdk_BCLasso_);
			return cb_didRangeLasso_Lcom_bluecats_sdk_BCLasso_;
		}

		static void n_DidRangeLasso_Lcom_bluecats_sdk_BCLasso_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCLassoManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCLassoManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCLasso p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLasso> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DidRangeLasso (p0);
		}
#pragma warning restore 0169

		IntPtr id_didRangeLasso_Lcom_bluecats_sdk_BCLasso_;
		public unsafe void DidRangeLasso (global::Com.Bluecats.Sdk.BCLasso p0)
		{
			if (id_didRangeLasso_Lcom_bluecats_sdk_BCLasso_ == IntPtr.Zero)
				id_didRangeLasso_Lcom_bluecats_sdk_BCLasso_ = JNIEnv.GetMethodID (class_ref, "didRangeLasso", "(Lcom/bluecats/sdk/BCLasso;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_didRangeLasso_Lcom_bluecats_sdk_BCLasso_, __args);
		}

		static Delegate cb_getMappingForLasso_Lcom_bluecats_sdk_BCLasso_;
#pragma warning disable 0169
		static Delegate GetGetMappingForLasso_Lcom_bluecats_sdk_BCLasso_Handler ()
		{
			if (cb_getMappingForLasso_Lcom_bluecats_sdk_BCLasso_ == null)
				cb_getMappingForLasso_Lcom_bluecats_sdk_BCLasso_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMappingForLasso_Lcom_bluecats_sdk_BCLasso_);
			return cb_getMappingForLasso_Lcom_bluecats_sdk_BCLasso_;
		}

		static IntPtr n_GetMappingForLasso_Lcom_bluecats_sdk_BCLasso_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCLassoManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCLassoManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCLasso p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLasso> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.GetMappingForLasso (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getMappingForLasso_Lcom_bluecats_sdk_BCLasso_;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> GetMappingForLasso (global::Com.Bluecats.Sdk.BCLasso p0)
		{
			if (id_getMappingForLasso_Lcom_bluecats_sdk_BCLasso_ == IntPtr.Zero)
				id_getMappingForLasso_Lcom_bluecats_sdk_BCLasso_ = JNIEnv.GetMethodID (class_ref, "getMappingForLasso", "(Lcom/bluecats/sdk/BCLasso;)Ljava/util/Map;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::System.Collections.Generic.IDictionary<string, string> __ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMappingForLasso_Lcom_bluecats_sdk_BCLasso_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_shouldBeginRedemptionRequest_Lcom_bluecats_sdk_BCLasso_;
#pragma warning disable 0169
		static Delegate GetShouldBeginRedemptionRequest_Lcom_bluecats_sdk_BCLasso_Handler ()
		{
			if (cb_shouldBeginRedemptionRequest_Lcom_bluecats_sdk_BCLasso_ == null)
				cb_shouldBeginRedemptionRequest_Lcom_bluecats_sdk_BCLasso_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ShouldBeginRedemptionRequest_Lcom_bluecats_sdk_BCLasso_);
			return cb_shouldBeginRedemptionRequest_Lcom_bluecats_sdk_BCLasso_;
		}

		static bool n_ShouldBeginRedemptionRequest_Lcom_bluecats_sdk_BCLasso_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCLassoManagerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCLassoManagerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCLasso p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLasso> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShouldBeginRedemptionRequest (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_shouldBeginRedemptionRequest_Lcom_bluecats_sdk_BCLasso_;
		public unsafe bool ShouldBeginRedemptionRequest (global::Com.Bluecats.Sdk.BCLasso p0)
		{
			if (id_shouldBeginRedemptionRequest_Lcom_bluecats_sdk_BCLasso_ == IntPtr.Zero)
				id_shouldBeginRedemptionRequest_Lcom_bluecats_sdk_BCLasso_ = JNIEnv.GetMethodID (class_ref, "shouldBeginRedemptionRequest", "(Lcom/bluecats/sdk/BCLasso;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_shouldBeginRedemptionRequest_Lcom_bluecats_sdk_BCLasso_, __args);
			return __ret;
		}

	}

}
