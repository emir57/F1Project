using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using f1project.data.Abstract;
using f1project.entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace f1project.data.Concrete.EfCore
{
    public class EfCorePostDal : EfCoreGenericDal<Post, F1ProjectContext>, IPostDal
    {
        public async Task<List<Post>> GetPostsWithDriver(int driverid, Expression<Func<Post, bool>> filter = null)
        {
            using (var context = new F1ProjectContext())
            {
                return filter == null ?
                await context.Posts
                    .Include(a => a.PostsDrivers)
                    .ThenInclude(a => a.Driver)
                    .Where(a => a.PostsDrivers.Any(a => a.DriverId == driverid))
                    .ToListAsync() :
                await context.Posts
                    .Where(filter)
                    .Include(a => a.PostsDrivers)
                    .ThenInclude(a => a.Driver)
                    .Where(a => a.PostsDrivers.Any(a => a.DriverId == driverid))
                    .ToListAsync();
            }

        }

        public async Task<List<Post>> GetPostsWithTeam(int teamid, Expression<Func<Post, bool>> filter = null)
        {
            using (var context = new F1ProjectContext())
            {
                return filter == null ?
                    await context.Posts
                    .Include(a => a.PostsTeams)
                    .ThenInclude(a => a.Team)
                    .Where(a => a.PostsTeams.Any(a => a.TeamId == teamid))
                    .ToListAsync() :
                    await context.Posts
                    .Include(a => a.PostsTeams)
                    .ThenInclude(a => a.Team)
                    .Where(a => a.PostsTeams.Any(a => a.TeamId == teamid))
                    .ToListAsync();
            }

        }


        public async Task<Post> GetPostWithDrivers(int postid)
        {
            using (var context = new F1ProjectContext())
            {
                return
                    await context.Posts
                        .Include(a => a.PostsDrivers)
                        .ThenInclude(a => a.Driver)
                        .FirstOrDefaultAsync(a => a.PostId == postid);

            }
        }

        public async Task<Post> GetPostWithTeams(int postid)
        {
            using (var context = new F1ProjectContext())
            {
                return
                    await context.Posts
                        .Include(a => a.PostsTeams)
                        .ThenInclude(a => a.Team)
                        .FirstOrDefaultAsync(a => a.PostId == postid);
            }
        }

        public async Task Update(Post entity, int[] driverIds, int[] teamIds)
        {
            using (var context = new F1ProjectContext())
            {
                var post = await context.Posts.SingleOrDefaultAsync(a => a.PostId == entity.PostId);
                var postDriver = await context.Posts
                    .Include(a => a.PostsDrivers)
                    .FirstOrDefaultAsync(a => a.PostId == entity.PostId);
                var postTeam = await context.Posts
                    .Include(a => a.PostsTeams)
                    .FirstOrDefaultAsync(a => a.PostId == entity.PostId);
                if (post != null)
                {
                    postDriver.ImageTitleUrl = entity.ImageTitleUrl;
                    postDriver.BodyText = entity.BodyText;
                    postDriver.Title = entity.Title;
                }
                if (postDriver != null)
                {
                    postDriver.PostsDrivers = driverIds.Select(drivId => new PostDriver()
                    {
                        PostId = entity.PostId,
                        DriverId = drivId
                    }).ToList();
                    await context.SaveChangesAsync();
                }
                if (postTeam != null)
                {
                    postDriver.PostsTeams = teamIds.Select(tmId => new PostTeam()
                    {
                        PostId = entity.PostId,
                        TeamId = tmId
                    }).ToList();
                    await context.SaveChangesAsync();
                }
            }
        }
        
    }
}
