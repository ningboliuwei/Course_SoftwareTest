using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using TinyShop.Data;
using TinyShop.Models;

namespace TinyShop.Controllers
{
    public class ProductController : Controller
    {
        private ProductService _productService;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public ProductController(DataContext context, IWebHostEnvironment hostingEnvironment) {
            _productService = new ProductService(context);
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromBody] ProductDTO productDTO) {
            var productDO = new ProductEntity() {
                ProductNumber = productDTO.ProductNumber,
                ProductName = productDTO.ProductName,
                ProductType = productDTO.ProductType,
                Price = Convert.ToDouble(productDTO.Price),
                ImgUrl = productDTO.ImgUrl
            };

            try {
                var insertedProduct = _productService.Insert(productDO);

                return Json(new {
                    code = "success",
                    data = insertedProduct
                });
            }
            catch (Exception ex) {
                return Json(new {
                    code = "fail",
                    message = ex.Message
                });
            }
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult GetAll(string order) {
            try {
                var result = _productService.GetAll(order);

                return Json(new {
                    code = "success",
                    data = result
                });
            }
            catch (Exception ex) {
                return Json(new {
                    code = "fail",
                    message = ex.Message
                });
            }
        }

        public IActionResult Delete(long id) {
            try {
                _productService.Delete(id);

                return Json(new {
                    code = "success",
                });
            }
            catch (Exception ex) {
                return Json(new {
                    code = "fail",
                    message = ex.Message
                });
            }
        }

        public IActionResult GetProductById(long id) {
            try {
                var product = _productService.GetById(id);

                return Json(new {
                    code = "success",
                    data = product
                });
            }
            catch (Exception ex) {
                return Json(new {
                    code = "fail",
                    message = ex.Message
                });
            }
        }

        public IActionResult Edit(long id) {
            ViewBag.Id = id;

            return View();
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

                _productService.Update(productEntity);

                return Json(new {
                    code = "success",
                });
            }
            catch (Exception ex) {
                return Json(new {
                    code = "fail",
                    message = ex.Message
                });
            }
        }

        public IActionResult GetProductsByKeyword(string keyword) {
            try {
                var result = _productService.GetByKeyword(keyword);

                return Json(new {
                    code = "success",
                    data = result
                });
            }
            catch (Exception ex) {
                return Json(new {
                    code = "fail",
                    message = ex.Message
                });
            }
        }

        public IActionResult GetProductsByCategory(string category) {
            try {
                var result = _productService.GetByCategory(category);

                return Json(new {
                    code = "success",
                    data = result
                });
            }
            catch (Exception ex) {
                return Json(new {
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
            var targetDir = Path.Combine(_hostingEnvironment.WebRootPath, uploadDir);
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

                return Json(new {
                    code = "success",
                    data = targetFileName
                });
            }
            catch (Exception ex) {
                return Json(new {
                    code = "fail",
                    message = ex.Message
                });
            }
        }

        public IActionResult Table() {
            return View();
        }
    }
}