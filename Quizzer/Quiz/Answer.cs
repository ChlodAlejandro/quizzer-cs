using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer
{
    class Answer
    {
        public Question Q;
        public String A;
        public bool Correct;
        public long TimeMiliseconds;
        
        public Answer(Question question, String answer, bool correct, long miliTime)
        {
            Q = question;
            A = answer;
            Correct = correct;
            TimeMiliseconds = miliTime;
        }
    }
}
