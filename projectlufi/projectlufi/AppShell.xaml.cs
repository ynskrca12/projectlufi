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
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }
        async void Handle_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
        async void Handle_Click1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BosSepetPage());

        }
        async void Handle_Click2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SepetPage());
        }
    }
}