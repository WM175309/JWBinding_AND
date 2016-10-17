using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Extractor.Flv {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.extractor.flv']/class[@name='FlvExtractor']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/extractor/flv/FlvExtractor", DoNotGenerateAcw=true)]
	public sealed partial class FlvExtractor : global::Java.Lang.Object, global::Com.Google.Android.Exoplayer.Extractor.ISeekMap {


		static IntPtr tagDataSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.flv']/class[@name='FlvExtractor']/field[@name='tagDataSize']"
		[Register ("tagDataSize")]
		public int TagDataSize {
			get {
				if (tagDataSize_jfieldId == IntPtr.Zero)
					tagDataSize_jfieldId = JNIEnv.GetFieldID (class_ref, "tagDataSize", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, tagDataSize_jfieldId);
			}
			set {
				if (tagDataSize_jfieldId == IntPtr.Zero)
					tagDataSize_jfieldId = JNIEnv.GetFieldID (class_ref, "tagDataSize", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, tagDataSize_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr tagTimestampUs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.flv']/class[@name='FlvExtractor']/field[@name='tagTimestampUs']"
		[Register ("tagTimestampUs")]
		public long TagTimestampUs {
			get {
				if (tagTimestampUs_jfieldId == IntPtr.Zero)
					tagTimestampUs_jfieldId = JNIEnv.GetFieldID (class_ref, "tagTimestampUs", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, tagTimestampUs_jfieldId);
			}
			set {
				if (tagTimestampUs_jfieldId == IntPtr.Zero)
					tagTimestampUs_jfieldId = JNIEnv.GetFieldID (class_ref, "tagTimestampUs", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, tagTimestampUs_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr tagType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.flv']/class[@name='FlvExtractor']/field[@name='tagType']"
		[Register ("tagType")]
		public int TagType {
			get {
				if (tagType_jfieldId == IntPtr.Zero)
					tagType_jfieldId = JNIEnv.GetFieldID (class_ref, "tagType", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, tagType_jfieldId);
			}
			set {
				if (tagType_jfieldId == IntPtr.Zero)
					tagType_jfieldId = JNIEnv.GetFieldID (class_ref, "tagType", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, tagType_jfieldId, value);
				} finally {
				}
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: com.google.android.exoplayer.extractor.SeekMap

			static IntPtr UNSEEKABLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/interface[@name='SeekMap']/field[@name='UNSEEKABLE']"
			[Register ("UNSEEKABLE")]
			public static global::Com.Google.Android.Exoplayer.Extractor.ISeekMap Unseekable {
				get {
					if (UNSEEKABLE_jfieldId == IntPtr.Zero)
						UNSEEKABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSEEKABLE", "Lcom/google/android/exoplayer/extractor/SeekMap;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNSEEKABLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.ISeekMap> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/extractor/flv/FlvExtractor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FlvExtractor); }
		}

		internal FlvExtractor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.extractor.flv']/class[@name='FlvExtractor']/constructor[@name='FlvExtractor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FlvExtractor ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (FlvExtractor)) {
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

		static IntPtr id_isSeekable;
		public unsafe bool IsSeekable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.flv']/class[@name='FlvExtractor']/method[@name='isSeekable' and count(parameter)=0]"
			[Register ("isSeekable", "()Z", "GetIsSeekableHandler")]
			get {
				if (id_isSeekable == IntPtr.Zero)
					id_isSeekable = JNIEnv.GetMethodID (class_ref, "isSeekable", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSeekable);
				} finally {
				}
			}
		}

		static IntPtr id_getPosition_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.flv']/class[@name='FlvExtractor']/method[@name='getPosition' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getPosition", "(J)J", "")]
		public unsafe long GetPosition (long p0)
		{
			if (id_getPosition_J == IntPtr.Zero)
				id_getPosition_J = JNIEnv.GetMethodID (class_ref, "getPosition", "(J)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPosition_J, __args);
			} finally {
			}
		}

		static IntPtr id_read_Lcom_google_android_exoplayer_extractor_ExtractorInput_Lcom_google_android_exoplayer_extractor_PositionHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.flv']/class[@name='FlvExtractor']/method[@name='read' and count(parameter)=2 and parameter[1][@type='com.google.android.exoplayer.extractor.ExtractorInput'] and parameter[2][@type='com.google.android.exoplayer.extractor.PositionHolder']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.flv']/class[@name='FlvExtractor']/method[@name='release' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.flv']/class[@name='FlvExtractor']/method[@name='seek' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.flv']/class[@name='FlvExtractor']/method[@name='sniff' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer.extractor.ExtractorInput']]"
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
