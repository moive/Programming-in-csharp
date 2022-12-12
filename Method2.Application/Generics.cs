using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Method2.Application
{
    public class Generics
    {
        public Generics()
        {
            var felipe = new Person() { Name = "Felipe" };
            var xml_felipe = Serialize<Person>(felipe);

            var maria = new Person() { Name = "María" };
            var xml_maria = Serialize<Person>(maria);

            var company = new Company() { Address = "Av. I don't know" };
            var xml_company = Serialize<Company>(company);
        }

        private static string Serialize<T>(T value)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var whiteString = new StringWriter())
            {
                using (var white = XmlWriter.Create(whiteString))
                {
                    serializer.Serialize(white, value);
                    return whiteString.ToString();
                }
            }
        }
    }

    public class Person
    {
        public string Name { get; set; }
    }

    public class Company
    {
        public string Address { get; set; }
    }
}
