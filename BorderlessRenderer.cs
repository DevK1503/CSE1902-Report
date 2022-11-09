using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using MyFirstApp.customrenderer;
using MyFirstApp.Droid.renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BorderlessEntry), typeof(BorderlessRenderer))]

namespace MyFirstApp.Droid.renderers
{
    public class BorderlessRenderer:EntryRenderer
    {
        public BorderlessRenderer(Context context):base(context)
        {
             
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Android.Graphics.Color entryLineColor = Android.Graphics.Color.Transparent;
                Control.BackgroundTintList = ColorStateList.ValueOf(entryLineColor);

                
            }
        }
    }
}