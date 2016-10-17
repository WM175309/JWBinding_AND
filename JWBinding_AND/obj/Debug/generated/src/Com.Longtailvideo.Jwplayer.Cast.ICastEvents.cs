using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Longtailvideo.Jwplayer.Cast {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/interface[@name='CastEvents.ApplicationListener']"
	[Register ("com/longtailvideo/jwplayer/cast/CastEvents$ApplicationListener", "", "Com.Longtailvideo.Jwplayer.Cast.ICastEventsApplicationListenerInvoker")]
	public partial interface ICastEventsApplicationListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/interface[@name='CastEvents.ApplicationListener']/method[@name='onApplicationConnected' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("onApplicationConnected", "(Ljava/lang/String;Z)V", "GetOnApplicationConnected_Ljava_lang_String_ZHandler:Com.Longtailvideo.Jwplayer.Cast.ICastEventsApplicationListenerInvoker, JWBinding_AND")]
		void OnApplicationConnected (string p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/interface[@name='CastEvents.ApplicationListener']/method[@name='onApplicationConnectionFailed' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onApplicationConnectionFailed", "(I)V", "GetOnApplicationConnectionFailed_IHandler:Com.Longtailvideo.Jwplayer.Cast.ICastEventsApplicationListenerInvoker, JWBinding_AND")]
		void OnApplicationConnectionFailed (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/interface[@name='CastEvents.ApplicationListener']/method[@name='onApplicationDisconnected' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onApplicationDisconnected", "(I)V", "GetOnApplicationDisconnected_IHandler:Com.Longtailvideo.Jwplayer.Cast.ICastEventsApplicationListenerInvoker, JWBinding_AND")]
		void OnApplicationDisconnected (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/interface[@name='CastEvents.ApplicationListener']/method[@name='onApplicationStatusChanged' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onApplicationStatusChanged", "(Ljava/lang/String;)V", "GetOnApplicationStatusChanged_Ljava_lang_String_Handler:Com.Longtailvideo.Jwplayer.Cast.ICastEventsApplicationListenerInvoker, JWBinding_AND")]
		void OnApplicationStatusChanged (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/interface[@name='CastEvents.ApplicationListener']/method[@name='onApplicationStopFailed' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onApplicationStopFailed", "(I)V", "GetOnApplicationStopFailed_IHandler:Com.Longtailvideo.Jwplayer.Cast.ICastEventsApplicationListenerInvoker, JWBinding_AND")]
		void OnApplicationStopFailed (int p0);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/cast/CastEvents$ApplicationListener", DoNotGenerateAcw=true)]
	internal class ICastEventsApplicationListenerInvoker : global::Java.Lang.Object, ICastEventsApplicationListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/cast/CastEvents$ApplicationListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICastEventsApplicationListenerInvoker); }
		}

		IntPtr class_ref;

		public static ICastEventsApplicationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICastEventsApplicationListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.cast.CastEvents.ApplicationListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICastEventsApplicationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onApplicationConnected_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetOnApplicationConnected_Ljava_lang_String_ZHandler ()
		{
			if (cb_onApplicationConnected_Ljava_lang_String_Z == null)
				cb_onApplicationConnected_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_OnApplicationConnected_Ljava_lang_String_Z);
			return cb_onApplicationConnected_Ljava_lang_String_Z;
		}

		static void n_OnApplicationConnected_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsApplicationListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsApplicationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnApplicationConnected (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onApplicationConnected_Ljava_lang_String_Z;
		public unsafe void OnApplicationConnected (string p0, bool p1)
		{
			if (id_onApplicationConnected_Ljava_lang_String_Z == IntPtr.Zero)
				id_onApplicationConnected_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "onApplicationConnected", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onApplicationConnected_Ljava_lang_String_Z, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onApplicationConnectionFailed_I;
#pragma warning disable 0169
		static Delegate GetOnApplicationConnectionFailed_IHandler ()
		{
			if (cb_onApplicationConnectionFailed_I == null)
				cb_onApplicationConnectionFailed_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnApplicationConnectionFailed_I);
			return cb_onApplicationConnectionFailed_I;
		}

		static void n_OnApplicationConnectionFailed_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsApplicationListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsApplicationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnApplicationConnectionFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onApplicationConnectionFailed_I;
		public unsafe void OnApplicationConnectionFailed (int p0)
		{
			if (id_onApplicationConnectionFailed_I == IntPtr.Zero)
				id_onApplicationConnectionFailed_I = JNIEnv.GetMethodID (class_ref, "onApplicationConnectionFailed", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onApplicationConnectionFailed_I, __args);
		}

		static Delegate cb_onApplicationDisconnected_I;
#pragma warning disable 0169
		static Delegate GetOnApplicationDisconnected_IHandler ()
		{
			if (cb_onApplicationDisconnected_I == null)
				cb_onApplicationDisconnected_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnApplicationDisconnected_I);
			return cb_onApplicationDisconnected_I;
		}

		static void n_OnApplicationDisconnected_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsApplicationListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsApplicationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnApplicationDisconnected (p0);
		}
#pragma warning restore 0169

		IntPtr id_onApplicationDisconnected_I;
		public unsafe void OnApplicationDisconnected (int p0)
		{
			if (id_onApplicationDisconnected_I == IntPtr.Zero)
				id_onApplicationDisconnected_I = JNIEnv.GetMethodID (class_ref, "onApplicationDisconnected", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onApplicationDisconnected_I, __args);
		}

		static Delegate cb_onApplicationStatusChanged_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnApplicationStatusChanged_Ljava_lang_String_Handler ()
		{
			if (cb_onApplicationStatusChanged_Ljava_lang_String_ == null)
				cb_onApplicationStatusChanged_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnApplicationStatusChanged_Ljava_lang_String_);
			return cb_onApplicationStatusChanged_Ljava_lang_String_;
		}

		static void n_OnApplicationStatusChanged_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsApplicationListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsApplicationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnApplicationStatusChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_onApplicationStatusChanged_Ljava_lang_String_;
		public unsafe void OnApplicationStatusChanged (string p0)
		{
			if (id_onApplicationStatusChanged_Ljava_lang_String_ == IntPtr.Zero)
				id_onApplicationStatusChanged_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onApplicationStatusChanged", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onApplicationStatusChanged_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onApplicationStopFailed_I;
#pragma warning disable 0169
		static Delegate GetOnApplicationStopFailed_IHandler ()
		{
			if (cb_onApplicationStopFailed_I == null)
				cb_onApplicationStopFailed_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnApplicationStopFailed_I);
			return cb_onApplicationStopFailed_I;
		}

		static void n_OnApplicationStopFailed_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsApplicationListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsApplicationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnApplicationStopFailed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onApplicationStopFailed_I;
		public unsafe void OnApplicationStopFailed (int p0)
		{
			if (id_onApplicationStopFailed_I == IntPtr.Zero)
				id_onApplicationStopFailed_I = JNIEnv.GetMethodID (class_ref, "onApplicationStopFailed", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onApplicationStopFailed_I, __args);
		}

	}

	public partial class ApplicationConnectedEventArgs : global::System.EventArgs {

		public ApplicationConnectedEventArgs (string p0, bool p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		bool p1;
		public bool P1 {
			get { return p1; }
		}
	}

	public partial class ApplicationConnectionFailedEventArgs : global::System.EventArgs {

		public ApplicationConnectionFailedEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	public partial class ApplicationDisconnectedEventArgs : global::System.EventArgs {

		public ApplicationDisconnectedEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	public partial class ApplicationStatusChangedEventArgs : global::System.EventArgs {

		public ApplicationStatusChangedEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	public partial class ApplicationStopFailedEventArgs : global::System.EventArgs {

		public ApplicationStopFailedEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/cast/CastEvents_ApplicationListenerImplementor")]
	internal sealed partial class ICastEventsApplicationListenerImplementor : global::Java.Lang.Object, ICastEventsApplicationListener {

		object sender;

		public ICastEventsApplicationListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/cast/CastEvents_ApplicationListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ApplicationConnectedEventArgs> OnApplicationConnectedHandler;
#pragma warning restore 0649

		public void OnApplicationConnected (string p0, bool p1)
		{
			var __h = OnApplicationConnectedHandler;
			if (__h != null)
				__h (sender, new ApplicationConnectedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<ApplicationConnectionFailedEventArgs> OnApplicationConnectionFailedHandler;
#pragma warning restore 0649

		public void OnApplicationConnectionFailed (int p0)
		{
			var __h = OnApplicationConnectionFailedHandler;
			if (__h != null)
				__h (sender, new ApplicationConnectionFailedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<ApplicationDisconnectedEventArgs> OnApplicationDisconnectedHandler;
#pragma warning restore 0649

		public void OnApplicationDisconnected (int p0)
		{
			var __h = OnApplicationDisconnectedHandler;
			if (__h != null)
				__h (sender, new ApplicationDisconnectedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<ApplicationStatusChangedEventArgs> OnApplicationStatusChangedHandler;
#pragma warning restore 0649

		public void OnApplicationStatusChanged (string p0)
		{
			var __h = OnApplicationStatusChangedHandler;
			if (__h != null)
				__h (sender, new ApplicationStatusChangedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<ApplicationStopFailedEventArgs> OnApplicationStopFailedHandler;
#pragma warning restore 0649

		public void OnApplicationStopFailed (int p0)
		{
			var __h = OnApplicationStopFailedHandler;
			if (__h != null)
				__h (sender, new ApplicationStopFailedEventArgs (p0));
		}

		internal static bool __IsEmpty (ICastEventsApplicationListenerImplementor value)
		{
			return value.OnApplicationConnectedHandler == null && value.OnApplicationConnectionFailedHandler == null && value.OnApplicationDisconnectedHandler == null && value.OnApplicationStatusChangedHandler == null && value.OnApplicationStopFailedHandler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/interface[@name='CastEvents.ConnectionListener']"
	[Register ("com/longtailvideo/jwplayer/cast/CastEvents$ConnectionListener", "", "Com.Longtailvideo.Jwplayer.Cast.ICastEventsConnectionListenerInvoker")]
	public partial interface ICastEventsConnectionListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/interface[@name='CastEvents.ConnectionListener']/method[@name='onConnected' and count(parameter)=0]"
		[Register ("onConnected", "()V", "GetOnConnectedHandler:Com.Longtailvideo.Jwplayer.Cast.ICastEventsConnectionListenerInvoker, JWBinding_AND")]
		void OnConnected ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/interface[@name='CastEvents.ConnectionListener']/method[@name='onConnectionFailed' and count(parameter)=0]"
		[Register ("onConnectionFailed", "()V", "GetOnConnectionFailedHandler:Com.Longtailvideo.Jwplayer.Cast.ICastEventsConnectionListenerInvoker, JWBinding_AND")]
		void OnConnectionFailed ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/interface[@name='CastEvents.ConnectionListener']/method[@name='onConnectionSuspended' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onConnectionSuspended", "(I)V", "GetOnConnectionSuspended_IHandler:Com.Longtailvideo.Jwplayer.Cast.ICastEventsConnectionListenerInvoker, JWBinding_AND")]
		void OnConnectionSuspended (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/interface[@name='CastEvents.ConnectionListener']/method[@name='onConnectivityRecovered' and count(parameter)=0]"
		[Register ("onConnectivityRecovered", "()V", "GetOnConnectivityRecoveredHandler:Com.Longtailvideo.Jwplayer.Cast.ICastEventsConnectionListenerInvoker, JWBinding_AND")]
		void OnConnectivityRecovered ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/interface[@name='CastEvents.ConnectionListener']/method[@name='onDisconnected' and count(parameter)=0]"
		[Register ("onDisconnected", "()V", "GetOnDisconnectedHandler:Com.Longtailvideo.Jwplayer.Cast.ICastEventsConnectionListenerInvoker, JWBinding_AND")]
		void OnDisconnected ();

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/cast/CastEvents$ConnectionListener", DoNotGenerateAcw=true)]
	internal class ICastEventsConnectionListenerInvoker : global::Java.Lang.Object, ICastEventsConnectionListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/cast/CastEvents$ConnectionListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICastEventsConnectionListenerInvoker); }
		}

		IntPtr class_ref;

		public static ICastEventsConnectionListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICastEventsConnectionListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.cast.CastEvents.ConnectionListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICastEventsConnectionListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onConnected;
#pragma warning disable 0169
		static Delegate GetOnConnectedHandler ()
		{
			if (cb_onConnected == null)
				cb_onConnected = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnConnected);
			return cb_onConnected;
		}

		static void n_OnConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsConnectionListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnected ();
		}
#pragma warning restore 0169

		IntPtr id_onConnected;
		public unsafe void OnConnected ()
		{
			if (id_onConnected == IntPtr.Zero)
				id_onConnected = JNIEnv.GetMethodID (class_ref, "onConnected", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnected);
		}

		static Delegate cb_onConnectionFailed;
#pragma warning disable 0169
		static Delegate GetOnConnectionFailedHandler ()
		{
			if (cb_onConnectionFailed == null)
				cb_onConnectionFailed = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnConnectionFailed);
			return cb_onConnectionFailed;
		}

		static void n_OnConnectionFailed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsConnectionListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionFailed ();
		}
#pragma warning restore 0169

		IntPtr id_onConnectionFailed;
		public unsafe void OnConnectionFailed ()
		{
			if (id_onConnectionFailed == IntPtr.Zero)
				id_onConnectionFailed = JNIEnv.GetMethodID (class_ref, "onConnectionFailed", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionFailed);
		}

		static Delegate cb_onConnectionSuspended_I;
#pragma warning disable 0169
		static Delegate GetOnConnectionSuspended_IHandler ()
		{
			if (cb_onConnectionSuspended_I == null)
				cb_onConnectionSuspended_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnConnectionSuspended_I);
			return cb_onConnectionSuspended_I;
		}

		static void n_OnConnectionSuspended_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsConnectionListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectionSuspended (p0);
		}
#pragma warning restore 0169

		IntPtr id_onConnectionSuspended_I;
		public unsafe void OnConnectionSuspended (int p0)
		{
			if (id_onConnectionSuspended_I == IntPtr.Zero)
				id_onConnectionSuspended_I = JNIEnv.GetMethodID (class_ref, "onConnectionSuspended", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionSuspended_I, __args);
		}

		static Delegate cb_onConnectivityRecovered;
#pragma warning disable 0169
		static Delegate GetOnConnectivityRecoveredHandler ()
		{
			if (cb_onConnectivityRecovered == null)
				cb_onConnectivityRecovered = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnConnectivityRecovered);
			return cb_onConnectivityRecovered;
		}

		static void n_OnConnectivityRecovered (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsConnectionListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectivityRecovered ();
		}
#pragma warning restore 0169

		IntPtr id_onConnectivityRecovered;
		public unsafe void OnConnectivityRecovered ()
		{
			if (id_onConnectivityRecovered == IntPtr.Zero)
				id_onConnectivityRecovered = JNIEnv.GetMethodID (class_ref, "onConnectivityRecovered", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectivityRecovered);
		}

		static Delegate cb_onDisconnected;
#pragma warning disable 0169
		static Delegate GetOnDisconnectedHandler ()
		{
			if (cb_onDisconnected == null)
				cb_onDisconnected = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDisconnected);
			return cb_onDisconnected;
		}

		static void n_OnDisconnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsConnectionListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsConnectionListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnected ();
		}
#pragma warning restore 0169

		IntPtr id_onDisconnected;
		public unsafe void OnDisconnected ()
		{
			if (id_onDisconnected == IntPtr.Zero)
				id_onDisconnected = JNIEnv.GetMethodID (class_ref, "onDisconnected", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDisconnected);
		}

	}

	public partial class ConnectionSuspendedEventArgs : global::System.EventArgs {

		public ConnectionSuspendedEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/cast/CastEvents_ConnectionListenerImplementor")]
	internal sealed partial class ICastEventsConnectionListenerImplementor : global::Java.Lang.Object, ICastEventsConnectionListener {

		object sender;

		public ICastEventsConnectionListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/cast/CastEvents_ConnectionListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler OnConnectedHandler;
#pragma warning restore 0649

		public void OnConnected ()
		{
			var __h = OnConnectedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnConnectionFailedHandler;
#pragma warning restore 0649

		public void OnConnectionFailed ()
		{
			var __h = OnConnectionFailedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<ConnectionSuspendedEventArgs> OnConnectionSuspendedHandler;
#pragma warning restore 0649

		public void OnConnectionSuspended (int p0)
		{
			var __h = OnConnectionSuspendedHandler;
			if (__h != null)
				__h (sender, new ConnectionSuspendedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler OnConnectivityRecoveredHandler;
#pragma warning restore 0649

		public void OnConnectivityRecovered ()
		{
			var __h = OnConnectivityRecoveredHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnDisconnectedHandler;
#pragma warning restore 0649

		public void OnDisconnected ()
		{
			var __h = OnDisconnectedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (ICastEventsConnectionListenerImplementor value)
		{
			return value.OnConnectedHandler == null && value.OnConnectionFailedHandler == null && value.OnConnectionSuspendedHandler == null && value.OnConnectivityRecoveredHandler == null && value.OnDisconnectedHandler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/interface[@name='CastEvents.ErrorListener']"
	[Register ("com/longtailvideo/jwplayer/cast/CastEvents$ErrorListener", "", "Com.Longtailvideo.Jwplayer.Cast.ICastEventsErrorListenerInvoker")]
	public partial interface ICastEventsErrorListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/interface[@name='CastEvents.ErrorListener']/method[@name='onFailed' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onFailed", "(II)V", "GetOnFailed_IIHandler:Com.Longtailvideo.Jwplayer.Cast.ICastEventsErrorListenerInvoker, JWBinding_AND")]
		void OnFailed (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/cast/CastEvents$ErrorListener", DoNotGenerateAcw=true)]
	internal class ICastEventsErrorListenerInvoker : global::Java.Lang.Object, ICastEventsErrorListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/cast/CastEvents$ErrorListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICastEventsErrorListenerInvoker); }
		}

		IntPtr class_ref;

		public static ICastEventsErrorListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICastEventsErrorListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.cast.CastEvents.ErrorListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICastEventsErrorListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFailed_II;
#pragma warning disable 0169
		static Delegate GetOnFailed_IIHandler ()
		{
			if (cb_onFailed_II == null)
				cb_onFailed_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnFailed_II);
			return cb_onFailed_II;
		}

		static void n_OnFailed_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsErrorListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsErrorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnFailed (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onFailed_II;
		public unsafe void OnFailed (int p0, int p1)
		{
			if (id_onFailed_II == IntPtr.Zero)
				id_onFailed_II = JNIEnv.GetMethodID (class_ref, "onFailed", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailed_II, __args);
		}

	}

	public partial class CastEventsErrorEventArgs : global::System.EventArgs {

		public CastEventsErrorEventArgs (int p0, int p1)
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

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/cast/CastEvents_ErrorListenerImplementor")]
	internal sealed partial class ICastEventsErrorListenerImplementor : global::Java.Lang.Object, ICastEventsErrorListener {

		object sender;

		public ICastEventsErrorListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/cast/CastEvents_ErrorListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CastEventsErrorEventArgs> Handler;
#pragma warning restore 0649

		public void OnFailed (int p0, int p1)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new CastEventsErrorEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (ICastEventsErrorListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/interface[@name='CastEvents.PlayerListener']"
	[Register ("com/longtailvideo/jwplayer/cast/CastEvents$PlayerListener", "", "Com.Longtailvideo.Jwplayer.Cast.ICastEventsPlayerListenerInvoker")]
	public partial interface ICastEventsPlayerListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/interface[@name='CastEvents.PlayerListener']/method[@name='onMediaLoadResult' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onMediaLoadResult", "(I)V", "GetOnMediaLoadResult_IHandler:Com.Longtailvideo.Jwplayer.Cast.ICastEventsPlayerListenerInvoker, JWBinding_AND")]
		void OnMediaLoadResult (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/interface[@name='CastEvents.PlayerListener']/method[@name='onRemoteMediaPlayerMetadataUpdated' and count(parameter)=0]"
		[Register ("onRemoteMediaPlayerMetadataUpdated", "()V", "GetOnRemoteMediaPlayerMetadataUpdatedHandler:Com.Longtailvideo.Jwplayer.Cast.ICastEventsPlayerListenerInvoker, JWBinding_AND")]
		void OnRemoteMediaPlayerMetadataUpdated ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/interface[@name='CastEvents.PlayerListener']/method[@name='onRemoteMediaPlayerStatusUpdated' and count(parameter)=0]"
		[Register ("onRemoteMediaPlayerStatusUpdated", "()V", "GetOnRemoteMediaPlayerStatusUpdatedHandler:Com.Longtailvideo.Jwplayer.Cast.ICastEventsPlayerListenerInvoker, JWBinding_AND")]
		void OnRemoteMediaPlayerStatusUpdated ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/interface[@name='CastEvents.PlayerListener']/method[@name='onVolumeChanged' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='boolean']]"
		[Register ("onVolumeChanged", "(DZ)V", "GetOnVolumeChanged_DZHandler:Com.Longtailvideo.Jwplayer.Cast.ICastEventsPlayerListenerInvoker, JWBinding_AND")]
		void OnVolumeChanged (double p0, bool p1);

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/cast/CastEvents$PlayerListener", DoNotGenerateAcw=true)]
	internal class ICastEventsPlayerListenerInvoker : global::Java.Lang.Object, ICastEventsPlayerListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/cast/CastEvents$PlayerListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICastEventsPlayerListenerInvoker); }
		}

		IntPtr class_ref;

		public static ICastEventsPlayerListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICastEventsPlayerListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.cast.CastEvents.PlayerListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICastEventsPlayerListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onMediaLoadResult_I;
#pragma warning disable 0169
		static Delegate GetOnMediaLoadResult_IHandler ()
		{
			if (cb_onMediaLoadResult_I == null)
				cb_onMediaLoadResult_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnMediaLoadResult_I);
			return cb_onMediaLoadResult_I;
		}

		static void n_OnMediaLoadResult_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsPlayerListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsPlayerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMediaLoadResult (p0);
		}
#pragma warning restore 0169

		IntPtr id_onMediaLoadResult_I;
		public unsafe void OnMediaLoadResult (int p0)
		{
			if (id_onMediaLoadResult_I == IntPtr.Zero)
				id_onMediaLoadResult_I = JNIEnv.GetMethodID (class_ref, "onMediaLoadResult", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMediaLoadResult_I, __args);
		}

		static Delegate cb_onRemoteMediaPlayerMetadataUpdated;
#pragma warning disable 0169
		static Delegate GetOnRemoteMediaPlayerMetadataUpdatedHandler ()
		{
			if (cb_onRemoteMediaPlayerMetadataUpdated == null)
				cb_onRemoteMediaPlayerMetadataUpdated = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRemoteMediaPlayerMetadataUpdated);
			return cb_onRemoteMediaPlayerMetadataUpdated;
		}

		static void n_OnRemoteMediaPlayerMetadataUpdated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsPlayerListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsPlayerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteMediaPlayerMetadataUpdated ();
		}
#pragma warning restore 0169

		IntPtr id_onRemoteMediaPlayerMetadataUpdated;
		public unsafe void OnRemoteMediaPlayerMetadataUpdated ()
		{
			if (id_onRemoteMediaPlayerMetadataUpdated == IntPtr.Zero)
				id_onRemoteMediaPlayerMetadataUpdated = JNIEnv.GetMethodID (class_ref, "onRemoteMediaPlayerMetadataUpdated", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRemoteMediaPlayerMetadataUpdated);
		}

		static Delegate cb_onRemoteMediaPlayerStatusUpdated;
#pragma warning disable 0169
		static Delegate GetOnRemoteMediaPlayerStatusUpdatedHandler ()
		{
			if (cb_onRemoteMediaPlayerStatusUpdated == null)
				cb_onRemoteMediaPlayerStatusUpdated = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRemoteMediaPlayerStatusUpdated);
			return cb_onRemoteMediaPlayerStatusUpdated;
		}

		static void n_OnRemoteMediaPlayerStatusUpdated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsPlayerListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsPlayerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoteMediaPlayerStatusUpdated ();
		}
#pragma warning restore 0169

		IntPtr id_onRemoteMediaPlayerStatusUpdated;
		public unsafe void OnRemoteMediaPlayerStatusUpdated ()
		{
			if (id_onRemoteMediaPlayerStatusUpdated == IntPtr.Zero)
				id_onRemoteMediaPlayerStatusUpdated = JNIEnv.GetMethodID (class_ref, "onRemoteMediaPlayerStatusUpdated", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRemoteMediaPlayerStatusUpdated);
		}

		static Delegate cb_onVolumeChanged_DZ;
#pragma warning disable 0169
		static Delegate GetOnVolumeChanged_DZHandler ()
		{
			if (cb_onVolumeChanged_DZ == null)
				cb_onVolumeChanged_DZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, bool>) n_OnVolumeChanged_DZ);
			return cb_onVolumeChanged_DZ;
		}

		static void n_OnVolumeChanged_DZ (IntPtr jnienv, IntPtr native__this, double p0, bool p1)
		{
			global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsPlayerListener __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Cast.ICastEventsPlayerListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnVolumeChanged (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onVolumeChanged_DZ;
		public unsafe void OnVolumeChanged (double p0, bool p1)
		{
			if (id_onVolumeChanged_DZ == IntPtr.Zero)
				id_onVolumeChanged_DZ = JNIEnv.GetMethodID (class_ref, "onVolumeChanged", "(DZ)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onVolumeChanged_DZ, __args);
		}

	}

	public partial class MediaLoadResultEventArgs : global::System.EventArgs {

		public MediaLoadResultEventArgs (int p0)
		{
			this.p0 = p0;
		}

		int p0;
		public int P0 {
			get { return p0; }
		}
	}

	public partial class VolumeChangedEventArgs : global::System.EventArgs {

		public VolumeChangedEventArgs (double p0, bool p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		double p0;
		public double P0 {
			get { return p0; }
		}

		bool p1;
		public bool P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/longtailvideo/jwplayer/cast/CastEvents_PlayerListenerImplementor")]
	internal sealed partial class ICastEventsPlayerListenerImplementor : global::Java.Lang.Object, ICastEventsPlayerListener {

		object sender;

		public ICastEventsPlayerListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/longtailvideo/jwplayer/cast/CastEvents_PlayerListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MediaLoadResultEventArgs> OnMediaLoadResultHandler;
#pragma warning restore 0649

		public void OnMediaLoadResult (int p0)
		{
			var __h = OnMediaLoadResultHandler;
			if (__h != null)
				__h (sender, new MediaLoadResultEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler OnRemoteMediaPlayerMetadataUpdatedHandler;
#pragma warning restore 0649

		public void OnRemoteMediaPlayerMetadataUpdated ()
		{
			var __h = OnRemoteMediaPlayerMetadataUpdatedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler OnRemoteMediaPlayerStatusUpdatedHandler;
#pragma warning restore 0649

		public void OnRemoteMediaPlayerStatusUpdated ()
		{
			var __h = OnRemoteMediaPlayerStatusUpdatedHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<VolumeChangedEventArgs> OnVolumeChangedHandler;
#pragma warning restore 0649

		public void OnVolumeChanged (double p0, bool p1)
		{
			var __h = OnVolumeChangedHandler;
			if (__h != null)
				__h (sender, new VolumeChangedEventArgs (p0, p1));
		}

		internal static bool __IsEmpty (ICastEventsPlayerListenerImplementor value)
		{
			return value.OnMediaLoadResultHandler == null && value.OnRemoteMediaPlayerMetadataUpdatedHandler == null && value.OnRemoteMediaPlayerStatusUpdatedHandler == null && value.OnVolumeChangedHandler == null;
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/interface[@name='CastEvents']"
	[Register ("com/longtailvideo/jwplayer/cast/CastEvents", "", "Com.Longtailvideo.Jwplayer.Cast.ICastEventsInvoker")]
	public partial interface ICastEvents : IJavaObject {

	}

	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/cast/CastEvents", DoNotGenerateAcw=true)]
	internal class ICastEventsInvoker : global::Java.Lang.Object, ICastEvents {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/longtailvideo/jwplayer/cast/CastEvents");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICastEventsInvoker); }
		}

		IntPtr class_ref;

		public static ICastEvents GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICastEvents> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.longtailvideo.jwplayer.cast.CastEvents"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICastEventsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
