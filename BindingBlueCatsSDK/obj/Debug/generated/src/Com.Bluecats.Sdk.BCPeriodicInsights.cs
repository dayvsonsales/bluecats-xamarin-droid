using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPeriodicInsights']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCPeriodicInsights", DoNotGenerateAcw=true)]
	public partial class BCPeriodicInsights : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPeriodicInsights']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCPeriodicInsights", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCPeriodicInsights); }
		}

		protected BCPeriodicInsights (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPeriodicInsights']/constructor[@name='BCPeriodicInsights' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCPeriodicInsights ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCPeriodicInsights)) {
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
			global::Com.Bluecats.Sdk.BCPeriodicInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPeriodicInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCPeriodicInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPeriodicInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AverageDurationOfVisits = value;
		}
#pragma warning restore 0169

		static IntPtr id_getAverageDurationOfVisits;
		static IntPtr id_setAverageDurationOfVisits_D;
		public virtual unsafe double AverageDurationOfVisits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPeriodicInsights']/method[@name='getAverageDurationOfVisits' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPeriodicInsights']/method[@name='setAverageDurationOfVisits' and count(parameter)=1 and parameter[1][@type='double']]"
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

		static Delegate cb_getCumulativeDurationOfVisits;
#pragma warning disable 0169
		static Delegate GetGetCumulativeDurationOfVisitsHandler ()
		{
			if (cb_getCumulativeDurationOfVisits == null)
				cb_getCumulativeDurationOfVisits = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetCumulativeDurationOfVisits);
			return cb_getCumulativeDurationOfVisits;
		}

		static double n_GetCumulativeDurationOfVisits (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCPeriodicInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPeriodicInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CumulativeDurationOfVisits;
		}
#pragma warning restore 0169

		static Delegate cb_setCumulativeDurationOfVisits_D;
#pragma warning disable 0169
		static Delegate GetSetCumulativeDurationOfVisits_DHandler ()
		{
			if (cb_setCumulativeDurationOfVisits_D == null)
				cb_setCumulativeDurationOfVisits_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetCumulativeDurationOfVisits_D);
			return cb_setCumulativeDurationOfVisits_D;
		}

		static void n_SetCumulativeDurationOfVisits_D (IntPtr jnienv, IntPtr native__this, double value)
		{
			global::Com.Bluecats.Sdk.BCPeriodicInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPeriodicInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CumulativeDurationOfVisits = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCumulativeDurationOfVisits;
		static IntPtr id_setCumulativeDurationOfVisits_D;
		public virtual unsafe double CumulativeDurationOfVisits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPeriodicInsights']/method[@name='getCumulativeDurationOfVisits' and count(parameter)=0]"
			[Register ("getCumulativeDurationOfVisits", "()D", "GetGetCumulativeDurationOfVisitsHandler")]
			get {
				if (id_getCumulativeDurationOfVisits == IntPtr.Zero)
					id_getCumulativeDurationOfVisits = JNIEnv.GetMethodID (class_ref, "getCumulativeDurationOfVisits", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getCumulativeDurationOfVisits);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCumulativeDurationOfVisits", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPeriodicInsights']/method[@name='setCumulativeDurationOfVisits' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setCumulativeDurationOfVisits", "(D)V", "GetSetCumulativeDurationOfVisits_DHandler")]
			set {
				if (id_setCumulativeDurationOfVisits_D == IntPtr.Zero)
					id_setCumulativeDurationOfVisits_D = JNIEnv.GetMethodID (class_ref, "setCumulativeDurationOfVisits", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCumulativeDurationOfVisits_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCumulativeDurationOfVisits", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDate;
#pragma warning disable 0169
		static Delegate GetGetDateHandler ()
		{
			if (cb_getDate == null)
				cb_getDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDate);
			return cb_getDate;
		}

		static IntPtr n_GetDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCPeriodicInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPeriodicInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Date);
		}
#pragma warning restore 0169

		static Delegate cb_setDate_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetDate_Ljava_util_Date_Handler ()
		{
			if (cb_setDate_Ljava_util_Date_ == null)
				cb_setDate_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDate_Ljava_util_Date_);
			return cb_setDate_Ljava_util_Date_;
		}

		static void n_SetDate_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCPeriodicInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPeriodicInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Date = value;
		}
#pragma warning restore 0169

		static IntPtr id_getDate;
		static IntPtr id_setDate_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date Date {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPeriodicInsights']/method[@name='getDate' and count(parameter)=0]"
			[Register ("getDate", "()Ljava/util/Date;", "GetGetDateHandler")]
			get {
				if (id_getDate == IntPtr.Zero)
					id_getDate = JNIEnv.GetMethodID (class_ref, "getDate", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDate", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPeriodicInsights']/method[@name='setDate' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setDate", "(Ljava/util/Date;)V", "GetSetDate_Ljava_util_Date_Handler")]
			set {
				if (id_setDate_Ljava_util_Date_ == IntPtr.Zero)
					id_setDate_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setDate", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDate_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDate", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxDurationOfVisits;
#pragma warning disable 0169
		static Delegate GetGetMaxDurationOfVisitsHandler ()
		{
			if (cb_getMaxDurationOfVisits == null)
				cb_getMaxDurationOfVisits = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMaxDurationOfVisits);
			return cb_getMaxDurationOfVisits;
		}

		static double n_GetMaxDurationOfVisits (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCPeriodicInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPeriodicInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxDurationOfVisits;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxDurationOfVisits_D;
#pragma warning disable 0169
		static Delegate GetSetMaxDurationOfVisits_DHandler ()
		{
			if (cb_setMaxDurationOfVisits_D == null)
				cb_setMaxDurationOfVisits_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetMaxDurationOfVisits_D);
			return cb_setMaxDurationOfVisits_D;
		}

		static void n_SetMaxDurationOfVisits_D (IntPtr jnienv, IntPtr native__this, double value)
		{
			global::Com.Bluecats.Sdk.BCPeriodicInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPeriodicInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxDurationOfVisits = value;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxDurationOfVisits;
		static IntPtr id_setMaxDurationOfVisits_D;
		public virtual unsafe double MaxDurationOfVisits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPeriodicInsights']/method[@name='getMaxDurationOfVisits' and count(parameter)=0]"
			[Register ("getMaxDurationOfVisits", "()D", "GetGetMaxDurationOfVisitsHandler")]
			get {
				if (id_getMaxDurationOfVisits == IntPtr.Zero)
					id_getMaxDurationOfVisits = JNIEnv.GetMethodID (class_ref, "getMaxDurationOfVisits", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getMaxDurationOfVisits);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxDurationOfVisits", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPeriodicInsights']/method[@name='setMaxDurationOfVisits' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setMaxDurationOfVisits", "(D)V", "GetSetMaxDurationOfVisits_DHandler")]
			set {
				if (id_setMaxDurationOfVisits_D == IntPtr.Zero)
					id_setMaxDurationOfVisits_D = JNIEnv.GetMethodID (class_ref, "setMaxDurationOfVisits", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxDurationOfVisits_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxDurationOfVisits", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMinDurationOfVisits;
#pragma warning disable 0169
		static Delegate GetGetMinDurationOfVisitsHandler ()
		{
			if (cb_getMinDurationOfVisits == null)
				cb_getMinDurationOfVisits = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMinDurationOfVisits);
			return cb_getMinDurationOfVisits;
		}

		static double n_GetMinDurationOfVisits (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCPeriodicInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPeriodicInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinDurationOfVisits;
		}
#pragma warning restore 0169

		static Delegate cb_setMinDurationOfVisits_D;
#pragma warning disable 0169
		static Delegate GetSetMinDurationOfVisits_DHandler ()
		{
			if (cb_setMinDurationOfVisits_D == null)
				cb_setMinDurationOfVisits_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetMinDurationOfVisits_D);
			return cb_setMinDurationOfVisits_D;
		}

		static void n_SetMinDurationOfVisits_D (IntPtr jnienv, IntPtr native__this, double value)
		{
			global::Com.Bluecats.Sdk.BCPeriodicInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPeriodicInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinDurationOfVisits = value;
		}
#pragma warning restore 0169

		static IntPtr id_getMinDurationOfVisits;
		static IntPtr id_setMinDurationOfVisits_D;
		public virtual unsafe double MinDurationOfVisits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPeriodicInsights']/method[@name='getMinDurationOfVisits' and count(parameter)=0]"
			[Register ("getMinDurationOfVisits", "()D", "GetGetMinDurationOfVisitsHandler")]
			get {
				if (id_getMinDurationOfVisits == IntPtr.Zero)
					id_getMinDurationOfVisits = JNIEnv.GetMethodID (class_ref, "getMinDurationOfVisits", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getMinDurationOfVisits);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinDurationOfVisits", "()D"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPeriodicInsights']/method[@name='setMinDurationOfVisits' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setMinDurationOfVisits", "(D)V", "GetSetMinDurationOfVisits_DHandler")]
			set {
				if (id_setMinDurationOfVisits_D == IntPtr.Zero)
					id_setMinDurationOfVisits_D = JNIEnv.GetMethodID (class_ref, "setMinDurationOfVisits", "(D)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMinDurationOfVisits_D, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinDurationOfVisits", "(D)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNumberOfNewVisitors;
#pragma warning disable 0169
		static Delegate GetGetNumberOfNewVisitorsHandler ()
		{
			if (cb_getNumberOfNewVisitors == null)
				cb_getNumberOfNewVisitors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumberOfNewVisitors);
			return cb_getNumberOfNewVisitors;
		}

		static int n_GetNumberOfNewVisitors (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCPeriodicInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPeriodicInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumberOfNewVisitors;
		}
#pragma warning restore 0169

		static Delegate cb_setNumberOfNewVisitors_I;
#pragma warning disable 0169
		static Delegate GetSetNumberOfNewVisitors_IHandler ()
		{
			if (cb_setNumberOfNewVisitors_I == null)
				cb_setNumberOfNewVisitors_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNumberOfNewVisitors_I);
			return cb_setNumberOfNewVisitors_I;
		}

		static void n_SetNumberOfNewVisitors_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Bluecats.Sdk.BCPeriodicInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPeriodicInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NumberOfNewVisitors = value;
		}
#pragma warning restore 0169

		static IntPtr id_getNumberOfNewVisitors;
		static IntPtr id_setNumberOfNewVisitors_I;
		public virtual unsafe int NumberOfNewVisitors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPeriodicInsights']/method[@name='getNumberOfNewVisitors' and count(parameter)=0]"
			[Register ("getNumberOfNewVisitors", "()I", "GetGetNumberOfNewVisitorsHandler")]
			get {
				if (id_getNumberOfNewVisitors == IntPtr.Zero)
					id_getNumberOfNewVisitors = JNIEnv.GetMethodID (class_ref, "getNumberOfNewVisitors", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumberOfNewVisitors);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumberOfNewVisitors", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPeriodicInsights']/method[@name='setNumberOfNewVisitors' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNumberOfNewVisitors", "(I)V", "GetSetNumberOfNewVisitors_IHandler")]
			set {
				if (id_setNumberOfNewVisitors_I == IntPtr.Zero)
					id_setNumberOfNewVisitors_I = JNIEnv.GetMethodID (class_ref, "setNumberOfNewVisitors", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNumberOfNewVisitors_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNumberOfNewVisitors", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNumberOfReturningVisitors;
#pragma warning disable 0169
		static Delegate GetGetNumberOfReturningVisitorsHandler ()
		{
			if (cb_getNumberOfReturningVisitors == null)
				cb_getNumberOfReturningVisitors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumberOfReturningVisitors);
			return cb_getNumberOfReturningVisitors;
		}

		static int n_GetNumberOfReturningVisitors (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCPeriodicInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPeriodicInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumberOfReturningVisitors;
		}
#pragma warning restore 0169

		static Delegate cb_setNumberOfReturningVisitors_I;
#pragma warning disable 0169
		static Delegate GetSetNumberOfReturningVisitors_IHandler ()
		{
			if (cb_setNumberOfReturningVisitors_I == null)
				cb_setNumberOfReturningVisitors_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNumberOfReturningVisitors_I);
			return cb_setNumberOfReturningVisitors_I;
		}

		static void n_SetNumberOfReturningVisitors_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Bluecats.Sdk.BCPeriodicInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPeriodicInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NumberOfReturningVisitors = value;
		}
#pragma warning restore 0169

		static IntPtr id_getNumberOfReturningVisitors;
		static IntPtr id_setNumberOfReturningVisitors_I;
		public virtual unsafe int NumberOfReturningVisitors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPeriodicInsights']/method[@name='getNumberOfReturningVisitors' and count(parameter)=0]"
			[Register ("getNumberOfReturningVisitors", "()I", "GetGetNumberOfReturningVisitorsHandler")]
			get {
				if (id_getNumberOfReturningVisitors == IntPtr.Zero)
					id_getNumberOfReturningVisitors = JNIEnv.GetMethodID (class_ref, "getNumberOfReturningVisitors", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumberOfReturningVisitors);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumberOfReturningVisitors", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPeriodicInsights']/method[@name='setNumberOfReturningVisitors' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNumberOfReturningVisitors", "(I)V", "GetSetNumberOfReturningVisitors_IHandler")]
			set {
				if (id_setNumberOfReturningVisitors_I == IntPtr.Zero)
					id_setNumberOfReturningVisitors_I = JNIEnv.GetMethodID (class_ref, "setNumberOfReturningVisitors", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNumberOfReturningVisitors_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNumberOfReturningVisitors", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNumberOfVisitors;
#pragma warning disable 0169
		static Delegate GetGetNumberOfVisitorsHandler ()
		{
			if (cb_getNumberOfVisitors == null)
				cb_getNumberOfVisitors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumberOfVisitors);
			return cb_getNumberOfVisitors;
		}

		static int n_GetNumberOfVisitors (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCPeriodicInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPeriodicInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumberOfVisitors;
		}
#pragma warning restore 0169

		static Delegate cb_setNumberOfVisitors_I;
#pragma warning disable 0169
		static Delegate GetSetNumberOfVisitors_IHandler ()
		{
			if (cb_setNumberOfVisitors_I == null)
				cb_setNumberOfVisitors_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNumberOfVisitors_I);
			return cb_setNumberOfVisitors_I;
		}

		static void n_SetNumberOfVisitors_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Bluecats.Sdk.BCPeriodicInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPeriodicInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NumberOfVisitors = value;
		}
#pragma warning restore 0169

		static IntPtr id_getNumberOfVisitors;
		static IntPtr id_setNumberOfVisitors_I;
		public virtual unsafe int NumberOfVisitors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPeriodicInsights']/method[@name='getNumberOfVisitors' and count(parameter)=0]"
			[Register ("getNumberOfVisitors", "()I", "GetGetNumberOfVisitorsHandler")]
			get {
				if (id_getNumberOfVisitors == IntPtr.Zero)
					id_getNumberOfVisitors = JNIEnv.GetMethodID (class_ref, "getNumberOfVisitors", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumberOfVisitors);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumberOfVisitors", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPeriodicInsights']/method[@name='setNumberOfVisitors' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNumberOfVisitors", "(I)V", "GetSetNumberOfVisitors_IHandler")]
			set {
				if (id_setNumberOfVisitors_I == IntPtr.Zero)
					id_setNumberOfVisitors_I = JNIEnv.GetMethodID (class_ref, "setNumberOfVisitors", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNumberOfVisitors_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNumberOfVisitors", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNumberOfVisits;
#pragma warning disable 0169
		static Delegate GetGetNumberOfVisitsHandler ()
		{
			if (cb_getNumberOfVisits == null)
				cb_getNumberOfVisits = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumberOfVisits);
			return cb_getNumberOfVisits;
		}

		static int n_GetNumberOfVisits (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCPeriodicInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPeriodicInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumberOfVisits;
		}
#pragma warning restore 0169

		static Delegate cb_setNumberOfVisits_I;
#pragma warning disable 0169
		static Delegate GetSetNumberOfVisits_IHandler ()
		{
			if (cb_setNumberOfVisits_I == null)
				cb_setNumberOfVisits_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNumberOfVisits_I);
			return cb_setNumberOfVisits_I;
		}

		static void n_SetNumberOfVisits_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Bluecats.Sdk.BCPeriodicInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPeriodicInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NumberOfVisits = value;
		}
#pragma warning restore 0169

		static IntPtr id_getNumberOfVisits;
		static IntPtr id_setNumberOfVisits_I;
		public virtual unsafe int NumberOfVisits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPeriodicInsights']/method[@name='getNumberOfVisits' and count(parameter)=0]"
			[Register ("getNumberOfVisits", "()I", "GetGetNumberOfVisitsHandler")]
			get {
				if (id_getNumberOfVisits == IntPtr.Zero)
					id_getNumberOfVisits = JNIEnv.GetMethodID (class_ref, "getNumberOfVisits", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumberOfVisits);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumberOfVisits", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPeriodicInsights']/method[@name='setNumberOfVisits' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNumberOfVisits", "(I)V", "GetSetNumberOfVisits_IHandler")]
			set {
				if (id_setNumberOfVisits_I == IntPtr.Zero)
					id_setNumberOfVisits_I = JNIEnv.GetMethodID (class_ref, "setNumberOfVisits", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNumberOfVisits_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNumberOfVisits", "(I)V"), __args);
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
			global::Com.Bluecats.Sdk.BCPeriodicInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPeriodicInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPeriodicInsights']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Bluecats.Sdk.BCPeriodicInsights __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPeriodicInsights> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPeriodicInsights']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
