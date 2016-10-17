using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='Assertions']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/util/Assertions", DoNotGenerateAcw=true)]
	public sealed partial class Assertions : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/util/Assertions", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Assertions); }
		}

		internal Assertions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_checkArgument_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='Assertions']/method[@name='checkArgument' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("checkArgument", "(Z)V", "")]
		public static unsafe void CheckArgument (bool p0)
		{
			if (id_checkArgument_Z == IntPtr.Zero)
				id_checkArgument_Z = JNIEnv.GetStaticMethodID (class_ref, "checkArgument", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkArgument_Z, __args);
			} finally {
			}
		}

		static IntPtr id_checkArgument_ZLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='Assertions']/method[@name='checkArgument' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkArgument", "(ZLjava/lang/Object;)V", "")]
		public static unsafe void CheckArgument (bool p0, global::Java.Lang.Object p1)
		{
			if (id_checkArgument_ZLjava_lang_Object_ == IntPtr.Zero)
				id_checkArgument_ZLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkArgument", "(ZLjava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkArgument_ZLjava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_checkMainThread;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='Assertions']/method[@name='checkMainThread' and count(parameter)=0]"
		[Register ("checkMainThread", "()V", "")]
		public static unsafe void CheckMainThread ()
		{
			if (id_checkMainThread == IntPtr.Zero)
				id_checkMainThread = JNIEnv.GetStaticMethodID (class_ref, "checkMainThread", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkMainThread);
			} finally {
			}
		}

		static IntPtr id_checkNotEmpty_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='Assertions']/method[@name='checkNotEmpty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkNotEmpty", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string CheckNotEmpty (string p0)
		{
			if (id_checkNotEmpty_Ljava_lang_String_ == IntPtr.Zero)
				id_checkNotEmpty_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "checkNotEmpty", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkNotEmpty_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_checkNotEmpty_Ljava_lang_String_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='Assertions']/method[@name='checkNotEmpty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkNotEmpty", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string CheckNotEmpty (string p0, global::Java.Lang.Object p1)
		{
			if (id_checkNotEmpty_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
				id_checkNotEmpty_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkNotEmpty", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkNotEmpty_Ljava_lang_String_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_checkNotNull_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='Assertions']/method[@name='checkNotNull' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("checkNotNull", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object CheckNotNull (global::Java.Lang.Object p0)
		{
			if (id_checkNotNull_Ljava_lang_Object_ == IntPtr.Zero)
				id_checkNotNull_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkNotNull", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkNotNull_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_checkNotNull_Ljava_lang_Object_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='Assertions']/method[@name='checkNotNull' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkNotNull", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object CheckNotNull (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_checkNotNull_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_checkNotNull_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkNotNull", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_checkNotNull_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_checkState_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='Assertions']/method[@name='checkState' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("checkState", "(Z)V", "")]
		public static unsafe void CheckState (bool p0)
		{
			if (id_checkState_Z == IntPtr.Zero)
				id_checkState_Z = JNIEnv.GetStaticMethodID (class_ref, "checkState", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkState_Z, __args);
			} finally {
			}
		}

		static IntPtr id_checkState_ZLjava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='Assertions']/method[@name='checkState' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.Object']]"
		[Register ("checkState", "(ZLjava/lang/Object;)V", "")]
		public static unsafe void CheckState (bool p0, global::Java.Lang.Object p1)
		{
			if (id_checkState_ZLjava_lang_Object_ == IntPtr.Zero)
				id_checkState_ZLjava_lang_Object_ = JNIEnv.GetStaticMethodID (class_ref, "checkState", "(ZLjava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_checkState_ZLjava_lang_Object_, __args);
			} finally {
			}
		}

	}
}
