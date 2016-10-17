using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Longtailvideo.Jwplayer.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='BufferChangeEvent']"
	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/BufferChangeEvent", DoNotGenerateAcw=true)]
	public partial class BufferChangeEvent : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/BufferChangeEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BufferChangeEvent); }
		}

		protected BufferChangeEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IJJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='BufferChangeEvent']/constructor[@name='BufferChangeEvent' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register (".ctor", "(IJJ)V", "")]
		public unsafe BufferChangeEvent (int p0, long p1, long p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (BufferChangeEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IJJ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IJJ)V", __args);
					return;
				}

				if (id_ctor_IJJ == IntPtr.Zero)
					id_ctor_IJJ = JNIEnv.GetMethodID (class_ref, "<init>", "(IJJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IJJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IJJ, __args);
			} finally {
			}
		}

		static Delegate cb_getBufferPercent;
#pragma warning disable 0169
		static Delegate GetGetBufferPercentHandler ()
		{
			if (cb_getBufferPercent == null)
				cb_getBufferPercent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBufferPercent);
			return cb_getBufferPercent;
		}

		static int n_GetBufferPercent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Events.BufferChangeEvent __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.BufferChangeEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BufferPercent;
		}
#pragma warning restore 0169

		static IntPtr id_getBufferPercent;
		public virtual unsafe int BufferPercent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='BufferChangeEvent']/method[@name='getBufferPercent' and count(parameter)=0]"
			[Register ("getBufferPercent", "()I", "GetGetBufferPercentHandler")]
			get {
				if (id_getBufferPercent == IntPtr.Zero)
					id_getBufferPercent = JNIEnv.GetMethodID (class_ref, "getBufferPercent", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBufferPercent);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBufferPercent", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDuration);
			return cb_getDuration;
		}

		static long n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Events.BufferChangeEvent __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.BufferChangeEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		static IntPtr id_getDuration;
		public virtual unsafe long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='BufferChangeEvent']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()J", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDuration);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDuration", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetPosition);
			return cb_getPosition;
		}

		static long n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Events.BufferChangeEvent __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.BufferChangeEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Position;
		}
#pragma warning restore 0169

		static IntPtr id_getPosition;
		public virtual unsafe long Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='BufferChangeEvent']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()J", "GetGetPositionHandler")]
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPosition);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPosition", "()J"));
				} finally {
				}
			}
		}

	}
}
