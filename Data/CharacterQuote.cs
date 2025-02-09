namespace AzurLaneLoreWiki.Data
{
    public class CharacterQuote
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public int EventId { get; set; }
        public string Quote { get; set; }
        public int QuoteEventIndex { get; set; }
        public int QuoteConversationId { get; set; }

    }
}
