using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Extractor.Ogg {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ogg']/class[@name='OggVorbisExtractor']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/extractor/ogg/OggVorbisExtractor", DoNotGenerateAcw=true)]
	public sealed partial class OggVorbisExtractor : global::Java.Lang.Object, global::Com.Google.Android.Exoplayer.Extractor.ISeekMap {


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

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ogg']/class[@name='OggVorbisExtractor.VorbisSetup']"
		[global::Android.Runtime.Register ("com/google/android/exoplayer/extractor/ogg/OggVorbisExtractor$VorbisSetup", DoNotGenerateAcw=true)]
		public sealed partial class VorbisSetup : global::Java.Lang.Object {


			static IntPtr iLogModes_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ogg']/class[@name='OggVorbisExtractor.VorbisSetup']/field[@name='iLogModes']"
			[Register ("iLogModes")]
			public int ILogModes {
				get {
					if (iLogModes_jfieldId == IntPtr.Zero)
						iLogModes_jfieldId = JNIEnv.GetFieldID (class_ref, "iLogModes", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, iLogModes_jfieldId);
				}
				set {
					if (iLogModes_jfieldId == IntPtr.Zero)
						iLogModes_jfieldId = JNIEnv.GetFieldID (class_ref, "iLogModes", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, iLogModes_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr setupHeaderData_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ogg']/class[@name='OggVorbisExtractor.VorbisSetup']/field[@name='setupHeaderData']"
			[Register ("setupHeaderData")]
			public IList<byte> SetupHeaderData {
				get {
					if (setupHeaderData_jfieldId == IntPtr.Zero)
						setupHeaderData_jfieldId = JNIEnv.GetFieldID (class_ref, "setupHeaderData", "[B");
					return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, setupHeaderData_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (setupHeaderData_jfieldId == IntPtr.Zero)
						setupHeaderData_jfieldId = JNIEnv.GetFieldID (class_ref, "setupHeaderData", "[B");
					IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, setupHeaderData_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/exoplayer/extractor/ogg/OggVorbisExtractor$VorbisSetup", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (VorbisSetup); }
			}

			internal VorbisSetup (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/extractor/ogg/OggVorbisExtractor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OggVorbisExtractor); }
		}

		internal OggVorbisExtractor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ogg']/class[@name='OggVorbisExtractor']/constructor[@name='OggVorbisExtractor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OggVorbisExtractor ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (OggVorbisExtractor)) {
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ogg']/class[@name='OggVorbisExtractor']/method[@name='isSeekable' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ogg']/class[@name='OggVorbisExtractor']/method[@name='getPosition' and count(parameter)=1 and parameter[1][@type='long']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ogg']/class[@name='OggVorbisExtractor']/method[@name='read' and count(parameter)=2 and parameter[1][@type='com.google.android.exoplayer.extractor.ExtractorInput'] and parameter[2][@type='com.google.android.exoplayer.extractor.PositionHolder']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ogg']/class[@name='OggVorbisExtractor']/method[@name='release' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ogg']/class[@name='OggVorbisExtractor']/method[@name='seek' and count(parameter)=0]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.ogg']/class[@name='OggVorbisExtractor']/method[@name='sniff' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer.extractor.ExtractorInput']]"
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
