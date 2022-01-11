﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ujlaki_Tamas_Lab12.Models;
using Ujlaki_Tamas_Lab12.ViewModels;
using Ujlaki_Tamas_Lab12.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ujlaki_Tamas_Lab12.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}