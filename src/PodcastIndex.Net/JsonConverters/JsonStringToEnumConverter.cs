using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace PodcastIndex.Net.JsonConverters;

public class JsonStringToEnumConverter<TEnum> : JsonConverter<TEnum>
    where TEnum : struct, Enum
{
    private readonly Dictionary<string, TEnum> _stringToEnum = new();

    public JsonStringToEnumConverter()
    {
        SetupConverter();
    }

    public override TEnum Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            var stringValue = reader.GetString();

            if (stringValue is null)
                throw new Exception("Token type is Null");

            _stringToEnum.TryGetValue(stringValue, out var enumValue);
            return enumValue;
        }

        return default;
    }

    public override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }

    private void SetupConverter()
    {
        var type = typeof(TEnum);
        var values = Enum.GetValues<TEnum>();

        foreach (var value in values)
        {
            var member = type.GetMember(
                    Enum.GetName(value)
                    ?? throw new Exception($"Couldn't get name of {nameof(value)}")
                )
                .First();

            var attr = member.GetCustomAttributes<EnumMemberAttribute>().FirstOrDefault();

            if (attr?.Value is not null)
                _stringToEnum.Add(attr.Value, value);
        }
    }
}