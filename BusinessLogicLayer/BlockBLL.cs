using DataAccessLayer;
using System.Data;
using ValueObject;

namespace BusinessLogicLayer
{

    public class BlockBLL
    {
        BlockAccess blockAs = new BlockAccess();
        public DataTable BlockClass()
        {
            return blockAs.BlockClass();
        }
        public DataTable GetClass()
        {
            return blockAs.GetClass();
        }
        public DataTable GetClasscb()
        {
            return blockAs.GetClasscb();
        }
        public DataTable GetClass(string search)
        {
            return blockAs.GetClass(search);
        }
        public string CreateBlock(Block block)
        {
            block.block_name = block.block_name.Trim();
            // Kiểm tra nghiệp vụ

            if (block.block_name == "")
            {
                return "requeid_blockname";
            }
            string info = blockAs.CreateBlock(block);
            return info;
        }
        public string UpdateBlock(Block block)
        {
            if (block != null)
            {
                if (block.block_name == "")
                    return "requeid_blockname";
                return blockAs.UpdateBlock(block);
            }
            return null;
        }
        public string DeleteBlock(Block block)
        {
            if (block != null)
            {
                return blockAs.DeleteBlock(block);
            }
            return null;
        }
        public string CreateClass(Class cl)
        {
            if(cl.nameClass == "") { return "requeid_nameclass"; }
            if (cl.schoolYear == "") return "requeid_schoolyear";
            return blockAs.CreateClass(cl);
        }

        public string UpdateClass(Class cl)
        {
            if (cl != null)
            {
                if (cl.nameClass == "")
                    return "requeid_blockname";
                if (cl.schoolYear == "")
                    return "requeid_schoolyear";
                return blockAs.UpdateClass(cl);
            }
            return null;
        }

        public string DeleteClass(Class cl)
        {
            if (cl != null)
            {
                return blockAs.DeleteClass(cl);
            }
            return null;
        }
    }
}
