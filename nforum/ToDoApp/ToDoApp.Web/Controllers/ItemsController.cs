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
    [RoutePrefix("api/items")]
    public class ItemsController : ApiController
    {
        [HttpGet]
        [Route("{id}")]
        public ToDoItem GetItem(int id)
        {
            using (ToDoStoreContext context = new ToDoStoreContext())
            {
                return context.ToDoItems.FirstOrDefault(u => u.Id == id);
            }
        }
    }
}