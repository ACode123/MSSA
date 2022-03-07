using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5._3
{
    public enum SerializeFormat
    {
        Binary,
        XML,
        Json
    }
    [Serializable]
    

    public class Student
    {
        public int Id { get; set; }
        public string Address { get; set; } 
        public string Name { get; set; }
    }
}
