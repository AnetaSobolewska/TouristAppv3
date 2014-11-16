using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Windows.Data.Xml.Dom;
using Windows.Storage;
using Windows.Storage.FileProperties;
using TouristAppv2.Annotations;
using TouristAppv2.Model;

namespace TouristAppv2.ViewModel
{
    class GenericViewModel:INotifyPropertyChanged
    {
        
      
        public static PlaceModel ActualPlaceModel { get; set; }
       
        private string _selectedcategory = MainViewModel.SelectedCategory;
        private string _description;


        public GenericViewModel()
        {
            XDocument xdoc = XDocument.Load("Places.xml");
            XAttribute name = xdoc.Descendants("place").ElementAt(0).Attribute("name");
            if (_selectedcategory==name.Value)
            {
                PlaceName = name.Value;
                IEnumerable<XElement> descriptionofplace = xdoc.Descendants("place").ElementAt(0).Descendants("description");
                foreach (XElement descElement in descriptionofplace)
                {
                    Description = descElement.Value;
                }
               

            }
            



        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string PlaceName
        {
            get { return _selectedcategory; }
            set { _selectedcategory = value; }
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
