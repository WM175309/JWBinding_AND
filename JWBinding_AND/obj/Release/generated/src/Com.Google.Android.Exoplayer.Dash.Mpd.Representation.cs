using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Dash.Mpd {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='Representation']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/dash/mpd/Representation", DoNotGenerateAcw=true)]
	public abstract partial class Representation : global::Java.Lang.Object, global::Com.Google.Android.Exoplayer.Chunk.IFormatWrapper {


		static IntPtr contentId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='Representation']/field[@name='contentId']"
		[Register ("contentId")]
		public string ContentId {
			get {
				if (contentId_jfieldId == IntPtr.Zero)
					contentId_jfieldId = JNIEnv.GetFieldID (class_ref, "contentId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, contentId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (contentId_jfieldId == IntPtr.Zero)
					contentId_jfieldId = JNIEnv.GetFieldID (class_ref, "contentId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, contentId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr presentationTimeOffsetUs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='Representation']/field[@name='presentationTimeOffsetUs']"
		[Register ("presentationTimeOffsetUs")]
		public long PresentationTimeOffsetUs {
			get {
				if (presentationTimeOffsetUs_jfieldId == IntPtr.Zero)
					presentationTimeOffsetUs_jfieldId = JNIEnv.GetFieldID (class_ref, "presentationTimeOffsetUs", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, presentationTimeOffsetUs_jfieldId);
			}
			set {
				if (presentationTimeOffsetUs_jfieldId == IntPtr.Zero)
					presentationTimeOffsetUs_jfieldId = JNIEnv.GetFieldID (class_ref, "presentationTimeOffsetUs", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, presentationTimeOffsetUs_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr revisionId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='Representation']/field[@name='revisionId']"
		[Register ("revisionId")]
		public long RevisionId {
			get {
				if (revisionId_jfieldId == IntPtr.Zero)
					revisionId_jfieldId = JNIEnv.GetFieldID (class_ref, "revisionId", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, revisionId_jfieldId);
			}
			set {
				if (revisionId_jfieldId == IntPtr.Zero)
					revisionId_jfieldId = JNIEnv.GetFieldID (class_ref, "revisionId", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, revisionId_jfieldId, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='Representation.MultiSegmentRepresentation']"
		[global::Android.Runtime.Register ("com/google/android/exoplayer/dash/mpd/Representation$MultiSegmentRepresentation", DoNotGenerateAcw=true)]
		public partial class MultiSegmentRepresentation : global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/exoplayer/dash/mpd/Representation$MultiSegmentRepresentation", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MultiSegmentRepresentation); }
			}

			protected MultiSegmentRepresentation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_JLcom_google_android_exoplayer_chunk_Format_Lcom_google_android_exoplayer_dash_mpd_SegmentBase_MultiSegmentBase_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='Representation.MultiSegmentRepresentation']/constructor[@name='Representation.MultiSegmentRepresentation' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='com.google.android.exoplayer.chunk.Format'] and parameter[4][@type='com.google.android.exoplayer.dash.mpd.SegmentBase.MultiSegmentBase'] and parameter[5][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;JLcom/google/android/exoplayer/chunk/Format;Lcom/google/android/exoplayer/dash/mpd/SegmentBase$MultiSegmentBase;Ljava/lang/String;)V", "")]
			public unsafe MultiSegmentRepresentation (string p0, long p1, global::Com.Google.Android.Exoplayer.Chunk.Format p2, global::Com.Google.Android.Exoplayer.Dash.Mpd.SegmentBase.MultiSegmentBase p3, string p4)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p4 = JNIEnv.NewString (p4);
				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (native_p4);
					if (GetType () != typeof (MultiSegmentRepresentation)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;JLcom/google/android/exoplayer/chunk/Format;Lcom/google/android/exoplayer/dash/mpd/SegmentBase$MultiSegmentBase;Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;JLcom/google/android/exoplayer/chunk/Format;Lcom/google/android/exoplayer/dash/mpd/SegmentBase$MultiSegmentBase;Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_JLcom_google_android_exoplayer_chunk_Format_Lcom_google_android_exoplayer_dash_mpd_SegmentBase_MultiSegmentBase_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_JLcom_google_android_exoplayer_chunk_Format_Lcom_google_android_exoplayer_dash_mpd_SegmentBase_MultiSegmentBase_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;JLcom/google/android/exoplayer/chunk/Format;Lcom/google/android/exoplayer/dash/mpd/SegmentBase$MultiSegmentBase;Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_JLcom_google_android_exoplayer_chunk_Format_Lcom_google_android_exoplayer_dash_mpd_SegmentBase_MultiSegmentBase_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_JLcom_google_android_exoplayer_chunk_Format_Lcom_google_android_exoplayer_dash_mpd_SegmentBase_MultiSegmentBase_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p4);
				}
			}

			static Delegate cb_getFirstSegmentNum;
#pragma warning disable 0169
			static Delegate GetGetFirstSegmentNumHandler ()
			{
				if (cb_getFirstSegmentNum == null)
					cb_getFirstSegmentNum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFirstSegmentNum);
				return cb_getFirstSegmentNum;
			}

			static int n_GetFirstSegmentNum (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation.MultiSegmentRepresentation __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation.MultiSegmentRepresentation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.FirstSegmentNum;
			}
#pragma warning restore 0169

			static IntPtr id_getFirstSegmentNum;
			public virtual unsafe int FirstSegmentNum {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='Representation.MultiSegmentRepresentation']/method[@name='getFirstSegmentNum' and count(parameter)=0]"
				[Register ("getFirstSegmentNum", "()I", "GetGetFirstSegmentNumHandler")]
				get {
					if (id_getFirstSegmentNum == IntPtr.Zero)
						id_getFirstSegmentNum = JNIEnv.GetMethodID (class_ref, "getFirstSegmentNum", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFirstSegmentNum);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirstSegmentNum", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_isExplicit;
#pragma warning disable 0169
			static Delegate GetIsExplicitHandler ()
			{
				if (cb_isExplicit == null)
					cb_isExplicit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsExplicit);
				return cb_isExplicit;
			}

			static bool n_IsExplicit (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation.MultiSegmentRepresentation __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation.MultiSegmentRepresentation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsExplicit;
			}
#pragma warning restore 0169

			static IntPtr id_isExplicit;
			public virtual unsafe bool IsExplicit {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='Representation.MultiSegmentRepresentation']/method[@name='isExplicit' and count(parameter)=0]"
				[Register ("isExplicit", "()Z", "GetIsExplicitHandler")]
				get {
					if (id_isExplicit == IntPtr.Zero)
						id_isExplicit = JNIEnv.GetMethodID (class_ref, "isExplicit", "()Z");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isExplicit);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isExplicit", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_getDurationUs_IJ;
#pragma warning disable 0169
			static Delegate GetGetDurationUs_IJHandler ()
			{
				if (cb_getDurationUs_IJ == null)
					cb_getDurationUs_IJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long, long>) n_GetDurationUs_IJ);
				return cb_getDurationUs_IJ;
			}

			static long n_GetDurationUs_IJ (IntPtr jnienv, IntPtr native__this, int p0, long p1)
			{
				global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation.MultiSegmentRepresentation __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation.MultiSegmentRepresentation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetDurationUs (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_getDurationUs_IJ;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='Representation.MultiSegmentRepresentation']/method[@name='getDurationUs' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
			[Register ("getDurationUs", "(IJ)J", "GetGetDurationUs_IJHandler")]
			public virtual unsafe long GetDurationUs (int p0, long p1)
			{
				if (id_getDurationUs_IJ == IntPtr.Zero)
					id_getDurationUs_IJ = JNIEnv.GetMethodID (class_ref, "getDurationUs", "(IJ)J");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDurationUs_IJ, __args);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDurationUs", "(IJ)J"), __args);
				} finally {
				}
			}

			static Delegate cb_getLastSegmentNum_J;
#pragma warning disable 0169
			static Delegate GetGetLastSegmentNum_JHandler ()
			{
				if (cb_getLastSegmentNum_J == null)
					cb_getLastSegmentNum_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int>) n_GetLastSegmentNum_J);
				return cb_getLastSegmentNum_J;
			}

			static int n_GetLastSegmentNum_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation.MultiSegmentRepresentation __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation.MultiSegmentRepresentation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetLastSegmentNum (p0);
			}
#pragma warning restore 0169

			static IntPtr id_getLastSegmentNum_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='Representation.MultiSegmentRepresentation']/method[@name='getLastSegmentNum' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("getLastSegmentNum", "(J)I", "GetGetLastSegmentNum_JHandler")]
			public virtual unsafe int GetLastSegmentNum (long p0)
			{
				if (id_getLastSegmentNum_J == IntPtr.Zero)
					id_getLastSegmentNum_J = JNIEnv.GetMethodID (class_ref, "getLastSegmentNum", "(J)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLastSegmentNum_J, __args);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastSegmentNum", "(J)I"), __args);
				} finally {
				}
			}

			static Delegate cb_getSegmentNum_JJ;
#pragma warning disable 0169
			static Delegate GetGetSegmentNum_JJHandler ()
			{
				if (cb_getSegmentNum_JJ == null)
					cb_getSegmentNum_JJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, int>) n_GetSegmentNum_JJ);
				return cb_getSegmentNum_JJ;
			}

			static int n_GetSegmentNum_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
			{
				global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation.MultiSegmentRepresentation __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation.MultiSegmentRepresentation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetSegmentNum (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_getSegmentNum_JJ;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='Representation.MultiSegmentRepresentation']/method[@name='getSegmentNum' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register ("getSegmentNum", "(JJ)I", "GetGetSegmentNum_JJHandler")]
			public virtual unsafe int GetSegmentNum (long p0, long p1)
			{
				if (id_getSegmentNum_JJ == IntPtr.Zero)
					id_getSegmentNum_JJ = JNIEnv.GetMethodID (class_ref, "getSegmentNum", "(JJ)I");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSegmentNum_JJ, __args);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSegmentNum", "(JJ)I"), __args);
				} finally {
				}
			}

			static Delegate cb_getTimeUs_I;
#pragma warning disable 0169
			static Delegate GetGetTimeUs_IHandler ()
			{
				if (cb_getTimeUs_I == null)
					cb_getTimeUs_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetTimeUs_I);
				return cb_getTimeUs_I;
			}

			static long n_GetTimeUs_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation.MultiSegmentRepresentation __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation.MultiSegmentRepresentation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetTimeUs (p0);
			}
#pragma warning restore 0169

			static IntPtr id_getTimeUs_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='Representation.MultiSegmentRepresentation']/method[@name='getTimeUs' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getTimeUs", "(I)J", "GetGetTimeUs_IHandler")]
			public virtual unsafe long GetTimeUs (int p0)
			{
				if (id_getTimeUs_I == IntPtr.Zero)
					id_getTimeUs_I = JNIEnv.GetMethodID (class_ref, "getTimeUs", "(I)J");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTimeUs_I, __args);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimeUs", "(I)J"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/dash/mpd/Representation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Representation); }
		}

		protected Representation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getCacheKey;
#pragma warning disable 0169
		static Delegate GetGetCacheKeyHandler ()
		{
			if (cb_getCacheKey == null)
				cb_getCacheKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCacheKey);
			return cb_getCacheKey;
		}

		static IntPtr n_GetCacheKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CacheKey);
		}
#pragma warning restore 0169

		static IntPtr id_getCacheKey;
		public virtual unsafe string CacheKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='Representation']/method[@name='getCacheKey' and count(parameter)=0]"
			[Register ("getCacheKey", "()Ljava/lang/String;", "GetGetCacheKeyHandler")]
			get {
				if (id_getCacheKey == IntPtr.Zero)
					id_getCacheKey = JNIEnv.GetMethodID (class_ref, "getCacheKey", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCacheKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCacheKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFormat;
#pragma warning disable 0169
		static Delegate GetGetFormatHandler ()
		{
			if (cb_getFormat == null)
				cb_getFormat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormat);
			return cb_getFormat;
		}

		static IntPtr n_GetFormat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Format);
		}
#pragma warning restore 0169

		static IntPtr id_getFormat;
		public virtual unsafe global::Com.Google.Android.Exoplayer.Chunk.Format Format {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='Representation']/method[@name='getFormat' and count(parameter)=0]"
			[Register ("getFormat", "()Lcom/google/android/exoplayer/chunk/Format;", "GetGetFormatHandler")]
			get {
				if (id_getFormat == IntPtr.Zero)
					id_getFormat = JNIEnv.GetMethodID (class_ref, "getFormat", "()Lcom/google/android/exoplayer/chunk/Format;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Chunk.Format> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormat), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Chunk.Format> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFormat", "()Lcom/google/android/exoplayer/chunk/Format;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_newInstance_Ljava_lang_String_JLcom_google_android_exoplayer_chunk_Format_Lcom_google_android_exoplayer_dash_mpd_SegmentBase_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='Representation']/method[@name='newInstance' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='com.google.android.exoplayer.chunk.Format'] and parameter[4][@type='com.google.android.exoplayer.dash.mpd.SegmentBase']]"
		[Register ("newInstance", "(Ljava/lang/String;JLcom/google/android/exoplayer/chunk/Format;Lcom/google/android/exoplayer/dash/mpd/SegmentBase;)Lcom/google/android/exoplayer/dash/mpd/Representation;", "")]
		public static unsafe global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation NewInstance (string p0, long p1, global::Com.Google.Android.Exoplayer.Chunk.Format p2, global::Com.Google.Android.Exoplayer.Dash.Mpd.SegmentBase p3)
		{
			if (id_newInstance_Ljava_lang_String_JLcom_google_android_exoplayer_chunk_Format_Lcom_google_android_exoplayer_dash_mpd_SegmentBase_ == IntPtr.Zero)
				id_newInstance_Ljava_lang_String_JLcom_google_android_exoplayer_chunk_Format_Lcom_google_android_exoplayer_dash_mpd_SegmentBase_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Ljava/lang/String;JLcom/google/android/exoplayer/chunk/Format;Lcom/google/android/exoplayer/dash/mpd/SegmentBase;)Lcom/google/android/exoplayer/dash/mpd/Representation;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Ljava_lang_String_JLcom_google_android_exoplayer_chunk_Format_Lcom_google_android_exoplayer_dash_mpd_SegmentBase_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_newInstance_Ljava_lang_String_JLcom_google_android_exoplayer_chunk_Format_Lcom_google_android_exoplayer_dash_mpd_SegmentBase_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='Representation']/method[@name='newInstance' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='com.google.android.exoplayer.chunk.Format'] and parameter[4][@type='com.google.android.exoplayer.dash.mpd.SegmentBase'] and parameter[5][@type='java.lang.String']]"
		[Register ("newInstance", "(Ljava/lang/String;JLcom/google/android/exoplayer/chunk/Format;Lcom/google/android/exoplayer/dash/mpd/SegmentBase;Ljava/lang/String;)Lcom/google/android/exoplayer/dash/mpd/Representation;", "")]
		public static unsafe global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation NewInstance (string p0, long p1, global::Com.Google.Android.Exoplayer.Chunk.Format p2, global::Com.Google.Android.Exoplayer.Dash.Mpd.SegmentBase p3, string p4)
		{
			if (id_newInstance_Ljava_lang_String_JLcom_google_android_exoplayer_chunk_Format_Lcom_google_android_exoplayer_dash_mpd_SegmentBase_Ljava_lang_String_ == IntPtr.Zero)
				id_newInstance_Ljava_lang_String_JLcom_google_android_exoplayer_chunk_Format_Lcom_google_android_exoplayer_dash_mpd_SegmentBase_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(Ljava/lang/String;JLcom/google/android/exoplayer/chunk/Format;Lcom/google/android/exoplayer/dash/mpd/SegmentBase;Ljava/lang/String;)Lcom/google/android/exoplayer/dash/mpd/Representation;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_Ljava_lang_String_JLcom_google_android_exoplayer_chunk_Format_Lcom_google_android_exoplayer_dash_mpd_SegmentBase_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/dash/mpd/Representation", DoNotGenerateAcw=true)]
	internal partial class RepresentationInvoker : Representation {

		public RepresentationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (RepresentationInvoker); }
		}

	}

}
