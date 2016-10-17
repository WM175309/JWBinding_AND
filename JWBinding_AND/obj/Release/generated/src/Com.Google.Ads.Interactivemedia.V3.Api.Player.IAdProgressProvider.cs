using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Ads.Interactivemedia.V3.Api.Player {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='AdProgressProvider']"
	[Register ("com/google/ads/interactivemedia/v3/api/player/AdProgressProvider", "", "Com.Google.Ads.Interactivemedia.V3.Api.Player.IAdProgressProviderInvoker")]
	public partial interface IAdProgressProvider : IJavaObject {

		global::Com.Google.Ads.Interactivemedia.V3.Api.Player.VideoProgressUpdate AdProgress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='AdProgressProvider']/method[@name='getAdProgress' and count(parameter)=0]"
			[Register ("getAdProgress", "()Lcom/google/ads/interactivemedia/v3/api/player/VideoProgressUpdate;", "GetGetAdProgressHandler:Com.Google.Ads.Interactivemedia.V3.Api.Player.IAdProgressProviderInvoker, JWBinding_AND")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/ads/interactivemedia/v3/api/player/AdProgressProvider", DoNotGenerateAcw=true)]
	internal class IAdProgressProviderInvoker : global::Java.Lang.Object, IAdProgressProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/ads/interactivemedia/v3/api/player/AdProgressProvider");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdProgressProviderInvoker); }
		}

		IntPtr class_ref;

		public static IAdProgressProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdProgressProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.ads.interactivemedia.v3.api.player.AdProgressProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdProgressProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAdProgress;
#pragma warning disable 0169
		static Delegate GetGetAdProgressHandler ()
		{
			if (cb_getAdProgress == null)
				cb_getAdProgress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdProgress);
			return cb_getAdProgress;
		}

		static IntPtr n_GetAdProgress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IAdProgressProvider __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IAdProgressProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdProgress);
		}
#pragma warning restore 0169

		IntPtr id_getAdProgress;
		public unsafe global::Com.Google.Ads.Interactivemedia.V3.Api.Player.VideoProgressUpdate AdProgress {
			get {
				if (id_getAdProgress == IntPtr.Zero)
					id_getAdProgress = JNIEnv.GetMethodID (class_ref, "getAdProgress", "()Lcom/google/ads/interactivemedia/v3/api/player/VideoProgressUpdate;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.VideoProgressUpdate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdProgress), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
