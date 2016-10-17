using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Ads.Interactivemedia.V3.Api {

	[Register ("com/google/ads/interactivemedia/v3/api/UiElement", DoNotGenerateAcw=true)]
	public abstract class UiElement : Java.Lang.Object {

		internal UiElement ()
		{
		}

		static IntPtr AD_ATTRIBUTION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='UiElement']/field[@name='AD_ATTRIBUTION']"
		[Register ("AD_ATTRIBUTION")]
		public static global::Com.Google.Ads.Interactivemedia.V3.Api.IUiElement AdAttribution {
			get {
				if (AD_ATTRIBUTION_jfieldId == IntPtr.Zero)
					AD_ATTRIBUTION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AD_ATTRIBUTION", "Lcom/google/ads/interactivemedia/v3/api/UiElement;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AD_ATTRIBUTION_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IUiElement> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr COUNTDOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='UiElement']/field[@name='COUNTDOWN']"
		[Register ("COUNTDOWN")]
		public static global::Com.Google.Ads.Interactivemedia.V3.Api.IUiElement Countdown {
			get {
				if (COUNTDOWN_jfieldId == IntPtr.Zero)
					COUNTDOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COUNTDOWN", "Lcom/google/ads/interactivemedia/v3/api/UiElement;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COUNTDOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IUiElement> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr class_ref = JNIEnv.FindClass ("com/google/ads/interactivemedia/v3/api/UiElement");
	}

	[Register ("com/google/ads/interactivemedia/v3/api/UiElement", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'UiElement' type. This type will be removed in a future release.")]
	public abstract class UiElementConsts : UiElement {

		private UiElementConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='UiElement']"
	[Register ("com/google/ads/interactivemedia/v3/api/UiElement", "", "Com.Google.Ads.Interactivemedia.V3.Api.IUiElementInvoker")]
	public partial interface IUiElement : IJavaObject {

		string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='UiElement']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler:Com.Google.Ads.Interactivemedia.V3.Api.IUiElementInvoker, JWBinding_AND")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/ads/interactivemedia/v3/api/UiElement", DoNotGenerateAcw=true)]
	internal class IUiElementInvoker : global::Java.Lang.Object, IUiElement {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/ads/interactivemedia/v3/api/UiElement");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IUiElementInvoker); }
		}

		IntPtr class_ref;

		public static IUiElement GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IUiElement> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.ads.interactivemedia.v3.api.UiElement"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IUiElementInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IUiElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IUiElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		IntPtr id_getName;
		public unsafe string Name {
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
