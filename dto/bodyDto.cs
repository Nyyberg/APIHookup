namespace apihookup.dto
{
    public class BodyDto
    {
        public int Hookup_Id { get; set; }
        public string? bodyType { get; set; }
        public string? parameterName { get; set; }
        public string? custom { get; set; }
        public string? sqlQuery { get; set; }
        public int hookup_as_parameter { get; set; }
    }
}
