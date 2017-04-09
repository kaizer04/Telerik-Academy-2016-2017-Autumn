public class SimpleMathExam : Exam
{
    private const int MinProblemsSolved = 0;
    private const int MaxProblemsSolved = 10;

    private int problemsSolved;

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved
    {
        get
        {
            if (this.problemsSolved < MinProblemsSolved)
            {
                return MinProblemsSolved;
            }
            else if (this.problemsSolved > MaxProblemsSolved)
            {
                return MaxProblemsSolved;
            }
            else
            {
                return this.problemsSolved;
            }
        }

        set
        {
            this.problemsSolved = value;
        }
    }
    
    public override ExamResult Check()
    {
        string comment;

        if (this.ProblemsSolved <= 2)
        {
            comment = "Bad result: nothing done.";
        }
        else if (this.ProblemsSolved <= 5)
        {
            comment = "Average result: almost nothing done.";
        }
        else if (this.ProblemsSolved <= 8)
        {
            comment = "Good result: almost everything's done correctly.";
        }
        else
        {
            comment = "Excellent result: everything's done correctly.";
        }

        return new ExamResult(this.ProblemsSolved, MinProblemsSolved, MaxProblemsSolved, comment);
    }
}
