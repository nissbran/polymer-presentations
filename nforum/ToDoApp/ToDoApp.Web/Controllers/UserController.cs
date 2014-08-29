using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ToDoApp.Data;
using ToDoApp.Models;

namespace ToDoApp.Web
{
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("{id}")]
        public User GetUser(int id)
        {
            using (ToDoStoreContext context = new ToDoStoreContext())
            {
                return context.Users.Include("ToDoItems").FirstOrDefault(u => u.Id == id);
            }
        }
    }
}