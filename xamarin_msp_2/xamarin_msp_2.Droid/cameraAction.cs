using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;
using xamarin_msp_2.Interface;
using xamarin_msp_2.Droid;

using Android.Content;


[assembly: Xamarin.Forms.Dependency(typeof(cameraAction))]
namespace xamarin_msp_2.Droid
{
    public class cameraAction : i_camera
    {
        void i_camera.captureImg()
        {
            var intent = new Android.Content.Intent(Android.Provider.MediaStore.ActionImageCapture);
            Forms.Context.StartActivity(intent);
        }
    }
}
