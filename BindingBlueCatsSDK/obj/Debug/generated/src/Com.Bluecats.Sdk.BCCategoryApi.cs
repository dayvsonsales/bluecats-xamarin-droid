using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategoryApi']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCCategoryApi", DoNotGenerateAcw=true)]
	public partial class BCCategoryApi : global::Java.Lang.Object {


		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategoryApi']/field[@name='id']"
		[Register ("id")]
		protected string Id {
			get {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, id_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, id_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCCategoryApi", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCCategoryApi); }
		}

		protected BCCategoryApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategoryApi']/constructor[@name='BCCategoryApi' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCCategoryApi ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCCategoryApi)) {
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

		static Delegate cb_getCategoryID;
#pragma warning disable 0169
		static Delegate GetGetCategoryIDHandler ()
		{
			if (cb_getCategoryID == null)
				cb_getCategoryID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCategoryID);
			return cb_getCategoryID;
		}

		static IntPtr n_GetCategoryID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCCategoryApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategoryApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CategoryID);
		}
#pragma warning restore 0169

		static Delegate cb_setCategoryID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCategoryID_Ljava_lang_String_Handler ()
		{
			if (cb_setCategoryID_Ljava_lang_String_ == null)
				cb_setCategoryID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCategoryID_Ljava_lang_String_);
			return cb_setCategoryID_Ljava_lang_String_;
		}

		static void n_SetCategoryID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCCategoryApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategoryApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.CategoryID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCategoryID;
		static IntPtr id_setCategoryID_Ljava_lang_String_;
		public virtual unsafe string CategoryID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategoryApi']/method[@name='getCategoryID' and count(parameter)=0]"
			[Register ("getCategoryID", "()Ljava/lang/String;", "GetGetCategoryIDHandler")]
			get {
				if (id_getCategoryID == IntPtr.Zero)
					id_getCategoryID = JNIEnv.GetMethodID (class_ref, "getCategoryID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCategoryID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCategoryID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategoryApi']/method[@name='setCategoryID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCategoryID", "(Ljava/lang/String;)V", "GetSetCategoryID_Ljava_lang_String_Handler")]
			set {
				if (id_setCategoryID_Ljava_lang_String_ == IntPtr.Zero)
					id_setCategoryID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCategoryID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCategoryID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCategoryID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTeamID;
#pragma warning disable 0169
		static Delegate GetGetTeamIDHandler ()
		{
			if (cb_getTeamID == null)
				cb_getTeamID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTeamID);
			return cb_getTeamID;
		}

		static IntPtr n_GetTeamID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCCategoryApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategoryApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TeamID);
		}
#pragma warning restore 0169

		static Delegate cb_setTeamID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTeamID_Ljava_lang_String_Handler ()
		{
			if (cb_setTeamID_Ljava_lang_String_ == null)
				cb_setTeamID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTeamID_Ljava_lang_String_);
			return cb_setTeamID_Ljava_lang_String_;
		}

		static void n_SetTeamID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCCategoryApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategoryApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.TeamID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getTeamID;
		static IntPtr id_setTeamID_Ljava_lang_String_;
		public virtual unsafe string TeamID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategoryApi']/method[@name='getTeamID' and count(parameter)=0]"
			[Register ("getTeamID", "()Ljava/lang/String;", "GetGetTeamIDHandler")]
			get {
				if (id_getTeamID == IntPtr.Zero)
					id_getTeamID = JNIEnv.GetMethodID (class_ref, "getTeamID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTeamID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTeamID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategoryApi']/method[@name='setTeamID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTeamID", "(Ljava/lang/String;)V", "GetSetTeamID_Ljava_lang_String_Handler")]
			set {
				if (id_setTeamID_Ljava_lang_String_ == IntPtr.Zero)
					id_setTeamID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTeamID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTeamID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTeamID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCategoryInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCCategoryCallback_;
#pragma warning disable 0169
		static Delegate GetGetCategoryInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCCategoryCallback_Handler ()
		{
			if (cb_getCategoryInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCCategoryCallback_ == null)
				cb_getCategoryInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCCategoryCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr>) n_GetCategoryInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCCategoryCallback_);
			return cb_getCategoryInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCCategoryCallback_;
		}

		static void n_GetCategoryInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCCategoryCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_endDate, IntPtr native_period, long duration, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCCategoryApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategoryApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date endDate = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_endDate, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod period = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod> (native_period, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCCategoryCallback @callback = (global::Com.Bluecats.Sdk.IBCCategoryCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCCategoryCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetCategoryInsightsForEndDate (endDate, period, duration, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_getCategoryInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCCategoryCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategoryApi']/method[@name='getCategoryInsightsForEndDate' and count(parameter)=4 and parameter[1][@type='java.util.Date'] and parameter[2][@type='com.bluecats.sdk.BCInsights.BCInsightsPeriod'] and parameter[3][@type='long'] and parameter[4][@type='com.bluecats.sdk.BCCategoryCallback']]"
		[Register ("getCategoryInsightsForEndDate", "(Ljava/util/Date;Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;JLcom/bluecats/sdk/BCCategoryCallback;)V", "GetGetCategoryInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCCategoryCallback_Handler")]
		public virtual unsafe void GetCategoryInsightsForEndDate (global::Java.Util.Date endDate, global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod period, long duration, global::Com.Bluecats.Sdk.IBCCategoryCallback @callback)
		{
			if (id_getCategoryInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCCategoryCallback_ == IntPtr.Zero)
				id_getCategoryInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCCategoryCallback_ = JNIEnv.GetMethodID (class_ref, "getCategoryInsightsForEndDate", "(Ljava/util/Date;Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;JLcom/bluecats/sdk/BCCategoryCallback;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (endDate);
				__args [1] = new JValue (period);
				__args [2] = new JValue (duration);
				__args [3] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getCategoryInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCCategoryCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCategoryInsightsForEndDate", "(Ljava/util/Date;Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;JLcom/bluecats/sdk/BCCategoryCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCCategoryCallback_;
#pragma warning disable 0169
		static Delegate GetUpdateCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCCategoryCallback_Handler ()
		{
			if (cb_updateCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCCategoryCallback_ == null)
				cb_updateCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCCategoryCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCCategoryCallback_);
			return cb_updateCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCCategoryCallback_;
		}

		static void n_UpdateCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCCategoryCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_category, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCCategoryApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategoryApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCCategory category = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategory> (native_category, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCCategoryCallback @callback = (global::Com.Bluecats.Sdk.IBCCategoryCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCCategoryCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.UpdateCategory (category, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_updateCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCCategoryCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCCategoryApi']/method[@name='updateCategory' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCCategory'] and parameter[2][@type='com.bluecats.sdk.BCCategoryCallback']]"
		[Register ("updateCategory", "(Lcom/bluecats/sdk/BCCategory;Lcom/bluecats/sdk/BCCategoryCallback;)V", "GetUpdateCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCCategoryCallback_Handler")]
		public virtual unsafe void UpdateCategory (global::Com.Bluecats.Sdk.BCCategory category, global::Com.Bluecats.Sdk.IBCCategoryCallback @callback)
		{
			if (id_updateCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCCategoryCallback_ == IntPtr.Zero)
				id_updateCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCCategoryCallback_ = JNIEnv.GetMethodID (class_ref, "updateCategory", "(Lcom/bluecats/sdk/BCCategory;Lcom/bluecats/sdk/BCCategoryCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (category);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCCategoryCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateCategory", "(Lcom/bluecats/sdk/BCCategory;Lcom/bluecats/sdk/BCCategoryCallback;)V"), __args);
			} finally {
			}
		}

	}
}
