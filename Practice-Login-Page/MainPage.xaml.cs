using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Edibubble
{
    public partial class MainPage : ContentPage
    {
        public ICommand ClickCommand => new Command<string>((url) =>
        {
            Browser.OpenAsync(new System.Uri(url), BrowserLaunchMode.SystemPreferred);
        });
        public MainPage()
        {

            InitializeComponent();
            BindingContext = this;
        }
    }
}
