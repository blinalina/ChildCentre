using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildCentre
{
    public class CourseModel
    {
        public int ID { get; }
        public string Name { get; }
        public CourseModel(int id, string cours_name)
        {
            ID = id;
            Name = cours_name;
        }
    }
}
