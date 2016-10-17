using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Smoothstreaming {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.smoothstreaming']/class[@name='SmoothStreamingManifest']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/smoothstreaming/SmoothStreamingManifest", DoNotGenerateAcw=true)]
	public partial class SmoothStreamingManifest : global::Java.Lang.Object {


		static IntPtr durationUs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.smoothstreaming']/class[@name='SmoothStreamingManifest']/field[@name='durationUs']"
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

		static IntPtr dvrWindowLengthUs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.smoothstreaming']/class[@name='SmoothStreamingManifest']/field[@name='dvrWindowLengthUs']"
		[Register ("dvrWindowLengthUs")]
		public long DvrWindowLengthUs {
			get {
				if (dvrWindowLengthUs_jfieldId == IntPtr.Zero)
					dvrWindowLengthUs_jfieldId = JNIEnv.GetFieldID (class_ref, "dvrWindowLengthUs", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, dvrWindowLengthUs_jfieldId);
			}
			set {
				if (dvrWindowLengthUs_jfieldId == IntPtr.Zero)
					dvrWindowLengthUs_jfieldId = JNIEnv.GetFieldID (class_ref, "dvrWindowLengthUs", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, dvrWindowLengthUs_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isLive_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.smoothstreaming']/class[@name='SmoothStreamingManifest']/field[@name='isLive']"
		[Register ("isLive")]
		public bool IsLive {
			get {
				if (isLive_jfieldId == IntPtr.Zero)
					isLive_jfieldId = JNIEnv.GetFieldID (class_ref, "isLive", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isLive_jfieldId);
			}
			set {
				if (isLive_jfieldId == IntPtr.Zero)
					isLive_jfieldId = JNIEnv.GetFieldID (class_ref, "isLive", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isLive_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr lookAheadCount_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.smoothstreaming']/class[@name='SmoothStreamingManifest']/field[@name='lookAheadCount']"
		[Register ("lookAheadCount")]
		public int LookAheadCount {
			get {
				if (lookAheadCount_jfieldId == IntPtr.Zero)
					lookAheadCount_jfieldId = JNIEnv.GetFieldID (class_ref, "lookAheadCount", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, lookAheadCount_jfieldId);
			}
			set {
				if (lookAheadCount_jfieldId == IntPtr.Zero)
					lookAheadCount_jfieldId = JNIEnv.GetFieldID (class_ref, "lookAheadCount", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lookAheadCount_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr majorVersion_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.smoothstreaming']/class[@name='SmoothStreamingManifest']/field[@name='majorVersion']"
		[Register ("majorVersion")]
		public int MajorVersion {
			get {
				if (majorVersion_jfieldId == IntPtr.Zero)
					majorVersion_jfieldId = JNIEnv.GetFieldID (class_ref, "majorVersion", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, majorVersion_jfieldId);
			}
			set {
				if (majorVersion_jfieldId == IntPtr.Zero)
					majorVersion_jfieldId = JNIEnv.GetFieldID (class_ref, "majorVersion", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, majorVersion_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr minorVersion_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.smoothstreaming']/class[@name='SmoothStreamingManifest']/field[@name='minorVersion']"
		[Register ("minorVersion")]
		public int MinorVersion {
			get {
				if (minorVersion_jfieldId == IntPtr.Zero)
					minorVersion_jfieldId = JNIEnv.GetFieldID (class_ref, "minorVersion", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, minorVersion_jfieldId);
			}
			set {
				if (minorVersion_jfieldId == IntPtr.Zero)
					minorVersion_jfieldId = JNIEnv.GetFieldID (class_ref, "minorVersion", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, minorVersion_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.smoothstreaming']/class[@name='SmoothStreamingManifest.ProtectionElement']"
		[global::Android.Runtime.Register ("com/google/android/exoplayer/smoothstreaming/SmoothStreamingManifest$ProtectionElement", DoNotGenerateAcw=true)]
		public partial class ProtectionElement : global::Java.Lang.Object {


			static IntPtr data_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.smoothstreaming']/class[@name='SmoothStreamingManifest.ProtectionElement']/field[@name='data']"
			[Register ("data")]
			public IList<byte> Data {
				get {
					if (data_jfieldId == IntPtr.Zero)
						data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
					return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, data_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (data_jfieldId == IntPtr.Zero)
						data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
					IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, data_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static IntPtr uuid_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.smoothstreaming']/class[@name='SmoothStreamingManifest.ProtectionElement']/field[@name='uuid']"
			[Register ("uuid")]
			public global::Java.Util.UUID Uuid {
				get {
					if (uuid_jfieldId == IntPtr.Zero)
						uuid_jfieldId = JNIEnv.GetFieldID (class_ref, "uuid", "Ljava/util/UUID;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, uuid_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (uuid_jfieldId == IntPtr.Zero)
						uuid_jfieldId = JNIEnv.GetFieldID (class_ref, "uuid", "Ljava/util/UUID;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, uuid_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/exoplayer/smoothstreaming/SmoothStreamingManifest$ProtectionElement", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ProtectionElement); }
			}

			protected ProtectionElement (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_util_UUID_arrayB;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.smoothstreaming']/class[@name='SmoothStreamingManifest.ProtectionElement']/constructor[@name='SmoothStreamingManifest.ProtectionElement' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='byte[]']]"
			[Register (".ctor", "(Ljava/util/UUID;[B)V", "")]
			public unsafe ProtectionElement (global::Java.Util.UUID p0, byte[] p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					if (GetType () != typeof (ProtectionElement)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/UUID;[B)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/UUID;[B)V", __args);
						return;
					}

					if (id_ctor_Ljava_util_UUID_arrayB == IntPtr.Zero)
						id_ctor_Ljava_util_UUID_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/UUID;[B)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_UUID_arrayB, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_UUID_arrayB, __args);
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.smoothstreaming']/class[@name='SmoothStreamingManifest.TrackElement']"
		[global::Android.Runtime.Register ("com/google/android/exoplayer/smoothstreaming/SmoothStreamingManifest$TrackElement", DoNotGenerateAcw=true)]
		public partial class TrackElement : global::Java.Lang.Object, global::Com.Google.Android.Exoplayer.Chunk.IFormatWrapper {


			static IntPtr csd_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.smoothstreaming']/class[@name='SmoothStreamingManifest.TrackElement']/field[@name='csd']"
			[Register ("csd")]
			public IList<byte[]> Csd {
				get {
					if (csd_jfieldId == IntPtr.Zero)
						csd_jfieldId = JNIEnv.GetFieldID (class_ref, "csd", "[[B");
					return global::Android.Runtime.JavaArray<byte[]>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, csd_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (csd_jfieldId == IntPtr.Zero)
						csd_jfieldId = JNIEnv.GetFieldID (class_ref, "csd", "[[B");
					IntPtr native_value = global::Android.Runtime.JavaArray<byte[]>.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, csd_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/exoplayer/smoothstreaming/SmoothStreamingManifest$TrackElement", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (TrackElement); }
			}

			protected TrackElement (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_IILjava_lang_String_arrayarrayBIIIILjava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.smoothstreaming']/class[@name='SmoothStreamingManifest.TrackElement']/constructor[@name='SmoothStreamingManifest.TrackElement' and count(parameter)=9 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='byte[][]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='java.lang.String']]"
			[Register (".ctor", "(IILjava/lang/String;[[BIIIILjava/lang/String;)V", "")]
			public unsafe TrackElement (int p0, int p1, string p2, byte[][] p3, int p4, int p5, int p6, int p7, string p8)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p2 = JNIEnv.NewString (p2);
				IntPtr native_p3 = JNIEnv.NewArray (p3);
				IntPtr native_p8 = JNIEnv.NewString (p8);
				try {
					JValue* __args = stackalloc JValue [9];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (native_p2);
					__args [3] = new JValue (native_p3);
					__args [4] = new JValue (p4);
					__args [5] = new JValue (p5);
					__args [6] = new JValue (p6);
					__args [7] = new JValue (p7);
					__args [8] = new JValue (native_p8);
					if (GetType () != typeof (TrackElement)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IILjava/lang/String;[[BIIIILjava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IILjava/lang/String;[[BIIIILjava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_IILjava_lang_String_arrayarrayBIIIILjava_lang_String_ == IntPtr.Zero)
						id_ctor_IILjava_lang_String_arrayarrayBIIIILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IILjava/lang/String;[[BIIIILjava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILjava_lang_String_arrayarrayBIIIILjava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IILjava_lang_String_arrayarrayBIIIILjava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p2);
					if (p3 != null) {
						JNIEnv.CopyArray (native_p3, p3);
						JNIEnv.DeleteLocalRef (native_p3);
					}
					JNIEnv.DeleteLocalRef (native_p8);
				}
			}

			static Delegate cb_getFormat;
#pragma warning disable 0169
			static Delegate GetGetFormatHandler ()
			{
				if (cb_getFormat == null)
					cb_getFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormat);
				return cb_getFormat;
			}

			static IntPtr n_GetFormat (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Exoplayer.Smoothstreaming.SmoothStreamingManifest.TrackElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Smoothstreaming.SmoothStreamingManifest.TrackElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Format);
			}
#pragma warning restore 0169

			static IntPtr id_getFormat;
			public virtual unsafe global::Com.Google.Android.Exoplayer.Chunk.Format Format {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.smoothstreaming']/class[@name='SmoothStreamingManifest.TrackElement']/method[@name='getFormat' and count(parameter)=0]"
				[Register ("getFormat", "()Lcom/google/android/exoplayer/chunk/Format;", "GetGetFormatHandler")]
				get {
					if (id_getFormat == IntPtr.Zero)
						id_getFormat = JNIEnv.GetMethodID (class_ref, "getFormat", "()Lcom/google/android/exoplayer/chunk/Format;");
					try {

						if (GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Chunk.Format> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormat), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Chunk.Format> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFormat", "()Lcom/google/android/exoplayer/chunk/Format;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/smoothstreaming/SmoothStreamingManifest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SmoothStreamingManifest); }
		}

		protected SmoothStreamingManifest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
