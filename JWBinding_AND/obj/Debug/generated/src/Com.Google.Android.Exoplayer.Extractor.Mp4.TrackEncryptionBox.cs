using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Extractor.Mp4 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp4']/class[@name='TrackEncryptionBox']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/extractor/mp4/TrackEncryptionBox", DoNotGenerateAcw=true)]
	public sealed partial class TrackEncryptionBox : global::Java.Lang.Object {


		static IntPtr initializationVectorSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp4']/class[@name='TrackEncryptionBox']/field[@name='initializationVectorSize']"
		[Register ("initializationVectorSize")]
		public int InitializationVectorSize {
			get {
				if (initializationVectorSize_jfieldId == IntPtr.Zero)
					initializationVectorSize_jfieldId = JNIEnv.GetFieldID (class_ref, "initializationVectorSize", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, initializationVectorSize_jfieldId);
			}
			set {
				if (initializationVectorSize_jfieldId == IntPtr.Zero)
					initializationVectorSize_jfieldId = JNIEnv.GetFieldID (class_ref, "initializationVectorSize", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, initializationVectorSize_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isEncrypted_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp4']/class[@name='TrackEncryptionBox']/field[@name='isEncrypted']"
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

		static IntPtr keyId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp4']/class[@name='TrackEncryptionBox']/field[@name='keyId']"
		[Register ("keyId")]
		public IList<byte> KeyId {
			get {
				if (keyId_jfieldId == IntPtr.Zero)
					keyId_jfieldId = JNIEnv.GetFieldID (class_ref, "keyId", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, keyId_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (keyId_jfieldId == IntPtr.Zero)
					keyId_jfieldId = JNIEnv.GetFieldID (class_ref, "keyId", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, keyId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/extractor/mp4/TrackEncryptionBox", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TrackEncryptionBox); }
		}

		internal TrackEncryptionBox (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ZIarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp4']/class[@name='TrackEncryptionBox']/constructor[@name='TrackEncryptionBox' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register (".ctor", "(ZI[B)V", "")]
		public unsafe TrackEncryptionBox (bool p0, int p1, byte[] p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (TrackEncryptionBox)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ZI[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(ZI[B)V", __args);
					return;
				}

				if (id_ctor_ZIarrayB == IntPtr.Zero)
					id_ctor_ZIarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(ZI[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ZIarrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_ZIarrayB, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

	}
}
