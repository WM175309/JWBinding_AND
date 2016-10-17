using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='VerboseLogUtil']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/util/VerboseLogUtil", DoNotGenerateAcw=true)]
	public sealed partial class VerboseLogUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/util/VerboseLogUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VerboseLogUtil); }
		}

		internal VerboseLogUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_areAllTagsEnabled;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='VerboseLogUtil']/method[@name='areAllTagsEnabled' and count(parameter)=0]"
		[Register ("areAllTagsEnabled", "()Z", "")]
		public static unsafe bool AreAllTagsEnabled ()
		{
			if (id_areAllTagsEnabled == IntPtr.Zero)
				id_areAllTagsEnabled = JNIEnv.GetStaticMethodID (class_ref, "areAllTagsEnabled", "()Z");
			try {
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_areAllTagsEnabled);
			} finally {
			}
		}

		static IntPtr id_isTagEnabled_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='VerboseLogUtil']/method[@name='isTagEnabled' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isTagEnabled", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsTagEnabled (string p0)
		{
			if (id_isTagEnabled_Ljava_lang_String_ == IntPtr.Zero)
				id_isTagEnabled_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isTagEnabled", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isTagEnabled_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setEnableAllTags_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='VerboseLogUtil']/method[@name='setEnableAllTags' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableAllTags", "(Z)V", "")]
		public static unsafe void SetEnableAllTags (bool p0)
		{
			if (id_setEnableAllTags_Z == IntPtr.Zero)
				id_setEnableAllTags_Z = JNIEnv.GetStaticMethodID (class_ref, "setEnableAllTags", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setEnableAllTags_Z, __args);
			} finally {
			}
		}

		static IntPtr id_setEnabledTags_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='VerboseLogUtil']/method[@name='setEnabledTags' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("setEnabledTags", "([Ljava/lang/String;)V", "")]
		public static unsafe void SetEnabledTags (params  string[] p0)
		{
			if (id_setEnabledTags_arrayLjava_lang_String_ == IntPtr.Zero)
				id_setEnabledTags_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setEnabledTags", "([Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setEnabledTags_arrayLjava_lang_String_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
