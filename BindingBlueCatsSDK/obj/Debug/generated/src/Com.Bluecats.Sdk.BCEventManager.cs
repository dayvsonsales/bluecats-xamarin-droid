using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventManager']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCEventManager", DoNotGenerateAcw=true)]
	public partial class BCEventManager : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventManager.BCEventPriority']"
		[global::Android.Runtime.Register ("com/bluecats/sdk/BCEventManager$BCEventPriority", DoNotGenerateAcw=true)]
		public sealed partial class BCEventPriority : global::Java.Lang.Enum {


			static IntPtr BC_EVENT_PRIORITY_HIGH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventManager.BCEventPriority']/field[@name='BC_EVENT_PRIORITY_HIGH']"
			[Register ("BC_EVENT_PRIORITY_HIGH")]
			public static global::Com.Bluecats.Sdk.BCEventManager.BCEventPriority BcEventPriorityHigh {
				get {
					if (BC_EVENT_PRIORITY_HIGH_jfieldId == IntPtr.Zero)
						BC_EVENT_PRIORITY_HIGH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_EVENT_PRIORITY_HIGH", "Lcom/bluecats/sdk/BCEventManager$BCEventPriority;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_EVENT_PRIORITY_HIGH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventManager.BCEventPriority> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_EVENT_PRIORITY_NORMAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventManager.BCEventPriority']/field[@name='BC_EVENT_PRIORITY_NORMAL']"
			[Register ("BC_EVENT_PRIORITY_NORMAL")]
			public static global::Com.Bluecats.Sdk.BCEventManager.BCEventPriority BcEventPriorityNormal {
				get {
					if (BC_EVENT_PRIORITY_NORMAL_jfieldId == IntPtr.Zero)
						BC_EVENT_PRIORITY_NORMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_EVENT_PRIORITY_NORMAL", "Lcom/bluecats/sdk/BCEventManager$BCEventPriority;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_EVENT_PRIORITY_NORMAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventManager.BCEventPriority> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bluecats/sdk/BCEventManager$BCEventPriority", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BCEventPriority); }
			}

			internal BCEventPriority (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventManager.BCEventPriority']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCEventManager$BCEventPriority;", "")]
			public static unsafe global::Com.Bluecats.Sdk.BCEventManager.BCEventPriority ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCEventManager$BCEventPriority;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Com.Bluecats.Sdk.BCEventManager.BCEventPriority __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventManager.BCEventPriority> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventManager.BCEventPriority']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bluecats/sdk/BCEventManager$BCEventPriority;", "")]
			public static unsafe global::Com.Bluecats.Sdk.BCEventManager.BCEventPriority[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bluecats/sdk/BCEventManager$BCEventPriority;");
				try {
					return (global::Com.Bluecats.Sdk.BCEventManager.BCEventPriority[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCEventManager.BCEventPriority));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCEventManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCEventManager); }
		}

		protected BCEventManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAllMonitoredEventIdentifiers;
#pragma warning disable 0169
		static Delegate GetGetAllMonitoredEventIdentifiersHandler ()
		{
			if (cb_getAllMonitoredEventIdentifiers == null)
				cb_getAllMonitoredEventIdentifiers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllMonitoredEventIdentifiers);
			return cb_getAllMonitoredEventIdentifiers;
		}

		static IntPtr n_GetAllMonitoredEventIdentifiers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.AllMonitoredEventIdentifiers);
		}
#pragma warning restore 0169

		static IntPtr id_getAllMonitoredEventIdentifiers;
		public virtual unsafe global::System.Collections.Generic.IList<string> AllMonitoredEventIdentifiers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventManager']/method[@name='getAllMonitoredEventIdentifiers' and count(parameter)=0]"
			[Register ("getAllMonitoredEventIdentifiers", "()Ljava/util/List;", "GetGetAllMonitoredEventIdentifiersHandler")]
			get {
				if (id_getAllMonitoredEventIdentifiers == IntPtr.Zero)
					id_getAllMonitoredEventIdentifiers = JNIEnv.GetMethodID (class_ref, "getAllMonitoredEventIdentifiers", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllMonitoredEventIdentifiers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllMonitoredEventIdentifiers", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Bluecats.Sdk.BCEventManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/bluecats/sdk/BCEventManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/bluecats/sdk/BCEventManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_logEvent_Lcom_bluecats_sdk_BCEvent_Lcom_bluecats_sdk_BCEventManager_BCEventPriority_;
#pragma warning disable 0169
		static Delegate GetLogEvent_Lcom_bluecats_sdk_BCEvent_Lcom_bluecats_sdk_BCEventManager_BCEventPriority_Handler ()
		{
			if (cb_logEvent_Lcom_bluecats_sdk_BCEvent_Lcom_bluecats_sdk_BCEventManager_BCEventPriority_ == null)
				cb_logEvent_Lcom_bluecats_sdk_BCEvent_Lcom_bluecats_sdk_BCEventManager_BCEventPriority_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_LogEvent_Lcom_bluecats_sdk_BCEvent_Lcom_bluecats_sdk_BCEventManager_BCEventPriority_);
			return cb_logEvent_Lcom_bluecats_sdk_BCEvent_Lcom_bluecats_sdk_BCEventManager_BCEventPriority_;
		}

		static void n_LogEvent_Lcom_bluecats_sdk_BCEvent_Lcom_bluecats_sdk_BCEventManager_BCEventPriority_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_priority)
		{
			global::Com.Bluecats.Sdk.BCEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCEvent e = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCEventManager.BCEventPriority priority = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventManager.BCEventPriority> (native_priority, JniHandleOwnership.DoNotTransfer);
			__this.LogEvent (e, priority);
		}
#pragma warning restore 0169

		static IntPtr id_logEvent_Lcom_bluecats_sdk_BCEvent_Lcom_bluecats_sdk_BCEventManager_BCEventPriority_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventManager']/method[@name='logEvent' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCEvent'] and parameter[2][@type='com.bluecats.sdk.BCEventManager.BCEventPriority']]"
		[Register ("logEvent", "(Lcom/bluecats/sdk/BCEvent;Lcom/bluecats/sdk/BCEventManager$BCEventPriority;)V", "GetLogEvent_Lcom_bluecats_sdk_BCEvent_Lcom_bluecats_sdk_BCEventManager_BCEventPriority_Handler")]
		public virtual unsafe void LogEvent (global::Com.Bluecats.Sdk.BCEvent e, global::Com.Bluecats.Sdk.BCEventManager.BCEventPriority priority)
		{
			if (id_logEvent_Lcom_bluecats_sdk_BCEvent_Lcom_bluecats_sdk_BCEventManager_BCEventPriority_ == IntPtr.Zero)
				id_logEvent_Lcom_bluecats_sdk_BCEvent_Lcom_bluecats_sdk_BCEventManager_BCEventPriority_ = JNIEnv.GetMethodID (class_ref, "logEvent", "(Lcom/bluecats/sdk/BCEvent;Lcom/bluecats/sdk/BCEventManager$BCEventPriority;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (e);
				__args [1] = new JValue (priority);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_logEvent_Lcom_bluecats_sdk_BCEvent_Lcom_bluecats_sdk_BCEventManager_BCEventPriority_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logEvent", "(Lcom/bluecats/sdk/BCEvent;Lcom/bluecats/sdk/BCEventManager$BCEventPriority;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_monitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_ZLcom_bluecats_sdk_BCEventManagerCallback_;
#pragma warning disable 0169
		static Delegate GetMonitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_ZLcom_bluecats_sdk_BCEventManagerCallback_Handler ()
		{
			if (cb_monitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_ZLcom_bluecats_sdk_BCEventManagerCallback_ == null)
				cb_monitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_ZLcom_bluecats_sdk_BCEventManagerCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_MonitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_ZLcom_bluecats_sdk_BCEventManagerCallback_);
			return cb_monitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_ZLcom_bluecats_sdk_BCEventManagerCallback_;
		}

		static void n_MonitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_ZLcom_bluecats_sdk_BCEventManagerCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_trigger, bool restoreTriggeredCount, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCTrigger trigger = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTrigger> (native_trigger, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCEventManagerCallback @callback = (global::Com.Bluecats.Sdk.IBCEventManagerCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCEventManagerCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.MonitorEventWithTrigger (trigger, restoreTriggeredCount, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_monitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_ZLcom_bluecats_sdk_BCEventManagerCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventManager']/method[@name='monitorEventWithTrigger' and count(parameter)=3 and parameter[1][@type='com.bluecats.sdk.BCTrigger'] and parameter[2][@type='boolean'] and parameter[3][@type='com.bluecats.sdk.BCEventManagerCallback']]"
		[Register ("monitorEventWithTrigger", "(Lcom/bluecats/sdk/BCTrigger;ZLcom/bluecats/sdk/BCEventManagerCallback;)V", "GetMonitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_ZLcom_bluecats_sdk_BCEventManagerCallback_Handler")]
		public virtual unsafe void MonitorEventWithTrigger (global::Com.Bluecats.Sdk.BCTrigger trigger, bool restoreTriggeredCount, global::Com.Bluecats.Sdk.IBCEventManagerCallback @callback)
		{
			if (id_monitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_ZLcom_bluecats_sdk_BCEventManagerCallback_ == IntPtr.Zero)
				id_monitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_ZLcom_bluecats_sdk_BCEventManagerCallback_ = JNIEnv.GetMethodID (class_ref, "monitorEventWithTrigger", "(Lcom/bluecats/sdk/BCTrigger;ZLcom/bluecats/sdk/BCEventManagerCallback;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (trigger);
				__args [1] = new JValue (restoreTriggeredCount);
				__args [2] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_monitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_ZLcom_bluecats_sdk_BCEventManagerCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "monitorEventWithTrigger", "(Lcom/bluecats/sdk/BCTrigger;ZLcom/bluecats/sdk/BCEventManagerCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_monitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_Lcom_bluecats_sdk_BCEventManagerCallback_;
#pragma warning disable 0169
		static Delegate GetMonitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_Lcom_bluecats_sdk_BCEventManagerCallback_Handler ()
		{
			if (cb_monitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_Lcom_bluecats_sdk_BCEventManagerCallback_ == null)
				cb_monitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_Lcom_bluecats_sdk_BCEventManagerCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_MonitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_Lcom_bluecats_sdk_BCEventManagerCallback_);
			return cb_monitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_Lcom_bluecats_sdk_BCEventManagerCallback_;
		}

		static void n_MonitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_Lcom_bluecats_sdk_BCEventManagerCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_trigger, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCTrigger trigger = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTrigger> (native_trigger, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCEventManagerCallback @callback = (global::Com.Bluecats.Sdk.IBCEventManagerCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCEventManagerCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.MonitorEventWithTrigger (trigger, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_monitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_Lcom_bluecats_sdk_BCEventManagerCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventManager']/method[@name='monitorEventWithTrigger' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCTrigger'] and parameter[2][@type='com.bluecats.sdk.BCEventManagerCallback']]"
		[Register ("monitorEventWithTrigger", "(Lcom/bluecats/sdk/BCTrigger;Lcom/bluecats/sdk/BCEventManagerCallback;)V", "GetMonitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_Lcom_bluecats_sdk_BCEventManagerCallback_Handler")]
		public virtual unsafe void MonitorEventWithTrigger (global::Com.Bluecats.Sdk.BCTrigger trigger, global::Com.Bluecats.Sdk.IBCEventManagerCallback @callback)
		{
			if (id_monitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_Lcom_bluecats_sdk_BCEventManagerCallback_ == IntPtr.Zero)
				id_monitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_Lcom_bluecats_sdk_BCEventManagerCallback_ = JNIEnv.GetMethodID (class_ref, "monitorEventWithTrigger", "(Lcom/bluecats/sdk/BCTrigger;Lcom/bluecats/sdk/BCEventManagerCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (trigger);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_monitorEventWithTrigger_Lcom_bluecats_sdk_BCTrigger_Lcom_bluecats_sdk_BCEventManagerCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "monitorEventWithTrigger", "(Lcom/bluecats/sdk/BCTrigger;Lcom/bluecats/sdk/BCEventManagerCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_registerBlueCatsSDKCallback;
#pragma warning disable 0169
		static Delegate GetRegisterBlueCatsSDKCallbackHandler ()
		{
			if (cb_registerBlueCatsSDKCallback == null)
				cb_registerBlueCatsSDKCallback = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RegisterBlueCatsSDKCallback);
			return cb_registerBlueCatsSDKCallback;
		}

		static void n_RegisterBlueCatsSDKCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RegisterBlueCatsSDKCallback ();
		}
#pragma warning restore 0169

		static IntPtr id_registerBlueCatsSDKCallback;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventManager']/method[@name='registerBlueCatsSDKCallback' and count(parameter)=0]"
		[Register ("registerBlueCatsSDKCallback", "()V", "GetRegisterBlueCatsSDKCallbackHandler")]
		public virtual unsafe void RegisterBlueCatsSDKCallback ()
		{
			if (id_registerBlueCatsSDKCallback == IntPtr.Zero)
				id_registerBlueCatsSDKCallback = JNIEnv.GetMethodID (class_ref, "registerBlueCatsSDKCallback", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerBlueCatsSDKCallback);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerBlueCatsSDKCallback", "()V"));
			} finally {
			}
		}

		static Delegate cb_registerBlueCatsSDKServiceCallback;
#pragma warning disable 0169
		static Delegate GetRegisterBlueCatsSDKServiceCallbackHandler ()
		{
			if (cb_registerBlueCatsSDKServiceCallback == null)
				cb_registerBlueCatsSDKServiceCallback = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RegisterBlueCatsSDKServiceCallback);
			return cb_registerBlueCatsSDKServiceCallback;
		}

		static void n_RegisterBlueCatsSDKServiceCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RegisterBlueCatsSDKServiceCallback ();
		}
#pragma warning restore 0169

		static IntPtr id_registerBlueCatsSDKServiceCallback;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventManager']/method[@name='registerBlueCatsSDKServiceCallback' and count(parameter)=0]"
		[Register ("registerBlueCatsSDKServiceCallback", "()V", "GetRegisterBlueCatsSDKServiceCallbackHandler")]
		public virtual unsafe void RegisterBlueCatsSDKServiceCallback ()
		{
			if (id_registerBlueCatsSDKServiceCallback == IntPtr.Zero)
				id_registerBlueCatsSDKServiceCallback = JNIEnv.GetMethodID (class_ref, "registerBlueCatsSDKServiceCallback", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerBlueCatsSDKServiceCallback);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerBlueCatsSDKServiceCallback", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeAllMonitoredEvents;
#pragma warning disable 0169
		static Delegate GetRemoveAllMonitoredEventsHandler ()
		{
			if (cb_removeAllMonitoredEvents == null)
				cb_removeAllMonitoredEvents = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllMonitoredEvents);
			return cb_removeAllMonitoredEvents;
		}

		static void n_RemoveAllMonitoredEvents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllMonitoredEvents ();
		}
#pragma warning restore 0169

		static IntPtr id_removeAllMonitoredEvents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventManager']/method[@name='removeAllMonitoredEvents' and count(parameter)=0]"
		[Register ("removeAllMonitoredEvents", "()V", "GetRemoveAllMonitoredEventsHandler")]
		public virtual unsafe void RemoveAllMonitoredEvents ()
		{
			if (id_removeAllMonitoredEvents == IntPtr.Zero)
				id_removeAllMonitoredEvents = JNIEnv.GetMethodID (class_ref, "removeAllMonitoredEvents", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeAllMonitoredEvents);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllMonitoredEvents", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeMonitoredEvent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveMonitoredEvent_Ljava_lang_String_Handler ()
		{
			if (cb_removeMonitoredEvent_Ljava_lang_String_ == null)
				cb_removeMonitoredEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveMonitoredEvent_Ljava_lang_String_);
			return cb_removeMonitoredEvent_Ljava_lang_String_;
		}

		static void n_RemoveMonitoredEvent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventIdentifier)
		{
			global::Com.Bluecats.Sdk.BCEventManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string eventIdentifier = JNIEnv.GetString (native_eventIdentifier, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMonitoredEvent (eventIdentifier);
		}
#pragma warning restore 0169

		static IntPtr id_removeMonitoredEvent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventManager']/method[@name='removeMonitoredEvent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeMonitoredEvent", "(Ljava/lang/String;)V", "GetRemoveMonitoredEvent_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveMonitoredEvent (string eventIdentifier)
		{
			if (id_removeMonitoredEvent_Ljava_lang_String_ == IntPtr.Zero)
				id_removeMonitoredEvent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeMonitoredEvent", "(Ljava/lang/String;)V");
			IntPtr native_eventIdentifier = JNIEnv.NewString (eventIdentifier);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_eventIdentifier);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeMonitoredEvent_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeMonitoredEvent", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_eventIdentifier);
			}
		}

	}
}
