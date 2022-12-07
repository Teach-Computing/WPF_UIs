using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM.ViewModels
{
    public partial class MVVMBindingWindowVM : ObservableObject
    {
        [ObservableProperty]
        public int fontSize;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        public string firstName;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        public string lastName;

        public string FullName { 
            get { return $"{FirstName} {LastName}"; } 
        }

    }
}


