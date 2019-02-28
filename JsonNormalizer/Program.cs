using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Threading.Tasks;

namespace JsonNormalizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var filename = args.Length > 0 ? args[0] : "suggestions.json";
            var task = Task.Run(async () =>
            {
                var json = await ReadFromFile(filename);
                return await Normalize(json);
            });

            task.Wait();
            Console.WriteLine(task.Result.ToString());

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }

        static async Task<JToken> ReadFromFile(string filename)
        {
            using (var fileStream = new FileStream(filename, FileMode.Open))
            using (var reader = new StreamReader(fileStream))
            using (var jsonReader = new JsonTextReader(reader))
            {
                return await JObject.ReadFromAsync(jsonReader);
            }
        }

        static async Task<JToken> Normalize(JToken denormalizedJson)
        {
            //TODO: implement normalization logic here
            return denormalizedJson;
        }
    }
}
