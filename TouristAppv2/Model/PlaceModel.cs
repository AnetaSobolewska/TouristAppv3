using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAppv2.Model
{
    class PlaceModel
    {
        private string _adress;
        private string _name;
        private string _description;
        private string _imageUrl;

        public string ImageURL
        {
            get { return _imageUrl; }
            set { _imageUrl = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
