//Menybasert console app
//Intro til objekter - JS/ vs c# objekt
//Hundehviskeren - 
/*
 let dog = {
color: 'black',
race: 'pitbull',
size: 'large',
toys: [],
age: 10,
name: 'Fido',
sex: 'female'
}
*/

//Pause til 13.30
using Hundehviskeren;

int age = 0;
//int[] numbers = new int[10];
//Dog[] dogs = new Dog[10];

Dog bjarne = new Dog("bjarne", 3);
Dog kåre = new Dog("kåre", 1);

//List<Dog> dogsInApp = new List<Dog>() { bjarne,kåre, new Dog("truls",5)};

//Dog chosenDog = new Dog();
bool isRunning = true;
while (isRunning)
{
    Menu();
}

void Menu()
{
    Console.WriteLine("Welcome to the dog park");
   // Console.WriteLine("1. Choose dog");
    Console.WriteLine("2. Feed dog");
    Console.WriteLine("3. Play with dog");
    Console.WriteLine("4. Show cupcake");
    Console.WriteLine("5. exit app");

    var input = Console.ReadLine();
    Console.WriteLine($"brukeren tastet {input}");

    switch (input)
    {
        case "2":
            bjarne.Eat();
            break;
        case "3":
            bjarne.Play();
            break;
        case "4":
            kåre.StareIntoTHeAbyssInCorner();
            break;
        case "5":
            isRunning = false;
            break;
        default:
            Console.WriteLine("Incorrect choice. Shutting down");
            Environment.Exit(0);
            break;

    }

 
}

void chooseDog()
{
    Console.WriteLine("Do you want to choose Bjarne? Y/N");
    var answer = Console.ReadLine();
    if (answer == "Y")
    {
        //chosenDog = bjarne;
    }
    else
    {
       // chosenDog = kåre;
    }
}