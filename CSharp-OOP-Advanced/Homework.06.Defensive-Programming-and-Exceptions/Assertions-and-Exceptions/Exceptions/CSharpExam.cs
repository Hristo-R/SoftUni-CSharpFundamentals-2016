namespace Exceptions_Homework
{
    using System;

    public class CSharpExam : Exam
    {
        private const int MinScore = 0;
        private const int MaxScore = 100;
        private int score = 0;
        
        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            } 

            private set
            {
                if (this.score < MinScore)
                {
                    throw new ArgumentException(string.Format("Invalid score value. Score must be bigger than {0}", MinScore));
                }
                
                if (this.score > MaxScore)
                {
                    throw new ArgumentException(string.Format("Invalid score value. Score must be smaller than {0}", MaxScore));
                }
            } 
        }

        public override ExamResult Check()
        {
            var examResult = new ExamResult(this.Score, MinScore, MaxScore, "Exam results calculated by score.");
            return examResult;
        }
    }
}
