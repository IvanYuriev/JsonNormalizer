using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace JsonNormalizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var filename = args[0];

            var file = File.ReadAllText(filename);
            var j = JObject.Parse(file);

            //TODO: implement normalization logic here
            var normalizedJson = j;
        
            Console.WriteLine(normalizedJson.ToString());

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}
