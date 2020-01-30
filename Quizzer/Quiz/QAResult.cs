using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer
{
    class QAResult
    {
        public Question Question;
        public Answer Answer;

        public QAResult(Question q, Answer a)
        {
            Question = q;
            Answer = a;
        }

    }
}
