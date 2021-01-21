using PageHandlingExample.Interfaces;
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
    public partial class WebViewPage : Grid, IPageContent
    {
        public WebViewPage()
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
        public void MoveToOtherPage()
        {
            throw new NotImplementedException();
        }

        public void MoveToOtherPage(IPageContent page)
        {
            throw new NotImplementedException();
        }
    }
}