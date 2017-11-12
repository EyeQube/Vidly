using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }
        public virtual MembershipType MembershipType { get; set; }   //Lazy loading by adding "Virtual"

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? Birthdate { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte MembershipTypeId { get; set; }

        


    }
}