namespace ToDoApp.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ToDoApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ToDoApp.Data.ToDoStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ToDoApp.Data.ToDoStoreContext context)
        {
            context.Users.AddOrUpdate(new User()
            {
                Name = "Demo user",
                ToDoItems = new List<ToDoItem>{
                    new ToDoItem {
                        Title = "G� till kontoret",
                        Description = "Arbeta",
                        Latitude = 57.702583m,
                        Longitude = 11.963223m
                    },
                    new ToDoItem {
                        Title = "Polymer f�rel�sning",
                        Description = "K�ra en f�rel�sning p� nforum",
                        Latitude = 57.700739m,
                        Longitude = 11.952963m
                    },
                    new ToDoItem {
                        Title = "Resa bort",
                        Latitude = 57.668067m,
                        Longitude = 12.296041m
                    }
                }
            });
        }
    }
}
