using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Longtailvideo.Jwplayer.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.longtailvideo.jwplayer.core']/class[@name='PlayerState']"
	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/core/PlayerState", DoNotGenerateAcw=true)]
	public sealed partial class PlayerState : global::Java.Lang.Enum {


		static IntPtr BUFFERING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.core']/class[@name='PlayerState']/field[@name='BUFFERING']"
		[Register ("BUFFERING")]
		public static global::Com.Longtailvideo.Jwplayer.Core.PlayerState Buffering {
			get {
				if (BUFFERING_jfieldId == IntPtr.Zero)
					BUFFERING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUFFERING", "Lcom/longtailvideo/jwplayer/core/PlayerState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BUFFERING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Core.PlayerState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr IDLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.core']/class[@name='PlayerState']/field[@name='IDLE']"
		[Register ("IDLE")]
		public static global::Com.Longtailvideo.Jwplayer.Core.PlayerState Idle {
			get {
				if (IDLE_jfieldId == IntPtr.Zero)
					IDLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IDLE", "Lcom/longtailvideo/jwplayer/core/PlayerState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IDLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Core.PlayerState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PAUSED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.core']/class[@name='PlayerState']/field[@name='PAUSED']"
		[Register ("PAUSED")]
		public static global::Com.Longtailvideo.Jwplayer.Core.PlayerState Paused {
			get {
				if (PAUSED_jfieldId == IntPtr.Zero)
					PAUSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAUSED", "Lcom/longtailvideo/jwplayer/core/PlayerState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAUSED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Core.PlayerState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PLAYING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.core']/class[@name='PlayerState']/field[@name='PLAYING']"
		[Register ("PLAYING")]
		public static global::Com.Longtailvideo.Jwplayer.Core.PlayerState Playing {
			get {
				if (PLAYING_jfieldId == IntPtr.Zero)
					PLAYING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PLAYING", "Lcom/longtailvideo/jwplayer/core/PlayerState;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PLAYING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Core.PlayerState> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/longtailvideo/jwplayer/core/PlayerState", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PlayerState); }
		}

		internal PlayerState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.core']/class[@name='PlayerState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/longtailvideo/jwplayer/core/PlayerState;", "")]
		public static unsafe global::Com.Longtailvideo.Jwplayer.Core.PlayerState ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/longtailvideo/jwplayer/core/PlayerState;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Longtailvideo.Jwplayer.Core.PlayerState __ret = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Core.PlayerState> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.core']/class[@name='PlayerState']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/longtailvideo/jwplayer/core/PlayerState;", "")]
		public static unsafe global::Com.Longtailvideo.Jwplayer.Core.PlayerState[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/longtailvideo/jwplayer/core/PlayerState;");
			try {
				return (global::Com.Longtailvideo.Jwplayer.Core.PlayerState[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Longtailvideo.Jwplayer.Core.PlayerState));
			} finally {
			}
		}

	}
}
