using System;
using System.Collections.Generic;
using System.Text;
using XamV.ViewModels;

namespace XamV.ViewModels
{
    public class MainViewModel
    {
        #region viewModels
        public LoginViewModel Login 
        { 
            get; 
            set; 
        
        }
        #endregion

        #region Constrctores
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }
        #endregion

    }
}
