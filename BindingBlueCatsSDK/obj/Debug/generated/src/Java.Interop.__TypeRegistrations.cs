using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/bluecats/sdk",
					},
					new Converter<string, Type>[]{
						lookup_com_bluecats_sdk_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_bluecats_sdk_mappings;
		static Type lookup_com_bluecats_sdk_package (string klass)
		{
			if (package_com_bluecats_sdk_mappings == null) {
				package_com_bluecats_sdk_mappings = new string[]{
					"com/bluecats/sdk/BCBeacon$BCBeaconState:Com.Bluecats.Sdk.BCBeaconBCBeaconState",
					"com/bluecats/sdk/BCBeacon$BCProximity:Com.Bluecats.Sdk.BCBeaconBCProximity",
					"com/bluecats/sdk/BCBeacon$BCSyncStatus:Com.Bluecats.Sdk.BCBeaconBCSyncStatus",
					"com/bluecats/sdk/BCBeacon$BCVerificationStatus:Com.Bluecats.Sdk.BCBeaconBCVerificationStatus",
					"com/bluecats/sdk/BCSite$BCSiteState:Com.Bluecats.Sdk.BCSiteBCSiteState",
				};
			}

			return Lookup (package_com_bluecats_sdk_mappings, klass);
		}
	}
}
