using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='TraceUtil']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/util/TraceUtil", DoNotGenerateAcw=true)]
	public sealed partial class TraceUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/util/TraceUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TraceUtil); }
		}

		internal TraceUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_beginSection_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='TraceUtil']/method[@name='beginSection' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("beginSection", "(Ljava/lang/String;)V", "")]
		public static unsafe void BeginSection (string p0)
		{
			if (id_beginSection_Ljava_lang_String_ == IntPtr.Zero)
				id_beginSection_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "beginSection", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_beginSection_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_endSection;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='TraceUtil']/method[@name='endSection' and count(parameter)=0]"
		[Register ("endSection", "()V", "")]
		public static unsafe void EndSection ()
		{
			if (id_endSection == IntPtr.Zero)
				id_endSection = JNIEnv.GetStaticMethodID (class_ref, "endSection", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_endSection);
			} finally {
			}
		}

	}
}
