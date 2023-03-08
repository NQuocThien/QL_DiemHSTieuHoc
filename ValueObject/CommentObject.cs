using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class CommentObject
    {
        public int comment_id {  get; set; }
        public int report_id { get; set; }
        public string knowledge { get; set; }
        public string capacity { get; set; }
        public string quality { get; set; }

    }
}
