using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

namespace WebApi.Models.Location
{
    public class SaveLocationAccount
    {
        [Required]
        public double _startLat { get; set; }
        [Required]
        public double _startLng { get; set; }
        [Required]
        public double _endLat { get; set; }
        [Required]
        public double _endLng { get; set; }

        public double StartLat
        {
            get => _startLat;
            set => _startLat = 0;
        }

        public double StartLng
        {
            get => _startLng;
            set => _startLng = 0;
        }

        public double EndLat
        {
            get => _endLat;
            set => _endLat = 0;
        }

        public double EndLng
        {
            get => _endLng;
            set => _endLng = 0;
        }
    }
}
