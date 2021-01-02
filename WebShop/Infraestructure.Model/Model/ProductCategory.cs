namespace Infraestructure.Model.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductCategory")]
    public partial class ProductCategory
    {
        public int ProductCategoryId { get; set; }

        public int? ProductId { get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual Product Product { get; set; }
    }
}
