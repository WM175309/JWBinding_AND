using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Metadata.Id3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.metadata.id3']/class[@name='PrivFrame']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/metadata/id3/PrivFrame", DoNotGenerateAcw=true)]
	public sealed partial class PrivFrame : global::Com.Google.Android.Exoplayer.Metadata.Id3.Id3Frame {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.metadata.id3']/class[@name='PrivFrame']/field[@name='ID']"
		[Register ("ID")]
		public const string Id = (string) "PRIV";

		static IntPtr owner_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.metadata.id3']/class[@name='PrivFrame']/field[@name='owner']"
		[Register ("owner")]
		public string Owner {
			get {
				if (owner_jfieldId == IntPtr.Zero)
					owner_jfieldId = JNIEnv.GetFieldID (class_ref, "owner", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, owner_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (owner_jfieldId == IntPtr.Zero)
					owner_jfieldId = JNIEnv.GetFieldID (class_ref, "owner", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, owner_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr privateData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.metadata.id3']/class[@name='PrivFrame']/field[@name='privateData']"
		[Register ("privateData")]
		public IList<byte> PrivateData {
			get {
				if (privateData_jfieldId == IntPtr.Zero)
					privateData_jfieldId = JNIEnv.GetFieldID (class_ref, "privateData", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, privateData_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (privateData_jfieldId == IntPtr.Zero)
					privateData_jfieldId = JNIEnv.GetFieldID (class_ref, "privateData", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, privateData_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/metadata/id3/PrivFrame", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PrivFrame); }
		}

		internal PrivFrame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.metadata.id3']/class[@name='PrivFrame']/constructor[@name='PrivFrame' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Ljava/lang/String;[B)V", "")]
		public unsafe PrivFrame (string p0, byte[] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (PrivFrame)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;[B)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_arrayB == IntPtr.Zero)
					id_ctor_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_arrayB, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
