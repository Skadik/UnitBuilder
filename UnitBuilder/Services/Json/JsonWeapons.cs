using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using UnitBuilder.Arsenal.Weapon;

namespace UnitBuilder.Services.Json
{
    public class JsonWeapons
    {
        private string FilePath = "";
        private List<Weapon> weapons;
        public JsonWeapons() 
        {
            string fileName = "JsonWeapons";
            string fileFolderPath = Path.GetTempPath();
            FilePath = fileFolderPath + fileName;
            weapons = new List<Weapon>();
        }    

        public void SaveObject(Weapon value)
        {
            weapons.Add(value);
            string objectSerialized = JsonConvert.SerializeObject(weapons);
            File.WriteAllText(FilePath, objectSerialized);
        }

        public static void reRecordObject(int id)
        {
            List<Weapon> weapons = new List<Weapon>();
            Weapon weapon = weapons.FirstOrDefault(w => w.getID() == id);
            if (weapon != null)
            {
                var weaponSerialize = JsonConvert.SerializeObject(weapon);
                var deserialized = JsonConvert.DeserializeObject<Weapon>(weaponSerialize);
                var result = JsonConvert.SerializeObject(deserialized, Formatting.Indented);
            }
        }

        public List<Weapon> readAllObject() 
        {
            string json = File.ReadAllText(FilePath);
            List<Weapon> currentObject = JsonConvert.DeserializeObject<List<Weapon>>(json);
            return currentObject;
        }
    }
}
