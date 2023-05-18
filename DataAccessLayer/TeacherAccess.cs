using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DataAccessLayer
{
    public class TeacherAccess: DatabaseAccess
    {
        public DataTable GetTeacher()
        {
            return GetTeacherDAO();
        }
        public DataTable GetClassOfTeacher(int teacher_id)
        {
            return GetClassOfTeacherDAO(teacher_id);
        }
        public DataTable GetClassNonOfTeacher(int teacher_id)
        {
            return GetClassNonOfTeacherDAO(teacher_id);
        }
        public DataTable GetSubjectOfTeacher(int teacher_id)
        {
            return GetSubjectOfTeacherDAO(teacher_id);
        }
        public DataTable GetSubjectNonOfTeacher(int teacher_id)
        {
            return GetSubjectNonOfTeacherDAO(teacher_id);
        }
        public string CreateTeacher(TeacherObject tc)
        {
            if (tc != null)
            {
                return CreateTeacherDAO(tc);
            }
            return null;
        }
        public string UpdateTeacher(TeacherObject tc)
        {
            if (tc != null)
            {
                return UpdateTeacherDAO(tc);
            }
            return null;
        }
        public string DeleteTeacher(TeacherObject tc)
        {
            if (tc != null)
                return DeleteTeacherDAO(tc);
            return null;
        }
        public string AddClassForTeacher(int class_id, int teacher_id)
        {
               return AddClassForTeacherDAO(class_id, teacher_id);
        }
        public string RemoveClassForTeacher(int class_id, int teacher_id)
        {
            return RemoveClassForTeacherDAO(class_id, teacher_id);
        }
        public string AddSubjectForTeacher(int class_id, int teacher_id)
        {
            return AddSubjectForTeacherDAO(class_id, teacher_id);
        }
        public string RemoveSubjectForTeacher(int class_id, int teacher_id)
        {
            return RemoveSubjectForTeacherDAO(class_id, teacher_id);
        } public DataTable GetTeacherIsNotBoss()
        {
            return GetTeacherIsNotBossDAO();
        }public DataTable GetNameByID(int teacher_id)
        {
            return GetNameByIDDAO(teacher_id);
        }
    }
}
