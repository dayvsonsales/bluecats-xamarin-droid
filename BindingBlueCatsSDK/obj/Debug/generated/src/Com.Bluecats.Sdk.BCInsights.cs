using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCInsights", DoNotGenerateAcw=true)]
	public partial class BCInsights : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights.BCInsightsPeriod']"
		[global::Android.Runtime.Register ("com/bluecats/sdk/BCInsights$BCInsightsPeriod", DoNotGenerateAcw=true)]
		public sealed partial class BCInsightsPeriod : global::Java.Lang.Enum {


			static IntPtr BC_INSIGHTS_PERIOD_DAY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights.BCInsightsPeriod']/field[@name='BC_INSIGHTS_PERIOD_DAY']"
			[Register ("BC_INSIGHTS_PERIOD_DAY")]
			public static global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod BcInsightsPeriodDay {
				get {
					if (BC_INSIGHTS_PERIOD_DAY_jfieldId == IntPtr.Zero)
						BC_INSIGHTS_PERIOD_DAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_INSIGHTS_PERIOD_DAY", "Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_INSIGHTS_PERIOD_DAY_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_INSIGHTS_PERIOD_MONTH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights.BCInsightsPeriod']/field[@name='BC_INSIGHTS_PERIOD_MONTH']"
			[Register ("BC_INSIGHTS_PERIOD_MONTH")]
			public static global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod BcInsightsPeriodMonth {
				get {
					if (BC_INSIGHTS_PERIOD_MONTH_jfieldId == IntPtr.Zero)
						BC_INSIGHTS_PERIOD_MONTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_INSIGHTS_PERIOD_MONTH", "Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_INSIGHTS_PERIOD_MONTH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_INSIGHTS_PERIOD_WEEK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights.BCInsightsPeriod']/field[@name='BC_INSIGHTS_PERIOD_WEEK']"
			[Register ("BC_INSIGHTS_PERIOD_WEEK")]
			public static global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod BcInsightsPeriodWeek {
				get {
					if (BC_INSIGHTS_PERIOD_WEEK_jfieldId == IntPtr.Zero)
						BC_INSIGHTS_PERIOD_WEEK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_INSIGHTS_PERIOD_WEEK", "Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_INSIGHTS_PERIOD_WEEK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_INSIGHTS_PERIOD_YEAR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights.BCInsightsPeriod']/field[@name='BC_INSIGHTS_PERIOD_YEAR']"
			[Register ("BC_INSIGHTS_PERIOD_YEAR")]
			public static global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod BcInsightsPeriodYear {
				get {
					if (BC_INSIGHTS_PERIOD_YEAR_jfieldId == IntPtr.Zero)
						BC_INSIGHTS_PERIOD_YEAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_INSIGHTS_PERIOD_YEAR", "Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_INSIGHTS_PERIOD_YEAR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bluecats/sdk/BCInsights$BCInsightsPeriod", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BCInsightsPeriod); }
			}

			internal BCInsightsPeriod (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getDisplayName;
			public unsafe string DisplayName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights.BCInsightsPeriod']/method[@name='getDisplayName' and count(parameter)=0]"
				[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler")]
				get {
					if (id_getDisplayName == IntPtr.Zero)
						id_getDisplayName = JNIEnv.GetMethodID (class_ref, "getDisplayName", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayName), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_getOrder;
			public unsafe int Order {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights.BCInsightsPeriod']/method[@name='getOrder' and count(parameter)=0]"
				[Register ("getOrder", "()I", "GetGetOrderHandler")]
				get {
					if (id_getOrder == IntPtr.Zero)
						id_getOrder = JNIEnv.GetMethodID (class_ref, "getOrder", "()I");
					try {
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOrder);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights.BCInsightsPeriod']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;", "")]
			public static unsafe global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights.BCInsightsPeriod']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;", "")]
			public static unsafe global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;");
				try {
					return (global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCInsights", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCInsights); }
		}

		protected BCInsights (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/constructor[@name='BCInsights' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCInsights ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCInsights)) {
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

		static Delegate cb_getAverageDurationOfVisits;
#pragma warning disable 0169
		static Delegate GetGetAverageDurationOfVisitsHandler ()
		{
			if (cb_getAverageDurationOfVisits == null)
				cb_getAverageDurationOfVisits = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetAverageDurationOfVisits);
			return cb_getAverageDurationOfVisits;
		}

		static double n_GetAverageDurationOfVisits (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AverageDurationOfVisits;
		}
#pragma warning restore 0169

		static Delegate cb_setAverageDurationOfVisits_D;
#pragma warning disable 0169
		static Delegate GetSetAverageDurationOfVisits_DHandler ()
		{
			if (cb_setAverageDurationOfVisits_D == null)
				cb_setAverageDurationOfVisits_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetAverageDurationOfVisits_D);
			return cb_setAverageDurationOfVisits_D;
		}

		static void n_SetAverageDurationOfVisits_D (IntPtr jnienv, IntPtr native__this, double value)
		{
			global::Com.Bluecats.Sdk.BCInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AverageDurationOfVisits = value;
		}
#pragma warning restore 0169

		static IntPtr id_getAverageDurationOfVisits;
		static IntPtr id_setAverageDurationOfVisits_D;
		public virtual unsafe double AverageDurationOfVisits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/method[@name='getAverageDurationOfVisits' and count(parameter)=0]"
			[Register ("getAverageDurationOfVisits", "()D", "GetGetAverageDurationOfVisitsHandler")]
			get {
				if (id_getAverageDurationOfVisits == IntPtr.Zero)
					id_getAverageDurationOfVisits = JNIEnv.GetMethodID (class_ref, "getAverageDurationOfVisits", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getAverageDurationOfVisits);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAverageDurationOfVisits", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/method[@name='setAverageDurationOfVisits' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setAverageDurationOfVisits", "(D)V", "GetSetAverageDurationOfVisits_DHandler")]
			set {
				if (id_setAverageDurationOfVisits_D == IntPtr.Zero)
					id_setAverageDurationOfVisits_D = JNIEnv.GetMethodID (class_ref, "setAverageDurationOfVisits", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAverageDurationOfVisits_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAverageDurationOfVisits", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDuration);
			return cb_getDuration;
		}

		static long n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		static Delegate cb_setDuration_J;
#pragma warning disable 0169
		static Delegate GetSetDuration_JHandler ()
		{
			if (cb_setDuration_J == null)
				cb_setDuration_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetDuration_J);
			return cb_setDuration_J;
		}

		static void n_SetDuration_J (IntPtr jnienv, IntPtr native__this, long value)
		{
			global::Com.Bluecats.Sdk.BCInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Duration = value;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		static IntPtr id_setDuration_J;
		public virtual unsafe long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()J", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDuration);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setDuration", "(J)V", "GetSetDuration_JHandler")]
			set {
				if (id_setDuration_J == IntPtr.Zero)
					id_setDuration_J = JNIEnv.GetMethodID (class_ref, "setDuration", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDuration_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDuration", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEndDate;
#pragma warning disable 0169
		static Delegate GetGetEndDateHandler ()
		{
			if (cb_getEndDate == null)
				cb_getEndDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndDate);
			return cb_getEndDate;
		}

		static IntPtr n_GetEndDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EndDate);
		}
#pragma warning restore 0169

		static Delegate cb_setEndDate_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetEndDate_Ljava_util_Date_Handler ()
		{
			if (cb_setEndDate_Ljava_util_Date_ == null)
				cb_setEndDate_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEndDate_Ljava_util_Date_);
			return cb_setEndDate_Ljava_util_Date_;
		}

		static void n_SetEndDate_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.EndDate = value;
		}
#pragma warning restore 0169

		static IntPtr id_getEndDate;
		static IntPtr id_setEndDate_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date EndDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/method[@name='getEndDate' and count(parameter)=0]"
			[Register ("getEndDate", "()Ljava/util/Date;", "GetGetEndDateHandler")]
			get {
				if (id_getEndDate == IntPtr.Zero)
					id_getEndDate = JNIEnv.GetMethodID (class_ref, "getEndDate", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEndDate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEndDate", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/method[@name='setEndDate' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setEndDate", "(Ljava/util/Date;)V", "GetSetEndDate_Ljava_util_Date_Handler")]
			set {
				if (id_setEndDate_Ljava_util_Date_ == IntPtr.Zero)
					id_setEndDate_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setEndDate", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEndDate_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEndDate", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPeriod;
#pragma warning disable 0169
		static Delegate GetGetPeriodHandler ()
		{
			if (cb_getPeriod == null)
				cb_getPeriod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPeriod);
			return cb_getPeriod;
		}

		static IntPtr n_GetPeriod (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Period);
		}
#pragma warning restore 0169

		static Delegate cb_setPeriod_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_;
#pragma warning disable 0169
		static Delegate GetSetPeriod_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_Handler ()
		{
			if (cb_setPeriod_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_ == null)
				cb_setPeriod_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPeriod_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_);
			return cb_setPeriod_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_;
		}

		static void n_SetPeriod_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod value = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Period = value;
		}
#pragma warning restore 0169

		static IntPtr id_getPeriod;
		static IntPtr id_setPeriod_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_;
		public virtual unsafe global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod Period {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/method[@name='getPeriod' and count(parameter)=0]"
			[Register ("getPeriod", "()Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;", "GetGetPeriodHandler")]
			get {
				if (id_getPeriod == IntPtr.Zero)
					id_getPeriod = JNIEnv.GetMethodID (class_ref, "getPeriod", "()Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPeriod), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPeriod", "()Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/method[@name='setPeriod' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCInsights.BCInsightsPeriod']]"
			[Register ("setPeriod", "(Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;)V", "GetSetPeriod_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_Handler")]
			set {
				if (id_setPeriod_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_ == IntPtr.Zero)
					id_setPeriod_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_ = JNIEnv.GetMethodID (class_ref, "setPeriod", "(Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPeriod_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPeriod", "(Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTotalDurationOfVisits;
#pragma warning disable 0169
		static Delegate GetGetTotalDurationOfVisitsHandler ()
		{
			if (cb_getTotalDurationOfVisits == null)
				cb_getTotalDurationOfVisits = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetTotalDurationOfVisits);
			return cb_getTotalDurationOfVisits;
		}

		static double n_GetTotalDurationOfVisits (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalDurationOfVisits;
		}
#pragma warning restore 0169

		static Delegate cb_setTotalDurationOfVisits_D;
#pragma warning disable 0169
		static Delegate GetSetTotalDurationOfVisits_DHandler ()
		{
			if (cb_setTotalDurationOfVisits_D == null)
				cb_setTotalDurationOfVisits_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetTotalDurationOfVisits_D);
			return cb_setTotalDurationOfVisits_D;
		}

		static void n_SetTotalDurationOfVisits_D (IntPtr jnienv, IntPtr native__this, double value)
		{
			global::Com.Bluecats.Sdk.BCInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TotalDurationOfVisits = value;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalDurationOfVisits;
		static IntPtr id_setTotalDurationOfVisits_D;
		public virtual unsafe double TotalDurationOfVisits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/method[@name='getTotalDurationOfVisits' and count(parameter)=0]"
			[Register ("getTotalDurationOfVisits", "()D", "GetGetTotalDurationOfVisitsHandler")]
			get {
				if (id_getTotalDurationOfVisits == IntPtr.Zero)
					id_getTotalDurationOfVisits = JNIEnv.GetMethodID (class_ref, "getTotalDurationOfVisits", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getTotalDurationOfVisits);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalDurationOfVisits", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/method[@name='setTotalDurationOfVisits' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setTotalDurationOfVisits", "(D)V", "GetSetTotalDurationOfVisits_DHandler")]
			set {
				if (id_setTotalDurationOfVisits_D == IntPtr.Zero)
					id_setTotalDurationOfVisits_D = JNIEnv.GetMethodID (class_ref, "setTotalDurationOfVisits", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTotalDurationOfVisits_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTotalDurationOfVisits", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTotalNumOfNewVisitors;
#pragma warning disable 0169
		static Delegate GetGetTotalNumOfNewVisitorsHandler ()
		{
			if (cb_getTotalNumOfNewVisitors == null)
				cb_getTotalNumOfNewVisitors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTotalNumOfNewVisitors);
			return cb_getTotalNumOfNewVisitors;
		}

		static int n_GetTotalNumOfNewVisitors (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalNumOfNewVisitors;
		}
#pragma warning restore 0169

		static Delegate cb_setTotalNumOfNewVisitors_I;
#pragma warning disable 0169
		static Delegate GetSetTotalNumOfNewVisitors_IHandler ()
		{
			if (cb_setTotalNumOfNewVisitors_I == null)
				cb_setTotalNumOfNewVisitors_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTotalNumOfNewVisitors_I);
			return cb_setTotalNumOfNewVisitors_I;
		}

		static void n_SetTotalNumOfNewVisitors_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Bluecats.Sdk.BCInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TotalNumOfNewVisitors = value;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalNumOfNewVisitors;
		static IntPtr id_setTotalNumOfNewVisitors_I;
		public virtual unsafe int TotalNumOfNewVisitors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/method[@name='getTotalNumOfNewVisitors' and count(parameter)=0]"
			[Register ("getTotalNumOfNewVisitors", "()I", "GetGetTotalNumOfNewVisitorsHandler")]
			get {
				if (id_getTotalNumOfNewVisitors == IntPtr.Zero)
					id_getTotalNumOfNewVisitors = JNIEnv.GetMethodID (class_ref, "getTotalNumOfNewVisitors", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTotalNumOfNewVisitors);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalNumOfNewVisitors", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/method[@name='setTotalNumOfNewVisitors' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTotalNumOfNewVisitors", "(I)V", "GetSetTotalNumOfNewVisitors_IHandler")]
			set {
				if (id_setTotalNumOfNewVisitors_I == IntPtr.Zero)
					id_setTotalNumOfNewVisitors_I = JNIEnv.GetMethodID (class_ref, "setTotalNumOfNewVisitors", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTotalNumOfNewVisitors_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTotalNumOfNewVisitors", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTotalNumOfReturningVisitors;
#pragma warning disable 0169
		static Delegate GetGetTotalNumOfReturningVisitorsHandler ()
		{
			if (cb_getTotalNumOfReturningVisitors == null)
				cb_getTotalNumOfReturningVisitors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTotalNumOfReturningVisitors);
			return cb_getTotalNumOfReturningVisitors;
		}

		static int n_GetTotalNumOfReturningVisitors (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalNumOfReturningVisitors;
		}
#pragma warning restore 0169

		static Delegate cb_setTotalNumOfReturningVisitors_I;
#pragma warning disable 0169
		static Delegate GetSetTotalNumOfReturningVisitors_IHandler ()
		{
			if (cb_setTotalNumOfReturningVisitors_I == null)
				cb_setTotalNumOfReturningVisitors_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTotalNumOfReturningVisitors_I);
			return cb_setTotalNumOfReturningVisitors_I;
		}

		static void n_SetTotalNumOfReturningVisitors_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Bluecats.Sdk.BCInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TotalNumOfReturningVisitors = value;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalNumOfReturningVisitors;
		static IntPtr id_setTotalNumOfReturningVisitors_I;
		public virtual unsafe int TotalNumOfReturningVisitors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/method[@name='getTotalNumOfReturningVisitors' and count(parameter)=0]"
			[Register ("getTotalNumOfReturningVisitors", "()I", "GetGetTotalNumOfReturningVisitorsHandler")]
			get {
				if (id_getTotalNumOfReturningVisitors == IntPtr.Zero)
					id_getTotalNumOfReturningVisitors = JNIEnv.GetMethodID (class_ref, "getTotalNumOfReturningVisitors", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTotalNumOfReturningVisitors);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalNumOfReturningVisitors", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/method[@name='setTotalNumOfReturningVisitors' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTotalNumOfReturningVisitors", "(I)V", "GetSetTotalNumOfReturningVisitors_IHandler")]
			set {
				if (id_setTotalNumOfReturningVisitors_I == IntPtr.Zero)
					id_setTotalNumOfReturningVisitors_I = JNIEnv.GetMethodID (class_ref, "setTotalNumOfReturningVisitors", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTotalNumOfReturningVisitors_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTotalNumOfReturningVisitors", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTotalNumOfVisitors;
#pragma warning disable 0169
		static Delegate GetGetTotalNumOfVisitorsHandler ()
		{
			if (cb_getTotalNumOfVisitors == null)
				cb_getTotalNumOfVisitors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTotalNumOfVisitors);
			return cb_getTotalNumOfVisitors;
		}

		static int n_GetTotalNumOfVisitors (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalNumOfVisitors;
		}
#pragma warning restore 0169

		static Delegate cb_setTotalNumOfVisitors_I;
#pragma warning disable 0169
		static Delegate GetSetTotalNumOfVisitors_IHandler ()
		{
			if (cb_setTotalNumOfVisitors_I == null)
				cb_setTotalNumOfVisitors_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTotalNumOfVisitors_I);
			return cb_setTotalNumOfVisitors_I;
		}

		static void n_SetTotalNumOfVisitors_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Bluecats.Sdk.BCInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TotalNumOfVisitors = value;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalNumOfVisitors;
		static IntPtr id_setTotalNumOfVisitors_I;
		public virtual unsafe int TotalNumOfVisitors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/method[@name='getTotalNumOfVisitors' and count(parameter)=0]"
			[Register ("getTotalNumOfVisitors", "()I", "GetGetTotalNumOfVisitorsHandler")]
			get {
				if (id_getTotalNumOfVisitors == IntPtr.Zero)
					id_getTotalNumOfVisitors = JNIEnv.GetMethodID (class_ref, "getTotalNumOfVisitors", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTotalNumOfVisitors);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalNumOfVisitors", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/method[@name='setTotalNumOfVisitors' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTotalNumOfVisitors", "(I)V", "GetSetTotalNumOfVisitors_IHandler")]
			set {
				if (id_setTotalNumOfVisitors_I == IntPtr.Zero)
					id_setTotalNumOfVisitors_I = JNIEnv.GetMethodID (class_ref, "setTotalNumOfVisitors", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTotalNumOfVisitors_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTotalNumOfVisitors", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTotalNumOfVisits;
#pragma warning disable 0169
		static Delegate GetGetTotalNumOfVisitsHandler ()
		{
			if (cb_getTotalNumOfVisits == null)
				cb_getTotalNumOfVisits = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTotalNumOfVisits);
			return cb_getTotalNumOfVisits;
		}

		static int n_GetTotalNumOfVisits (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalNumOfVisits;
		}
#pragma warning restore 0169

		static Delegate cb_setTotalNumOfVisits_I;
#pragma warning disable 0169
		static Delegate GetSetTotalNumOfVisits_IHandler ()
		{
			if (cb_setTotalNumOfVisits_I == null)
				cb_setTotalNumOfVisits_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTotalNumOfVisits_I);
			return cb_setTotalNumOfVisits_I;
		}

		static void n_SetTotalNumOfVisits_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Bluecats.Sdk.BCInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TotalNumOfVisits = value;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalNumOfVisits;
		static IntPtr id_setTotalNumOfVisits_I;
		public virtual unsafe int TotalNumOfVisits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/method[@name='getTotalNumOfVisits' and count(parameter)=0]"
			[Register ("getTotalNumOfVisits", "()I", "GetGetTotalNumOfVisitsHandler")]
			get {
				if (id_getTotalNumOfVisits == IntPtr.Zero)
					id_getTotalNumOfVisits = JNIEnv.GetMethodID (class_ref, "getTotalNumOfVisits", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTotalNumOfVisits);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalNumOfVisits", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/method[@name='setTotalNumOfVisits' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTotalNumOfVisits", "(I)V", "GetSetTotalNumOfVisits_IHandler")]
			set {
				if (id_setTotalNumOfVisits_I == IntPtr.Zero)
					id_setTotalNumOfVisits_I = JNIEnv.GetMethodID (class_ref, "setTotalNumOfVisits", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTotalNumOfVisits_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTotalNumOfVisits", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static IntPtr id_getPeriodAsInt_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/method[@name='getPeriodAsInt' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCInsights.BCInsightsPeriod']]"
		[Register ("getPeriodAsInt", "(Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;)J", "")]
		public static unsafe long GetPeriodAsInt (global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod period)
		{
			if (id_getPeriodAsInt_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_ == IntPtr.Zero)
				id_getPeriodAsInt_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_ = JNIEnv.GetStaticMethodID (class_ref, "getPeriodAsInt", "(Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (period);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_getPeriodAsInt_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getPeriodicInsights;
#pragma warning disable 0169
		static Delegate GetGetPeriodicInsightsHandler ()
		{
			if (cb_getPeriodicInsights == null)
				cb_getPeriodicInsights = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPeriodicInsights);
			return cb_getPeriodicInsights;
		}

		static IntPtr n_GetPeriodicInsights (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPeriodicInsights ());
		}
#pragma warning restore 0169

		static IntPtr id_getPeriodicInsights;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/method[@name='getPeriodicInsights' and count(parameter)=0]"
		[Register ("getPeriodicInsights", "()[Lcom/bluecats/sdk/BCPeriodicInsights;", "GetGetPeriodicInsightsHandler")]
		public virtual unsafe global::Com.Bluecats.Sdk.BCPeriodicInsights[] GetPeriodicInsights ()
		{
			if (id_getPeriodicInsights == IntPtr.Zero)
				id_getPeriodicInsights = JNIEnv.GetMethodID (class_ref, "getPeriodicInsights", "()[Lcom/bluecats/sdk/BCPeriodicInsights;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Com.Bluecats.Sdk.BCPeriodicInsights[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPeriodicInsights), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCPeriodicInsights));
				else
					return (global::Com.Bluecats.Sdk.BCPeriodicInsights[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPeriodicInsights", "()[Lcom/bluecats/sdk/BCPeriodicInsights;")), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCPeriodicInsights));
			} finally {
			}
		}

		static Delegate cb_setPeriodicInsights_arrayLcom_bluecats_sdk_BCPeriodicInsights_;
#pragma warning disable 0169
		static Delegate GetSetPeriodicInsights_arrayLcom_bluecats_sdk_BCPeriodicInsights_Handler ()
		{
			if (cb_setPeriodicInsights_arrayLcom_bluecats_sdk_BCPeriodicInsights_ == null)
				cb_setPeriodicInsights_arrayLcom_bluecats_sdk_BCPeriodicInsights_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPeriodicInsights_arrayLcom_bluecats_sdk_BCPeriodicInsights_);
			return cb_setPeriodicInsights_arrayLcom_bluecats_sdk_BCPeriodicInsights_;
		}

		static void n_SetPeriodicInsights_arrayLcom_bluecats_sdk_BCPeriodicInsights_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCPeriodicInsights[] value = (global::Com.Bluecats.Sdk.BCPeriodicInsights[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Bluecats.Sdk.BCPeriodicInsights));
			__this.SetPeriodicInsights (value);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		static IntPtr id_setPeriodicInsights_arrayLcom_bluecats_sdk_BCPeriodicInsights_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/method[@name='setPeriodicInsights' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCPeriodicInsights[]']]"
		[Register ("setPeriodicInsights", "([Lcom/bluecats/sdk/BCPeriodicInsights;)V", "GetSetPeriodicInsights_arrayLcom_bluecats_sdk_BCPeriodicInsights_Handler")]
		public virtual unsafe void SetPeriodicInsights (global::Com.Bluecats.Sdk.BCPeriodicInsights[] value)
		{
			if (id_setPeriodicInsights_arrayLcom_bluecats_sdk_BCPeriodicInsights_ == IntPtr.Zero)
				id_setPeriodicInsights_arrayLcom_bluecats_sdk_BCPeriodicInsights_ = JNIEnv.GetMethodID (class_ref, "setPeriodicInsights", "([Lcom/bluecats/sdk/BCPeriodicInsights;)V");
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPeriodicInsights_arrayLcom_bluecats_sdk_BCPeriodicInsights_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPeriodicInsights", "([Lcom/bluecats/sdk/BCPeriodicInsights;)V"), __args);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.Bluecats.Sdk.BCInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCInsights']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dest);
				__args [1] = new JValue ((int) flags);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
