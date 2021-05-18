using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Transactions;
using Microsoft.AspNetCore.Http;
using TinyShop.Data;

namespace Service
{
    public class ProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context) {
            _context = context;
        }

        public ProductEntity Insert(ProductEntity product) {
            _context.Set<ProductEntity>().Add(product);
            _context.SaveChanges();

            return product;
        }

        public IEnumerable<ProductEntity> GetAll(string order) {
            if (order == "asc") {
                return _context.Set<ProductEntity>().OrderBy(t => t.Price);
            }

            return _context.Set<ProductEntity>().OrderByDescending(t => t.Price);
        }

        public void Delete(long id) {
            var product = _context.Set<ProductEntity>().FirstOrDefault(t => t.Id == id);

            if (product == null)
                throw new Exception("没有找到指定 ID 的产品记录");
            _context.Set<ProductEntity>().Remove(product);
            _context.SaveChanges();
        }

        public ProductEntity Update(ProductEntity product) {
            var productExists = _context.Set<ProductEntity>().Any(t => t.Id == product.Id);

            if (!productExists) {
                throw new Exception("没有找到指定 ID 的产品记录");
            }

            _context.Set<ProductEntity>().Update(product);
            _context.SaveChanges();

            return product;
        }

        public ProductEntity GetById(long id) {
            var product = _context.Set<ProductEntity>().FirstOrDefault(t => t.Id == id);

            if (product == null) {
                throw new Exception("没有找到指定 ID 的产品记录");
            }

            return product;
        }

        public IEnumerable<ProductEntity> GetByKeyword(string keyword) {
            var result = _context.Set<ProductEntity>().Where(t => t.ProductName.Contains(keyword));

            return result;
        }

        public IEnumerable<ProductEntity> GetByCategory(string category) {
            var result = _context.Set<ProductEntity>().Where(t => t.ProductType == category);

            return result;
        }
    }
}