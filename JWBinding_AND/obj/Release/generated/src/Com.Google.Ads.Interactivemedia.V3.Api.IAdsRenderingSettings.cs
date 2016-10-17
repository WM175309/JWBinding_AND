using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Ads.Interactivemedia.V3.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdsRenderingSettings']"
	[Register ("com/google/ads/interactivemedia/v3/api/AdsRenderingSettings", "", "Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettingsInvoker")]
	public partial interface IAdsRenderingSettings : IJavaObject {

		int BitrateKbps {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdsRenderingSettings']/method[@name='getBitrateKbps' and count(parameter)=0]"
			[Register ("getBitrateKbps", "()I", "GetGetBitrateKbpsHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettingsInvoker, JWBinding_AND")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdsRenderingSettings']/method[@name='setBitrateKbps' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBitrateKbps", "(I)V", "GetSetBitrateKbps_IHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettingsInvoker, JWBinding_AND")] set;
		}

		bool EnablePreloading {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdsRenderingSettings']/method[@name='getEnablePreloading' and count(parameter)=0]"
			[Register ("getEnablePreloading", "()Z", "GetGetEnablePreloadingHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettingsInvoker, JWBinding_AND")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdsRenderingSettings']/method[@name='setEnablePreloading' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnablePreloading", "(Z)V", "GetSetEnablePreloading_ZHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettingsInvoker, JWBinding_AND")] set;
		}

		global::System.Collections.Generic.IList<string> MimeTypes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdsRenderingSettings']/method[@name='getMimeTypes' and count(parameter)=0]"
			[Register ("getMimeTypes", "()Ljava/util/List;", "GetGetMimeTypesHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettingsInvoker, JWBinding_AND")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdsRenderingSettings']/method[@name='setMimeTypes' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setMimeTypes", "(Ljava/util/List;)V", "GetSetMimeTypes_Ljava_util_List_Handler:Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettingsInvoker, JWBinding_AND")] set;
		}

		bool RenderCompanions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdsRenderingSettings']/method[@name='isRenderCompanions' and count(parameter)=0]"
			[Register ("isRenderCompanions", "()Z", "GetIsRenderCompanionsHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettingsInvoker, JWBinding_AND")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdsRenderingSettings']/method[@name='setRenderCompanions' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRenderCompanions", "(Z)V", "GetSetRenderCompanions_ZHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettingsInvoker, JWBinding_AND")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdsRenderingSettings']/method[@name='setPlayAdsAfterTime' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setPlayAdsAfterTime", "(D)V", "GetSetPlayAdsAfterTime_DHandler:Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettingsInvoker, JWBinding_AND")]
		void SetPlayAdsAfterTime (double p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.api']/interface[@name='AdsRenderingSettings']/method[@name='setUiElements' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;com.google.ads.interactivemedia.v3.api.UiElement&gt;']]"
		[Register ("setUiElements", "(Ljava/util/Set;)V", "GetSetUiElements_Ljava_util_Set_Handler:Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettingsInvoker, JWBinding_AND")]
		void SetUiElements (global::System.Collections.Generic.ICollection<global::Com.Google.Ads.Interactivemedia.V3.Api.IUiElement> p0);

	}

	[global::Android.Runtime.Register ("com/google/ads/interactivemedia/v3/api/AdsRenderingSettings", DoNotGenerateAcw=true)]
	internal class IAdsRenderingSettingsInvoker : global::Java.Lang.Object, IAdsRenderingSettings {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/ads/interactivemedia/v3/api/AdsRenderingSettings");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAdsRenderingSettingsInvoker); }
		}

		IntPtr class_ref;

		public static IAdsRenderingSettings GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdsRenderingSettings> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.ads.interactivemedia.v3.api.AdsRenderingSettings"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdsRenderingSettingsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getBitrateKbps;
#pragma warning disable 0169
		static Delegate GetGetBitrateKbpsHandler ()
		{
			if (cb_getBitrateKbps == null)
				cb_getBitrateKbps = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBitrateKbps);
			return cb_getBitrateKbps;
		}

		static int n_GetBitrateKbps (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettings __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BitrateKbps;
		}
#pragma warning restore 0169

		static Delegate cb_setBitrateKbps_I;
#pragma warning disable 0169
		static Delegate GetSetBitrateKbps_IHandler ()
		{
			if (cb_setBitrateKbps_I == null)
				cb_setBitrateKbps_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBitrateKbps_I);
			return cb_setBitrateKbps_I;
		}

		static void n_SetBitrateKbps_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettings __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BitrateKbps = p0;
		}
#pragma warning restore 0169

		IntPtr id_getBitrateKbps;
		IntPtr id_setBitrateKbps_I;
		public unsafe int BitrateKbps {
			get {
				if (id_getBitrateKbps == IntPtr.Zero)
					id_getBitrateKbps = JNIEnv.GetMethodID (class_ref, "getBitrateKbps", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBitrateKbps);
			}
			set {
				if (id_setBitrateKbps_I == IntPtr.Zero)
					id_setBitrateKbps_I = JNIEnv.GetMethodID (class_ref, "setBitrateKbps", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBitrateKbps_I, __args);
			}
		}

		static Delegate cb_getEnablePreloading;
#pragma warning disable 0169
		static Delegate GetGetEnablePreloadingHandler ()
		{
			if (cb_getEnablePreloading == null)
				cb_getEnablePreloading = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetEnablePreloading);
			return cb_getEnablePreloading;
		}

		static bool n_GetEnablePreloading (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettings __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnablePreloading;
		}
#pragma warning restore 0169

		static Delegate cb_setEnablePreloading_Z;
#pragma warning disable 0169
		static Delegate GetSetEnablePreloading_ZHandler ()
		{
			if (cb_setEnablePreloading_Z == null)
				cb_setEnablePreloading_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEnablePreloading_Z);
			return cb_setEnablePreloading_Z;
		}

		static void n_SetEnablePreloading_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettings __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnablePreloading = p0;
		}
#pragma warning restore 0169

		IntPtr id_getEnablePreloading;
		IntPtr id_setEnablePreloading_Z;
		public unsafe bool EnablePreloading {
			get {
				if (id_getEnablePreloading == IntPtr.Zero)
					id_getEnablePreloading = JNIEnv.GetMethodID (class_ref, "getEnablePreloading", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getEnablePreloading);
			}
			set {
				if (id_setEnablePreloading_Z == IntPtr.Zero)
					id_setEnablePreloading_Z = JNIEnv.GetMethodID (class_ref, "setEnablePreloading", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEnablePreloading_Z, __args);
			}
		}

		static Delegate cb_getMimeTypes;
#pragma warning disable 0169
		static Delegate GetGetMimeTypesHandler ()
		{
			if (cb_getMimeTypes == null)
				cb_getMimeTypes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMimeTypes);
			return cb_getMimeTypes;
		}

		static IntPtr n_GetMimeTypes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettings __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.MimeTypes);
		}
#pragma warning restore 0169

		static Delegate cb_setMimeTypes_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetMimeTypes_Ljava_util_List_Handler ()
		{
			if (cb_setMimeTypes_Ljava_util_List_ == null)
				cb_setMimeTypes_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMimeTypes_Ljava_util_List_);
			return cb_setMimeTypes_Ljava_util_List_;
		}

		static void n_SetMimeTypes_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettings __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MimeTypes = p0;
		}
#pragma warning restore 0169

		IntPtr id_getMimeTypes;
		IntPtr id_setMimeTypes_Ljava_util_List_;
		public unsafe global::System.Collections.Generic.IList<string> MimeTypes {
			get {
				if (id_getMimeTypes == IntPtr.Zero)
					id_getMimeTypes = JNIEnv.GetMethodID (class_ref, "getMimeTypes", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMimeTypes), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setMimeTypes_Ljava_util_List_ == IntPtr.Zero)
					id_setMimeTypes_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setMimeTypes", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMimeTypes_Ljava_util_List_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_isRenderCompanions;
#pragma warning disable 0169
		static Delegate GetIsRenderCompanionsHandler ()
		{
			if (cb_isRenderCompanions == null)
				cb_isRenderCompanions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRenderCompanions);
			return cb_isRenderCompanions;
		}

		static bool n_IsRenderCompanions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettings __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RenderCompanions;
		}
#pragma warning restore 0169

		static Delegate cb_setRenderCompanions_Z;
#pragma warning disable 0169
		static Delegate GetSetRenderCompanions_ZHandler ()
		{
			if (cb_setRenderCompanions_Z == null)
				cb_setRenderCompanions_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRenderCompanions_Z);
			return cb_setRenderCompanions_Z;
		}

		static void n_SetRenderCompanions_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettings __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RenderCompanions = p0;
		}
#pragma warning restore 0169

		IntPtr id_isRenderCompanions;
		IntPtr id_setRenderCompanions_Z;
		public unsafe bool RenderCompanions {
			get {
				if (id_isRenderCompanions == IntPtr.Zero)
					id_isRenderCompanions = JNIEnv.GetMethodID (class_ref, "isRenderCompanions", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRenderCompanions);
			}
			set {
				if (id_setRenderCompanions_Z == IntPtr.Zero)
					id_setRenderCompanions_Z = JNIEnv.GetMethodID (class_ref, "setRenderCompanions", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRenderCompanions_Z, __args);
			}
		}

		static Delegate cb_setPlayAdsAfterTime_D;
#pragma warning disable 0169
		static Delegate GetSetPlayAdsAfterTime_DHandler ()
		{
			if (cb_setPlayAdsAfterTime_D == null)
				cb_setPlayAdsAfterTime_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_SetPlayAdsAfterTime_D);
			return cb_setPlayAdsAfterTime_D;
		}

		static void n_SetPlayAdsAfterTime_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettings __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPlayAdsAfterTime (p0);
		}
#pragma warning restore 0169

		IntPtr id_setPlayAdsAfterTime_D;
		public unsafe void SetPlayAdsAfterTime (double p0)
		{
			if (id_setPlayAdsAfterTime_D == IntPtr.Zero)
				id_setPlayAdsAfterTime_D = JNIEnv.GetMethodID (class_ref, "setPlayAdsAfterTime", "(D)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPlayAdsAfterTime_D, __args);
		}

		static Delegate cb_setUiElements_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetSetUiElements_Ljava_util_Set_Handler ()
		{
			if (cb_setUiElements_Ljava_util_Set_ == null)
				cb_setUiElements_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUiElements_Ljava_util_Set_);
			return cb_setUiElements_Ljava_util_Set_;
		}

		static void n_SetUiElements_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettings __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Api.IAdsRenderingSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<global::Com.Google.Ads.Interactivemedia.V3.Api.IUiElement>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetUiElements (p0);
		}
#pragma warning restore 0169

		IntPtr id_setUiElements_Ljava_util_Set_;
		public unsafe void SetUiElements (global::System.Collections.Generic.ICollection<global::Com.Google.Ads.Interactivemedia.V3.Api.IUiElement> p0)
		{
			if (id_setUiElements_Ljava_util_Set_ == IntPtr.Zero)
				id_setUiElements_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "setUiElements", "(Ljava/util/Set;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<global::Com.Google.Ads.Interactivemedia.V3.Api.IUiElement>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUiElements_Ljava_util_Set_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
