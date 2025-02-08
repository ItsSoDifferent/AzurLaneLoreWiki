namespace AzurLaneLoreWiki.Data
{
    public class Event
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ShortDescription { get; set; }
        public string? InDepthOverview { get; set; }
        public string? SplashArt { get; set; } //bytestream of image data
    }
}
