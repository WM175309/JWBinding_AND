using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Chunk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='ChunkOperationHolder']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/chunk/ChunkOperationHolder", DoNotGenerateAcw=true)]
	public sealed partial class ChunkOperationHolder : global::Java.Lang.Object {


		static IntPtr endOfStream_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='ChunkOperationHolder']/field[@name='endOfStream']"
		[Register ("endOfStream")]
		public bool EndOfStream {
			get {
				if (endOfStream_jfieldId == IntPtr.Zero)
					endOfStream_jfieldId = JNIEnv.GetFieldID (class_ref, "endOfStream", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, endOfStream_jfieldId);
			}
			set {
				if (endOfStream_jfieldId == IntPtr.Zero)
					endOfStream_jfieldId = JNIEnv.GetFieldID (class_ref, "endOfStream", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, endOfStream_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr queueSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='ChunkOperationHolder']/field[@name='queueSize']"
		[Register ("queueSize")]
		public int QueueSize {
			get {
				if (queueSize_jfieldId == IntPtr.Zero)
					queueSize_jfieldId = JNIEnv.GetFieldID (class_ref, "queueSize", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, queueSize_jfieldId);
			}
			set {
				if (queueSize_jfieldId == IntPtr.Zero)
					queueSize_jfieldId = JNIEnv.GetFieldID (class_ref, "queueSize", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, queueSize_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/chunk/ChunkOperationHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChunkOperationHolder); }
		}

		internal ChunkOperationHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='ChunkOperationHolder']/constructor[@name='ChunkOperationHolder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ChunkOperationHolder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ChunkOperationHolder)) {
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

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='ChunkOperationHolder']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
			} finally {
			}
		}

	}
}
