using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Ads.Interactivemedia.V3.Impl.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='CompanionData']"
	[global::Android.Runtime.Register ("com/google/ads/interactivemedia/v3/impl/data/CompanionData", DoNotGenerateAcw=true)]
	public abstract partial class CompanionData : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/ads/interactivemedia/v3/impl/data/CompanionData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CompanionData); }
		}

		protected CompanionData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='CompanionData']/constructor[@name='CompanionData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CompanionData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CompanionData)) {
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

		static Delegate cb_clickThroughUrl;
#pragma warning disable 0169
		static Delegate GetClickThroughUrlHandler ()
		{
			if (cb_clickThroughUrl == null)
				cb_clickThroughUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ClickThroughUrl);
			return cb_clickThroughUrl;
		}

		static IntPtr n_ClickThroughUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.CompanionData __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.CompanionData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClickThroughUrl ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='CompanionData']/method[@name='clickThroughUrl' and count(parameter)=0]"
		[Register ("clickThroughUrl", "()Ljava/lang/String;", "GetClickThroughUrlHandler")]
		public abstract string ClickThroughUrl ();

		static Delegate cb_companionId;
#pragma warning disable 0169
		static Delegate GetCompanionIdHandler ()
		{
			if (cb_companionId == null)
				cb_companionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CompanionId);
			return cb_companionId;
		}

		static IntPtr n_CompanionId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.CompanionData __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.CompanionData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CompanionId ());
		}
#pragma warning restore 0169

		static IntPtr id_companionId;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='CompanionData']/method[@name='companionId' and count(parameter)=0]"
		[Register ("companionId", "()Ljava/lang/String;", "GetCompanionIdHandler")]
		public virtual unsafe string CompanionId ()
		{
			if (id_companionId == IntPtr.Zero)
				id_companionId = JNIEnv.GetMethodID (class_ref, "companionId", "()Ljava/lang/String;");
			try {

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_companionId), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "companionId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Size);
			return cb_size;
		}

		static IntPtr n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.CompanionData __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.CompanionData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Size ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='CompanionData']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()Ljava/lang/String;", "GetSizeHandler")]
		public abstract string Size ();

		static Delegate cb_src;
#pragma warning disable 0169
		static Delegate GetSrcHandler ()
		{
			if (cb_src == null)
				cb_src = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Src);
			return cb_src;
		}

		static IntPtr n_Src (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.CompanionData __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.CompanionData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Src ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='CompanionData']/method[@name='src' and count(parameter)=0]"
		[Register ("src", "()Ljava/lang/String;", "GetSrcHandler")]
		public abstract string Src ();

	}

	[global::Android.Runtime.Register ("com/google/ads/interactivemedia/v3/impl/data/CompanionData", DoNotGenerateAcw=true)]
	internal partial class CompanionDataInvoker : CompanionData {

		public CompanionDataInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (CompanionDataInvoker); }
		}

		static IntPtr id_clickThroughUrl;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='CompanionData']/method[@name='clickThroughUrl' and count(parameter)=0]"
		[Register ("clickThroughUrl", "()Ljava/lang/String;", "GetClickThroughUrlHandler")]
		public override unsafe string ClickThroughUrl ()
		{
			if (id_clickThroughUrl == IntPtr.Zero)
				id_clickThroughUrl = JNIEnv.GetMethodID (class_ref, "clickThroughUrl", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_clickThroughUrl), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='CompanionData']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()Ljava/lang/String;", "GetSizeHandler")]
		public override unsafe string Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_size), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_src;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='CompanionData']/method[@name='src' and count(parameter)=0]"
		[Register ("src", "()Ljava/lang/String;", "GetSrcHandler")]
		public override unsafe string Src ()
		{
			if (id_src == IntPtr.Zero)
				id_src = JNIEnv.GetMethodID (class_ref, "src", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_src), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
