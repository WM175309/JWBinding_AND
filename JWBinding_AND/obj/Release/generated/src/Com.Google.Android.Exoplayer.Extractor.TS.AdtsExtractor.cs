using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Extractor.TS {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ts']/class[@name='AdtsExtractor']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/extractor/ts/AdtsExtractor", DoNotGenerateAcw=true)]
	public sealed partial class AdtsExtractor : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/extractor/ts/AdtsExtractor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdtsExtractor); }
		}

		internal AdtsExtractor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ts']/class[@name='AdtsExtractor']/constructor[@name='AdtsExtractor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AdtsExtractor ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (AdtsExtractor)) {
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

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ts']/class[@name='AdtsExtractor']/constructor[@name='AdtsExtractor' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe AdtsExtractor (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (AdtsExtractor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(J)V", __args);
					return;
				}

				if (id_ctor_J == IntPtr.Zero)
					id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_J, __args);
			} finally {
			}
		}

		static IntPtr id_read_Lcom_google_android_exoplayer_extractor_ExtractorInput_Lcom_google_android_exoplayer_extractor_PositionHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ts']/class[@name='AdtsExtractor']/method[@name='read' and count(parameter)=2 and parameter[1][@type='com.google.android.exoplayer.extractor.ExtractorInput'] and parameter[2][@type='com.google.android.exoplayer.extractor.PositionHolder']]"
		[Register ("read", "(Lcom/google/android/exoplayer/extractor/ExtractorInput;Lcom/google/android/exoplayer/extractor/PositionHolder;)I", "")]
		public unsafe int Read (global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput p0, global::Com.Google.Android.Exoplayer.Extractor.PositionHolder p1)
		{
			if (id_read_Lcom_google_android_exoplayer_extractor_ExtractorInput_Lcom_google_android_exoplayer_extractor_PositionHolder_ == IntPtr.Zero)
				id_read_Lcom_google_android_exoplayer_extractor_ExtractorInput_Lcom_google_android_exoplayer_extractor_PositionHolder_ = JNIEnv.GetMethodID (class_ref, "read", "(Lcom/google/android/exoplayer/extractor/ExtractorInput;Lcom/google/android/exoplayer/extractor/PositionHolder;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_Lcom_google_android_exoplayer_extractor_ExtractorInput_Lcom_google_android_exoplayer_extractor_PositionHolder_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ts']/class[@name='AdtsExtractor']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "")]
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
			} finally {
			}
		}

		static IntPtr id_seek;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ts']/class[@name='AdtsExtractor']/method[@name='seek' and count(parameter)=0]"
		[Register ("seek", "()V", "")]
		public unsafe void Seek ()
		{
			if (id_seek == IntPtr.Zero)
				id_seek = JNIEnv.GetMethodID (class_ref, "seek", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seek);
			} finally {
			}
		}

		static IntPtr id_sniff_Lcom_google_android_exoplayer_extractor_ExtractorInput_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ts']/class[@name='AdtsExtractor']/method[@name='sniff' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer.extractor.ExtractorInput']]"
		[Register ("sniff", "(Lcom/google/android/exoplayer/extractor/ExtractorInput;)Z", "")]
		public unsafe bool Sniff (global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput p0)
		{
			if (id_sniff_Lcom_google_android_exoplayer_extractor_ExtractorInput_ == IntPtr.Zero)
				id_sniff_Lcom_google_android_exoplayer_extractor_ExtractorInput_ = JNIEnv.GetMethodID (class_ref, "sniff", "(Lcom/google/android/exoplayer/extractor/ExtractorInput;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_sniff_Lcom_google_android_exoplayer_extractor_ExtractorInput_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
