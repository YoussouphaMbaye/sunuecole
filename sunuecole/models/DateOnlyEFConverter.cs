using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace sunuecole.models
{
    public class DateOnlyEFConverter: ValueConverter<DateOnly, DateTime>
    {
        public DateOnlyEFConverter() : base(
             d => d.ToDateTime(TimeOnly.MinValue),
             dt => DateOnly.FromDateTime(dt))
        { }
    }
}
