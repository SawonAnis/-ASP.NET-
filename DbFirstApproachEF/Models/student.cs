namespace DbFirstApproachEF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int age { get; set; }
        public int standard { get; set; }
    }
}
