namespace ViewDataUsingReact
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Table")]
    public partial class Table
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int langID { get; set; }

        [Required]
        [StringLength(50)]
        public string LanName { get; set; }

        [Required]
        [StringLength(50)]
        public string designedBy { get; set; }

        public int yearOfFound { get; set; }

        [Required]
        [StringLength(50)]
        public string website { get; set; }
    }
}
