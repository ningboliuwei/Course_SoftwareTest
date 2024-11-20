#region

using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using TinyShop.Data;
using TinyShop.Models;

#endregion

namespace TinyShop.Controllers {
    public class ProductController : Controller {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly ProductService _productService;

        public ProductController(DataContext context, IWebHostEnvironment hostingEnvironment) {
            this._productService = new ProductService(context);
            this._hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Create() {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create([FromBody] ProductDTO productDTO) {
            var productDO = new ProductEntity {
                ProductNumber = productDTO.ProductNumber,
                ProductName = productDTO.ProductName,
                ProductType = productDTO.ProductType,
                Price = Convert.ToDouble(productDTO.Price),
                ImgUrl = productDTO.ImgUrl
            };

            try {
                var insertedProduct = this._productService.Insert(productDO);

                return this.Json(new {
                    code = "success", data = insertedProduct
                });
            }
            catch (Exception ex) {
                return this.Json(new {
                    code = "fail",
                    message = ex.Message
                });
            }
        }

        public IActionResult Delete(long id) {
            try {
                this._productService.Delete(id);

                return this.Json(new {
                    code = "success"
                });
            }
            catch (Exception ex) {
                return this.Json(new {
                    code = "fail",
                    message = ex.Message
                });
            }
        }

        public IActionResult Edit(long id) {
            this.ViewBag.Id = id;

            return this.View();
        }

        public IActionResult GetAll(string order) {
            try {
                var result = this._productService.GetAll(order);

                return this.Json(new {
                    code = "success",
                    data = result
                });
            }
            catch (Exception ex) {
                return this.Json(new {
                    code = "fail",
                    message = ex.Message
                });
            }
        }

        public IActionResult GetProductById(long id) {
            try {
                var product = this._productService.GetById(id);

                return this.Json(new {
                    code = "success",
                    data = product
                });
            }
            catch (Exception ex) {
                return this.Json(new {
                    code = "fail",
                    message = ex.Message
                });
            }
        }

        public IActionResult GetProductsByCategory(string category) {
            try {
                var result = this._productService.GetByCategory(category);

                return this.Json(new {
                    code = "success",
                    data = result
                });
            }
            catch (Exception ex) {
                return this.Json(new {
                    code = "fail",
                    message = ex.Message
                });
            }
        }

        public IActionResult GetProductsByKeyword(string keyword) {
            try {
                var result = this._productService.GetByKeyword(keyword);

                return this.Json(new {
                    code = "success",
                    data = result
                });
            }
            catch (Exception ex) {
                return this.Json(new {
                    code = "fail",
                    message = ex.Message
                });
            }
        }

        public IActionResult Index() {
            return this.View();
        }

        public IActionResult Table() {
            return this.View();
        }

        [HttpPost]
        public IActionResult Update([FromBody] ProductDTO productDTO) {
            try {
                var productEntity = new ProductEntity {
                    Id = productDTO.Id,
                    ProductNumber = productDTO.ProductNumber,
                    ProductName = productDTO.ProductName,
                    ProductType = productDTO.ProductType,
                    Price = Convert.ToDouble(productDTO.Price),
                    ImgUrl = productDTO.ImgUrl
                };

                this._productService.Update(productEntity);

                return this.Json(new {
                    code = "success"
                });
            }
            catch (Exception ex) {
                return this.Json(new {
                    code = "fail",
                    message = ex.Message
                });
            }
        }

        [HttpPost]
        public IActionResult UploadImage(IFormFile file) {
            // 上传的文件的相对路径
            var uploadDir = "upload";
            // 上传的文件的扩展名
            var fileExtension = Path.GetExtension(file.FileName);
            // 使用 Guid 类生成一个“唯一”的 ID 作为上传后的文件名，以免重复（并在保存成功后返回）
            var targetFileName = $"{Guid.NewGuid()}{fileExtension}";
            // Web 应用程序（项目中的 wwwroot 文件夹）下的 upload 子文件夹在磁盘上的绝对路径
            var targetDir = Path.Combine(this._hostingEnvironment.WebRootPath, uploadDir);
            var targetFilePath = Path.Combine(targetDir, targetFileName);

            try {
                // 若要放置图片的文件夹不存在，则创建文件夹
                if (!Directory.Exists(targetDir)) {
                    Directory.CreateDirectory(targetDir);
                }

                // 将上传的文件复制到指定位置
                using (var fs = new FileStream(targetFilePath, FileMode.Create)) {
                    file.CopyTo(fs);
                }

                return this.Json(new {
                    code = "success",
                    data = targetFileName
                });
            }
            catch (Exception ex) {
                return this.Json(new {
                    code = "fail",
                    message = ex.Message
                });
            }
        }
    }
}