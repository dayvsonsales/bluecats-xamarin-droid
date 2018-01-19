using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCNetworkAccess']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCNetworkAccess", DoNotGenerateAcw=true)]
	public partial class BCNetworkAccess : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCNetworkAccess']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/bluecats/sdk/BCNetworkAccess", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCNetworkAccess); }
		}

		protected BCNetworkAccess (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCNetworkAccess']/constructor[@name='BCNetworkAccess' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCNetworkAccess ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCNetworkAccess)) {
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

		static Delegate cb_getBeginsAt;
#pragma warning disable 0169
		static Delegate GetGetBeginsAtHandler ()
		{
			if (cb_getBeginsAt == null)
				cb_getBeginsAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBeginsAt);
			return cb_getBeginsAt;
		}

		static IntPtr n_GetBeginsAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCNetworkAccess __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCNetworkAccess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BeginsAt);
		}
#pragma warning restore 0169

		static Delegate cb_setBeginsAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetBeginsAt_Ljava_util_Date_Handler ()
		{
			if (cb_setBeginsAt_Ljava_util_Date_ == null)
				cb_setBeginsAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBeginsAt_Ljava_util_Date_);
			return cb_setBeginsAt_Ljava_util_Date_;
		}

		static void n_SetBeginsAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Com.Bluecats.Sdk.BCNetworkAccess __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCNetworkAccess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date date = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_date, JniHandleOwnership.DoNotTransfer);
			__this.BeginsAt = date;
		}
#pragma warning restore 0169

		static IntPtr id_getBeginsAt;
		static IntPtr id_setBeginsAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date BeginsAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCNetworkAccess']/method[@name='getBeginsAt' and count(parameter)=0]"
			[Register ("getBeginsAt", "()Ljava/util/Date;", "GetGetBeginsAtHandler")]
			get {
				if (id_getBeginsAt == IntPtr.Zero)
					id_getBeginsAt = JNIEnv.GetMethodID (class_ref, "getBeginsAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBeginsAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBeginsAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCNetworkAccess']/method[@name='setBeginsAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setBeginsAt", "(Ljava/util/Date;)V", "GetSetBeginsAt_Ljava_util_Date_Handler")]
			set {
				if (id_setBeginsAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setBeginsAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setBeginsAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBeginsAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBeginsAt", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEndsAt;
#pragma warning disable 0169
		static Delegate GetGetEndsAtHandler ()
		{
			if (cb_getEndsAt == null)
				cb_getEndsAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEndsAt);
			return cb_getEndsAt;
		}

		static IntPtr n_GetEndsAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCNetworkAccess __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCNetworkAccess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EndsAt);
		}
#pragma warning restore 0169

		static Delegate cb_setEndsAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetEndsAt_Ljava_util_Date_Handler ()
		{
			if (cb_setEndsAt_Ljava_util_Date_ == null)
				cb_setEndsAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEndsAt_Ljava_util_Date_);
			return cb_setEndsAt_Ljava_util_Date_;
		}

		static void n_SetEndsAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Com.Bluecats.Sdk.BCNetworkAccess __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCNetworkAccess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date date = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_date, JniHandleOwnership.DoNotTransfer);
			__this.EndsAt = date;
		}
#pragma warning restore 0169

		static IntPtr id_getEndsAt;
		static IntPtr id_setEndsAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date EndsAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCNetworkAccess']/method[@name='getEndsAt' and count(parameter)=0]"
			[Register ("getEndsAt", "()Ljava/util/Date;", "GetGetEndsAtHandler")]
			get {
				if (id_getEndsAt == IntPtr.Zero)
					id_getEndsAt = JNIEnv.GetMethodID (class_ref, "getEndsAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEndsAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEndsAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCNetworkAccess']/method[@name='setEndsAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setEndsAt", "(Ljava/util/Date;)V", "GetSetEndsAt_Ljava_util_Date_Handler")]
			set {
				if (id_setEndsAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setEndsAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setEndsAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEndsAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEndsAt", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxSecondsBeforeRevalidation;
#pragma warning disable 0169
		static Delegate GetGetMaxSecondsBeforeRevalidationHandler ()
		{
			if (cb_getMaxSecondsBeforeRevalidation == null)
				cb_getMaxSecondsBeforeRevalidation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxSecondsBeforeRevalidation);
			return cb_getMaxSecondsBeforeRevalidation;
		}

		static int n_GetMaxSecondsBeforeRevalidation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCNetworkAccess __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCNetworkAccess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxSecondsBeforeRevalidation;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxSecondsBeforeRevalidation;
		public virtual unsafe int MaxSecondsBeforeRevalidation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCNetworkAccess']/method[@name='getMaxSecondsBeforeRevalidation' and count(parameter)=0]"
			[Register ("getMaxSecondsBeforeRevalidation", "()I", "GetGetMaxSecondsBeforeRevalidationHandler")]
			get {
				if (id_getMaxSecondsBeforeRevalidation == IntPtr.Zero)
					id_getMaxSecondsBeforeRevalidation = JNIEnv.GetMethodID (class_ref, "getMaxSecondsBeforeRevalidation", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxSecondsBeforeRevalidation);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxSecondsBeforeRevalidation", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getOwnerShip;
#pragma warning disable 0169
		static Delegate GetGetOwnerShipHandler ()
		{
			if (cb_getOwnerShip == null)
				cb_getOwnerShip = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOwnerShip);
			return cb_getOwnerShip;
		}

		static IntPtr n_GetOwnerShip (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCNetworkAccess __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCNetworkAccess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OwnerShip);
		}
#pragma warning restore 0169

		static IntPtr id_getOwnerShip;
		public virtual unsafe global::Com.Bluecats.Sdk.BCNetworkAccessOwnerShip OwnerShip {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCNetworkAccess']/method[@name='getOwnerShip' and count(parameter)=0]"
			[Register ("getOwnerShip", "()Lcom/bluecats/sdk/BCNetworkAccessOwnerShip;", "GetGetOwnerShipHandler")]
			get {
				if (id_getOwnerShip == IntPtr.Zero)
					id_getOwnerShip = JNIEnv.GetMethodID (class_ref, "getOwnerShip", "()Lcom/bluecats/sdk/BCNetworkAccessOwnerShip;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCNetworkAccessOwnerShip> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOwnerShip), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCNetworkAccessOwnerShip> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOwnerShip", "()Lcom/bluecats/sdk/BCNetworkAccessOwnerShip;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Bluecats.Sdk.BCNetworkAccess __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCNetworkAccess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCNetworkAccess']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_getPermittedRoles;
#pragma warning disable 0169
		static Delegate GetGetPermittedRolesHandler ()
		{
			if (cb_getPermittedRoles == null)
				cb_getPermittedRoles = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPermittedRoles);
			return cb_getPermittedRoles;
		}

		static IntPtr n_GetPermittedRoles (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCNetworkAccess __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCNetworkAccess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPermittedRoles ());
		}
#pragma warning restore 0169

		static IntPtr id_getPermittedRoles;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCNetworkAccess']/method[@name='getPermittedRoles' and count(parameter)=0]"
		[Register ("getPermittedRoles", "()[Lcom/bluecats/sdk/BCNetworkAccessRole;", "GetGetPermittedRolesHandler")]
		public virtual unsafe global::Com.Bluecats.Sdk.BCNetworkAccessRole[] GetPermittedRoles ()
		{
			if (id_getPermittedRoles == IntPtr.Zero)
				id_getPermittedRoles = JNIEnv.GetMethodID (class_ref, "getPermittedRoles", "()[Lcom/bluecats/sdk/BCNetworkAccessRole;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Com.Bluecats.Sdk.BCNetworkAccessRole[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPermittedRoles), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCNetworkAccessRole));
				else
					return (global::Com.Bluecats.Sdk.BCNetworkAccessRole[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPermittedRoles", "()[Lcom/bluecats/sdk/BCNetworkAccessRole;")), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCNetworkAccessRole));
			} finally {
			}
		}

		static Delegate cb_setOwnership_Lcom_bluecats_sdk_BCNetworkAccessOwnerShip_;
#pragma warning disable 0169
		static Delegate GetSetOwnership_Lcom_bluecats_sdk_BCNetworkAccessOwnerShip_Handler ()
		{
			if (cb_setOwnership_Lcom_bluecats_sdk_BCNetworkAccessOwnerShip_ == null)
				cb_setOwnership_Lcom_bluecats_sdk_BCNetworkAccessOwnerShip_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOwnership_Lcom_bluecats_sdk_BCNetworkAccessOwnerShip_);
			return cb_setOwnership_Lcom_bluecats_sdk_BCNetworkAccessOwnerShip_;
		}

		static void n_SetOwnership_Lcom_bluecats_sdk_BCNetworkAccessOwnerShip_ (IntPtr jnienv, IntPtr native__this, IntPtr native_os)
		{
			global::Com.Bluecats.Sdk.BCNetworkAccess __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCNetworkAccess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCNetworkAccessOwnerShip os = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCNetworkAccessOwnerShip> (native_os, JniHandleOwnership.DoNotTransfer);
			__this.SetOwnership (os);
		}
#pragma warning restore 0169

		static IntPtr id_setOwnership_Lcom_bluecats_sdk_BCNetworkAccessOwnerShip_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCNetworkAccess']/method[@name='setOwnership' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCNetworkAccessOwnerShip']]"
		[Register ("setOwnership", "(Lcom/bluecats/sdk/BCNetworkAccessOwnerShip;)V", "GetSetOwnership_Lcom_bluecats_sdk_BCNetworkAccessOwnerShip_Handler")]
		public virtual unsafe void SetOwnership (global::Com.Bluecats.Sdk.BCNetworkAccessOwnerShip os)
		{
			if (id_setOwnership_Lcom_bluecats_sdk_BCNetworkAccessOwnerShip_ == IntPtr.Zero)
				id_setOwnership_Lcom_bluecats_sdk_BCNetworkAccessOwnerShip_ = JNIEnv.GetMethodID (class_ref, "setOwnership", "(Lcom/bluecats/sdk/BCNetworkAccessOwnerShip;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (os);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOwnership_Lcom_bluecats_sdk_BCNetworkAccessOwnerShip_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOwnership", "(Lcom/bluecats/sdk/BCNetworkAccessOwnerShip;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPermittedRoles_arrayLcom_bluecats_sdk_BCNetworkAccessRole_;
#pragma warning disable 0169
		static Delegate GetSetPermittedRoles_arrayLcom_bluecats_sdk_BCNetworkAccessRole_Handler ()
		{
			if (cb_setPermittedRoles_arrayLcom_bluecats_sdk_BCNetworkAccessRole_ == null)
				cb_setPermittedRoles_arrayLcom_bluecats_sdk_BCNetworkAccessRole_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPermittedRoles_arrayLcom_bluecats_sdk_BCNetworkAccessRole_);
			return cb_setPermittedRoles_arrayLcom_bluecats_sdk_BCNetworkAccessRole_;
		}

		static void n_SetPermittedRoles_arrayLcom_bluecats_sdk_BCNetworkAccessRole_ (IntPtr jnienv, IntPtr native__this, IntPtr native_roles)
		{
			global::Com.Bluecats.Sdk.BCNetworkAccess __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCNetworkAccess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCNetworkAccessRole[] roles = (global::Com.Bluecats.Sdk.BCNetworkAccessRole[]) JNIEnv.GetArray (native_roles, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Bluecats.Sdk.BCNetworkAccessRole));
			__this.SetPermittedRoles (roles);
			if (roles != null)
				JNIEnv.CopyArray (roles, native_roles);
		}
#pragma warning restore 0169

		static IntPtr id_setPermittedRoles_arrayLcom_bluecats_sdk_BCNetworkAccessRole_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCNetworkAccess']/method[@name='setPermittedRoles' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCNetworkAccessRole[]']]"
		[Register ("setPermittedRoles", "([Lcom/bluecats/sdk/BCNetworkAccessRole;)V", "GetSetPermittedRoles_arrayLcom_bluecats_sdk_BCNetworkAccessRole_Handler")]
		public virtual unsafe void SetPermittedRoles (global::Com.Bluecats.Sdk.BCNetworkAccessRole[] roles)
		{
			if (id_setPermittedRoles_arrayLcom_bluecats_sdk_BCNetworkAccessRole_ == IntPtr.Zero)
				id_setPermittedRoles_arrayLcom_bluecats_sdk_BCNetworkAccessRole_ = JNIEnv.GetMethodID (class_ref, "setPermittedRoles", "([Lcom/bluecats/sdk/BCNetworkAccessRole;)V");
			IntPtr native_roles = JNIEnv.NewArray (roles);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_roles);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPermittedRoles_arrayLcom_bluecats_sdk_BCNetworkAccessRole_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPermittedRoles", "([Lcom/bluecats/sdk/BCNetworkAccessRole;)V"), __args);
			} finally {
				if (roles != null) {
					JNIEnv.CopyArray (native_roles, roles);
					JNIEnv.DeleteLocalRef (native_roles);
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
			global::Com.Bluecats.Sdk.BCNetworkAccess __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCNetworkAccess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCNetworkAccess']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
