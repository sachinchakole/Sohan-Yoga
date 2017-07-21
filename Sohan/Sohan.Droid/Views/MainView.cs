﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;
using Sohan.Core.ViewModels;

namespace Sohan.Droid.Views
{
    [Activity(Label = "MainView")]
    public class MainView : BaseView<MainViewModel>//MvxActivity
    {
        protected override int LayoutResources => Resource.Layout.MainView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(LayoutResources);
        }
    }
}