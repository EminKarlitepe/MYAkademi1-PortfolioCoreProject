using System.ComponentModel.DataAnnotations;

namespace portfolioCore.Entities
{
    public class Service
    {
        [Key]
        public int ServicesID { get; set; }
        public string? ServiceTitle { get; set; }
        public string ServiceIcon { get; set; }
        public string ServiceDescription { get; set; }
    }
}
