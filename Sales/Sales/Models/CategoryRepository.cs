using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Sales.Models
{
    public class CategoryRepository: ICategory
    {
        private List<Category> _category;
        public CategoryRepository()
        {
            _category = new List<Category>()
            {
                new Category(){Id=1,Name="Soap"},
                new Category(){Id=2,Name="Shampoo"},
                 new Category(){Id=3,Name="Body Spray"}

            };
        }
        public bool AddCategory(Category cat)
        {
            int index = _category.FindIndex(each => each.Name.ToLower() == cat.Name.ToLower());
            if(index == -1)
            {
                cat.Id = _category.Max(each => each.Id) + 1;
                _category.Add(cat);
                return true;
            }
            else
            {
                return false;
            }
        }
        IEnumerable<Category> ICategory.GetAllCategory()
        {
            return _category;
        }
        Category ICategory.GetCategoryId(int id)
        {
            return _category.FirstOrDefault(c => c.Id == id);
        }
    }
}
