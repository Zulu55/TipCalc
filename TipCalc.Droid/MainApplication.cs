namespace TipCalc.Droid
{
    using Android.App;
    using Android.Runtime;
    using Core;
    using MvvmCross.Platforms.Android.Core;
    using MvvmCross.Platforms.Android.Views;
    using System;

    [Application]
    public class MainApplication : MvxAndroidApplication<MvxAndroidSetup<App>, App>
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }
    }
}