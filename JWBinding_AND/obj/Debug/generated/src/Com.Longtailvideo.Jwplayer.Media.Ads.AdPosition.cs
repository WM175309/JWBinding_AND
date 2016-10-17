using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Longtailvideo.Jwplayer.Media.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.ads']/class[@name='AdPosition']"
	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/media/ads/AdPosition", DoNotGenerateAcw=true)]
	public sealed partial class AdPosition : global::Java.Lang.Enum {


		static IntPtr MID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.ads']/class[@name='AdPosition']/field[@name='MID']"
		[Register ("MID")]
		public static global::Com.Longtailvideo.Jwplayer.Media.Ads.AdPosition Mid {
			get {
				if (MID_jfieldId == IntPtr.Zero)
					MID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MID", "Lcom/longtailvideo/jwplayer/media/ads/AdPosition;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Ads.AdPosition> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr POST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.ads']/class[@name='AdPosition']/field[@name='POST']"
		[Register ("POST")]
		public static global::Com.Longtailvideo.Jwplayer.Media.Ads.AdPosition Post {
			get {
				if (POST_jfieldId == IntPtr.Zero)
					POST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POST", "Lcom/longtailvideo/jwplayer/media/ads/AdPosition;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Ads.AdPosition> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PRE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.ads']/class[@name='AdPosition']/field[@name='PRE']"
		[Register ("PRE")]
		public static global::Com.Longtailvideo.Jwplayer.Media.Ads.AdPosition Pre {
			get {
				if (PRE_jfieldId == IntPtr.Zero)
					PRE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PRE", "Lcom/longtailvideo/jwplayer/media/ads/AdPosition;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PRE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Ads.AdPosition> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/longtailvideo/jwplayer/media/ads/AdPosition", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdPosition); }
		}

		internal AdPosition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.ads']/class[@name='AdPosition']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/longtailvideo/jwplayer/media/ads/AdPosition;", "")]
		public static unsafe global::Com.Longtailvideo.Jwplayer.Media.Ads.AdPosition ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/longtailvideo/jwplayer/media/ads/AdPosition;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Longtailvideo.Jwplayer.Media.Ads.AdPosition __ret = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Ads.AdPosition> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.ads']/class[@name='AdPosition']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/longtailvideo/jwplayer/media/ads/AdPosition;", "")]
		public static unsafe global::Com.Longtailvideo.Jwplayer.Media.Ads.AdPosition[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/longtailvideo/jwplayer/media/ads/AdPosition;");
			try {
				return (global::Com.Longtailvideo.Jwplayer.Media.Ads.AdPosition[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Longtailvideo.Jwplayer.Media.Ads.AdPosition));
			} finally {
			}
		}

	}
}
