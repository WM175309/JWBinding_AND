using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Metadata {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer.metadata']/interface[@name='MetadataParser']"
	[Register ("com/google/android/exoplayer/metadata/MetadataParser", "", "Com.Google.Android.Exoplayer.Metadata.IMetadataParserInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IMetadataParser : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.metadata']/interface[@name='MetadataParser']/method[@name='canParse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("canParse", "(Ljava/lang/String;)Z", "GetCanParse_Ljava_lang_String_Handler:Com.Google.Android.Exoplayer.Metadata.IMetadataParserInvoker, JWBinding_AND")]
		bool CanParse (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.metadata']/interface[@name='MetadataParser']/method[@name='parse' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("parse", "([BI)Ljava/lang/Object;", "GetParse_arrayBIHandler:Com.Google.Android.Exoplayer.Metadata.IMetadataParserInvoker, JWBinding_AND")]
		global::Java.Lang.Object Parse (byte[] p0, int p1);

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/metadata/MetadataParser", DoNotGenerateAcw=true)]
	internal class IMetadataParserInvoker : global::Java.Lang.Object, IMetadataParser {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/metadata/MetadataParser");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMetadataParserInvoker); }
		}

		IntPtr class_ref;

		public static IMetadataParser GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMetadataParser> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.metadata.MetadataParser"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMetadataParserInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_canParse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCanParse_Ljava_lang_String_Handler ()
		{
			if (cb_canParse_Ljava_lang_String_ == null)
				cb_canParse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_CanParse_Ljava_lang_String_);
			return cb_canParse_Ljava_lang_String_;
		}

		static bool n_CanParse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Exoplayer.Metadata.IMetadataParser __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Metadata.IMetadataParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.CanParse (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_canParse_Ljava_lang_String_;
		public unsafe bool CanParse (string p0)
		{
			if (id_canParse_Ljava_lang_String_ == IntPtr.Zero)
				id_canParse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "canParse", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canParse_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_parse_arrayBI;
#pragma warning disable 0169
		static Delegate GetParse_arrayBIHandler ()
		{
			if (cb_parse_arrayBI == null)
				cb_parse_arrayBI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_Parse_arrayBI);
			return cb_parse_arrayBI;
		}

		static IntPtr n_Parse_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Google.Android.Exoplayer.Metadata.IMetadataParser __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Metadata.IMetadataParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Parse (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_parse_arrayBI;
		public unsafe global::Java.Lang.Object Parse (byte[] p0, int p1)
		{
			if (id_parse_arrayBI == IntPtr.Zero)
				id_parse_arrayBI = JNIEnv.GetMethodID (class_ref, "parse", "([BI)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parse_arrayBI, __args), JniHandleOwnership.TransferLocalRef);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}

}
