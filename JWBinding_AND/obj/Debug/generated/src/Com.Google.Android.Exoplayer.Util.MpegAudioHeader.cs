using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='MpegAudioHeader']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/util/MpegAudioHeader", DoNotGenerateAcw=true)]
	public sealed partial class MpegAudioHeader : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='MpegAudioHeader']/field[@name='MAX_FRAME_SIZE_BYTES']"
		[Register ("MAX_FRAME_SIZE_BYTES")]
		public const int MaxFrameSizeBytes = (int) 4096;

		static IntPtr bitrate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='MpegAudioHeader']/field[@name='bitrate']"
		[Register ("bitrate")]
		public int Bitrate {
			get {
				if (bitrate_jfieldId == IntPtr.Zero)
					bitrate_jfieldId = JNIEnv.GetFieldID (class_ref, "bitrate", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, bitrate_jfieldId);
			}
			set {
				if (bitrate_jfieldId == IntPtr.Zero)
					bitrate_jfieldId = JNIEnv.GetFieldID (class_ref, "bitrate", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bitrate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr channels_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='MpegAudioHeader']/field[@name='channels']"
		[Register ("channels")]
		public int Channels {
			get {
				if (channels_jfieldId == IntPtr.Zero)
					channels_jfieldId = JNIEnv.GetFieldID (class_ref, "channels", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, channels_jfieldId);
			}
			set {
				if (channels_jfieldId == IntPtr.Zero)
					channels_jfieldId = JNIEnv.GetFieldID (class_ref, "channels", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, channels_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr frameSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='MpegAudioHeader']/field[@name='frameSize']"
		[Register ("frameSize")]
		public int FrameSize {
			get {
				if (frameSize_jfieldId == IntPtr.Zero)
					frameSize_jfieldId = JNIEnv.GetFieldID (class_ref, "frameSize", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, frameSize_jfieldId);
			}
			set {
				if (frameSize_jfieldId == IntPtr.Zero)
					frameSize_jfieldId = JNIEnv.GetFieldID (class_ref, "frameSize", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, frameSize_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mimeType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='MpegAudioHeader']/field[@name='mimeType']"
		[Register ("mimeType")]
		public string MimeType {
			get {
				if (mimeType_jfieldId == IntPtr.Zero)
					mimeType_jfieldId = JNIEnv.GetFieldID (class_ref, "mimeType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mimeType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mimeType_jfieldId == IntPtr.Zero)
					mimeType_jfieldId = JNIEnv.GetFieldID (class_ref, "mimeType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mimeType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sampleRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='MpegAudioHeader']/field[@name='sampleRate']"
		[Register ("sampleRate")]
		public int SampleRate {
			get {
				if (sampleRate_jfieldId == IntPtr.Zero)
					sampleRate_jfieldId = JNIEnv.GetFieldID (class_ref, "sampleRate", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, sampleRate_jfieldId);
			}
			set {
				if (sampleRate_jfieldId == IntPtr.Zero)
					sampleRate_jfieldId = JNIEnv.GetFieldID (class_ref, "sampleRate", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sampleRate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr samplesPerFrame_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='MpegAudioHeader']/field[@name='samplesPerFrame']"
		[Register ("samplesPerFrame")]
		public int SamplesPerFrame {
			get {
				if (samplesPerFrame_jfieldId == IntPtr.Zero)
					samplesPerFrame_jfieldId = JNIEnv.GetFieldID (class_ref, "samplesPerFrame", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, samplesPerFrame_jfieldId);
			}
			set {
				if (samplesPerFrame_jfieldId == IntPtr.Zero)
					samplesPerFrame_jfieldId = JNIEnv.GetFieldID (class_ref, "samplesPerFrame", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, samplesPerFrame_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr version_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='MpegAudioHeader']/field[@name='version']"
		[Register ("version")]
		public int Version {
			get {
				if (version_jfieldId == IntPtr.Zero)
					version_jfieldId = JNIEnv.GetFieldID (class_ref, "version", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, version_jfieldId);
			}
			set {
				if (version_jfieldId == IntPtr.Zero)
					version_jfieldId = JNIEnv.GetFieldID (class_ref, "version", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, version_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/util/MpegAudioHeader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MpegAudioHeader); }
		}

		internal MpegAudioHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='MpegAudioHeader']/constructor[@name='MpegAudioHeader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MpegAudioHeader ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MpegAudioHeader)) {
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

		static IntPtr id_getFrameSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='MpegAudioHeader']/method[@name='getFrameSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getFrameSize", "(I)I", "")]
		public static unsafe int GetFrameSize (int p0)
		{
			if (id_getFrameSize_I == IntPtr.Zero)
				id_getFrameSize_I = JNIEnv.GetStaticMethodID (class_ref, "getFrameSize", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_getFrameSize_I, __args);
			} finally {
			}
		}

		static IntPtr id_populateHeader_ILcom_google_android_exoplayer_util_MpegAudioHeader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='MpegAudioHeader']/method[@name='populateHeader' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.android.exoplayer.util.MpegAudioHeader']]"
		[Register ("populateHeader", "(ILcom/google/android/exoplayer/util/MpegAudioHeader;)Z", "")]
		public static unsafe bool PopulateHeader (int p0, global::Com.Google.Android.Exoplayer.Util.MpegAudioHeader p1)
		{
			if (id_populateHeader_ILcom_google_android_exoplayer_util_MpegAudioHeader_ == IntPtr.Zero)
				id_populateHeader_ILcom_google_android_exoplayer_util_MpegAudioHeader_ = JNIEnv.GetStaticMethodID (class_ref, "populateHeader", "(ILcom/google/android/exoplayer/util/MpegAudioHeader;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_populateHeader_ILcom_google_android_exoplayer_util_MpegAudioHeader_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
