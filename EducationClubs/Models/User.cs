using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EducationClubs.Models
{
    public class User
    {
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        
        [BsonIgnoreIfDefault]
        public String Username { get; set; }
        
        [BsonIgnoreIfDefault]
        public String Email { get; set; }

        [BsonIgnoreIfDefault]
        public String Password { get; set; }
        
        [BsonIgnoreIfDefault]
        public String? Image { get; set; }
    }
}