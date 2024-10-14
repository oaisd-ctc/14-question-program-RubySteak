using System;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ok pal, i'm gonna need you to enter in some info down below (it will totally not be sold to the dark web)");
        Console.WriteLine("name?");
        String name = Console.ReadLine();

        Console.WriteLine("age?");
        String age = Console.ReadLine();

        Console.WriteLine("Yes... Excellent... \nAlright, im now gonna ask some questions about your apperance.");
        Console.WriteLine("eye color?");
        String eye_color = Console.ReadLine();
    
        Console.WriteLine("hair color?");
        String hair_color = Console.ReadLine();

        Console.WriteLine("shoe size? (dont question why im asking this)");
        String shoe_size = Console.ReadLine();

        Console.WriteLine("Alright, now for some questions about your favorite things \nfavorite color?");
        String favorite_color = Console.ReadLine();

        Console.WriteLine("favorite movie/show?");
        String favorite_movie = Console.ReadLine();

        Console.WriteLine("favorite teacher?");
        String favorite_teacher = Console.ReadLine();

        Console.WriteLine("favorite class?");
        String favorite_class = Console.ReadLine();

        Console.WriteLine("favorite holiday?");
        String favorite_holiday = Console.ReadLine();

        Console.WriteLine("favorite season?");
        String favorite_season = Console.ReadLine();

        Console.WriteLine("dream job?");
        String job = Console.ReadLine();

        Console.WriteLine("lastly, how many siblings do you have?");
        String siblings = Console.ReadLine();

        int age_five_years = int.Parse(age);

        Console.WriteLine("alrighty, just to conform: \nYour name is " + name + ", you are " + age + " years old and will be " + (age_five_years + 5) + " in 5 years, you have " + siblings + " siblings, you have " + eye_color + " eyes, you have " + hair_color + " hair, your shoe size is " + shoe_size + ", your favorite color is " + favorite_color + ", your favorite movie or TV show is " + favorite_movie + ", your favorite teacher is " + favorite_teacher + ", your favorite class is " + favorite_class + ", your favorite holiday is " + favorite_holiday + ", your favorite season is " + favorite_season + ", and your dream job is " + job + ". Did i get all of that?");
        
        Console.ReadKey();
    }
}
