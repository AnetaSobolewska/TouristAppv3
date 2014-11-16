using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Windows.Storage;
using TouristAppv2.Model;
using TouristAppv2.View;
using TouristAppv2.ViewModel;

namespace TouristAppv2
{
    class XMLContainer
    {
       
        
       public string place = MainViewModel.SelectedCategory;
       
        public XMLContainer()
        {
            GetXML("Places");
        }

        private async void GetXML(string Places)
        {
            StorageFile placesFile = null;

            if(Places=="Places")
            {
                try
                {
                    placesFile = await ApplicationData.Current.LocalFolder.GetFileAsync("Places.xml");
                }
                catch (Exception)
                {
                    
                    
                }
                
            }
        }
    }
}
