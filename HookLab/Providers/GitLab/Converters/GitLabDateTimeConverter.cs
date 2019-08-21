using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HookLab.Providers.GitLab.Converters
{
    public class GitLabDateTimeConverter : DateTimeConverterBase
    {
        private const string Format = "yyyy-MM-dd  HH:mm:ss ZZZ";
        private const DateTimeStyles Style = DateTimeStyles.None;
        
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (!(value is DateTime dateTime))
            {
                throw new FormatException(
                    "The value is not an instance of DateTime."
                );
            }
            
            writer.WriteValue(
                dateTime.ToString(Format)
            );
        }

        public override object ReadJson(JsonReader reader, Type type, object value, JsonSerializer serializer)
        {
            var str = reader.Value as string;
            var culture = CultureInfo.InvariantCulture;
            
            if (reader.Value is null)
            {
                return null;
            }

            return DateTime.TryParseExact(str, Format, culture, Style, out var result) ? result : DateTime.Now;
        }
    }
}
