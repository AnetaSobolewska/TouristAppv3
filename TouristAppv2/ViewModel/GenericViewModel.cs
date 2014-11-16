using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TouristAppv2.Annotations;
using TouristAppv2.Model;

namespace TouristAppv2.ViewModel
{
    class GenericViewModel:INotifyPropertyChanged
    {
        
        private string Places;
        public static PlaceModel ActualPlaceModel { get; set; }
       
        public string _selectedcategory = MainViewModel.SelectedCategory;
        private Dictionary<string, string> _placeModels;

        public Dictionary<string, string> PlaceModels
        {
            get { return _placeModels; }
            set
            {
                _placeModels = value;
                OnPropertyChanged("PlaceModels");
                
            }
        }

        public GenericViewModel()
        {


            PlaceModels = new Dictionary<string, string>();

  
            LoadXML();

            PopulatePageInfo();


        }

        private void LoadXML()
        {
            XMLContainer xmlcontainer= new XMLContainer();
        }

        public string PlaceName
        {
            get { return _selectedcategory; }
            set { _selectedcategory = value; }
        }

        private void PopulatePageInfo()
        {
          Places=  XElement.Load("Assets/XML File/Places.xml");
            foreach (XElement place in Places)
            {
                PlaceModels["Name"] = place.Attribute("name").Value;
                PlaceModels["Description"] = place.Element("description").Value;
                PlaceModels["Adress"] = place.Element("adress").Value;
                PlaceModels["ImageUrl"] = place.Element("ImageURL").Value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
