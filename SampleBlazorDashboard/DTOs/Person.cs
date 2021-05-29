using System;

namespace SampleBlazorDashboard.DTOs
{
    public class Person
    {
        public int Id => new Random().Next(0, 10000);
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}