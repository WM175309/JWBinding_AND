using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='TimeRange.DynamicTimeRange']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/TimeRange$DynamicTimeRange", DoNotGenerateAcw=true)]
	public sealed partial class TimeRangeDynamicTimeRange : global::Java.Lang.Object, global::Com.Google.Android.Exoplayer.ITimeRange {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/TimeRange$DynamicTimeRange", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TimeRangeDynamicTimeRange); }
		}

		internal TimeRangeDynamicTimeRange (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JJJJLcom_google_android_exoplayer_util_Clock_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='TimeRange.DynamicTimeRange']/constructor[@name='TimeRange.DynamicTimeRange' and count(parameter)=5 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='com.google.android.exoplayer.util.Clock']]"
		[Register (".ctor", "(JJJJLcom/google/android/exoplayer/util/Clock;)V", "")]
		public unsafe TimeRangeDynamicTimeRange (long p0, long p1, long p2, long p3, global::Com.Google.Android.Exoplayer.Util.IClock p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (TimeRangeDynamicTimeRange)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(JJJJLcom/google/android/exoplayer/util/Clock;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(JJJJLcom/google/android/exoplayer/util/Clock;)V", __args);
					return;
				}

				if (id_ctor_JJJJLcom_google_android_exoplayer_util_Clock_ == IntPtr.Zero)
					id_ctor_JJJJLcom_google_android_exoplayer_util_Clock_ = JNIEnv.GetMethodID (class_ref, "<init>", "(JJJJLcom/google/android/exoplayer/util/Clock;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_JJJJLcom_google_android_exoplayer_util_Clock_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_JJJJLcom_google_android_exoplayer_util_Clock_, __args);
			} finally {
			}
		}

		static IntPtr id_isStatic;
		public unsafe bool IsStatic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='TimeRange.DynamicTimeRange']/method[@name='isStatic' and count(parameter)=0]"
			[Register ("isStatic", "()Z", "GetIsStaticHandler")]
			get {
				if (id_isStatic == IntPtr.Zero)
					id_isStatic = JNIEnv.GetMethodID (class_ref, "isStatic", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStatic);
				} finally {
				}
			}
		}

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='TimeRange.DynamicTimeRange']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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

		static IntPtr id_getCurrentBoundsMs_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='TimeRange.DynamicTimeRange']/method[@name='getCurrentBoundsMs' and count(parameter)=1 and parameter[1][@type='long[]']]"
		[Register ("getCurrentBoundsMs", "([J)[J", "")]
		public unsafe long[] GetCurrentBoundsMs (long[] p0)
		{
			if (id_getCurrentBoundsMs_arrayJ == IntPtr.Zero)
				id_getCurrentBoundsMs_arrayJ = JNIEnv.GetMethodID (class_ref, "getCurrentBoundsMs", "([J)[J");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentBoundsMs_arrayJ, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getCurrentBoundsUs_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='TimeRange.DynamicTimeRange']/method[@name='getCurrentBoundsUs' and count(parameter)=1 and parameter[1][@type='long[]']]"
		[Register ("getCurrentBoundsUs", "([J)[J", "")]
		public unsafe long[] GetCurrentBoundsUs (long[] p0)
		{
			if (id_getCurrentBoundsUs_arrayJ == IntPtr.Zero)
				id_getCurrentBoundsUs_arrayJ = JNIEnv.GetMethodID (class_ref, "getCurrentBoundsUs", "([J)[J");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentBoundsUs_arrayJ, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_hashCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='TimeRange.DynamicTimeRange']/method[@name='hashCode' and count(parameter)=0]"
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

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='TimeRange.StaticTimeRange']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/TimeRange$StaticTimeRange", DoNotGenerateAcw=true)]
	public sealed partial class TimeRangeStaticTimeRange : global::Java.Lang.Object, global::Com.Google.Android.Exoplayer.ITimeRange {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/TimeRange$StaticTimeRange", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TimeRangeStaticTimeRange); }
		}

		internal TimeRangeStaticTimeRange (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_JJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='TimeRange.StaticTimeRange']/constructor[@name='TimeRange.StaticTimeRange' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register (".ctor", "(JJ)V", "")]
		public unsafe TimeRangeStaticTimeRange (long p0, long p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (TimeRangeStaticTimeRange)) {
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

		static IntPtr id_isStatic;
		public unsafe bool IsStatic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='TimeRange.StaticTimeRange']/method[@name='isStatic' and count(parameter)=0]"
			[Register ("isStatic", "()Z", "GetIsStaticHandler")]
			get {
				if (id_isStatic == IntPtr.Zero)
					id_isStatic = JNIEnv.GetMethodID (class_ref, "isStatic", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStatic);
				} finally {
				}
			}
		}

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='TimeRange.StaticTimeRange']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
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

		static IntPtr id_getCurrentBoundsMs_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='TimeRange.StaticTimeRange']/method[@name='getCurrentBoundsMs' and count(parameter)=1 and parameter[1][@type='long[]']]"
		[Register ("getCurrentBoundsMs", "([J)[J", "")]
		public unsafe long[] GetCurrentBoundsMs (long[] p0)
		{
			if (id_getCurrentBoundsMs_arrayJ == IntPtr.Zero)
				id_getCurrentBoundsMs_arrayJ = JNIEnv.GetMethodID (class_ref, "getCurrentBoundsMs", "([J)[J");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentBoundsMs_arrayJ, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getCurrentBoundsUs_arrayJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='TimeRange.StaticTimeRange']/method[@name='getCurrentBoundsUs' and count(parameter)=1 and parameter[1][@type='long[]']]"
		[Register ("getCurrentBoundsUs", "([J)[J", "")]
		public unsafe long[] GetCurrentBoundsUs (long[] p0)
		{
			if (id_getCurrentBoundsUs_arrayJ == IntPtr.Zero)
				id_getCurrentBoundsUs_arrayJ = JNIEnv.GetMethodID (class_ref, "getCurrentBoundsUs", "([J)[J");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentBoundsUs_arrayJ, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_hashCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='TimeRange.StaticTimeRange']/method[@name='hashCode' and count(parameter)=0]"
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

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer']/interface[@name='TimeRange']"
	[Register ("com/google/android/exoplayer/TimeRange", "", "Com.Google.Android.Exoplayer.ITimeRangeInvoker")]
	public partial interface ITimeRange : IJavaObject {

		bool IsStatic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/interface[@name='TimeRange']/method[@name='isStatic' and count(parameter)=0]"
			[Register ("isStatic", "()Z", "GetIsStaticHandler:Com.Google.Android.Exoplayer.ITimeRangeInvoker, JWBinding_AND")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/interface[@name='TimeRange']/method[@name='getCurrentBoundsMs' and count(parameter)=1 and parameter[1][@type='long[]']]"
		[Register ("getCurrentBoundsMs", "([J)[J", "GetGetCurrentBoundsMs_arrayJHandler:Com.Google.Android.Exoplayer.ITimeRangeInvoker, JWBinding_AND")]
		long[] GetCurrentBoundsMs (long[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/interface[@name='TimeRange']/method[@name='getCurrentBoundsUs' and count(parameter)=1 and parameter[1][@type='long[]']]"
		[Register ("getCurrentBoundsUs", "([J)[J", "GetGetCurrentBoundsUs_arrayJHandler:Com.Google.Android.Exoplayer.ITimeRangeInvoker, JWBinding_AND")]
		long[] GetCurrentBoundsUs (long[] p0);

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/TimeRange", DoNotGenerateAcw=true)]
	internal class ITimeRangeInvoker : global::Java.Lang.Object, ITimeRange {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/TimeRange");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITimeRangeInvoker); }
		}

		IntPtr class_ref;

		public static ITimeRange GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITimeRange> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.TimeRange"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITimeRangeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isStatic;
#pragma warning disable 0169
		static Delegate GetIsStaticHandler ()
		{
			if (cb_isStatic == null)
				cb_isStatic = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStatic);
			return cb_isStatic;
		}

		static bool n_IsStatic (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.ITimeRange __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.ITimeRange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStatic;
		}
#pragma warning restore 0169

		IntPtr id_isStatic;
		public unsafe bool IsStatic {
			get {
				if (id_isStatic == IntPtr.Zero)
					id_isStatic = JNIEnv.GetMethodID (class_ref, "isStatic", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStatic);
			}
		}

		static Delegate cb_getCurrentBoundsMs_arrayJ;
#pragma warning disable 0169
		static Delegate GetGetCurrentBoundsMs_arrayJHandler ()
		{
			if (cb_getCurrentBoundsMs_arrayJ == null)
				cb_getCurrentBoundsMs_arrayJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCurrentBoundsMs_arrayJ);
			return cb_getCurrentBoundsMs_arrayJ;
		}

		static IntPtr n_GetCurrentBoundsMs_arrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Exoplayer.ITimeRange __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.ITimeRange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			long[] p0 = (long[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (long));
			IntPtr __ret = JNIEnv.NewArray (__this.GetCurrentBoundsMs (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentBoundsMs_arrayJ;
		public unsafe long[] GetCurrentBoundsMs (long[] p0)
		{
			if (id_getCurrentBoundsMs_arrayJ == IntPtr.Zero)
				id_getCurrentBoundsMs_arrayJ = JNIEnv.GetMethodID (class_ref, "getCurrentBoundsMs", "([J)[J");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentBoundsMs_arrayJ, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_getCurrentBoundsUs_arrayJ;
#pragma warning disable 0169
		static Delegate GetGetCurrentBoundsUs_arrayJHandler ()
		{
			if (cb_getCurrentBoundsUs_arrayJ == null)
				cb_getCurrentBoundsUs_arrayJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCurrentBoundsUs_arrayJ);
			return cb_getCurrentBoundsUs_arrayJ;
		}

		static IntPtr n_GetCurrentBoundsUs_arrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Exoplayer.ITimeRange __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.ITimeRange> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			long[] p0 = (long[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (long));
			IntPtr __ret = JNIEnv.NewArray (__this.GetCurrentBoundsUs (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentBoundsUs_arrayJ;
		public unsafe long[] GetCurrentBoundsUs (long[] p0)
		{
			if (id_getCurrentBoundsUs_arrayJ == IntPtr.Zero)
				id_getCurrentBoundsUs_arrayJ = JNIEnv.GetMethodID (class_ref, "getCurrentBoundsUs", "([J)[J");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			long[] __ret = (long[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentBoundsUs_arrayJ, __args), JniHandleOwnership.TransferLocalRef, typeof (long));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

	}

}
