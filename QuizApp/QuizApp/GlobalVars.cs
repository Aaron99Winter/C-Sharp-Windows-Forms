using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class GlobalVars
    {
        //All public variables can be accessed anywhere in the application//
        public static string strForname;
        public static string strSurname; //these variables store users first and second name respectively in strings

        public static int intTotal = 0; //keeps track of the total questions answered \
        public static int intCorrectAnswers; //tracks total correct answers        using integer datatype
        public static int intIncorrectAnswers; //tracks total incorrect answers   /   

        //Quiz 1
        public static int intComponentsCorrect1;
        public static int intComponentsIncorrect1; //variables for the correct and incorrect scores for quiz 1

        //Quiz 2
        public static int intComponentsCorrect2;
        public static int intComponentsIncorrect2; //variables for the correct and incorrect scores for quiz 2
    }
}
