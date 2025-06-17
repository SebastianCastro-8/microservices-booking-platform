namespace Microservices.Core.Exceptions;

public class NotFoundException : BusinessException
{
    public NotFoundException(string entityName, object key)
      : base($"{entityName} con ID '{key}' no fue encontrado.")
    {
    }
}
