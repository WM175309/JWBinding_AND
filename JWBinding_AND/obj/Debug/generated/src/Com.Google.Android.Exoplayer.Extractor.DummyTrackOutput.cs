using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DummyTrackOutput']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/extractor/DummyTrackOutput", DoNotGenerateAcw=true)]
	public partial class DummyTrackOutput : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/extractor/DummyTrackOutput", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DummyTrackOutput); }
		}

		protected DummyTrackOutput (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DummyTrackOutput']/constructor[@name='DummyTrackOutput' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DummyTrackOutput ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DummyTrackOutput)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_sampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ;
#pragma warning disable 0169
		static Delegate GetSampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZHandler ()
		{
			if (cb_sampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ == null)
				cb_sampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool, int>) n_SampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ);
			return cb_sampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ;
		}

		static int n_SampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2)
		{
			global::Com.Google.Android.Exoplayer.Extractor.DummyTrackOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.DummyTrackOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput p0 = (global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SampleData (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DummyTrackOutput']/method[@name='sampleData' and count(parameter)=3 and parameter[1][@type='com.google.android.exoplayer.extractor.ExtractorInput'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("sampleData", "(Lcom/google/android/exoplayer/extractor/ExtractorInput;IZ)I", "GetSampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZHandler")]
		public virtual unsafe int SampleData (global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput p0, int p1, bool p2)
		{
			if (id_sampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ == IntPtr.Zero)
				id_sampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ = JNIEnv.GetMethodID (class_ref, "sampleData", "(Lcom/google/android/exoplayer/extractor/ExtractorInput;IZ)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sampleData", "(Lcom/google/android/exoplayer/extractor/ExtractorInput;IZ)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_sampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I;
#pragma warning disable 0169
		static Delegate GetSampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_IHandler ()
		{
			if (cb_sampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I == null)
				cb_sampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I);
			return cb_sampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I;
		}

		static void n_SampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Google.Android.Exoplayer.Extractor.DummyTrackOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.DummyTrackOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Util.ParsableByteArray p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Util.ParsableByteArray> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SampleData (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DummyTrackOutput']/method[@name='sampleData' and count(parameter)=2 and parameter[1][@type='com.google.android.exoplayer.util.ParsableByteArray'] and parameter[2][@type='int']]"
		[Register ("sampleData", "(Lcom/google/android/exoplayer/util/ParsableByteArray;I)V", "GetSampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_IHandler")]
		public virtual unsafe void SampleData (global::Com.Google.Android.Exoplayer.Util.ParsableByteArray p0, int p1)
		{
			if (id_sampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I == IntPtr.Zero)
				id_sampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I = JNIEnv.GetMethodID (class_ref, "sampleData", "(Lcom/google/android/exoplayer/util/ParsableByteArray;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sampleData", "(Lcom/google/android/exoplayer/util/ParsableByteArray;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sampleMetadata_JIIIarrayB;
#pragma warning disable 0169
		static Delegate GetSampleMetadata_JIIIarrayBHandler ()
		{
			if (cb_sampleMetadata_JIIIarrayB == null)
				cb_sampleMetadata_JIIIarrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, int, int, int, IntPtr>) n_SampleMetadata_JIIIarrayB);
			return cb_sampleMetadata_JIIIarrayB;
		}

		static void n_SampleMetadata_JIIIarrayB (IntPtr jnienv, IntPtr native__this, long p0, int p1, int p2, int p3, IntPtr native_p4)
		{
			global::Com.Google.Android.Exoplayer.Extractor.DummyTrackOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.DummyTrackOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p4 = (byte[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SampleMetadata (p0, p1, p2, p3, p4);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
		}
#pragma warning restore 0169

		static IntPtr id_sampleMetadata_JIIIarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DummyTrackOutput']/method[@name='sampleMetadata' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]']]"
		[Register ("sampleMetadata", "(JIII[B)V", "GetSampleMetadata_JIIIarrayBHandler")]
		public virtual unsafe void SampleMetadata (long p0, int p1, int p2, int p3, byte[] p4)
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

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sampleMetadata_JIIIarrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sampleMetadata", "(JIII[B)V"), __args);
			} finally {
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

	}
}
