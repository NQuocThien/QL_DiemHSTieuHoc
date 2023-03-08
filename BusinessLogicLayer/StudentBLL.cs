using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BusinessLogicLayer
{
    public class StudentBLL
    {
        StudentAccess stAs = new StudentAccess();
        public DataTable GetStudent(int class_id)
        {
            return stAs.GetStudent(class_id);
        }
        public DataTable GetStudent(string name)
        {
            return stAs.GetStudent(name);
        }
        public DataTable GetStudent1(int class_id)
        {
            return stAs.GetStudent1(class_id);
        }
        public DataTable GetStudent1(string name)
        {
            return stAs.GetStudent1(name);
        }

        public DataTable GetStudentOfFamily(int family_id)
        {
            return stAs.GetStudentOfFamily(family_id);
        }
        public DataTable GetStudentNonOfFamily(int family_id,int class_id)
        {
            return stAs.GetStudentNonOfFamily(family_id, class_id);
        }
        public DataTable GetStudentNonOfFamily(int family_id, string name)
        {
            return stAs.GetStudentNonOfFamily(family_id, name);
        }
        public string CreateStudent(StudentObject st)
        {
            if(st!= null)
            {
                if (st.studentName == "") return "requeid_name";
                if (st.adress == "") return "requeid_adress";
                if (st.numberPhone == "") return "requeid_numberphone";
                return stAs.CreateStudent(st);
            }
            return null;
        }
        public string UpdateStudent(StudentObject st)
        {
            if (st != null)
            {
                if (st.studentName == "") return "requeid_name";
                if (st.adress == "") return "requeid_adress";
                if (st.numberPhone == "") return "requeid_numberphone";
                return stAs.UpdateStudent(st);
            }
            return null;
        }
        public string DeleteStudent(StudentObject st)
        {
            if (st != null)
            {
                return stAs.DeleteStudent(st);
            }
            return null;
        }
        public string AddStudentForFamily(int student_id, int family_id)
        {
            return stAs.AddStudentForFamily(student_id, family_id);
        
            }
        public string RemoveStudentForFamily(int student_id, int family_id)
        {
            return stAs.RemoveStudentForFamily(student_id, family_id);

        }
    }
}
