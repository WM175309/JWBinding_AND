using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Longtailvideo.Jwplayer.Media.Ads {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.ads']/class[@name='AdSource']"
	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/media/ads/AdSource", DoNotGenerateAcw=true)]
	public sealed partial class AdSource : global::Java.Lang.Enum {


		static IntPtr IMA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.ads']/class[@name='AdSource']/field[@name='IMA']"
		[Register ("IMA")]
		public static global::Com.Longtailvideo.Jwplayer.Media.Ads.AdSource Ima {
			get {
				if (IMA_jfieldId == IntPtr.Zero)
					IMA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IMA", "Lcom/longtailvideo/jwplayer/media/ads/AdSource;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IMA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Ads.AdSource> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr VAST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.ads']/class[@name='AdSource']/field[@name='VAST']"
		[Register ("VAST")]
		public static global::Com.Longtailvideo.Jwplayer.Media.Ads.AdSource Vast {
			get {
				if (VAST_jfieldId == IntPtr.Zero)
					VAST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VAST", "Lcom/longtailvideo/jwplayer/media/ads/AdSource;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VAST_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Ads.AdSource> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/longtailvideo/jwplayer/media/ads/AdSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdSource); }
		}

		internal AdSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.ads']/class[@name='AdSource']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/longtailvideo/jwplayer/media/ads/AdSource;", "")]
		public static unsafe global::Com.Longtailvideo.Jwplayer.Media.Ads.AdSource ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/longtailvideo/jwplayer/media/ads/AdSource;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Longtailvideo.Jwplayer.Media.Ads.AdSource __ret = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Ads.AdSource> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.ads']/class[@name='AdSource']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/longtailvideo/jwplayer/media/ads/AdSource;", "")]
		public static unsafe global::Com.Longtailvideo.Jwplayer.Media.Ads.AdSource[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/longtailvideo/jwplayer/media/ads/AdSource;");
			try {
				return (global::Com.Longtailvideo.Jwplayer.Media.Ads.AdSource[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Longtailvideo.Jwplayer.Media.Ads.AdSource));
			} finally {
			}
		}

	}
}
