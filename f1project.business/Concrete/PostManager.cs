using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using f1project.business.Abstract;
using f1project.data.Abstract;
using f1project.entity.Concrete;

namespace f1project.business.Concrete
{
    public class PostManager : IPostService
    {
        IPostDal _postDal;
        public PostManager(IPostDal postDal)
        {
            this._postDal = postDal;
        }
        public async Task Create(Post entity)
        {
            await _postDal.Create(entity);
        }

        public async Task Delete(Post entity)
        {
            await _postDal.Delete(entity);
        }

        public async Task<List<Post>> GetAll(Expression<Func<Post, bool>> filter = null)
        {
            return filter == null ?
                await _postDal.GetAll():
                await _postDal.GetAll(filter);
        }

        public async Task<Post> GetById(int id)
        {
            return await _postDal.GetById(id);
        }

        public async Task<List<Post>> GetPostsWithDriver(int driverid,Expression<Func<Post,bool>> filter=null)
        {
            return filter==null?
                await _postDal.GetPostsWithDriver(driverid):
                await _postDal.GetPostsWithDriver(driverid,filter);
        }

        public async Task<List<Post>> GetPostsWithTeam(int teamid, Expression<Func<Post, bool>> filter = null)
        {
            return filter==null?
                await _postDal.GetPostsWithTeam(teamid):
                await _postDal.GetPostsWithTeam(teamid,filter);
        }

        public async Task<Post> GetPostWithDrivers(int postid)
        {
            return await _postDal.GetPostWithDrivers(postid);
        }

        public async Task<Post> GetPostWithTeams(int postid)
        {
            return await _postDal.GetPostWithTeams(postid);
        }

        public async Task Update(Post entity)
        {
            await _postDal.Update(entity);
        }

        public async Task Update(Post entity, int[] driverIds, int[] teamIds)
        {
            await _postDal.Update(entity,driverIds,teamIds);
        }
    }
}