using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectlufi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SepetPage : ContentPage
    {
        public SepetPage()
        {
            InitializeComponent();

            BindingContext = new Urun();
        }
    }
}