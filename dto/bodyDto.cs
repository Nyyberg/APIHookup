namespace apihookup.dto
{
    public class BodyDto
    {
        public int Id { get; set; }

        public int? HookupBeId { get; set; }

        public string? BodyType { get; set; }

        public string? ParameterName { get; set; }

        public string? SqlQuery { get; set; }

        public string? Custom { get; set; }
    }
}
