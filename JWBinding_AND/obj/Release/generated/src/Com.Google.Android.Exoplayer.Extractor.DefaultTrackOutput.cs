using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultTrackOutput']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/extractor/DefaultTrackOutput", DoNotGenerateAcw=true)]
	public partial class DefaultTrackOutput : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/extractor/DefaultTrackOutput", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultTrackOutput); }
		}

		protected DefaultTrackOutput (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_android_exoplayer_upstream_Allocator_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultTrackOutput']/constructor[@name='DefaultTrackOutput' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer.upstream.Allocator']]"
		[Register (".ctor", "(Lcom/google/android/exoplayer/upstream/Allocator;)V", "")]
		public unsafe DefaultTrackOutput (global::Com.Google.Android.Exoplayer.Upstream.IAllocator p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (DefaultTrackOutput)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/google/android/exoplayer/upstream/Allocator;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/google/android/exoplayer/upstream/Allocator;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_android_exoplayer_upstream_Allocator_ == IntPtr.Zero)
					id_ctor_Lcom_google_android_exoplayer_upstream_Allocator_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/android/exoplayer/upstream/Allocator;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_android_exoplayer_upstream_Allocator_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_google_android_exoplayer_upstream_Allocator_, __args);
			} finally {
			}
		}

		static Delegate cb_hasFormat;
#pragma warning disable 0169
		static Delegate GetHasFormatHandler ()
		{
			if (cb_hasFormat == null)
				cb_hasFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasFormat);
			return cb_hasFormat;
		}

		static bool n_HasFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasFormat;
		}
#pragma warning restore 0169

		static IntPtr id_hasFormat;
		public virtual unsafe bool HasFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultTrackOutput']/method[@name='hasFormat' and count(parameter)=0]"
			[Register ("hasFormat", "()Z", "GetHasFormatHandler")]
			get {
				if (id_hasFormat == IntPtr.Zero)
					id_hasFormat = JNIEnv.GetMethodID (class_ref, "hasFormat", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasFormat);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasFormat", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		static IntPtr id_isEmpty;
		public virtual unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultTrackOutput']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				if (id_isEmpty == IntPtr.Zero)
					id_isEmpty = JNIEnv.GetMethodID (class_ref, "isEmpty", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEmpty);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEmpty", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLargestParsedTimestampUs;
#pragma warning disable 0169
		static Delegate GetGetLargestParsedTimestampUsHandler ()
		{
			if (cb_getLargestParsedTimestampUs == null)
				cb_getLargestParsedTimestampUs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLargestParsedTimestampUs);
			return cb_getLargestParsedTimestampUs;
		}

		static long n_GetLargestParsedTimestampUs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LargestParsedTimestampUs;
		}
#pragma warning restore 0169

		static IntPtr id_getLargestParsedTimestampUs;
		public virtual unsafe long LargestParsedTimestampUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultTrackOutput']/method[@name='getLargestParsedTimestampUs' and count(parameter)=0]"
			[Register ("getLargestParsedTimestampUs", "()J", "GetGetLargestParsedTimestampUsHandler")]
			get {
				if (id_getLargestParsedTimestampUs == IntPtr.Zero)
					id_getLargestParsedTimestampUs = JNIEnv.GetMethodID (class_ref, "getLargestParsedTimestampUs", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLargestParsedTimestampUs);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLargestParsedTimestampUs", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getReadIndex;
#pragma warning disable 0169
		static Delegate GetGetReadIndexHandler ()
		{
			if (cb_getReadIndex == null)
				cb_getReadIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetReadIndex);
			return cb_getReadIndex;
		}

		static int n_GetReadIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadIndex;
		}
#pragma warning restore 0169

		static IntPtr id_getReadIndex;
		public virtual unsafe int ReadIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultTrackOutput']/method[@name='getReadIndex' and count(parameter)=0]"
			[Register ("getReadIndex", "()I", "GetGetReadIndexHandler")]
			get {
				if (id_getReadIndex == IntPtr.Zero)
					id_getReadIndex = JNIEnv.GetMethodID (class_ref, "getReadIndex", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getReadIndex);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReadIndex", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getWriteIndex;
#pragma warning disable 0169
		static Delegate GetGetWriteIndexHandler ()
		{
			if (cb_getWriteIndex == null)
				cb_getWriteIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWriteIndex);
			return cb_getWriteIndex;
		}

		static int n_GetWriteIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WriteIndex;
		}
#pragma warning restore 0169

		static IntPtr id_getWriteIndex;
		public virtual unsafe int WriteIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultTrackOutput']/method[@name='getWriteIndex' and count(parameter)=0]"
			[Register ("getWriteIndex", "()I", "GetGetWriteIndexHandler")]
			get {
				if (id_getWriteIndex == IntPtr.Zero)
					id_getWriteIndex = JNIEnv.GetMethodID (class_ref, "getWriteIndex", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWriteIndex);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWriteIndex", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultTrackOutput']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_configureSpliceTo_Lcom_google_android_exoplayer_extractor_DefaultTrackOutput_;
#pragma warning disable 0169
		static Delegate GetConfigureSpliceTo_Lcom_google_android_exoplayer_extractor_DefaultTrackOutput_Handler ()
		{
			if (cb_configureSpliceTo_Lcom_google_android_exoplayer_extractor_DefaultTrackOutput_ == null)
				cb_configureSpliceTo_Lcom_google_android_exoplayer_extractor_DefaultTrackOutput_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ConfigureSpliceTo_Lcom_google_android_exoplayer_extractor_DefaultTrackOutput_);
			return cb_configureSpliceTo_Lcom_google_android_exoplayer_extractor_DefaultTrackOutput_;
		}

		static bool n_ConfigureSpliceTo_Lcom_google_android_exoplayer_extractor_DefaultTrackOutput_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ConfigureSpliceTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_configureSpliceTo_Lcom_google_android_exoplayer_extractor_DefaultTrackOutput_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultTrackOutput']/method[@name='configureSpliceTo' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer.extractor.DefaultTrackOutput']]"
		[Register ("configureSpliceTo", "(Lcom/google/android/exoplayer/extractor/DefaultTrackOutput;)Z", "GetConfigureSpliceTo_Lcom_google_android_exoplayer_extractor_DefaultTrackOutput_Handler")]
		public virtual unsafe bool ConfigureSpliceTo (global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput p0)
		{
			if (id_configureSpliceTo_Lcom_google_android_exoplayer_extractor_DefaultTrackOutput_ == IntPtr.Zero)
				id_configureSpliceTo_Lcom_google_android_exoplayer_extractor_DefaultTrackOutput_ = JNIEnv.GetMethodID (class_ref, "configureSpliceTo", "(Lcom/google/android/exoplayer/extractor/DefaultTrackOutput;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_configureSpliceTo_Lcom_google_android_exoplayer_extractor_DefaultTrackOutput_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "configureSpliceTo", "(Lcom/google/android/exoplayer/extractor/DefaultTrackOutput;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_discardUntil_J;
#pragma warning disable 0169
		static Delegate GetDiscardUntil_JHandler ()
		{
			if (cb_discardUntil_J == null)
				cb_discardUntil_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_DiscardUntil_J);
			return cb_discardUntil_J;
		}

		static void n_DiscardUntil_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DiscardUntil (p0);
		}
#pragma warning restore 0169

		static IntPtr id_discardUntil_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultTrackOutput']/method[@name='discardUntil' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("discardUntil", "(J)V", "GetDiscardUntil_JHandler")]
		public virtual unsafe void DiscardUntil (long p0)
		{
			if (id_discardUntil_J == IntPtr.Zero)
				id_discardUntil_J = JNIEnv.GetMethodID (class_ref, "discardUntil", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_discardUntil_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "discardUntil", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_discardUpstreamSamples_I;
#pragma warning disable 0169
		static Delegate GetDiscardUpstreamSamples_IHandler ()
		{
			if (cb_discardUpstreamSamples_I == null)
				cb_discardUpstreamSamples_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_DiscardUpstreamSamples_I);
			return cb_discardUpstreamSamples_I;
		}

		static void n_DiscardUpstreamSamples_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DiscardUpstreamSamples (p0);
		}
#pragma warning restore 0169

		static IntPtr id_discardUpstreamSamples_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultTrackOutput']/method[@name='discardUpstreamSamples' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("discardUpstreamSamples", "(I)V", "GetDiscardUpstreamSamples_IHandler")]
		public virtual unsafe void DiscardUpstreamSamples (int p0)
		{
			if (id_discardUpstreamSamples_I == IntPtr.Zero)
				id_discardUpstreamSamples_I = JNIEnv.GetMethodID (class_ref, "discardUpstreamSamples", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_discardUpstreamSamples_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "discardUpstreamSamples", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getSample_Lcom_google_android_exoplayer_SampleHolder_;
#pragma warning disable 0169
		static Delegate GetGetSample_Lcom_google_android_exoplayer_SampleHolder_Handler ()
		{
			if (cb_getSample_Lcom_google_android_exoplayer_SampleHolder_ == null)
				cb_getSample_Lcom_google_android_exoplayer_SampleHolder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_GetSample_Lcom_google_android_exoplayer_SampleHolder_);
			return cb_getSample_Lcom_google_android_exoplayer_SampleHolder_;
		}

		static bool n_GetSample_Lcom_google_android_exoplayer_SampleHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.SampleHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.SampleHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetSample (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSample_Lcom_google_android_exoplayer_SampleHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultTrackOutput']/method[@name='getSample' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer.SampleHolder']]"
		[Register ("getSample", "(Lcom/google/android/exoplayer/SampleHolder;)Z", "GetGetSample_Lcom_google_android_exoplayer_SampleHolder_Handler")]
		public virtual unsafe bool GetSample (global::Com.Google.Android.Exoplayer.SampleHolder p0)
		{
			if (id_getSample_Lcom_google_android_exoplayer_SampleHolder_ == IntPtr.Zero)
				id_getSample_Lcom_google_android_exoplayer_SampleHolder_ = JNIEnv.GetMethodID (class_ref, "getSample", "(Lcom/google/android/exoplayer/SampleHolder;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getSample_Lcom_google_android_exoplayer_SampleHolder_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSample", "(Lcom/google/android/exoplayer/SampleHolder;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_sampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ;
#pragma warning disable 0169
		static Delegate GetSampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZHandler ()
		{
			if (cb_sampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ == null)
				cb_sampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool, int>) n_SampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ);
			return cb_sampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ;
		}

		static int n_SampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, bool p2)
		{
			global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput p0 = (global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SampleData (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultTrackOutput']/method[@name='sampleData' and count(parameter)=3 and parameter[1][@type='com.google.android.exoplayer.extractor.ExtractorInput'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("sampleData", "(Lcom/google/android/exoplayer/extractor/ExtractorInput;IZ)I", "GetSampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZHandler")]
		public virtual unsafe int SampleData (global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput p0, int p1, bool p2)
		{
			if (id_sampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ == IntPtr.Zero)
				id_sampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ = JNIEnv.GetMethodID (class_ref, "sampleData", "(Lcom/google/android/exoplayer/extractor/ExtractorInput;IZ)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_sampleData_Lcom_google_android_exoplayer_extractor_ExtractorInput_IZ, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sampleData", "(Lcom/google/android/exoplayer/extractor/ExtractorInput;IZ)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_sampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I;
#pragma warning disable 0169
		static Delegate GetSampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_IHandler ()
		{
			if (cb_sampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I == null)
				cb_sampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I);
			return cb_sampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I;
		}

		static void n_SampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Util.ParsableByteArray p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Util.ParsableByteArray> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SampleData (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultTrackOutput']/method[@name='sampleData' and count(parameter)=2 and parameter[1][@type='com.google.android.exoplayer.util.ParsableByteArray'] and parameter[2][@type='int']]"
		[Register ("sampleData", "(Lcom/google/android/exoplayer/util/ParsableByteArray;I)V", "GetSampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_IHandler")]
		public virtual unsafe void SampleData (global::Com.Google.Android.Exoplayer.Util.ParsableByteArray p0, int p1)
		{
			if (id_sampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I == IntPtr.Zero)
				id_sampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I = JNIEnv.GetMethodID (class_ref, "sampleData", "(Lcom/google/android/exoplayer/util/ParsableByteArray;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sampleData_Lcom_google_android_exoplayer_util_ParsableByteArray_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sampleData", "(Lcom/google/android/exoplayer/util/ParsableByteArray;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sampleMetadata_JIIIarrayB;
#pragma warning disable 0169
		static Delegate GetSampleMetadata_JIIIarrayBHandler ()
		{
			if (cb_sampleMetadata_JIIIarrayB == null)
				cb_sampleMetadata_JIIIarrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, int, int, int, IntPtr>) n_SampleMetadata_JIIIarrayB);
			return cb_sampleMetadata_JIIIarrayB;
		}

		static void n_SampleMetadata_JIIIarrayB (IntPtr jnienv, IntPtr native__this, long p0, int p1, int p2, int p3, IntPtr native_p4)
		{
			global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p4 = (byte[]) JNIEnv.GetArray (native_p4, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SampleMetadata (p0, p1, p2, p3, p4);
			if (p4 != null)
				JNIEnv.CopyArray (p4, native_p4);
		}
#pragma warning restore 0169

		static IntPtr id_sampleMetadata_JIIIarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultTrackOutput']/method[@name='sampleMetadata' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='byte[]']]"
		[Register ("sampleMetadata", "(JIII[B)V", "GetSampleMetadata_JIIIarrayBHandler")]
		public virtual unsafe void SampleMetadata (long p0, int p1, int p2, int p3, byte[] p4)
		{
			if (id_sampleMetadata_JIIIarrayB == IntPtr.Zero)
				id_sampleMetadata_JIIIarrayB = JNIEnv.GetMethodID (class_ref, "sampleMetadata", "(JIII[B)V");
			IntPtr native_p4 = JNIEnv.NewArray (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sampleMetadata_JIIIarrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sampleMetadata", "(JIII[B)V"), __args);
			} finally {
				if (p4 != null) {
					JNIEnv.CopyArray (native_p4, p4);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}
		}

		static Delegate cb_skipToKeyframeBefore_J;
#pragma warning disable 0169
		static Delegate GetSkipToKeyframeBefore_JHandler ()
		{
			if (cb_skipToKeyframeBefore_J == null)
				cb_skipToKeyframeBefore_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_SkipToKeyframeBefore_J);
			return cb_skipToKeyframeBefore_J;
		}

		static bool n_SkipToKeyframeBefore_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.DefaultTrackOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SkipToKeyframeBefore (p0);
		}
#pragma warning restore 0169

		static IntPtr id_skipToKeyframeBefore_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultTrackOutput']/method[@name='skipToKeyframeBefore' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("skipToKeyframeBefore", "(J)Z", "GetSkipToKeyframeBefore_JHandler")]
		public virtual unsafe bool SkipToKeyframeBefore (long p0)
		{
			if (id_skipToKeyframeBefore_J == IntPtr.Zero)
				id_skipToKeyframeBefore_J = JNIEnv.GetMethodID (class_ref, "skipToKeyframeBefore", "(J)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_skipToKeyframeBefore_J, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "skipToKeyframeBefore", "(J)Z"), __args);
			} finally {
			}
		}

	}
}
