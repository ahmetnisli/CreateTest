using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOluşturmaProgramı
{
   public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int QuestionQuantity { get; set; }
        public string TeacherName { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
