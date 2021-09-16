using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearningMVC.Models
{
    public class EmpDepartment
    {
        public List<Friends> friends { get; set; }

        public List<Department> depatment { get; set; }
    }
}