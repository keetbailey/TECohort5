using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GetExercises.Web.Models
{
    public class CustSearchModel : Customer
    {
        public string FirstOrLastName { get; set; }
        public string SortOrder { get; set; }
    }
}