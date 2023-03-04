using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace DataAccessLayer
{
    public class BlockAccess : DatabaseAccess
    {
        public DataTable BlockClass()
        {
            return BlockClassDAO();
        }
        public DataTable GetClass()
        {
            return GetClassDAO();
        }
        public DataTable GetClasscb()
        {
            return GetClasscbDAO();
        }
        public DataTable GetClass(string search)
        {
            return GetClassDAO(search);
        }
        public string CreateBlock(Block block)
        {
            return CreateBlockDAO(block);
        }
        public string UpdateBlock(Block block)
        {
            return UpdateBlockDAO(block);
        }
        public string DeleteBlock(Block block)
        {
            return DeleteBlockDAO(block);
        }
        public string CreateClass(Class cl )
        {
            return CreateClassDAO(cl);
        }
        public string UpdateClass(Class cl)
        {
            return UpdateClassDAO(cl);
        }
        public string DeleteClass(Class cl)
        {
            return DeleteClassDAO(cl);
        }
    }
}
