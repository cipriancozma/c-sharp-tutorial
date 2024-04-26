

Console.WriteLine("Hello!\n");


string[] resultsUserChoice = { "S", "A", "R", "E" };

bool isValidResponse = false;
List<string> todos = new List<string>();
string userChoice;
do
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");
    userChoice = Console.ReadLine().ToUpper();

    if (resultsUserChoice.Contains(userChoice))
    {
        if (userChoice == "A")
        {
            Console.WriteLine("Enter a TODO description: ");
            string description = Console.ReadLine().Trim();

            if (description == "")
            {
                do
                {
                    Console.WriteLine("The description cannot be empty.");
                    Console.WriteLine("Enter a TODO description: ");
                    description = Console.ReadLine().Trim();
                } while (description == "");

            }
            else if (todos.Contains(description))
            {
                Console.WriteLine("The description must be unique.\n");
            }
            else
            {
                todos.Add(description);
                Console.WriteLine("TODO succesfully added: " + description + "\n");
            }
        }
        else if (userChoice == "S")
        {
            if (todos.Count > 0)
            {
                getTodos(todos);
            }
            else
            {
                Console.WriteLine("No todos in the list.");
            }
        }
        else if (userChoice == "R")
        {
            bool isIndexValid = false;

            while (!isIndexValid)
            {
                Console.WriteLine("Select the index of the TODO you want to remove: ");
                getTodos(todos);
                string userInput = Console.ReadLine().Trim();

                if (userInput == "")
                {
                    Console.WriteLine("Selected index cannot be empty.");
                    continue;
                }

                if (int.TryParse(userInput, out int index) &&
                        index >= 1 && index <= todos.Count)
                {
                    var idxTodo = index - 1;
                    var todosRemoved = todos[idxTodo];
                    todos.RemoveAt(idxTodo);
                    isIndexValid = true;
                    Console.WriteLine("TODO removed: " + todosRemoved);
                } else
                {
                    Console.WriteLine("The index is not valid.");
                }
            }
        } else if(userChoice == "E")
        {
            System.Environment.Exit(0);
        }
    }

    else
    {
        Console.WriteLine("Invalid choice.\n");
    }
} while (!isValidResponse);


void getTodos(List<string> todos)
{
    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine((i + 1) + "." + todos[i]);
    }
}


Console.ReadKey();