using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Smoothstreaming {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer.smoothstreaming']/interface[@name='SmoothStreamingTrackSelector.Output']"
	[Register ("com/google/android/exoplayer/smoothstreaming/SmoothStreamingTrackSelector$Output", "", "Com.Google.Android.Exoplayer.Smoothstreaming.ISmoothStreamingTrackSelectorOutputInvoker")]
	public partial interface ISmoothStreamingTrackSelectorOutput : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.smoothstreaming']/interface[@name='SmoothStreamingTrackSelector.Output']/method[@name='adaptiveTrack' and count(parameter)=3 and parameter[1][@type='com.google.android.exoplayer.smoothstreaming.SmoothStreamingManifest'] and parameter[2][@type='int'] and parameter[3][@type='int[]']]"
		[Register ("adaptiveTrack", "(Lcom/google/android/exoplayer/smoothstreaming/SmoothStreamingManifest;I[I)V", "GetAdaptiveTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_IarrayIHandler:Com.Google.Android.Exoplayer.Smoothstreaming.ISmoothStreamingTrackSelectorOutputInvoker, JWBinding_AND")]
		void AdaptiveTrack (global::Com.Google.Android.Exoplayer.Smoothstreaming.SmoothStreamingManifest p0, int p1, int[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.smoothstreaming']/interface[@name='SmoothStreamingTrackSelector.Output']/method[@name='fixedTrack' and count(parameter)=3 and parameter[1][@type='com.google.android.exoplayer.smoothstreaming.SmoothStreamingManifest'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("fixedTrack", "(Lcom/google/android/exoplayer/smoothstreaming/SmoothStreamingManifest;II)V", "GetFixedTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_IIHandler:Com.Google.Android.Exoplayer.Smoothstreaming.ISmoothStreamingTrackSelectorOutputInvoker, JWBinding_AND")]
		void FixedTrack (global::Com.Google.Android.Exoplayer.Smoothstreaming.SmoothStreamingManifest p0, int p1, int p2);

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/smoothstreaming/SmoothStreamingTrackSelector$Output", DoNotGenerateAcw=true)]
	internal class ISmoothStreamingTrackSelectorOutputInvoker : global::Java.Lang.Object, ISmoothStreamingTrackSelectorOutput {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/smoothstreaming/SmoothStreamingTrackSelector$Output");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISmoothStreamingTrackSelectorOutputInvoker); }
		}

		IntPtr class_ref;

		public static ISmoothStreamingTrackSelectorOutput GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISmoothStreamingTrackSelectorOutput> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.smoothstreaming.SmoothStreamingTrackSelector.Output"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISmoothStreamingTrackSelectorOutputInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_adaptiveTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_IarrayI;
#pragma warning disable 0169
		static Delegate GetAdaptiveTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_IarrayIHandler ()
		{
			if (cb_adaptiveTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_IarrayI == null)
				cb_adaptiveTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_IarrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_AdaptiveTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_IarrayI);
			return cb_adaptiveTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_IarrayI;
		}

		static void n_AdaptiveTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_IarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Com.Google.Android.Exoplayer.Smoothstreaming.ISmoothStreamingTrackSelectorOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Smoothstreaming.ISmoothStreamingTrackSelectorOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Smoothstreaming.SmoothStreamingManifest p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Smoothstreaming.SmoothStreamingManifest> (native_p0, JniHandleOwnership.DoNotTransfer);
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.AdaptiveTrack (p0, p1, p2);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		IntPtr id_adaptiveTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_IarrayI;
		public unsafe void AdaptiveTrack (global::Com.Google.Android.Exoplayer.Smoothstreaming.SmoothStreamingManifest p0, int p1, int[] p2)
		{
			if (id_adaptiveTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_IarrayI == IntPtr.Zero)
				id_adaptiveTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_IarrayI = JNIEnv.GetMethodID (class_ref, "adaptiveTrack", "(Lcom/google/android/exoplayer/smoothstreaming/SmoothStreamingManifest;I[I)V");
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_adaptiveTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_IarrayI, __args);
			if (p2 != null) {
				JNIEnv.CopyArray (native_p2, p2);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_fixedTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_II;
#pragma warning disable 0169
		static Delegate GetFixedTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_IIHandler ()
		{
			if (cb_fixedTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_II == null)
				cb_fixedTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_FixedTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_II);
			return cb_fixedTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_II;
		}

		static void n_FixedTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Google.Android.Exoplayer.Smoothstreaming.ISmoothStreamingTrackSelectorOutput __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Smoothstreaming.ISmoothStreamingTrackSelectorOutput> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Smoothstreaming.SmoothStreamingManifest p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Smoothstreaming.SmoothStreamingManifest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FixedTrack (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_fixedTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_II;
		public unsafe void FixedTrack (global::Com.Google.Android.Exoplayer.Smoothstreaming.SmoothStreamingManifest p0, int p1, int p2)
		{
			if (id_fixedTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_II == IntPtr.Zero)
				id_fixedTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_II = JNIEnv.GetMethodID (class_ref, "fixedTrack", "(Lcom/google/android/exoplayer/smoothstreaming/SmoothStreamingManifest;II)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fixedTrack_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_II, __args);
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.android.exoplayer.smoothstreaming']/interface[@name='SmoothStreamingTrackSelector']"
	[Register ("com/google/android/exoplayer/smoothstreaming/SmoothStreamingTrackSelector", "", "Com.Google.Android.Exoplayer.Smoothstreaming.ISmoothStreamingTrackSelectorInvoker")]
	public partial interface ISmoothStreamingTrackSelector : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.smoothstreaming']/interface[@name='SmoothStreamingTrackSelector']/method[@name='selectTracks' and count(parameter)=2 and parameter[1][@type='com.google.android.exoplayer.smoothstreaming.SmoothStreamingManifest'] and parameter[2][@type='com.google.android.exoplayer.smoothstreaming.SmoothStreamingTrackSelector.Output']]"
		[Register ("selectTracks", "(Lcom/google/android/exoplayer/smoothstreaming/SmoothStreamingManifest;Lcom/google/android/exoplayer/smoothstreaming/SmoothStreamingTrackSelector$Output;)V", "GetSelectTracks_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingTrackSelector_Output_Handler:Com.Google.Android.Exoplayer.Smoothstreaming.ISmoothStreamingTrackSelectorInvoker, JWBinding_AND")]
		void SelectTracks (global::Com.Google.Android.Exoplayer.Smoothstreaming.SmoothStreamingManifest p0, global::Com.Google.Android.Exoplayer.Smoothstreaming.ISmoothStreamingTrackSelectorOutput p1);

	}

	[global::Android.Runtime.Register ("com/google/android/exoplayer/smoothstreaming/SmoothStreamingTrackSelector", DoNotGenerateAcw=true)]
	internal class ISmoothStreamingTrackSelectorInvoker : global::Java.Lang.Object, ISmoothStreamingTrackSelector {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/android/exoplayer/smoothstreaming/SmoothStreamingTrackSelector");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISmoothStreamingTrackSelectorInvoker); }
		}

		IntPtr class_ref;

		public static ISmoothStreamingTrackSelector GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISmoothStreamingTrackSelector> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.android.exoplayer.smoothstreaming.SmoothStreamingTrackSelector"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISmoothStreamingTrackSelectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_selectTracks_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingTrackSelector_Output_;
#pragma warning disable 0169
		static Delegate GetSelectTracks_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingTrackSelector_Output_Handler ()
		{
			if (cb_selectTracks_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingTrackSelector_Output_ == null)
				cb_selectTracks_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingTrackSelector_Output_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SelectTracks_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingTrackSelector_Output_);
			return cb_selectTracks_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingTrackSelector_Output_;
		}

		static void n_SelectTracks_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingTrackSelector_Output_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Android.Exoplayer.Smoothstreaming.ISmoothStreamingTrackSelector __this = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Smoothstreaming.ISmoothStreamingTrackSelector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Smoothstreaming.SmoothStreamingManifest p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Smoothstreaming.SmoothStreamingManifest> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Android.Exoplayer.Smoothstreaming.ISmoothStreamingTrackSelectorOutput p1 = (global::Com.Google.Android.Exoplayer.Smoothstreaming.ISmoothStreamingTrackSelectorOutput)global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Smoothstreaming.ISmoothStreamingTrackSelectorOutput> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SelectTracks (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_selectTracks_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingTrackSelector_Output_;
		public unsafe void SelectTracks (global::Com.Google.Android.Exoplayer.Smoothstreaming.SmoothStreamingManifest p0, global::Com.Google.Android.Exoplayer.Smoothstreaming.ISmoothStreamingTrackSelectorOutput p1)
		{
			if (id_selectTracks_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingTrackSelector_Output_ == IntPtr.Zero)
				id_selectTracks_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingTrackSelector_Output_ = JNIEnv.GetMethodID (class_ref, "selectTracks", "(Lcom/google/android/exoplayer/smoothstreaming/SmoothStreamingManifest;Lcom/google/android/exoplayer/smoothstreaming/SmoothStreamingTrackSelector$Output;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_selectTracks_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingManifest_Lcom_google_android_exoplayer_smoothstreaming_SmoothStreamingTrackSelector_Output_, __args);
		}

	}

}
