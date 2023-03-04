using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class StudentObject
    {
        public int student_id { set; get; }
        public string studentName { set; get; }
        public string numberPhone { set; get;}
        public string dateOfBirth { set; get; }
        public string sex { set; get; }

        public string adress { set; get; }
        public int class_id { set; get; }
    }
}
