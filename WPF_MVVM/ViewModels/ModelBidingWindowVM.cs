using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM.ViewModels
{
    class ModelBidingWindowVM
    {
        public int FontSize { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName { 
            get { return $"{FirstName} {LastName}"; } 
        }

        public ModelBidingWindowVM()
        {
            FontSize= 20;
            FirstName = "John";
            LastName = "Bear";
        }
    }
}
