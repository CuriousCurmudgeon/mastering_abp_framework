using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ProductManagement.Products;

public interface IProductAppService : IApplicationService
{
    Task<ProductDto> GetAsync(Guid id);

    Task<PagedResultDto<ProductDto>> GetListAsync(PagedAndSortedResultRequestDto input);

    Task<ListResultDto<CategoryLookupDto>> GetCategoriesAsync();

    Task CreateAsync(CreateUpdateProductDto input);

    Task UpdateAsync(Guid id, CreateUpdateProductDto input);
}
