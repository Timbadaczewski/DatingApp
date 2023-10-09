using API.DTOs;
using API.Entities;
using API.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLikeAsync(int sourceUserId, int likedUserId);

        Task<AppUser> GetUserWithLikesAsync(int userId);

        Task<PagedList<LikeDto>> GetUserLikesAsync(LikesParams likesParams);
    }
}
