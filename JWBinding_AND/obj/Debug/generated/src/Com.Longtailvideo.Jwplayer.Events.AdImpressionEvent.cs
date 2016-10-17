using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Longtailvideo.Jwplayer.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='AdImpressionEvent']"
	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/AdImpressionEvent", DoNotGenerateAcw=true)]
	public partial class AdImpressionEvent : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/AdImpressionEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdImpressionEvent); }
		}

		protected AdImpressionEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Longtailvideo.Jwplayer.Events.AdImpressionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdImpressionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdPosition);
		}
#pragma warning restore 0169

		static IntPtr id_getAdPosition;
		public virtual unsafe global::Com.Longtailvideo.Jwplayer.Media.Ads.AdPosition AdPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='AdImpressionEvent']/method[@name='getAdPosition' and count(parameter)=0]"
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

		static Delegate cb_getAdSystem;
#pragma warning disable 0169
		static Delegate GetGetAdSystemHandler ()
		{
			if (cb_getAdSystem == null)
				cb_getAdSystem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdSystem);
			return cb_getAdSystem;
		}

		static IntPtr n_GetAdSystem (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Events.AdImpressionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdImpressionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdSystem);
		}
#pragma warning restore 0169

		static IntPtr id_getAdSystem;
		public virtual unsafe string AdSystem {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='AdImpressionEvent']/method[@name='getAdSystem' and count(parameter)=0]"
			[Register ("getAdSystem", "()Ljava/lang/String;", "GetGetAdSystemHandler")]
			get {
				if (id_getAdSystem == IntPtr.Zero)
					id_getAdSystem = JNIEnv.GetMethodID (class_ref, "getAdSystem", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdSystem), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdSystem", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdTitle;
#pragma warning disable 0169
		static Delegate GetGetAdTitleHandler ()
		{
			if (cb_getAdTitle == null)
				cb_getAdTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdTitle);
			return cb_getAdTitle;
		}

		static IntPtr n_GetAdTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Events.AdImpressionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdImpressionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdTitle);
		}
#pragma warning restore 0169

		static IntPtr id_getAdTitle;
		public virtual unsafe string AdTitle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='AdImpressionEvent']/method[@name='getAdTitle' and count(parameter)=0]"
			[Register ("getAdTitle", "()Ljava/lang/String;", "GetGetAdTitleHandler")]
			get {
				if (id_getAdTitle == IntPtr.Zero)
					id_getAdTitle = JNIEnv.GetMethodID (class_ref, "getAdTitle", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdTitle), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdTitle", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Longtailvideo.Jwplayer.Events.AdImpressionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdImpressionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Client);
		}
#pragma warning restore 0169

		static IntPtr id_getClient;
		public virtual unsafe global::Com.Longtailvideo.Jwplayer.Media.Ads.AdSource Client {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='AdImpressionEvent']/method[@name='getClient' and count(parameter)=0]"
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

		static Delegate cb_getCreativeType;
#pragma warning disable 0169
		static Delegate GetGetCreativeTypeHandler ()
		{
			if (cb_getCreativeType == null)
				cb_getCreativeType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreativeType);
			return cb_getCreativeType;
		}

		static IntPtr n_GetCreativeType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Events.AdImpressionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdImpressionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreativeType);
		}
#pragma warning restore 0169

		static IntPtr id_getCreativeType;
		public virtual unsafe string CreativeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='AdImpressionEvent']/method[@name='getCreativeType' and count(parameter)=0]"
			[Register ("getCreativeType", "()Ljava/lang/String;", "GetGetCreativeTypeHandler")]
			get {
				if (id_getCreativeType == IntPtr.Zero)
					id_getCreativeType = JNIEnv.GetMethodID (class_ref, "getCreativeType", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCreativeType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreativeType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLinear;
#pragma warning disable 0169
		static Delegate GetGetLinearHandler ()
		{
			if (cb_getLinear == null)
				cb_getLinear = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLinear);
			return cb_getLinear;
		}

		static IntPtr n_GetLinear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Events.AdImpressionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdImpressionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Linear);
		}
#pragma warning restore 0169

		static IntPtr id_getLinear;
		public virtual unsafe string Linear {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='AdImpressionEvent']/method[@name='getLinear' and count(parameter)=0]"
			[Register ("getLinear", "()Ljava/lang/String;", "GetGetLinearHandler")]
			get {
				if (id_getLinear == IntPtr.Zero)
					id_getLinear = JNIEnv.GetMethodID (class_ref, "getLinear", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLinear), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLinear", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Longtailvideo.Jwplayer.Events.AdImpressionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdImpressionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Tag);
		}
#pragma warning restore 0169

		static IntPtr id_getTag;
		public virtual unsafe string Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='AdImpressionEvent']/method[@name='getTag' and count(parameter)=0]"
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

		static Delegate cb_getVastVersion;
#pragma warning disable 0169
		static Delegate GetGetVastVersionHandler ()
		{
			if (cb_getVastVersion == null)
				cb_getVastVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVastVersion);
			return cb_getVastVersion;
		}

		static IntPtr n_GetVastVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Events.AdImpressionEvent __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdImpressionEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VastVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getVastVersion;
		public virtual unsafe string VastVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='AdImpressionEvent']/method[@name='getVastVersion' and count(parameter)=0]"
			[Register ("getVastVersion", "()Ljava/lang/String;", "GetGetVastVersionHandler")]
			get {
				if (id_getVastVersion == IntPtr.Zero)
					id_getVastVersion = JNIEnv.GetMethodID (class_ref, "getVastVersion", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVastVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVastVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
