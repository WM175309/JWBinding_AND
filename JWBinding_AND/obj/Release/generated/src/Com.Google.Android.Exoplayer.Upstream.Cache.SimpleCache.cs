using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Upstream.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='SimpleCache']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/upstream/cache/SimpleCache", DoNotGenerateAcw=true)]
	public sealed partial class SimpleCache : global::Java.Lang.Object, global::Com.Google.Android.Exoplayer.Upstream.Cache.ICache {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/upstream/cache/SimpleCache", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleCache); }
		}

		internal SimpleCache (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_File_Lcom_google_android_exoplayer_upstream_cache_CacheEvictor_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='SimpleCache']/constructor[@name='SimpleCache' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='com.google.android.exoplayer.upstream.cache.CacheEvictor']]"
		[Register (".ctor", "(Ljava/io/File;Lcom/google/android/exoplayer/upstream/cache/CacheEvictor;)V", "")]
		public unsafe SimpleCache (global::Java.IO.File p0, global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheEvictor p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (SimpleCache)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/File;Lcom/google/android/exoplayer/upstream/cache/CacheEvictor;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/File;Lcom/google/android/exoplayer/upstream/cache/CacheEvictor;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_File_Lcom_google_android_exoplayer_upstream_cache_CacheEvictor_ == IntPtr.Zero)
					id_ctor_Ljava_io_File_Lcom_google_android_exoplayer_upstream_cache_CacheEvictor_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;Lcom/google/android/exoplayer/upstream/cache/CacheEvictor;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_Lcom_google_android_exoplayer_upstream_cache_CacheEvictor_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_File_Lcom_google_android_exoplayer_upstream_cache_CacheEvictor_, __args);
			} finally {
			}
		}

		static IntPtr id_getCacheSpace;
		public unsafe long CacheSpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='SimpleCache']/method[@name='getCacheSpace' and count(parameter)=0]"
			[Register ("getCacheSpace", "()J", "GetGetCacheSpaceHandler")]
			get {
				if (id_getCacheSpace == IntPtr.Zero)
					id_getCacheSpace = JNIEnv.GetMethodID (class_ref, "getCacheSpace", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCacheSpace);
				} finally {
				}
			}
		}

		static IntPtr id_getKeys;
		public unsafe global::System.Collections.Generic.ICollection<string> Keys {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='SimpleCache']/method[@name='getKeys' and count(parameter)=0]"
			[Register ("getKeys", "()Ljava/util/Set;", "GetGetKeysHandler")]
			get {
				if (id_getKeys == IntPtr.Zero)
					id_getKeys = JNIEnv.GetMethodID (class_ref, "getKeys", "()Ljava/util/Set;");
				try {
					return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKeys), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_addListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='SimpleCache']/method[@name='addListener' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.android.exoplayer.upstream.cache.Cache.Listener']]"
		[Register ("addListener", "(Ljava/lang/String;Lcom/google/android/exoplayer/upstream/cache/Cache$Listener;)Ljava/util/NavigableSet;", "")]
		public unsafe global::Java.Util.INavigableSet AddListener (string p0, global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheListener p1)
		{
			if (id_addListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_ == IntPtr.Zero)
				id_addListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_ = JNIEnv.GetMethodID (class_ref, "addListener", "(Ljava/lang/String;Lcom/google/android/exoplayer/upstream/cache/Cache$Listener;)Ljava/util/NavigableSet;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Java.Util.INavigableSet __ret = global::Java.Lang.Object.GetObject<global::Java.Util.INavigableSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_commitFile_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='SimpleCache']/method[@name='commitFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("commitFile", "(Ljava/io/File;)V", "")]
		public unsafe void CommitFile (global::Java.IO.File p0)
		{
			if (id_commitFile_Ljava_io_File_ == IntPtr.Zero)
				id_commitFile_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "commitFile", "(Ljava/io/File;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_commitFile_Ljava_io_File_, __args);
			} finally {
			}
		}

		static IntPtr id_getCachedSpans_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='SimpleCache']/method[@name='getCachedSpans' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCachedSpans", "(Ljava/lang/String;)Ljava/util/NavigableSet;", "")]
		public unsafe global::Java.Util.INavigableSet GetCachedSpans (string p0)
		{
			if (id_getCachedSpans_Ljava_lang_String_ == IntPtr.Zero)
				id_getCachedSpans_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCachedSpans", "(Ljava/lang/String;)Ljava/util/NavigableSet;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Util.INavigableSet __ret = global::Java.Lang.Object.GetObject<global::Java.Util.INavigableSet> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCachedSpans_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isCached_Ljava_lang_String_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='SimpleCache']/method[@name='isCached' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("isCached", "(Ljava/lang/String;JJ)Z", "")]
		public unsafe bool IsCached (string p0, long p1, long p2)
		{
			if (id_isCached_Ljava_lang_String_JJ == IntPtr.Zero)
				id_isCached_Ljava_lang_String_JJ = JNIEnv.GetMethodID (class_ref, "isCached", "(Ljava/lang/String;JJ)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCached_Ljava_lang_String_JJ, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_releaseHoleSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='SimpleCache']/method[@name='releaseHoleSpan' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer.upstream.cache.CacheSpan']]"
		[Register ("releaseHoleSpan", "(Lcom/google/android/exoplayer/upstream/cache/CacheSpan;)V", "")]
		public unsafe void ReleaseHoleSpan (global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p0)
		{
			if (id_releaseHoleSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ == IntPtr.Zero)
				id_releaseHoleSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ = JNIEnv.GetMethodID (class_ref, "releaseHoleSpan", "(Lcom/google/android/exoplayer/upstream/cache/CacheSpan;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseHoleSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_, __args);
			} finally {
			}
		}

		static IntPtr id_removeListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='SimpleCache']/method[@name='removeListener' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.android.exoplayer.upstream.cache.Cache.Listener']]"
		[Register ("removeListener", "(Ljava/lang/String;Lcom/google/android/exoplayer/upstream/cache/Cache$Listener;)V", "")]
		public unsafe void RemoveListener (string p0, global::Com.Google.Android.Exoplayer.Upstream.Cache.ICacheListener p1)
		{
			if (id_removeListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_ == IntPtr.Zero)
				id_removeListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_ = JNIEnv.GetMethodID (class_ref, "removeListener", "(Ljava/lang/String;Lcom/google/android/exoplayer/upstream/cache/Cache$Listener;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeListener_Ljava_lang_String_Lcom_google_android_exoplayer_upstream_cache_Cache_Listener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_removeSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='SimpleCache']/method[@name='removeSpan' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer.upstream.cache.CacheSpan']]"
		[Register ("removeSpan", "(Lcom/google/android/exoplayer/upstream/cache/CacheSpan;)V", "")]
		public unsafe void RemoveSpan (global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p0)
		{
			if (id_removeSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ == IntPtr.Zero)
				id_removeSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ = JNIEnv.GetMethodID (class_ref, "removeSpan", "(Lcom/google/android/exoplayer/upstream/cache/CacheSpan;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeSpan_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_, __args);
			} finally {
			}
		}

		static IntPtr id_startFile_Ljava_lang_String_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='SimpleCache']/method[@name='startFile' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("startFile", "(Ljava/lang/String;JJ)Ljava/io/File;", "")]
		public unsafe global::Java.IO.File StartFile (string p0, long p1, long p2)
		{
			if (id_startFile_Ljava_lang_String_JJ == IntPtr.Zero)
				id_startFile_Ljava_lang_String_JJ = JNIEnv.GetMethodID (class_ref, "startFile", "(Ljava/lang/String;JJ)Ljava/io/File;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_startFile_Ljava_lang_String_JJ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_startReadWrite_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='SimpleCache']/method[@name='startReadWrite' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("startReadWrite", "(Ljava/lang/String;J)Lcom/google/android/exoplayer/upstream/cache/CacheSpan;", "")]
		public unsafe global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan StartReadWrite (string p0, long p1)
		{
			if (id_startReadWrite_Ljava_lang_String_J == IntPtr.Zero)
				id_startReadWrite_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "startReadWrite", "(Ljava/lang/String;J)Lcom/google/android/exoplayer/upstream/cache/CacheSpan;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_startReadWrite_Ljava_lang_String_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_startReadWriteNonBlocking_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='SimpleCache']/method[@name='startReadWriteNonBlocking' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("startReadWriteNonBlocking", "(Ljava/lang/String;J)Lcom/google/android/exoplayer/upstream/cache/CacheSpan;", "")]
		public unsafe global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan StartReadWriteNonBlocking (string p0, long p1)
		{
			if (id_startReadWriteNonBlocking_Ljava_lang_String_J == IntPtr.Zero)
				id_startReadWriteNonBlocking_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "startReadWriteNonBlocking", "(Ljava/lang/String;J)Lcom/google/android/exoplayer/upstream/cache/CacheSpan;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_startReadWriteNonBlocking_Ljava_lang_String_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
