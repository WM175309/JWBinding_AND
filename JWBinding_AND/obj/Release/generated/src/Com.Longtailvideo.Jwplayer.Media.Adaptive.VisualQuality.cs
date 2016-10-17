using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Longtailvideo.Jwplayer.Media.Adaptive {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.adaptive']/class[@name='VisualQuality']"
	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/media/adaptive/VisualQuality", DoNotGenerateAcw=true)]
	public sealed partial class VisualQuality : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.adaptive']/class[@name='VisualQuality.Mode']"
		[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/media/adaptive/VisualQuality$Mode", DoNotGenerateAcw=true)]
		public sealed partial class Mode : global::Java.Lang.Enum {


			static IntPtr AUTO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.adaptive']/class[@name='VisualQuality.Mode']/field[@name='AUTO']"
			[Register ("AUTO")]
			public static global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Mode Auto {
				get {
					if (AUTO_jfieldId == IntPtr.Zero)
						AUTO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTO", "Lcom/longtailvideo/jwplayer/media/adaptive/VisualQuality$Mode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MANUAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.adaptive']/class[@name='VisualQuality.Mode']/field[@name='MANUAL']"
			[Register ("MANUAL")]
			public static global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Mode Manual {
				get {
					if (MANUAL_jfieldId == IntPtr.Zero)
						MANUAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MANUAL", "Lcom/longtailvideo/jwplayer/media/adaptive/VisualQuality$Mode;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MANUAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Mode> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/longtailvideo/jwplayer/media/adaptive/VisualQuality$Mode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Mode); }
			}

			internal Mode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.adaptive']/class[@name='VisualQuality.Mode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/longtailvideo/jwplayer/media/adaptive/VisualQuality$Mode;", "")]
			public static unsafe global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Mode ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/longtailvideo/jwplayer/media/adaptive/VisualQuality$Mode;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Mode __ret = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Mode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.adaptive']/class[@name='VisualQuality.Mode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/longtailvideo/jwplayer/media/adaptive/VisualQuality$Mode;", "")]
			public static unsafe global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Mode[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/longtailvideo/jwplayer/media/adaptive/VisualQuality$Mode;");
				try {
					return (global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Mode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Mode));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.adaptive']/class[@name='VisualQuality.Reason']"
		[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/media/adaptive/VisualQuality$Reason", DoNotGenerateAcw=true)]
		public sealed partial class Reason : global::Java.Lang.Enum {


			static IntPtr API_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.adaptive']/class[@name='VisualQuality.Reason']/field[@name='API']"
			[Register ("API")]
			public static global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Reason Api {
				get {
					if (API_jfieldId == IntPtr.Zero)
						API_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "API", "Lcom/longtailvideo/jwplayer/media/adaptive/VisualQuality$Reason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, API_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Reason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr AUTO_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.adaptive']/class[@name='VisualQuality.Reason']/field[@name='AUTO']"
			[Register ("AUTO")]
			public static global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Reason Auto {
				get {
					if (AUTO_jfieldId == IntPtr.Zero)
						AUTO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTO", "Lcom/longtailvideo/jwplayer/media/adaptive/VisualQuality$Reason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTO_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Reason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr INITIAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.adaptive']/class[@name='VisualQuality.Reason']/field[@name='INITIAL']"
			[Register ("INITIAL")]
			public static global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Reason Initial {
				get {
					if (INITIAL_jfieldId == IntPtr.Zero)
						INITIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INITIAL", "Lcom/longtailvideo/jwplayer/media/adaptive/VisualQuality$Reason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INITIAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Reason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.adaptive']/class[@name='VisualQuality.Reason']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Reason Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/longtailvideo/jwplayer/media/adaptive/VisualQuality$Reason;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Reason> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/longtailvideo/jwplayer/media/adaptive/VisualQuality$Reason", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Reason); }
			}

			internal Reason (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.adaptive']/class[@name='VisualQuality.Reason']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/longtailvideo/jwplayer/media/adaptive/VisualQuality$Reason;", "")]
			public static unsafe global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Reason ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/longtailvideo/jwplayer/media/adaptive/VisualQuality$Reason;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Reason __ret = global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Reason> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.adaptive']/class[@name='VisualQuality.Reason']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/longtailvideo/jwplayer/media/adaptive/VisualQuality$Reason;", "")]
			public static unsafe global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Reason[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/longtailvideo/jwplayer/media/adaptive/VisualQuality$Reason;");
				try {
					return (global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Reason[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Reason));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/longtailvideo/jwplayer/media/adaptive/VisualQuality", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VisualQuality); }
		}

		internal VisualQuality (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getMode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.adaptive']/class[@name='VisualQuality']/method[@name='getMode' and count(parameter)=0]"
		[Register ("getMode", "()Lcom/longtailvideo/jwplayer/media/adaptive/VisualQuality$Mode;", "")]
		public unsafe global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Mode GetMode ()
		{
			if (id_getMode == IntPtr.Zero)
				id_getMode = JNIEnv.GetMethodID (class_ref, "getMode", "()Lcom/longtailvideo/jwplayer/media/adaptive/VisualQuality$Mode;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Mode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMode), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getReason;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.longtailvideo.jwplayer.media.adaptive']/class[@name='VisualQuality']/method[@name='getReason' and count(parameter)=0]"
		[Register ("getReason", "()Lcom/longtailvideo/jwplayer/media/adaptive/VisualQuality$Reason;", "")]
		public unsafe global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Reason GetReason ()
		{
			if (id_getReason == IntPtr.Zero)
				id_getReason = JNIEnv.GetMethodID (class_ref, "getReason", "()Lcom/longtailvideo/jwplayer/media/adaptive/VisualQuality$Reason;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Longtailvideo.Jwplayer.Media.Adaptive.VisualQuality.Reason> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReason), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
