using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace EducationClubs.Models
{
    public class Lesson
    {
        [BsonIgnoreIfDefault]
        public ObjectId _id;

        [BsonIgnoreIfDefault]
        public ObjectId AdditionalClassId { get; set; }
        [BsonIgnoreIfDefault]
        public DateTime? DateOfFinishing { get; set; }

        [BsonIgnoreIfDefault]
        public List<Student> ListOfStudents { get; set; }
    }
}
