using fetch_API.interfaces;

class ErrorResponse : IResponse
{
    public string? Response { get; set; }
    public string? Error { get; set; }

}