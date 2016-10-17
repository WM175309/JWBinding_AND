using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableBitArray']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/util/ParsableBitArray", DoNotGenerateAcw=true)]
	public sealed partial class ParsableBitArray : global::Java.Lang.Object {


		static IntPtr data_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableBitArray']/field[@name='data']"
		[Register ("data")]
		public IList<byte> Data {
			get {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, data_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, data_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/util/ParsableBitArray", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParsableBitArray); }
		}

		internal ParsableBitArray (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayBI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableBitArray']/constructor[@name='ParsableBitArray' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register (".ctor", "([BI)V", "")]
		public unsafe ParsableBitArray (byte[] p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ParsableBitArray)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([BI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([BI)V", __args);
					return;
				}

				if (id_ctor_arrayBI == IntPtr.Zero)
					id_ctor_arrayBI = JNIEnv.GetMethodID (class_ref, "<init>", "([BI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayBI, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableBitArray']/constructor[@name='ParsableBitArray' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe ParsableBitArray (byte[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (ParsableBitArray)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([B)V", __args);
					return;
				}

				if (id_ctor_arrayB == IntPtr.Zero)
					id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayB, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableBitArray']/constructor[@name='ParsableBitArray' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ParsableBitArray ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ParsableBitArray)) {
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

		static IntPtr id_getPosition;
		static IntPtr id_setPosition_I;
		public unsafe int Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableBitArray']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()I", "GetGetPositionHandler")]
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPosition);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableBitArray']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPosition", "(I)V", "GetSetPosition_IHandler")]
			set {
				if (id_setPosition_I == IntPtr.Zero)
					id_setPosition_I = JNIEnv.GetMethodID (class_ref, "setPosition", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPosition_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_bitsLeft;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableBitArray']/method[@name='bitsLeft' and count(parameter)=0]"
		[Register ("bitsLeft", "()I", "")]
		public unsafe int BitsLeft ()
		{
			if (id_bitsLeft == IntPtr.Zero)
				id_bitsLeft = JNIEnv.GetMethodID (class_ref, "bitsLeft", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_bitsLeft);
			} finally {
			}
		}

		static IntPtr id_canReadExpGolombCodedNum;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableBitArray']/method[@name='canReadExpGolombCodedNum' and count(parameter)=0]"
		[Register ("canReadExpGolombCodedNum", "()Z", "")]
		public unsafe bool CanReadExpGolombCodedNum ()
		{
			if (id_canReadExpGolombCodedNum == IntPtr.Zero)
				id_canReadExpGolombCodedNum = JNIEnv.GetMethodID (class_ref, "canReadExpGolombCodedNum", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canReadExpGolombCodedNum);
			} finally {
			}
		}

		static IntPtr id_readBit;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableBitArray']/method[@name='readBit' and count(parameter)=0]"
		[Register ("readBit", "()Z", "")]
		public unsafe bool ReadBit ()
		{
			if (id_readBit == IntPtr.Zero)
				id_readBit = JNIEnv.GetMethodID (class_ref, "readBit", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_readBit);
			} finally {
			}
		}

		static IntPtr id_readBits_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableBitArray']/method[@name='readBits' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("readBits", "(I)I", "")]
		public unsafe int ReadBits (int p0)
		{
			if (id_readBits_I == IntPtr.Zero)
				id_readBits_I = JNIEnv.GetMethodID (class_ref, "readBits", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readBits_I, __args);
			} finally {
			}
		}

		static IntPtr id_readSignedExpGolombCodedInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableBitArray']/method[@name='readSignedExpGolombCodedInt' and count(parameter)=0]"
		[Register ("readSignedExpGolombCodedInt", "()I", "")]
		public unsafe int ReadSignedExpGolombCodedInt ()
		{
			if (id_readSignedExpGolombCodedInt == IntPtr.Zero)
				id_readSignedExpGolombCodedInt = JNIEnv.GetMethodID (class_ref, "readSignedExpGolombCodedInt", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readSignedExpGolombCodedInt);
			} finally {
			}
		}

		static IntPtr id_readUnsignedExpGolombCodedInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableBitArray']/method[@name='readUnsignedExpGolombCodedInt' and count(parameter)=0]"
		[Register ("readUnsignedExpGolombCodedInt", "()I", "")]
		public unsafe int ReadUnsignedExpGolombCodedInt ()
		{
			if (id_readUnsignedExpGolombCodedInt == IntPtr.Zero)
				id_readUnsignedExpGolombCodedInt = JNIEnv.GetMethodID (class_ref, "readUnsignedExpGolombCodedInt", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readUnsignedExpGolombCodedInt);
			} finally {
			}
		}

		static IntPtr id_reset_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableBitArray']/method[@name='reset' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("reset", "([B)V", "")]
		public unsafe void Reset (byte[] p0)
		{
			if (id_reset_arrayB == IntPtr.Zero)
				id_reset_arrayB = JNIEnv.GetMethodID (class_ref, "reset", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset_arrayB, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_reset_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableBitArray']/method[@name='reset' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("reset", "([BI)V", "")]
		public unsafe void Reset (byte[] p0, int p1)
		{
			if (id_reset_arrayBI == IntPtr.Zero)
				id_reset_arrayBI = JNIEnv.GetMethodID (class_ref, "reset", "([BI)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset_arrayBI, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_skipBits_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableBitArray']/method[@name='skipBits' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skipBits", "(I)V", "")]
		public unsafe void SkipBits (int p0)
		{
			if (id_skipBits_I == IntPtr.Zero)
				id_skipBits_I = JNIEnv.GetMethodID (class_ref, "skipBits", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_skipBits_I, __args);
			} finally {
			}
		}

	}
}
