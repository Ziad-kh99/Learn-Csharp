class Project3
{
    public static void Run()
    {
        string[] myStrings = new string[2] 
            { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
        
        int startAt;
        int EndAt;

        foreach (string myString in myStrings)
        {
            startAt = 0;
            EndAt = myString.IndexOf('.');
            string sentence = myString;

            while (EndAt != -1)
            {
                startAt = 0;

                string subString = sentence.Substring(startAt, EndAt);
                Console.WriteLine(subString);
                
                sentence = sentence.Remove(startAt, EndAt+1).TrimStart();

                EndAt = sentence.IndexOf('.');
            }
            Console.WriteLine(sentence);
        }
    }
}