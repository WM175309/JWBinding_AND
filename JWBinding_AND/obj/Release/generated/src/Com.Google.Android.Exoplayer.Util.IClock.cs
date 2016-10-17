using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Util {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer.util']/interface[@name='Clock']"
	[Register ("com/google/android/exoplayer/util/Clock", "", "Com.Google.Android.Exoplayer.Util.IClockInvoker")]
	public partial interface IClock : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/interface[@name='Clock']/method[@name='elapsedRealtime' and count(parameter)=0]"
		[Register ("elapsedRealtime", "()J", "GetElapsedRealtimeHandler:Com.Google.Android.Exoplayer.Util.IClockInvoker, JWBinding_AND")]
		long ElapsedRealtime ();

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/util/Clock", DoNotGenerateAcw=true)]
	internal class IClockInvoker : global::Java.Lang.Object, IClock {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/util/Clock");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IClockInvoker); }
		}

		IntPtr class_ref;

		public static IClock GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IClock> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.util.Clock"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IClockInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_elapsedRealtime;
#pragma warning disable 0169
		static Delegate GetElapsedRealtimeHandler ()
		{
			if (cb_elapsedRealtime == null)
				cb_elapsedRealtime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_ElapsedRealtime);
			return cb_elapsedRealtime;
		}

		static long n_ElapsedRealtime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Util.IClock __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Util.IClock> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ElapsedRealtime ();
		}
#pragma warning restore 0169

		IntPtr id_elapsedRealtime;
		public unsafe long ElapsedRealtime ()
		{
			if (id_elapsedRealtime == IntPtr.Zero)
				id_elapsedRealtime = JNIEnv.GetMethodID (class_ref, "elapsedRealtime", "()J");
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_elapsedRealtime);
		}

	}

}
