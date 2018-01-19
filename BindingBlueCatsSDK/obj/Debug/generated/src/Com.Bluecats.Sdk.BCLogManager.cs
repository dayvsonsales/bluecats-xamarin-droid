using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLogManager']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCLogManager", DoNotGenerateAcw=true)]
	public partial class BCLogManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLogManager']/field[@name='BC_LOG_LEVEL_LESS']"
		[Register ("BC_LOG_LEVEL_LESS")]
		public const int BcLogLevelLess = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLogManager']/field[@name='BC_LOG_LEVEL_MEDIUM']"
		[Register ("BC_LOG_LEVEL_MEDIUM")]
		public const int BcLogLevelMedium = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLogManager']/field[@name='BC_LOG_LEVEL_MORE']"
		[Register ("BC_LOG_LEVEL_MORE")]
		public const int BcLogLevelMore = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLogManager']/field[@name='BC_LOG_LEVEL_NONE']"
		[Register ("BC_LOG_LEVEL_NONE")]
		public const int BcLogLevelNone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLogManager']/field[@name='BC_LOG_TYPE_NETWORK']"
		[Register ("BC_LOG_TYPE_NETWORK")]
		public const int BcLogTypeNetwork = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLogManager']/field[@name='BC_LOG_TYPE_RANGER']"
		[Register ("BC_LOG_TYPE_RANGER")]
		public const int BcLogTypeRanger = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLogManager']/field[@name='BC_LOG_TYPE_SCANNER']"
		[Register ("BC_LOG_TYPE_SCANNER")]
		public const int BcLogTypeScanner = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLogManager']/field[@name='BC_LOG_TYPE_UNKNOWN']"
		[Register ("BC_LOG_TYPE_UNKNOWN")]
		public const int BcLogTypeUnknown = (int) 0;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCLogManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCLogManager); }
		}

		protected BCLogManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Bluecats.Sdk.BCLogManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLogManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/bluecats/sdk/BCLogManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/bluecats/sdk/BCLogManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLogManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setLogLevel_II;
#pragma warning disable 0169
		static Delegate GetSetLogLevel_IIHandler ()
		{
			if (cb_setLogLevel_II == null)
				cb_setLogLevel_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetLogLevel_II);
			return cb_setLogLevel_II;
		}

		static void n_SetLogLevel_II (IntPtr jnienv, IntPtr native__this, int logType, int level)
		{
			global::Com.Bluecats.Sdk.BCLogManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCLogManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLogLevel (logType, level);
		}
#pragma warning restore 0169

		static IntPtr id_setLogLevel_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCLogManager']/method[@name='setLogLevel' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setLogLevel", "(II)V", "GetSetLogLevel_IIHandler")]
		public virtual unsafe void SetLogLevel (int logType, int level)
		{
			if (id_setLogLevel_II == IntPtr.Zero)
				id_setLogLevel_II = JNIEnv.GetMethodID (class_ref, "setLogLevel", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (logType);
				__args [1] = new JValue (level);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLogLevel_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLogLevel", "(II)V"), __args);
			} finally {
			}
		}

	}
}
