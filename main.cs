using System;

public class Program
{
    public static void Main()
    {
        Animal human = new Human();
        human.Move();
        human.Eat();
        
        Animal monkey = new Monkey();
        monkey.Move();
        monkey.Eat();
        
        Animal elephant = new Elephant();
        elephant.Move();
        elephant.Eat();
        
        Animal turtle = new Turtle();
        turtle.Move();
        turtle.Eat();
        
        Animal lizard = new Lizard();
        lizard.Move();
        lizard.Eat();
    }
}