using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UberClone.Models;

namespace letsworks.Services
{
    interface IMethodesL
    {
        

               

            Task<GoogleDirection> GetDirections(string originLatitude, string originLongitude, string destinationLatitude, string destinationLongitude);
            Task<GooglePlaceAutoCompleteResult> GetPlaces(string text);
            Task<GooglePlace> GetPlaceDetails(string placeId);
        
    }
}
