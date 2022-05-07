using AutoMapper;
using TSDC.SharedMvc.Warehouse.Models;

namespace TSDC.SharedMvc.Warehouse.Infrastructure
{
    public class WarehouseProfile : Profile
    {
        public WarehouseProfile()
        {
            #region Warehouse
            CreateMap<Core.Domain.Warehouse.Warehouse, WarehouseModel>();
            CreateMap<WarehouseModel, Core.Domain.Warehouse.Warehouse>()
                .ForMember(x => x.WarehouseBalances, opt => opt.Ignore())
                .ForMember(x => x.BeginningWarehouses, opt => opt.Ignore())
                .ForMember(x => x.WarehouseLimits, opt => opt.Ignore());
            #endregion
        }
    }
}
