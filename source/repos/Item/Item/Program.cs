using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Item
{
    class Items
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }
        public string FlvText { get; set; }
        public string NameHidden { get; set; }

        public Items(int id, string name, string descr, string flvText, string nameHidden)
        {
            this.Id = id;
            this.Name = name;
            this.Descr = descr;
            this.FlvText = flvText;
            this.NameHidden = nameHidden;
        }

        public int GetId()
        {
            return this.Id;
            
        }

        public string GetName()
        {
            return this.Name;
        }

        public string GetDescr()
        {
            return this.Descr;
        }

        public string GetFlvText()
        {
            return this.FlvText;
        }

        public string GetNameHidden()
        {
            return this.NameHidden;
        }

        static void Main(string[] args)
        {
            using (StreamReader r = new StreamReader(@"c:\users\shane_programming\source\repos\Item\Item\MasterItems.json"))
            {
                string json = r.ReadToEnd();
                List<Dictionary<string, string>> data = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(json);
                foreach(Dictionary<string, string> i in data)
                {
                    if(i["ID"] == "1")
                    {
                        Items item = new Items(Int32.Parse(i["ID"]), i["Name"], i["Description"], i["Flavor Text"], i["Name Hidden"]);
                        item.GetId();
                    }
        
                }
 
            }
                  
        }
    }
}
