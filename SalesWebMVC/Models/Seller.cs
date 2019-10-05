﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double BasicSalary { get; set; }
        public DateTime BirthDate { get; set; }

        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() { }
        public Seller(int id, string name, string email, double basicSalary, DateTime birthDate, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BasicSalary = basicSalary;
            BirthDate = birthDate;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales
                .Where(s => s.Date >= initial && s.Date <= final)
                .Select(s => s.Amount)
                .DefaultIfEmpty(0.0)
                .Sum();
        }
    }
}
