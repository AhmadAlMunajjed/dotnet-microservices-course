namespace ordering;

public static class orderingDbProperties
{
    public static string DbTablePrefix { get; set; } = "ordering";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "ordering";
}
