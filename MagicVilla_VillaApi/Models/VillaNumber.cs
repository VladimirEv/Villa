using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_VillaApi.Models
{
    public class VillaNumber
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] //Id задаём ручками
        public int VillaNo { get; set; }

        [ForeignKey("Villa")]
        public int VillaID { get; set; }
        public Villa Villa { get; set; }

        public string SpecialDetails { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
