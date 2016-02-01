﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carubbi.ExtendedWebBrowser
{
    public interface IWindowManager
    {
        /// <summary>
        /// Closes the active tab
        /// </summary>
        void Close(int index);
        

        /// <summary>
        /// Opens a new browser tab, and navigates to the home page
        /// </summary>
        /// <returns>The instance of the browser created</returns>
        ExtendedWebBrowser New(string title);


        ExtendedWebBrowser New(bool navigateHome, string title);
      
        void Open(Uri url);

        void SetTitleName(int tabIndex, string title);

        string GetTitleName(int tabIndex);

        event EventHandler<TextChangedEventArgs> StatusTextChanged;

        void ChangeActiveBrowser(int index);
       

        ExtendedWebBrowser ActiveBrowser {get; }
       

        event EventHandler<CommandStateEventArgs> CommandStateChanged;

        ExtendedWebBrowser this[int index]
        {
            get;
        }

        int LastTabIndex
        {
            get;
        }

        void CloseAllTabs();
       
    }
}
