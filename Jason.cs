using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invent3
{
    public class Jason
    {
        public Rice Read(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Rice>(json);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Problem in reading the file");
                    return null;
                }
            }
        }

    }
}



    

