using AITech.Business.Services.GenericServices;
using AITech.DTO.ProjectDtos;
using AITech.Entity.Entities;

namespace AITech.Business.Services.ProjectServices
{
    public interface IProjectService : IGenericService<ResultProjectDto, CreateProjectDto, UpdateProjectDto>
    {
        Task<List<ResultProjectDto>> TGetProjectWithCategoriesAsync();
    }
}
