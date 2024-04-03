// Purpose: Implement the LowerCaseObserver class which implements the 
//IObserver interface and prints the parameter in lower case.
namespace DesignPatterns.Observer;

using DesignPatterns.Observer.Interfaces;
public class LowerCaseObserver : IObserver<string>
{
    public void Update(string param)
    {
        Console.WriteLine(param.ToLower());
    }

}