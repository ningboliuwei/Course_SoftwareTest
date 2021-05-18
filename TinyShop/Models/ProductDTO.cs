using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TinyShop.Models
{
    public class ProductDTO
    {
        public long Id { get; set; }

        // 产品编号
        public string ProductNumber { get; set; }

        // 产品名称
        public string ProductName { get; set; }

        // 产品类型
        public string ProductType { get; set; }

        // 产品价格
        public string Price { get; set; }

        // 图片路径
        public string ImgUrl { get; set; }
    }
}