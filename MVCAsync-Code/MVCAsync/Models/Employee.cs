using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAsync.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public string Designation { get; set; }
        public string Dept { get; set; }
    }
}