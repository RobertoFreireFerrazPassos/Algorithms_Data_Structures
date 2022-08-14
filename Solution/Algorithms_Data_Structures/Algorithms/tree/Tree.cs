using System.Collections.Generic;

namespace Algorithms_Data_Structures
{
    public class Tree
    {
        public TreeNode Root;

        public Tree()
        {
            Root = null;
        }

        public List<TreeNode> GetAll()
        {
            var list = new List<TreeNode>();
            list.Add(Root);            
            return AddChildrenToList(Root, list);
        }

        private List<TreeNode> AddChildrenToList(TreeNode node, List<TreeNode> result) 
        {
            if (node.Childrens.Count == 0)
            {
                return result;
            }

            result.AddRange(node.Childrens);

            foreach (TreeNode childNode in node.Childrens)
            {
                result = AddChildrenToList(childNode, result);
            }

            return result; 
        }
    }
}
