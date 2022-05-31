using System;
using System.Collections.Generic;
using CoreBusiness;

namespace UseCases.DataStorePluginInterfaces
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetCategories();
    
    }
}
