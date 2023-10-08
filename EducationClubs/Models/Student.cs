using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace EducationClubs.Models
{
    public class Student
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
        public List<AdditionalClass> ListOfClasses { get; set; }
    }
}
