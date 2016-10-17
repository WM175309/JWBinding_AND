using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Drm {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.drm']/class[@name='DrmInitData.Mapped']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/drm/DrmInitData$Mapped", DoNotGenerateAcw=true)]
	public sealed partial class DrmInitDataMapped : global::Java.Lang.Object, global::Com.Google.Android.Exoplayer.Drm.IDrmInitData {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/drm/DrmInitData$Mapped", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrmInitDataMapped); }
		}

		internal DrmInitDataMapped (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.drm']/class[@name='DrmInitData.Mapped']/constructor[@name='DrmInitData.Mapped' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DrmInitDataMapped ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (DrmInitDataMapped)) {
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

		static IntPtr id_get_Ljava_util_UUID_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.drm']/class[@name='DrmInitData.Mapped']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
		[Register ("get", "(Ljava/util/UUID;)Lcom/google/android/exoplayer/drm/DrmInitData$SchemeInitData;", "")]
		public unsafe global::Com.Google.Android.Exoplayer.Drm.DrmInitDataSchemeInitData Get (global::Java.Util.UUID p0)
		{
			if (id_get_Ljava_util_UUID_ == IntPtr.Zero)
				id_get_Ljava_util_UUID_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/util/UUID;)Lcom/google/android/exoplayer/drm/DrmInitData$SchemeInitData;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Android.Exoplayer.Drm.DrmInitDataSchemeInitData __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Drm.DrmInitDataSchemeInitData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_util_UUID_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_put_Ljava_util_UUID_Lcom_google_android_exoplayer_drm_DrmInitData_SchemeInitData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.drm']/class[@name='DrmInitData.Mapped']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.util.UUID'] and parameter[2][@type='com.google.android.exoplayer.drm.DrmInitData.SchemeInitData']]"
		[Register ("put", "(Ljava/util/UUID;Lcom/google/android/exoplayer/drm/DrmInitData$SchemeInitData;)V", "")]
		public unsafe void Put (global::Java.Util.UUID p0, global::Com.Google.Android.Exoplayer.Drm.DrmInitDataSchemeInitData p1)
		{
			if (id_put_Ljava_util_UUID_Lcom_google_android_exoplayer_drm_DrmInitData_SchemeInitData_ == IntPtr.Zero)
				id_put_Ljava_util_UUID_Lcom_google_android_exoplayer_drm_DrmInitData_SchemeInitData_ = JNIEnv.GetMethodID (class_ref, "put", "(Ljava/util/UUID;Lcom/google/android/exoplayer/drm/DrmInitData$SchemeInitData;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_put_Ljava_util_UUID_Lcom_google_android_exoplayer_drm_DrmInitData_SchemeInitData_, __args);
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.drm']/class[@name='DrmInitData.SchemeInitData']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/drm/DrmInitData$SchemeInitData", DoNotGenerateAcw=true)]
	public sealed partial class DrmInitDataSchemeInitData : global::Java.Lang.Object {


		static IntPtr data_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.drm']/class[@name='DrmInitData.SchemeInitData']/field[@name='data']"
		[Register ("data")]
		public IList<byte> Data {
			get {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, data_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, data_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mimeType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.drm']/class[@name='DrmInitData.SchemeInitData']/field[@name='mimeType']"
		[Register ("mimeType")]
		public string MimeType {
			get {
				if (mimeType_jfieldId == IntPtr.Zero)
					mimeType_jfieldId = JNIEnv.GetFieldID (class_ref, "mimeType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mimeType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mimeType_jfieldId == IntPtr.Zero)
					mimeType_jfieldId = JNIEnv.GetFieldID (class_ref, "mimeType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mimeType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/drm/DrmInitData$SchemeInitData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrmInitDataSchemeInitData); }
		}

		internal DrmInitDataSchemeInitData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.drm']/class[@name='DrmInitData.SchemeInitData']/constructor[@name='DrmInitData.SchemeInitData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(Ljava/lang/String;[B)V", "")]
		public unsafe DrmInitDataSchemeInitData (string p0, byte[] p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (DrmInitDataSchemeInitData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;[B)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_arrayB == IntPtr.Zero)
					id_ctor_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_arrayB, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.drm']/class[@name='DrmInitData.SchemeInitData']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "")]
		public override sealed unsafe bool Equals (global::Java.Lang.Object p0)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hashCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.drm']/class[@name='DrmInitData.SchemeInitData']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "")]
		public override sealed unsafe int GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.drm']/class[@name='DrmInitData.Universal']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/drm/DrmInitData$Universal", DoNotGenerateAcw=true)]
	public sealed partial class DrmInitDataUniversal : global::Java.Lang.Object, global::Com.Google.Android.Exoplayer.Drm.IDrmInitData {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/drm/DrmInitData$Universal", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DrmInitDataUniversal); }
		}

		internal DrmInitDataUniversal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_android_exoplayer_drm_DrmInitData_SchemeInitData_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.drm']/class[@name='DrmInitData.Universal']/constructor[@name='DrmInitData.Universal' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer.drm.DrmInitData.SchemeInitData']]"
		[Register (".ctor", "(Lcom/google/android/exoplayer/drm/DrmInitData$SchemeInitData;)V", "")]
		public unsafe DrmInitDataUniversal (global::Com.Google.Android.Exoplayer.Drm.DrmInitDataSchemeInitData p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DrmInitDataUniversal)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/google/android/exoplayer/drm/DrmInitData$SchemeInitData;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/google/android/exoplayer/drm/DrmInitData$SchemeInitData;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_android_exoplayer_drm_DrmInitData_SchemeInitData_ == IntPtr.Zero)
					id_ctor_Lcom_google_android_exoplayer_drm_DrmInitData_SchemeInitData_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/android/exoplayer/drm/DrmInitData$SchemeInitData;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_android_exoplayer_drm_DrmInitData_SchemeInitData_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_google_android_exoplayer_drm_DrmInitData_SchemeInitData_, __args);
			} finally {
			}
		}

		static IntPtr id_get_Ljava_util_UUID_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.drm']/class[@name='DrmInitData.Universal']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
		[Register ("get", "(Ljava/util/UUID;)Lcom/google/android/exoplayer/drm/DrmInitData$SchemeInitData;", "")]
		public unsafe global::Com.Google.Android.Exoplayer.Drm.DrmInitDataSchemeInitData Get (global::Java.Util.UUID p0)
		{
			if (id_get_Ljava_util_UUID_ == IntPtr.Zero)
				id_get_Ljava_util_UUID_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/util/UUID;)Lcom/google/android/exoplayer/drm/DrmInitData$SchemeInitData;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Android.Exoplayer.Drm.DrmInitDataSchemeInitData __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Drm.DrmInitDataSchemeInitData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_util_UUID_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer.drm']/interface[@name='DrmInitData']"
	[Register ("com/google/android/exoplayer/drm/DrmInitData", "", "Com.Google.Android.Exoplayer.Drm.IDrmInitDataInvoker")]
	public partial interface IDrmInitData : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.drm']/interface[@name='DrmInitData']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
		[Register ("get", "(Ljava/util/UUID;)Lcom/google/android/exoplayer/drm/DrmInitData$SchemeInitData;", "GetGet_Ljava_util_UUID_Handler:Com.Google.Android.Exoplayer.Drm.IDrmInitDataInvoker, JWBinding_AND")]
		global::Com.Google.Android.Exoplayer.Drm.DrmInitDataSchemeInitData Get (global::Java.Util.UUID p0);

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/drm/DrmInitData", DoNotGenerateAcw=true)]
	internal class IDrmInitDataInvoker : global::Java.Lang.Object, IDrmInitData {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/drm/DrmInitData");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IDrmInitDataInvoker); }
		}

		IntPtr class_ref;

		public static IDrmInitData GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDrmInitData> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.drm.DrmInitData"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDrmInitDataInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_get_Ljava_util_UUID_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_util_UUID_Handler ()
		{
			if (cb_get_Ljava_util_UUID_ == null)
				cb_get_Ljava_util_UUID_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_util_UUID_);
			return cb_get_Ljava_util_UUID_;
		}

		static IntPtr n_Get_Ljava_util_UUID_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Exoplayer.Drm.IDrmInitData __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Drm.IDrmInitData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.UUID p0 = global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_util_UUID_;
		public unsafe global::Com.Google.Android.Exoplayer.Drm.DrmInitDataSchemeInitData Get (global::Java.Util.UUID p0)
		{
			if (id_get_Ljava_util_UUID_ == IntPtr.Zero)
				id_get_Ljava_util_UUID_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/util/UUID;)Lcom/google/android/exoplayer/drm/DrmInitData$SchemeInitData;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Google.Android.Exoplayer.Drm.DrmInitDataSchemeInitData __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Drm.DrmInitDataSchemeInitData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_util_UUID_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
