using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilterContext']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCEventFilterContext", DoNotGenerateAcw=true)]
	public partial class BCEventFilterContext : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCEventFilterContext", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCEventFilterContext); }
		}

		protected BCEventFilterContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilterContext']/constructor[@name='BCEventFilterContext' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCEventFilterContext ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCEventFilterContext)) {
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

		static Delegate cb_getBeaconsToFilter;
#pragma warning disable 0169
		static Delegate GetGetBeaconsToFilterHandler ()
		{
			if (cb_getBeaconsToFilter == null)
				cb_getBeaconsToFilter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeaconsToFilter);
			return cb_getBeaconsToFilter;
		}

		static IntPtr n_GetBeaconsToFilter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEventFilterContext __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilterContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.ToLocalJniHandle (__this.BeaconsToFilter);
		}
#pragma warning restore 0169

		static Delegate cb_setBeaconsToFilter_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetBeaconsToFilter_Ljava_util_List_Handler ()
		{
			if (cb_setBeaconsToFilter_Ljava_util_List_ == null)
				cb_setBeaconsToFilter_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBeaconsToFilter_Ljava_util_List_);
			return cb_setBeaconsToFilter_Ljava_util_List_;
		}

		static void n_SetBeaconsToFilter_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCEventFilterContext __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilterContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (native_value, JniHandleOwnership.DoNotTransfer);
			__this.BeaconsToFilter = value;
		}
#pragma warning restore 0169

		static IntPtr id_getBeaconsToFilter;
		static IntPtr id_setBeaconsToFilter_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> BeaconsToFilter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilterContext']/method[@name='getBeaconsToFilter' and count(parameter)=0]"
			[Register ("getBeaconsToFilter", "()Ljava/util/List;", "GetGetBeaconsToFilterHandler")]
			get {
				if (id_getBeaconsToFilter == IntPtr.Zero)
					id_getBeaconsToFilter = JNIEnv.GetMethodID (class_ref, "getBeaconsToFilter", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeaconsToFilter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeaconsToFilter", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilterContext']/method[@name='setBeaconsToFilter' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;? extends com.bluecats.sdk.BCBeacon&gt;']]"
			[Register ("setBeaconsToFilter", "(Ljava/util/List;)V", "GetSetBeaconsToFilter_Ljava_util_List_Handler")]
			set {
				if (id_setBeaconsToFilter_Ljava_util_List_ == IntPtr.Zero)
					id_setBeaconsToFilter_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setBeaconsToFilter", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeaconsToFilter_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBeaconsToFilter", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
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
			global::Com.Bluecats.Sdk.BCEventFilterContext __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilterContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCEventFilterContext __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilterContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCEvent value = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEvent> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Event = value;
		}
#pragma warning restore 0169

		static IntPtr id_getEvent;
		static IntPtr id_setEvent_Lcom_bluecats_sdk_BCEvent_;
		public virtual unsafe global::Com.Bluecats.Sdk.BCEvent Event {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilterContext']/method[@name='getEvent' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilterContext']/method[@name='setEvent' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCEvent']]"
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
			global::Com.Bluecats.Sdk.BCEventFilterContext __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilterContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCEventFilterContext __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilterContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.FirstTriggeredAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getFirstTriggeredAt;
		static IntPtr id_setFirstTriggeredAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date FirstTriggeredAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilterContext']/method[@name='getFirstTriggeredAt' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilterContext']/method[@name='setFirstTriggeredAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
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
			global::Com.Bluecats.Sdk.BCEventFilterContext __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilterContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCEventFilterContext __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilterContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.LastTriggeredAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getLastTriggeredAt;
		static IntPtr id_setLastTriggeredAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date LastTriggeredAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilterContext']/method[@name='getLastTriggeredAt' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilterContext']/method[@name='setLastTriggeredAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
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

		static Delegate cb_getSiteForSiteID;
#pragma warning disable 0169
		static Delegate GetGetSiteForSiteIDHandler ()
		{
			if (cb_getSiteForSiteID == null)
				cb_getSiteForSiteID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSiteForSiteID);
			return cb_getSiteForSiteID;
		}

		static IntPtr n_GetSiteForSiteID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEventFilterContext __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilterContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Com.Bluecats.Sdk.BCSiteInternal>.ToLocalJniHandle (__this.SiteForSiteID);
		}
#pragma warning restore 0169

		static Delegate cb_setSiteForSiteID_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetSiteForSiteID_Ljava_util_Map_Handler ()
		{
			if (cb_setSiteForSiteID_Ljava_util_Map_ == null)
				cb_setSiteForSiteID_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSiteForSiteID_Ljava_util_Map_);
			return cb_setSiteForSiteID_Ljava_util_Map_;
		}

		static void n_SetSiteForSiteID_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCEventFilterContext __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilterContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Android.Runtime.JavaDictionary<string, global::Com.Bluecats.Sdk.BCSiteInternal>.FromJniHandle (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SiteForSiteID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getSiteForSiteID;
		static IntPtr id_setSiteForSiteID_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Com.Bluecats.Sdk.BCSiteInternal> SiteForSiteID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilterContext']/method[@name='getSiteForSiteID' and count(parameter)=0]"
			[Register ("getSiteForSiteID", "()Ljava/util/Map;", "GetGetSiteForSiteIDHandler")]
			get {
				if (id_getSiteForSiteID == IntPtr.Zero)
					id_getSiteForSiteID = JNIEnv.GetMethodID (class_ref, "getSiteForSiteID", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Com.Bluecats.Sdk.BCSiteInternal>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSiteForSiteID), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Com.Bluecats.Sdk.BCSiteInternal>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSiteForSiteID", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilterContext']/method[@name='setSiteForSiteID' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, com.bluecats.sdk.BCSiteInternal&gt;']]"
			[Register ("setSiteForSiteID", "(Ljava/util/Map;)V", "GetSetSiteForSiteID_Ljava_util_Map_Handler")]
			set {
				if (id_setSiteForSiteID_Ljava_util_Map_ == IntPtr.Zero)
					id_setSiteForSiteID_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setSiteForSiteID", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, global::Com.Bluecats.Sdk.BCSiteInternal>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSiteForSiteID_Ljava_util_Map_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSiteForSiteID", "(Ljava/util/Map;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Bluecats.Sdk.BCEventFilterContext __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilterContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCEventFilterContext __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilterContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCTriggeredEvent.BCTriggerState value = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTriggeredEvent.BCTriggerState> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.TriggerState = value;
		}
#pragma warning restore 0169

		static IntPtr id_getTriggerState;
		static IntPtr id_setTriggerState_Lcom_bluecats_sdk_BCTriggeredEvent_BCTriggerState_;
		public virtual unsafe global::Com.Bluecats.Sdk.BCTriggeredEvent.BCTriggerState TriggerState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilterContext']/method[@name='getTriggerState' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilterContext']/method[@name='setTriggerState' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCTriggeredEvent.BCTriggerState']]"
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
			global::Com.Bluecats.Sdk.BCEventFilterContext __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilterContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCEventFilterContext __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilterContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.TriggeredCount = value;
		}
#pragma warning restore 0169

		static IntPtr id_getTriggeredCount;
		static IntPtr id_setTriggeredCount_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer TriggeredCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilterContext']/method[@name='getTriggeredCount' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilterContext']/method[@name='setTriggeredCount' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
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

		static Delegate cb_getSiteForSiteID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSiteForSiteID_Ljava_lang_String_Handler ()
		{
			if (cb_getSiteForSiteID_Ljava_lang_String_ == null)
				cb_getSiteForSiteID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSiteForSiteID_Ljava_lang_String_);
			return cb_getSiteForSiteID_Ljava_lang_String_;
		}

		static IntPtr n_GetSiteForSiteID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_siteID)
		{
			global::Com.Bluecats.Sdk.BCEventFilterContext __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilterContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string siteID = JNIEnv.GetString (native_siteID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSiteForSiteID (siteID));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSiteForSiteID_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilterContext']/method[@name='getSiteForSiteID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSiteForSiteID", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetSiteForSiteID_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object GetSiteForSiteID (string siteID)
		{
			if (id_getSiteForSiteID_Ljava_lang_String_ == IntPtr.Zero)
				id_getSiteForSiteID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSiteForSiteID", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_siteID = JNIEnv.NewString (siteID);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_siteID);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSiteForSiteID_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSiteForSiteID", "(Ljava/lang/String;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_siteID);
			}
		}

	}
}
