using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BD28.MVVM.Model
{
    [Table("Цены")]
    internal class Prices: INotifyPropertyChanged
    {
      


        public Prices() { }
        public Prices(string country, string city, string postAddress, string adress)
        {
            //this.country = country;
            //this.city = city;
            //this.postAddress = postAddress;
            //this.adress = adress;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
