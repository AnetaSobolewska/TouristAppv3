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
using Windows.Storage.FileProperties;
using TouristAppv2.Annotations;
using TouristAppv2.Model;

namespace TouristAppv2.ViewModel
{
    class GenericViewModel:INotifyPropertyChanged
    {
        
      
        public static PlaceModel ActualPlaceModel { get; set; }
       
        private string _selectedcategory = MainViewModel.SelectedCategory;


        public GenericViewModel()
        {
            XDocument xdoc = XDocument.Load(@"C:\Users\Pan Jakub\Desktop\TouristAppSOBOLGINA\TouristAppv2\Places.xml");
            XAttribute name = xdoc.Descendants("place").ElementAt(0).Attribute("name");
            if (_selectedcategory==name.Value)
            {
                PlaceName = name.Value;
                IEnumerable<XElement> description = xdoc.Descendants("place").ElementAt(0).Descendants("description");
            }




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
