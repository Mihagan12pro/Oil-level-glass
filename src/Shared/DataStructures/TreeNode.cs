namespace Shared.DataStructures
{
    public class TreeNode<T>
    {
        public T Data { get; set; }

        public List<TreeNode<T>> Children { get; set; } = new();

        public TreeNode(T data)
        {
            Data = data;
        }

        public void AddChild(TreeNode<T> child)
        {
            Children.Add(child);
        }
    }
}
