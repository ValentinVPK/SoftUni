using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "course start")
                {
                    int counter = 1;
                    foreach (string lesson in schedule)
                    {
                        Console.WriteLine($"{counter}.{lesson}");
                        counter++;
                    }
                    break;
                }
                List<string> listOfCommands = command.Split(":").ToList();

                string typeOfMethod = listOfCommands[0];
                string lessonTitle = listOfCommands[1];
                int lessonTitleIndex = schedule.IndexOf(lessonTitle);

                switch (typeOfMethod)
                {
                    case "Add":
                        if (!schedule.Contains(lessonTitle))
                        {
                            schedule.Add(lessonTitle);
                        }
                        break;
                    case "Insert":
                        int index = int.Parse(listOfCommands[2]);
                        if (!schedule.Contains(lessonTitle))
                        {
                            schedule.Insert(index, lessonTitle);
                        }
                        break;
                    case "Remove":
                        if (schedule.Contains(lessonTitle))
                        {
                            if (schedule.Contains($"{lessonTitle}-Exercise")) schedule.Remove($"{lessonTitle}-Exercise");
                            schedule.Remove(lessonTitle);
                        }
                        break;
                    case "Swap":
                        string anotherLessonTitle = listOfCommands[2];
                        int anotherLessonIndex = schedule.IndexOf(anotherLessonTitle);

                        schedule[lessonTitleIndex] = anotherLessonTitle;
                        schedule[anotherLessonIndex] = lessonTitle;

                        string exercise = lessonTitle + "-Exercise";
                        if (schedule.Contains(exercise))
                        {
                            schedule.Remove(exercise);
                            if (anotherLessonIndex == schedule.Count - 1)
                            {
                                schedule.Add(exercise);
                            }
                            else
                            {
                                schedule.Insert(anotherLessonIndex + 1, exercise);
                            }

                        }

                        exercise = anotherLessonTitle + "-Exercise";
                        if (schedule.Contains(exercise))
                        {
                            schedule.Remove(exercise);
                            if (lessonTitleIndex == schedule.Count - 1)
                            {
                                schedule.Add(exercise);
                            }
                            else
                            {
                                schedule.Insert(lessonTitleIndex + 1, exercise);
                            }
                        }
                        break;
                    case "Exercise":
                        if (!schedule.Contains(lessonTitle))
                        {
                            schedule.Add(lessonTitle);
                            schedule.Add($"{lessonTitle}-Exercise");
                        }
                        else if (schedule.Contains(lessonTitle) && !schedule.Contains($"{lessonTitle}-Exercise"))
                        {
                            if (lessonTitleIndex == schedule.Count - 1)
                            {
                                schedule.Add($"{lessonTitle}-Exercise");
                            }
                            else
                            {
                                schedule.Insert(lessonTitleIndex + 1, $"{lessonTitle}-Exercise");
                            }
                        }
                        break;
                }
            }
        }
    }
}
