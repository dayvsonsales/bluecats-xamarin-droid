using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSharedPreferencesManager']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCSharedPreferencesManager", DoNotGenerateAcw=true)]
	public partial class BCSharedPreferencesManager : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCSharedPreferencesManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCSharedPreferencesManager); }
		}

		protected BCSharedPreferencesManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSharedPreferencesManager']/constructor[@name='BCSharedPreferencesManager' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCSharedPreferencesManager ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCSharedPreferencesManager)) {
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

		static IntPtr id_getInstance;
		public static unsafe global::Com.Bluecats.Sdk.BCSharedPreferencesManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSharedPreferencesManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/bluecats/sdk/BCSharedPreferencesManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/bluecats/sdk/BCSharedPreferencesManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSharedPreferencesManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clearBeaconRegionCacheNextAttemptAt_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetClearBeaconRegionCacheNextAttemptAt_Landroid_content_Context_Handler ()
		{
			if (cb_clearBeaconRegionCacheNextAttemptAt_Landroid_content_Context_ == null)
				cb_clearBeaconRegionCacheNextAttemptAt_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ClearBeaconRegionCacheNextAttemptAt_Landroid_content_Context_);
			return cb_clearBeaconRegionCacheNextAttemptAt_Landroid_content_Context_;
		}

		static void n_ClearBeaconRegionCacheNextAttemptAt_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Bluecats.Sdk.BCSharedPreferencesManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSharedPreferencesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.ClearBeaconRegionCacheNextAttemptAt (context);
		}
#pragma warning restore 0169

		static IntPtr id_clearBeaconRegionCacheNextAttemptAt_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSharedPreferencesManager']/method[@name='clearBeaconRegionCacheNextAttemptAt' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearBeaconRegionCacheNextAttemptAt", "(Landroid/content/Context;)V", "GetClearBeaconRegionCacheNextAttemptAt_Landroid_content_Context_Handler")]
		public virtual unsafe void ClearBeaconRegionCacheNextAttemptAt (global::Android.Content.Context context)
		{
			if (id_clearBeaconRegionCacheNextAttemptAt_Landroid_content_Context_ == IntPtr.Zero)
				id_clearBeaconRegionCacheNextAttemptAt_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "clearBeaconRegionCacheNextAttemptAt", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearBeaconRegionCacheNextAttemptAt_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearBeaconRegionCacheNextAttemptAt", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_clearBeaconRegionForRegionIdentifier_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetClearBeaconRegionForRegionIdentifier_Landroid_content_Context_Handler ()
		{
			if (cb_clearBeaconRegionForRegionIdentifier_Landroid_content_Context_ == null)
				cb_clearBeaconRegionForRegionIdentifier_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ClearBeaconRegionForRegionIdentifier_Landroid_content_Context_);
			return cb_clearBeaconRegionForRegionIdentifier_Landroid_content_Context_;
		}

		static void n_ClearBeaconRegionForRegionIdentifier_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Bluecats.Sdk.BCSharedPreferencesManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSharedPreferencesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.ClearBeaconRegionForRegionIdentifier (context);
		}
#pragma warning restore 0169

		static IntPtr id_clearBeaconRegionForRegionIdentifier_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSharedPreferencesManager']/method[@name='clearBeaconRegionForRegionIdentifier' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("clearBeaconRegionForRegionIdentifier", "(Landroid/content/Context;)V", "GetClearBeaconRegionForRegionIdentifier_Landroid_content_Context_Handler")]
		public virtual unsafe void ClearBeaconRegionForRegionIdentifier (global::Android.Content.Context context)
		{
			if (id_clearBeaconRegionForRegionIdentifier_Landroid_content_Context_ == IntPtr.Zero)
				id_clearBeaconRegionForRegionIdentifier_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "clearBeaconRegionForRegionIdentifier", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearBeaconRegionForRegionIdentifier_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearBeaconRegionForRegionIdentifier", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_loadBeaconRegionCacheNextAttemptAt_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetLoadBeaconRegionCacheNextAttemptAt_Landroid_content_Context_Handler ()
		{
			if (cb_loadBeaconRegionCacheNextAttemptAt_Landroid_content_Context_ == null)
				cb_loadBeaconRegionCacheNextAttemptAt_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadBeaconRegionCacheNextAttemptAt_Landroid_content_Context_);
			return cb_loadBeaconRegionCacheNextAttemptAt_Landroid_content_Context_;
		}

		static IntPtr n_LoadBeaconRegionCacheNextAttemptAt_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Bluecats.Sdk.BCSharedPreferencesManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSharedPreferencesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LoadBeaconRegionCacheNextAttemptAt (context));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadBeaconRegionCacheNextAttemptAt_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSharedPreferencesManager']/method[@name='loadBeaconRegionCacheNextAttemptAt' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("loadBeaconRegionCacheNextAttemptAt", "(Landroid/content/Context;)Ljava/util/Date;", "GetLoadBeaconRegionCacheNextAttemptAt_Landroid_content_Context_Handler")]
		public virtual unsafe global::Java.Util.Date LoadBeaconRegionCacheNextAttemptAt (global::Android.Content.Context context)
		{
			if (id_loadBeaconRegionCacheNextAttemptAt_Landroid_content_Context_ == IntPtr.Zero)
				id_loadBeaconRegionCacheNextAttemptAt_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "loadBeaconRegionCacheNextAttemptAt", "(Landroid/content/Context;)Ljava/util/Date;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);

				global::Java.Util.Date __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_loadBeaconRegionCacheNextAttemptAt_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadBeaconRegionCacheNextAttemptAt", "(Landroid/content/Context;)Ljava/util/Date;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_loadBeaconRegionForRegionIdentifier_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetLoadBeaconRegionForRegionIdentifier_Landroid_content_Context_Handler ()
		{
			if (cb_loadBeaconRegionForRegionIdentifier_Landroid_content_Context_ == null)
				cb_loadBeaconRegionForRegionIdentifier_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LoadBeaconRegionForRegionIdentifier_Landroid_content_Context_);
			return cb_loadBeaconRegionForRegionIdentifier_Landroid_content_Context_;
		}

		static IntPtr n_LoadBeaconRegionForRegionIdentifier_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Bluecats.Sdk.BCSharedPreferencesManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSharedPreferencesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, global::Com.Bluecats.Sdk.BCBeaconRegion>.ToLocalJniHandle (__this.LoadBeaconRegionForRegionIdentifier (context));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_loadBeaconRegionForRegionIdentifier_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSharedPreferencesManager']/method[@name='loadBeaconRegionForRegionIdentifier' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("loadBeaconRegionForRegionIdentifier", "(Landroid/content/Context;)Ljava/util/Map;", "GetLoadBeaconRegionForRegionIdentifier_Landroid_content_Context_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Com.Bluecats.Sdk.BCBeaconRegion> LoadBeaconRegionForRegionIdentifier (global::Android.Content.Context context)
		{
			if (id_loadBeaconRegionForRegionIdentifier_Landroid_content_Context_ == IntPtr.Zero)
				id_loadBeaconRegionForRegionIdentifier_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "loadBeaconRegionForRegionIdentifier", "(Landroid/content/Context;)Ljava/util/Map;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);

				global::System.Collections.Generic.IDictionary<string, global::Com.Bluecats.Sdk.BCBeaconRegion> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, global::Com.Bluecats.Sdk.BCBeaconRegion>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_loadBeaconRegionForRegionIdentifier_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, global::Com.Bluecats.Sdk.BCBeaconRegion>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "loadBeaconRegionForRegionIdentifier", "(Landroid/content/Context;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_storeBeaconRegionCacheNextAttemptAt_Landroid_content_Context_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetStoreBeaconRegionCacheNextAttemptAt_Landroid_content_Context_Ljava_util_Date_Handler ()
		{
			if (cb_storeBeaconRegionCacheNextAttemptAt_Landroid_content_Context_Ljava_util_Date_ == null)
				cb_storeBeaconRegionCacheNextAttemptAt_Landroid_content_Context_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_StoreBeaconRegionCacheNextAttemptAt_Landroid_content_Context_Ljava_util_Date_);
			return cb_storeBeaconRegionCacheNextAttemptAt_Landroid_content_Context_Ljava_util_Date_;
		}

		static void n_StoreBeaconRegionCacheNextAttemptAt_Landroid_content_Context_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_regionCacheNextAttemptAt)
		{
			global::Com.Bluecats.Sdk.BCSharedPreferencesManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSharedPreferencesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date regionCacheNextAttemptAt = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_regionCacheNextAttemptAt, JniHandleOwnership.DoNotTransfer);
			__this.StoreBeaconRegionCacheNextAttemptAt (context, regionCacheNextAttemptAt);
		}
#pragma warning restore 0169

		static IntPtr id_storeBeaconRegionCacheNextAttemptAt_Landroid_content_Context_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSharedPreferencesManager']/method[@name='storeBeaconRegionCacheNextAttemptAt' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.Date']]"
		[Register ("storeBeaconRegionCacheNextAttemptAt", "(Landroid/content/Context;Ljava/util/Date;)V", "GetStoreBeaconRegionCacheNextAttemptAt_Landroid_content_Context_Ljava_util_Date_Handler")]
		public virtual unsafe void StoreBeaconRegionCacheNextAttemptAt (global::Android.Content.Context context, global::Java.Util.Date regionCacheNextAttemptAt)
		{
			if (id_storeBeaconRegionCacheNextAttemptAt_Landroid_content_Context_Ljava_util_Date_ == IntPtr.Zero)
				id_storeBeaconRegionCacheNextAttemptAt_Landroid_content_Context_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "storeBeaconRegionCacheNextAttemptAt", "(Landroid/content/Context;Ljava/util/Date;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (regionCacheNextAttemptAt);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_storeBeaconRegionCacheNextAttemptAt_Landroid_content_Context_Ljava_util_Date_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "storeBeaconRegionCacheNextAttemptAt", "(Landroid/content/Context;Ljava/util/Date;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_storeBeaconRegionForRegionIdentifier_Landroid_content_Context_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetStoreBeaconRegionForRegionIdentifier_Landroid_content_Context_Ljava_util_Map_Handler ()
		{
			if (cb_storeBeaconRegionForRegionIdentifier_Landroid_content_Context_Ljava_util_Map_ == null)
				cb_storeBeaconRegionForRegionIdentifier_Landroid_content_Context_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_StoreBeaconRegionForRegionIdentifier_Landroid_content_Context_Ljava_util_Map_);
			return cb_storeBeaconRegionForRegionIdentifier_Landroid_content_Context_Ljava_util_Map_;
		}

		static void n_StoreBeaconRegionForRegionIdentifier_Landroid_content_Context_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_beaconRegionForRegionIdentifier)
		{
			global::Com.Bluecats.Sdk.BCSharedPreferencesManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSharedPreferencesManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			var beaconRegionForRegionIdentifier = global::Android.Runtime.JavaDictionary<string, global::Com.Bluecats.Sdk.BCBeaconRegion>.FromJniHandle (native_beaconRegionForRegionIdentifier, JniHandleOwnership.DoNotTransfer);
			__this.StoreBeaconRegionForRegionIdentifier (context, beaconRegionForRegionIdentifier);
		}
#pragma warning restore 0169

		static IntPtr id_storeBeaconRegionForRegionIdentifier_Landroid_content_Context_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSharedPreferencesManager']/method[@name='storeBeaconRegionForRegionIdentifier' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.Map&lt;java.lang.String, com.bluecats.sdk.BCBeaconRegion&gt;']]"
		[Register ("storeBeaconRegionForRegionIdentifier", "(Landroid/content/Context;Ljava/util/Map;)V", "GetStoreBeaconRegionForRegionIdentifier_Landroid_content_Context_Ljava_util_Map_Handler")]
		public virtual unsafe void StoreBeaconRegionForRegionIdentifier (global::Android.Content.Context context, global::System.Collections.Generic.IDictionary<string, global::Com.Bluecats.Sdk.BCBeaconRegion> beaconRegionForRegionIdentifier)
		{
			if (id_storeBeaconRegionForRegionIdentifier_Landroid_content_Context_Ljava_util_Map_ == IntPtr.Zero)
				id_storeBeaconRegionForRegionIdentifier_Landroid_content_Context_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "storeBeaconRegionForRegionIdentifier", "(Landroid/content/Context;Ljava/util/Map;)V");
			IntPtr native_beaconRegionForRegionIdentifier = global::Android.Runtime.JavaDictionary<string, global::Com.Bluecats.Sdk.BCBeaconRegion>.ToLocalJniHandle (beaconRegionForRegionIdentifier);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (native_beaconRegionForRegionIdentifier);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_storeBeaconRegionForRegionIdentifier_Landroid_content_Context_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "storeBeaconRegionForRegionIdentifier", "(Landroid/content/Context;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_beaconRegionForRegionIdentifier);
			}
		}

	}
}
