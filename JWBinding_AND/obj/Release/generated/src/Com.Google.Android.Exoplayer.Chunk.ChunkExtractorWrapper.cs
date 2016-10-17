using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Chunk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='ChunkExtractorWrapper']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/chunk/ChunkExtractorWrapper", DoNotGenerateAcw=true)]
	public sealed partial class ChunkExtractorWrapper : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/chunk/ChunkExtractorWrapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChunkExtractorWrapper); }
		}

		internal ChunkExtractorWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_drmInitData_Lcom_google_android_exoplayer_drm_DrmInitData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='ChunkExtractorWrapper']/method[@name='drmInitData' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer.drm.DrmInitData']]"
		[Register ("drmInitData", "(Lcom/google/android/exoplayer/drm/DrmInitData;)V", "")]
		public unsafe void DrmInitData (global::Com.Google.Android.Exoplayer.Drm.IDrmInitData p0)
		{
			if (id_drmInitData_Lcom_google_android_exoplayer_drm_DrmInitData_ == IntPtr.Zero)
				id_drmInitData_Lcom_google_android_exoplayer_drm_DrmInitData_ = JNIEnv.GetMethodID (class_ref, "drmInitData", "(Lcom/google/android/exoplayer/drm/DrmInitData;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_drmInitData_Lcom_google_android_exoplayer_drm_DrmInitData_, __args);
			} finally {
			}
		}

		static IntPtr id_endTracks;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='ChunkExtractorWrapper']/method[@name='endTracks' and count(parameter)=0]"
		[Register ("endTracks", "()V", "")]
		public unsafe void EndTracks ()
		{
			if (id_endTracks == IntPtr.Zero)
				id_endTracks = JNIEnv.GetMethodID (class_ref, "endTracks", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_endTracks);
			} finally {
			}
		}

		static IntPtr id_read_Lcom_google_android_exoplayer_extractor_ExtractorInput_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='ChunkExtractorWrapper']/method[@name='read' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer.extractor.ExtractorInput']]"
		[Register ("read", "(Lcom/google/android/exoplayer/extractor/ExtractorInput;)I", "")]
		public unsafe int Read (global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput p0)
		{
			if (id_read_Lcom_google_android_exoplayer_extractor_ExtractorInput_ == IntPtr.Zero)
				id_read_Lcom_google_android_exoplayer_extractor_ExtractorInput_ = JNIEnv.GetMethodID (class_ref, "read", "(Lcom/google/android/exoplayer/extractor/ExtractorInput;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_Lcom_google_android_exoplayer_extractor_ExtractorInput_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='ChunkExtractorWrapper']/method[@name='sampleData' and count(parameter)=3 and parameter[1][@type='com.google.android.exoplayer.extractor.ExtractorInput'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("sampleData", "(Lcom/google/android/exoplayer/extractor/ExtractorInput;IZ)I", "")]
		public unsafe int SampleData (global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput p0, int p1, bool p2)
		{
			if (id_sampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ == IntPtr.Zero)
				id_sampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ = JNIEnv.GetMethodID (class_ref, "sampleData", "(Lcom/google/android/exoplayer/extractor/ExtractorInput;IZ)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_sampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='ChunkExtractorWrapper']/method[@name='sampleData' and count(parameter)=2 and parameter[1][@type='com.google.android.exoplayer.util.ParsableByteArray'] and parameter[2][@type='int']]"
		[Register ("sampleData", "(Lcom/google/android/exoplayer/util/ParsableByteArray;I)V", "")]
		public unsafe void SampleData (global::Com.Google.Android.Exoplayer.Util.ParsableByteArray p0, int p1)
		{
			if (id_sampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I == IntPtr.Zero)
				id_sampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I = JNIEnv.GetMethodID (class_ref, "sampleData", "(Lcom/google/android/exoplayer/util/ParsableByteArray;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I, __args);
			} finally {
			}
		}

		static IntPtr id_sampleMetadata_JIIIarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='ChunkExtractorWrapper']/method[@name='sampleMetadata' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]']]"
		[Register ("sampleMetadata", "(JIII[B)V", "")]
		public unsafe void SampleMetadata (long p0, int p1, int p2, int p3, byte[] p4)
		{
			if (id_sampleMetadata_JIIIarrayB == IntPtr.Zero)
				id_sampleMetadata_JIIIarrayB = JNIEnv.GetMethodID (class_ref, "sampleMetadata", "(JIII[B)V");
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sampleMetadata_JIIIarrayB, __args);
			} finally {
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

		static IntPtr id_seekMap_Lcom_google_android_exoplayer_extractor_SeekMap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='ChunkExtractorWrapper']/method[@name='seekMap' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer.extractor.SeekMap']]"
		[Register ("seekMap", "(Lcom/google/android/exoplayer/extractor/SeekMap;)V", "")]
		public unsafe void SeekMap (global::Com.Google.Android.Exoplayer.Extractor.ISeekMap p0)
		{
			if (id_seekMap_Lcom_google_android_exoplayer_extractor_SeekMap_ == IntPtr.Zero)
				id_seekMap_Lcom_google_android_exoplayer_extractor_SeekMap_ = JNIEnv.GetMethodID (class_ref, "seekMap", "(Lcom/google/android/exoplayer/extractor/SeekMap;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seekMap_Lcom_google_android_exoplayer_extractor_SeekMap_, __args);
			} finally {
			}
		}

	}
}
