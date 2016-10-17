using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Extractor {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultExtractorInput']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/extractor/DefaultExtractorInput", DoNotGenerateAcw=true)]
	public sealed partial class DefaultExtractorInput : global::Java.Lang.Object, global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/extractor/DefaultExtractorInput", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DefaultExtractorInput); }
		}

		internal DefaultExtractorInput (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getLength;
		public unsafe long Length {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultExtractorInput']/method[@name='getLength' and count(parameter)=0]"
			[Register ("getLength", "()J", "GetGetLengthHandler")]
			get {
				if (id_getLength == IntPtr.Zero)
					id_getLength = JNIEnv.GetMethodID (class_ref, "getLength", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLength);
				} finally {
				}
			}
		}

		static IntPtr id_getPeekPosition;
		public unsafe long PeekPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultExtractorInput']/method[@name='getPeekPosition' and count(parameter)=0]"
			[Register ("getPeekPosition", "()J", "GetGetPeekPositionHandler")]
			get {
				if (id_getPeekPosition == IntPtr.Zero)
					id_getPeekPosition = JNIEnv.GetMethodID (class_ref, "getPeekPosition", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPeekPosition);
				} finally {
				}
			}
		}

		static IntPtr id_getPosition;
		public unsafe long Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultExtractorInput']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()J", "GetGetPositionHandler")]
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()J");
				try {
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPosition);
				} finally {
				}
			}
		}

		static IntPtr id_advancePeekPosition_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultExtractorInput']/method[@name='advancePeekPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("advancePeekPosition", "(I)V", "")]
		public unsafe void AdvancePeekPosition (int p0)
		{
			if (id_advancePeekPosition_I == IntPtr.Zero)
				id_advancePeekPosition_I = JNIEnv.GetMethodID (class_ref, "advancePeekPosition", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_advancePeekPosition_I, __args);
			} finally {
			}
		}

		static IntPtr id_advancePeekPosition_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultExtractorInput']/method[@name='advancePeekPosition' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("advancePeekPosition", "(IZ)Z", "")]
		public unsafe bool AdvancePeekPosition (int p0, bool p1)
		{
			if (id_advancePeekPosition_IZ == IntPtr.Zero)
				id_advancePeekPosition_IZ = JNIEnv.GetMethodID (class_ref, "advancePeekPosition", "(IZ)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_advancePeekPosition_IZ, __args);
			} finally {
			}
		}

		static IntPtr id_peekFully_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultExtractorInput']/method[@name='peekFully' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("peekFully", "([BII)V", "")]
		public unsafe void PeekFully (byte[] p0, int p1, int p2)
		{
			if (id_peekFully_arrayBII == IntPtr.Zero)
				id_peekFully_arrayBII = JNIEnv.GetMethodID (class_ref, "peekFully", "([BII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_peekFully_arrayBII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_peekFully_arrayBIIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultExtractorInput']/method[@name='peekFully' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("peekFully", "([BIIZ)Z", "")]
		public unsafe bool PeekFully (byte[] p0, int p1, int p2, bool p3)
		{
			if (id_peekFully_arrayBIIZ == IntPtr.Zero)
				id_peekFully_arrayBIIZ = JNIEnv.GetMethodID (class_ref, "peekFully", "([BIIZ)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_peekFully_arrayBIIZ, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_read_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultExtractorInput']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("read", "([BII)I", "")]
		public unsafe int Read (byte[] p0, int p1, int p2)
		{
			if (id_read_arrayBII == IntPtr.Zero)
				id_read_arrayBII = JNIEnv.GetMethodID (class_ref, "read", "([BII)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_arrayBII, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_readFully_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultExtractorInput']/method[@name='readFully' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("readFully", "([BII)V", "")]
		public unsafe void ReadFully (byte[] p0, int p1, int p2)
		{
			if (id_readFully_arrayBII == IntPtr.Zero)
				id_readFully_arrayBII = JNIEnv.GetMethodID (class_ref, "readFully", "([BII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readFully_arrayBII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_readFully_arrayBIIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultExtractorInput']/method[@name='readFully' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("readFully", "([BIIZ)Z", "")]
		public unsafe bool ReadFully (byte[] p0, int p1, int p2, bool p3)
		{
			if (id_readFully_arrayBIIZ == IntPtr.Zero)
				id_readFully_arrayBIIZ = JNIEnv.GetMethodID (class_ref, "readFully", "([BIIZ)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_readFully_arrayBIIZ, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_resetPeekPosition;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultExtractorInput']/method[@name='resetPeekPosition' and count(parameter)=0]"
		[Register ("resetPeekPosition", "()V", "")]
		public unsafe void ResetPeekPosition ()
		{
			if (id_resetPeekPosition == IntPtr.Zero)
				id_resetPeekPosition = JNIEnv.GetMethodID (class_ref, "resetPeekPosition", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetPeekPosition);
			} finally {
			}
		}

		static IntPtr id_skip_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultExtractorInput']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skip", "(I)I", "")]
		public unsafe int Skip (int p0)
		{
			if (id_skip_I == IntPtr.Zero)
				id_skip_I = JNIEnv.GetMethodID (class_ref, "skip", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_skip_I, __args);
			} finally {
			}
		}

		static IntPtr id_skipFully_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultExtractorInput']/method[@name='skipFully' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skipFully", "(I)V", "")]
		public unsafe void SkipFully (int p0)
		{
			if (id_skipFully_I == IntPtr.Zero)
				id_skipFully_I = JNIEnv.GetMethodID (class_ref, "skipFully", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_skipFully_I, __args);
			} finally {
			}
		}

		static IntPtr id_skipFully_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/class[@name='DefaultExtractorInput']/method[@name='skipFully' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("skipFully", "(IZ)Z", "")]
		public unsafe bool SkipFully (int p0, bool p1)
		{
			if (id_skipFully_IZ == IntPtr.Zero)
				id_skipFully_IZ = JNIEnv.GetMethodID (class_ref, "skipFully", "(IZ)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_skipFully_IZ, __args);
			} finally {
			}
		}

	}
}
