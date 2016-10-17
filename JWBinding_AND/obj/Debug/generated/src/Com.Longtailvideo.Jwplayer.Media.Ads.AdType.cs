using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Longtailvideo.Jwplayer.Media.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.ads']/class[@name='AdType']"
	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/media/ads/AdType", DoNotGenerateAcw=true)]
	public sealed partial class AdType : global::Java.Lang.Enum {


		static IntPtr LINEAR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.ads']/class[@name='AdType']/field[@name='LINEAR']"
		[Register ("LINEAR")]
		public static global::Com.Longtailvideo.Jwplayer.Media.Ads.AdType Linear {
			get {
				if (LINEAR_jfieldId == IntPtr.Zero)
					LINEAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LINEAR", "Lcom/longtailvideo/jwplayer/media/ads/AdType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LINEAR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Ads.AdType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NONLINEAR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.ads']/class[@name='AdType']/field[@name='NONLINEAR']"
		[Register ("NONLINEAR")]
		public static global::Com.Longtailvideo.Jwplayer.Media.Ads.AdType Nonlinear {
			get {
				if (NONLINEAR_jfieldId == IntPtr.Zero)
					NONLINEAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONLINEAR", "Lcom/longtailvideo/jwplayer/media/ads/AdType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONLINEAR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Ads.AdType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/longtailvideo/jwplayer/media/ads/AdType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdType); }
		}

		internal AdType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.ads']/class[@name='AdType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/longtailvideo/jwplayer/media/ads/AdType;", "")]
		public static unsafe global::Com.Longtailvideo.Jwplayer.Media.Ads.AdType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/longtailvideo/jwplayer/media/ads/AdType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Longtailvideo.Jwplayer.Media.Ads.AdType __ret = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Ads.AdType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.ads']/class[@name='AdType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/longtailvideo/jwplayer/media/ads/AdType;", "")]
		public static unsafe global::Com.Longtailvideo.Jwplayer.Media.Ads.AdType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/longtailvideo/jwplayer/media/ads/AdType;");
			try {
				return (global::Com.Longtailvideo.Jwplayer.Media.Ads.AdType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Longtailvideo.Jwplayer.Media.Ads.AdType));
			} finally {
			}
		}

	}
}
