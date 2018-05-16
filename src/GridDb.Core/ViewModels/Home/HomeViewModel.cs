using System;
using System.Collections.Generic;
using System.Text;

namespace GridDb.Core.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
        private List<DemoData> _demoCollection;
        public List<DemoData> DemoCollection
        {
            get => _demoCollection;
            set => SetProperty(ref _demoCollection, value);
        }

        public HomeViewModel()
        {
            SetupDemoData();
        }

        private void SetupDemoData()
        {
            var collection = new List<DemoData>();
            var i = 1;
            while (i <= 10)
            {
                collection.Add(new DemoData() { Name = $"Demo {i}", Price = 2.25 * i });
                i += 1;
            }
            DemoCollection = collection;
        }
    }
}
