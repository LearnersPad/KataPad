namespace SupermarketPricing.Domain
{
    /// <summary>
    /// Associates a categorization with the Product
    /// </summary>
    public class Category
    {
        private readonly string     _name;
        private readonly Category _parentCategory;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="parent"></param>
        public Category(string name, Category parent)
        {
            _name = name;
            _parentCategory = parent;
        }

        /// <summary>
        /// Gets the Name of the Category
        /// </summary>
        public string CategoryName
        {
            get { return _name; }
        }

        /// <summary>
        /// Gets the Parent Category
        /// </summary>
        public Category ParentCategory
        {
            get { return _parentCategory; }
        }

        /// <summary>
        /// Gets the Root Category
        /// </summary>
        public Category RootCategory
        {
            get
            {
                Category rootCategory = _parentCategory;
                while (true)
                {
                    if(rootCategory.ParentCategory == null)
                        break;
                    rootCategory = rootCategory.ParentCategory;
                }
                return rootCategory;
            }
        }
    }
}