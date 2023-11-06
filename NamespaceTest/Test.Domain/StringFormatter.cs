namespace Test.Domain;

public static class StringFormatter
{
    public static string AddAsterix(this string text) => $"*** {text} ***";
}