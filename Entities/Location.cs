using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public int AccountId { get; set; }
        public double StartLat { get; set; }
        public double StartLng { get; set; }
        public double EndLat { get; set; }
        public double EndLng { get; set; }
        public double Distance { get; set; }
    }
}