using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='GaplessInfo']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/extractor/GaplessInfo", DoNotGenerateAcw=true)]
	public sealed partial class GaplessInfo : global::Java.Lang.Object {


		static IntPtr encoderDelay_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='GaplessInfo']/field[@name='encoderDelay']"
		[Register ("encoderDelay")]
		public int EncoderDelay {
			get {
				if (encoderDelay_jfieldId == IntPtr.Zero)
					encoderDelay_jfieldId = JNIEnv.GetFieldID (class_ref, "encoderDelay", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, encoderDelay_jfieldId);
			}
			set {
				if (encoderDelay_jfieldId == IntPtr.Zero)
					encoderDelay_jfieldId = JNIEnv.GetFieldID (class_ref, "encoderDelay", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, encoderDelay_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr encoderPadding_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='GaplessInfo']/field[@name='encoderPadding']"
		[Register ("encoderPadding")]
		public int EncoderPadding {
			get {
				if (encoderPadding_jfieldId == IntPtr.Zero)
					encoderPadding_jfieldId = JNIEnv.GetFieldID (class_ref, "encoderPadding", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, encoderPadding_jfieldId);
			}
			set {
				if (encoderPadding_jfieldId == IntPtr.Zero)
					encoderPadding_jfieldId = JNIEnv.GetFieldID (class_ref, "encoderPadding", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, encoderPadding_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/extractor/GaplessInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GaplessInfo); }
		}

		internal GaplessInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_createFromComment_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='GaplessInfo']/method[@name='createFromComment' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("createFromComment", "(Ljava/lang/String;Ljava/lang/String;)Lcom/google/android/exoplayer/extractor/GaplessInfo;", "")]
		public static unsafe global::Com.Google.Android.Exoplayer.Extractor.GaplessInfo CreateFromComment (string p0, string p1)
		{
			if (id_createFromComment_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_createFromComment_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "createFromComment", "(Ljava/lang/String;Ljava/lang/String;)Lcom/google/android/exoplayer/extractor/GaplessInfo;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.Google.Android.Exoplayer.Extractor.GaplessInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.GaplessInfo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromComment_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_createFromXingHeaderValue_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='GaplessInfo']/method[@name='createFromXingHeaderValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createFromXingHeaderValue", "(I)Lcom/google/android/exoplayer/extractor/GaplessInfo;", "")]
		public static unsafe global::Com.Google.Android.Exoplayer.Extractor.GaplessInfo CreateFromXingHeaderValue (int p0)
		{
			if (id_createFromXingHeaderValue_I == IntPtr.Zero)
				id_createFromXingHeaderValue_I = JNIEnv.GetStaticMethodID (class_ref, "createFromXingHeaderValue", "(I)Lcom/google/android/exoplayer/extractor/GaplessInfo;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.GaplessInfo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createFromXingHeaderValue_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
