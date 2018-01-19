using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCEventFilter", DoNotGenerateAcw=true)]
	public partial class BCEventFilter : global::Java.Lang.Object, global::Com.Bluecats.Sdk.IBCEventFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/field[@name='TAG']"
		[Register ("TAG")]
		protected const string Tag = (string) "BCEventFilter";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCEventFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCEventFilter); }
		}

		protected BCEventFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/constructor[@name='BCEventFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCEventFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCEventFilter)) {
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

		static Delegate cb_getEventFilterCallback;
#pragma warning disable 0169
		static Delegate GetGetEventFilterCallbackHandler ()
		{
			if (cb_getEventFilterCallback == null)
				cb_getEventFilterCallback = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventFilterCallback);
			return cb_getEventFilterCallback;
		}

		static IntPtr n_GetEventFilterCallback (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEventFilter __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EventFilterCallback);
		}
#pragma warning restore 0169

		static Delegate cb_setEventFilterCallback_Lcom_bluecats_sdk_BCEventFilterCallback_;
#pragma warning disable 0169
		static Delegate GetSetEventFilterCallback_Lcom_bluecats_sdk_BCEventFilterCallback_Handler ()
		{
			if (cb_setEventFilterCallback_Lcom_bluecats_sdk_BCEventFilterCallback_ == null)
				cb_setEventFilterCallback_Lcom_bluecats_sdk_BCEventFilterCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEventFilterCallback_Lcom_bluecats_sdk_BCEventFilterCallback_);
			return cb_setEventFilterCallback_Lcom_bluecats_sdk_BCEventFilterCallback_;
		}

		static void n_SetEventFilterCallback_Lcom_bluecats_sdk_BCEventFilterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCEventFilter __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCEventFilterCallback value = (global::Com.Bluecats.Sdk.IBCEventFilterCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCEventFilterCallback> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.EventFilterCallback = value;
		}
#pragma warning restore 0169

		static IntPtr id_getEventFilterCallback;
		static IntPtr id_setEventFilterCallback_Lcom_bluecats_sdk_BCEventFilterCallback_;
		public virtual unsafe global::Com.Bluecats.Sdk.IBCEventFilterCallback EventFilterCallback {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='getEventFilterCallback' and count(parameter)=0]"
			[Register ("getEventFilterCallback", "()Lcom/bluecats/sdk/BCEventFilterCallback;", "GetGetEventFilterCallbackHandler")]
			get {
				if (id_getEventFilterCallback == IntPtr.Zero)
					id_getEventFilterCallback = JNIEnv.GetMethodID (class_ref, "getEventFilterCallback", "()Lcom/bluecats/sdk/BCEventFilterCallback;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCEventFilterCallback> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEventFilterCallback), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCEventFilterCallback> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEventFilterCallback", "()Lcom/bluecats/sdk/BCEventFilterCallback;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='setEventFilterCallback' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCEventFilterCallback']]"
			[Register ("setEventFilterCallback", "(Lcom/bluecats/sdk/BCEventFilterCallback;)V", "GetSetEventFilterCallback_Lcom_bluecats_sdk_BCEventFilterCallback_Handler")]
			set {
				if (id_setEventFilterCallback_Lcom_bluecats_sdk_BCEventFilterCallback_ == IntPtr.Zero)
					id_setEventFilterCallback_Lcom_bluecats_sdk_BCEventFilterCallback_ = JNIEnv.GetMethodID (class_ref, "setEventFilterCallback", "(Lcom/bluecats/sdk/BCEventFilterCallback;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEventFilterCallback_Lcom_bluecats_sdk_BCEventFilterCallback_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEventFilterCallback", "(Lcom/bluecats/sdk/BCEventFilterCallback;)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_filterApplySmoothedAccuracyOverTimeInterval_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterApplySmoothedAccuracyOverTimeInterval' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("filterApplySmoothedAccuracyOverTimeInterval", "(J)Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterApplySmoothedAccuracyOverTimeInterval (long timeInterval)
		{
			if (id_filterApplySmoothedAccuracyOverTimeInterval_J == IntPtr.Zero)
				id_filterApplySmoothedAccuracyOverTimeInterval_J = JNIEnv.GetStaticMethodID (class_ref, "filterApplySmoothedAccuracyOverTimeInterval", "(J)Lcom/bluecats/sdk/BCEventFilter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (timeInterval);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterApplySmoothedAccuracyOverTimeInterval_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_filterApplySmoothedRSSIOverTimeInterval_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterApplySmoothedRSSIOverTimeInterval' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("filterApplySmoothedRSSIOverTimeInterval", "(J)Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterApplySmoothedRSSIOverTimeInterval (long timeInterval)
		{
			if (id_filterApplySmoothedRSSIOverTimeInterval_J == IntPtr.Zero)
				id_filterApplySmoothedRSSIOverTimeInterval_J = JNIEnv.GetStaticMethodID (class_ref, "filterApplySmoothedRSSIOverTimeInterval", "(J)Lcom/bluecats/sdk/BCEventFilter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (timeInterval);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterApplySmoothedRSSIOverTimeInterval_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_;
#pragma warning disable 0169
		static Delegate GetFilterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_Handler ()
		{
			if (cb_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_ == null)
				cb_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FilterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_);
			return cb_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_;
		}

		static IntPtr n_FilterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventContext)
		{
			global::Com.Bluecats.Sdk.BCEventFilter __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCEventFilterContext eventContext = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilterContext> (native_eventContext, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.ToLocalJniHandle (__this.FilterBeaconsForEvent (eventContext));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterBeaconsForEvent' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCEventFilterContext']]"
		[Register ("filterBeaconsForEvent", "(Lcom/bluecats/sdk/BCEventFilterContext;)Ljava/util/List;", "GetFilterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> FilterBeaconsForEvent (global::Com.Bluecats.Sdk.BCEventFilterContext eventContext)
		{
			if (id_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_ == IntPtr.Zero)
				id_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_ = JNIEnv.GetMethodID (class_ref, "filterBeaconsForEvent", "(Lcom/bluecats/sdk/BCEventFilterContext;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (eventContext);

				global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_filterBeaconsForEvent_Lcom_bluecats_sdk_BCEventFilterContext_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "filterBeaconsForEvent", "(Lcom/bluecats/sdk/BCEventFilterContext;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_filterByAccuracyRangeFrom_DD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterByAccuracyRangeFrom' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("filterByAccuracyRangeFrom", "(DD)Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterByAccuracyRangeFrom (double fromAccuracy, double toAccuracy)
		{
			if (id_filterByAccuracyRangeFrom_DD == IntPtr.Zero)
				id_filterByAccuracyRangeFrom_DD = JNIEnv.GetStaticMethodID (class_ref, "filterByAccuracyRangeFrom", "(DD)Lcom/bluecats/sdk/BCEventFilter;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (fromAccuracy);
				__args [1] = new JValue (toAccuracy);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterByAccuracyRangeFrom_DD, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_filterByCategoriesNamed_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterByCategoriesNamed' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("filterByCategoriesNamed", "(Ljava/util/List;)Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterByCategoriesNamed (global::System.Collections.Generic.IList<string> categoryNames)
		{
			if (id_filterByCategoriesNamed_Ljava_util_List_ == IntPtr.Zero)
				id_filterByCategoriesNamed_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "filterByCategoriesNamed", "(Ljava/util/List;)Lcom/bluecats/sdk/BCEventFilter;");
			IntPtr native_categoryNames = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (categoryNames);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_categoryNames);
				global::Com.Bluecats.Sdk.BCEventFilter __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterByCategoriesNamed_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_categoryNames);
			}
		}

		static IntPtr id_filterByCategoriesWithCustomValueKeys_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterByCategoriesWithCustomValueKeys' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("filterByCategoriesWithCustomValueKeys", "(Ljava/util/List;)Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterByCategoriesWithCustomValueKeys (global::System.Collections.Generic.IList<string> customValueList)
		{
			if (id_filterByCategoriesWithCustomValueKeys_Ljava_util_List_ == IntPtr.Zero)
				id_filterByCategoriesWithCustomValueKeys_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "filterByCategoriesWithCustomValueKeys", "(Ljava/util/List;)Lcom/bluecats/sdk/BCEventFilter;");
			IntPtr native_customValueList = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (customValueList);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_customValueList);
				global::Com.Bluecats.Sdk.BCEventFilter __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterByCategoriesWithCustomValueKeys_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_customValueList);
			}
		}

		static IntPtr id_filterByCategoriesWithIDs_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterByCategoriesWithIDs' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("filterByCategoriesWithIDs", "(Ljava/util/List;)Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterByCategoriesWithIDs (global::System.Collections.Generic.IList<string> categoryIDs)
		{
			if (id_filterByCategoriesWithIDs_Ljava_util_List_ == IntPtr.Zero)
				id_filterByCategoriesWithIDs_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "filterByCategoriesWithIDs", "(Ljava/util/List;)Lcom/bluecats/sdk/BCEventFilter;");
			IntPtr native_categoryIDs = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (categoryIDs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_categoryIDs);
				global::Com.Bluecats.Sdk.BCEventFilter __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterByCategoriesWithIDs_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_categoryIDs);
			}
		}

		static IntPtr id_filterByClosestBeacon;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterByClosestBeacon' and count(parameter)=0]"
		[Register ("filterByClosestBeacon", "()Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterByClosestBeacon ()
		{
			if (id_filterByClosestBeacon == IntPtr.Zero)
				id_filterByClosestBeacon = JNIEnv.GetStaticMethodID (class_ref, "filterByClosestBeacon", "()Lcom/bluecats/sdk/BCEventFilter;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterByClosestBeacon), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_filterByClosestBeaconChanged;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterByClosestBeaconChanged' and count(parameter)=0]"
		[Register ("filterByClosestBeaconChanged", "()Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterByClosestBeaconChanged ()
		{
			if (id_filterByClosestBeaconChanged == IntPtr.Zero)
				id_filterByClosestBeaconChanged = JNIEnv.GetStaticMethodID (class_ref, "filterByClosestBeaconChanged", "()Lcom/bluecats/sdk/BCEventFilter;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterByClosestBeaconChanged), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_filterByCustomValuesWithKeys_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterByCustomValuesWithKeys' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("filterByCustomValuesWithKeys", "(Ljava/util/List;)Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterByCustomValuesWithKeys (global::System.Collections.Generic.IList<string> customValueKeys)
		{
			if (id_filterByCustomValuesWithKeys_Ljava_util_List_ == IntPtr.Zero)
				id_filterByCustomValuesWithKeys_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "filterByCustomValuesWithKeys", "(Ljava/util/List;)Lcom/bluecats/sdk/BCEventFilter;");
			IntPtr native_customValueKeys = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (customValueKeys);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_customValueKeys);
				global::Com.Bluecats.Sdk.BCEventFilter __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterByCustomValuesWithKeys_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_customValueKeys);
			}
		}

		static IntPtr id_filterByEnteredAnyBeaconResetAfterTimeIntervalAllUnmatched_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterByEnteredAnyBeaconResetAfterTimeIntervalAllUnmatched' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("filterByEnteredAnyBeaconResetAfterTimeIntervalAllUnmatched", "(J)Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterByEnteredAnyBeaconResetAfterTimeIntervalAllUnmatched (long minTimeUnmatchedBeforeReset)
		{
			if (id_filterByEnteredAnyBeaconResetAfterTimeIntervalAllUnmatched_J == IntPtr.Zero)
				id_filterByEnteredAnyBeaconResetAfterTimeIntervalAllUnmatched_J = JNIEnv.GetStaticMethodID (class_ref, "filterByEnteredAnyBeaconResetAfterTimeIntervalAllUnmatched", "(J)Lcom/bluecats/sdk/BCEventFilter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (minTimeUnmatchedBeforeReset);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterByEnteredAnyBeaconResetAfterTimeIntervalAllUnmatched_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_filterByEnteredBeaconResetAfterTimeIntervalUnmatched_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterByEnteredBeaconResetAfterTimeIntervalUnmatched' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("filterByEnteredBeaconResetAfterTimeIntervalUnmatched", "(J)Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterByEnteredBeaconResetAfterTimeIntervalUnmatched (long minTimeUnmatchedBeforeReset)
		{
			if (id_filterByEnteredBeaconResetAfterTimeIntervalUnmatched_J == IntPtr.Zero)
				id_filterByEnteredBeaconResetAfterTimeIntervalUnmatched_J = JNIEnv.GetStaticMethodID (class_ref, "filterByEnteredBeaconResetAfterTimeIntervalUnmatched", "(J)Lcom/bluecats/sdk/BCEventFilter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (minTimeUnmatchedBeforeReset);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterByEnteredBeaconResetAfterTimeIntervalUnmatched_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_filterByExitedAllBeaconsAfterTimeInterval_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterByExitedAllBeaconsAfterTimeInterval' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("filterByExitedAllBeaconsAfterTimeInterval", "(J)Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterByExitedAllBeaconsAfterTimeInterval (long minTimeIntervalUnmatched)
		{
			if (id_filterByExitedAllBeaconsAfterTimeInterval_J == IntPtr.Zero)
				id_filterByExitedAllBeaconsAfterTimeInterval_J = JNIEnv.GetStaticMethodID (class_ref, "filterByExitedAllBeaconsAfterTimeInterval", "(J)Lcom/bluecats/sdk/BCEventFilter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (minTimeIntervalUnmatched);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterByExitedAllBeaconsAfterTimeInterval_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_filterByExitedBeaconAfterTimeIntervalUnmatched_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterByExitedBeaconAfterTimeIntervalUnmatched' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("filterByExitedBeaconAfterTimeIntervalUnmatched", "(J)Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterByExitedBeaconAfterTimeIntervalUnmatched (long minTimeIntervalUnmatched)
		{
			if (id_filterByExitedBeaconAfterTimeIntervalUnmatched_J == IntPtr.Zero)
				id_filterByExitedBeaconAfterTimeIntervalUnmatched_J = JNIEnv.GetStaticMethodID (class_ref, "filterByExitedBeaconAfterTimeIntervalUnmatched", "(J)Lcom/bluecats/sdk/BCEventFilter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (minTimeIntervalUnmatched);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterByExitedBeaconAfterTimeIntervalUnmatched_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_filterByIDs_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterByIDs' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("filterByIDs", "(Ljava/util/List;)Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterByIDs (global::System.Collections.Generic.IList<string> beaconIDs)
		{
			if (id_filterByIDs_Ljava_util_List_ == IntPtr.Zero)
				id_filterByIDs_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "filterByIDs", "(Ljava/util/List;)Lcom/bluecats/sdk/BCEventFilter;");
			IntPtr native_beaconIDs = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (beaconIDs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_beaconIDs);
				global::Com.Bluecats.Sdk.BCEventFilter __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterByIDs_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_beaconIDs);
			}
		}

		static IntPtr id_filterByMinTimeIntervalBeaconMatched_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterByMinTimeIntervalBeaconMatched' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("filterByMinTimeIntervalBeaconMatched", "(JJ)Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterByMinTimeIntervalBeaconMatched (long minTimeIntervalMatched, long maxTimeIntervalNotMatched)
		{
			if (id_filterByMinTimeIntervalBeaconMatched_JJ == IntPtr.Zero)
				id_filterByMinTimeIntervalBeaconMatched_JJ = JNIEnv.GetStaticMethodID (class_ref, "filterByMinTimeIntervalBeaconMatched", "(JJ)Lcom/bluecats/sdk/BCEventFilter;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (minTimeIntervalMatched);
				__args [1] = new JValue (maxTimeIntervalNotMatched);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterByMinTimeIntervalBeaconMatched_JJ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_filterByMinTimeIntervalBetweenBeaconMatches_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterByMinTimeIntervalBetweenBeaconMatches' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("filterByMinTimeIntervalBetweenBeaconMatches", "(J)Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterByMinTimeIntervalBetweenBeaconMatches (long minTimeIntervalBetweenMatches)
		{
			if (id_filterByMinTimeIntervalBetweenBeaconMatches_J == IntPtr.Zero)
				id_filterByMinTimeIntervalBetweenBeaconMatches_J = JNIEnv.GetStaticMethodID (class_ref, "filterByMinTimeIntervalBetweenBeaconMatches", "(J)Lcom/bluecats/sdk/BCEventFilter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (minTimeIntervalBetweenMatches);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterByMinTimeIntervalBetweenBeaconMatches_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_filterByMinTimeIntervalBetweenTriggers_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterByMinTimeIntervalBetweenTriggers' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("filterByMinTimeIntervalBetweenTriggers", "(J)Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterByMinTimeIntervalBetweenTriggers (long minTimeIntervalBetweenTriggers)
		{
			if (id_filterByMinTimeIntervalBetweenTriggers_J == IntPtr.Zero)
				id_filterByMinTimeIntervalBetweenTriggers_J = JNIEnv.GetStaticMethodID (class_ref, "filterByMinTimeIntervalBetweenTriggers", "(J)Lcom/bluecats/sdk/BCEventFilter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (minTimeIntervalBetweenTriggers);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterByMinTimeIntervalBetweenTriggers_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_filterByNeverEnteredBeacon;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterByNeverEnteredBeacon' and count(parameter)=0]"
		[Register ("filterByNeverEnteredBeacon", "()Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterByNeverEnteredBeacon ()
		{
			if (id_filterByNeverEnteredBeacon == IntPtr.Zero)
				id_filterByNeverEnteredBeacon = JNIEnv.GetStaticMethodID (class_ref, "filterByNeverEnteredBeacon", "()Lcom/bluecats/sdk/BCEventFilter;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterByNeverEnteredBeacon), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_filterByPredicate_Lcom_bluecats_sdk_BCPredicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterByPredicate' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCPredicate&lt;com.bluecats.sdk.BCBeacon&gt;']]"
		[Register ("filterByPredicate", "(Lcom/bluecats/sdk/BCPredicate;)Lcom/bluecats/sdk/BCEventFilter;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterByPredicate (global::Com.Bluecats.Sdk.IBCPredicate predicate)
		{
			if (id_filterByPredicate_Lcom_bluecats_sdk_BCPredicate_ == IntPtr.Zero)
				id_filterByPredicate_Lcom_bluecats_sdk_BCPredicate_ = JNIEnv.GetStaticMethodID (class_ref, "filterByPredicate", "(Lcom/bluecats/sdk/BCPredicate;)Lcom/bluecats/sdk/BCEventFilter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (predicate);
				global::Com.Bluecats.Sdk.BCEventFilter __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterByPredicate_Lcom_bluecats_sdk_BCPredicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_filterByProximities_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterByProximities' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCBeacon.BCProximity&gt;']]"
		[Register ("filterByProximities", "(Ljava/util/List;)Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterByProximities (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCBeaconBCProximity> proximities)
		{
			if (id_filterByProximities_Ljava_util_List_ == IntPtr.Zero)
				id_filterByProximities_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "filterByProximities", "(Ljava/util/List;)Lcom/bluecats/sdk/BCEventFilter;");
			IntPtr native_proximities = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCBeaconBCProximity>.ToLocalJniHandle (proximities);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_proximities);
				global::Com.Bluecats.Sdk.BCEventFilter __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterByProximities_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_proximities);
			}
		}

		static IntPtr id_filterByProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterByProximity' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeacon.BCProximity']]"
		[Register ("filterByProximity", "(Lcom/bluecats/sdk/BCBeacon$BCProximity;)Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterByProximity (global::Com.Bluecats.Sdk.BCBeaconBCProximity proximity)
		{
			if (id_filterByProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ == IntPtr.Zero)
				id_filterByProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ = JNIEnv.GetStaticMethodID (class_ref, "filterByProximity", "(Lcom/bluecats/sdk/BCBeacon$BCProximity;)Lcom/bluecats/sdk/BCEventFilter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (proximity);
				global::Com.Bluecats.Sdk.BCEventFilter __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterByProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_filterByReassembledBlockDataWithDataType_Lcom_bluecats_sdk_BCBeaconUpdates_BCBlockDataType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterByReassembledBlockDataWithDataType' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeaconUpdates.BCBlockDataType']]"
		[Register ("filterByReassembledBlockDataWithDataType", "(Lcom/bluecats/sdk/BCBeaconUpdates$BCBlockDataType;)Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterByReassembledBlockDataWithDataType (global::Com.Bluecats.Sdk.BCBeaconUpdates.BCBlockDataType dataType)
		{
			if (id_filterByReassembledBlockDataWithDataType_Lcom_bluecats_sdk_BCBeaconUpdates_BCBlockDataType_ == IntPtr.Zero)
				id_filterByReassembledBlockDataWithDataType_Lcom_bluecats_sdk_BCBeaconUpdates_BCBlockDataType_ = JNIEnv.GetStaticMethodID (class_ref, "filterByReassembledBlockDataWithDataType", "(Lcom/bluecats/sdk/BCBeaconUpdates$BCBlockDataType;)Lcom/bluecats/sdk/BCEventFilter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (dataType);
				global::Com.Bluecats.Sdk.BCEventFilter __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterByReassembledBlockDataWithDataType_Lcom_bluecats_sdk_BCBeaconUpdates_BCBlockDataType_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_filterBySitesNamed_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterBySitesNamed' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("filterBySitesNamed", "(Ljava/util/List;)Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterBySitesNamed (global::System.Collections.Generic.IList<string> siteNames)
		{
			if (id_filterBySitesNamed_Ljava_util_List_ == IntPtr.Zero)
				id_filterBySitesNamed_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "filterBySitesNamed", "(Ljava/util/List;)Lcom/bluecats/sdk/BCEventFilter;");
			IntPtr native_siteNames = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (siteNames);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_siteNames);
				global::Com.Bluecats.Sdk.BCEventFilter __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterBySitesNamed_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_siteNames);
			}
		}

		static IntPtr id_filterBySitesWithIDs_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterBySitesWithIDs' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("filterBySitesWithIDs", "(Ljava/util/List;)Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterBySitesWithIDs (global::System.Collections.Generic.IList<string> siteIDs)
		{
			if (id_filterBySitesWithIDs_Ljava_util_List_ == IntPtr.Zero)
				id_filterBySitesWithIDs_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "filterBySitesWithIDs", "(Ljava/util/List;)Lcom/bluecats/sdk/BCEventFilter;");
			IntPtr native_siteIDs = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (siteIDs);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_siteIDs);
				global::Com.Bluecats.Sdk.BCEventFilter __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterBySitesWithIDs_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_siteIDs);
			}
		}

		static IntPtr id_filterBySitesWithPredicate_Lcom_bluecats_sdk_BCPredicate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='filterBySitesWithPredicate' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCPredicate&lt;com.bluecats.sdk.BCSite&gt;']]"
		[Register ("filterBySitesWithPredicate", "(Lcom/bluecats/sdk/BCPredicate;)Lcom/bluecats/sdk/BCEventFilter;", "")]
		public static unsafe global::Com.Bluecats.Sdk.BCEventFilter FilterBySitesWithPredicate (global::Com.Bluecats.Sdk.IBCPredicate sitePredicate)
		{
			if (id_filterBySitesWithPredicate_Lcom_bluecats_sdk_BCPredicate_ == IntPtr.Zero)
				id_filterBySitesWithPredicate_Lcom_bluecats_sdk_BCPredicate_ = JNIEnv.GetStaticMethodID (class_ref, "filterBySitesWithPredicate", "(Lcom/bluecats/sdk/BCPredicate;)Lcom/bluecats/sdk/BCEventFilter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sitePredicate);
				global::Com.Bluecats.Sdk.BCEventFilter __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_filterBySitesWithPredicate_Lcom_bluecats_sdk_BCPredicate_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setShouldApplyFilterWhenNoBeaconsRemaining_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetShouldApplyFilterWhenNoBeaconsRemaining_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setShouldApplyFilterWhenNoBeaconsRemaining_Ljava_lang_Boolean_ == null)
				cb_setShouldApplyFilterWhenNoBeaconsRemaining_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShouldApplyFilterWhenNoBeaconsRemaining_Ljava_lang_Boolean_);
			return cb_setShouldApplyFilterWhenNoBeaconsRemaining_Ljava_lang_Boolean_;
		}

		static void n_SetShouldApplyFilterWhenNoBeaconsRemaining_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCEventFilter __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean value = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SetShouldApplyFilterWhenNoBeaconsRemaining (value);
		}
#pragma warning restore 0169

		static IntPtr id_setShouldApplyFilterWhenNoBeaconsRemaining_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='setShouldApplyFilterWhenNoBeaconsRemaining' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setShouldApplyFilterWhenNoBeaconsRemaining", "(Ljava/lang/Boolean;)V", "GetSetShouldApplyFilterWhenNoBeaconsRemaining_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetShouldApplyFilterWhenNoBeaconsRemaining (global::Java.Lang.Boolean value)
		{
			if (id_setShouldApplyFilterWhenNoBeaconsRemaining_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setShouldApplyFilterWhenNoBeaconsRemaining_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setShouldApplyFilterWhenNoBeaconsRemaining", "(Ljava/lang/Boolean;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShouldApplyFilterWhenNoBeaconsRemaining_Ljava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShouldApplyFilterWhenNoBeaconsRemaining", "(Ljava/lang/Boolean;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_shouldApplyFilterWhenNoBeaconsRemaining;
#pragma warning disable 0169
		static Delegate GetShouldApplyFilterWhenNoBeaconsRemainingHandler ()
		{
			if (cb_shouldApplyFilterWhenNoBeaconsRemaining == null)
				cb_shouldApplyFilterWhenNoBeaconsRemaining = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ShouldApplyFilterWhenNoBeaconsRemaining);
			return cb_shouldApplyFilterWhenNoBeaconsRemaining;
		}

		static IntPtr n_ShouldApplyFilterWhenNoBeaconsRemaining (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCEventFilter __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShouldApplyFilterWhenNoBeaconsRemaining ());
		}
#pragma warning restore 0169

		static IntPtr id_shouldApplyFilterWhenNoBeaconsRemaining;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEventFilter']/method[@name='shouldApplyFilterWhenNoBeaconsRemaining' and count(parameter)=0]"
		[Register ("shouldApplyFilterWhenNoBeaconsRemaining", "()Ljava/lang/Boolean;", "GetShouldApplyFilterWhenNoBeaconsRemainingHandler")]
		public virtual unsafe global::Java.Lang.Boolean ShouldApplyFilterWhenNoBeaconsRemaining ()
		{
			if (id_shouldApplyFilterWhenNoBeaconsRemaining == IntPtr.Zero)
				id_shouldApplyFilterWhenNoBeaconsRemaining = JNIEnv.GetMethodID (class_ref, "shouldApplyFilterWhenNoBeaconsRemaining", "()Ljava/lang/Boolean;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_shouldApplyFilterWhenNoBeaconsRemaining), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldApplyFilterWhenNoBeaconsRemaining", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
