using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Upstream.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='NoOpCacheEvictor']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/upstream/cache/NoOpCacheEvictor", DoNotGenerateAcw=true)]
	public sealed partial class NoOpCacheEvictor : global::Java.Lang.Object, global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheEvictor {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/upstream/cache/NoOpCacheEvictor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NoOpCacheEvictor); }
		}

		internal NoOpCacheEvictor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='NoOpCacheEvictor']/constructor[@name='NoOpCacheEvictor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NoOpCacheEvictor ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (NoOpCacheEvictor)) {
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

		static IntPtr id_onSpanAdded_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='NoOpCacheEvictor']/method[@name='onSpanAdded' and count(parameter)=2 and parameter[1][@type='com.google.android.exoplayer.upstream.cache.Cache'] and parameter[2][@type='com.google.android.exoplayer.upstream.cache.CacheSpan']]"
		[Register ("onSpanAdded", "(Lcom/google/android/exoplayer/upstream/cache/Cache;Lcom/google/android/exoplayer/upstream/cache/CacheSpan;)V", "")]
		public unsafe void OnSpanAdded (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0, global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p1)
		{
			if (id_onSpanAdded_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ == IntPtr.Zero)
				id_onSpanAdded_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ = JNIEnv.GetMethodID (class_ref, "onSpanAdded", "(Lcom/google/android/exoplayer/upstream/cache/Cache;Lcom/google/android/exoplayer/upstream/cache/CacheSpan;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpanAdded_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_, __args);
			} finally {
			}
		}

		static IntPtr id_onSpanRemoved_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='NoOpCacheEvictor']/method[@name='onSpanRemoved' and count(parameter)=2 and parameter[1][@type='com.google.android.exoplayer.upstream.cache.Cache'] and parameter[2][@type='com.google.android.exoplayer.upstream.cache.CacheSpan']]"
		[Register ("onSpanRemoved", "(Lcom/google/android/exoplayer/upstream/cache/Cache;Lcom/google/android/exoplayer/upstream/cache/CacheSpan;)V", "")]
		public unsafe void OnSpanRemoved (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0, global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p1)
		{
			if (id_onSpanRemoved_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ == IntPtr.Zero)
				id_onSpanRemoved_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ = JNIEnv.GetMethodID (class_ref, "onSpanRemoved", "(Lcom/google/android/exoplayer/upstream/cache/Cache;Lcom/google/android/exoplayer/upstream/cache/CacheSpan;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpanRemoved_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_, __args);
			} finally {
			}
		}

		static IntPtr id_onSpanTouched_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='NoOpCacheEvictor']/method[@name='onSpanTouched' and count(parameter)=3 and parameter[1][@type='com.google.android.exoplayer.upstream.cache.Cache'] and parameter[2][@type='com.google.android.exoplayer.upstream.cache.CacheSpan'] and parameter[3][@type='com.google.android.exoplayer.upstream.cache.CacheSpan']]"
		[Register ("onSpanTouched", "(Lcom/google/android/exoplayer/upstream/cache/Cache;Lcom/google/android/exoplayer/upstream/cache/CacheSpan;Lcom/google/android/exoplayer/upstream/cache/CacheSpan;)V", "")]
		public unsafe void OnSpanTouched (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0, global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p1, global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p2)
		{
			if (id_onSpanTouched_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ == IntPtr.Zero)
				id_onSpanTouched_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ = JNIEnv.GetMethodID (class_ref, "onSpanTouched", "(Lcom/google/android/exoplayer/upstream/cache/Cache;Lcom/google/android/exoplayer/upstream/cache/CacheSpan;Lcom/google/android/exoplayer/upstream/cache/CacheSpan;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpanTouched_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_, __args);
			} finally {
			}
		}

		static IntPtr id_onStartFile_Lcom_google_android_exoplayer_upstream_cache_Cache_Ljava_lang_String_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='NoOpCacheEvictor']/method[@name='onStartFile' and count(parameter)=4 and parameter[1][@type='com.google.android.exoplayer.upstream.cache.Cache'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("onStartFile", "(Lcom/google/android/exoplayer/upstream/cache/Cache;Ljava/lang/String;JJ)V", "")]
		public unsafe void OnStartFile (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0, string p1, long p2, long p3)
		{
			if (id_onStartFile_Lcom_google_android_exoplayer_upstream_cache_Cache_Ljava_lang_String_JJ == IntPtr.Zero)
				id_onStartFile_Lcom_google_android_exoplayer_upstream_cache_Cache_Ljava_lang_String_JJ = JNIEnv.GetMethodID (class_ref, "onStartFile", "(Lcom/google/android/exoplayer/upstream/cache/Cache;Ljava/lang/String;JJ)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStartFile_Lcom_google_android_exoplayer_upstream_cache_Cache_Ljava_lang_String_JJ, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
