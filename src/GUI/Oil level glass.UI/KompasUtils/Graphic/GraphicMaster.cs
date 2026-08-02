namespace Oil_level_glass.UI.KompasUtils.Graphic
{
    public static class GraphicMaster
    {
        public static TreeNode FilterByHatch(
            int hatch,
            TreeNode tree)
        {
            //var filters = (TreeNode t)
            //                => t.Nodes.Count > 0 || t.Text != "" ||
            //                    (!t.Text.Contains('|') || t.Text.Contains($"|{hatch}"));
            var filters = (TreeNode t)
                => (!t.Text.Contains('|') || t.Text.Contains($"|{hatch}"));

            tree = FilterLeaves(
                   tree,
                   filters
               );

            filters = (TreeNode t)
                => t.Nodes.Count > 0 || t.Text != "";

            while (GetNodesSatisfyFilters(tree, filters).Count() > 0)
            {
                tree = FilterLeaves(
                    tree,
                    filters
                );
            }

            return tree;
        }

        /// <summary>
        /// Reads the Graphic.dns file and converts the lines into nodes
        /// </summary>
        /// <returns></returns>
        public static TreeNode GetAllNodesFromFile()
        {
            var lines = new Queue<string>(
                File.ReadLines(
                    KompasSystem.MaterialsFile)
            );

            return StringToNodes(lines, new TreeNode("Доступные материалы")).Nodes[0];
        }

        private static IEnumerable<TreeNode> GetNodesSatisfyFilters(
            TreeNode treeNode,
            Func<TreeNode, bool> filters)
        {
            List<TreeNode> treeNodes = new List<TreeNode>();

            for (int i = 0; i < treeNode.Nodes.Count; i++)
            {
                TreeNode node = treeNode.Nodes[i];

                if (node.Nodes.Count > 0)
                {
                    treeNodes.AddRange(GetNodesSatisfyFilters(node, filters));
                }
                if (filters.Invoke(node))
                    treeNodes.Add(node);
            }

            return treeNodes;
        }

        private static TreeNode StringToNodes(
            Queue<string> lines,
            TreeNode treeNode)
        {
            while(lines.Count > 0)
            {
                string line = lines.Dequeue();

                if (line.Contains("{"))
                {
                    treeNode.Nodes.Add(
                        StringToNodes(
                            lines,
                            new TreeNode(line.Replace("{", "").Replace(" ", string.Empty))
                        )    
                    );
                }
                else if (line.Contains("}"))
                {
                    treeNode.Nodes.Add(
                        new TreeNode(
                            line.Replace("}", string.Empty)
                            .Replace(" ", string.Empty)
                            )
                        );

                    return treeNode;
                }
                else if (line.Length > 0)
                {
                    treeNode.Nodes.Add(new TreeNode(line));
                }
            }

            return treeNode;
        }

        private static TreeNode FilterLeaves(
            this TreeNode tree,
            Func<TreeNode, bool> filter)
        {
            for(int i = 0; i < tree.Nodes.Count; i++)
            {
                var node = tree.Nodes[i];

                node = DoFilterLeaves(node, filter);
            }

            return tree;
        }

        private static TreeNode DoFilterLeaves(
            TreeNode treeNode,
            Func<TreeNode, bool> filter)
        {
            List<TreeNode> forRemoving = new List<TreeNode>();

            int count = treeNode.Nodes.Count;

            for (int i = 0; i < count; i++)
            {
                TreeNode node = treeNode.Nodes[i];

                if (node.Nodes.Count > 0)
                {
                    DoFilterLeaves(node, filter);
                }
                else
                {
                    if (!filter.Invoke(node))
                    {
                        forRemoving.Add(node);
                    }
                }
            }

            foreach (var node in forRemoving)
                node.Remove();

            return treeNode;
        }
    }
}
