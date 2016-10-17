using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Extractor.Mp3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp3']/class[@name='Mp3Extractor']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/extractor/mp3/Mp3Extractor", DoNotGenerateAcw=true)]
	public sealed partial class Mp3Extractor : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp3']/interface[@name='Mp3Extractor.Seeker']"
		[Register ("com/google/android/exoplayer/extractor/mp3/Mp3Extractor$Seeker", "", "Com.Google.Android.Exoplayer.Extractor.Mp3.Mp3Extractor/ISeekerInvoker")]
		public partial interface ISeeker : global::Com.Google.Android.Exoplayer.Extractor.ISeekMap {

			long DurationUs {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp3']/interface[@name='Mp3Extractor.Seeker']/method[@name='getDurationUs' and count(parameter)=0]"
				[Register ("getDurationUs", "()J", "GetGetDurationUsHandler:Com.Google.Android.Exoplayer.Extractor.Mp3.Mp3Extractor/ISeekerInvoker, JWBinding_AND")] get;
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp3']/interface[@name='Mp3Extractor.Seeker']/method[@name='getTimeUs' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("getTimeUs", "(J)J", "GetGetTimeUs_JHandler:Com.Google.Android.Exoplayer.Extractor.Mp3.Mp3Extractor/ISeekerInvoker, JWBinding_AND")]
			long GetTimeUs (long p0);

		}

		[global::Android.Runtime.Register ("com/google/android/exoplayer/extractor/mp3/Mp3Extractor$Seeker", DoNotGenerateAcw=true)]
		internal class ISeekerInvoker : global::Java.Lang.Object, ISeeker {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/extractor/mp3/Mp3Extractor$Seeker");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ISeekerInvoker); }
			}

			IntPtr class_ref;

			public static ISeeker GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISeeker> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.extractor.mp3.Mp3Extractor.Seeker"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISeekerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getDurationUs;
#pragma warning disable 0169
			static Delegate GetGetDurationUsHandler ()
			{
				if (cb_getDurationUs == null)
					cb_getDurationUs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDurationUs);
				return cb_getDurationUs;
			}

			static long n_GetDurationUs (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Exoplayer.Extractor.Mp3.Mp3Extractor.ISeeker __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.Mp3.Mp3Extractor.ISeeker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.DurationUs;
			}
#pragma warning restore 0169

			IntPtr id_getDurationUs;
			public unsafe long DurationUs {
				get {
					if (id_getDurationUs == IntPtr.Zero)
						id_getDurationUs = JNIEnv.GetMethodID (class_ref, "getDurationUs", "()J");
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDurationUs);
				}
			}

			static Delegate cb_getTimeUs_J;
#pragma warning disable 0169
			static Delegate GetGetTimeUs_JHandler ()
			{
				if (cb_getTimeUs_J == null)
					cb_getTimeUs_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long>) n_GetTimeUs_J);
				return cb_getTimeUs_J;
			}

			static long n_GetTimeUs_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Google.Android.Exoplayer.Extractor.Mp3.Mp3Extractor.ISeeker __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.Mp3.Mp3Extractor.ISeeker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetTimeUs (p0);
			}
#pragma warning restore 0169

			IntPtr id_getTimeUs_J;
			public unsafe long GetTimeUs (long p0)
			{
				if (id_getTimeUs_J == IntPtr.Zero)
					id_getTimeUs_J = JNIEnv.GetMethodID (class_ref, "getTimeUs", "(J)J");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTimeUs_J, __args);
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
				global::Com.Google.Android.Exoplayer.Extractor.Mp3.Mp3Extractor.ISeeker __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.Mp3.Mp3Extractor.ISeeker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				global::Com.Google.Android.Exoplayer.Extractor.Mp3.Mp3Extractor.ISeeker __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.Mp3.Mp3Extractor.ISeeker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/extractor/mp3/Mp3Extractor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Mp3Extractor); }
		}

		internal Mp3Extractor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp3']/class[@name='Mp3Extractor']/constructor[@name='Mp3Extractor' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Mp3Extractor ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Mp3Extractor)) {
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

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp3']/class[@name='Mp3Extractor']/constructor[@name='Mp3Extractor' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe Mp3Extractor (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (Mp3Extractor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(J)V", __args);
					return;
				}

				if (id_ctor_J == IntPtr.Zero)
					id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_J, __args);
			} finally {
			}
		}

		static IntPtr id_read_Lcom_google_android_exoplayer_extractor_ExtractorInput_Lcom_google_android_exoplayer_extractor_PositionHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp3']/class[@name='Mp3Extractor']/method[@name='read' and count(parameter)=2 and parameter[1][@type='com.google.android.exoplayer.extractor.ExtractorInput'] and parameter[2][@type='com.google.android.exoplayer.extractor.PositionHolder']]"
		[Register ("read", "(Lcom/google/android/exoplayer/extractor/ExtractorInput;Lcom/google/android/exoplayer/extractor/PositionHolder;)I", "")]
		public unsafe int Read (global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput p0, global::Com.Google.Android.Exoplayer.Extractor.PositionHolder p1)
		{
			if (id_read_Lcom_google_android_exoplayer_extractor_ExtractorInput_Lcom_google_android_exoplayer_extractor_PositionHolder_ == IntPtr.Zero)
				id_read_Lcom_google_android_exoplayer_extractor_ExtractorInput_Lcom_google_android_exoplayer_extractor_PositionHolder_ = JNIEnv.GetMethodID (class_ref, "read", "(Lcom/google/android/exoplayer/extractor/ExtractorInput;Lcom/google/android/exoplayer/extractor/PositionHolder;)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_Lcom_google_android_exoplayer_extractor_ExtractorInput_Lcom_google_android_exoplayer_extractor_PositionHolder_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp3']/class[@name='Mp3Extractor']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "")]
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
			} finally {
			}
		}

		static IntPtr id_seek;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp3']/class[@name='Mp3Extractor']/method[@name='seek' and count(parameter)=0]"
		[Register ("seek", "()V", "")]
		public unsafe void Seek ()
		{
			if (id_seek == IntPtr.Zero)
				id_seek = JNIEnv.GetMethodID (class_ref, "seek", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_seek);
			} finally {
			}
		}

		static IntPtr id_sniff_Lcom_google_android_exoplayer_extractor_ExtractorInput_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor.mp3']/class[@name='Mp3Extractor']/method[@name='sniff' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer.extractor.ExtractorInput']]"
		[Register ("sniff", "(Lcom/google/android/exoplayer/extractor/ExtractorInput;)Z", "")]
		public unsafe bool Sniff (global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput p0)
		{
			if (id_sniff_Lcom_google_android_exoplayer_extractor_ExtractorInput_ == IntPtr.Zero)
				id_sniff_Lcom_google_android_exoplayer_extractor_ExtractorInput_ = JNIEnv.GetMethodID (class_ref, "sniff", "(Lcom/google/android/exoplayer/extractor/ExtractorInput;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_sniff_Lcom_google_android_exoplayer_extractor_ExtractorInput_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
