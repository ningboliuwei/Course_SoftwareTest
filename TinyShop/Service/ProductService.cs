#region

using System;
using System.Collections.Generic;
using System.Linq;
using TinyShop.Data;

#endregion

namespace Service {
    public class ProductService {
        private readonly DataContext _context;

        public ProductService(DataContext context) {
            this._context = context;
        }

        public void Delete(long id) {
            var product = this._context.Set<ProductEntity>().FirstOrDefault(t => t.Id == id);

            if (product == null) {
                throw new Exception("没有找到指定 ID 的产品记录");
            }

            this._context.Set<ProductEntity>().Remove(product);
            this._context.SaveChanges();
        }

        public IEnumerable<ProductEntity> GetAll(string order) {
            if (order == "asc") {
                return this._context.Set<ProductEntity>().OrderBy(t => t.Price);
            }

            return this._context.Set<ProductEntity>().OrderByDescending(t => t.Price);
        }

        public IEnumerable<ProductEntity> GetByCategory(string category) {
            var result = this._context.Set<ProductEntity>().Where(t => t.ProductType == category);

            return result;
        }

        public ProductEntity GetById(long id) {
            var product = this._context.Set<ProductEntity>().FirstOrDefault(t => t.Id == id);

            if (product == null) {
                throw new Exception("没有找到指定 ID 的产品记录");
            }

            return product;
        }

        public IEnumerable<ProductEntity> GetByKeyword(string keyword) {
            var result = this._context.Set<ProductEntity>().Where(t => t.ProductName.Contains(keyword));

            return result;
        }

        public ProductEntity Insert(ProductEntity product) {
            this._context.Set<ProductEntity>().Add(product);
            this._context.SaveChanges();

            return product;
        }

        public ProductEntity Update(ProductEntity product) {
            var productExists = this._context.Set<ProductEntity>().Any(t => t.Id == product.Id);

            if (!productExists) {
                throw new Exception("没有找到指定 ID 的产品记录");
            }

            this._context.Set<ProductEntity>().Update(product);
            this._context.SaveChanges();

            return product;
        }
    }
}