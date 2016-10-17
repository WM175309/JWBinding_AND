using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Extractor.Mp4 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp4']/class[@name='Track']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/extractor/mp4/Track", DoNotGenerateAcw=true)]
	public sealed partial class Track : global::Java.Lang.Object {


		static IntPtr TYPE_sbtl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp4']/class[@name='Track']/field[@name='TYPE_sbtl']"
		[Register ("TYPE_sbtl")]
		public static int TYPESbtl {
			get {
				if (TYPE_sbtl_jfieldId == IntPtr.Zero)
					TYPE_sbtl_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_sbtl", "I");
				return JNIEnv.GetStaticIntField (class_ref, TYPE_sbtl_jfieldId);
			}
		}

		static IntPtr TYPE_soun_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp4']/class[@name='Track']/field[@name='TYPE_soun']"
		[Register ("TYPE_soun")]
		public static int TYPESoun {
			get {
				if (TYPE_soun_jfieldId == IntPtr.Zero)
					TYPE_soun_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_soun", "I");
				return JNIEnv.GetStaticIntField (class_ref, TYPE_soun_jfieldId);
			}
		}

		static IntPtr TYPE_subt_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp4']/class[@name='Track']/field[@name='TYPE_subt']"
		[Register ("TYPE_subt")]
		public static int TYPESubt {
			get {
				if (TYPE_subt_jfieldId == IntPtr.Zero)
					TYPE_subt_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_subt", "I");
				return JNIEnv.GetStaticIntField (class_ref, TYPE_subt_jfieldId);
			}
		}

		static IntPtr TYPE_text_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp4']/class[@name='Track']/field[@name='TYPE_text']"
		[Register ("TYPE_text")]
		public static int TYPEText {
			get {
				if (TYPE_text_jfieldId == IntPtr.Zero)
					TYPE_text_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_text", "I");
				return JNIEnv.GetStaticIntField (class_ref, TYPE_text_jfieldId);
			}
		}

		static IntPtr TYPE_vide_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp4']/class[@name='Track']/field[@name='TYPE_vide']"
		[Register ("TYPE_vide")]
		public static int TYPEVide {
			get {
				if (TYPE_vide_jfieldId == IntPtr.Zero)
					TYPE_vide_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TYPE_vide", "I");
				return JNIEnv.GetStaticIntField (class_ref, TYPE_vide_jfieldId);
			}
		}

		static IntPtr durationUs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp4']/class[@name='Track']/field[@name='durationUs']"
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

		static IntPtr editListDurations_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp4']/class[@name='Track']/field[@name='editListDurations']"
		[Register ("editListDurations")]
		public IList<long> EditListDurations {
			get {
				if (editListDurations_jfieldId == IntPtr.Zero)
					editListDurations_jfieldId = JNIEnv.GetFieldID (class_ref, "editListDurations", "[J");
				return global::Android.Runtime.JavaArray<long>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, editListDurations_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (editListDurations_jfieldId == IntPtr.Zero)
					editListDurations_jfieldId = JNIEnv.GetFieldID (class_ref, "editListDurations", "[J");
				IntPtr native_value = global::Android.Runtime.JavaArray<long>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, editListDurations_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr editListMediaTimes_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp4']/class[@name='Track']/field[@name='editListMediaTimes']"
		[Register ("editListMediaTimes")]
		public IList<long> EditListMediaTimes {
			get {
				if (editListMediaTimes_jfieldId == IntPtr.Zero)
					editListMediaTimes_jfieldId = JNIEnv.GetFieldID (class_ref, "editListMediaTimes", "[J");
				return global::Android.Runtime.JavaArray<long>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, editListMediaTimes_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (editListMediaTimes_jfieldId == IntPtr.Zero)
					editListMediaTimes_jfieldId = JNIEnv.GetFieldID (class_ref, "editListMediaTimes", "[J");
				IntPtr native_value = global::Android.Runtime.JavaArray<long>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, editListMediaTimes_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp4']/class[@name='Track']/field[@name='id']"
		[Register ("id")]
		public int Id {
			get {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, id_jfieldId);
			}
			set {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, id_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr movieTimescale_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp4']/class[@name='Track']/field[@name='movieTimescale']"
		[Register ("movieTimescale")]
		public long MovieTimescale {
			get {
				if (movieTimescale_jfieldId == IntPtr.Zero)
					movieTimescale_jfieldId = JNIEnv.GetFieldID (class_ref, "movieTimescale", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, movieTimescale_jfieldId);
			}
			set {
				if (movieTimescale_jfieldId == IntPtr.Zero)
					movieTimescale_jfieldId = JNIEnv.GetFieldID (class_ref, "movieTimescale", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, movieTimescale_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr nalUnitLengthFieldLength_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp4']/class[@name='Track']/field[@name='nalUnitLengthFieldLength']"
		[Register ("nalUnitLengthFieldLength")]
		public int NalUnitLengthFieldLength {
			get {
				if (nalUnitLengthFieldLength_jfieldId == IntPtr.Zero)
					nalUnitLengthFieldLength_jfieldId = JNIEnv.GetFieldID (class_ref, "nalUnitLengthFieldLength", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, nalUnitLengthFieldLength_jfieldId);
			}
			set {
				if (nalUnitLengthFieldLength_jfieldId == IntPtr.Zero)
					nalUnitLengthFieldLength_jfieldId = JNIEnv.GetFieldID (class_ref, "nalUnitLengthFieldLength", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, nalUnitLengthFieldLength_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr sampleDescriptionEncryptionBoxes_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp4']/class[@name='Track']/field[@name='sampleDescriptionEncryptionBoxes']"
		[Register ("sampleDescriptionEncryptionBoxes")]
		public IList<Com.Google.Android.Exoplayer.Extractor.Mp4.TrackEncryptionBox> SampleDescriptionEncryptionBoxes {
			get {
				if (sampleDescriptionEncryptionBoxes_jfieldId == IntPtr.Zero)
					sampleDescriptionEncryptionBoxes_jfieldId = JNIEnv.GetFieldID (class_ref, "sampleDescriptionEncryptionBoxes", "[Lcom/google/android/exoplayer/extractor/mp4/TrackEncryptionBox;");
				return global::Android.Runtime.JavaArray<global::Com.Google.Android.Exoplayer.Extractor.Mp4.TrackEncryptionBox>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, sampleDescriptionEncryptionBoxes_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sampleDescriptionEncryptionBoxes_jfieldId == IntPtr.Zero)
					sampleDescriptionEncryptionBoxes_jfieldId = JNIEnv.GetFieldID (class_ref, "sampleDescriptionEncryptionBoxes", "[Lcom/google/android/exoplayer/extractor/mp4/TrackEncryptionBox;");
				IntPtr native_value = global::Android.Runtime.JavaArray<global::Com.Google.Android.Exoplayer.Extractor.Mp4.TrackEncryptionBox>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sampleDescriptionEncryptionBoxes_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr timescale_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp4']/class[@name='Track']/field[@name='timescale']"
		[Register ("timescale")]
		public long Timescale {
			get {
				if (timescale_jfieldId == IntPtr.Zero)
					timescale_jfieldId = JNIEnv.GetFieldID (class_ref, "timescale", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, timescale_jfieldId);
			}
			set {
				if (timescale_jfieldId == IntPtr.Zero)
					timescale_jfieldId = JNIEnv.GetFieldID (class_ref, "timescale", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, timescale_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp4']/class[@name='Track']/field[@name='type']"
		[Register ("type")]
		public int Type {
			get {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
			}
			set {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/extractor/mp4/Track", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Track); }
		}

		internal Track (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
