using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='MediaFormatHolder']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/MediaFormatHolder", DoNotGenerateAcw=true)]
	public sealed partial class MediaFormatHolder : global::Java.Lang.Object {


		static IntPtr drmInitData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='MediaFormatHolder']/field[@name='drmInitData']"
		[Register ("drmInitData")]
		public global::Com.Google.Android.Exoplayer.Drm.IDrmInitData DrmInitData {
			get {
				if (drmInitData_jfieldId == IntPtr.Zero)
					drmInitData_jfieldId = JNIEnv.GetFieldID (class_ref, "drmInitData", "Lcom/google/android/exoplayer/drm/DrmInitData;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, drmInitData_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Drm.IDrmInitData> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (drmInitData_jfieldId == IntPtr.Zero)
					drmInitData_jfieldId = JNIEnv.GetFieldID (class_ref, "drmInitData", "Lcom/google/android/exoplayer/drm/DrmInitData;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, drmInitData_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/MediaFormatHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaFormatHolder); }
		}

		internal MediaFormatHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='MediaFormatHolder']/constructor[@name='MediaFormatHolder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MediaFormatHolder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (MediaFormatHolder)) {
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

	}
}
