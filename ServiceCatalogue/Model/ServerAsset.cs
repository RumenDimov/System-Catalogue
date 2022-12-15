using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceCatalogue.Model
{
    public class ServerAsset
    {
        
        [Key]

        public int Id { get; set; }

        [Required]

        public string ServerName { get; set; }
        [Display(Name = "Server name")]

        [DefaultValue(false)]
        public bool Active { get; set; } = false;

        [ForeignKey("1")]
        public int? AppsId { get; set; }


        public AppRole Apps { get; set; }

    }
}
