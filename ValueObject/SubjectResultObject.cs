using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class SubjectResultObject
    {
        public int subjectresult_id { set; get; }
        public int subject_id { set; get; }
        public int report_id { set; get; }
        public string lever { set; get; }   
        public double scores { set; get; }

    }
}
