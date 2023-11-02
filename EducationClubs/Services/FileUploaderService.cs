using System;
using System.Threading.Tasks;
using Firebase.Storage;
using Microsoft.AspNetCore.Components.Forms;

namespace EducationClubs.Services
{
    public class FileUploaderService
    {
        private const String STORE_CONNECTION = "flutterapp-63c02.appspot.com";
        private const String EDUCATION_CLUB = "EducationClub";
        public static async Task<string> GetImage(String folderName, String fileName)
        {
            var task = new FirebaseStorage(STORE_CONNECTION)
                .Child(EDUCATION_CLUB)
                .Child(folderName)
                .Child(fileName) // 
                .GetDownloadUrlAsync();

            try
            {
                return await task;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
        
        public static async Task Upload(String folderName, String fileName, IBrowserFile file)
        {
            try
            {
                var task = new FirebaseStorage(STORE_CONNECTION)
                    .Child(EDUCATION_CLUB)
                    .Child(folderName)
                    .Child(fileName)
                    .PutAsync(file.OpenReadStream());
        
                task.Progress.ProgressChanged += (s, e) => Console.WriteLine($"Progress: {e.Percentage} %");
            
                var downloadUrl = await task;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}