using Lotfi.OnlineShoping.Domain.Contract.ApplicationService;
using Lotfi.OnlineShoping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.OnlineShoping.Infrastructure.AppService
{
    public class CategoryService : ICategoryService
    {
        #region Fileds
        private ICategoryRepository _categoryRepository;
        #endregion

        #region Constractor
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }
        #endregion

        #region Property
        #endregion

        #region Methods
        public void Add(Category category)
        {
            _categoryRepository.Insert(category);
        }
        #endregion
    }
}
