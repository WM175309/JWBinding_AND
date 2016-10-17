using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Dash.Mpd {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='AdaptationSet']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/dash/mpd/AdaptationSet", DoNotGenerateAcw=true)]
	public partial class AdaptationSet : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='AdaptationSet']/field[@name='TYPE_AUDIO']"
		[Register ("TYPE_AUDIO")]
		public const int TypeAudio = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='AdaptationSet']/field[@name='TYPE_TEXT']"
		[Register ("TYPE_TEXT")]
		public const int TypeText = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='AdaptationSet']/field[@name='TYPE_UNKNOWN']"
		[Register ("TYPE_UNKNOWN")]
		public const int TypeUnknown = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='AdaptationSet']/field[@name='TYPE_VIDEO']"
		[Register ("TYPE_VIDEO")]
		public const int TypeVideo = (int) 0;

		static IntPtr contentProtections_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='AdaptationSet']/field[@name='contentProtections']"
		[Register ("contentProtections")]
		public global::System.Collections.IList ContentProtections {
			get {
				if (contentProtections_jfieldId == IntPtr.Zero)
					contentProtections_jfieldId = JNIEnv.GetFieldID (class_ref, "contentProtections", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, contentProtections_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (contentProtections_jfieldId == IntPtr.Zero)
					contentProtections_jfieldId = JNIEnv.GetFieldID (class_ref, "contentProtections", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, contentProtections_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='AdaptationSet']/field[@name='id']"
		[Register ("id")]
		public int Id {
			get {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, id_jfieldId);
			}
			set {
				if (id_jfieldId == IntPtr.Zero)
					id_jfieldId = JNIEnv.GetFieldID (class_ref, "id", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, id_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr representations_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='AdaptationSet']/field[@name='representations']"
		[Register ("representations")]
		public global::System.Collections.IList Representations {
			get {
				if (representations_jfieldId == IntPtr.Zero)
					representations_jfieldId = JNIEnv.GetFieldID (class_ref, "representations", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, representations_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (representations_jfieldId == IntPtr.Zero)
					representations_jfieldId = JNIEnv.GetFieldID (class_ref, "representations", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, representations_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr type_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='AdaptationSet']/field[@name='type']"
		[Register ("type")]
		public int Type {
			get {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, type_jfieldId);
			}
			set {
				if (type_jfieldId == IntPtr.Zero)
					type_jfieldId = JNIEnv.GetFieldID (class_ref, "type", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, type_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/dash/mpd/AdaptationSet", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdaptationSet); }
		}

		protected AdaptationSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_IILjava_util_List_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='AdaptationSet']/constructor[@name='AdaptationSet' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;com.google.android.exoplayer.dash.mpd.Representation&gt;'] and parameter[4][@type='java.util.List&lt;com.google.android.exoplayer.dash.mpd.ContentProtection&gt;']]"
		[Register (".ctor", "(IILjava/util/List;Ljava/util/List;)V", "")]
		public unsafe AdaptationSet (int p0, int p1, global::System.Collections.Generic.IList<global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation> p2, global::System.Collections.Generic.IList<global::Com.Google.Android.Exoplayer.Dash.Mpd.ContentProtection> p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation>.ToLocalJniHandle (p2);
			IntPtr native_p3 = global::Android.Runtime.JavaList<global::Com.Google.Android.Exoplayer.Dash.Mpd.ContentProtection>.ToLocalJniHandle (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				if (GetType () != typeof (AdaptationSet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IILjava/util/List;Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IILjava/util/List;Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_IILjava_util_List_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_IILjava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IILjava/util/List;Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILjava_util_List_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IILjava_util_List_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_ctor_IILjava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='AdaptationSet']/constructor[@name='AdaptationSet' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.util.List&lt;com.google.android.exoplayer.dash.mpd.Representation&gt;']]"
		[Register (".ctor", "(IILjava/util/List;)V", "")]
		public unsafe AdaptationSet (int p0, int p1, global::System.Collections.Generic.IList<global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation> p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Com.Google.Android.Exoplayer.Dash.Mpd.Representation>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (GetType () != typeof (AdaptationSet)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IILjava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IILjava/util/List;)V", __args);
					return;
				}

				if (id_ctor_IILjava_util_List_ == IntPtr.Zero)
					id_ctor_IILjava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(IILjava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IILjava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IILjava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_hasContentProtection;
#pragma warning disable 0169
		static Delegate GetHasContentProtectionHandler ()
		{
			if (cb_hasContentProtection == null)
				cb_hasContentProtection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasContentProtection);
			return cb_hasContentProtection;
		}

		static bool n_HasContentProtection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Dash.Mpd.AdaptationSet __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Dash.Mpd.AdaptationSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasContentProtection;
		}
#pragma warning restore 0169

		static IntPtr id_hasContentProtection;
		public virtual unsafe bool HasContentProtection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.dash.mpd']/class[@name='AdaptationSet']/method[@name='hasContentProtection' and count(parameter)=0]"
			[Register ("hasContentProtection", "()Z", "GetHasContentProtectionHandler")]
			get {
				if (id_hasContentProtection == IntPtr.Zero)
					id_hasContentProtection = JNIEnv.GetMethodID (class_ref, "hasContentProtection", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasContentProtection);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasContentProtection", "()Z"));
				} finally {
				}
			}
		}

	}
}
