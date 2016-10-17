using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Ads.Interactivemedia.V3.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdPodInfo']"
	[Register ("com/google/ads/interactivemedia/v3/api/AdPodInfo", "", "Com.Google.Ads.Interactivemedia.V3.Api.IAdPodInfoInvoker")]
	public partial interface IAdPodInfo : IJavaObject {

		int AdPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdPodInfo']/method[@name='getAdPosition' and count(parameter)=0]"
			[Register ("getAdPosition", "()I", "GetGetAdPositionHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdPodInfoInvoker, JWBinding_AND")] get;
		}

		bool IsBumper {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdPodInfo']/method[@name='isBumper' and count(parameter)=0]"
			[Register ("isBumper", "()Z", "GetIsBumperHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdPodInfoInvoker, JWBinding_AND")] get;
		}

		double MaxDuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdPodInfo']/method[@name='getMaxDuration' and count(parameter)=0]"
			[Register ("getMaxDuration", "()D", "GetGetMaxDurationHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdPodInfoInvoker, JWBinding_AND")] get;
		}

		int PodIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdPodInfo']/method[@name='getPodIndex' and count(parameter)=0]"
			[Register ("getPodIndex", "()I", "GetGetPodIndexHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdPodInfoInvoker, JWBinding_AND")] get;
		}

		double TimeOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdPodInfo']/method[@name='getTimeOffset' and count(parameter)=0]"
			[Register ("getTimeOffset", "()D", "GetGetTimeOffsetHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdPodInfoInvoker, JWBinding_AND")] get;
		}

		int TotalAds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdPodInfo']/method[@name='getTotalAds' and count(parameter)=0]"
			[Register ("getTotalAds", "()I", "GetGetTotalAdsHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdPodInfoInvoker, JWBinding_AND")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/ads/interactivemedia/v3/api/AdPodInfo", DoNotGenerateAcw=true)]
	internal class IAdPodInfoInvoker : global::Java.Lang.Object, IAdPodInfo {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/ads/interactivemedia/v3/api/AdPodInfo");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdPodInfoInvoker); }
		}

		IntPtr class_ref;

		public static IAdPodInfo GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdPodInfo> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.ads.interactivemedia.v3.api.AdPodInfo"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdPodInfoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAdPosition;
#pragma warning disable 0169
		static Delegate GetGetAdPositionHandler ()
		{
			if (cb_getAdPosition == null)
				cb_getAdPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAdPosition);
			return cb_getAdPosition;
		}

		static int n_GetAdPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAdPodInfo __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAdPodInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AdPosition;
		}
#pragma warning restore 0169

		IntPtr id_getAdPosition;
		public unsafe int AdPosition {
			get {
				if (id_getAdPosition == IntPtr.Zero)
					id_getAdPosition = JNIEnv.GetMethodID (class_ref, "getAdPosition", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAdPosition);
			}
		}

		static Delegate cb_isBumper;
#pragma warning disable 0169
		static Delegate GetIsBumperHandler ()
		{
			if (cb_isBumper == null)
				cb_isBumper = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBumper);
			return cb_isBumper;
		}

		static bool n_IsBumper (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAdPodInfo __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAdPodInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBumper;
		}
#pragma warning restore 0169

		IntPtr id_isBumper;
		public unsafe bool IsBumper {
			get {
				if (id_isBumper == IntPtr.Zero)
					id_isBumper = JNIEnv.GetMethodID (class_ref, "isBumper", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBumper);
			}
		}

		static Delegate cb_getMaxDuration;
#pragma warning disable 0169
		static Delegate GetGetMaxDurationHandler ()
		{
			if (cb_getMaxDuration == null)
				cb_getMaxDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetMaxDuration);
			return cb_getMaxDuration;
		}

		static double n_GetMaxDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAdPodInfo __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAdPodInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxDuration;
		}
#pragma warning restore 0169

		IntPtr id_getMaxDuration;
		public unsafe double MaxDuration {
			get {
				if (id_getMaxDuration == IntPtr.Zero)
					id_getMaxDuration = JNIEnv.GetMethodID (class_ref, "getMaxDuration", "()D");
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getMaxDuration);
			}
		}

		static Delegate cb_getPodIndex;
#pragma warning disable 0169
		static Delegate GetGetPodIndexHandler ()
		{
			if (cb_getPodIndex == null)
				cb_getPodIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPodIndex);
			return cb_getPodIndex;
		}

		static int n_GetPodIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAdPodInfo __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAdPodInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PodIndex;
		}
#pragma warning restore 0169

		IntPtr id_getPodIndex;
		public unsafe int PodIndex {
			get {
				if (id_getPodIndex == IntPtr.Zero)
					id_getPodIndex = JNIEnv.GetMethodID (class_ref, "getPodIndex", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPodIndex);
			}
		}

		static Delegate cb_getTimeOffset;
#pragma warning disable 0169
		static Delegate GetGetTimeOffsetHandler ()
		{
			if (cb_getTimeOffset == null)
				cb_getTimeOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetTimeOffset);
			return cb_getTimeOffset;
		}

		static double n_GetTimeOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAdPodInfo __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAdPodInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeOffset;
		}
#pragma warning restore 0169

		IntPtr id_getTimeOffset;
		public unsafe double TimeOffset {
			get {
				if (id_getTimeOffset == IntPtr.Zero)
					id_getTimeOffset = JNIEnv.GetMethodID (class_ref, "getTimeOffset", "()D");
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getTimeOffset);
			}
		}

		static Delegate cb_getTotalAds;
#pragma warning disable 0169
		static Delegate GetGetTotalAdsHandler ()
		{
			if (cb_getTotalAds == null)
				cb_getTotalAds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTotalAds);
			return cb_getTotalAds;
		}

		static int n_GetTotalAds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAdPodInfo __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAdPodInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalAds;
		}
#pragma warning restore 0169

		IntPtr id_getTotalAds;
		public unsafe int TotalAds {
			get {
				if (id_getTotalAds == IntPtr.Zero)
					id_getTotalAds = JNIEnv.GetMethodID (class_ref, "getTotalAds", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTotalAds);
			}
		}

	}

}
