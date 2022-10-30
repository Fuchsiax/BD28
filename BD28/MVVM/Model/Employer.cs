using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BD28.MVVM.Model
{
    [Table("Сотрудники")]
    internal class Employer : INotifyPropertyChanged
    {
        [Key]
        public long Код_сотрудника { get; set; }
        public long Код_филиала { get; set; }

        public virtual Filial RemarkNavigation { get; set; }


        private string name, surname, lastname;

        public string Имя
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Имя");
            }
        }
        public string Фамилия
        {
            get { return surname; }
            set
            {
                surname = value;
                OnPropertyChanged("Фамилия");
            }
        }
        public string Отчество
        {
            get { return lastname; }
            set
            {
                lastname = value;
                OnPropertyChanged("Отчество");
            }
        }

        public Employer() { }
        public Employer(string name, string surname, string lastname)
        {
            this.name = name;
            this.surname = surname;
            this.lastname = lastname;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
