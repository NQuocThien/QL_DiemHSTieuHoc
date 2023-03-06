using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DataAccessLayer
{
    public class FamilyAccess : DatabaseAccess
    {
        public DataTable GetFamilyForStudent(StudentObject st)
        {
            return GetFamilyForStudentDAO(st);
        }
        public DataTable GetFamily()
        {
            return GetFamilyDAO();
        }
        public string CreateFamily(Family family)
        {
            return CreateFamilyDAO(family);
        }
        public string UpdateFamily(Family family)
        {
            return UpdateFamilyDAO(family);
        }
        public string DeleteFamily(Family family)
        {
            return DeleteFamilyDAO(family);
        }
    }
}
