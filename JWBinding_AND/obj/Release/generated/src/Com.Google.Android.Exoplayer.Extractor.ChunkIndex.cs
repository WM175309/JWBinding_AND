using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='ChunkIndex']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/extractor/ChunkIndex", DoNotGenerateAcw=true)]
	public sealed partial class ChunkIndex : global::Java.Lang.Object, global::Com.Google.Android.Exoplayer.Extractor.ISeekMap {


		static IntPtr durationsUs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='ChunkIndex']/field[@name='durationsUs']"
		[Register ("durationsUs")]
		public IList<long> DurationsUs {
			get {
				if (durationsUs_jfieldId == IntPtr.Zero)
					durationsUs_jfieldId = JNIEnv.GetFieldID (class_ref, "durationsUs", "[J");
				return global::Android.Runtime.JavaArray<long>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, durationsUs_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (durationsUs_jfieldId == IntPtr.Zero)
					durationsUs_jfieldId = JNIEnv.GetFieldID (class_ref, "durationsUs", "[J");
				IntPtr native_value = global::Android.Runtime.JavaArray<long>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, durationsUs_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr length_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='ChunkIndex']/field[@name='length']"
		[Register ("length")]
		public int Length {
			get {
				if (length_jfieldId == IntPtr.Zero)
					length_jfieldId = JNIEnv.GetFieldID (class_ref, "length", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, length_jfieldId);
			}
			set {
				if (length_jfieldId == IntPtr.Zero)
					length_jfieldId = JNIEnv.GetFieldID (class_ref, "length", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, length_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr offsets_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='ChunkIndex']/field[@name='offsets']"
		[Register ("offsets")]
		public IList<long> Offsets {
			get {
				if (offsets_jfieldId == IntPtr.Zero)
					offsets_jfieldId = JNIEnv.GetFieldID (class_ref, "offsets", "[J");
				return global::Android.Runtime.JavaArray<long>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, offsets_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (offsets_jfieldId == IntPtr.Zero)
					offsets_jfieldId = JNIEnv.GetFieldID (class_ref, "offsets", "[J");
				IntPtr native_value = global::Android.Runtime.JavaArray<long>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, offsets_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sizes_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='ChunkIndex']/field[@name='sizes']"
		[Register ("sizes")]
		public IList<int> Sizes {
			get {
				if (sizes_jfieldId == IntPtr.Zero)
					sizes_jfieldId = JNIEnv.GetFieldID (class_ref, "sizes", "[I");
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, sizes_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sizes_jfieldId == IntPtr.Zero)
					sizes_jfieldId = JNIEnv.GetFieldID (class_ref, "sizes", "[I");
				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sizes_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr timesUs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='ChunkIndex']/field[@name='timesUs']"
		[Register ("timesUs")]
		public IList<long> TimesUs {
			get {
				if (timesUs_jfieldId == IntPtr.Zero)
					timesUs_jfieldId = JNIEnv.GetFieldID (class_ref, "timesUs", "[J");
				return global::Android.Runtime.JavaArray<long>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, timesUs_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (timesUs_jfieldId == IntPtr.Zero)
					timesUs_jfieldId = JNIEnv.GetFieldID (class_ref, "timesUs", "[J");
				IntPtr native_value = global::Android.Runtime.JavaArray<long>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, timesUs_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

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
				return JNIEnv.FindClass ("com/google/android/exoplayer/extractor/ChunkIndex", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChunkIndex); }
		}

		internal ChunkIndex (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayIarrayJarrayJarrayJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='ChunkIndex']/constructor[@name='ChunkIndex' and count(parameter)=4 and parameter[1][@type='int[]'] and parameter[2][@type='long[]'] and parameter[3][@type='long[]'] and parameter[4][@type='long[]']]"
		[Register (".ctor", "([I[J[J[J)V", "")]
		public unsafe ChunkIndex (int[] p0, long[] p1, long[] p2, long[] p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				if (GetType () != typeof (ChunkIndex)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([I[J[J[J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([I[J[J[J)V", __args);
					return;
				}

				if (id_ctor_arrayIarrayJarrayJarrayJ == IntPtr.Zero)
					id_ctor_arrayIarrayJarrayJarrayJ = JNIEnv.GetMethodID (class_ref, "<init>", "([I[J[J[J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayIarrayJarrayJarrayJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayIarrayJarrayJarrayJ, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_isSeekable;
		public unsafe bool IsSeekable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='ChunkIndex']/method[@name='isSeekable' and count(parameter)=0]"
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

		static IntPtr id_getChunkIndex_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='ChunkIndex']/method[@name='getChunkIndex' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getChunkIndex", "(J)I", "")]
		public unsafe int GetChunkIndex (long p0)
		{
			if (id_getChunkIndex_J == IntPtr.Zero)
				id_getChunkIndex_J = JNIEnv.GetMethodID (class_ref, "getChunkIndex", "(J)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getChunkIndex_J, __args);
			} finally {
			}
		}

		static IntPtr id_getPosition_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='ChunkIndex']/method[@name='getPosition' and count(parameter)=1 and parameter[1][@type='long']]"
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
}
