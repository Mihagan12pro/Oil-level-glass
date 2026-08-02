using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataStructures
{
    public class HierarchyNode<T>
    {
        public string Name { get; set; }

        public T Data { get; set; }

        public List<HierarchyNode<T>> Children { get; set; } = new();
    }

    public class StringHierarchyNode : HierarchyNode<string>
    {

    }
}
