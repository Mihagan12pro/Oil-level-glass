using Shared.DataStructues;

namespace Shared.Utils.CatalogUtils
{
    public abstract class CatalogFiller
    {
        protected Queue<string> sourceLines;

        private Catalog _catalog;

        private readonly string _rootName;

        protected abstract Catalog Fill(Catalog catalog);

        public Catalog GetCatalog()
        {
            if (_catalog == null)
                _catalog = Fill(new Catalog() { Value = _rootName });

            return _catalog;
        }

        public CatalogFiller(FileInfo sourceFile, string rootName)
        {
            _rootName = rootName;

            sourceLines = new (File.ReadAllLines(sourceFile.FullName));
        }

        public CatalogFiller(string source, string rootName)
        {
            _rootName = rootName;

            sourceLines = new();
            foreach(var line in source.Split('\n'))
            {
                sourceLines.Enqueue(line);
            }
        }

        public CatalogFiller(string[] source, string rootName)
        {
            sourceLines = new(source);

            _rootName = rootName;
        }
    }
}
