using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotificationManager']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCLocalNotificationManager", DoNotGenerateAcw=true)]
	public partial class BCLocalNotificationManager : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCLocalNotificationManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCLocalNotificationManager); }
		}

		protected BCLocalNotificationManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getApplicationNotifications;
		public static unsafe global::System.Collections.Generic.IDictionary<global::Android.Content.Context, global::Java.Util.IMapEntry> ApplicationNotifications {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotificationManager']/method[@name='getApplicationNotifications' and count(parameter)=0]"
			[Register ("getApplicationNotifications", "()Ljava/util/Map;", "GetGetApplicationNotificationsHandler")]
			get {
				if (id_getApplicationNotifications == IntPtr.Zero)
					id_getApplicationNotifications = JNIEnv.GetStaticMethodID (class_ref, "getApplicationNotifications", "()Ljava/util/Map;");
				try {
					return global::Android.Runtime.JavaDictionary<global::Android.Content.Context, global::Java.Util.IMapEntry>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getApplicationNotifications), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Bluecats.Sdk.BCLocalNotificationManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotificationManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/bluecats/sdk/BCLocalNotificationManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/bluecats/sdk/BCLocalNotificationManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotificationManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScheduledLocalNotifications;
#pragma warning disable 0169
		static Delegate GetGetScheduledLocalNotificationsHandler ()
		{
			if (cb_getScheduledLocalNotifications == null)
				cb_getScheduledLocalNotifications = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScheduledLocalNotifications);
			return cb_getScheduledLocalNotifications;
		}

		static IntPtr n_GetScheduledLocalNotifications (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCLocalNotificationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotificationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCLocalNotification>.ToLocalJniHandle (__this.ScheduledLocalNotifications);
		}
#pragma warning restore 0169

		static IntPtr id_getScheduledLocalNotifications;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCLocalNotification> ScheduledLocalNotifications {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotificationManager']/method[@name='getScheduledLocalNotifications' and count(parameter)=0]"
			[Register ("getScheduledLocalNotifications", "()Ljava/util/List;", "GetGetScheduledLocalNotificationsHandler")]
			get {
				if (id_getScheduledLocalNotifications == IntPtr.Zero)
					id_getScheduledLocalNotifications = JNIEnv.GetMethodID (class_ref, "getScheduledLocalNotifications", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCLocalNotification>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScheduledLocalNotifications), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCLocalNotification>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScheduledLocalNotifications", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_cancelAllLocalNotifications;
#pragma warning disable 0169
		static Delegate GetCancelAllLocalNotificationsHandler ()
		{
			if (cb_cancelAllLocalNotifications == null)
				cb_cancelAllLocalNotifications = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelAllLocalNotifications);
			return cb_cancelAllLocalNotifications;
		}

		static void n_CancelAllLocalNotifications (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCLocalNotificationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotificationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelAllLocalNotifications ();
		}
#pragma warning restore 0169

		static IntPtr id_cancelAllLocalNotifications;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotificationManager']/method[@name='cancelAllLocalNotifications' and count(parameter)=0]"
		[Register ("cancelAllLocalNotifications", "()V", "GetCancelAllLocalNotificationsHandler")]
		public virtual unsafe void CancelAllLocalNotifications ()
		{
			if (id_cancelAllLocalNotifications == IntPtr.Zero)
				id_cancelAllLocalNotifications = JNIEnv.GetMethodID (class_ref, "cancelAllLocalNotifications", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelAllLocalNotifications);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelAllLocalNotifications", "()V"));
			} finally {
			}
		}

		static Delegate cb_cancelLocalNotification_I;
#pragma warning disable 0169
		static Delegate GetCancelLocalNotification_IHandler ()
		{
			if (cb_cancelLocalNotification_I == null)
				cb_cancelLocalNotification_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_CancelLocalNotification_I);
			return cb_cancelLocalNotification_I;
		}

		static void n_CancelLocalNotification_I (IntPtr jnienv, IntPtr native__this, int id)
		{
			global::Com.Bluecats.Sdk.BCLocalNotificationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotificationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelLocalNotification (id);
		}
#pragma warning restore 0169

		static IntPtr id_cancelLocalNotification_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotificationManager']/method[@name='cancelLocalNotification' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("cancelLocalNotification", "(I)V", "GetCancelLocalNotification_IHandler")]
		public virtual unsafe void CancelLocalNotification (int id)
		{
			if (id_cancelLocalNotification_I == IntPtr.Zero)
				id_cancelLocalNotification_I = JNIEnv.GetMethodID (class_ref, "cancelLocalNotification", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (id);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelLocalNotification_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelLocalNotification", "(I)V"), __args);
			} finally {
			}
		}

		static IntPtr id_newInstance;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotificationManager']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/bluecats/sdk/BCLocalNotificationManager;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCLocalNotificationManager NewInstance ()
		{
			if (id_newInstance == IntPtr.Zero)
				id_newInstance = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "()Lcom/bluecats/sdk/BCLocalNotificationManager;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotificationManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_registerForBackgroundNotifications_Landroid_content_Context_ILandroid_app_Notification_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotificationManager']/method[@name='registerForBackgroundNotifications' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='android.app.Notification']]"
		[Register ("registerForBackgroundNotifications", "(Landroid/content/Context;ILandroid/app/Notification;)V", "")]
		public static unsafe void RegisterForBackgroundNotifications (global::Android.Content.Context applicationContext, int notificationId, global::Android.App.Notification notification)
		{
			if (id_registerForBackgroundNotifications_Landroid_content_Context_ILandroid_app_Notification_ == IntPtr.Zero)
				id_registerForBackgroundNotifications_Landroid_content_Context_ILandroid_app_Notification_ = JNIEnv.GetStaticMethodID (class_ref, "registerForBackgroundNotifications", "(Landroid/content/Context;ILandroid/app/Notification;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (applicationContext);
				__args [1] = new JValue (notificationId);
				__args [2] = new JValue (notification);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_registerForBackgroundNotifications_Landroid_content_Context_ILandroid_app_Notification_, __args);
			} finally {
			}
		}

		static Delegate cb_registerLocalNotificationManagerCallback_ILcom_bluecats_sdk_BCLocalNotificationManagerCallback_;
#pragma warning disable 0169
		static Delegate GetRegisterLocalNotificationManagerCallback_ILcom_bluecats_sdk_BCLocalNotificationManagerCallback_Handler ()
		{
			if (cb_registerLocalNotificationManagerCallback_ILcom_bluecats_sdk_BCLocalNotificationManagerCallback_ == null)
				cb_registerLocalNotificationManagerCallback_ILcom_bluecats_sdk_BCLocalNotificationManagerCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_RegisterLocalNotificationManagerCallback_ILcom_bluecats_sdk_BCLocalNotificationManagerCallback_);
			return cb_registerLocalNotificationManagerCallback_ILcom_bluecats_sdk_BCLocalNotificationManagerCallback_;
		}

		static void n_RegisterLocalNotificationManagerCallback_ILcom_bluecats_sdk_BCLocalNotificationManagerCallback_ (IntPtr jnienv, IntPtr native__this, int id, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCLocalNotificationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotificationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCLocalNotificationManagerCallback @callback = (global::Com.Bluecats.Sdk.IBCLocalNotificationManagerCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCLocalNotificationManagerCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.RegisterLocalNotificationManagerCallback (id, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_registerLocalNotificationManagerCallback_ILcom_bluecats_sdk_BCLocalNotificationManagerCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotificationManager']/method[@name='registerLocalNotificationManagerCallback' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.bluecats.sdk.BCLocalNotificationManagerCallback']]"
		[Register ("registerLocalNotificationManagerCallback", "(ILcom/bluecats/sdk/BCLocalNotificationManagerCallback;)V", "GetRegisterLocalNotificationManagerCallback_ILcom_bluecats_sdk_BCLocalNotificationManagerCallback_Handler")]
		public virtual unsafe void RegisterLocalNotificationManagerCallback (int id, global::Com.Bluecats.Sdk.IBCLocalNotificationManagerCallback @callback)
		{
			if (id_registerLocalNotificationManagerCallback_ILcom_bluecats_sdk_BCLocalNotificationManagerCallback_ == IntPtr.Zero)
				id_registerLocalNotificationManagerCallback_ILcom_bluecats_sdk_BCLocalNotificationManagerCallback_ = JNIEnv.GetMethodID (class_ref, "registerLocalNotificationManagerCallback", "(ILcom/bluecats/sdk/BCLocalNotificationManagerCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (id);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerLocalNotificationManagerCallback_ILcom_bluecats_sdk_BCLocalNotificationManagerCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerLocalNotificationManagerCallback", "(ILcom/bluecats/sdk/BCLocalNotificationManagerCallback;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_removeBackgroundNotification_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotificationManager']/method[@name='removeBackgroundNotification' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("removeBackgroundNotification", "(Landroid/content/Context;)V", "")]
		public static unsafe void RemoveBackgroundNotification (global::Android.Content.Context context)
		{
			if (id_removeBackgroundNotification_Landroid_content_Context_ == IntPtr.Zero)
				id_removeBackgroundNotification_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "removeBackgroundNotification", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_removeBackgroundNotification_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_removeBlueCatsSDKCallback_I;
#pragma warning disable 0169
		static Delegate GetRemoveBlueCatsSDKCallback_IHandler ()
		{
			if (cb_removeBlueCatsSDKCallback_I == null)
				cb_removeBlueCatsSDKCallback_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_RemoveBlueCatsSDKCallback_I);
			return cb_removeBlueCatsSDKCallback_I;
		}

		static void n_RemoveBlueCatsSDKCallback_I (IntPtr jnienv, IntPtr native__this, int id)
		{
			global::Com.Bluecats.Sdk.BCLocalNotificationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotificationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveBlueCatsSDKCallback (id);
		}
#pragma warning restore 0169

		static IntPtr id_removeBlueCatsSDKCallback_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotificationManager']/method[@name='removeBlueCatsSDKCallback' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeBlueCatsSDKCallback", "(I)V", "GetRemoveBlueCatsSDKCallback_IHandler")]
		public virtual unsafe void RemoveBlueCatsSDKCallback (int id)
		{
			if (id_removeBlueCatsSDKCallback_I == IntPtr.Zero)
				id_removeBlueCatsSDKCallback_I = JNIEnv.GetMethodID (class_ref, "removeBlueCatsSDKCallback", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (id);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeBlueCatsSDKCallback_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeBlueCatsSDKCallback", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_scheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_;
#pragma warning disable 0169
		static Delegate GetScheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_Handler ()
		{
			if (cb_scheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_ == null)
				cb_scheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ScheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_);
			return cb_scheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_;
		}

		static void n_ScheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_ (IntPtr jnienv, IntPtr native__this, IntPtr native_localNotification)
		{
			global::Com.Bluecats.Sdk.BCLocalNotificationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotificationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCLocalNotification localNotification = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (native_localNotification, JniHandleOwnership.DoNotTransfer);
			__this.ScheduleLocalNotification (localNotification);
		}
#pragma warning restore 0169

		static IntPtr id_scheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotificationManager']/method[@name='scheduleLocalNotification' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCLocalNotification']]"
		[Register ("scheduleLocalNotification", "(Lcom/bluecats/sdk/BCLocalNotification;)V", "GetScheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_Handler")]
		public virtual unsafe void ScheduleLocalNotification (global::Com.Bluecats.Sdk.BCLocalNotification localNotification)
		{
			if (id_scheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_ == IntPtr.Zero)
				id_scheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_ = JNIEnv.GetMethodID (class_ref, "scheduleLocalNotification", "(Lcom/bluecats/sdk/BCLocalNotification;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (localNotification);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_scheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scheduleLocalNotification", "(Lcom/bluecats/sdk/BCLocalNotification;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_scheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_Z;
#pragma warning disable 0169
		static Delegate GetScheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_ZHandler ()
		{
			if (cb_scheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_Z == null)
				cb_scheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_ScheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_Z);
			return cb_scheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_Z;
		}

		static void n_ScheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_localNotification, bool storeLocalNotificationToPreferences)
		{
			global::Com.Bluecats.Sdk.BCLocalNotificationManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotificationManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCLocalNotification localNotification = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (native_localNotification, JniHandleOwnership.DoNotTransfer);
			__this.ScheduleLocalNotification (localNotification, storeLocalNotificationToPreferences);
		}
#pragma warning restore 0169

		static IntPtr id_scheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotificationManager']/method[@name='scheduleLocalNotification' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCLocalNotification'] and parameter[2][@type='boolean']]"
		[Register ("scheduleLocalNotification", "(Lcom/bluecats/sdk/BCLocalNotification;Z)V", "GetScheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_ZHandler")]
		public virtual unsafe void ScheduleLocalNotification (global::Com.Bluecats.Sdk.BCLocalNotification localNotification, bool storeLocalNotificationToPreferences)
		{
			if (id_scheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_Z == IntPtr.Zero)
				id_scheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_Z = JNIEnv.GetMethodID (class_ref, "scheduleLocalNotification", "(Lcom/bluecats/sdk/BCLocalNotification;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (localNotification);
				__args [1] = new JValue (storeLocalNotificationToPreferences);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_scheduleLocalNotification_Lcom_bluecats_sdk_BCLocalNotification_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scheduleLocalNotification", "(Lcom/bluecats/sdk/BCLocalNotification;Z)V"), __args);
			} finally {
			}
		}

	}
}
