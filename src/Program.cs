// See https://aka.ms/new-console-template for more information

using src;

Console.WriteLine("Hello, World!");

    string nom;
    string prenom;
    int nbPerson = 0;
    List<Person> list= new List<Person>();

    //Console.WriteLine("Saisissez votre nom: ");
    //nom=Console.ReadLine();

    //Console.WriteLine("Saisissez votre prenom: ");
    //prenom=Console.ReadLine();

    //Console.WriteLine(myPerson.nom +" "+myPerson.prenom);
    PeopleContainer mylist = new PeopleContainer(list);
    while(nbPerson < 3)
    {
        Console.WriteLine("Saisissez votre nom: ");
        nom=Console.ReadLine();
        Console.WriteLine("Saisissez votre prenom: ");
        prenom=Console.ReadLine();
        nbPerson++;
        Person myPerson = new Person(nom, prenom);
        mylist.Personnes.Add(myPerson);
    }
    for(int i = 0; i < 3; i++)
    {
        Console.WriteLine(mylist.Personnes[i].nom+ " " +mylist.Personnes[i].prenom);
    }
