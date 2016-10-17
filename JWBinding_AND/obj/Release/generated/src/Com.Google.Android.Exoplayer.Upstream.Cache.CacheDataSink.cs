using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Upstream.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='CacheDataSink']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/upstream/cache/CacheDataSink", DoNotGenerateAcw=true)]
	public sealed partial class CacheDataSink : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='CacheDataSink.CacheDataSinkException']"
		[global::Android.Runtime.Register ("com/google/android/exoplayer/upstream/cache/CacheDataSink$CacheDataSinkException", DoNotGenerateAcw=true)]
		public partial class CacheDataSinkException : global::Java.IO.IOException {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/exoplayer/upstream/cache/CacheDataSink$CacheDataSinkException", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CacheDataSinkException); }
			}

			protected CacheDataSinkException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_io_IOException_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='CacheDataSink.CacheDataSinkException']/constructor[@name='CacheDataSink.CacheDataSinkException' and count(parameter)=1 and parameter[1][@type='java.io.IOException']]"
			[Register (".ctor", "(Ljava/io/IOException;)V", "")]
			public unsafe CacheDataSinkException (global::Java.IO.IOException p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (GetType () != typeof (CacheDataSinkException)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/IOException;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/io/IOException;)V", __args);
						return;
					}

					if (id_ctor_Ljava_io_IOException_ == IntPtr.Zero)
						id_ctor_Ljava_io_IOException_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/IOException;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_IOException_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_io_IOException_, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/upstream/cache/CacheDataSink", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CacheDataSink); }
		}

		internal CacheDataSink (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_android_exoplayer_upstream_cache_Cache_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='CacheDataSink']/constructor[@name='CacheDataSink' and count(parameter)=2 and parameter[1][@type='com.google.android.exoplayer.upstream.cache.Cache'] and parameter[2][@type='long']]"
		[Register (".ctor", "(Lcom/google/android/exoplayer/upstream/cache/Cache;J)V", "")]
		public unsafe CacheDataSink (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0, long p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (CacheDataSink)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/google/android/exoplayer/upstream/cache/Cache;J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/google/android/exoplayer/upstream/cache/Cache;J)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_android_exoplayer_upstream_cache_Cache_J == IntPtr.Zero)
					id_ctor_Lcom_google_android_exoplayer_upstream_cache_Cache_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/android/exoplayer/upstream/cache/Cache;J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_android_exoplayer_upstream_cache_Cache_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_google_android_exoplayer_upstream_cache_Cache_J, __args);
			} finally {
			}
		}

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='CacheDataSink']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
			} finally {
			}
		}

		static IntPtr id_write_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='CacheDataSink']/method[@name='write' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("write", "([BII)V", "")]
		public unsafe void Write (byte[] p0, int p1, int p2)
		{
			if (id_write_arrayBII == IntPtr.Zero)
				id_write_arrayBII = JNIEnv.GetMethodID (class_ref, "write", "([BII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_arrayBII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
