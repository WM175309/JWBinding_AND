using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Hls {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsPlaylist']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/hls/HlsPlaylist", DoNotGenerateAcw=true)]
	public abstract partial class HlsPlaylist : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsPlaylist']/field[@name='TYPE_MASTER']"
		[Register ("TYPE_MASTER")]
		public const int TypeMaster = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsPlaylist']/field[@name='TYPE_MEDIA']"
		[Register ("TYPE_MEDIA")]
		public const int TypeMedia = (int) 1;

		static IntPtr baseUri_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsPlaylist']/field[@name='baseUri']"
		[Register ("baseUri")]
		public string BaseUri {
			get {
				if (baseUri_jfieldId == IntPtr.Zero)
					baseUri_jfieldId = JNIEnv.GetFieldID (class_ref, "baseUri", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, baseUri_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (baseUri_jfieldId == IntPtr.Zero)
					baseUri_jfieldId = JNIEnv.GetFieldID (class_ref, "baseUri", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, baseUri_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsPlaylist']/field[@name='type']"
		[Register ("type")]
		public int Type {
			get {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
			}
			set {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/hls/HlsPlaylist", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HlsPlaylist); }
		}

		protected HlsPlaylist (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsPlaylist']/constructor[@name='HlsPlaylist' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		protected unsafe HlsPlaylist (string p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (HlsPlaylist)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_I == IntPtr.Zero)
					id_ctor_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/hls/HlsPlaylist", DoNotGenerateAcw=true)]
	internal partial class HlsPlaylistInvoker : HlsPlaylist {

		public HlsPlaylistInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (HlsPlaylistInvoker); }
		}

	}

}
