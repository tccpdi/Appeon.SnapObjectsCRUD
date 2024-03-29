using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SnapObjects.Data;
using SnapObjects.Data.SqlServer;

namespace AdventureWorks.Models
{
    [SqlParameter("fName", typeof(string))]
    [FromTable("Person", Schema = "Person")]
    [SqlWhere("FirstName = :fName")]
    [SqlOrderBy("BusinessEntityID ASC")]
    public class PersonByFirstName
    {
        [Key]
        [Required]
        public int businessEntityID { get; set; }
        
        [MaxLength(2)]
        [MinLength(2)]
        [Required]
        public string personType { get; set; }
        
        [Required]
        public bool nameStyle { get; set; }
        
        [MaxLength(8)]
        public string title { get; set; }
        
        [MaxLength(50)]
        [Required]
        public string firstName { get; set; }
        
        [MaxLength(50)]
        public string middleName { get; set; }
        
        [MaxLength(50)]
        [Required]
        public string lastName { get; set; }
        
        [MaxLength(10)]
        public string suffix { get; set; }
        
        [Required]
        public int emailPromotion { get; set; }
        
        public string additionalContactInfo { get; set; }
        
        public string demographics { get; set; }
        
        [Required]
        public Guid rowguid { get; set; }
        
        [Required]
        public DateTime modifiedDate { get; set; }
    }
}
