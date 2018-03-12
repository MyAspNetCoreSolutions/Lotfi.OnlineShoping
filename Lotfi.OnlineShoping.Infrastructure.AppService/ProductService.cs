using Lotfi.OnlineShoping.Domain.Contract.ApplicationService;
using Lotfi.OnlineShoping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.OnlineShoping.Infrastructure.AppService
{
    public class ProductService : IProductService
    {
        #region Fileds
        IProductRepository _productRepository;
        #endregion

        #region Constractor
        public ProductService(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
        #endregion

        #region Property
        #endregion

        #region Methods
        public void Add(Product product)
        {
            _productRepository.Insert(product);
        }
        #endregion
    }
}
