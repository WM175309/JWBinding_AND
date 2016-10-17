using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer']/interface[@name='LoadControl']"
	[Register ("com/google/android/exoplayer/LoadControl", "", "Com.Google.Android.Exoplayer.ILoadControlInvoker")]
	public partial interface ILoadControl : IJavaObject {

		global::Com.Google.Android.Exoplayer.Upstream.IAllocator Allocator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/interface[@name='LoadControl']/method[@name='getAllocator' and count(parameter)=0]"
			[Register ("getAllocator", "()Lcom/google/android/exoplayer/upstream/Allocator;", "GetGetAllocatorHandler:Com.Google.Android.Exoplayer.ILoadControlInvoker, JWBinding_AND")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/interface[@name='LoadControl']/method[@name='register' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int']]"
		[Register ("register", "(Ljava/lang/Object;I)V", "GetRegister_Ljava_lang_Object_IHandler:Com.Google.Android.Exoplayer.ILoadControlInvoker, JWBinding_AND")]
		void Register (global::Java.Lang.Object p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/interface[@name='LoadControl']/method[@name='trimAllocator' and count(parameter)=0]"
		[Register ("trimAllocator", "()V", "GetTrimAllocatorHandler:Com.Google.Android.Exoplayer.ILoadControlInvoker, JWBinding_AND")]
		void TrimAllocator ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/interface[@name='LoadControl']/method[@name='unregister' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("unregister", "(Ljava/lang/Object;)V", "GetUnregister_Ljava_lang_Object_Handler:Com.Google.Android.Exoplayer.ILoadControlInvoker, JWBinding_AND")]
		void Unregister (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer']/interface[@name='LoadControl']/method[@name='update' and count(parameter)=4 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='boolean']]"
		[Register ("update", "(Ljava/lang/Object;JJZ)Z", "GetUpdate_Ljava_lang_Object_JJZHandler:Com.Google.Android.Exoplayer.ILoadControlInvoker, JWBinding_AND")]
		bool Update (global::Java.Lang.Object p0, long p1, long p2, bool p3);

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/LoadControl", DoNotGenerateAcw=true)]
	internal class ILoadControlInvoker : global::Java.Lang.Object, ILoadControl {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/LoadControl");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILoadControlInvoker); }
		}

		IntPtr class_ref;

		public static ILoadControl GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILoadControl> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.LoadControl"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoadControlInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAllocator;
#pragma warning disable 0169
		static Delegate GetGetAllocatorHandler ()
		{
			if (cb_getAllocator == null)
				cb_getAllocator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllocator);
			return cb_getAllocator;
		}

		static IntPtr n_GetAllocator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.ILoadControl __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.ILoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Allocator);
		}
#pragma warning restore 0169

		IntPtr id_getAllocator;
		public unsafe global::Com.Google.Android.Exoplayer.Upstream.IAllocator Allocator {
			get {
				if (id_getAllocator == IntPtr.Zero)
					id_getAllocator = JNIEnv.GetMethodID (class_ref, "getAllocator", "()Lcom/google/android/exoplayer/upstream/Allocator;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Upstream.IAllocator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllocator), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_register_Ljava_lang_Object_I;
#pragma warning disable 0169
		static Delegate GetRegister_Ljava_lang_Object_IHandler ()
		{
			if (cb_register_Ljava_lang_Object_I == null)
				cb_register_Ljava_lang_Object_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Register_Ljava_lang_Object_I);
			return cb_register_Ljava_lang_Object_I;
		}

		static void n_Register_Ljava_lang_Object_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Google.Android.Exoplayer.ILoadControl __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.ILoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Register (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_register_Ljava_lang_Object_I;
		public unsafe void Register (global::Java.Lang.Object p0, int p1)
		{
			if (id_register_Ljava_lang_Object_I == IntPtr.Zero)
				id_register_Ljava_lang_Object_I = JNIEnv.GetMethodID (class_ref, "register", "(Ljava/lang/Object;I)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_register_Ljava_lang_Object_I, __args);
		}

		static Delegate cb_trimAllocator;
#pragma warning disable 0169
		static Delegate GetTrimAllocatorHandler ()
		{
			if (cb_trimAllocator == null)
				cb_trimAllocator = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_TrimAllocator);
			return cb_trimAllocator;
		}

		static void n_TrimAllocator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Android.Exoplayer.ILoadControl __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.ILoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrimAllocator ();
		}
#pragma warning restore 0169

		IntPtr id_trimAllocator;
		public unsafe void TrimAllocator ()
		{
			if (id_trimAllocator == IntPtr.Zero)
				id_trimAllocator = JNIEnv.GetMethodID (class_ref, "trimAllocator", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_trimAllocator);
		}

		static Delegate cb_unregister_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetUnregister_Ljava_lang_Object_Handler ()
		{
			if (cb_unregister_Ljava_lang_Object_ == null)
				cb_unregister_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Unregister_Ljava_lang_Object_);
			return cb_unregister_Ljava_lang_Object_;
		}

		static void n_Unregister_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Android.Exoplayer.ILoadControl __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.ILoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Unregister (p0);
		}
#pragma warning restore 0169

		IntPtr id_unregister_Ljava_lang_Object_;
		public unsafe void Unregister (global::Java.Lang.Object p0)
		{
			if (id_unregister_Ljava_lang_Object_ == IntPtr.Zero)
				id_unregister_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "unregister", "(Ljava/lang/Object;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregister_Ljava_lang_Object_, __args);
		}

		static Delegate cb_update_Ljava_lang_Object_JJZ;
#pragma warning disable 0169
		static Delegate GetUpdate_Ljava_lang_Object_JJZHandler ()
		{
			if (cb_update_Ljava_lang_Object_JJZ == null)
				cb_update_Ljava_lang_Object_JJZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, long, bool, bool>) n_Update_Ljava_lang_Object_JJZ);
			return cb_update_Ljava_lang_Object_JJZ;
		}

		static bool n_Update_Ljava_lang_Object_JJZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2, bool p3)
		{
			global::Com.Google.Android.Exoplayer.ILoadControl __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.ILoadControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Update (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_update_Ljava_lang_Object_JJZ;
		public unsafe bool Update (global::Java.Lang.Object p0, long p1, long p2, bool p3)
		{
			if (id_update_Ljava_lang_Object_JJZ == IntPtr.Zero)
				id_update_Ljava_lang_Object_JJZ = JNIEnv.GetMethodID (class_ref, "update", "(Ljava/lang/Object;JJZ)Z");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_update_Ljava_lang_Object_JJZ, __args);
			return __ret;
		}

	}

}
