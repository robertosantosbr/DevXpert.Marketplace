using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace DevXpert.Marketplace.Domain.Responses;

public class Response<T>
{
    private readonly int _statusCode;

    public T? Data { get; set; }

    public string? Message { get; set; }

    [JsonConstructor]
    public Response() 
        => _statusCode = Configuration.DefaultStatusCode;

    public Response(T? data, int statusCode = Configuration.DefaultStatusCode, string? message = null)
    {
        Data = data;
        Message = message;
        _statusCode = statusCode;
    }

    [JsonIgnore]
    public bool IsSuccess
        => _statusCode is >= 200 and <= 299;
}