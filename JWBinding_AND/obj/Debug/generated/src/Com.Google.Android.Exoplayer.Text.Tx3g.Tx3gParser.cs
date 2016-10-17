using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Text.Tx3g {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.text.tx3g']/class[@name='Tx3gParser']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/text/tx3g/Tx3gParser", DoNotGenerateAcw=true)]
	public sealed partial class Tx3gParser : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/text/tx3g/Tx3gParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Tx3gParser); }
		}

		internal Tx3gParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.text.tx3g']/class[@name='Tx3gParser']/constructor[@name='Tx3gParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Tx3gParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Tx3gParser)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.text.tx3g']/class[@name='Tx3gParser']/method[@name='canParse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
