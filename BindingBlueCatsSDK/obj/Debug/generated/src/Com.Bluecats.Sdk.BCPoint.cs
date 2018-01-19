using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPoint']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCPoint", DoNotGenerateAcw=true)]
	public partial class BCPoint : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPoint']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/bluecats/sdk/BCPoint", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCPoint); }
		}

		protected BCPoint (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPoint']/constructor[@name='BCPoint' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCPoint ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCPoint)) {
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

		static IntPtr id_ctor_Lcom_bluecats_sdk_BCPoint_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPoint']/constructor[@name='BCPoint' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCPoint']]"
		[Register (".ctor", "(Lcom/bluecats/sdk/BCPoint;)V", "")]
		public unsafe BCPoint (global::Com.Bluecats.Sdk.BCPoint point)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (point);
				if (((object) this).GetType () != typeof (BCPoint)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/bluecats/sdk/BCPoint;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/bluecats/sdk/BCPoint;)V", __args);
					return;
				}

				if (id_ctor_Lcom_bluecats_sdk_BCPoint_ == IntPtr.Zero)
					id_ctor_Lcom_bluecats_sdk_BCPoint_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/bluecats/sdk/BCPoint;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_bluecats_sdk_BCPoint_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_bluecats_sdk_BCPoint_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_Double_Ljava_lang_Double_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPoint']/constructor[@name='BCPoint' and count(parameter)=2 and parameter[1][@type='java.lang.Double'] and parameter[2][@type='java.lang.Double']]"
		[Register (".ctor", "(Ljava/lang/Double;Ljava/lang/Double;)V", "")]
		public unsafe BCPoint (global::Java.Lang.Double _x, global::Java.Lang.Double _y)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (_x);
				__args [1] = new JValue (_y);
				if (((object) this).GetType () != typeof (BCPoint)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Double;Ljava/lang/Double;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Double;Ljava/lang/Double;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Double_Ljava_lang_Double_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Double_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Double;Ljava/lang/Double;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Double_Ljava_lang_Double_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Double_Ljava_lang_Double_, __args);
			} finally {
			}
		}

		static Delegate cb_copy;
#pragma warning disable 0169
		static Delegate GetCopyHandler ()
		{
			if (cb_copy == null)
				cb_copy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Copy);
			return cb_copy;
		}

		static IntPtr n_Copy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCPoint __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Copy ());
		}
#pragma warning restore 0169

		static IntPtr id_copy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPoint']/method[@name='copy' and count(parameter)=0]"
		[Register ("copy", "()Lcom/bluecats/sdk/BCPoint;", "GetCopyHandler")]
		public virtual unsafe global::Com.Bluecats.Sdk.BCPoint Copy ()
		{
			if (id_copy == IntPtr.Zero)
				id_copy = JNIEnv.GetMethodID (class_ref, "copy", "()Lcom/bluecats/sdk/BCPoint;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPoint> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_copy), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPoint> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "copy", "()Lcom/bluecats/sdk/BCPoint;")), JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::Com.Bluecats.Sdk.BCPoint __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPoint']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_getX;
#pragma warning disable 0169
		static Delegate GetGetXHandler ()
		{
			if (cb_getX == null)
				cb_getX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetX);
			return cb_getX;
		}

		static IntPtr n_GetX (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCPoint __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetX ());
		}
#pragma warning restore 0169

		static IntPtr id_getX;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPoint']/method[@name='getX' and count(parameter)=0]"
		[Register ("getX", "()Ljava/lang/Double;", "GetGetXHandler")]
		public virtual unsafe global::Java.Lang.Double GetX ()
		{
			if (id_getX == IntPtr.Zero)
				id_getX = JNIEnv.GetMethodID (class_ref, "getX", "()Ljava/lang/Double;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getX), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getX", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getY;
#pragma warning disable 0169
		static Delegate GetGetYHandler ()
		{
			if (cb_getY == null)
				cb_getY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetY);
			return cb_getY;
		}

		static IntPtr n_GetY (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCPoint __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetY ());
		}
#pragma warning restore 0169

		static IntPtr id_getY;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPoint']/method[@name='getY' and count(parameter)=0]"
		[Register ("getY", "()Ljava/lang/Double;", "GetGetYHandler")]
		public virtual unsafe global::Java.Lang.Double GetY ()
		{
			if (id_getY == IntPtr.Zero)
				id_getY = JNIEnv.GetMethodID (class_ref, "getY", "()Ljava/lang/Double;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getY), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getY", "()Ljava/lang/Double;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_set_Ljava_lang_Double_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSet_Ljava_lang_Double_Ljava_lang_Double_Handler ()
		{
			if (cb_set_Ljava_lang_Double_Ljava_lang_Double_ == null)
				cb_set_Ljava_lang_Double_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Ljava_lang_Double_Ljava_lang_Double_);
			return cb_set_Ljava_lang_Double_Ljava_lang_Double_;
		}

		static void n_Set_Ljava_lang_Double_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native__x, IntPtr native__y)
		{
			global::Com.Bluecats.Sdk.BCPoint __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double _x = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native__x, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double _y = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native__y, JniHandleOwnership.DoNotTransfer);
			__this.Set (_x, _y);
		}
#pragma warning restore 0169

		static IntPtr id_set_Ljava_lang_Double_Ljava_lang_Double_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPoint']/method[@name='set' and count(parameter)=2 and parameter[1][@type='java.lang.Double'] and parameter[2][@type='java.lang.Double']]"
		[Register ("set", "(Ljava/lang/Double;Ljava/lang/Double;)V", "GetSet_Ljava_lang_Double_Ljava_lang_Double_Handler")]
		public virtual unsafe void Set (global::Java.Lang.Double _x, global::Java.Lang.Double _y)
		{
			if (id_set_Ljava_lang_Double_Ljava_lang_Double_ == IntPtr.Zero)
				id_set_Ljava_lang_Double_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "set", "(Ljava/lang/Double;Ljava/lang/Double;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (_x);
				__args [1] = new JValue (_y);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_set_Ljava_lang_Double_Ljava_lang_Double_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "set", "(Ljava/lang/Double;Ljava/lang/Double;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setX_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetX_Ljava_lang_Double_Handler ()
		{
			if (cb_setX_Ljava_lang_Double_ == null)
				cb_setX_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetX_Ljava_lang_Double_);
			return cb_setX_Ljava_lang_Double_;
		}

		static void n_SetX_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCPoint __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double value = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SetX (value);
		}
#pragma warning restore 0169

		static IntPtr id_setX_Ljava_lang_Double_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPoint']/method[@name='setX' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
		[Register ("setX", "(Ljava/lang/Double;)V", "GetSetX_Ljava_lang_Double_Handler")]
		public virtual unsafe void SetX (global::Java.Lang.Double value)
		{
			if (id_setX_Ljava_lang_Double_ == IntPtr.Zero)
				id_setX_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setX", "(Ljava/lang/Double;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setX_Ljava_lang_Double_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setX", "(Ljava/lang/Double;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setY_Ljava_lang_Double_;
#pragma warning disable 0169
		static Delegate GetSetY_Ljava_lang_Double_Handler ()
		{
			if (cb_setY_Ljava_lang_Double_ == null)
				cb_setY_Ljava_lang_Double_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetY_Ljava_lang_Double_);
			return cb_setY_Ljava_lang_Double_;
		}

		static void n_SetY_Ljava_lang_Double_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Bluecats.Sdk.BCPoint __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Double value = global::Java.Lang.Object.GetObject<global::Java.Lang.Double> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SetY (value);
		}
#pragma warning restore 0169

		static IntPtr id_setY_Ljava_lang_Double_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPoint']/method[@name='setY' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
		[Register ("setY", "(Ljava/lang/Double;)V", "GetSetY_Ljava_lang_Double_Handler")]
		public virtual unsafe void SetY (global::Java.Lang.Double value)
		{
			if (id_setY_Ljava_lang_Double_ == IntPtr.Zero)
				id_setY_Ljava_lang_Double_ = JNIEnv.GetMethodID (class_ref, "setY", "(Ljava/lang/Double;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setY_Ljava_lang_Double_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setY", "(Ljava/lang/Double;)V"), __args);
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
			global::Com.Bluecats.Sdk.BCPoint __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCPoint> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCPoint']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
