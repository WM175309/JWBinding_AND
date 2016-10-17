using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Ads.Interactivemedia.V3.Api.Player {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/class[@name='VideoProgressUpdate']"
	[global::Android.Runtime.Register ("com/google/ads/interactivemedia/v3/api/player/VideoProgressUpdate", DoNotGenerateAcw=true)]
	public sealed partial class VideoProgressUpdate : global::Java.Lang.Object {


		static IntPtr VIDEO_TIME_NOT_READY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/class[@name='VideoProgressUpdate']/field[@name='VIDEO_TIME_NOT_READY']"
		[Register ("VIDEO_TIME_NOT_READY")]
		public static global::Com.Google.Ads.Interactivemedia.V3.Api.Player.VideoProgressUpdate VideoTimeNotReady {
			get {
				if (VIDEO_TIME_NOT_READY_jfieldId == IntPtr.Zero)
					VIDEO_TIME_NOT_READY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VIDEO_TIME_NOT_READY", "Lcom/google/ads/interactivemedia/v3/api/player/VideoProgressUpdate;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VIDEO_TIME_NOT_READY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.VideoProgressUpdate> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/ads/interactivemedia/v3/api/player/VideoProgressUpdate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VideoProgressUpdate); }
		}

		internal VideoProgressUpdate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/class[@name='VideoProgressUpdate']/constructor[@name='VideoProgressUpdate' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register (".ctor", "(JJ)V", "")]
		public unsafe VideoProgressUpdate (long p0, long p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (VideoProgressUpdate)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(JJ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(JJ)V", __args);
					return;
				}

				if (id_ctor_JJ == IntPtr.Zero)
					id_ctor_JJ = JNIEnv.GetMethodID (class_ref, "<init>", "(JJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_JJ, __args);
			} finally {
			}
		}

		static IntPtr id_getCurrentTime;
		public unsafe float CurrentTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/class[@name='VideoProgressUpdate']/method[@name='getCurrentTime' and count(parameter)=0]"
			[Register ("getCurrentTime", "()F", "GetGetCurrentTimeHandler")]
			get {
				if (id_getCurrentTime == IntPtr.Zero)
					id_getCurrentTime = JNIEnv.GetMethodID (class_ref, "getCurrentTime", "()F");
				try {
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentTime);
				} finally {
				}
			}
		}

		static IntPtr id_getDuration;
		public unsafe float Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/class[@name='VideoProgressUpdate']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()F", "GetGetDurationHandler")]
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()F");
				try {
					return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getDuration);
				} finally {
				}
			}
		}

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/class[@name='VideoProgressUpdate']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "")]
		public override sealed unsafe bool Equals (global::Java.Lang.Object p0)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hashCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/class[@name='VideoProgressUpdate']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "")]
		public override sealed unsafe int GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			} finally {
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/class[@name='VideoProgressUpdate']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
