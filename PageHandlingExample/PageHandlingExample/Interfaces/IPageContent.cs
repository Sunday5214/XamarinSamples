using System;
using System.Collections.Generic;
using System.Text;

namespace PageHandlingExample.Interfaces
{
    public interface IPageContent
    {
        IPageContent GetPageInstance();
        void InitPageAsync();
        void MoveToOtherPage(IPageContent page);
    }
}
