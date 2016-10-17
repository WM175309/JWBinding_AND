using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Upstream.Cache {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/interface[@name='Cache.Listener']"
	[Register ("com/google/android/exoplayer/upstream/cache/Cache$Listener", "", "Com.Google.Android.Exoplayer.Upstream.Cache.ICacheListenerInvoker")]
	public partial interface ICacheListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/interface[@name='Cache.Listener']/method[@name='onSpanAdded' and count(parameter)=2 and parameter[1][@type='com.google.android.exoplayer.upstream.cache.Cache'] and parameter[2][@type='com.google.android.exoplayer.upstream.cache.CacheSpan']]"
		[Register ("onSpanAdded", "(Lcom/google/android/exoplayer/upstream/cache/Cache;Lcom/google/android/exoplayer/upstream/cache/CacheSpan;)V", "GetOnSpanAdded_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Handler:Com.Google.Android.Exoplayer.Upstream.Cache.ICacheListenerInvoker, JWBinding_AND")]
		void OnSpanAdded (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0, global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/interface[@name='Cache.Listener']/method[@name='onSpanRemoved' and count(parameter)=2 and parameter[1][@type='com.google.android.exoplayer.upstream.cache.Cache'] and parameter[2][@type='com.google.android.exoplayer.upstream.cache.CacheSpan']]"
		[Register ("onSpanRemoved", "(Lcom/google/android/exoplayer/upstream/cache/Cache;Lcom/google/android/exoplayer/upstream/cache/CacheSpan;)V", "GetOnSpanRemoved_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Handler:Com.Google.Android.Exoplayer.Upstream.Cache.ICacheListenerInvoker, JWBinding_AND")]
		void OnSpanRemoved (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0, global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/interface[@name='Cache.Listener']/method[@name='onSpanTouched' and count(parameter)=3 and parameter[1][@type='com.google.android.exoplayer.upstream.cache.Cache'] and parameter[2][@type='com.google.android.exoplayer.upstream.cache.CacheSpan'] and parameter[3][@type='com.google.android.exoplayer.upstream.cache.CacheSpan']]"
		[Register ("onSpanTouched", "(Lcom/google/android/exoplayer/upstream/cache/Cache;Lcom/google/android/exoplayer/upstream/cache/CacheSpan;Lcom/google/android/exoplayer/upstream/cache/CacheSpan;)V", "GetOnSpanTouched_Lcom_google_android_exoplayer_upstream_cache_Cache_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Handler:Com.Google.Android.Exoplayer.Upstream.Cache.ICacheListenerInvoker, JWBinding_AND")]
		void OnSpanTouched (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0, global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p1, global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p2);

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/upstream/cache/Cache$Listener", DoNotGenerateAcw=true)]
	internal class ICacheListenerInvoker : global::Java.Lang.Object, ICacheListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/upstream/cache/Cache$Listener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICacheListenerInvoker); }
		}

		IntPtr class_ref;

		public static ICacheListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICacheListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.upstream.cache.Cache.Listener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICacheListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	public partial class SpanAddedEventArgs : global::System.EventArgs {

		public SpanAddedEventArgs (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0, global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0;
		public global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache P0 {
			get { return p0; }
		}

		global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p1;
		public global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan P1 {
			get { return p1; }
		}
	}

	public partial class SpanRemovedEventArgs : global::System.EventArgs {

		public SpanRemovedEventArgs (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0, global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0;
		public global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache P0 {
			get { return p0; }
		}

		global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p1;
		public global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan P1 {
			get { return p1; }
		}
	}

	public partial class SpanTouchedEventArgs : global::System.EventArgs {

		public SpanTouchedEventArgs (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0, global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p1, global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0;
		public global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache P0 {
			get { return p0; }
		}

		global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p1;
		public global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan P1 {
			get { return p1; }
		}

		global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p2;
		public global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/exoplayer/upstream/cache/Cache_ListenerImplementor")]
	internal sealed partial class ICacheListenerImplementor : global::Java.Lang.Object, ICacheListener {

		object sender;

		public ICacheListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/google/android/exoplayer/upstream/cache/Cache_ListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<SpanAddedEventArgs> OnSpanAddedHandler;
#pragma warning restore 0649

		public void OnSpanAdded (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0, global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p1)
		{
			var __h = OnSpanAddedHandler;
			if (__h != null)
				__h (sender, new SpanAddedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<SpanRemovedEventArgs> OnSpanRemovedHandler;
#pragma warning restore 0649

		public void OnSpanRemoved (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0, global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p1)
		{
			var __h = OnSpanRemovedHandler;
			if (__h != null)
				__h (sender, new SpanRemovedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<SpanTouchedEventArgs> OnSpanTouchedHandler;
#pragma warning restore 0649

		public void OnSpanTouched (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache p0, global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p1, global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p2)
		{
			var __h = OnSpanTouchedHandler;
			if (__h != null)
				__h (sender, new SpanTouchedEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (ICacheListenerImplementor value)
		{
			return value.OnSpanAddedHandler == null && value.OnSpanRemovedHandler == null && value.OnSpanTouchedHandler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/interface[@name='Cache']"
	[Register ("com/google/android/exoplayer/upstream/cache/Cache", "", "Com.Google.Android.Exoplayer.Upstream.Cache.ICacheInvoker")]
	public partial interface ICache : IJavaObject {

		long CacheSpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/interface[@name='Cache']/method[@name='getCacheSpace' and count(parameter)=0]"
			[Register ("getCacheSpace", "()J", "GetGetCacheSpaceHandler:Com.Google.Android.Exoplayer.Upstream.Cache.ICacheInvoker, JWBinding_AND")] get;
		}

		global::System.Collections.Generic.ICollection<string> Keys {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/interface[@name='Cache']/method[@name='getKeys' and count(parameter)=0]"
			[Register ("getKeys", "()Ljava/util/Set;", "GetGetKeysHandler:Com.Google.Android.Exoplayer.Upstream.Cache.ICacheInvoker, JWBinding_AND")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/interface[@name='Cache']/method[@name='addListener' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.android.exoplayer.upstream.cache.Cache.Listener']]"
		[Register ("addListener", "(Ljava/lang/String;Lcom/google/android/exoplayer/upstream/cache/Cache$Listener;)Ljava/util/NavigableSet;", "GetAddListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_Handler:Com.Google.Android.Exoplayer.Upstream.Cache.ICacheInvoker, JWBinding_AND")]
		global::Java.Util.INavigableSet AddListener (string p0, global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/interface[@name='Cache']/method[@name='commitFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("commitFile", "(Ljava/io/File;)V", "GetCommitFile_Ljava_io_File_Handler:Com.Google.Android.Exoplayer.Upstream.Cache.ICacheInvoker, JWBinding_AND")]
		void CommitFile (global::Java.IO.File p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/interface[@name='Cache']/method[@name='getCachedSpans' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCachedSpans", "(Ljava/lang/String;)Ljava/util/NavigableSet;", "GetGetCachedSpans_Ljava_lang_String_Handler:Com.Google.Android.Exoplayer.Upstream.Cache.ICacheInvoker, JWBinding_AND")]
		global::Java.Util.INavigableSet GetCachedSpans (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/interface[@name='Cache']/method[@name='isCached' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("isCached", "(Ljava/lang/String;JJ)Z", "GetIsCached_Ljava_lang_String_JJHandler:Com.Google.Android.Exoplayer.Upstream.Cache.ICacheInvoker, JWBinding_AND")]
		bool IsCached (string p0, long p1, long p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/interface[@name='Cache']/method[@name='releaseHoleSpan' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer.upstream.cache.CacheSpan']]"
		[Register ("releaseHoleSpan", "(Lcom/google/android/exoplayer/upstream/cache/CacheSpan;)V", "GetReleaseHoleSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Handler:Com.Google.Android.Exoplayer.Upstream.Cache.ICacheInvoker, JWBinding_AND")]
		void ReleaseHoleSpan (global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/interface[@name='Cache']/method[@name='removeListener' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.android.exoplayer.upstream.cache.Cache.Listener']]"
		[Register ("removeListener", "(Ljava/lang/String;Lcom/google/android/exoplayer/upstream/cache/Cache$Listener;)V", "GetRemoveListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_Handler:Com.Google.Android.Exoplayer.Upstream.Cache.ICacheInvoker, JWBinding_AND")]
		void RemoveListener (string p0, global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheListener p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/interface[@name='Cache']/method[@name='removeSpan' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer.upstream.cache.CacheSpan']]"
		[Register ("removeSpan", "(Lcom/google/android/exoplayer/upstream/cache/CacheSpan;)V", "GetRemoveSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Handler:Com.Google.Android.Exoplayer.Upstream.Cache.ICacheInvoker, JWBinding_AND")]
		void RemoveSpan (global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/interface[@name='Cache']/method[@name='startFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("startFile", "(Ljava/lang/String;JJ)Ljava/io/File;", "GetStartFile_Ljava_lang_String_JJHandler:Com.Google.Android.Exoplayer.Upstream.Cache.ICacheInvoker, JWBinding_AND")]
		global::Java.IO.File StartFile (string p0, long p1, long p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/interface[@name='Cache']/method[@name='startReadWrite' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("startReadWrite", "(Ljava/lang/String;J)Lcom/google/android/exoplayer/upstream/cache/CacheSpan;", "GetStartReadWrite_Ljava_lang_String_JHandler:Com.Google.Android.Exoplayer.Upstream.Cache.ICacheInvoker, JWBinding_AND")]
		global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan StartReadWrite (string p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/interface[@name='Cache']/method[@name='startReadWriteNonBlocking' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("startReadWriteNonBlocking", "(Ljava/lang/String;J)Lcom/google/android/exoplayer/upstream/cache/CacheSpan;", "GetStartReadWriteNonBlocking_Ljava_lang_String_JHandler:Com.Google.Android.Exoplayer.Upstream.Cache.ICacheInvoker, JWBinding_AND")]
		global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan StartReadWriteNonBlocking (string p0, long p1);

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/upstream/cache/Cache", DoNotGenerateAcw=true)]
	internal class ICacheInvoker : global::Java.Lang.Object, ICache {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/upstream/cache/Cache");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICacheInvoker); }
		}

		IntPtr class_ref;

		public static ICache GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICache> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.upstream.cache.Cache"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICacheInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCacheSpace;
#pragma warning disable 0169
		static Delegate GetGetCacheSpaceHandler ()
		{
			if (cb_getCacheSpace == null)
				cb_getCacheSpace = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCacheSpace);
			return cb_getCacheSpace;
		}

		static long n_GetCacheSpace (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CacheSpace;
		}
#pragma warning restore 0169

		IntPtr id_getCacheSpace;
		public unsafe long CacheSpace {
			get {
				if (id_getCacheSpace == IntPtr.Zero)
					id_getCacheSpace = JNIEnv.GetMethodID (class_ref, "getCacheSpace", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCacheSpace);
			}
		}

		static Delegate cb_getKeys;
#pragma warning disable 0169
		static Delegate GetGetKeysHandler ()
		{
			if (cb_getKeys == null)
				cb_getKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKeys);
			return cb_getKeys;
		}

		static IntPtr n_GetKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.Keys);
		}
#pragma warning restore 0169

		IntPtr id_getKeys;
		public unsafe global::System.Collections.Generic.ICollection<string> Keys {
			get {
				if (id_getKeys == IntPtr.Zero)
					id_getKeys = JNIEnv.GetMethodID (class_ref, "getKeys", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKeys), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_addListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_;
#pragma warning disable 0169
		static Delegate GetAddListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_Handler ()
		{
			if (cb_addListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_ == null)
				cb_addListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_);
			return cb_addListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_;
		}

		static IntPtr n_AddListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheListener p1 = (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheListener)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddListener (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_addListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_;
		public unsafe global::Java.Util.INavigableSet AddListener (string p0, global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheListener p1)
		{
			if (id_addListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_ == IntPtr.Zero)
				id_addListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_ = JNIEnv.GetMethodID (class_ref, "addListener", "(Ljava/lang/String;Lcom/google/android/exoplayer/upstream/cache/Cache$Listener;)Ljava/util/NavigableSet;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			global::Java.Util.INavigableSet __ret = global::Java.Lang.Object.GetObject<global::Java.Util.INavigableSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_commitFile_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetCommitFile_Ljava_io_File_Handler ()
		{
			if (cb_commitFile_Ljava_io_File_ == null)
				cb_commitFile_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CommitFile_Ljava_io_File_);
			return cb_commitFile_Ljava_io_File_;
		}

		static void n_CommitFile_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p0 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CommitFile (p0);
		}
#pragma warning restore 0169

		IntPtr id_commitFile_Ljava_io_File_;
		public unsafe void CommitFile (global::Java.IO.File p0)
		{
			if (id_commitFile_Ljava_io_File_ == IntPtr.Zero)
				id_commitFile_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "commitFile", "(Ljava/io/File;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commitFile_Ljava_io_File_, __args);
		}

		static Delegate cb_getCachedSpans_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCachedSpans_Ljava_lang_String_Handler ()
		{
			if (cb_getCachedSpans_Ljava_lang_String_ == null)
				cb_getCachedSpans_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCachedSpans_Ljava_lang_String_);
			return cb_getCachedSpans_Ljava_lang_String_;
		}

		static IntPtr n_GetCachedSpans_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCachedSpans (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getCachedSpans_Ljava_lang_String_;
		public unsafe global::Java.Util.INavigableSet GetCachedSpans (string p0)
		{
			if (id_getCachedSpans_Ljava_lang_String_ == IntPtr.Zero)
				id_getCachedSpans_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCachedSpans", "(Ljava/lang/String;)Ljava/util/NavigableSet;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Util.INavigableSet __ret = global::Java.Lang.Object.GetObject<global::Java.Util.INavigableSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedSpans_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_isCached_Ljava_lang_String_JJ;
#pragma warning disable 0169
		static Delegate GetIsCached_Ljava_lang_String_JJHandler ()
		{
			if (cb_isCached_Ljava_lang_String_JJ == null)
				cb_isCached_Ljava_lang_String_JJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, long, bool>) n_IsCached_Ljava_lang_String_JJ);
			return cb_isCached_Ljava_lang_String_JJ;
		}

		static bool n_IsCached_Ljava_lang_String_JJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2)
		{
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsCached (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isCached_Ljava_lang_String_JJ;
		public unsafe bool IsCached (string p0, long p1, long p2)
		{
			if (id_isCached_Ljava_lang_String_JJ == IntPtr.Zero)
				id_isCached_Ljava_lang_String_JJ = JNIEnv.GetMethodID (class_ref, "isCached", "(Ljava/lang/String;JJ)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCached_Ljava_lang_String_JJ, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_releaseHoleSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_;
#pragma warning disable 0169
		static Delegate GetReleaseHoleSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Handler ()
		{
			if (cb_releaseHoleSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ == null)
				cb_releaseHoleSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReleaseHoleSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_);
			return cb_releaseHoleSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_;
		}

		static void n_ReleaseHoleSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseHoleSpan (p0);
		}
#pragma warning restore 0169

		IntPtr id_releaseHoleSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_;
		public unsafe void ReleaseHoleSpan (global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p0)
		{
			if (id_releaseHoleSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ == IntPtr.Zero)
				id_releaseHoleSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ = JNIEnv.GetMethodID (class_ref, "releaseHoleSpan", "(Lcom/google/android/exoplayer/upstream/cache/CacheSpan;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseHoleSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_, __args);
		}

		static Delegate cb_removeListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_;
#pragma warning disable 0169
		static Delegate GetRemoveListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_Handler ()
		{
			if (cb_removeListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_ == null)
				cb_removeListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_);
			return cb_removeListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_;
		}

		static void n_RemoveListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheListener p1 = (global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheListener)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveListener (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_removeListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_;
		public unsafe void RemoveListener (string p0, global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheListener p1)
		{
			if (id_removeListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_ == IntPtr.Zero)
				id_removeListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_ = JNIEnv.GetMethodID (class_ref, "removeListener", "(Ljava/lang/String;Lcom/google/android/exoplayer/upstream/cache/Cache$Listener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_removeSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_;
#pragma warning disable 0169
		static Delegate GetRemoveSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_Handler ()
		{
			if (cb_removeSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ == null)
				cb_removeSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_);
			return cb_removeSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_;
		}

		static void n_RemoveSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveSpan (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_;
		public unsafe void RemoveSpan (global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p0)
		{
			if (id_removeSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ == IntPtr.Zero)
				id_removeSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ = JNIEnv.GetMethodID (class_ref, "removeSpan", "(Lcom/google/android/exoplayer/upstream/cache/CacheSpan;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_, __args);
		}

		static Delegate cb_startFile_Ljava_lang_String_JJ;
#pragma warning disable 0169
		static Delegate GetStartFile_Ljava_lang_String_JJHandler ()
		{
			if (cb_startFile_Ljava_lang_String_JJ == null)
				cb_startFile_Ljava_lang_String_JJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, long, IntPtr>) n_StartFile_Ljava_lang_String_JJ);
			return cb_startFile_Ljava_lang_String_JJ;
		}

		static IntPtr n_StartFile_Ljava_lang_String_JJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2)
		{
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StartFile (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_startFile_Ljava_lang_String_JJ;
		public unsafe global::Java.IO.File StartFile (string p0, long p1, long p2)
		{
			if (id_startFile_Ljava_lang_String_JJ == IntPtr.Zero)
				id_startFile_Ljava_lang_String_JJ = JNIEnv.GetMethodID (class_ref, "startFile", "(Ljava/lang/String;JJ)Ljava/io/File;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_startFile_Ljava_lang_String_JJ, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_startReadWrite_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetStartReadWrite_Ljava_lang_String_JHandler ()
		{
			if (cb_startReadWrite_Ljava_lang_String_J == null)
				cb_startReadWrite_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_StartReadWrite_Ljava_lang_String_J);
			return cb_startReadWrite_Ljava_lang_String_J;
		}

		static IntPtr n_StartReadWrite_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StartReadWrite (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_startReadWrite_Ljava_lang_String_J;
		public unsafe global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan StartReadWrite (string p0, long p1)
		{
			if (id_startReadWrite_Ljava_lang_String_J == IntPtr.Zero)
				id_startReadWrite_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "startReadWrite", "(Ljava/lang/String;J)Lcom/google/android/exoplayer/upstream/cache/CacheSpan;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_startReadWrite_Ljava_lang_String_J, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_startReadWriteNonBlocking_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetStartReadWriteNonBlocking_Ljava_lang_String_JHandler ()
		{
			if (cb_startReadWriteNonBlocking_Ljava_lang_String_J == null)
				cb_startReadWriteNonBlocking_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_StartReadWriteNonBlocking_Ljava_lang_String_J);
			return cb_startReadWriteNonBlocking_Ljava_lang_String_J;
		}

		static IntPtr n_StartReadWriteNonBlocking_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StartReadWriteNonBlocking (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_startReadWriteNonBlocking_Ljava_lang_String_J;
		public unsafe global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan StartReadWriteNonBlocking (string p0, long p1)
		{
			if (id_startReadWriteNonBlocking_Ljava_lang_String_J == IntPtr.Zero)
				id_startReadWriteNonBlocking_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "startReadWriteNonBlocking", "(Ljava/lang/String;J)Lcom/google/android/exoplayer/upstream/cache/CacheSpan;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_startReadWriteNonBlocking_Ljava_lang_String_J, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
