using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='Ac3Util']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/util/Ac3Util", DoNotGenerateAcw=true)]
	public sealed partial class Ac3Util : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/util/Ac3Util", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Ac3Util); }
		}

		internal Ac3Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getAc3SyncframeAudioSampleCount;
		public static unsafe int Ac3SyncframeAudioSampleCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='Ac3Util']/method[@name='getAc3SyncframeAudioSampleCount' and count(parameter)=0]"
			[Register ("getAc3SyncframeAudioSampleCount", "()I", "GetGetAc3SyncframeAudioSampleCountHandler")]
			get {
				if (id_getAc3SyncframeAudioSampleCount == IntPtr.Zero)
					id_getAc3SyncframeAudioSampleCount = JNIEnv.GetStaticMethodID (class_ref, "getAc3SyncframeAudioSampleCount", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getAc3SyncframeAudioSampleCount);
				} finally {
				}
			}
		}

		static IntPtr id_parseAc3SyncframeSize_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='Ac3Util']/method[@name='parseAc3SyncframeSize' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("parseAc3SyncframeSize", "([B)I", "")]
		public static unsafe int ParseAc3SyncframeSize (byte[] p0)
		{
			if (id_parseAc3SyncframeSize_arrayB == IntPtr.Zero)
				id_parseAc3SyncframeSize_arrayB = JNIEnv.GetStaticMethodID (class_ref, "parseAc3SyncframeSize", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_parseAc3SyncframeSize_arrayB, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_parseEAc3SyncframeAudioSampleCount_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='Ac3Util']/method[@name='parseEAc3SyncframeAudioSampleCount' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("parseEAc3SyncframeAudioSampleCount", "([B)I", "")]
		public static unsafe int ParseEAc3SyncframeAudioSampleCount (byte[] p0)
		{
			if (id_parseEAc3SyncframeAudioSampleCount_arrayB == IntPtr.Zero)
				id_parseEAc3SyncframeAudioSampleCount_arrayB = JNIEnv.GetStaticMethodID (class_ref, "parseEAc3SyncframeAudioSampleCount", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_parseEAc3SyncframeAudioSampleCount_arrayB, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_parseEAc3SyncframeAudioSampleCount_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='Ac3Util']/method[@name='parseEAc3SyncframeAudioSampleCount' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("parseEAc3SyncframeAudioSampleCount", "(Ljava/nio/ByteBuffer;)I", "")]
		public static unsafe int ParseEAc3SyncframeAudioSampleCount (global::Java.Nio.ByteBuffer p0)
		{
			if (id_parseEAc3SyncframeAudioSampleCount_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_parseEAc3SyncframeAudioSampleCount_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "parseEAc3SyncframeAudioSampleCount", "(Ljava/nio/ByteBuffer;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_parseEAc3SyncframeAudioSampleCount_Ljava_nio_ByteBuffer_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_parseEAc3SyncframeSize_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='Ac3Util']/method[@name='parseEAc3SyncframeSize' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("parseEAc3SyncframeSize", "([B)I", "")]
		public static unsafe int ParseEAc3SyncframeSize (byte[] p0)
		{
			if (id_parseEAc3SyncframeSize_arrayB == IntPtr.Zero)
				id_parseEAc3SyncframeSize_arrayB = JNIEnv.GetStaticMethodID (class_ref, "parseEAc3SyncframeSize", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_parseEAc3SyncframeSize_arrayB, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
