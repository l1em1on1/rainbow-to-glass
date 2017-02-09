using System.IO;
using Rainbow.Storage.Yaml;
using RainbowItemsCodeGenerator.Model;

namespace RainbowItemsCodeGenerator.Provider
{
    public class ItemDataProvider
    {
        private static YamlSerializationFormatter Formatter => new YamlSerializationFormatter(null, null);

        public Item Read(string filename)
        {
            using (var streamReader = new StreamReader(filename))
            {
                return Read(streamReader.BaseStream, filename);
            }
        }

        public Item Read(Stream stream, string key)
        {
            var item = Formatter.ReadSerializedItem(stream, key);

            return new Item
            {
                Id = item.Id,
                Name = item.Name
            };
        }
    }
}