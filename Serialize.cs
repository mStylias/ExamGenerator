using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ExamGenerator
{
    public static class Serialize
    {
        static string savePath;

        static Serialize()
        {
            var commonAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            savePath = Path.Combine(commonAppDataPath, "Exam Generator");
            Directory.CreateDirectory(savePath);
        }

        private static string GetFullPath(string fileName) 
        {
            return Path.Combine(savePath, fileName);
        }

        public static void SaveSubjects(Dictionary<string, Subject> subjects) 
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(GetFullPath("subjects.eg"), FileMode.OpenOrCreate, FileAccess.Write);

            formatter.Serialize(stream, subjects);

            stream.Close();
        }

        public static Dictionary<string, Subject> LoadSubjects()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(GetFullPath("subjects.eg"), FileMode.OpenOrCreate, FileAccess.Read);

            Dictionary<string, Subject> subjects;
            if (stream.Length > 0)
                subjects = (Dictionary<string, Subject>)formatter.Deserialize(stream);
            else
                subjects = null;

            stream.Close();
            return subjects;
        }
    }
}
