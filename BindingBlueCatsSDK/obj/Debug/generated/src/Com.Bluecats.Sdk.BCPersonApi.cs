using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPersonApi']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCPersonApi", DoNotGenerateAcw=true)]
	public partial class BCPersonApi : global::Java.Lang.Object {


		static IntPtr mCachedTeamInvites_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPersonApi']/field[@name='mCachedTeamInvites']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPersonApi']/field[@name='mCachedTeamInvitesAt']"
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

		static IntPtr mCachedTeamsAt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPersonApi']/field[@name='mCachedTeamsAt']"
		[Register ("mCachedTeamsAt")]
		protected global::Java.Util.Date MCachedTeamsAt {
			get {
				if (mCachedTeamsAt_jfieldId == IntPtr.Zero)
					mCachedTeamsAt_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedTeamsAt", "Ljava/util/Date;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mCachedTeamsAt_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCachedTeamsAt_jfieldId == IntPtr.Zero)
					mCachedTeamsAt_jfieldId = JNIEnv.GetFieldID (class_ref, "mCachedTeamsAt", "Ljava/util/Date;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mCachedTeamsAt_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mTeamForKey_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPersonApi']/field[@name='mTeamForKey']"
		[Register ("mTeamForKey")]
		protected global::System.Collections.IDictionary MTeamForKey {
			get {
				if (mTeamForKey_jfieldId == IntPtr.Zero)
					mTeamForKey_jfieldId = JNIEnv.GetFieldID (class_ref, "mTeamForKey", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mTeamForKey_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTeamForKey_jfieldId == IntPtr.Zero)
					mTeamForKey_jfieldId = JNIEnv.GetFieldID (class_ref, "mTeamForKey", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mTeamForKey_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCPersonApi", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCPersonApi); }
		}

		protected BCPersonApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPersonApi']/constructor[@name='BCPersonApi' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCPersonApi ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCPersonApi)) {
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

		static Delegate cb_getAllCachedTeams;
#pragma warning disable 0169
		static Delegate GetGetAllCachedTeamsHandler ()
		{
			if (cb_getAllCachedTeams == null)
				cb_getAllCachedTeams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllCachedTeams);
			return cb_getAllCachedTeams;
		}

		static IntPtr n_GetAllCachedTeams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCPersonApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPersonApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCTeam>.ToLocalJniHandle (__this.AllCachedTeams);
		}
#pragma warning restore 0169

		static IntPtr id_getAllCachedTeams;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCTeam> AllCachedTeams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPersonApi']/method[@name='getAllCachedTeams' and count(parameter)=0]"
			[Register ("getAllCachedTeams", "()Ljava/util/List;", "GetGetAllCachedTeamsHandler")]
			get {
				if (id_getAllCachedTeams == IntPtr.Zero)
					id_getAllCachedTeams = JNIEnv.GetMethodID (class_ref, "getAllCachedTeams", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCTeam>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllCachedTeams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCTeam>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllCachedTeams", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Bluecats.Sdk.BCPersonApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPersonApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCTeamInvite>.ToLocalJniHandle (__this.CachedTeamInvites);
		}
#pragma warning restore 0169

		static IntPtr id_getCachedTeamInvites;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCTeamInvite> CachedTeamInvites {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPersonApi']/method[@name='getCachedTeamInvites' and count(parameter)=0]"
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
			global::Com.Bluecats.Sdk.BCPersonApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPersonApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CachedTeamInvitesAt);
		}
#pragma warning restore 0169

		static Delegate cb_setCachedTeamInvitesAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetCachedTeamInvitesAt_Ljava_util_Date_Handler ()
		{
			if (cb_setCachedTeamInvitesAt_Ljava_util_Date_ == null)
				cb_setCachedTeamInvitesAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCachedTeamInvitesAt_Ljava_util_Date_);
			return cb_setCachedTeamInvitesAt_Ljava_util_Date_;
		}

		static void n_SetCachedTeamInvitesAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCPersonApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPersonApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.CachedTeamInvitesAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCachedTeamInvitesAt;
		static IntPtr id_setCachedTeamInvitesAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date CachedTeamInvitesAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPersonApi']/method[@name='getCachedTeamInvitesAt' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPersonApi']/method[@name='setCachedTeamInvitesAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setCachedTeamInvitesAt", "(Ljava/util/Date;)V", "GetSetCachedTeamInvitesAt_Ljava_util_Date_Handler")]
			set {
				if (id_setCachedTeamInvitesAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setCachedTeamInvitesAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setCachedTeamInvitesAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCachedTeamInvitesAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCachedTeamInvitesAt", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCachedTeamsAt;
#pragma warning disable 0169
		static Delegate GetGetCachedTeamsAtHandler ()
		{
			if (cb_getCachedTeamsAt == null)
				cb_getCachedTeamsAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCachedTeamsAt);
			return cb_getCachedTeamsAt;
		}

		static IntPtr n_GetCachedTeamsAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCPersonApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPersonApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CachedTeamsAt);
		}
#pragma warning restore 0169

		static Delegate cb_setCachedTeamsAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetCachedTeamsAt_Ljava_util_Date_Handler ()
		{
			if (cb_setCachedTeamsAt_Ljava_util_Date_ == null)
				cb_setCachedTeamsAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCachedTeamsAt_Ljava_util_Date_);
			return cb_setCachedTeamsAt_Ljava_util_Date_;
		}

		static void n_SetCachedTeamsAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCPersonApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPersonApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date value = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.CachedTeamsAt = value;
		}
#pragma warning restore 0169

		static IntPtr id_getCachedTeamsAt;
		static IntPtr id_setCachedTeamsAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date CachedTeamsAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPersonApi']/method[@name='getCachedTeamsAt' and count(parameter)=0]"
			[Register ("getCachedTeamsAt", "()Ljava/util/Date;", "GetGetCachedTeamsAtHandler")]
			get {
				if (id_getCachedTeamsAt == IntPtr.Zero)
					id_getCachedTeamsAt = JNIEnv.GetMethodID (class_ref, "getCachedTeamsAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedTeamsAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedTeamsAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPersonApi']/method[@name='setCachedTeamsAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setCachedTeamsAt", "(Ljava/util/Date;)V", "GetSetCachedTeamsAt_Ljava_util_Date_Handler")]
			set {
				if (id_setCachedTeamsAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setCachedTeamsAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setCachedTeamsAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCachedTeamsAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCachedTeamsAt", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_hasTeamsCacheExpired;
#pragma warning disable 0169
		static Delegate GetHasTeamsCacheExpiredHandler ()
		{
			if (cb_hasTeamsCacheExpired == null)
				cb_hasTeamsCacheExpired = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasTeamsCacheExpired);
			return cb_hasTeamsCacheExpired;
		}

		static bool n_HasTeamsCacheExpired (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCPersonApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPersonApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasTeamsCacheExpired;
		}
#pragma warning restore 0169

		static IntPtr id_hasTeamsCacheExpired;
		public virtual unsafe bool HasTeamsCacheExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPersonApi']/method[@name='hasTeamsCacheExpired' and count(parameter)=0]"
			[Register ("hasTeamsCacheExpired", "()Z", "GetHasTeamsCacheExpiredHandler")]
			get {
				if (id_hasTeamsCacheExpired == IntPtr.Zero)
					id_hasTeamsCacheExpired = JNIEnv.GetMethodID (class_ref, "hasTeamsCacheExpired", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasTeamsCacheExpired);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasTeamsCacheExpired", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getTeamCount;
#pragma warning disable 0169
		static Delegate GetGetTeamCountHandler ()
		{
			if (cb_getTeamCount == null)
				cb_getTeamCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTeamCount);
			return cb_getTeamCount;
		}

		static int n_GetTeamCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCPersonApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPersonApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TeamCount;
		}
#pragma warning restore 0169

		static IntPtr id_getTeamCount;
		public virtual unsafe int TeamCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPersonApi']/method[@name='getTeamCount' and count(parameter)=0]"
			[Register ("getTeamCount", "()I", "GetGetTeamCountHandler")]
			get {
				if (id_getTeamCount == IntPtr.Zero)
					id_getTeamCount = JNIEnv.GetMethodID (class_ref, "getTeamCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTeamCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTeamCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_cacheTeam_Lcom_bluecats_sdk_BCTeam_;
#pragma warning disable 0169
		static Delegate GetCacheTeam_Lcom_bluecats_sdk_BCTeam_Handler ()
		{
			if (cb_cacheTeam_Lcom_bluecats_sdk_BCTeam_ == null)
				cb_cacheTeam_Lcom_bluecats_sdk_BCTeam_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CacheTeam_Lcom_bluecats_sdk_BCTeam_);
			return cb_cacheTeam_Lcom_bluecats_sdk_BCTeam_;
		}

		static void n_CacheTeam_Lcom_bluecats_sdk_BCTeam_ (IntPtr jnienv, IntPtr native__this, IntPtr native_team)
		{
			global::Com.Bluecats.Sdk.BCPersonApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPersonApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCTeam team = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (native_team, JniHandleOwnership.DoNotTransfer);
			__this.CacheTeam (team);
		}
#pragma warning restore 0169

		static IntPtr id_cacheTeam_Lcom_bluecats_sdk_BCTeam_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPersonApi']/method[@name='cacheTeam' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCTeam']]"
		[Register ("cacheTeam", "(Lcom/bluecats/sdk/BCTeam;)V", "GetCacheTeam_Lcom_bluecats_sdk_BCTeam_Handler")]
		public virtual unsafe void CacheTeam (global::Com.Bluecats.Sdk.BCTeam team)
		{
			if (id_cacheTeam_Lcom_bluecats_sdk_BCTeam_ == IntPtr.Zero)
				id_cacheTeam_Lcom_bluecats_sdk_BCTeam_ = JNIEnv.GetMethodID (class_ref, "cacheTeam", "(Lcom/bluecats/sdk/BCTeam;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (team);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cacheTeam_Lcom_bluecats_sdk_BCTeam_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cacheTeam", "(Lcom/bluecats/sdk/BCTeam;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_cacheTeamsFromArray_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetCacheTeamsFromArray_Ljava_util_List_Handler ()
		{
			if (cb_cacheTeamsFromArray_Ljava_util_List_ == null)
				cb_cacheTeamsFromArray_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CacheTeamsFromArray_Ljava_util_List_);
			return cb_cacheTeamsFromArray_Ljava_util_List_;
		}

		static void n_CacheTeamsFromArray_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_teams)
		{
			global::Com.Bluecats.Sdk.BCPersonApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPersonApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var teams = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCTeam>.FromJniHandle (native_teams, JniHandleOwnership.DoNotTransfer);
			__this.CacheTeamsFromArray (teams);
		}
#pragma warning restore 0169

		static IntPtr id_cacheTeamsFromArray_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPersonApi']/method[@name='cacheTeamsFromArray' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCTeam&gt;']]"
		[Register ("cacheTeamsFromArray", "(Ljava/util/List;)V", "GetCacheTeamsFromArray_Ljava_util_List_Handler")]
		public virtual unsafe void CacheTeamsFromArray (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCTeam> teams)
		{
			if (id_cacheTeamsFromArray_Ljava_util_List_ == IntPtr.Zero)
				id_cacheTeamsFromArray_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "cacheTeamsFromArray", "(Ljava/util/List;)V");
			IntPtr native_teams = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCTeam>.ToLocalJniHandle (teams);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_teams);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cacheTeamsFromArray_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cacheTeamsFromArray", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_teams);
			}
		}

		static Delegate cb_createTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_;
#pragma warning disable 0169
		static Delegate GetCreateTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_Handler ()
		{
			if (cb_createTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_ == null)
				cb_createTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_);
			return cb_createTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_;
		}

		static void n_CreateTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_team, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCPersonApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPersonApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCTeam team = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (native_team, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCPersonCallback @callback = (global::Com.Bluecats.Sdk.IBCPersonCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCPersonCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.CreateTeam (team, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_createTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPersonApi']/method[@name='createTeam' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCTeam'] and parameter[2][@type='com.bluecats.sdk.BCPersonCallback']]"
		[Register ("createTeam", "(Lcom/bluecats/sdk/BCTeam;Lcom/bluecats/sdk/BCPersonCallback;)V", "GetCreateTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_Handler")]
		public virtual unsafe void CreateTeam (global::Com.Bluecats.Sdk.BCTeam team, global::Com.Bluecats.Sdk.IBCPersonCallback @callback)
		{
			if (id_createTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_ == IntPtr.Zero)
				id_createTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_ = JNIEnv.GetMethodID (class_ref, "createTeam", "(Lcom/bluecats/sdk/BCTeam;Lcom/bluecats/sdk/BCPersonCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (team);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createTeam", "(Lcom/bluecats/sdk/BCTeam;Lcom/bluecats/sdk/BCPersonCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deleteTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_;
#pragma warning disable 0169
		static Delegate GetDeleteTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_Handler ()
		{
			if (cb_deleteTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_ == null)
				cb_deleteTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_);
			return cb_deleteTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_;
		}

		static void n_DeleteTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_team, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCPersonApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPersonApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCTeam team = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (native_team, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCPersonCallback @callback = (global::Com.Bluecats.Sdk.IBCPersonCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCPersonCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.DeleteTeam (team, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_deleteTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPersonApi']/method[@name='deleteTeam' and count(parameter)=2 and parameter[1][@type='com.bluecats.sdk.BCTeam'] and parameter[2][@type='com.bluecats.sdk.BCPersonCallback']]"
		[Register ("deleteTeam", "(Lcom/bluecats/sdk/BCTeam;Lcom/bluecats/sdk/BCPersonCallback;)V", "GetDeleteTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_Handler")]
		public virtual unsafe void DeleteTeam (global::Com.Bluecats.Sdk.BCTeam team, global::Com.Bluecats.Sdk.IBCPersonCallback @callback)
		{
			if (id_deleteTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_ == IntPtr.Zero)
				id_deleteTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_ = JNIEnv.GetMethodID (class_ref, "deleteTeam", "(Lcom/bluecats/sdk/BCTeam;Lcom/bluecats/sdk/BCPersonCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (team);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteTeam_Lcom_bluecats_sdk_BCTeam_Lcom_bluecats_sdk_BCPersonCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteTeam", "(Lcom/bluecats/sdk/BCTeam;Lcom/bluecats/sdk/BCPersonCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getCachedTeamWithTeamID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCachedTeamWithTeamID_Ljava_lang_String_Handler ()
		{
			if (cb_getCachedTeamWithTeamID_Ljava_lang_String_ == null)
				cb_getCachedTeamWithTeamID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCachedTeamWithTeamID_Ljava_lang_String_);
			return cb_getCachedTeamWithTeamID_Ljava_lang_String_;
		}

		static IntPtr n_GetCachedTeamWithTeamID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_teamID)
		{
			global::Com.Bluecats.Sdk.BCPersonApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPersonApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string teamID = JNIEnv.GetString (native_teamID, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCachedTeamWithTeamID (teamID));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getCachedTeamWithTeamID_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPersonApi']/method[@name='getCachedTeamWithTeamID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCachedTeamWithTeamID", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCTeam;", "GetGetCachedTeamWithTeamID_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Bluecats.Sdk.BCTeam GetCachedTeamWithTeamID (string teamID)
		{
			if (id_getCachedTeamWithTeamID_Ljava_lang_String_ == IntPtr.Zero)
				id_getCachedTeamWithTeamID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCachedTeamWithTeamID", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCTeam;");
			IntPtr native_teamID = JNIEnv.NewString (teamID);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_teamID);

				global::Com.Bluecats.Sdk.BCTeam __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedTeamWithTeamID_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedTeamWithTeamID", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCTeam;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_teamID);
			}
		}

		static Delegate cb_getCachedTeamsWithOwner_Lcom_bluecats_sdk_BCPerson_;
#pragma warning disable 0169
		static Delegate GetGetCachedTeamsWithOwner_Lcom_bluecats_sdk_BCPerson_Handler ()
		{
			if (cb_getCachedTeamsWithOwner_Lcom_bluecats_sdk_BCPerson_ == null)
				cb_getCachedTeamsWithOwner_Lcom_bluecats_sdk_BCPerson_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCachedTeamsWithOwner_Lcom_bluecats_sdk_BCPerson_);
			return cb_getCachedTeamsWithOwner_Lcom_bluecats_sdk_BCPerson_;
		}

		static IntPtr n_GetCachedTeamsWithOwner_Lcom_bluecats_sdk_BCPerson_ (IntPtr jnienv, IntPtr native__this, IntPtr native_owner)
		{
			global::Com.Bluecats.Sdk.BCPersonApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPersonApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCPerson owner = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPerson> (native_owner, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCTeam>.ToLocalJniHandle (__this.GetCachedTeamsWithOwner (owner));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getCachedTeamsWithOwner_Lcom_bluecats_sdk_BCPerson_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPersonApi']/method[@name='getCachedTeamsWithOwner' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCPerson']]"
		[Register ("getCachedTeamsWithOwner", "(Lcom/bluecats/sdk/BCPerson;)Ljava/util/List;", "GetGetCachedTeamsWithOwner_Lcom_bluecats_sdk_BCPerson_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCTeam> GetCachedTeamsWithOwner (global::Com.Bluecats.Sdk.BCPerson owner)
		{
			if (id_getCachedTeamsWithOwner_Lcom_bluecats_sdk_BCPerson_ == IntPtr.Zero)
				id_getCachedTeamsWithOwner_Lcom_bluecats_sdk_BCPerson_ = JNIEnv.GetMethodID (class_ref, "getCachedTeamsWithOwner", "(Lcom/bluecats/sdk/BCPerson;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (owner);

				global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCTeam> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCTeam>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedTeamsWithOwner_Lcom_bluecats_sdk_BCPerson_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCTeam>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCachedTeamsWithOwner", "(Lcom/bluecats/sdk/BCPerson;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getTeams_ZLcom_bluecats_sdk_BCPersonCallback_;
#pragma warning disable 0169
		static Delegate GetGetTeams_ZLcom_bluecats_sdk_BCPersonCallback_Handler ()
		{
			if (cb_getTeams_ZLcom_bluecats_sdk_BCPersonCallback_ == null)
				cb_getTeams_ZLcom_bluecats_sdk_BCPersonCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_GetTeams_ZLcom_bluecats_sdk_BCPersonCallback_);
			return cb_getTeams_ZLcom_bluecats_sdk_BCPersonCallback_;
		}

		static void n_GetTeams_ZLcom_bluecats_sdk_BCPersonCallback_ (IntPtr jnienv, IntPtr native__this, bool preferCached, IntPtr native__callback)
		{
			global::Com.Bluecats.Sdk.BCPersonApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPersonApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCPersonCallback @callback = (global::Com.Bluecats.Sdk.IBCPersonCallback)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCPersonCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.GetTeams (preferCached, @callback);
		}
#pragma warning restore 0169

		static IntPtr id_getTeams_ZLcom_bluecats_sdk_BCPersonCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPersonApi']/method[@name='getTeams' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.bluecats.sdk.BCPersonCallback']]"
		[Register ("getTeams", "(ZLcom/bluecats/sdk/BCPersonCallback;)V", "GetGetTeams_ZLcom_bluecats_sdk_BCPersonCallback_Handler")]
		public virtual unsafe void GetTeams (bool preferCached, global::Com.Bluecats.Sdk.IBCPersonCallback @callback)
		{
			if (id_getTeams_ZLcom_bluecats_sdk_BCPersonCallback_ == IntPtr.Zero)
				id_getTeams_ZLcom_bluecats_sdk_BCPersonCallback_ = JNIEnv.GetMethodID (class_ref, "getTeams", "(ZLcom/bluecats/sdk/BCPersonCallback;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (preferCached);
				__args [1] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getTeams_ZLcom_bluecats_sdk_BCPersonCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTeams", "(ZLcom/bluecats/sdk/BCPersonCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_removeCachedTeam_Lcom_bluecats_sdk_BCTeam_;
#pragma warning disable 0169
		static Delegate GetRemoveCachedTeam_Lcom_bluecats_sdk_BCTeam_Handler ()
		{
			if (cb_removeCachedTeam_Lcom_bluecats_sdk_BCTeam_ == null)
				cb_removeCachedTeam_Lcom_bluecats_sdk_BCTeam_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveCachedTeam_Lcom_bluecats_sdk_BCTeam_);
			return cb_removeCachedTeam_Lcom_bluecats_sdk_BCTeam_;
		}

		static void n_RemoveCachedTeam_Lcom_bluecats_sdk_BCTeam_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cachedTeam)
		{
			global::Com.Bluecats.Sdk.BCPersonApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPersonApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCTeam cachedTeam = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (native_cachedTeam, JniHandleOwnership.DoNotTransfer);
			__this.RemoveCachedTeam (cachedTeam);
		}
#pragma warning restore 0169

		static IntPtr id_removeCachedTeam_Lcom_bluecats_sdk_BCTeam_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPersonApi']/method[@name='removeCachedTeam' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCTeam']]"
		[Register ("removeCachedTeam", "(Lcom/bluecats/sdk/BCTeam;)V", "GetRemoveCachedTeam_Lcom_bluecats_sdk_BCTeam_Handler")]
		public virtual unsafe void RemoveCachedTeam (global::Com.Bluecats.Sdk.BCTeam cachedTeam)
		{
			if (id_removeCachedTeam_Lcom_bluecats_sdk_BCTeam_ == IntPtr.Zero)
				id_removeCachedTeam_Lcom_bluecats_sdk_BCTeam_ = JNIEnv.GetMethodID (class_ref, "removeCachedTeam", "(Lcom/bluecats/sdk/BCTeam;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cachedTeam);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeCachedTeam_Lcom_bluecats_sdk_BCTeam_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeCachedTeam", "(Lcom/bluecats/sdk/BCTeam;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAllCachedTeamInvites_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetAllCachedTeamInvites_Ljava_util_List_Handler ()
		{
			if (cb_setAllCachedTeamInvites_Ljava_util_List_ == null)
				cb_setAllCachedTeamInvites_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAllCachedTeamInvites_Ljava_util_List_);
			return cb_setAllCachedTeamInvites_Ljava_util_List_;
		}

		static void n_SetAllCachedTeamInvites_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCPersonApi __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPersonApi> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var value = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCTeamInvite>.FromJniHandle (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SetAllCachedTeamInvites (value);
		}
#pragma warning restore 0169

		static IntPtr id_setAllCachedTeamInvites_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPersonApi']/method[@name='setAllCachedTeamInvites' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.bluecats.sdk.BCTeamInvite&gt;']]"
		[Register ("setAllCachedTeamInvites", "(Ljava/util/List;)V", "GetSetAllCachedTeamInvites_Ljava_util_List_Handler")]
		public virtual unsafe void SetAllCachedTeamInvites (global::System.Collections.Generic.IList<global::Com.Bluecats.Sdk.BCTeamInvite> value)
		{
			if (id_setAllCachedTeamInvites_Ljava_util_List_ == IntPtr.Zero)
				id_setAllCachedTeamInvites_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setAllCachedTeamInvites", "(Ljava/util/List;)V");
			IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Bluecats.Sdk.BCTeamInvite>.ToLocalJniHandle (value);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAllCachedTeamInvites_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAllCachedTeamInvites", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
