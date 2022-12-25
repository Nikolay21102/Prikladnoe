﻿using ShopApi.Entities.Models;

namespace ShopApi.Contracts;

public interface ICompanyRepository : IRepositoryBase<Company>
{
    IEnumerable<Company> GetAllCompanies(bool trackChanges);
    Company? GetCompany(Guid companyId, bool trackChanges);
}