using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Upstream.Cache {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/interface[@name='CacheEvictor']"
	[Register ("com/google/android/exoplayer/upstream/cache/CacheEvictor", "", "Com.Google.Android.Exoplayer.Upstream.Cache.ICacheEvictorInvoker")]
	public partial interface ICacheEvictor : global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheListener {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/interface[@name='CacheEvictor']/method[@name='onStartFile' and count(parameter)=4 and parameter[1][@type='com.google.android.exoplayer.upstream.cache.Cache'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("onStartFile", "(Lcom/google/android/exoplayer/upstream/cache/Cache;Ljava/lang/String;JJ)V", "GetOnStartFile_Lcom_google_android_exoplayer_upstream_cache_Cache_Ljava_lang_String_JJHandler:Com.Google.Android.Exoplayer.Upstream.Cache.ICacheEvictorInvoker, JWBinding_AND")]
		void OnStartFile (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0, string p1, long p2, long p3);

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/upstream/cache/CacheEvictor", DoNotGenerateAcw=true)]
	internal class ICacheEvictorInvoker : global::Java.Lang.Object, ICacheEvictor {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/upstream/cache/CacheEvictor");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICacheEvictorInvoker); }
		}

		IntPtr class_ref;

		public static ICacheEvictor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICacheEvictor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.upstream.cache.CacheEvictor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICacheEvictorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onStartFile_Lcom_google_android_exoplayer_upstream_cache_Cache_Ljava_lang_String_JJ;
#pragma warning disable 0169
		static Delegate GetOnStartFile_Lcom_google_android_exoplayer_upstream_cache_Cache_Ljava_lang_String_JJHandler ()
		{
			if (cb_onStartFile_Lcom_google_android_exoplayer_upstream_cache_Cache_Ljava_lang_String_JJ == null)
				cb_onStartFile_Lcom_google_android_exoplayer_upstream_cache_Cache_Ljava_lang_String_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, long, long>) n_OnStartFile_Lcom_google_android_exoplayer_upstream_cache_Cache_Ljava_lang_String_JJ);
			return cb_onStartFile_Lcom_google_android_exoplayer_upstream_cache_Cache_Ljava_lang_String_JJ;
		}

		static void n_OnStartFile_Lcom_google_android_exoplayer_upstream_cache_Cache_Ljava_lang_String_JJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2, long p3)
		{
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheEvictor __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheEvictor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0 = (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnStartFile (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onStartFile_Lcom_google_android_exoplayer_upstream_cache_Cache_Ljava_lang_String_JJ;
		public unsafe void OnStartFile (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0, string p1, long p2, long p3)
		{
			if (id_onStartFile_Lcom_google_android_exoplayer_upstream_cache_Cache_Ljava_lang_String_JJ == IntPtr.Zero)
				id_onStartFile_Lcom_google_android_exoplayer_upstream_cache_Cache_Ljava_lang_String_JJ = JNIEnv.GetMethodID (class_ref, "onStartFile", "(Lcom/google/android/exoplayer/upstream/cache/Cache;Ljava/lang/String;JJ)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onStartFile_Lcom_google_android_exoplayer_upstream_cache_Cache_Ljava_lang_String_JJ, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_onSpanAdded_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_;
#pragma warning disable 0169
		static Delegate GetOnSpanAdded_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Handler ()
		{
			if (cb_onSpanAdded_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ == null)
				cb_onSpanAdded_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSpanAdded_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_);
			return cb_onSpanAdded_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_;
		}

		static void n_OnSpanAdded_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheEvictor __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheEvictor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0 = (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSpanAdded (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onSpanAdded_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_;
		public unsafe void OnSpanAdded (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0, global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p1)
		{
			if (id_onSpanAdded_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ == IntPtr.Zero)
				id_onSpanAdded_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ = JNIEnv.GetMethodID (class_ref, "onSpanAdded", "(Lcom/google/android/exoplayer/upstream/cache/Cache;Lcom/google/android/exoplayer/upstream/cache/CacheSpan;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpanAdded_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_, __args);
		}

		static Delegate cb_onSpanRemoved_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_;
#pragma warning disable 0169
		static Delegate GetOnSpanRemoved_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Handler ()
		{
			if (cb_onSpanRemoved_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ == null)
				cb_onSpanRemoved_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSpanRemoved_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_);
			return cb_onSpanRemoved_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_;
		}

		static void n_OnSpanRemoved_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheEvictor __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheEvictor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0 = (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnSpanRemoved (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onSpanRemoved_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_;
		public unsafe void OnSpanRemoved (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0, global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p1)
		{
			if (id_onSpanRemoved_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ == IntPtr.Zero)
				id_onSpanRemoved_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ = JNIEnv.GetMethodID (class_ref, "onSpanRemoved", "(Lcom/google/android/exoplayer/upstream/cache/Cache;Lcom/google/android/exoplayer/upstream/cache/CacheSpan;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpanRemoved_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_, __args);
		}

		static Delegate cb_onSpanTouched_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_;
#pragma warning disable 0169
		static Delegate GetOnSpanTouched_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Handler ()
		{
			if (cb_onSpanTouched_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ == null)
				cb_onSpanTouched_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSpanTouched_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_);
			return cb_onSpanTouched_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_;
		}

		static void n_OnSpanTouched_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheEvictor __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheEvictor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0 = (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p2 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnSpanTouched (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onSpanTouched_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_;
		public unsafe void OnSpanTouched (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0, global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p1, global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p2)
		{
			if (id_onSpanTouched_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ == IntPtr.Zero)
				id_onSpanTouched_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ = JNIEnv.GetMethodID (class_ref, "onSpanTouched", "(Lcom/google/android/exoplayer/upstream/cache/Cache;Lcom/google/android/exoplayer/upstream/cache/CacheSpan;Lcom/google/android/exoplayer/upstream/cache/CacheSpan;)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSpanTouched_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_, __args);
		}

	}

}
