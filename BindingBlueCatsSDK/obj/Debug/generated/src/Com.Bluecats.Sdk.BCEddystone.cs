using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEddystone']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCEddystone", DoNotGenerateAcw=true)]
	public sealed partial class BCEddystone : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEddystone']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/bluecats/sdk/BCEddystone", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCEddystone); }
		}

		internal BCEddystone (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEddystone']/constructor[@name='BCEddystone' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCEddystone ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCEddystone)) {
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

		static IntPtr id_getEncodedUrl;
		static IntPtr id_setEncodedUrl_Ljava_lang_String_;
		public unsafe string EncodedUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEddystone']/method[@name='getEncodedUrl' and count(parameter)=0]"
			[Register ("getEncodedUrl", "()Ljava/lang/String;", "GetGetEncodedUrlHandler")]
			get {
				if (id_getEncodedUrl == IntPtr.Zero)
					id_getEncodedUrl = JNIEnv.GetMethodID (class_ref, "getEncodedUrl", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEncodedUrl), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEddystone']/method[@name='setEncodedUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEncodedUrl", "(Ljava/lang/String;)V", "GetSetEncodedUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setEncodedUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setEncodedUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEncodedUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEncodedUrl_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getInstanceID;
		static IntPtr id_setInstanceID_Ljava_lang_String_;
		public unsafe string InstanceID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEddystone']/method[@name='getInstanceID' and count(parameter)=0]"
			[Register ("getInstanceID", "()Ljava/lang/String;", "GetGetInstanceIDHandler")]
			get {
				if (id_getInstanceID == IntPtr.Zero)
					id_getInstanceID = JNIEnv.GetMethodID (class_ref, "getInstanceID", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInstanceID), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEddystone']/method[@name='setInstanceID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setInstanceID", "(Ljava/lang/String;)V", "GetSetInstanceID_Ljava_lang_String_Handler")]
			set {
				if (id_setInstanceID_Ljava_lang_String_ == IntPtr.Zero)
					id_setInstanceID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setInstanceID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInstanceID_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getNamespaceID;
		static IntPtr id_setNamespaceID_Ljava_lang_String_;
		public unsafe string NamespaceID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEddystone']/method[@name='getNamespaceID' and count(parameter)=0]"
			[Register ("getNamespaceID", "()Ljava/lang/String;", "GetGetNamespaceIDHandler")]
			get {
				if (id_getNamespaceID == IntPtr.Zero)
					id_getNamespaceID = JNIEnv.GetMethodID (class_ref, "getNamespaceID", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNamespaceID), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEddystone']/method[@name='setNamespaceID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNamespaceID", "(Ljava/lang/String;)V", "GetSetNamespaceID_Ljava_lang_String_Handler")]
			set {
				if (id_setNamespaceID_Ljava_lang_String_ == IntPtr.Zero)
					id_setNamespaceID_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNamespaceID", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNamespaceID_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getURL;
		static IntPtr id_setURL_Ljava_lang_String_;
		public unsafe string URL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEddystone']/method[@name='getURL' and count(parameter)=0]"
			[Register ("getURL", "()Ljava/lang/String;", "GetGetURLHandler")]
			get {
				if (id_getURL == IntPtr.Zero)
					id_getURL = JNIEnv.GetMethodID (class_ref, "getURL", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getURL), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEddystone']/method[@name='setURL' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setURL", "(Ljava/lang/String;)V", "GetSetURL_Ljava_lang_String_Handler")]
			set {
				if (id_setURL_Ljava_lang_String_ == IntPtr.Zero)
					id_setURL_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setURL", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setURL_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getUid;
		static IntPtr id_setUid_Ljava_lang_String_;
		public unsafe string Uid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEddystone']/method[@name='getUid' and count(parameter)=0]"
			[Register ("getUid", "()Ljava/lang/String;", "GetGetUidHandler")]
			get {
				if (id_getUid == IntPtr.Zero)
					id_getUid = JNIEnv.GetMethodID (class_ref, "getUid", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUid), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEddystone']/method[@name='setUid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUid", "(Ljava/lang/String;)V", "GetSetUid_Ljava_lang_String_Handler")]
			set {
				if (id_setUid_Ljava_lang_String_ == IntPtr.Zero)
					id_setUid_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUid", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUid_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getUrlSchemePrefixID;
		static IntPtr id_setUrlSchemePrefixID_Ljava_lang_Integer_;
		public unsafe global::Java.Lang.Integer UrlSchemePrefixID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEddystone']/method[@name='getUrlSchemePrefixID' and count(parameter)=0]"
			[Register ("getUrlSchemePrefixID", "()Ljava/lang/Integer;", "GetGetUrlSchemePrefixIDHandler")]
			get {
				if (id_getUrlSchemePrefixID == IntPtr.Zero)
					id_getUrlSchemePrefixID = JNIEnv.GetMethodID (class_ref, "getUrlSchemePrefixID", "()Ljava/lang/Integer;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrlSchemePrefixID), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEddystone']/method[@name='setUrlSchemePrefixID' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setUrlSchemePrefixID", "(Ljava/lang/Integer;)V", "GetSetUrlSchemePrefixID_Ljava_lang_Integer_Handler")]
			set {
				if (id_setUrlSchemePrefixID_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setUrlSchemePrefixID_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setUrlSchemePrefixID", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUrlSchemePrefixID_Ljava_lang_Integer_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_copy_Lcom_bluecats_sdk_BCEddystone_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEddystone']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCEddystone']]"
		[Register ("copy", "(Lcom/bluecats/sdk/BCEddystone;)V", "")]
		public unsafe void Copy (global::Com.Bluecats.Sdk.BCEddystone src)
		{
			if (id_copy_Lcom_bluecats_sdk_BCEddystone_ == IntPtr.Zero)
				id_copy_Lcom_bluecats_sdk_BCEddystone_ = JNIEnv.GetMethodID (class_ref, "copy", "(Lcom/bluecats/sdk/BCEddystone;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (src);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_copy_Lcom_bluecats_sdk_BCEddystone_, __args);
			} finally {
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEddystone']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
			} finally {
			}
		}

		static IntPtr id_getEncodedUrlData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEddystone']/method[@name='getEncodedUrlData' and count(parameter)=0]"
		[Register ("getEncodedUrlData", "()[B", "")]
		public unsafe byte[] GetEncodedUrlData ()
		{
			if (id_getEncodedUrlData == IntPtr.Zero)
				id_getEncodedUrlData = JNIEnv.GetMethodID (class_ref, "getEncodedUrlData", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEncodedUrlData), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_getNamespaceIDAndInstanceIDFromUIDString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEddystone']/method[@name='getNamespaceIDAndInstanceIDFromUIDString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getNamespaceIDAndInstanceIDFromUIDString", "(Ljava/lang/String;)[Ljava/lang/String;", "")]
		public static unsafe string[] GetNamespaceIDAndInstanceIDFromUIDString (string uidString)
		{
			if (id_getNamespaceIDAndInstanceIDFromUIDString_Ljava_lang_String_ == IntPtr.Zero)
				id_getNamespaceIDAndInstanceIDFromUIDString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getNamespaceIDAndInstanceIDFromUIDString", "(Ljava/lang/String;)[Ljava/lang/String;");
			IntPtr native_uidString = JNIEnv.NewString (uidString);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_uidString);
				string[] __ret = (string[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getNamespaceIDAndInstanceIDFromUIDString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_uidString);
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCEddystone']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (dest);
				__args [1] = new JValue ((int) flags);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			} finally {
			}
		}

	}
}
