using System;

public abstract class Animal
{
    public abstract void Move();
    
    public void Eat()
    {
        Console.WriteLine("The animal eat food.");
    }
}

public abstract class Biped : Animal
{
    public override void Move()
    {
        Console.WriteLine("The animal moves using its two limbs.");
    }
}

public abstract class Quadruped : Animal
{
    public override void Move()
    {
        Console.WriteLine("The animal moves using its four limbs.");
    }
}

public class Human : Biped
{
    public override void Move()
    {
        Console.WriteLine("The human walks on two legs.");
    }
}

public class Monkey : Biped
{
    public override void Move()
    {
        Console.WriteLine("The monkey moves from tree to tree.");
    }
}

public class Elephant : Quadruped
{
    public override void Move()
    {
        Console.WriteLine("The elephant walks with its four legs.");
    }
}

public class Turtle : Quadruped
{
    public override void Move()
    {
        Console.WriteLine("The turtle moves slowly with its four legs.");
    }
}

public class Lizard : Quadruped
{
    public override void Move()
    {
        Console.WriteLine("The lizard moves with its four legs.");
    }
}