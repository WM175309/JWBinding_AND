using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Util.Extensions {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/interface[@name='Decoder']"
	[Register ("com/google/android/exoplayer/util/extensions/Decoder", "", "Com.Google.Android.Exoplayer.Util.Extensions.IDecoderInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"I", "O", "E extends java.lang.Exception"})]
	public partial interface IDecoder : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/interface[@name='Decoder']/method[@name='dequeueInputBuffer' and count(parameter)=0]"
		[Register ("dequeueInputBuffer", "()Ljava/lang/Object;", "GetDequeueInputBufferHandler:Com.Google.Android.Exoplayer.Util.Extensions.IDecoderInvoker, JWBinding_AND")]
		global::Java.Lang.Object DequeueInputBuffer ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/interface[@name='Decoder']/method[@name='dequeueOutputBuffer' and count(parameter)=0]"
		[Register ("dequeueOutputBuffer", "()Ljava/lang/Object;", "GetDequeueOutputBufferHandler:Com.Google.Android.Exoplayer.Util.Extensions.IDecoderInvoker, JWBinding_AND")]
		global::Java.Lang.Object DequeueOutputBuffer ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/interface[@name='Decoder']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler:Com.Google.Android.Exoplayer.Util.Extensions.IDecoderInvoker, JWBinding_AND")]
		void Flush ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/interface[@name='Decoder']/method[@name='queueInputBuffer' and count(parameter)=1 and parameter[1][@type='I']]"
		[Register ("queueInputBuffer", "(Ljava/lang/Object;)V", "GetQueueInputBuffer_Ljava_lang_Object_Handler:Com.Google.Android.Exoplayer.Util.Extensions.IDecoderInvoker, JWBinding_AND")]
		void QueueInputBuffer (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/interface[@name='Decoder']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler:Com.Google.Android.Exoplayer.Util.Extensions.IDecoderInvoker, JWBinding_AND")]
		void Release ();

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/util/extensions/Decoder", DoNotGenerateAcw=true)]
	internal class IDecoderInvoker : global::Java.Lang.Object, IDecoder {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/util/extensions/Decoder");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDecoderInvoker); }
		}

		IntPtr class_ref;

		public static IDecoder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDecoder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.util.extensions.Decoder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDecoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_dequeueInputBuffer;
#pragma warning disable 0169
		static Delegate GetDequeueInputBufferHandler ()
		{
			if (cb_dequeueInputBuffer == null)
				cb_dequeueInputBuffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DequeueInputBuffer);
			return cb_dequeueInputBuffer;
		}

		static IntPtr n_DequeueInputBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Util.Extensions.IDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Util.Extensions.IDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DequeueInputBuffer ());
		}
#pragma warning restore 0169

		IntPtr id_dequeueInputBuffer;
		public unsafe global::Java.Lang.Object DequeueInputBuffer ()
		{
			if (id_dequeueInputBuffer == IntPtr.Zero)
				id_dequeueInputBuffer = JNIEnv.GetMethodID (class_ref, "dequeueInputBuffer", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dequeueInputBuffer), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_dequeueOutputBuffer;
#pragma warning disable 0169
		static Delegate GetDequeueOutputBufferHandler ()
		{
			if (cb_dequeueOutputBuffer == null)
				cb_dequeueOutputBuffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DequeueOutputBuffer);
			return cb_dequeueOutputBuffer;
		}

		static IntPtr n_DequeueOutputBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Util.Extensions.IDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Util.Extensions.IDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DequeueOutputBuffer ());
		}
#pragma warning restore 0169

		IntPtr id_dequeueOutputBuffer;
		public unsafe global::Java.Lang.Object DequeueOutputBuffer ()
		{
			if (id_dequeueOutputBuffer == IntPtr.Zero)
				id_dequeueOutputBuffer = JNIEnv.GetMethodID (class_ref, "dequeueOutputBuffer", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dequeueOutputBuffer), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Util.Extensions.IDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Util.Extensions.IDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		IntPtr id_flush;
		public unsafe void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_flush);
		}

		static Delegate cb_queueInputBuffer_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetQueueInputBuffer_Ljava_lang_Object_Handler ()
		{
			if (cb_queueInputBuffer_Ljava_lang_Object_ == null)
				cb_queueInputBuffer_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_QueueInputBuffer_Ljava_lang_Object_);
			return cb_queueInputBuffer_Ljava_lang_Object_;
		}

		static void n_QueueInputBuffer_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Exoplayer.Util.Extensions.IDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Util.Extensions.IDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.QueueInputBuffer (p0);
		}
#pragma warning restore 0169

		IntPtr id_queueInputBuffer_Ljava_lang_Object_;
		public unsafe void QueueInputBuffer (global::Java.Lang.Object p0)
		{
			if (id_queueInputBuffer_Ljava_lang_Object_ == IntPtr.Zero)
				id_queueInputBuffer_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "queueInputBuffer", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_queueInputBuffer_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Util.Extensions.IDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Util.Extensions.IDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		IntPtr id_release;
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
		}

	}

}
