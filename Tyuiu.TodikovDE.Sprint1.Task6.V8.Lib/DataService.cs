using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.TodikovDE.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            value = string.Join("", value.Skip(1)) + value[0];
            return value;
        }
    }
}
