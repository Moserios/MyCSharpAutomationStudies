using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interfases
{
    interface IPageObject
    {
        string PageName { get; }
    }

    class PageObjectOne : IPageObject
    {
     

        public string PageName => "Page Name 1";
     
    }

    class PageObjectTwo : IPageObject
    {
        

        public string PageName => "Page Name 2";
    
    }
}
