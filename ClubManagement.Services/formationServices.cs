using System;
using System.Collections.Generic;
using ClubManagement.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ClubManagement.Services
{
    public class formationServices : IFormationServices
    {
        private readonly DbContext _context = null;



        public formationServices(IOptions<DbSetting> settings)
        {
            _context = new DbContext(settings.Value);
        }
        public Formation AddFormation(Formation formation)
        {
            _context._formations.InsertOne(formation);
            return formation;
         
        }

        public List<Formation> GetListFormations()
        {
            var result = _context._formations.Find(Builders<Formation>.Filter.Empty).ToList();

            return result;
          //  throw new NotImplementedException();
        }
    }
   
   
}
