using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Upstream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='UriLoadable']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/upstream/UriLoadable", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class UriLoadable : global::Java.Lang.Object, global::Com.Google.Android.Exoplayer.Upstream.Loader.ILoadable {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/interface[@name='UriLoadable.Parser']"
		[Register ("com/google/android/exoplayer/upstream/UriLoadable$Parser", "", "Com.Google.Android.Exoplayer.Upstream.UriLoadable/IParserInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial interface IParser : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/interface[@name='UriLoadable.Parser']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.InputStream']]"
			[Register ("parse", "(Ljava/lang/String;Ljava/io/InputStream;)Ljava/lang/Object;", "GetParse_Ljava_lang_String_Ljava_io_InputStream_Handler:Com.Google.Android.Exoplayer.Upstream.UriLoadable/IParserInvoker, JWBinding_AND")]
			global::Java.Lang.Object Parse (string p0, global::System.IO.Stream p1);

		}

		[global::Android.Runtime.Register ("com/google/android/exoplayer/upstream/UriLoadable$Parser", DoNotGenerateAcw=true)]
		internal class IParserInvoker : global::Java.Lang.Object, IParser {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/upstream/UriLoadable$Parser");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IParserInvoker); }
			}

			IntPtr class_ref;

			public static IParser GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IParser> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.upstream.UriLoadable.Parser"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IParserInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_parse_Ljava_lang_String_Ljava_io_InputStream_;
#pragma warning disable 0169
			static Delegate GetParse_Ljava_lang_String_Ljava_io_InputStream_Handler ()
			{
				if (cb_parse_Ljava_lang_String_Ljava_io_InputStream_ == null)
					cb_parse_Ljava_lang_String_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Parse_Ljava_lang_String_Ljava_io_InputStream_);
				return cb_parse_Ljava_lang_String_Ljava_io_InputStream_;
			}

			static IntPtr n_Parse_Ljava_lang_String_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Google.Android.Exoplayer.Upstream.UriLoadable.IParser __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.UriLoadable.IParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				System.IO.Stream p1 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Parse (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_parse_Ljava_lang_String_Ljava_io_InputStream_;
			public unsafe global::Java.Lang.Object Parse (string p0, global::System.IO.Stream p1)
			{
				if (id_parse_Ljava_lang_String_Ljava_io_InputStream_ == IntPtr.Zero)
					id_parse_Ljava_lang_String_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "parse", "(Ljava/lang/String;Ljava/io/InputStream;)Ljava/lang/Object;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parse_Ljava_lang_String_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return __ret;
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/upstream/UriLoadable", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UriLoadable); }
		}

		internal UriLoadable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isLoadCanceled;
		public unsafe bool IsLoadCanceled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='UriLoadable']/method[@name='isLoadCanceled' and count(parameter)=0]"
			[Register ("isLoadCanceled", "()Z", "GetIsLoadCanceledHandler")]
			get {
				if (id_isLoadCanceled == IntPtr.Zero)
					id_isLoadCanceled = JNIEnv.GetMethodID (class_ref, "isLoadCanceled", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLoadCanceled);
				} finally {
				}
			}
		}

		static IntPtr id_getResult;
		public unsafe global::Java.Lang.Object Result {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='UriLoadable']/method[@name='getResult' and count(parameter)=0]"
			[Register ("getResult", "()Ljava/lang/Object;", "GetGetResultHandler")]
			get {
				if (id_getResult == IntPtr.Zero)
					id_getResult = JNIEnv.GetMethodID (class_ref, "getResult", "()Ljava/lang/Object;");
				try {
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResult), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_cancelLoad;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='UriLoadable']/method[@name='cancelLoad' and count(parameter)=0]"
		[Register ("cancelLoad", "()V", "")]
		public unsafe void CancelLoad ()
		{
			if (id_cancelLoad == IntPtr.Zero)
				id_cancelLoad = JNIEnv.GetMethodID (class_ref, "cancelLoad", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelLoad);
			} finally {
			}
		}

		static IntPtr id_load;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='UriLoadable']/method[@name='load' and count(parameter)=0]"
		[Register ("load", "()V", "")]
		public unsafe void Load ()
		{
			if (id_load == IntPtr.Zero)
				id_load = JNIEnv.GetMethodID (class_ref, "load", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_load);
			} finally {
			}
		}

	}
}
