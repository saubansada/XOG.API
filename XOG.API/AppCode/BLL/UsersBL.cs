using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using XOG.AppCode.DAL;
using XOG.AppCode.Models.FilterModels;
using XOG.AppCode.Transformers;
using XOG.Models;
using XOG.Util;

namespace XOG.AppCode.BLL
{
    public static class UsersBL
    {
        internal static List<OListItem> GetRoles(XOGEntities context = null, string userId = "", string userType = "")
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetRoles(_context, userId, userType);
                }
            }
            var query = context.AspNetRoles.Where(i => true);

            if (userType == UserType.Admin.ToString() || userType == UserType.Developer.ToString())
            {
                query =  query.Where(i => i.Name != UserType.Admin.ToString() && i.Name != UserType.Developer.ToString()); 
            }
            else if (userType == UserType.SubAdmin.ToString())
            {
                query = query.Where(i => i.Name != UserType.Admin.ToString() && i.Name != UserType.SubAdmin.ToString() && i.Name != UserType.Developer.ToString());
            }

            return query.Select(role => new OListItem()
            {
                Text = role.Name,
                Value = role.Id,
                Selected = userId != "" && (role.AspNetUsers.Count(i => i.Id == userId) > 0)
            }).ToList();

        }


        internal static XOGEntities GetXOGContext()
        {
            return new XOGEntities();
        }

        private static IQueryable<AspNetUser> GetFilteredWhereQuery(IQueryable<AspNetUser> query, UserFilter filter, string currentUser = "")
        {
            if (filter != null)
            {
                query = !(string.IsNullOrWhiteSpace(filter.Search)) ? query.Where(i => i.UserName.Contains(filter.Search) ||
                                                                                      filter.Search.Contains(i.UserName) ||
                                                                                      i.PhoneNumber.Contains(filter.Search) ||
                                                                                      filter.Search.Contains(i.PhoneNumber) ||
                                                                                      i.Email.Contains(filter.Search) ||
                                                                                      filter.Search.Contains(i.Email))
                                                                   : query;

                string userType = filter.UserType.ToString();

                query = filter.UserType != UserType.Any ? query.Where(i => i.AspNetRoles.Count(r => r.Name.Equals(userType)) > 0)
                                                        : query;

                query = query.Where(u => u.Id != currentUser);
            }

            return query;
        }

        private static IQueryable<AspNetUser> GetFilteredQuery(UserFilter filter, XOGEntities context = null, string currentUser = "")
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetFilteredQuery(filter, _context, currentUser);
                }
            }
            return GetFilteredWhereQuery(context.AspNetUsers, filter, currentUser);
        }

        internal static object GetTList(XOGEntities context = null, UserFilter filter = null, ModelType type = ModelType.Default, ListingType listType = ListingType.GridList, string currentUser = "",  object model = null)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetTList(_context, filter, type, listType, currentUser, model);
                }
            }
            IQueryable<AspNetUser> query = GetFilteredQuery(filter, context, currentUser);

            return query.TransformToUserModelListing(model, type, listType);
        }

        internal static Object GetUserInfo(string userId, XOGEntities context = null, ModelType modelType = ModelType.Default)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetUserInfo(userId, _context, modelType);
                }
            }

            var user = context.AspNetUsers.FirstOrDefault(i => i.Id == userId);

            return user.TransformToUserModel(type: modelType);

        }


        internal static async Task<Object> GetUserInfoAsync(string userId, XOGEntities context = null, ModelType modelType = ModelType.Default)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return await GetUserInfoAsync(userId, _context, modelType);
                }
            }

            var user = await context.AspNetUsers.FirstOrDefaultAsync(i => i.Id == userId);

            return user.TransformToUserModel(type: modelType);

        }

        internal static bool UpdateUserRole(string userId, string role, XOGEntities context = null)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return UpdateUserRole(userId, role, _context);
                }
            }
            return true;
            //AspNetRole _role = UserManager
        }
    }
}