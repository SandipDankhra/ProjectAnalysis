namespace BusinessInfoApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProjectDetail
    {
        public int ProjectDetailId { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string ProjectType { get; set; }

        [Required]
        [StringLength(50)]
        public string ProjectDuration { get; set; }

        public DateTime ProjectStartDate { get; set; }

        public DateTime ProejctEndDate { get; set; }

        public int ProjectId { get; set; }

        public virtual Project Project { get; set; }
    }
}
