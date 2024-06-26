﻿namespace ClinicFlow_Blazor.Models
{
    public class Person
    {
        public int Id { get; set; } 
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";
        public string? Email {  get; set; }
        public string? Cpf { get; set; }

    }
}
