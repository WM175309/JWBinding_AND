using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Hls {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMediaPlaylist']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/hls/HlsMediaPlaylist", DoNotGenerateAcw=true)]
	public sealed partial class HlsMediaPlaylist : global::Com.Google.Android.Exoplayer.Hls.HlsPlaylist {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMediaPlaylist']/field[@name='ENCRYPTION_METHOD_AES_128']"
		[Register ("ENCRYPTION_METHOD_AES_128")]
		public const string EncryptionMethodAes128 = (string) "AES-128";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMediaPlaylist']/field[@name='ENCRYPTION_METHOD_NONE']"
		[Register ("ENCRYPTION_METHOD_NONE")]
		public const string EncryptionMethodNone = (string) "NONE";

		static IntPtr durationUs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMediaPlaylist']/field[@name='durationUs']"
		[Register ("durationUs")]
		public long DurationUs {
			get {
				if (durationUs_jfieldId == IntPtr.Zero)
					durationUs_jfieldId = JNIEnv.GetFieldID (class_ref, "durationUs", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, durationUs_jfieldId);
			}
			set {
				if (durationUs_jfieldId == IntPtr.Zero)
					durationUs_jfieldId = JNIEnv.GetFieldID (class_ref, "durationUs", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, durationUs_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr live_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMediaPlaylist']/field[@name='live']"
		[Register ("live")]
		public bool Live {
			get {
				if (live_jfieldId == IntPtr.Zero)
					live_jfieldId = JNIEnv.GetFieldID (class_ref, "live", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, live_jfieldId);
			}
			set {
				if (live_jfieldId == IntPtr.Zero)
					live_jfieldId = JNIEnv.GetFieldID (class_ref, "live", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, live_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mediaSequence_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMediaPlaylist']/field[@name='mediaSequence']"
		[Register ("mediaSequence")]
		public int MediaSequence {
			get {
				if (mediaSequence_jfieldId == IntPtr.Zero)
					mediaSequence_jfieldId = JNIEnv.GetFieldID (class_ref, "mediaSequence", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mediaSequence_jfieldId);
			}
			set {
				if (mediaSequence_jfieldId == IntPtr.Zero)
					mediaSequence_jfieldId = JNIEnv.GetFieldID (class_ref, "mediaSequence", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mediaSequence_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr segments_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMediaPlaylist']/field[@name='segments']"
		[Register ("segments")]
		public global::System.Collections.IList Segments {
			get {
				if (segments_jfieldId == IntPtr.Zero)
					segments_jfieldId = JNIEnv.GetFieldID (class_ref, "segments", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, segments_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (segments_jfieldId == IntPtr.Zero)
					segments_jfieldId = JNIEnv.GetFieldID (class_ref, "segments", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, segments_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr targetDurationSecs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMediaPlaylist']/field[@name='targetDurationSecs']"
		[Register ("targetDurationSecs")]
		public int TargetDurationSecs {
			get {
				if (targetDurationSecs_jfieldId == IntPtr.Zero)
					targetDurationSecs_jfieldId = JNIEnv.GetFieldID (class_ref, "targetDurationSecs", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, targetDurationSecs_jfieldId);
			}
			set {
				if (targetDurationSecs_jfieldId == IntPtr.Zero)
					targetDurationSecs_jfieldId = JNIEnv.GetFieldID (class_ref, "targetDurationSecs", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, targetDurationSecs_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr version_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMediaPlaylist']/field[@name='version']"
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
		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMediaPlaylist.Segment']"
		[global::Android.Runtime.Register ("com/google/android/exoplayer/hls/HlsMediaPlaylist$Segment", DoNotGenerateAcw=true)]
		public sealed partial class Segment : global::Java.Lang.Object, global::Java.Lang.IComparable {


			static IntPtr byterangeLength_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMediaPlaylist.Segment']/field[@name='byterangeLength']"
			[Register ("byterangeLength")]
			public long ByterangeLength {
				get {
					if (byterangeLength_jfieldId == IntPtr.Zero)
						byterangeLength_jfieldId = JNIEnv.GetFieldID (class_ref, "byterangeLength", "J");
					return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, byterangeLength_jfieldId);
				}
				set {
					if (byterangeLength_jfieldId == IntPtr.Zero)
						byterangeLength_jfieldId = JNIEnv.GetFieldID (class_ref, "byterangeLength", "J");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, byterangeLength_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr byterangeOffset_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMediaPlaylist.Segment']/field[@name='byterangeOffset']"
			[Register ("byterangeOffset")]
			public long ByterangeOffset {
				get {
					if (byterangeOffset_jfieldId == IntPtr.Zero)
						byterangeOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "byterangeOffset", "J");
					return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, byterangeOffset_jfieldId);
				}
				set {
					if (byterangeOffset_jfieldId == IntPtr.Zero)
						byterangeOffset_jfieldId = JNIEnv.GetFieldID (class_ref, "byterangeOffset", "J");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, byterangeOffset_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr discontinuitySequenceNumber_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMediaPlaylist.Segment']/field[@name='discontinuitySequenceNumber']"
			[Register ("discontinuitySequenceNumber")]
			public int DiscontinuitySequenceNumber {
				get {
					if (discontinuitySequenceNumber_jfieldId == IntPtr.Zero)
						discontinuitySequenceNumber_jfieldId = JNIEnv.GetFieldID (class_ref, "discontinuitySequenceNumber", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, discontinuitySequenceNumber_jfieldId);
				}
				set {
					if (discontinuitySequenceNumber_jfieldId == IntPtr.Zero)
						discontinuitySequenceNumber_jfieldId = JNIEnv.GetFieldID (class_ref, "discontinuitySequenceNumber", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, discontinuitySequenceNumber_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr durationSecs_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMediaPlaylist.Segment']/field[@name='durationSecs']"
			[Register ("durationSecs")]
			public double DurationSecs {
				get {
					if (durationSecs_jfieldId == IntPtr.Zero)
						durationSecs_jfieldId = JNIEnv.GetFieldID (class_ref, "durationSecs", "D");
					return JNIEnv.GetDoubleField (((global::Java.Lang.Object) this).Handle, durationSecs_jfieldId);
				}
				set {
					if (durationSecs_jfieldId == IntPtr.Zero)
						durationSecs_jfieldId = JNIEnv.GetFieldID (class_ref, "durationSecs", "D");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, durationSecs_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr encryptionIV_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMediaPlaylist.Segment']/field[@name='encryptionIV']"
			[Register ("encryptionIV")]
			public string EncryptionIV {
				get {
					if (encryptionIV_jfieldId == IntPtr.Zero)
						encryptionIV_jfieldId = JNIEnv.GetFieldID (class_ref, "encryptionIV", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, encryptionIV_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (encryptionIV_jfieldId == IntPtr.Zero)
						encryptionIV_jfieldId = JNIEnv.GetFieldID (class_ref, "encryptionIV", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, encryptionIV_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr encryptionKeyUri_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMediaPlaylist.Segment']/field[@name='encryptionKeyUri']"
			[Register ("encryptionKeyUri")]
			public string EncryptionKeyUri {
				get {
					if (encryptionKeyUri_jfieldId == IntPtr.Zero)
						encryptionKeyUri_jfieldId = JNIEnv.GetFieldID (class_ref, "encryptionKeyUri", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, encryptionKeyUri_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (encryptionKeyUri_jfieldId == IntPtr.Zero)
						encryptionKeyUri_jfieldId = JNIEnv.GetFieldID (class_ref, "encryptionKeyUri", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, encryptionKeyUri_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr isEncrypted_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMediaPlaylist.Segment']/field[@name='isEncrypted']"
			[Register ("isEncrypted")]
			public bool IsEncrypted {
				get {
					if (isEncrypted_jfieldId == IntPtr.Zero)
						isEncrypted_jfieldId = JNIEnv.GetFieldID (class_ref, "isEncrypted", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isEncrypted_jfieldId);
				}
				set {
					if (isEncrypted_jfieldId == IntPtr.Zero)
						isEncrypted_jfieldId = JNIEnv.GetFieldID (class_ref, "isEncrypted", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isEncrypted_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr startTimeUs_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMediaPlaylist.Segment']/field[@name='startTimeUs']"
			[Register ("startTimeUs")]
			public long StartTimeUs {
				get {
					if (startTimeUs_jfieldId == IntPtr.Zero)
						startTimeUs_jfieldId = JNIEnv.GetFieldID (class_ref, "startTimeUs", "J");
					return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, startTimeUs_jfieldId);
				}
				set {
					if (startTimeUs_jfieldId == IntPtr.Zero)
						startTimeUs_jfieldId = JNIEnv.GetFieldID (class_ref, "startTimeUs", "J");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, startTimeUs_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr url_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMediaPlaylist.Segment']/field[@name='url']"
			[Register ("url")]
			public string Url {
				get {
					if (url_jfieldId == IntPtr.Zero)
						url_jfieldId = JNIEnv.GetFieldID (class_ref, "url", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, url_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (url_jfieldId == IntPtr.Zero)
						url_jfieldId = JNIEnv.GetFieldID (class_ref, "url", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, url_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/exoplayer/hls/HlsMediaPlaylist$Segment", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Segment); }
			}

			internal Segment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_DIJZLjava_lang_String_Ljava_lang_String_JJ;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMediaPlaylist.Segment']/constructor[@name='HlsMediaPlaylist.Segment' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double'] and parameter[3][@type='int'] and parameter[4][@type='long'] and parameter[5][@type='boolean'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='long'] and parameter[9][@type='long']]"
			[Register (".ctor", "(Ljava/lang/String;DIJZLjava/lang/String;Ljava/lang/String;JJ)V", "")]
			public unsafe Segment (string p0, double p1, int p2, long p3, bool p4, string p5, string p6, long p7, long p8)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p5 = JNIEnv.NewString (p5);
				IntPtr native_p6 = JNIEnv.NewString (p6);
				try {
					JValue* __args = stackalloc JValue [9];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					__args [5] = new JValue (native_p5);
					__args [6] = new JValue (native_p6);
					__args [7] = new JValue (p7);
					__args [8] = new JValue (p8);
					if (GetType () != typeof (Segment)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;DIJZLjava/lang/String;Ljava/lang/String;JJ)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;DIJZLjava/lang/String;Ljava/lang/String;JJ)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_DIJZLjava_lang_String_Ljava_lang_String_JJ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_DIJZLjava_lang_String_Ljava_lang_String_JJ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;DIJZLjava/lang/String;Ljava/lang/String;JJ)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_DIJZLjava_lang_String_Ljava_lang_String_JJ, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_DIJZLjava_lang_String_Ljava_lang_String_JJ, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p5);
					JNIEnv.DeleteLocalRef (native_p6);
				}
			}

			static IntPtr id_compareTo_Ljava_lang_Long_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMediaPlaylist.Segment']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("compareTo", "(Ljava/lang/Long;)I", "")]
			public unsafe int CompareTo (global::Java.Lang.Long p0)
			{
				if (id_compareTo_Ljava_lang_Long_ == IntPtr.Zero)
					id_compareTo_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Ljava/lang/Long;)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_compareTo_Ljava_lang_Long_, __args);
					return __ret;
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/hls/HlsMediaPlaylist", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HlsMediaPlaylist); }
		}

		internal HlsMediaPlaylist (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_IIIZLjava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMediaPlaylist']/constructor[@name='HlsMediaPlaylist' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean'] and parameter[6][@type='java.util.List&lt;com.google.android.exoplayer.hls.HlsMediaPlaylist.Segment&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;IIIZLjava/util/List;)V", "")]
		public unsafe HlsMediaPlaylist (string p0, int p1, int p2, int p3, bool p4, global::System.Collections.Generic.IList<global::Com.Google.Android.Exoplayer.Hls.HlsMediaPlaylist.Segment> p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p5 = global::Android.Runtime.JavaList<global::Com.Google.Android.Exoplayer.Hls.HlsMediaPlaylist.Segment>.ToLocalJniHandle (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				if (GetType () != typeof (HlsMediaPlaylist)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;IIIZLjava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;IIIZLjava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_IIIZLjava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_IIIZLjava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;IIIZLjava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_IIIZLjava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_IIIZLjava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

	}
}
