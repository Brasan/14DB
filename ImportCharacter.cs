using System;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Documents;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;

namespace charImport
{
    public class CharImporter
    {
         public async void ImportCharacter(string charId)
        {

            HttpClient client = new HttpClient();
            Debug.WriteLine("Sending import request");
            string response = await client.GetStringAsync("https://ffxivcollect.com/api/characters/" + charId);
            Debug.WriteLine("Dserializing import result");
            string deserialized = JsonConvert.DeserializeObject(response).ToString();
            Directory.CreateDirectory("api_result");
            await File.WriteAllTextAsync("api_result/result.json", deserialized);
        }
    }
}