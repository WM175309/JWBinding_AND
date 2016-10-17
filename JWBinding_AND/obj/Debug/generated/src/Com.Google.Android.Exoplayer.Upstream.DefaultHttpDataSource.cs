using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Upstream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultHttpDataSource']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/upstream/DefaultHttpDataSource", DoNotGenerateAcw=true)]
	public partial class DefaultHttpDataSource : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultHttpDataSource']/field[@name='DEFAULT_CONNECT_TIMEOUT_MILLIS']"
		[Register ("DEFAULT_CONNECT_TIMEOUT_MILLIS")]
		public const int DefaultConnectTimeoutMillis = (int) 8000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultHttpDataSource']/field[@name='DEFAULT_READ_TIMEOUT_MILLIS']"
		[Register ("DEFAULT_READ_TIMEOUT_MILLIS")]
		public const int DefaultReadTimeoutMillis = (int) 8000;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/upstream/DefaultHttpDataSource", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultHttpDataSource); }
		}

		protected DefaultHttpDataSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_util_Predicate_Lcom_google_android_exoplayer_upstream_TransferListener_IIZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultHttpDataSource']/constructor[@name='DefaultHttpDataSource' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.android.exoplayer.util.Predicate&lt;java.lang.String&gt;'] and parameter[3][@type='com.google.android.exoplayer.upstream.TransferListener'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/google/android/exoplayer/util/Predicate;Lcom/google/android/exoplayer/upstream/TransferListener;IIZ)V", "")]
		public unsafe DefaultHttpDataSource (string p0, global::Com.Google.Android.Exoplayer.Util.IPredicate p1, global::Com.Google.Android.Exoplayer.Upstream.ITransferListener p2, int p3, int p4, bool p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);
				if (GetType () != typeof (DefaultHttpDataSource)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/google/android/exoplayer/util/Predicate;Lcom/google/android/exoplayer/upstream/TransferListener;IIZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/google/android/exoplayer/util/Predicate;Lcom/google/android/exoplayer/upstream/TransferListener;IIZ)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_util_Predicate_Lcom_google_android_exoplayer_upstream_TransferListener_IIZ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_util_Predicate_Lcom_google_android_exoplayer_upstream_TransferListener_IIZ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/google/android/exoplayer/util/Predicate;Lcom/google/android/exoplayer/upstream/TransferListener;IIZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_util_Predicate_Lcom_google_android_exoplayer_upstream_TransferListener_IIZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_util_Predicate_Lcom_google_android_exoplayer_upstream_TransferListener_IIZ, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_util_Predicate_Lcom_google_android_exoplayer_upstream_TransferListener_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultHttpDataSource']/constructor[@name='DefaultHttpDataSource' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.android.exoplayer.util.Predicate&lt;java.lang.String&gt;'] and parameter[3][@type='com.google.android.exoplayer.upstream.TransferListener'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/google/android/exoplayer/util/Predicate;Lcom/google/android/exoplayer/upstream/TransferListener;II)V", "")]
		public unsafe DefaultHttpDataSource (string p0, global::Com.Google.Android.Exoplayer.Util.IPredicate p1, global::Com.Google.Android.Exoplayer.Upstream.ITransferListener p2, int p3, int p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (DefaultHttpDataSource)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/google/android/exoplayer/util/Predicate;Lcom/google/android/exoplayer/upstream/TransferListener;II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/google/android/exoplayer/util/Predicate;Lcom/google/android/exoplayer/upstream/TransferListener;II)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_util_Predicate_Lcom_google_android_exoplayer_upstream_TransferListener_II == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_util_Predicate_Lcom_google_android_exoplayer_upstream_TransferListener_II = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/google/android/exoplayer/util/Predicate;Lcom/google/android/exoplayer/upstream/TransferListener;II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_util_Predicate_Lcom_google_android_exoplayer_upstream_TransferListener_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_util_Predicate_Lcom_google_android_exoplayer_upstream_TransferListener_II, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_util_Predicate_Lcom_google_android_exoplayer_upstream_TransferListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultHttpDataSource']/constructor[@name='DefaultHttpDataSource' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.android.exoplayer.util.Predicate&lt;java.lang.String&gt;'] and parameter[3][@type='com.google.android.exoplayer.upstream.TransferListener']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/google/android/exoplayer/util/Predicate;Lcom/google/android/exoplayer/upstream/TransferListener;)V", "")]
		public unsafe DefaultHttpDataSource (string p0, global::Com.Google.Android.Exoplayer.Util.IPredicate p1, global::Com.Google.Android.Exoplayer.Upstream.ITransferListener p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (DefaultHttpDataSource)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/google/android/exoplayer/util/Predicate;Lcom/google/android/exoplayer/upstream/TransferListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/google/android/exoplayer/util/Predicate;Lcom/google/android/exoplayer/upstream/TransferListener;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_util_Predicate_Lcom_google_android_exoplayer_upstream_TransferListener_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_util_Predicate_Lcom_google_android_exoplayer_upstream_TransferListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/google/android/exoplayer/util/Predicate;Lcom/google/android/exoplayer/upstream/TransferListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_util_Predicate_Lcom_google_android_exoplayer_upstream_TransferListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_util_Predicate_Lcom_google_android_exoplayer_upstream_TransferListener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_util_Predicate_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultHttpDataSource']/constructor[@name='DefaultHttpDataSource' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.android.exoplayer.util.Predicate&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/google/android/exoplayer/util/Predicate;)V", "")]
		public unsafe DefaultHttpDataSource (string p0, global::Com.Google.Android.Exoplayer.Util.IPredicate p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (DefaultHttpDataSource)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/google/android/exoplayer/util/Predicate;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/google/android/exoplayer/util/Predicate;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_util_Predicate_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_util_Predicate_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/google/android/exoplayer/util/Predicate;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_util_Predicate_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_google_android_exoplayer_util_Predicate_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getConnection;
		protected unsafe global::Java.Net.HttpURLConnection Connection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultHttpDataSource']/method[@name='getConnection' and count(parameter)=0]"
			[Register ("getConnection", "()Ljava/net/HttpURLConnection;", "GetGetConnectionHandler")]
			get {
				if (id_getConnection == IntPtr.Zero)
					id_getConnection = JNIEnv.GetMethodID (class_ref, "getConnection", "()Ljava/net/HttpURLConnection;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnection), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResponseHeaders;
#pragma warning disable 0169
		static Delegate GetGetResponseHeadersHandler ()
		{
			if (cb_getResponseHeaders == null)
				cb_getResponseHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponseHeaders);
			return cb_getResponseHeaders;
		}

		static IntPtr n_GetResponseHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Upstream.DefaultHttpDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.DefaultHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.ToLocalJniHandle (__this.ResponseHeaders);
		}
#pragma warning restore 0169

		static IntPtr id_getResponseHeaders;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::System.Collections.Generic.IList<string>> ResponseHeaders {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultHttpDataSource']/method[@name='getResponseHeaders' and count(parameter)=0]"
			[Register ("getResponseHeaders", "()Ljava/util/Map;", "GetGetResponseHeadersHandler")]
			get {
				if (id_getResponseHeaders == IntPtr.Zero)
					id_getResponseHeaders = JNIEnv.GetMethodID (class_ref, "getResponseHeaders", "()Ljava/util/Map;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponseHeaders), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::System.Collections.Generic.IList<string>>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponseHeaders", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUri;
#pragma warning disable 0169
		static Delegate GetGetUriHandler ()
		{
			if (cb_getUri == null)
				cb_getUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUri);
			return cb_getUri;
		}

		static IntPtr n_GetUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Upstream.DefaultHttpDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.DefaultHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Uri);
		}
#pragma warning restore 0169

		static IntPtr id_getUri;
		public virtual unsafe string Uri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultHttpDataSource']/method[@name='getUri' and count(parameter)=0]"
			[Register ("getUri", "()Ljava/lang/String;", "GetGetUriHandler")]
			get {
				if (id_getUri == IntPtr.Zero)
					id_getUri = JNIEnv.GetMethodID (class_ref, "getUri", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUri), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUri", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_bytesRead;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultHttpDataSource']/method[@name='bytesRead' and count(parameter)=0]"
		[Register ("bytesRead", "()J", "")]
		protected unsafe long BytesRead ()
		{
			if (id_bytesRead == IntPtr.Zero)
				id_bytesRead = JNIEnv.GetMethodID (class_ref, "bytesRead", "()J");
			try {
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_bytesRead);
			} finally {
			}
		}

		static IntPtr id_bytesRemaining;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultHttpDataSource']/method[@name='bytesRemaining' and count(parameter)=0]"
		[Register ("bytesRemaining", "()J", "")]
		protected unsafe long BytesRemaining ()
		{
			if (id_bytesRemaining == IntPtr.Zero)
				id_bytesRemaining = JNIEnv.GetMethodID (class_ref, "bytesRemaining", "()J");
			try {
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_bytesRemaining);
			} finally {
			}
		}

		static IntPtr id_bytesSkipped;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultHttpDataSource']/method[@name='bytesSkipped' and count(parameter)=0]"
		[Register ("bytesSkipped", "()J", "")]
		protected unsafe long BytesSkipped ()
		{
			if (id_bytesSkipped == IntPtr.Zero)
				id_bytesSkipped = JNIEnv.GetMethodID (class_ref, "bytesSkipped", "()J");
			try {
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_bytesSkipped);
			} finally {
			}
		}

		static Delegate cb_clearAllRequestProperties;
#pragma warning disable 0169
		static Delegate GetClearAllRequestPropertiesHandler ()
		{
			if (cb_clearAllRequestProperties == null)
				cb_clearAllRequestProperties = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearAllRequestProperties);
			return cb_clearAllRequestProperties;
		}

		static void n_ClearAllRequestProperties (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Upstream.DefaultHttpDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.DefaultHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAllRequestProperties ();
		}
#pragma warning restore 0169

		static IntPtr id_clearAllRequestProperties;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultHttpDataSource']/method[@name='clearAllRequestProperties' and count(parameter)=0]"
		[Register ("clearAllRequestProperties", "()V", "GetClearAllRequestPropertiesHandler")]
		public virtual unsafe void ClearAllRequestProperties ()
		{
			if (id_clearAllRequestProperties == IntPtr.Zero)
				id_clearAllRequestProperties = JNIEnv.GetMethodID (class_ref, "clearAllRequestProperties", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearAllRequestProperties);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearAllRequestProperties", "()V"));
			} finally {
			}
		}

		static Delegate cb_clearRequestProperty_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetClearRequestProperty_Ljava_lang_String_Handler ()
		{
			if (cb_clearRequestProperty_Ljava_lang_String_ == null)
				cb_clearRequestProperty_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ClearRequestProperty_Ljava_lang_String_);
			return cb_clearRequestProperty_Ljava_lang_String_;
		}

		static void n_ClearRequestProperty_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Exoplayer.Upstream.DefaultHttpDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.DefaultHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClearRequestProperty (p0);
		}
#pragma warning restore 0169

		static IntPtr id_clearRequestProperty_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultHttpDataSource']/method[@name='clearRequestProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("clearRequestProperty", "(Ljava/lang/String;)V", "GetClearRequestProperty_Ljava_lang_String_Handler")]
		public virtual unsafe void ClearRequestProperty (string p0)
		{
			if (id_clearRequestProperty_Ljava_lang_String_ == IntPtr.Zero)
				id_clearRequestProperty_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "clearRequestProperty", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearRequestProperty_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearRequestProperty", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Upstream.DefaultHttpDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.DefaultHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultHttpDataSource']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_read_arrayBII;
#pragma warning disable 0169
		static Delegate GetRead_arrayBIIHandler ()
		{
			if (cb_read_arrayBII == null)
				cb_read_arrayBII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int>) n_Read_arrayBII);
			return cb_read_arrayBII;
		}

		static int n_Read_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Google.Android.Exoplayer.Upstream.DefaultHttpDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.DefaultHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_read_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultHttpDataSource']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("read", "([BII)I", "GetRead_arrayBIIHandler")]
		public virtual unsafe int Read (byte[] p0, int p1, int p2)
		{
			if (id_read_arrayBII == IntPtr.Zero)
				id_read_arrayBII = JNIEnv.GetMethodID (class_ref, "read", "([BII)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_arrayBII, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "([BII)I"), __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRequestProperty_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRequestProperty_Ljava_lang_String_Ljava_lang_String_);
			return cb_setRequestProperty_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetRequestProperty_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Exoplayer.Upstream.DefaultHttpDataSource __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.DefaultHttpDataSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetRequestProperty (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setRequestProperty_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultHttpDataSource']/method[@name='setRequestProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetRequestProperty_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetRequestProperty (string p0, string p1)
		{
			if (id_setRequestProperty_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setRequestProperty_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRequestProperty_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequestProperty", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
