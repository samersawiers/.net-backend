using System;
using System.Collections.Generic;

class Question
{
    public string QuestionBody { get; set; }
    public int Marks { get; set; }

    public Question(string body, int marks)
    {
        QuestionBody = body;
        Marks = marks;
    }

    public override string ToString()
    {
        return "Question: " + QuestionBody + " (Marks: " + Marks + ")";
    }
}

class Answer
{
    public int Num { get; set; }
    public string ChooseText { get; set; }

    public Answer(int num, string text)
    {
        Num = num;
        ChooseText = text;
    }

    public override string ToString()
    {
        return "Answer " + Num + ": " + ChooseText;
    }
}

class Program
{
    static void Main()
    {
        List<Question> questions = new List<Question>
        {
            new Question("What is OOP?", 5),
            new Question("Explain polymorphism.", 10)
        };

        Console.WriteLine("Questions List:");
        foreach (var question in questions)
        {
            Console.WriteLine(question.ToString());
        }

        Dictionary<Question, List<Answer>> exam = new Dictionary<Question, List<Answer>>();

        List<Answer> answers1 = new List<Answer>
        {
            new Answer(1, "Object-Oriented Programming"),
            new Answer(2, "Overloading and Inheritance")
        };
        exam[questions[0]] = answers1;

        List<Answer> answers2 = new List<Answer>
        {
            new Answer(1, "Allows objects to share functionality."),
            new Answer(2, "Enhances code reusability.")
        };
        exam[questions[1]] = answers2;

        Console.WriteLine("\nExam Dictionary:");
        foreach (var entry in exam)
        {
            Console.WriteLine(entry.Key.ToString());
            foreach (var answer in entry.Value)
            {
                Console.WriteLine("  " + answer.ToString());
            }
        }
    }
}
