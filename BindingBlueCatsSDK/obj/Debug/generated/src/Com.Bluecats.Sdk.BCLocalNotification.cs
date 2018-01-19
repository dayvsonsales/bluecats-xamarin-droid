using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCLocalNotification", DoNotGenerateAcw=true)]
	public partial class BCLocalNotification : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCLocalNotification", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCLocalNotification); }
		}

		protected BCLocalNotification (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']/constructor[@name='BCLocalNotification' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe BCLocalNotification (int id)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (id);
				if (((object) this).GetType () != typeof (BCLocalNotification)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_getAlertContentText;
#pragma warning disable 0169
		static Delegate GetGetAlertContentTextHandler ()
		{
			if (cb_getAlertContentText == null)
				cb_getAlertContentText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAlertContentText);
			return cb_getAlertContentText;
		}

		static IntPtr n_GetAlertContentText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCLocalNotification __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AlertContentText);
		}
#pragma warning restore 0169

		static Delegate cb_setAlertContentText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAlertContentText_Ljava_lang_String_Handler ()
		{
			if (cb_setAlertContentText_Ljava_lang_String_ == null)
				cb_setAlertContentText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAlertContentText_Ljava_lang_String_);
			return cb_setAlertContentText_Ljava_lang_String_;
		}

		static void n_SetAlertContentText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCLocalNotification __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AlertContentText = value;
		}
#pragma warning restore 0169

		static IntPtr id_getAlertContentText;
		static IntPtr id_setAlertContentText_Ljava_lang_String_;
		public virtual unsafe string AlertContentText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']/method[@name='getAlertContentText' and count(parameter)=0]"
			[Register ("getAlertContentText", "()Ljava/lang/String;", "GetGetAlertContentTextHandler")]
			get {
				if (id_getAlertContentText == IntPtr.Zero)
					id_getAlertContentText = JNIEnv.GetMethodID (class_ref, "getAlertContentText", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAlertContentText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlertContentText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']/method[@name='setAlertContentText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAlertContentText", "(Ljava/lang/String;)V", "GetSetAlertContentText_Ljava_lang_String_Handler")]
			set {
				if (id_setAlertContentText_Ljava_lang_String_ == IntPtr.Zero)
					id_setAlertContentText_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAlertContentText", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlertContentText_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlertContentText", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAlertContentTitle;
#pragma warning disable 0169
		static Delegate GetGetAlertContentTitleHandler ()
		{
			if (cb_getAlertContentTitle == null)
				cb_getAlertContentTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAlertContentTitle);
			return cb_getAlertContentTitle;
		}

		static IntPtr n_GetAlertContentTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCLocalNotification __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AlertContentTitle);
		}
#pragma warning restore 0169

		static Delegate cb_setAlertContentTitle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAlertContentTitle_Ljava_lang_String_Handler ()
		{
			if (cb_setAlertContentTitle_Ljava_lang_String_ == null)
				cb_setAlertContentTitle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAlertContentTitle_Ljava_lang_String_);
			return cb_setAlertContentTitle_Ljava_lang_String_;
		}

		static void n_SetAlertContentTitle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCLocalNotification __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AlertContentTitle = value;
		}
#pragma warning restore 0169

		static IntPtr id_getAlertContentTitle;
		static IntPtr id_setAlertContentTitle_Ljava_lang_String_;
		public virtual unsafe string AlertContentTitle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']/method[@name='getAlertContentTitle' and count(parameter)=0]"
			[Register ("getAlertContentTitle", "()Ljava/lang/String;", "GetGetAlertContentTitleHandler")]
			get {
				if (id_getAlertContentTitle == IntPtr.Zero)
					id_getAlertContentTitle = JNIEnv.GetMethodID (class_ref, "getAlertContentTitle", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAlertContentTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlertContentTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']/method[@name='setAlertContentTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAlertContentTitle", "(Ljava/lang/String;)V", "GetSetAlertContentTitle_Ljava_lang_String_Handler")]
			set {
				if (id_setAlertContentTitle_Ljava_lang_String_ == IntPtr.Zero)
					id_setAlertContentTitle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAlertContentTitle", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlertContentTitle_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlertContentTitle", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAlertSmallIcon;
#pragma warning disable 0169
		static Delegate GetGetAlertSmallIconHandler ()
		{
			if (cb_getAlertSmallIcon == null)
				cb_getAlertSmallIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAlertSmallIcon);
			return cb_getAlertSmallIcon;
		}

		static IntPtr n_GetAlertSmallIcon (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCLocalNotification __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AlertSmallIcon);
		}
#pragma warning restore 0169

		static Delegate cb_setAlertSmallIcon_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetAlertSmallIcon_Ljava_lang_Integer_Handler ()
		{
			if (cb_setAlertSmallIcon_Ljava_lang_Integer_ == null)
				cb_setAlertSmallIcon_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAlertSmallIcon_Ljava_lang_Integer_);
			return cb_setAlertSmallIcon_Ljava_lang_Integer_;
		}

		static void n_SetAlertSmallIcon_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCLocalNotification __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AlertSmallIcon = value;
		}
#pragma warning restore 0169

		static IntPtr id_getAlertSmallIcon;
		static IntPtr id_setAlertSmallIcon_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer AlertSmallIcon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']/method[@name='getAlertSmallIcon' and count(parameter)=0]"
			[Register ("getAlertSmallIcon", "()Ljava/lang/Integer;", "GetGetAlertSmallIconHandler")]
			get {
				if (id_getAlertSmallIcon == IntPtr.Zero)
					id_getAlertSmallIcon = JNIEnv.GetMethodID (class_ref, "getAlertSmallIcon", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAlertSmallIcon), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlertSmallIcon", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']/method[@name='setAlertSmallIcon' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setAlertSmallIcon", "(Ljava/lang/Integer;)V", "GetSetAlertSmallIcon_Ljava_lang_Integer_Handler")]
			set {
				if (id_setAlertSmallIcon_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setAlertSmallIcon_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setAlertSmallIcon", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlertSmallIcon_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlertSmallIcon", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAlertSound;
#pragma warning disable 0169
		static Delegate GetGetAlertSoundHandler ()
		{
			if (cb_getAlertSound == null)
				cb_getAlertSound = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAlertSound);
			return cb_getAlertSound;
		}

		static IntPtr n_GetAlertSound (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCLocalNotification __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AlertSound);
		}
#pragma warning restore 0169

		static Delegate cb_setAlertSound_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetSetAlertSound_Landroid_net_Uri_Handler ()
		{
			if (cb_setAlertSound_Landroid_net_Uri_ == null)
				cb_setAlertSound_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAlertSound_Landroid_net_Uri_);
			return cb_setAlertSound_Landroid_net_Uri_;
		}

		static void n_SetAlertSound_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCLocalNotification __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri value = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.AlertSound = value;
		}
#pragma warning restore 0169

		static IntPtr id_getAlertSound;
		static IntPtr id_setAlertSound_Landroid_net_Uri_;
		public virtual unsafe global::Android.Net.Uri AlertSound {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']/method[@name='getAlertSound' and count(parameter)=0]"
			[Register ("getAlertSound", "()Landroid/net/Uri;", "GetGetAlertSoundHandler")]
			get {
				if (id_getAlertSound == IntPtr.Zero)
					id_getAlertSound = JNIEnv.GetMethodID (class_ref, "getAlertSound", "()Landroid/net/Uri;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAlertSound), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlertSound", "()Landroid/net/Uri;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']/method[@name='setAlertSound' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
			[Register ("setAlertSound", "(Landroid/net/Uri;)V", "GetSetAlertSound_Landroid_net_Uri_Handler")]
			set {
				if (id_setAlertSound_Landroid_net_Uri_ == IntPtr.Zero)
					id_setAlertSound_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "setAlertSound", "(Landroid/net/Uri;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlertSound_Landroid_net_Uri_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlertSound", "(Landroid/net/Uri;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getContentIntent;
#pragma warning disable 0169
		static Delegate GetGetContentIntentHandler ()
		{
			if (cb_getContentIntent == null)
				cb_getContentIntent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentIntent);
			return cb_getContentIntent;
		}

		static IntPtr n_GetContentIntent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCLocalNotification __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentIntent);
		}
#pragma warning restore 0169

		static Delegate cb_setContentIntent_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetSetContentIntent_Landroid_content_Intent_Handler ()
		{
			if (cb_setContentIntent_Landroid_content_Intent_ == null)
				cb_setContentIntent_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentIntent_Landroid_content_Intent_);
			return cb_setContentIntent_Landroid_content_Intent_;
		}

		static void n_SetContentIntent_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCLocalNotification __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent value = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.ContentIntent = value;
		}
#pragma warning restore 0169

		static IntPtr id_getContentIntent;
		static IntPtr id_setContentIntent_Landroid_content_Intent_;
		public virtual unsafe global::Android.Content.Intent ContentIntent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']/method[@name='getContentIntent' and count(parameter)=0]"
			[Register ("getContentIntent", "()Landroid/content/Intent;", "GetGetContentIntentHandler")]
			get {
				if (id_getContentIntent == IntPtr.Zero)
					id_getContentIntent = JNIEnv.GetMethodID (class_ref, "getContentIntent", "()Landroid/content/Intent;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentIntent), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentIntent", "()Landroid/content/Intent;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']/method[@name='setContentIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
			[Register ("setContentIntent", "(Landroid/content/Intent;)V", "GetSetContentIntent_Landroid_content_Intent_Handler")]
			set {
				if (id_setContentIntent_Landroid_content_Intent_ == IntPtr.Zero)
					id_setContentIntent_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "setContentIntent", "(Landroid/content/Intent;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContentIntent_Landroid_content_Intent_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentIntent", "(Landroid/content/Intent;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFireAfter;
#pragma warning disable 0169
		static Delegate GetGetFireAfterHandler ()
		{
			if (cb_getFireAfter == null)
				cb_getFireAfter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFireAfter);
			return cb_getFireAfter;
		}

		static IntPtr n_GetFireAfter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCLocalNotification __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FireAfter);
		}
#pragma warning restore 0169

		static Delegate cb_setFireAfter_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetFireAfter_Ljava_util_Date_Handler ()
		{
			if (cb_setFireAfter_Ljava_util_Date_ == null)
				cb_setFireAfter_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFireAfter_Ljava_util_Date_);
			return cb_setFireAfter_Ljava_util_Date_;
		}

		static void n_SetFireAfter_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCLocalNotification __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.FireAfter = value;
		}
#pragma warning restore 0169

		static IntPtr id_getFireAfter;
		static IntPtr id_setFireAfter_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date FireAfter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']/method[@name='getFireAfter' and count(parameter)=0]"
			[Register ("getFireAfter", "()Ljava/util/Date;", "GetGetFireAfterHandler")]
			get {
				if (id_getFireAfter == IntPtr.Zero)
					id_getFireAfter = JNIEnv.GetMethodID (class_ref, "getFireAfter", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFireAfter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFireAfter", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']/method[@name='setFireAfter' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setFireAfter", "(Ljava/util/Date;)V", "GetSetFireAfter_Ljava_util_Date_Handler")]
			set {
				if (id_setFireAfter_Ljava_util_Date_ == IntPtr.Zero)
					id_setFireAfter_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setFireAfter", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFireAfter_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFireAfter", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFireInCategories;
#pragma warning disable 0169
		static Delegate GetGetFireInCategoriesHandler ()
		{
			if (cb_getFireInCategories == null)
				cb_getFireInCategories = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFireInCategories);
			return cb_getFireInCategories;
		}

		static IntPtr n_GetFireInCategories (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCLocalNotification __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCCategory>.ToLocalJniHandle (__this.FireInCategories);
		}
#pragma warning restore 0169

		static Delegate cb_setFireInCategories_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetFireInCategories_Ljava_util_List_Handler ()
		{
			if (cb_setFireInCategories_Ljava_util_List_ == null)
				cb_setFireInCategories_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFireInCategories_Ljava_util_List_);
			return cb_setFireInCategories_Ljava_util_List_;
		}

		static void n_SetFireInCategories_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCLocalNotification __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCCategory>.FromJniHandle (native_value, JniHandleOwnership.DoNotTransfer);
			__this.FireInCategories = value;
		}
#pragma warning restore 0169

		static IntPtr id_getFireInCategories;
		static IntPtr id_setFireInCategories_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCCategory> FireInCategories {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']/method[@name='getFireInCategories' and count(parameter)=0]"
			[Register ("getFireInCategories", "()Ljava/util/List;", "GetGetFireInCategoriesHandler")]
			get {
				if (id_getFireInCategories == IntPtr.Zero)
					id_getFireInCategories = JNIEnv.GetMethodID (class_ref, "getFireInCategories", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCCategory>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFireInCategories), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCCategory>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFireInCategories", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']/method[@name='setFireInCategories' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCCategory&gt;']]"
			[Register ("setFireInCategories", "(Ljava/util/List;)V", "GetSetFireInCategories_Ljava_util_List_Handler")]
			set {
				if (id_setFireInCategories_Ljava_util_List_ == IntPtr.Zero)
					id_setFireInCategories_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setFireInCategories", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCCategory>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFireInCategories_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFireInCategories", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFireInProximity;
#pragma warning disable 0169
		static Delegate GetGetFireInProximityHandler ()
		{
			if (cb_getFireInProximity == null)
				cb_getFireInProximity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFireInProximity);
			return cb_getFireInProximity;
		}

		static IntPtr n_GetFireInProximity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCLocalNotification __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FireInProximity);
		}
#pragma warning restore 0169

		static Delegate cb_setFireInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_;
#pragma warning disable 0169
		static Delegate GetSetFireInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_Handler ()
		{
			if (cb_setFireInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ == null)
				cb_setFireInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFireInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_);
			return cb_setFireInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_;
		}

		static void n_SetFireInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCLocalNotification __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCBeaconBCProximity value = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCProximity> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.FireInProximity = value;
		}
#pragma warning restore 0169

		static IntPtr id_getFireInProximity;
		static IntPtr id_setFireInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_;
		public virtual unsafe global::Com.Bluecats.Sdk.BCBeaconBCProximity FireInProximity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']/method[@name='getFireInProximity' and count(parameter)=0]"
			[Register ("getFireInProximity", "()Lcom/bluecats/sdk/BCBeacon$BCProximity;", "GetGetFireInProximityHandler")]
			get {
				if (id_getFireInProximity == IntPtr.Zero)
					id_getFireInProximity = JNIEnv.GetMethodID (class_ref, "getFireInProximity", "()Lcom/bluecats/sdk/BCBeacon$BCProximity;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCProximity> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFireInProximity), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCBeaconBCProximity> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFireInProximity", "()Lcom/bluecats/sdk/BCBeacon$BCProximity;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']/method[@name='setFireInProximity' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCBeacon.BCProximity']]"
			[Register ("setFireInProximity", "(Lcom/bluecats/sdk/BCBeacon$BCProximity;)V", "GetSetFireInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_Handler")]
			set {
				if (id_setFireInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ == IntPtr.Zero)
					id_setFireInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_ = JNIEnv.GetMethodID (class_ref, "setFireInProximity", "(Lcom/bluecats/sdk/BCBeacon$BCProximity;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFireInProximity_Lcom_bluecats_sdk_BCBeacon_BCProximity_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFireInProximity", "(Lcom/bluecats/sdk/BCBeacon$BCProximity;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFireInSite;
#pragma warning disable 0169
		static Delegate GetGetFireInSiteHandler ()
		{
			if (cb_getFireInSite == null)
				cb_getFireInSite = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFireInSite);
			return cb_getFireInSite;
		}

		static IntPtr n_GetFireInSite (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCLocalNotification __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FireInSite);
		}
#pragma warning restore 0169

		static Delegate cb_setFireInSite_Lcom_bluecats_sdk_BCSite_;
#pragma warning disable 0169
		static Delegate GetSetFireInSite_Lcom_bluecats_sdk_BCSite_Handler ()
		{
			if (cb_setFireInSite_Lcom_bluecats_sdk_BCSite_ == null)
				cb_setFireInSite_Lcom_bluecats_sdk_BCSite_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFireInSite_Lcom_bluecats_sdk_BCSite_);
			return cb_setFireInSite_Lcom_bluecats_sdk_BCSite_;
		}

		static void n_SetFireInSite_Lcom_bluecats_sdk_BCSite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCLocalNotification __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite value = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.FireInSite = value;
		}
#pragma warning restore 0169

		static IntPtr id_getFireInSite;
		static IntPtr id_setFireInSite_Lcom_bluecats_sdk_BCSite_;
		public virtual unsafe global::Com.Bluecats.Sdk.IBCSite FireInSite {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']/method[@name='getFireInSite' and count(parameter)=0]"
			[Register ("getFireInSite", "()Lcom/bluecats/sdk/BCSite;", "GetGetFireInSiteHandler")]
			get {
				if (id_getFireInSite == IntPtr.Zero)
					id_getFireInSite = JNIEnv.GetMethodID (class_ref, "getFireInSite", "()Lcom/bluecats/sdk/BCSite;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFireInSite), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFireInSite", "()Lcom/bluecats/sdk/BCSite;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']/method[@name='setFireInSite' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCSite']]"
			[Register ("setFireInSite", "(Lcom/bluecats/sdk/BCSite;)V", "GetSetFireInSite_Lcom_bluecats_sdk_BCSite_Handler")]
			set {
				if (id_setFireInSite_Lcom_bluecats_sdk_BCSite_ == IntPtr.Zero)
					id_setFireInSite_Lcom_bluecats_sdk_BCSite_ = JNIEnv.GetMethodID (class_ref, "setFireInSite", "(Lcom/bluecats/sdk/BCSite;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFireInSite_Lcom_bluecats_sdk_BCSite_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFireInSite", "(Lcom/bluecats/sdk/BCSite;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getID;
#pragma warning disable 0169
		static Delegate GetGetIDHandler ()
		{
			if (cb_getID == null)
				cb_getID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetID);
			return cb_getID;
		}

		static int n_GetID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCLocalNotification __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ID;
		}
#pragma warning restore 0169

		static Delegate cb_setID_I;
#pragma warning disable 0169
		static Delegate GetSetID_IHandler ()
		{
			if (cb_setID_I == null)
				cb_setID_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetID_I);
			return cb_setID_I;
		}

		static void n_SetID_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Bluecats.Sdk.BCLocalNotification __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getID;
		static IntPtr id_setID_I;
		public virtual unsafe int ID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']/method[@name='getID' and count(parameter)=0]"
			[Register ("getID", "()I", "GetGetIDHandler")]
			get {
				if (id_getID == IntPtr.Zero)
					id_getID = JNIEnv.GetMethodID (class_ref, "getID", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getID);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getID", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']/method[@name='setID' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setID", "(I)V", "GetSetID_IHandler")]
			set {
				if (id_setID_I == IntPtr.Zero)
					id_setID_I = JNIEnv.GetMethodID (class_ref, "setID", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setID_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setID", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTimeZone;
#pragma warning disable 0169
		static Delegate GetGetTimeZoneHandler ()
		{
			if (cb_getTimeZone == null)
				cb_getTimeZone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimeZone);
			return cb_getTimeZone;
		}

		static IntPtr n_GetTimeZone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCLocalNotification __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TimeZone);
		}
#pragma warning restore 0169

		static Delegate cb_setTimeZone_Ljava_util_TimeZone_;
#pragma warning disable 0169
		static Delegate GetSetTimeZone_Ljava_util_TimeZone_Handler ()
		{
			if (cb_setTimeZone_Ljava_util_TimeZone_ == null)
				cb_setTimeZone_Ljava_util_TimeZone_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTimeZone_Ljava_util_TimeZone_);
			return cb_setTimeZone_Ljava_util_TimeZone_;
		}

		static void n_SetTimeZone_Ljava_util_TimeZone_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCLocalNotification __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLocalNotification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.TimeZone value = global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.TimeZone = value;
		}
#pragma warning restore 0169

		static IntPtr id_getTimeZone;
		static IntPtr id_setTimeZone_Ljava_util_TimeZone_;
		public virtual unsafe global::Java.Util.TimeZone TimeZone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']/method[@name='getTimeZone' and count(parameter)=0]"
			[Register ("getTimeZone", "()Ljava/util/TimeZone;", "GetGetTimeZoneHandler")]
			get {
				if (id_getTimeZone == IntPtr.Zero)
					id_getTimeZone = JNIEnv.GetMethodID (class_ref, "getTimeZone", "()Ljava/util/TimeZone;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTimeZone), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.TimeZone> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeZone", "()Ljava/util/TimeZone;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLocalNotification']/method[@name='setTimeZone' and count(parameter)=1 and parameter[1][@type='java.util.TimeZone']]"
			[Register ("setTimeZone", "(Ljava/util/TimeZone;)V", "GetSetTimeZone_Ljava_util_TimeZone_Handler")]
			set {
				if (id_setTimeZone_Ljava_util_TimeZone_ == IntPtr.Zero)
					id_setTimeZone_Ljava_util_TimeZone_ = JNIEnv.GetMethodID (class_ref, "setTimeZone", "(Ljava/util/TimeZone;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTimeZone_Ljava_util_TimeZone_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimeZone", "(Ljava/util/TimeZone;)V"), __args);
				} finally {
				}
			}
		}

	}
}
