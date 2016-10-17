using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='C']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/C", DoNotGenerateAcw=true)]
	public sealed partial class C : global::Java.Lang.Object {


		static IntPtr CHANNEL_OUT_7POINT1_SURROUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='C']/field[@name='CHANNEL_OUT_7POINT1_SURROUND']"
		[Register ("CHANNEL_OUT_7POINT1_SURROUND")]
		public static int ChannelOut7point1Surround {
			get {
				if (CHANNEL_OUT_7POINT1_SURROUND_jfieldId == IntPtr.Zero)
					CHANNEL_OUT_7POINT1_SURROUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHANNEL_OUT_7POINT1_SURROUND", "I");
				return JNIEnv.GetStaticIntField (class_ref, CHANNEL_OUT_7POINT1_SURROUND_jfieldId);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='C']/field[@name='CRYPTO_MODE_AES_CTR']"
		[Register ("CRYPTO_MODE_AES_CTR")]
		public const int CryptoModeAesCtr = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='C']/field[@name='ENCODING_AC3']"
		[Register ("ENCODING_AC3")]
		public const int EncodingAc3 = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='C']/field[@name='ENCODING_DTS']"
		[Register ("ENCODING_DTS")]
		public const int EncodingDts = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='C']/field[@name='ENCODING_DTS_HD']"
		[Register ("ENCODING_DTS_HD")]
		public const int EncodingDtsHd = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='C']/field[@name='ENCODING_E_AC3']"
		[Register ("ENCODING_E_AC3")]
		public const int EncodingEAc3 = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='C']/field[@name='LENGTH_UNBOUNDED']"
		[Register ("LENGTH_UNBOUNDED")]
		public const int LengthUnbounded = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='C']/field[@name='MATCH_LONGEST_US']"
		[Register ("MATCH_LONGEST_US")]
		public const long MatchLongestUs = (long) -2L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='C']/field[@name='MICROS_PER_SECOND']"
		[Register ("MICROS_PER_SECOND")]
		public const long MicrosPerSecond = (long) 1000000L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='C']/field[@name='RESULT_END_OF_INPUT']"
		[Register ("RESULT_END_OF_INPUT")]
		public const int ResultEndOfInput = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='C']/field[@name='RESULT_MAX_LENGTH_EXCEEDED']"
		[Register ("RESULT_MAX_LENGTH_EXCEEDED")]
		public const int ResultMaxLengthExceeded = (int) -2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='C']/field[@name='SAMPLE_FLAG_DECODE_ONLY']"
		[Register ("SAMPLE_FLAG_DECODE_ONLY")]
		public const int SampleFlagDecodeOnly = (int) 134217728;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='C']/field[@name='SAMPLE_FLAG_ENCRYPTED']"
		[Register ("SAMPLE_FLAG_ENCRYPTED")]
		public const int SampleFlagEncrypted = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='C']/field[@name='SAMPLE_FLAG_SYNC']"
		[Register ("SAMPLE_FLAG_SYNC")]
		public const int SampleFlagSync = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='C']/field[@name='UNKNOWN_TIME_US']"
		[Register ("UNKNOWN_TIME_US")]
		public const long UnknownTimeUs = (long) -1L;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='C']/field[@name='UTF8_NAME']"
		[Register ("UTF8_NAME")]
		public const string Utf8Name = (string) "UTF-8";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/C", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (C); }
		}

		internal C (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
