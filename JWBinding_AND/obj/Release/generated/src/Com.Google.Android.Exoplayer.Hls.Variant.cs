using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Hls {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='Variant']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/hls/Variant", DoNotGenerateAcw=true)]
	public sealed partial class Variant : global::Java.Lang.Object, global::Com.Google.Android.Exoplayer.Chunk.IFormatWrapper {


		static IntPtr url_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='Variant']/field[@name='url']"
		[Register ("url")]
		public string Url {
			get {
				if (url_jfieldId == IntPtr.Zero)
					url_jfieldId = JNIEnv.GetFieldID (class_ref, "url", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, url_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (url_jfieldId == IntPtr.Zero)
					url_jfieldId = JNIEnv.GetFieldID (class_ref, "url", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, url_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/hls/Variant", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Variant); }
		}

		internal Variant (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_chunk_Format_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='Variant']/constructor[@name='Variant' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.android.exoplayer.chunk.Format']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/google/android/exoplayer/chunk/Format;)V", "")]
		public unsafe Variant (string p0, global::Com.Google.Android.Exoplayer.Chunk.Format p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Variant)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/google/android/exoplayer/chunk/Format;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/google/android/exoplayer/chunk/Format;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_chunk_Format_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_chunk_Format_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/google/android/exoplayer/chunk/Format;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_chunk_Format_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_chunk_Format_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getFormat;
		public unsafe global::Com.Google.Android.Exoplayer.Chunk.Format Format {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='Variant']/method[@name='getFormat' and count(parameter)=0]"
			[Register ("getFormat", "()Lcom/google/android/exoplayer/chunk/Format;", "GetGetFormatHandler")]
			get {
				if (id_getFormat == IntPtr.Zero)
					id_getFormat = JNIEnv.GetMethodID (class_ref, "getFormat", "()Lcom/google/android/exoplayer/chunk/Format;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Chunk.Format> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormat), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
