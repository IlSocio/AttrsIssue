﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms.Labs.Mvvm;

using Xamarin.Forms;

namespace App1
{
    public class App
    {
        public static Page GetMainPage()
        {
            IXFormsApp dummy = null;
            return new ContentPage
            {
                Content = new Label
                {
                    Text = "Hello, Forms !",
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
            };
        }
    }
}
