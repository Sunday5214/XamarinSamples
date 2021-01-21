using PageHandlingExample.Interfaces;
using PageHandlingExample.Pages.Authentication;
using PageHandlingExample.Pages.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PageHandlingExample.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RootPage : ContentPage, IPageContent
    {
        bool isCertifiedUser = false;
        public RootPage()
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
            if (isCertifiedUser)
            {
                MoveToOtherPage();
            }
            else
            {
                MoveToOtherPage(new AuthenticationPage());
            }
        }

        public async void MoveToOtherPage()
        {
           
            Navigation.InsertPageBefore(new MainPage(), this);
            await Navigation.PopToRootAsync();
        }

        public async void CompleteAuthentication()
        {
            isCertifiedUser = true;
            await ClearModal();
            MoveToOtherPage();
        }

        private async Task ClearModal()
        {
            await Navigation.PopModalAsync(false);
            await Task.Delay(1);
            await Navigation.PopModalAsync(false);
            await Task.Delay(1);
        }

        public async void MoveToOtherPage(IPageContent page)
        {
            await Navigation.PushModalAsync(page as Page);        
        }
    }
}