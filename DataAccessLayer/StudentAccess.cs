using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public DataTable GetStudent(string name)
        {
            return GetStudentDAO(name);
        }

        public DataTable GetStudent1(int class_id)
        {
            return GetStudentDAO1(class_id);
        }
        public DataTable GetStudent1(string name)
        {
            return GetStudentDAO1(name);
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
        public string AddStudentForFamily(int student_id, int family_id)
        {
            return AddStudentForFamilyDAO(student_id, family_id);

        }
        public string RemoveStudentForFamily(int student_id, int family_id)
        {
            return RemoveStudentForFamilyDAO(student_id, family_id);

        }
        public DataTable GetStudentOfFamily(int family_id)
        {
            return GetStudentOfFamilyDAO(family_id);
        }
        public DataTable GetStudentNonOfFamily(int family_id, int class_id)
        {
            return GetStudentNonOfFamilyDAO(family_id, class_id);
        }
        public DataTable GetStudentNonOfFamily(int family_id, string name)
        {
            return GetStudentNonOfFamilyDAO(family_id, name);
        }
    }
}
