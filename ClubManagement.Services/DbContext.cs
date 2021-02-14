using System;
using System.Collections.Generic;
using System.Text;
using ClubManagement.Entities;
using MongoDB.Driver;
namespace ClubManagement.Services
{
   public class DbContext
    {
        public IMongoCollection<Formation> _formations;



        public DbContext(DbSetting settings)

        {
            //MongoClient = Reads the server instance for performing database operations. 
            //The constructor of this class is provided the MongoDB connection string
            MongoClient client = new MongoClient(settings.ConnectionString);



            //IMongoDatabase =Represents the Mongo database for performing operations. 
            IMongoDatabase _database = client.GetDatabase(settings.DatabaseName);



            //IMongoCollection = object representing the collection.
            _formations = _database.GetCollection<Formation>(settings.FormationCollectionName);
        }
    }
}
