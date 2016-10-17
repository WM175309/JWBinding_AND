using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='DtsUtil']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/util/DtsUtil", DoNotGenerateAcw=true)]
	public sealed partial class DtsUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/util/DtsUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DtsUtil); }
		}

		internal DtsUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDtsFrameSize_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='DtsUtil']/method[@name='getDtsFrameSize' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getDtsFrameSize", "([B)I", "")]
		public static unsafe int GetDtsFrameSize (byte[] p0)
		{
			if (id_getDtsFrameSize_arrayB == IntPtr.Zero)
				id_getDtsFrameSize_arrayB = JNIEnv.GetStaticMethodID (class_ref, "getDtsFrameSize", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getDtsFrameSize_arrayB, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_parseDtsAudioSampleCount_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='DtsUtil']/method[@name='parseDtsAudioSampleCount' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("parseDtsAudioSampleCount", "([B)I", "")]
		public static unsafe int ParseDtsAudioSampleCount (byte[] p0)
		{
			if (id_parseDtsAudioSampleCount_arrayB == IntPtr.Zero)
				id_parseDtsAudioSampleCount_arrayB = JNIEnv.GetStaticMethodID (class_ref, "parseDtsAudioSampleCount", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_parseDtsAudioSampleCount_arrayB, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_parseDtsAudioSampleCount_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='DtsUtil']/method[@name='parseDtsAudioSampleCount' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("parseDtsAudioSampleCount", "(Ljava/nio/ByteBuffer;)I", "")]
		public static unsafe int ParseDtsAudioSampleCount (global::Java.Nio.ByteBuffer p0)
		{
			if (id_parseDtsAudioSampleCount_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_parseDtsAudioSampleCount_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "parseDtsAudioSampleCount", "(Ljava/nio/ByteBuffer;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_parseDtsAudioSampleCount_Ljava_nio_ByteBuffer_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
