namespace AzurLaneLoreWiki.Data
{
    public class Character
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Faction { get; set; }
        public string? Prefix { get; set; }// e.g. HMS, USS, IJN, etc. can't just go off faction due to cases like IB with SMS/KMS
        public string? Class { get; set; }
        public string? Description { get; set; }
        public string? Icon { get; set; }
    }
}
