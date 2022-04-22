using AutoMapper;
using Northwind.Entity.Models;
using Northwnd.Entity.DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwnd.Entity.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, DtoCustomer>().ReverseMap();
            CreateMap<User, DtoUser>().ReverseMap();
            CreateMap<Territory, DtoTerritory>().ReverseMap();
            CreateMap<Supplier, DtoSupplier>().ReverseMap();
            CreateMap<Shipper, DtoShipper>().ReverseMap();
            CreateMap<Region, DtoRegion>().ReverseMap();
            CreateMap<Product, DtoProduct>().ReverseMap();
            CreateMap<Order, DtoOrder>().ReverseMap();
            CreateMap<OrderDetail, DtoOrderDetail>().ReverseMap();
            CreateMap<EmployeeTerritory, DtoEmployeeTerritory>().ReverseMap();
            CreateMap<Employee, DtoEmployee>().ReverseMap();
            CreateMap<CustomerDemographic, DtoCustomerDemographic>().ReverseMap();
            CreateMap<CustomerCustomerDemo, DtoCustomerCustomerDemo>().ReverseMap();
            CreateMap<Category, DtoCategory>().ReverseMap();
            CreateMap<AlphabeticalListOfProduct, DtoAlphabeticalListOfProduct>().ReverseMap();
            CreateMap<CategorySalesFor1997, DtoCategorySalesFor1997>().ReverseMap();
            CreateMap<CurrentProductList, DtoCurrentProductList>().ReverseMap();
            CreateMap<CustomerAndSuppliersByCity, DtoCustomerAndSuppliersByCity>().ReverseMap();
            CreateMap<Invoice, DtoInvoice>().ReverseMap();
            CreateMap<OrderDetailsExtended, DtoOrderDetailsExtended>().ReverseMap();
            CreateMap<OrdersQry, DtoOrdersQry>().ReverseMap();
            CreateMap<OrderSubtotal, DtoOrderSubtotal>().ReverseMap();
            CreateMap<ProductsAboveAveragePrice, DtoProductsAboveAveragePrice>().ReverseMap();
            CreateMap<ProductSalesFor1997, DtoProductSalesFor1997>().ReverseMap();
            CreateMap<ProductsByCategory, DtoProductsByCategory>().ReverseMap();
            CreateMap<QuarterlyOrder, DtoQuarterlyOrder>().ReverseMap();
            CreateMap<SalesByCategory, DtoSalesByCategory>().ReverseMap();
            CreateMap<SalesTotalsByAmount, DtoSalesTotalsByAmount>().ReverseMap();
            CreateMap<SummaryOfSalesByQuarter, DtoSummaryOfSalesByQuarter>().ReverseMap();
            CreateMap<SummaryOfSalesByYear, DtoSummaryOfSalesByYear>().ReverseMap();
        }
    }
}
