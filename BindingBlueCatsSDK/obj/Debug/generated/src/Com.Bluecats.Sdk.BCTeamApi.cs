using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCTeamApi", DoNotGenerateAcw=true)]
	public partial class BCTeamApi : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/field[@name='TAG']"
		[Register ("TAG")]
		protected const string Tag = (string) "BCTeamApi";

		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/field[@name='id']"
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

		static IntPtr mCachedApps_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/field[@name='mCachedApps']"
		[Register ("mCachedApps")]
		protected IList<Com.Bluecats.Sdk.IBCApp> MCachedApps {
			get {
				if (mCachedApps_jfieldId == IntPtr.Zero)
					mCachedApps_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedApps", "[Lcom/bluecats/sdk/BCApp;");
				return global::Android.Runtime.JavaArray<global::Com.Bluecats.Sdk.IBCApp>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCachedApps_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCachedApps_jfieldId == IntPtr.Zero)
					mCachedApps_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedApps", "[Lcom/bluecats/sdk/BCApp;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Bluecats.Sdk.IBCApp>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCachedApps_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCachedAppsAt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/field[@name='mCachedAppsAt']"
		[Register ("mCachedAppsAt")]
		protected global::Java.Util.Date MCachedAppsAt {
			get {
				if (mCachedAppsAt_jfieldId == IntPtr.Zero)
					mCachedAppsAt_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedAppsAt", "Ljava/util/Date;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCachedAppsAt_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCachedAppsAt_jfieldId == IntPtr.Zero)
					mCachedAppsAt_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedAppsAt", "Ljava/util/Date;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCachedAppsAt_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCachedBeaconRegions_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/field[@name='mCachedBeaconRegions']"
		[Register ("mCachedBeaconRegions")]
		protected IList<Com.Bluecats.Sdk.BCBeaconRegion> MCachedBeaconRegions {
			get {
				if (mCachedBeaconRegions_jfieldId == IntPtr.Zero)
					mCachedBeaconRegions_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedBeaconRegions", "[Lcom/bluecats/sdk/BCBeaconRegion;");
				return global::Android.Runtime.JavaArray<global::Com.Bluecats.Sdk.BCBeaconRegion>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCachedBeaconRegions_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCachedBeaconRegions_jfieldId == IntPtr.Zero)
					mCachedBeaconRegions_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedBeaconRegions", "[Lcom/bluecats/sdk/BCBeaconRegion;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Bluecats.Sdk.BCBeaconRegion>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCachedBeaconRegions_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCachedBeaconRegionsAt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/field[@name='mCachedBeaconRegionsAt']"
		[Register ("mCachedBeaconRegionsAt")]
		protected global::Java.Util.Date MCachedBeaconRegionsAt {
			get {
				if (mCachedBeaconRegionsAt_jfieldId == IntPtr.Zero)
					mCachedBeaconRegionsAt_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedBeaconRegionsAt", "Ljava/util/Date;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCachedBeaconRegionsAt_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCachedBeaconRegionsAt_jfieldId == IntPtr.Zero)
					mCachedBeaconRegionsAt_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedBeaconRegionsAt", "Ljava/util/Date;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCachedBeaconRegionsAt_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCachedBeaconsAt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/field[@name='mCachedBeaconsAt']"
		[Register ("mCachedBeaconsAt")]
		protected global::Java.Util.Date MCachedBeaconsAt {
			get {
				if (mCachedBeaconsAt_jfieldId == IntPtr.Zero)
					mCachedBeaconsAt_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedBeaconsAt", "Ljava/util/Date;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCachedBeaconsAt_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCachedBeaconsAt_jfieldId == IntPtr.Zero)
					mCachedBeaconsAt_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedBeaconsAt", "Ljava/util/Date;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCachedBeaconsAt_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCachedCategories_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/field[@name='mCachedCategories']"
		[Register ("mCachedCategories")]
		protected IList<Com.Bluecats.Sdk.BCCategory> MCachedCategories {
			get {
				if (mCachedCategories_jfieldId == IntPtr.Zero)
					mCachedCategories_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedCategories", "[Lcom/bluecats/sdk/BCCategory;");
				return global::Android.Runtime.JavaArray<global::Com.Bluecats.Sdk.BCCategory>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCachedCategories_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCachedCategories_jfieldId == IntPtr.Zero)
					mCachedCategories_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedCategories", "[Lcom/bluecats/sdk/BCCategory;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Bluecats.Sdk.BCCategory>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCachedCategories_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCachedCategoriesAt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/field[@name='mCachedCategoriesAt']"
		[Register ("mCachedCategoriesAt")]
		protected global::Java.Util.Date MCachedCategoriesAt {
			get {
				if (mCachedCategoriesAt_jfieldId == IntPtr.Zero)
					mCachedCategoriesAt_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedCategoriesAt", "Ljava/util/Date;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCachedCategoriesAt_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCachedCategoriesAt_jfieldId == IntPtr.Zero)
					mCachedCategoriesAt_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedCategoriesAt", "Ljava/util/Date;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCachedCategoriesAt_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCachedSitesAt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/field[@name='mCachedSitesAt']"
		[Register ("mCachedSitesAt")]
		protected global::Java.Util.Date MCachedSitesAt {
			get {
				if (mCachedSitesAt_jfieldId == IntPtr.Zero)
					mCachedSitesAt_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedSitesAt", "Ljava/util/Date;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCachedSitesAt_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCachedSitesAt_jfieldId == IntPtr.Zero)
					mCachedSitesAt_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedSitesAt", "Ljava/util/Date;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCachedSitesAt_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCachedTeamInvites_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/field[@name='mCachedTeamInvites']"
		[Register ("mCachedTeamInvites")]
		protected IList<Com.Bluecats.Sdk.BCTeamInvite> MCachedTeamInvites {
			get {
				if (mCachedTeamInvites_jfieldId == IntPtr.Zero)
					mCachedTeamInvites_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedTeamInvites", "[Lcom/bluecats/sdk/BCTeamInvite;");
				return global::Android.Runtime.JavaArray<global::Com.Bluecats.Sdk.BCTeamInvite>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCachedTeamInvites_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCachedTeamInvites_jfieldId == IntPtr.Zero)
					mCachedTeamInvites_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedTeamInvites", "[Lcom/bluecats/sdk/BCTeamInvite;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Bluecats.Sdk.BCTeamInvite>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCachedTeamInvites_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCachedTeamInvitesAt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/field[@name='mCachedTeamInvitesAt']"
		[Register ("mCachedTeamInvitesAt")]
		protected global::Java.Util.Date MCachedTeamInvitesAt {
			get {
				if (mCachedTeamInvitesAt_jfieldId == IntPtr.Zero)
					mCachedTeamInvitesAt_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedTeamInvitesAt", "Ljava/util/Date;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCachedTeamInvitesAt_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCachedTeamInvitesAt_jfieldId == IntPtr.Zero)
					mCachedTeamInvitesAt_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedTeamInvitesAt", "Ljava/util/Date;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCachedTeamInvitesAt_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCachedTeammates_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/field[@name='mCachedTeammates']"
		[Register ("mCachedTeammates")]
		protected IList<Com.Bluecats.Sdk.BCPerson> MCachedTeammates {
			get {
				if (mCachedTeammates_jfieldId == IntPtr.Zero)
					mCachedTeammates_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedTeammates", "[Lcom/bluecats/sdk/BCPerson;");
				return global::Android.Runtime.JavaArray<global::Com.Bluecats.Sdk.BCPerson>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCachedTeammates_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCachedTeammates_jfieldId == IntPtr.Zero)
					mCachedTeammates_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedTeammates", "[Lcom/bluecats/sdk/BCPerson;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Bluecats.Sdk.BCPerson>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCachedTeammates_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCachedTeammatesAt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/field[@name='mCachedTeammatesAt']"
		[Register ("mCachedTeammatesAt")]
		protected global::Java.Util.Date MCachedTeammatesAt {
			get {
				if (mCachedTeammatesAt_jfieldId == IntPtr.Zero)
					mCachedTeammatesAt_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedTeammatesAt", "Ljava/util/Date;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCachedTeammatesAt_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCachedTeammatesAt_jfieldId == IntPtr.Zero)
					mCachedTeammatesAt_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedTeammatesAt", "Ljava/util/Date;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCachedTeammatesAt_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mNumberOfBeaconsCached_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/field[@name='mNumberOfBeaconsCached']"
		[Register ("mNumberOfBeaconsCached")]
		protected global::Java.Lang.Integer MNumberOfBeaconsCached {
			get {
				if (mNumberOfBeaconsCached_jfieldId == IntPtr.Zero)
					mNumberOfBeaconsCached_jfieldId = JNIEnv.GetFieldID (class_ref, "mNumberOfBeaconsCached", "Ljava/lang/Integer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mNumberOfBeaconsCached_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mNumberOfBeaconsCached_jfieldId == IntPtr.Zero)
					mNumberOfBeaconsCached_jfieldId = JNIEnv.GetFieldID (class_ref, "mNumberOfBeaconsCached", "Ljava/lang/Integer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mNumberOfBeaconsCached_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mNumberOfSitesCached_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/field[@name='mNumberOfSitesCached']"
		[Register ("mNumberOfSitesCached")]
		protected global::Java.Lang.Integer MNumberOfSitesCached {
			get {
				if (mNumberOfSitesCached_jfieldId == IntPtr.Zero)
					mNumberOfSitesCached_jfieldId = JNIEnv.GetFieldID (class_ref, "mNumberOfSitesCached", "Ljava/lang/Integer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mNumberOfSitesCached_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mNumberOfSitesCached_jfieldId == IntPtr.Zero)
					mNumberOfSitesCached_jfieldId = JNIEnv.GetFieldID (class_ref, "mNumberOfSitesCached", "Ljava/lang/Integer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mNumberOfSitesCached_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCTeamApi", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCTeamApi); }
		}

		protected BCTeamApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/constructor[@name='BCTeamApi' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCTeamApi ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCTeamApi)) {
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

		static Delegate cb_getCachedApps;
#pragma warning disable 0169
		static Delegate GetGetCachedAppsHandler ()
		{
			if (cb_getCachedApps == null)
				cb_getCachedApps = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedApps);
			return cb_getCachedApps;
		}

		static IntPtr n_GetCachedApps (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCApp>.ToLocalJniHandle (__this.CachedApps);
		}
#pragma warning restore 0169

		static IntPtr id_getCachedApps;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCApp> CachedApps {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getCachedApps' and count(parameter)=0]"
			[Register ("getCachedApps", "()Ljava/util/List;", "GetGetCachedAppsHandler")]
			get {
				if (id_getCachedApps == IntPtr.Zero)
					id_getCachedApps = JNIEnv.GetMethodID (class_ref, "getCachedApps", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCApp>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedApps), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCApp>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedApps", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCachedAppsAt;
#pragma warning disable 0169
		static Delegate GetGetCachedAppsAtHandler ()
		{
			if (cb_getCachedAppsAt == null)
				cb_getCachedAppsAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedAppsAt);
			return cb_getCachedAppsAt;
		}

		static IntPtr n_GetCachedAppsAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CachedAppsAt);
		}
#pragma warning restore 0169

		static IntPtr id_getCachedAppsAt;
		public virtual unsafe global::Java.Util.Date CachedAppsAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getCachedAppsAt' and count(parameter)=0]"
			[Register ("getCachedAppsAt", "()Ljava/util/Date;", "GetGetCachedAppsAtHandler")]
			get {
				if (id_getCachedAppsAt == IntPtr.Zero)
					id_getCachedAppsAt = JNIEnv.GetMethodID (class_ref, "getCachedAppsAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedAppsAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedAppsAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCachedBeaconRegions;
#pragma warning disable 0169
		static Delegate GetGetCachedBeaconRegionsHandler ()
		{
			if (cb_getCachedBeaconRegions == null)
				cb_getCachedBeaconRegions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedBeaconRegions);
			return cb_getCachedBeaconRegions;
		}

		static IntPtr n_GetCachedBeaconRegions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCBeaconRegion>.ToLocalJniHandle (__this.CachedBeaconRegions);
		}
#pragma warning restore 0169

		static IntPtr id_getCachedBeaconRegions;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCBeaconRegion> CachedBeaconRegions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getCachedBeaconRegions' and count(parameter)=0]"
			[Register ("getCachedBeaconRegions", "()Ljava/util/List;", "GetGetCachedBeaconRegionsHandler")]
			get {
				if (id_getCachedBeaconRegions == IntPtr.Zero)
					id_getCachedBeaconRegions = JNIEnv.GetMethodID (class_ref, "getCachedBeaconRegions", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCBeaconRegion>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedBeaconRegions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCBeaconRegion>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedBeaconRegions", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCachedBeaconRegionsAt;
#pragma warning disable 0169
		static Delegate GetGetCachedBeaconRegionsAtHandler ()
		{
			if (cb_getCachedBeaconRegionsAt == null)
				cb_getCachedBeaconRegionsAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedBeaconRegionsAt);
			return cb_getCachedBeaconRegionsAt;
		}

		static IntPtr n_GetCachedBeaconRegionsAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CachedBeaconRegionsAt);
		}
#pragma warning restore 0169

		static IntPtr id_getCachedBeaconRegionsAt;
		public virtual unsafe global::Java.Util.Date CachedBeaconRegionsAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getCachedBeaconRegionsAt' and count(parameter)=0]"
			[Register ("getCachedBeaconRegionsAt", "()Ljava/util/Date;", "GetGetCachedBeaconRegionsAtHandler")]
			get {
				if (id_getCachedBeaconRegionsAt == IntPtr.Zero)
					id_getCachedBeaconRegionsAt = JNIEnv.GetMethodID (class_ref, "getCachedBeaconRegionsAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedBeaconRegionsAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedBeaconRegionsAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.IBCBeacon>.ToLocalJniHandle (__this.CachedBeacons);
		}
#pragma warning restore 0169

		static IntPtr id_getCachedBeacons;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.IBCBeacon> CachedBeacons {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getCachedBeacons' and count(parameter)=0]"
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
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CachedBeaconsAt);
		}
#pragma warning restore 0169

		static IntPtr id_getCachedBeaconsAt;
		public virtual unsafe global::Java.Util.Date CachedBeaconsAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getCachedBeaconsAt' and count(parameter)=0]"
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
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCCategory>.ToLocalJniHandle (__this.CachedCategories);
		}
#pragma warning restore 0169

		static IntPtr id_getCachedCategories;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCCategory> CachedCategories {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getCachedCategories' and count(parameter)=0]"
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
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CachedCategoriesAt);
		}
#pragma warning restore 0169

		static IntPtr id_getCachedCategoriesAt;
		public virtual unsafe global::Java.Util.Date CachedCategoriesAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getCachedCategoriesAt' and count(parameter)=0]"
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
		}

		static Delegate cb_getCachedSites;
#pragma warning disable 0169
		static Delegate GetGetCachedSitesHandler ()
		{
			if (cb_getCachedSites == null)
				cb_getCachedSites = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedSites);
			return cb_getCachedSites;
		}

		static IntPtr n_GetCachedSites (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCSiteInternal>.ToLocalJniHandle (__this.CachedSites);
		}
#pragma warning restore 0169

		static IntPtr id_getCachedSites;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCSiteInternal> CachedSites {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getCachedSites' and count(parameter)=0]"
			[Register ("getCachedSites", "()Ljava/util/List;", "GetGetCachedSitesHandler")]
			get {
				if (id_getCachedSites == IntPtr.Zero)
					id_getCachedSites = JNIEnv.GetMethodID (class_ref, "getCachedSites", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCSiteInternal>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedSites), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCSiteInternal>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedSites", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCachedSitesAt;
#pragma warning disable 0169
		static Delegate GetGetCachedSitesAtHandler ()
		{
			if (cb_getCachedSitesAt == null)
				cb_getCachedSitesAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedSitesAt);
			return cb_getCachedSitesAt;
		}

		static IntPtr n_GetCachedSitesAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CachedSitesAt);
		}
#pragma warning restore 0169

		static IntPtr id_getCachedSitesAt;
		public virtual unsafe global::Java.Util.Date CachedSitesAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getCachedSitesAt' and count(parameter)=0]"
			[Register ("getCachedSitesAt", "()Ljava/util/Date;", "GetGetCachedSitesAtHandler")]
			get {
				if (id_getCachedSitesAt == IntPtr.Zero)
					id_getCachedSitesAt = JNIEnv.GetMethodID (class_ref, "getCachedSitesAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedSitesAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedSitesAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCachedTeamInvites;
#pragma warning disable 0169
		static Delegate GetGetCachedTeamInvitesHandler ()
		{
			if (cb_getCachedTeamInvites == null)
				cb_getCachedTeamInvites = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedTeamInvites);
			return cb_getCachedTeamInvites;
		}

		static IntPtr n_GetCachedTeamInvites (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCTeamInvite>.ToLocalJniHandle (__this.CachedTeamInvites);
		}
#pragma warning restore 0169

		static IntPtr id_getCachedTeamInvites;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCTeamInvite> CachedTeamInvites {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getCachedTeamInvites' and count(parameter)=0]"
			[Register ("getCachedTeamInvites", "()Ljava/util/List;", "GetGetCachedTeamInvitesHandler")]
			get {
				if (id_getCachedTeamInvites == IntPtr.Zero)
					id_getCachedTeamInvites = JNIEnv.GetMethodID (class_ref, "getCachedTeamInvites", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCTeamInvite>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedTeamInvites), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCTeamInvite>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedTeamInvites", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCachedTeamInvitesAt;
#pragma warning disable 0169
		static Delegate GetGetCachedTeamInvitesAtHandler ()
		{
			if (cb_getCachedTeamInvitesAt == null)
				cb_getCachedTeamInvitesAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedTeamInvitesAt);
			return cb_getCachedTeamInvitesAt;
		}

		static IntPtr n_GetCachedTeamInvitesAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CachedTeamInvitesAt);
		}
#pragma warning restore 0169

		static IntPtr id_getCachedTeamInvitesAt;
		public virtual unsafe global::Java.Util.Date CachedTeamInvitesAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getCachedTeamInvitesAt' and count(parameter)=0]"
			[Register ("getCachedTeamInvitesAt", "()Ljava/util/Date;", "GetGetCachedTeamInvitesAtHandler")]
			get {
				if (id_getCachedTeamInvitesAt == IntPtr.Zero)
					id_getCachedTeamInvitesAt = JNIEnv.GetMethodID (class_ref, "getCachedTeamInvitesAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedTeamInvitesAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedTeamInvitesAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCachedTeammates;
#pragma warning disable 0169
		static Delegate GetGetCachedTeammatesHandler ()
		{
			if (cb_getCachedTeammates == null)
				cb_getCachedTeammates = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedTeammates);
			return cb_getCachedTeammates;
		}

		static IntPtr n_GetCachedTeammates (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCPerson>.ToLocalJniHandle (__this.CachedTeammates);
		}
#pragma warning restore 0169

		static IntPtr id_getCachedTeammates;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCPerson> CachedTeammates {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getCachedTeammates' and count(parameter)=0]"
			[Register ("getCachedTeammates", "()Ljava/util/List;", "GetGetCachedTeammatesHandler")]
			get {
				if (id_getCachedTeammates == IntPtr.Zero)
					id_getCachedTeammates = JNIEnv.GetMethodID (class_ref, "getCachedTeammates", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCPerson>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedTeammates), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCPerson>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedTeammates", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCachedTeammatesAt;
#pragma warning disable 0169
		static Delegate GetGetCachedTeammatesAtHandler ()
		{
			if (cb_getCachedTeammatesAt == null)
				cb_getCachedTeammatesAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedTeammatesAt);
			return cb_getCachedTeammatesAt;
		}

		static IntPtr n_GetCachedTeammatesAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CachedTeammatesAt);
		}
#pragma warning restore 0169

		static IntPtr id_getCachedTeammatesAt;
		public virtual unsafe global::Java.Util.Date CachedTeammatesAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getCachedTeammatesAt' and count(parameter)=0]"
			[Register ("getCachedTeammatesAt", "()Ljava/util/Date;", "GetGetCachedTeammatesAtHandler")]
			get {
				if (id_getCachedTeammatesAt == IntPtr.Zero)
					id_getCachedTeammatesAt = JNIEnv.GetMethodID (class_ref, "getCachedTeammatesAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedTeammatesAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedTeammatesAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasAppsCacheExpired;
#pragma warning disable 0169
		static Delegate GetHasAppsCacheExpiredHandler ()
		{
			if (cb_hasAppsCacheExpired == null)
				cb_hasAppsCacheExpired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasAppsCacheExpired);
			return cb_hasAppsCacheExpired;
		}

		static bool n_HasAppsCacheExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasAppsCacheExpired;
		}
#pragma warning restore 0169

		static IntPtr id_hasAppsCacheExpired;
		public virtual unsafe bool HasAppsCacheExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='hasAppsCacheExpired' and count(parameter)=0]"
			[Register ("hasAppsCacheExpired", "()Z", "GetHasAppsCacheExpiredHandler")]
			get {
				if (id_hasAppsCacheExpired == IntPtr.Zero)
					id_hasAppsCacheExpired = JNIEnv.GetMethodID (class_ref, "hasAppsCacheExpired", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasAppsCacheExpired);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasAppsCacheExpired", "()Z"));
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
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBeaconsCacheExpired;
		}
#pragma warning restore 0169

		static IntPtr id_hasBeaconsCacheExpired;
		public virtual unsafe bool HasBeaconsCacheExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='hasBeaconsCacheExpired' and count(parameter)=0]"
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

		static Delegate cb_hasCachedBeaconRegionsCacheExpired;
#pragma warning disable 0169
		static Delegate GetHasCachedBeaconRegionsCacheExpiredHandler ()
		{
			if (cb_hasCachedBeaconRegionsCacheExpired == null)
				cb_hasCachedBeaconRegionsCacheExpired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasCachedBeaconRegionsCacheExpired);
			return cb_hasCachedBeaconRegionsCacheExpired;
		}

		static bool n_HasCachedBeaconRegionsCacheExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasCachedBeaconRegionsCacheExpired;
		}
#pragma warning restore 0169

		static IntPtr id_hasCachedBeaconRegionsCacheExpired;
		public virtual unsafe bool HasCachedBeaconRegionsCacheExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='hasCachedBeaconRegionsCacheExpired' and count(parameter)=0]"
			[Register ("hasCachedBeaconRegionsCacheExpired", "()Z", "GetHasCachedBeaconRegionsCacheExpiredHandler")]
			get {
				if (id_hasCachedBeaconRegionsCacheExpired == IntPtr.Zero)
					id_hasCachedBeaconRegionsCacheExpired = JNIEnv.GetMethodID (class_ref, "hasCachedBeaconRegionsCacheExpired", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasCachedBeaconRegionsCacheExpired);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasCachedBeaconRegionsCacheExpired", "()Z"));
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
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasCategoriesCacheExpired;
		}
#pragma warning restore 0169

		static IntPtr id_hasCategoriesCacheExpired;
		public virtual unsafe bool HasCategoriesCacheExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='hasCategoriesCacheExpired' and count(parameter)=0]"
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

		static Delegate cb_hasSitesCacheExpired;
#pragma warning disable 0169
		static Delegate GetHasSitesCacheExpiredHandler ()
		{
			if (cb_hasSitesCacheExpired == null)
				cb_hasSitesCacheExpired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasSitesCacheExpired);
			return cb_hasSitesCacheExpired;
		}

		static bool n_HasSitesCacheExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasSitesCacheExpired;
		}
#pragma warning restore 0169

		static IntPtr id_hasSitesCacheExpired;
		public virtual unsafe bool HasSitesCacheExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='hasSitesCacheExpired' and count(parameter)=0]"
			[Register ("hasSitesCacheExpired", "()Z", "GetHasSitesCacheExpiredHandler")]
			get {
				if (id_hasSitesCacheExpired == IntPtr.Zero)
					id_hasSitesCacheExpired = JNIEnv.GetMethodID (class_ref, "hasSitesCacheExpired", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasSitesCacheExpired);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasSitesCacheExpired", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_hasTeamInvitesCacheExpired;
#pragma warning disable 0169
		static Delegate GetHasTeamInvitesCacheExpiredHandler ()
		{
			if (cb_hasTeamInvitesCacheExpired == null)
				cb_hasTeamInvitesCacheExpired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasTeamInvitesCacheExpired);
			return cb_hasTeamInvitesCacheExpired;
		}

		static bool n_HasTeamInvitesCacheExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasTeamInvitesCacheExpired;
		}
#pragma warning restore 0169

		static IntPtr id_hasTeamInvitesCacheExpired;
		public virtual unsafe bool HasTeamInvitesCacheExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='hasTeamInvitesCacheExpired' and count(parameter)=0]"
			[Register ("hasTeamInvitesCacheExpired", "()Z", "GetHasTeamInvitesCacheExpiredHandler")]
			get {
				if (id_hasTeamInvitesCacheExpired == IntPtr.Zero)
					id_hasTeamInvitesCacheExpired = JNIEnv.GetMethodID (class_ref, "hasTeamInvitesCacheExpired", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasTeamInvitesCacheExpired);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasTeamInvitesCacheExpired", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_hasTeammatesCacheExpired;
#pragma warning disable 0169
		static Delegate GetHasTeammatesCacheExpiredHandler ()
		{
			if (cb_hasTeammatesCacheExpired == null)
				cb_hasTeammatesCacheExpired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasTeammatesCacheExpired);
			return cb_hasTeammatesCacheExpired;
		}

		static bool n_HasTeammatesCacheExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasTeammatesCacheExpired;
		}
#pragma warning restore 0169

		static IntPtr id_hasTeammatesCacheExpired;
		public virtual unsafe bool HasTeammatesCacheExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='hasTeammatesCacheExpired' and count(parameter)=0]"
			[Register ("hasTeammatesCacheExpired", "()Z", "GetHasTeammatesCacheExpiredHandler")]
			get {
				if (id_hasTeammatesCacheExpired == IntPtr.Zero)
					id_hasTeammatesCacheExpired = JNIEnv.GetMethodID (class_ref, "hasTeammatesCacheExpired", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasTeammatesCacheExpired);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasTeammatesCacheExpired", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getNumberOfBeaconsCached;
#pragma warning disable 0169
		static Delegate GetGetNumberOfBeaconsCachedHandler ()
		{
			if (cb_getNumberOfBeaconsCached == null)
				cb_getNumberOfBeaconsCached = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNumberOfBeaconsCached);
			return cb_getNumberOfBeaconsCached;
		}

		static IntPtr n_GetNumberOfBeaconsCached (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NumberOfBeaconsCached);
		}
#pragma warning restore 0169

		static IntPtr id_getNumberOfBeaconsCached;
		public virtual unsafe global::Java.Lang.Integer NumberOfBeaconsCached {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getNumberOfBeaconsCached' and count(parameter)=0]"
			[Register ("getNumberOfBeaconsCached", "()Ljava/lang/Integer;", "GetGetNumberOfBeaconsCachedHandler")]
			get {
				if (id_getNumberOfBeaconsCached == IntPtr.Zero)
					id_getNumberOfBeaconsCached = JNIEnv.GetMethodID (class_ref, "getNumberOfBeaconsCached", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNumberOfBeaconsCached), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumberOfBeaconsCached", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNumberOfSitesCached;
#pragma warning disable 0169
		static Delegate GetGetNumberOfSitesCachedHandler ()
		{
			if (cb_getNumberOfSitesCached == null)
				cb_getNumberOfSitesCached = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNumberOfSitesCached);
			return cb_getNumberOfSitesCached;
		}

		static IntPtr n_GetNumberOfSitesCached (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NumberOfSitesCached);
		}
#pragma warning restore 0169

		static IntPtr id_getNumberOfSitesCached;
		public virtual unsafe global::Java.Lang.Integer NumberOfSitesCached {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getNumberOfSitesCached' and count(parameter)=0]"
			[Register ("getNumberOfSitesCached", "()Ljava/lang/Integer;", "GetGetNumberOfSitesCachedHandler")]
			get {
				if (id_getNumberOfSitesCached == IntPtr.Zero)
					id_getNumberOfSitesCached = JNIEnv.GetMethodID (class_ref, "getNumberOfSitesCached", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNumberOfSitesCached), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNumberOfSitesCached", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSiteCount;
#pragma warning disable 0169
		static Delegate GetGetSiteCountHandler ()
		{
			if (cb_getSiteCount == null)
				cb_getSiteCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSiteCount);
			return cb_getSiteCount;
		}

		static IntPtr n_GetSiteCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SiteCount);
		}
#pragma warning restore 0169

		static Delegate cb_setSiteCount_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetSiteCount_Ljava_lang_Integer_Handler ()
		{
			if (cb_setSiteCount_Ljava_lang_Integer_ == null)
				cb_setSiteCount_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSiteCount_Ljava_lang_Integer_);
			return cb_setSiteCount_Ljava_lang_Integer_;
		}

		static void n_SetSiteCount_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer value = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SiteCount = value;
		}
#pragma warning restore 0169

		static IntPtr id_getSiteCount;
		static IntPtr id_setSiteCount_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer SiteCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getSiteCount' and count(parameter)=0]"
			[Register ("getSiteCount", "()Ljava/lang/Integer;", "GetGetSiteCountHandler")]
			get {
				if (id_getSiteCount == IntPtr.Zero)
					id_getSiteCount = JNIEnv.GetMethodID (class_ref, "getSiteCount", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSiteCount), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSiteCount", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='setSiteCount' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setSiteCount", "(Ljava/lang/Integer;)V", "GetSetSiteCount_Ljava_lang_Integer_Handler")]
			set {
				if (id_setSiteCount_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setSiteCount_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setSiteCount", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSiteCount_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSiteCount", "(Ljava/lang/Integer;)V"), __args);
				} finally {
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
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.TeamID = value;
		}
#pragma warning restore 0169

		static IntPtr id_getTeamID;
		static IntPtr id_setTeamID_Ljava_lang_String_;
		public virtual unsafe string TeamID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getTeamID' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='setTeamID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_createApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_;
#pragma warning disable 0169
		static Delegate GetCreateApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_Handler ()
		{
			if (cb_createApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_ == null)
				cb_createApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_);
			return cb_createApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_;
		}

		static void n_CreateApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_app2, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCApp app2 = (global::Com.Bluecats.Sdk.IBCApp)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (native_app2, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCTeamCallback @callback = (global::Com.Bluecats.Sdk.IBCTeamCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.CreateApp (app2, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_createApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='createApp' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCApp'] and parameter[2][@type='com.bluecats.sdk.BCTeamCallback']]"
		[Register ("createApp", "(Lcom/bluecats/sdk/BCApp;Lcom/bluecats/sdk/BCTeamCallback;)V", "GetCreateApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_Handler")]
		public virtual unsafe void CreateApp (global::Com.Bluecats.Sdk.IBCApp app2, global::Com.Bluecats.Sdk.IBCTeamCallback @callback)
		{
			if (id_createApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_ == IntPtr.Zero)
				id_createApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_ = JNIEnv.GetMethodID (class_ref, "createApp", "(Lcom/bluecats/sdk/BCApp;Lcom/bluecats/sdk/BCTeamCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (app2);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createApp", "(Lcom/bluecats/sdk/BCApp;Lcom/bluecats/sdk/BCTeamCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_createCategories_Ljava_util_List_Lcom_bluecats_sdk_BCTeamCallback_;
#pragma warning disable 0169
		static Delegate GetCreateCategories_Ljava_util_List_Lcom_bluecats_sdk_BCTeamCallback_Handler ()
		{
			if (cb_createCategories_Ljava_util_List_Lcom_bluecats_sdk_BCTeamCallback_ == null)
				cb_createCategories_Ljava_util_List_Lcom_bluecats_sdk_BCTeamCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateCategories_Ljava_util_List_Lcom_bluecats_sdk_BCTeamCallback_);
			return cb_createCategories_Ljava_util_List_Lcom_bluecats_sdk_BCTeamCallback_;
		}

		static void n_CreateCategories_Ljava_util_List_Lcom_bluecats_sdk_BCTeamCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_categories, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var categories = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCCategory>.FromJniHandle (native_categories, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCTeamCallback @callback = (global::Com.Bluecats.Sdk.IBCTeamCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.CreateCategories (categories, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_createCategories_Ljava_util_List_Lcom_bluecats_sdk_BCTeamCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='createCategories' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCCategory&gt;'] and parameter[2][@type='com.bluecats.sdk.BCTeamCallback']]"
		[Register ("createCategories", "(Ljava/util/List;Lcom/bluecats/sdk/BCTeamCallback;)V", "GetCreateCategories_Ljava_util_List_Lcom_bluecats_sdk_BCTeamCallback_Handler")]
		public virtual unsafe void CreateCategories (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCCategory> categories, global::Com.Bluecats.Sdk.IBCTeamCallback @callback)
		{
			if (id_createCategories_Ljava_util_List_Lcom_bluecats_sdk_BCTeamCallback_ == IntPtr.Zero)
				id_createCategories_Ljava_util_List_Lcom_bluecats_sdk_BCTeamCallback_ = JNIEnv.GetMethodID (class_ref, "createCategories", "(Ljava/util/List;Lcom/bluecats/sdk/BCTeamCallback;)V");
			IntPtr native_categories = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCCategory>.ToLocalJniHandle (categories);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_categories);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createCategories_Ljava_util_List_Lcom_bluecats_sdk_BCTeamCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createCategories", "(Ljava/util/List;Lcom/bluecats/sdk/BCTeamCallback;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_categories);
			}
		}

		static Delegate cb_createCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_;
#pragma warning disable 0169
		static Delegate GetCreateCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_Handler ()
		{
			if (cb_createCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_ == null)
				cb_createCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_);
			return cb_createCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_;
		}

		static void n_CreateCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_category, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCCategory category = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategory> (native_category, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCTeamCallback @callback = (global::Com.Bluecats.Sdk.IBCTeamCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.CreateCategory (category, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_createCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='createCategory' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCCategory'] and parameter[2][@type='com.bluecats.sdk.BCTeamCallback']]"
		[Register ("createCategory", "(Lcom/bluecats/sdk/BCCategory;Lcom/bluecats/sdk/BCTeamCallback;)V", "GetCreateCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_Handler")]
		public virtual unsafe void CreateCategory (global::Com.Bluecats.Sdk.BCCategory category, global::Com.Bluecats.Sdk.IBCTeamCallback @callback)
		{
			if (id_createCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_ == IntPtr.Zero)
				id_createCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_ = JNIEnv.GetMethodID (class_ref, "createCategory", "(Lcom/bluecats/sdk/BCCategory;Lcom/bluecats/sdk/BCTeamCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (category);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createCategory", "(Lcom/bluecats/sdk/BCCategory;Lcom/bluecats/sdk/BCTeamCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_createSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_;
#pragma warning disable 0169
		static Delegate GetCreateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_Handler ()
		{
			if (cb_createSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_ == null)
				cb_createSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_);
			return cb_createSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_;
		}

		static void n_CreateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_site, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite site = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_site, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCTeamCallback @callback = (global::Com.Bluecats.Sdk.IBCTeamCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.CreateSite (site, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_createSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='createSite' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCSite'] and parameter[2][@type='com.bluecats.sdk.BCTeamCallback']]"
		[Register ("createSite", "(Lcom/bluecats/sdk/BCSite;Lcom/bluecats/sdk/BCTeamCallback;)V", "GetCreateSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_Handler")]
		public virtual unsafe void CreateSite (global::Com.Bluecats.Sdk.IBCSite site, global::Com.Bluecats.Sdk.IBCTeamCallback @callback)
		{
			if (id_createSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_ == IntPtr.Zero)
				id_createSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_ = JNIEnv.GetMethodID (class_ref, "createSite", "(Lcom/bluecats/sdk/BCSite;Lcom/bluecats/sdk/BCTeamCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (site);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createSite", "(Lcom/bluecats/sdk/BCSite;Lcom/bluecats/sdk/BCTeamCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deleteApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_;
#pragma warning disable 0169
		static Delegate GetDeleteApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_Handler ()
		{
			if (cb_deleteApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_ == null)
				cb_deleteApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_);
			return cb_deleteApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_;
		}

		static void n_DeleteApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_app2, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCApp app2 = (global::Com.Bluecats.Sdk.IBCApp)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCApp> (native_app2, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCTeamCallback @callback = (global::Com.Bluecats.Sdk.IBCTeamCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.DeleteApp (app2, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_deleteApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='deleteApp' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCApp'] and parameter[2][@type='com.bluecats.sdk.BCTeamCallback']]"
		[Register ("deleteApp", "(Lcom/bluecats/sdk/BCApp;Lcom/bluecats/sdk/BCTeamCallback;)V", "GetDeleteApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_Handler")]
		public virtual unsafe void DeleteApp (global::Com.Bluecats.Sdk.IBCApp app2, global::Com.Bluecats.Sdk.IBCTeamCallback @callback)
		{
			if (id_deleteApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_ == IntPtr.Zero)
				id_deleteApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_ = JNIEnv.GetMethodID (class_ref, "deleteApp", "(Lcom/bluecats/sdk/BCApp;Lcom/bluecats/sdk/BCTeamCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (app2);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteApp_Lcom_bluecats_sdk_BCApp_Lcom_bluecats_sdk_BCTeamCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteApp", "(Lcom/bluecats/sdk/BCApp;Lcom/bluecats/sdk/BCTeamCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deleteCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_;
#pragma warning disable 0169
		static Delegate GetDeleteCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_Handler ()
		{
			if (cb_deleteCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_ == null)
				cb_deleteCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_);
			return cb_deleteCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_;
		}

		static void n_DeleteCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_category, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCCategory category = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCCategory> (native_category, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCTeamCallback @callback = (global::Com.Bluecats.Sdk.IBCTeamCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.DeleteCategory (category, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_deleteCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='deleteCategory' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCCategory'] and parameter[2][@type='com.bluecats.sdk.BCTeamCallback']]"
		[Register ("deleteCategory", "(Lcom/bluecats/sdk/BCCategory;Lcom/bluecats/sdk/BCTeamCallback;)V", "GetDeleteCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_Handler")]
		public virtual unsafe void DeleteCategory (global::Com.Bluecats.Sdk.BCCategory category, global::Com.Bluecats.Sdk.IBCTeamCallback @callback)
		{
			if (id_deleteCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_ == IntPtr.Zero)
				id_deleteCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_ = JNIEnv.GetMethodID (class_ref, "deleteCategory", "(Lcom/bluecats/sdk/BCCategory;Lcom/bluecats/sdk/BCTeamCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (category);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteCategory_Lcom_bluecats_sdk_BCCategory_Lcom_bluecats_sdk_BCTeamCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteCategory", "(Lcom/bluecats/sdk/BCCategory;Lcom/bluecats/sdk/BCTeamCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deleteSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_;
#pragma warning disable 0169
		static Delegate GetDeleteSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_Handler ()
		{
			if (cb_deleteSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_ == null)
				cb_deleteSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_);
			return cb_deleteSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_;
		}

		static void n_DeleteSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_site, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite site = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_site, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCTeamCallback @callback = (global::Com.Bluecats.Sdk.IBCTeamCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.DeleteSite (site, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_deleteSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='deleteSite' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCSite'] and parameter[2][@type='com.bluecats.sdk.BCTeamCallback']]"
		[Register ("deleteSite", "(Lcom/bluecats/sdk/BCSite;Lcom/bluecats/sdk/BCTeamCallback;)V", "GetDeleteSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_Handler")]
		public virtual unsafe void DeleteSite (global::Com.Bluecats.Sdk.IBCSite site, global::Com.Bluecats.Sdk.IBCTeamCallback @callback)
		{
			if (id_deleteSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_ == IntPtr.Zero)
				id_deleteSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_ = JNIEnv.GetMethodID (class_ref, "deleteSite", "(Lcom/bluecats/sdk/BCSite;Lcom/bluecats/sdk/BCTeamCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (site);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteSite_Lcom_bluecats_sdk_BCSite_Lcom_bluecats_sdk_BCTeamCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteSite", "(Lcom/bluecats/sdk/BCSite;Lcom/bluecats/sdk/BCTeamCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getAlertsFromDate_Ljava_util_Date_Ljava_util_Date_Lcom_bluecats_sdk_BCTeamCallback_;
#pragma warning disable 0169
		static Delegate GetGetAlertsFromDate_Ljava_util_Date_Ljava_util_Date_Lcom_bluecats_sdk_BCTeamCallback_Handler ()
		{
			if (cb_getAlertsFromDate_Ljava_util_Date_Ljava_util_Date_Lcom_bluecats_sdk_BCTeamCallback_ == null)
				cb_getAlertsFromDate_Ljava_util_Date_Ljava_util_Date_Lcom_bluecats_sdk_BCTeamCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAlertsFromDate_Ljava_util_Date_Ljava_util_Date_Lcom_bluecats_sdk_BCTeamCallback_);
			return cb_getAlertsFromDate_Ljava_util_Date_Ljava_util_Date_Lcom_bluecats_sdk_BCTeamCallback_;
		}

		static void n_GetAlertsFromDate_Ljava_util_Date_Ljava_util_Date_Lcom_bluecats_sdk_BCTeamCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fromDate, IntPtr native_toDate, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date fromDate = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_fromDate, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date toDate = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_toDate, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCTeamCallback @callback = (global::Com.Bluecats.Sdk.IBCTeamCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetAlertsFromDate (fromDate, toDate, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_getAlertsFromDate_Ljava_util_Date_Ljava_util_Date_Lcom_bluecats_sdk_BCTeamCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getAlertsFromDate' and count(parameter)=3 and parameter[1][@type='java.util.Date'] and parameter[2][@type='java.util.Date'] and parameter[3][@type='com.bluecats.sdk.BCTeamCallback']]"
		[Register ("getAlertsFromDate", "(Ljava/util/Date;Ljava/util/Date;Lcom/bluecats/sdk/BCTeamCallback;)V", "GetGetAlertsFromDate_Ljava_util_Date_Ljava_util_Date_Lcom_bluecats_sdk_BCTeamCallback_Handler")]
		public virtual unsafe void GetAlertsFromDate (global::Java.Util.Date fromDate, global::Java.Util.Date toDate, global::Com.Bluecats.Sdk.IBCTeamCallback @callback)
		{
			if (id_getAlertsFromDate_Ljava_util_Date_Ljava_util_Date_Lcom_bluecats_sdk_BCTeamCallback_ == IntPtr.Zero)
				id_getAlertsFromDate_Ljava_util_Date_Ljava_util_Date_Lcom_bluecats_sdk_BCTeamCallback_ = JNIEnv.GetMethodID (class_ref, "getAlertsFromDate", "(Ljava/util/Date;Ljava/util/Date;Lcom/bluecats/sdk/BCTeamCallback;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (fromDate);
				__args [1] = new JValue (toDate);
				__args [2] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getAlertsFromDate_Ljava_util_Date_Ljava_util_Date_Lcom_bluecats_sdk_BCTeamCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAlertsFromDate", "(Ljava/util/Date;Ljava/util/Date;Lcom/bluecats/sdk/BCTeamCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getApps_ZLcom_bluecats_sdk_BCTeamCallback_;
#pragma warning disable 0169
		static Delegate GetGetApps_ZLcom_bluecats_sdk_BCTeamCallback_Handler ()
		{
			if (cb_getApps_ZLcom_bluecats_sdk_BCTeamCallback_ == null)
				cb_getApps_ZLcom_bluecats_sdk_BCTeamCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_GetApps_ZLcom_bluecats_sdk_BCTeamCallback_);
			return cb_getApps_ZLcom_bluecats_sdk_BCTeamCallback_;
		}

		static void n_GetApps_ZLcom_bluecats_sdk_BCTeamCallback_ (IntPtr jnienv, IntPtr native__this, bool preferCached, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCTeamCallback @callback = (global::Com.Bluecats.Sdk.IBCTeamCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetApps (preferCached, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_getApps_ZLcom_bluecats_sdk_BCTeamCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getApps' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.bluecats.sdk.BCTeamCallback']]"
		[Register ("getApps", "(ZLcom/bluecats/sdk/BCTeamCallback;)V", "GetGetApps_ZLcom_bluecats_sdk_BCTeamCallback_Handler")]
		public virtual unsafe void GetApps (bool preferCached, global::Com.Bluecats.Sdk.IBCTeamCallback @callback)
		{
			if (id_getApps_ZLcom_bluecats_sdk_BCTeamCallback_ == IntPtr.Zero)
				id_getApps_ZLcom_bluecats_sdk_BCTeamCallback_ = JNIEnv.GetMethodID (class_ref, "getApps", "(ZLcom/bluecats/sdk/BCTeamCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (preferCached);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getApps_ZLcom_bluecats_sdk_BCTeamCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApps", "(ZLcom/bluecats/sdk/BCTeamCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getBeacons_ZLcom_bluecats_sdk_BCTeamCallback_;
#pragma warning disable 0169
		static Delegate GetGetBeacons_ZLcom_bluecats_sdk_BCTeamCallback_Handler ()
		{
			if (cb_getBeacons_ZLcom_bluecats_sdk_BCTeamCallback_ == null)
				cb_getBeacons_ZLcom_bluecats_sdk_BCTeamCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_GetBeacons_ZLcom_bluecats_sdk_BCTeamCallback_);
			return cb_getBeacons_ZLcom_bluecats_sdk_BCTeamCallback_;
		}

		static void n_GetBeacons_ZLcom_bluecats_sdk_BCTeamCallback_ (IntPtr jnienv, IntPtr native__this, bool preferCached, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCTeamCallback @callback = (global::Com.Bluecats.Sdk.IBCTeamCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetBeacons (preferCached, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_getBeacons_ZLcom_bluecats_sdk_BCTeamCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getBeacons' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.bluecats.sdk.BCTeamCallback']]"
		[Register ("getBeacons", "(ZLcom/bluecats/sdk/BCTeamCallback;)V", "GetGetBeacons_ZLcom_bluecats_sdk_BCTeamCallback_Handler")]
		public virtual unsafe void GetBeacons (bool preferCached, global::Com.Bluecats.Sdk.IBCTeamCallback @callback)
		{
			if (id_getBeacons_ZLcom_bluecats_sdk_BCTeamCallback_ == IntPtr.Zero)
				id_getBeacons_ZLcom_bluecats_sdk_BCTeamCallback_ = JNIEnv.GetMethodID (class_ref, "getBeacons", "(ZLcom/bluecats/sdk/BCTeamCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (preferCached);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getBeacons_ZLcom_bluecats_sdk_BCTeamCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeacons", "(ZLcom/bluecats/sdk/BCTeamCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getCachedSiteWithSiteID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCachedSiteWithSiteID_Ljava_lang_String_Handler ()
		{
			if (cb_getCachedSiteWithSiteID_Ljava_lang_String_ == null)
				cb_getCachedSiteWithSiteID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCachedSiteWithSiteID_Ljava_lang_String_);
			return cb_getCachedSiteWithSiteID_Ljava_lang_String_;
		}

		static IntPtr n_GetCachedSiteWithSiteID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_siteID)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string siteID = JNIEnv.GetString (native_siteID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCachedSiteWithSiteID (siteID));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getCachedSiteWithSiteID_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getCachedSiteWithSiteID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCachedSiteWithSiteID", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetCachedSiteWithSiteID_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object GetCachedSiteWithSiteID (string siteID)
		{
			if (id_getCachedSiteWithSiteID_Ljava_lang_String_ == IntPtr.Zero)
				id_getCachedSiteWithSiteID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCachedSiteWithSiteID", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_siteID = JNIEnv.NewString (siteID);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_siteID);

				global::Java.Lang.Object __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedSiteWithSiteID_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedSiteWithSiteID", "(Ljava/lang/String;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_siteID);
			}
		}

		static Delegate cb_getCategories_ZLcom_bluecats_sdk_BCTeamCallback_;
#pragma warning disable 0169
		static Delegate GetGetCategories_ZLcom_bluecats_sdk_BCTeamCallback_Handler ()
		{
			if (cb_getCategories_ZLcom_bluecats_sdk_BCTeamCallback_ == null)
				cb_getCategories_ZLcom_bluecats_sdk_BCTeamCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_GetCategories_ZLcom_bluecats_sdk_BCTeamCallback_);
			return cb_getCategories_ZLcom_bluecats_sdk_BCTeamCallback_;
		}

		static void n_GetCategories_ZLcom_bluecats_sdk_BCTeamCallback_ (IntPtr jnienv, IntPtr native__this, bool preferCached, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCTeamCallback @callback = (global::Com.Bluecats.Sdk.IBCTeamCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetCategories (preferCached, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_getCategories_ZLcom_bluecats_sdk_BCTeamCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getCategories' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.bluecats.sdk.BCTeamCallback']]"
		[Register ("getCategories", "(ZLcom/bluecats/sdk/BCTeamCallback;)V", "GetGetCategories_ZLcom_bluecats_sdk_BCTeamCallback_Handler")]
		public virtual unsafe void GetCategories (bool preferCached, global::Com.Bluecats.Sdk.IBCTeamCallback @callback)
		{
			if (id_getCategories_ZLcom_bluecats_sdk_BCTeamCallback_ == IntPtr.Zero)
				id_getCategories_ZLcom_bluecats_sdk_BCTeamCallback_ = JNIEnv.GetMethodID (class_ref, "getCategories", "(ZLcom/bluecats/sdk/BCTeamCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (preferCached);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getCategories_ZLcom_bluecats_sdk_BCTeamCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCategories", "(ZLcom/bluecats/sdk/BCTeamCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getSites_ZLcom_bluecats_sdk_BCTeamCallback_;
#pragma warning disable 0169
		static Delegate GetGetSites_ZLcom_bluecats_sdk_BCTeamCallback_Handler ()
		{
			if (cb_getSites_ZLcom_bluecats_sdk_BCTeamCallback_ == null)
				cb_getSites_ZLcom_bluecats_sdk_BCTeamCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_GetSites_ZLcom_bluecats_sdk_BCTeamCallback_);
			return cb_getSites_ZLcom_bluecats_sdk_BCTeamCallback_;
		}

		static void n_GetSites_ZLcom_bluecats_sdk_BCTeamCallback_ (IntPtr jnienv, IntPtr native__this, bool preferCached, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCTeamCallback @callback = (global::Com.Bluecats.Sdk.IBCTeamCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetSites (preferCached, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_getSites_ZLcom_bluecats_sdk_BCTeamCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getSites' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.bluecats.sdk.BCTeamCallback']]"
		[Register ("getSites", "(ZLcom/bluecats/sdk/BCTeamCallback;)V", "GetGetSites_ZLcom_bluecats_sdk_BCTeamCallback_Handler")]
		public virtual unsafe void GetSites (bool preferCached, global::Com.Bluecats.Sdk.IBCTeamCallback @callback)
		{
			if (id_getSites_ZLcom_bluecats_sdk_BCTeamCallback_ == IntPtr.Zero)
				id_getSites_ZLcom_bluecats_sdk_BCTeamCallback_ = JNIEnv.GetMethodID (class_ref, "getSites", "(ZLcom/bluecats/sdk/BCTeamCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (preferCached);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getSites_ZLcom_bluecats_sdk_BCTeamCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSites", "(ZLcom/bluecats/sdk/BCTeamCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getTeamInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCTeamCallback_;
#pragma warning disable 0169
		static Delegate GetGetTeamInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCTeamCallback_Handler ()
		{
			if (cb_getTeamInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCTeamCallback_ == null)
				cb_getTeamInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCTeamCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long, IntPtr>) n_GetTeamInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCTeamCallback_);
			return cb_getTeamInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCTeamCallback_;
		}

		static void n_GetTeamInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCTeamCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_endDate, IntPtr native_period, long duration, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date endDate = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_endDate, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod period = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod> (native_period, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCTeamCallback @callback = (global::Com.Bluecats.Sdk.IBCTeamCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetTeamInsightsForEndDate (endDate, period, duration, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_getTeamInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCTeamCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getTeamInsightsForEndDate' and count(parameter)=4 and parameter[1][@type='java.util.Date'] and parameter[2][@type='com.bluecats.sdk.BCInsights.BCInsightsPeriod'] and parameter[3][@type='long'] and parameter[4][@type='com.bluecats.sdk.BCTeamCallback']]"
		[Register ("getTeamInsightsForEndDate", "(Ljava/util/Date;Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;JLcom/bluecats/sdk/BCTeamCallback;)V", "GetGetTeamInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCTeamCallback_Handler")]
		public virtual unsafe void GetTeamInsightsForEndDate (global::Java.Util.Date endDate, global::Com.Bluecats.Sdk.BCInsights.BCInsightsPeriod period, long duration, global::Com.Bluecats.Sdk.IBCTeamCallback @callback)
		{
			if (id_getTeamInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCTeamCallback_ == IntPtr.Zero)
				id_getTeamInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCTeamCallback_ = JNIEnv.GetMethodID (class_ref, "getTeamInsightsForEndDate", "(Ljava/util/Date;Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;JLcom/bluecats/sdk/BCTeamCallback;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (endDate);
				__args [1] = new JValue (period);
				__args [2] = new JValue (duration);
				__args [3] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getTeamInsightsForEndDate_Ljava_util_Date_Lcom_bluecats_sdk_BCInsights_BCInsightsPeriod_JLcom_bluecats_sdk_BCTeamCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTeamInsightsForEndDate", "(Ljava/util/Date;Lcom/bluecats/sdk/BCInsights$BCInsightsPeriod;JLcom/bluecats/sdk/BCTeamCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getTeamInvites_ZLcom_bluecats_sdk_BCTeamCallback_;
#pragma warning disable 0169
		static Delegate GetGetTeamInvites_ZLcom_bluecats_sdk_BCTeamCallback_Handler ()
		{
			if (cb_getTeamInvites_ZLcom_bluecats_sdk_BCTeamCallback_ == null)
				cb_getTeamInvites_ZLcom_bluecats_sdk_BCTeamCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_GetTeamInvites_ZLcom_bluecats_sdk_BCTeamCallback_);
			return cb_getTeamInvites_ZLcom_bluecats_sdk_BCTeamCallback_;
		}

		static void n_GetTeamInvites_ZLcom_bluecats_sdk_BCTeamCallback_ (IntPtr jnienv, IntPtr native__this, bool preferCached, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCTeamCallback @callback = (global::Com.Bluecats.Sdk.IBCTeamCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetTeamInvites (preferCached, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_getTeamInvites_ZLcom_bluecats_sdk_BCTeamCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getTeamInvites' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.bluecats.sdk.BCTeamCallback']]"
		[Register ("getTeamInvites", "(ZLcom/bluecats/sdk/BCTeamCallback;)V", "GetGetTeamInvites_ZLcom_bluecats_sdk_BCTeamCallback_Handler")]
		public virtual unsafe void GetTeamInvites (bool preferCached, global::Com.Bluecats.Sdk.IBCTeamCallback @callback)
		{
			if (id_getTeamInvites_ZLcom_bluecats_sdk_BCTeamCallback_ == IntPtr.Zero)
				id_getTeamInvites_ZLcom_bluecats_sdk_BCTeamCallback_ = JNIEnv.GetMethodID (class_ref, "getTeamInvites", "(ZLcom/bluecats/sdk/BCTeamCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (preferCached);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getTeamInvites_ZLcom_bluecats_sdk_BCTeamCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTeamInvites", "(ZLcom/bluecats/sdk/BCTeamCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getTeammates_ZLcom_bluecats_sdk_BCTeamCallback_;
#pragma warning disable 0169
		static Delegate GetGetTeammates_ZLcom_bluecats_sdk_BCTeamCallback_Handler ()
		{
			if (cb_getTeammates_ZLcom_bluecats_sdk_BCTeamCallback_ == null)
				cb_getTeammates_ZLcom_bluecats_sdk_BCTeamCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_GetTeammates_ZLcom_bluecats_sdk_BCTeamCallback_);
			return cb_getTeammates_ZLcom_bluecats_sdk_BCTeamCallback_;
		}

		static void n_GetTeammates_ZLcom_bluecats_sdk_BCTeamCallback_ (IntPtr jnienv, IntPtr native__this, bool preferCached, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCTeamCallback @callback = (global::Com.Bluecats.Sdk.IBCTeamCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetTeammates (preferCached, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_getTeammates_ZLcom_bluecats_sdk_BCTeamCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='getTeammates' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.bluecats.sdk.BCTeamCallback']]"
		[Register ("getTeammates", "(ZLcom/bluecats/sdk/BCTeamCallback;)V", "GetGetTeammates_ZLcom_bluecats_sdk_BCTeamCallback_Handler")]
		public virtual unsafe void GetTeammates (bool preferCached, global::Com.Bluecats.Sdk.IBCTeamCallback @callback)
		{
			if (id_getTeammates_ZLcom_bluecats_sdk_BCTeamCallback_ == IntPtr.Zero)
				id_getTeammates_ZLcom_bluecats_sdk_BCTeamCallback_ = JNIEnv.GetMethodID (class_ref, "getTeammates", "(ZLcom/bluecats/sdk/BCTeamCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (preferCached);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getTeammates_ZLcom_bluecats_sdk_BCTeamCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTeammates", "(ZLcom/bluecats/sdk/BCTeamCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_Lcom_bluecats_sdk_BCTeamCallback_;
#pragma warning disable 0169
		static Delegate GetSendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_Lcom_bluecats_sdk_BCTeamCallback_Handler ()
		{
			if (cb_sendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_Lcom_bluecats_sdk_BCTeamCallback_ == null)
				cb_sendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_Lcom_bluecats_sdk_BCTeamCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_Lcom_bluecats_sdk_BCTeamCallback_);
			return cb_sendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_Lcom_bluecats_sdk_BCTeamCallback_;
		}

		static void n_SendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_Lcom_bluecats_sdk_BCTeamCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_teamInvite, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCTeamInvite teamInvite = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamInvite> (native_teamInvite, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCTeamCallback @callback = (global::Com.Bluecats.Sdk.IBCTeamCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SendTeamInvite (teamInvite, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_sendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_Lcom_bluecats_sdk_BCTeamCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='sendTeamInvite' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCTeamInvite'] and parameter[2][@type='com.bluecats.sdk.BCTeamCallback']]"
		[Register ("sendTeamInvite", "(Lcom/bluecats/sdk/BCTeamInvite;Lcom/bluecats/sdk/BCTeamCallback;)V", "GetSendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_Lcom_bluecats_sdk_BCTeamCallback_Handler")]
		public virtual unsafe void SendTeamInvite (global::Com.Bluecats.Sdk.BCTeamInvite teamInvite, global::Com.Bluecats.Sdk.IBCTeamCallback @callback)
		{
			if (id_sendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_Lcom_bluecats_sdk_BCTeamCallback_ == IntPtr.Zero)
				id_sendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_Lcom_bluecats_sdk_BCTeamCallback_ = JNIEnv.GetMethodID (class_ref, "sendTeamInvite", "(Lcom/bluecats/sdk/BCTeamInvite;Lcom/bluecats/sdk/BCTeamCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (teamInvite);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendTeamInvite_Lcom_bluecats_sdk_BCTeamInvite_Lcom_bluecats_sdk_BCTeamCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendTeamInvite", "(Lcom/bluecats/sdk/BCTeamInvite;Lcom/bluecats/sdk/BCTeamCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCTeamCallback_;
#pragma warning disable 0169
		static Delegate GetUpdateTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCTeamCallback_Handler ()
		{
			if (cb_updateTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCTeamCallback_ == null)
				cb_updateTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCTeamCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCTeamCallback_);
			return cb_updateTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCTeamCallback_;
		}

		static void n_UpdateTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCTeamCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_team, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCTeamApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCTeam team = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (native_team, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCTeamCallback @callback = (global::Com.Bluecats.Sdk.IBCTeamCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCTeamCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTeam (team, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_updateTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCTeamCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeamApi']/method[@name='updateTeam' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCTeam'] and parameter[2][@type='com.bluecats.sdk.BCTeamCallback']]"
		[Register ("updateTeam", "(Lcom/bluecats/sdk/BCTeam;Lcom/bluecats/sdk/BCTeamCallback;)V", "GetUpdateTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCTeamCallback_Handler")]
		public virtual unsafe void UpdateTeam (global::Com.Bluecats.Sdk.BCTeam team, global::Com.Bluecats.Sdk.IBCTeamCallback @callback)
		{
			if (id_updateTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCTeamCallback_ == IntPtr.Zero)
				id_updateTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCTeamCallback_ = JNIEnv.GetMethodID (class_ref, "updateTeam", "(Lcom/bluecats/sdk/BCTeam;Lcom/bluecats/sdk/BCTeamCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (team);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCTeamCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateTeam", "(Lcom/bluecats/sdk/BCTeam;Lcom/bluecats/sdk/BCTeamCallback;)V"), __args);
			} finally {
			}
		}

	}
}
