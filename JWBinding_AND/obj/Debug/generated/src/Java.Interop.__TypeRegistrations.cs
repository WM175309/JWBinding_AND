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
						"com/google/ads/interactivemedia/v3/api",
						"com/google/android/exoplayer",
						"com/google/android/exoplayer/drm",
						"com/google/android/exoplayer/extractor",
					},
					new Converter<string, Type>[]{
						lookup_com_google_ads_interactivemedia_v3_api_package,
						lookup_com_google_android_exoplayer_package,
						lookup_com_google_android_exoplayer_drm_package,
						lookup_com_google_android_exoplayer_extractor_package,
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

		static string[] package_com_google_ads_interactivemedia_v3_api_mappings;
		static Type lookup_com_google_ads_interactivemedia_v3_api_package (string klass)
		{
			if (package_com_google_ads_interactivemedia_v3_api_mappings == null) {
				package_com_google_ads_interactivemedia_v3_api_mappings = new string[]{
					"com/google/ads/interactivemedia/v3/api/AdEvent$AdEventType:Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType",
				};
			}

			return Lookup (package_com_google_ads_interactivemedia_v3_api_mappings, klass);
		}

		static string[] package_com_google_android_exoplayer_mappings;
		static Type lookup_com_google_android_exoplayer_package (string klass)
		{
			if (package_com_google_android_exoplayer_mappings == null) {
				package_com_google_android_exoplayer_mappings = new string[]{
					"com/google/android/exoplayer/MediaCodecSelector$1:Com.Google.Android.Exoplayer.MediaCodecSelector1",
					"com/google/android/exoplayer/TimeRange$DynamicTimeRange:Com.Google.Android.Exoplayer.TimeRangeDynamicTimeRange",
					"com/google/android/exoplayer/TimeRange$StaticTimeRange:Com.Google.Android.Exoplayer.TimeRangeStaticTimeRange",
				};
			}

			return Lookup (package_com_google_android_exoplayer_mappings, klass);
		}

		static string[] package_com_google_android_exoplayer_drm_mappings;
		static Type lookup_com_google_android_exoplayer_drm_package (string klass)
		{
			if (package_com_google_android_exoplayer_drm_mappings == null) {
				package_com_google_android_exoplayer_drm_mappings = new string[]{
					"com/google/android/exoplayer/drm/DrmInitData$Mapped:Com.Google.Android.Exoplayer.Drm.DrmInitDataMapped",
					"com/google/android/exoplayer/drm/DrmInitData$SchemeInitData:Com.Google.Android.Exoplayer.Drm.DrmInitDataSchemeInitData",
					"com/google/android/exoplayer/drm/DrmInitData$Universal:Com.Google.Android.Exoplayer.Drm.DrmInitDataUniversal",
				};
			}

			return Lookup (package_com_google_android_exoplayer_drm_mappings, klass);
		}

		static string[] package_com_google_android_exoplayer_extractor_mappings;
		static Type lookup_com_google_android_exoplayer_extractor_package (string klass)
		{
			if (package_com_google_android_exoplayer_extractor_mappings == null) {
				package_com_google_android_exoplayer_extractor_mappings = new string[]{
					"com/google/android/exoplayer/extractor/SeekMap$1:Com.Google.Android.Exoplayer.Extractor.SeekMap1",
				};
			}

			return Lookup (package_com_google_android_exoplayer_extractor_mappings, klass);
		}
	}
}
