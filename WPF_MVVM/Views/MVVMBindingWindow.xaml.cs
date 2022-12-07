using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF_MVVM.ViewModels;

namespace WPF_MVVM.Views
{
    /// <summary>
    /// Interaction logic for MVVMBindingWindow.xaml
    /// </summary>
    public partial class MVVMBindingWindow : Window
    {
        public MVVMBindingWindow()
        {
            DataContext = new MVVMBindingWindowVM();
            InitializeComponent();
        }
    }
}
