using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Dash.Mpd {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='Period']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/dash/mpd/Period", DoNotGenerateAcw=true)]
	public partial class Period : global::Java.Lang.Object {


		static IntPtr adaptationSets_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='Period']/field[@name='adaptationSets']"
		[Register ("adaptationSets")]
		public global::System.Collections.IList AdaptationSets {
			get {
				if (adaptationSets_jfieldId == IntPtr.Zero)
					adaptationSets_jfieldId = JNIEnv.GetFieldID (class_ref, "adaptationSets", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, adaptationSets_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (adaptationSets_jfieldId == IntPtr.Zero)
					adaptationSets_jfieldId = JNIEnv.GetFieldID (class_ref, "adaptationSets", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, adaptationSets_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='Period']/field[@name='id']"
		[Register ("id")]
		public string Id {
			get {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, id_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, id_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr startMs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='Period']/field[@name='startMs']"
		[Register ("startMs")]
		public long StartMs {
			get {
				if (startMs_jfieldId == IntPtr.Zero)
					startMs_jfieldId = JNIEnv.GetFieldID (class_ref, "startMs", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, startMs_jfieldId);
			}
			set {
				if (startMs_jfieldId == IntPtr.Zero)
					startMs_jfieldId = JNIEnv.GetFieldID (class_ref, "startMs", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, startMs_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/dash/mpd/Period", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Period); }
		}

		protected Period (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_JLjava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='Period']/constructor[@name='Period' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='java.util.List&lt;com.google.android.exoplayer.dash.mpd.AdaptationSet&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;JLjava/util/List;)V", "")]
		public unsafe Period (string p0, long p1, global::System.Collections.Generic.IList<global::Com.Google.Android.Exoplayer.Dash.Mpd.AdaptationSet> p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Google.Android.Exoplayer.Dash.Mpd.AdaptationSet>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (Period)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;JLjava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;JLjava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_JLjava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_JLjava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;JLjava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_JLjava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_JLjava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getAdaptationSetIndex_I;
#pragma warning disable 0169
		static Delegate GetGetAdaptationSetIndex_IHandler ()
		{
			if (cb_getAdaptationSetIndex_I == null)
				cb_getAdaptationSetIndex_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetAdaptationSetIndex_I);
			return cb_getAdaptationSetIndex_I;
		}

		static int n_GetAdaptationSetIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Android.Exoplayer.Dash.Mpd.Period __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Dash.Mpd.Period> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetAdaptationSetIndex (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getAdaptationSetIndex_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='Period']/method[@name='getAdaptationSetIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getAdaptationSetIndex", "(I)I", "GetGetAdaptationSetIndex_IHandler")]
		public virtual unsafe int GetAdaptationSetIndex (int p0)
		{
			if (id_getAdaptationSetIndex_I == IntPtr.Zero)
				id_getAdaptationSetIndex_I = JNIEnv.GetMethodID (class_ref, "getAdaptationSetIndex", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAdaptationSetIndex_I, __args);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdaptationSetIndex", "(I)I"), __args);
			} finally {
			}
		}

	}
}
