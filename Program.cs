using System;

public class Program
{
    static string name;
    static string age;
    static string eyeColor;
    static string hairColor;
    static string shoeSize;
    static string favoriteColor;
    static string favoriteTVorMovie;
    static string favoriteTeacher;
    static string favoriteClass;
    static string favoriteHoliday;
    static string favoriteSeason;
    static string dreamJob;
    static string numberOfSiblings;


    public static void Main(string[] args)
    {
        AskName();
        AskAge();
        AskEyeColor();
        AskHairColor();
        AskShoeSize();
        AskFavoriteColor();
        AskFavoriteTvShow();
        AskFavoriteTeacher();
        AskFavoriteClass();
        AskFavoriteHoliday();
        AskFavoriteSeason();
        AskDreamJob();
        AskNumberOfSiblings();
        DisplaySummaryMessage();
    }


    public static string AskName()
    {
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
        return name;
    }

    public static string AskAge()
    {
        Console.WriteLine("What is your age?");
        age = Console.ReadLine();
        return age;
    }

    public static string AskEyeColor()
    {
        Console.WriteLine("What is your eye color?");
        eyeColor = Console.ReadLine();
        return eyeColor;
    }

    public static string AskHairColor()
    {
        Console.WriteLine("What is your hair color?");
        hairColor = Console.ReadLine();
        return hairColor;
    }

    public static string AskShoeSize()
    {
        Console.WriteLine("What is your shoe size?");
        shoeSize = Console.ReadLine();
        return shoeSize;
    }

    public static string AskFavoriteColor()
    {
        Console.WriteLine("What is your favorite color?");
        favoriteColor = Console.ReadLine();
        return favoriteColor;
    }

    public static string AskFavoriteTvShow()
    {
        Console.WriteLine("What is your favorite tv show or movie?");
        favoriteTVorMovie = Console.ReadLine();
        return favoriteTVorMovie;
    }

    public static string AskFavoriteTeacher()
    {
        Console.WriteLine("What is your favorite teacher?");
        favoriteTeacher = Console.ReadLine();
        return favoriteTeacher;
    }

    public static string AskFavoriteClass()
    {
        Console.WriteLine("What is your favorite class?");
        favoriteClass = Console.ReadLine();
        return favoriteClass;
    }

    public static string AskFavoriteHoliday()
    {
        Console.WriteLine("What is your favroite holiday?");
        favoriteHoliday = Console.ReadLine();
        return favoriteHoliday;
    }

    public static string AskFavoriteSeason()
    {
        Console.WriteLine("What is your favorite season?");
        favoriteSeason = Console.ReadLine();
        return favoriteSeason;
    }

    public static string AskDreamJob()
    {
        Console.WriteLine("What is your dream job?");
        dreamJob = Console.ReadLine();
        return dreamJob;
    }

    public static int AskNumberOfSiblings()
    {
        Console.WriteLine("how many siblings do you have?");
        int numberOfSiblings = int.Parse(Console.ReadLine());
        return numberOfSiblings;
    }

    public static void DisplaySummaryMessage()
    {
        Console.WriteLine("OK, just to make sure, your name is " + name + " , your age is " + age + " and you will be " + (age + 5) + " in 5 years, you have " + numberOfSiblings + " siblings, you have " + eyeColor + " eyes, you have " + hairColor + " hair, your shoe size is " + shoeSize + ", your favorite color is " + favoriteColor + ", your favorite movie or TV show is " + favoriteTVorMovie + ", your favorite teacher is " + favoriteTeacher + ", your favorite class is " + favoriteClass + ", your favorite holiday is " + favoriteHoliday + ", your favorite season is " + favoriteSeason + ", and your dream job is " + dreamJob + ". Did i get all of that?");
    }
}