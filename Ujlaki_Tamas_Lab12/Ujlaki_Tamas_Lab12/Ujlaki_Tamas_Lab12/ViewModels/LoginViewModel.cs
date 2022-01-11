﻿using System;
using System.Collections.Generic;
using System.Text;
using Ujlaki_Tamas_Lab12.Views;
using Xamarin.Forms;

namespace Ujlaki_Tamas_Lab12.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
