using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='MediaCodecSelector.1']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/MediaCodecSelector$1", DoNotGenerateAcw=true)]
	public partial class MediaCodecSelector1 : global::Java.Lang.Object, global::Com.Google.Android.Exoplayer.IMediaCodecSelector {


		public static class InterfaceConsts {

			// The following are fields from: com.google.android.exoplayer.MediaCodecSelector

			static IntPtr DEFAULT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/interface[@name='MediaCodecSelector']/field[@name='DEFAULT']"
			[Register ("DEFAULT")]
			public static global::Com.Google.Android.Exoplayer.IMediaCodecSelector Default {
				get {
					if (DEFAULT_jfieldId == IntPtr.Zero)
						DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/google/android/exoplayer/MediaCodecSelector;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.IMediaCodecSelector> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/MediaCodecSelector$1", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MediaCodecSelector1); }
		}

		protected MediaCodecSelector1 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getPassthroughDecoderName;
		public unsafe string PassthroughDecoderName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='MediaCodecSelector.1']/method[@name='getPassthroughDecoderName' and count(parameter)=0]"
			[Register ("getPassthroughDecoderName", "()Ljava/lang/String;", "GetGetPassthroughDecoderNameHandler")]
			get {
				if (id_getPassthroughDecoderName == IntPtr.Zero)
					id_getPassthroughDecoderName = JNIEnv.GetMethodID (class_ref, "getPassthroughDecoderName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPassthroughDecoderName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDecoderInfo_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='MediaCodecSelector.1']/method[@name='getDecoderInfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("getDecoderInfo", "(Ljava/lang/String;Z)Lcom/google/android/exoplayer/DecoderInfo;", "")]
		public unsafe global::Com.Google.Android.Exoplayer.DecoderInfo GetDecoderInfo (string p0, bool p1)
		{
			if (id_getDecoderInfo_Ljava_lang_String_Z == IntPtr.Zero)
				id_getDecoderInfo_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "getDecoderInfo", "(Ljava/lang/String;Z)Lcom/google/android/exoplayer/DecoderInfo;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Com.Google.Android.Exoplayer.DecoderInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.DecoderInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDecoderInfo_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

	[Register ("com/google/android/exoplayer/MediaCodecSelector", DoNotGenerateAcw=true)]
	public abstract class MediaCodecSelector : Java.Lang.Object {

		internal MediaCodecSelector ()
		{
		}

		static IntPtr DEFAULT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/interface[@name='MediaCodecSelector']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Com.Google.Android.Exoplayer.IMediaCodecSelector Default {
			get {
				if (DEFAULT_jfieldId == IntPtr.Zero)
					DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/google/android/exoplayer/MediaCodecSelector;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.IMediaCodecSelector> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/MediaCodecSelector");
	}

	[Register ("com/google/android/exoplayer/MediaCodecSelector", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'MediaCodecSelector' type. This type will be removed in a future release.")]
	public abstract class MediaCodecSelectorConsts : MediaCodecSelector {

		private MediaCodecSelectorConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer']/interface[@name='MediaCodecSelector']"
	[Register ("com/google/android/exoplayer/MediaCodecSelector", "", "Com.Google.Android.Exoplayer.IMediaCodecSelectorInvoker")]
	public partial interface IMediaCodecSelector : IJavaObject {

		string PassthroughDecoderName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/interface[@name='MediaCodecSelector']/method[@name='getPassthroughDecoderName' and count(parameter)=0]"
			[Register ("getPassthroughDecoderName", "()Ljava/lang/String;", "GetGetPassthroughDecoderNameHandler:Com.Google.Android.Exoplayer.IMediaCodecSelectorInvoker, JWBinding_AND")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/interface[@name='MediaCodecSelector']/method[@name='getDecoderInfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("getDecoderInfo", "(Ljava/lang/String;Z)Lcom/google/android/exoplayer/DecoderInfo;", "GetGetDecoderInfo_Ljava_lang_String_ZHandler:Com.Google.Android.Exoplayer.IMediaCodecSelectorInvoker, JWBinding_AND")]
		global::Com.Google.Android.Exoplayer.DecoderInfo GetDecoderInfo (string p0, bool p1);

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/MediaCodecSelector", DoNotGenerateAcw=true)]
	internal class IMediaCodecSelectorInvoker : global::Java.Lang.Object, IMediaCodecSelector {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/MediaCodecSelector");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMediaCodecSelectorInvoker); }
		}

		IntPtr class_ref;

		public static IMediaCodecSelector GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaCodecSelector> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.MediaCodecSelector"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaCodecSelectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getPassthroughDecoderName;
#pragma warning disable 0169
		static Delegate GetGetPassthroughDecoderNameHandler ()
		{
			if (cb_getPassthroughDecoderName == null)
				cb_getPassthroughDecoderName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPassthroughDecoderName);
			return cb_getPassthroughDecoderName;
		}

		static IntPtr n_GetPassthroughDecoderName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.IMediaCodecSelector __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.IMediaCodecSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PassthroughDecoderName);
		}
#pragma warning restore 0169

		IntPtr id_getPassthroughDecoderName;
		public unsafe string PassthroughDecoderName {
			get {
				if (id_getPassthroughDecoderName == IntPtr.Zero)
					id_getPassthroughDecoderName = JNIEnv.GetMethodID (class_ref, "getPassthroughDecoderName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPassthroughDecoderName), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDecoderInfo_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetDecoderInfo_Ljava_lang_String_ZHandler ()
		{
			if (cb_getDecoderInfo_Ljava_lang_String_Z == null)
				cb_getDecoderInfo_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_GetDecoderInfo_Ljava_lang_String_Z);
			return cb_getDecoderInfo_Ljava_lang_String_Z;
		}

		static IntPtr n_GetDecoderInfo_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Google.Android.Exoplayer.IMediaCodecSelector __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.IMediaCodecSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDecoderInfo (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getDecoderInfo_Ljava_lang_String_Z;
		public unsafe global::Com.Google.Android.Exoplayer.DecoderInfo GetDecoderInfo (string p0, bool p1)
		{
			if (id_getDecoderInfo_Ljava_lang_String_Z == IntPtr.Zero)
				id_getDecoderInfo_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "getDecoderInfo", "(Ljava/lang/String;Z)Lcom/google/android/exoplayer/DecoderInfo;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			global::Com.Google.Android.Exoplayer.DecoderInfo __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.DecoderInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDecoderInfo_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
