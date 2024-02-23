using Session_05;

Console.WriteLine("Welcome to the ActionResolver Program");

// Create an Action Request based on what we want to do 
// and give it the input we want to provide to the program
var actionRequest = new ActionRequest()
{
    Input = "Achilleas",
    Action = ActionEnum.Uppercase
};

// Create a resolver to handle the different types of execution
var actionResolver = new ActionResolver();

// Get back from the program the Action Response with the results
// from the Execute() function
ActionResponse actionResponse = actionResolver.Execute(actionRequest);

// Show the messages we want for the user to see, in our example
// the uppercase word and all the messages, or errors stored in our logger
// during the execution of the program
Console.WriteLine(actionResponse.Output);
actionResolver.Logger.ReadAll();