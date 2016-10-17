using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Ads.Interactivemedia.V3.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdEvent.AdEventListener']"
	[Register ("com/google/ads/interactivemedia/v3/api/AdEvent$AdEventListener", "", "Com.Google.Ads.Interactivemedia.V3.Api.IAdEventAdEventListenerInvoker")]
	public partial interface IAdEventAdEventListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdEvent.AdEventListener']/method[@name='onAdEvent' and count(parameter)=1 and parameter[1][@type='com.google.ads.interactivemedia.v3.api.AdEvent']]"
		[Register ("onAdEvent", "(Lcom/google/ads/interactivemedia/v3/api/AdEvent;)V", "GetOnAdEvent_Lcom_google_ads_interactivemedia_v3_api_AdEvent_Handler:Com.Google.Ads.Interactivemedia.V3.Api.IAdEventAdEventListenerInvoker, JWBinding_AND")]
		void OnAdEvent (global::Com.Google.Ads.Interactivemedia.V3.Api.IAdEvent p0);

	}

	[global::Android.Runtime.Register ("com/google/ads/interactivemedia/v3/api/AdEvent$AdEventListener", DoNotGenerateAcw=true)]
	internal class IAdEventAdEventListenerInvoker : global::Java.Lang.Object, IAdEventAdEventListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/ads/interactivemedia/v3/api/AdEvent$AdEventListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdEventAdEventListenerInvoker); }
		}

		IntPtr class_ref;

		public static IAdEventAdEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdEventAdEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.ads.interactivemedia.v3.api.AdEvent.AdEventListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdEventAdEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdEvent_Lcom_google_ads_interactivemedia_v3_api_AdEvent_;
#pragma warning disable 0169
		static Delegate GetOnAdEvent_Lcom_google_ads_interactivemedia_v3_api_AdEvent_Handler ()
		{
			if (cb_onAdEvent_Lcom_google_ads_interactivemedia_v3_api_AdEvent_ == null)
				cb_onAdEvent_Lcom_google_ads_interactivemedia_v3_api_AdEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAdEvent_Lcom_google_ads_interactivemedia_v3_api_AdEvent_);
			return cb_onAdEvent_Lcom_google_ads_interactivemedia_v3_api_AdEvent_;
		}

		static void n_OnAdEvent_Lcom_google_ads_interactivemedia_v3_api_AdEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAdEventAdEventListener __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAdEventAdEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAdEvent p0 = (global::Com.Google.Ads.Interactivemedia.V3.Api.IAdEvent)global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAdEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdEvent (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdEvent_Lcom_google_ads_interactivemedia_v3_api_AdEvent_;
		public unsafe void OnAdEvent (global::Com.Google.Ads.Interactivemedia.V3.Api.IAdEvent p0)
		{
			if (id_onAdEvent_Lcom_google_ads_interactivemedia_v3_api_AdEvent_ == IntPtr.Zero)
				id_onAdEvent_Lcom_google_ads_interactivemedia_v3_api_AdEvent_ = JNIEnv.GetMethodID (class_ref, "onAdEvent", "(Lcom/google/ads/interactivemedia/v3/api/AdEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdEvent_Lcom_google_ads_interactivemedia_v3_api_AdEvent_, __args);
		}

	}

	public partial class AdEventAdEventEventArgs : global::System.EventArgs {

		public AdEventAdEventEventArgs (global::Com.Google.Ads.Interactivemedia.V3.Api.IAdEvent p0)
		{
			this.p0 = p0;
		}

		global::Com.Google.Ads.Interactivemedia.V3.Api.IAdEvent p0;
		public global::Com.Google.Ads.Interactivemedia.V3.Api.IAdEvent P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/google/ads/interactivemedia/v3/api/AdEvent_AdEventListenerImplementor")]
	internal sealed partial class IAdEventAdEventListenerImplementor : global::Java.Lang.Object, IAdEventAdEventListener {

		object sender;

		public IAdEventAdEventListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/google/ads/interactivemedia/v3/api/AdEvent_AdEventListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<AdEventAdEventEventArgs> Handler;
#pragma warning restore 0649

		public void OnAdEvent (global::Com.Google.Ads.Interactivemedia.V3.Api.IAdEvent p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new AdEventAdEventEventArgs (p0));
		}

		internal static bool __IsEmpty (IAdEventAdEventListenerImplementor value)
		{
			return value.Handler == null;
		}
	}


	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='AdEvent.AdEventType']"
	[global::Android.Runtime.Register ("com/google/ads/interactivemedia/v3/api/AdEvent$AdEventType", DoNotGenerateAcw=true)]
	public sealed partial class AdEventAdEventType : global::Java.Lang.Enum {


		static IntPtr AD_BREAK_ENDED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='AdEvent.AdEventType']/field[@name='AD_BREAK_ENDED']"
		[Register ("AD_BREAK_ENDED")]
		public static global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType AdBreakEnded {
			get {
				if (AD_BREAK_ENDED_jfieldId == IntPtr.Zero)
					AD_BREAK_ENDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AD_BREAK_ENDED", "Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AD_BREAK_ENDED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AD_BREAK_READY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='AdEvent.AdEventType']/field[@name='AD_BREAK_READY']"
		[Register ("AD_BREAK_READY")]
		public static global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType AdBreakReady {
			get {
				if (AD_BREAK_READY_jfieldId == IntPtr.Zero)
					AD_BREAK_READY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AD_BREAK_READY", "Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AD_BREAK_READY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AD_BREAK_STARTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='AdEvent.AdEventType']/field[@name='AD_BREAK_STARTED']"
		[Register ("AD_BREAK_STARTED")]
		public static global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType AdBreakStarted {
			get {
				if (AD_BREAK_STARTED_jfieldId == IntPtr.Zero)
					AD_BREAK_STARTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AD_BREAK_STARTED", "Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AD_BREAK_STARTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ALL_ADS_COMPLETED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='AdEvent.AdEventType']/field[@name='ALL_ADS_COMPLETED']"
		[Register ("ALL_ADS_COMPLETED")]
		public static global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType AllAdsCompleted {
			get {
				if (ALL_ADS_COMPLETED_jfieldId == IntPtr.Zero)
					ALL_ADS_COMPLETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALL_ADS_COMPLETED", "Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALL_ADS_COMPLETED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CLICKED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='AdEvent.AdEventType']/field[@name='CLICKED']"
		[Register ("CLICKED")]
		public static global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType Clicked {
			get {
				if (CLICKED_jfieldId == IntPtr.Zero)
					CLICKED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLICKED", "Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLICKED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr COMPLETED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='AdEvent.AdEventType']/field[@name='COMPLETED']"
		[Register ("COMPLETED")]
		public static global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType Completed {
			get {
				if (COMPLETED_jfieldId == IntPtr.Zero)
					COMPLETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "COMPLETED", "Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, COMPLETED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CONTENT_PAUSE_REQUESTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='AdEvent.AdEventType']/field[@name='CONTENT_PAUSE_REQUESTED']"
		[Register ("CONTENT_PAUSE_REQUESTED")]
		public static global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType ContentPauseRequested {
			get {
				if (CONTENT_PAUSE_REQUESTED_jfieldId == IntPtr.Zero)
					CONTENT_PAUSE_REQUESTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTENT_PAUSE_REQUESTED", "Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONTENT_PAUSE_REQUESTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CONTENT_RESUME_REQUESTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='AdEvent.AdEventType']/field[@name='CONTENT_RESUME_REQUESTED']"
		[Register ("CONTENT_RESUME_REQUESTED")]
		public static global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType ContentResumeRequested {
			get {
				if (CONTENT_RESUME_REQUESTED_jfieldId == IntPtr.Zero)
					CONTENT_RESUME_REQUESTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTENT_RESUME_REQUESTED", "Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONTENT_RESUME_REQUESTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FIRST_QUARTILE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='AdEvent.AdEventType']/field[@name='FIRST_QUARTILE']"
		[Register ("FIRST_QUARTILE")]
		public static global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType FirstQuartile {
			get {
				if (FIRST_QUARTILE_jfieldId == IntPtr.Zero)
					FIRST_QUARTILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FIRST_QUARTILE", "Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FIRST_QUARTILE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LOADED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='AdEvent.AdEventType']/field[@name='LOADED']"
		[Register ("LOADED")]
		public static global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType Loaded {
			get {
				if (LOADED_jfieldId == IntPtr.Zero)
					LOADED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOADED", "Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOADED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LOG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='AdEvent.AdEventType']/field[@name='LOG']"
		[Register ("LOG")]
		public static global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType Log {
			get {
				if (LOG_jfieldId == IntPtr.Zero)
					LOG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOG", "Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOG_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr MIDPOINT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='AdEvent.AdEventType']/field[@name='MIDPOINT']"
		[Register ("MIDPOINT")]
		public static global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType Midpoint {
			get {
				if (MIDPOINT_jfieldId == IntPtr.Zero)
					MIDPOINT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MIDPOINT", "Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MIDPOINT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PAUSED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='AdEvent.AdEventType']/field[@name='PAUSED']"
		[Register ("PAUSED")]
		public static global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType Paused {
			get {
				if (PAUSED_jfieldId == IntPtr.Zero)
					PAUSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PAUSED", "Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PAUSED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RESUMED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='AdEvent.AdEventType']/field[@name='RESUMED']"
		[Register ("RESUMED")]
		public static global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType Resumed {
			get {
				if (RESUMED_jfieldId == IntPtr.Zero)
					RESUMED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RESUMED", "Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RESUMED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SKIPPED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='AdEvent.AdEventType']/field[@name='SKIPPED']"
		[Register ("SKIPPED")]
		public static global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType Skipped {
			get {
				if (SKIPPED_jfieldId == IntPtr.Zero)
					SKIPPED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SKIPPED", "Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SKIPPED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STARTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='AdEvent.AdEventType']/field[@name='STARTED']"
		[Register ("STARTED")]
		public static global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType Started {
			get {
				if (STARTED_jfieldId == IntPtr.Zero)
					STARTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STARTED", "Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STARTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TAPPED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='AdEvent.AdEventType']/field[@name='TAPPED']"
		[Register ("TAPPED")]
		public static global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType Tapped {
			get {
				if (TAPPED_jfieldId == IntPtr.Zero)
					TAPPED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TAPPED", "Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TAPPED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr THIRD_QUARTILE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='AdEvent.AdEventType']/field[@name='THIRD_QUARTILE']"
		[Register ("THIRD_QUARTILE")]
		public static global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType ThirdQuartile {
			get {
				if (THIRD_QUARTILE_jfieldId == IntPtr.Zero)
					THIRD_QUARTILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THIRD_QUARTILE", "Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THIRD_QUARTILE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/ads/interactivemedia/v3/api/AdEvent$AdEventType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AdEventAdEventType); }
		}

		internal AdEventAdEventType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='AdEvent.AdEventType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;", "")]
		public static unsafe global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/class[@name='AdEvent.AdEventType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;", "")]
		public static unsafe global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;");
			try {
				return (global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType));
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdEvent']"
	[Register ("com/google/ads/interactivemedia/v3/api/AdEvent", "", "Com.Google.Ads.Interactivemedia.V3.Api.IAdEventInvoker")]
	public partial interface IAdEvent : IJavaObject {

		global::Com.Google.Ads.Interactivemedia.V3.Api.IAd Ad {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdEvent']/method[@name='getAd' and count(parameter)=0]"
			[Register ("getAd", "()Lcom/google/ads/interactivemedia/v3/api/Ad;", "GetGetAdHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdEventInvoker, JWBinding_AND")] get;
		}

		global::System.Collections.Generic.IDictionary<string, string> AdData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdEvent']/method[@name='getAdData' and count(parameter)=0]"
			[Register ("getAdData", "()Ljava/util/Map;", "GetGetAdDataHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdEventInvoker, JWBinding_AND")] get;
		}

		global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdEvent']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;", "GetGetTypeHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdEventInvoker, JWBinding_AND")] get;
		}

	}

	[global::Android.Runtime.Register ("com/google/ads/interactivemedia/v3/api/AdEvent", DoNotGenerateAcw=true)]
	internal class IAdEventInvoker : global::Java.Lang.Object, IAdEvent {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/ads/interactivemedia/v3/api/AdEvent");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdEventInvoker); }
		}

		IntPtr class_ref;

		public static IAdEvent GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdEvent> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.ads.interactivemedia.v3.api.AdEvent"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdEventInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAd;
#pragma warning disable 0169
		static Delegate GetGetAdHandler ()
		{
			if (cb_getAd == null)
				cb_getAd = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAd);
			return cb_getAd;
		}

		static IntPtr n_GetAd (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAdEvent __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAdEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Ad);
		}
#pragma warning restore 0169

		IntPtr id_getAd;
		public unsafe global::Com.Google.Ads.Interactivemedia.V3.Api.IAd Ad {
			get {
				if (id_getAd == IntPtr.Zero)
					id_getAd = JNIEnv.GetMethodID (class_ref, "getAd", "()Lcom/google/ads/interactivemedia/v3/api/Ad;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAd> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAd), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAdData;
#pragma warning disable 0169
		static Delegate GetGetAdDataHandler ()
		{
			if (cb_getAdData == null)
				cb_getAdData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdData);
			return cb_getAdData;
		}

		static IntPtr n_GetAdData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAdEvent __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAdEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.AdData);
		}
#pragma warning restore 0169

		IntPtr id_getAdData;
		public unsafe global::System.Collections.Generic.IDictionary<string, string> AdData {
			get {
				if (id_getAdData == IntPtr.Zero)
					id_getAdData = JNIEnv.GetMethodID (class_ref, "getAdData", "()Ljava/util/Map;");
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdData), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAdEvent __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAdEvent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Type);
		}
#pragma warning restore 0169

		IntPtr id_getType;
		public unsafe global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType Type {
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Lcom/google/ads/interactivemedia/v3/api/AdEvent$AdEventType;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.AdEventAdEventType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
