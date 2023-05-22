using System.ComponentModel;

namespace P01WebApplicationMVC.Models
{
    public class Person
    {
        //private static int _lastPersonId = 0;
        [DisplayName("ID")]
        public int PersonId { get; set; }
        [DisplayName("Name z Displaya")]
        public string PersonName { get; set; } = "";
        [DisplayName("Age z Displaya")]
        public int PersonAge{ get; set; }




        //public Person(string personName, int personAge)
        //{
        //    PersonId = GenerateId();
        //    PersonName = personName;
        //    PersonAge = personAge;
        //}

        //public Person(int personId, string personName, int personAge)
        //{
        //    PersonId = personId;
        //    PersonName = personName;
        //    PersonAge = personAge;
        //}
        //private int GenerateId()
        //{
        //    _lastPersonId++;
        //    return _lastPersonId;
        //}

    }
}
