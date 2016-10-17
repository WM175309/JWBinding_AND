using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Upstream {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/interface[@name='Allocator']"
	[Register ("com/google/android/exoplayer/upstream/Allocator", "", "Com.Google.Android.Exoplayer.Upstream.IAllocatorInvoker")]
	public partial interface IAllocator : IJavaObject {

		int IndividualAllocationLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/interface[@name='Allocator']/method[@name='getIndividualAllocationLength' and count(parameter)=0]"
			[Register ("getIndividualAllocationLength", "()I", "GetGetIndividualAllocationLengthHandler:Com.Google.Android.Exoplayer.Upstream.IAllocatorInvoker, JWBinding_AND")] get;
		}

		int TotalBytesAllocated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/interface[@name='Allocator']/method[@name='getTotalBytesAllocated' and count(parameter)=0]"
			[Register ("getTotalBytesAllocated", "()I", "GetGetTotalBytesAllocatedHandler:Com.Google.Android.Exoplayer.Upstream.IAllocatorInvoker, JWBinding_AND")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/interface[@name='Allocator']/method[@name='allocate' and count(parameter)=0]"
		[Register ("allocate", "()Lcom/google/android/exoplayer/upstream/Allocation;", "GetAllocateHandler:Com.Google.Android.Exoplayer.Upstream.IAllocatorInvoker, JWBinding_AND")]
		global::Com.Google.Android.Exoplayer.Upstream.Allocation Allocate ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/interface[@name='Allocator']/method[@name='blockWhileTotalBytesAllocatedExceeds' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("blockWhileTotalBytesAllocatedExceeds", "(I)V", "GetBlockWhileTotalBytesAllocatedExceeds_IHandler:Com.Google.Android.Exoplayer.Upstream.IAllocatorInvoker, JWBinding_AND")]
		void BlockWhileTotalBytesAllocatedExceeds (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/interface[@name='Allocator']/method[@name='release' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer.upstream.Allocation']]"
		[Register ("release", "(Lcom/google/android/exoplayer/upstream/Allocation;)V", "GetRelease_Lcom_google_android_exoplayer_upstream_Allocation_Handler:Com.Google.Android.Exoplayer.Upstream.IAllocatorInvoker, JWBinding_AND")]
		void Release (global::Com.Google.Android.Exoplayer.Upstream.Allocation p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/interface[@name='Allocator']/method[@name='trim' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("trim", "(I)V", "GetTrim_IHandler:Com.Google.Android.Exoplayer.Upstream.IAllocatorInvoker, JWBinding_AND")]
		void Trim (int p0);

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/upstream/Allocator", DoNotGenerateAcw=true)]
	internal class IAllocatorInvoker : global::Java.Lang.Object, IAllocator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/upstream/Allocator");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAllocatorInvoker); }
		}

		IntPtr class_ref;

		public static IAllocator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAllocator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.upstream.Allocator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAllocatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getIndividualAllocationLength;
#pragma warning disable 0169
		static Delegate GetGetIndividualAllocationLengthHandler ()
		{
			if (cb_getIndividualAllocationLength == null)
				cb_getIndividualAllocationLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndividualAllocationLength);
			return cb_getIndividualAllocationLength;
		}

		static int n_GetIndividualAllocationLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Upstream.IAllocator __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.IAllocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IndividualAllocationLength;
		}
#pragma warning restore 0169

		IntPtr id_getIndividualAllocationLength;
		public unsafe int IndividualAllocationLength {
			get {
				if (id_getIndividualAllocationLength == IntPtr.Zero)
					id_getIndividualAllocationLength = JNIEnv.GetMethodID (class_ref, "getIndividualAllocationLength", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndividualAllocationLength);
			}
		}

		static Delegate cb_getTotalBytesAllocated;
#pragma warning disable 0169
		static Delegate GetGetTotalBytesAllocatedHandler ()
		{
			if (cb_getTotalBytesAllocated == null)
				cb_getTotalBytesAllocated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTotalBytesAllocated);
			return cb_getTotalBytesAllocated;
		}

		static int n_GetTotalBytesAllocated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Upstream.IAllocator __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.IAllocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalBytesAllocated;
		}
#pragma warning restore 0169

		IntPtr id_getTotalBytesAllocated;
		public unsafe int TotalBytesAllocated {
			get {
				if (id_getTotalBytesAllocated == IntPtr.Zero)
					id_getTotalBytesAllocated = JNIEnv.GetMethodID (class_ref, "getTotalBytesAllocated", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTotalBytesAllocated);
			}
		}

		static Delegate cb_allocate;
#pragma warning disable 0169
		static Delegate GetAllocateHandler ()
		{
			if (cb_allocate == null)
				cb_allocate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Allocate);
			return cb_allocate;
		}

		static IntPtr n_Allocate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Upstream.IAllocator __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.IAllocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Allocate ());
		}
#pragma warning restore 0169

		IntPtr id_allocate;
		public unsafe global::Com.Google.Android.Exoplayer.Upstream.Allocation Allocate ()
		{
			if (id_allocate == IntPtr.Zero)
				id_allocate = JNIEnv.GetMethodID (class_ref, "allocate", "()Lcom/google/android/exoplayer/upstream/Allocation;");
			return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Allocation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_allocate), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_blockWhileTotalBytesAllocatedExceeds_I;
#pragma warning disable 0169
		static Delegate GetBlockWhileTotalBytesAllocatedExceeds_IHandler ()
		{
			if (cb_blockWhileTotalBytesAllocatedExceeds_I == null)
				cb_blockWhileTotalBytesAllocatedExceeds_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_BlockWhileTotalBytesAllocatedExceeds_I);
			return cb_blockWhileTotalBytesAllocatedExceeds_I;
		}

		static void n_BlockWhileTotalBytesAllocatedExceeds_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Android.Exoplayer.Upstream.IAllocator __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.IAllocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BlockWhileTotalBytesAllocatedExceeds (p0);
		}
#pragma warning restore 0169

		IntPtr id_blockWhileTotalBytesAllocatedExceeds_I;
		public unsafe void BlockWhileTotalBytesAllocatedExceeds (int p0)
		{
			if (id_blockWhileTotalBytesAllocatedExceeds_I == IntPtr.Zero)
				id_blockWhileTotalBytesAllocatedExceeds_I = JNIEnv.GetMethodID (class_ref, "blockWhileTotalBytesAllocatedExceeds", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_blockWhileTotalBytesAllocatedExceeds_I, __args);
		}

		static Delegate cb_release_Lcom_google_android_exoplayer_upstream_Allocation_;
#pragma warning disable 0169
		static Delegate GetRelease_Lcom_google_android_exoplayer_upstream_Allocation_Handler ()
		{
			if (cb_release_Lcom_google_android_exoplayer_upstream_Allocation_ == null)
				cb_release_Lcom_google_android_exoplayer_upstream_Allocation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Release_Lcom_google_android_exoplayer_upstream_Allocation_);
			return cb_release_Lcom_google_android_exoplayer_upstream_Allocation_;
		}

		static void n_Release_Lcom_google_android_exoplayer_upstream_Allocation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Exoplayer.Upstream.IAllocator __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.IAllocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Upstream.Allocation p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.Allocation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Release (p0);
		}
#pragma warning restore 0169

		IntPtr id_release_Lcom_google_android_exoplayer_upstream_Allocation_;
		public unsafe void Release (global::Com.Google.Android.Exoplayer.Upstream.Allocation p0)
		{
			if (id_release_Lcom_google_android_exoplayer_upstream_Allocation_ == IntPtr.Zero)
				id_release_Lcom_google_android_exoplayer_upstream_Allocation_ = JNIEnv.GetMethodID (class_ref, "release", "(Lcom/google/android/exoplayer/upstream/Allocation;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release_Lcom_google_android_exoplayer_upstream_Allocation_, __args);
		}

		static Delegate cb_trim_I;
#pragma warning disable 0169
		static Delegate GetTrim_IHandler ()
		{
			if (cb_trim_I == null)
				cb_trim_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Trim_I);
			return cb_trim_I;
		}

		static void n_Trim_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Android.Exoplayer.Upstream.IAllocator __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.IAllocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Trim (p0);
		}
#pragma warning restore 0169

		IntPtr id_trim_I;
		public unsafe void Trim (int p0)
		{
			if (id_trim_I == IntPtr.Zero)
				id_trim_I = JNIEnv.GetMethodID (class_ref, "trim", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trim_I, __args);
		}

	}

}
