using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='SampleHolder']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/SampleHolder", DoNotGenerateAcw=true)]
	public sealed partial class SampleHolder : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='SampleHolder']/field[@name='BUFFER_REPLACEMENT_MODE_DIRECT']"
		[Register ("BUFFER_REPLACEMENT_MODE_DIRECT")]
		public const int BufferReplacementModeDirect = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='SampleHolder']/field[@name='BUFFER_REPLACEMENT_MODE_DISABLED']"
		[Register ("BUFFER_REPLACEMENT_MODE_DISABLED")]
		public const int BufferReplacementModeDisabled = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='SampleHolder']/field[@name='BUFFER_REPLACEMENT_MODE_NORMAL']"
		[Register ("BUFFER_REPLACEMENT_MODE_NORMAL")]
		public const int BufferReplacementModeNormal = (int) 1;

		static IntPtr data_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='SampleHolder']/field[@name='data']"
		[Register ("data")]
		public global::Java.Nio.ByteBuffer Data {
			get {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "Ljava/nio/ByteBuffer;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, data_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "Ljava/nio/ByteBuffer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, data_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr flags_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='SampleHolder']/field[@name='flags']"
		[Register ("flags")]
		public int Flags {
			get {
				if (flags_jfieldId == IntPtr.Zero)
					flags_jfieldId = JNIEnv.GetFieldID (class_ref, "flags", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, flags_jfieldId);
			}
			set {
				if (flags_jfieldId == IntPtr.Zero)
					flags_jfieldId = JNIEnv.GetFieldID (class_ref, "flags", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, flags_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr size_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='SampleHolder']/field[@name='size']"
		[Register ("size")]
		public int Size {
			get {
				if (size_jfieldId == IntPtr.Zero)
					size_jfieldId = JNIEnv.GetFieldID (class_ref, "size", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, size_jfieldId);
			}
			set {
				if (size_jfieldId == IntPtr.Zero)
					size_jfieldId = JNIEnv.GetFieldID (class_ref, "size", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, size_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr timeUs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='SampleHolder']/field[@name='timeUs']"
		[Register ("timeUs")]
		public long TimeUs {
			get {
				if (timeUs_jfieldId == IntPtr.Zero)
					timeUs_jfieldId = JNIEnv.GetFieldID (class_ref, "timeUs", "J");
				return JNIEnv.GetLongField (((global::Java.Lang.Object) this).Handle, timeUs_jfieldId);
			}
			set {
				if (timeUs_jfieldId == IntPtr.Zero)
					timeUs_jfieldId = JNIEnv.GetFieldID (class_ref, "timeUs", "J");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, timeUs_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/SampleHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SampleHolder); }
		}

		internal SampleHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='SampleHolder']/constructor[@name='SampleHolder' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe SampleHolder (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (SampleHolder)) {
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

		static IntPtr id_isDecodeOnly;
		public unsafe bool IsDecodeOnly {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='SampleHolder']/method[@name='isDecodeOnly' and count(parameter)=0]"
			[Register ("isDecodeOnly", "()Z", "GetIsDecodeOnlyHandler")]
			get {
				if (id_isDecodeOnly == IntPtr.Zero)
					id_isDecodeOnly = JNIEnv.GetMethodID (class_ref, "isDecodeOnly", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDecodeOnly);
				} finally {
				}
			}
		}

		static IntPtr id_isEncrypted;
		public unsafe bool IsEncrypted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='SampleHolder']/method[@name='isEncrypted' and count(parameter)=0]"
			[Register ("isEncrypted", "()Z", "GetIsEncryptedHandler")]
			get {
				if (id_isEncrypted == IntPtr.Zero)
					id_isEncrypted = JNIEnv.GetMethodID (class_ref, "isEncrypted", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEncrypted);
				} finally {
				}
			}
		}

		static IntPtr id_isSyncFrame;
		public unsafe bool IsSyncFrame {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='SampleHolder']/method[@name='isSyncFrame' and count(parameter)=0]"
			[Register ("isSyncFrame", "()Z", "GetIsSyncFrameHandler")]
			get {
				if (id_isSyncFrame == IntPtr.Zero)
					id_isSyncFrame = JNIEnv.GetMethodID (class_ref, "isSyncFrame", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSyncFrame);
				} finally {
				}
			}
		}

		static IntPtr id_clearData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='SampleHolder']/method[@name='clearData' and count(parameter)=0]"
		[Register ("clearData", "()V", "")]
		public unsafe void ClearData ()
		{
			if (id_clearData == IntPtr.Zero)
				id_clearData = JNIEnv.GetMethodID (class_ref, "clearData", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearData);
			} finally {
			}
		}

		static IntPtr id_ensureSpaceForWrite_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='SampleHolder']/method[@name='ensureSpaceForWrite' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("ensureSpaceForWrite", "(I)V", "")]
		public unsafe void EnsureSpaceForWrite (int p0)
		{
			if (id_ensureSpaceForWrite_I == IntPtr.Zero)
				id_ensureSpaceForWrite_I = JNIEnv.GetMethodID (class_ref, "ensureSpaceForWrite", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_ensureSpaceForWrite_I, __args);
			} finally {
			}
		}

	}
}
