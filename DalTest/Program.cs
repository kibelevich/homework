﻿using Dal;
using DalApi;
using DO;

namespace DalTest
{ 
    internal class Program
    {
        private static IEngineer? s_dalEngineer = new EngineerImplementation();
        private static ITask? s_dalTask = new TaskImplementation();
        private static IDependency? s_dalDependency = new DependencyImplementation();

        /// <summary>
        /// Crud functions for engineer
        /// </summary>
        private static void createEngineer()
        {
            try {
                int _id;
                EngineerExperiece _level;
                string _name, _email;
                double _cost;
                Console.WriteLine("Enter id, name, email, level, cost");
                int.TryParse(Console.ReadLine()!, out _id);
                _name = Console.ReadLine()!;
                _email = Console.ReadLine()!;
                EngineerExperiece.TryParse(Console.ReadLine()!, out _level);
                double.TryParse(Console.ReadLine()!, out _cost);
                Engineer newEngineer = new(_id, _name, _email, _level, _cost);
                s_dalEngineer!.Create(newEngineer);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        private static void readEngineer()
        {
            int _id;
            Console.WriteLine("Enter engineer's ID");
            int.TryParse(Console.ReadLine()!, out _id);
            Console.WriteLine(s_dalEngineer!.Read(_id));
        }

        private static void readAllEngineers()
        {
            s_dalEngineer!.ReadAll().ForEach(ele =>
            {
                Console.WriteLine(ele);
            });
        }

        private static void updateEngineer()
        {
            try {
                int _id;
                DO.EngineerExperiece _level;
                string _name, _email;
                double _cost;
                Console.WriteLine("Enter id");
                int.TryParse(Console.ReadLine()!, out _id);
                Console.WriteLine(s_dalEngineer!.Read(_id));
                Console.WriteLine("Enter details to update");
                _name = Console.ReadLine()!;
                _email = Console.ReadLine()!;
                EngineerExperiece.TryParse(Console.ReadLine()!, out _level);
                double.TryParse(Console.ReadLine()!, out _cost);
                Engineer newEngineer = new(_id, _name, _email, _level, _cost);
                s_dalEngineer!.Update(newEngineer);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void deleteEngineer()
        {
            try { 
                Console.WriteLine("Enter engineer's ID");
                int _id;
                int.TryParse(Console.ReadLine()!, out _id); 
                s_dalEngineer!.Delete(_id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        // Submenu for engineer
        private static void crudEngineer()
        {
            string choice;
            choice = Console.ReadLine()!;
            do
            {
                switch (choice)
                {
                    case "1":
                        {
                            createEngineer();
                            break;
                        }
                    case "2":
                        {
                            readEngineer();
                            break;
                        }
                    case "3":
                        {
                            readAllEngineers();
                            break;
                        }
                    case "4":
                        {
                            updateEngineer();
                            break;
                        }
                    case "5":
                        {
                            deleteEngineer();
                            break;
                        }
                    default:
                        break;
                }
                crudMenu("engineer");
                choice = Console.ReadLine()!;
            } while (choice != "0");
        }

        /// <summary>
        /// Crud functions for engineer
        /// </summary>
        private static int createTask()
        {
            EngineerExperiece _complexityLevel;
            int _engineerId;
            string? _desciption, _alias, _remarks, _deliverable;
            DateTime _deadline, _createdAt;
            Console.WriteLine("Enter description, alias, dead line, deliverable, remarks, engineer ID, complexity level");
            _desciption = Console.ReadLine();
            _alias = Console.ReadLine();
            _createdAt = DateTime.Now;
            DateTime.TryParse(Console.ReadLine()!, out _deadline);
            _deliverable = Console.ReadLine();
            _remarks = Console.ReadLine();
            int.TryParse(Console.ReadLine()!, out _engineerId);
            EngineerExperiece.TryParse(Console.ReadLine()!, out _complexityLevel);
            DO.Task newTask = new(0, _desciption, _alias, false, _createdAt, null, null, _deadline, null, _deliverable, _remarks, _engineerId, _complexityLevel);
            return s_dalTask!.Create(newTask);
        }
        private static void readTask()
        {
            int _id;
            Console.WriteLine("Enter task's ID");
            int.TryParse(Console.ReadLine()!, out _id);
            Console.WriteLine(s_dalTask!.Read(_id));
        }

        private static void readAllTask()
        {
            s_dalTask!.ReadAll().ForEach(ele =>
            {
                Console.WriteLine(ele);
            });
        }

        private static void updateTask()
        {
            try {
                EngineerExperiece _complexityLevel;
                int ID;
                int _engineerId;
                string? _desciption, _alias, _remarks, _deliverable;
                bool _milestone; 
                DateTime _deadline, _createdAt, _complete, _start, _forecastDate;
                Console.WriteLine("Enter ID");
                int.TryParse(Console.ReadLine()!, out ID); 
                Console.WriteLine(s_dalTask!.Read(ID));
                Console.WriteLine("Enter details to update");
                _desciption = Console.ReadLine();
                _alias = Console.ReadLine();
                bool.TryParse(Console.ReadLine()!, out _milestone);
                _createdAt = DateTime.Now;
                DateTime.TryParse(Console.ReadLine()!, out _start);
                DateTime.TryParse(Console.ReadLine()!, out _forecastDate);
                DateTime.TryParse(Console.ReadLine()!, out _deadline);
                DateTime.TryParse(Console.ReadLine()!, out _complete);
                _deliverable = Console.ReadLine();
                _remarks = Console.ReadLine();
                int.TryParse(Console.ReadLine()!, out _engineerId);
                EngineerExperiece.TryParse(Console.ReadLine()!, out _complexityLevel);
                DO.Task newTask = new(ID, _desciption, _alias, _milestone, _createdAt, _start, _forecastDate, _deadline, _complete, _deliverable, _remarks, _engineerId, _complexityLevel);
                s_dalTask!.Update(newTask);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void deleteTask()
        {
            try { 
                Console.WriteLine("Enter task's ID");
                int _id;
                int.TryParse(Console.ReadLine()!, out _id);
                s_dalTask!.Delete(_id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        // Submenu for task
        private static void crudTask()
        {
            string choice;
            choice = Console.ReadLine()!;
            do
            {
                switch (choice)
                {
                    case "1":
                        {
                            createTask();
                            break;
                        }
                    case "2":
                        {
                            readTask();
                            break;
                        }
                    case "3":
                        {
                            readAllTask();
                            break;
                        }
                    case "4":
                        {
                            updateTask();
                            break;
                        }
                    case "5":
                        {
                            deleteTask();
                            break;
                        }
                    default:
                        break;
                }
                crudMenu("task");
                choice = Console.ReadLine()!;
            } while (choice != "0");

        }

        /// <summary>
        /// Crud functions for engineer
        /// </summary>
        private static int createDependency()
        {
            int _dependsOnTask, _dependentTask;
            Console.WriteLine("Enter, pending task, previous task");
            int.TryParse(Console.ReadLine()!, out _dependentTask);
            int.TryParse(Console.ReadLine()!, out _dependsOnTask);
            Dependency newDependency = new(0, _dependentTask, _dependsOnTask);
            return s_dalDependency!.Create(newDependency);
        }
        private static void readDependency()
        {
            int _id;
            Console.WriteLine("Enter dependency's ID");
            int.TryParse(Console.ReadLine()!, out _id);
            Console.WriteLine(s_dalDependency!.Read(_id));
        }

        private static void readAllDependencies()
        {
            s_dalDependency!.ReadAll().ForEach(ele =>
            {
                Console.WriteLine(ele);
            });
        }

        private static void updateDependency()
        {
            try { 
                int ID, _dependsOnTask, _dependentTask;
                Console.WriteLine("Enter ID");
                int.TryParse(Console.ReadLine()!, out ID);
                Console.WriteLine(s_dalDependency!.Read(ID));
                int.TryParse(Console.ReadLine()!, out _dependentTask);
                int.TryParse(Console.ReadLine()!, out _dependsOnTask);
                Dependency newDependency = new(ID, _dependentTask, _dependsOnTask);
                s_dalDependency!.Update(newDependency);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void deleteDependency()
        {
            try { 
                Console.WriteLine("Enter dependency's ID");
                int _id;
                int.TryParse(Console.ReadLine()!, out _id);
                s_dalDependency!.Delete(_id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        // Submenu for dependency
        private static void crudDependency()
        {
            string choice;
            choice = Console.ReadLine()!;
            do
            {
                switch (choice)
                {
                    case "1":
                        {
                            createDependency();
                            break;
                        }
                    case "2":
                        {
                            readDependency();
                            break;
                        }
                    case "3":
                        {
                            readAllDependencies();
                            break;
                        }
                    case "4":
                        {
                            updateDependency();
                            break;
                        }
                    case "5":
                        {
                            deleteDependency();
                            break;
                        }
                    default:
                        break;
                }
                crudMenu("dependency");
                choice = Console.ReadLine()!;
            } while (choice != "0");
        }

        // Prints the entity's options 
        private static void crudMenu(string entity)
        {    
            Console.WriteLine($"Choose:\n 0 to exit\n 1 to create a new {entity}\n 2 to read the {entity}\n" +
            $" 3 to read all\n 4 to update the {entity}\n 5 to delete the {entity}\n"); 
        }

        // Main menu - entity selection 
        private static void mainMenu()
        {
            Console.WriteLine("Choose:\n 0 to exit\n 1 to engineer\n 2 to task\n 3 to dependency\n");
            string choice;
            choice = Console.ReadLine()!;
            do
            {
                switch (choice)
                {
                    case "1":
                        {
                            crudMenu("engineer");
                            crudEngineer();
                            break;
                        }
                    case "2":
                        {
                            crudMenu("task");
                            crudTask();
                            break;
                        }
                    case "3":
                        {
                            crudMenu("dependency");
                            crudDependency();
                            break;
                        }
                }
                Console.WriteLine("Choose:\n 0 to exit\n 1 to engineer\n 2 to task\n 3 to dependency\n");
                choice = Console.ReadLine()!;
            } while (choice != "0");
        }
        static void Main()
        {
            try
            {
                Initialization.Do(s_dalEngineer, s_dalTask, s_dalDependency);
                mainMenu();
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

    
