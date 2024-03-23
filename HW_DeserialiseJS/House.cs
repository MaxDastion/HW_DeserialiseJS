using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;



class Flat
{
    public int Number { get; set; }
    public int Square { get; set; }
    public int NumberOfResidents { get; set; }

}
internal class House
{
    public string Address;
    public List<Flat> flats { get; set; }
    public void DeserialiseJS(ref House house)
    {
        string json = File.ReadAllText("C:\\Users\\User\\source\\repos\\HW_DeserialiseJS\\HW_DeserialiseJS\\HouseJS.json");
        house = Newtonsoft.Json.JsonConvert.DeserializeObject<House>(json);
        Console.WriteLine(house.Address);
        foreach (var item in house.flats)
        {
            Console.WriteLine($"Number:{item.Number}, square:{item.Square}, number of resident:{item.NumberOfResidents}\n");
        }

    }
  
}
  
