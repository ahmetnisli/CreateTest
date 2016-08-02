using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOluşturmaProgramı
{
   public class Soru
    {
        public int SoruId{ get; set; }
        public string Text { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public string Answer { get; set; }
        public int TestID { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
}
