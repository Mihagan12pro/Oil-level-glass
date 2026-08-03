using Shared.DataStructues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oil_level_glass.UI.Utils.Extensions
{
    public static class CatalogExtensions
    {
        public static TreeNode ToTreeNode(this Catalog catalog)
            => DoToTreeNode(catalog, new TreeNode());

        private static TreeNode DoToTreeNode(Catalog catalog, TreeNode treeNode)
        {
            if (catalog.Parent == null)
                treeNode.Text = catalog.Text;

            for(int i = 0; i < catalog.Count; i++)
            {
                Catalog item = catalog[i];

                if (item.Count > 0)
                {
                    TreeNode node = new TreeNode(item.Text);

                    treeNode.Nodes.Add(DoToTreeNode(item, node));
                }
                else
                {
                    treeNode.Nodes.Add(item.Text);
                }
            }

            return treeNode;
        }
    }
}
