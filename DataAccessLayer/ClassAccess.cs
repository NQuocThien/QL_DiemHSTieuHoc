using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ClassAccess:DatabaseAccess
    {
        public DataTable GetClassNotHaveTeacher() // lấy thông tin lớp chưa có giáo viên chủ nhiệm
        {

            return GetClassNotHaveTeacherDAO();
        }
    }
}
