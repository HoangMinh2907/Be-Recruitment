using WebRecruitment.Application.IRepository.IGeneric;
using WebRecruitment.Application.Model.Response.PostResponse;
using WebRecruitment.Domain.Entity;

namespace WebRecruitment.Application.IRepository;

public interface IPostRepository : IGenericRepository<Post>
{
    Task<List<Post>> GetPostByNameSkill(Guid jobId);
    Task<List<Post>> GetPostByCompanyID(Guid companyId);
    Task<List<Post>> GetPostByLocation(string location);
    Task<List<Post>> GetPostBySalary(double salary);
    Task<Post> GetAllPostDetail(Guid id);
    Task<List<Post>> GetAllPost();
}