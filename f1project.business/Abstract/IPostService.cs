using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using f1project.entity.Concrete;

namespace f1project.business.Abstract
{
    public interface IPostService
    {
        Task Create(Post entity); 
        Task Update(Post entity); 
        Task Delete(Post entity);
        Task<Post> GetById(int id);
        Task<List<Post>> GetAll(Expression<Func<Post,bool>> filter=null);
        Task<List<Post>> GetPostsWithDriver(int driverid,Expression<Func<Post,bool>> filter=null);
        Task<List<Post>> GetPostsWithTeam(int teamid,Expression<Func<Post,bool>> filter=null);
        Task Update(Post entity, int[] driverIds, int[] teamIds);

        Task<Post> GetPostWithTeams(int postid);
        Task<Post> GetPostWithDrivers(int postid);
    }
}