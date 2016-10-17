using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Util.Extensions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='OutputBuffer']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/util/extensions/OutputBuffer", DoNotGenerateAcw=true)]
	public abstract partial class OutputBuffer : global::Com.Google.Android.Exoplayer.Util.Extensions.Buffer {


		static IntPtr timestampUs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='OutputBuffer']/field[@name='timestampUs']"
		[Register ("timestampUs")]
		public long TimestampUs {
			get {
				if (timestampUs_jfieldId == IntPtr.Zero)
					timestampUs_jfieldId = JNIEnv.GetFieldID (class_ref, "timestampUs", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, timestampUs_jfieldId);
			}
			set {
				if (timestampUs_jfieldId == IntPtr.Zero)
					timestampUs_jfieldId = JNIEnv.GetFieldID (class_ref, "timestampUs", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, timestampUs_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/util/extensions/OutputBuffer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OutputBuffer); }
		}

		protected OutputBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='OutputBuffer']/constructor[@name='OutputBuffer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OutputBuffer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (OutputBuffer)) {
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
			global::Com.Google.Android.Exoplayer.Util.Extensions.OutputBuffer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Util.Extensions.OutputBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='OutputBuffer']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public abstract void Release ();

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/util/extensions/OutputBuffer", DoNotGenerateAcw=true)]
	internal partial class OutputBufferInvoker : OutputBuffer {

		public OutputBufferInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (OutputBufferInvoker); }
		}

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='OutputBuffer']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public override unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
			} finally {
			}
		}

	}

}
