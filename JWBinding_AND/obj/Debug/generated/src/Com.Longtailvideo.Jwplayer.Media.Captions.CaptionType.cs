using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Longtailvideo.Jwplayer.Media.Captions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.captions']/class[@name='CaptionType']"
	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/media/captions/CaptionType", DoNotGenerateAcw=true)]
	public sealed partial class CaptionType : global::Java.Lang.Enum {


		static IntPtr CAPTIONS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.captions']/class[@name='CaptionType']/field[@name='CAPTIONS']"
		[Register ("CAPTIONS")]
		public static global::Com.Longtailvideo.Jwplayer.Media.Captions.CaptionType Captions {
			get {
				if (CAPTIONS_jfieldId == IntPtr.Zero)
					CAPTIONS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CAPTIONS", "Lcom/longtailvideo/jwplayer/media/captions/CaptionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CAPTIONS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Captions.CaptionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CHAPTERS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.captions']/class[@name='CaptionType']/field[@name='CHAPTERS']"
		[Register ("CHAPTERS")]
		public static global::Com.Longtailvideo.Jwplayer.Media.Captions.CaptionType Chapters {
			get {
				if (CHAPTERS_jfieldId == IntPtr.Zero)
					CHAPTERS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHAPTERS", "Lcom/longtailvideo/jwplayer/media/captions/CaptionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHAPTERS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Captions.CaptionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr THUMBNAILS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.captions']/class[@name='CaptionType']/field[@name='THUMBNAILS']"
		[Register ("THUMBNAILS")]
		public static global::Com.Longtailvideo.Jwplayer.Media.Captions.CaptionType Thumbnails {
			get {
				if (THUMBNAILS_jfieldId == IntPtr.Zero)
					THUMBNAILS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THUMBNAILS", "Lcom/longtailvideo/jwplayer/media/captions/CaptionType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THUMBNAILS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Captions.CaptionType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/longtailvideo/jwplayer/media/captions/CaptionType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CaptionType); }
		}

		internal CaptionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.captions']/class[@name='CaptionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/longtailvideo/jwplayer/media/captions/CaptionType;", "")]
		public static unsafe global::Com.Longtailvideo.Jwplayer.Media.Captions.CaptionType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/longtailvideo/jwplayer/media/captions/CaptionType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Longtailvideo.Jwplayer.Media.Captions.CaptionType __ret = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Captions.CaptionType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.captions']/class[@name='CaptionType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/longtailvideo/jwplayer/media/captions/CaptionType;", "")]
		public static unsafe global::Com.Longtailvideo.Jwplayer.Media.Captions.CaptionType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/longtailvideo/jwplayer/media/captions/CaptionType;");
			try {
				return (global::Com.Longtailvideo.Jwplayer.Media.Captions.CaptionType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Longtailvideo.Jwplayer.Media.Captions.CaptionType));
			} finally {
			}
		}

	}
}
