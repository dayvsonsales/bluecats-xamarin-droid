using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeaconCallback']"
	[Register ("com/bluecats/sdk/BCBeaconCallback", "", "Com.Bluecats.Sdk.IBCBeaconCallbackInvoker")]
	public partial interface IBCBeaconCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeaconCallback']/method[@name='onDidConfirmBeaconVersion' and count(parameter)=0]"
		[Register ("onDidConfirmBeaconVersion", "()V", "GetOnDidConfirmBeaconVersionHandler:Com.Bluecats.Sdk.IBCBeaconCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidConfirmBeaconVersion ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeaconCallback']/method[@name='onDidFailWithError' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCError']]"
		[Register ("onDidFailWithError", "(Lcom/bluecats/sdk/BCError;)V", "GetOnDidFailWithError_Lcom_bluecats_sdk_BCError_Handler:Com.Bluecats.Sdk.IBCBeaconCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidFailWithError (global::Com.Bluecats.Sdk.BCError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeaconCallback']/method[@name='onDidGetBeaconLoudnesses' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconLoudness[]']]"
		[Register ("onDidGetBeaconLoudnesses", "([Lcom/bluecats/sdk/BCBeaconLoudness;)V", "GetOnDidGetBeaconLoudnesses_arrayLcom_bluecats_sdk_BCBeaconLoudness_Handler:Com.Bluecats.Sdk.IBCBeaconCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidGetBeaconLoudnesses (global::Com.Bluecats.Sdk.BCBeaconLoudness[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeaconCallback']/method[@name='onDidGetBeaconModes' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconMode[]']]"
		[Register ("onDidGetBeaconModes", "([Lcom/bluecats/sdk/BCBeaconMode;)V", "GetOnDidGetBeaconModes_arrayLcom_bluecats_sdk_BCBeaconMode_Handler:Com.Bluecats.Sdk.IBCBeaconCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidGetBeaconModes (global::Com.Bluecats.Sdk.BCBeaconMode[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeaconCallback']/method[@name='onDidGetBeaconRegions' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconRegion[]']]"
		[Register ("onDidGetBeaconRegions", "([Lcom/bluecats/sdk/BCBeaconRegion;)V", "GetOnDidGetBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_Handler:Com.Bluecats.Sdk.IBCBeaconCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidGetBeaconRegions (global::Com.Bluecats.Sdk.BCBeaconRegion[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeaconCallback']/method[@name='onDidGetBeaconVersion' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconVersion']]"
		[Register ("onDidGetBeaconVersion", "(Lcom/bluecats/sdk/BCBeaconVersion;)V", "GetOnDidGetBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_Handler:Com.Bluecats.Sdk.IBCBeaconCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidGetBeaconVersion (global::Com.Bluecats.Sdk.BCBeaconVersion p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeaconCallback']/method[@name='onDidGetLatestBeacon' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeacon']]"
		[Register ("onDidGetLatestBeacon", "(Lcom/bluecats/sdk/BCBeacon;)V", "GetOnDidGetLatestBeacon_Lcom_bluecats_sdk_BCBeacon_Handler:Com.Bluecats.Sdk.IBCBeaconCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidGetLatestBeacon (global::Com.Bluecats.Sdk.IBCBeacon p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeaconCallback']/method[@name='onDidGetLatestBeaconVersion' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconVersion']]"
		[Register ("onDidGetLatestBeaconVersion", "(Lcom/bluecats/sdk/BCBeaconVersion;)V", "GetOnDidGetLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_Handler:Com.Bluecats.Sdk.IBCBeaconCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidGetLatestBeaconVersion (global::Com.Bluecats.Sdk.BCBeaconVersion p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeaconCallback']/method[@name='onDidGetTargetSpeeds' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCTargetSpeed[]']]"
		[Register ("onDidGetTargetSpeeds", "([Lcom/bluecats/sdk/BCTargetSpeed;)V", "GetOnDidGetTargetSpeeds_arrayLcom_bluecats_sdk_BCTargetSpeed_Handler:Com.Bluecats.Sdk.IBCBeaconCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidGetTargetSpeeds (global::Com.Bluecats.Sdk.BCTargetSpeed[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeaconCallback']/method[@name='onDidLoadBeaconInsights' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconInsights']]"
		[Register ("onDidLoadBeaconInsights", "(Lcom/bluecats/sdk/BCBeaconInsights;)V", "GetOnDidLoadBeaconInsights_Lcom_bluecats_sdk_BCBeaconInsights_Handler:Com.Bluecats.Sdk.IBCBeaconCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidLoadBeaconInsights (global::Com.Bluecats.Sdk.BCBeaconInsights p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeaconCallback']/method[@name='onDidRefreshBeacon' and count(parameter)=0]"
		[Register ("onDidRefreshBeacon", "()V", "GetOnDidRefreshBeaconHandler:Com.Bluecats.Sdk.IBCBeaconCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidRefreshBeacon ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/interface[@name='BCBeaconCallback']/method[@name='onDidUpdateBeacon' and count(parameter)=0]"
		[Register ("onDidUpdateBeacon", "()V", "GetOnDidUpdateBeaconHandler:Com.Bluecats.Sdk.IBCBeaconCallbackInvoker, BindingBlueCatsSDK")]
		void OnDidUpdateBeacon ();

	}

	[global::Android.Runtime.Register ("com/bluecats/sdk/BCBeaconCallback", DoNotGenerateAcw=true)]
	internal class IBCBeaconCallbackInvoker : global::Java.Lang.Object, IBCBeaconCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/bluecats/sdk/BCBeaconCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBCBeaconCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IBCBeaconCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBCBeaconCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bluecats.sdk.BCBeaconCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBCBeaconCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDidConfirmBeaconVersion;
#pragma warning disable 0169
		static Delegate GetOnDidConfirmBeaconVersionHandler ()
		{
			if (cb_onDidConfirmBeaconVersion == null)
				cb_onDidConfirmBeaconVersion = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDidConfirmBeaconVersion);
			return cb_onDidConfirmBeaconVersion;
		}

		static void n_OnDidConfirmBeaconVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeaconCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDidConfirmBeaconVersion ();
		}
#pragma warning restore 0169

		IntPtr id_onDidConfirmBeaconVersion;
		public unsafe void OnDidConfirmBeaconVersion ()
		{
			if (id_onDidConfirmBeaconVersion == IntPtr.Zero)
				id_onDidConfirmBeaconVersion = JNIEnv.GetMethodID (class_ref, "onDidConfirmBeaconVersion", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidConfirmBeaconVersion);
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
			global::Com.Bluecats.Sdk.IBCBeaconCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onDidGetBeaconLoudnesses_arrayLcom_bluecats_sdk_BCBeaconLoudness_;
#pragma warning disable 0169
		static Delegate GetOnDidGetBeaconLoudnesses_arrayLcom_bluecats_sdk_BCBeaconLoudness_Handler ()
		{
			if (cb_onDidGetBeaconLoudnesses_arrayLcom_bluecats_sdk_BCBeaconLoudness_ == null)
				cb_onDidGetBeaconLoudnesses_arrayLcom_bluecats_sdk_BCBeaconLoudness_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidGetBeaconLoudnesses_arrayLcom_bluecats_sdk_BCBeaconLoudness_);
			return cb_onDidGetBeaconLoudnesses_arrayLcom_bluecats_sdk_BCBeaconLoudness_;
		}

		static void n_OnDidGetBeaconLoudnesses_arrayLcom_bluecats_sdk_BCBeaconLoudness_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeaconCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconLoudness[] p0 = (global::Com.Bluecats.Sdk.BCBeaconLoudness[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Bluecats.Sdk.BCBeaconLoudness));
			__this.OnDidGetBeaconLoudnesses (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidGetBeaconLoudnesses_arrayLcom_bluecats_sdk_BCBeaconLoudness_;
		public unsafe void OnDidGetBeaconLoudnesses (global::Com.Bluecats.Sdk.BCBeaconLoudness[] p0)
		{
			if (id_onDidGetBeaconLoudnesses_arrayLcom_bluecats_sdk_BCBeaconLoudness_ == IntPtr.Zero)
				id_onDidGetBeaconLoudnesses_arrayLcom_bluecats_sdk_BCBeaconLoudness_ = JNIEnv.GetMethodID (class_ref, "onDidGetBeaconLoudnesses", "([Lcom/bluecats/sdk/BCBeaconLoudness;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidGetBeaconLoudnesses_arrayLcom_bluecats_sdk_BCBeaconLoudness_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onDidGetBeaconModes_arrayLcom_bluecats_sdk_BCBeaconMode_;
#pragma warning disable 0169
		static Delegate GetOnDidGetBeaconModes_arrayLcom_bluecats_sdk_BCBeaconMode_Handler ()
		{
			if (cb_onDidGetBeaconModes_arrayLcom_bluecats_sdk_BCBeaconMode_ == null)
				cb_onDidGetBeaconModes_arrayLcom_bluecats_sdk_BCBeaconMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidGetBeaconModes_arrayLcom_bluecats_sdk_BCBeaconMode_);
			return cb_onDidGetBeaconModes_arrayLcom_bluecats_sdk_BCBeaconMode_;
		}

		static void n_OnDidGetBeaconModes_arrayLcom_bluecats_sdk_BCBeaconMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeaconCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconMode[] p0 = (global::Com.Bluecats.Sdk.BCBeaconMode[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Bluecats.Sdk.BCBeaconMode));
			__this.OnDidGetBeaconModes (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidGetBeaconModes_arrayLcom_bluecats_sdk_BCBeaconMode_;
		public unsafe void OnDidGetBeaconModes (global::Com.Bluecats.Sdk.BCBeaconMode[] p0)
		{
			if (id_onDidGetBeaconModes_arrayLcom_bluecats_sdk_BCBeaconMode_ == IntPtr.Zero)
				id_onDidGetBeaconModes_arrayLcom_bluecats_sdk_BCBeaconMode_ = JNIEnv.GetMethodID (class_ref, "onDidGetBeaconModes", "([Lcom/bluecats/sdk/BCBeaconMode;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidGetBeaconModes_arrayLcom_bluecats_sdk_BCBeaconMode_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onDidGetBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_;
#pragma warning disable 0169
		static Delegate GetOnDidGetBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_Handler ()
		{
			if (cb_onDidGetBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_ == null)
				cb_onDidGetBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidGetBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_);
			return cb_onDidGetBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_;
		}

		static void n_OnDidGetBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeaconCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconRegion[] p0 = (global::Com.Bluecats.Sdk.BCBeaconRegion[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Bluecats.Sdk.BCBeaconRegion));
			__this.OnDidGetBeaconRegions (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidGetBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_;
		public unsafe void OnDidGetBeaconRegions (global::Com.Bluecats.Sdk.BCBeaconRegion[] p0)
		{
			if (id_onDidGetBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_ == IntPtr.Zero)
				id_onDidGetBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_ = JNIEnv.GetMethodID (class_ref, "onDidGetBeaconRegions", "([Lcom/bluecats/sdk/BCBeaconRegion;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidGetBeaconRegions_arrayLcom_bluecats_sdk_BCBeaconRegion_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onDidGetBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_;
#pragma warning disable 0169
		static Delegate GetOnDidGetBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_Handler ()
		{
			if (cb_onDidGetBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_ == null)
				cb_onDidGetBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidGetBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_);
			return cb_onDidGetBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_;
		}

		static void n_OnDidGetBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeaconCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconVersion p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidGetBeaconVersion (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidGetBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_;
		public unsafe void OnDidGetBeaconVersion (global::Com.Bluecats.Sdk.BCBeaconVersion p0)
		{
			if (id_onDidGetBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_ == IntPtr.Zero)
				id_onDidGetBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_ = JNIEnv.GetMethodID (class_ref, "onDidGetBeaconVersion", "(Lcom/bluecats/sdk/BCBeaconVersion;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidGetBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_, __args);
		}

		static Delegate cb_onDidGetLatestBeacon_Lcom_bluecats_sdk_BCBeacon_;
#pragma warning disable 0169
		static Delegate GetOnDidGetLatestBeacon_Lcom_bluecats_sdk_BCBeacon_Handler ()
		{
			if (cb_onDidGetLatestBeacon_Lcom_bluecats_sdk_BCBeacon_ == null)
				cb_onDidGetLatestBeacon_Lcom_bluecats_sdk_BCBeacon_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidGetLatestBeacon_Lcom_bluecats_sdk_BCBeacon_);
			return cb_onDidGetLatestBeacon_Lcom_bluecats_sdk_BCBeacon_;
		}

		static void n_OnDidGetLatestBeacon_Lcom_bluecats_sdk_BCBeacon_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeaconCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCBeacon p0 = (global::Com.Bluecats.Sdk.IBCBeacon)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeacon> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidGetLatestBeacon (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidGetLatestBeacon_Lcom_bluecats_sdk_BCBeacon_;
		public unsafe void OnDidGetLatestBeacon (global::Com.Bluecats.Sdk.IBCBeacon p0)
		{
			if (id_onDidGetLatestBeacon_Lcom_bluecats_sdk_BCBeacon_ == IntPtr.Zero)
				id_onDidGetLatestBeacon_Lcom_bluecats_sdk_BCBeacon_ = JNIEnv.GetMethodID (class_ref, "onDidGetLatestBeacon", "(Lcom/bluecats/sdk/BCBeacon;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidGetLatestBeacon_Lcom_bluecats_sdk_BCBeacon_, __args);
		}

		static Delegate cb_onDidGetLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_;
#pragma warning disable 0169
		static Delegate GetOnDidGetLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_Handler ()
		{
			if (cb_onDidGetLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_ == null)
				cb_onDidGetLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidGetLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_);
			return cb_onDidGetLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_;
		}

		static void n_OnDidGetLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeaconCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconVersion p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconVersion> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidGetLatestBeaconVersion (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidGetLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_;
		public unsafe void OnDidGetLatestBeaconVersion (global::Com.Bluecats.Sdk.BCBeaconVersion p0)
		{
			if (id_onDidGetLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_ == IntPtr.Zero)
				id_onDidGetLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_ = JNIEnv.GetMethodID (class_ref, "onDidGetLatestBeaconVersion", "(Lcom/bluecats/sdk/BCBeaconVersion;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidGetLatestBeaconVersion_Lcom_bluecats_sdk_BCBeaconVersion_, __args);
		}

		static Delegate cb_onDidGetTargetSpeeds_arrayLcom_bluecats_sdk_BCTargetSpeed_;
#pragma warning disable 0169
		static Delegate GetOnDidGetTargetSpeeds_arrayLcom_bluecats_sdk_BCTargetSpeed_Handler ()
		{
			if (cb_onDidGetTargetSpeeds_arrayLcom_bluecats_sdk_BCTargetSpeed_ == null)
				cb_onDidGetTargetSpeeds_arrayLcom_bluecats_sdk_BCTargetSpeed_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidGetTargetSpeeds_arrayLcom_bluecats_sdk_BCTargetSpeed_);
			return cb_onDidGetTargetSpeeds_arrayLcom_bluecats_sdk_BCTargetSpeed_;
		}

		static void n_OnDidGetTargetSpeeds_arrayLcom_bluecats_sdk_BCTargetSpeed_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeaconCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCTargetSpeed[] p0 = (global::Com.Bluecats.Sdk.BCTargetSpeed[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Bluecats.Sdk.BCTargetSpeed));
			__this.OnDidGetTargetSpeeds (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidGetTargetSpeeds_arrayLcom_bluecats_sdk_BCTargetSpeed_;
		public unsafe void OnDidGetTargetSpeeds (global::Com.Bluecats.Sdk.BCTargetSpeed[] p0)
		{
			if (id_onDidGetTargetSpeeds_arrayLcom_bluecats_sdk_BCTargetSpeed_ == IntPtr.Zero)
				id_onDidGetTargetSpeeds_arrayLcom_bluecats_sdk_BCTargetSpeed_ = JNIEnv.GetMethodID (class_ref, "onDidGetTargetSpeeds", "([Lcom/bluecats/sdk/BCTargetSpeed;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidGetTargetSpeeds_arrayLcom_bluecats_sdk_BCTargetSpeed_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onDidLoadBeaconInsights_Lcom_bluecats_sdk_BCBeaconInsights_;
#pragma warning disable 0169
		static Delegate GetOnDidLoadBeaconInsights_Lcom_bluecats_sdk_BCBeaconInsights_Handler ()
		{
			if (cb_onDidLoadBeaconInsights_Lcom_bluecats_sdk_BCBeaconInsights_ == null)
				cb_onDidLoadBeaconInsights_Lcom_bluecats_sdk_BCBeaconInsights_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDidLoadBeaconInsights_Lcom_bluecats_sdk_BCBeaconInsights_);
			return cb_onDidLoadBeaconInsights_Lcom_bluecats_sdk_BCBeaconInsights_;
		}

		static void n_OnDidLoadBeaconInsights_Lcom_bluecats_sdk_BCBeaconInsights_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluecats.Sdk.IBCBeaconCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconInsights p0 = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconInsights> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDidLoadBeaconInsights (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDidLoadBeaconInsights_Lcom_bluecats_sdk_BCBeaconInsights_;
		public unsafe void OnDidLoadBeaconInsights (global::Com.Bluecats.Sdk.BCBeaconInsights p0)
		{
			if (id_onDidLoadBeaconInsights_Lcom_bluecats_sdk_BCBeaconInsights_ == IntPtr.Zero)
				id_onDidLoadBeaconInsights_Lcom_bluecats_sdk_BCBeaconInsights_ = JNIEnv.GetMethodID (class_ref, "onDidLoadBeaconInsights", "(Lcom/bluecats/sdk/BCBeaconInsights;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidLoadBeaconInsights_Lcom_bluecats_sdk_BCBeaconInsights_, __args);
		}

		static Delegate cb_onDidRefreshBeacon;
#pragma warning disable 0169
		static Delegate GetOnDidRefreshBeaconHandler ()
		{
			if (cb_onDidRefreshBeacon == null)
				cb_onDidRefreshBeacon = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDidRefreshBeacon);
			return cb_onDidRefreshBeacon;
		}

		static void n_OnDidRefreshBeacon (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeaconCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDidRefreshBeacon ();
		}
#pragma warning restore 0169

		IntPtr id_onDidRefreshBeacon;
		public unsafe void OnDidRefreshBeacon ()
		{
			if (id_onDidRefreshBeacon == IntPtr.Zero)
				id_onDidRefreshBeacon = JNIEnv.GetMethodID (class_ref, "onDidRefreshBeacon", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidRefreshBeacon);
		}

		static Delegate cb_onDidUpdateBeacon;
#pragma warning disable 0169
		static Delegate GetOnDidUpdateBeaconHandler ()
		{
			if (cb_onDidUpdateBeacon == null)
				cb_onDidUpdateBeacon = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDidUpdateBeacon);
			return cb_onDidUpdateBeacon;
		}

		static void n_OnDidUpdateBeacon (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.IBCBeaconCallback __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCBeaconCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDidUpdateBeacon ();
		}
#pragma warning restore 0169

		IntPtr id_onDidUpdateBeacon;
		public unsafe void OnDidUpdateBeacon ()
		{
			if (id_onDidUpdateBeacon == IntPtr.Zero)
				id_onDidUpdateBeacon = JNIEnv.GetMethodID (class_ref, "onDidUpdateBeacon", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDidUpdateBeacon);
		}

	}

}
