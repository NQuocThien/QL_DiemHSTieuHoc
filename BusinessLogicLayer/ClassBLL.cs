using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class ClassBLL
    {
        ClassAccess classAs = new ClassAccess();
        public DataTable GetClassNotHaveTeacher()
        {
            return classAs.GetClassNotHaveTeacher();
        }
    }
}
