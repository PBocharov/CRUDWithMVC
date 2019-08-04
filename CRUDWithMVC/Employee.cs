namespace CRUDWithMVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        public int EmpId { get; set; }
        [Required(ErrorMessage = "Name is a required field.")]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(250)]
        public string Address { get; set; }
    }
}
