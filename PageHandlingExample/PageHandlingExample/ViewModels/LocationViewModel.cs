using PageHandlingExample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace PageHandlingExample.ViewModels
{
    public class LocationViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<LocationSample> _locationSampleItems = new ObservableCollection<LocationSample>();
        public ObservableCollection<LocationSample> LocationSampleItems
        { 
            get=>_locationSampleItems; 
            set=> PropertyChanged(this, new PropertyChangedEventArgs(nameof(_locationSampleItems))); 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public LocationViewModel()
        {
            LocationSampleItems.Add(new LocationSample { Idx = 0, LocationName = "영등포" });
            LocationSampleItems.Add(new LocationSample { Idx = 1, LocationName = "선유도" });
            LocationSampleItems.Add(new LocationSample { Idx = 2, LocationName = "서울" });
            LocationSampleItems.Add(new LocationSample { Idx = 3, LocationName = "당산" });
            LocationSampleItems.Add(new LocationSample { Idx = 4, LocationName = "창원" });
            LocationSampleItems.Add(new LocationSample { Idx = 5, LocationName = "마산" });
            LocationSampleItems.Add(new LocationSample { Idx = 6, LocationName = "포항" });
        }
    }
}
