using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Dash.Mpd {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='ContentProtection']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/dash/mpd/ContentProtection", DoNotGenerateAcw=true)]
	public partial class ContentProtection : global::Java.Lang.Object {


		static IntPtr data_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='ContentProtection']/field[@name='data']"
		[Register ("data")]
		public global::Com.Google.Android.Exoplayer.Drm.DrmInitDataSchemeInitData Data {
			get {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "Lcom/google/android/exoplayer/drm/DrmInitData$SchemeInitData;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, data_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Drm.DrmInitDataSchemeInitData> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "Lcom/google/android/exoplayer/drm/DrmInitData$SchemeInitData;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, data_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr schemeUriId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='ContentProtection']/field[@name='schemeUriId']"
		[Register ("schemeUriId")]
		public string SchemeUriId {
			get {
				if (schemeUriId_jfieldId == IntPtr.Zero)
					schemeUriId_jfieldId = JNIEnv.GetFieldID (class_ref, "schemeUriId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, schemeUriId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (schemeUriId_jfieldId == IntPtr.Zero)
					schemeUriId_jfieldId = JNIEnv.GetFieldID (class_ref, "schemeUriId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, schemeUriId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr uuid_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='ContentProtection']/field[@name='uuid']"
		[Register ("uuid")]
		public global::Java.Util.UUID Uuid {
			get {
				if (uuid_jfieldId == IntPtr.Zero)
					uuid_jfieldId = JNIEnv.GetFieldID (class_ref, "uuid", "Ljava/util/UUID;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, uuid_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (uuid_jfieldId == IntPtr.Zero)
					uuid_jfieldId = JNIEnv.GetFieldID (class_ref, "uuid", "Ljava/util/UUID;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, uuid_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/dash/mpd/ContentProtection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContentProtection); }
		}

		protected ContentProtection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_UUID_Lcom_google_android_exoplayer_drm_DrmInitData_SchemeInitData_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='ContentProtection']/constructor[@name='ContentProtection' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.UUID'] and parameter[3][@type='com.google.android.exoplayer.drm.DrmInitData.SchemeInitData']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/UUID;Lcom/google/android/exoplayer/drm/DrmInitData$SchemeInitData;)V", "")]
		public unsafe ContentProtection (string p0, global::Java.Util.UUID p1, global::Com.Google.Android.Exoplayer.Drm.DrmInitDataSchemeInitData p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (ContentProtection)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/util/UUID;Lcom/google/android/exoplayer/drm/DrmInitData$SchemeInitData;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/util/UUID;Lcom/google/android/exoplayer/drm/DrmInitData$SchemeInitData;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_util_UUID_Lcom_google_android_exoplayer_drm_DrmInitData_SchemeInitData_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_util_UUID_Lcom_google_android_exoplayer_drm_DrmInitData_SchemeInitData_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/UUID;Lcom/google/android/exoplayer/drm/DrmInitData$SchemeInitData;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_UUID_Lcom_google_android_exoplayer_drm_DrmInitData_SchemeInitData_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_UUID_Lcom_google_android_exoplayer_drm_DrmInitData_SchemeInitData_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
