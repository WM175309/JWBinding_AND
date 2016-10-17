using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Upstream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultAllocator']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/upstream/DefaultAllocator", DoNotGenerateAcw=true)]
	public sealed partial class DefaultAllocator : global::Java.Lang.Object, global::Com.Google.Android.Exoplayer.Upstream.IAllocator {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/upstream/DefaultAllocator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultAllocator); }
		}

		internal DefaultAllocator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultAllocator']/constructor[@name='DefaultAllocator' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe DefaultAllocator (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DefaultAllocator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultAllocator']/constructor[@name='DefaultAllocator' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe DefaultAllocator (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (DefaultAllocator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(II)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
					return;
				}

				if (id_ctor_II == IntPtr.Zero)
					id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
			} finally {
			}
		}

		static IntPtr id_getIndividualAllocationLength;
		public unsafe int IndividualAllocationLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultAllocator']/method[@name='getIndividualAllocationLength' and count(parameter)=0]"
			[Register ("getIndividualAllocationLength", "()I", "GetGetIndividualAllocationLengthHandler")]
			get {
				if (id_getIndividualAllocationLength == IntPtr.Zero)
					id_getIndividualAllocationLength = JNIEnv.GetMethodID (class_ref, "getIndividualAllocationLength", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndividualAllocationLength);
				} finally {
				}
			}
		}

		static IntPtr id_getTotalBytesAllocated;
		public unsafe int TotalBytesAllocated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultAllocator']/method[@name='getTotalBytesAllocated' and count(parameter)=0]"
			[Register ("getTotalBytesAllocated", "()I", "GetGetTotalBytesAllocatedHandler")]
			get {
				if (id_getTotalBytesAllocated == IntPtr.Zero)
					id_getTotalBytesAllocated = JNIEnv.GetMethodID (class_ref, "getTotalBytesAllocated", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTotalBytesAllocated);
				} finally {
				}
			}
		}

		static IntPtr id_allocate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultAllocator']/method[@name='allocate' and count(parameter)=0]"
		[Register ("allocate", "()Lcom/google/android/exoplayer/upstream/Allocation;", "")]
		public unsafe global::Com.Google.Android.Exoplayer.Upstream.Allocation Allocate ()
		{
			if (id_allocate == IntPtr.Zero)
				id_allocate = JNIEnv.GetMethodID (class_ref, "allocate", "()Lcom/google/android/exoplayer/upstream/Allocation;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Allocation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_allocate), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_blockWhileTotalBytesAllocatedExceeds_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultAllocator']/method[@name='blockWhileTotalBytesAllocatedExceeds' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("blockWhileTotalBytesAllocatedExceeds", "(I)V", "")]
		public unsafe void BlockWhileTotalBytesAllocatedExceeds (int p0)
		{
			if (id_blockWhileTotalBytesAllocatedExceeds_I == IntPtr.Zero)
				id_blockWhileTotalBytesAllocatedExceeds_I = JNIEnv.GetMethodID (class_ref, "blockWhileTotalBytesAllocatedExceeds", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_blockWhileTotalBytesAllocatedExceeds_I, __args);
			} finally {
			}
		}

		static IntPtr id_release_Lcom_google_android_exoplayer_upstream_Allocation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultAllocator']/method[@name='release' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer.upstream.Allocation']]"
		[Register ("release", "(Lcom/google/android/exoplayer/upstream/Allocation;)V", "")]
		public unsafe void Release (global::Com.Google.Android.Exoplayer.Upstream.Allocation p0)
		{
			if (id_release_Lcom_google_android_exoplayer_upstream_Allocation_ == IntPtr.Zero)
				id_release_Lcom_google_android_exoplayer_upstream_Allocation_ = JNIEnv.GetMethodID (class_ref, "release", "(Lcom/google/android/exoplayer/upstream/Allocation;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release_Lcom_google_android_exoplayer_upstream_Allocation_, __args);
			} finally {
			}
		}

		static IntPtr id_trim_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/class[@name='DefaultAllocator']/method[@name='trim' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("trim", "(I)V", "")]
		public unsafe void Trim (int p0)
		{
			if (id_trim_I == IntPtr.Zero)
				id_trim_I = JNIEnv.GetMethodID (class_ref, "trim", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trim_I, __args);
			} finally {
			}
		}

	}
}
