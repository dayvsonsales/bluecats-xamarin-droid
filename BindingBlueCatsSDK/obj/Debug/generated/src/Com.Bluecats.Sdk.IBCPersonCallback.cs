using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCPersonCallback']"
	[Register ("com/bluecats/sdk/BCPersonCallback", "", "Com.Bluecats.Sdk.IBCPersonCallbackInvoker")]
	public partial interface IBCPersonCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCPersonCallback']/method[@name='onDidCreateTeam' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCTeam']]"
		[Register ("onDidCreateTeam", "(Lcom/bluecats/sdk/BCTeam;)V", "GetOnDidCreateTeam_Lcom_bluecats_sdk_BCTeam_Handler:Com.Bluecats.Sdk.IBCPersonCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidCreateTeam (global::Com.Bluecats.Sdk.BCTeam p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCPersonCallback']/method[@name='onDidDeleteTeam' and count(parameter)=0]"
		[Register ("onDidDeleteTeam", "()V", "GetOnDidDeleteTeamHandler:Com.Bluecats.Sdk.IBCPersonCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidDeleteTeam ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCPersonCallback']/method[@name='onDidFailWithError' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCError']]"
		[Register ("onDidFailWithError", "(Lcom/bluecats/sdk/BCError;)V", "GetOnDidFailWithError_Lcom_bluecats_sdk_BCError_Handler:Com.Bluecats.Sdk.IBCPersonCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidFailWithError (global::Com.Bluecats.Sdk.BCError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCPersonCallback']/method[@name='onDidLoadTeams' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCTeam&gt;']]"
		[Register ("onDidLoadTeams", "(Ljava/util/List;)V", "GetOnDidLoadTeams_Ljava_util_List_Handler:Com.Bluecats.Sdk.IBCPersonCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidLoadTeams (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCTeam> p0);

	}

	[global::Android.Runtime.Register ("com/bluecats/sdk/BCPersonCallback", DoNotGenerateAcw=true)]
	internal class IBCPersonCallbackInvoker : global::Java.Lang.Object, IBCPersonCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bluecats/sdk/BCPersonCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBCPersonCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBCPersonCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBCPersonCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bluecats.sdk.BCPersonCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBCPersonCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDidCreateTeam_Lcom_bluecats_sdk_BCTeam_;
#pragma warning disable 0169
		static Delegate GetOnDidCreateTeam_Lcom_bluecats_sdk_BCTeam_Handler ()
		{
			if (cb_onDidCreateTeam_Lcom_bluecats_sdk_BCTeam_ == null)
				cb_onDidCreateTeam_Lcom_bluecats_sdk_BCTeam_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidCreateTeam_Lcom_bluecats_sdk_BCTeam_);
			return cb_onDidCreateTeam_Lcom_bluecats_sdk_BCTeam_;
		}

		static void n_OnDidCreateTeam_Lcom_bluecats_sdk_BCTeam_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCPersonCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCPersonCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCTeam p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidCreateTeam (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidCreateTeam_Lcom_bluecats_sdk_BCTeam_;
		public unsafe void OnDidCreateTeam (global::Com.Bluecats.Sdk.BCTeam p0)
		{
			if (id_onDidCreateTeam_Lcom_bluecats_sdk_BCTeam_ == IntPtr.Zero)
				id_onDidCreateTeam_Lcom_bluecats_sdk_BCTeam_ = JNIEnv.GetMethodID (class_ref, "onDidCreateTeam", "(Lcom/bluecats/sdk/BCTeam;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidCreateTeam_Lcom_bluecats_sdk_BCTeam_, __args);
		}

		static Delegate cb_onDidDeleteTeam;
#pragma warning disable 0169
		static Delegate GetOnDidDeleteTeamHandler ()
		{
			if (cb_onDidDeleteTeam == null)
				cb_onDidDeleteTeam = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDidDeleteTeam);
			return cb_onDidDeleteTeam;
		}

		static void n_OnDidDeleteTeam (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCPersonCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCPersonCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDidDeleteTeam ();
		}
#pragma warning restore 0169

		IntPtr id_onDidDeleteTeam;
		public unsafe void OnDidDeleteTeam ()
		{
			if (id_onDidDeleteTeam == IntPtr.Zero)
				id_onDidDeleteTeam = JNIEnv.GetMethodID (class_ref, "onDidDeleteTeam", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidDeleteTeam);
		}

		static Delegate cb_onDidFailWithError_Lcom_bluecats_sdk_BCError_;
#pragma warning disable 0169
		static Delegate GetOnDidFailWithError_Lcom_bluecats_sdk_BCError_Handler ()
		{
			if (cb_onDidFailWithError_Lcom_bluecats_sdk_BCError_ == null)
				cb_onDidFailWithError_Lcom_bluecats_sdk_BCError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidFailWithError_Lcom_bluecats_sdk_BCError_);
			return cb_onDidFailWithError_Lcom_bluecats_sdk_BCError_;
		}

		static void n_OnDidFailWithError_Lcom_bluecats_sdk_BCError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCPersonCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCPersonCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCError p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidFailWithError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidFailWithError_Lcom_bluecats_sdk_BCError_;
		public unsafe void OnDidFailWithError (global::Com.Bluecats.Sdk.BCError p0)
		{
			if (id_onDidFailWithError_Lcom_bluecats_sdk_BCError_ == IntPtr.Zero)
				id_onDidFailWithError_Lcom_bluecats_sdk_BCError_ = JNIEnv.GetMethodID (class_ref, "onDidFailWithError", "(Lcom/bluecats/sdk/BCError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidFailWithError_Lcom_bluecats_sdk_BCError_, __args);
		}

		static Delegate cb_onDidLoadTeams_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetOnDidLoadTeams_Ljava_util_List_Handler ()
		{
			if (cb_onDidLoadTeams_Ljava_util_List_ == null)
				cb_onDidLoadTeams_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidLoadTeams_Ljava_util_List_);
			return cb_onDidLoadTeams_Ljava_util_List_;
		}

		static void n_OnDidLoadTeams_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCPersonCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCPersonCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCTeam>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidLoadTeams (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidLoadTeams_Ljava_util_List_;
		public unsafe void OnDidLoadTeams (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCTeam> p0)
		{
			if (id_onDidLoadTeams_Ljava_util_List_ == IntPtr.Zero)
				id_onDidLoadTeams_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "onDidLoadTeams", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCTeam>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidLoadTeams_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
