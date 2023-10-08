using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EducationClubs.Models
{
    public class AdditionalClass
    {
        [BsonIgnoreIfDefault]
        public ObjectId _id;

        [BsonIgnoreIfDefault]
        public String Name { get; set; }

        [BsonIgnoreIfDefault]
        public ObjectId TutorId { get; set; }

        [BsonIgnoreIfDefault]
        public bool IsActive { get; set; }
    }
}
