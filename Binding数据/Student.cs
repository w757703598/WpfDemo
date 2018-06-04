using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Binding数据
{
    public class Student:INotifyPropertyChanged
    {
        private string name;
        public string Age { get; set; }
        public int Id { get; set; }
        public string Name
        {
            get { return name; }
            set { name = value;
                if (this.PropertyChanged != null)
                {
                    this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
                }

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
