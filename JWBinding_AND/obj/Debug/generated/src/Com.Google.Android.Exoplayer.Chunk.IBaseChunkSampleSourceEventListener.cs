using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Chunk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/interface[@name='BaseChunkSampleSourceEventListener']"
	[Register ("com/google/android/exoplayer/chunk/BaseChunkSampleSourceEventListener", "", "Com.Google.Android.Exoplayer.Chunk.IBaseChunkSampleSourceEventListenerInvoker")]
	public partial interface IBaseChunkSampleSourceEventListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/interface[@name='BaseChunkSampleSourceEventListener']/method[@name='onDownstreamFormatChanged' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='com.google.android.exoplayer.chunk.Format'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("onDownstreamFormatChanged", "(ILcom/google/android/exoplayer/chunk/Format;IJ)V", "GetOnDownstreamFormatChanged_ILcom_google_android_exoplayer_chunk_Format_IJHandler:Com.Google.Android.Exoplayer.Chunk.IBaseChunkSampleSourceEventListenerInvoker, JWBinding_AND")]
		void OnDownstreamFormatChanged (int p0, global::Com.Google.Android.Exoplayer.Chunk.Format p1, int p2, long p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/interface[@name='BaseChunkSampleSourceEventListener']/method[@name='onLoadCanceled' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("onLoadCanceled", "(IJ)V", "GetOnLoadCanceled_IJHandler:Com.Google.Android.Exoplayer.Chunk.IBaseChunkSampleSourceEventListenerInvoker, JWBinding_AND")]
		void OnLoadCanceled (int p0, long p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/interface[@name='BaseChunkSampleSourceEventListener']/method[@name='onLoadCompleted' and count(parameter)=9 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.google.android.exoplayer.chunk.Format'] and parameter[6][@type='long'] and parameter[7][@type='long'] and parameter[8][@type='long'] and parameter[9][@type='long']]"
		[Register ("onLoadCompleted", "(IJIILcom/google/android/exoplayer/chunk/Format;JJJJ)V", "GetOnLoadCompleted_IJIILcom_google_android_exoplayer_chunk_Format_JJJJHandler:Com.Google.Android.Exoplayer.Chunk.IBaseChunkSampleSourceEventListenerInvoker, JWBinding_AND")]
		void OnLoadCompleted (int p0, long p1, int p2, int p3, global::Com.Google.Android.Exoplayer.Chunk.Format p4, long p5, long p6, long p7, long p8);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/interface[@name='BaseChunkSampleSourceEventListener']/method[@name='onLoadError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.io.IOException']]"
		[Register ("onLoadError", "(ILjava/io/IOException;)V", "GetOnLoadError_ILjava_io_IOException_Handler:Com.Google.Android.Exoplayer.Chunk.IBaseChunkSampleSourceEventListenerInvoker, JWBinding_AND")]
		void OnLoadError (int p0, global::Java.IO.IOException p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/interface[@name='BaseChunkSampleSourceEventListener']/method[@name='onLoadStarted' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.google.android.exoplayer.chunk.Format'] and parameter[6][@type='long'] and parameter[7][@type='long']]"
		[Register ("onLoadStarted", "(IJIILcom/google/android/exoplayer/chunk/Format;JJ)V", "GetOnLoadStarted_IJIILcom_google_android_exoplayer_chunk_Format_JJHandler:Com.Google.Android.Exoplayer.Chunk.IBaseChunkSampleSourceEventListenerInvoker, JWBinding_AND")]
		void OnLoadStarted (int p0, long p1, int p2, int p3, global::Com.Google.Android.Exoplayer.Chunk.Format p4, long p5, long p6);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/interface[@name='BaseChunkSampleSourceEventListener']/method[@name='onUpstreamDiscarded' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("onUpstreamDiscarded", "(IJJ)V", "GetOnUpstreamDiscarded_IJJHandler:Com.Google.Android.Exoplayer.Chunk.IBaseChunkSampleSourceEventListenerInvoker, JWBinding_AND")]
		void OnUpstreamDiscarded (int p0, long p1, long p2);

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/chunk/BaseChunkSampleSourceEventListener", DoNotGenerateAcw=true)]
	internal class IBaseChunkSampleSourceEventListenerInvoker : global::Java.Lang.Object, IBaseChunkSampleSourceEventListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/chunk/BaseChunkSampleSourceEventListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBaseChunkSampleSourceEventListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBaseChunkSampleSourceEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBaseChunkSampleSourceEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.chunk.BaseChunkSampleSourceEventListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBaseChunkSampleSourceEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDownstreamFormatChanged_ILcom_google_android_exoplayer_chunk_Format_IJ;
#pragma warning disable 0169
		static Delegate GetOnDownstreamFormatChanged_ILcom_google_android_exoplayer_chunk_Format_IJHandler ()
		{
			if (cb_onDownstreamFormatChanged_ILcom_google_android_exoplayer_chunk_Format_IJ == null)
				cb_onDownstreamFormatChanged_ILcom_google_android_exoplayer_chunk_Format_IJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, int, long>) n_OnDownstreamFormatChanged_ILcom_google_android_exoplayer_chunk_Format_IJ);
			return cb_onDownstreamFormatChanged_ILcom_google_android_exoplayer_chunk_Format_IJ;
		}

		static void n_OnDownstreamFormatChanged_ILcom_google_android_exoplayer_chunk_Format_IJ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, int p2, long p3)
		{
			global::Com.Google.Android.Exoplayer.Chunk.IBaseChunkSampleSourceEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Chunk.IBaseChunkSampleSourceEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Chunk.Format p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Chunk.Format> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnDownstreamFormatChanged (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onDownstreamFormatChanged_ILcom_google_android_exoplayer_chunk_Format_IJ;
		public unsafe void OnDownstreamFormatChanged (int p0, global::Com.Google.Android.Exoplayer.Chunk.Format p1, int p2, long p3)
		{
			if (id_onDownstreamFormatChanged_ILcom_google_android_exoplayer_chunk_Format_IJ == IntPtr.Zero)
				id_onDownstreamFormatChanged_ILcom_google_android_exoplayer_chunk_Format_IJ = JNIEnv.GetMethodID (class_ref, "onDownstreamFormatChanged", "(ILcom/google/android/exoplayer/chunk/Format;IJ)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDownstreamFormatChanged_ILcom_google_android_exoplayer_chunk_Format_IJ, __args);
		}

		static Delegate cb_onLoadCanceled_IJ;
#pragma warning disable 0169
		static Delegate GetOnLoadCanceled_IJHandler ()
		{
			if (cb_onLoadCanceled_IJ == null)
				cb_onLoadCanceled_IJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, long>) n_OnLoadCanceled_IJ);
			return cb_onLoadCanceled_IJ;
		}

		static void n_OnLoadCanceled_IJ (IntPtr jnienv, IntPtr native__this, int p0, long p1)
		{
			global::Com.Google.Android.Exoplayer.Chunk.IBaseChunkSampleSourceEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Chunk.IBaseChunkSampleSourceEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadCanceled (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onLoadCanceled_IJ;
		public unsafe void OnLoadCanceled (int p0, long p1)
		{
			if (id_onLoadCanceled_IJ == IntPtr.Zero)
				id_onLoadCanceled_IJ = JNIEnv.GetMethodID (class_ref, "onLoadCanceled", "(IJ)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoadCanceled_IJ, __args);
		}

		static Delegate cb_onLoadCompleted_IJIILcom_google_android_exoplayer_chunk_Format_JJJJ;
#pragma warning disable 0169
		static Delegate GetOnLoadCompleted_IJIILcom_google_android_exoplayer_chunk_Format_JJJJHandler ()
		{
			if (cb_onLoadCompleted_IJIILcom_google_android_exoplayer_chunk_Format_JJJJ == null)
				cb_onLoadCompleted_IJIILcom_google_android_exoplayer_chunk_Format_JJJJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, long, int, int, IntPtr, long, long, long, long>) n_OnLoadCompleted_IJIILcom_google_android_exoplayer_chunk_Format_JJJJ);
			return cb_onLoadCompleted_IJIILcom_google_android_exoplayer_chunk_Format_JJJJ;
		}

		static void n_OnLoadCompleted_IJIILcom_google_android_exoplayer_chunk_Format_JJJJ (IntPtr jnienv, IntPtr native__this, int p0, long p1, int p2, int p3, IntPtr native_p4, long p5, long p6, long p7, long p8)
		{
			global::Com.Google.Android.Exoplayer.Chunk.IBaseChunkSampleSourceEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Chunk.IBaseChunkSampleSourceEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Chunk.Format p4 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Chunk.Format> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadCompleted (p0, p1, p2, p3, p4, p5, p6, p7, p8);
		}
#pragma warning restore 0169

		IntPtr id_onLoadCompleted_IJIILcom_google_android_exoplayer_chunk_Format_JJJJ;
		public unsafe void OnLoadCompleted (int p0, long p1, int p2, int p3, global::Com.Google.Android.Exoplayer.Chunk.Format p4, long p5, long p6, long p7, long p8)
		{
			if (id_onLoadCompleted_IJIILcom_google_android_exoplayer_chunk_Format_JJJJ == IntPtr.Zero)
				id_onLoadCompleted_IJIILcom_google_android_exoplayer_chunk_Format_JJJJ = JNIEnv.GetMethodID (class_ref, "onLoadCompleted", "(IJIILcom/google/android/exoplayer/chunk/Format;JJJJ)V");
			JValue* __args = stackalloc JValue [9];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (p5);
			__args [6] = new JValue (p6);
			__args [7] = new JValue (p7);
			__args [8] = new JValue (p8);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoadCompleted_IJIILcom_google_android_exoplayer_chunk_Format_JJJJ, __args);
		}

		static Delegate cb_onLoadError_ILjava_io_IOException_;
#pragma warning disable 0169
		static Delegate GetOnLoadError_ILjava_io_IOException_Handler ()
		{
			if (cb_onLoadError_ILjava_io_IOException_ == null)
				cb_onLoadError_ILjava_io_IOException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnLoadError_ILjava_io_IOException_);
			return cb_onLoadError_ILjava_io_IOException_;
		}

		static void n_OnLoadError_ILjava_io_IOException_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Exoplayer.Chunk.IBaseChunkSampleSourceEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Chunk.IBaseChunkSampleSourceEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.IOException p1 = global::Java.Lang.Object.GetObject<global::Java.IO.IOException> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onLoadError_ILjava_io_IOException_;
		public unsafe void OnLoadError (int p0, global::Java.IO.IOException p1)
		{
			if (id_onLoadError_ILjava_io_IOException_ == IntPtr.Zero)
				id_onLoadError_ILjava_io_IOException_ = JNIEnv.GetMethodID (class_ref, "onLoadError", "(ILjava/io/IOException;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoadError_ILjava_io_IOException_, __args);
		}

		static Delegate cb_onLoadStarted_IJIILcom_google_android_exoplayer_chunk_Format_JJ;
#pragma warning disable 0169
		static Delegate GetOnLoadStarted_IJIILcom_google_android_exoplayer_chunk_Format_JJHandler ()
		{
			if (cb_onLoadStarted_IJIILcom_google_android_exoplayer_chunk_Format_JJ == null)
				cb_onLoadStarted_IJIILcom_google_android_exoplayer_chunk_Format_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, long, int, int, IntPtr, long, long>) n_OnLoadStarted_IJIILcom_google_android_exoplayer_chunk_Format_JJ);
			return cb_onLoadStarted_IJIILcom_google_android_exoplayer_chunk_Format_JJ;
		}

		static void n_OnLoadStarted_IJIILcom_google_android_exoplayer_chunk_Format_JJ (IntPtr jnienv, IntPtr native__this, int p0, long p1, int p2, int p3, IntPtr native_p4, long p5, long p6)
		{
			global::Com.Google.Android.Exoplayer.Chunk.IBaseChunkSampleSourceEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Chunk.IBaseChunkSampleSourceEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Chunk.Format p4 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Chunk.Format> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.OnLoadStarted (p0, p1, p2, p3, p4, p5, p6);
		}
#pragma warning restore 0169

		IntPtr id_onLoadStarted_IJIILcom_google_android_exoplayer_chunk_Format_JJ;
		public unsafe void OnLoadStarted (int p0, long p1, int p2, int p3, global::Com.Google.Android.Exoplayer.Chunk.Format p4, long p5, long p6)
		{
			if (id_onLoadStarted_IJIILcom_google_android_exoplayer_chunk_Format_JJ == IntPtr.Zero)
				id_onLoadStarted_IJIILcom_google_android_exoplayer_chunk_Format_JJ = JNIEnv.GetMethodID (class_ref, "onLoadStarted", "(IJIILcom/google/android/exoplayer/chunk/Format;JJ)V");
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (p5);
			__args [6] = new JValue (p6);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLoadStarted_IJIILcom_google_android_exoplayer_chunk_Format_JJ, __args);
		}

		static Delegate cb_onUpstreamDiscarded_IJJ;
#pragma warning disable 0169
		static Delegate GetOnUpstreamDiscarded_IJJHandler ()
		{
			if (cb_onUpstreamDiscarded_IJJ == null)
				cb_onUpstreamDiscarded_IJJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, long, long>) n_OnUpstreamDiscarded_IJJ);
			return cb_onUpstreamDiscarded_IJJ;
		}

		static void n_OnUpstreamDiscarded_IJJ (IntPtr jnienv, IntPtr native__this, int p0, long p1, long p2)
		{
			global::Com.Google.Android.Exoplayer.Chunk.IBaseChunkSampleSourceEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Chunk.IBaseChunkSampleSourceEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUpstreamDiscarded (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onUpstreamDiscarded_IJJ;
		public unsafe void OnUpstreamDiscarded (int p0, long p1, long p2)
		{
			if (id_onUpstreamDiscarded_IJJ == IntPtr.Zero)
				id_onUpstreamDiscarded_IJJ = JNIEnv.GetMethodID (class_ref, "onUpstreamDiscarded", "(IJJ)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpstreamDiscarded_IJJ, __args);
		}

	}

	public partial class DownstreamFormatChangedEventArgs : global::System.EventArgs {

		public DownstreamFormatChangedEventArgs (int p0, global::Com.Google.Android.Exoplayer.Chunk.Format p1, int p2, long p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		global::Com.Google.Android.Exoplayer.Chunk.Format p1;
		public global::Com.Google.Android.Exoplayer.Chunk.Format P1 {
			get { return p1; }
		}

		int p2;
		public int P2 {
			get { return p2; }
		}

		long p3;
		public long P3 {
			get { return p3; }
		}
	}

	public partial class LoadCanceledEventArgs : global::System.EventArgs {

		public LoadCanceledEventArgs (int p0, long p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		long p1;
		public long P1 {
			get { return p1; }
		}
	}

	public partial class LoadCompletedEventArgs : global::System.EventArgs {

		public LoadCompletedEventArgs (int p0, long p1, int p2, int p3, global::Com.Google.Android.Exoplayer.Chunk.Format p4, long p5, long p6, long p7, long p8)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
			this.p5 = p5;
			this.p6 = p6;
			this.p7 = p7;
			this.p8 = p8;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		long p1;
		public long P1 {
			get { return p1; }
		}

		int p2;
		public int P2 {
			get { return p2; }
		}

		int p3;
		public int P3 {
			get { return p3; }
		}

		global::Com.Google.Android.Exoplayer.Chunk.Format p4;
		public global::Com.Google.Android.Exoplayer.Chunk.Format P4 {
			get { return p4; }
		}

		long p5;
		public long P5 {
			get { return p5; }
		}

		long p6;
		public long P6 {
			get { return p6; }
		}

		long p7;
		public long P7 {
			get { return p7; }
		}

		long p8;
		public long P8 {
			get { return p8; }
		}
	}

	public partial class LoadErrorEventArgs : global::System.EventArgs {

		public LoadErrorEventArgs (int p0, global::Java.IO.IOException p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		global::Java.IO.IOException p1;
		public global::Java.IO.IOException P1 {
			get { return p1; }
		}
	}

	public partial class LoadStartedEventArgs : global::System.EventArgs {

		public LoadStartedEventArgs (int p0, long p1, int p2, int p3, global::Com.Google.Android.Exoplayer.Chunk.Format p4, long p5, long p6)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
			this.p5 = p5;
			this.p6 = p6;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		long p1;
		public long P1 {
			get { return p1; }
		}

		int p2;
		public int P2 {
			get { return p2; }
		}

		int p3;
		public int P3 {
			get { return p3; }
		}

		global::Com.Google.Android.Exoplayer.Chunk.Format p4;
		public global::Com.Google.Android.Exoplayer.Chunk.Format P4 {
			get { return p4; }
		}

		long p5;
		public long P5 {
			get { return p5; }
		}

		long p6;
		public long P6 {
			get { return p6; }
		}
	}

	public partial class UpstreamDiscardedEventArgs : global::System.EventArgs {

		public UpstreamDiscardedEventArgs (int p0, long p1, long p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		long p1;
		public long P1 {
			get { return p1; }
		}

		long p2;
		public long P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/exoplayer/chunk/BaseChunkSampleSourceEventListenerImplementor")]
	internal sealed partial class IBaseChunkSampleSourceEventListenerImplementor : global::Java.Lang.Object, IBaseChunkSampleSourceEventListener {

		object sender;

		public IBaseChunkSampleSourceEventListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/google/android/exoplayer/chunk/BaseChunkSampleSourceEventListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<DownstreamFormatChangedEventArgs> OnDownstreamFormatChangedHandler;
#pragma warning restore 0649

		public void OnDownstreamFormatChanged (int p0, global::Com.Google.Android.Exoplayer.Chunk.Format p1, int p2, long p3)
		{
			var __h = OnDownstreamFormatChangedHandler;
			if (__h != null)
				__h (sender, new DownstreamFormatChangedEventArgs (p0, p1, p2, p3));
		}
#pragma warning disable 0649
		public EventHandler<LoadCanceledEventArgs> OnLoadCanceledHandler;
#pragma warning restore 0649

		public void OnLoadCanceled (int p0, long p1)
		{
			var __h = OnLoadCanceledHandler;
			if (__h != null)
				__h (sender, new LoadCanceledEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<LoadCompletedEventArgs> OnLoadCompletedHandler;
#pragma warning restore 0649

		public void OnLoadCompleted (int p0, long p1, int p2, int p3, global::Com.Google.Android.Exoplayer.Chunk.Format p4, long p5, long p6, long p7, long p8)
		{
			var __h = OnLoadCompletedHandler;
			if (__h != null)
				__h (sender, new LoadCompletedEventArgs (p0, p1, p2, p3, p4, p5, p6, p7, p8));
		}
#pragma warning disable 0649
		public EventHandler<LoadErrorEventArgs> OnLoadErrorHandler;
#pragma warning restore 0649

		public void OnLoadError (int p0, global::Java.IO.IOException p1)
		{
			var __h = OnLoadErrorHandler;
			if (__h != null)
				__h (sender, new LoadErrorEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<LoadStartedEventArgs> OnLoadStartedHandler;
#pragma warning restore 0649

		public void OnLoadStarted (int p0, long p1, int p2, int p3, global::Com.Google.Android.Exoplayer.Chunk.Format p4, long p5, long p6)
		{
			var __h = OnLoadStartedHandler;
			if (__h != null)
				__h (sender, new LoadStartedEventArgs (p0, p1, p2, p3, p4, p5, p6));
		}
#pragma warning disable 0649
		public EventHandler<UpstreamDiscardedEventArgs> OnUpstreamDiscardedHandler;
#pragma warning restore 0649

		public void OnUpstreamDiscarded (int p0, long p1, long p2)
		{
			var __h = OnUpstreamDiscardedHandler;
			if (__h != null)
				__h (sender, new UpstreamDiscardedEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IBaseChunkSampleSourceEventListenerImplementor value)
		{
			return value.OnDownstreamFormatChangedHandler == null && value.OnLoadCanceledHandler == null && value.OnLoadCompletedHandler == null && value.OnLoadErrorHandler == null && value.OnLoadStartedHandler == null && value.OnUpstreamDiscardedHandler == null;
		}
	}

}
