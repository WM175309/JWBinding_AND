using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Extractor {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/interface[@name='ExtractorInput']"
	[Register ("com/google/android/exoplayer/extractor/ExtractorInput", "", "Com.Google.Android.Exoplayer.Extractor.IExtractorInputInvoker")]
	public partial interface IExtractorInput : IJavaObject {

		long Length {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/interface[@name='ExtractorInput']/method[@name='getLength' and count(parameter)=0]"
			[Register ("getLength", "()J", "GetGetLengthHandler:Com.Google.Android.Exoplayer.Extractor.IExtractorInputInvoker, JWBinding_AND")] get;
		}

		long PeekPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/interface[@name='ExtractorInput']/method[@name='getPeekPosition' and count(parameter)=0]"
			[Register ("getPeekPosition", "()J", "GetGetPeekPositionHandler:Com.Google.Android.Exoplayer.Extractor.IExtractorInputInvoker, JWBinding_AND")] get;
		}

		long Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/interface[@name='ExtractorInput']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()J", "GetGetPositionHandler:Com.Google.Android.Exoplayer.Extractor.IExtractorInputInvoker, JWBinding_AND")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/interface[@name='ExtractorInput']/method[@name='advancePeekPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("advancePeekPosition", "(I)V", "GetAdvancePeekPosition_IHandler:Com.Google.Android.Exoplayer.Extractor.IExtractorInputInvoker, JWBinding_AND")]
		void AdvancePeekPosition (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/interface[@name='ExtractorInput']/method[@name='advancePeekPosition' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("advancePeekPosition", "(IZ)Z", "GetAdvancePeekPosition_IZHandler:Com.Google.Android.Exoplayer.Extractor.IExtractorInputInvoker, JWBinding_AND")]
		bool AdvancePeekPosition (int p0, bool p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/interface[@name='ExtractorInput']/method[@name='peekFully' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("peekFully", "([BII)V", "GetPeekFully_arrayBIIHandler:Com.Google.Android.Exoplayer.Extractor.IExtractorInputInvoker, JWBinding_AND")]
		void PeekFully (byte[] p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/interface[@name='ExtractorInput']/method[@name='peekFully' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("peekFully", "([BIIZ)Z", "GetPeekFully_arrayBIIZHandler:Com.Google.Android.Exoplayer.Extractor.IExtractorInputInvoker, JWBinding_AND")]
		bool PeekFully (byte[] p0, int p1, int p2, bool p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/interface[@name='ExtractorInput']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("read", "([BII)I", "GetRead_arrayBIIHandler:Com.Google.Android.Exoplayer.Extractor.IExtractorInputInvoker, JWBinding_AND")]
		int Read (byte[] p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/interface[@name='ExtractorInput']/method[@name='readFully' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("readFully", "([BII)V", "GetReadFully_arrayBIIHandler:Com.Google.Android.Exoplayer.Extractor.IExtractorInputInvoker, JWBinding_AND")]
		void ReadFully (byte[] p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/interface[@name='ExtractorInput']/method[@name='readFully' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("readFully", "([BIIZ)Z", "GetReadFully_arrayBIIZHandler:Com.Google.Android.Exoplayer.Extractor.IExtractorInputInvoker, JWBinding_AND")]
		bool ReadFully (byte[] p0, int p1, int p2, bool p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/interface[@name='ExtractorInput']/method[@name='resetPeekPosition' and count(parameter)=0]"
		[Register ("resetPeekPosition", "()V", "GetResetPeekPositionHandler:Com.Google.Android.Exoplayer.Extractor.IExtractorInputInvoker, JWBinding_AND")]
		void ResetPeekPosition ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/interface[@name='ExtractorInput']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skip", "(I)I", "GetSkip_IHandler:Com.Google.Android.Exoplayer.Extractor.IExtractorInputInvoker, JWBinding_AND")]
		int Skip (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/interface[@name='ExtractorInput']/method[@name='skipFully' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("skipFully", "(I)V", "GetSkipFully_IHandler:Com.Google.Android.Exoplayer.Extractor.IExtractorInputInvoker, JWBinding_AND")]
		void SkipFully (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.extractor']/interface[@name='ExtractorInput']/method[@name='skipFully' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("skipFully", "(IZ)Z", "GetSkipFully_IZHandler:Com.Google.Android.Exoplayer.Extractor.IExtractorInputInvoker, JWBinding_AND")]
		bool SkipFully (int p0, bool p1);

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/extractor/ExtractorInput", DoNotGenerateAcw=true)]
	internal class IExtractorInputInvoker : global::Java.Lang.Object, IExtractorInput {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/extractor/ExtractorInput");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IExtractorInputInvoker); }
		}

		IntPtr class_ref;

		public static IExtractorInput GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExtractorInput> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.extractor.ExtractorInput"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExtractorInputInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getLength;
#pragma warning disable 0169
		static Delegate GetGetLengthHandler ()
		{
			if (cb_getLength == null)
				cb_getLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLength);
			return cb_getLength;
		}

		static long n_GetLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Length;
		}
#pragma warning restore 0169

		IntPtr id_getLength;
		public unsafe long Length {
			get {
				if (id_getLength == IntPtr.Zero)
					id_getLength = JNIEnv.GetMethodID (class_ref, "getLength", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLength);
			}
		}

		static Delegate cb_getPeekPosition;
#pragma warning disable 0169
		static Delegate GetGetPeekPositionHandler ()
		{
			if (cb_getPeekPosition == null)
				cb_getPeekPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetPeekPosition);
			return cb_getPeekPosition;
		}

		static long n_GetPeekPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PeekPosition;
		}
#pragma warning restore 0169

		IntPtr id_getPeekPosition;
		public unsafe long PeekPosition {
			get {
				if (id_getPeekPosition == IntPtr.Zero)
					id_getPeekPosition = JNIEnv.GetMethodID (class_ref, "getPeekPosition", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPeekPosition);
			}
		}

		static Delegate cb_getPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetPosition);
			return cb_getPosition;
		}

		static long n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Position;
		}
#pragma warning restore 0169

		IntPtr id_getPosition;
		public unsafe long Position {
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getPosition);
			}
		}

		static Delegate cb_advancePeekPosition_I;
#pragma warning disable 0169
		static Delegate GetAdvancePeekPosition_IHandler ()
		{
			if (cb_advancePeekPosition_I == null)
				cb_advancePeekPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_AdvancePeekPosition_I);
			return cb_advancePeekPosition_I;
		}

		static void n_AdvancePeekPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AdvancePeekPosition (p0);
		}
#pragma warning restore 0169

		IntPtr id_advancePeekPosition_I;
		public unsafe void AdvancePeekPosition (int p0)
		{
			if (id_advancePeekPosition_I == IntPtr.Zero)
				id_advancePeekPosition_I = JNIEnv.GetMethodID (class_ref, "advancePeekPosition", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_advancePeekPosition_I, __args);
		}

		static Delegate cb_advancePeekPosition_IZ;
#pragma warning disable 0169
		static Delegate GetAdvancePeekPosition_IZHandler ()
		{
			if (cb_advancePeekPosition_IZ == null)
				cb_advancePeekPosition_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, bool>) n_AdvancePeekPosition_IZ);
			return cb_advancePeekPosition_IZ;
		}

		static bool n_AdvancePeekPosition_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdvancePeekPosition (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_advancePeekPosition_IZ;
		public unsafe bool AdvancePeekPosition (int p0, bool p1)
		{
			if (id_advancePeekPosition_IZ == IntPtr.Zero)
				id_advancePeekPosition_IZ = JNIEnv.GetMethodID (class_ref, "advancePeekPosition", "(IZ)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_advancePeekPosition_IZ, __args);
		}

		static Delegate cb_peekFully_arrayBII;
#pragma warning disable 0169
		static Delegate GetPeekFully_arrayBIIHandler ()
		{
			if (cb_peekFully_arrayBII == null)
				cb_peekFully_arrayBII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_PeekFully_arrayBII);
			return cb_peekFully_arrayBII;
		}

		static void n_PeekFully_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.PeekFully (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_peekFully_arrayBII;
		public unsafe void PeekFully (byte[] p0, int p1, int p2)
		{
			if (id_peekFully_arrayBII == IntPtr.Zero)
				id_peekFully_arrayBII = JNIEnv.GetMethodID (class_ref, "peekFully", "([BII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_peekFully_arrayBII, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_peekFully_arrayBIIZ;
#pragma warning disable 0169
		static Delegate GetPeekFully_arrayBIIZHandler ()
		{
			if (cb_peekFully_arrayBIIZ == null)
				cb_peekFully_arrayBIIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool, bool>) n_PeekFully_arrayBIIZ);
			return cb_peekFully_arrayBIIZ;
		}

		static bool n_PeekFully_arrayBIIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, bool p3)
		{
			global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.PeekFully (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_peekFully_arrayBIIZ;
		public unsafe bool PeekFully (byte[] p0, int p1, int p2, bool p3)
		{
			if (id_peekFully_arrayBIIZ == IntPtr.Zero)
				id_peekFully_arrayBIIZ = JNIEnv.GetMethodID (class_ref, "peekFully", "([BIIZ)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_peekFully_arrayBIIZ, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_read_arrayBII;
#pragma warning disable 0169
		static Delegate GetRead_arrayBIIHandler ()
		{
			if (cb_read_arrayBII == null)
				cb_read_arrayBII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int>) n_Read_arrayBII);
			return cb_read_arrayBII;
		}

		static int n_Read_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_read_arrayBII;
		public unsafe int Read (byte[] p0, int p1, int p2)
		{
			if (id_read_arrayBII == IntPtr.Zero)
				id_read_arrayBII = JNIEnv.GetMethodID (class_ref, "read", "([BII)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read_arrayBII, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_readFully_arrayBII;
#pragma warning disable 0169
		static Delegate GetReadFully_arrayBIIHandler ()
		{
			if (cb_readFully_arrayBII == null)
				cb_readFully_arrayBII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_ReadFully_arrayBII);
			return cb_readFully_arrayBII;
		}

		static void n_ReadFully_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.ReadFully (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		IntPtr id_readFully_arrayBII;
		public unsafe void ReadFully (byte[] p0, int p1, int p2)
		{
			if (id_readFully_arrayBII == IntPtr.Zero)
				id_readFully_arrayBII = JNIEnv.GetMethodID (class_ref, "readFully", "([BII)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readFully_arrayBII, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_readFully_arrayBIIZ;
#pragma warning disable 0169
		static Delegate GetReadFully_arrayBIIZHandler ()
		{
			if (cb_readFully_arrayBIIZ == null)
				cb_readFully_arrayBIIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, bool, bool>) n_ReadFully_arrayBIIZ);
			return cb_readFully_arrayBIIZ;
		}

		static bool n_ReadFully_arrayBIIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, bool p3)
		{
			global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.ReadFully (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readFully_arrayBIIZ;
		public unsafe bool ReadFully (byte[] p0, int p1, int p2, bool p3)
		{
			if (id_readFully_arrayBIIZ == IntPtr.Zero)
				id_readFully_arrayBIIZ = JNIEnv.GetMethodID (class_ref, "readFully", "([BIIZ)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_readFully_arrayBIIZ, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_resetPeekPosition;
#pragma warning disable 0169
		static Delegate GetResetPeekPositionHandler ()
		{
			if (cb_resetPeekPosition == null)
				cb_resetPeekPosition = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetPeekPosition);
			return cb_resetPeekPosition;
		}

		static void n_ResetPeekPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetPeekPosition ();
		}
#pragma warning restore 0169

		IntPtr id_resetPeekPosition;
		public unsafe void ResetPeekPosition ()
		{
			if (id_resetPeekPosition == IntPtr.Zero)
				id_resetPeekPosition = JNIEnv.GetMethodID (class_ref, "resetPeekPosition", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetPeekPosition);
		}

		static Delegate cb_skip_I;
#pragma warning disable 0169
		static Delegate GetSkip_IHandler ()
		{
			if (cb_skip_I == null)
				cb_skip_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_Skip_I);
			return cb_skip_I;
		}

		static int n_Skip_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Skip (p0);
		}
#pragma warning restore 0169

		IntPtr id_skip_I;
		public unsafe int Skip (int p0)
		{
			if (id_skip_I == IntPtr.Zero)
				id_skip_I = JNIEnv.GetMethodID (class_ref, "skip", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_skip_I, __args);
		}

		static Delegate cb_skipFully_I;
#pragma warning disable 0169
		static Delegate GetSkipFully_IHandler ()
		{
			if (cb_skipFully_I == null)
				cb_skipFully_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SkipFully_I);
			return cb_skipFully_I;
		}

		static void n_SkipFully_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SkipFully (p0);
		}
#pragma warning restore 0169

		IntPtr id_skipFully_I;
		public unsafe void SkipFully (int p0)
		{
			if (id_skipFully_I == IntPtr.Zero)
				id_skipFully_I = JNIEnv.GetMethodID (class_ref, "skipFully", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_skipFully_I, __args);
		}

		static Delegate cb_skipFully_IZ;
#pragma warning disable 0169
		static Delegate GetSkipFully_IZHandler ()
		{
			if (cb_skipFully_IZ == null)
				cb_skipFully_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool, bool>) n_SkipFully_IZ);
			return cb_skipFully_IZ;
		}

		static bool n_SkipFully_IZ (IntPtr jnienv, IntPtr native__this, int p0, bool p1)
		{
			global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Extractor.IExtractorInput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SkipFully (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_skipFully_IZ;
		public unsafe bool SkipFully (int p0, bool p1)
		{
			if (id_skipFully_IZ == IntPtr.Zero)
				id_skipFully_IZ = JNIEnv.GetMethodID (class_ref, "skipFully", "(IZ)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_skipFully_IZ, __args);
		}

	}

}
