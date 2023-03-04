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
    }
}
