using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='DecoderInfo']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/DecoderInfo", DoNotGenerateAcw=true)]
	public sealed partial class DecoderInfo : global::Java.Lang.Object {


		static IntPtr adaptive_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='DecoderInfo']/field[@name='adaptive']"
		[Register ("adaptive")]
		public bool Adaptive {
			get {
				if (adaptive_jfieldId == IntPtr.Zero)
					adaptive_jfieldId = JNIEnv.GetFieldID (class_ref, "adaptive", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, adaptive_jfieldId);
			}
			set {
				if (adaptive_jfieldId == IntPtr.Zero)
					adaptive_jfieldId = JNIEnv.GetFieldID (class_ref, "adaptive", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, adaptive_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr name_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='DecoderInfo']/field[@name='name']"
		[Register ("name")]
		public string Name {
			get {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, name_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (name_jfieldId == IntPtr.Zero)
					name_jfieldId = JNIEnv.GetFieldID (class_ref, "name", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, name_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/DecoderInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DecoderInfo); }
		}

		internal DecoderInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
