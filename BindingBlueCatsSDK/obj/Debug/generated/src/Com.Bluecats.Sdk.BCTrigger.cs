using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTrigger']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCTrigger", DoNotGenerateAcw=true)]
	public partial class BCTrigger : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCTrigger", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCTrigger); }
		}

		protected BCTrigger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTrigger']/constructor[@name='BCTrigger' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCTrigger ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCTrigger)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTrigger']/constructor[@name='BCTrigger' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;com.bluecats.sdk.IBCEventFilter&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/List;)V", "")]
		public unsafe BCTrigger (string identifier, global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCEventFilter> filters)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_identifier = JNIEnv.NewString (identifier);
			IntPtr native_filters = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCEventFilter>.ToLocalJniHandle (filters);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_identifier);
				__args [1] = new JValue (native_filters);
				if (((object) this).GetType () != typeof (BCTrigger)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_identifier);
				JNIEnv.DeleteLocalRef (native_filters);
			}
		}

		static Delegate cb_getEventIdentifier;
#pragma warning disable 0169
		static Delegate GetGetEventIdentifierHandler ()
		{
			if (cb_getEventIdentifier == null)
				cb_getEventIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventIdentifier);
			return cb_getEventIdentifier;
		}

		static IntPtr n_GetEventIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTrigger __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTrigger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EventIdentifier);
		}
#pragma warning restore 0169

		static Delegate cb_setEventIdentifier_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEventIdentifier_Ljava_lang_String_Handler ()
		{
			if (cb_setEventIdentifier_Ljava_lang_String_ == null)
				cb_setEventIdentifier_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEventIdentifier_Ljava_lang_String_);
			return cb_setEventIdentifier_Ljava_lang_String_;
		}

		static void n_SetEventIdentifier_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCTrigger __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTrigger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.EventIdentifier = value;
		}
#pragma warning restore 0169

		static IntPtr id_getEventIdentifier;
		static IntPtr id_setEventIdentifier_Ljava_lang_String_;
		public virtual unsafe string EventIdentifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTrigger']/method[@name='getEventIdentifier' and count(parameter)=0]"
			[Register ("getEventIdentifier", "()Ljava/lang/String;", "GetGetEventIdentifierHandler")]
			get {
				if (id_getEventIdentifier == IntPtr.Zero)
					id_getEventIdentifier = JNIEnv.GetMethodID (class_ref, "getEventIdentifier", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEventIdentifier), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEventIdentifier", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTrigger']/method[@name='setEventIdentifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEventIdentifier", "(Ljava/lang/String;)V", "GetSetEventIdentifier_Ljava_lang_String_Handler")]
			set {
				if (id_setEventIdentifier_Ljava_lang_String_ == IntPtr.Zero)
					id_setEventIdentifier_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEventIdentifier", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEventIdentifier_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEventIdentifier", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEventName;
#pragma warning disable 0169
		static Delegate GetGetEventNameHandler ()
		{
			if (cb_getEventName == null)
				cb_getEventName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventName);
			return cb_getEventName;
		}

		static IntPtr n_GetEventName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTrigger __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTrigger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EventName);
		}
#pragma warning restore 0169

		static Delegate cb_setEventName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEventName_Ljava_lang_String_Handler ()
		{
			if (cb_setEventName_Ljava_lang_String_ == null)
				cb_setEventName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEventName_Ljava_lang_String_);
			return cb_setEventName_Ljava_lang_String_;
		}

		static void n_SetEventName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCTrigger __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTrigger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.EventName = value;
		}
#pragma warning restore 0169

		static IntPtr id_getEventName;
		static IntPtr id_setEventName_Ljava_lang_String_;
		public virtual unsafe string EventName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTrigger']/method[@name='getEventName' and count(parameter)=0]"
			[Register ("getEventName", "()Ljava/lang/String;", "GetGetEventNameHandler")]
			get {
				if (id_getEventName == IntPtr.Zero)
					id_getEventName = JNIEnv.GetMethodID (class_ref, "getEventName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEventName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEventName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTrigger']/method[@name='setEventName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEventName", "(Ljava/lang/String;)V", "GetSetEventName_Ljava_lang_String_Handler")]
			set {
				if (id_setEventName_Ljava_lang_String_ == IntPtr.Zero)
					id_setEventName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEventName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEventName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEventName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getExpiresAt;
#pragma warning disable 0169
		static Delegate GetGetExpiresAtHandler ()
		{
			if (cb_getExpiresAt == null)
				cb_getExpiresAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpiresAt);
			return cb_getExpiresAt;
		}

		static IntPtr n_GetExpiresAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTrigger __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTrigger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExpiresAt);
		}
#pragma warning restore 0169

		static Delegate cb_setExpiresAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetExpiresAt_Ljava_util_Date_Handler ()
		{
			if (cb_setExpiresAt_Ljava_util_Date_ == null)
				cb_setExpiresAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExpiresAt_Ljava_util_Date_);
			return cb_setExpiresAt_Ljava_util_Date_;
		}

		static void n_SetExpiresAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCTrigger __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTrigger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.ExpiresAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getExpiresAt;
		static IntPtr id_setExpiresAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date ExpiresAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTrigger']/method[@name='getExpiresAt' and count(parameter)=0]"
			[Register ("getExpiresAt", "()Ljava/util/Date;", "GetGetExpiresAtHandler")]
			get {
				if (id_getExpiresAt == IntPtr.Zero)
					id_getExpiresAt = JNIEnv.GetMethodID (class_ref, "getExpiresAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExpiresAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExpiresAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTrigger']/method[@name='setExpiresAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setExpiresAt", "(Ljava/util/Date;)V", "GetSetExpiresAt_Ljava_util_Date_Handler")]
			set {
				if (id_setExpiresAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setExpiresAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setExpiresAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExpiresAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExpiresAt", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFilters;
#pragma warning disable 0169
		static Delegate GetGetFiltersHandler ()
		{
			if (cb_getFilters == null)
				cb_getFilters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFilters);
			return cb_getFilters;
		}

		static IntPtr n_GetFilters (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTrigger __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTrigger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCEventFilter>.ToLocalJniHandle (__this.Filters);
		}
#pragma warning restore 0169

		static Delegate cb_setFilters_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetFilters_Ljava_util_List_Handler ()
		{
			if (cb_setFilters_Ljava_util_List_ == null)
				cb_setFilters_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFilters_Ljava_util_List_);
			return cb_setFilters_Ljava_util_List_;
		}

		static void n_SetFilters_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCTrigger __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTrigger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCEventFilter>.FromJniHandle (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Filters = value;
		}
#pragma warning restore 0169

		static IntPtr id_getFilters;
		static IntPtr id_setFilters_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCEventFilter> Filters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTrigger']/method[@name='getFilters' and count(parameter)=0]"
			[Register ("getFilters", "()Ljava/util/List;", "GetGetFiltersHandler")]
			get {
				if (id_getFilters == IntPtr.Zero)
					id_getFilters = JNIEnv.GetMethodID (class_ref, "getFilters", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCEventFilter>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFilters), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCEventFilter>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFilters", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTrigger']/method[@name='setFilters' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.IBCEventFilter&gt;']]"
			[Register ("setFilters", "(Ljava/util/List;)V", "GetSetFilters_Ljava_util_List_Handler")]
			set {
				if (id_setFilters_Ljava_util_List_ == IntPtr.Zero)
					id_setFilters_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setFilters", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCEventFilter>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFilters_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFilters", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRepeatCount;
#pragma warning disable 0169
		static Delegate GetGetRepeatCountHandler ()
		{
			if (cb_getRepeatCount == null)
				cb_getRepeatCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRepeatCount);
			return cb_getRepeatCount;
		}

		static int n_GetRepeatCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTrigger __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTrigger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RepeatCount;
		}
#pragma warning restore 0169

		static Delegate cb_setRepeatCount_I;
#pragma warning disable 0169
		static Delegate GetSetRepeatCount_IHandler ()
		{
			if (cb_setRepeatCount_I == null)
				cb_setRepeatCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRepeatCount_I);
			return cb_setRepeatCount_I;
		}

		static void n_SetRepeatCount_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Bluecats.Sdk.BCTrigger __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTrigger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RepeatCount = value;
		}
#pragma warning restore 0169

		static IntPtr id_getRepeatCount;
		static IntPtr id_setRepeatCount_I;
		public virtual unsafe int RepeatCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTrigger']/method[@name='getRepeatCount' and count(parameter)=0]"
			[Register ("getRepeatCount", "()I", "GetGetRepeatCountHandler")]
			get {
				if (id_getRepeatCount == IntPtr.Zero)
					id_getRepeatCount = JNIEnv.GetMethodID (class_ref, "getRepeatCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRepeatCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRepeatCount", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTrigger']/method[@name='setRepeatCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRepeatCount", "(I)V", "GetSetRepeatCount_IHandler")]
			set {
				if (id_setRepeatCount_I == IntPtr.Zero)
					id_setRepeatCount_I = JNIEnv.GetMethodID (class_ref, "setRepeatCount", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRepeatCount_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRepeatCount", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getValidFrom;
#pragma warning disable 0169
		static Delegate GetGetValidFromHandler ()
		{
			if (cb_getValidFrom == null)
				cb_getValidFrom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValidFrom);
			return cb_getValidFrom;
		}

		static IntPtr n_GetValidFrom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTrigger __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTrigger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ValidFrom);
		}
#pragma warning restore 0169

		static Delegate cb_setValidFrom_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetValidFrom_Ljava_util_Date_Handler ()
		{
			if (cb_setValidFrom_Ljava_util_Date_ == null)
				cb_setValidFrom_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValidFrom_Ljava_util_Date_);
			return cb_setValidFrom_Ljava_util_Date_;
		}

		static void n_SetValidFrom_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCTrigger __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTrigger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.ValidFrom = value;
		}
#pragma warning restore 0169

		static IntPtr id_getValidFrom;
		static IntPtr id_setValidFrom_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date ValidFrom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTrigger']/method[@name='getValidFrom' and count(parameter)=0]"
			[Register ("getValidFrom", "()Ljava/util/Date;", "GetGetValidFromHandler")]
			get {
				if (id_getValidFrom == IntPtr.Zero)
					id_getValidFrom = JNIEnv.GetMethodID (class_ref, "getValidFrom", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValidFrom), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValidFrom", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTrigger']/method[@name='setValidFrom' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setValidFrom", "(Ljava/util/Date;)V", "GetSetValidFrom_Ljava_util_Date_Handler")]
			set {
				if (id_setValidFrom_Ljava_util_Date_ == IntPtr.Zero)
					id_setValidFrom_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setValidFrom", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValidFrom_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setValidFrom", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_addFilter_Lcom_bluecats_sdk_BCEventFilter_;
#pragma warning disable 0169
		static Delegate GetAddFilter_Lcom_bluecats_sdk_BCEventFilter_Handler ()
		{
			if (cb_addFilter_Lcom_bluecats_sdk_BCEventFilter_ == null)
				cb_addFilter_Lcom_bluecats_sdk_BCEventFilter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddFilter_Lcom_bluecats_sdk_BCEventFilter_);
			return cb_addFilter_Lcom_bluecats_sdk_BCEventFilter_;
		}

		static void n_AddFilter_Lcom_bluecats_sdk_BCEventFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filter)
		{
			global::Com.Bluecats.Sdk.BCTrigger __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTrigger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCEventFilter filter = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCEventFilter> (native_filter, JniHandleOwnership.DoNotTransfer);
			__this.AddFilter (filter);
		}
#pragma warning restore 0169

		static IntPtr id_addFilter_Lcom_bluecats_sdk_BCEventFilter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTrigger']/method[@name='addFilter' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCEventFilter']]"
		[Register ("addFilter", "(Lcom/bluecats/sdk/BCEventFilter;)V", "GetAddFilter_Lcom_bluecats_sdk_BCEventFilter_Handler")]
		public virtual unsafe void AddFilter (global::Com.Bluecats.Sdk.BCEventFilter filter)
		{
			if (id_addFilter_Lcom_bluecats_sdk_BCEventFilter_ == IntPtr.Zero)
				id_addFilter_Lcom_bluecats_sdk_BCEventFilter_ = JNIEnv.GetMethodID (class_ref, "addFilter", "(Lcom/bluecats/sdk/BCEventFilter;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (filter);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFilter_Lcom_bluecats_sdk_BCEventFilter_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFilter", "(Lcom/bluecats/sdk/BCEventFilter;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_clearFilters;
#pragma warning disable 0169
		static Delegate GetClearFiltersHandler ()
		{
			if (cb_clearFilters == null)
				cb_clearFilters = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearFilters);
			return cb_clearFilters;
		}

		static void n_ClearFilters (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTrigger __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTrigger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearFilters ();
		}
#pragma warning restore 0169

		static IntPtr id_clearFilters;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTrigger']/method[@name='clearFilters' and count(parameter)=0]"
		[Register ("clearFilters", "()V", "GetClearFiltersHandler")]
		public virtual unsafe void ClearFilters ()
		{
			if (id_clearFilters == IntPtr.Zero)
				id_clearFilters = JNIEnv.GetMethodID (class_ref, "clearFilters", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearFilters);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearFilters", "()V"));
			} finally {
			}
		}

	}
}
