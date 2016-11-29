using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using xamarin_msp_2.Interface;
using Xamarin.Forms;

namespace xamarin_msp_2.Views
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            this.Title = "MainPage";
            Button testBtn = new Button();
            testBtn.Text = "test Btn";
            testBtn.Clicked += delegate
            {
                i_camera cameraAction;
                cameraAction = DependencyService.Get<i_camera>();
                cameraAction.captureImg();
            };


            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello Page" }, testBtn
                }
            };
        }
    }
}
