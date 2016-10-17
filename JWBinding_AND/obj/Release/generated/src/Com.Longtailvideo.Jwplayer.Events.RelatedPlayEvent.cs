using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Longtailvideo.Jwplayer.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='RelatedPlayEvent']"
	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/RelatedPlayEvent", DoNotGenerateAcw=true)]
	public partial class RelatedPlayEvent : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/RelatedPlayEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RelatedPlayEvent); }
		}

		protected RelatedPlayEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAuto;
#pragma warning disable 0169
		static Delegate GetGetAutoHandler ()
		{
			if (cb_getAuto == null)
				cb_getAuto = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAuto);
			return cb_getAuto;
		}

		static bool n_GetAuto (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Events.RelatedPlayEvent __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.RelatedPlayEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Auto;
		}
#pragma warning restore 0169

		static IntPtr id_getAuto;
		public virtual unsafe bool Auto {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='RelatedPlayEvent']/method[@name='getAuto' and count(parameter)=0]"
			[Register ("getAuto", "()Z", "GetGetAutoHandler")]
			get {
				if (id_getAuto == IntPtr.Zero)
					id_getAuto = JNIEnv.GetMethodID (class_ref, "getAuto", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getAuto);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuto", "()Z"));
				} finally {
				}
			}
		}

	}
}
