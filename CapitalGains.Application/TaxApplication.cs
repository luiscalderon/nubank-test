using CapitalGains.Domain.DTO;
using CapitalGains.Domain.Entities;
using CapitalGains.Domain.Interfaces;

namespace CapitalGains.Application
{
    public class TaxApplication
    {
        protected readonly ITaxService _taxService;
        
        public TaxApplication(ITaxService taxService)
        {
            _taxService = taxService;
        }

        public List<TaxDTO> Calculate(List<OperationDTO> operationsDTO)
        {
            List<OperationEntity> operationsEntity = new List<OperationEntity>();
            List<TaxDTO> result = new List<TaxDTO>();
            foreach (OperationDTO operationDTO in operationsDTO)
            {
                operationsEntity.Add(new OperationEntity(operationDTO.Operation, operationDTO.UnitCost, operationDTO.Quantity));
            }

            var taxCalculate = _taxService.Calculate(operationsEntity);
            foreach (var item in taxCalculate)
            {
                result.Add(new TaxDTO(item.Tax));
            }

            return result;
            
        }
    }
}
