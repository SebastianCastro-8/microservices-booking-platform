namespace Microservices.Core.Utilities;

public static class Guard
{
    public static void AgainstNull(object? value, string name)
    {
        if (value is null)
            throw new ArgumentNullException(name);
    }

    public static void AgainstNullOrEmpty(string? value, string name)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException($"The {name} cannot be null or empty.");
    }

    public static void AgainstOutOfRange(bool condition, string message)
    {
        if (condition)
            throw new ArgumentOutOfRangeException(message);
    }
}
