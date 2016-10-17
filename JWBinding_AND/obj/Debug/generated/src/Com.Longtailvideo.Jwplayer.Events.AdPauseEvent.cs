using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Longtailvideo.Jwplayer.Events {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='AdPauseEvent']"
	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/events/AdPauseEvent", DoNotGenerateAcw=true)]
	public partial class AdPauseEvent : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/longtailvideo/jwplayer/events/AdPauseEvent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdPauseEvent); }
		}

		protected AdPauseEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_Lcom_longtailvideo_jwplayer_core_PlayerState_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='AdPauseEvent']/constructor[@name='AdPauseEvent' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.longtailvideo.jwplayer.core.PlayerState'] and parameter[3][@type='com.longtailvideo.jwplayer.core.PlayerState'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/longtailvideo/jwplayer/core/PlayerState;Lcom/longtailvideo/jwplayer/core/PlayerState;Ljava/lang/String;)V", "")]
		public unsafe AdPauseEvent (string p0, global::Com.Longtailvideo.Jwplayer.Core.PlayerState p1, global::Com.Longtailvideo.Jwplayer.Core.PlayerState p2, string p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				if (GetType () != typeof (AdPauseEvent)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/longtailvideo/jwplayer/core/PlayerState;Lcom/longtailvideo/jwplayer/core/PlayerState;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Lcom/longtailvideo/jwplayer/core/PlayerState;Lcom/longtailvideo/jwplayer/core/PlayerState;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_Lcom_longtailvideo_jwplayer_core_PlayerState_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_Lcom_longtailvideo_jwplayer_core_PlayerState_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/longtailvideo/jwplayer/core/PlayerState;Lcom/longtailvideo/jwplayer/core/PlayerState;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_Lcom_longtailvideo_jwplayer_core_PlayerState_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_longtailvideo_jwplayer_core_PlayerState_Lcom_longtailvideo_jwplayer_core_PlayerState_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
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
			global::Com.Longtailvideo.Jwplayer.Events.AdPauseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdPauseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreativeType);
		}
#pragma warning restore 0169

		static IntPtr id_getCreativeType;
		public virtual unsafe string CreativeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='AdPauseEvent']/method[@name='getCreativeType' and count(parameter)=0]"
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

		static Delegate cb_getNewState;
#pragma warning disable 0169
		static Delegate GetGetNewStateHandler ()
		{
			if (cb_getNewState == null)
				cb_getNewState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNewState);
			return cb_getNewState;
		}

		static IntPtr n_GetNewState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Events.AdPauseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdPauseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NewState);
		}
#pragma warning restore 0169

		static IntPtr id_getNewState;
		public virtual unsafe global::Com.Longtailvideo.Jwplayer.Core.PlayerState NewState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='AdPauseEvent']/method[@name='getNewState' and count(parameter)=0]"
			[Register ("getNewState", "()Lcom/longtailvideo/jwplayer/core/PlayerState;", "GetGetNewStateHandler")]
			get {
				if (id_getNewState == IntPtr.Zero)
					id_getNewState = JNIEnv.GetMethodID (class_ref, "getNewState", "()Lcom/longtailvideo/jwplayer/core/PlayerState;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Core.PlayerState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNewState), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Core.PlayerState> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNewState", "()Lcom/longtailvideo/jwplayer/core/PlayerState;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOldState;
#pragma warning disable 0169
		static Delegate GetGetOldStateHandler ()
		{
			if (cb_getOldState == null)
				cb_getOldState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOldState);
			return cb_getOldState;
		}

		static IntPtr n_GetOldState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Longtailvideo.Jwplayer.Events.AdPauseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdPauseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OldState);
		}
#pragma warning restore 0169

		static IntPtr id_getOldState;
		public virtual unsafe global::Com.Longtailvideo.Jwplayer.Core.PlayerState OldState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='AdPauseEvent']/method[@name='getOldState' and count(parameter)=0]"
			[Register ("getOldState", "()Lcom/longtailvideo/jwplayer/core/PlayerState;", "GetGetOldStateHandler")]
			get {
				if (id_getOldState == IntPtr.Zero)
					id_getOldState = JNIEnv.GetMethodID (class_ref, "getOldState", "()Lcom/longtailvideo/jwplayer/core/PlayerState;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Core.PlayerState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOldState), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Core.PlayerState> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOldState", "()Lcom/longtailvideo/jwplayer/core/PlayerState;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Longtailvideo.Jwplayer.Events.AdPauseEvent __this = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Events.AdPauseEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Tag);
		}
#pragma warning restore 0169

		static IntPtr id_getTag;
		public virtual unsafe string Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.events']/class[@name='AdPauseEvent']/method[@name='getTag' and count(parameter)=0]"
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
