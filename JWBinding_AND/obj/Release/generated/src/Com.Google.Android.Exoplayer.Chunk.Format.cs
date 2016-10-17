using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Chunk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='Format']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/chunk/Format", DoNotGenerateAcw=true)]
	public partial class Format : global::Java.Lang.Object {


		static IntPtr audioChannels_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='Format']/field[@name='audioChannels']"
		[Register ("audioChannels")]
		public int AudioChannels {
			get {
				if (audioChannels_jfieldId == IntPtr.Zero)
					audioChannels_jfieldId = JNIEnv.GetFieldID (class_ref, "audioChannels", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, audioChannels_jfieldId);
			}
			set {
				if (audioChannels_jfieldId == IntPtr.Zero)
					audioChannels_jfieldId = JNIEnv.GetFieldID (class_ref, "audioChannels", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, audioChannels_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr audioSamplingRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='Format']/field[@name='audioSamplingRate']"
		[Register ("audioSamplingRate")]
		public int AudioSamplingRate {
			get {
				if (audioSamplingRate_jfieldId == IntPtr.Zero)
					audioSamplingRate_jfieldId = JNIEnv.GetFieldID (class_ref, "audioSamplingRate", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, audioSamplingRate_jfieldId);
			}
			set {
				if (audioSamplingRate_jfieldId == IntPtr.Zero)
					audioSamplingRate_jfieldId = JNIEnv.GetFieldID (class_ref, "audioSamplingRate", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, audioSamplingRate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr bitrate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='Format']/field[@name='bitrate']"
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

		static IntPtr codecs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='Format']/field[@name='codecs']"
		[Register ("codecs")]
		public string Codecs {
			get {
				if (codecs_jfieldId == IntPtr.Zero)
					codecs_jfieldId = JNIEnv.GetFieldID (class_ref, "codecs", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, codecs_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (codecs_jfieldId == IntPtr.Zero)
					codecs_jfieldId = JNIEnv.GetFieldID (class_ref, "codecs", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, codecs_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr frameRate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='Format']/field[@name='frameRate']"
		[Register ("frameRate")]
		public float FrameRate {
			get {
				if (frameRate_jfieldId == IntPtr.Zero)
					frameRate_jfieldId = JNIEnv.GetFieldID (class_ref, "frameRate", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, frameRate_jfieldId);
			}
			set {
				if (frameRate_jfieldId == IntPtr.Zero)
					frameRate_jfieldId = JNIEnv.GetFieldID (class_ref, "frameRate", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, frameRate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr height_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='Format']/field[@name='height']"
		[Register ("height")]
		public int Height {
			get {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, height_jfieldId);
			}
			set {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, height_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='Format']/field[@name='id']"
		[Register ("id")]
		public string Id {
			get {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, id_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, id_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr language_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='Format']/field[@name='language']"
		[Register ("language")]
		public string Language {
			get {
				if (language_jfieldId == IntPtr.Zero)
					language_jfieldId = JNIEnv.GetFieldID (class_ref, "language", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, language_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (language_jfieldId == IntPtr.Zero)
					language_jfieldId = JNIEnv.GetFieldID (class_ref, "language", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, language_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mimeType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='Format']/field[@name='mimeType']"
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

		static IntPtr width_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='Format']/field[@name='width']"
		[Register ("width")]
		public int Width {
			get {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, width_jfieldId);
			}
			set {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, width_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='Format.DecreasingBandwidthComparator']"
		[global::Android.Runtime.Register ("com/google/android/exoplayer/chunk/Format$DecreasingBandwidthComparator", DoNotGenerateAcw=true)]
		public sealed partial class DecreasingBandwidthComparator : global::Java.Lang.Object, global::Java.Util.IComparator {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/exoplayer/chunk/Format$DecreasingBandwidthComparator", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DecreasingBandwidthComparator); }
			}

			internal DecreasingBandwidthComparator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='Format.DecreasingBandwidthComparator']/constructor[@name='Format.DecreasingBandwidthComparator' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DecreasingBandwidthComparator ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (GetType () != typeof (DecreasingBandwidthComparator)) {
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

			static IntPtr id_compare_Lcom_google_android_exoplayer_chunk_Format_Lcom_google_android_exoplayer_chunk_Format_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='Format.DecreasingBandwidthComparator']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='com.google.android.exoplayer.chunk.Format'] and parameter[2][@type='com.google.android.exoplayer.chunk.Format']]"
			[Register ("compare", "(Lcom/google/android/exoplayer/chunk/Format;Lcom/google/android/exoplayer/chunk/Format;)I", "")]
			public unsafe int Compare (global::Com.Google.Android.Exoplayer.Chunk.Format p0, global::Com.Google.Android.Exoplayer.Chunk.Format p1)
			{
				if (id_compare_Lcom_google_android_exoplayer_chunk_Format_Lcom_google_android_exoplayer_chunk_Format_ == IntPtr.Zero)
					id_compare_Lcom_google_android_exoplayer_chunk_Format_Lcom_google_android_exoplayer_chunk_Format_ = JNIEnv.GetMethodID (class_ref, "compare", "(Lcom/google/android/exoplayer/chunk/Format;Lcom/google/android/exoplayer/chunk/Format;)I");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_compare_Lcom_google_android_exoplayer_chunk_Format_Lcom_google_android_exoplayer_chunk_Format_, __args);
					return __ret;
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/chunk/Format", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Format); }
		}

		protected Format (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_IIFIIILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='Format']/constructor[@name='Format' and count(parameter)=10 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='float'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;IIFIIILjava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe Format (string p0, string p1, int p2, int p3, float p4, int p5, int p6, int p7, string p8, string p9)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p8 = JNIEnv.NewString (p8);
			IntPtr native_p9 = JNIEnv.NewString (p9);
			try {
				JValue* __args = stackalloc JValue [10];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (native_p8);
				__args [9] = new JValue (native_p9);
				if (GetType () != typeof (Format)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;IIFIIILjava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;IIFIIILjava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_IIFIIILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_IIFIIILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;IIFIIILjava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_IIFIIILjava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_IIFIIILjava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p8);
				JNIEnv.DeleteLocalRef (native_p9);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_IIFIIILjava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='Format']/constructor[@name='Format' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='float'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;IIFIIILjava/lang/String;)V", "")]
		public unsafe Format (string p0, string p1, int p2, int p3, float p4, int p5, int p6, int p7, string p8)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p8 = JNIEnv.NewString (p8);
			try {
				JValue* __args = stackalloc JValue [9];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				__args [8] = new JValue (native_p8);
				if (GetType () != typeof (Format)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;IIFIIILjava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;IIFIIILjava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_IIFIIILjava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_IIFIIILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;IIFIIILjava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_IIFIIILjava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_IIFIIILjava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p8);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_IIFIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/class[@name='Format']/constructor[@name='Format' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='float'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;IIFIII)V", "")]
		public unsafe Format (string p0, string p1, int p2, int p3, float p4, int p5, int p6, int p7)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);
				if (GetType () != typeof (Format)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/lang/String;IIFIII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;IIFIII)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_IIFIII == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_IIFIII = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;IIFIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_IIFIII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_IIFIII, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
