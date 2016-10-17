using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Ads.Interactivemedia.V3.Impl.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='TestingConfiguration']"
	[global::Android.Runtime.Register ("com/google/ads/interactivemedia/v3/impl/data/TestingConfiguration", DoNotGenerateAcw=true)]
	public abstract partial class TestingConfiguration : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='TestingConfiguration']/field[@name='PARAMETER_KEY']"
		[Register ("PARAMETER_KEY")]
		public const string ParameterKey = (string) "tcnfp";
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/interface[@name='TestingConfiguration.Builder']"
		[Register ("com/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder", "", "Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration/IBuilderInvoker")]
		public partial interface IBuilder : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/interface[@name='TestingConfiguration.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration;", "GetBuildHandler:Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration/IBuilderInvoker, JWBinding_AND")]
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration Build ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/interface[@name='TestingConfiguration.Builder']/method[@name='disableExperiments' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("disableExperiments", "(Z)Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder;", "GetDisableExperiments_ZHandler:Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration/IBuilderInvoker, JWBinding_AND")]
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder DisableExperiments (bool p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/interface[@name='TestingConfiguration.Builder']/method[@name='enableMonitorAppLifecycle' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("enableMonitorAppLifecycle", "(Z)Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder;", "GetEnableMonitorAppLifecycle_ZHandler:Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration/IBuilderInvoker, JWBinding_AND")]
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder EnableMonitorAppLifecycle (bool p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/interface[@name='TestingConfiguration.Builder']/method[@name='extraParams' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
			[Register ("extraParams", "(Ljava/util/Map;)Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder;", "GetExtraParams_Ljava_util_Map_Handler:Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration/IBuilderInvoker, JWBinding_AND")]
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder ExtraParams (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/interface[@name='TestingConfiguration.Builder']/method[@name='forceExperimentIds' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Long&gt;']]"
			[Register ("forceExperimentIds", "(Ljava/util/List;)Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder;", "GetForceExperimentIds_Ljava_util_List_Handler:Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration/IBuilderInvoker, JWBinding_AND")]
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder ForceExperimentIds (global::System.Collections.Generic.IList<global::Java.Lang.Long> p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/interface[@name='TestingConfiguration.Builder']/method[@name='forceTvMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("forceTvMode", "(Z)Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder;", "GetForceTvMode_ZHandler:Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration/IBuilderInvoker, JWBinding_AND")]
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder ForceTvMode (bool p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/interface[@name='TestingConfiguration.Builder']/method[@name='ignoreStrictModeFalsePositives' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("ignoreStrictModeFalsePositives", "(Z)Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder;", "GetIgnoreStrictModeFalsePositives_ZHandler:Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration/IBuilderInvoker, JWBinding_AND")]
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder IgnoreStrictModeFalsePositives (bool p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/interface[@name='TestingConfiguration.Builder']/method[@name='useTestStreamManager' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("useTestStreamManager", "(Z)Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder;", "GetUseTestStreamManager_ZHandler:Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration/IBuilderInvoker, JWBinding_AND")]
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder UseTestStreamManager (bool p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/interface[@name='TestingConfiguration.Builder']/method[@name='useVideoElementMock' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("useVideoElementMock", "(Z)Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder;", "GetUseVideoElementMock_ZHandler:Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration/IBuilderInvoker, JWBinding_AND")]
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder UseVideoElementMock (bool p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/interface[@name='TestingConfiguration.Builder']/method[@name='videoElementMockDuration' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("videoElementMockDuration", "(F)Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder;", "GetVideoElementMockDuration_FHandler:Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration/IBuilderInvoker, JWBinding_AND")]
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder VideoElementMockDuration (float p0);

		}

		[global::Android.Runtime.Register ("com/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder", DoNotGenerateAcw=true)]
		internal class IBuilderInvoker : global::Java.Lang.Object, IBuilder {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IBuilderInvoker); }
			}

			IntPtr class_ref;

			public static IBuilder GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBuilder> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.google.ads.interactivemedia.v3.impl.data.TestingConfiguration.Builder"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBuilderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			IntPtr id_build;
			public unsafe global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration Build ()
			{
				if (id_build == IntPtr.Zero)
					id_build = JNIEnv.GetMethodID (class_ref, "build", "()Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration;");
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_build), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_disableExperiments_Z;
#pragma warning disable 0169
			static Delegate GetDisableExperiments_ZHandler ()
			{
				if (cb_disableExperiments_Z == null)
					cb_disableExperiments_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_DisableExperiments_Z);
				return cb_disableExperiments_Z;
			}

			static IntPtr n_DisableExperiments_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.DisableExperiments (p0));
			}
#pragma warning restore 0169

			IntPtr id_disableExperiments_Z;
			public unsafe global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder DisableExperiments (bool p0)
			{
				if (id_disableExperiments_Z == IntPtr.Zero)
					id_disableExperiments_Z = JNIEnv.GetMethodID (class_ref, "disableExperiments", "(Z)Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_disableExperiments_Z, __args), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_enableMonitorAppLifecycle_Z;
#pragma warning disable 0169
			static Delegate GetEnableMonitorAppLifecycle_ZHandler ()
			{
				if (cb_enableMonitorAppLifecycle_Z == null)
					cb_enableMonitorAppLifecycle_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_EnableMonitorAppLifecycle_Z);
				return cb_enableMonitorAppLifecycle_Z;
			}

			static IntPtr n_EnableMonitorAppLifecycle_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.EnableMonitorAppLifecycle (p0));
			}
#pragma warning restore 0169

			IntPtr id_enableMonitorAppLifecycle_Z;
			public unsafe global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder EnableMonitorAppLifecycle (bool p0)
			{
				if (id_enableMonitorAppLifecycle_Z == IntPtr.Zero)
					id_enableMonitorAppLifecycle_Z = JNIEnv.GetMethodID (class_ref, "enableMonitorAppLifecycle", "(Z)Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_enableMonitorAppLifecycle_Z, __args), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_extraParams_Ljava_util_Map_;
#pragma warning disable 0169
			static Delegate GetExtraParams_Ljava_util_Map_Handler ()
			{
				if (cb_extraParams_Ljava_util_Map_ == null)
					cb_extraParams_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ExtraParams_Ljava_util_Map_);
				return cb_extraParams_Ljava_util_Map_;
			}

			static IntPtr n_ExtraParams_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExtraParams (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_extraParams_Ljava_util_Map_;
			public unsafe global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder ExtraParams (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
			{
				if (id_extraParams_Ljava_util_Map_ == IntPtr.Zero)
					id_extraParams_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "extraParams", "(Ljava/util/Map;)Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder;");
				IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extraParams_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_forceExperimentIds_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetForceExperimentIds_Ljava_util_List_Handler ()
			{
				if (cb_forceExperimentIds_Ljava_util_List_ == null)
					cb_forceExperimentIds_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ForceExperimentIds_Ljava_util_List_);
				return cb_forceExperimentIds_Ljava_util_List_;
			}

			static IntPtr n_ForceExperimentIds_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaList<global::Java.Lang.Long>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ForceExperimentIds (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_forceExperimentIds_Ljava_util_List_;
			public unsafe global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder ForceExperimentIds (global::System.Collections.Generic.IList<global::Java.Lang.Long> p0)
			{
				if (id_forceExperimentIds_Ljava_util_List_ == IntPtr.Zero)
					id_forceExperimentIds_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "forceExperimentIds", "(Ljava/util/List;)Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder;");
				IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Long>.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_forceExperimentIds_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

			static Delegate cb_forceTvMode_Z;
#pragma warning disable 0169
			static Delegate GetForceTvMode_ZHandler ()
			{
				if (cb_forceTvMode_Z == null)
					cb_forceTvMode_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_ForceTvMode_Z);
				return cb_forceTvMode_Z;
			}

			static IntPtr n_ForceTvMode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.ForceTvMode (p0));
			}
#pragma warning restore 0169

			IntPtr id_forceTvMode_Z;
			public unsafe global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder ForceTvMode (bool p0)
			{
				if (id_forceTvMode_Z == IntPtr.Zero)
					id_forceTvMode_Z = JNIEnv.GetMethodID (class_ref, "forceTvMode", "(Z)Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_forceTvMode_Z, __args), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_ignoreStrictModeFalsePositives_Z;
#pragma warning disable 0169
			static Delegate GetIgnoreStrictModeFalsePositives_ZHandler ()
			{
				if (cb_ignoreStrictModeFalsePositives_Z == null)
					cb_ignoreStrictModeFalsePositives_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_IgnoreStrictModeFalsePositives_Z);
				return cb_ignoreStrictModeFalsePositives_Z;
			}

			static IntPtr n_IgnoreStrictModeFalsePositives_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.IgnoreStrictModeFalsePositives (p0));
			}
#pragma warning restore 0169

			IntPtr id_ignoreStrictModeFalsePositives_Z;
			public unsafe global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder IgnoreStrictModeFalsePositives (bool p0)
			{
				if (id_ignoreStrictModeFalsePositives_Z == IntPtr.Zero)
					id_ignoreStrictModeFalsePositives_Z = JNIEnv.GetMethodID (class_ref, "ignoreStrictModeFalsePositives", "(Z)Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_ignoreStrictModeFalsePositives_Z, __args), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_useTestStreamManager_Z;
#pragma warning disable 0169
			static Delegate GetUseTestStreamManager_ZHandler ()
			{
				if (cb_useTestStreamManager_Z == null)
					cb_useTestStreamManager_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_UseTestStreamManager_Z);
				return cb_useTestStreamManager_Z;
			}

			static IntPtr n_UseTestStreamManager_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.UseTestStreamManager (p0));
			}
#pragma warning restore 0169

			IntPtr id_useTestStreamManager_Z;
			public unsafe global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder UseTestStreamManager (bool p0)
			{
				if (id_useTestStreamManager_Z == IntPtr.Zero)
					id_useTestStreamManager_Z = JNIEnv.GetMethodID (class_ref, "useTestStreamManager", "(Z)Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_useTestStreamManager_Z, __args), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_useVideoElementMock_Z;
#pragma warning disable 0169
			static Delegate GetUseVideoElementMock_ZHandler ()
			{
				if (cb_useVideoElementMock_Z == null)
					cb_useVideoElementMock_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_UseVideoElementMock_Z);
				return cb_useVideoElementMock_Z;
			}

			static IntPtr n_UseVideoElementMock_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.UseVideoElementMock (p0));
			}
#pragma warning restore 0169

			IntPtr id_useVideoElementMock_Z;
			public unsafe global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder UseVideoElementMock (bool p0)
			{
				if (id_useVideoElementMock_Z == IntPtr.Zero)
					id_useVideoElementMock_Z = JNIEnv.GetMethodID (class_ref, "useVideoElementMock", "(Z)Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_useVideoElementMock_Z, __args), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_videoElementMockDuration_F;
#pragma warning disable 0169
			static Delegate GetVideoElementMockDuration_FHandler ()
			{
				if (cb_videoElementMockDuration_F == null)
					cb_videoElementMockDuration_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_VideoElementMockDuration_F);
				return cb_videoElementMockDuration_F;
			}

			static IntPtr n_VideoElementMockDuration_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.VideoElementMockDuration (p0));
			}
#pragma warning restore 0169

			IntPtr id_videoElementMockDuration_F;
			public unsafe global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder VideoElementMockDuration (float p0)
			{
				if (id_videoElementMockDuration_F == IntPtr.Zero)
					id_videoElementMockDuration_F = JNIEnv.GetMethodID (class_ref, "videoElementMockDuration", "(F)Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_videoElementMockDuration_F, __args), JniHandleOwnership.TransferLocalRef);
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/ads/interactivemedia/v3/impl/data/TestingConfiguration", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TestingConfiguration); }
		}

		protected TestingConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_builder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='TestingConfiguration']/method[@name='builder' and count(parameter)=0]"
		[Register ("builder", "()Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder;", "")]
		public static unsafe global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder Builder ()
		{
			if (id_builder == IntPtr.Zero)
				id_builder = JNIEnv.GetStaticMethodID (class_ref, "builder", "()Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder> (JNIEnv.CallStaticObjectMethod  (class_ref, id_builder), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_copy;
#pragma warning disable 0169
		static Delegate GetCopyHandler ()
		{
			if (cb_copy == null)
				cb_copy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Copy);
			return cb_copy;
		}

		static IntPtr n_Copy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Copy ());
		}
#pragma warning restore 0169

		static IntPtr id_copy;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='TestingConfiguration']/method[@name='copy' and count(parameter)=0]"
		[Register ("copy", "()Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder;", "GetCopyHandler")]
		public virtual unsafe global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder Copy ()
		{
			if (id_copy == IntPtr.Zero)
				id_copy = JNIEnv.GetMethodID (class_ref, "copy", "()Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_copy), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration.IBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "copy", "()Lcom/google/ads/interactivemedia/v3/impl/data/TestingConfiguration$Builder;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_disableExperiments;
#pragma warning disable 0169
		static Delegate GetDisableExperimentsHandler ()
		{
			if (cb_disableExperiments == null)
				cb_disableExperiments = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_DisableExperiments);
			return cb_disableExperiments;
		}

		static bool n_DisableExperiments (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisableExperiments ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='TestingConfiguration']/method[@name='disableExperiments' and count(parameter)=0]"
		[Register ("disableExperiments", "()Z", "GetDisableExperimentsHandler")]
		public abstract bool DisableExperiments ();

		static Delegate cb_enableMonitorAppLifecycle;
#pragma warning disable 0169
		static Delegate GetEnableMonitorAppLifecycleHandler ()
		{
			if (cb_enableMonitorAppLifecycle == null)
				cb_enableMonitorAppLifecycle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_EnableMonitorAppLifecycle);
			return cb_enableMonitorAppLifecycle;
		}

		static bool n_EnableMonitorAppLifecycle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnableMonitorAppLifecycle ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='TestingConfiguration']/method[@name='enableMonitorAppLifecycle' and count(parameter)=0]"
		[Register ("enableMonitorAppLifecycle", "()Z", "GetEnableMonitorAppLifecycleHandler")]
		public abstract bool EnableMonitorAppLifecycle ();

		static Delegate cb_extraParams;
#pragma warning disable 0169
		static Delegate GetExtraParamsHandler ()
		{
			if (cb_extraParams == null)
				cb_extraParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ExtraParams);
			return cb_extraParams;
		}

		static IntPtr n_ExtraParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.ExtraParams ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='TestingConfiguration']/method[@name='extraParams' and count(parameter)=0]"
		[Register ("extraParams", "()Ljava/util/Map;", "GetExtraParamsHandler")]
		public abstract global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> ExtraParams ();

		static Delegate cb_forceExperimentIds;
#pragma warning disable 0169
		static Delegate GetForceExperimentIdsHandler ()
		{
			if (cb_forceExperimentIds == null)
				cb_forceExperimentIds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ForceExperimentIds);
			return cb_forceExperimentIds;
		}

		static IntPtr n_ForceExperimentIds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Long>.ToLocalJniHandle (__this.ForceExperimentIds ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='TestingConfiguration']/method[@name='forceExperimentIds' and count(parameter)=0]"
		[Register ("forceExperimentIds", "()Ljava/util/List;", "GetForceExperimentIdsHandler")]
		public abstract global::System.Collections.Generic.IList<global::Java.Lang.Long> ForceExperimentIds ();

		static Delegate cb_forceTvMode;
#pragma warning disable 0169
		static Delegate GetForceTvModeHandler ()
		{
			if (cb_forceTvMode == null)
				cb_forceTvMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ForceTvMode);
			return cb_forceTvMode;
		}

		static bool n_ForceTvMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ForceTvMode ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='TestingConfiguration']/method[@name='forceTvMode' and count(parameter)=0]"
		[Register ("forceTvMode", "()Z", "GetForceTvModeHandler")]
		public abstract bool ForceTvMode ();

		static Delegate cb_ignoreStrictModeFalsePositives;
#pragma warning disable 0169
		static Delegate GetIgnoreStrictModeFalsePositivesHandler ()
		{
			if (cb_ignoreStrictModeFalsePositives == null)
				cb_ignoreStrictModeFalsePositives = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IgnoreStrictModeFalsePositives);
			return cb_ignoreStrictModeFalsePositives;
		}

		static bool n_IgnoreStrictModeFalsePositives (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IgnoreStrictModeFalsePositives ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='TestingConfiguration']/method[@name='ignoreStrictModeFalsePositives' and count(parameter)=0]"
		[Register ("ignoreStrictModeFalsePositives", "()Z", "GetIgnoreStrictModeFalsePositivesHandler")]
		public abstract bool IgnoreStrictModeFalsePositives ();

		static Delegate cb_useTestStreamManager;
#pragma warning disable 0169
		static Delegate GetUseTestStreamManagerHandler ()
		{
			if (cb_useTestStreamManager == null)
				cb_useTestStreamManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UseTestStreamManager);
			return cb_useTestStreamManager;
		}

		static bool n_UseTestStreamManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseTestStreamManager ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='TestingConfiguration']/method[@name='useTestStreamManager' and count(parameter)=0]"
		[Register ("useTestStreamManager", "()Z", "GetUseTestStreamManagerHandler")]
		public abstract bool UseTestStreamManager ();

		static Delegate cb_useVideoElementMock;
#pragma warning disable 0169
		static Delegate GetUseVideoElementMockHandler ()
		{
			if (cb_useVideoElementMock == null)
				cb_useVideoElementMock = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_UseVideoElementMock);
			return cb_useVideoElementMock;
		}

		static bool n_UseVideoElementMock (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseVideoElementMock ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='TestingConfiguration']/method[@name='useVideoElementMock' and count(parameter)=0]"
		[Register ("useVideoElementMock", "()Z", "GetUseVideoElementMockHandler")]
		public abstract bool UseVideoElementMock ();

		static Delegate cb_videoElementMockDuration;
#pragma warning disable 0169
		static Delegate GetVideoElementMockDurationHandler ()
		{
			if (cb_videoElementMockDuration == null)
				cb_videoElementMockDuration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_VideoElementMockDuration);
			return cb_videoElementMockDuration;
		}

		static float n_VideoElementMockDuration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration __this = global::Java.Lang.Object.GetObject<global::Com.Google.Ads.Interactivemedia.V3.Impl.Data.TestingConfiguration> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoElementMockDuration ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='TestingConfiguration']/method[@name='videoElementMockDuration' and count(parameter)=0]"
		[Register ("videoElementMockDuration", "()F", "GetVideoElementMockDurationHandler")]
		public abstract float VideoElementMockDuration ();

	}

	[global::Android.Runtime.Register ("com/google/ads/interactivemedia/v3/impl/data/TestingConfiguration", DoNotGenerateAcw=true)]
	internal partial class TestingConfigurationInvoker : TestingConfiguration {

		public TestingConfigurationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (TestingConfigurationInvoker); }
		}

		static IntPtr id_disableExperiments;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='TestingConfiguration']/method[@name='disableExperiments' and count(parameter)=0]"
		[Register ("disableExperiments", "()Z", "GetDisableExperimentsHandler")]
		public override unsafe bool DisableExperiments ()
		{
			if (id_disableExperiments == IntPtr.Zero)
				id_disableExperiments = JNIEnv.GetMethodID (class_ref, "disableExperiments", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_disableExperiments);
			} finally {
			}
		}

		static IntPtr id_enableMonitorAppLifecycle;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='TestingConfiguration']/method[@name='enableMonitorAppLifecycle' and count(parameter)=0]"
		[Register ("enableMonitorAppLifecycle", "()Z", "GetEnableMonitorAppLifecycleHandler")]
		public override unsafe bool EnableMonitorAppLifecycle ()
		{
			if (id_enableMonitorAppLifecycle == IntPtr.Zero)
				id_enableMonitorAppLifecycle = JNIEnv.GetMethodID (class_ref, "enableMonitorAppLifecycle", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_enableMonitorAppLifecycle);
			} finally {
			}
		}

		static IntPtr id_extraParams;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='TestingConfiguration']/method[@name='extraParams' and count(parameter)=0]"
		[Register ("extraParams", "()Ljava/util/Map;", "GetExtraParamsHandler")]
		public override unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> ExtraParams ()
		{
			if (id_extraParams == IntPtr.Zero)
				id_extraParams = JNIEnv.GetMethodID (class_ref, "extraParams", "()Ljava/util/Map;");
			try {
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extraParams), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_forceExperimentIds;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='TestingConfiguration']/method[@name='forceExperimentIds' and count(parameter)=0]"
		[Register ("forceExperimentIds", "()Ljava/util/List;", "GetForceExperimentIdsHandler")]
		public override unsafe global::System.Collections.Generic.IList<global::Java.Lang.Long> ForceExperimentIds ()
		{
			if (id_forceExperimentIds == IntPtr.Zero)
				id_forceExperimentIds = JNIEnv.GetMethodID (class_ref, "forceExperimentIds", "()Ljava/util/List;");
			try {
				return global::Android.Runtime.JavaList<global::Java.Lang.Long>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_forceExperimentIds), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_forceTvMode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='TestingConfiguration']/method[@name='forceTvMode' and count(parameter)=0]"
		[Register ("forceTvMode", "()Z", "GetForceTvModeHandler")]
		public override unsafe bool ForceTvMode ()
		{
			if (id_forceTvMode == IntPtr.Zero)
				id_forceTvMode = JNIEnv.GetMethodID (class_ref, "forceTvMode", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_forceTvMode);
			} finally {
			}
		}

		static IntPtr id_ignoreStrictModeFalsePositives;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='TestingConfiguration']/method[@name='ignoreStrictModeFalsePositives' and count(parameter)=0]"
		[Register ("ignoreStrictModeFalsePositives", "()Z", "GetIgnoreStrictModeFalsePositivesHandler")]
		public override unsafe bool IgnoreStrictModeFalsePositives ()
		{
			if (id_ignoreStrictModeFalsePositives == IntPtr.Zero)
				id_ignoreStrictModeFalsePositives = JNIEnv.GetMethodID (class_ref, "ignoreStrictModeFalsePositives", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_ignoreStrictModeFalsePositives);
			} finally {
			}
		}

		static IntPtr id_useTestStreamManager;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='TestingConfiguration']/method[@name='useTestStreamManager' and count(parameter)=0]"
		[Register ("useTestStreamManager", "()Z", "GetUseTestStreamManagerHandler")]
		public override unsafe bool UseTestStreamManager ()
		{
			if (id_useTestStreamManager == IntPtr.Zero)
				id_useTestStreamManager = JNIEnv.GetMethodID (class_ref, "useTestStreamManager", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_useTestStreamManager);
			} finally {
			}
		}

		static IntPtr id_useVideoElementMock;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='TestingConfiguration']/method[@name='useVideoElementMock' and count(parameter)=0]"
		[Register ("useVideoElementMock", "()Z", "GetUseVideoElementMockHandler")]
		public override unsafe bool UseVideoElementMock ()
		{
			if (id_useVideoElementMock == IntPtr.Zero)
				id_useVideoElementMock = JNIEnv.GetMethodID (class_ref, "useVideoElementMock", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_useVideoElementMock);
			} finally {
			}
		}

		static IntPtr id_videoElementMockDuration;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.ads.interactivemedia.v3.impl.data']/class[@name='TestingConfiguration']/method[@name='videoElementMockDuration' and count(parameter)=0]"
		[Register ("videoElementMockDuration", "()F", "GetVideoElementMockDurationHandler")]
		public override unsafe float VideoElementMockDuration ()
		{
			if (id_videoElementMockDuration == IntPtr.Zero)
				id_videoElementMockDuration = JNIEnv.GetMethodID (class_ref, "videoElementMockDuration", "()F");
			try {
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_videoElementMockDuration);
			} finally {
			}
		}

	}

}
