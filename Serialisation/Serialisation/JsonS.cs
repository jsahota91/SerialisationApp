using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialisation
{
    class JsonS
    {
        static readonly string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static void Main(string[] args)
        {
            //Create a trainee
            Trainee t1 = new Trainee { FirstName = "Cathy", LastName = "French", SpartaNo = 100 };
            //the file we get is not in human readable format. Can be found in Documents folder
            SerializeToFileJSON(t1);

            //Trainee t2 = DeserializeFromFileJSON("100 - Cathy French.json");
            Course eng83 = new Course { Title = "Engineering 83", Subject = "C# SDET", StartDate = new DateTime(2021, 3, 16) };
            eng83.AddTrainee(t1);
            eng83.AddTrainee(new Trainee { FirstName = "Martin", LastName = "Beard", SpartaNo = 101 });
            SerializeToFileJSON(eng83);

            Course otherCourse = DeserializeCourseFromFileJSON("NewCourse.json");
        }

        private static Trainee DeserializeFromFileJSON(string fileName)
        {
            //create the file path
            var filePath = $"{_path}/{fileName}";
            string jsonString = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Trainee>(jsonString);
        }

        private static Course DeserializeCourseFromFileJSON(string fileName)
        {
            //create the file path
            var filePath = $"{_path}/{fileName}";
            string jsonString = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Course>(jsonString);
        }

        private static void SerializeToFileJSON(Object o)
        {
            //create the file path
            var filePath = $"{_path}/{o}.json";
            string jsonString = JsonConvert.SerializeObject(o);
            File.WriteAllText(filePath, jsonString);
        }
    }
}
