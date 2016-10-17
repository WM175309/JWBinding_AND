using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Extractor.TS {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ts']/class[@name='PtsTimestampAdjuster']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/extractor/ts/PtsTimestampAdjuster", DoNotGenerateAcw=true)]
	public sealed partial class PtsTimestampAdjuster : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ts']/class[@name='PtsTimestampAdjuster']/field[@name='DO_NOT_OFFSET']"
		[Register ("DO_NOT_OFFSET")]
		public const long DoNotOffset = (long) 9223372036854775807L;

		static IntPtr firstSampleTimestampUs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ts']/class[@name='PtsTimestampAdjuster']/field[@name='firstSampleTimestampUs']"
		[Register ("firstSampleTimestampUs")]
		public long FirstSampleTimestampUs {
			get {
				if (firstSampleTimestampUs_jfieldId == IntPtr.Zero)
					firstSampleTimestampUs_jfieldId = JNIEnv.GetFieldID (class_ref, "firstSampleTimestampUs", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, firstSampleTimestampUs_jfieldId);
			}
			set {
				if (firstSampleTimestampUs_jfieldId == IntPtr.Zero)
					firstSampleTimestampUs_jfieldId = JNIEnv.GetFieldID (class_ref, "firstSampleTimestampUs", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, firstSampleTimestampUs_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/extractor/ts/PtsTimestampAdjuster", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PtsTimestampAdjuster); }
		}

		internal PtsTimestampAdjuster (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ts']/class[@name='PtsTimestampAdjuster']/constructor[@name='PtsTimestampAdjuster' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe PtsTimestampAdjuster (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (PtsTimestampAdjuster)) {
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

		static IntPtr id_isInitialized;
		public unsafe bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ts']/class[@name='PtsTimestampAdjuster']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler")]
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInitialized);
				} finally {
				}
			}
		}

		static IntPtr id_adjustTimestamp_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ts']/class[@name='PtsTimestampAdjuster']/method[@name='adjustTimestamp' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("adjustTimestamp", "(J)J", "")]
		public unsafe long AdjustTimestamp (long p0)
		{
			if (id_adjustTimestamp_J == IntPtr.Zero)
				id_adjustTimestamp_J = JNIEnv.GetMethodID (class_ref, "adjustTimestamp", "(J)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_adjustTimestamp_J, __args);
			} finally {
			}
		}

		static IntPtr id_ptsToUs_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ts']/class[@name='PtsTimestampAdjuster']/method[@name='ptsToUs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("ptsToUs", "(J)J", "")]
		public static unsafe long PtsToUs (long p0)
		{
			if (id_ptsToUs_J == IntPtr.Zero)
				id_ptsToUs_J = JNIEnv.GetStaticMethodID (class_ref, "ptsToUs", "(J)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticLongMethod  (class_ref, id_ptsToUs_J, __args);
			} finally {
			}
		}

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ts']/class[@name='PtsTimestampAdjuster']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
			} finally {
			}
		}

		static IntPtr id_usToPts_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ts']/class[@name='PtsTimestampAdjuster']/method[@name='usToPts' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("usToPts", "(J)J", "")]
		public static unsafe long UsToPts (long p0)
		{
			if (id_usToPts_J == IntPtr.Zero)
				id_usToPts_J = JNIEnv.GetStaticMethodID (class_ref, "usToPts", "(J)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticLongMethod  (class_ref, id_usToPts_J, __args);
			} finally {
			}
		}

	}
}
