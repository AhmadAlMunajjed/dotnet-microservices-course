namespace catalog;

public static class catalogDbProperties
{
    public static string DbTablePrefix { get; set; } = "catalog";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "catalog";
}
