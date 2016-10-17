using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer']/interface[@name='MediaClock']"
	[Register ("com/google/android/exoplayer/MediaClock", "", "Com.Google.Android.Exoplayer.IMediaClockInvoker")]
	public partial interface IMediaClock : IJavaObject {

		long PositionUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/interface[@name='MediaClock']/method[@name='getPositionUs' and count(parameter)=0]"
			[Register ("getPositionUs", "()J", "GetGetPositionUsHandler:Com.Google.Android.Exoplayer.IMediaClockInvoker, JWBinding_AND")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/MediaClock", DoNotGenerateAcw=true)]
	internal class IMediaClockInvoker : global::Java.Lang.Object, IMediaClock {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/MediaClock");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMediaClockInvoker); }
		}

		IntPtr class_ref;

		public static IMediaClock GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaClock> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.MediaClock"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaClockInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getPositionUs;
#pragma warning disable 0169
		static Delegate GetGetPositionUsHandler ()
		{
			if (cb_getPositionUs == null)
				cb_getPositionUs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetPositionUs);
			return cb_getPositionUs;
		}

		static long n_GetPositionUs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.IMediaClock __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.IMediaClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PositionUs;
		}
#pragma warning restore 0169

		IntPtr id_getPositionUs;
		public unsafe long PositionUs {
			get {
				if (id_getPositionUs == IntPtr.Zero)
					id_getPositionUs = JNIEnv.GetMethodID (class_ref, "getPositionUs", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPositionUs);
			}
		}

	}

}
