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
    public partial class AuthenticationPage : ContentPage, IPageContent
    {
        public AuthenticationPage()
        {
            InitializeComponent();
            InitPageAsync();
        }

        public IPageContent GetPageInstance()
        {
            return this;
        }

        public void InitPageAsync()
        {
            // Some Code
        }

        public async void MoveToOtherPage()
        {
            await Navigation.PushModalAsync(new AuthenticationCodePage());
        }

        public void MoveToOtherPage(IPageContent page)
        {
            throw new NotImplementedException();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            MoveToOtherPage();
        }
    }
}