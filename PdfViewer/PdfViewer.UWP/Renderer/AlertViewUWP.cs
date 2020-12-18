#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using SampleBrowser.SfPdfViewer.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Xamarin.Forms;

[assembly: Dependency(typeof(AlertViewUWP))]
namespace SampleBrowser.SfPdfViewer.UWP
{
    class AlertViewUWP : IAlertView
    {
        public async void Show(string description)
        {
            MessageDialog dialog = new MessageDialog(description);
            await dialog.ShowAsync();
        }
    }
}
