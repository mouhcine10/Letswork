using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace letsworks.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapView : ContentPage
    {
        public async Task<List<Xamarin.Essentials.Placemark>> GetPlacemarck(double la, double log)
        {

            var place = await Xamarin.Essentials.Geocoding.GetPlacemarksAsync(la, log);


            return place.ToList();
        }
        public async Task<Xamarin.Essentials.Location> GetGeolocation()
        {


            var location = await Xamarin.Essentials.Geolocation.GetLastKnownLocationAsync();

            return location;
        }
        public MapView()
        {

            try
            {

                var location = Xamarin.Essentials.Geolocation.GetLastKnownLocationAsync();

                if (GetPlacemarck(GetGeolocation().Result.Latitude, GetGeolocation().Result.Longitude) != null)
                {

                    // var getitemsplace = place.Result.ToList()[0];
                    Pin pin = new Pin
                    {
                        Label = "",
                        Address = " ",
                        Type = PinType.Place,
                        Position = new Position(GetGeolocation().Result.Latitude, GetGeolocation().Result.Longitude)
                    };

                    Position position = new Position(location.Result.Latitude, location.Result.Longitude);
                    MapSpan mapSpan = new MapSpan(position, 0.01, 0.01);


                    Map map = new Map(mapSpan);
                    map.Pins.Add(pin);
                    Content = map;
                }
            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);

            }
        }
    }
}