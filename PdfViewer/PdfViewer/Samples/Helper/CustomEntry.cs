#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace SampleBrowser.SfPdfViewer
{
    [Preserve(AllMembers = true)]
    public class CustomEntry : Entry
    {
        public Syncfusion.SfPdfViewer.XForms.SfPdfViewer PdfViewer
        {
            get;
            set;
        }

        public bool IsPageNumberEntry
        {
            get; set;
        }

        public CustomEntry()
        {
        }
    }
}
