using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Android.Exoplayer.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil']"
	[global::Android.Runtime.Register ("com/google/android/exoplayer/util/NalUnitUtil", DoNotGenerateAcw=true)]
	public sealed partial class NalUnitUtil : global::Java.Lang.Object {


		static IntPtr ASPECT_RATIO_IDC_VALUES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil']/field[@name='ASPECT_RATIO_IDC_VALUES']"
		[Register ("ASPECT_RATIO_IDC_VALUES")]
		public static IList<float> AspectRatioIdcValues {
			get {
				if (ASPECT_RATIO_IDC_VALUES_jfieldId == IntPtr.Zero)
					ASPECT_RATIO_IDC_VALUES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ASPECT_RATIO_IDC_VALUES", "[F");
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, ASPECT_RATIO_IDC_VALUES_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil']/field[@name='EXTENDED_SAR']"
		[Register ("EXTENDED_SAR")]
		public const int ExtendedSar = (int) 255;

		static IntPtr NAL_START_CODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil']/field[@name='NAL_START_CODE']"
		[Register ("NAL_START_CODE")]
		public static IList<byte> NalStartCode {
			get {
				if (NAL_START_CODE_jfieldId == IntPtr.Zero)
					NAL_START_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NAL_START_CODE", "[B");
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, NAL_START_CODE_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil.PpsData']"
		[global::Android.Runtime.Register ("com/google/android/exoplayer/util/NalUnitUtil$PpsData", DoNotGenerateAcw=true)]
		public sealed partial class PpsData : global::Java.Lang.Object {


			static IntPtr bottomFieldPicOrderInFramePresentFlag_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil.PpsData']/field[@name='bottomFieldPicOrderInFramePresentFlag']"
			[Register ("bottomFieldPicOrderInFramePresentFlag")]
			public bool BottomFieldPicOrderInFramePresentFlag {
				get {
					if (bottomFieldPicOrderInFramePresentFlag_jfieldId == IntPtr.Zero)
						bottomFieldPicOrderInFramePresentFlag_jfieldId = JNIEnv.GetFieldID (class_ref, "bottomFieldPicOrderInFramePresentFlag", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, bottomFieldPicOrderInFramePresentFlag_jfieldId);
				}
				set {
					if (bottomFieldPicOrderInFramePresentFlag_jfieldId == IntPtr.Zero)
						bottomFieldPicOrderInFramePresentFlag_jfieldId = JNIEnv.GetFieldID (class_ref, "bottomFieldPicOrderInFramePresentFlag", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, bottomFieldPicOrderInFramePresentFlag_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr picParameterSetId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil.PpsData']/field[@name='picParameterSetId']"
			[Register ("picParameterSetId")]
			public int PicParameterSetId {
				get {
					if (picParameterSetId_jfieldId == IntPtr.Zero)
						picParameterSetId_jfieldId = JNIEnv.GetFieldID (class_ref, "picParameterSetId", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, picParameterSetId_jfieldId);
				}
				set {
					if (picParameterSetId_jfieldId == IntPtr.Zero)
						picParameterSetId_jfieldId = JNIEnv.GetFieldID (class_ref, "picParameterSetId", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, picParameterSetId_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr seqParameterSetId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil.PpsData']/field[@name='seqParameterSetId']"
			[Register ("seqParameterSetId")]
			public int SeqParameterSetId {
				get {
					if (seqParameterSetId_jfieldId == IntPtr.Zero)
						seqParameterSetId_jfieldId = JNIEnv.GetFieldID (class_ref, "seqParameterSetId", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, seqParameterSetId_jfieldId);
				}
				set {
					if (seqParameterSetId_jfieldId == IntPtr.Zero)
						seqParameterSetId_jfieldId = JNIEnv.GetFieldID (class_ref, "seqParameterSetId", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, seqParameterSetId_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/exoplayer/util/NalUnitUtil$PpsData", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PpsData); }
			}

			internal PpsData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_IIZ;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil.PpsData']/constructor[@name='NalUnitUtil.PpsData' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
			[Register (".ctor", "(IIZ)V", "")]
			public unsafe PpsData (int p0, int p1, bool p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					if (GetType () != typeof (PpsData)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIZ)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIZ)V", __args);
						return;
					}

					if (id_ctor_IIZ == IntPtr.Zero)
						id_ctor_IIZ = JNIEnv.GetMethodID (class_ref, "<init>", "(IIZ)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIZ, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIZ, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil.SpsData']"
		[global::Android.Runtime.Register ("com/google/android/exoplayer/util/NalUnitUtil$SpsData", DoNotGenerateAcw=true)]
		public sealed partial class SpsData : global::Java.Lang.Object {


			static IntPtr deltaPicOrderAlwaysZeroFlag_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil.SpsData']/field[@name='deltaPicOrderAlwaysZeroFlag']"
			[Register ("deltaPicOrderAlwaysZeroFlag")]
			public bool DeltaPicOrderAlwaysZeroFlag {
				get {
					if (deltaPicOrderAlwaysZeroFlag_jfieldId == IntPtr.Zero)
						deltaPicOrderAlwaysZeroFlag_jfieldId = JNIEnv.GetFieldID (class_ref, "deltaPicOrderAlwaysZeroFlag", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, deltaPicOrderAlwaysZeroFlag_jfieldId);
				}
				set {
					if (deltaPicOrderAlwaysZeroFlag_jfieldId == IntPtr.Zero)
						deltaPicOrderAlwaysZeroFlag_jfieldId = JNIEnv.GetFieldID (class_ref, "deltaPicOrderAlwaysZeroFlag", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, deltaPicOrderAlwaysZeroFlag_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr frameMbsOnlyFlag_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil.SpsData']/field[@name='frameMbsOnlyFlag']"
			[Register ("frameMbsOnlyFlag")]
			public bool FrameMbsOnlyFlag {
				get {
					if (frameMbsOnlyFlag_jfieldId == IntPtr.Zero)
						frameMbsOnlyFlag_jfieldId = JNIEnv.GetFieldID (class_ref, "frameMbsOnlyFlag", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, frameMbsOnlyFlag_jfieldId);
				}
				set {
					if (frameMbsOnlyFlag_jfieldId == IntPtr.Zero)
						frameMbsOnlyFlag_jfieldId = JNIEnv.GetFieldID (class_ref, "frameMbsOnlyFlag", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, frameMbsOnlyFlag_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr frameNumLength_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil.SpsData']/field[@name='frameNumLength']"
			[Register ("frameNumLength")]
			public int FrameNumLength {
				get {
					if (frameNumLength_jfieldId == IntPtr.Zero)
						frameNumLength_jfieldId = JNIEnv.GetFieldID (class_ref, "frameNumLength", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, frameNumLength_jfieldId);
				}
				set {
					if (frameNumLength_jfieldId == IntPtr.Zero)
						frameNumLength_jfieldId = JNIEnv.GetFieldID (class_ref, "frameNumLength", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, frameNumLength_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr height_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil.SpsData']/field[@name='height']"
			[Register ("height")]
			public int Height {
				get {
					if (height_jfieldId == IntPtr.Zero)
						height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, height_jfieldId);
				}
				set {
					if (height_jfieldId == IntPtr.Zero)
						height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, height_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr picOrderCntLsbLength_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil.SpsData']/field[@name='picOrderCntLsbLength']"
			[Register ("picOrderCntLsbLength")]
			public int PicOrderCntLsbLength {
				get {
					if (picOrderCntLsbLength_jfieldId == IntPtr.Zero)
						picOrderCntLsbLength_jfieldId = JNIEnv.GetFieldID (class_ref, "picOrderCntLsbLength", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, picOrderCntLsbLength_jfieldId);
				}
				set {
					if (picOrderCntLsbLength_jfieldId == IntPtr.Zero)
						picOrderCntLsbLength_jfieldId = JNIEnv.GetFieldID (class_ref, "picOrderCntLsbLength", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, picOrderCntLsbLength_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr picOrderCountType_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil.SpsData']/field[@name='picOrderCountType']"
			[Register ("picOrderCountType")]
			public int PicOrderCountType {
				get {
					if (picOrderCountType_jfieldId == IntPtr.Zero)
						picOrderCountType_jfieldId = JNIEnv.GetFieldID (class_ref, "picOrderCountType", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, picOrderCountType_jfieldId);
				}
				set {
					if (picOrderCountType_jfieldId == IntPtr.Zero)
						picOrderCountType_jfieldId = JNIEnv.GetFieldID (class_ref, "picOrderCountType", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, picOrderCountType_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr pixelWidthAspectRatio_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil.SpsData']/field[@name='pixelWidthAspectRatio']"
			[Register ("pixelWidthAspectRatio")]
			public float PixelWidthAspectRatio {
				get {
					if (pixelWidthAspectRatio_jfieldId == IntPtr.Zero)
						pixelWidthAspectRatio_jfieldId = JNIEnv.GetFieldID (class_ref, "pixelWidthAspectRatio", "F");
					return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, pixelWidthAspectRatio_jfieldId);
				}
				set {
					if (pixelWidthAspectRatio_jfieldId == IntPtr.Zero)
						pixelWidthAspectRatio_jfieldId = JNIEnv.GetFieldID (class_ref, "pixelWidthAspectRatio", "F");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, pixelWidthAspectRatio_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr separateColorPlaneFlag_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil.SpsData']/field[@name='separateColorPlaneFlag']"
			[Register ("separateColorPlaneFlag")]
			public bool SeparateColorPlaneFlag {
				get {
					if (separateColorPlaneFlag_jfieldId == IntPtr.Zero)
						separateColorPlaneFlag_jfieldId = JNIEnv.GetFieldID (class_ref, "separateColorPlaneFlag", "Z");
					return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, separateColorPlaneFlag_jfieldId);
				}
				set {
					if (separateColorPlaneFlag_jfieldId == IntPtr.Zero)
						separateColorPlaneFlag_jfieldId = JNIEnv.GetFieldID (class_ref, "separateColorPlaneFlag", "Z");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, separateColorPlaneFlag_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr seqParameterSetId_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil.SpsData']/field[@name='seqParameterSetId']"
			[Register ("seqParameterSetId")]
			public int SeqParameterSetId {
				get {
					if (seqParameterSetId_jfieldId == IntPtr.Zero)
						seqParameterSetId_jfieldId = JNIEnv.GetFieldID (class_ref, "seqParameterSetId", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, seqParameterSetId_jfieldId);
				}
				set {
					if (seqParameterSetId_jfieldId == IntPtr.Zero)
						seqParameterSetId_jfieldId = JNIEnv.GetFieldID (class_ref, "seqParameterSetId", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, seqParameterSetId_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr width_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil.SpsData']/field[@name='width']"
			[Register ("width")]
			public int Width {
				get {
					if (width_jfieldId == IntPtr.Zero)
						width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
					return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, width_jfieldId);
				}
				set {
					if (width_jfieldId == IntPtr.Zero)
						width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, width_jfieldId, value);
					} finally {
					}
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/android/exoplayer/util/NalUnitUtil$SpsData", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SpsData); }
			}

			internal SpsData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_IIIFZZIIIZ;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil.SpsData']/constructor[@name='NalUnitUtil.SpsData' and count(parameter)=10 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='float'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='boolean']]"
			[Register (".ctor", "(IIIFZZIIIZ)V", "")]
			public unsafe SpsData (int p0, int p1, int p2, float p3, bool p4, bool p5, int p6, int p7, int p8, bool p9)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [10];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					__args [5] = new JValue (p5);
					__args [6] = new JValue (p6);
					__args [7] = new JValue (p7);
					__args [8] = new JValue (p8);
					__args [9] = new JValue (p9);
					if (GetType () != typeof (SpsData)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(IIIFZZIIIZ)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(IIIFZZIIIZ)V", __args);
						return;
					}

					if (id_ctor_IIIFZZIIIZ == IntPtr.Zero)
						id_ctor_IIIFZZIIIZ = JNIEnv.GetMethodID (class_ref, "<init>", "(IIIFZZIIIZ)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IIIFZZIIIZ, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_IIIFZZIIIZ, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/android/exoplayer/util/NalUnitUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NalUnitUtil); }
		}

		internal NalUnitUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_clearPrefixFlags_arrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil']/method[@name='clearPrefixFlags' and count(parameter)=1 and parameter[1][@type='boolean[]']]"
		[Register ("clearPrefixFlags", "([Z)V", "")]
		public static unsafe void ClearPrefixFlags (bool[] p0)
		{
			if (id_clearPrefixFlags_arrayZ == IntPtr.Zero)
				id_clearPrefixFlags_arrayZ = JNIEnv.GetStaticMethodID (class_ref, "clearPrefixFlags", "([Z)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_clearPrefixFlags_arrayZ, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_discardToSps_Ljava_nio_ByteBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil']/method[@name='discardToSps' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("discardToSps", "(Ljava/nio/ByteBuffer;)V", "")]
		public static unsafe void DiscardToSps (global::Java.Nio.ByteBuffer p0)
		{
			if (id_discardToSps_Ljava_nio_ByteBuffer_ == IntPtr.Zero)
				id_discardToSps_Ljava_nio_ByteBuffer_ = JNIEnv.GetStaticMethodID (class_ref, "discardToSps", "(Ljava/nio/ByteBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_discardToSps_Ljava_nio_ByteBuffer_, __args);
			} finally {
			}
		}

		static IntPtr id_findNalUnit_arrayBIIarrayZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil']/method[@name='findNalUnit' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean[]']]"
		[Register ("findNalUnit", "([BII[Z)I", "")]
		public static unsafe int FindNalUnit (byte[] p0, int p1, int p2, bool[] p3)
		{
			if (id_findNalUnit_arrayBIIarrayZ == IntPtr.Zero)
				id_findNalUnit_arrayBIIarrayZ = JNIEnv.GetStaticMethodID (class_ref, "findNalUnit", "([BII[Z)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_findNalUnit_arrayBIIarrayZ, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_getH265NalUnitType_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil']/method[@name='getH265NalUnitType' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("getH265NalUnitType", "([BI)I", "")]
		public static unsafe int GetH265NalUnitType (byte[] p0, int p1)
		{
			if (id_getH265NalUnitType_arrayBI == IntPtr.Zero)
				id_getH265NalUnitType_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "getH265NalUnitType", "([BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getH265NalUnitType_arrayBI, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getNalUnitType_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil']/method[@name='getNalUnitType' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("getNalUnitType", "([BI)I", "")]
		public static unsafe int GetNalUnitType (byte[] p0, int p1)
		{
			if (id_getNalUnitType_arrayBI == IntPtr.Zero)
				id_getNalUnitType_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "getNalUnitType", "([BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getNalUnitType_arrayBI, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_parseChildNalUnit_Lcom_google_android_exoplayer_util_ParsableByteArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil']/method[@name='parseChildNalUnit' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer.util.ParsableByteArray']]"
		[Register ("parseChildNalUnit", "(Lcom/google/android/exoplayer/util/ParsableByteArray;)[B", "")]
		public static unsafe byte[] ParseChildNalUnit (global::Com.Google.Android.Exoplayer.Util.ParsableByteArray p0)
		{
			if (id_parseChildNalUnit_Lcom_google_android_exoplayer_util_ParsableByteArray_ == IntPtr.Zero)
				id_parseChildNalUnit_Lcom_google_android_exoplayer_util_ParsableByteArray_ = JNIEnv.GetStaticMethodID (class_ref, "parseChildNalUnit", "(Lcom/google/android/exoplayer/util/ParsableByteArray;)[B");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseChildNalUnit_Lcom_google_android_exoplayer_util_ParsableByteArray_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
			}
		}

		static IntPtr id_parsePpsNalUnit_Lcom_google_android_exoplayer_util_ParsableBitArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil']/method[@name='parsePpsNalUnit' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer.util.ParsableBitArray']]"
		[Register ("parsePpsNalUnit", "(Lcom/google/android/exoplayer/util/ParsableBitArray;)Lcom/google/android/exoplayer/util/NalUnitUtil$PpsData;", "")]
		public static unsafe global::Com.Google.Android.Exoplayer.Util.NalUnitUtil.PpsData ParsePpsNalUnit (global::Com.Google.Android.Exoplayer.Util.ParsableBitArray p0)
		{
			if (id_parsePpsNalUnit_Lcom_google_android_exoplayer_util_ParsableBitArray_ == IntPtr.Zero)
				id_parsePpsNalUnit_Lcom_google_android_exoplayer_util_ParsableBitArray_ = JNIEnv.GetStaticMethodID (class_ref, "parsePpsNalUnit", "(Lcom/google/android/exoplayer/util/ParsableBitArray;)Lcom/google/android/exoplayer/util/NalUnitUtil$PpsData;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Android.Exoplayer.Util.NalUnitUtil.PpsData __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Util.NalUnitUtil.PpsData> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parsePpsNalUnit_Lcom_google_android_exoplayer_util_ParsableBitArray_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_parseSpsNalUnit_Lcom_google_android_exoplayer_util_ParsableBitArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil']/method[@name='parseSpsNalUnit' and count(parameter)=1 and parameter[1][@type='com.google.android.exoplayer.util.ParsableBitArray']]"
		[Register ("parseSpsNalUnit", "(Lcom/google/android/exoplayer/util/ParsableBitArray;)Lcom/google/android/exoplayer/util/NalUnitUtil$SpsData;", "")]
		public static unsafe global::Com.Google.Android.Exoplayer.Util.NalUnitUtil.SpsData ParseSpsNalUnit (global::Com.Google.Android.Exoplayer.Util.ParsableBitArray p0)
		{
			if (id_parseSpsNalUnit_Lcom_google_android_exoplayer_util_ParsableBitArray_ == IntPtr.Zero)
				id_parseSpsNalUnit_Lcom_google_android_exoplayer_util_ParsableBitArray_ = JNIEnv.GetStaticMethodID (class_ref, "parseSpsNalUnit", "(Lcom/google/android/exoplayer/util/ParsableBitArray;)Lcom/google/android/exoplayer/util/NalUnitUtil$SpsData;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Android.Exoplayer.Util.NalUnitUtil.SpsData __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Android.Exoplayer.Util.NalUnitUtil.SpsData> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parseSpsNalUnit_Lcom_google_android_exoplayer_util_ParsableBitArray_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_unescapeStream_arrayBI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.android.exoplayer.util']/class[@name='NalUnitUtil']/method[@name='unescapeStream' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("unescapeStream", "([BI)I", "")]
		public static unsafe int UnescapeStream (byte[] p0, int p1)
		{
			if (id_unescapeStream_arrayBI == IntPtr.Zero)
				id_unescapeStream_arrayBI = JNIEnv.GetStaticMethodID (class_ref, "unescapeStream", "([BI)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_unescapeStream_arrayBI, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
