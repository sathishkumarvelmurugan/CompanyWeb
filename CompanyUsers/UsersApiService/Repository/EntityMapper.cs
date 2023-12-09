using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using DataAccessLayer;

namespace UsersApiService.Repository
{
    public class EntityMapper<TSource, TDestination> where TSource : class where TDestination : class
    {
        public EntityMapper()
        {
            Mapper.CreateMap<UsersApiService.Models.User, UserDetail>();
            Mapper.CreateMap<UserDetail, UsersApiService.Models.User>();
        }
        public TDestination Translate(TSource obj)
        {
            return Mapper.Map<TDestination>(obj);
        }
    }
}