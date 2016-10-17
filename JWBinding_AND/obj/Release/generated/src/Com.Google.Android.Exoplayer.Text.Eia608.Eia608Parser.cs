using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Text.Eia608 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.text.eia608']/class[@name='Eia608Parser']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/text/eia608/Eia608Parser", DoNotGenerateAcw=true)]
	public sealed partial class Eia608Parser : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/text/eia608/Eia608Parser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Eia608Parser); }
		}

		internal Eia608Parser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isSeiMessageEia608_IILcom_google_android_exoplayer_util_ParsableByteArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.text.eia608']/class[@name='Eia608Parser']/method[@name='isSeiMessageEia608' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.google.android.exoplayer.util.ParsableByteArray']]"
		[Register ("isSeiMessageEia608", "(IILcom/google/android/exoplayer/util/ParsableByteArray;)Z", "")]
		public static unsafe bool IsSeiMessageEia608 (int p0, int p1, global::Com.Google.Android.Exoplayer.Util.ParsableByteArray p2)
		{
			if (id_isSeiMessageEia608_IILcom_google_android_exoplayer_util_ParsableByteArray_ == IntPtr.Zero)
				id_isSeiMessageEia608_IILcom_google_android_exoplayer_util_ParsableByteArray_ = JNIEnv.GetStaticMethodID (class_ref, "isSeiMessageEia608", "(IILcom/google/android/exoplayer/util/ParsableByteArray;)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSeiMessageEia608_IILcom_google_android_exoplayer_util_ParsableByteArray_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
