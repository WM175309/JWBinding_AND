using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Util.Extensions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='Buffer']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/util/extensions/Buffer", DoNotGenerateAcw=true)]
	public abstract partial class Buffer : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='Buffer']/field[@name='FLAG_DECODE_ONLY']"
		[Register ("FLAG_DECODE_ONLY")]
		public const int FlagDecodeOnly = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='Buffer']/field[@name='FLAG_END_OF_STREAM']"
		[Register ("FLAG_END_OF_STREAM")]
		public const int FlagEndOfStream = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='Buffer']/field[@name='FLAG_RESET']"
		[Register ("FLAG_RESET")]
		public const int FlagReset = (int) 2;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/util/extensions/Buffer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Buffer); }
		}

		protected Buffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='Buffer']/constructor[@name='Buffer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Buffer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Buffer)) {
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

		static IntPtr id_getFlag_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='Buffer']/method[@name='getFlag' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getFlag", "(I)Z", "")]
		public unsafe bool GetFlag (int p0)
		{
			if (id_getFlag_I == IntPtr.Zero)
				id_getFlag_I = JNIEnv.GetMethodID (class_ref, "getFlag", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getFlag_I, __args);
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Util.Extensions.Buffer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Util.Extensions.Buffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='Buffer']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reset", "()V"));
			} finally {
			}
		}

		static IntPtr id_setFlag_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='Buffer']/method[@name='setFlag' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFlag", "(I)V", "")]
		public unsafe void SetFlag (int p0)
		{
			if (id_setFlag_I == IntPtr.Zero)
				id_setFlag_I = JNIEnv.GetMethodID (class_ref, "setFlag", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFlag_I, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/util/extensions/Buffer", DoNotGenerateAcw=true)]
	internal partial class BufferInvoker : Buffer {

		public BufferInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (BufferInvoker); }
		}

	}

}
