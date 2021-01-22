using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

namespace WebApi.Models.Location
{
    public class LocationResponse
    {
        public double _startLat { get; set; }
        public double _startLng { get; set; }
        public double _endLat { get; set; }
        public double _endLng { get; set; }

    }
}
