using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Chunk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/interface[@name='FormatWrapper']"
	[Register ("com/google/android/exoplayer/chunk/FormatWrapper", "", "Com.Google.Android.Exoplayer.Chunk.IFormatWrapperInvoker")]
	public partial interface IFormatWrapper : IJavaObject {

		global::Com.Google.Android.Exoplayer.Chunk.Format Format {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.chunk']/interface[@name='FormatWrapper']/method[@name='getFormat' and count(parameter)=0]"
			[Register ("getFormat", "()Lcom/google/android/exoplayer/chunk/Format;", "GetGetFormatHandler:Com.Google.Android.Exoplayer.Chunk.IFormatWrapperInvoker, JWBinding_AND")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/chunk/FormatWrapper", DoNotGenerateAcw=true)]
	internal class IFormatWrapperInvoker : global::Java.Lang.Object, IFormatWrapper {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/chunk/FormatWrapper");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFormatWrapperInvoker); }
		}

		IntPtr class_ref;

		public static IFormatWrapper GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFormatWrapper> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.chunk.FormatWrapper"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFormatWrapperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getFormat;
#pragma warning disable 0169
		static Delegate GetGetFormatHandler ()
		{
			if (cb_getFormat == null)
				cb_getFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormat);
			return cb_getFormat;
		}

		static IntPtr n_GetFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Chunk.IFormatWrapper __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Chunk.IFormatWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Format);
		}
#pragma warning restore 0169

		IntPtr id_getFormat;
		public unsafe global::Com.Google.Android.Exoplayer.Chunk.Format Format {
			get {
				if (id_getFormat == IntPtr.Zero)
					id_getFormat = JNIEnv.GetMethodID (class_ref, "getFormat", "()Lcom/google/android/exoplayer/chunk/Format;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Chunk.Format> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormat), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
