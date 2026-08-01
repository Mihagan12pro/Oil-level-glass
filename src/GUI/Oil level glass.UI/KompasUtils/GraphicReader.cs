namespace Oil_level_glass.UI.KompasUtils
{
    public static class GraphicReader
    {
        public static TreeNode GetByHatch(int hatch)
        {
            var lines = new Queue<string>(File.ReadLines(KompasSystem.MaterialsFile));

            var tree = StringToNodes(lines, new TreeNode()).Nodes[0];

            return tree;
        }

        private static TreeNode StringToNodes(Queue<string> lines, TreeNode treeNode)
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
    }
}
