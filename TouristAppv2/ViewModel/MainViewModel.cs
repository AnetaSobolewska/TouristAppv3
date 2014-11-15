using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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

        public static PlaceModel ActualPlaceModel { get; set; }
        private ObservableCollection<PlaceModel> _placesModels;
        private PlaceModel _vikingMuseum;
        private PlaceModel _roskildeCathedral;
        private PlaceModel _hotelPrindsen;
        private PlaceModel _hotelComwell;


        public PlaceModel RoskildeCathedral
        {
            get { return _roskildeCathedral; }
            set { _roskildeCathedral = value; }
        }

        public PlaceModel VikingMuseum
        {
            get { return _vikingMuseum; }
            set { _vikingMuseum = value; }
        }

        public PlaceModel HotelPrindsen
        {
            get { return _hotelPrindsen; }
            set { _hotelPrindsen = value; }
        }

        public PlaceModel HotelComwell
        {
            get { return _hotelComwell; }
            set { _hotelComwell = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

       


        public MainViewModel()
        {
            //adds Roskilde Wikipedia description to the Main Page
            RoskildeDescripton =
                "The city is ancient, dating from the Viking Age and is a member of the Most Ancient European Towns Network. \n Roskilde train station is a major stop between Copenhagen and the regions of Denmark located to its west. With a population of 48,721 ,the city is an economic centre for the region. Roskilde is the 10th largest city in Denmark.\n Roskilde has a pedestrian street running down the centre of the city, with many shops, restaurants, and cafes. Several tourist attractions draw visitors from around Denmark and the world.";
            MainImage = "/Assets/MainPage/MainPage_Roskilde.jpg";
            VikingImage = "/Assets/MainPage/VikinMuseum_ship.jpg";
            CathedralImage = "/Assets/MainPage/MainPage_RoskildeCathedral.jpg";
            HotelComwellImage = "/Assets/MainPage/comwellRoskilde_hotel.jpg";
            HotelPrindsenImage = "/Assets/MainPage/MainPage_HotelPrindsen.jpg";


           
           VikingMuseum=new PlaceModel();
            VikingMuseum.Adress = "VIKING MUSEUM\n Vindeboder 12\n DK-4000\n Roskilde Denmark";
            VikingMuseum.Name = "Viking Museum";
            VikingMuseum.ImageURL = "/Assets/GenericPage/VikinMuseum_Interior.jpg";
            VikingMuseum.Description = "The Viking Ship Museum in Roskilde is the Danish museum for ships, seafaring and boatbuilding culture in ancient and medieval times.\n The Viking Ship Hall, the oldest part of the museum, was opened in 1969. It was designed as a large showcase to display the five Viking ships found at Skuldelev. The hall also houses special temporary exhibitions and a cinema, where a film about the excavation of the ships is shown.\n An extension to the museum, Museum Island, was opened in 1997. The museum boatyard, where visitors can watch shipwrights at work, is located on the island. The Activity Centre, where the School Service is housed, is also found here.\n The large collection of traditional Nordic wooden boats is berthed at the harbour on Museum Island. Here you will also find the five reconstructions of the Skuldelev ships. Many of the vessels were built at the museum boatyard, which also maintains them.\n Together with other museums, the Viking Ship Museum carries out investigations before construction projects are commenced under water and along Denmark's coasts, or when the forces of nature uncover items of historical interest on the sea floor.\n Archaeological finds from throughout Denmark are documented at the Archaeological Workshop on Museum Island using digital technology, and information on all Danish maritime archaeological finds are collected in the museum archives.";
          
          RoskildeCathedral=new PlaceModel();
            RoskildeCathedral.Name = "Roskilde Cathedral";
            RoskildeCathedral.Description = "Roskilde Cathedral is inscribed on the UNESCO world heritage list. It is a unique and beautiful medieval cathedral. The Viking kings Harold Bluetooth (d. 985) and his son, Sweyn Forkbeard (d. 1014) conqueror of England is buried here. Almost 40 kings and queens of Denmark are buried here.\n For more than 1000 years there have been churches on the spot where the cathedral now stands. The first church on the site was built by Harold Bluetooth who died around 985 and, according to contemporary writings, is “buried in the town of Roskilde, in the church he himself built to the honour of the Holy Trinity”. Harold’s church was made of wood, and later it became the burial site for King Sweyn Forbeard. After having invaded, plundered and conquered England, Sweyn died in 1014. His corpse was brought to Roskilde by an English woman and buried by his family. In 1026 the church was the scene of a brutal murder when the king of England and Denmark, Canute the great murdered his brother in law. Canute was then forced pay penance to his sister Estrid, the daughter of Sweyn Forkbeard who used the money to build a new church of stone. Her son, Sweyn 2. was crowned as king of Denmark in 1047. Sweyn was born in England. In 1069 he joined forces with the last heir to the Anglo Saxon royal house. They invaded England, recently conquered by William the Conquerer in 1066. Sweyn conquered York, but failed in conquering England. Sweyn 2. and his mother Estrid is buried in Roskilde cathedral.\n In the 1170s the present brick church was started. It took 100 years to build and is one of the earliest examples of gothic architecture in Northern Europe. Over the centuries porches and royal burial chapels have been added. More than 40 kings and queens of Denmark are buried inside the church, making Roskilde Cathedral a world record holder in regards to royal church burials. The Cathedral was inscribed on the UNESCO World Heritage List in 1995.";
            RoskildeCathedral.Adress = "ROSKILDE CATHEDRAL\n Domkirkepladsen 3\n 4000 Roskilde \n Denmark";
            RoskildeCathedral.ImageURL = "/Assets/GenericPage/RoskildeCathedral.jpg";
            
            HotelPrindsen = new PlaceModel();
            HotelPrindsen.Name = "Hotel Prindsen";
            HotelPrindsen.Description = "Prindsen in Roskilde is one of the most beautiful and most historic hotels in Denmark which can be traced right back to 1695, when the first Hotel Prindsen was built, having been given the status of licensed inn in accordance with a statutory order issued by King Christian V.\n The architecture, as it appears today, is from 1875.\n At Prindsen in Roskilde they firmly believe that it is not only the surroundings but also, to an equal extent, the individual service and attention that make the difference between a pleasant and an unpleasant stay. They are convinced that the classic architecture and beautiful interior act as a stimulus to theirs guests’ expectations.";
            HotelPrindsen.Adress = "HOTEL PRINDSEN\n Algade 13\n 4000 Roskilde\n Denmark";
            HotelPrindsen.ImageURL = "/Assets/GenericPage/HotelPrindsen_restaurant.png";

            HotelComwell = new PlaceModel();
            HotelComwell.Name = "Hotel Comwell";
            HotelComwell.Description = "Comwell Roskilde is situated close to Roskilde Fjord and has a beautiful view of the water. The hotel is close to many different tourist attractions, such as The viking Ship Museum and Roskilde Cathedral.\n They offer the perfect settings for meetings, conferences, parties or perhaps a nice relaxing weekend stay.\n Being close to the woods and beach, gives you the opportunity to do several outdoor activities either on your own, or together with your meeting contestants.\n They offer many different facilities indoor as well- fitness center, restaurant, bar with an open fire, large terrace; where you can enjoy the beautiful sunset and also our private bar, where you can play Wii, billiards or table football.\n The food at Comwell Roskilde is nothing less than phenominal. Head Chef Rasmus Rasmussen won the title 'Best Conference Chef' in 2010.\n They have many different arrangements during the year- shellfish evening, gourmet evening or venison evening. Furthermore hotel restaurant is open every day, where you can enjoy a lovely meal.";
            HotelComwell.Adress = "Comwell Roskilde\n Vestre Kirkevej 12, HimmelevDK\n 4000 Roskilde\n Danmark";
            HotelComwell.ImageURL = "/Assets/GenericPage/ComwellRoskilde.jpg";


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
