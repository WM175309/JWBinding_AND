using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Upstream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='NetworkLock']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/upstream/NetworkLock", DoNotGenerateAcw=true)]
	public sealed partial class NetworkLock : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='NetworkLock']/field[@name='DOWNLOAD_PRIORITY']"
		[Register ("DOWNLOAD_PRIORITY")]
		public const int DownloadPriority = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='NetworkLock']/field[@name='STREAMING_PRIORITY']"
		[Register ("STREAMING_PRIORITY")]
		public const int StreamingPriority = (int) 0;

		static IntPtr instance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='NetworkLock']/field[@name='instance']"
		[Register ("instance")]
		public static global::Com.Google.Android.Exoplayer.Upstream.NetworkLock Instance {
			get {
				if (instance_jfieldId == IntPtr.Zero)
					instance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "instance", "Lcom/google/android/exoplayer/upstream/NetworkLock;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, instance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.NetworkLock> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='NetworkLock.PriorityTooLowException']"
		[global::Android.Runtime.Register ("com/google/android/exoplayer/upstream/NetworkLock$PriorityTooLowException", DoNotGenerateAcw=true)]
		public partial class PriorityTooLowException : global::Java.IO.IOException {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/exoplayer/upstream/NetworkLock$PriorityTooLowException", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PriorityTooLowException); }
			}

			protected PriorityTooLowException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_II;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='NetworkLock.PriorityTooLowException']/constructor[@name='NetworkLock.PriorityTooLowException' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register (".ctor", "(II)V", "")]
			public unsafe PriorityTooLowException (int p0, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (PriorityTooLowException)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(II)V", __args);
						return;
					}

					if (id_ctor_II == IntPtr.Zero)
						id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_II, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/upstream/NetworkLock", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkLock); }
		}

		internal NetworkLock (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_add_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='NetworkLock']/method[@name='add' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("add", "(I)V", "")]
		public unsafe void Add (int p0)
		{
			if (id_add_I == IntPtr.Zero)
				id_add_I = JNIEnv.GetMethodID (class_ref, "add", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_I, __args);
			} finally {
			}
		}

		static IntPtr id_proceed_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='NetworkLock']/method[@name='proceed' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("proceed", "(I)V", "")]
		public unsafe void Proceed (int p0)
		{
			if (id_proceed_I == IntPtr.Zero)
				id_proceed_I = JNIEnv.GetMethodID (class_ref, "proceed", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_proceed_I, __args);
			} finally {
			}
		}

		static IntPtr id_proceedNonBlocking_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='NetworkLock']/method[@name='proceedNonBlocking' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("proceedNonBlocking", "(I)Z", "")]
		public unsafe bool ProceedNonBlocking (int p0)
		{
			if (id_proceedNonBlocking_I == IntPtr.Zero)
				id_proceedNonBlocking_I = JNIEnv.GetMethodID (class_ref, "proceedNonBlocking", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_proceedNonBlocking_I, __args);
			} finally {
			}
		}

		static IntPtr id_proceedOrThrow_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='NetworkLock']/method[@name='proceedOrThrow' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("proceedOrThrow", "(I)V", "")]
		public unsafe void ProceedOrThrow (int p0)
		{
			if (id_proceedOrThrow_I == IntPtr.Zero)
				id_proceedOrThrow_I = JNIEnv.GetMethodID (class_ref, "proceedOrThrow", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_proceedOrThrow_I, __args);
			} finally {
			}
		}

		static IntPtr id_remove_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='NetworkLock']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("remove", "(I)V", "")]
		public unsafe void Remove (int p0)
		{
			if (id_remove_I == IntPtr.Zero)
				id_remove_I = JNIEnv.GetMethodID (class_ref, "remove", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_I, __args);
			} finally {
			}
		}

	}
}
