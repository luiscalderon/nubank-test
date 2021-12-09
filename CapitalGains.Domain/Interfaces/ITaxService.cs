using CapitalGains.Domain.Entities;

namespace CapitalGains.Domain.Interfaces
{
    public interface ITaxService
    {
        List<OperationEntity> Calculate(List<OperationEntity> operations);
    }
}
