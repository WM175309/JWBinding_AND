using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/util/ParsableByteArray", DoNotGenerateAcw=true)]
	public sealed partial class ParsableByteArray : global::Java.Lang.Object {


		static IntPtr data_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/field[@name='data']"
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
				return JNIEnv.FindClass ("com/google/android/exoplayer/util/ParsableByteArray", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ParsableByteArray); }
		}

		internal ParsableByteArray (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayBI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/constructor[@name='ParsableByteArray' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register (".ctor", "([BI)V", "")]
		public unsafe ParsableByteArray (byte[] p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (ParsableByteArray)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/constructor[@name='ParsableByteArray' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe ParsableByteArray (byte[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (ParsableByteArray)) {
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

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/constructor[@name='ParsableByteArray' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe ParsableByteArray (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ParsableByteArray)) {
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

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/constructor[@name='ParsableByteArray' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ParsableByteArray ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (ParsableByteArray)) {
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()I", "GetGetPositionHandler")]
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPosition);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static IntPtr id_bytesLeft;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='bytesLeft' and count(parameter)=0]"
		[Register ("bytesLeft", "()I", "")]
		public unsafe int BytesLeft ()
		{
			if (id_bytesLeft == IntPtr.Zero)
				id_bytesLeft = JNIEnv.GetMethodID (class_ref, "bytesLeft", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_bytesLeft);
			} finally {
			}
		}

		static IntPtr id_capacity;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='capacity' and count(parameter)=0]"
		[Register ("capacity", "()I", "")]
		public unsafe int Capacity ()
		{
			if (id_capacity == IntPtr.Zero)
				id_capacity = JNIEnv.GetMethodID (class_ref, "capacity", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_capacity);
			} finally {
			}
		}

		static IntPtr id_limit;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='limit' and count(parameter)=0]"
		[Register ("limit", "()I", "")]
		public unsafe int Limit ()
		{
			if (id_limit == IntPtr.Zero)
				id_limit = JNIEnv.GetMethodID (class_ref, "limit", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_limit);
			} finally {
			}
		}

		static IntPtr id_readBytes_arrayBII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readBytes' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("readBytes", "([BII)V", "")]
		public unsafe void ReadBytes (byte[] p0, int p1, int p2)
		{
			if (id_readBytes_arrayBII == IntPtr.Zero)
				id_readBytes_arrayBII = JNIEnv.GetMethodID (class_ref, "readBytes", "([BII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readBytes_arrayBII, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_readBytes_Lcom_google_android_exoplayer_util_ParsableBitArray_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readBytes' and count(parameter)=2 and parameter[1][@type='com.google.android.exoplayer.util.ParsableBitArray'] and parameter[2][@type='int']]"
		[Register ("readBytes", "(Lcom/google/android/exoplayer/util/ParsableBitArray;I)V", "")]
		public unsafe void ReadBytes (global::Com.Google.Android.Exoplayer.Util.ParsableBitArray p0, int p1)
		{
			if (id_readBytes_Lcom_google_android_exoplayer_util_ParsableBitArray_I == IntPtr.Zero)
				id_readBytes_Lcom_google_android_exoplayer_util_ParsableBitArray_I = JNIEnv.GetMethodID (class_ref, "readBytes", "(Lcom/google/android/exoplayer/util/ParsableBitArray;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readBytes_Lcom_google_android_exoplayer_util_ParsableBitArray_I, __args);
			} finally {
			}
		}

		static IntPtr id_readBytes_Ljava_nio_ByteBuffer_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readBytes' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int']]"
		[Register ("readBytes", "(Ljava/nio/ByteBuffer;I)V", "")]
		public unsafe void ReadBytes (global::Java.Nio.ByteBuffer p0, int p1)
		{
			if (id_readBytes_Ljava_nio_ByteBuffer_I == IntPtr.Zero)
				id_readBytes_Ljava_nio_ByteBuffer_I = JNIEnv.GetMethodID (class_ref, "readBytes", "(Ljava/nio/ByteBuffer;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readBytes_Ljava_nio_ByteBuffer_I, __args);
			} finally {
			}
		}

		static IntPtr id_readInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readInt' and count(parameter)=0]"
		[Register ("readInt", "()I", "")]
		public unsafe int ReadInt ()
		{
			if (id_readInt == IntPtr.Zero)
				id_readInt = JNIEnv.GetMethodID (class_ref, "readInt", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readInt);
			} finally {
			}
		}

		static IntPtr id_readLine;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readLine' and count(parameter)=0]"
		[Register ("readLine", "()Ljava/lang/String;", "")]
		public unsafe string ReadLine ()
		{
			if (id_readLine == IntPtr.Zero)
				id_readLine = JNIEnv.GetMethodID (class_ref, "readLine", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readLine), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_readLittleEndianInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readLittleEndianInt' and count(parameter)=0]"
		[Register ("readLittleEndianInt", "()I", "")]
		public unsafe int ReadLittleEndianInt ()
		{
			if (id_readLittleEndianInt == IntPtr.Zero)
				id_readLittleEndianInt = JNIEnv.GetMethodID (class_ref, "readLittleEndianInt", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readLittleEndianInt);
			} finally {
			}
		}

		static IntPtr id_readLittleEndianInt24;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readLittleEndianInt24' and count(parameter)=0]"
		[Register ("readLittleEndianInt24", "()I", "")]
		public unsafe int ReadLittleEndianInt24 ()
		{
			if (id_readLittleEndianInt24 == IntPtr.Zero)
				id_readLittleEndianInt24 = JNIEnv.GetMethodID (class_ref, "readLittleEndianInt24", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readLittleEndianInt24);
			} finally {
			}
		}

		static IntPtr id_readLittleEndianLong;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readLittleEndianLong' and count(parameter)=0]"
		[Register ("readLittleEndianLong", "()J", "")]
		public unsafe long ReadLittleEndianLong ()
		{
			if (id_readLittleEndianLong == IntPtr.Zero)
				id_readLittleEndianLong = JNIEnv.GetMethodID (class_ref, "readLittleEndianLong", "()J");
			try {
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_readLittleEndianLong);
			} finally {
			}
		}

		static IntPtr id_readLittleEndianShort;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readLittleEndianShort' and count(parameter)=0]"
		[Register ("readLittleEndianShort", "()S", "")]
		public unsafe short ReadLittleEndianShort ()
		{
			if (id_readLittleEndianShort == IntPtr.Zero)
				id_readLittleEndianShort = JNIEnv.GetMethodID (class_ref, "readLittleEndianShort", "()S");
			try {
				return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_readLittleEndianShort);
			} finally {
			}
		}

		static IntPtr id_readLittleEndianUnsignedInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readLittleEndianUnsignedInt' and count(parameter)=0]"
		[Register ("readLittleEndianUnsignedInt", "()J", "")]
		public unsafe long ReadLittleEndianUnsignedInt ()
		{
			if (id_readLittleEndianUnsignedInt == IntPtr.Zero)
				id_readLittleEndianUnsignedInt = JNIEnv.GetMethodID (class_ref, "readLittleEndianUnsignedInt", "()J");
			try {
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_readLittleEndianUnsignedInt);
			} finally {
			}
		}

		static IntPtr id_readLittleEndianUnsignedInt24;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readLittleEndianUnsignedInt24' and count(parameter)=0]"
		[Register ("readLittleEndianUnsignedInt24", "()I", "")]
		public unsafe int ReadLittleEndianUnsignedInt24 ()
		{
			if (id_readLittleEndianUnsignedInt24 == IntPtr.Zero)
				id_readLittleEndianUnsignedInt24 = JNIEnv.GetMethodID (class_ref, "readLittleEndianUnsignedInt24", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readLittleEndianUnsignedInt24);
			} finally {
			}
		}

		static IntPtr id_readLittleEndianUnsignedIntToInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readLittleEndianUnsignedIntToInt' and count(parameter)=0]"
		[Register ("readLittleEndianUnsignedIntToInt", "()I", "")]
		public unsafe int ReadLittleEndianUnsignedIntToInt ()
		{
			if (id_readLittleEndianUnsignedIntToInt == IntPtr.Zero)
				id_readLittleEndianUnsignedIntToInt = JNIEnv.GetMethodID (class_ref, "readLittleEndianUnsignedIntToInt", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readLittleEndianUnsignedIntToInt);
			} finally {
			}
		}

		static IntPtr id_readLittleEndianUnsignedShort;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readLittleEndianUnsignedShort' and count(parameter)=0]"
		[Register ("readLittleEndianUnsignedShort", "()I", "")]
		public unsafe int ReadLittleEndianUnsignedShort ()
		{
			if (id_readLittleEndianUnsignedShort == IntPtr.Zero)
				id_readLittleEndianUnsignedShort = JNIEnv.GetMethodID (class_ref, "readLittleEndianUnsignedShort", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readLittleEndianUnsignedShort);
			} finally {
			}
		}

		static IntPtr id_readLong;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readLong' and count(parameter)=0]"
		[Register ("readLong", "()J", "")]
		public unsafe long ReadLong ()
		{
			if (id_readLong == IntPtr.Zero)
				id_readLong = JNIEnv.GetMethodID (class_ref, "readLong", "()J");
			try {
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_readLong);
			} finally {
			}
		}

		static IntPtr id_readShort;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readShort' and count(parameter)=0]"
		[Register ("readShort", "()S", "")]
		public unsafe short ReadShort ()
		{
			if (id_readShort == IntPtr.Zero)
				id_readShort = JNIEnv.GetMethodID (class_ref, "readShort", "()S");
			try {
				return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_readShort);
			} finally {
			}
		}

		static IntPtr id_readString_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("readString", "(I)Ljava/lang/String;", "")]
		public unsafe string ReadString (int p0)
		{
			if (id_readString_I == IntPtr.Zero)
				id_readString_I = JNIEnv.GetMethodID (class_ref, "readString", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readString_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_readString_ILjava_nio_charset_Charset_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readString' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register ("readString", "(ILjava/nio/charset/Charset;)Ljava/lang/String;", "")]
		public unsafe string ReadString (int p0, global::Java.Nio.Charset.Charset p1)
		{
			if (id_readString_ILjava_nio_charset_Charset_ == IntPtr.Zero)
				id_readString_ILjava_nio_charset_Charset_ = JNIEnv.GetMethodID (class_ref, "readString", "(ILjava/nio/charset/Charset;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readString_ILjava_nio_charset_Charset_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_readSynchSafeInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readSynchSafeInt' and count(parameter)=0]"
		[Register ("readSynchSafeInt", "()I", "")]
		public unsafe int ReadSynchSafeInt ()
		{
			if (id_readSynchSafeInt == IntPtr.Zero)
				id_readSynchSafeInt = JNIEnv.GetMethodID (class_ref, "readSynchSafeInt", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readSynchSafeInt);
			} finally {
			}
		}

		static IntPtr id_readUnsignedByte;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readUnsignedByte' and count(parameter)=0]"
		[Register ("readUnsignedByte", "()I", "")]
		public unsafe int ReadUnsignedByte ()
		{
			if (id_readUnsignedByte == IntPtr.Zero)
				id_readUnsignedByte = JNIEnv.GetMethodID (class_ref, "readUnsignedByte", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readUnsignedByte);
			} finally {
			}
		}

		static IntPtr id_readUnsignedFixedPoint1616;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readUnsignedFixedPoint1616' and count(parameter)=0]"
		[Register ("readUnsignedFixedPoint1616", "()I", "")]
		public unsafe int ReadUnsignedFixedPoint1616 ()
		{
			if (id_readUnsignedFixedPoint1616 == IntPtr.Zero)
				id_readUnsignedFixedPoint1616 = JNIEnv.GetMethodID (class_ref, "readUnsignedFixedPoint1616", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readUnsignedFixedPoint1616);
			} finally {
			}
		}

		static IntPtr id_readUnsignedInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readUnsignedInt' and count(parameter)=0]"
		[Register ("readUnsignedInt", "()J", "")]
		public unsafe long ReadUnsignedInt ()
		{
			if (id_readUnsignedInt == IntPtr.Zero)
				id_readUnsignedInt = JNIEnv.GetMethodID (class_ref, "readUnsignedInt", "()J");
			try {
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_readUnsignedInt);
			} finally {
			}
		}

		static IntPtr id_readUnsignedInt24;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readUnsignedInt24' and count(parameter)=0]"
		[Register ("readUnsignedInt24", "()I", "")]
		public unsafe int ReadUnsignedInt24 ()
		{
			if (id_readUnsignedInt24 == IntPtr.Zero)
				id_readUnsignedInt24 = JNIEnv.GetMethodID (class_ref, "readUnsignedInt24", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readUnsignedInt24);
			} finally {
			}
		}

		static IntPtr id_readUnsignedIntToInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readUnsignedIntToInt' and count(parameter)=0]"
		[Register ("readUnsignedIntToInt", "()I", "")]
		public unsafe int ReadUnsignedIntToInt ()
		{
			if (id_readUnsignedIntToInt == IntPtr.Zero)
				id_readUnsignedIntToInt = JNIEnv.GetMethodID (class_ref, "readUnsignedIntToInt", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readUnsignedIntToInt);
			} finally {
			}
		}

		static IntPtr id_readUnsignedLongToLong;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readUnsignedLongToLong' and count(parameter)=0]"
		[Register ("readUnsignedLongToLong", "()J", "")]
		public unsafe long ReadUnsignedLongToLong ()
		{
			if (id_readUnsignedLongToLong == IntPtr.Zero)
				id_readUnsignedLongToLong = JNIEnv.GetMethodID (class_ref, "readUnsignedLongToLong", "()J");
			try {
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_readUnsignedLongToLong);
			} finally {
			}
		}

		static IntPtr id_readUnsignedShort;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='readUnsignedShort' and count(parameter)=0]"
		[Register ("readUnsignedShort", "()I", "")]
		public unsafe int ReadUnsignedShort ()
		{
			if (id_readUnsignedShort == IntPtr.Zero)
				id_readUnsignedShort = JNIEnv.GetMethodID (class_ref, "readUnsignedShort", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readUnsignedShort);
			} finally {
			}
		}

		static IntPtr id_reset;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "")]
		public unsafe void Reset ()
		{
			if (id_reset == IntPtr.Zero)
				id_reset = JNIEnv.GetMethodID (class_ref, "reset", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reset);
			} finally {
			}
		}

		static IntPtr id_reset_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='reset' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
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

		static IntPtr id_setLimit_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='setLimit' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLimit", "(I)V", "")]
		public unsafe void SetLimit (int p0)
		{
			if (id_setLimit_I == IntPtr.Zero)
				id_setLimit_I = JNIEnv.GetMethodID (class_ref, "setLimit", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLimit_I, __args);
			} finally {
			}
		}

		static IntPtr id_skipBytes_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='ParsableByteArray']/method[@name='skipBytes' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skipBytes", "(I)V", "")]
		public unsafe void SkipBytes (int p0)
		{
			if (id_skipBytes_I == IntPtr.Zero)
				id_skipBytes_I = JNIEnv.GetMethodID (class_ref, "skipBytes", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_skipBytes_I, __args);
			} finally {
			}
		}

	}
}
