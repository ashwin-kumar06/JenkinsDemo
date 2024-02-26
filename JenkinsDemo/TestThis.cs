namespace JenkinsDemo
{
    public class TestThis
    {
        public string SayHello(int number)
        {
            string output = string.Empty;
            for (int i = 0; i < number; i++)
            {
                output = output + "Hello";
            }
            return output;
        }
    }
}
