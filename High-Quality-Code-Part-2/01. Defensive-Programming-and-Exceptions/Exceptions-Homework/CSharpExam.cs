using System;

public class CSharpExam : Exam
{
    private const int MinGrade = 0;
    private const int MaxGrade = 100;

    private int score;

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

        set
        {
            if (value < MinGrade || value > MaxGrade)
            {
                throw new ArgumentException("Score can not be less than minimum grade and bigger than maximum grade!");
            }

            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        if (this.Score < MinGrade || this.Score > MaxGrade)
        {
            throw new InvalidOperationException("Score can not be less than minimum grade and bigger than maximum grade!");
        }

        return new ExamResult(this.Score, MinGrade, MaxGrade, "Exam results calculated by score.");
    }
}
