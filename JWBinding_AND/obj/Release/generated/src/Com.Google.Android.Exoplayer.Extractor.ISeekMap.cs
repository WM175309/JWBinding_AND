using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='SeekMap.1']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/extractor/SeekMap$1", DoNotGenerateAcw=true)]
	public partial class SeekMap1 : global::Java.Lang.Object, global::Com.Google.Android.Exoplayer.Extractor.ISeekMap {


		public static class InterfaceConsts {

			// The following are fields from: com.google.android.exoplayer.extractor.SeekMap

			static IntPtr UNSEEKABLE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/interface[@name='SeekMap']/field[@name='UNSEEKABLE']"
			[Register ("UNSEEKABLE")]
			public static global::Com.Google.Android.Exoplayer.Extractor.ISeekMap Unseekable {
				get {
					if (UNSEEKABLE_jfieldId == IntPtr.Zero)
						UNSEEKABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSEEKABLE", "Lcom/google/android/exoplayer/extractor/SeekMap;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNSEEKABLE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.ISeekMap> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/extractor/SeekMap$1", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SeekMap1); }
		}

		protected SeekMap1 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isSeekable;
		public unsafe bool IsSeekable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='SeekMap.1']/method[@name='isSeekable' and count(parameter)=0]"
			[Register ("isSeekable", "()Z", "GetIsSeekableHandler")]
			get {
				if (id_isSeekable == IntPtr.Zero)
					id_isSeekable = JNIEnv.GetMethodID (class_ref, "isSeekable", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSeekable);
				} finally {
				}
			}
		}

		static IntPtr id_getPosition_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='SeekMap.1']/method[@name='getPosition' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getPosition", "(J)J", "")]
		public unsafe long GetPosition (long p0)
		{
			if (id_getPosition_J == IntPtr.Zero)
				id_getPosition_J = JNIEnv.GetMethodID (class_ref, "getPosition", "(J)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPosition_J, __args);
			} finally {
			}
		}

	}

	[Register ("com/google/android/exoplayer/extractor/SeekMap", DoNotGenerateAcw=true)]
	public abstract class SeekMap : Java.Lang.Object {

		internal SeekMap ()
		{
		}

		static IntPtr UNSEEKABLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/interface[@name='SeekMap']/field[@name='UNSEEKABLE']"
		[Register ("UNSEEKABLE")]
		public static global::Com.Google.Android.Exoplayer.Extractor.ISeekMap Unseekable {
			get {
				if (UNSEEKABLE_jfieldId == IntPtr.Zero)
					UNSEEKABLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNSEEKABLE", "Lcom/google/android/exoplayer/extractor/SeekMap;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNSEEKABLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.ISeekMap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/extractor/SeekMap");
	}

	[Register ("com/google/android/exoplayer/extractor/SeekMap", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'SeekMap' type. This type will be removed in a future release.")]
	public abstract class SeekMapConsts : SeekMap {

		private SeekMapConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/interface[@name='SeekMap']"
	[Register ("com/google/android/exoplayer/extractor/SeekMap", "", "Com.Google.Android.Exoplayer.Extractor.ISeekMapInvoker")]
	public partial interface ISeekMap : IJavaObject {

		bool IsSeekable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/interface[@name='SeekMap']/method[@name='isSeekable' and count(parameter)=0]"
			[Register ("isSeekable", "()Z", "GetIsSeekableHandler:Com.Google.Android.Exoplayer.Extractor.ISeekMapInvoker, JWBinding_AND")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/interface[@name='SeekMap']/method[@name='getPosition' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getPosition", "(J)J", "GetGetPosition_JHandler:Com.Google.Android.Exoplayer.Extractor.ISeekMapInvoker, JWBinding_AND")]
		long GetPosition (long p0);

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/extractor/SeekMap", DoNotGenerateAcw=true)]
	internal class ISeekMapInvoker : global::Java.Lang.Object, ISeekMap {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/extractor/SeekMap");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISeekMapInvoker); }
		}

		IntPtr class_ref;

		public static ISeekMap GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISeekMap> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.extractor.SeekMap"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISeekMapInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isSeekable;
#pragma warning disable 0169
		static Delegate GetIsSeekableHandler ()
		{
			if (cb_isSeekable == null)
				cb_isSeekable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSeekable);
			return cb_isSeekable;
		}

		static bool n_IsSeekable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Extractor.ISeekMap __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.ISeekMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSeekable;
		}
#pragma warning restore 0169

		IntPtr id_isSeekable;
		public unsafe bool IsSeekable {
			get {
				if (id_isSeekable == IntPtr.Zero)
					id_isSeekable = JNIEnv.GetMethodID (class_ref, "isSeekable", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSeekable);
			}
		}

		static Delegate cb_getPosition_J;
#pragma warning disable 0169
		static Delegate GetGetPosition_JHandler ()
		{
			if (cb_getPosition_J == null)
				cb_getPosition_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long>) n_GetPosition_J);
			return cb_getPosition_J;
		}

		static long n_GetPosition_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Google.Android.Exoplayer.Extractor.ISeekMap __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.ISeekMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPosition (p0);
		}
#pragma warning restore 0169

		IntPtr id_getPosition_J;
		public unsafe long GetPosition (long p0)
		{
			if (id_getPosition_J == IntPtr.Zero)
				id_getPosition_J = JNIEnv.GetMethodID (class_ref, "getPosition", "(J)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPosition_J, __args);
		}

	}

}
