using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Upstream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DataSourceInputStream']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/upstream/DataSourceInputStream", DoNotGenerateAcw=true)]
	public sealed partial class DataSourceInputStream : global::Java.IO.InputStream {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/upstream/DataSourceInputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DataSourceInputStream); }
		}

		internal DataSourceInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DataSourceInputStream']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public override sealed unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
			} finally {
			}
		}

		static IntPtr id_open;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DataSourceInputStream']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()V", "")]
		public unsafe void Open ()
		{
			if (id_open == IntPtr.Zero)
				id_open = JNIEnv.GetMethodID (class_ref, "open", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_open);
			} finally {
			}
		}

		static IntPtr id_read;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DataSourceInputStream']/method[@name='read' and count(parameter)=0]"
		[Register ("read", "()I", "")]
		public override sealed unsafe int Read ()
		{
			if (id_read == IntPtr.Zero)
				id_read = JNIEnv.GetMethodID (class_ref, "read", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read);
			} finally {
			}
		}

		static IntPtr id_read_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DataSourceInputStream']/method[@name='read' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("read", "([B)I", "")]
		public override sealed unsafe int Read (byte[] p0)
		{
			if (id_read_arrayB == IntPtr.Zero)
				id_read_arrayB = JNIEnv.GetMethodID (class_ref, "read", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_arrayB, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_read_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DataSourceInputStream']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("read", "([BII)I", "")]
		public override sealed unsafe int Read (byte[] p0, int p1, int p2)
		{
			if (id_read_arrayBII == IntPtr.Zero)
				id_read_arrayBII = JNIEnv.GetMethodID (class_ref, "read", "([BII)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_arrayBII, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_skip_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DataSourceInputStream']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("skip", "(J)J", "")]
		public override sealed unsafe long Skip (long p0)
		{
			if (id_skip_J == IntPtr.Zero)
				id_skip_J = JNIEnv.GetMethodID (class_ref, "skip", "(J)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_skip_J, __args);
			} finally {
			}
		}

	}
}
