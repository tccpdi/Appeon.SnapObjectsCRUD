using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using SnapObjects.Data;

namespace AdventureWorks.Models
{
    [FromTable("Person", Schema = "Person")]
    public class Person
    {
        [Key]
        [Required]
        public int BusinessEntityID { get; set; }
        
        [Required]
        public string PersonType { get; set; }
        
        [Required]
        public int NameStyle { get; set; }
        
        string Title { get; set; }
        
        [Required]
        public string FirstName { get; set; }
        
        public string MiddleName { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
        public string Suffix { get; set; }
        
        [Required]
        public int EmailPromotion { get; set; }
        
        public string additionalContactInfo { get; set; }
        
        public string demographics { get; set; }
        
        [Required]
        public Guid rowguid { get; set; }
        
        [Required]
        public DateTime ModifiedDate { get; set; }
    }
}
