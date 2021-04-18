using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace projectlufi.Models
{
    public class Urun:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        

        private string _ad = "Harry Mont Siyah";
        public string Ad 
        {
            get 
            {
                return _ad;
            } 
            set
            {
                _ad = value;
                OnPropertyChanged(nameof(_ad));
            } }
        void OnPropertyChanged(string ad)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(ad));
        }
        private decimal _fiyat=519.99M;
        public decimal Fiyat
        {
            get
            {
                return _fiyat;
            }
            set
            {
                _fiyat = value;
                OnPropertyChanged(nameof(_fiyat));
            }
        }
        public decimal IndirimsizFiyat { get; set; }

        private string _imageUrl = "https://cdn.lufian.com/inka-kazak-acik-gri-modelini-incelemek-icin-hemen-tiklayin-erkek-giyim-modasinin-devi-lufianin-yeni-sezon-koleksiyonunu-kesfedin-kazak-lufian-216596-39-K.jpg";
        public string ImageUrl
        {
            get
            {
                return _imageUrl;
            }
            set
            {
                _imageUrl = value;
                OnPropertyChanged(nameof(_imageUrl));
            }
        }


    }
}
