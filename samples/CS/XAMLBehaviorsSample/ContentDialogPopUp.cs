﻿using Microsoft.Xaml.Interactivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.UI.Xaml;

namespace XAMLBehaviorsSample
{
    class ContentDialogPopUp : DependencyObject, IAction
    {
        ContentDialogSample samplecd;

        public object Execute(object sender, object parameter)
        {
            samplecd = new ContentDialogSample();
            ShowCD();
            return null;
        }

        public async void ShowCD()
        {
            await samplecd.ShowAsync();
        }
    }
}
