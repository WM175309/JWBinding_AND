using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Text.Webvtt {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.text.webvtt']/class[@name='WebvttParser']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/text/webvtt/WebvttParser", DoNotGenerateAcw=true)]
	public sealed partial class WebvttParser : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/text/webvtt/WebvttParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WebvttParser); }
		}

		internal WebvttParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.text.webvtt']/class[@name='WebvttParser']/constructor[@name='WebvttParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WebvttParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (WebvttParser)) {
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.text.webvtt']/class[@name='WebvttParser']/method[@name='canParse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_parse_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.text.webvtt']/class[@name='WebvttParser']/method[@name='parse' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("parse", "([BII)Lcom/google/android/exoplayer/text/webvtt/WebvttSubtitle;", "")]
		public unsafe global::Com.Google.Android.Exoplayer.Text.Webvtt.WebvttSubtitle Parse (byte[] p0, int p1, int p2)
		{
			if (id_parse_arrayBII == IntPtr.Zero)
				id_parse_arrayBII = JNIEnv.GetMethodID (class_ref, "parse", "([BII)Lcom/google/android/exoplayer/text/webvtt/WebvttSubtitle;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Google.Android.Exoplayer.Text.Webvtt.WebvttSubtitle __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Text.Webvtt.WebvttSubtitle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parse_arrayBII, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
