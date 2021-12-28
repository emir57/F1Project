using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using f1project.entity.Concrete;

namespace f1project.data.Abstract
{
    public interface IPostDal:IRepositoryDal<Post>
    {
        Task<List<Post>> GetPostsWithDriver(int driverid,Expression<Func<Post,bool>> filter=null);
        Task<List<Post>> GetPostsWithTeam(int teamid,Expression<Func<Post,bool>> filter=null);

        Task<Post> GetPostWithTeams(int postid);
        Task<Post> GetPostWithDrivers(int postid);
        
        Task Update(Post entity,int[] driverIds,int[] teamIds);
    }
}