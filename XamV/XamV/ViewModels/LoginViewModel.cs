using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;
using XamV.Views;

using System.ComponentModel;

namespace XamV.ViewModels
{
    

    public class LoginViewModel : BaseViewModel
    {
        #region Atributos
        private string Email { get; set; }
        private string Password { get; set; }
        private bool IsRunning { get; set; }
        private bool IsEnabled { get; set; }
        private bool IsRemember { get; set; }
        #endregion

        #region Prpiedades
        public string email
        {
            get { return this.Email; }
            set { Email = value;OnPropertyChanged(); }
        }
        public string password 
        {
            get { return this.Password; }
            set { Password = value;OnPropertyChanged(); }
        }
        public bool isRunnig 
        {
            get { return this.IsRunning; }
            set { IsRunning = value; OnPropertyChanged(); }
            
        }
        public bool isRemember { get; set; }
        public bool isEnabled 
        {
            get { return this.IsEnabled; }
            set { IsEnabled = value;OnPropertyChanged(); }
            
        }

        #endregion

        #region Comandos
        public ICommand loginComand 
        { get
            {
                return new RelayCommand(Login);
            }

            }

      

        private async void Login()
        {
            if(String.IsNullOrEmpty(this.email)){
                await Application.Current.MainPage.DisplayAlert("Error:", "ingrese un e-mail por favor", "ok");
                return;
            }

            if (String.IsNullOrEmpty(this.password))
            {
                await Application.Current.MainPage.DisplayAlert("Error:", "ingrese su contraseña", "ok");
                return;
            }

            if(this.email != "erick.alvear7@gmail.com" || this.password != "erick")
            {
                await Application.Current.MainPage.DisplayAlert("Error:", "e-mail o password incorrecto", "aceptar");
                this.password = string.Empty;
                this.email = string.Empty;
                return;
            }
            else
            {
                MainViewModel.GetInstance().Lands = new LandsViewModel();
                await Application.Current.MainPage.Navigation.PushAsync(new LandsPage());

            }


        }

        #endregion

        #region Constructor
        public LoginViewModel()
        {
            this.isRemember = false;
            this.isEnabled = true;
        }

        #endregion
    }
}
