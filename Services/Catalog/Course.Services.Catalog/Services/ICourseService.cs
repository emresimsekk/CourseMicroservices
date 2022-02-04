using Course.Services.Catalog.Dtos;
using Course.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Course.Services.Catalog.Services
{
    public interface ICourseService
    {
        Task<Response<NoContent>> DeleteAsync(string Id);
        Task<Response<NoContent>> UpdateAsync(CourseUpdateDto courseUpdateDto);
        Task<Response<CourseDto>> CreateAsync(CourseCreateDto courseCreateDto);
        Task<Response<List<CourseDto>>> GetAllByUserId(string Id);
        Task<Response<CourseDto>> GetByIdAsync(string Id);
        Task<Response<List<CourseDto>>> GetAllAsync();
    }
}
