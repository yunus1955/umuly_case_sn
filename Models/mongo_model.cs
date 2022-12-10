using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace umuly_case_sn.Models
{
    public class mongo_model
    {

        [BsonId]     //it uses because object id is primary for ourdatabase
        public ObjectId Id { get; set; }


        [BsonElement("Sehir")]
        public string Sehir { get; set; }



        [BsonElement("Kargo")]
        public string Kargo { get; set; }


        [BsonElement("Hareket_tipi")]
        public string Hareket_tipi { get; set; }

        [BsonElement("Miktar")]
        public string Miktar { get; set; }

        [BsonElement("Ücret")]
        public string Ücret { get; set; }

        [BsonElement("Ödeme_türü")]
        public string Ödeme_türü { get; set; }

    }
}