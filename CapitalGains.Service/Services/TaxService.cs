using CapitalGains.Domain.Entities;
using CapitalGains.Domain.Interfaces;

namespace CapitalGains.Service.Services
{
    public class TaxService : ITaxService
    {
        private const decimal _noTaxes = 20000;
        private decimal _averagePrice = 0;

        public List<OperationEntity> Calculate(List<OperationEntity> operations)
        {
            CalculateAveragePrice(operations.Where(o => o.Operation.Equals("buy")).ToList());
            CalculateSellTax(operations.Where(o => o.Operation.Equals("sell")).ToList());

            return operations;
        }

        private void CalculateSellTax(List<OperationEntity> operationEntities)
        {
            decimal totalGain = 0; 

            foreach (var operation in operationEntities)
            {
                totalGain = (operation.UnitCost * _averagePrice) * operation.Quantity;
            }
        }

        private void CalculateAveragePrice(List<OperationEntity> operationEntities)
        {
            int totalQuatity = operationEntities.Sum(operation => operation.Quantity);
            decimal calculateAverageParece = 0;
            foreach (var operation in operationEntities)
            {
                calculateAverageParece += operation.Quantity * operation.UnitCost;
                operation.Tax = 0;
            }

            _averagePrice = calculateAverageParece / totalQuatity;
        }

        private decimal CalculateSellTax(OperationEntity operation)
        {
            decimal amount = 0;
            decimal operationTotal = operation.Quantity * operation.UnitCost;
            if (operationTotal <= _noTaxes)
                return amount;

            return 20000;
        }
    }
}
