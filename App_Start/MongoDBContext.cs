using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;  
using System.Configuration;
using MongoDB.Bson;

namespace umuly_case_sn.App_Start
{
    public class MongoDBContext
    {

        public IMongoDatabase database;

        public MongoDBContext()                     
        {
            var mongoClient = new MongoClient(ConfigurationManager.AppSettings["MongoDBHost"]);
            database = mongoClient.GetDatabase(ConfigurationManager.AppSettings["MongoDBName"]);
        }



    }
}