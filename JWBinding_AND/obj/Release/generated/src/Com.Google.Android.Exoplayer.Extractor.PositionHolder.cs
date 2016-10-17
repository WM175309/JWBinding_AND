using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='PositionHolder']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/extractor/PositionHolder", DoNotGenerateAcw=true)]
	public sealed partial class PositionHolder : global::Java.Lang.Object {


		static IntPtr position_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='PositionHolder']/field[@name='position']"
		[Register ("position")]
		public long Position {
			get {
				if (position_jfieldId == IntPtr.Zero)
					position_jfieldId = JNIEnv.GetFieldID (class_ref, "position", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, position_jfieldId);
			}
			set {
				if (position_jfieldId == IntPtr.Zero)
					position_jfieldId = JNIEnv.GetFieldID (class_ref, "position", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, position_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/extractor/PositionHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PositionHolder); }
		}

		internal PositionHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='PositionHolder']/constructor[@name='PositionHolder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PositionHolder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (PositionHolder)) {
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
