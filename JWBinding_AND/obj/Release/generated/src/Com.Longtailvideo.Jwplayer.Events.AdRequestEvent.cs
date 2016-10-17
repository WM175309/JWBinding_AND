using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Longtailvideo.Jwplayer.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='AdRequestEvent']"
	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/AdRequestEvent", DoNotGenerateAcw=true)]
	public partial class AdRequestEvent : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/AdRequestEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdRequestEvent); }
		}

		protected AdRequestEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_longtailvideo_jwplayer_media_ads_AdPosition_Lcom_longtailvideo_jwplayer_media_ads_AdSource_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='AdRequestEvent']/constructor[@name='AdRequestEvent' and count(parameter)=4 and parameter[1][@type='com.longtailvideo.jwplayer.media.ads.AdPosition'] and parameter[2][@type='com.longtailvideo.jwplayer.media.ads.AdSource'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/longtailvideo/jwplayer/media/ads/AdPosition;Lcom/longtailvideo/jwplayer/media/ads/AdSource;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe AdRequestEvent (global::Com.Longtailvideo.Jwplayer.Media.Ads.AdPosition p0, global::Com.Longtailvideo.Jwplayer.Media.Ads.AdSource p1, string p2, string p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				if (GetType () != typeof (AdRequestEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/longtailvideo/jwplayer/media/ads/AdPosition;Lcom/longtailvideo/jwplayer/media/ads/AdSource;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/longtailvideo/jwplayer/media/ads/AdPosition;Lcom/longtailvideo/jwplayer/media/ads/AdSource;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_longtailvideo_jwplayer_media_ads_AdPosition_Lcom_longtailvideo_jwplayer_media_ads_AdSource_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_longtailvideo_jwplayer_media_ads_AdPosition_Lcom_longtailvideo_jwplayer_media_ads_AdSource_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/longtailvideo/jwplayer/media/ads/AdPosition;Lcom/longtailvideo/jwplayer/media/ads/AdSource;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_longtailvideo_jwplayer_media_ads_AdPosition_Lcom_longtailvideo_jwplayer_media_ads_AdSource_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_longtailvideo_jwplayer_media_ads_AdPosition_Lcom_longtailvideo_jwplayer_media_ads_AdSource_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_getAdPosition;
#pragma warning disable 0169
		static Delegate GetGetAdPositionHandler ()
		{
			if (cb_getAdPosition == null)
				cb_getAdPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdPosition);
			return cb_getAdPosition;
		}

		static IntPtr n_GetAdPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Events.AdRequestEvent __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdRequestEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdPosition);
		}
#pragma warning restore 0169

		static IntPtr id_getAdPosition;
		public virtual unsafe global::Com.Longtailvideo.Jwplayer.Media.Ads.AdPosition AdPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='AdRequestEvent']/method[@name='getAdPosition' and count(parameter)=0]"
			[Register ("getAdPosition", "()Lcom/longtailvideo/jwplayer/media/ads/AdPosition;", "GetGetAdPositionHandler")]
			get {
				if (id_getAdPosition == IntPtr.Zero)
					id_getAdPosition = JNIEnv.GetMethodID (class_ref, "getAdPosition", "()Lcom/longtailvideo/jwplayer/media/ads/AdPosition;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Ads.AdPosition> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdPosition), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Ads.AdPosition> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdPosition", "()Lcom/longtailvideo/jwplayer/media/ads/AdPosition;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClient;
#pragma warning disable 0169
		static Delegate GetGetClientHandler ()
		{
			if (cb_getClient == null)
				cb_getClient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClient);
			return cb_getClient;
		}

		static IntPtr n_GetClient (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Events.AdRequestEvent __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdRequestEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Client);
		}
#pragma warning restore 0169

		static IntPtr id_getClient;
		public virtual unsafe global::Com.Longtailvideo.Jwplayer.Media.Ads.AdSource Client {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='AdRequestEvent']/method[@name='getClient' and count(parameter)=0]"
			[Register ("getClient", "()Lcom/longtailvideo/jwplayer/media/ads/AdSource;", "GetGetClientHandler")]
			get {
				if (id_getClient == IntPtr.Zero)
					id_getClient = JNIEnv.GetMethodID (class_ref, "getClient", "()Lcom/longtailvideo/jwplayer/media/ads/AdSource;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Ads.AdSource> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClient), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Ads.AdSource> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClient", "()Lcom/longtailvideo/jwplayer/media/ads/AdSource;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOffset;
#pragma warning disable 0169
		static Delegate GetGetOffsetHandler ()
		{
			if (cb_getOffset == null)
				cb_getOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOffset);
			return cb_getOffset;
		}

		static IntPtr n_GetOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Events.AdRequestEvent __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdRequestEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Offset);
		}
#pragma warning restore 0169

		static IntPtr id_getOffset;
		public virtual unsafe string Offset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='AdRequestEvent']/method[@name='getOffset' and count(parameter)=0]"
			[Register ("getOffset", "()Ljava/lang/String;", "GetGetOffsetHandler")]
			get {
				if (id_getOffset == IntPtr.Zero)
					id_getOffset = JNIEnv.GetMethodID (class_ref, "getOffset", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOffset), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOffset", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTag;
#pragma warning disable 0169
		static Delegate GetGetTagHandler ()
		{
			if (cb_getTag == null)
				cb_getTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTag);
			return cb_getTag;
		}

		static IntPtr n_GetTag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Events.AdRequestEvent __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdRequestEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Tag);
		}
#pragma warning restore 0169

		static IntPtr id_getTag;
		public virtual unsafe string Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='AdRequestEvent']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()Ljava/lang/String;", "GetGetTagHandler")]
			get {
				if (id_getTag == IntPtr.Zero)
					id_getTag = JNIEnv.GetMethodID (class_ref, "getTag", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTag), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTag", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
