using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Droid.Support.V7.AppCompat;
using Android.Support.V7.Widget;
using MvvmCross.Core.ViewModels;

namespace Sohan.Droid.Views
{
    public abstract class BaseView : MvxAppCompatActivity
    {
        protected abstract int LayoutResources { get;}
        protected Toolbar Toolbar { get; set; }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(LayoutResources);
            Toolbar = FindViewById<Toolbar>(Resource.Layout.toolbar);
            if (Toolbar != null)
            {
                SetSupportActionBar(Toolbar);
                SupportActionBar.SetDisplayHomeAsUpEnabled(true);
                SupportActionBar.SetHomeButtonEnabled(true);
            }

        }
    }
   public abstract class BaseView<T>:MvxAppCompatActivity<T> where T:class,IMvxViewModel
    {
        protected abstract int LayoutResources { get; }

        protected Toolbar Toolbar { get; set; }
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(LayoutResources);
            Toolbar = FindViewById<Toolbar>(Resource.Layout.toolbar);
            if (Toolbar != null)
            {
                SetSupportActionBar(Toolbar);
                SupportActionBar.SetDisplayHomeAsUpEnabled(true);
                SupportActionBar.SetHomeButtonEnabled(true);
            }
        }
    }
}