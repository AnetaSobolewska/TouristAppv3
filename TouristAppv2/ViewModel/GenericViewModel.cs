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
        private string _pic;
        private string _address;


        public GenericViewModel()
        {
            XDocument xdoc = XDocument.Load("Places.xml");
            XAttribute name = xdoc.Descendants("place").ElementAt(0).Attribute("name");
            XAttribute Cname = xdoc.Descendants("place").ElementAt(1).Attribute("name");
            XAttribute Comwellname = xdoc.Descendants("place").ElementAt(2).Attribute("name");
            XAttribute Prindsenname = xdoc.Descendants("place").ElementAt(3).Attribute("name");

            if (_selectedcategory==name.Value)
            {
                PlaceName = name.Value;
                IEnumerable<XElement> descriptionofplace = xdoc.Descendants("place").ElementAt(0).Descendants("description");

                foreach (XElement descElement in descriptionofplace)
                {
                    Description = descElement.Value;
                }
                IEnumerable<XElement> picofplace = xdoc.Descendants("place").ElementAt(0).Descendants("ImageURL");
                foreach (XElement picelement in picofplace)
                {
                    Pic = picelement.Value;
                }
                IEnumerable<XElement> addressElement = xdoc.Descendants("place").ElementAt(0).Descendants("address");
                foreach (XElement adress in addressElement)
                {
                    Address = adress.Value;
                }
               
            }
            
            if (_selectedcategory == Cname.Value)
                {
                    PlaceName = Cname.Value;
                    IEnumerable<XElement> cathedraldesc = xdoc.Descendants("place").ElementAt(1).Descendants("description");
                    foreach (XElement Celement in cathedraldesc)
                    {
                        Description = Celement.Value;
                    }
                    IEnumerable<XElement> picElements = xdoc.Descendants("place").ElementAt(1).Descendants("ImageURL");
                    foreach (XElement picElement in picElements)
                    {
                        Pic = picElement.Value;
                    } IEnumerable<XElement> addressElements = xdoc.Descendants("place").ElementAt(1).Descendants("addres");
                    foreach (XElement addresElement in addressElements)
                    {
                        Address = addresElement.Value;
                    }

                }

            if (_selectedcategory == Comwellname.Value)
            {
                PlaceName = Comwellname.Value;
                IEnumerable<XElement> comwellElements = xdoc.Descendants("place").ElementAt(2).Descendants("description");
                foreach (XElement comwellElement in comwellElements)
                {
                    Description = comwellElement.Value;
                }
                IEnumerable<XElement> comwellpicElements = xdoc.Descendants("place").ElementAt(2).Descendants("ImageURL");
                foreach (XElement comwellpicElement in comwellpicElements)
                {
                    Pic = comwellpicElement.Value;
                } IEnumerable<XElement> comwelladdressElements = xdoc.Descendants("place").ElementAt(2).Descendants("address");
                foreach (XElement comwelladdressElement in comwelladdressElements)
                {
                    Address = comwelladdressElement.Value;
                }

            }
            if (_selectedcategory == Prindsenname.Value)
            {
                PlaceName = Prindsenname.Value;
                IEnumerable<XElement> prindsebdescriptionElements = xdoc.Descendants("place").ElementAt(3).Descendants("description");
                foreach (XElement prindsendesciptionElement in prindsebdescriptionElements)
                {
                    Description = prindsendesciptionElement.Value;
                }
                IEnumerable<XElement> prindsenpicElements = xdoc.Descendants("place").ElementAt(3).Descendants("ImageURL");
                foreach (XElement prindsenpicElement in prindsenpicElements)
                {
                    Pic = prindsenpicElement.Value;
                } IEnumerable<XElement> prindsenaddressElements = xdoc.Descendants("place").ElementAt(3).Descendants("address");
                foreach (XElement prindsenaddressElement in prindsenaddressElements)
                {
                    Address =prindsenaddressElement.Value;
                }

            }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string Pic
        {
            get { return _pic; }
            set { _pic = value; }
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
