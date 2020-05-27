using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagerModel
{
    //Сущность Address настроена с поддержкой каскадного удаления -
    //удаляется вместе со связанным Employee
    public partial class Address
    {
        [Key, ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        [Required]
        [MaxLength(70)]
        public string Country { get; set; }
        [MaxLength(20)]
        public string ZipCode { get; set; }
        [MaxLength(100)]
        public string Region { get; set; }
        [Required]
        [MaxLength(50)]
        public string City { get; set; }
        [Required]
        [MaxLength(100)]
        public string StreetAddress { get; set; }
        [MaxLength(100)]
        public string Apartment { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
