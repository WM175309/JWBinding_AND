using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Hls {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsPlaylistParser']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/hls/HlsPlaylistParser", DoNotGenerateAcw=true)]
	public sealed partial class HlsPlaylistParser : global::Java.Lang.Object, global::Com.Google.Android.Exoplayer.Upstream.UriLoadable.IParser {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsPlaylistParser.LineIterator']"
		[global::Android.Runtime.Register ("com/google/android/exoplayer/hls/HlsPlaylistParser$LineIterator", DoNotGenerateAcw=true)]
		public partial class LineIterator : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/exoplayer/hls/HlsPlaylistParser$LineIterator", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (LineIterator); }
			}

			protected LineIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_util_Queue_Ljava_io_BufferedReader_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsPlaylistParser.LineIterator']/constructor[@name='HlsPlaylistParser.LineIterator' and count(parameter)=2 and parameter[1][@type='java.util.Queue&lt;java.lang.String&gt;'] and parameter[2][@type='java.io.BufferedReader']]"
			[Register (".ctor", "(Ljava/util/Queue;Ljava/io/BufferedReader;)V", "")]
			public unsafe LineIterator (global::Java.Util.IQueue p0, global::Java.IO.BufferedReader p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (LineIterator)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/Queue;Ljava/io/BufferedReader;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/Queue;Ljava/io/BufferedReader;)V", __args);
						return;
					}

					if (id_ctor_Ljava_util_Queue_Ljava_io_BufferedReader_ == IntPtr.Zero)
						id_ctor_Ljava_util_Queue_Ljava_io_BufferedReader_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Queue;Ljava/io/BufferedReader;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Queue_Ljava_io_BufferedReader_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_Queue_Ljava_io_BufferedReader_, __args);
				} finally {
				}
			}

			static Delegate cb_hasNext;
#pragma warning disable 0169
			static Delegate GetHasNextHandler ()
			{
				if (cb_hasNext == null)
					cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNext);
				return cb_hasNext;
			}

			static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Exoplayer.Hls.HlsPlaylistParser.LineIterator __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Hls.HlsPlaylistParser.LineIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.HasNext;
			}
#pragma warning restore 0169

			static IntPtr id_hasNext;
			public virtual unsafe bool HasNext {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsPlaylistParser.LineIterator']/method[@name='hasNext' and count(parameter)=0]"
				[Register ("hasNext", "()Z", "GetHasNextHandler")]
				get {
					if (id_hasNext == IntPtr.Zero)
						id_hasNext = JNIEnv.GetMethodID (class_ref, "hasNext", "()Z");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasNext);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasNext", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_next;
#pragma warning disable 0169
			static Delegate GetNextHandler ()
			{
				if (cb_next == null)
					cb_next = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Next);
				return cb_next;
			}

			static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Exoplayer.Hls.HlsPlaylistParser.LineIterator __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Hls.HlsPlaylistParser.LineIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Next ());
			}
#pragma warning restore 0169

			static IntPtr id_next;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsPlaylistParser.LineIterator']/method[@name='next' and count(parameter)=0]"
			[Register ("next", "()Ljava/lang/String;", "GetNextHandler")]
			public virtual unsafe string Next ()
			{
				if (id_next == IntPtr.Zero)
					id_next = JNIEnv.GetMethodID (class_ref, "next", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_next), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "next", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/hls/HlsPlaylistParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HlsPlaylistParser); }
		}

		internal HlsPlaylistParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsPlaylistParser']/constructor[@name='HlsPlaylistParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HlsPlaylistParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HlsPlaylistParser)) {
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

		static IntPtr id_parse_Ljava_lang_String_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsPlaylistParser']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.InputStream']]"
		[Register ("parse", "(Ljava/lang/String;Ljava/io/InputStream;)Lcom/google/android/exoplayer/hls/HlsPlaylist;", "")]
		public unsafe global::Com.Google.Android.Exoplayer.Hls.HlsPlaylist Parse (string p0, global::System.IO.Stream p1)
		{
			if (id_parse_Ljava_lang_String_Ljava_io_InputStream_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "parse", "(Ljava/lang/String;Ljava/io/InputStream;)Lcom/google/android/exoplayer/hls/HlsPlaylist;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Com.Google.Android.Exoplayer.Hls.HlsPlaylist __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Hls.HlsPlaylist> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parse_Ljava_lang_String_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// This method is explicitly implemented as a member of an instantiated Com.Google.Android.Exoplayer.Upstream.UriLoadable.IParser
		global::Java.Lang.Object global::Com.Google.Android.Exoplayer.Upstream.UriLoadable.IParser.Parse (string p0, global::System.IO.Stream p1)
		{
			return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(Parse (p0, p1));
		}

	}
}
