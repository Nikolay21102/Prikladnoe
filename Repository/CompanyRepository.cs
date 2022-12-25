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

    public IEnumerable<Company> GetAllCompanies(bool trackChanges) =>
        FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToList();
    
    public Company? GetCompany(Guid companyId, bool trackChanges)
    {
        return FindByCondition(c
            => c.Id.Equals(companyId), trackChanges).SingleOrDefault();
    }
}