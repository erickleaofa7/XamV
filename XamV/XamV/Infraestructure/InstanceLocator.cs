using System;
using System.Collections.Generic;
using System.Text;
using XamV.ViewModels;

namespace XamV.Infraestructure
{
   
    public class InstanceLocator
    {

        #region propiety
        public MainViewModel Main 
        { 
            get; set; 
        }

        #endregion

        #region constructor
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
