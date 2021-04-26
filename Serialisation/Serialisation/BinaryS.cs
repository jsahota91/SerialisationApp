//using System;
//using System.IO;
//using System.Runtime.Serialization.Formatters.Binary;

//namespace Serialisation
//{
//    class BinaryS
//    {
//        static readonly string _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
//        static void Main(string[] args)
//        {
//            //Create a trainee
//            Trainee t1 = new Trainee { FirstName = "Cathy", LastName = "French", SpartaNo = 100 };
//            //the file we get is not in human readable format. Can be found in Documents folder
//            SerializeToFileBinary(t1);

//            Trainee t2 = DeserializeFromFileBinary("BinaryTrainee.bin");
//        }

//        private static Trainee DeserializeFromFileBinary(string fileName)
//        {
//            //create the file path
//            var filePath = $"{_path}/{fileName}";
//            //create a Stream object for reading
//            Stream file = File.OpenRead(filePath);
//            //create the BinaryFormatter and use it to read the file.
//            BinaryFormatter reader = new BinaryFormatter();
//            var trainee = (Trainee)reader.Deserialize(file);
//            file.Close();
//            return trainee;
//        }

//        private static void SerializeToFileBinary(Object o)
//        {
//            //create the file path
//            var filePath = $"{_path}/BinaryTrainee.bin";
//            //create a filestream object
//            FileStream file = File.Create(filePath);
//            //create a BinaryFormatter object, and use it to serialize the Trainee object to file
//            BinaryFormatter writer = new BinaryFormatter();
//            writer.Serialize(file, o);
//            file.Close();

//        }
//    }
//}
