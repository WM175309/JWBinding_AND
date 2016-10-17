using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Longtailvideo.Jwplayer.Events.Listeners {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdClickListener']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdClickListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdClickListenerInvoker")]
	public partial interface IAdvertisingEventsOnAdClickListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdClickListener']/method[@name='onAdClick' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
[Obsolete (@"deprecated")]
		[Register ("onAdClick", "(Ljava/lang/String;)V", "GetOnAdClick_Ljava_lang_String_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdClickListenerInvoker, JWBinding_AND")]
		void OnAdClick (string p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdClickListener", DoNotGenerateAcw=true)]
	internal class IAdvertisingEventsOnAdClickListenerInvoker : global::Java.Lang.Object, IAdvertisingEventsOnAdClickListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdClickListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdvertisingEventsOnAdClickListenerInvoker); }
		}

		IntPtr class_ref;

		public static IAdvertisingEventsOnAdClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdvertisingEventsOnAdClickListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.AdvertisingEvents.OnAdClickListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdvertisingEventsOnAdClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdClick_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAdClick_Ljava_lang_String_Handler ()
		{
			if (cb_onAdClick_Ljava_lang_String_ == null)
				cb_onAdClick_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdClick_Ljava_lang_String_);
			return cb_onAdClick_Ljava_lang_String_;
		}

		static void n_OnAdClick_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdClick (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdClick_Ljava_lang_String_;
		public unsafe void OnAdClick (string p0)
		{
			if (id_onAdClick_Ljava_lang_String_ == IntPtr.Zero)
				id_onAdClick_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAdClick", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdClick_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	public partial class AdvertisingEventsOnAdClickEventArgs : global::System.EventArgs {

		public AdvertisingEventsOnAdClickEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnAdClickListenerImplementor")]
	internal sealed partial class IAdvertisingEventsOnAdClickListenerImplementor : global::Java.Lang.Object, IAdvertisingEventsOnAdClickListener {

		object sender;

		public IAdvertisingEventsOnAdClickListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnAdClickListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AdvertisingEventsOnAdClickEventArgs> Handler;
#pragma warning restore 0649

		public void OnAdClick (string p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new AdvertisingEventsOnAdClickEventArgs (p0));
		}

		internal static bool __IsEmpty (IAdvertisingEventsOnAdClickListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdClickListenerV2']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdClickListenerV2", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdClickListenerV2Invoker")]
	public partial interface IAdvertisingEventsOnAdClickListenerV2 : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdClickListenerV2']/method[@name='onAdClick' and count(parameter)=1 and parameter[1][@type='com.longtailvideo.jwplayer.events.AdClickEvent']]"
		[Register ("onAdClick", "(Lcom/longtailvideo/jwplayer/events/AdClickEvent;)V", "GetOnAdClick_Lcom_longtailvideo_jwplayer_events_AdClickEvent_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdClickListenerV2Invoker, JWBinding_AND")]
		void OnAdClick (global::Com.Longtailvideo.Jwplayer.Events.AdClickEvent p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdClickListenerV2", DoNotGenerateAcw=true)]
	internal class IAdvertisingEventsOnAdClickListenerV2Invoker : global::Java.Lang.Object, IAdvertisingEventsOnAdClickListenerV2 {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdClickListenerV2");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdvertisingEventsOnAdClickListenerV2Invoker); }
		}

		IntPtr class_ref;

		public static IAdvertisingEventsOnAdClickListenerV2 GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdvertisingEventsOnAdClickListenerV2> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.AdvertisingEvents.OnAdClickListenerV2"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdvertisingEventsOnAdClickListenerV2Invoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdClick_Lcom_longtailvideo_jwplayer_events_AdClickEvent_;
#pragma warning disable 0169
		static Delegate GetOnAdClick_Lcom_longtailvideo_jwplayer_events_AdClickEvent_Handler ()
		{
			if (cb_onAdClick_Lcom_longtailvideo_jwplayer_events_AdClickEvent_ == null)
				cb_onAdClick_Lcom_longtailvideo_jwplayer_events_AdClickEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdClick_Lcom_longtailvideo_jwplayer_events_AdClickEvent_);
			return cb_onAdClick_Lcom_longtailvideo_jwplayer_events_AdClickEvent_;
		}

		static void n_OnAdClick_Lcom_longtailvideo_jwplayer_events_AdClickEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdClickListenerV2 __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdClickListenerV2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Longtailvideo.Jwplayer.Events.AdClickEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdClickEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdClick (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdClick_Lcom_longtailvideo_jwplayer_events_AdClickEvent_;
		public unsafe void OnAdClick (global::Com.Longtailvideo.Jwplayer.Events.AdClickEvent p0)
		{
			if (id_onAdClick_Lcom_longtailvideo_jwplayer_events_AdClickEvent_ == IntPtr.Zero)
				id_onAdClick_Lcom_longtailvideo_jwplayer_events_AdClickEvent_ = JNIEnv.GetMethodID (class_ref, "onAdClick", "(Lcom/longtailvideo/jwplayer/events/AdClickEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdClick_Lcom_longtailvideo_jwplayer_events_AdClickEvent_, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdCompleteListener']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdCompleteListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdCompleteListenerInvoker")]
	public partial interface IAdvertisingEventsOnAdCompleteListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdCompleteListener']/method[@name='onAdComplete' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
[Obsolete (@"deprecated")]
		[Register ("onAdComplete", "(Ljava/lang/String;)V", "GetOnAdComplete_Ljava_lang_String_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdCompleteListenerInvoker, JWBinding_AND")]
		void OnAdComplete (string p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdCompleteListener", DoNotGenerateAcw=true)]
	internal class IAdvertisingEventsOnAdCompleteListenerInvoker : global::Java.Lang.Object, IAdvertisingEventsOnAdCompleteListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdCompleteListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdvertisingEventsOnAdCompleteListenerInvoker); }
		}

		IntPtr class_ref;

		public static IAdvertisingEventsOnAdCompleteListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdvertisingEventsOnAdCompleteListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.AdvertisingEvents.OnAdCompleteListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdvertisingEventsOnAdCompleteListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdComplete_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAdComplete_Ljava_lang_String_Handler ()
		{
			if (cb_onAdComplete_Ljava_lang_String_ == null)
				cb_onAdComplete_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdComplete_Ljava_lang_String_);
			return cb_onAdComplete_Ljava_lang_String_;
		}

		static void n_OnAdComplete_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdCompleteListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdCompleteListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdComplete (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdComplete_Ljava_lang_String_;
		public unsafe void OnAdComplete (string p0)
		{
			if (id_onAdComplete_Ljava_lang_String_ == IntPtr.Zero)
				id_onAdComplete_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAdComplete", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdComplete_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	public partial class AdvertisingEventsOnAdCompleteEventArgs : global::System.EventArgs {

		public AdvertisingEventsOnAdCompleteEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnAdCompleteListenerImplementor")]
	internal sealed partial class IAdvertisingEventsOnAdCompleteListenerImplementor : global::Java.Lang.Object, IAdvertisingEventsOnAdCompleteListener {

		object sender;

		public IAdvertisingEventsOnAdCompleteListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnAdCompleteListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AdvertisingEventsOnAdCompleteEventArgs> Handler;
#pragma warning restore 0649

		public void OnAdComplete (string p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new AdvertisingEventsOnAdCompleteEventArgs (p0));
		}

		internal static bool __IsEmpty (IAdvertisingEventsOnAdCompleteListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdCompleteListenerV2']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdCompleteListenerV2", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdCompleteListenerV2Invoker")]
	public partial interface IAdvertisingEventsOnAdCompleteListenerV2 : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdCompleteListenerV2']/method[@name='onAdComplete' and count(parameter)=1 and parameter[1][@type='com.longtailvideo.jwplayer.events.AdCompleteEvent']]"
		[Register ("onAdComplete", "(Lcom/longtailvideo/jwplayer/events/AdCompleteEvent;)V", "GetOnAdComplete_Lcom_longtailvideo_jwplayer_events_AdCompleteEvent_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdCompleteListenerV2Invoker, JWBinding_AND")]
		void OnAdComplete (global::Com.Longtailvideo.Jwplayer.Events.AdCompleteEvent p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdCompleteListenerV2", DoNotGenerateAcw=true)]
	internal class IAdvertisingEventsOnAdCompleteListenerV2Invoker : global::Java.Lang.Object, IAdvertisingEventsOnAdCompleteListenerV2 {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdCompleteListenerV2");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdvertisingEventsOnAdCompleteListenerV2Invoker); }
		}

		IntPtr class_ref;

		public static IAdvertisingEventsOnAdCompleteListenerV2 GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdvertisingEventsOnAdCompleteListenerV2> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.AdvertisingEvents.OnAdCompleteListenerV2"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdvertisingEventsOnAdCompleteListenerV2Invoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdComplete_Lcom_longtailvideo_jwplayer_events_AdCompleteEvent_;
#pragma warning disable 0169
		static Delegate GetOnAdComplete_Lcom_longtailvideo_jwplayer_events_AdCompleteEvent_Handler ()
		{
			if (cb_onAdComplete_Lcom_longtailvideo_jwplayer_events_AdCompleteEvent_ == null)
				cb_onAdComplete_Lcom_longtailvideo_jwplayer_events_AdCompleteEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdComplete_Lcom_longtailvideo_jwplayer_events_AdCompleteEvent_);
			return cb_onAdComplete_Lcom_longtailvideo_jwplayer_events_AdCompleteEvent_;
		}

		static void n_OnAdComplete_Lcom_longtailvideo_jwplayer_events_AdCompleteEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdCompleteListenerV2 __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdCompleteListenerV2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Longtailvideo.Jwplayer.Events.AdCompleteEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdCompleteEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdComplete (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdComplete_Lcom_longtailvideo_jwplayer_events_AdCompleteEvent_;
		public unsafe void OnAdComplete (global::Com.Longtailvideo.Jwplayer.Events.AdCompleteEvent p0)
		{
			if (id_onAdComplete_Lcom_longtailvideo_jwplayer_events_AdCompleteEvent_ == IntPtr.Zero)
				id_onAdComplete_Lcom_longtailvideo_jwplayer_events_AdCompleteEvent_ = JNIEnv.GetMethodID (class_ref, "onAdComplete", "(Lcom/longtailvideo/jwplayer/events/AdCompleteEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdComplete_Lcom_longtailvideo_jwplayer_events_AdCompleteEvent_, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdErrorListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdErrorListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdErrorListenerInvoker")]
	public partial interface IAdvertisingEventsOnAdErrorListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdErrorListener']/method[@name='onAdError' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("onAdError", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOnAdError_Ljava_lang_String_Ljava_lang_String_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdErrorListenerInvoker, JWBinding_AND")]
		void OnAdError (string p0, string p1);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdErrorListener", DoNotGenerateAcw=true)]
	internal class IAdvertisingEventsOnAdErrorListenerInvoker : global::Java.Lang.Object, IAdvertisingEventsOnAdErrorListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdErrorListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdvertisingEventsOnAdErrorListenerInvoker); }
		}

		IntPtr class_ref;

		public static IAdvertisingEventsOnAdErrorListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdvertisingEventsOnAdErrorListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.AdvertisingEvents.OnAdErrorListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdvertisingEventsOnAdErrorListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdError_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAdError_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onAdError_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onAdError_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAdError_Ljava_lang_String_Ljava_lang_String_);
			return cb_onAdError_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnAdError_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdErrorListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdErrorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAdError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAdError_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnAdError (string p0, string p1)
		{
			if (id_onAdError_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onAdError_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAdError", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdError_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	public partial class AdvertisingEventsOnAdErrorEventArgs : global::System.EventArgs {

		public AdvertisingEventsOnAdErrorEventArgs (string p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnAdErrorListenerImplementor")]
	internal sealed partial class IAdvertisingEventsOnAdErrorListenerImplementor : global::Java.Lang.Object, IAdvertisingEventsOnAdErrorListener {

		object sender;

		public IAdvertisingEventsOnAdErrorListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnAdErrorListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AdvertisingEventsOnAdErrorEventArgs> Handler;
#pragma warning restore 0649

		public void OnAdError (string p0, string p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new AdvertisingEventsOnAdErrorEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IAdvertisingEventsOnAdErrorListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdImpressionListener']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdImpressionListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdImpressionListenerInvoker")]
	public partial interface IAdvertisingEventsOnAdImpressionListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdImpressionListener']/method[@name='onAdImpression' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
[Obsolete (@"deprecated")]
		[Register ("onAdImpression", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetOnAdImpression_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdImpressionListenerInvoker, JWBinding_AND")]
		void OnAdImpression (string p0, string p1, string p2);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdImpressionListener", DoNotGenerateAcw=true)]
	internal class IAdvertisingEventsOnAdImpressionListenerInvoker : global::Java.Lang.Object, IAdvertisingEventsOnAdImpressionListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdImpressionListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdvertisingEventsOnAdImpressionListenerInvoker); }
		}

		IntPtr class_ref;

		public static IAdvertisingEventsOnAdImpressionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdvertisingEventsOnAdImpressionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.AdvertisingEvents.OnAdImpressionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdvertisingEventsOnAdImpressionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdImpression_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAdImpression_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onAdImpression_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onAdImpression_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAdImpression_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_onAdImpression_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnAdImpression_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdImpressionListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdImpressionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnAdImpression (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onAdImpression_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnAdImpression (string p0, string p1, string p2)
		{
			if (id_onAdImpression_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onAdImpression_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAdImpression", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdImpression_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

	}

	public partial class AdvertisingEventsOnAdImpressionEventArgs : global::System.EventArgs {

		public AdvertisingEventsOnAdImpressionEventArgs (string p0, string p1, string p2)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}

		string p2;
		public string P2 {
			get { return p2; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnAdImpressionListenerImplementor")]
	internal sealed partial class IAdvertisingEventsOnAdImpressionListenerImplementor : global::Java.Lang.Object, IAdvertisingEventsOnAdImpressionListener {

		object sender;

		public IAdvertisingEventsOnAdImpressionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnAdImpressionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AdvertisingEventsOnAdImpressionEventArgs> Handler;
#pragma warning restore 0649

		public void OnAdImpression (string p0, string p1, string p2)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new AdvertisingEventsOnAdImpressionEventArgs (p0, p1, p2));
		}

		internal static bool __IsEmpty (IAdvertisingEventsOnAdImpressionListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdImpressionListenerV2']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdImpressionListenerV2", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdImpressionListenerV2Invoker")]
	public partial interface IAdvertisingEventsOnAdImpressionListenerV2 : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdImpressionListenerV2']/method[@name='onAdImpression' and count(parameter)=1 and parameter[1][@type='com.longtailvideo.jwplayer.events.AdImpressionEvent']]"
		[Register ("onAdImpression", "(Lcom/longtailvideo/jwplayer/events/AdImpressionEvent;)V", "GetOnAdImpression_Lcom_longtailvideo_jwplayer_events_AdImpressionEvent_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdImpressionListenerV2Invoker, JWBinding_AND")]
		void OnAdImpression (global::Com.Longtailvideo.Jwplayer.Events.AdImpressionEvent p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdImpressionListenerV2", DoNotGenerateAcw=true)]
	internal class IAdvertisingEventsOnAdImpressionListenerV2Invoker : global::Java.Lang.Object, IAdvertisingEventsOnAdImpressionListenerV2 {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdImpressionListenerV2");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdvertisingEventsOnAdImpressionListenerV2Invoker); }
		}

		IntPtr class_ref;

		public static IAdvertisingEventsOnAdImpressionListenerV2 GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdvertisingEventsOnAdImpressionListenerV2> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.AdvertisingEvents.OnAdImpressionListenerV2"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdvertisingEventsOnAdImpressionListenerV2Invoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdImpression_Lcom_longtailvideo_jwplayer_events_AdImpressionEvent_;
#pragma warning disable 0169
		static Delegate GetOnAdImpression_Lcom_longtailvideo_jwplayer_events_AdImpressionEvent_Handler ()
		{
			if (cb_onAdImpression_Lcom_longtailvideo_jwplayer_events_AdImpressionEvent_ == null)
				cb_onAdImpression_Lcom_longtailvideo_jwplayer_events_AdImpressionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdImpression_Lcom_longtailvideo_jwplayer_events_AdImpressionEvent_);
			return cb_onAdImpression_Lcom_longtailvideo_jwplayer_events_AdImpressionEvent_;
		}

		static void n_OnAdImpression_Lcom_longtailvideo_jwplayer_events_AdImpressionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdImpressionListenerV2 __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdImpressionListenerV2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Longtailvideo.Jwplayer.Events.AdImpressionEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdImpressionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdImpression (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdImpression_Lcom_longtailvideo_jwplayer_events_AdImpressionEvent_;
		public unsafe void OnAdImpression (global::Com.Longtailvideo.Jwplayer.Events.AdImpressionEvent p0)
		{
			if (id_onAdImpression_Lcom_longtailvideo_jwplayer_events_AdImpressionEvent_ == IntPtr.Zero)
				id_onAdImpression_Lcom_longtailvideo_jwplayer_events_AdImpressionEvent_ = JNIEnv.GetMethodID (class_ref, "onAdImpression", "(Lcom/longtailvideo/jwplayer/events/AdImpressionEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdImpression_Lcom_longtailvideo_jwplayer_events_AdImpressionEvent_, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdPauseListener']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdPauseListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdPauseListenerInvoker")]
	public partial interface IAdvertisingEventsOnAdPauseListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdPauseListener']/method[@name='onAdPause' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.longtailvideo.jwplayer.core.PlayerState']]"
[Obsolete (@"deprecated")]
		[Register ("onAdPause", "(Ljava/lang/String;Lcom/longtailvideo/jwplayer/core/PlayerState;)V", "GetOnAdPause_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdPauseListenerInvoker, JWBinding_AND")]
		void OnAdPause (string p0, global::Com.Longtailvideo.Jwplayer.Core.PlayerState p1);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdPauseListener", DoNotGenerateAcw=true)]
	internal class IAdvertisingEventsOnAdPauseListenerInvoker : global::Java.Lang.Object, IAdvertisingEventsOnAdPauseListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdPauseListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdvertisingEventsOnAdPauseListenerInvoker); }
		}

		IntPtr class_ref;

		public static IAdvertisingEventsOnAdPauseListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdvertisingEventsOnAdPauseListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.AdvertisingEvents.OnAdPauseListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdvertisingEventsOnAdPauseListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdPause_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_;
#pragma warning disable 0169
		static Delegate GetOnAdPause_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_Handler ()
		{
			if (cb_onAdPause_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_ == null)
				cb_onAdPause_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAdPause_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_);
			return cb_onAdPause_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_;
		}

		static void n_OnAdPause_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdPauseListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdPauseListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Longtailvideo.Jwplayer.Core.PlayerState p1 = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Core.PlayerState> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAdPause (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAdPause_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_;
		public unsafe void OnAdPause (string p0, global::Com.Longtailvideo.Jwplayer.Core.PlayerState p1)
		{
			if (id_onAdPause_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_ == IntPtr.Zero)
				id_onAdPause_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_ = JNIEnv.GetMethodID (class_ref, "onAdPause", "(Ljava/lang/String;Lcom/longtailvideo/jwplayer/core/PlayerState;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdPause_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	public partial class AdvertisingEventsOnAdPauseEventArgs : global::System.EventArgs {

		public AdvertisingEventsOnAdPauseEventArgs (string p0, global::Com.Longtailvideo.Jwplayer.Core.PlayerState p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::Com.Longtailvideo.Jwplayer.Core.PlayerState p1;
		public global::Com.Longtailvideo.Jwplayer.Core.PlayerState P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnAdPauseListenerImplementor")]
	internal sealed partial class IAdvertisingEventsOnAdPauseListenerImplementor : global::Java.Lang.Object, IAdvertisingEventsOnAdPauseListener {

		object sender;

		public IAdvertisingEventsOnAdPauseListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnAdPauseListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AdvertisingEventsOnAdPauseEventArgs> Handler;
#pragma warning restore 0649

		public void OnAdPause (string p0, global::Com.Longtailvideo.Jwplayer.Core.PlayerState p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new AdvertisingEventsOnAdPauseEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IAdvertisingEventsOnAdPauseListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdPauseListenerV2']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdPauseListenerV2", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdPauseListenerV2Invoker")]
	public partial interface IAdvertisingEventsOnAdPauseListenerV2 : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdPauseListenerV2']/method[@name='onAdPause' and count(parameter)=1 and parameter[1][@type='com.longtailvideo.jwplayer.events.AdPauseEvent']]"
		[Register ("onAdPause", "(Lcom/longtailvideo/jwplayer/events/AdPauseEvent;)V", "GetOnAdPause_Lcom_longtailvideo_jwplayer_events_AdPauseEvent_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdPauseListenerV2Invoker, JWBinding_AND")]
		void OnAdPause (global::Com.Longtailvideo.Jwplayer.Events.AdPauseEvent p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdPauseListenerV2", DoNotGenerateAcw=true)]
	internal class IAdvertisingEventsOnAdPauseListenerV2Invoker : global::Java.Lang.Object, IAdvertisingEventsOnAdPauseListenerV2 {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdPauseListenerV2");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdvertisingEventsOnAdPauseListenerV2Invoker); }
		}

		IntPtr class_ref;

		public static IAdvertisingEventsOnAdPauseListenerV2 GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdvertisingEventsOnAdPauseListenerV2> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.AdvertisingEvents.OnAdPauseListenerV2"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdvertisingEventsOnAdPauseListenerV2Invoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdPause_Lcom_longtailvideo_jwplayer_events_AdPauseEvent_;
#pragma warning disable 0169
		static Delegate GetOnAdPause_Lcom_longtailvideo_jwplayer_events_AdPauseEvent_Handler ()
		{
			if (cb_onAdPause_Lcom_longtailvideo_jwplayer_events_AdPauseEvent_ == null)
				cb_onAdPause_Lcom_longtailvideo_jwplayer_events_AdPauseEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdPause_Lcom_longtailvideo_jwplayer_events_AdPauseEvent_);
			return cb_onAdPause_Lcom_longtailvideo_jwplayer_events_AdPauseEvent_;
		}

		static void n_OnAdPause_Lcom_longtailvideo_jwplayer_events_AdPauseEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdPauseListenerV2 __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdPauseListenerV2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Longtailvideo.Jwplayer.Events.AdPauseEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdPauseEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdPause (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdPause_Lcom_longtailvideo_jwplayer_events_AdPauseEvent_;
		public unsafe void OnAdPause (global::Com.Longtailvideo.Jwplayer.Events.AdPauseEvent p0)
		{
			if (id_onAdPause_Lcom_longtailvideo_jwplayer_events_AdPauseEvent_ == IntPtr.Zero)
				id_onAdPause_Lcom_longtailvideo_jwplayer_events_AdPauseEvent_ = JNIEnv.GetMethodID (class_ref, "onAdPause", "(Lcom/longtailvideo/jwplayer/events/AdPauseEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdPause_Lcom_longtailvideo_jwplayer_events_AdPauseEvent_, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdPlayListener']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdPlayListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdPlayListenerInvoker")]
	public partial interface IAdvertisingEventsOnAdPlayListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdPlayListener']/method[@name='onAdPlay' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.longtailvideo.jwplayer.core.PlayerState']]"
[Obsolete (@"deprecated")]
		[Register ("onAdPlay", "(Ljava/lang/String;Lcom/longtailvideo/jwplayer/core/PlayerState;)V", "GetOnAdPlay_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdPlayListenerInvoker, JWBinding_AND")]
		void OnAdPlay (string p0, global::Com.Longtailvideo.Jwplayer.Core.PlayerState p1);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdPlayListener", DoNotGenerateAcw=true)]
	internal class IAdvertisingEventsOnAdPlayListenerInvoker : global::Java.Lang.Object, IAdvertisingEventsOnAdPlayListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdPlayListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdvertisingEventsOnAdPlayListenerInvoker); }
		}

		IntPtr class_ref;

		public static IAdvertisingEventsOnAdPlayListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdvertisingEventsOnAdPlayListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.AdvertisingEvents.OnAdPlayListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdvertisingEventsOnAdPlayListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdPlay_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_;
#pragma warning disable 0169
		static Delegate GetOnAdPlay_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_Handler ()
		{
			if (cb_onAdPlay_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_ == null)
				cb_onAdPlay_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAdPlay_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_);
			return cb_onAdPlay_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_;
		}

		static void n_OnAdPlay_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdPlayListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdPlayListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Longtailvideo.Jwplayer.Core.PlayerState p1 = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Core.PlayerState> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAdPlay (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAdPlay_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_;
		public unsafe void OnAdPlay (string p0, global::Com.Longtailvideo.Jwplayer.Core.PlayerState p1)
		{
			if (id_onAdPlay_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_ == IntPtr.Zero)
				id_onAdPlay_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_ = JNIEnv.GetMethodID (class_ref, "onAdPlay", "(Ljava/lang/String;Lcom/longtailvideo/jwplayer/core/PlayerState;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdPlay_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	public partial class AdvertisingEventsOnAdPlayEventArgs : global::System.EventArgs {

		public AdvertisingEventsOnAdPlayEventArgs (string p0, global::Com.Longtailvideo.Jwplayer.Core.PlayerState p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::Com.Longtailvideo.Jwplayer.Core.PlayerState p1;
		public global::Com.Longtailvideo.Jwplayer.Core.PlayerState P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnAdPlayListenerImplementor")]
	internal sealed partial class IAdvertisingEventsOnAdPlayListenerImplementor : global::Java.Lang.Object, IAdvertisingEventsOnAdPlayListener {

		object sender;

		public IAdvertisingEventsOnAdPlayListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnAdPlayListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AdvertisingEventsOnAdPlayEventArgs> Handler;
#pragma warning restore 0649

		public void OnAdPlay (string p0, global::Com.Longtailvideo.Jwplayer.Core.PlayerState p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new AdvertisingEventsOnAdPlayEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IAdvertisingEventsOnAdPlayListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdPlayListenerV2']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdPlayListenerV2", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdPlayListenerV2Invoker")]
	public partial interface IAdvertisingEventsOnAdPlayListenerV2 : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdPlayListenerV2']/method[@name='onAdPlay' and count(parameter)=1 and parameter[1][@type='com.longtailvideo.jwplayer.events.AdPlayEvent']]"
		[Register ("onAdPlay", "(Lcom/longtailvideo/jwplayer/events/AdPlayEvent;)V", "GetOnAdPlay_Lcom_longtailvideo_jwplayer_events_AdPlayEvent_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdPlayListenerV2Invoker, JWBinding_AND")]
		void OnAdPlay (global::Com.Longtailvideo.Jwplayer.Events.AdPlayEvent p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdPlayListenerV2", DoNotGenerateAcw=true)]
	internal class IAdvertisingEventsOnAdPlayListenerV2Invoker : global::Java.Lang.Object, IAdvertisingEventsOnAdPlayListenerV2 {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdPlayListenerV2");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdvertisingEventsOnAdPlayListenerV2Invoker); }
		}

		IntPtr class_ref;

		public static IAdvertisingEventsOnAdPlayListenerV2 GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdvertisingEventsOnAdPlayListenerV2> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.AdvertisingEvents.OnAdPlayListenerV2"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdvertisingEventsOnAdPlayListenerV2Invoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdPlay_Lcom_longtailvideo_jwplayer_events_AdPlayEvent_;
#pragma warning disable 0169
		static Delegate GetOnAdPlay_Lcom_longtailvideo_jwplayer_events_AdPlayEvent_Handler ()
		{
			if (cb_onAdPlay_Lcom_longtailvideo_jwplayer_events_AdPlayEvent_ == null)
				cb_onAdPlay_Lcom_longtailvideo_jwplayer_events_AdPlayEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdPlay_Lcom_longtailvideo_jwplayer_events_AdPlayEvent_);
			return cb_onAdPlay_Lcom_longtailvideo_jwplayer_events_AdPlayEvent_;
		}

		static void n_OnAdPlay_Lcom_longtailvideo_jwplayer_events_AdPlayEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdPlayListenerV2 __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdPlayListenerV2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Longtailvideo.Jwplayer.Events.AdPlayEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdPlayEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdPlay (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdPlay_Lcom_longtailvideo_jwplayer_events_AdPlayEvent_;
		public unsafe void OnAdPlay (global::Com.Longtailvideo.Jwplayer.Events.AdPlayEvent p0)
		{
			if (id_onAdPlay_Lcom_longtailvideo_jwplayer_events_AdPlayEvent_ == IntPtr.Zero)
				id_onAdPlay_Lcom_longtailvideo_jwplayer_events_AdPlayEvent_ = JNIEnv.GetMethodID (class_ref, "onAdPlay", "(Lcom/longtailvideo/jwplayer/events/AdPlayEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdPlay_Lcom_longtailvideo_jwplayer_events_AdPlayEvent_, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdRequestListener']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdRequestListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdRequestListenerInvoker")]
	public partial interface IAdvertisingEventsOnAdRequestListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdRequestListener']/method[@name='onAdRequest' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
[Obsolete (@"deprecated")]
		[Register ("onAdRequest", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOnAdRequest_Ljava_lang_String_Ljava_lang_String_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdRequestListenerInvoker, JWBinding_AND")]
		void OnAdRequest (string p0, string p1);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdRequestListener", DoNotGenerateAcw=true)]
	internal class IAdvertisingEventsOnAdRequestListenerInvoker : global::Java.Lang.Object, IAdvertisingEventsOnAdRequestListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdRequestListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdvertisingEventsOnAdRequestListenerInvoker); }
		}

		IntPtr class_ref;

		public static IAdvertisingEventsOnAdRequestListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdvertisingEventsOnAdRequestListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.AdvertisingEvents.OnAdRequestListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdvertisingEventsOnAdRequestListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdRequest_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAdRequest_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onAdRequest_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onAdRequest_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAdRequest_Ljava_lang_String_Ljava_lang_String_);
			return cb_onAdRequest_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnAdRequest_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdRequestListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdRequestListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAdRequest (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAdRequest_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnAdRequest (string p0, string p1)
		{
			if (id_onAdRequest_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onAdRequest_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAdRequest", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdRequest_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	public partial class AdvertisingEventsOnAdRequestEventArgs : global::System.EventArgs {

		public AdvertisingEventsOnAdRequestEventArgs (string p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnAdRequestListenerImplementor")]
	internal sealed partial class IAdvertisingEventsOnAdRequestListenerImplementor : global::Java.Lang.Object, IAdvertisingEventsOnAdRequestListener {

		object sender;

		public IAdvertisingEventsOnAdRequestListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnAdRequestListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AdvertisingEventsOnAdRequestEventArgs> Handler;
#pragma warning restore 0649

		public void OnAdRequest (string p0, string p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new AdvertisingEventsOnAdRequestEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IAdvertisingEventsOnAdRequestListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdRequestListenerV2']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdRequestListenerV2", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdRequestListenerV2Invoker")]
	public partial interface IAdvertisingEventsOnAdRequestListenerV2 : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdRequestListenerV2']/method[@name='onAdRequest' and count(parameter)=1 and parameter[1][@type='com.longtailvideo.jwplayer.events.AdRequestEvent']]"
		[Register ("onAdRequest", "(Lcom/longtailvideo/jwplayer/events/AdRequestEvent;)V", "GetOnAdRequest_Lcom_longtailvideo_jwplayer_events_AdRequestEvent_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdRequestListenerV2Invoker, JWBinding_AND")]
		void OnAdRequest (global::Com.Longtailvideo.Jwplayer.Events.AdRequestEvent p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdRequestListenerV2", DoNotGenerateAcw=true)]
	internal class IAdvertisingEventsOnAdRequestListenerV2Invoker : global::Java.Lang.Object, IAdvertisingEventsOnAdRequestListenerV2 {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdRequestListenerV2");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdvertisingEventsOnAdRequestListenerV2Invoker); }
		}

		IntPtr class_ref;

		public static IAdvertisingEventsOnAdRequestListenerV2 GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdvertisingEventsOnAdRequestListenerV2> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.AdvertisingEvents.OnAdRequestListenerV2"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdvertisingEventsOnAdRequestListenerV2Invoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdRequest_Lcom_longtailvideo_jwplayer_events_AdRequestEvent_;
#pragma warning disable 0169
		static Delegate GetOnAdRequest_Lcom_longtailvideo_jwplayer_events_AdRequestEvent_Handler ()
		{
			if (cb_onAdRequest_Lcom_longtailvideo_jwplayer_events_AdRequestEvent_ == null)
				cb_onAdRequest_Lcom_longtailvideo_jwplayer_events_AdRequestEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdRequest_Lcom_longtailvideo_jwplayer_events_AdRequestEvent_);
			return cb_onAdRequest_Lcom_longtailvideo_jwplayer_events_AdRequestEvent_;
		}

		static void n_OnAdRequest_Lcom_longtailvideo_jwplayer_events_AdRequestEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdRequestListenerV2 __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdRequestListenerV2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Longtailvideo.Jwplayer.Events.AdRequestEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdRequestEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdRequest (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdRequest_Lcom_longtailvideo_jwplayer_events_AdRequestEvent_;
		public unsafe void OnAdRequest (global::Com.Longtailvideo.Jwplayer.Events.AdRequestEvent p0)
		{
			if (id_onAdRequest_Lcom_longtailvideo_jwplayer_events_AdRequestEvent_ == IntPtr.Zero)
				id_onAdRequest_Lcom_longtailvideo_jwplayer_events_AdRequestEvent_ = JNIEnv.GetMethodID (class_ref, "onAdRequest", "(Lcom/longtailvideo/jwplayer/events/AdRequestEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdRequest_Lcom_longtailvideo_jwplayer_events_AdRequestEvent_, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdSkippedListener']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdSkippedListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdSkippedListenerInvoker")]
	public partial interface IAdvertisingEventsOnAdSkippedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdSkippedListener']/method[@name='onAdSkipped' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
[Obsolete (@"deprecated")]
		[Register ("onAdSkipped", "(Ljava/lang/String;)V", "GetOnAdSkipped_Ljava_lang_String_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdSkippedListenerInvoker, JWBinding_AND")]
		void OnAdSkipped (string p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdSkippedListener", DoNotGenerateAcw=true)]
	internal class IAdvertisingEventsOnAdSkippedListenerInvoker : global::Java.Lang.Object, IAdvertisingEventsOnAdSkippedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdSkippedListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdvertisingEventsOnAdSkippedListenerInvoker); }
		}

		IntPtr class_ref;

		public static IAdvertisingEventsOnAdSkippedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdvertisingEventsOnAdSkippedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.AdvertisingEvents.OnAdSkippedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdvertisingEventsOnAdSkippedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdSkipped_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAdSkipped_Ljava_lang_String_Handler ()
		{
			if (cb_onAdSkipped_Ljava_lang_String_ == null)
				cb_onAdSkipped_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdSkipped_Ljava_lang_String_);
			return cb_onAdSkipped_Ljava_lang_String_;
		}

		static void n_OnAdSkipped_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdSkippedListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdSkippedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdSkipped (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdSkipped_Ljava_lang_String_;
		public unsafe void OnAdSkipped (string p0)
		{
			if (id_onAdSkipped_Ljava_lang_String_ == IntPtr.Zero)
				id_onAdSkipped_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAdSkipped", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdSkipped_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	public partial class AdvertisingEventsOnAdSkippedEventArgs : global::System.EventArgs {

		public AdvertisingEventsOnAdSkippedEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnAdSkippedListenerImplementor")]
	internal sealed partial class IAdvertisingEventsOnAdSkippedListenerImplementor : global::Java.Lang.Object, IAdvertisingEventsOnAdSkippedListener {

		object sender;

		public IAdvertisingEventsOnAdSkippedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnAdSkippedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AdvertisingEventsOnAdSkippedEventArgs> Handler;
#pragma warning restore 0649

		public void OnAdSkipped (string p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new AdvertisingEventsOnAdSkippedEventArgs (p0));
		}

		internal static bool __IsEmpty (IAdvertisingEventsOnAdSkippedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdSkippedListenerV2']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdSkippedListenerV2", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdSkippedListenerV2Invoker")]
	public partial interface IAdvertisingEventsOnAdSkippedListenerV2 : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdSkippedListenerV2']/method[@name='onAdSkipped' and count(parameter)=1 and parameter[1][@type='com.longtailvideo.jwplayer.events.AdSkippedEvent']]"
		[Register ("onAdSkipped", "(Lcom/longtailvideo/jwplayer/events/AdSkippedEvent;)V", "GetOnAdSkipped_Lcom_longtailvideo_jwplayer_events_AdSkippedEvent_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdSkippedListenerV2Invoker, JWBinding_AND")]
		void OnAdSkipped (global::Com.Longtailvideo.Jwplayer.Events.AdSkippedEvent p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdSkippedListenerV2", DoNotGenerateAcw=true)]
	internal class IAdvertisingEventsOnAdSkippedListenerV2Invoker : global::Java.Lang.Object, IAdvertisingEventsOnAdSkippedListenerV2 {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdSkippedListenerV2");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdvertisingEventsOnAdSkippedListenerV2Invoker); }
		}

		IntPtr class_ref;

		public static IAdvertisingEventsOnAdSkippedListenerV2 GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdvertisingEventsOnAdSkippedListenerV2> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.AdvertisingEvents.OnAdSkippedListenerV2"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdvertisingEventsOnAdSkippedListenerV2Invoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdSkipped_Lcom_longtailvideo_jwplayer_events_AdSkippedEvent_;
#pragma warning disable 0169
		static Delegate GetOnAdSkipped_Lcom_longtailvideo_jwplayer_events_AdSkippedEvent_Handler ()
		{
			if (cb_onAdSkipped_Lcom_longtailvideo_jwplayer_events_AdSkippedEvent_ == null)
				cb_onAdSkipped_Lcom_longtailvideo_jwplayer_events_AdSkippedEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdSkipped_Lcom_longtailvideo_jwplayer_events_AdSkippedEvent_);
			return cb_onAdSkipped_Lcom_longtailvideo_jwplayer_events_AdSkippedEvent_;
		}

		static void n_OnAdSkipped_Lcom_longtailvideo_jwplayer_events_AdSkippedEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdSkippedListenerV2 __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdSkippedListenerV2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Longtailvideo.Jwplayer.Events.AdSkippedEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdSkippedEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdSkipped (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdSkipped_Lcom_longtailvideo_jwplayer_events_AdSkippedEvent_;
		public unsafe void OnAdSkipped (global::Com.Longtailvideo.Jwplayer.Events.AdSkippedEvent p0)
		{
			if (id_onAdSkipped_Lcom_longtailvideo_jwplayer_events_AdSkippedEvent_ == IntPtr.Zero)
				id_onAdSkipped_Lcom_longtailvideo_jwplayer_events_AdSkippedEvent_ = JNIEnv.GetMethodID (class_ref, "onAdSkipped", "(Lcom/longtailvideo/jwplayer/events/AdSkippedEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdSkipped_Lcom_longtailvideo_jwplayer_events_AdSkippedEvent_, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdStartedListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdStartedListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdStartedListenerInvoker")]
	public partial interface IAdvertisingEventsOnAdStartedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdStartedListener']/method[@name='onAdStarted' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("onAdStarted", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOnAdStarted_Ljava_lang_String_Ljava_lang_String_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdStartedListenerInvoker, JWBinding_AND")]
		void OnAdStarted (string p0, string p1);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdStartedListener", DoNotGenerateAcw=true)]
	internal class IAdvertisingEventsOnAdStartedListenerInvoker : global::Java.Lang.Object, IAdvertisingEventsOnAdStartedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdStartedListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdvertisingEventsOnAdStartedListenerInvoker); }
		}

		IntPtr class_ref;

		public static IAdvertisingEventsOnAdStartedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdvertisingEventsOnAdStartedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.AdvertisingEvents.OnAdStartedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdvertisingEventsOnAdStartedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdStarted_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnAdStarted_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onAdStarted_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onAdStarted_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnAdStarted_Ljava_lang_String_Ljava_lang_String_);
			return cb_onAdStarted_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnAdStarted_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdStartedListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdStartedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAdStarted (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAdStarted_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnAdStarted (string p0, string p1)
		{
			if (id_onAdStarted_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onAdStarted_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onAdStarted", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdStarted_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

	public partial class AdvertisingEventsOnAdStartedEventArgs : global::System.EventArgs {

		public AdvertisingEventsOnAdStartedEventArgs (string p0, string p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		string p1;
		public string P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnAdStartedListenerImplementor")]
	internal sealed partial class IAdvertisingEventsOnAdStartedListenerImplementor : global::Java.Lang.Object, IAdvertisingEventsOnAdStartedListener {

		object sender;

		public IAdvertisingEventsOnAdStartedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnAdStartedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AdvertisingEventsOnAdStartedEventArgs> Handler;
#pragma warning restore 0649

		public void OnAdStarted (string p0, string p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new AdvertisingEventsOnAdStartedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (IAdvertisingEventsOnAdStartedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdTimeListener']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdTimeListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdTimeListenerInvoker")]
	public partial interface IAdvertisingEventsOnAdTimeListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdTimeListener']/method[@name='onAdTime' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='int']]"
[Obsolete (@"deprecated")]
		[Register ("onAdTime", "(Ljava/lang/String;JJI)V", "GetOnAdTime_Ljava_lang_String_JJIHandler:Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdTimeListenerInvoker, JWBinding_AND")]
		void OnAdTime (string p0, long p1, long p2, int p3);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdTimeListener", DoNotGenerateAcw=true)]
	internal class IAdvertisingEventsOnAdTimeListenerInvoker : global::Java.Lang.Object, IAdvertisingEventsOnAdTimeListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdTimeListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdvertisingEventsOnAdTimeListenerInvoker); }
		}

		IntPtr class_ref;

		public static IAdvertisingEventsOnAdTimeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdvertisingEventsOnAdTimeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.AdvertisingEvents.OnAdTimeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdvertisingEventsOnAdTimeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdTime_Ljava_lang_String_JJI;
#pragma warning disable 0169
		static Delegate GetOnAdTime_Ljava_lang_String_JJIHandler ()
		{
			if (cb_onAdTime_Ljava_lang_String_JJI == null)
				cb_onAdTime_Ljava_lang_String_JJI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, long, int>) n_OnAdTime_Ljava_lang_String_JJI);
			return cb_onAdTime_Ljava_lang_String_JJI;
		}

		static void n_OnAdTime_Ljava_lang_String_JJI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2, int p3)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdTimeListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdTimeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdTime (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onAdTime_Ljava_lang_String_JJI;
		public unsafe void OnAdTime (string p0, long p1, long p2, int p3)
		{
			if (id_onAdTime_Ljava_lang_String_JJI == IntPtr.Zero)
				id_onAdTime_Ljava_lang_String_JJI = JNIEnv.GetMethodID (class_ref, "onAdTime", "(Ljava/lang/String;JJI)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdTime_Ljava_lang_String_JJI, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	public partial class AdvertisingEventsOnAdTimeEventArgs : global::System.EventArgs {

		public AdvertisingEventsOnAdTimeEventArgs (string p0, long p1, long p2, int p3)
		{
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		string p0;
		public string P0 {
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

		int p3;
		public int P3 {
			get { return p3; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnAdTimeListenerImplementor")]
	internal sealed partial class IAdvertisingEventsOnAdTimeListenerImplementor : global::Java.Lang.Object, IAdvertisingEventsOnAdTimeListener {

		object sender;

		public IAdvertisingEventsOnAdTimeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnAdTimeListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AdvertisingEventsOnAdTimeEventArgs> Handler;
#pragma warning restore 0649

		public void OnAdTime (string p0, long p1, long p2, int p3)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new AdvertisingEventsOnAdTimeEventArgs (p0, p1, p2, p3));
		}

		internal static bool __IsEmpty (IAdvertisingEventsOnAdTimeListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdTimeListenerV2']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdTimeListenerV2", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdTimeListenerV2Invoker")]
	public partial interface IAdvertisingEventsOnAdTimeListenerV2 : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnAdTimeListenerV2']/method[@name='onAdTime' and count(parameter)=1 and parameter[1][@type='com.longtailvideo.jwplayer.events.AdTimeEvent']]"
		[Register ("onAdTime", "(Lcom/longtailvideo/jwplayer/events/AdTimeEvent;)V", "GetOnAdTime_Lcom_longtailvideo_jwplayer_events_AdTimeEvent_Handler:Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdTimeListenerV2Invoker, JWBinding_AND")]
		void OnAdTime (global::Com.Longtailvideo.Jwplayer.Events.AdTimeEvent p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdTimeListenerV2", DoNotGenerateAcw=true)]
	internal class IAdvertisingEventsOnAdTimeListenerV2Invoker : global::Java.Lang.Object, IAdvertisingEventsOnAdTimeListenerV2 {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnAdTimeListenerV2");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdvertisingEventsOnAdTimeListenerV2Invoker); }
		}

		IntPtr class_ref;

		public static IAdvertisingEventsOnAdTimeListenerV2 GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdvertisingEventsOnAdTimeListenerV2> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.AdvertisingEvents.OnAdTimeListenerV2"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdvertisingEventsOnAdTimeListenerV2Invoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdTime_Lcom_longtailvideo_jwplayer_events_AdTimeEvent_;
#pragma warning disable 0169
		static Delegate GetOnAdTime_Lcom_longtailvideo_jwplayer_events_AdTimeEvent_Handler ()
		{
			if (cb_onAdTime_Lcom_longtailvideo_jwplayer_events_AdTimeEvent_ == null)
				cb_onAdTime_Lcom_longtailvideo_jwplayer_events_AdTimeEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdTime_Lcom_longtailvideo_jwplayer_events_AdTimeEvent_);
			return cb_onAdTime_Lcom_longtailvideo_jwplayer_events_AdTimeEvent_;
		}

		static void n_OnAdTime_Lcom_longtailvideo_jwplayer_events_AdTimeEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdTimeListenerV2 __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnAdTimeListenerV2> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Longtailvideo.Jwplayer.Events.AdTimeEvent p0 = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdTimeEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdTime (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdTime_Lcom_longtailvideo_jwplayer_events_AdTimeEvent_;
		public unsafe void OnAdTime (global::Com.Longtailvideo.Jwplayer.Events.AdTimeEvent p0)
		{
			if (id_onAdTime_Lcom_longtailvideo_jwplayer_events_AdTimeEvent_ == IntPtr.Zero)
				id_onAdTime_Lcom_longtailvideo_jwplayer_events_AdTimeEvent_ = JNIEnv.GetMethodID (class_ref, "onAdTime", "(Lcom/longtailvideo/jwplayer/events/AdTimeEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdTime_Lcom_longtailvideo_jwplayer_events_AdTimeEvent_, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnBeforeCompleteListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnBeforeCompleteListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnBeforeCompleteListenerInvoker")]
	public partial interface IAdvertisingEventsOnBeforeCompleteListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnBeforeCompleteListener']/method[@name='onBeforeComplete' and count(parameter)=0]"
		[Register ("onBeforeComplete", "()V", "GetOnBeforeCompleteHandler:Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnBeforeCompleteListenerInvoker, JWBinding_AND")]
		void OnBeforeComplete ();

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnBeforeCompleteListener", DoNotGenerateAcw=true)]
	internal class IAdvertisingEventsOnBeforeCompleteListenerInvoker : global::Java.Lang.Object, IAdvertisingEventsOnBeforeCompleteListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnBeforeCompleteListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdvertisingEventsOnBeforeCompleteListenerInvoker); }
		}

		IntPtr class_ref;

		public static IAdvertisingEventsOnBeforeCompleteListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdvertisingEventsOnBeforeCompleteListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.AdvertisingEvents.OnBeforeCompleteListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdvertisingEventsOnBeforeCompleteListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBeforeComplete;
#pragma warning disable 0169
		static Delegate GetOnBeforeCompleteHandler ()
		{
			if (cb_onBeforeComplete == null)
				cb_onBeforeComplete = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBeforeComplete);
			return cb_onBeforeComplete;
		}

		static void n_OnBeforeComplete (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnBeforeCompleteListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnBeforeCompleteListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBeforeComplete ();
		}
#pragma warning restore 0169

		IntPtr id_onBeforeComplete;
		public unsafe void OnBeforeComplete ()
		{
			if (id_onBeforeComplete == IntPtr.Zero)
				id_onBeforeComplete = JNIEnv.GetMethodID (class_ref, "onBeforeComplete", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBeforeComplete);
		}

	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnBeforeCompleteListenerImplementor")]
	internal sealed partial class IAdvertisingEventsOnBeforeCompleteListenerImplementor : global::Java.Lang.Object, IAdvertisingEventsOnBeforeCompleteListener {

		object sender;

		public IAdvertisingEventsOnBeforeCompleteListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnBeforeCompleteListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void OnBeforeComplete ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IAdvertisingEventsOnBeforeCompleteListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnBeforePlayListener']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnBeforePlayListener", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnBeforePlayListenerInvoker")]
	public partial interface IAdvertisingEventsOnBeforePlayListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents.OnBeforePlayListener']/method[@name='onBeforePlay' and count(parameter)=0]"
		[Register ("onBeforePlay", "()V", "GetOnBeforePlayHandler:Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnBeforePlayListenerInvoker, JWBinding_AND")]
		void OnBeforePlay ();

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnBeforePlayListener", DoNotGenerateAcw=true)]
	internal class IAdvertisingEventsOnBeforePlayListenerInvoker : global::Java.Lang.Object, IAdvertisingEventsOnBeforePlayListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents$OnBeforePlayListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdvertisingEventsOnBeforePlayListenerInvoker); }
		}

		IntPtr class_ref;

		public static IAdvertisingEventsOnBeforePlayListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdvertisingEventsOnBeforePlayListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.AdvertisingEvents.OnBeforePlayListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdvertisingEventsOnBeforePlayListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBeforePlay;
#pragma warning disable 0169
		static Delegate GetOnBeforePlayHandler ()
		{
			if (cb_onBeforePlay == null)
				cb_onBeforePlay = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnBeforePlay);
			return cb_onBeforePlay;
		}

		static void n_OnBeforePlay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnBeforePlayListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsOnBeforePlayListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnBeforePlay ();
		}
#pragma warning restore 0169

		IntPtr id_onBeforePlay;
		public unsafe void OnBeforePlay ()
		{
			if (id_onBeforePlay == IntPtr.Zero)
				id_onBeforePlay = JNIEnv.GetMethodID (class_ref, "onBeforePlay", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBeforePlay);
		}

	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnBeforePlayListenerImplementor")]
	internal sealed partial class IAdvertisingEventsOnBeforePlayListenerImplementor : global::Java.Lang.Object, IAdvertisingEventsOnBeforePlayListener {

		object sender;

		public IAdvertisingEventsOnBeforePlayListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents_OnBeforePlayListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void OnBeforePlay ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IAdvertisingEventsOnBeforePlayListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.events.listeners']/interface[@name='AdvertisingEvents']"
	[Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents", "", "Com.Longtailvideo.Jwplayer.Events.Listeners.IAdvertisingEventsInvoker")]
	public partial interface IAdvertisingEvents : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents", DoNotGenerateAcw=true)]
	internal class IAdvertisingEventsInvoker : global::Java.Lang.Object, IAdvertisingEvents {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/listeners/AdvertisingEvents");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdvertisingEventsInvoker); }
		}

		IntPtr class_ref;

		public static IAdvertisingEvents GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdvertisingEvents> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.events.listeners.AdvertisingEvents"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdvertisingEventsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
