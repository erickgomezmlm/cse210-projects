public class Prompts
{
    public string[] _questions = {"If you could do something differently today, What would it be?", "What was the best part of your day?", "What was a challenge you faced today?", "What is something you want to take away from today?"};
    public string _datenow;
    public string _J_entry;
    public string _pickedq;

    public Prompts()
    {
        DateTime currentdate = DateTime.Now;
        _datenow = currentdate.ToString("MM/dd/yyyy");
    }

    public void Pick_and_ask_q()
    {
        Random random = new Random();
        int randomIndex = random.Next(_questions.Length);
        string random_question = _questions[randomIndex];
        _pickedq = random_question;
        Console.Write($"{random_question} \n>");
        string Response = Console.ReadLine();
        _J_entry =  Response;

        
    }

}

