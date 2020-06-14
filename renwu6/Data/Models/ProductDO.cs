using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    [Table("Products")]
    class ProductDO
    {
        [Key] public long Id { get; set; }
        //顾客
        [StringLength(100)] public string Customer { get; set; }

        //管理员
        [StringLength(100)] public string Admin { get; set; }

        //商品
        [StringLength(100)] public string Commodity { get; set; }

        //分类
        [StringLength(100)] public string Classification  { get; set; }

        //订单
        [StringLength(100)] public string Order  { get; set; }

    }
}
