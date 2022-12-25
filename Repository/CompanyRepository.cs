using Microsoft.EntityFrameworkCore;
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

    public async Task<IEnumerable<Company>> GetAllCompaniesAsync(bool trackChanges)
        => await FindAll(trackChanges)
            .OrderBy(c => c.Name)
            .ToListAsync();
    public async Task<Company> GetCompanyAsync(Guid companyId, bool trackChanges) =>
        await FindByCondition(c => c.Id.Equals(companyId), trackChanges)
            .SingleOrDefaultAsync();
    public async Task<IEnumerable<Company>> GetByIdsAsync(IEnumerable<Guid> ids, bool
        trackChanges) =>
        await FindByCondition(x => ids.Contains(x.Id), trackChanges)
            .ToListAsync();
    
    public void CreateCompany(Company company) => Create(company);
    
    public IEnumerable<Company> GetByIds(IEnumerable<Guid> ids, bool trackChanges) =>
        FindByCondition(x => ids.Contains(x.Id), trackChanges).ToList();
    
    public void DeleteCompany(Company company) => Delete(company);
}