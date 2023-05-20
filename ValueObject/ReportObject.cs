using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class ReportObject
    {
        public int report_id { set; get; }
        public int student_id { set; get; }
        public int class_id { set; get; }
        public string semester { set; get; }

        public int subjectresult_id { set; get; }
        public string comment { set; get; }
        public int capacity_id { set; get; }

        public int quality_id { set; get; }
    }
}
