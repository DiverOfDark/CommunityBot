namespace CommunityBot.Contracts
{
    public class SQLiteConfigurationOptions
    {
        public const string SectionName = "SQLite";
        
        public string DbFilePath { get; set; } = null!;
    }
}