using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Ads.Interactivemedia.V3.Api.Player {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='VideoAdPlayer.VideoAdPlayerCallback']"
	[Register ("com/google/ads/interactivemedia/v3/api/player/VideoAdPlayer$VideoAdPlayerCallback", "", "Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallbackInvoker")]
	public partial interface IVideoAdPlayerVideoAdPlayerCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='VideoAdPlayer.VideoAdPlayerCallback']/method[@name='onEnded' and count(parameter)=0]"
		[Register ("onEnded", "()V", "GetOnEndedHandler:Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallbackInvoker, JWBinding_AND")]
		void OnEnded ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='VideoAdPlayer.VideoAdPlayerCallback']/method[@name='onError' and count(parameter)=0]"
		[Register ("onError", "()V", "GetOnErrorHandler:Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallbackInvoker, JWBinding_AND")]
		void OnError ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='VideoAdPlayer.VideoAdPlayerCallback']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler:Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallbackInvoker, JWBinding_AND")]
		void OnPause ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='VideoAdPlayer.VideoAdPlayerCallback']/method[@name='onPlay' and count(parameter)=0]"
		[Register ("onPlay", "()V", "GetOnPlayHandler:Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallbackInvoker, JWBinding_AND")]
		void OnPlay ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='VideoAdPlayer.VideoAdPlayerCallback']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler:Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallbackInvoker, JWBinding_AND")]
		void OnResume ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='VideoAdPlayer.VideoAdPlayerCallback']/method[@name='onVolumeChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onVolumeChanged", "(I)V", "GetOnVolumeChanged_IHandler:Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallbackInvoker, JWBinding_AND")]
		void OnVolumeChanged (int p0);

	}

	[global::Android.Runtime.Register ("com/google/ads/interactivemedia/v3/api/player/VideoAdPlayer$VideoAdPlayerCallback", DoNotGenerateAcw=true)]
	internal class IVideoAdPlayerVideoAdPlayerCallbackInvoker : global::Java.Lang.Object, IVideoAdPlayerVideoAdPlayerCallback {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/ads/interactivemedia/v3/api/player/VideoAdPlayer$VideoAdPlayerCallback");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoAdPlayerVideoAdPlayerCallbackInvoker); }
		}

		IntPtr class_ref;

		public static IVideoAdPlayerVideoAdPlayerCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoAdPlayerVideoAdPlayerCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.ads.interactivemedia.v3.api.player.VideoAdPlayer.VideoAdPlayerCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoAdPlayerVideoAdPlayerCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onEnded;
#pragma warning disable 0169
		static Delegate GetOnEndedHandler ()
		{
			if (cb_onEnded == null)
				cb_onEnded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnEnded);
			return cb_onEnded;
		}

		static void n_OnEnded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnEnded ();
		}
#pragma warning restore 0169

		IntPtr id_onEnded;
		public unsafe void OnEnded ()
		{
			if (id_onEnded == IntPtr.Zero)
				id_onEnded = JNIEnv.GetMethodID (class_ref, "onEnded", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEnded);
		}

		static Delegate cb_onError;
#pragma warning disable 0169
		static Delegate GetOnErrorHandler ()
		{
			if (cb_onError == null)
				cb_onError = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnError);
			return cb_onError;
		}

		static void n_OnError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnError ();
		}
#pragma warning restore 0169

		IntPtr id_onError;
		public unsafe void OnError ()
		{
			if (id_onError == IntPtr.Zero)
				id_onError = JNIEnv.GetMethodID (class_ref, "onError", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError);
		}

		static Delegate cb_onPause;
#pragma warning disable 0169
		static Delegate GetOnPauseHandler ()
		{
			if (cb_onPause == null)
				cb_onPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPause);
			return cb_onPause;
		}

		static void n_OnPause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		IntPtr id_onPause;
		public unsafe void OnPause ()
		{
			if (id_onPause == IntPtr.Zero)
				id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPause);
		}

		static Delegate cb_onPlay;
#pragma warning disable 0169
		static Delegate GetOnPlayHandler ()
		{
			if (cb_onPlay == null)
				cb_onPlay = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPlay);
			return cb_onPlay;
		}

		static void n_OnPlay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPlay ();
		}
#pragma warning restore 0169

		IntPtr id_onPlay;
		public unsafe void OnPlay ()
		{
			if (id_onPlay == IntPtr.Zero)
				id_onPlay = JNIEnv.GetMethodID (class_ref, "onPlay", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPlay);
		}

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		IntPtr id_onResume;
		public unsafe void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResume);
		}

		static Delegate cb_onVolumeChanged_I;
#pragma warning disable 0169
		static Delegate GetOnVolumeChanged_IHandler ()
		{
			if (cb_onVolumeChanged_I == null)
				cb_onVolumeChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnVolumeChanged_I);
			return cb_onVolumeChanged_I;
		}

		static void n_OnVolumeChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallback __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnVolumeChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onVolumeChanged_I;
		public unsafe void OnVolumeChanged (int p0)
		{
			if (id_onVolumeChanged_I == IntPtr.Zero)
				id_onVolumeChanged_I = JNIEnv.GetMethodID (class_ref, "onVolumeChanged", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVolumeChanged_I, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='VideoAdPlayer']"
	[Register ("com/google/ads/interactivemedia/v3/api/player/VideoAdPlayer", "", "Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerInvoker")]
	public partial interface IVideoAdPlayer : global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IAdProgressProvider {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='VideoAdPlayer']/method[@name='addCallback' and count(parameter)=1 and parameter[1][@type='com.google.ads.interactivemedia.v3.api.player.VideoAdPlayer.VideoAdPlayerCallback']]"
		[Register ("addCallback", "(Lcom/google/ads/interactivemedia/v3/api/player/VideoAdPlayer$VideoAdPlayerCallback;)V", "GetAddCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_Handler:Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerInvoker, JWBinding_AND")]
		void AddCallback (global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='VideoAdPlayer']/method[@name='loadAd' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadAd", "(Ljava/lang/String;)V", "GetLoadAd_Ljava_lang_String_Handler:Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerInvoker, JWBinding_AND")]
		void LoadAd (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='VideoAdPlayer']/method[@name='pauseAd' and count(parameter)=0]"
		[Register ("pauseAd", "()V", "GetPauseAdHandler:Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerInvoker, JWBinding_AND")]
		void PauseAd ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='VideoAdPlayer']/method[@name='playAd' and count(parameter)=0]"
		[Register ("playAd", "()V", "GetPlayAdHandler:Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerInvoker, JWBinding_AND")]
		void PlayAd ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='VideoAdPlayer']/method[@name='removeCallback' and count(parameter)=1 and parameter[1][@type='com.google.ads.interactivemedia.v3.api.player.VideoAdPlayer.VideoAdPlayerCallback']]"
		[Register ("removeCallback", "(Lcom/google/ads/interactivemedia/v3/api/player/VideoAdPlayer$VideoAdPlayerCallback;)V", "GetRemoveCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_Handler:Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerInvoker, JWBinding_AND")]
		void RemoveCallback (global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallback p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='VideoAdPlayer']/method[@name='resumeAd' and count(parameter)=0]"
		[Register ("resumeAd", "()V", "GetResumeAdHandler:Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerInvoker, JWBinding_AND")]
		void ResumeAd ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='VideoAdPlayer']/method[@name='stopAd' and count(parameter)=0]"
		[Register ("stopAd", "()V", "GetStopAdHandler:Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerInvoker, JWBinding_AND")]
		void StopAd ();

	}

	[global::Android.Runtime.Register ("com/google/ads/interactivemedia/v3/api/player/VideoAdPlayer", DoNotGenerateAcw=true)]
	internal class IVideoAdPlayerInvoker : global::Java.Lang.Object, IVideoAdPlayer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/ads/interactivemedia/v3/api/player/VideoAdPlayer");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoAdPlayerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoAdPlayer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoAdPlayer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.ads.interactivemedia.v3.api.player.VideoAdPlayer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoAdPlayerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_addCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_;
#pragma warning disable 0169
		static Delegate GetAddCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_Handler ()
		{
			if (cb_addCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_ == null)
				cb_addCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_);
			return cb_addCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_;
		}

		static void n_AddCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallback p0 = (global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallback)global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_addCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_;
		public unsafe void AddCallback (global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallback p0)
		{
			if (id_addCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_ == IntPtr.Zero)
				id_addCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_ = JNIEnv.GetMethodID (class_ref, "addCallback", "(Lcom/google/ads/interactivemedia/v3/api/player/VideoAdPlayer$VideoAdPlayerCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_, __args);
		}

		static Delegate cb_loadAd_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLoadAd_Ljava_lang_String_Handler ()
		{
			if (cb_loadAd_Ljava_lang_String_ == null)
				cb_loadAd_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_LoadAd_Ljava_lang_String_);
			return cb_loadAd_Ljava_lang_String_;
		}

		static void n_LoadAd_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LoadAd (p0);
		}
#pragma warning restore 0169

		IntPtr id_loadAd_Ljava_lang_String_;
		public unsafe void LoadAd (string p0)
		{
			if (id_loadAd_Ljava_lang_String_ == IntPtr.Zero)
				id_loadAd_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "loadAd", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_loadAd_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_pauseAd;
#pragma warning disable 0169
		static Delegate GetPauseAdHandler ()
		{
			if (cb_pauseAd == null)
				cb_pauseAd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PauseAd);
			return cb_pauseAd;
		}

		static void n_PauseAd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseAd ();
		}
#pragma warning restore 0169

		IntPtr id_pauseAd;
		public unsafe void PauseAd ()
		{
			if (id_pauseAd == IntPtr.Zero)
				id_pauseAd = JNIEnv.GetMethodID (class_ref, "pauseAd", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pauseAd);
		}

		static Delegate cb_playAd;
#pragma warning disable 0169
		static Delegate GetPlayAdHandler ()
		{
			if (cb_playAd == null)
				cb_playAd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PlayAd);
			return cb_playAd;
		}

		static void n_PlayAd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PlayAd ();
		}
#pragma warning restore 0169

		IntPtr id_playAd;
		public unsafe void PlayAd ()
		{
			if (id_playAd == IntPtr.Zero)
				id_playAd = JNIEnv.GetMethodID (class_ref, "playAd", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_playAd);
		}

		static Delegate cb_removeCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_;
#pragma warning disable 0169
		static Delegate GetRemoveCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_Handler ()
		{
			if (cb_removeCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_ == null)
				cb_removeCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_);
			return cb_removeCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_;
		}

		static void n_RemoveCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallback p0 = (global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallback)global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveCallback (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_;
		public unsafe void RemoveCallback (global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayerVideoAdPlayerCallback p0)
		{
			if (id_removeCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_ == IntPtr.Zero)
				id_removeCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_ = JNIEnv.GetMethodID (class_ref, "removeCallback", "(Lcom/google/ads/interactivemedia/v3/api/player/VideoAdPlayer$VideoAdPlayerCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeCallback_Lcom_google_ads_interactivemedia_v3_api_player_VideoAdPlayer_VideoAdPlayerCallback_, __args);
		}

		static Delegate cb_resumeAd;
#pragma warning disable 0169
		static Delegate GetResumeAdHandler ()
		{
			if (cb_resumeAd == null)
				cb_resumeAd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResumeAd);
			return cb_resumeAd;
		}

		static void n_ResumeAd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResumeAd ();
		}
#pragma warning restore 0169

		IntPtr id_resumeAd;
		public unsafe void ResumeAd ()
		{
			if (id_resumeAd == IntPtr.Zero)
				id_resumeAd = JNIEnv.GetMethodID (class_ref, "resumeAd", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resumeAd);
		}

		static Delegate cb_stopAd;
#pragma warning disable 0169
		static Delegate GetStopAdHandler ()
		{
			if (cb_stopAd == null)
				cb_stopAd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopAd);
			return cb_stopAd;
		}

		static void n_StopAd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAd ();
		}
#pragma warning restore 0169

		IntPtr id_stopAd;
		public unsafe void StopAd ()
		{
			if (id_stopAd == IntPtr.Zero)
				id_stopAd = JNIEnv.GetMethodID (class_ref, "stopAd", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopAd);
		}

		static Delegate cb_getAdProgress;
#pragma warning disable 0169
		static Delegate GetGetAdProgressHandler ()
		{
			if (cb_getAdProgress == null)
				cb_getAdProgress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdProgress);
			return cb_getAdProgress;
		}

		static IntPtr n_GetAdProgress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IVideoAdPlayer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdProgress);
		}
#pragma warning restore 0169

		IntPtr id_getAdProgress;
		public unsafe global::Com.Google.Ads.Interactivemedia.V3.Api.Player.VideoProgressUpdate AdProgress {
			get {
				if (id_getAdProgress == IntPtr.Zero)
					id_getAdProgress = JNIEnv.GetMethodID (class_ref, "getAdProgress", "()Lcom/google/ads/interactivemedia/v3/api/player/VideoProgressUpdate;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.VideoProgressUpdate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdProgress), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
