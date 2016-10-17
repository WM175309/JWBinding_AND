using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Longtailvideo.Jwplayer.Events.Listeners {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnAudioTrackChangeListener']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnAudioTrackChangeListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnAudioTrackChangeListenerInvoker")]
	public partial interface IVideoPlayerEventsOnAudioTrackChangeListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnAudioTrackChangeListener']/method[@name='onAudioTrackChange' and count(parameter)=1 and parameter[1][@type='int']]"
[Obsolete (@"deprecated")]
		[Register ("onAudioTrackChange", "(I)V", "GetOnAudioTrackChange_IHandler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnAudioTrackChangeListenerInvoker, JWBinding_AND")]
		void OnAudioTrackChange (int p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnAudioTrackChangeListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnAudioTrackChangeListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnAudioTrackChangeListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnAudioTrackChangeListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnAudioTrackChangeListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnAudioTrackChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnAudioTrackChangeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnAudioTrackChangeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnAudioTrackChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAudioTrackChange_I;
#pragma warning disable 0169
		static Delegate GetOnAudioTrackChange_IHandler ()
		{
			if (cb_onAudioTrackChange_I == null)
				cb_onAudioTrackChange_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnAudioTrackChange_I);
			return cb_onAudioTrackChange_I;
		}

		static void n_OnAudioTrackChange_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnAudioTrackChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnAudioTrackChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAudioTrackChange (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAudioTrackChange_I;
		public unsafe void OnAudioTrackChange (int p0)
		{
			if (id_onAudioTrackChange_I == IntPtr.Zero)
				id_onAudioTrackChange_I = JNIEnv.GetMethodID (class_ref, "onAudioTrackChange", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAudioTrackChange_I, __args);
		}

	}

	public partial class VideoPlayerEventsOnAudioTrackChangeEventArgs : global::System.EventArgs {

		public VideoPlayerEventsOnAudioTrackChangeEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnAudioTrackChangeListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnAudioTrackChangeListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnAudioTrackChangeListener {

		object sender;

		public IVideoPlayerEventsOnAudioTrackChangeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnAudioTrackChangeListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<VideoPlayerEventsOnAudioTrackChangeEventArgs> Handler;
#pragma warning restore 0649

		public void OnAudioTrackChange (int p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new VideoPlayerEventsOnAudioTrackChangeEventArgs (p0));
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnAudioTrackChangeListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnAudioTrackChangedListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnAudioTrackChangedListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnAudioTrackChangedListenerInvoker")]
	public partial interface IVideoPlayerEventsOnAudioTrackChangedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnAudioTrackChangedListener']/method[@name='onAudioTrackChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onAudioTrackChanged", "(I)V", "GetOnAudioTrackChanged_IHandler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnAudioTrackChangedListenerInvoker, JWBinding_AND")]
		void OnAudioTrackChanged (int p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnAudioTrackChangedListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnAudioTrackChangedListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnAudioTrackChangedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnAudioTrackChangedListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnAudioTrackChangedListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnAudioTrackChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnAudioTrackChangedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnAudioTrackChangedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnAudioTrackChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAudioTrackChanged_I;
#pragma warning disable 0169
		static Delegate GetOnAudioTrackChanged_IHandler ()
		{
			if (cb_onAudioTrackChanged_I == null)
				cb_onAudioTrackChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnAudioTrackChanged_I);
			return cb_onAudioTrackChanged_I;
		}

		static void n_OnAudioTrackChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnAudioTrackChangedListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnAudioTrackChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnAudioTrackChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAudioTrackChanged_I;
		public unsafe void OnAudioTrackChanged (int p0)
		{
			if (id_onAudioTrackChanged_I == IntPtr.Zero)
				id_onAudioTrackChanged_I = JNIEnv.GetMethodID (class_ref, "onAudioTrackChanged", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAudioTrackChanged_I, __args);
		}

	}

	public partial class VideoPlayerEventsOnAudioTrackChangedEventArgs : global::System.EventArgs {

		public VideoPlayerEventsOnAudioTrackChangedEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnAudioTrackChangedListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnAudioTrackChangedListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnAudioTrackChangedListener {

		object sender;

		public IVideoPlayerEventsOnAudioTrackChangedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnAudioTrackChangedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<VideoPlayerEventsOnAudioTrackChangedEventArgs> Handler;
#pragma warning restore 0649

		public void OnAudioTrackChanged (int p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new VideoPlayerEventsOnAudioTrackChangedEventArgs (p0));
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnAudioTrackChangedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnBufferChangeListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnBufferChangeListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnBufferChangeListenerInvoker")]
	public partial interface IVideoPlayerEventsOnBufferChangeListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnBufferChangeListener']/method[@name='onBufferChange' and count(parameter)=1 and parameter[1][@type='com.longtailvideo.jwplayer.events.BufferChangeEvent']]"
		[Register ("onBufferChange", "(Lcom/longtailvideo/jwplayer/events/BufferChangeEvent;)V", "GetOnBufferChange_Lcom_longtailvideo_jwplayer_events_BufferChangeEvent_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnBufferChangeListenerInvoker, JWBinding_AND")]
		void OnBufferChange (global::Com.Longtailvideo.Jwplayer.Events.BufferChangeEvent p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnBufferChangeListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnBufferChangeListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnBufferChangeListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnBufferChangeListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnBufferChangeListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnBufferChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnBufferChangeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnBufferChangeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnBufferChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBufferChange_Lcom_longtailvideo_jwplayer_events_BufferChangeEvent_;
#pragma warning disable 0169
		static Delegate GetOnBufferChange_Lcom_longtailvideo_jwplayer_events_BufferChangeEvent_Handler ()
		{
			if (cb_onBufferChange_Lcom_longtailvideo_jwplayer_events_BufferChangeEvent_ == null)
				cb_onBufferChange_Lcom_longtailvideo_jwplayer_events_BufferChangeEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBufferChange_Lcom_longtailvideo_jwplayer_events_BufferChangeEvent_);
			return cb_onBufferChange_Lcom_longtailvideo_jwplayer_events_BufferChangeEvent_;
		}

		static void n_OnBufferChange_Lcom_longtailvideo_jwplayer_events_BufferChangeEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnBufferChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnBufferChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Longtailvideo.Jwplayer.Events.BufferChangeEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.BufferChangeEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBufferChange (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBufferChange_Lcom_longtailvideo_jwplayer_events_BufferChangeEvent_;
		public unsafe void OnBufferChange (global::Com.Longtailvideo.Jwplayer.Events.BufferChangeEvent p0)
		{
			if (id_onBufferChange_Lcom_longtailvideo_jwplayer_events_BufferChangeEvent_ == IntPtr.Zero)
				id_onBufferChange_Lcom_longtailvideo_jwplayer_events_BufferChangeEvent_ = JNIEnv.GetMethodID (class_ref, "onBufferChange", "(Lcom/longtailvideo/jwplayer/events/BufferChangeEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBufferChange_Lcom_longtailvideo_jwplayer_events_BufferChangeEvent_, __args);
		}

	}

	public partial class VideoPlayerEventsOnBufferChangeEventArgs : global::System.EventArgs {

		public VideoPlayerEventsOnBufferChangeEventArgs (global::Com.Longtailvideo.Jwplayer.Events.BufferChangeEvent p0)
		{
			this.p0 = p0;
		}

		global::Com.Longtailvideo.Jwplayer.Events.BufferChangeEvent p0;
		public global::Com.Longtailvideo.Jwplayer.Events.BufferChangeEvent P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnBufferChangeListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnBufferChangeListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnBufferChangeListener {

		object sender;

		public IVideoPlayerEventsOnBufferChangeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnBufferChangeListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<VideoPlayerEventsOnBufferChangeEventArgs> Handler;
#pragma warning restore 0649

		public void OnBufferChange (global::Com.Longtailvideo.Jwplayer.Events.BufferChangeEvent p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new VideoPlayerEventsOnBufferChangeEventArgs (p0));
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnBufferChangeListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnBufferListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnBufferListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnBufferListenerInvoker")]
	public partial interface IVideoPlayerEventsOnBufferListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnBufferListener']/method[@name='onBuffer' and count(parameter)=1 and parameter[1][@type='com.longtailvideo.jwplayer.core.PlayerState']]"
		[Register ("onBuffer", "(Lcom/longtailvideo/jwplayer/core/PlayerState;)V", "GetOnBuffer_Lcom_longtailvideo_jwplayer_core_PlayerState_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnBufferListenerInvoker, JWBinding_AND")]
		void OnBuffer (global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnBufferListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnBufferListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnBufferListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnBufferListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnBufferListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnBufferListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnBufferListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnBufferListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnBufferListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBuffer_Lcom_longtailvideo_jwplayer_core_PlayerState_;
#pragma warning disable 0169
		static Delegate GetOnBuffer_Lcom_longtailvideo_jwplayer_core_PlayerState_Handler ()
		{
			if (cb_onBuffer_Lcom_longtailvideo_jwplayer_core_PlayerState_ == null)
				cb_onBuffer_Lcom_longtailvideo_jwplayer_core_PlayerState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnBuffer_Lcom_longtailvideo_jwplayer_core_PlayerState_);
			return cb_onBuffer_Lcom_longtailvideo_jwplayer_core_PlayerState_;
		}

		static void n_OnBuffer_Lcom_longtailvideo_jwplayer_core_PlayerState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnBufferListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnBufferListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0 = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Core.PlayerState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnBuffer (p0);
		}
#pragma warning restore 0169

		IntPtr id_onBuffer_Lcom_longtailvideo_jwplayer_core_PlayerState_;
		public unsafe void OnBuffer (global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0)
		{
			if (id_onBuffer_Lcom_longtailvideo_jwplayer_core_PlayerState_ == IntPtr.Zero)
				id_onBuffer_Lcom_longtailvideo_jwplayer_core_PlayerState_ = JNIEnv.GetMethodID (class_ref, "onBuffer", "(Lcom/longtailvideo/jwplayer/core/PlayerState;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBuffer_Lcom_longtailvideo_jwplayer_core_PlayerState_, __args);
		}

	}

	public partial class VideoPlayerEventsOnBufferEventArgs : global::System.EventArgs {

		public VideoPlayerEventsOnBufferEventArgs (global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0)
		{
			this.p0 = p0;
		}

		global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0;
		public global::Com.Longtailvideo.Jwplayer.Core.PlayerState P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnBufferListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnBufferListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnBufferListener {

		object sender;

		public IVideoPlayerEventsOnBufferListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnBufferListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<VideoPlayerEventsOnBufferEventArgs> Handler;
#pragma warning restore 0649

		public void OnBuffer (global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new VideoPlayerEventsOnBufferEventArgs (p0));
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnBufferListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnCompleteListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnCompleteListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnCompleteListenerInvoker")]
	public partial interface IVideoPlayerEventsOnCompleteListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnCompleteListener']/method[@name='onComplete' and count(parameter)=0]"
		[Register ("onComplete", "()V", "GetOnCompleteHandler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnCompleteListenerInvoker, JWBinding_AND")]
		void OnComplete ();

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnCompleteListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnCompleteListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnCompleteListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnCompleteListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnCompleteListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnCompleteListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnCompleteListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnCompleteListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnCompleteListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onComplete;
#pragma warning disable 0169
		static Delegate GetOnCompleteHandler ()
		{
			if (cb_onComplete == null)
				cb_onComplete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnComplete);
			return cb_onComplete;
		}

		static void n_OnComplete (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnCompleteListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnCompleteListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete ();
		}
#pragma warning restore 0169

		IntPtr id_onComplete;
		public unsafe void OnComplete ()
		{
			if (id_onComplete == IntPtr.Zero)
				id_onComplete = JNIEnv.GetMethodID (class_ref, "onComplete", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete);
		}

	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnCompleteListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnCompleteListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnCompleteListener {

		object sender;

		public IVideoPlayerEventsOnCompleteListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnCompleteListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void OnComplete ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnCompleteListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnControlsListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnControlsListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnControlsListenerInvoker")]
	public partial interface IVideoPlayerEventsOnControlsListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnControlsListener']/method[@name='onControls' and count(parameter)=1 and parameter[1][@type='com.longtailvideo.jwplayer.events.ControlsEvent']]"
		[Register ("onControls", "(Lcom/longtailvideo/jwplayer/events/ControlsEvent;)V", "GetOnControls_Lcom_longtailvideo_jwplayer_events_ControlsEvent_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnControlsListenerInvoker, JWBinding_AND")]
		void OnControls (global::Com.Longtailvideo.Jwplayer.Events.ControlsEvent p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnControlsListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnControlsListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnControlsListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnControlsListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnControlsListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnControlsListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnControlsListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnControlsListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnControlsListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onControls_Lcom_longtailvideo_jwplayer_events_ControlsEvent_;
#pragma warning disable 0169
		static Delegate GetOnControls_Lcom_longtailvideo_jwplayer_events_ControlsEvent_Handler ()
		{
			if (cb_onControls_Lcom_longtailvideo_jwplayer_events_ControlsEvent_ == null)
				cb_onControls_Lcom_longtailvideo_jwplayer_events_ControlsEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnControls_Lcom_longtailvideo_jwplayer_events_ControlsEvent_);
			return cb_onControls_Lcom_longtailvideo_jwplayer_events_ControlsEvent_;
		}

		static void n_OnControls_Lcom_longtailvideo_jwplayer_events_ControlsEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnControlsListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnControlsListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Longtailvideo.Jwplayer.Events.ControlsEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.ControlsEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnControls (p0);
		}
#pragma warning restore 0169

		IntPtr id_onControls_Lcom_longtailvideo_jwplayer_events_ControlsEvent_;
		public unsafe void OnControls (global::Com.Longtailvideo.Jwplayer.Events.ControlsEvent p0)
		{
			if (id_onControls_Lcom_longtailvideo_jwplayer_events_ControlsEvent_ == IntPtr.Zero)
				id_onControls_Lcom_longtailvideo_jwplayer_events_ControlsEvent_ = JNIEnv.GetMethodID (class_ref, "onControls", "(Lcom/longtailvideo/jwplayer/events/ControlsEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onControls_Lcom_longtailvideo_jwplayer_events_ControlsEvent_, __args);
		}

	}

	public partial class VideoPlayerEventsOnControlsEventArgs : global::System.EventArgs {

		public VideoPlayerEventsOnControlsEventArgs (global::Com.Longtailvideo.Jwplayer.Events.ControlsEvent p0)
		{
			this.p0 = p0;
		}

		global::Com.Longtailvideo.Jwplayer.Events.ControlsEvent p0;
		public global::Com.Longtailvideo.Jwplayer.Events.ControlsEvent P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnControlsListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnControlsListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnControlsListener {

		object sender;

		public IVideoPlayerEventsOnControlsListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnControlsListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<VideoPlayerEventsOnControlsEventArgs> Handler;
#pragma warning restore 0649

		public void OnControls (global::Com.Longtailvideo.Jwplayer.Events.ControlsEvent p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new VideoPlayerEventsOnControlsEventArgs (p0));
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnControlsListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnDisplayClickListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnDisplayClickListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnDisplayClickListenerInvoker")]
	public partial interface IVideoPlayerEventsOnDisplayClickListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnDisplayClickListener']/method[@name='onDisplayClick' and count(parameter)=0]"
		[Register ("onDisplayClick", "()V", "GetOnDisplayClickHandler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnDisplayClickListenerInvoker, JWBinding_AND")]
		void OnDisplayClick ();

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnDisplayClickListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnDisplayClickListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnDisplayClickListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnDisplayClickListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnDisplayClickListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnDisplayClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnDisplayClickListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnDisplayClickListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnDisplayClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDisplayClick;
#pragma warning disable 0169
		static Delegate GetOnDisplayClickHandler ()
		{
			if (cb_onDisplayClick == null)
				cb_onDisplayClick = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDisplayClick);
			return cb_onDisplayClick;
		}

		static void n_OnDisplayClick (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnDisplayClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnDisplayClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDisplayClick ();
		}
#pragma warning restore 0169

		IntPtr id_onDisplayClick;
		public unsafe void OnDisplayClick ()
		{
			if (id_onDisplayClick == IntPtr.Zero)
				id_onDisplayClick = JNIEnv.GetMethodID (class_ref, "onDisplayClick", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDisplayClick);
		}

	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnDisplayClickListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnDisplayClickListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnDisplayClickListener {

		object sender;

		public IVideoPlayerEventsOnDisplayClickListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnDisplayClickListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void OnDisplayClick ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnDisplayClickListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnErrorListener']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnErrorListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnErrorListenerInvoker")]
	public partial interface IVideoPlayerEventsOnErrorListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnErrorListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
[Obsolete (@"deprecated")]
		[Register ("onError", "(Ljava/lang/String;)V", "GetOnError_Ljava_lang_String_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnErrorListenerInvoker, JWBinding_AND")]
		void OnError (string p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnErrorListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnErrorListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnErrorListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnErrorListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnErrorListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnErrorListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnErrorListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnErrorListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnErrorListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onError_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_lang_String_Handler ()
		{
			if (cb_onError_Ljava_lang_String_ == null)
				cb_onError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_String_);
			return cb_onError_Ljava_lang_String_;
		}

		static void n_OnError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnErrorListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnErrorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Ljava_lang_String_;
		public unsafe void OnError (string p0)
		{
			if (id_onError_Ljava_lang_String_ == IntPtr.Zero)
				id_onError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	public partial class VideoPlayerEventsOnErrorEventArgs : global::System.EventArgs {

		public VideoPlayerEventsOnErrorEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnErrorListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnErrorListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnErrorListener {

		object sender;

		public IVideoPlayerEventsOnErrorListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnErrorListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<VideoPlayerEventsOnErrorEventArgs> Handler;
#pragma warning restore 0649

		public void OnError (string p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new VideoPlayerEventsOnErrorEventArgs (p0));
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnErrorListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnErrorListenerV2']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnErrorListenerV2", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnErrorListenerV2Invoker")]
	public partial interface IVideoPlayerEventsOnErrorListenerV2 : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnErrorListenerV2']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='com.longtailvideo.jwplayer.events.ErrorEvent']]"
		[Register ("onError", "(Lcom/longtailvideo/jwplayer/events/ErrorEvent;)V", "GetOnError_Lcom_longtailvideo_jwplayer_events_ErrorEvent_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnErrorListenerV2Invoker, JWBinding_AND")]
		void OnError (global::Com.Longtailvideo.Jwplayer.Events.ErrorEvent p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnErrorListenerV2", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnErrorListenerV2Invoker : global::Java.Lang.Object, IVideoPlayerEventsOnErrorListenerV2 {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnErrorListenerV2");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnErrorListenerV2Invoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnErrorListenerV2 GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnErrorListenerV2> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnErrorListenerV2"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnErrorListenerV2Invoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onError_Lcom_longtailvideo_jwplayer_events_ErrorEvent_;
#pragma warning disable 0169
		static Delegate GetOnError_Lcom_longtailvideo_jwplayer_events_ErrorEvent_Handler ()
		{
			if (cb_onError_Lcom_longtailvideo_jwplayer_events_ErrorEvent_ == null)
				cb_onError_Lcom_longtailvideo_jwplayer_events_ErrorEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Lcom_longtailvideo_jwplayer_events_ErrorEvent_);
			return cb_onError_Lcom_longtailvideo_jwplayer_events_ErrorEvent_;
		}

		static void n_OnError_Lcom_longtailvideo_jwplayer_events_ErrorEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnErrorListenerV2 __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnErrorListenerV2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Longtailvideo.Jwplayer.Events.ErrorEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.ErrorEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Lcom_longtailvideo_jwplayer_events_ErrorEvent_;
		public unsafe void OnError (global::Com.Longtailvideo.Jwplayer.Events.ErrorEvent p0)
		{
			if (id_onError_Lcom_longtailvideo_jwplayer_events_ErrorEvent_ == IntPtr.Zero)
				id_onError_Lcom_longtailvideo_jwplayer_events_ErrorEvent_ = JNIEnv.GetMethodID (class_ref, "onError", "(Lcom/longtailvideo/jwplayer/events/ErrorEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Lcom_longtailvideo_jwplayer_events_ErrorEvent_, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnFirstFrameListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnFirstFrameListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnFirstFrameListenerInvoker")]
	public partial interface IVideoPlayerEventsOnFirstFrameListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnFirstFrameListener']/method[@name='onFirstFrame' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onFirstFrame", "(I)V", "GetOnFirstFrame_IHandler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnFirstFrameListenerInvoker, JWBinding_AND")]
		void OnFirstFrame (int p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnFirstFrameListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnFirstFrameListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnFirstFrameListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnFirstFrameListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnFirstFrameListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnFirstFrameListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnFirstFrameListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnFirstFrameListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnFirstFrameListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFirstFrame_I;
#pragma warning disable 0169
		static Delegate GetOnFirstFrame_IHandler ()
		{
			if (cb_onFirstFrame_I == null)
				cb_onFirstFrame_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnFirstFrame_I);
			return cb_onFirstFrame_I;
		}

		static void n_OnFirstFrame_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnFirstFrameListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnFirstFrameListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFirstFrame (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFirstFrame_I;
		public unsafe void OnFirstFrame (int p0)
		{
			if (id_onFirstFrame_I == IntPtr.Zero)
				id_onFirstFrame_I = JNIEnv.GetMethodID (class_ref, "onFirstFrame", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFirstFrame_I, __args);
		}

	}

	public partial class VideoPlayerEventsOnFirstFrameEventArgs : global::System.EventArgs {

		public VideoPlayerEventsOnFirstFrameEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnFirstFrameListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnFirstFrameListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnFirstFrameListener {

		object sender;

		public IVideoPlayerEventsOnFirstFrameListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnFirstFrameListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<VideoPlayerEventsOnFirstFrameEventArgs> Handler;
#pragma warning restore 0649

		public void OnFirstFrame (int p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new VideoPlayerEventsOnFirstFrameEventArgs (p0));
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnFirstFrameListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnFullscreenListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnFullscreenListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnFullscreenListenerInvoker")]
	public partial interface IVideoPlayerEventsOnFullscreenListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnFullscreenListener']/method[@name='onFullscreen' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onFullscreen", "(Z)V", "GetOnFullscreen_ZHandler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnFullscreenListenerInvoker, JWBinding_AND")]
		void OnFullscreen (bool p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnFullscreenListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnFullscreenListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnFullscreenListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnFullscreenListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnFullscreenListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnFullscreenListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnFullscreenListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnFullscreenListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnFullscreenListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFullscreen_Z;
#pragma warning disable 0169
		static Delegate GetOnFullscreen_ZHandler ()
		{
			if (cb_onFullscreen_Z == null)
				cb_onFullscreen_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnFullscreen_Z);
			return cb_onFullscreen_Z;
		}

		static void n_OnFullscreen_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnFullscreenListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnFullscreenListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFullscreen (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFullscreen_Z;
		public unsafe void OnFullscreen (bool p0)
		{
			if (id_onFullscreen_Z == IntPtr.Zero)
				id_onFullscreen_Z = JNIEnv.GetMethodID (class_ref, "onFullscreen", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFullscreen_Z, __args);
		}

	}

	public partial class VideoPlayerEventsOnFullscreenEventArgs : global::System.EventArgs {

		public VideoPlayerEventsOnFullscreenEventArgs (bool p0)
		{
			this.p0 = p0;
		}

		bool p0;
		public bool P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnFullscreenListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnFullscreenListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnFullscreenListener {

		object sender;

		public IVideoPlayerEventsOnFullscreenListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnFullscreenListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<VideoPlayerEventsOnFullscreenEventArgs> Handler;
#pragma warning restore 0649

		public void OnFullscreen (bool p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new VideoPlayerEventsOnFullscreenEventArgs (p0));
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnFullscreenListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnIdleListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnIdleListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnIdleListenerInvoker")]
	public partial interface IVideoPlayerEventsOnIdleListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnIdleListener']/method[@name='onIdle' and count(parameter)=1 and parameter[1][@type='com.longtailvideo.jwplayer.core.PlayerState']]"
		[Register ("onIdle", "(Lcom/longtailvideo/jwplayer/core/PlayerState;)V", "GetOnIdle_Lcom_longtailvideo_jwplayer_core_PlayerState_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnIdleListenerInvoker, JWBinding_AND")]
		void OnIdle (global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnIdleListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnIdleListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnIdleListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnIdleListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnIdleListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnIdleListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnIdleListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnIdleListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnIdleListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onIdle_Lcom_longtailvideo_jwplayer_core_PlayerState_;
#pragma warning disable 0169
		static Delegate GetOnIdle_Lcom_longtailvideo_jwplayer_core_PlayerState_Handler ()
		{
			if (cb_onIdle_Lcom_longtailvideo_jwplayer_core_PlayerState_ == null)
				cb_onIdle_Lcom_longtailvideo_jwplayer_core_PlayerState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnIdle_Lcom_longtailvideo_jwplayer_core_PlayerState_);
			return cb_onIdle_Lcom_longtailvideo_jwplayer_core_PlayerState_;
		}

		static void n_OnIdle_Lcom_longtailvideo_jwplayer_core_PlayerState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnIdleListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnIdleListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0 = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Core.PlayerState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnIdle (p0);
		}
#pragma warning restore 0169

		IntPtr id_onIdle_Lcom_longtailvideo_jwplayer_core_PlayerState_;
		public unsafe void OnIdle (global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0)
		{
			if (id_onIdle_Lcom_longtailvideo_jwplayer_core_PlayerState_ == IntPtr.Zero)
				id_onIdle_Lcom_longtailvideo_jwplayer_core_PlayerState_ = JNIEnv.GetMethodID (class_ref, "onIdle", "(Lcom/longtailvideo/jwplayer/core/PlayerState;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onIdle_Lcom_longtailvideo_jwplayer_core_PlayerState_, __args);
		}

	}

	public partial class VideoPlayerEventsOnIdleEventArgs : global::System.EventArgs {

		public VideoPlayerEventsOnIdleEventArgs (global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0)
		{
			this.p0 = p0;
		}

		global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0;
		public global::Com.Longtailvideo.Jwplayer.Core.PlayerState P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnIdleListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnIdleListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnIdleListener {

		object sender;

		public IVideoPlayerEventsOnIdleListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnIdleListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<VideoPlayerEventsOnIdleEventArgs> Handler;
#pragma warning restore 0649

		public void OnIdle (global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new VideoPlayerEventsOnIdleEventArgs (p0));
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnIdleListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnLevelsChangedListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnLevelsChangedListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnLevelsChangedListenerInvoker")]
	public partial interface IVideoPlayerEventsOnLevelsChangedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnLevelsChangedListener']/method[@name='onLevelsChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onLevelsChanged", "(I)V", "GetOnLevelsChanged_IHandler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnLevelsChangedListenerInvoker, JWBinding_AND")]
		void OnLevelsChanged (int p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnLevelsChangedListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnLevelsChangedListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnLevelsChangedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnLevelsChangedListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnLevelsChangedListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnLevelsChangedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnLevelsChangedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnLevelsChangedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnLevelsChangedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onLevelsChanged_I;
#pragma warning disable 0169
		static Delegate GetOnLevelsChanged_IHandler ()
		{
			if (cb_onLevelsChanged_I == null)
				cb_onLevelsChanged_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnLevelsChanged_I);
			return cb_onLevelsChanged_I;
		}

		static void n_OnLevelsChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnLevelsChangedListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnLevelsChangedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLevelsChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onLevelsChanged_I;
		public unsafe void OnLevelsChanged (int p0)
		{
			if (id_onLevelsChanged_I == IntPtr.Zero)
				id_onLevelsChanged_I = JNIEnv.GetMethodID (class_ref, "onLevelsChanged", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLevelsChanged_I, __args);
		}

	}

	public partial class VideoPlayerEventsOnLevelsChangedEventArgs : global::System.EventArgs {

		public VideoPlayerEventsOnLevelsChangedEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnLevelsChangedListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnLevelsChangedListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnLevelsChangedListener {

		object sender;

		public IVideoPlayerEventsOnLevelsChangedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnLevelsChangedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<VideoPlayerEventsOnLevelsChangedEventArgs> Handler;
#pragma warning restore 0649

		public void OnLevelsChanged (int p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new VideoPlayerEventsOnLevelsChangedEventArgs (p0));
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnLevelsChangedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnMuteListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnMuteListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnMuteListenerInvoker")]
	public partial interface IVideoPlayerEventsOnMuteListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnMuteListener']/method[@name='onMute' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("onMute", "(Z)V", "GetOnMute_ZHandler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnMuteListenerInvoker, JWBinding_AND")]
		void OnMute (bool p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnMuteListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnMuteListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnMuteListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnMuteListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnMuteListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnMuteListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnMuteListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnMuteListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnMuteListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onMute_Z;
#pragma warning disable 0169
		static Delegate GetOnMute_ZHandler ()
		{
			if (cb_onMute_Z == null)
				cb_onMute_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OnMute_Z);
			return cb_onMute_Z;
		}

		static void n_OnMute_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnMuteListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnMuteListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMute (p0);
		}
#pragma warning restore 0169

		IntPtr id_onMute_Z;
		public unsafe void OnMute (bool p0)
		{
			if (id_onMute_Z == IntPtr.Zero)
				id_onMute_Z = JNIEnv.GetMethodID (class_ref, "onMute", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMute_Z, __args);
		}

	}

	public partial class VideoPlayerEventsOnMuteEventArgs : global::System.EventArgs {

		public VideoPlayerEventsOnMuteEventArgs (bool p0)
		{
			this.p0 = p0;
		}

		bool p0;
		public bool P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnMuteListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnMuteListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnMuteListener {

		object sender;

		public IVideoPlayerEventsOnMuteListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnMuteListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<VideoPlayerEventsOnMuteEventArgs> Handler;
#pragma warning restore 0649

		public void OnMute (bool p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new VideoPlayerEventsOnMuteEventArgs (p0));
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnMuteListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnPauseListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnPauseListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnPauseListenerInvoker")]
	public partial interface IVideoPlayerEventsOnPauseListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnPauseListener']/method[@name='onPause' and count(parameter)=1 and parameter[1][@type='com.longtailvideo.jwplayer.core.PlayerState']]"
		[Register ("onPause", "(Lcom/longtailvideo/jwplayer/core/PlayerState;)V", "GetOnPause_Lcom_longtailvideo_jwplayer_core_PlayerState_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnPauseListenerInvoker, JWBinding_AND")]
		void OnPause (global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnPauseListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnPauseListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnPauseListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnPauseListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnPauseListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnPauseListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnPauseListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnPauseListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnPauseListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onPause_Lcom_longtailvideo_jwplayer_core_PlayerState_;
#pragma warning disable 0169
		static Delegate GetOnPause_Lcom_longtailvideo_jwplayer_core_PlayerState_Handler ()
		{
			if (cb_onPause_Lcom_longtailvideo_jwplayer_core_PlayerState_ == null)
				cb_onPause_Lcom_longtailvideo_jwplayer_core_PlayerState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPause_Lcom_longtailvideo_jwplayer_core_PlayerState_);
			return cb_onPause_Lcom_longtailvideo_jwplayer_core_PlayerState_;
		}

		static void n_OnPause_Lcom_longtailvideo_jwplayer_core_PlayerState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnPauseListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnPauseListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0 = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Core.PlayerState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPause (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPause_Lcom_longtailvideo_jwplayer_core_PlayerState_;
		public unsafe void OnPause (global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0)
		{
			if (id_onPause_Lcom_longtailvideo_jwplayer_core_PlayerState_ == IntPtr.Zero)
				id_onPause_Lcom_longtailvideo_jwplayer_core_PlayerState_ = JNIEnv.GetMethodID (class_ref, "onPause", "(Lcom/longtailvideo/jwplayer/core/PlayerState;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPause_Lcom_longtailvideo_jwplayer_core_PlayerState_, __args);
		}

	}

	public partial class VideoPlayerEventsOnPauseEventArgs : global::System.EventArgs {

		public VideoPlayerEventsOnPauseEventArgs (global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0)
		{
			this.p0 = p0;
		}

		global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0;
		public global::Com.Longtailvideo.Jwplayer.Core.PlayerState P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnPauseListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnPauseListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnPauseListener {

		object sender;

		public IVideoPlayerEventsOnPauseListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnPauseListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<VideoPlayerEventsOnPauseEventArgs> Handler;
#pragma warning restore 0649

		public void OnPause (global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new VideoPlayerEventsOnPauseEventArgs (p0));
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnPauseListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnPlayListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnPlayListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnPlayListenerInvoker")]
	public partial interface IVideoPlayerEventsOnPlayListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnPlayListener']/method[@name='onPlay' and count(parameter)=1 and parameter[1][@type='com.longtailvideo.jwplayer.core.PlayerState']]"
		[Register ("onPlay", "(Lcom/longtailvideo/jwplayer/core/PlayerState;)V", "GetOnPlay_Lcom_longtailvideo_jwplayer_core_PlayerState_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnPlayListenerInvoker, JWBinding_AND")]
		void OnPlay (global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnPlayListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnPlayListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnPlayListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnPlayListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnPlayListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnPlayListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnPlayListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnPlayListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnPlayListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onPlay_Lcom_longtailvideo_jwplayer_core_PlayerState_;
#pragma warning disable 0169
		static Delegate GetOnPlay_Lcom_longtailvideo_jwplayer_core_PlayerState_Handler ()
		{
			if (cb_onPlay_Lcom_longtailvideo_jwplayer_core_PlayerState_ == null)
				cb_onPlay_Lcom_longtailvideo_jwplayer_core_PlayerState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPlay_Lcom_longtailvideo_jwplayer_core_PlayerState_);
			return cb_onPlay_Lcom_longtailvideo_jwplayer_core_PlayerState_;
		}

		static void n_OnPlay_Lcom_longtailvideo_jwplayer_core_PlayerState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnPlayListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnPlayListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0 = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Core.PlayerState> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPlay (p0);
		}
#pragma warning restore 0169

		IntPtr id_onPlay_Lcom_longtailvideo_jwplayer_core_PlayerState_;
		public unsafe void OnPlay (global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0)
		{
			if (id_onPlay_Lcom_longtailvideo_jwplayer_core_PlayerState_ == IntPtr.Zero)
				id_onPlay_Lcom_longtailvideo_jwplayer_core_PlayerState_ = JNIEnv.GetMethodID (class_ref, "onPlay", "(Lcom/longtailvideo/jwplayer/core/PlayerState;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPlay_Lcom_longtailvideo_jwplayer_core_PlayerState_, __args);
		}

	}

	public partial class VideoPlayerEventsOnPlayEventArgs : global::System.EventArgs {

		public VideoPlayerEventsOnPlayEventArgs (global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0)
		{
			this.p0 = p0;
		}

		global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0;
		public global::Com.Longtailvideo.Jwplayer.Core.PlayerState P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnPlayListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnPlayListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnPlayListener {

		object sender;

		public IVideoPlayerEventsOnPlayListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnPlayListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<VideoPlayerEventsOnPlayEventArgs> Handler;
#pragma warning restore 0649

		public void OnPlay (global::Com.Longtailvideo.Jwplayer.Core.PlayerState p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new VideoPlayerEventsOnPlayEventArgs (p0));
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnPlayListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnPlaylistCompleteListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnPlaylistCompleteListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnPlaylistCompleteListenerInvoker")]
	public partial interface IVideoPlayerEventsOnPlaylistCompleteListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnPlaylistCompleteListener']/method[@name='onPlaylistComplete' and count(parameter)=0]"
		[Register ("onPlaylistComplete", "()V", "GetOnPlaylistCompleteHandler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnPlaylistCompleteListenerInvoker, JWBinding_AND")]
		void OnPlaylistComplete ();

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnPlaylistCompleteListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnPlaylistCompleteListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnPlaylistCompleteListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnPlaylistCompleteListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnPlaylistCompleteListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnPlaylistCompleteListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnPlaylistCompleteListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnPlaylistCompleteListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnPlaylistCompleteListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onPlaylistComplete;
#pragma warning disable 0169
		static Delegate GetOnPlaylistCompleteHandler ()
		{
			if (cb_onPlaylistComplete == null)
				cb_onPlaylistComplete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPlaylistComplete);
			return cb_onPlaylistComplete;
		}

		static void n_OnPlaylistComplete (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnPlaylistCompleteListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnPlaylistCompleteListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPlaylistComplete ();
		}
#pragma warning restore 0169

		IntPtr id_onPlaylistComplete;
		public unsafe void OnPlaylistComplete ()
		{
			if (id_onPlaylistComplete == IntPtr.Zero)
				id_onPlaylistComplete = JNIEnv.GetMethodID (class_ref, "onPlaylistComplete", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPlaylistComplete);
		}

	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnPlaylistCompleteListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnPlaylistCompleteListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnPlaylistCompleteListener {

		object sender;

		public IVideoPlayerEventsOnPlaylistCompleteListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnPlaylistCompleteListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void OnPlaylistComplete ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnPlaylistCompleteListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnQualityChangeListener']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnQualityChangeListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnQualityChangeListenerInvoker")]
	public partial interface IVideoPlayerEventsOnQualityChangeListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnQualityChangeListener']/method[@name='onQualityChange' and count(parameter)=1 and parameter[1][@type='int']]"
[Obsolete (@"deprecated")]
		[Register ("onQualityChange", "(I)V", "GetOnQualityChange_IHandler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnQualityChangeListenerInvoker, JWBinding_AND")]
		void OnQualityChange (int p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnQualityChangeListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnQualityChangeListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnQualityChangeListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnQualityChangeListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnQualityChangeListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnQualityChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnQualityChangeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnQualityChangeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnQualityChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onQualityChange_I;
#pragma warning disable 0169
		static Delegate GetOnQualityChange_IHandler ()
		{
			if (cb_onQualityChange_I == null)
				cb_onQualityChange_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnQualityChange_I);
			return cb_onQualityChange_I;
		}

		static void n_OnQualityChange_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnQualityChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnQualityChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnQualityChange (p0);
		}
#pragma warning restore 0169

		IntPtr id_onQualityChange_I;
		public unsafe void OnQualityChange (int p0)
		{
			if (id_onQualityChange_I == IntPtr.Zero)
				id_onQualityChange_I = JNIEnv.GetMethodID (class_ref, "onQualityChange", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onQualityChange_I, __args);
		}

	}

	public partial class VideoPlayerEventsOnQualityChangeEventArgs : global::System.EventArgs {

		public VideoPlayerEventsOnQualityChangeEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnQualityChangeListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnQualityChangeListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnQualityChangeListener {

		object sender;

		public IVideoPlayerEventsOnQualityChangeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnQualityChangeListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<VideoPlayerEventsOnQualityChangeEventArgs> Handler;
#pragma warning restore 0649

		public void OnQualityChange (int p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new VideoPlayerEventsOnQualityChangeEventArgs (p0));
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnQualityChangeListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnRelatedCloseListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnRelatedCloseListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnRelatedCloseListenerInvoker")]
	public partial interface IVideoPlayerEventsOnRelatedCloseListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnRelatedCloseListener']/method[@name='onRelatedClose' and count(parameter)=1 and parameter[1][@type='com.longtailvideo.jwplayer.events.RelatedCloseEvent']]"
		[Register ("onRelatedClose", "(Lcom/longtailvideo/jwplayer/events/RelatedCloseEvent;)V", "GetOnRelatedClose_Lcom_longtailvideo_jwplayer_events_RelatedCloseEvent_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnRelatedCloseListenerInvoker, JWBinding_AND")]
		void OnRelatedClose (global::Com.Longtailvideo.Jwplayer.Events.RelatedCloseEvent p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnRelatedCloseListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnRelatedCloseListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnRelatedCloseListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnRelatedCloseListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnRelatedCloseListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnRelatedCloseListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnRelatedCloseListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnRelatedCloseListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnRelatedCloseListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRelatedClose_Lcom_longtailvideo_jwplayer_events_RelatedCloseEvent_;
#pragma warning disable 0169
		static Delegate GetOnRelatedClose_Lcom_longtailvideo_jwplayer_events_RelatedCloseEvent_Handler ()
		{
			if (cb_onRelatedClose_Lcom_longtailvideo_jwplayer_events_RelatedCloseEvent_ == null)
				cb_onRelatedClose_Lcom_longtailvideo_jwplayer_events_RelatedCloseEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRelatedClose_Lcom_longtailvideo_jwplayer_events_RelatedCloseEvent_);
			return cb_onRelatedClose_Lcom_longtailvideo_jwplayer_events_RelatedCloseEvent_;
		}

		static void n_OnRelatedClose_Lcom_longtailvideo_jwplayer_events_RelatedCloseEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnRelatedCloseListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnRelatedCloseListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Longtailvideo.Jwplayer.Events.RelatedCloseEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.RelatedCloseEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRelatedClose (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRelatedClose_Lcom_longtailvideo_jwplayer_events_RelatedCloseEvent_;
		public unsafe void OnRelatedClose (global::Com.Longtailvideo.Jwplayer.Events.RelatedCloseEvent p0)
		{
			if (id_onRelatedClose_Lcom_longtailvideo_jwplayer_events_RelatedCloseEvent_ == IntPtr.Zero)
				id_onRelatedClose_Lcom_longtailvideo_jwplayer_events_RelatedCloseEvent_ = JNIEnv.GetMethodID (class_ref, "onRelatedClose", "(Lcom/longtailvideo/jwplayer/events/RelatedCloseEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRelatedClose_Lcom_longtailvideo_jwplayer_events_RelatedCloseEvent_, __args);
		}

	}

	public partial class VideoPlayerEventsOnRelatedCloseEventArgs : global::System.EventArgs {

		public VideoPlayerEventsOnRelatedCloseEventArgs (global::Com.Longtailvideo.Jwplayer.Events.RelatedCloseEvent p0)
		{
			this.p0 = p0;
		}

		global::Com.Longtailvideo.Jwplayer.Events.RelatedCloseEvent p0;
		public global::Com.Longtailvideo.Jwplayer.Events.RelatedCloseEvent P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnRelatedCloseListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnRelatedCloseListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnRelatedCloseListener {

		object sender;

		public IVideoPlayerEventsOnRelatedCloseListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnRelatedCloseListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<VideoPlayerEventsOnRelatedCloseEventArgs> Handler;
#pragma warning restore 0649

		public void OnRelatedClose (global::Com.Longtailvideo.Jwplayer.Events.RelatedCloseEvent p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new VideoPlayerEventsOnRelatedCloseEventArgs (p0));
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnRelatedCloseListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnRelatedOpenListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnRelatedOpenListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnRelatedOpenListenerInvoker")]
	public partial interface IVideoPlayerEventsOnRelatedOpenListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnRelatedOpenListener']/method[@name='onRelatedOpen' and count(parameter)=1 and parameter[1][@type='com.longtailvideo.jwplayer.events.RelatedOpenEvent']]"
		[Register ("onRelatedOpen", "(Lcom/longtailvideo/jwplayer/events/RelatedOpenEvent;)V", "GetOnRelatedOpen_Lcom_longtailvideo_jwplayer_events_RelatedOpenEvent_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnRelatedOpenListenerInvoker, JWBinding_AND")]
		void OnRelatedOpen (global::Com.Longtailvideo.Jwplayer.Events.RelatedOpenEvent p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnRelatedOpenListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnRelatedOpenListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnRelatedOpenListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnRelatedOpenListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnRelatedOpenListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnRelatedOpenListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnRelatedOpenListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnRelatedOpenListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnRelatedOpenListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRelatedOpen_Lcom_longtailvideo_jwplayer_events_RelatedOpenEvent_;
#pragma warning disable 0169
		static Delegate GetOnRelatedOpen_Lcom_longtailvideo_jwplayer_events_RelatedOpenEvent_Handler ()
		{
			if (cb_onRelatedOpen_Lcom_longtailvideo_jwplayer_events_RelatedOpenEvent_ == null)
				cb_onRelatedOpen_Lcom_longtailvideo_jwplayer_events_RelatedOpenEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRelatedOpen_Lcom_longtailvideo_jwplayer_events_RelatedOpenEvent_);
			return cb_onRelatedOpen_Lcom_longtailvideo_jwplayer_events_RelatedOpenEvent_;
		}

		static void n_OnRelatedOpen_Lcom_longtailvideo_jwplayer_events_RelatedOpenEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnRelatedOpenListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnRelatedOpenListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Longtailvideo.Jwplayer.Events.RelatedOpenEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.RelatedOpenEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRelatedOpen (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRelatedOpen_Lcom_longtailvideo_jwplayer_events_RelatedOpenEvent_;
		public unsafe void OnRelatedOpen (global::Com.Longtailvideo.Jwplayer.Events.RelatedOpenEvent p0)
		{
			if (id_onRelatedOpen_Lcom_longtailvideo_jwplayer_events_RelatedOpenEvent_ == IntPtr.Zero)
				id_onRelatedOpen_Lcom_longtailvideo_jwplayer_events_RelatedOpenEvent_ = JNIEnv.GetMethodID (class_ref, "onRelatedOpen", "(Lcom/longtailvideo/jwplayer/events/RelatedOpenEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRelatedOpen_Lcom_longtailvideo_jwplayer_events_RelatedOpenEvent_, __args);
		}

	}

	public partial class VideoPlayerEventsOnRelatedOpenEventArgs : global::System.EventArgs {

		public VideoPlayerEventsOnRelatedOpenEventArgs (global::Com.Longtailvideo.Jwplayer.Events.RelatedOpenEvent p0)
		{
			this.p0 = p0;
		}

		global::Com.Longtailvideo.Jwplayer.Events.RelatedOpenEvent p0;
		public global::Com.Longtailvideo.Jwplayer.Events.RelatedOpenEvent P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnRelatedOpenListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnRelatedOpenListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnRelatedOpenListener {

		object sender;

		public IVideoPlayerEventsOnRelatedOpenListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnRelatedOpenListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<VideoPlayerEventsOnRelatedOpenEventArgs> Handler;
#pragma warning restore 0649

		public void OnRelatedOpen (global::Com.Longtailvideo.Jwplayer.Events.RelatedOpenEvent p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new VideoPlayerEventsOnRelatedOpenEventArgs (p0));
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnRelatedOpenListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnRelatedPlayListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnRelatedPlayListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnRelatedPlayListenerInvoker")]
	public partial interface IVideoPlayerEventsOnRelatedPlayListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnRelatedPlayListener']/method[@name='onRelatedPlay' and count(parameter)=1 and parameter[1][@type='com.longtailvideo.jwplayer.events.RelatedPlayEvent']]"
		[Register ("onRelatedPlay", "(Lcom/longtailvideo/jwplayer/events/RelatedPlayEvent;)V", "GetOnRelatedPlay_Lcom_longtailvideo_jwplayer_events_RelatedPlayEvent_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnRelatedPlayListenerInvoker, JWBinding_AND")]
		void OnRelatedPlay (global::Com.Longtailvideo.Jwplayer.Events.RelatedPlayEvent p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnRelatedPlayListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnRelatedPlayListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnRelatedPlayListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnRelatedPlayListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnRelatedPlayListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnRelatedPlayListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnRelatedPlayListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnRelatedPlayListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnRelatedPlayListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRelatedPlay_Lcom_longtailvideo_jwplayer_events_RelatedPlayEvent_;
#pragma warning disable 0169
		static Delegate GetOnRelatedPlay_Lcom_longtailvideo_jwplayer_events_RelatedPlayEvent_Handler ()
		{
			if (cb_onRelatedPlay_Lcom_longtailvideo_jwplayer_events_RelatedPlayEvent_ == null)
				cb_onRelatedPlay_Lcom_longtailvideo_jwplayer_events_RelatedPlayEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRelatedPlay_Lcom_longtailvideo_jwplayer_events_RelatedPlayEvent_);
			return cb_onRelatedPlay_Lcom_longtailvideo_jwplayer_events_RelatedPlayEvent_;
		}

		static void n_OnRelatedPlay_Lcom_longtailvideo_jwplayer_events_RelatedPlayEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnRelatedPlayListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnRelatedPlayListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Longtailvideo.Jwplayer.Events.RelatedPlayEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.RelatedPlayEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRelatedPlay (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRelatedPlay_Lcom_longtailvideo_jwplayer_events_RelatedPlayEvent_;
		public unsafe void OnRelatedPlay (global::Com.Longtailvideo.Jwplayer.Events.RelatedPlayEvent p0)
		{
			if (id_onRelatedPlay_Lcom_longtailvideo_jwplayer_events_RelatedPlayEvent_ == IntPtr.Zero)
				id_onRelatedPlay_Lcom_longtailvideo_jwplayer_events_RelatedPlayEvent_ = JNIEnv.GetMethodID (class_ref, "onRelatedPlay", "(Lcom/longtailvideo/jwplayer/events/RelatedPlayEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRelatedPlay_Lcom_longtailvideo_jwplayer_events_RelatedPlayEvent_, __args);
		}

	}

	public partial class VideoPlayerEventsOnRelatedPlayEventArgs : global::System.EventArgs {

		public VideoPlayerEventsOnRelatedPlayEventArgs (global::Com.Longtailvideo.Jwplayer.Events.RelatedPlayEvent p0)
		{
			this.p0 = p0;
		}

		global::Com.Longtailvideo.Jwplayer.Events.RelatedPlayEvent p0;
		public global::Com.Longtailvideo.Jwplayer.Events.RelatedPlayEvent P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnRelatedPlayListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnRelatedPlayListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnRelatedPlayListener {

		object sender;

		public IVideoPlayerEventsOnRelatedPlayListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnRelatedPlayListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<VideoPlayerEventsOnRelatedPlayEventArgs> Handler;
#pragma warning restore 0649

		public void OnRelatedPlay (global::Com.Longtailvideo.Jwplayer.Events.RelatedPlayEvent p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new VideoPlayerEventsOnRelatedPlayEventArgs (p0));
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnRelatedPlayListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnSeekListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnSeekListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnSeekListenerInvoker")]
	public partial interface IVideoPlayerEventsOnSeekListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnSeekListener']/method[@name='onSeek' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onSeek", "(II)V", "GetOnSeek_IIHandler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnSeekListenerInvoker, JWBinding_AND")]
		void OnSeek (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnSeekListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnSeekListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnSeekListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnSeekListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnSeekListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnSeekListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnSeekListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnSeekListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnSeekListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSeek_II;
#pragma warning disable 0169
		static Delegate GetOnSeek_IIHandler ()
		{
			if (cb_onSeek_II == null)
				cb_onSeek_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnSeek_II);
			return cb_onSeek_II;
		}

		static void n_OnSeek_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnSeekListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnSeekListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSeek (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onSeek_II;
		public unsafe void OnSeek (int p0, int p1)
		{
			if (id_onSeek_II == IntPtr.Zero)
				id_onSeek_II = JNIEnv.GetMethodID (class_ref, "onSeek", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSeek_II, __args);
		}

	}

	public partial class VideoPlayerEventsOnSeekEventArgs : global::System.EventArgs {

		public VideoPlayerEventsOnSeekEventArgs (int p0, int p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		int p1;
		public int P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnSeekListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnSeekListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnSeekListener {

		object sender;

		public IVideoPlayerEventsOnSeekListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnSeekListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<VideoPlayerEventsOnSeekEventArgs> Handler;
#pragma warning restore 0649

		public void OnSeek (int p0, int p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new VideoPlayerEventsOnSeekEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnSeekListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnSeekedListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnSeekedListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnSeekedListenerInvoker")]
	public partial interface IVideoPlayerEventsOnSeekedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnSeekedListener']/method[@name='onSeeked' and count(parameter)=0]"
		[Register ("onSeeked", "()V", "GetOnSeekedHandler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnSeekedListenerInvoker, JWBinding_AND")]
		void OnSeeked ();

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnSeekedListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnSeekedListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnSeekedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnSeekedListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnSeekedListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnSeekedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnSeekedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnSeekedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnSeekedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSeeked;
#pragma warning disable 0169
		static Delegate GetOnSeekedHandler ()
		{
			if (cb_onSeeked == null)
				cb_onSeeked = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnSeeked);
			return cb_onSeeked;
		}

		static void n_OnSeeked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnSeekedListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnSeekedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSeeked ();
		}
#pragma warning restore 0169

		IntPtr id_onSeeked;
		public unsafe void OnSeeked ()
		{
			if (id_onSeeked == IntPtr.Zero)
				id_onSeeked = JNIEnv.GetMethodID (class_ref, "onSeeked", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSeeked);
		}

	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnSeekedListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnSeekedListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnSeekedListener {

		object sender;

		public IVideoPlayerEventsOnSeekedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnSeekedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void OnSeeked ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnSeekedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnSetupErrorListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnSetupErrorListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnSetupErrorListenerInvoker")]
	public partial interface IVideoPlayerEventsOnSetupErrorListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnSetupErrorListener']/method[@name='onSetupError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onSetupError", "(Ljava/lang/String;)V", "GetOnSetupError_Ljava_lang_String_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnSetupErrorListenerInvoker, JWBinding_AND")]
		void OnSetupError (string p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnSetupErrorListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnSetupErrorListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnSetupErrorListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnSetupErrorListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnSetupErrorListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnSetupErrorListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnSetupErrorListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnSetupErrorListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnSetupErrorListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onSetupError_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnSetupError_Ljava_lang_String_Handler ()
		{
			if (cb_onSetupError_Ljava_lang_String_ == null)
				cb_onSetupError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSetupError_Ljava_lang_String_);
			return cb_onSetupError_Ljava_lang_String_;
		}

		static void n_OnSetupError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnSetupErrorListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnSetupErrorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSetupError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSetupError_Ljava_lang_String_;
		public unsafe void OnSetupError (string p0)
		{
			if (id_onSetupError_Ljava_lang_String_ == IntPtr.Zero)
				id_onSetupError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onSetupError", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSetupError_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	public partial class VideoPlayerEventsOnSetupErrorEventArgs : global::System.EventArgs {

		public VideoPlayerEventsOnSetupErrorEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnSetupErrorListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnSetupErrorListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnSetupErrorListener {

		object sender;

		public IVideoPlayerEventsOnSetupErrorListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnSetupErrorListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<VideoPlayerEventsOnSetupErrorEventArgs> Handler;
#pragma warning restore 0649

		public void OnSetupError (string p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new VideoPlayerEventsOnSetupErrorEventArgs (p0));
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnSetupErrorListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnTimeListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnTimeListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnTimeListenerInvoker")]
	public partial interface IVideoPlayerEventsOnTimeListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnTimeListener']/method[@name='onTime' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("onTime", "(JJ)V", "GetOnTime_JJHandler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnTimeListenerInvoker, JWBinding_AND")]
		void OnTime (long p0, long p1);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnTimeListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnTimeListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnTimeListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnTimeListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnTimeListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnTimeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnTimeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnTimeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnTimeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onTime_JJ;
#pragma warning disable 0169
		static Delegate GetOnTime_JJHandler ()
		{
			if (cb_onTime_JJ == null)
				cb_onTime_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long>) n_OnTime_JJ);
			return cb_onTime_JJ;
		}

		static void n_OnTime_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnTimeListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnTimeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnTime (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onTime_JJ;
		public unsafe void OnTime (long p0, long p1)
		{
			if (id_onTime_JJ == IntPtr.Zero)
				id_onTime_JJ = JNIEnv.GetMethodID (class_ref, "onTime", "(JJ)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTime_JJ, __args);
		}

	}

	public partial class VideoPlayerEventsOnTimeEventArgs : global::System.EventArgs {

		public VideoPlayerEventsOnTimeEventArgs (long p0, long p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		long p0;
		public long P0 {
			get { return p0; }
		}

		long p1;
		public long P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnTimeListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnTimeListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnTimeListener {

		object sender;

		public IVideoPlayerEventsOnTimeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnTimeListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<VideoPlayerEventsOnTimeEventArgs> Handler;
#pragma warning restore 0649

		public void OnTime (long p0, long p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new VideoPlayerEventsOnTimeEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnTimeListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnVisualQualityListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnVisualQualityListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnVisualQualityListenerInvoker")]
	public partial interface IVideoPlayerEventsOnVisualQualityListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents.OnVisualQualityListener']/method[@name='onVisualQuality' and count(parameter)=1 and parameter[1][@type='com.longtailvideo.jwplayer.media.adaptive.VisualQuality']]"
		[Register ("onVisualQuality", "(Lcom/longtailvideo/jwplayer/media/adaptive/VisualQuality;)V", "GetOnVisualQuality_Lcom_longtailvideo_jwplayer_media_adaptive_VisualQuality_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnVisualQualityListenerInvoker, JWBinding_AND")]
		void OnVisualQuality (global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnVisualQualityListener", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsOnVisualQualityListenerInvoker : global::Java.Lang.Object, IVideoPlayerEventsOnVisualQualityListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents$OnVisualQualityListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsOnVisualQualityListenerInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEventsOnVisualQualityListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEventsOnVisualQualityListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents.OnVisualQualityListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsOnVisualQualityListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onVisualQuality_Lcom_longtailvideo_jwplayer_media_adaptive_VisualQuality_;
#pragma warning disable 0169
		static Delegate GetOnVisualQuality_Lcom_longtailvideo_jwplayer_media_adaptive_VisualQuality_Handler ()
		{
			if (cb_onVisualQuality_Lcom_longtailvideo_jwplayer_media_adaptive_VisualQuality_ == null)
				cb_onVisualQuality_Lcom_longtailvideo_jwplayer_media_adaptive_VisualQuality_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnVisualQuality_Lcom_longtailvideo_jwplayer_media_adaptive_VisualQuality_);
			return cb_onVisualQuality_Lcom_longtailvideo_jwplayer_media_adaptive_VisualQuality_;
		}

		static void n_OnVisualQuality_Lcom_longtailvideo_jwplayer_media_adaptive_VisualQuality_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnVisualQualityListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsOnVisualQualityListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality p0 = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnVisualQuality (p0);
		}
#pragma warning restore 0169

		IntPtr id_onVisualQuality_Lcom_longtailvideo_jwplayer_media_adaptive_VisualQuality_;
		public unsafe void OnVisualQuality (global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality p0)
		{
			if (id_onVisualQuality_Lcom_longtailvideo_jwplayer_media_adaptive_VisualQuality_ == IntPtr.Zero)
				id_onVisualQuality_Lcom_longtailvideo_jwplayer_media_adaptive_VisualQuality_ = JNIEnv.GetMethodID (class_ref, "onVisualQuality", "(Lcom/longtailvideo/jwplayer/media/adaptive/VisualQuality;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVisualQuality_Lcom_longtailvideo_jwplayer_media_adaptive_VisualQuality_, __args);
		}

	}

	public partial class VideoPlayerEventsOnVisualQualityEventArgs : global::System.EventArgs {

		public VideoPlayerEventsOnVisualQualityEventArgs (global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality p0)
		{
			this.p0 = p0;
		}

		global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality p0;
		public global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnVisualQualityListenerImplementor")]
	internal sealed partial class IVideoPlayerEventsOnVisualQualityListenerImplementor : global::Java.Lang.Object, IVideoPlayerEventsOnVisualQualityListener {

		object sender;

		public IVideoPlayerEventsOnVisualQualityListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents_OnVisualQualityListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<VideoPlayerEventsOnVisualQualityEventArgs> Handler;
#pragma warning restore 0649

		public void OnVisualQuality (global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new VideoPlayerEventsOnVisualQualityEventArgs (p0));
		}

		internal static bool __IsEmpty (IVideoPlayerEventsOnVisualQualityListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='VideoPlayerEvents']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IVideoPlayerEventsInvoker")]
	public partial interface IVideoPlayerEvents : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents", DoNotGenerateAcw=true)]
	internal class IVideoPlayerEventsInvoker : global::Java.Lang.Object, IVideoPlayerEvents {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/VideoPlayerEvents");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IVideoPlayerEventsInvoker); }
		}

		IntPtr class_ref;

		public static IVideoPlayerEvents GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IVideoPlayerEvents> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.VideoPlayerEvents"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IVideoPlayerEventsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
