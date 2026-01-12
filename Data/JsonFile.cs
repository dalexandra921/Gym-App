using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GymApp_final.Data
{
    public static class JsonFile
    {
        public static List<T> Load<T>(string fileName)
        {
            var path = Path.Combine(AppContext.BaseDirectory, fileName);

            if (!File.Exists(path))
                return new List<T>();

            try
            {
                var json = File.ReadAllText(path);
                return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
            }
            catch
            {
                return new List<T>();
            }
        }
    }
}
