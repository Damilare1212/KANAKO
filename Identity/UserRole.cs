﻿using KANOKO.Contract;

namespace KANOKO.Identity
{
    public class UserRole: AuditableEntity
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Role { get; set; }
    }
}
