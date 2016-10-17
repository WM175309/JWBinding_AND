using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Text.Subrip {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.text.subrip']/class[@name='SubripParser']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/text/subrip/SubripParser", DoNotGenerateAcw=true)]
	public sealed partial class SubripParser : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/text/subrip/SubripParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SubripParser); }
		}

		internal SubripParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.text.subrip']/class[@name='SubripParser']/constructor[@name='SubripParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SubripParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SubripParser)) {
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

		static IntPtr id_canParse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.text.subrip']/class[@name='SubripParser']/method[@name='canParse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("canParse", "(Ljava/lang/String;)Z", "")]
		public unsafe bool CanParse (string p0)
		{
			if (id_canParse_Ljava_lang_String_ == IntPtr.Zero)
				id_canParse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "canParse", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canParse_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
