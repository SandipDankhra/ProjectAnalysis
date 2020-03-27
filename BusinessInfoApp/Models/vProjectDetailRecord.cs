namespace BusinessInfoApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vProjectDetailRecord")]
    public partial class vProjectDetailRecord
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ProjectName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ProjectType { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ProjectDuration { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime ProjectStartDate { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime ProejctEndDate { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeId { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectDetailId { get; set; }
    }
}
