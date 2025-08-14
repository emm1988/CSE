using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Current Score: {_score} points");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": running = false; break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            string status = goal.IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {status} {goal.GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nSelect goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string typeChoice = Console.ReadLine();

        Console.Write("What is the name of the goal? ");
        string name = Console.ReadLine();
        Console.Write("What is the description of the goal? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (typeChoice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (typeChoice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (typeChoice == "3")
        {
            Console.Write("What is the bonus for accomplishing this goal? ");
            int bonus = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Which goal did you accomplish? Select goal number to record: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            goal.RecordEvent();
            _score += goal.GetPoints();

            if (goal is ChecklistGoal checklist && checklist.IsComplete())
            {
                _score += checklist.GetBonus();
            }
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save goals: ");
        string fileName = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter(fileName))
        {
            sw.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                sw.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load goals: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("No such file found.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(fileName);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (type == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                                             int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
            }
        }
        Console.WriteLine("Goals loaded.");
    }
}



            