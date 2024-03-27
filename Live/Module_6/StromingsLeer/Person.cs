

using System.Xml.Serialization;

namespace StromingsLeer;

[XmlRoot("person")]
public class Person
{
    [XmlElement("first-name")]
    public string? FirstName { get; set; }  
    [XmlElement("last-name")]
    public string? LastName { get; set; }
    [XmlElement("age")]
    public int Age { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName} ({Age})";
    }
}
