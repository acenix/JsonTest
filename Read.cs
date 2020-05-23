using JsonTest.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonTest
{
    public class Read
    {
        public List<string> ReadFile(string filepath)
        {
            try
            {
                if (!File.Exists(filepath))
                    return null;

                string jsonString = File.ReadAllText(filepath);
                Recipents result  = JsonSerializer.Deserialize<Recipents>(jsonString);

                ParseObject parse = new ParseObject();
                return parse.Handle(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
