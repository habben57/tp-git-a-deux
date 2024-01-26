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
    src.PeopleContainer mylist = new src.PeopleContainer(list);
    while(nbPerson < 3)
    {
        Console.WriteLine("Saisissez votre nom: ");
        nom=Console.ReadLine();
        Console.WriteLine("Saisissez votre prenom: ");
        prenom=Console.ReadLine();
        nbPerson++;
        src.Person myPerson = new src.Person(nom, prenom);
        mylist.personnes.Add(myPerson);
    }
    for(int i = 0; i < 3; i++)
    {
        Console.WriteLine(mylist.personnes[i].nom+ " " +mylist.personnes[i].prenom);
    }
