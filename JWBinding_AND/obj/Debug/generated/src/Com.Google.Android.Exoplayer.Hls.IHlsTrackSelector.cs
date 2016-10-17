using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Hls {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer.hls']/interface[@name='HlsTrackSelector.Output']"
	[Register ("com/google/android/exoplayer/hls/HlsTrackSelector$Output", "", "Com.Google.Android.Exoplayer.Hls.IHlsTrackSelectorOutputInvoker")]
	public partial interface IHlsTrackSelectorOutput : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.hls']/interface[@name='HlsTrackSelector.Output']/method[@name='adaptiveTrack' and count(parameter)=2 and parameter[1][@type='com.google.android.exoplayer.hls.HlsMasterPlaylist'] and parameter[2][@type='com.google.android.exoplayer.hls.Variant[]']]"
		[Register ("adaptiveTrack", "(Lcom/google/android/exoplayer/hls/HlsMasterPlaylist;[Lcom/google/android/exoplayer/hls/Variant;)V", "GetAdaptiveTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_arrayLcom_google_android_exoplayer_hls_Variant_Handler:Com.Google.Android.Exoplayer.Hls.IHlsTrackSelectorOutputInvoker, JWBinding_AND")]
		void AdaptiveTrack (global::Com.Google.Android.Exoplayer.Hls.HlsMasterPlaylist p0, global::Com.Google.Android.Exoplayer.Hls.Variant[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.hls']/interface[@name='HlsTrackSelector.Output']/method[@name='fixedTrack' and count(parameter)=2 and parameter[1][@type='com.google.android.exoplayer.hls.HlsMasterPlaylist'] and parameter[2][@type='com.google.android.exoplayer.hls.Variant']]"
		[Register ("fixedTrack", "(Lcom/google/android/exoplayer/hls/HlsMasterPlaylist;Lcom/google/android/exoplayer/hls/Variant;)V", "GetFixedTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_Variant_Handler:Com.Google.Android.Exoplayer.Hls.IHlsTrackSelectorOutputInvoker, JWBinding_AND")]
		void FixedTrack (global::Com.Google.Android.Exoplayer.Hls.HlsMasterPlaylist p0, global::Com.Google.Android.Exoplayer.Hls.Variant p1);

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/hls/HlsTrackSelector$Output", DoNotGenerateAcw=true)]
	internal class IHlsTrackSelectorOutputInvoker : global::Java.Lang.Object, IHlsTrackSelectorOutput {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/hls/HlsTrackSelector$Output");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IHlsTrackSelectorOutputInvoker); }
		}

		IntPtr class_ref;

		public static IHlsTrackSelectorOutput GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHlsTrackSelectorOutput> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.hls.HlsTrackSelector.Output"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHlsTrackSelectorOutputInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_adaptiveTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_arrayLcom_google_android_exoplayer_hls_Variant_;
#pragma warning disable 0169
		static Delegate GetAdaptiveTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_arrayLcom_google_android_exoplayer_hls_Variant_Handler ()
		{
			if (cb_adaptiveTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_arrayLcom_google_android_exoplayer_hls_Variant_ == null)
				cb_adaptiveTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_arrayLcom_google_android_exoplayer_hls_Variant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AdaptiveTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_arrayLcom_google_android_exoplayer_hls_Variant_);
			return cb_adaptiveTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_arrayLcom_google_android_exoplayer_hls_Variant_;
		}

		static void n_AdaptiveTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_arrayLcom_google_android_exoplayer_hls_Variant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Exoplayer.Hls.IHlsTrackSelectorOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Hls.IHlsTrackSelectorOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Hls.HlsMasterPlaylist p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Hls.HlsMasterPlaylist> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Hls.Variant[] p1 = (global::Com.Google.Android.Exoplayer.Hls.Variant[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Google.Android.Exoplayer.Hls.Variant));
			__this.AdaptiveTrack (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		IntPtr id_adaptiveTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_arrayLcom_google_android_exoplayer_hls_Variant_;
		public unsafe void AdaptiveTrack (global::Com.Google.Android.Exoplayer.Hls.HlsMasterPlaylist p0, global::Com.Google.Android.Exoplayer.Hls.Variant[] p1)
		{
			if (id_adaptiveTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_arrayLcom_google_android_exoplayer_hls_Variant_ == IntPtr.Zero)
				id_adaptiveTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_arrayLcom_google_android_exoplayer_hls_Variant_ = JNIEnv.GetMethodID (class_ref, "adaptiveTrack", "(Lcom/google/android/exoplayer/hls/HlsMasterPlaylist;[Lcom/google/android/exoplayer/hls/Variant;)V");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_adaptiveTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_arrayLcom_google_android_exoplayer_hls_Variant_, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_fixedTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_Variant_;
#pragma warning disable 0169
		static Delegate GetFixedTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_Variant_Handler ()
		{
			if (cb_fixedTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_Variant_ == null)
				cb_fixedTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_Variant_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_FixedTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_Variant_);
			return cb_fixedTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_Variant_;
		}

		static void n_FixedTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_Variant_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Exoplayer.Hls.IHlsTrackSelectorOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Hls.IHlsTrackSelectorOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Hls.HlsMasterPlaylist p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Hls.HlsMasterPlaylist> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Hls.Variant p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Hls.Variant> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.FixedTrack (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_fixedTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_Variant_;
		public unsafe void FixedTrack (global::Com.Google.Android.Exoplayer.Hls.HlsMasterPlaylist p0, global::Com.Google.Android.Exoplayer.Hls.Variant p1)
		{
			if (id_fixedTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_Variant_ == IntPtr.Zero)
				id_fixedTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_Variant_ = JNIEnv.GetMethodID (class_ref, "fixedTrack", "(Lcom/google/android/exoplayer/hls/HlsMasterPlaylist;Lcom/google/android/exoplayer/hls/Variant;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fixedTrack_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_Variant_, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer.hls']/interface[@name='HlsTrackSelector']"
	[Register ("com/google/android/exoplayer/hls/HlsTrackSelector", "", "Com.Google.Android.Exoplayer.Hls.IHlsTrackSelectorInvoker")]
	public partial interface IHlsTrackSelector : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.hls']/interface[@name='HlsTrackSelector']/method[@name='selectTracks' and count(parameter)=2 and parameter[1][@type='com.google.android.exoplayer.hls.HlsMasterPlaylist'] and parameter[2][@type='com.google.android.exoplayer.hls.HlsTrackSelector.Output']]"
		[Register ("selectTracks", "(Lcom/google/android/exoplayer/hls/HlsMasterPlaylist;Lcom/google/android/exoplayer/hls/HlsTrackSelector$Output;)V", "GetSelectTracks_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_HlsTrackSelector_Output_Handler:Com.Google.Android.Exoplayer.Hls.IHlsTrackSelectorInvoker, JWBinding_AND")]
		void SelectTracks (global::Com.Google.Android.Exoplayer.Hls.HlsMasterPlaylist p0, global::Com.Google.Android.Exoplayer.Hls.IHlsTrackSelectorOutput p1);

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/hls/HlsTrackSelector", DoNotGenerateAcw=true)]
	internal class IHlsTrackSelectorInvoker : global::Java.Lang.Object, IHlsTrackSelector {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/hls/HlsTrackSelector");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IHlsTrackSelectorInvoker); }
		}

		IntPtr class_ref;

		public static IHlsTrackSelector GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHlsTrackSelector> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.hls.HlsTrackSelector"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHlsTrackSelectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_selectTracks_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_HlsTrackSelector_Output_;
#pragma warning disable 0169
		static Delegate GetSelectTracks_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_HlsTrackSelector_Output_Handler ()
		{
			if (cb_selectTracks_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_HlsTrackSelector_Output_ == null)
				cb_selectTracks_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_HlsTrackSelector_Output_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SelectTracks_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_HlsTrackSelector_Output_);
			return cb_selectTracks_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_HlsTrackSelector_Output_;
		}

		static void n_SelectTracks_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_HlsTrackSelector_Output_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Exoplayer.Hls.IHlsTrackSelector __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Hls.IHlsTrackSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Hls.HlsMasterPlaylist p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Hls.HlsMasterPlaylist> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Hls.IHlsTrackSelectorOutput p1 = (global::Com.Google.Android.Exoplayer.Hls.IHlsTrackSelectorOutput)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Hls.IHlsTrackSelectorOutput> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SelectTracks (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_selectTracks_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_HlsTrackSelector_Output_;
		public unsafe void SelectTracks (global::Com.Google.Android.Exoplayer.Hls.HlsMasterPlaylist p0, global::Com.Google.Android.Exoplayer.Hls.IHlsTrackSelectorOutput p1)
		{
			if (id_selectTracks_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_HlsTrackSelector_Output_ == IntPtr.Zero)
				id_selectTracks_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_HlsTrackSelector_Output_ = JNIEnv.GetMethodID (class_ref, "selectTracks", "(Lcom/google/android/exoplayer/hls/HlsMasterPlaylist;Lcom/google/android/exoplayer/hls/HlsTrackSelector$Output;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_selectTracks_Lcom_google_android_exoplayer_hls_HlsMasterPlaylist_Lcom_google_android_exoplayer_hls_HlsTrackSelector_Output_, __args);
		}

	}

}
