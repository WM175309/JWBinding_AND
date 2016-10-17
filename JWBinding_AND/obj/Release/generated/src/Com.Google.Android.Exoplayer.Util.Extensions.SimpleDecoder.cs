using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Util.Extensions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='SimpleDecoder']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/util/extensions/SimpleDecoder", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"I extends com.google.android.exoplayer.util.extensions.InputBuffer", "O extends com.google.android.exoplayer.util.extensions.OutputBuffer", "E extends java.lang.Exception"})]
	public abstract partial class SimpleDecoder : global::Java.Lang.Thread, global::Com.Google.Android.Exoplayer.Util.Extensions.IDecoder {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/interface[@name='SimpleDecoder.EventListener']"
		[Register ("com/google/android/exoplayer/util/extensions/SimpleDecoder$EventListener", "", "Com.Google.Android.Exoplayer.Util.Extensions.SimpleDecoder/IEventListenerInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E"})]
		public partial interface IEventListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/interface[@name='SimpleDecoder.EventListener']/method[@name='onDecoderError' and count(parameter)=1 and parameter[1][@type='E']]"
			[Register ("onDecoderError", "(Ljava/lang/Object;)V", "GetOnDecoderError_Ljava_lang_Object_Handler:Com.Google.Android.Exoplayer.Util.Extensions.SimpleDecoder/IEventListenerInvoker, JWBinding_AND")]
			void OnDecoderError (global::Java.Lang.Object p0);

		}

		[global::Android.Runtime.Register ("com/google/android/exoplayer/util/extensions/SimpleDecoder$EventListener", DoNotGenerateAcw=true)]
		internal class IEventListenerInvoker : global::Java.Lang.Object, IEventListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/util/extensions/SimpleDecoder$EventListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IEventListenerInvoker); }
			}

			IntPtr class_ref;

			public static IEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IEventListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.util.extensions.SimpleDecoder.EventListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDecoderError_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnDecoderError_Ljava_lang_Object_Handler ()
			{
				if (cb_onDecoderError_Ljava_lang_Object_ == null)
					cb_onDecoderError_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDecoderError_Ljava_lang_Object_);
				return cb_onDecoderError_Ljava_lang_Object_;
			}

			static void n_OnDecoderError_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Android.Exoplayer.Util.Extensions.SimpleDecoder.IEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Util.Extensions.SimpleDecoder.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDecoderError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onDecoderError_Ljava_lang_Object_;
			public unsafe void OnDecoderError (global::Java.Lang.Object p0)
			{
				if (id_onDecoderError_Ljava_lang_Object_ == IntPtr.Zero)
					id_onDecoderError_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onDecoderError", "(Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDecoderError_Ljava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		public partial class EventEventArgs : global::System.EventArgs {

			public EventEventArgs (global::Java.Lang.Object p0)
			{
				this.p0 = p0;
			}

			global::Java.Lang.Object p0;
			public global::Java.Lang.Object P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/google/android/exoplayer/util/extensions/SimpleDecoder_EventListenerImplementor")]
		internal sealed partial class IEventListenerImplementor : global::Java.Lang.Object, IEventListener {

			object sender;

			public IEventListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/google/android/exoplayer/util/extensions/SimpleDecoder_EventListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<EventEventArgs> Handler;
#pragma warning restore 0649

			public void OnDecoderError (global::Java.Lang.Object p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventEventArgs (p0));
			}

			internal static bool __IsEmpty (IEventListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/util/extensions/SimpleDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleDecoder); }
		}

		protected SimpleDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayLcom_google_android_exoplayer_util_extensions_InputBuffer_arrayLcom_google_android_exoplayer_util_extensions_OutputBuffer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='SimpleDecoder']/constructor[@name='SimpleDecoder' and count(parameter)=2 and parameter[1][@type='I[]'] and parameter[2][@type='O[]']]"
		[Register (".ctor", "([Lcom/google/android/exoplayer/util/extensions/InputBuffer;[Lcom/google/android/exoplayer/util/extensions/OutputBuffer;)V", "")]
		protected unsafe SimpleDecoder (global::Java.Lang.Object[] p0, global::Java.Lang.Object[] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (SimpleDecoder)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([Lcom/google/android/exoplayer/util/extensions/InputBuffer;[Lcom/google/android/exoplayer/util/extensions/OutputBuffer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Lcom/google/android/exoplayer/util/extensions/InputBuffer;[Lcom/google/android/exoplayer/util/extensions/OutputBuffer;)V", __args);
					return;
				}

				if (id_ctor_arrayLcom_google_android_exoplayer_util_extensions_InputBuffer_arrayLcom_google_android_exoplayer_util_extensions_OutputBuffer_ == IntPtr.Zero)
					id_ctor_arrayLcom_google_android_exoplayer_util_extensions_InputBuffer_arrayLcom_google_android_exoplayer_util_extensions_OutputBuffer_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lcom/google/android/exoplayer/util/extensions/InputBuffer;[Lcom/google/android/exoplayer/util/extensions/OutputBuffer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLcom_google_android_exoplayer_util_extensions_InputBuffer_arrayLcom_google_android_exoplayer_util_extensions_OutputBuffer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLcom_google_android_exoplayer_util_extensions_InputBuffer_arrayLcom_google_android_exoplayer_util_extensions_OutputBuffer_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_createInputBuffer;
#pragma warning disable 0169
		static Delegate GetCreateInputBufferHandler ()
		{
			if (cb_createInputBuffer == null)
				cb_createInputBuffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateInputBuffer);
			return cb_createInputBuffer;
		}

		static IntPtr n_CreateInputBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Util.Extensions.SimpleDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Util.Extensions.SimpleDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateInputBuffer ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='SimpleDecoder']/method[@name='createInputBuffer' and count(parameter)=0]"
		[Register ("createInputBuffer", "()Lcom/google/android/exoplayer/util/extensions/InputBuffer;", "GetCreateInputBufferHandler")]
		protected abstract global::Java.Lang.Object CreateInputBuffer ();

		static Delegate cb_createOutputBuffer;
#pragma warning disable 0169
		static Delegate GetCreateOutputBufferHandler ()
		{
			if (cb_createOutputBuffer == null)
				cb_createOutputBuffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CreateOutputBuffer);
			return cb_createOutputBuffer;
		}

		static IntPtr n_CreateOutputBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Util.Extensions.SimpleDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Util.Extensions.SimpleDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateOutputBuffer ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='SimpleDecoder']/method[@name='createOutputBuffer' and count(parameter)=0]"
		[Register ("createOutputBuffer", "()Lcom/google/android/exoplayer/util/extensions/OutputBuffer;", "GetCreateOutputBufferHandler")]
		protected abstract global::Java.Lang.Object CreateOutputBuffer ();

		static Delegate cb_decode_Lcom_google_android_exoplayer_util_extensions_InputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_;
#pragma warning disable 0169
		static Delegate GetDecode_Lcom_google_android_exoplayer_util_extensions_InputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_Handler ()
		{
			if (cb_decode_Lcom_google_android_exoplayer_util_extensions_InputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_ == null)
				cb_decode_Lcom_google_android_exoplayer_util_extensions_InputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Decode_Lcom_google_android_exoplayer_util_extensions_InputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_);
			return cb_decode_Lcom_google_android_exoplayer_util_extensions_InputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_;
		}

		static IntPtr n_Decode_Lcom_google_android_exoplayer_util_extensions_InputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Exoplayer.Util.Extensions.SimpleDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Util.Extensions.SimpleDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Decode (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='SimpleDecoder']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='I'] and parameter[2][@type='O']]"
		[Register ("decode", "(Lcom/google/android/exoplayer/util/extensions/InputBuffer;Lcom/google/android/exoplayer/util/extensions/OutputBuffer;)Ljava/lang/Exception;", "GetDecode_Lcom_google_android_exoplayer_util_extensions_InputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_Handler")]
		protected abstract global::Java.Lang.Object Decode (global::Java.Lang.Object p0, global::Java.Lang.Object p1);

		static IntPtr id_dequeueInputBuffer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='SimpleDecoder']/method[@name='dequeueInputBuffer' and count(parameter)=0]"
		[Register ("dequeueInputBuffer", "()Lcom/google/android/exoplayer/util/extensions/InputBuffer;", "")]
		public unsafe global::Java.Lang.Object DequeueInputBuffer ()
		{
			if (id_dequeueInputBuffer == IntPtr.Zero)
				id_dequeueInputBuffer = JNIEnv.GetMethodID (class_ref, "dequeueInputBuffer", "()Lcom/google/android/exoplayer/util/extensions/InputBuffer;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dequeueInputBuffer), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_dequeueOutputBuffer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='SimpleDecoder']/method[@name='dequeueOutputBuffer' and count(parameter)=0]"
		[Register ("dequeueOutputBuffer", "()Lcom/google/android/exoplayer/util/extensions/OutputBuffer;", "")]
		public unsafe global::Java.Lang.Object DequeueOutputBuffer ()
		{
			if (id_dequeueOutputBuffer == IntPtr.Zero)
				id_dequeueOutputBuffer = JNIEnv.GetMethodID (class_ref, "dequeueOutputBuffer", "()Lcom/google/android/exoplayer/util/extensions/OutputBuffer;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_dequeueOutputBuffer), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_flush;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='SimpleDecoder']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "")]
		public unsafe void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_flush);
			} finally {
			}
		}

		static IntPtr id_queueInputBuffer_Lcom_google_android_exoplayer_util_extensions_InputBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='SimpleDecoder']/method[@name='queueInputBuffer' and count(parameter)=1 and parameter[1][@type='I']]"
		[Register ("queueInputBuffer", "(Lcom/google/android/exoplayer/util/extensions/InputBuffer;)V", "")]
		public unsafe void QueueInputBuffer (global::Java.Lang.Object p0)
		{
			if (id_queueInputBuffer_Lcom_google_android_exoplayer_util_extensions_InputBuffer_ == IntPtr.Zero)
				id_queueInputBuffer_Lcom_google_android_exoplayer_util_extensions_InputBuffer_ = JNIEnv.GetMethodID (class_ref, "queueInputBuffer", "(Lcom/google/android/exoplayer/util/extensions/InputBuffer;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_queueInputBuffer_Lcom_google_android_exoplayer_util_extensions_InputBuffer_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
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
			global::Com.Google.Android.Exoplayer.Util.Extensions.SimpleDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Util.Extensions.SimpleDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='SimpleDecoder']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "release", "()V"));
			} finally {
			}
		}

		static Delegate cb_releaseOutputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_;
#pragma warning disable 0169
		static Delegate GetReleaseOutputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_Handler ()
		{
			if (cb_releaseOutputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_ == null)
				cb_releaseOutputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReleaseOutputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_);
			return cb_releaseOutputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_;
		}

		static void n_ReleaseOutputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Exoplayer.Util.Extensions.SimpleDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Util.Extensions.SimpleDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseOutputBuffer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_releaseOutputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='SimpleDecoder']/method[@name='releaseOutputBuffer' and count(parameter)=1 and parameter[1][@type='O']]"
		[Register ("releaseOutputBuffer", "(Lcom/google/android/exoplayer/util/extensions/OutputBuffer;)V", "GetReleaseOutputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_Handler")]
		protected virtual unsafe void ReleaseOutputBuffer (global::Java.Lang.Object p0)
		{
			if (id_releaseOutputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_ == IntPtr.Zero)
				id_releaseOutputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_ = JNIEnv.GetMethodID (class_ref, "releaseOutputBuffer", "(Lcom/google/android/exoplayer/util/extensions/OutputBuffer;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_releaseOutputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "releaseOutputBuffer", "(Lcom/google/android/exoplayer/util/extensions/OutputBuffer;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='SimpleDecoder']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "")]
		public override sealed unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
			} finally {
			}
		}

		static IntPtr id_setInitialInputBufferSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='SimpleDecoder']/method[@name='setInitialInputBufferSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setInitialInputBufferSize", "(I)V", "")]
		protected unsafe void SetInitialInputBufferSize (int p0)
		{
			if (id_setInitialInputBufferSize_I == IntPtr.Zero)
				id_setInitialInputBufferSize_I = JNIEnv.GetMethodID (class_ref, "setInitialInputBufferSize", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInitialInputBufferSize_I, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/util/extensions/SimpleDecoder", DoNotGenerateAcw=true)]
	internal partial class SimpleDecoderInvoker : SimpleDecoder, global::Com.Google.Android.Exoplayer.Util.Extensions.IDecoder {

		public SimpleDecoderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleDecoderInvoker); }
		}

		static IntPtr id_createInputBuffer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='SimpleDecoder']/method[@name='createInputBuffer' and count(parameter)=0]"
		[Register ("createInputBuffer", "()Lcom/google/android/exoplayer/util/extensions/InputBuffer;", "GetCreateInputBufferHandler")]
		protected override unsafe global::Java.Lang.Object CreateInputBuffer ()
		{
			if (id_createInputBuffer == IntPtr.Zero)
				id_createInputBuffer = JNIEnv.GetMethodID (class_ref, "createInputBuffer", "()Lcom/google/android/exoplayer/util/extensions/InputBuffer;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createInputBuffer), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_createOutputBuffer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='SimpleDecoder']/method[@name='createOutputBuffer' and count(parameter)=0]"
		[Register ("createOutputBuffer", "()Lcom/google/android/exoplayer/util/extensions/OutputBuffer;", "GetCreateOutputBufferHandler")]
		protected override unsafe global::Java.Lang.Object CreateOutputBuffer ()
		{
			if (id_createOutputBuffer == IntPtr.Zero)
				id_createOutputBuffer = JNIEnv.GetMethodID (class_ref, "createOutputBuffer", "()Lcom/google/android/exoplayer/util/extensions/OutputBuffer;");
			try {
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createOutputBuffer), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_decode_Lcom_google_android_exoplayer_util_extensions_InputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='SimpleDecoder']/method[@name='decode' and count(parameter)=2 and parameter[1][@type='I'] and parameter[2][@type='O']]"
		[Register ("decode", "(Lcom/google/android/exoplayer/util/extensions/InputBuffer;Lcom/google/android/exoplayer/util/extensions/OutputBuffer;)Ljava/lang/Exception;", "GetDecode_Lcom_google_android_exoplayer_util_extensions_InputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_Handler")]
		protected override unsafe global::Java.Lang.Object Decode (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_decode_Lcom_google_android_exoplayer_util_extensions_InputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_ == IntPtr.Zero)
				id_decode_Lcom_google_android_exoplayer_util_extensions_InputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_ = JNIEnv.GetMethodID (class_ref, "decode", "(Lcom/google/android/exoplayer/util/extensions/InputBuffer;Lcom/google/android/exoplayer/util/extensions/OutputBuffer;)Ljava/lang/Exception;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decode_Lcom_google_android_exoplayer_util_extensions_InputBuffer_Lcom_google_android_exoplayer_util_extensions_OutputBuffer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

}
