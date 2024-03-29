﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clXPos.DataModel
{
    [Table("MstOrderDetail")]
    public class OrderDetail : BaseTable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public long HeaderId { get; set; }
        public long ProductId { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public bool Active { get; set; }

        [ForeignKey("HeaderId")]
        public virtual OrderHeader OrderHeader { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
