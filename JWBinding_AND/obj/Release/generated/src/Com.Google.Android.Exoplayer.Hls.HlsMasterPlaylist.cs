using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Hls {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMasterPlaylist']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/hls/HlsMasterPlaylist", DoNotGenerateAcw=true)]
	public sealed partial class HlsMasterPlaylist : global::Com.Google.Android.Exoplayer.Hls.HlsPlaylist {


		static IntPtr audios_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMasterPlaylist']/field[@name='audios']"
		[Register ("audios")]
		public global::System.Collections.IList Audios {
			get {
				if (audios_jfieldId == IntPtr.Zero)
					audios_jfieldId = JNIEnv.GetFieldID (class_ref, "audios", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, audios_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (audios_jfieldId == IntPtr.Zero)
					audios_jfieldId = JNIEnv.GetFieldID (class_ref, "audios", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, audios_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr muxedAudioLanguage_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMasterPlaylist']/field[@name='muxedAudioLanguage']"
		[Register ("muxedAudioLanguage")]
		public string MuxedAudioLanguage {
			get {
				if (muxedAudioLanguage_jfieldId == IntPtr.Zero)
					muxedAudioLanguage_jfieldId = JNIEnv.GetFieldID (class_ref, "muxedAudioLanguage", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, muxedAudioLanguage_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (muxedAudioLanguage_jfieldId == IntPtr.Zero)
					muxedAudioLanguage_jfieldId = JNIEnv.GetFieldID (class_ref, "muxedAudioLanguage", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, muxedAudioLanguage_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr muxedAudioName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMasterPlaylist']/field[@name='muxedAudioName']"
		[Register ("muxedAudioName")]
		public string MuxedAudioName {
			get {
				if (muxedAudioName_jfieldId == IntPtr.Zero)
					muxedAudioName_jfieldId = JNIEnv.GetFieldID (class_ref, "muxedAudioName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, muxedAudioName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (muxedAudioName_jfieldId == IntPtr.Zero)
					muxedAudioName_jfieldId = JNIEnv.GetFieldID (class_ref, "muxedAudioName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, muxedAudioName_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr muxedCaptionLanguage_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMasterPlaylist']/field[@name='muxedCaptionLanguage']"
		[Register ("muxedCaptionLanguage")]
		public string MuxedCaptionLanguage {
			get {
				if (muxedCaptionLanguage_jfieldId == IntPtr.Zero)
					muxedCaptionLanguage_jfieldId = JNIEnv.GetFieldID (class_ref, "muxedCaptionLanguage", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, muxedCaptionLanguage_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (muxedCaptionLanguage_jfieldId == IntPtr.Zero)
					muxedCaptionLanguage_jfieldId = JNIEnv.GetFieldID (class_ref, "muxedCaptionLanguage", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, muxedCaptionLanguage_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr subtitles_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMasterPlaylist']/field[@name='subtitles']"
		[Register ("subtitles")]
		public global::System.Collections.IList Subtitles {
			get {
				if (subtitles_jfieldId == IntPtr.Zero)
					subtitles_jfieldId = JNIEnv.GetFieldID (class_ref, "subtitles", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, subtitles_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (subtitles_jfieldId == IntPtr.Zero)
					subtitles_jfieldId = JNIEnv.GetFieldID (class_ref, "subtitles", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, subtitles_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr variants_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMasterPlaylist']/field[@name='variants']"
		[Register ("variants")]
		public global::System.Collections.IList Variants {
			get {
				if (variants_jfieldId == IntPtr.Zero)
					variants_jfieldId = JNIEnv.GetFieldID (class_ref, "variants", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, variants_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (variants_jfieldId == IntPtr.Zero)
					variants_jfieldId = JNIEnv.GetFieldID (class_ref, "variants", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, variants_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/hls/HlsMasterPlaylist", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HlsMasterPlaylist); }
		}

		internal HlsMasterPlaylist (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_List_Ljava_util_List_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.hls']/class[@name='HlsMasterPlaylist']/constructor[@name='HlsMasterPlaylist' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;com.google.android.exoplayer.hls.Variant&gt;'] and parameter[3][@type='java.util.List&lt;com.google.android.exoplayer.hls.Variant&gt;'] and parameter[4][@type='java.util.List&lt;com.google.android.exoplayer.hls.Variant&gt;'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe HlsMasterPlaylist (string p0, global::System.Collections.Generic.IList<global::Com.Google.Android.Exoplayer.Hls.Variant> p1, global::System.Collections.Generic.IList<global::Com.Google.Android.Exoplayer.Hls.Variant> p2, global::System.Collections.Generic.IList<global::Com.Google.Android.Exoplayer.Hls.Variant> p3, string p4, string p5, string p6)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Google.Android.Exoplayer.Hls.Variant>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Google.Android.Exoplayer.Hls.Variant>.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::Com.Google.Android.Exoplayer.Hls.Variant>.ToLocalJniHandle (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);
				if (GetType () != typeof (HlsMasterPlaylist)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_util_List_Ljava_util_List_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_util_List_Ljava_util_List_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_List_Ljava_util_List_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_List_Ljava_util_List_Ljava_util_List_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

	}
}
