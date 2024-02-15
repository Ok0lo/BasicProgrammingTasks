using System.Collections.Generic;

namespace _8_4
{
    public static class PeopleListManipulator
    {

        public static List<People> FilterPeopleListByCity(List<People> peopleList, string targetCity)
        {
            var filtredPeopleList = new List<People>();
            foreach (var people in peopleList)
            {
                if (people.LivingCity == targetCity)
                {
                    filtredPeopleList.Add(people);
                }
            }

            return filtredPeopleList;
        }

        public static int CalculateAveragePeopleAge(List<People> peopleList)
        {
            int averagePeopleAge, peoplesAge = 0;
            foreach (var people in peopleList)
            {
                peoplesAge += people.Age;
            }

            averagePeopleAge = peoplesAge / peopleList.Count;

            return averagePeopleAge;
        }

    }

}
