using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Text.Webvtt {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.text.webvtt']/class[@name='WebvttParserUtil']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/text/webvtt/WebvttParserUtil", DoNotGenerateAcw=true)]
	public sealed partial class WebvttParserUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/text/webvtt/WebvttParserUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WebvttParserUtil); }
		}

		internal WebvttParserUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_parsePercentage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.text.webvtt']/class[@name='WebvttParserUtil']/method[@name='parsePercentage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parsePercentage", "(Ljava/lang/String;)F", "")]
		public static unsafe float ParsePercentage (string p0)
		{
			if (id_parsePercentage_Ljava_lang_String_ == IntPtr.Zero)
				id_parsePercentage_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parsePercentage", "(Ljava/lang/String;)F");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				float __ret = JNIEnv.CallStaticFloatMethod  (class_ref, id_parsePercentage_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_parseTimestampUs_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.text.webvtt']/class[@name='WebvttParserUtil']/method[@name='parseTimestampUs' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseTimestampUs", "(Ljava/lang/String;)J", "")]
		public static unsafe long ParseTimestampUs (string p0)
		{
			if (id_parseTimestampUs_Ljava_lang_String_ == IntPtr.Zero)
				id_parseTimestampUs_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parseTimestampUs", "(Ljava/lang/String;)J");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_parseTimestampUs_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_validateWebvttHeaderLine_Lcom_google_android_exoplayer_util_ParsableByteArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.text.webvtt']/class[@name='WebvttParserUtil']/method[@name='validateWebvttHeaderLine' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer.util.ParsableByteArray']]"
		[Register ("validateWebvttHeaderLine", "(Lcom/google/android/exoplayer/util/ParsableByteArray;)V", "")]
		public static unsafe void ValidateWebvttHeaderLine (global::Com.Google.Android.Exoplayer.Util.ParsableByteArray p0)
		{
			if (id_validateWebvttHeaderLine_Lcom_google_android_exoplayer_util_ParsableByteArray_ == IntPtr.Zero)
				id_validateWebvttHeaderLine_Lcom_google_android_exoplayer_util_ParsableByteArray_ = JNIEnv.GetStaticMethodID (class_ref, "validateWebvttHeaderLine", "(Lcom/google/android/exoplayer/util/ParsableByteArray;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_validateWebvttHeaderLine_Lcom_google_android_exoplayer_util_ParsableByteArray_, __args);
			} finally {
			}
		}

	}
}
