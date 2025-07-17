namespace Star_Wars_Planets.Exstionstion
{
    public static class ConvertIntegerToString
    {
        public static long? IntegerOrNull(this string? value)
        {
            return long.TryParse(value, out var ConverttedValue)
                 ? ConverttedValue : null;
        }
    }
}