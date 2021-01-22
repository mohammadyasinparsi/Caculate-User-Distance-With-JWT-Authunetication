using AutoMapper;
using Microsoft.Extensions.Options;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models.Accounts;
using GeoCoordinatePortable;
using System.Linq;
using System;
using System.Collections.Generic;
using WebApi.Models.Location;

namespace WebApi.Services
{
    public interface ILocationService
    {
        double Create(int accountId, SaveLocationAccount model);
        List<LocationResponse> GetAll(int accountId);
    }

    public class LocationService : ILocationService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly AppSettings _appSettings;

        public LocationService(
            DataContext context,
            IMapper mapper,
            IOptions<AppSettings> appSettings
            )
        {
            _context = context;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        public double Create(int accountId, SaveLocationAccount model)
        {

            var sCoord = new GeoCoordinate(model._startLat, model._startLng);
            var eCoord = new GeoCoordinate(model._endLat, model._endLng);

            // map model to new location object
            var location = _mapper.Map<Location>(model);
            location.Distance = sCoord.GetDistanceTo(eCoord);
            location.AccountId = accountId;
            // save location
            _context.Locations.Add(location);
            _context.SaveChanges();
            double Distance = location.Distance;
            return Distance;
        }
        public List<LocationResponse> GetAll(int accountId)
        {


            return _context.Locations.Where(w => w.AccountId == accountId).Select(s => new LocationResponse
            {
                _startLat = s.StartLat,
                _startLng = s.StartLng,
                _endLat = s.EndLat,
                _endLng = s.EndLng
            }).ToList();

        }

    }
}
