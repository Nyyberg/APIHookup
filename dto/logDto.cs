namespace apihookup.dto
{
    public class logDto
    {
        public int Id { get; set; }

        public int? HookupBeId { get; set; }

        public DateTime? Timestamp { get; set; }

        public bool? IsSuccessful { get; set; }

        public string? ErrorMessage { get; set; }
    }
}
