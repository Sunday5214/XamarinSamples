using PageHandlingExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PageHandlingExample.Pages.Authentication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthenticationCodePage : ContentPage, IPageContent
    {
        public AuthenticationCodePage()
        {
            InitializeComponent();
        }

        public IPageContent GetPageInstance()
        {
            throw new NotImplementedException();
        }

        public void InitPageAsync()
        {
            throw new NotImplementedException();
        }

        public void MoveToOtherPage(IPageContent page)
        {
           
        }

        public void MoveToOtherPage()
        {
            var rootPage = (Application.Current.MainPage as NavigationPage).RootPage as RootPage;
            rootPage.CompleteAuthentication();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            MoveToOtherPage();
        }
    }
}