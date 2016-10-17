using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Upstream.Cache {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='CacheSpan']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/upstream/cache/CacheSpan", DoNotGenerateAcw=true)]
	public sealed partial class CacheSpan : global::Java.Lang.Object, global::Java.Lang.IComparable {


		static IntPtr file_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='CacheSpan']/field[@name='file']"
		[Register ("file")]
		public global::Java.IO.File File {
			get {
				if (file_jfieldId == IntPtr.Zero)
					file_jfieldId = JNIEnv.GetFieldID (class_ref, "file", "Ljava/io/File;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, file_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (file_jfieldId == IntPtr.Zero)
					file_jfieldId = JNIEnv.GetFieldID (class_ref, "file", "Ljava/io/File;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, file_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr isCached_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='CacheSpan']/field[@name='isCached']"
		[Register ("isCached")]
		public bool IsCached {
			get {
				if (isCached_jfieldId == IntPtr.Zero)
					isCached_jfieldId = JNIEnv.GetFieldID (class_ref, "isCached", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, isCached_jfieldId);
			}
			set {
				if (isCached_jfieldId == IntPtr.Zero)
					isCached_jfieldId = JNIEnv.GetFieldID (class_ref, "isCached", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, isCached_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr key_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='CacheSpan']/field[@name='key']"
		[Register ("key")]
		public string Key {
			get {
				if (key_jfieldId == IntPtr.Zero)
					key_jfieldId = JNIEnv.GetFieldID (class_ref, "key", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, key_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (key_jfieldId == IntPtr.Zero)
					key_jfieldId = JNIEnv.GetFieldID (class_ref, "key", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, key_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr lastAccessTimestamp_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='CacheSpan']/field[@name='lastAccessTimestamp']"
		[Register ("lastAccessTimestamp")]
		public long LastAccessTimestamp {
			get {
				if (lastAccessTimestamp_jfieldId == IntPtr.Zero)
					lastAccessTimestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "lastAccessTimestamp", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, lastAccessTimestamp_jfieldId);
			}
			set {
				if (lastAccessTimestamp_jfieldId == IntPtr.Zero)
					lastAccessTimestamp_jfieldId = JNIEnv.GetFieldID (class_ref, "lastAccessTimestamp", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, lastAccessTimestamp_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr length_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='CacheSpan']/field[@name='length']"
		[Register ("length")]
		public long Length {
			get {
				if (length_jfieldId == IntPtr.Zero)
					length_jfieldId = JNIEnv.GetFieldID (class_ref, "length", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, length_jfieldId);
			}
			set {
				if (length_jfieldId == IntPtr.Zero)
					length_jfieldId = JNIEnv.GetFieldID (class_ref, "length", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, length_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr position_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='CacheSpan']/field[@name='position']"
		[Register ("position")]
		public long Position {
			get {
				if (position_jfieldId == IntPtr.Zero)
					position_jfieldId = JNIEnv.GetFieldID (class_ref, "position", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, position_jfieldId);
			}
			set {
				if (position_jfieldId == IntPtr.Zero)
					position_jfieldId = JNIEnv.GetFieldID (class_ref, "position", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, position_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/upstream/cache/CacheSpan", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CacheSpan); }
		}

		internal CacheSpan (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isOpenEnded;
		public unsafe bool IsOpenEnded {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='CacheSpan']/method[@name='isOpenEnded' and count(parameter)=0]"
			[Register ("isOpenEnded", "()Z", "GetIsOpenEndedHandler")]
			get {
				if (id_isOpenEnded == IntPtr.Zero)
					id_isOpenEnded = JNIEnv.GetMethodID (class_ref, "isOpenEnded", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOpenEnded);
				} finally {
				}
			}
		}

		static IntPtr id_compareTo_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='CacheSpan']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer.upstream.cache.CacheSpan']]"
		[Register ("compareTo", "(Lcom/google/android/exoplayer/upstream/cache/CacheSpan;)I", "")]
		public unsafe int CompareTo (global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan p0)
		{
			if (id_compareTo_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ == IntPtr.Zero)
				id_compareTo_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/google/android/exoplayer/upstream/cache/CacheSpan;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_compareTo_Lcom_google_android_exoplayer_upstream_cache_CacheSpan_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createCacheEntry_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='CacheSpan']/method[@name='createCacheEntry' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("createCacheEntry", "(Ljava/io/File;)Lcom/google/android/exoplayer/upstream/cache/CacheSpan;", "")]
		public static unsafe global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan CreateCacheEntry (global::Java.IO.File p0)
		{
			if (id_createCacheEntry_Ljava_io_File_ == IntPtr.Zero)
				id_createCacheEntry_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "createCacheEntry", "(Ljava/io/File;)Lcom/google/android/exoplayer/upstream/cache/CacheSpan;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createCacheEntry_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_createClosedHole_Ljava_lang_String_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='CacheSpan']/method[@name='createClosedHole' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("createClosedHole", "(Ljava/lang/String;JJ)Lcom/google/android/exoplayer/upstream/cache/CacheSpan;", "")]
		public static unsafe global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan CreateClosedHole (string p0, long p1, long p2)
		{
			if (id_createClosedHole_Ljava_lang_String_JJ == IntPtr.Zero)
				id_createClosedHole_Ljava_lang_String_JJ = JNIEnv.GetStaticMethodID (class_ref, "createClosedHole", "(Ljava/lang/String;JJ)Lcom/google/android/exoplayer/upstream/cache/CacheSpan;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createClosedHole_Ljava_lang_String_JJ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_createLookup_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='CacheSpan']/method[@name='createLookup' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("createLookup", "(Ljava/lang/String;J)Lcom/google/android/exoplayer/upstream/cache/CacheSpan;", "")]
		public static unsafe global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan CreateLookup (string p0, long p1)
		{
			if (id_createLookup_Ljava_lang_String_J == IntPtr.Zero)
				id_createLookup_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "createLookup", "(Ljava/lang/String;J)Lcom/google/android/exoplayer/upstream/cache/CacheSpan;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createLookup_Ljava_lang_String_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_createOpenHole_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='CacheSpan']/method[@name='createOpenHole' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("createOpenHole", "(Ljava/lang/String;J)Lcom/google/android/exoplayer/upstream/cache/CacheSpan;", "")]
		public static unsafe global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan CreateOpenHole (string p0, long p1)
		{
			if (id_createOpenHole_Ljava_lang_String_J == IntPtr.Zero)
				id_createOpenHole_Ljava_lang_String_J = JNIEnv.GetStaticMethodID (class_ref, "createOpenHole", "(Ljava/lang/String;J)Lcom/google/android/exoplayer/upstream/cache/CacheSpan;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createOpenHole_Ljava_lang_String_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getCacheFileName_Ljava_io_File_Ljava_lang_String_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='CacheSpan']/method[@name='getCacheFileName' and count(parameter)=4 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("getCacheFileName", "(Ljava/io/File;Ljava/lang/String;JJ)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File GetCacheFileName (global::Java.IO.File p0, string p1, long p2, long p3)
		{
			if (id_getCacheFileName_Ljava_io_File_Ljava_lang_String_JJ == IntPtr.Zero)
				id_getCacheFileName_Ljava_io_File_Ljava_lang_String_JJ = JNIEnv.GetStaticMethodID (class_ref, "getCacheFileName", "(Ljava/io/File;Ljava/lang/String;JJ)Ljava/io/File;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getCacheFileName_Ljava_io_File_Ljava_lang_String_JJ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_touch;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream.cache']/class[@name='CacheSpan']/method[@name='touch' and count(parameter)=0]"
		[Register ("touch", "()Lcom/google/android/exoplayer/upstream/cache/CacheSpan;", "")]
		public unsafe global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan Touch ()
		{
			if (id_touch == IntPtr.Zero)
				id_touch = JNIEnv.GetMethodID (class_ref, "touch", "()Lcom/google/android/exoplayer/upstream/cache/CacheSpan;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Cache.CacheSpan> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_touch), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
