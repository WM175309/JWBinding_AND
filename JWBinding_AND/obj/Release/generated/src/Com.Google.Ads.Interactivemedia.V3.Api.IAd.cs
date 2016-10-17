using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Ads.Interactivemedia.V3.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='Ad']"
	[Register ("com/google/ads/interactivemedia/v3/api/Ad", "", "Com.Google.Ads.Interactivemedia.V3.Api.IAdInvoker")]
	public partial interface IAd : IJavaObject {

		string AdId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='Ad']/method[@name='getAdId' and count(parameter)=0]"
			[Register ("getAdId", "()Ljava/lang/String;", "GetGetAdIdHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdInvoker, JWBinding_AND")] get;
		}

		global::Com.Google.Ads.Interactivemedia.V3.Api.IAdPodInfo AdPodInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='Ad']/method[@name='getAdPodInfo' and count(parameter)=0]"
			[Register ("getAdPodInfo", "()Lcom/google/ads/interactivemedia/v3/api/AdPodInfo;", "GetGetAdPodInfoHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdInvoker, JWBinding_AND")] get;
		}

		string AdSystem {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='Ad']/method[@name='getAdSystem' and count(parameter)=0]"
			[Register ("getAdSystem", "()Ljava/lang/String;", "GetGetAdSystemHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdInvoker, JWBinding_AND")] get;
		}

		string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='Ad']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "GetGetContentTypeHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdInvoker, JWBinding_AND")] get;
		}

		string Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='Ad']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdInvoker, JWBinding_AND")] get;
		}

		double Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='Ad']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()D", "GetGetDurationHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdInvoker, JWBinding_AND")] get;
		}

		int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='Ad']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdInvoker, JWBinding_AND")] get;
		}

		bool IsLinear {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='Ad']/method[@name='isLinear' and count(parameter)=0]"
			[Register ("isLinear", "()Z", "GetIsLinearHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdInvoker, JWBinding_AND")] get;
		}

		bool IsSkippable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='Ad']/method[@name='isSkippable' and count(parameter)=0]"
			[Register ("isSkippable", "()Z", "GetIsSkippableHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdInvoker, JWBinding_AND")] get;
		}

		string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='Ad']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdInvoker, JWBinding_AND")] get;
		}

		string TraffickingParameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='Ad']/method[@name='getTraffickingParameters' and count(parameter)=0]"
			[Register ("getTraffickingParameters", "()Ljava/lang/String;", "GetGetTraffickingParametersHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdInvoker, JWBinding_AND")] get;
		}

		global::System.Collections.Generic.ICollection<global::Com.Google.Ads.Interactivemedia.V3.Api.IUiElement> UiElements {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='Ad']/method[@name='getUiElements' and count(parameter)=0]"
			[Register ("getUiElements", "()Ljava/util/Set;", "GetGetUiElementsHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdInvoker, JWBinding_AND")] get;
		}

		int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='Ad']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdInvoker, JWBinding_AND")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='Ad']/method[@name='getAdWrapperIds' and count(parameter)=0]"
		[Register ("getAdWrapperIds", "()[Ljava/lang/String;", "GetGetAdWrapperIdsHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdInvoker, JWBinding_AND")]
		string[] GetAdWrapperIds ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='Ad']/method[@name='getAdWrapperSystems' and count(parameter)=0]"
		[Register ("getAdWrapperSystems", "()[Ljava/lang/String;", "GetGetAdWrapperSystemsHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdInvoker, JWBinding_AND")]
		string[] GetAdWrapperSystems ();

	}

	[global::Android.Runtime.Register ("com/google/ads/interactivemedia/v3/api/Ad", DoNotGenerateAcw=true)]
	internal class IAdInvoker : global::Java.Lang.Object, IAd {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/ads/interactivemedia/v3/api/Ad");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdInvoker); }
		}

		IntPtr class_ref;

		public static IAd GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAd> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.ads.interactivemedia.v3.api.Ad"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAdId;
#pragma warning disable 0169
		static Delegate GetGetAdIdHandler ()
		{
			if (cb_getAdId == null)
				cb_getAdId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdId);
			return cb_getAdId;
		}

		static IntPtr n_GetAdId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAd __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdId);
		}
#pragma warning restore 0169

		IntPtr id_getAdId;
		public unsafe string AdId {
			get {
				if (id_getAdId == IntPtr.Zero)
					id_getAdId = JNIEnv.GetMethodID (class_ref, "getAdId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAdPodInfo;
#pragma warning disable 0169
		static Delegate GetGetAdPodInfoHandler ()
		{
			if (cb_getAdPodInfo == null)
				cb_getAdPodInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdPodInfo);
			return cb_getAdPodInfo;
		}

		static IntPtr n_GetAdPodInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAd __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AdPodInfo);
		}
#pragma warning restore 0169

		IntPtr id_getAdPodInfo;
		public unsafe global::Com.Google.Ads.Interactivemedia.V3.Api.IAdPodInfo AdPodInfo {
			get {
				if (id_getAdPodInfo == IntPtr.Zero)
					id_getAdPodInfo = JNIEnv.GetMethodID (class_ref, "getAdPodInfo", "()Lcom/google/ads/interactivemedia/v3/api/AdPodInfo;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAdPodInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdPodInfo), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAdSystem;
#pragma warning disable 0169
		static Delegate GetGetAdSystemHandler ()
		{
			if (cb_getAdSystem == null)
				cb_getAdSystem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdSystem);
			return cb_getAdSystem;
		}

		static IntPtr n_GetAdSystem (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAd __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdSystem);
		}
#pragma warning restore 0169

		IntPtr id_getAdSystem;
		public unsafe string AdSystem {
			get {
				if (id_getAdSystem == IntPtr.Zero)
					id_getAdSystem = JNIEnv.GetMethodID (class_ref, "getAdSystem", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdSystem), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentType);
			return cb_getContentType;
		}

		static IntPtr n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAd __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType);
		}
#pragma warning restore 0169

		IntPtr id_getContentType;
		public unsafe string ContentType {
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAd __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Description);
		}
#pragma warning restore 0169

		IntPtr id_getDescription;
		public unsafe string Description {
			get {
				if (id_getDescription == IntPtr.Zero)
					id_getDescription = JNIEnv.GetMethodID (class_ref, "getDescription", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDescription), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetDuration);
			return cb_getDuration;
		}

		static double n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAd __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		IntPtr id_getDuration;
		public unsafe double Duration {
			get {
				if (id_getDuration == IntPtr.Zero)
					id_getDuration = JNIEnv.GetMethodID (class_ref, "getDuration", "()D");
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getDuration);
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAd __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		IntPtr id_getHeight;
		public unsafe int Height {
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeight);
			}
		}

		static Delegate cb_isLinear;
#pragma warning disable 0169
		static Delegate GetIsLinearHandler ()
		{
			if (cb_isLinear == null)
				cb_isLinear = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLinear);
			return cb_isLinear;
		}

		static bool n_IsLinear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAd __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLinear;
		}
#pragma warning restore 0169

		IntPtr id_isLinear;
		public unsafe bool IsLinear {
			get {
				if (id_isLinear == IntPtr.Zero)
					id_isLinear = JNIEnv.GetMethodID (class_ref, "isLinear", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLinear);
			}
		}

		static Delegate cb_isSkippable;
#pragma warning disable 0169
		static Delegate GetIsSkippableHandler ()
		{
			if (cb_isSkippable == null)
				cb_isSkippable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSkippable);
			return cb_isSkippable;
		}

		static bool n_IsSkippable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAd __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSkippable;
		}
#pragma warning restore 0169

		IntPtr id_isSkippable;
		public unsafe bool IsSkippable {
			get {
				if (id_isSkippable == IntPtr.Zero)
					id_isSkippable = JNIEnv.GetMethodID (class_ref, "isSkippable", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSkippable);
			}
		}

		static Delegate cb_getTitle;
#pragma warning disable 0169
		static Delegate GetGetTitleHandler ()
		{
			if (cb_getTitle == null)
				cb_getTitle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTitle);
			return cb_getTitle;
		}

		static IntPtr n_GetTitle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAd __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Title);
		}
#pragma warning restore 0169

		IntPtr id_getTitle;
		public unsafe string Title {
			get {
				if (id_getTitle == IntPtr.Zero)
					id_getTitle = JNIEnv.GetMethodID (class_ref, "getTitle", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTitle), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTraffickingParameters;
#pragma warning disable 0169
		static Delegate GetGetTraffickingParametersHandler ()
		{
			if (cb_getTraffickingParameters == null)
				cb_getTraffickingParameters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTraffickingParameters);
			return cb_getTraffickingParameters;
		}

		static IntPtr n_GetTraffickingParameters (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAd __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TraffickingParameters);
		}
#pragma warning restore 0169

		IntPtr id_getTraffickingParameters;
		public unsafe string TraffickingParameters {
			get {
				if (id_getTraffickingParameters == IntPtr.Zero)
					id_getTraffickingParameters = JNIEnv.GetMethodID (class_ref, "getTraffickingParameters", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTraffickingParameters), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getUiElements;
#pragma warning disable 0169
		static Delegate GetGetUiElementsHandler ()
		{
			if (cb_getUiElements == null)
				cb_getUiElements = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUiElements);
			return cb_getUiElements;
		}

		static IntPtr n_GetUiElements (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAd __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Google.Ads.Interactivemedia.V3.Api.IUiElement>.ToLocalJniHandle (__this.UiElements);
		}
#pragma warning restore 0169

		IntPtr id_getUiElements;
		public unsafe global::System.Collections.Generic.ICollection<global::Com.Google.Ads.Interactivemedia.V3.Api.IUiElement> UiElements {
			get {
				if (id_getUiElements == IntPtr.Zero)
					id_getUiElements = JNIEnv.GetMethodID (class_ref, "getUiElements", "()Ljava/util/Set;");
				return global::Android.Runtime.JavaSet<global::Com.Google.Ads.Interactivemedia.V3.Api.IUiElement>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUiElements), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAd __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		IntPtr id_getWidth;
		public unsafe int Width {
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
			}
		}

		static Delegate cb_getAdWrapperIds;
#pragma warning disable 0169
		static Delegate GetGetAdWrapperIdsHandler ()
		{
			if (cb_getAdWrapperIds == null)
				cb_getAdWrapperIds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdWrapperIds);
			return cb_getAdWrapperIds;
		}

		static IntPtr n_GetAdWrapperIds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAd __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAdWrapperIds ());
		}
#pragma warning restore 0169

		IntPtr id_getAdWrapperIds;
		public unsafe string[] GetAdWrapperIds ()
		{
			if (id_getAdWrapperIds == IntPtr.Zero)
				id_getAdWrapperIds = JNIEnv.GetMethodID (class_ref, "getAdWrapperIds", "()[Ljava/lang/String;");
			return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdWrapperIds), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

		static Delegate cb_getAdWrapperSystems;
#pragma warning disable 0169
		static Delegate GetGetAdWrapperSystemsHandler ()
		{
			if (cb_getAdWrapperSystems == null)
				cb_getAdWrapperSystems = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdWrapperSystems);
			return cb_getAdWrapperSystems;
		}

		static IntPtr n_GetAdWrapperSystems (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAd __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAdWrapperSystems ());
		}
#pragma warning restore 0169

		IntPtr id_getAdWrapperSystems;
		public unsafe string[] GetAdWrapperSystems ()
		{
			if (id_getAdWrapperSystems == IntPtr.Zero)
				id_getAdWrapperSystems = JNIEnv.GetMethodID (class_ref, "getAdWrapperSystems", "()[Ljava/lang/String;");
			return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdWrapperSystems), JniHandleOwnership.TransferLocalRef, typeof (string));
		}

	}

}
