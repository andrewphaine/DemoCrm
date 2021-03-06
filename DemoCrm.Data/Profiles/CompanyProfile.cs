﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCrm.Data.Profiles
{
    public class CompanyProfile
    {
        public static IEnumerable<Models.Company> GetCompanyModelsFromEntities(IEnumerable<Entities.Company> companies)
        {
            return new MapperConfiguration(configure =>
                configure.CreateMap<Entities.Company, Models.Company>()
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src =>
                src.PhoneNumber))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src =>
                src.ObjectType.Name))
                .ForMember(dest => dest.User, opt => opt.MapFrom(src =>
                $"{src.CrmUser.FirstName} {src.CrmUser.LastName}")))
                .CreateMapper().Map<IEnumerable<Models.Company>>(companies);
        }

        public static Models.Company GetCompanyModelFromEntity(Entities.Company company)
        {
            return new MapperConfiguration(configure =>
                configure.CreateMap<Entities.Company, Models.Company>()
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src =>
                src.PhoneNumber))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src =>
                src.ObjectType.Name))
                .ForMember(dest => dest.User, opt => opt.MapFrom(src =>
                $"{src.CrmUser.FirstName} {src.CrmUser.LastName}")))
                .CreateMapper().Map<Models.Company>(company);
        }

        public static Entities.Company GetCompanyEntityFromCreateModel(Models.CompanyCreate companyCreate)
        {
            return new MapperConfiguration(configure =>
                configure.CreateMap<Models.CompanyCreate, Entities.Company>())
                .CreateMapper().Map<Entities.Company>(companyCreate);
        }

        public static void MapCompanyUpdateModelToEntity(Models.CompanyUpdate companyUpdate, Entities.Company company)
        {
            var mapper = new MapperConfiguration(configure =>
                configure.CreateMap<Models.CompanyUpdate, Entities.Company>())
                .CreateMapper();

            mapper.Map(companyUpdate, company);
        }

        public static void GetCompanyEntityFromUpdateModel(Models.CompanyUpdate companyUpdate, Entities.Company company)
        {
            var mapper = new MapperConfiguration(configure =>
                configure.CreateMap<Models.CompanyUpdate, Entities.Company>())
                .CreateMapper();

            mapper.Map(companyUpdate, company);
        }

        public static Models.CompanyUpdate GetCompanyUpdateModelFromEntity(Entities.Company company)
        {
            return new MapperConfiguration(configure =>
                configure.CreateMap<Entities.Company, Models.CompanyUpdate>())
                .CreateMapper().Map<Models.CompanyUpdate>(company);
        }
    }
}
