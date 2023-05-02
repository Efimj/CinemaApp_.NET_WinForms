using System.Text.Json;

namespace CPProject.DataBaseModel.serialization
{
    public static class Serialization
    {
        public static bool SerialiazeToJSON<T>(ref T inObject, string inFileName)
        {
            try
            {
                var stringJson = JsonSerializer.Serialize(inObject);
                File.WriteAllText(inFileName + ".json", stringJson);
                return true;
            }
            catch { return false; }
        }
        public static bool DeserializationFromJSON<T>(ref T inObject, string inFileName)
        {
            try
            {
                if (File.Exists(inFileName + ".json"))
                {
                    var stringJson = File.ReadAllText(inFileName + ".json");
                    T? deserializeObject = JsonSerializer.Deserialize<T>(stringJson);
                    if (deserializeObject == null)
                    {
                        return false;
                    }
                    inObject = deserializeObject;
                    return true;
                }
                return false;
            }
            catch { return false; }
        }
    }
}
