using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GridDb.Core
{
    public class DemoData : INotifyPropertyChanged, IEditableObject
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }

        private double _price;
        public double Price
        {
            get => _price;
            set
            {
                _price = value;
                RaisePropertyChanged("Price");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        public void BeginEdit()
        {
            // throw new NotImplementedException();
        }

        public void CancelEdit()
        {
            // throw new NotImplementedException();
        }

        public void EndEdit()
        {
            // throw new NotImplementedException();
        }
    }
}
