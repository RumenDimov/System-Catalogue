using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceCatalogue.Model
{
    public class SystemAsset
    {
        

        public int Id { get; set; }

        [Required]

        public string Name { get; set; }


        public string Website { get; set; }

        public string Wiki { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Last Deployed")]
        public DateTime LastDeployed { get; set; }

        [ForeignKey("1")]
        public int? ServerAssetsId { get; set; }

        public ServerAsset ServerAssets { get; set; }





    }
}
