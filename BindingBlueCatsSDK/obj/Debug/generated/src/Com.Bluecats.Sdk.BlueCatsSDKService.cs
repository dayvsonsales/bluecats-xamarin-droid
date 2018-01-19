using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDKService']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BlueCatsSDKService", DoNotGenerateAcw=true)]
	public partial class BlueCatsSDKService : global::Android.App.Service {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDKService.LocalBinder']"
		[global::Android.Runtime.Register ("com/bluecats/sdk/BlueCatsSDKService$LocalBinder", DoNotGenerateAcw=true)]
		public partial class LocalBinder : global::Android.OS.Binder {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bluecats/sdk/BlueCatsSDKService$LocalBinder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LocalBinder); }
			}

			protected LocalBinder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_bluecats_sdk_BlueCatsSDKService_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDKService.LocalBinder']/constructor[@name='BlueCatsSDKService.LocalBinder' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BlueCatsSDKService']]"
			[Register (".ctor", "(Lcom/bluecats/sdk/BlueCatsSDKService;)V", "")]
			public unsafe LocalBinder (global::Com.Bluecats.Sdk.BlueCatsSDKService __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (LocalBinder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lcom_bluecats_sdk_BlueCatsSDKService_ == IntPtr.Zero)
						id_ctor_Lcom_bluecats_sdk_BlueCatsSDKService_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bluecats/sdk/BlueCatsSDKService;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bluecats_sdk_BlueCatsSDKService_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_bluecats_sdk_BlueCatsSDKService_, __args);
				} finally {
				}
			}

			static Delegate cb_getService;
#pragma warning disable 0169
			static Delegate GetGetServiceHandler ()
			{
				if (cb_getService == null)
					cb_getService = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetService);
				return cb_getService;
			}

			static IntPtr n_GetService (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Bluecats.Sdk.BlueCatsSDKService.LocalBinder __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BlueCatsSDKService.LocalBinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Service);
			}
#pragma warning restore 0169

			static IntPtr id_getService;
			public virtual unsafe global::Com.Bluecats.Sdk.BlueCatsSDKService Service {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDKService.LocalBinder']/method[@name='getService' and count(parameter)=0]"
				[Register ("getService", "()Lcom/bluecats/sdk/BlueCatsSDKService;", "GetGetServiceHandler")]
				get {
					if (id_getService == IntPtr.Zero)
						id_getService = JNIEnv.GetMethodID (class_ref, "getService", "()Lcom/bluecats/sdk/BlueCatsSDKService;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BlueCatsSDKService> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getService), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BlueCatsSDKService> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getService", "()Lcom/bluecats/sdk/BlueCatsSDKService;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BlueCatsSDKService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BlueCatsSDKService); }
		}

		protected BlueCatsSDKService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDKService']/constructor[@name='BlueCatsSDKService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BlueCatsSDKService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BlueCatsSDKService)) {
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

		static IntPtr id_getBlueCatsSDKServiceID;
		public static unsafe global::Java.Util.UUID BlueCatsSDKServiceID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDKService']/method[@name='getBlueCatsSDKServiceID' and count(parameter)=0]"
			[Register ("getBlueCatsSDKServiceID", "()Ljava/util/UUID;", "GetGetBlueCatsSDKServiceIDHandler")]
			get {
				if (id_getBlueCatsSDKServiceID == IntPtr.Zero)
					id_getBlueCatsSDKServiceID = JNIEnv.GetStaticMethodID (class_ref, "getBlueCatsSDKServiceID", "()Ljava/util/UUID;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBlueCatsSDKServiceID), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getServiceContext;
		public static unsafe global::Android.Content.Context ServiceContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDKService']/method[@name='getServiceContext' and count(parameter)=0]"
			[Register ("getServiceContext", "()Landroid/content/Context;", "GetGetServiceContextHandler")]
			get {
				if (id_getServiceContext == IntPtr.Zero)
					id_getServiceContext = JNIEnv.GetStaticMethodID (class_ref, "getServiceContext", "()Landroid/content/Context;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getServiceContext), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getToken;
		public static unsafe string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDKService']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Ljava/lang/String;", "GetGetTokenHandler")]
			get {
				if (id_getToken == IntPtr.Zero)
					id_getToken = JNIEnv.GetStaticMethodID (class_ref, "getToken", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getToken), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_onBind_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnBind_Landroid_content_Intent_Handler ()
		{
			if (cb_onBind_Landroid_content_Intent_ == null)
				cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBind_Landroid_content_Intent_);
			return cb_onBind_Landroid_content_Intent_;
		}

		static IntPtr n_OnBind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_arg0)
		{
			global::Com.Bluecats.Sdk.BlueCatsSDKService __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BlueCatsSDKService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent arg0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_arg0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (arg0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onBind_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BlueCatsSDKService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler")]
		public override unsafe global::Android.OS.IBinder OnBind (global::Android.Content.Intent arg0)
		{
			if (id_onBind_Landroid_content_Intent_ == IntPtr.Zero)
				id_onBind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (arg0);

				global::Android.OS.IBinder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onBind_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
