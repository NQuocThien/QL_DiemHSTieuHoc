using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BusinessLogicLayer
{
    public class TeacherBLL
    {
        TeacherAccess teacherAs = new TeacherAccess();
        public DataTable GetTeacher()
        {
            return teacherAs.GetTeacher();
        }
        public DataTable GetClassOfTeacher(int teacher_id)
        {
            return teacherAs.GetClassOfTeacher(teacher_id);
        }
        public DataTable GetClassNonOfTeacher(int teacher_id)
        {
            return teacherAs.GetClassNonOfTeacher(teacher_id);
        }
        public DataTable GetSubjectOfTeacher(int teacher_id)
        {
            return teacherAs.GetSubjectOfTeacher( teacher_id);
        }
        public DataTable GetSubjectNonOfTeacher(int teacher_id)
        {
         
            return teacherAs.GetSubjectNonOfTeacher(teacher_id);
        }
        public string CreateTeacher(TeacherObject tc)
        {
            if (tc != null)
            {
                if (tc.name_teacher == "") return "requeid_name";
                if (tc.adress == "") return "requeid_adress";
                if (tc.numberPhone == "") return "requeid_numberphone";
                return teacherAs.CreateTeacher(tc);
            }
            return null;
        }
        public string UpdateTeacher(TeacherObject tc)
        {
            if (tc != null)
            {
                if (tc.name_teacher == "") return "requeid_name";
                if (tc.adress == "") return "requeid_adress";
                if (tc.numberPhone == "") return "requeid_numberphone";
                return teacherAs.UpdateTeacher(tc);
            }
            return null;
        }
        public string DeleteTeacher(TeacherObject tc)
        {
            if(tc != null)
            {
                return teacherAs.DeleteTeacher(tc);

            }return null;
        }
        public string AddClassForTeacher(int class_id, int teacher_id)
        {
            return teacherAs.AddClassForTeacher(class_id, teacher_id);
        }
        public string RemoveClassForTeacher(int class_id, int teacher_id)
        {
            return teacherAs.RemoveClassForTeacher(class_id, teacher_id);
        }
        public string AddSubjectForTeacher(int subject_id, int teacher_id)
        {
            return teacherAs.AddSubjectForTeacher(subject_id, teacher_id);
        }
        public string RemoveSubjectForTeacher(int class_id, int teacher_id)
        {
            return teacherAs.RemoveSubjectForTeacher(class_id, teacher_id);
        }
    }
}
