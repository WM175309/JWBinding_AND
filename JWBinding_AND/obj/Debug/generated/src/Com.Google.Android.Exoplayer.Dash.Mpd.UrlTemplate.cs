using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Dash.Mpd {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='UrlTemplate']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/dash/mpd/UrlTemplate", DoNotGenerateAcw=true)]
	public sealed partial class UrlTemplate : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/dash/mpd/UrlTemplate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UrlTemplate); }
		}

		internal UrlTemplate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_buildUri_Ljava_lang_String_IIJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='UrlTemplate']/method[@name='buildUri' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("buildUri", "(Ljava/lang/String;IIJ)Ljava/lang/String;", "")]
		public unsafe string BuildUri (string p0, int p1, int p2, long p3)
		{
			if (id_buildUri_Ljava_lang_String_IIJ == IntPtr.Zero)
				id_buildUri_Ljava_lang_String_IIJ = JNIEnv.GetMethodID (class_ref, "buildUri", "(Ljava/lang/String;IIJ)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buildUri_Ljava_lang_String_IIJ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_compile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='UrlTemplate']/method[@name='compile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("compile", "(Ljava/lang/String;)Lcom/google/android/exoplayer/dash/mpd/UrlTemplate;", "")]
		public static unsafe global::Com.Google.Android.Exoplayer.Dash.Mpd.UrlTemplate Compile (string p0)
		{
			if (id_compile_Ljava_lang_String_ == IntPtr.Zero)
				id_compile_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "compile", "(Ljava/lang/String;)Lcom/google/android/exoplayer/dash/mpd/UrlTemplate;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Android.Exoplayer.Dash.Mpd.UrlTemplate __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Dash.Mpd.UrlTemplate> (JNIEnv.CallStaticObjectMethod  (class_ref, id_compile_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
