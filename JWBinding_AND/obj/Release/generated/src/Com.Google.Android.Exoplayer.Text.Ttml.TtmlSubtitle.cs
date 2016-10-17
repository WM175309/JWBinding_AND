using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Text.Ttml {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.text.ttml']/class[@name='TtmlSubtitle']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/text/ttml/TtmlSubtitle", DoNotGenerateAcw=true)]
	public sealed partial class TtmlSubtitle : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/text/ttml/TtmlSubtitle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TtmlSubtitle); }
		}

		internal TtmlSubtitle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getEventTimeCount;
		public unsafe int EventTimeCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.text.ttml']/class[@name='TtmlSubtitle']/method[@name='getEventTimeCount' and count(parameter)=0]"
			[Register ("getEventTimeCount", "()I", "GetGetEventTimeCountHandler")]
			get {
				if (id_getEventTimeCount == IntPtr.Zero)
					id_getEventTimeCount = JNIEnv.GetMethodID (class_ref, "getEventTimeCount", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEventTimeCount);
				} finally {
				}
			}
		}

		static IntPtr id_getLastEventTime;
		public unsafe long LastEventTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.text.ttml']/class[@name='TtmlSubtitle']/method[@name='getLastEventTime' and count(parameter)=0]"
			[Register ("getLastEventTime", "()J", "GetGetLastEventTimeHandler")]
			get {
				if (id_getLastEventTime == IntPtr.Zero)
					id_getLastEventTime = JNIEnv.GetMethodID (class_ref, "getLastEventTime", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLastEventTime);
				} finally {
				}
			}
		}

		static IntPtr id_getEventTime_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.text.ttml']/class[@name='TtmlSubtitle']/method[@name='getEventTime' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getEventTime", "(I)J", "")]
		public unsafe long GetEventTime (int p0)
		{
			if (id_getEventTime_I == IntPtr.Zero)
				id_getEventTime_I = JNIEnv.GetMethodID (class_ref, "getEventTime", "(I)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getEventTime_I, __args);
			} finally {
			}
		}

		static IntPtr id_getNextEventTimeIndex_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.text.ttml']/class[@name='TtmlSubtitle']/method[@name='getNextEventTimeIndex' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getNextEventTimeIndex", "(J)I", "")]
		public unsafe int GetNextEventTimeIndex (long p0)
		{
			if (id_getNextEventTimeIndex_J == IntPtr.Zero)
				id_getNextEventTimeIndex_J = JNIEnv.GetMethodID (class_ref, "getNextEventTimeIndex", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNextEventTimeIndex_J, __args);
			} finally {
			}
		}

	}
}
