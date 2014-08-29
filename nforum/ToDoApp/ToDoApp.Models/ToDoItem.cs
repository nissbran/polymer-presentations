using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    [DataContract(Name = "toDoItem")]
    public class ToDoItem
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "userId")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [DataMember(Name = "latitude")]
        public decimal Latitude { get; set; }

        [DataMember(Name = "longitude")]
        public decimal Longitude { get; set; }
    }
}
