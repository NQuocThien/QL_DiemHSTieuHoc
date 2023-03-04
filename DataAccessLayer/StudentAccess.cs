using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DataAccessLayer
{
    public class StudentAccess : DatabaseAccess
    {
        public DataTable GetStudent(int class_id)
        {
            return GetStudentDAO(class_id);
        }
        public string CreateStudent(StudentObject st)
        {
            return CreateStudentDAO(st);
        }
        public string UpdateStudent(StudentObject st)
        {
            if (st != null)
            {
                return UpdateStudentDAO(st);
            }
            return null;
        }
        public string DeleteStudent(StudentObject st)
        {
            if (st != null)
            {
                return DeleteStudentDAO(st);
            }
            return null;
        }
    }
}
