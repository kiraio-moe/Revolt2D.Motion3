using System.Text.Json;

namespace Revolt2D.Motion.Json
{
    public class Motion3Loader
    {
        private Motion3 _motion;

        public Motion3Loader(string filePath)
        {
            _motion = LoadFromFile(filePath);
        }

        public Motion3 GetMotion()
        {
            return _motion;
        }

        public Motion3? LoadFromFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
                throw new Exception($"Invalid path! {filePath}");

            string? jsonData = File.ReadAllText(filePath);
            return LoadJson(jsonData);
        }

        public Motion3? LoadJson(string jsonData)
        {
            try
            {
                if (string.IsNullOrEmpty(jsonData))
                    throw new Exception("JSON data empty!");

                JsonSerializerOptions options = new JsonSerializerOptions { IncludeFields = true };
                return JsonSerializer.Deserialize<Motion3>(jsonData, options);
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }
    }
}
