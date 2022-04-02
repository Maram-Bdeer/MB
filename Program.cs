// See https://aka.ms/new-console-template for more information
 Console.WriteLine("Choose an option:");
    Console.WriteLine("1) add user");
    Console.WriteLine("2) Remove user");
    Console.WriteLine("3) Edit user");
     Console.WriteLine("4) Exit");
    Console.Write("\r\nSelect an option: ");
    int id , age;
string name;
User u;
    switch (Console.ReadLine())
    {
        case "1":
           Add();
            return true;
        case "2":
            Remove();
            return true;
         case "3":
           edit(id,age,name,u);
            return true;
        
        case "4":
            return false;
        default:
            return true;
    }
}
