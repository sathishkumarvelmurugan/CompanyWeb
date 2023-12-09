using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using UsersManageUI.Repository;

namespace UsersManageUI.Controllers
{
    public class UserManageController : Controller
    {
        // GET: UserManage
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult GetAllUsers()
        {
            try
            {
                ServiceRepository serviceObj = new ServiceRepository();
                HttpResponseMessage response = serviceObj.GetResponse("api/userregistration/getallusers");
                response.EnsureSuccessStatusCode();
                List<Models.User> users = response.Content.ReadAsAsync<List<Models.User>>().Result;
                ViewBag.Title = "All Users";
                return View(users);
            }
            catch (Exception)
            {
                throw;
            }
        }


        //[HttpGet]  
        public ActionResult EditUser(int id)
        {
            ServiceRepository serviceObj = new ServiceRepository();
            HttpResponseMessage response = serviceObj.GetResponse("api/userregistration/GetUser?id=" + id.ToString());
            response.EnsureSuccessStatusCode();
            Models.User editUser = response.Content.ReadAsAsync<Models.User>().Result;
            ViewBag.Title = "All Users";
            return View(editUser);
        }


        //[HttpPost]  
        public ActionResult Update(Models.User product)
        {
            ServiceRepository serviceObj = new ServiceRepository();
            HttpResponseMessage response = serviceObj.PutResponse("api/userregistration/UpdateUser", product);
            response.EnsureSuccessStatusCode();
            return RedirectToAction("GetAllUsers");
        }
        public ActionResult Details(int id)
        {
            ServiceRepository serviceObj = new ServiceRepository();
            HttpResponseMessage response = serviceObj.GetResponse("api/userregistration/GetProduct?id=" + id.ToString());
            response.EnsureSuccessStatusCode();
            Models.User detailUsers = response.Content.ReadAsAsync<Models.User>().Result;
            ViewBag.Title = "All Users";
            return View(detailUsers);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Models.User user)
        {
            ServiceRepository serviceObj = new ServiceRepository();
            HttpResponseMessage response = serviceObj.PostResponse("api/userregistration/InsertUser", user);
            response.EnsureSuccessStatusCode();
            return RedirectToAction("GetAllUsers");
        }


        public ActionResult Delete(int id)
        {
            ServiceRepository serviceObj = new ServiceRepository();
            HttpResponseMessage response = serviceObj.DeleteResponse("api/userregistration/DeleteUser?id=" + id.ToString());
            response.EnsureSuccessStatusCode();
            return RedirectToAction("GetAllUsers");
        }
    }
}