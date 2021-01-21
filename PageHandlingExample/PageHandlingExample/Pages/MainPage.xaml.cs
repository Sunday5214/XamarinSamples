using PageHandlingExample.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PageHandlingExample.Pages
{
    public partial class MainPage : TabbedPage, IPageContent
    {
        public MainPage()
        {
            InitializeComponent();
            InitPageAsync();
        }

        public IPageContent GetPageInstance()
        {
            throw new NotImplementedException();
        }

        public void InitPageAsync()
        {

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
