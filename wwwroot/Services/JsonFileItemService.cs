using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using ToDoList.Models;
using Microsoft.AspNetCore.Hosting;

namespace ToDoList.WebSite.Services
{
    public class JsonFileItemService
    {
        public JsonFileItemService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "Items.json"); }
        }

        public IEnumerable<Item> GetItems()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Item[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
} 