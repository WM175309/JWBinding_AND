using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Upstream {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/interface[@name='BandwidthMeter.EventListener']"
	[Register ("com/google/android/exoplayer/upstream/BandwidthMeter$EventListener", "", "Com.Google.Android.Exoplayer.Upstream.IBandwidthMeterEventListenerInvoker")]
	public partial interface IBandwidthMeterEventListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/interface[@name='BandwidthMeter.EventListener']/method[@name='onBandwidthSample' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("onBandwidthSample", "(IJJ)V", "GetOnBandwidthSample_IJJHandler:Com.Google.Android.Exoplayer.Upstream.IBandwidthMeterEventListenerInvoker, JWBinding_AND")]
		void OnBandwidthSample (int p0, long p1, long p2);

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/upstream/BandwidthMeter$EventListener", DoNotGenerateAcw=true)]
	internal class IBandwidthMeterEventListenerInvoker : global::Java.Lang.Object, IBandwidthMeterEventListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/upstream/BandwidthMeter$EventListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBandwidthMeterEventListenerInvoker); }
		}

		IntPtr class_ref;

		public static IBandwidthMeterEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBandwidthMeterEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.upstream.BandwidthMeter.EventListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBandwidthMeterEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBandwidthSample_IJJ;
#pragma warning disable 0169
		static Delegate GetOnBandwidthSample_IJJHandler ()
		{
			if (cb_onBandwidthSample_IJJ == null)
				cb_onBandwidthSample_IJJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, long, long>) n_OnBandwidthSample_IJJ);
			return cb_onBandwidthSample_IJJ;
		}

		static void n_OnBandwidthSample_IJJ (IntPtr jnienv, IntPtr native__this, int p0, long p1, long p2)
		{
			global::Com.Google.Android.Exoplayer.Upstream.IBandwidthMeterEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.IBandwidthMeterEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBandwidthSample (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onBandwidthSample_IJJ;
		public unsafe void OnBandwidthSample (int p0, long p1, long p2)
		{
			if (id_onBandwidthSample_IJJ == IntPtr.Zero)
				id_onBandwidthSample_IJJ = JNIEnv.GetMethodID (class_ref, "onBandwidthSample", "(IJJ)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBandwidthSample_IJJ, __args);
		}

	}

	public partial class BandwidthMeterEventEventArgs : global::System.EventArgs {

		public BandwidthMeterEventEventArgs (int p0, long p1, long p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		long p1;
		public long P1 {
			get { return p1; }
		}

		long p2;
		public long P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/android/exoplayer/upstream/BandwidthMeter_EventListenerImplementor")]
	internal sealed partial class IBandwidthMeterEventListenerImplementor : global::Java.Lang.Object, IBandwidthMeterEventListener {

		object sender;

		public IBandwidthMeterEventListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/google/android/exoplayer/upstream/BandwidthMeter_EventListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BandwidthMeterEventEventArgs> Handler;
#pragma warning restore 0649

		public void OnBandwidthSample (int p0, long p1, long p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BandwidthMeterEventEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IBandwidthMeterEventListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	[Register ("com/google/android/exoplayer/upstream/BandwidthMeter", DoNotGenerateAcw=true)]
	public abstract class BandwidthMeter : Java.Lang.Object {

		internal BandwidthMeter ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/interface[@name='BandwidthMeter']/field[@name='NO_ESTIMATE']"
		[Register ("NO_ESTIMATE")]
		public const long NoEstimate = (long) -1L;

		// The following are fields from: com.google.android.exoplayer.upstream.TransferListener
	}

	[Register ("com/google/android/exoplayer/upstream/BandwidthMeter", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'BandwidthMeter' type. This type will be removed in a future release.")]
	public abstract class BandwidthMeterConsts : BandwidthMeter {

		private BandwidthMeterConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/interface[@name='BandwidthMeter']"
	[Register ("com/google/android/exoplayer/upstream/BandwidthMeter", "", "Com.Google.Android.Exoplayer.Upstream.IBandwidthMeterInvoker")]
	public partial interface IBandwidthMeter : global::Com.Google.Android.Exoplayer.Upstream.ITransferListener {

		long BitrateEstimate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.upstream']/interface[@name='BandwidthMeter']/method[@name='getBitrateEstimate' and count(parameter)=0]"
			[Register ("getBitrateEstimate", "()J", "GetGetBitrateEstimateHandler:Com.Google.Android.Exoplayer.Upstream.IBandwidthMeterInvoker, JWBinding_AND")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/upstream/BandwidthMeter", DoNotGenerateAcw=true)]
	internal class IBandwidthMeterInvoker : global::Java.Lang.Object, IBandwidthMeter {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/upstream/BandwidthMeter");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBandwidthMeterInvoker); }
		}

		IntPtr class_ref;

		public static IBandwidthMeter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBandwidthMeter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.upstream.BandwidthMeter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBandwidthMeterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getBitrateEstimate;
#pragma warning disable 0169
		static Delegate GetGetBitrateEstimateHandler ()
		{
			if (cb_getBitrateEstimate == null)
				cb_getBitrateEstimate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetBitrateEstimate);
			return cb_getBitrateEstimate;
		}

		static long n_GetBitrateEstimate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Upstream.IBandwidthMeter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.IBandwidthMeter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BitrateEstimate;
		}
#pragma warning restore 0169

		IntPtr id_getBitrateEstimate;
		public unsafe long BitrateEstimate {
			get {
				if (id_getBitrateEstimate == IntPtr.Zero)
					id_getBitrateEstimate = JNIEnv.GetMethodID (class_ref, "getBitrateEstimate", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getBitrateEstimate);
			}
		}

		static Delegate cb_onBytesTransferred_I;
#pragma warning disable 0169
		static Delegate GetOnBytesTransferred_IHandler ()
		{
			if (cb_onBytesTransferred_I == null)
				cb_onBytesTransferred_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnBytesTransferred_I);
			return cb_onBytesTransferred_I;
		}

		static void n_OnBytesTransferred_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Android.Exoplayer.Upstream.IBandwidthMeter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.IBandwidthMeter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBytesTransferred (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBytesTransferred_I;
		public unsafe void OnBytesTransferred (int p0)
		{
			if (id_onBytesTransferred_I == IntPtr.Zero)
				id_onBytesTransferred_I = JNIEnv.GetMethodID (class_ref, "onBytesTransferred", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBytesTransferred_I, __args);
		}

		static Delegate cb_onTransferEnd;
#pragma warning disable 0169
		static Delegate GetOnTransferEndHandler ()
		{
			if (cb_onTransferEnd == null)
				cb_onTransferEnd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnTransferEnd);
			return cb_onTransferEnd;
		}

		static void n_OnTransferEnd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Upstream.IBandwidthMeter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.IBandwidthMeter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTransferEnd ();
		}
#pragma warning restore 0169

		IntPtr id_onTransferEnd;
		public unsafe void OnTransferEnd ()
		{
			if (id_onTransferEnd == IntPtr.Zero)
				id_onTransferEnd = JNIEnv.GetMethodID (class_ref, "onTransferEnd", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTransferEnd);
		}

		static Delegate cb_onTransferStart;
#pragma warning disable 0169
		static Delegate GetOnTransferStartHandler ()
		{
			if (cb_onTransferStart == null)
				cb_onTransferStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnTransferStart);
			return cb_onTransferStart;
		}

		static void n_OnTransferStart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Upstream.IBandwidthMeter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.IBandwidthMeter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTransferStart ();
		}
#pragma warning restore 0169

		IntPtr id_onTransferStart;
		public unsafe void OnTransferStart ()
		{
			if (id_onTransferStart == IntPtr.Zero)
				id_onTransferStart = JNIEnv.GetMethodID (class_ref, "onTransferStart", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTransferStart);
		}

	}

}
