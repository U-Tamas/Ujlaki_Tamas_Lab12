using System;
using System.Collections.Generic;
using System.ComponentModel;
using Ujlaki_Tamas_Lab12.Models;
using Ujlaki_Tamas_Lab12.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ujlaki_Tamas_Lab12.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}