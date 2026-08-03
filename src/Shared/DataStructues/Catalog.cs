namespace Shared.DataStructues
{
    /// <summary>
    /// Represents a hierarchical catalog node with parent-child relationships
    /// </summary>
    public class Catalog
    {
        private List<Catalog> _subcatalogs = new List<Catalog>();

        /// <summary>
        ///  Represents a node in a tree structure
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets the parent catalog node.
        /// </summary>
        public Catalog Parent { get; private set; }

        /// <summary>
        /// Gets the number of child catalog nodes.
        /// </summary>
        public int Count
            => _subcatalogs.Count;

        public Catalog this[int index]
            => _subcatalogs[index];

        /// <summary>
        /// Add new subcatalog
        /// </summary>
        /// <param name="section"></param>
        public void Add(Catalog section)
        {
            section.Parent = this;

            _subcatalogs.Add(section);
        }

        /// <summary>
        /// Removes a child catalog node
        /// </summary>
        /// <param name="section"></param>
        public void Remove(Catalog section)
            => _subcatalogs.Remove(section);
    }
}
