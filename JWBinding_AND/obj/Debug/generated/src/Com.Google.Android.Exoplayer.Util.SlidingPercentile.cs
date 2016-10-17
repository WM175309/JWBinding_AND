using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='SlidingPercentile']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/util/SlidingPercentile", DoNotGenerateAcw=true)]
	public sealed partial class SlidingPercentile : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='SlidingPercentile.Sample']"
		[global::Android.Runtime.Register ("com/google/android/exoplayer/util/SlidingPercentile$Sample", DoNotGenerateAcw=true)]
		public partial class Sample : global::Java.Lang.Object {


			static IntPtr index_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='SlidingPercentile.Sample']/field[@name='index']"
			[Register ("index")]
			public int Index {
				get {
					if (index_jfieldId == IntPtr.Zero)
						index_jfieldId = JNIEnv.GetFieldID (class_ref, "index", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, index_jfieldId);
				}
				set {
					if (index_jfieldId == IntPtr.Zero)
						index_jfieldId = JNIEnv.GetFieldID (class_ref, "index", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, index_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr value_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='SlidingPercentile.Sample']/field[@name='value']"
			[Register ("value")]
			public float Value {
				get {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "F");
					return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, value_jfieldId);
				}
				set {
					if (value_jfieldId == IntPtr.Zero)
						value_jfieldId = JNIEnv.GetFieldID (class_ref, "value", "F");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, value_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr weight_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='SlidingPercentile.Sample']/field[@name='weight']"
			[Register ("weight")]
			public int Weight {
				get {
					if (weight_jfieldId == IntPtr.Zero)
						weight_jfieldId = JNIEnv.GetFieldID (class_ref, "weight", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, weight_jfieldId);
				}
				set {
					if (weight_jfieldId == IntPtr.Zero)
						weight_jfieldId = JNIEnv.GetFieldID (class_ref, "weight", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, weight_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/exoplayer/util/SlidingPercentile$Sample", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Sample); }
			}

			protected Sample (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/util/SlidingPercentile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SlidingPercentile); }
		}

		internal SlidingPercentile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='SlidingPercentile']/constructor[@name='SlidingPercentile' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe SlidingPercentile (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SlidingPercentile)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static IntPtr id_addSample_IF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='SlidingPercentile']/method[@name='addSample' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("addSample", "(IF)V", "")]
		public unsafe void AddSample (int p0, float p1)
		{
			if (id_addSample_IF == IntPtr.Zero)
				id_addSample_IF = JNIEnv.GetMethodID (class_ref, "addSample", "(IF)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addSample_IF, __args);
			} finally {
			}
		}

		static IntPtr id_getPercentile_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='SlidingPercentile']/method[@name='getPercentile' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getPercentile", "(F)F", "")]
		public unsafe float GetPercentile (float p0)
		{
			if (id_getPercentile_F == IntPtr.Zero)
				id_getPercentile_F = JNIEnv.GetMethodID (class_ref, "getPercentile", "(F)F");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getPercentile_F, __args);
			} finally {
			}
		}

	}
}
