﻿namespace EmployeeManagementApi.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        public int createdBy { get; set; }

        public int? updatedBy { get; set; }

        public bool IsDeleted { get; set; } = false;


    }
}
