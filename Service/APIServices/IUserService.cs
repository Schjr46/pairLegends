﻿using System.Linq.Expressions;
using Model.Database;
using Model.Request;
using Model.Response;
using Model.Result;

namespace Service.APIServices
{
    public interface IUserService
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);
        Task<ApiResult<bool>> Register(RegisterRequest request);
        Task<ApiResult<bool>> ChangePassword(ChangePasswordRequest request);
        // Task<ApiResult<string>> GetConfirmCode(GetConfirmCodeRequest request);
        // Task<ApiResult<bool>> ConfirmEmail(ConfirmEmailRequest request);
        Task<ApiResult<bool>> Update(UpdateUserRequest request);
        Task<ApiResult<UserResponse>> GetById(Guid id);
        Task<ApiResult<UserResponse>> GetByUserName(string userName);
        Task<ApiResult<PagedList<UserResponse>>> GetUserPagingList(PagingRequest request);
        Task<IEnumerable<AppUser>> GetUserList(
            Expression<Func<AppUser, bool>>? filter = null,
            Func<IQueryable<AppUser>, IOrderedQueryable<AppUser>>? orderBy = null,
            string includeProperties = "",
            int take = 0,
            int skip = 0
        );
        Task<ApiResult<bool>> Delete(Guid id);
        Task<ApiResult<bool>> Delete(string userName);
        Task<ApiResult<bool>> RoleAssign(RoleAssignRequest request);
    }
}
