using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EducationClubs.Models
{
    public class Director
    {
        [BsonIgnoreIfDefault]
        public ObjectId _id;

        [BsonIgnoreIfDefault]
        public String Surname { get; set; }

        [BsonIgnoreIfDefault]
        public String Name { get; set; }

        [BsonIgnoreIfDefault]
        public String? Patronymic { get; set; }

        [BsonIgnoreIfDefault]
        public ObjectId LoginID { get; set; }

        [BsonIgnoreIfDefault]
        public bool IsWorking { get; set; }
    }
}
