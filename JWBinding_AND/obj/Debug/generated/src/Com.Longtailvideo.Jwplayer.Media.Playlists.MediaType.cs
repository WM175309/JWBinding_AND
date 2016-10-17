using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Longtailvideo.Jwplayer.Media.Playlists {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.playlists']/class[@name='MediaType']"
	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/media/playlists/MediaType", DoNotGenerateAcw=true)]
	public sealed partial class MediaType : global::Java.Lang.Enum {


		static IntPtr AAC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.playlists']/class[@name='MediaType']/field[@name='AAC']"
		[Register ("AAC")]
		public static global::Com.Longtailvideo.Jwplayer.Media.Playlists.MediaType Aac {
			get {
				if (AAC_jfieldId == IntPtr.Zero)
					AAC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AAC", "Lcom/longtailvideo/jwplayer/media/playlists/MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AAC_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Playlists.MediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr HLS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.playlists']/class[@name='MediaType']/field[@name='HLS']"
		[Register ("HLS")]
		public static global::Com.Longtailvideo.Jwplayer.Media.Playlists.MediaType Hls {
			get {
				if (HLS_jfieldId == IntPtr.Zero)
					HLS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HLS", "Lcom/longtailvideo/jwplayer/media/playlists/MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HLS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Playlists.MediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ISM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.playlists']/class[@name='MediaType']/field[@name='ISM']"
		[Register ("ISM")]
		public static global::Com.Longtailvideo.Jwplayer.Media.Playlists.MediaType Ism {
			get {
				if (ISM_jfieldId == IntPtr.Zero)
					ISM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ISM", "Lcom/longtailvideo/jwplayer/media/playlists/MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ISM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Playlists.MediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr M3U8_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.playlists']/class[@name='MediaType']/field[@name='M3U8']"
		[Register ("M3U8")]
		public static global::Com.Longtailvideo.Jwplayer.Media.Playlists.MediaType M3u8 {
			get {
				if (M3U8_jfieldId == IntPtr.Zero)
					M3U8_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "M3U8", "Lcom/longtailvideo/jwplayer/media/playlists/MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, M3U8_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Playlists.MediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MP3_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.playlists']/class[@name='MediaType']/field[@name='MP3']"
		[Register ("MP3")]
		public static global::Com.Longtailvideo.Jwplayer.Media.Playlists.MediaType Mp3 {
			get {
				if (MP3_jfieldId == IntPtr.Zero)
					MP3_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MP3", "Lcom/longtailvideo/jwplayer/media/playlists/MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MP3_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Playlists.MediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MP4_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.playlists']/class[@name='MediaType']/field[@name='MP4']"
		[Register ("MP4")]
		public static global::Com.Longtailvideo.Jwplayer.Media.Playlists.MediaType Mp4 {
			get {
				if (MP4_jfieldId == IntPtr.Zero)
					MP4_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MP4", "Lcom/longtailvideo/jwplayer/media/playlists/MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MP4_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Playlists.MediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MPD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.playlists']/class[@name='MediaType']/field[@name='MPD']"
		[Register ("MPD")]
		public static global::Com.Longtailvideo.Jwplayer.Media.Playlists.MediaType Mpd {
			get {
				if (MPD_jfieldId == IntPtr.Zero)
					MPD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MPD", "Lcom/longtailvideo/jwplayer/media/playlists/MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MPD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Playlists.MediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr WEBM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.playlists']/class[@name='MediaType']/field[@name='WEBM']"
		[Register ("WEBM")]
		public static global::Com.Longtailvideo.Jwplayer.Media.Playlists.MediaType Webm {
			get {
				if (WEBM_jfieldId == IntPtr.Zero)
					WEBM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEBM", "Lcom/longtailvideo/jwplayer/media/playlists/MediaType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WEBM_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Playlists.MediaType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/longtailvideo/jwplayer/media/playlists/MediaType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaType); }
		}

		internal MediaType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.playlists']/class[@name='MediaType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/longtailvideo/jwplayer/media/playlists/MediaType;", "")]
		public static unsafe global::Com.Longtailvideo.Jwplayer.Media.Playlists.MediaType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/longtailvideo/jwplayer/media/playlists/MediaType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Longtailvideo.Jwplayer.Media.Playlists.MediaType __ret = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Playlists.MediaType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.playlists']/class[@name='MediaType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/longtailvideo/jwplayer/media/playlists/MediaType;", "")]
		public static unsafe global::Com.Longtailvideo.Jwplayer.Media.Playlists.MediaType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/longtailvideo/jwplayer/media/playlists/MediaType;");
			try {
				return (global::Com.Longtailvideo.Jwplayer.Media.Playlists.MediaType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Longtailvideo.Jwplayer.Media.Playlists.MediaType));
			} finally {
			}
		}

	}
}
