using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
public class SerializeDeserializeDemo
{
    public void SerializeNow()
    {
        ClassToSerialize c = new ClassToSerialize();
        c.Name = "bipin";
        c.Age = 26;
        ClassToSerialize.CompanyName = "xyz";
        FileStream fs = File.OpenWrite("temp.txt");
        BinaryFormatter b = new BinaryFormatter();
        b.Serialize(fs, c);
        fs.Close();
    }
    public void DeSerializeNow()
    {
        ClassToSerialize c = new ClassToSerialize();
        FileStream f = File.OpenRead("temp.txt");
        BinaryFormatter b = new BinaryFormatter();
        c = (ClassToSerialize)b.Deserialize(f);
        Console.WriteLine("Name :" + c.Name);
        Console.WriteLine("Age :" + c.Age);
        Console.WriteLine("Company Name :" + ClassToSerialize.CompanyName);
        Console.WriteLine("Company Name :" + c.GetSupportClassString());
        f.Close();
    }

    public class ClassToSerialize
    {
        private int age;
        private string name;
        static string companyname;
        SupportClass supp = new SupportClass();
        public ClassToSerialize()
        {
            supp.SupportClassString = "In support class";
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public static string CompanyName
        {
            get
            {
                return companyname;
            }
            set
            {
                companyname = value;
            }
        }
        public string GetSupportClassString()
        {
            return supp.SupportClassString;
        }
    }
    public class SupportClass
    {
        public string SupportClassString;
    }
}