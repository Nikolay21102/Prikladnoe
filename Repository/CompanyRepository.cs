using ShopApi.Contracts;
using ShopApi.Entities;
using ShopApi.Entities.Models;

namespace ShopApi.Repository;

public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
{
    public CompanyRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
    }
}