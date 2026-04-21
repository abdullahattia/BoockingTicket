namespace OOP_Assignment1
{
    internal class Program
    {
        static void Main( string[] args )
        {
            Console.Write("Enter Movie Name: ");
            string movie = Console.ReadLine();

            Console.Write("Enter Ticket Type (0 = Standard, 1 = VIP, 2 = IMAX): ");

            int typeInput = int.Parse(Console.ReadLine());

            TicketType type = (TicketType)typeInput;

            Console.Write("Enter Seat Row (A, B, C...): ");
            char row = char.Parse(Console.ReadLine());

            Console.Write("Enter Seat Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter Discount Amount: ");
            double discount = double.Parse(Console.ReadLine());

            Seat seat = new Seat(row , number);
            Ticket ticket = new Ticket(movie , type , seat , price);

            // Before discount
            Console.WriteLine("\n===== Ticket Info =====");
            ticket.PrintTicket();
            Console.WriteLine($"Total (14% tax) : {ticket.CalcTotal(14):F2}");

            // Apply discount
            double before = discount;
            ticket.ApplyDiscount(ref discount);

            Console.WriteLine("\n===== After Discount =====");
            Console.WriteLine($"Discount Before : {before:F2}");
            Console.WriteLine($"Discount After  : {discount:F2}");

            ticket.PrintTicket();
            Console.WriteLine($"Total (14% tax) : {ticket.CalcTotal(14):F2}");

        }

    }

}
