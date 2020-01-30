using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer
{
    class Question
    {

        public Int32 ID;
        public String Q;
        public String A;
        public String B;
        public String C;
        public String D;
        public Int16 Correct = 0;
        public Int16 Difficulty;
        public bool Valid;

        public Question(Int32 id, String question, String choiceA, String choiceB, String choiceC, String choiceD, Int16 correct, Int16 difficulty)
        {
            if (difficulty < 0 || difficulty > 2 || question == String.Empty || choiceA == String.Empty || choiceB == String.Empty || choiceC == String.Empty || choiceD == String.Empty)
            {
                Valid = false;
                return;
            }
            ID = id;
            Q = question;
            A = choiceA;
            B = choiceB;
            C = choiceC;
            D = choiceD;
            Correct = correct;
            Difficulty = difficulty;
            Valid = true;
        }

    }
}
