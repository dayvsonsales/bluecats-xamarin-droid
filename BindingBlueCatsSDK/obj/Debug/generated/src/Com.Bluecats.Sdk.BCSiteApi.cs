using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCSiteApi", DoNotGenerateAcw=true)]
	public partial class BCSiteApi : global::Java.Lang.Object {


		static IntPtr customValues_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/field[@name='customValues']"
		[Register ("customValues")]
		protected IList<Com.Bluecats.Sdk.BCCustomValue> CustomValues {
			get {
				if (customValues_jfieldId == IntPtr.Zero)
					customValues_jfieldId = JNIEnv.GetFieldID (class_ref, "customValues", "[Lcom/bluecats/sdk/BCCustomValue;");
				return global::Android.Runtime.JavaArray<global::Com.Bluecats.Sdk.BCCustomValue>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, customValues_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (customValues_jfieldId == IntPtr.Zero)
					customValues_jfieldId = JNIEnv.GetFieldID (class_ref, "customValues", "[Lcom/bluecats/sdk/BCCustomValue;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Bluecats.Sdk.BCCustomValue>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, customValues_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/field[@name='id']"
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

		static IntPtr mNumberOfBeaconsCached_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/field[@name='mNumberOfBeaconsCached']"
		[Register ("mNumberOfBeaconsCached")]
		protected int MNumberOfBeaconsCached {
			get {
				if (mNumberOfBeaconsCached_jfieldId == IntPtr.Zero)
					mNumberOfBeaconsCached_jfieldId = JNIEnv.GetFieldID (class_ref, "mNumberOfBeaconsCached", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mNumberOfBeaconsCached_jfieldId);
			}
			set {
				if (mNumberOfBeaconsCached_jfieldId == IntPtr.Zero)
					mNumberOfBeaconsCached_jfieldId = JNIEnv.GetFieldID (class_ref, "mNumberOfBeaconsCached", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mNumberOfBeaconsCached_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mSiteCallback_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/field[@name='mSiteCallback']"
		[Register ("mSiteCallback")]
		protected global::Com.Bluecats.Sdk.IBCSiteCallback MSiteCallback {
			get {
				if (mSiteCallback_jfieldId == IntPtr.Zero)
					mSiteCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mSiteCallback", "Lcom/bluecats/sdk/BCSiteCallback;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mSiteCallback_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSiteCallback> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSiteCallback_jfieldId == IntPtr.Zero)
					mSiteCallback_jfieldId = JNIEnv.GetFieldID (class_ref, "mSiteCallback", "Lcom/bluecats/sdk/BCSiteCallback;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSiteCallback_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCSiteApi", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCSiteApi); }
		}

		protected BCSiteApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/constructor[@name='BCSiteApi' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCSiteApi ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCSiteApi)) {
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

		static Delegate cb_getCachedBeacons;
#pragma warning disable 0169
		static Delegate GetGetCachedBeaconsHandler ()
		{
			if (cb_getCachedBeacons == null)
				cb_getCachedBeacons = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedBeacons);
			return cb_getCachedBeacons;
		}

		static IntPtr n_GetCachedBeacons (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCSiteApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.ToLocalJniHandle (__this.CachedBeacons);
		}
#pragma warning restore 0169

		static IntPtr id_getCachedBeacons;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> CachedBeacons {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/method[@name='getCachedBeacons' and count(parameter)=0]"
			[Register ("getCachedBeacons", "()Ljava/util/List;", "GetGetCachedBeaconsHandler")]
			get {
				if (id_getCachedBeacons == IntPtr.Zero)
					id_getCachedBeacons = JNIEnv.GetMethodID (class_ref, "getCachedBeacons", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedBeacons), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedBeacons", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCachedBeaconsAt;
#pragma warning disable 0169
		static Delegate GetGetCachedBeaconsAtHandler ()
		{
			if (cb_getCachedBeaconsAt == null)
				cb_getCachedBeaconsAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedBeaconsAt);
			return cb_getCachedBeaconsAt;
		}

		static IntPtr n_GetCachedBeaconsAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCSiteApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CachedBeaconsAt);
		}
#pragma warning restore 0169

		static Delegate cb_setCachedBeaconsAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetCachedBeaconsAt_Ljava_util_Date_Handler ()
		{
			if (cb_setCachedBeaconsAt_Ljava_util_Date_ == null)
				cb_setCachedBeaconsAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCachedBeaconsAt_Ljava_util_Date_);
			return cb_setCachedBeaconsAt_Ljava_util_Date_;
		}

		static void n_SetCachedBeaconsAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCSiteApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.CachedBeaconsAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCachedBeaconsAt;
		static IntPtr id_setCachedBeaconsAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date CachedBeaconsAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/method[@name='getCachedBeaconsAt' and count(parameter)=0]"
			[Register ("getCachedBeaconsAt", "()Ljava/util/Date;", "GetGetCachedBeaconsAtHandler")]
			get {
				if (id_getCachedBeaconsAt == IntPtr.Zero)
					id_getCachedBeaconsAt = JNIEnv.GetMethodID (class_ref, "getCachedBeaconsAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedBeaconsAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedBeaconsAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/method[@name='setCachedBeaconsAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setCachedBeaconsAt", "(Ljava/util/Date;)V", "GetSetCachedBeaconsAt_Ljava_util_Date_Handler")]
			set {
				if (id_setCachedBeaconsAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setCachedBeaconsAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setCachedBeaconsAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCachedBeaconsAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCachedBeaconsAt", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCachedCategories;
#pragma warning disable 0169
		static Delegate GetGetCachedCategoriesHandler ()
		{
			if (cb_getCachedCategories == null)
				cb_getCachedCategories = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedCategories);
			return cb_getCachedCategories;
		}

		static IntPtr n_GetCachedCategories (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCSiteApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCCategory>.ToLocalJniHandle (__this.CachedCategories);
		}
#pragma warning restore 0169

		static IntPtr id_getCachedCategories;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCCategory> CachedCategories {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/method[@name='getCachedCategories' and count(parameter)=0]"
			[Register ("getCachedCategories", "()Ljava/util/List;", "GetGetCachedCategoriesHandler")]
			get {
				if (id_getCachedCategories == IntPtr.Zero)
					id_getCachedCategories = JNIEnv.GetMethodID (class_ref, "getCachedCategories", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCCategory>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedCategories), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCCategory>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedCategories", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCachedCategoriesAt;
#pragma warning disable 0169
		static Delegate GetGetCachedCategoriesAtHandler ()
		{
			if (cb_getCachedCategoriesAt == null)
				cb_getCachedCategoriesAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedCategoriesAt);
			return cb_getCachedCategoriesAt;
		}

		static IntPtr n_GetCachedCategoriesAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCSiteApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CachedCategoriesAt);
		}
#pragma warning restore 0169

		static Delegate cb_setCachedCategoriesAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetCachedCategoriesAt_Ljava_util_Date_Handler ()
		{
			if (cb_setCachedCategoriesAt_Ljava_util_Date_ == null)
				cb_setCachedCategoriesAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCachedCategoriesAt_Ljava_util_Date_);
			return cb_setCachedCategoriesAt_Ljava_util_Date_;
		}

		static void n_SetCachedCategoriesAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCSiteApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.CachedCategoriesAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCachedCategoriesAt;
		static IntPtr id_setCachedCategoriesAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date CachedCategoriesAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/method[@name='getCachedCategoriesAt' and count(parameter)=0]"
			[Register ("getCachedCategoriesAt", "()Ljava/util/Date;", "GetGetCachedCategoriesAtHandler")]
			get {
				if (id_getCachedCategoriesAt == IntPtr.Zero)
					id_getCachedCategoriesAt = JNIEnv.GetMethodID (class_ref, "getCachedCategoriesAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedCategoriesAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedCategoriesAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/method[@name='setCachedCategoriesAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setCachedCategoriesAt", "(Ljava/util/Date;)V", "GetSetCachedCategoriesAt_Ljava_util_Date_Handler")]
			set {
				if (id_setCachedCategoriesAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setCachedCategoriesAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setCachedCategoriesAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCachedCategoriesAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCachedCategoriesAt", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_hasBeaconsCacheExpired;
#pragma warning disable 0169
		static Delegate GetHasBeaconsCacheExpiredHandler ()
		{
			if (cb_hasBeaconsCacheExpired == null)
				cb_hasBeaconsCacheExpired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasBeaconsCacheExpired);
			return cb_hasBeaconsCacheExpired;
		}

		static bool n_HasBeaconsCacheExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCSiteApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBeaconsCacheExpired;
		}
#pragma warning restore 0169

		static IntPtr id_hasBeaconsCacheExpired;
		public virtual unsafe bool HasBeaconsCacheExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/method[@name='hasBeaconsCacheExpired' and count(parameter)=0]"
			[Register ("hasBeaconsCacheExpired", "()Z", "GetHasBeaconsCacheExpiredHandler")]
			get {
				if (id_hasBeaconsCacheExpired == IntPtr.Zero)
					id_hasBeaconsCacheExpired = JNIEnv.GetMethodID (class_ref, "hasBeaconsCacheExpired", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasBeaconsCacheExpired);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasBeaconsCacheExpired", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_hasCategoriesCacheExpired;
#pragma warning disable 0169
		static Delegate GetHasCategoriesCacheExpiredHandler ()
		{
			if (cb_hasCategoriesCacheExpired == null)
				cb_hasCategoriesCacheExpired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasCategoriesCacheExpired);
			return cb_hasCategoriesCacheExpired;
		}

		static bool n_HasCategoriesCacheExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCSiteApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasCategoriesCacheExpired;
		}
#pragma warning restore 0169

		static IntPtr id_hasCategoriesCacheExpired;
		public virtual unsafe bool HasCategoriesCacheExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/method[@name='hasCategoriesCacheExpired' and count(parameter)=0]"
			[Register ("hasCategoriesCacheExpired", "()Z", "GetHasCategoriesCacheExpiredHandler")]
			get {
				if (id_hasCategoriesCacheExpired == IntPtr.Zero)
					id_hasCategoriesCacheExpired = JNIEnv.GetMethodID (class_ref, "hasCategoriesCacheExpired", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasCategoriesCacheExpired);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasCategoriesCacheExpired", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getNumberOfBeaconsCached;
#pragma warning disable 0169
		static Delegate GetGetNumberOfBeaconsCachedHandler ()
		{
			if (cb_getNumberOfBeaconsCached == null)
				cb_getNumberOfBeaconsCached = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNumberOfBeaconsCached);
			return cb_getNumberOfBeaconsCached;
		}

		static int n_GetNumberOfBeaconsCached (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCSiteApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumberOfBeaconsCached;
		}
#pragma warning restore 0169

		static Delegate cb_setNumberOfBeaconsCached_I;
#pragma warning disable 0169
		static Delegate GetSetNumberOfBeaconsCached_IHandler ()
		{
			if (cb_setNumberOfBeaconsCached_I == null)
				cb_setNumberOfBeaconsCached_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNumberOfBeaconsCached_I);
			return cb_setNumberOfBeaconsCached_I;
		}

		static void n_SetNumberOfBeaconsCached_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Bluecats.Sdk.BCSiteApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NumberOfBeaconsCached = value;
		}
#pragma warning restore 0169

		static IntPtr id_getNumberOfBeaconsCached;
		static IntPtr id_setNumberOfBeaconsCached_I;
		public virtual unsafe int NumberOfBeaconsCached {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/method[@name='getNumberOfBeaconsCached' and count(parameter)=0]"
			[Register ("getNumberOfBeaconsCached", "()I", "GetGetNumberOfBeaconsCachedHandler")]
			get {
				if (id_getNumberOfBeaconsCached == IntPtr.Zero)
					id_getNumberOfBeaconsCached = JNIEnv.GetMethodID (class_ref, "getNumberOfBeaconsCached", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumberOfBeaconsCached);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumberOfBeaconsCached", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/method[@name='setNumberOfBeaconsCached' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNumberOfBeaconsCached", "(I)V", "GetSetNumberOfBeaconsCached_IHandler")]
			set {
				if (id_setNumberOfBeaconsCached_I == IntPtr.Zero)
					id_setNumberOfBeaconsCached_I = JNIEnv.GetMethodID (class_ref, "setNumberOfBeaconsCached", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNumberOfBeaconsCached_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNumberOfBeaconsCached", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSiteID;
#pragma warning disable 0169
		static Delegate GetGetSiteIDHandler ()
		{
			if (cb_getSiteID == null)
				cb_getSiteID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSiteID);
			return cb_getSiteID;
		}

		static IntPtr n_GetSiteID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCSiteApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SiteID);
		}
#pragma warning restore 0169

		static Delegate cb_setSiteID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSiteID_Ljava_lang_String_Handler ()
		{
			if (cb_setSiteID_Ljava_lang_String_ == null)
				cb_setSiteID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSiteID_Ljava_lang_String_);
			return cb_setSiteID_Ljava_lang_String_;
		}

		static void n_SetSiteID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCSiteApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SiteID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getSiteID;
		static IntPtr id_setSiteID_Ljava_lang_String_;
		public virtual unsafe string SiteID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/method[@name='getSiteID' and count(parameter)=0]"
			[Register ("getSiteID", "()Ljava/lang/String;", "GetGetSiteIDHandler")]
			get {
				if (id_getSiteID == IntPtr.Zero)
					id_getSiteID = JNIEnv.GetMethodID (class_ref, "getSiteID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSiteID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSiteID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/method[@name='setSiteID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSiteID", "(Ljava/lang/String;)V", "GetSetSiteID_Ljava_lang_String_Handler")]
			set {
				if (id_setSiteID_Ljava_lang_String_ == IntPtr.Zero)
					id_setSiteID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSiteID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSiteID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSiteID", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Bluecats.Sdk.BCSiteApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCSiteApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.TeamID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getTeamID;
		static IntPtr id_setTeamID_Ljava_lang_String_;
		public virtual unsafe string TeamID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/method[@name='getTeamID' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/method[@name='setTeamID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getBeacons_ZLcom_bluecats_sdk_BCSiteCallback_;
#pragma warning disable 0169
		static Delegate GetGetBeacons_ZLcom_bluecats_sdk_BCSiteCallback_Handler ()
		{
			if (cb_getBeacons_ZLcom_bluecats_sdk_BCSiteCallback_ == null)
				cb_getBeacons_ZLcom_bluecats_sdk_BCSiteCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_GetBeacons_ZLcom_bluecats_sdk_BCSiteCallback_);
			return cb_getBeacons_ZLcom_bluecats_sdk_BCSiteCallback_;
		}

		static void n_GetBeacons_ZLcom_bluecats_sdk_BCSiteCallback_ (IntPtr jnienv, IntPtr native__this, bool preferCached, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCSiteApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSiteCallback @callback = (global::Com.Bluecats.Sdk.IBCSiteCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSiteCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetBeacons (preferCached, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_getBeacons_ZLcom_bluecats_sdk_BCSiteCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/method[@name='getBeacons' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.bluecats.sdk.BCSiteCallback']]"
		[Register ("getBeacons", "(ZLcom/bluecats/sdk/BCSiteCallback;)V", "GetGetBeacons_ZLcom_bluecats_sdk_BCSiteCallback_Handler")]
		public virtual unsafe void GetBeacons (bool preferCached, global::Com.Bluecats.Sdk.IBCSiteCallback @callback)
		{
			if (id_getBeacons_ZLcom_bluecats_sdk_BCSiteCallback_ == IntPtr.Zero)
				id_getBeacons_ZLcom_bluecats_sdk_BCSiteCallback_ = JNIEnv.GetMethodID (class_ref, "getBeacons", "(ZLcom/bluecats/sdk/BCSiteCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (preferCached);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getBeacons_ZLcom_bluecats_sdk_BCSiteCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeacons", "(ZLcom/bluecats/sdk/BCSiteCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getCategories_ZLcom_bluecats_sdk_BCSiteCallback_;
#pragma warning disable 0169
		static Delegate GetGetCategories_ZLcom_bluecats_sdk_BCSiteCallback_Handler ()
		{
			if (cb_getCategories_ZLcom_bluecats_sdk_BCSiteCallback_ == null)
				cb_getCategories_ZLcom_bluecats_sdk_BCSiteCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_GetCategories_ZLcom_bluecats_sdk_BCSiteCallback_);
			return cb_getCategories_ZLcom_bluecats_sdk_BCSiteCallback_;
		}

		static void n_GetCategories_ZLcom_bluecats_sdk_BCSiteCallback_ (IntPtr jnienv, IntPtr native__this, bool preferCached, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCSiteApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSiteCallback @callback = (global::Com.Bluecats.Sdk.IBCSiteCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSiteCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetCategories (preferCached, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_getCategories_ZLcom_bluecats_sdk_BCSiteCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/method[@name='getCategories' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.bluecats.sdk.BCSiteCallback']]"
		[Register ("getCategories", "(ZLcom/bluecats/sdk/BCSiteCallback;)V", "GetGetCategories_ZLcom_bluecats_sdk_BCSiteCallback_Handler")]
		public virtual unsafe void GetCategories (bool preferCached, global::Com.Bluecats.Sdk.IBCSiteCallback @callback)
		{
			if (id_getCategories_ZLcom_bluecats_sdk_BCSiteCallback_ == IntPtr.Zero)
				id_getCategories_ZLcom_bluecats_sdk_BCSiteCallback_ = JNIEnv.GetMethodID (class_ref, "getCategories", "(ZLcom/bluecats/sdk/BCSiteCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (preferCached);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getCategories_ZLcom_bluecats_sdk_BCSiteCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCategories", "(ZLcom/bluecats/sdk/BCSiteCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getCustomValues;
#pragma warning disable 0169
		static Delegate GetGetCustomValuesHandler ()
		{
			if (cb_getCustomValues == null)
				cb_getCustomValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomValues);
			return cb_getCustomValues;
		}

		static IntPtr n_GetCustomValues (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCSiteApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCustomValues ());
		}
#pragma warning restore 0169

		static IntPtr id_getCustomValues;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/method[@name='getCustomValues' and count(parameter)=0]"
		[Register ("getCustomValues", "()[Lcom/bluecats/sdk/BCCustomValue;", "GetGetCustomValuesHandler")]
		public virtual unsafe global::Com.Bluecats.Sdk.BCCustomValue[] GetCustomValues ()
		{
			if (id_getCustomValues == IntPtr.Zero)
				id_getCustomValues = JNIEnv.GetMethodID (class_ref, "getCustomValues", "()[Lcom/bluecats/sdk/BCCustomValue;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Com.Bluecats.Sdk.BCCustomValue[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCustomValues), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCCustomValue));
				else
					return (global::Com.Bluecats.Sdk.BCCustomValue[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCustomValues", "()[Lcom/bluecats/sdk/BCCustomValue;")), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCCustomValue));
			} finally {
			}
		}

		static Delegate cb_getSiteInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCSiteCallback_;
#pragma warning disable 0169
		static Delegate GetGetSiteInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCSiteCallback_Handler ()
		{
			if (cb_getSiteInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCSiteCallback_ == null)
				cb_getSiteInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCSiteCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr>) n_GetSiteInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCSiteCallback_);
			return cb_getSiteInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCSiteCallback_;
		}

		static void n_GetSiteInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCSiteCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_endDate, IntPtr native_period, long duration, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCSiteApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date endDate = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_endDate, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod period = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod> (native_period, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSiteCallback @callback = (global::Com.Bluecats.Sdk.IBCSiteCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSiteCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetSiteInsightsForEndDate (endDate, period, duration, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_getSiteInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCSiteCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/method[@name='getSiteInsightsForEndDate' and count(parameter)=4 and parameter[1][@type='java.util.Date'] and parameter[2][@type='com.bluecats.sdk.BCInsights.BCInsightsPeriod'] and parameter[3][@type='long'] and parameter[4][@type='com.bluecats.sdk.BCSiteCallback']]"
		[Register ("getSiteInsightsForEndDate", "(Ljava/util/Date;Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;JLcom/bluecats/sdk/BCSiteCallback;)V", "GetGetSiteInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCSiteCallback_Handler")]
		public virtual unsafe void GetSiteInsightsForEndDate (global::Java.Util.Date endDate, global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod period, long duration, global::Com.Bluecats.Sdk.IBCSiteCallback @callback)
		{
			if (id_getSiteInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCSiteCallback_ == IntPtr.Zero)
				id_getSiteInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCSiteCallback_ = JNIEnv.GetMethodID (class_ref, "getSiteInsightsForEndDate", "(Ljava/util/Date;Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;JLcom/bluecats/sdk/BCSiteCallback;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (endDate);
				__args [1] = new JValue (period);
				__args [2] = new JValue (duration);
				__args [3] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getSiteInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCSiteCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSiteInsightsForEndDate", "(Ljava/util/Date;Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;JLcom/bluecats/sdk/BCSiteCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCachedCategories_arrayLcom_bluecats_sdk_BCCategory_;
#pragma warning disable 0169
		static Delegate GetSetCachedCategories_arrayLcom_bluecats_sdk_BCCategory_Handler ()
		{
			if (cb_setCachedCategories_arrayLcom_bluecats_sdk_BCCategory_ == null)
				cb_setCachedCategories_arrayLcom_bluecats_sdk_BCCategory_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCachedCategories_arrayLcom_bluecats_sdk_BCCategory_);
			return cb_setCachedCategories_arrayLcom_bluecats_sdk_BCCategory_;
		}

		static void n_SetCachedCategories_arrayLcom_bluecats_sdk_BCCategory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCSiteApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCCategory[] value = (global::Com.Bluecats.Sdk.BCCategory[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Bluecats.Sdk.BCCategory));
			__this.SetCachedCategories (value);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		static IntPtr id_setCachedCategories_arrayLcom_bluecats_sdk_BCCategory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/method[@name='setCachedCategories' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCCategory[]']]"
		[Register ("setCachedCategories", "([Lcom/bluecats/sdk/BCCategory;)V", "GetSetCachedCategories_arrayLcom_bluecats_sdk_BCCategory_Handler")]
		public virtual unsafe void SetCachedCategories (global::Com.Bluecats.Sdk.BCCategory[] value)
		{
			if (id_setCachedCategories_arrayLcom_bluecats_sdk_BCCategory_ == IntPtr.Zero)
				id_setCachedCategories_arrayLcom_bluecats_sdk_BCCategory_ = JNIEnv.GetMethodID (class_ref, "setCachedCategories", "([Lcom/bluecats/sdk/BCCategory;)V");
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCachedCategories_arrayLcom_bluecats_sdk_BCCategory_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCachedCategories", "([Lcom/bluecats/sdk/BCCategory;)V"), __args);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_;
#pragma warning disable 0169
		static Delegate GetSetCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_Handler ()
		{
			if (cb_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_ == null)
				cb_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_);
			return cb_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_;
		}

		static void n_SetCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCSiteApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCCustomValue[] value = (global::Com.Bluecats.Sdk.BCCustomValue[]) JNIEnv.GetArray (native_value, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Bluecats.Sdk.BCCustomValue));
			__this.SetCustomValues (value);
			if (value != null)
				JNIEnv.CopyArray (value, native_value);
		}
#pragma warning restore 0169

		static IntPtr id_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/method[@name='setCustomValues' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCCustomValue[]']]"
		[Register ("setCustomValues", "([Lcom/bluecats/sdk/BCCustomValue;)V", "GetSetCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_Handler")]
		public virtual unsafe void SetCustomValues (global::Com.Bluecats.Sdk.BCCustomValue[] value)
		{
			if (id_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_ == IntPtr.Zero)
				id_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_ = JNIEnv.GetMethodID (class_ref, "setCustomValues", "([Lcom/bluecats/sdk/BCCustomValue;)V");
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCustomValues_arrayLcom_bluecats_sdk_BCCustomValue_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomValues", "([Lcom/bluecats/sdk/BCCustomValue;)V"), __args);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_updateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_;
#pragma warning disable 0169
		static Delegate GetUpdateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_Handler ()
		{
			if (cb_updateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_ == null)
				cb_updateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_);
			return cb_updateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_;
		}

		static void n_UpdateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_site, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCSiteApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCSiteApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite site = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_site, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSiteCallback @callback = (global::Com.Bluecats.Sdk.IBCSiteCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSiteCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.UpdateSite (site, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_updateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCSiteApi']/method[@name='updateSite' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCSite'] and parameter[2][@type='com.bluecats.sdk.BCSiteCallback']]"
		[Register ("updateSite", "(Lcom/bluecats/sdk/BCSite;Lcom/bluecats/sdk/BCSiteCallback;)V", "GetUpdateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_Handler")]
		public virtual unsafe void UpdateSite (global::Com.Bluecats.Sdk.IBCSite site, global::Com.Bluecats.Sdk.IBCSiteCallback @callback)
		{
			if (id_updateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_ == IntPtr.Zero)
				id_updateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_ = JNIEnv.GetMethodID (class_ref, "updateSite", "(Lcom/bluecats/sdk/BCSite;Lcom/bluecats/sdk/BCSiteCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (site);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCSiteCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateSite", "(Lcom/bluecats/sdk/BCSite;Lcom/bluecats/sdk/BCSiteCallback;)V"), __args);
			} finally {
			}
		}

	}
}
