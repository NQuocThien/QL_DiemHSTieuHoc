using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DataAccessLayer
{
    public class FamilyBLL
    {
        FamilyAccess familyAs = new FamilyAccess();
        public DataTable GetFamilyForStudent(StudentObject st)
        {
            return familyAs.GetFamilyForStudent(st);
        }
        public DataTable GetFamily()
        {
            return familyAs.GetFamily();
        }
        public string CreateFamily (Family f)
        {
            if (f != null)
            {
                if (f.parent_name == "") return "requeid_name";
                if (f.nameRelationShip == "") return "requeid_relationShip";
                if (f.numberPhone == "") return "requeid_numberphone";
                return familyAs.CreateFamily(f);
            }
            return null;
        }
        public string UpdateFamily(Family f)
        {
            if (f != null)
            {
                if (f.parent_name == "") return "requeid_name";
                if (f.nameRelationShip == "") return "requeid_relationShip";
                if (f.numberPhone == "") return "requeid_numberphone";
                return familyAs.UpdateFamily(f);
            }
            return null;
        }
        public string DeleteFamily(Family f)
        {
            if (f != null)
            {
                return familyAs.DeleteFamily(f);
            }
            return null;
        }
    }
}
