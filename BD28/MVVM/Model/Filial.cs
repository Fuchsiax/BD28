using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BD28.MVVM.Model
{
    [Table("Филиалы")]
    internal class Filial : INotifyPropertyChanged
    {
        [Key]
        public long Код_филиала { get; set; }

        public virtual ICollection<Filial> ComplaintsReverseNavigation { get; set; }

        private string name;

        public string Название
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Название");
            }
        }
        public Filial() { }
        public Filial(string name)
        {
            this.name = name;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
