using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Longtailvideo.Jwplayer.Cast {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/class[@name='CastStatusCodes']"
	[global::Android.Runtime.Register ("com/longtailvideo/jwplayer/cast/CastStatusCodes", DoNotGenerateAcw=true)]
	public partial class CastStatusCodes : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/class[@name='CastStatusCodes']/field[@name='APPLICATION_NOT_FOUND']"
		[Register ("APPLICATION_NOT_FOUND")]
		public const int ApplicationNotFound = (int) 2004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/class[@name='CastStatusCodes']/field[@name='APPLICATION_NOT_RUNNING']"
		[Register ("APPLICATION_NOT_RUNNING")]
		public const int ApplicationNotRunning = (int) 2005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/class[@name='CastStatusCodes']/field[@name='AUTHENTICATION_FAILED']"
		[Register ("AUTHENTICATION_FAILED")]
		public const int AuthenticationFailed = (int) 2000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/class[@name='CastStatusCodes']/field[@name='CANCELED']"
		[Register ("CANCELED")]
		public const int Canceled = (int) 2002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/class[@name='CastStatusCodes']/field[@name='ERROR_SERVICE_CREATION_FAILED']"
		[Register ("ERROR_SERVICE_CREATION_FAILED")]
		public const int ErrorServiceCreationFailed = (int) 2200;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/class[@name='CastStatusCodes']/field[@name='ERROR_SERVICE_DISCONNECTED']"
		[Register ("ERROR_SERVICE_DISCONNECTED")]
		public const int ErrorServiceDisconnected = (int) 2201;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/class[@name='CastStatusCodes']/field[@name='FAILED']"
		[Register ("FAILED")]
		public const int Failed = (int) 2100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/class[@name='CastStatusCodes']/field[@name='INTERNAL_ERROR']"
		[Register ("INTERNAL_ERROR")]
		public const int InternalError = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/class[@name='CastStatusCodes']/field[@name='INTERRUPTED']"
		[Register ("INTERRUPTED")]
		public const int Interrupted = (int) 14;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/class[@name='CastStatusCodes']/field[@name='INVALID_REQUEST']"
		[Register ("INVALID_REQUEST")]
		public const int InvalidRequest = (int) 2001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/class[@name='CastStatusCodes']/field[@name='MESSAGE_SEND_BUFFER_TOO_FULL']"
		[Register ("MESSAGE_SEND_BUFFER_TOO_FULL")]
		public const int MessageSendBufferTooFull = (int) 2007;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/class[@name='CastStatusCodes']/field[@name='MESSAGE_TOO_LARGE']"
		[Register ("MESSAGE_TOO_LARGE")]
		public const int MessageTooLarge = (int) 2006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/class[@name='CastStatusCodes']/field[@name='NETWORK_ERROR']"
		[Register ("NETWORK_ERROR")]
		public const int NetworkError = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/class[@name='CastStatusCodes']/field[@name='NOT_ALLOWED']"
		[Register ("NOT_ALLOWED")]
		public const int NotAllowed = (int) 2003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/class[@name='CastStatusCodes']/field[@name='REPLACED']"
		[Register ("REPLACED")]
		public const int Replaced = (int) 2103;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/class[@name='CastStatusCodes']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public const int Success = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/class[@name='CastStatusCodes']/field[@name='TIMEOUT']"
		[Register ("TIMEOUT")]
		public const int Timeout = (int) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/class[@name='CastStatusCodes']/field[@name='UNKNOWN_ERROR']"
		[Register ("UNKNOWN_ERROR")]
		public const int UnknownError = (int) 13;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/longtailvideo/jwplayer/cast/CastStatusCodes", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CastStatusCodes); }
		}

		protected CastStatusCodes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.longtailvideo.jwplayer.cast']/class[@name='CastStatusCodes']/constructor[@name='CastStatusCodes' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CastStatusCodes ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (CastStatusCodes)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
