namespace TCSASystems.Blazor.EmployeeManagement.Models.Responses;

public class BaseResponse
{
    public bool Success { get; set; }
    public required string Message { get; set; }
    public int StatusCode { get; set; }
}

public class ServiceResponse<T> : BaseResponse
{
    public T? Data { get; set; }
}
