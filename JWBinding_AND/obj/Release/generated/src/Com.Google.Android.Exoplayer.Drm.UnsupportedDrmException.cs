using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Drm {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.drm']/class[@name='UnsupportedDrmException']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/drm/UnsupportedDrmException", DoNotGenerateAcw=true)]
	public sealed partial class UnsupportedDrmException : global::Java.Lang.Exception {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.drm']/class[@name='UnsupportedDrmException']/field[@name='REASON_INSTANTIATION_ERROR']"
		[Register ("REASON_INSTANTIATION_ERROR")]
		public const int ReasonInstantiationError = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.drm']/class[@name='UnsupportedDrmException']/field[@name='REASON_UNSUPPORTED_SCHEME']"
		[Register ("REASON_UNSUPPORTED_SCHEME")]
		public const int ReasonUnsupportedScheme = (int) 1;

		static IntPtr reason_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.drm']/class[@name='UnsupportedDrmException']/field[@name='reason']"
		[Register ("reason")]
		public int Reason {
			get {
				if (reason_jfieldId == IntPtr.Zero)
					reason_jfieldId = JNIEnv.GetFieldID (class_ref, "reason", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Throwable) this).Handle, reason_jfieldId);
			}
			set {
				if (reason_jfieldId == IntPtr.Zero)
					reason_jfieldId = JNIEnv.GetFieldID (class_ref, "reason", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Throwable) this).Handle, reason_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/drm/UnsupportedDrmException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnsupportedDrmException); }
		}

		internal UnsupportedDrmException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.drm']/class[@name='UnsupportedDrmException']/constructor[@name='UnsupportedDrmException' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe UnsupportedDrmException (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (UnsupportedDrmException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_ILjava_lang_Exception_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.drm']/class[@name='UnsupportedDrmException']/constructor[@name='UnsupportedDrmException' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Exception']]"
		[Register (".ctor", "(ILjava/lang/Exception;)V", "")]
		public unsafe UnsupportedDrmException (int p0, global::Java.Lang.Exception p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (UnsupportedDrmException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/lang/Exception;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(ILjava/lang/Exception;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_Exception_ == IntPtr.Zero)
					id_ctor_ILjava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/Exception;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_Exception_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_ILjava_lang_Exception_, __args);
			} finally {
			}
		}

	}
}
