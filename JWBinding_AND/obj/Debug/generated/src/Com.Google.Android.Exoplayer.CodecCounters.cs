using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='CodecCounters']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/CodecCounters", DoNotGenerateAcw=true)]
	public sealed partial class CodecCounters : global::Java.Lang.Object {


		static IntPtr codecInitCount_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='CodecCounters']/field[@name='codecInitCount']"
		[Register ("codecInitCount")]
		public int CodecInitCount {
			get {
				if (codecInitCount_jfieldId == IntPtr.Zero)
					codecInitCount_jfieldId = JNIEnv.GetFieldID (class_ref, "codecInitCount", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, codecInitCount_jfieldId);
			}
			set {
				if (codecInitCount_jfieldId == IntPtr.Zero)
					codecInitCount_jfieldId = JNIEnv.GetFieldID (class_ref, "codecInitCount", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, codecInitCount_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr codecReleaseCount_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='CodecCounters']/field[@name='codecReleaseCount']"
		[Register ("codecReleaseCount")]
		public int CodecReleaseCount {
			get {
				if (codecReleaseCount_jfieldId == IntPtr.Zero)
					codecReleaseCount_jfieldId = JNIEnv.GetFieldID (class_ref, "codecReleaseCount", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, codecReleaseCount_jfieldId);
			}
			set {
				if (codecReleaseCount_jfieldId == IntPtr.Zero)
					codecReleaseCount_jfieldId = JNIEnv.GetFieldID (class_ref, "codecReleaseCount", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, codecReleaseCount_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr droppedOutputBufferCount_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='CodecCounters']/field[@name='droppedOutputBufferCount']"
		[Register ("droppedOutputBufferCount")]
		public int DroppedOutputBufferCount {
			get {
				if (droppedOutputBufferCount_jfieldId == IntPtr.Zero)
					droppedOutputBufferCount_jfieldId = JNIEnv.GetFieldID (class_ref, "droppedOutputBufferCount", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, droppedOutputBufferCount_jfieldId);
			}
			set {
				if (droppedOutputBufferCount_jfieldId == IntPtr.Zero)
					droppedOutputBufferCount_jfieldId = JNIEnv.GetFieldID (class_ref, "droppedOutputBufferCount", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, droppedOutputBufferCount_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr inputBufferCount_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='CodecCounters']/field[@name='inputBufferCount']"
		[Register ("inputBufferCount")]
		public int InputBufferCount {
			get {
				if (inputBufferCount_jfieldId == IntPtr.Zero)
					inputBufferCount_jfieldId = JNIEnv.GetFieldID (class_ref, "inputBufferCount", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, inputBufferCount_jfieldId);
			}
			set {
				if (inputBufferCount_jfieldId == IntPtr.Zero)
					inputBufferCount_jfieldId = JNIEnv.GetFieldID (class_ref, "inputBufferCount", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, inputBufferCount_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr maxConsecutiveDroppedOutputBufferCount_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='CodecCounters']/field[@name='maxConsecutiveDroppedOutputBufferCount']"
		[Register ("maxConsecutiveDroppedOutputBufferCount")]
		public int MaxConsecutiveDroppedOutputBufferCount {
			get {
				if (maxConsecutiveDroppedOutputBufferCount_jfieldId == IntPtr.Zero)
					maxConsecutiveDroppedOutputBufferCount_jfieldId = JNIEnv.GetFieldID (class_ref, "maxConsecutiveDroppedOutputBufferCount", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, maxConsecutiveDroppedOutputBufferCount_jfieldId);
			}
			set {
				if (maxConsecutiveDroppedOutputBufferCount_jfieldId == IntPtr.Zero)
					maxConsecutiveDroppedOutputBufferCount_jfieldId = JNIEnv.GetFieldID (class_ref, "maxConsecutiveDroppedOutputBufferCount", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, maxConsecutiveDroppedOutputBufferCount_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr outputBuffersChangedCount_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='CodecCounters']/field[@name='outputBuffersChangedCount']"
		[Register ("outputBuffersChangedCount")]
		public int OutputBuffersChangedCount {
			get {
				if (outputBuffersChangedCount_jfieldId == IntPtr.Zero)
					outputBuffersChangedCount_jfieldId = JNIEnv.GetFieldID (class_ref, "outputBuffersChangedCount", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, outputBuffersChangedCount_jfieldId);
			}
			set {
				if (outputBuffersChangedCount_jfieldId == IntPtr.Zero)
					outputBuffersChangedCount_jfieldId = JNIEnv.GetFieldID (class_ref, "outputBuffersChangedCount", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, outputBuffersChangedCount_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr outputFormatChangedCount_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='CodecCounters']/field[@name='outputFormatChangedCount']"
		[Register ("outputFormatChangedCount")]
		public int OutputFormatChangedCount {
			get {
				if (outputFormatChangedCount_jfieldId == IntPtr.Zero)
					outputFormatChangedCount_jfieldId = JNIEnv.GetFieldID (class_ref, "outputFormatChangedCount", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, outputFormatChangedCount_jfieldId);
			}
			set {
				if (outputFormatChangedCount_jfieldId == IntPtr.Zero)
					outputFormatChangedCount_jfieldId = JNIEnv.GetFieldID (class_ref, "outputFormatChangedCount", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, outputFormatChangedCount_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr renderedOutputBufferCount_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='CodecCounters']/field[@name='renderedOutputBufferCount']"
		[Register ("renderedOutputBufferCount")]
		public int RenderedOutputBufferCount {
			get {
				if (renderedOutputBufferCount_jfieldId == IntPtr.Zero)
					renderedOutputBufferCount_jfieldId = JNIEnv.GetFieldID (class_ref, "renderedOutputBufferCount", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, renderedOutputBufferCount_jfieldId);
			}
			set {
				if (renderedOutputBufferCount_jfieldId == IntPtr.Zero)
					renderedOutputBufferCount_jfieldId = JNIEnv.GetFieldID (class_ref, "renderedOutputBufferCount", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, renderedOutputBufferCount_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr skippedOutputBufferCount_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='CodecCounters']/field[@name='skippedOutputBufferCount']"
		[Register ("skippedOutputBufferCount")]
		public int SkippedOutputBufferCount {
			get {
				if (skippedOutputBufferCount_jfieldId == IntPtr.Zero)
					skippedOutputBufferCount_jfieldId = JNIEnv.GetFieldID (class_ref, "skippedOutputBufferCount", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, skippedOutputBufferCount_jfieldId);
			}
			set {
				if (skippedOutputBufferCount_jfieldId == IntPtr.Zero)
					skippedOutputBufferCount_jfieldId = JNIEnv.GetFieldID (class_ref, "skippedOutputBufferCount", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, skippedOutputBufferCount_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/CodecCounters", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CodecCounters); }
		}

		internal CodecCounters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='CodecCounters']/constructor[@name='CodecCounters' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CodecCounters ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CodecCounters)) {
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

		static IntPtr id_getDebugString;
		public unsafe string DebugString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='CodecCounters']/method[@name='getDebugString' and count(parameter)=0]"
			[Register ("getDebugString", "()Ljava/lang/String;", "GetGetDebugStringHandler")]
			get {
				if (id_getDebugString == IntPtr.Zero)
					id_getDebugString = JNIEnv.GetMethodID (class_ref, "getDebugString", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDebugString), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_ensureUpdated;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='CodecCounters']/method[@name='ensureUpdated' and count(parameter)=0]"
		[Register ("ensureUpdated", "()V", "")]
		public unsafe void EnsureUpdated ()
		{
			if (id_ensureUpdated == IntPtr.Zero)
				id_ensureUpdated = JNIEnv.GetMethodID (class_ref, "ensureUpdated", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ensureUpdated);
			} finally {
			}
		}

	}
}
