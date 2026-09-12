namespace Practice.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        [Key]
        [StringLength(100)]
        public string ProductArticleNumber { get; set; }

        [Required]
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public int? ProductCategoryID { get; set; }

        [StringLength(255)]
        public string ProductPhoto { get; set; }

        public int? ProductManufacturerID { get; set; }

        public int? ProductSupplierID { get; set; }

        public decimal ProductCost { get; set; }

        public byte? ProductDiscountAmount { get; set; }

        public byte? MaximumDiscountAmount { get; set; }

        public int ProductQuantityInStock { get; set; }

        [Required]
        [StringLength(10)]
        public string UnitOfMeasure { get; set; }

        public virtual Category Category { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
