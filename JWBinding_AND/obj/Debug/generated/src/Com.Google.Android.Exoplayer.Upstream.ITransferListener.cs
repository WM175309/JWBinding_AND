using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Upstream {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/interface[@name='TransferListener']"
	[Register ("com/google/android/exoplayer/upstream/TransferListener", "", "Com.Google.Android.Exoplayer.Upstream.ITransferListenerInvoker")]
	public partial interface ITransferListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/interface[@name='TransferListener']/method[@name='onBytesTransferred' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onBytesTransferred", "(I)V", "GetOnBytesTransferred_IHandler:Com.Google.Android.Exoplayer.Upstream.ITransferListenerInvoker, JWBinding_AND")]
		void OnBytesTransferred (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/interface[@name='TransferListener']/method[@name='onTransferEnd' and count(parameter)=0]"
		[Register ("onTransferEnd", "()V", "GetOnTransferEndHandler:Com.Google.Android.Exoplayer.Upstream.ITransferListenerInvoker, JWBinding_AND")]
		void OnTransferEnd ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/interface[@name='TransferListener']/method[@name='onTransferStart' and count(parameter)=0]"
		[Register ("onTransferStart", "()V", "GetOnTransferStartHandler:Com.Google.Android.Exoplayer.Upstream.ITransferListenerInvoker, JWBinding_AND")]
		void OnTransferStart ();

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/upstream/TransferListener", DoNotGenerateAcw=true)]
	internal class ITransferListenerInvoker : global::Java.Lang.Object, ITransferListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/upstream/TransferListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITransferListenerInvoker); }
		}

		IntPtr class_ref;

		public static ITransferListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITransferListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.upstream.TransferListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITransferListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBytesTransferred_I;
#pragma warning disable 0169
		static Delegate GetOnBytesTransferred_IHandler ()
		{
			if (cb_onBytesTransferred_I == null)
				cb_onBytesTransferred_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnBytesTransferred_I);
			return cb_onBytesTransferred_I;
		}

		static void n_OnBytesTransferred_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Android.Exoplayer.Upstream.ITransferListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.ITransferListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBytesTransferred (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBytesTransferred_I;
		public unsafe void OnBytesTransferred (int p0)
		{
			if (id_onBytesTransferred_I == IntPtr.Zero)
				id_onBytesTransferred_I = JNIEnv.GetMethodID (class_ref, "onBytesTransferred", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBytesTransferred_I, __args);
		}

		static Delegate cb_onTransferEnd;
#pragma warning disable 0169
		static Delegate GetOnTransferEndHandler ()
		{
			if (cb_onTransferEnd == null)
				cb_onTransferEnd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnTransferEnd);
			return cb_onTransferEnd;
		}

		static void n_OnTransferEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Upstream.ITransferListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.ITransferListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTransferEnd ();
		}
#pragma warning restore 0169

		IntPtr id_onTransferEnd;
		public unsafe void OnTransferEnd ()
		{
			if (id_onTransferEnd == IntPtr.Zero)
				id_onTransferEnd = JNIEnv.GetMethodID (class_ref, "onTransferEnd", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTransferEnd);
		}

		static Delegate cb_onTransferStart;
#pragma warning disable 0169
		static Delegate GetOnTransferStartHandler ()
		{
			if (cb_onTransferStart == null)
				cb_onTransferStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnTransferStart);
			return cb_onTransferStart;
		}

		static void n_OnTransferStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Upstream.ITransferListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.ITransferListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTransferStart ();
		}
#pragma warning restore 0169

		IntPtr id_onTransferStart;
		public unsafe void OnTransferStart ()
		{
			if (id_onTransferStart == IntPtr.Zero)
				id_onTransferStart = JNIEnv.GetMethodID (class_ref, "onTransferStart", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTransferStart);
		}

	}

	public partial class BytesTransferredEventArgs : global::System.EventArgs {

		public BytesTransferredEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/exoplayer/upstream/TransferListenerImplementor")]
	internal sealed partial class ITransferListenerImplementor : global::Java.Lang.Object, ITransferListener {

		object sender;

		public ITransferListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/google/android/exoplayer/upstream/TransferListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BytesTransferredEventArgs> OnBytesTransferredHandler;
#pragma warning restore 0649

		public void OnBytesTransferred (int p0)
		{
			var __h = OnBytesTransferredHandler;
			if (__h != null)
				__h (sender, new BytesTransferredEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler OnTransferEndHandler;
#pragma warning restore 0649

		public void OnTransferEnd ()
		{
			var __h = OnTransferEndHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnTransferStartHandler;
#pragma warning restore 0649

		public void OnTransferStart ()
		{
			var __h = OnTransferStartHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (ITransferListenerImplementor value)
		{
			return value.OnBytesTransferredHandler == null && value.OnTransferEndHandler == null && value.OnTransferStartHandler == null;
		}
	}

}
