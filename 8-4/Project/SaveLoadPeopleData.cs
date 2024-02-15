using System.Collections.Generic;
using System.IO;

namespace _8_4
{
    public static class SaveLoadPeopleData
    {

        public static void Save(List<People> peopleList)
        {
            using (BinaryWriter binaryWriter = new BinaryWriter(File.Open("data.dat", FileMode.Create)))
            {
                for (int i = 0; i < peopleList.Count; i++)
                {
                    binaryWriter.Write(peopleList[i].Surname);
                    binaryWriter.Write(peopleList[i].LivingCity);
                    binaryWriter.Write(peopleList[i].Age);
                }
            }
        }

        public static List<People> Load()
        {
            var peopleList = new List<People>();
            var peopleTemp = new People();
            using (BinaryReader binaryReader = new BinaryReader(File.Open("data.dat", FileMode.Open)))
            {
                while (binaryReader.PeekChar() != -1)
                {
                    peopleTemp.Surname = binaryReader.ReadString();
                    peopleTemp.LivingCity = binaryReader.ReadString();
                    peopleTemp.Age = binaryReader.ReadInt32();
                    peopleList.Add(peopleTemp);
                }
            }

            return peopleList;
        }

    }

}
