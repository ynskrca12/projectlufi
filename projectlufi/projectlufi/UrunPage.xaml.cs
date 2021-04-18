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
    public partial class UrunPage : ContentPage
    {
        public UrunPage()
        {
            InitializeComponent();

            //var layout = new Grid
            //{
            //    RowSpacing = 10,
            //    ColumnSpacing = 10
            //};

            //var lbl1 = new Label { Text = "Row1 Column 1", BackgroundColor = Color.Aqua };
            //var lbl2 = new Label { Text = "Row1 Column 2", BackgroundColor = Color.Aqua };
            //var lbl3 = new Label { Text = "Row2 Column 1", BackgroundColor = Color.Aqua };
            //var lbl4 = new Label { Text = "Row2 Column 2", BackgroundColor = Color.Aqua };
            //var lbl5 = new Label { Text = "Row3 Column 1", BackgroundColor = Color.Aqua };

            //layout.Children.Add(lbl1, 0, 0);
            //layout.Children.Add(lbl2, 1, 0);
            //layout.Children.Add(lbl3, 0, 1);
            //layout.Children.Add(lbl4, 1, 1);
            //layout.Children.Add(lbl5, 0, 2);

            //Content = layout;
        }

        
    }
}