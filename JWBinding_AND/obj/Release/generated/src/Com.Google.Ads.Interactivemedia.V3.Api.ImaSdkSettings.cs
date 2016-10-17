using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Ads.Interactivemedia.V3.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='ImaSdkSettings']"
	[global::Android.Runtime.Register ("com/google/ads/interactivemedia/v3/api/ImaSdkSettings", DoNotGenerateAcw=true)]
	public sealed partial class ImaSdkSettings : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='ImaSdkSettings']/field[@name='DEFAULT_MAX_REDIRECTS']"
		[Register ("DEFAULT_MAX_REDIRECTS")]
		public const int DefaultMaxRedirects = (int) 4;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/ads/interactivemedia/v3/api/ImaSdkSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImaSdkSettings); }
		}

		internal ImaSdkSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='ImaSdkSettings']/constructor[@name='ImaSdkSettings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ImaSdkSettings ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ImaSdkSettings)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_getAutoPlayAdBreaks;
		static IntPtr id_setAutoPlayAdBreaks_Z;
		public unsafe bool AutoPlayAdBreaks {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='ImaSdkSettings']/method[@name='getAutoPlayAdBreaks' and count(parameter)=0]"
			[Register ("getAutoPlayAdBreaks", "()Z", "GetGetAutoPlayAdBreaksHandler")]
			get {
				if (id_getAutoPlayAdBreaks == IntPtr.Zero)
					id_getAutoPlayAdBreaks = JNIEnv.GetMethodID (class_ref, "getAutoPlayAdBreaks", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getAutoPlayAdBreaks);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='ImaSdkSettings']/method[@name='setAutoPlayAdBreaks' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoPlayAdBreaks", "(Z)V", "GetSetAutoPlayAdBreaks_ZHandler")]
			set {
				if (id_setAutoPlayAdBreaks_Z == IntPtr.Zero)
					id_setAutoPlayAdBreaks_Z = JNIEnv.GetMethodID (class_ref, "setAutoPlayAdBreaks", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAutoPlayAdBreaks_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getLanguage;
		static IntPtr id_setLanguage_Ljava_lang_String_;
		public unsafe string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='ImaSdkSettings']/method[@name='getLanguage' and count(parameter)=0]"
			[Register ("getLanguage", "()Ljava/lang/String;", "GetGetLanguageHandler")]
			get {
				if (id_getLanguage == IntPtr.Zero)
					id_getLanguage = JNIEnv.GetMethodID (class_ref, "getLanguage", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLanguage), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='ImaSdkSettings']/method[@name='setLanguage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLanguage", "(Ljava/lang/String;)V", "GetSetLanguage_Ljava_lang_String_Handler")]
			set {
				if (id_setLanguage_Ljava_lang_String_ == IntPtr.Zero)
					id_setLanguage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLanguage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLanguage_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getMaxRedirects;
		static IntPtr id_setMaxRedirects_I;
		public unsafe int MaxRedirects {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='ImaSdkSettings']/method[@name='getMaxRedirects' and count(parameter)=0]"
			[Register ("getMaxRedirects", "()I", "GetGetMaxRedirectsHandler")]
			get {
				if (id_getMaxRedirects == IntPtr.Zero)
					id_getMaxRedirects = JNIEnv.GetMethodID (class_ref, "getMaxRedirects", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxRedirects);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='ImaSdkSettings']/method[@name='setMaxRedirects' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxRedirects", "(I)V", "GetSetMaxRedirects_IHandler")]
			set {
				if (id_setMaxRedirects_I == IntPtr.Zero)
					id_setMaxRedirects_I = JNIEnv.GetMethodID (class_ref, "setMaxRedirects", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxRedirects_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getPlayerType;
		static IntPtr id_setPlayerType_Ljava_lang_String_;
		public unsafe string PlayerType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='ImaSdkSettings']/method[@name='getPlayerType' and count(parameter)=0]"
			[Register ("getPlayerType", "()Ljava/lang/String;", "GetGetPlayerTypeHandler")]
			get {
				if (id_getPlayerType == IntPtr.Zero)
					id_getPlayerType = JNIEnv.GetMethodID (class_ref, "getPlayerType", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlayerType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='ImaSdkSettings']/method[@name='setPlayerType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPlayerType", "(Ljava/lang/String;)V", "GetSetPlayerType_Ljava_lang_String_Handler")]
			set {
				if (id_setPlayerType_Ljava_lang_String_ == IntPtr.Zero)
					id_setPlayerType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPlayerType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPlayerType_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getPlayerVersion;
		static IntPtr id_setPlayerVersion_Ljava_lang_String_;
		public unsafe string PlayerVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='ImaSdkSettings']/method[@name='getPlayerVersion' and count(parameter)=0]"
			[Register ("getPlayerVersion", "()Ljava/lang/String;", "GetGetPlayerVersionHandler")]
			get {
				if (id_getPlayerVersion == IntPtr.Zero)
					id_getPlayerVersion = JNIEnv.GetMethodID (class_ref, "getPlayerVersion", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlayerVersion), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='ImaSdkSettings']/method[@name='setPlayerVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPlayerVersion", "(Ljava/lang/String;)V", "GetSetPlayerVersion_Ljava_lang_String_Handler")]
			set {
				if (id_setPlayerVersion_Ljava_lang_String_ == IntPtr.Zero)
					id_setPlayerVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPlayerVersion", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPlayerVersion_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_getPpid;
		static IntPtr id_setPpid_Ljava_lang_String_;
		public unsafe string Ppid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='ImaSdkSettings']/method[@name='getPpid' and count(parameter)=0]"
			[Register ("getPpid", "()Ljava/lang/String;", "GetGetPpidHandler")]
			get {
				if (id_getPpid == IntPtr.Zero)
					id_getPpid = JNIEnv.GetMethodID (class_ref, "getPpid", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPpid), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='ImaSdkSettings']/method[@name='setPpid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPpid", "(Ljava/lang/String;)V", "GetSetPpid_Ljava_lang_String_Handler")]
			set {
				if (id_setPpid_Ljava_lang_String_ == IntPtr.Zero)
					id_setPpid_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPpid", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPpid_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_doesRestrictToCustomPlayer;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='ImaSdkSettings']/method[@name='doesRestrictToCustomPlayer' and count(parameter)=0]"
		[Register ("doesRestrictToCustomPlayer", "()Z", "")]
		public unsafe bool DoesRestrictToCustomPlayer ()
		{
			if (id_doesRestrictToCustomPlayer == IntPtr.Zero)
				id_doesRestrictToCustomPlayer = JNIEnv.GetMethodID (class_ref, "doesRestrictToCustomPlayer", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_doesRestrictToCustomPlayer);
			} finally {
			}
		}

		static IntPtr id_setRestrictToCustomPlayer_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='ImaSdkSettings']/method[@name='setRestrictToCustomPlayer' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setRestrictToCustomPlayer", "(Z)V", "")]
		public unsafe void SetRestrictToCustomPlayer (bool p0)
		{
			if (id_setRestrictToCustomPlayer_Z == IntPtr.Zero)
				id_setRestrictToCustomPlayer_Z = JNIEnv.GetMethodID (class_ref, "setRestrictToCustomPlayer", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRestrictToCustomPlayer_Z, __args);
			} finally {
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='ImaSdkSettings']/method[@name='toString' and count(parameter)=0]"
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
