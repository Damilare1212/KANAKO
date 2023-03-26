﻿using KANOKO.Contract;
using KANOKO.Identity;

namespace KANOKO.Entity
{
    public class Admin: AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Dispute Dispute { get; set; }
        List<Dispute> Disputes = new List<Dispute>();
    }
}
