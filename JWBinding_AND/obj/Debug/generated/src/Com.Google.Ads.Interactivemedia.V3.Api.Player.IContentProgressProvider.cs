using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Ads.Interactivemedia.V3.Api.Player {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='ContentProgressProvider']"
	[Register ("com/google/ads/interactivemedia/v3/api/player/ContentProgressProvider", "", "Com.Google.Ads.Interactivemedia.V3.Api.Player.IContentProgressProviderInvoker")]
	public partial interface IContentProgressProvider : IJavaObject {

		global::Com.Google.Ads.Interactivemedia.V3.Api.Player.VideoProgressUpdate ContentProgress {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api.player']/interface[@name='ContentProgressProvider']/method[@name='getContentProgress' and count(parameter)=0]"
			[Register ("getContentProgress", "()Lcom/google/ads/interactivemedia/v3/api/player/VideoProgressUpdate;", "GetGetContentProgressHandler:Com.Google.Ads.Interactivemedia.V3.Api.Player.IContentProgressProviderInvoker, JWBinding_AND")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/ads/interactivemedia/v3/api/player/ContentProgressProvider", DoNotGenerateAcw=true)]
	internal class IContentProgressProviderInvoker : global::Java.Lang.Object, IContentProgressProvider {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/ads/interactivemedia/v3/api/player/ContentProgressProvider");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IContentProgressProviderInvoker); }
		}

		IntPtr class_ref;

		public static IContentProgressProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IContentProgressProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.ads.interactivemedia.v3.api.player.ContentProgressProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IContentProgressProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getContentProgress;
#pragma warning disable 0169
		static Delegate GetGetContentProgressHandler ()
		{
			if (cb_getContentProgress == null)
				cb_getContentProgress = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentProgress);
			return cb_getContentProgress;
		}

		static IntPtr n_GetContentProgress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IContentProgressProvider __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.IContentProgressProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentProgress);
		}
#pragma warning restore 0169

		IntPtr id_getContentProgress;
		public unsafe global::Com.Google.Ads.Interactivemedia.V3.Api.Player.VideoProgressUpdate ContentProgress {
			get {
				if (id_getContentProgress == IntPtr.Zero)
					id_getContentProgress = JNIEnv.GetMethodID (class_ref, "getContentProgress", "()Lcom/google/ads/interactivemedia/v3/api/player/VideoProgressUpdate;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.Player.VideoProgressUpdate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentProgress), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
