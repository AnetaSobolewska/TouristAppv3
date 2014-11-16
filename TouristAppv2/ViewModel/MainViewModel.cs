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
    class MainViewModel:INotifyPropertyChanged
    {
       
        private string _roskildeDescripton;
        private string _mainImage;
        private string _vikingImage;
        private string _cathedralImage;
       private string _hotelComwellImage;
        private string _hotelPrindsenImage;
        private ObservableCollection<PlaceModel> Places; 
         public static string SelectedCategory { get; set; }
        // public string _selectedcategory = ActualPlaceModel.Name;

        //public string PlaceName
        //{
        //    get { return _selectedcategory; }
        //    set { _selectedcategory = value; }
        //}


        //public static PlaceModel ActualPlaceModel { get; set; }
        //private ObservableCollection<PlaceModel> _placesModels;
        //private PlaceModel _vikingMuseum;
        //private PlaceModel _roskildeCathedral;
        //private PlaceModel _hotelPrindsen;
        //private PlaceModel _hotelComwell;
        //private Dictionary<string, string> PlaceInfo;
        //private IEnumerable<XElement> Places;
        
       


        //public PlaceModel RoskildeCathedral
        //{
        //    get { return _roskildeCathedral; }
        //    set { _roskildeCathedral = value; }
        //}

        //public PlaceModel VikingMuseum
        //{
        //    get { return _vikingMuseum; }
        //    set { _vikingMuseum = value; }
        //}

        //public PlaceModel HotelPrindsen
        //{
        //    get { return _hotelPrindsen; }
        //    set { _hotelPrindsen = value; }
        //}

        //public PlaceModel HotelComwell
        //{
        //    get { return _hotelComwell; }
        //    set { _hotelComwell = value; }
        //}

        public event PropertyChangedEventHandler PropertyChanged;

       


        public MainViewModel()
        {
            Places=new ObservableCollection<PlaceModel>();
            XMLContainer xmlContainer=new XMLContainer();

            //adds Roskilde Wikipedia description to the Main Page
            RoskildeDescripton =
                "The city is ancient, dating from the Viking Age and is a member of the Most Ancient European Towns Network. \n Roskilde train station is a major stop between Copenhagen and the regions of Denmark located to its west. With a population of 48,721 ,the city is an economic centre for the region. Roskilde is the 10th largest city in Denmark.\n Roskilde has a pedestrian street running down the centre of the city, with many shops, restaurants, and cafes. Several tourist attractions draw visitors from around Denmark and the world.";
            MainImage = "/Assets/MainPage/MainPage_Roskilde.jpg";
            VikingImage = "/Assets/MainPage/VikinMuseum_ship.jpg";
            CathedralImage = "/Assets/MainPage/MainPage_RoskildeCathedral.jpg";
            HotelComwellImage = "/Assets/MainPage/comwellRoskilde_hotel.jpg";
            HotelPrindsenImage = "/Assets/MainPage/MainPage_HotelPrindsen.jpg";
        }


 
       
         public string RoskildeDescripton
        {
            get { return _roskildeDescripton; }
            set { _roskildeDescripton = value; }
        }

         public string MainImage
         {
             get { return _mainImage; }
             set { _mainImage = value; }
         }
         public string VikingImage
         {
             get { return _vikingImage; }
             set { _vikingImage = value; }
         }

 public string CathedralImage
        {
            get { return _cathedralImage; }
            set { _cathedralImage = value; }
        }
public string HotelComwellImage
        {
            get { return _hotelComwellImage; }
            set { _hotelComwellImage = value; }
        }

        public string HotelPrindsenImage
        {
            get { return _hotelPrindsenImage; }
            set { _hotelPrindsenImage = value; }
        }



        #region prop chsngrd
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion 
    }
}
