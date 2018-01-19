using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Bluecats.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone']"
	[global::Android.Runtime.Register ("com/bluecats/sdk/BCZone", DoNotGenerateAcw=true)]
	public partial class BCZone : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone.BCZoneState']"
		[global::Android.Runtime.Register ("com/bluecats/sdk/BCZone$BCZoneState", DoNotGenerateAcw=true)]
		public sealed partial class BCZoneState : global::Java.Lang.Enum {


			static IntPtr BC_ZONE_STATE_INSIDE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone.BCZoneState']/field[@name='BC_ZONE_STATE_INSIDE']"
			[Register ("BC_ZONE_STATE_INSIDE")]
			public static global::Com.Bluecats.Sdk.BCZone.BCZoneState BcZoneStateInside {
				get {
					if (BC_ZONE_STATE_INSIDE_jfieldId == IntPtr.Zero)
						BC_ZONE_STATE_INSIDE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_ZONE_STATE_INSIDE", "Lcom/bluecats/sdk/BCZone$BCZoneState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_ZONE_STATE_INSIDE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone.BCZoneState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_ZONE_STATE_OUTSIDE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone.BCZoneState']/field[@name='BC_ZONE_STATE_OUTSIDE']"
			[Register ("BC_ZONE_STATE_OUTSIDE")]
			public static global::Com.Bluecats.Sdk.BCZone.BCZoneState BcZoneStateOutside {
				get {
					if (BC_ZONE_STATE_OUTSIDE_jfieldId == IntPtr.Zero)
						BC_ZONE_STATE_OUTSIDE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_ZONE_STATE_OUTSIDE", "Lcom/bluecats/sdk/BCZone$BCZoneState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_ZONE_STATE_OUTSIDE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone.BCZoneState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr BC_ZONE_STATE_UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone.BCZoneState']/field[@name='BC_ZONE_STATE_UNKNOWN']"
			[Register ("BC_ZONE_STATE_UNKNOWN")]
			public static global::Com.Bluecats.Sdk.BCZone.BCZoneState BcZoneStateUnknown {
				get {
					if (BC_ZONE_STATE_UNKNOWN_jfieldId == IntPtr.Zero)
						BC_ZONE_STATE_UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BC_ZONE_STATE_UNKNOWN", "Lcom/bluecats/sdk/BCZone$BCZoneState;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BC_ZONE_STATE_UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone.BCZoneState> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/bluecats/sdk/BCZone$BCZoneState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BCZoneState); }
			}

			internal BCZoneState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getName;
			public unsafe string Name {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone.BCZoneState']/method[@name='getName' and count(parameter)=0]"
				[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
				get {
					if (id_getName == IntPtr.Zero)
						id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
					try {
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_getValue;
			public unsafe int Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone.BCZoneState']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()I", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()I");
					try {
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getValue);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone.BCZoneState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCZone$BCZoneState;", "")]
			public static unsafe global::Com.Bluecats.Sdk.BCZone.BCZoneState ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/bluecats/sdk/BCZone$BCZoneState;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::Com.Bluecats.Sdk.BCZone.BCZoneState __ret = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone.BCZoneState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone.BCZoneState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/bluecats/sdk/BCZone$BCZoneState;", "")]
			public static unsafe global::Com.Bluecats.Sdk.BCZone.BCZoneState[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/bluecats/sdk/BCZone$BCZoneState;");
				try {
					return (global::Com.Bluecats.Sdk.BCZone.BCZoneState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Bluecats.Sdk.BCZone.BCZoneState));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/bluecats/sdk/BCZone", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BCZone); }
		}

		protected BCZone (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone']/constructor[@name='BCZone' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BCZone ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (BCZone)) {
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

		static Delegate cb_getEnteredZoneAt;
#pragma warning disable 0169
		static Delegate GetGetEnteredZoneAtHandler ()
		{
			if (cb_getEnteredZoneAt == null)
				cb_getEnteredZoneAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEnteredZoneAt);
			return cb_getEnteredZoneAt;
		}

		static IntPtr n_GetEnteredZoneAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCZone __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EnteredZoneAt);
		}
#pragma warning restore 0169

		static Delegate cb_setEnteredZoneAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetEnteredZoneAt_Ljava_util_Date_Handler ()
		{
			if (cb_setEnteredZoneAt_Ljava_util_Date_ == null)
				cb_setEnteredZoneAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEnteredZoneAt_Ljava_util_Date_);
			return cb_setEnteredZoneAt_Ljava_util_Date_;
		}

		static void n_SetEnteredZoneAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Com.Bluecats.Sdk.BCZone __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date date = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_date, JniHandleOwnership.DoNotTransfer);
			__this.EnteredZoneAt = date;
		}
#pragma warning restore 0169

		static IntPtr id_getEnteredZoneAt;
		static IntPtr id_setEnteredZoneAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date EnteredZoneAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone']/method[@name='getEnteredZoneAt' and count(parameter)=0]"
			[Register ("getEnteredZoneAt", "()Ljava/util/Date;", "GetGetEnteredZoneAtHandler")]
			get {
				if (id_getEnteredZoneAt == IntPtr.Zero)
					id_getEnteredZoneAt = JNIEnv.GetMethodID (class_ref, "getEnteredZoneAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEnteredZoneAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEnteredZoneAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone']/method[@name='setEnteredZoneAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setEnteredZoneAt", "(Ljava/util/Date;)V", "GetSetEnteredZoneAt_Ljava_util_Date_Handler")]
			set {
				if (id_setEnteredZoneAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setEnteredZoneAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setEnteredZoneAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEnteredZoneAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnteredZoneAt", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEntryCount;
#pragma warning disable 0169
		static Delegate GetGetEntryCountHandler ()
		{
			if (cb_getEntryCount == null)
				cb_getEntryCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEntryCount);
			return cb_getEntryCount;
		}

		static IntPtr n_GetEntryCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCZone __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EntryCount);
		}
#pragma warning restore 0169

		static IntPtr id_getEntryCount;
		public virtual unsafe global::Java.Lang.Integer EntryCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone']/method[@name='getEntryCount' and count(parameter)=0]"
			[Register ("getEntryCount", "()Ljava/lang/Integer;", "GetGetEntryCountHandler")]
			get {
				if (id_getEntryCount == IntPtr.Zero)
					id_getEntryCount = JNIEnv.GetMethodID (class_ref, "getEntryCount", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEntryCount), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEntryCount", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExitedZoneAt;
#pragma warning disable 0169
		static Delegate GetGetExitedZoneAtHandler ()
		{
			if (cb_getExitedZoneAt == null)
				cb_getExitedZoneAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExitedZoneAt);
			return cb_getExitedZoneAt;
		}

		static IntPtr n_GetExitedZoneAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCZone __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExitedZoneAt);
		}
#pragma warning restore 0169

		static Delegate cb_setExitedZoneAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetExitedZoneAt_Ljava_util_Date_Handler ()
		{
			if (cb_setExitedZoneAt_Ljava_util_Date_ == null)
				cb_setExitedZoneAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExitedZoneAt_Ljava_util_Date_);
			return cb_setExitedZoneAt_Ljava_util_Date_;
		}

		static void n_SetExitedZoneAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Com.Bluecats.Sdk.BCZone __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date date = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_date, JniHandleOwnership.DoNotTransfer);
			__this.ExitedZoneAt = date;
		}
#pragma warning restore 0169

		static IntPtr id_getExitedZoneAt;
		static IntPtr id_setExitedZoneAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date ExitedZoneAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone']/method[@name='getExitedZoneAt' and count(parameter)=0]"
			[Register ("getExitedZoneAt", "()Ljava/util/Date;", "GetGetExitedZoneAtHandler")]
			get {
				if (id_getExitedZoneAt == IntPtr.Zero)
					id_getExitedZoneAt = JNIEnv.GetMethodID (class_ref, "getExitedZoneAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExitedZoneAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExitedZoneAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone']/method[@name='setExitedZoneAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setExitedZoneAt", "(Ljava/util/Date;)V", "GetSetExitedZoneAt_Ljava_util_Date_Handler")]
			set {
				if (id_setExitedZoneAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setExitedZoneAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setExitedZoneAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExitedZoneAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExitedZoneAt", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIdentifier;
#pragma warning disable 0169
		static Delegate GetGetIdentifierHandler ()
		{
			if (cb_getIdentifier == null)
				cb_getIdentifier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIdentifier);
			return cb_getIdentifier;
		}

		static IntPtr n_GetIdentifier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCZone __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Identifier);
		}
#pragma warning restore 0169

		static IntPtr id_getIdentifier;
		public virtual unsafe string Identifier {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone']/method[@name='getIdentifier' and count(parameter)=0]"
			[Register ("getIdentifier", "()Ljava/lang/String;", "GetGetIdentifierHandler")]
			get {
				if (id_getIdentifier == IntPtr.Zero)
					id_getIdentifier = JNIEnv.GetMethodID (class_ref, "getIdentifier", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIdentifier), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIdentifier", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLastEnteredZoneAt;
#pragma warning disable 0169
		static Delegate GetGetLastEnteredZoneAtHandler ()
		{
			if (cb_getLastEnteredZoneAt == null)
				cb_getLastEnteredZoneAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastEnteredZoneAt);
			return cb_getLastEnteredZoneAt;
		}

		static IntPtr n_GetLastEnteredZoneAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCZone __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastEnteredZoneAt);
		}
#pragma warning restore 0169

		static IntPtr id_getLastEnteredZoneAt;
		public virtual unsafe global::Java.Util.Date LastEnteredZoneAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone']/method[@name='getLastEnteredZoneAt' and count(parameter)=0]"
			[Register ("getLastEnteredZoneAt", "()Ljava/util/Date;", "GetGetLastEnteredZoneAtHandler")]
			get {
				if (id_getLastEnteredZoneAt == IntPtr.Zero)
					id_getLastEnteredZoneAt = JNIEnv.GetMethodID (class_ref, "getLastEnteredZoneAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastEnteredZoneAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastEnteredZoneAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLastRangedBeaconsInZoneAt;
#pragma warning disable 0169
		static Delegate GetGetLastRangedBeaconsInZoneAtHandler ()
		{
			if (cb_getLastRangedBeaconsInZoneAt == null)
				cb_getLastRangedBeaconsInZoneAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastRangedBeaconsInZoneAt);
			return cb_getLastRangedBeaconsInZoneAt;
		}

		static IntPtr n_GetLastRangedBeaconsInZoneAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCZone __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastRangedBeaconsInZoneAt);
		}
#pragma warning restore 0169

		static Delegate cb_setLastRangedBeaconsInZoneAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetLastRangedBeaconsInZoneAt_Ljava_util_Date_Handler ()
		{
			if (cb_setLastRangedBeaconsInZoneAt_Ljava_util_Date_ == null)
				cb_setLastRangedBeaconsInZoneAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLastRangedBeaconsInZoneAt_Ljava_util_Date_);
			return cb_setLastRangedBeaconsInZoneAt_Ljava_util_Date_;
		}

		static void n_SetLastRangedBeaconsInZoneAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Com.Bluecats.Sdk.BCZone __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date date = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_date, JniHandleOwnership.DoNotTransfer);
			__this.LastRangedBeaconsInZoneAt = date;
		}
#pragma warning restore 0169

		static IntPtr id_getLastRangedBeaconsInZoneAt;
		static IntPtr id_setLastRangedBeaconsInZoneAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date LastRangedBeaconsInZoneAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone']/method[@name='getLastRangedBeaconsInZoneAt' and count(parameter)=0]"
			[Register ("getLastRangedBeaconsInZoneAt", "()Ljava/util/Date;", "GetGetLastRangedBeaconsInZoneAtHandler")]
			get {
				if (id_getLastRangedBeaconsInZoneAt == IntPtr.Zero)
					id_getLastRangedBeaconsInZoneAt = JNIEnv.GetMethodID (class_ref, "getLastRangedBeaconsInZoneAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastRangedBeaconsInZoneAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastRangedBeaconsInZoneAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone']/method[@name='setLastRangedBeaconsInZoneAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setLastRangedBeaconsInZoneAt", "(Ljava/util/Date;)V", "GetSetLastRangedBeaconsInZoneAt_Ljava_util_Date_Handler")]
			set {
				if (id_setLastRangedBeaconsInZoneAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setLastRangedBeaconsInZoneAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setLastRangedBeaconsInZoneAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastRangedBeaconsInZoneAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastRangedBeaconsInZoneAt", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPrefixLocationEventIdWithSiteName;
#pragma warning disable 0169
		static Delegate GetGetPrefixLocationEventIdWithSiteNameHandler ()
		{
			if (cb_getPrefixLocationEventIdWithSiteName == null)
				cb_getPrefixLocationEventIdWithSiteName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetPrefixLocationEventIdWithSiteName);
			return cb_getPrefixLocationEventIdWithSiteName;
		}

		static bool n_GetPrefixLocationEventIdWithSiteName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCZone __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PrefixLocationEventIdWithSiteName;
		}
#pragma warning restore 0169

		static Delegate cb_setPrefixLocationEventIdWithSiteName_Z;
#pragma warning disable 0169
		static Delegate GetSetPrefixLocationEventIdWithSiteName_ZHandler ()
		{
			if (cb_setPrefixLocationEventIdWithSiteName_Z == null)
				cb_setPrefixLocationEventIdWithSiteName_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPrefixLocationEventIdWithSiteName_Z);
			return cb_setPrefixLocationEventIdWithSiteName_Z;
		}

		static void n_SetPrefixLocationEventIdWithSiteName_Z (IntPtr jnienv, IntPtr native__this, bool b)
		{
			global::Com.Bluecats.Sdk.BCZone __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PrefixLocationEventIdWithSiteName = b;
		}
#pragma warning restore 0169

		static IntPtr id_getPrefixLocationEventIdWithSiteName;
		static IntPtr id_setPrefixLocationEventIdWithSiteName_Z;
		public virtual unsafe bool PrefixLocationEventIdWithSiteName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone']/method[@name='getPrefixLocationEventIdWithSiteName' and count(parameter)=0]"
			[Register ("getPrefixLocationEventIdWithSiteName", "()Z", "GetGetPrefixLocationEventIdWithSiteNameHandler")]
			get {
				if (id_getPrefixLocationEventIdWithSiteName == IntPtr.Zero)
					id_getPrefixLocationEventIdWithSiteName = JNIEnv.GetMethodID (class_ref, "getPrefixLocationEventIdWithSiteName", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getPrefixLocationEventIdWithSiteName);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPrefixLocationEventIdWithSiteName", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone']/method[@name='setPrefixLocationEventIdWithSiteName' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPrefixLocationEventIdWithSiteName", "(Z)V", "GetSetPrefixLocationEventIdWithSiteName_ZHandler")]
			set {
				if (id_setPrefixLocationEventIdWithSiteName_Z == IntPtr.Zero)
					id_setPrefixLocationEventIdWithSiteName_Z = JNIEnv.GetMethodID (class_ref, "setPrefixLocationEventIdWithSiteName", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPrefixLocationEventIdWithSiteName_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPrefixLocationEventIdWithSiteName", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getReenteredZoneAt;
#pragma warning disable 0169
		static Delegate GetGetReenteredZoneAtHandler ()
		{
			if (cb_getReenteredZoneAt == null)
				cb_getReenteredZoneAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReenteredZoneAt);
			return cb_getReenteredZoneAt;
		}

		static IntPtr n_GetReenteredZoneAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCZone __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReenteredZoneAt);
		}
#pragma warning restore 0169

		static Delegate cb_setReenteredZoneAt_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetReenteredZoneAt_Ljava_util_Date_Handler ()
		{
			if (cb_setReenteredZoneAt_Ljava_util_Date_ == null)
				cb_setReenteredZoneAt_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReenteredZoneAt_Ljava_util_Date_);
			return cb_setReenteredZoneAt_Ljava_util_Date_;
		}

		static void n_SetReenteredZoneAt_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Com.Bluecats.Sdk.BCZone __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date date = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_date, JniHandleOwnership.DoNotTransfer);
			__this.ReenteredZoneAt = date;
		}
#pragma warning restore 0169

		static IntPtr id_getReenteredZoneAt;
		static IntPtr id_setReenteredZoneAt_Ljava_util_Date_;
		public virtual unsafe global::Java.Util.Date ReenteredZoneAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone']/method[@name='getReenteredZoneAt' and count(parameter)=0]"
			[Register ("getReenteredZoneAt", "()Ljava/util/Date;", "GetGetReenteredZoneAtHandler")]
			get {
				if (id_getReenteredZoneAt == IntPtr.Zero)
					id_getReenteredZoneAt = JNIEnv.GetMethodID (class_ref, "getReenteredZoneAt", "()Ljava/util/Date;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReenteredZoneAt), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReenteredZoneAt", "()Ljava/util/Date;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone']/method[@name='setReenteredZoneAt' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
			[Register ("setReenteredZoneAt", "(Ljava/util/Date;)V", "GetSetReenteredZoneAt_Ljava_util_Date_Handler")]
			set {
				if (id_setReenteredZoneAt_Ljava_util_Date_ == IntPtr.Zero)
					id_setReenteredZoneAt_Ljava_util_Date_ = JNIEnv.GetMethodID (class_ref, "setReenteredZoneAt", "(Ljava/util/Date;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReenteredZoneAt_Ljava_util_Date_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReenteredZoneAt", "(Ljava/util/Date;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getZoneSite;
#pragma warning disable 0169
		static Delegate GetGetZoneSiteHandler ()
		{
			if (cb_getZoneSite == null)
				cb_getZoneSite = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetZoneSite);
			return cb_getZoneSite;
		}

		static IntPtr n_GetZoneSite (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCZone __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ZoneSite);
		}
#pragma warning restore 0169

		static Delegate cb_setZoneSite_Lcom_bluecats_sdk_BCSite_;
#pragma warning disable 0169
		static Delegate GetSetZoneSite_Lcom_bluecats_sdk_BCSite_Handler ()
		{
			if (cb_setZoneSite_Lcom_bluecats_sdk_BCSite_ == null)
				cb_setZoneSite_Lcom_bluecats_sdk_BCSite_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetZoneSite_Lcom_bluecats_sdk_BCSite_);
			return cb_setZoneSite_Lcom_bluecats_sdk_BCSite_;
		}

		static void n_SetZoneSite_Lcom_bluecats_sdk_BCSite_ (IntPtr jnienv, IntPtr native__this, IntPtr native_site)
		{
			global::Com.Bluecats.Sdk.BCZone __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.IBCSite site = (global::Com.Bluecats.Sdk.IBCSite)global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (native_site, JniHandleOwnership.DoNotTransfer);
			__this.ZoneSite = site;
		}
#pragma warning restore 0169

		static IntPtr id_getZoneSite;
		static IntPtr id_setZoneSite_Lcom_bluecats_sdk_BCSite_;
		public virtual unsafe global::Com.Bluecats.Sdk.IBCSite ZoneSite {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone']/method[@name='getZoneSite' and count(parameter)=0]"
			[Register ("getZoneSite", "()Lcom/bluecats/sdk/BCSite;", "GetGetZoneSiteHandler")]
			get {
				if (id_getZoneSite == IntPtr.Zero)
					id_getZoneSite = JNIEnv.GetMethodID (class_ref, "getZoneSite", "()Lcom/bluecats/sdk/BCSite;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getZoneSite), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.IBCSite> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZoneSite", "()Lcom/bluecats/sdk/BCSite;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone']/method[@name='setZoneSite' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCSite']]"
			[Register ("setZoneSite", "(Lcom/bluecats/sdk/BCSite;)V", "GetSetZoneSite_Lcom_bluecats_sdk_BCSite_Handler")]
			set {
				if (id_setZoneSite_Lcom_bluecats_sdk_BCSite_ == IntPtr.Zero)
					id_setZoneSite_Lcom_bluecats_sdk_BCSite_ = JNIEnv.GetMethodID (class_ref, "setZoneSite", "(Lcom/bluecats/sdk/BCSite;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZoneSite_Lcom_bluecats_sdk_BCSite_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZoneSite", "(Lcom/bluecats/sdk/BCSite;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getZoneState;
#pragma warning disable 0169
		static Delegate GetGetZoneStateHandler ()
		{
			if (cb_getZoneState == null)
				cb_getZoneState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetZoneState);
			return cb_getZoneState;
		}

		static IntPtr n_GetZoneState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCZone __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ZoneState);
		}
#pragma warning restore 0169

		static Delegate cb_setZoneState_Lcom_bluecats_sdk_BCZone_BCZoneState_;
#pragma warning disable 0169
		static Delegate GetSetZoneState_Lcom_bluecats_sdk_BCZone_BCZoneState_Handler ()
		{
			if (cb_setZoneState_Lcom_bluecats_sdk_BCZone_BCZoneState_ == null)
				cb_setZoneState_Lcom_bluecats_sdk_BCZone_BCZoneState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetZoneState_Lcom_bluecats_sdk_BCZone_BCZoneState_);
			return cb_setZoneState_Lcom_bluecats_sdk_BCZone_BCZoneState_;
		}

		static void n_SetZoneState_Lcom_bluecats_sdk_BCZone_BCZoneState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_state)
		{
			global::Com.Bluecats.Sdk.BCZone __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Bluecats.Sdk.BCZone.BCZoneState state = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone.BCZoneState> (native_state, JniHandleOwnership.DoNotTransfer);
			__this.ZoneState = state;
		}
#pragma warning restore 0169

		static IntPtr id_getZoneState;
		static IntPtr id_setZoneState_Lcom_bluecats_sdk_BCZone_BCZoneState_;
		public virtual unsafe global::Com.Bluecats.Sdk.BCZone.BCZoneState ZoneState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone']/method[@name='getZoneState' and count(parameter)=0]"
			[Register ("getZoneState", "()Lcom/bluecats/sdk/BCZone$BCZoneState;", "GetGetZoneStateHandler")]
			get {
				if (id_getZoneState == IntPtr.Zero)
					id_getZoneState = JNIEnv.GetMethodID (class_ref, "getZoneState", "()Lcom/bluecats/sdk/BCZone$BCZoneState;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone.BCZoneState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getZoneState), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone.BCZoneState> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZoneState", "()Lcom/bluecats/sdk/BCZone$BCZoneState;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone']/method[@name='setZoneState' and count(parameter)=1 and parameter[1][@type='com.bluecats.sdk.BCZone.BCZoneState']]"
			[Register ("setZoneState", "(Lcom/bluecats/sdk/BCZone$BCZoneState;)V", "GetSetZoneState_Lcom_bluecats_sdk_BCZone_BCZoneState_Handler")]
			set {
				if (id_setZoneState_Lcom_bluecats_sdk_BCZone_BCZoneState_ == IntPtr.Zero)
					id_setZoneState_Lcom_bluecats_sdk_BCZone_BCZoneState_ = JNIEnv.GetMethodID (class_ref, "setZoneState", "(Lcom/bluecats/sdk/BCZone$BCZoneState;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZoneState_Lcom_bluecats_sdk_BCZone_BCZoneState_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZoneState", "(Lcom/bluecats/sdk/BCZone$BCZoneState;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_decreaseEntryCount;
#pragma warning disable 0169
		static Delegate GetDecreaseEntryCountHandler ()
		{
			if (cb_decreaseEntryCount == null)
				cb_decreaseEntryCount = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DecreaseEntryCount);
			return cb_decreaseEntryCount;
		}

		static void n_DecreaseEntryCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCZone __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DecreaseEntryCount ();
		}
#pragma warning restore 0169

		static IntPtr id_decreaseEntryCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone']/method[@name='decreaseEntryCount' and count(parameter)=0]"
		[Register ("decreaseEntryCount", "()V", "GetDecreaseEntryCountHandler")]
		public virtual unsafe void DecreaseEntryCount ()
		{
			if (id_decreaseEntryCount == IntPtr.Zero)
				id_decreaseEntryCount = JNIEnv.GetMethodID (class_ref, "decreaseEntryCount", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_decreaseEntryCount);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "decreaseEntryCount", "()V"));
			} finally {
			}
		}

		static Delegate cb_increaseEntryCount;
#pragma warning disable 0169
		static Delegate GetIncreaseEntryCountHandler ()
		{
			if (cb_increaseEntryCount == null)
				cb_increaseEntryCount = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_IncreaseEntryCount);
			return cb_increaseEntryCount;
		}

		static void n_IncreaseEntryCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluecats.Sdk.BCZone __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IncreaseEntryCount ();
		}
#pragma warning restore 0169

		static IntPtr id_increaseEntryCount;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone']/method[@name='increaseEntryCount' and count(parameter)=0]"
		[Register ("increaseEntryCount", "()V", "GetIncreaseEntryCountHandler")]
		public virtual unsafe void IncreaseEntryCount ()
		{
			if (id_increaseEntryCount == IntPtr.Zero)
				id_increaseEntryCount = JNIEnv.GetMethodID (class_ref, "increaseEntryCount", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_increaseEntryCount);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "increaseEntryCount", "()V"));
			} finally {
			}
		}

		static Delegate cb_setZoneId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetZoneId_Ljava_lang_String_Handler ()
		{
			if (cb_setZoneId_Ljava_lang_String_ == null)
				cb_setZoneId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetZoneId_Ljava_lang_String_);
			return cb_setZoneId_Ljava_lang_String_;
		}

		static void n_SetZoneId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_id)
		{
			global::Com.Bluecats.Sdk.BCZone __this = global::Java.Lang.Object.GetObject<global::Com.Bluecats.Sdk.BCZone> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string id = JNIEnv.GetString (native_id, JniHandleOwnership.DoNotTransfer);
			__this.SetZoneId (id);
		}
#pragma warning restore 0169

		static IntPtr id_setZoneId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluecats.sdk']/class[@name='BCZone']/method[@name='setZoneId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setZoneId", "(Ljava/lang/String;)V", "GetSetZoneId_Ljava_lang_String_Handler")]
		public virtual unsafe void SetZoneId (string id)
		{
			if (id_setZoneId_Ljava_lang_String_ == IntPtr.Zero)
				id_setZoneId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setZoneId", "(Ljava/lang/String;)V");
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_id);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZoneId_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZoneId", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

	}
}
