﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DemoCrm.Data.Entities
{
    [Table("BusinessLeads")]
    public class BusinessLead : DemoCrmEntity
    {
        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(150)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(150)]
        public string Company { get; set; }

        [Required]
        [MaxLength(150)]
        public string Email { get; set; }

        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }

        [ForeignKey("StaffMember.Id")]
        [Column("Manager")]
        public Guid StaffMemberId { get; set; }

        [Required]
        [ForeignKey("Company.Id")]
        public Guid CompanyId { get; set; }
    }
}