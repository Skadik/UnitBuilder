using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnitBuilder.Arsenal.Weapon;
using UnitBuilder.Arsenal.Weapon.Bow;
using UnitBuilder.Environment;

namespace UnitBuilder.Services.Json
{
    public class JsonWeapons
    {
        private string FilePath = "";
        private List<Weapon> weapons;

        public JsonWeapons() 
        {
            string fileName = "data.json";
            string fileFolderPath = "E:\\VS C# and C++ projekt\\UnitBuilder\\UnitBuilder\\UnitBuilder\\Services";
            FilePath =  fileName;

            if(!File.Exists(fileFolderPath))
            {
                var file=File.Create(FilePath);
                file.Close();
            }
            weapons = new List<Weapon>();
        }  
        
        public void SaveRegiment(Regiment regiment)
        {
            using (StreamWriter streamWriter = new StreamWriter(FilePath, false))
            {
                string json = JsonConvert.SerializeObject(regiment);

                streamWriter.WriteLine(json);
            }
        }

        public void SaveObject(Weapon value)
        {
            weapons.Add(value);   
            string objectSerialized = JsonConvert.SerializeObject(weapons);
            
            File.WriteAllText(FilePath, objectSerialized);
        }

        //public static void reRecordObject(int id)
        //{
        //    List<Weapon> weapons = new List<Weapon>();
        //    Weapon weapon = weapons.FirstOrDefault(w => w.getID() == id);
        //    if (weapon != null)
        //    {
        //        var weaponSerialize = JsonConvert.SerializeObject(weapon);
        //        var deserialized = JsonConvert.DeserializeObject<Weapon>(weaponSerialize);
        //        var result = JsonConvert.SerializeObject(deserialized, Formatting.Indented);
        //    }
        //}

        public List<Weapon> readAllObject() 
        {
            
            string json = File.ReadAllText(FilePath);
            var currentObject = JsonConvert.DeserializeObject<List<Weapon>>(json);
            return currentObject;
        }
    }
}
