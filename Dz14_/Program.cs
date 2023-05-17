namespace Dz14_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter task (1 - 2): ");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.Write("\nEnter title of piece: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter PIB of author of piece: ");
                        string PIB = Console.ReadLine();
                        Console.Write("Enter genre of piece (Tragedy, Comedy, Drama, Tragicomedy, Melodrama, Historical, Farce, Experimental, Morality, Interactive): ");
                        string genre = Console.ReadLine();
                        Console.Write("Enter year of piece: ");
                        int year = int.Parse(Console.ReadLine());

                        using (Piece piece = new Piece(name, PIB, genre, year))
                        {
                            piece.Show();
                        }

                        break;
                    case 2:
                        Console.Write("\nEnter title of shop: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter address of shop: ");
                        string address = Console.ReadLine();
                        Console.Write("Enter type of shop (Grocery, Hardware, Clothing, Shoes): ");
                        string type = Console.ReadLine();

                        using (Shop shop = new Shop(title, address, type))
                        {
                            shop.Show();
                        }

                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
        }
    }
}