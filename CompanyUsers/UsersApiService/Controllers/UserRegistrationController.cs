using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using UsersApiService.Repository;
using AutoMapper;

namespace UsersApiService.Controllers
{
    public class UserRegistrationController : ApiController
    {

        #region Users
        // GET api/<controller>
        [System.Web.Http.HttpGet]
        public JsonResult<List<Models.User>> GetAllUsers()
        {
            EntityMapper<DataAccessLayer.UserDetail, Models.User> mapObj = new EntityMapper<DataAccessLayer.UserDetail, Models.User>();
            List<DataAccessLayer.UserDetail> userList = DAL.GetAllUsers();
            List<Models.User> users = new List<Models.User>();
            foreach (var item in userList)
            {
                users.Add(mapObj.Translate(item));
            }
            return Json<List<Models.User>>(users);
        }

        //// GET api/<controller>/5
        [System.Web.Http.HttpGet]
        public JsonResult<Models.User> GetUser(int id)
        {
            EntityMapper<DataAccessLayer.UserDetail, Models.User> mapObj = new EntityMapper<DataAccessLayer.UserDetail, Models.User>();
            DataAccessLayer.UserDetail dalUser = DAL.GetUser(id);
            Models.User users = new Models.User();
            users = mapObj.Translate(dalUser);
            return Json<Models.User>(users);
        }

        //// POST api/<controller>
        [System.Web.Http.HttpPost]
        public bool InsertUser(Models.User product)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                EntityMapper<Models.User, DataAccessLayer.UserDetail> mapObj = new EntityMapper<Models.User, DataAccessLayer.UserDetail>();
                DataAccessLayer.UserDetail userObj = new DataAccessLayer.UserDetail();
                userObj = mapObj.Translate(product);
                status = DAL.InsertUser(userObj);
            }
            return status;

        }

        //// PUT api/<controller>/5
        [System.Web.Http.HttpPut]
        public bool UpdateUser(Models.User product)
        {
            EntityMapper<Models.User, DataAccessLayer.UserDetail> mapObj = new EntityMapper<Models.User, DataAccessLayer.UserDetail>();
            DataAccessLayer.UserDetail userObj = new DataAccessLayer.UserDetail();
            userObj = mapObj.Translate(product);
            var status = DAL.UpdateUser(userObj);
            return status;

        }

        //// DELETE api/<controller>/5
        [System.Web.Http.HttpDelete]
        public bool DeleteUser(int id)
        {
            var status = DAL.DeleteUser(id);
            return status;
        }
        #endregion
    }
}