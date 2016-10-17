using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Util.Extensions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='InputBuffer']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/util/extensions/InputBuffer", DoNotGenerateAcw=true)]
	public partial class InputBuffer : global::Com.Google.Android.Exoplayer.Util.Extensions.Buffer {


		static IntPtr sampleHolder_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='InputBuffer']/field[@name='sampleHolder']"
		[Register ("sampleHolder")]
		public global::Com.Google.Android.Exoplayer.SampleHolder SampleHolder {
			get {
				if (sampleHolder_jfieldId == IntPtr.Zero)
					sampleHolder_jfieldId = JNIEnv.GetFieldID (class_ref, "sampleHolder", "Lcom/google/android/exoplayer/SampleHolder;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, sampleHolder_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.SampleHolder> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sampleHolder_jfieldId == IntPtr.Zero)
					sampleHolder_jfieldId = JNIEnv.GetFieldID (class_ref, "sampleHolder", "Lcom/google/android/exoplayer/SampleHolder;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sampleHolder_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/util/extensions/InputBuffer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InputBuffer); }
		}

		protected InputBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.util.extensions']/class[@name='InputBuffer']/constructor[@name='InputBuffer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InputBuffer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (InputBuffer)) {
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

	}
}
