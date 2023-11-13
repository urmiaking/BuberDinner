using System.Net;
using FluentResults;

namespace BuberDinner.Application.Common.Errors;

public class DuplicateEmailError : IError
{
    public string Message => "Email already exists.";
    public Dictionary<string, object> Metadata { get; } = null!;
    public List<IError> Reasons { get; } = null!;
};