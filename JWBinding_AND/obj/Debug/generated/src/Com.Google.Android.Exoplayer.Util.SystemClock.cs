using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='SystemClock']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/util/SystemClock", DoNotGenerateAcw=true)]
	public sealed partial class SystemClock : global::Java.Lang.Object, global::Com.Google.Android.Exoplayer.Util.IClock {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/util/SystemClock", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SystemClock); }
		}

		internal SystemClock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='SystemClock']/constructor[@name='SystemClock' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SystemClock ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SystemClock)) {
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

		static IntPtr id_elapsedRealtime;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='SystemClock']/method[@name='elapsedRealtime' and count(parameter)=0]"
		[Register ("elapsedRealtime", "()J", "")]
		public unsafe long ElapsedRealtime ()
		{
			if (id_elapsedRealtime == IntPtr.Zero)
				id_elapsedRealtime = JNIEnv.GetMethodID (class_ref, "elapsedRealtime", "()J");
			try {
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_elapsedRealtime);
			} finally {
			}
		}

	}
}
