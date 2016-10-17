using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Ads.Interactivemedia.V3.Api.Player {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='VideoStreamPlayer.VideoStreamPlayerCallback']"
	[Register ("com/google/ads/interactivemedia/v3/api/player/VideoStreamPlayer$VideoStreamPlayerCallback", "", "Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayerVideoStreamPlayerCallbackInvoker")]
	public partial interface IVideoStreamPlayerVideoStreamPlayerCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='VideoStreamPlayer.VideoStreamPlayerCallback']/method[@name='onUserTextReceived' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onUserTextReceived", "(Ljava/lang/String;)V", "GetOnUserTextReceived_Ljava_lang_String_Handler:Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayerVideoStreamPlayerCallbackInvoker, JWBinding_AND")]
		void OnUserTextReceived (string p0);

	}

	[global::Android.Runtime.Register ("com/google/ads/interactivemedia/v3/api/player/VideoStreamPlayer$VideoStreamPlayerCallback", DoNotGenerateAcw=true)]
	internal class IVideoStreamPlayerVideoStreamPlayerCallbackInvoker : global::Java.Lang.Object, IVideoStreamPlayerVideoStreamPlayerCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/ads/interactivemedia/v3/api/player/VideoStreamPlayer$VideoStreamPlayerCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoStreamPlayerVideoStreamPlayerCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IVideoStreamPlayerVideoStreamPlayerCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoStreamPlayerVideoStreamPlayerCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.ads.interactivemedia.v3.api.player.VideoStreamPlayer.VideoStreamPlayerCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoStreamPlayerVideoStreamPlayerCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onUserTextReceived_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnUserTextReceived_Ljava_lang_String_Handler ()
		{
			if (cb_onUserTextReceived_Ljava_lang_String_ == null)
				cb_onUserTextReceived_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUserTextReceived_Ljava_lang_String_);
			return cb_onUserTextReceived_Ljava_lang_String_;
		}

		static void n_OnUserTextReceived_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayerVideoStreamPlayerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayerVideoStreamPlayerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUserTextReceived (p0);
		}
#pragma warning restore 0169

		IntPtr id_onUserTextReceived_Ljava_lang_String_;
		public unsafe void OnUserTextReceived (string p0)
		{
			if (id_onUserTextReceived_Ljava_lang_String_ == IntPtr.Zero)
				id_onUserTextReceived_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onUserTextReceived", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUserTextReceived_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='VideoStreamPlayer']"
	[Register ("com/google/ads/interactivemedia/v3/api/player/VideoStreamPlayer", "", "Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayerInvoker")]
	public partial interface IVideoStreamPlayer : global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IContentProgressProvider {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='VideoStreamPlayer']/method[@name='addCallback' and count(parameter)=1 and parameter[1][@type='com.google.ads.interactivemedia.v3.api.player.VideoStreamPlayer.VideoStreamPlayerCallback']]"
		[Register ("addCallback", "(Lcom/google/ads/interactivemedia/v3/api/player/VideoStreamPlayer$VideoStreamPlayerCallback;)V", "GetAddCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_Handler:Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayerInvoker, JWBinding_AND")]
		void AddCallback (global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayerVideoStreamPlayerCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='VideoStreamPlayer']/method[@name='loadUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadUrl", "(Ljava/lang/String;)V", "GetLoadUrl_Ljava_lang_String_Handler:Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayerInvoker, JWBinding_AND")]
		void LoadUrl (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='VideoStreamPlayer']/method[@name='onAdBreakEnded' and count(parameter)=0]"
		[Register ("onAdBreakEnded", "()V", "GetOnAdBreakEndedHandler:Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayerInvoker, JWBinding_AND")]
		void OnAdBreakEnded ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='VideoStreamPlayer']/method[@name='onAdBreakStarted' and count(parameter)=0]"
		[Register ("onAdBreakStarted", "()V", "GetOnAdBreakStartedHandler:Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayerInvoker, JWBinding_AND")]
		void OnAdBreakStarted ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='VideoStreamPlayer']/method[@name='removeCallback' and count(parameter)=1 and parameter[1][@type='com.google.ads.interactivemedia.v3.api.player.VideoStreamPlayer.VideoStreamPlayerCallback']]"
		[Register ("removeCallback", "(Lcom/google/ads/interactivemedia/v3/api/player/VideoStreamPlayer$VideoStreamPlayerCallback;)V", "GetRemoveCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_Handler:Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayerInvoker, JWBinding_AND")]
		void RemoveCallback (global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayerVideoStreamPlayerCallback p0);

	}

	[global::Android.Runtime.Register ("com/google/ads/interactivemedia/v3/api/player/VideoStreamPlayer", DoNotGenerateAcw=true)]
	internal class IVideoStreamPlayerInvoker : global::Java.Lang.Object, IVideoStreamPlayer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/ads/interactivemedia/v3/api/player/VideoStreamPlayer");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoStreamPlayerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoStreamPlayer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoStreamPlayer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.ads.interactivemedia.v3.api.player.VideoStreamPlayer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoStreamPlayerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_addCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_;
#pragma warning disable 0169
		static Delegate GetAddCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_Handler ()
		{
			if (cb_addCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_ == null)
				cb_addCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_);
			return cb_addCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_;
		}

		static void n_AddCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayerVideoStreamPlayerCallback p0 = (global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayerVideoStreamPlayerCallback)global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayerVideoStreamPlayerCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_addCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_;
		public unsafe void AddCallback (global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayerVideoStreamPlayerCallback p0)
		{
			if (id_addCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_ == IntPtr.Zero)
				id_addCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_ = JNIEnv.GetMethodID (class_ref, "addCallback", "(Lcom/google/ads/interactivemedia/v3/api/player/VideoStreamPlayer$VideoStreamPlayerCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_, __args);
		}

		static Delegate cb_loadUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadUrl_Ljava_lang_String_Handler ()
		{
			if (cb_loadUrl_Ljava_lang_String_ == null)
				cb_loadUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadUrl_Ljava_lang_String_);
			return cb_loadUrl_Ljava_lang_String_;
		}

		static void n_LoadUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadUrl (p0);
		}
#pragma warning restore 0169

		IntPtr id_loadUrl_Ljava_lang_String_;
		public unsafe void LoadUrl (string p0)
		{
			if (id_loadUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_loadUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadUrl", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadUrl_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onAdBreakEnded;
#pragma warning disable 0169
		static Delegate GetOnAdBreakEndedHandler ()
		{
			if (cb_onAdBreakEnded == null)
				cb_onAdBreakEnded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAdBreakEnded);
			return cb_onAdBreakEnded;
		}

		static void n_OnAdBreakEnded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAdBreakEnded ();
		}
#pragma warning restore 0169

		IntPtr id_onAdBreakEnded;
		public unsafe void OnAdBreakEnded ()
		{
			if (id_onAdBreakEnded == IntPtr.Zero)
				id_onAdBreakEnded = JNIEnv.GetMethodID (class_ref, "onAdBreakEnded", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdBreakEnded);
		}

		static Delegate cb_onAdBreakStarted;
#pragma warning disable 0169
		static Delegate GetOnAdBreakStartedHandler ()
		{
			if (cb_onAdBreakStarted == null)
				cb_onAdBreakStarted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAdBreakStarted);
			return cb_onAdBreakStarted;
		}

		static void n_OnAdBreakStarted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAdBreakStarted ();
		}
#pragma warning restore 0169

		IntPtr id_onAdBreakStarted;
		public unsafe void OnAdBreakStarted ()
		{
			if (id_onAdBreakStarted == IntPtr.Zero)
				id_onAdBreakStarted = JNIEnv.GetMethodID (class_ref, "onAdBreakStarted", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdBreakStarted);
		}

		static Delegate cb_removeCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_;
#pragma warning disable 0169
		static Delegate GetRemoveCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_Handler ()
		{
			if (cb_removeCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_ == null)
				cb_removeCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_);
			return cb_removeCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_;
		}

		static void n_RemoveCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayerVideoStreamPlayerCallback p0 = (global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayerVideoStreamPlayerCallback)global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayerVideoStreamPlayerCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_;
		public unsafe void RemoveCallback (global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayerVideoStreamPlayerCallback p0)
		{
			if (id_removeCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_ == IntPtr.Zero)
				id_removeCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_ = JNIEnv.GetMethodID (class_ref, "removeCallback", "(Lcom/google/ads/interactivemedia/v3/api/player/VideoStreamPlayer$VideoStreamPlayerCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoStreamPlayer_VideoStreamPlayerCallback_, __args);
		}

		static Delegate cb_getContentProgress;
#pragma warning disable 0169
		static Delegate GetGetContentProgressHandler ()
		{
			if (cb_getContentProgress == null)
				cb_getContentProgress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentProgress);
			return cb_getContentProgress;
		}

		static IntPtr n_GetContentProgress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoStreamPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentProgress);
		}
#pragma warning restore 0169

		IntPtr id_getContentProgress;
		public unsafe global::Com.Google.Ads.Interactivemedia.V3.Api.Player.VideoProgressUpdate ContentProgress {
			get {
				if (id_getContentProgress == IntPtr.Zero)
					id_getContentProgress = JNIEnv.GetMethodID (class_ref, "getContentProgress", "()Lcom/google/ads/interactivemedia/v3/api/player/VideoProgressUpdate;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.VideoProgressUpdate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentProgress), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
