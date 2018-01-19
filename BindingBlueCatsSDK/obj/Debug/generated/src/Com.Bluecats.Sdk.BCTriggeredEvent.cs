using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTriggeredEvent']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCTriggeredEvent", DoNotGenerateAcw=true)]
	public partial class BCTriggeredEvent : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTriggeredEvent.BCTriggerState']"
		[global::Android.Runtime.Register ("com/bluecats/sdk/BCTriggeredEvent$BCTriggerState", DoNotGenerateAcw=true)]
		public sealed partial class BCTriggerState : global::Java.Lang.Enum {


			static IntPtr BC_TRIGGER_STATE_EXPIRED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTriggeredEvent.BCTriggerState']/field[@name='BC_TRIGGER_STATE_EXPIRED']"
			[Register ("BC_TRIGGER_STATE_EXPIRED")]
			public static global::Com.Bluecats.Sdk.BCTriggeredEvent.BCTriggerState BcTriggerStateExpired {
				get {
					if (BC_TRIGGER_STATE_EXPIRED_jfieldId == IntPtr.Zero)
						BC_TRIGGER_STATE_EXPIRED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_TRIGGER_STATE_EXPIRED", "Lcom/bluecats/sdk/BCTriggeredEvent$BCTriggerState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_TRIGGER_STATE_EXPIRED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTriggeredEvent.BCTriggerState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_TRIGGER_STATE_INCOMPLETE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTriggeredEvent.BCTriggerState']/field[@name='BC_TRIGGER_STATE_INCOMPLETE']"
			[Register ("BC_TRIGGER_STATE_INCOMPLETE")]
			public static global::Com.Bluecats.Sdk.BCTriggeredEvent.BCTriggerState BcTriggerStateIncomplete {
				get {
					if (BC_TRIGGER_STATE_INCOMPLETE_jfieldId == IntPtr.Zero)
						BC_TRIGGER_STATE_INCOMPLETE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_TRIGGER_STATE_INCOMPLETE", "Lcom/bluecats/sdk/BCTriggeredEvent$BCTriggerState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_TRIGGER_STATE_INCOMPLETE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTriggeredEvent.BCTriggerState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_TRIGGER_STATE_TRIGGERED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTriggeredEvent.BCTriggerState']/field[@name='BC_TRIGGER_STATE_TRIGGERED']"
			[Register ("BC_TRIGGER_STATE_TRIGGERED")]
			public static global::Com.Bluecats.Sdk.BCTriggeredEvent.BCTriggerState BcTriggerStateTriggered {
				get {
					if (BC_TRIGGER_STATE_TRIGGERED_jfieldId == IntPtr.Zero)
						BC_TRIGGER_STATE_TRIGGERED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_TRIGGER_STATE_TRIGGERED", "Lcom/bluecats/sdk/BCTriggeredEvent$BCTriggerState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_TRIGGER_STATE_TRIGGERED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTriggeredEvent.BCTriggerState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bluecats/sdk/BCTriggeredEvent$BCTriggerState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BCTriggerState); }
			}

			internal BCTriggerState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTriggeredEvent.BCTriggerState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCTriggeredEvent$BCTriggerState;", "")]
			public static unsafe global::Com.Bluecats.Sdk.BCTriggeredEvent.BCTriggerState ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCTriggeredEvent$BCTriggerState;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Com.Bluecats.Sdk.BCTriggeredEvent.BCTriggerState __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTriggeredEvent.BCTriggerState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTriggeredEvent.BCTriggerState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bluecats/sdk/BCTriggeredEvent$BCTriggerState;", "")]
			public static unsafe global::Com.Bluecats.Sdk.BCTriggeredEvent.BCTriggerState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bluecats/sdk/BCTriggeredEvent$BCTriggerState;");
				try {
					return (global::Com.Bluecats.Sdk.BCTriggeredEvent.BCTriggerState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCTriggeredEvent.BCTriggerState));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCTriggeredEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCTriggeredEvent); }
		}

		protected BCTriggeredEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTriggeredEvent']/constructor[@name='BCTriggeredEvent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCTriggeredEvent ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCTriggeredEvent)) {
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

		static Delegate cb_getEvent;
#pragma warning disable 0169
		static Delegate GetGetEventHandler ()
		{
			if (cb_getEvent == null)
				cb_getEvent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEvent);
			return cb_getEvent;
		}

		static IntPtr n_GetEvent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTriggeredEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTriggeredEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Event);
		}
#pragma warning restore 0169

		static Delegate cb_setEvent_Lcom_bluecats_sdk_BCEvent_;
#pragma warning disable 0169
		static Delegate GetSetEvent_Lcom_bluecats_sdk_BCEvent_Handler ()
		{
			if (cb_setEvent_Lcom_bluecats_sdk_BCEvent_ == null)
				cb_setEvent_Lcom_bluecats_sdk_BCEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEvent_Lcom_bluecats_sdk_BCEvent_);
			return cb_setEvent_Lcom_bluecats_sdk_BCEvent_;
		}

		static void n_SetEvent_Lcom_bluecats_sdk_BCEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCTriggeredEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTriggeredEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCEvent value = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Event = value;
		}
#pragma warning restore 0169

		static IntPtr id_getEvent;
		static IntPtr id_setEvent_Lcom_bluecats_sdk_BCEvent_;
		public virtual unsafe global::Com.Bluecats.Sdk.BCEvent Event {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTriggeredEvent']/method[@name='getEvent' and count(parameter)=0]"
			[Register ("getEvent", "()Lcom/bluecats/sdk/BCEvent;", "GetGetEventHandler")]
			get {
				if (id_getEvent == IntPtr.Zero)
					id_getEvent = JNIEnv.GetMethodID (class_ref, "getEvent", "()Lcom/bluecats/sdk/BCEvent;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEvent), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEvent", "()Lcom/bluecats/sdk/BCEvent;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTriggeredEvent']/method[@name='setEvent' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCEvent']]"
			[Register ("setEvent", "(Lcom/bluecats/sdk/BCEvent;)V", "GetSetEvent_Lcom_bluecats_sdk_BCEvent_Handler")]
			set {
				if (id_setEvent_Lcom_bluecats_sdk_BCEvent_ == IntPtr.Zero)
					id_setEvent_Lcom_bluecats_sdk_BCEvent_ = JNIEnv.GetMethodID (class_ref, "setEvent", "(Lcom/bluecats/sdk/BCEvent;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEvent_Lcom_bluecats_sdk_BCEvent_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEvent", "(Lcom/bluecats/sdk/BCEvent;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFilteredMicroLocation;
#pragma warning disable 0169
		static Delegate GetGetFilteredMicroLocationHandler ()
		{
			if (cb_getFilteredMicroLocation == null)
				cb_getFilteredMicroLocation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFilteredMicroLocation);
			return cb_getFilteredMicroLocation;
		}

		static IntPtr n_GetFilteredMicroLocation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTriggeredEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTriggeredEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FilteredMicroLocation);
		}
#pragma warning restore 0169

		static Delegate cb_setFilteredMicroLocation_Lcom_bluecats_sdk_BCMicroLocation_;
#pragma warning disable 0169
		static Delegate GetSetFilteredMicroLocation_Lcom_bluecats_sdk_BCMicroLocation_Handler ()
		{
			if (cb_setFilteredMicroLocation_Lcom_bluecats_sdk_BCMicroLocation_ == null)
				cb_setFilteredMicroLocation_Lcom_bluecats_sdk_BCMicroLocation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFilteredMicroLocation_Lcom_bluecats_sdk_BCMicroLocation_);
			return cb_setFilteredMicroLocation_Lcom_bluecats_sdk_BCMicroLocation_;
		}

		static void n_SetFilteredMicroLocation_Lcom_bluecats_sdk_BCMicroLocation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCTriggeredEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTriggeredEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCMicroLocation value = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocation> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.FilteredMicroLocation = value;
		}
#pragma warning restore 0169

		static IntPtr id_getFilteredMicroLocation;
		static IntPtr id_setFilteredMicroLocation_Lcom_bluecats_sdk_BCMicroLocation_;
		public virtual unsafe global::Com.Bluecats.Sdk.BCMicroLocation FilteredMicroLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTriggeredEvent']/method[@name='getFilteredMicroLocation' and count(parameter)=0]"
			[Register ("getFilteredMicroLocation", "()Lcom/bluecats/sdk/BCMicroLocation;", "GetGetFilteredMicroLocationHandler")]
			get {
				if (id_getFilteredMicroLocation == IntPtr.Zero)
					id_getFilteredMicroLocation = JNIEnv.GetMethodID (class_ref, "getFilteredMicroLocation", "()Lcom/bluecats/sdk/BCMicroLocation;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFilteredMicroLocation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCMicroLocation> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFilteredMicroLocation", "()Lcom/bluecats/sdk/BCMicroLocation;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTriggeredEvent']/method[@name='setFilteredMicroLocation' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCMicroLocation']]"
			[Register ("setFilteredMicroLocation", "(Lcom/bluecats/sdk/BCMicroLocation;)V", "GetSetFilteredMicroLocation_Lcom_bluecats_sdk_BCMicroLocation_Handler")]
			set {
				if (id_setFilteredMicroLocation_Lcom_bluecats_sdk_BCMicroLocation_ == IntPtr.Zero)
					id_setFilteredMicroLocation_Lcom_bluecats_sdk_BCMicroLocation_ = JNIEnv.GetMethodID (class_ref, "setFilteredMicroLocation", "(Lcom/bluecats/sdk/BCMicroLocation;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFilteredMicroLocation_Lcom_bluecats_sdk_BCMicroLocation_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFilteredMicroLocation", "(Lcom/bluecats/sdk/BCMicroLocation;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFirstTriggeredAt;
#pragma warning disable 0169
		static Delegate GetGetFirstTriggeredAtHandler ()
		{
			if (cb_getFirstTriggeredAt == null)
				cb_getFirstTriggeredAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFirstTriggeredAt);
			return cb_getFirstTriggeredAt;
		}

		static IntPtr n_GetFirstTriggeredAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTriggeredEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTriggeredEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FirstTriggeredAt);
		}
#pragma warning restore 0169

		static Delegate cb_setFirstTriggeredAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetFirstTriggeredAt_Ljava_util_Date_Handler ()
		{
			if (cb_setFirstTriggeredAt_Ljava_util_Date_ == null)
				cb_setFirstTriggeredAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFirstTriggeredAt_Ljava_util_Date_);
			return cb_setFirstTriggeredAt_Ljava_util_Date_;
		}

		static void n_SetFirstTriggeredAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCTriggeredEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTriggeredEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.FirstTriggeredAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getFirstTriggeredAt;
		static IntPtr id_setFirstTriggeredAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date FirstTriggeredAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTriggeredEvent']/method[@name='getFirstTriggeredAt' and count(parameter)=0]"
			[Register ("getFirstTriggeredAt", "()Ljava/util/Date;", "GetGetFirstTriggeredAtHandler")]
			get {
				if (id_getFirstTriggeredAt == IntPtr.Zero)
					id_getFirstTriggeredAt = JNIEnv.GetMethodID (class_ref, "getFirstTriggeredAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFirstTriggeredAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirstTriggeredAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTriggeredEvent']/method[@name='setFirstTriggeredAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setFirstTriggeredAt", "(Ljava/util/Date;)V", "GetSetFirstTriggeredAt_Ljava_util_Date_Handler")]
			set {
				if (id_setFirstTriggeredAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setFirstTriggeredAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setFirstTriggeredAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFirstTriggeredAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFirstTriggeredAt", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLastTriggeredAt;
#pragma warning disable 0169
		static Delegate GetGetLastTriggeredAtHandler ()
		{
			if (cb_getLastTriggeredAt == null)
				cb_getLastTriggeredAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastTriggeredAt);
			return cb_getLastTriggeredAt;
		}

		static IntPtr n_GetLastTriggeredAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTriggeredEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTriggeredEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastTriggeredAt);
		}
#pragma warning restore 0169

		static Delegate cb_setLastTriggeredAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetLastTriggeredAt_Ljava_util_Date_Handler ()
		{
			if (cb_setLastTriggeredAt_Ljava_util_Date_ == null)
				cb_setLastTriggeredAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLastTriggeredAt_Ljava_util_Date_);
			return cb_setLastTriggeredAt_Ljava_util_Date_;
		}

		static void n_SetLastTriggeredAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCTriggeredEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTriggeredEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.LastTriggeredAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getLastTriggeredAt;
		static IntPtr id_setLastTriggeredAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date LastTriggeredAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTriggeredEvent']/method[@name='getLastTriggeredAt' and count(parameter)=0]"
			[Register ("getLastTriggeredAt", "()Ljava/util/Date;", "GetGetLastTriggeredAtHandler")]
			get {
				if (id_getLastTriggeredAt == IntPtr.Zero)
					id_getLastTriggeredAt = JNIEnv.GetMethodID (class_ref, "getLastTriggeredAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastTriggeredAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastTriggeredAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTriggeredEvent']/method[@name='setLastTriggeredAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setLastTriggeredAt", "(Ljava/util/Date;)V", "GetSetLastTriggeredAt_Ljava_util_Date_Handler")]
			set {
				if (id_setLastTriggeredAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setLastTriggeredAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setLastTriggeredAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastTriggeredAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastTriggeredAt", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTriggerState;
#pragma warning disable 0169
		static Delegate GetGetTriggerStateHandler ()
		{
			if (cb_getTriggerState == null)
				cb_getTriggerState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTriggerState);
			return cb_getTriggerState;
		}

		static IntPtr n_GetTriggerState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTriggeredEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTriggeredEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TriggerState);
		}
#pragma warning restore 0169

		static Delegate cb_setTriggerState_Lcom_bluecats_sdk_BCTriggeredEvent_BCTriggerState_;
#pragma warning disable 0169
		static Delegate GetSetTriggerState_Lcom_bluecats_sdk_BCTriggeredEvent_BCTriggerState_Handler ()
		{
			if (cb_setTriggerState_Lcom_bluecats_sdk_BCTriggeredEvent_BCTriggerState_ == null)
				cb_setTriggerState_Lcom_bluecats_sdk_BCTriggeredEvent_BCTriggerState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTriggerState_Lcom_bluecats_sdk_BCTriggeredEvent_BCTriggerState_);
			return cb_setTriggerState_Lcom_bluecats_sdk_BCTriggeredEvent_BCTriggerState_;
		}

		static void n_SetTriggerState_Lcom_bluecats_sdk_BCTriggeredEvent_BCTriggerState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCTriggeredEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTriggeredEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCTriggeredEvent.BCTriggerState value = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTriggeredEvent.BCTriggerState> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.TriggerState = value;
		}
#pragma warning restore 0169

		static IntPtr id_getTriggerState;
		static IntPtr id_setTriggerState_Lcom_bluecats_sdk_BCTriggeredEvent_BCTriggerState_;
		public virtual unsafe global::Com.Bluecats.Sdk.BCTriggeredEvent.BCTriggerState TriggerState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTriggeredEvent']/method[@name='getTriggerState' and count(parameter)=0]"
			[Register ("getTriggerState", "()Lcom/bluecats/sdk/BCTriggeredEvent$BCTriggerState;", "GetGetTriggerStateHandler")]
			get {
				if (id_getTriggerState == IntPtr.Zero)
					id_getTriggerState = JNIEnv.GetMethodID (class_ref, "getTriggerState", "()Lcom/bluecats/sdk/BCTriggeredEvent$BCTriggerState;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTriggeredEvent.BCTriggerState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTriggerState), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTriggeredEvent.BCTriggerState> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTriggerState", "()Lcom/bluecats/sdk/BCTriggeredEvent$BCTriggerState;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTriggeredEvent']/method[@name='setTriggerState' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCTriggeredEvent.BCTriggerState']]"
			[Register ("setTriggerState", "(Lcom/bluecats/sdk/BCTriggeredEvent$BCTriggerState;)V", "GetSetTriggerState_Lcom_bluecats_sdk_BCTriggeredEvent_BCTriggerState_Handler")]
			set {
				if (id_setTriggerState_Lcom_bluecats_sdk_BCTriggeredEvent_BCTriggerState_ == IntPtr.Zero)
					id_setTriggerState_Lcom_bluecats_sdk_BCTriggeredEvent_BCTriggerState_ = JNIEnv.GetMethodID (class_ref, "setTriggerState", "(Lcom/bluecats/sdk/BCTriggeredEvent$BCTriggerState;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTriggerState_Lcom_bluecats_sdk_BCTriggeredEvent_BCTriggerState_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTriggerState", "(Lcom/bluecats/sdk/BCTriggeredEvent$BCTriggerState;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTriggeredCount;
#pragma warning disable 0169
		static Delegate GetGetTriggeredCountHandler ()
		{
			if (cb_getTriggeredCount == null)
				cb_getTriggeredCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTriggeredCount);
			return cb_getTriggeredCount;
		}

		static IntPtr n_GetTriggeredCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTriggeredEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTriggeredEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TriggeredCount);
		}
#pragma warning restore 0169

		static Delegate cb_setTriggeredCount_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetTriggeredCount_Ljava_lang_Integer_Handler ()
		{
			if (cb_setTriggeredCount_Ljava_lang_Integer_ == null)
				cb_setTriggeredCount_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTriggeredCount_Ljava_lang_Integer_);
			return cb_setTriggeredCount_Ljava_lang_Integer_;
		}

		static void n_SetTriggeredCount_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCTriggeredEvent __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTriggeredEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.TriggeredCount = value;
		}
#pragma warning restore 0169

		static IntPtr id_getTriggeredCount;
		static IntPtr id_setTriggeredCount_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer TriggeredCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTriggeredEvent']/method[@name='getTriggeredCount' and count(parameter)=0]"
			[Register ("getTriggeredCount", "()Ljava/lang/Integer;", "GetGetTriggeredCountHandler")]
			get {
				if (id_getTriggeredCount == IntPtr.Zero)
					id_getTriggeredCount = JNIEnv.GetMethodID (class_ref, "getTriggeredCount", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTriggeredCount), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTriggeredCount", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTriggeredEvent']/method[@name='setTriggeredCount' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setTriggeredCount", "(Ljava/lang/Integer;)V", "GetSetTriggeredCount_Ljava_lang_Integer_Handler")]
			set {
				if (id_setTriggeredCount_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setTriggeredCount_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setTriggeredCount", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTriggeredCount_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTriggeredCount", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

	}
}
