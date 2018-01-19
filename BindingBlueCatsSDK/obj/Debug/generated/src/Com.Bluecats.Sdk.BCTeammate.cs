using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeammate']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCTeammate", DoNotGenerateAcw=true)]
	public partial class BCTeammate : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeammate']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/bluecats/sdk/BCTeammate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCTeammate); }
		}

		protected BCTeammate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getPerson;
#pragma warning disable 0169
		static Delegate GetGetPersonHandler ()
		{
			if (cb_getPerson == null)
				cb_getPerson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPerson);
			return cb_getPerson;
		}

		static IntPtr n_GetPerson (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeammate __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeammate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Person);
		}
#pragma warning restore 0169

		static Delegate cb_setPerson_Lcom_bluecats_sdk_BCPerson_;
#pragma warning disable 0169
		static Delegate GetSetPerson_Lcom_bluecats_sdk_BCPerson_Handler ()
		{
			if (cb_setPerson_Lcom_bluecats_sdk_BCPerson_ == null)
				cb_setPerson_Lcom_bluecats_sdk_BCPerson_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPerson_Lcom_bluecats_sdk_BCPerson_);
			return cb_setPerson_Lcom_bluecats_sdk_BCPerson_;
		}

		static void n_SetPerson_Lcom_bluecats_sdk_BCPerson_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p)
		{
			global::Com.Bluecats.Sdk.BCTeammate __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeammate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCPerson p = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPerson> (native_p, JniHandleOwnership.DoNotTransfer);
			__this.Person = p;
		}
#pragma warning restore 0169

		static IntPtr id_getPerson;
		static IntPtr id_setPerson_Lcom_bluecats_sdk_BCPerson_;
		public virtual unsafe global::Com.Bluecats.Sdk.BCPerson Person {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeammate']/method[@name='getPerson' and count(parameter)=0]"
			[Register ("getPerson", "()Lcom/bluecats/sdk/BCPerson;", "GetGetPersonHandler")]
			get {
				if (id_getPerson == IntPtr.Zero)
					id_getPerson = JNIEnv.GetMethodID (class_ref, "getPerson", "()Lcom/bluecats/sdk/BCPerson;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPerson> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPerson), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPerson> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPerson", "()Lcom/bluecats/sdk/BCPerson;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeammate']/method[@name='setPerson' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCPerson']]"
			[Register ("setPerson", "(Lcom/bluecats/sdk/BCPerson;)V", "GetSetPerson_Lcom_bluecats_sdk_BCPerson_Handler")]
			set {
				if (id_setPerson_Lcom_bluecats_sdk_BCPerson_ == IntPtr.Zero)
					id_setPerson_Lcom_bluecats_sdk_BCPerson_ = JNIEnv.GetMethodID (class_ref, "setPerson", "(Lcom/bluecats/sdk/BCPerson;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPerson_Lcom_bluecats_sdk_BCPerson_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPerson", "(Lcom/bluecats/sdk/BCPerson;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTeam;
#pragma warning disable 0169
		static Delegate GetGetTeamHandler ()
		{
			if (cb_getTeam == null)
				cb_getTeam = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTeam);
			return cb_getTeam;
		}

		static IntPtr n_GetTeam (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeammate __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeammate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Team);
		}
#pragma warning restore 0169

		static Delegate cb_setTeam_Lcom_bluecats_sdk_BCTeam_;
#pragma warning disable 0169
		static Delegate GetSetTeam_Lcom_bluecats_sdk_BCTeam_Handler ()
		{
			if (cb_setTeam_Lcom_bluecats_sdk_BCTeam_ == null)
				cb_setTeam_Lcom_bluecats_sdk_BCTeam_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTeam_Lcom_bluecats_sdk_BCTeam_);
			return cb_setTeam_Lcom_bluecats_sdk_BCTeam_;
		}

		static void n_SetTeam_Lcom_bluecats_sdk_BCTeam_ (IntPtr jnienv, IntPtr native__this, IntPtr native_team)
		{
			global::Com.Bluecats.Sdk.BCTeammate __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeammate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCTeam team = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (native_team, JniHandleOwnership.DoNotTransfer);
			__this.Team = team;
		}
#pragma warning restore 0169

		static IntPtr id_getTeam;
		static IntPtr id_setTeam_Lcom_bluecats_sdk_BCTeam_;
		public virtual unsafe global::Com.Bluecats.Sdk.BCTeam Team {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeammate']/method[@name='getTeam' and count(parameter)=0]"
			[Register ("getTeam", "()Lcom/bluecats/sdk/BCTeam;", "GetGetTeamHandler")]
			get {
				if (id_getTeam == IntPtr.Zero)
					id_getTeam = JNIEnv.GetMethodID (class_ref, "getTeam", "()Lcom/bluecats/sdk/BCTeam;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTeam), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeam> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTeam", "()Lcom/bluecats/sdk/BCTeam;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeammate']/method[@name='setTeam' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCTeam']]"
			[Register ("setTeam", "(Lcom/bluecats/sdk/BCTeam;)V", "GetSetTeam_Lcom_bluecats_sdk_BCTeam_Handler")]
			set {
				if (id_setTeam_Lcom_bluecats_sdk_BCTeam_ == IntPtr.Zero)
					id_setTeam_Lcom_bluecats_sdk_BCTeam_ = JNIEnv.GetMethodID (class_ref, "setTeam", "(Lcom/bluecats/sdk/BCTeam;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTeam_Lcom_bluecats_sdk_BCTeam_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTeam", "(Lcom/bluecats/sdk/BCTeam;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTeamRole;
#pragma warning disable 0169
		static Delegate GetGetTeamRoleHandler ()
		{
			if (cb_getTeamRole == null)
				cb_getTeamRole = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTeamRole);
			return cb_getTeamRole;
		}

		static IntPtr n_GetTeamRole (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeammate __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeammate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TeamRole);
		}
#pragma warning restore 0169

		static Delegate cb_setTeamRole_Lcom_bluecats_sdk_BCTeamRole_;
#pragma warning disable 0169
		static Delegate GetSetTeamRole_Lcom_bluecats_sdk_BCTeamRole_Handler ()
		{
			if (cb_setTeamRole_Lcom_bluecats_sdk_BCTeamRole_ == null)
				cb_setTeamRole_Lcom_bluecats_sdk_BCTeamRole_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTeamRole_Lcom_bluecats_sdk_BCTeamRole_);
			return cb_setTeamRole_Lcom_bluecats_sdk_BCTeamRole_;
		}

		static void n_SetTeamRole_Lcom_bluecats_sdk_BCTeamRole_ (IntPtr jnienv, IntPtr native__this, IntPtr native_teamRole)
		{
			global::Com.Bluecats.Sdk.BCTeammate __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeammate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCTeamRole teamRole = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamRole> (native_teamRole, JniHandleOwnership.DoNotTransfer);
			__this.TeamRole = teamRole;
		}
#pragma warning restore 0169

		static IntPtr id_getTeamRole;
		static IntPtr id_setTeamRole_Lcom_bluecats_sdk_BCTeamRole_;
		public virtual unsafe global::Com.Bluecats.Sdk.BCTeamRole TeamRole {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeammate']/method[@name='getTeamRole' and count(parameter)=0]"
			[Register ("getTeamRole", "()Lcom/bluecats/sdk/BCTeamRole;", "GetGetTeamRoleHandler")]
			get {
				if (id_getTeamRole == IntPtr.Zero)
					id_getTeamRole = JNIEnv.GetMethodID (class_ref, "getTeamRole", "()Lcom/bluecats/sdk/BCTeamRole;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamRole> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTeamRole), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeamRole> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTeamRole", "()Lcom/bluecats/sdk/BCTeamRole;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeammate']/method[@name='setTeamRole' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCTeamRole']]"
			[Register ("setTeamRole", "(Lcom/bluecats/sdk/BCTeamRole;)V", "GetSetTeamRole_Lcom_bluecats_sdk_BCTeamRole_Handler")]
			set {
				if (id_setTeamRole_Lcom_bluecats_sdk_BCTeamRole_ == IntPtr.Zero)
					id_setTeamRole_Lcom_bluecats_sdk_BCTeamRole_ = JNIEnv.GetMethodID (class_ref, "setTeamRole", "(Lcom/bluecats/sdk/BCTeamRole;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTeamRole_Lcom_bluecats_sdk_BCTeamRole_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTeamRole", "(Lcom/bluecats/sdk/BCTeamRole;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTeammateID;
#pragma warning disable 0169
		static Delegate GetGetTeammateIDHandler ()
		{
			if (cb_getTeammateID == null)
				cb_getTeammateID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTeammateID);
			return cb_getTeammateID;
		}

		static IntPtr n_GetTeammateID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCTeammate __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeammate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TeammateID);
		}
#pragma warning restore 0169

		static Delegate cb_setTeammateID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTeammateID_Ljava_lang_String_Handler ()
		{
			if (cb_setTeammateID_Ljava_lang_String_ == null)
				cb_setTeammateID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTeammateID_Ljava_lang_String_);
			return cb_setTeammateID_Ljava_lang_String_;
		}

		static void n_SetTeammateID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uuid)
		{
			global::Com.Bluecats.Sdk.BCTeammate __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeammate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string uuid = JNIEnv.GetString (native_uuid, JniHandleOwnership.DoNotTransfer);
			__this.TeammateID = uuid;
		}
#pragma warning restore 0169

		static IntPtr id_getTeammateID;
		static IntPtr id_setTeammateID_Ljava_lang_String_;
		public virtual unsafe string TeammateID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeammate']/method[@name='getTeammateID' and count(parameter)=0]"
			[Register ("getTeammateID", "()Ljava/lang/String;", "GetGetTeammateIDHandler")]
			get {
				if (id_getTeammateID == IntPtr.Zero)
					id_getTeammateID = JNIEnv.GetMethodID (class_ref, "getTeammateID", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTeammateID), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTeammateID", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeammate']/method[@name='setTeammateID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTeammateID", "(Ljava/lang/String;)V", "GetSetTeammateID_Ljava_lang_String_Handler")]
			set {
				if (id_setTeammateID_Ljava_lang_String_ == IntPtr.Zero)
					id_setTeammateID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTeammateID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTeammateID_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTeammateID", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Bluecats.Sdk.BCTeammate __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeammate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeammate']/method[@name='describeContents' and count(parameter)=0]"
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
			global::Com.Bluecats.Sdk.BCTeammate __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCTeammate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCTeammate']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
