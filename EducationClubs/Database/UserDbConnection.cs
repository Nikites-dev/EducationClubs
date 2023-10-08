using System;
using EducationClubs.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace EducationClubs.Database
{
    public class UserDbConnection
    {
        private readonly IMongoCollection<User> _users;

        public UserDbConnection(IOptions<DatabaseConnectionSettings> databaseConnectionSettings)
        {
            var mongoClient = new MongoClient(
                databaseConnectionSettings.Value.DefaultConnection);

            var mongoDatabase = mongoClient.GetDatabase(
                databaseConnectionSettings.Value.DbName);

            _users = mongoDatabase.GetCollection<User>(
                databaseConnectionSettings.Value.Users);
        }

        public User? isLoginUser { get; set; }
        public void AddToDatabase(User user)
        {
            _users.InsertOne(user);
        }
        
        
        public User GetUserByUsernamePassword(String username, String passwerd)
        {
            User user = _users.Find(x => x.Username  == username && x.Password == passwerd).FirstOrDefault();
            
            if (user == null)
            {
                return null;
            }
            return user;
        }
        
        public User GetUserByUsername(String username)
        {
            User user = _users.Find(x => x.Username == username).FirstOrDefault();
            
            if (user == null)
            {
                return null;
            }
            return user;
        }
        
        public bool ExistsUser(String username)
        {
            User user = _users.Find(x => x.Username  == username).FirstOrDefault();
            
            if (user == null)
            {
                return false;
            }
            return true;
        }
        
        public void UpdateUser(User user)
        {
            var b = _users.ReplaceOne(x => x.Username == user.Username, user).ModifiedCount > 0;
        }
    }
}