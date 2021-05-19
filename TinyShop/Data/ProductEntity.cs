﻿using System.ComponentModel.DataAnnotations;

namespace TinyShop.Data
{
    public class ProductEntity
    {
        [Key] public long Id { get; set; }

        // 产品编号
        [StringLength(100)] public string ProductNumber { get; set; }

        // 产品名称
        [StringLength(100)] public string ProductName { get; set; }

        // 产品类型
        [StringLength(100)] public string ProductType { get; set; }

        // 产品价格
        [StringLength(100)] public double Price { get; set; }

        // 图片路径
        [StringLength(300)] public string ImgUrl { get; set; }
    }
}