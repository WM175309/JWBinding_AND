using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='ExoPlayerLibraryInfo']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/ExoPlayerLibraryInfo", DoNotGenerateAcw=true)]
	public sealed partial class ExoPlayerLibraryInfo : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='ExoPlayerLibraryInfo']/field[@name='ASSERTIONS_ENABLED']"
		[Register ("ASSERTIONS_ENABLED")]
		public const bool AssertionsEnabled = (bool) true;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='ExoPlayerLibraryInfo']/field[@name='TRACE_ENABLED']"
		[Register ("TRACE_ENABLED")]
		public const bool TraceEnabled = (bool) true;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='ExoPlayerLibraryInfo']/field[@name='VERSION']"
		[Register ("VERSION")]
		public const string Version = (string) "1.5.7";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer']/class[@name='ExoPlayerLibraryInfo']/field[@name='VERSION_INT']"
		[Register ("VERSION_INT")]
		public const int VersionInt = (int) 264711;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/ExoPlayerLibraryInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExoPlayerLibraryInfo); }
		}

		internal ExoPlayerLibraryInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
