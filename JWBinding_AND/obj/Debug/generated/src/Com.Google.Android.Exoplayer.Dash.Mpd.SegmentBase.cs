using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Dash.Mpd {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='SegmentBase']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/dash/mpd/SegmentBase", DoNotGenerateAcw=true)]
	public abstract partial class SegmentBase : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='SegmentBase.MultiSegmentBase']"
		[global::Android.Runtime.Register ("com/google/android/exoplayer/dash/mpd/SegmentBase$MultiSegmentBase", DoNotGenerateAcw=true)]
		public abstract partial class MultiSegmentBase : global::Com.Google.Android.Exoplayer.Dash.Mpd.SegmentBase {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/exoplayer/dash/mpd/SegmentBase$MultiSegmentBase", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MultiSegmentBase); }
			}

			protected MultiSegmentBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Google.Android.Exoplayer.Dash.Mpd.SegmentBase.MultiSegmentBase __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Dash.Mpd.SegmentBase.MultiSegmentBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.FirstSegmentNum;
			}
#pragma warning restore 0169

			static IntPtr id_getFirstSegmentNum;
			public virtual unsafe int FirstSegmentNum {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='SegmentBase.MultiSegmentBase']/method[@name='getFirstSegmentNum' and count(parameter)=0]"
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
				global::Com.Google.Android.Exoplayer.Dash.Mpd.SegmentBase.MultiSegmentBase __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Dash.Mpd.SegmentBase.MultiSegmentBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsExplicit;
			}
#pragma warning restore 0169

			static IntPtr id_isExplicit;
			public virtual unsafe bool IsExplicit {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='SegmentBase.MultiSegmentBase']/method[@name='isExplicit' and count(parameter)=0]"
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
				global::Com.Google.Android.Exoplayer.Dash.Mpd.SegmentBase.MultiSegmentBase __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Dash.Mpd.SegmentBase.MultiSegmentBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetLastSegmentNum (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='SegmentBase.MultiSegmentBase']/method[@name='getLastSegmentNum' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("getLastSegmentNum", "(J)I", "GetGetLastSegmentNum_JHandler")]
			public abstract int GetLastSegmentNum (long p0);

			static IntPtr id_getSegmentDurationUs_IJ;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='SegmentBase.MultiSegmentBase']/method[@name='getSegmentDurationUs' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
			[Register ("getSegmentDurationUs", "(IJ)J", "")]
			public unsafe long GetSegmentDurationUs (int p0, long p1)
			{
				if (id_getSegmentDurationUs_IJ == IntPtr.Zero)
					id_getSegmentDurationUs_IJ = JNIEnv.GetMethodID (class_ref, "getSegmentDurationUs", "(IJ)J");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getSegmentDurationUs_IJ, __args);
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
				global::Com.Google.Android.Exoplayer.Dash.Mpd.SegmentBase.MultiSegmentBase __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Dash.Mpd.SegmentBase.MultiSegmentBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetSegmentNum (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_getSegmentNum_JJ;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='SegmentBase.MultiSegmentBase']/method[@name='getSegmentNum' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
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

			static IntPtr id_getSegmentTimeUs_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='SegmentBase.MultiSegmentBase']/method[@name='getSegmentTimeUs' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getSegmentTimeUs", "(I)J", "")]
			public unsafe long GetSegmentTimeUs (int p0)
			{
				if (id_getSegmentTimeUs_I == IntPtr.Zero)
					id_getSegmentTimeUs_I = JNIEnv.GetMethodID (class_ref, "getSegmentTimeUs", "(I)J");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getSegmentTimeUs_I, __args);
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("com/google/android/exoplayer/dash/mpd/SegmentBase$MultiSegmentBase", DoNotGenerateAcw=true)]
		internal partial class MultiSegmentBaseInvoker : MultiSegmentBase {

			public MultiSegmentBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (MultiSegmentBaseInvoker); }
			}

			static IntPtr id_getLastSegmentNum_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='SegmentBase.MultiSegmentBase']/method[@name='getLastSegmentNum' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("getLastSegmentNum", "(J)I", "GetGetLastSegmentNum_JHandler")]
			public override unsafe int GetLastSegmentNum (long p0)
			{
				if (id_getLastSegmentNum_J == IntPtr.Zero)
					id_getLastSegmentNum_J = JNIEnv.GetMethodID (class_ref, "getLastSegmentNum", "(J)I");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLastSegmentNum_J, __args);
				} finally {
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='SegmentBase.SegmentList']"
		[global::Android.Runtime.Register ("com/google/android/exoplayer/dash/mpd/SegmentBase$SegmentList", DoNotGenerateAcw=true)]
		public partial class SegmentList : global::Com.Google.Android.Exoplayer.Dash.Mpd.SegmentBase.MultiSegmentBase {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/exoplayer/dash/mpd/SegmentBase$SegmentList", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SegmentList); }
			}

			protected SegmentList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Google.Android.Exoplayer.Dash.Mpd.SegmentBase.SegmentList __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Dash.Mpd.SegmentBase.SegmentList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetLastSegmentNum (p0);
			}
#pragma warning restore 0169

			static IntPtr id_getLastSegmentNum_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='SegmentBase.SegmentList']/method[@name='getLastSegmentNum' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("getLastSegmentNum", "(J)I", "GetGetLastSegmentNum_JHandler")]
			public override unsafe int GetLastSegmentNum (long p0)
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='SegmentBase.SegmentTemplate']"
		[global::Android.Runtime.Register ("com/google/android/exoplayer/dash/mpd/SegmentBase$SegmentTemplate", DoNotGenerateAcw=true)]
		public partial class SegmentTemplate : global::Com.Google.Android.Exoplayer.Dash.Mpd.SegmentBase.MultiSegmentBase {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/exoplayer/dash/mpd/SegmentBase$SegmentTemplate", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SegmentTemplate); }
			}

			protected SegmentTemplate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Google.Android.Exoplayer.Dash.Mpd.SegmentBase.SegmentTemplate __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Dash.Mpd.SegmentBase.SegmentTemplate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetLastSegmentNum (p0);
			}
#pragma warning restore 0169

			static IntPtr id_getLastSegmentNum_J;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='SegmentBase.SegmentTemplate']/method[@name='getLastSegmentNum' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("getLastSegmentNum", "(J)I", "GetGetLastSegmentNum_JHandler")]
			public override unsafe int GetLastSegmentNum (long p0)
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='SegmentBase.SegmentTimelineElement']"
		[global::Android.Runtime.Register ("com/google/android/exoplayer/dash/mpd/SegmentBase$SegmentTimelineElement", DoNotGenerateAcw=true)]
		public partial class SegmentTimelineElement : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/exoplayer/dash/mpd/SegmentBase$SegmentTimelineElement", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SegmentTimelineElement); }
			}

			protected SegmentTimelineElement (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_JJ;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='SegmentBase.SegmentTimelineElement']/constructor[@name='SegmentBase.SegmentTimelineElement' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
			[Register (".ctor", "(JJ)V", "")]
			public unsafe SegmentTimelineElement (long p0, long p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (GetType () != typeof (SegmentTimelineElement)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(JJ)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(JJ)V", __args);
						return;
					}

					if (id_ctor_JJ == IntPtr.Zero)
						id_ctor_JJ = JNIEnv.GetMethodID (class_ref, "<init>", "(JJ)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JJ, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_JJ, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='SegmentBase.SingleSegmentBase']"
		[global::Android.Runtime.Register ("com/google/android/exoplayer/dash/mpd/SegmentBase$SingleSegmentBase", DoNotGenerateAcw=true)]
		public partial class SingleSegmentBase : global::Com.Google.Android.Exoplayer.Dash.Mpd.SegmentBase {


			static IntPtr uri_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='SegmentBase.SingleSegmentBase']/field[@name='uri']"
			[Register ("uri")]
			public string Uri {
				get {
					if (uri_jfieldId == IntPtr.Zero)
						uri_jfieldId = JNIEnv.GetFieldID (class_ref, "uri", "Ljava/lang/String;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, uri_jfieldId);
					return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (uri_jfieldId == IntPtr.Zero)
						uri_jfieldId = JNIEnv.GetFieldID (class_ref, "uri", "Ljava/lang/String;");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, uri_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/exoplayer/dash/mpd/SegmentBase$SingleSegmentBase", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SingleSegmentBase); }
			}

			protected SingleSegmentBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='SegmentBase.SingleSegmentBase']/constructor[@name='SegmentBase.SingleSegmentBase' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe SingleSegmentBase (string p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					if (GetType () != typeof (SingleSegmentBase)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
						id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/dash/mpd/SegmentBase", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SegmentBase); }
		}

		protected SegmentBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getPresentationTimeOffsetUs;
#pragma warning disable 0169
		static Delegate GetGetPresentationTimeOffsetUsHandler ()
		{
			if (cb_getPresentationTimeOffsetUs == null)
				cb_getPresentationTimeOffsetUs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetPresentationTimeOffsetUs);
			return cb_getPresentationTimeOffsetUs;
		}

		static long n_GetPresentationTimeOffsetUs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Dash.Mpd.SegmentBase __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Dash.Mpd.SegmentBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PresentationTimeOffsetUs;
		}
#pragma warning restore 0169

		static IntPtr id_getPresentationTimeOffsetUs;
		public virtual unsafe long PresentationTimeOffsetUs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='SegmentBase']/method[@name='getPresentationTimeOffsetUs' and count(parameter)=0]"
			[Register ("getPresentationTimeOffsetUs", "()J", "GetGetPresentationTimeOffsetUsHandler")]
			get {
				if (id_getPresentationTimeOffsetUs == IntPtr.Zero)
					id_getPresentationTimeOffsetUs = JNIEnv.GetMethodID (class_ref, "getPresentationTimeOffsetUs", "()J");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPresentationTimeOffsetUs);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPresentationTimeOffsetUs", "()J"));
				} finally {
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/dash/mpd/SegmentBase", DoNotGenerateAcw=true)]
	internal partial class SegmentBaseInvoker : SegmentBase {

		public SegmentBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (SegmentBaseInvoker); }
		}

	}

}
