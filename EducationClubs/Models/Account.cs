using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EducationClubs.Models
{
    public class Account
    {
        [BsonIgnoreIfDefault]
        public ObjectId _id;

        [BsonIgnoreIfDefault]
        public String Login { get; set; }

        [BsonIgnoreIfDefault]
        public String Password { get; set; }
    }
}
