using projectlufi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projectlufi.Lists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModelBinding : ContentPage
    {
        public ModelBinding()
        {
            InitializeComponent();

            var urunler = new List<Urun>
            {
                new Urun {
                    
                    Ad="Gain Mont Lacivert",
                    Fiyat=559.99M,
                    IndirimsizFiyat=1399.99M,
                    ImageUrl="https://cdn.lufian.com/gain-mont-lacivert-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-mont-lufian-206364-40-K.jpg" },
                new Urun {
                    
                    Ad="Gain Mont Lacivert",
                    Fiyat=559.99M,
                    IndirimsizFiyat=1399.99M,
                    ImageUrl="https://cdn.lufian.com/gain-mont-lacivert-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-mont-lufian-206364-40-K.jpg" },
                new Urun {
                    
                    Ad="Gain Mont Lacivert",
                    Fiyat=559.99M,
                    IndirimsizFiyat=1399.99M,
                    ImageUrl="https://cdn.lufian.com/gain-mont-lacivert-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-mont-lufian-206364-40-K.jpg" },
                new Urun {
                   
                    Ad="Gain Mont Lacivert",
                    Fiyat=559.99M,
                    IndirimsizFiyat=1399.99M,
                    ImageUrl="https://cdn.lufian.com/gain-mont-lacivert-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-mont-lufian-206364-40-K.jpg" },
                new Urun {
                    
                    Ad="Gain Mont Lacivert",
                    Fiyat=559.99M,
                    IndirimsizFiyat=1399.99M,
                    ImageUrl="https://cdn.lufian.com/gain-mont-lacivert-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-mont-lufian-206364-40-K.jpg" },
            };
            listview.ItemsSource = urunler;
        }
    }
}