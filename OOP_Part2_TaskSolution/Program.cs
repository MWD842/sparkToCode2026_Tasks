namespace OOP_Part2_TaskSolution
{
    public class Room
    {
        public string roomNumber;
        public string roomType;
        public double pricePerNight;
        public bool isAvailable;

        public Room(string roomNumber, string roomType, double pricePerNight)
        {
            this.roomNumber = roomNumber;
            this.roomType = roomType;
            this.pricePerNight = pricePerNight;
            this.isAvailable = true;
        }

        public void displayRoom()
        {
            string status = isAvailable ? "Available" : "Booked";
            Console.WriteLine($"Room {roomNumber} | {roomType} | {pricePerNight} OMR | {status}");
        }
    }

    public class Guest
    {
        public string guestId;
        public string guestName;
        public string roomNumber;
        public string checkInDate;
        public int totalNights;

        public Guest(string guestId, string guestName, string checkInDate, int totalNights)
        {
            this.guestId = guestId;
            this.guestName = guestName;
            this.roomNumber = "Not Assigned";
            this.checkInDate = checkInDate;
            this.totalNights = totalNights;
        }

        public void displayGuest()
        {
            Console.WriteLine($"{guestId} | {guestName} | Room {roomNumber} | {checkInDate} | {totalNights} nights");
        }

        public double calculateTotalCost(double pricePerNight)
        {
            return pricePerNight * totalNights;
        }
    }

    public class Program
    {
        static List<Room> rooms = new List<Room>();
        static List<Guest> guests = new List<Guest>();
        static void Main(string[] args)
        {
            rooms.Add(new Room("101", "Single", 25));
            rooms.Add(new Room("102", "Single", 25));
            rooms.Add(new Room("201", "Double", 40));
            rooms.Add(new Room("202", "Double", 40));
            rooms.Add(new Room("301", "Suite", 75));
            rooms.Add(new Room("302", "Suite", 75));

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n================================================");
                Console.WriteLine("   GRAND VISTA HOTEL — MANAGEMENT SYSTEM");
                Console.WriteLine("================================================");
                Console.WriteLine(" 1. Add New Room");
                Console.WriteLine(" 2. Register New Guest");
                Console.WriteLine(" 3. Book a Room for a Guest");
                Console.WriteLine(" 4. View All Rooms");
                Console.WriteLine(" 5. View All Guests");
                Console.WriteLine(" 6. Search & Filter Rooms");
                Console.WriteLine(" 7. Guest & Booking Statistics");
                Console.WriteLine(" 8. Update Room Price");
                Console.WriteLine(" 9. Guest Lookup by Name");
                Console.WriteLine("10. Room Type Breakdown Report");
                Console.WriteLine("11. Check Out a Guest");
                Console.WriteLine("12. Remove Unavailable Rooms");
                Console.WriteLine("13. Extend Guest Stay");
                Console.WriteLine("14. Highest Revenue Booking");
                Console.WriteLine("15. Guest Pagination Viewer");
                Console.WriteLine(" 0. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                if (!int .TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number!");
                    continue;
                }
                
                switch (choice)
                {
                    case 1: AddNewRoom(); break;
                    case 2: RegisterNewGuest(); break;
                    case 3: BookRoom(); break;
                    case 4: ViewAllRooms(); break;
                    case 5: ViewAllGuests(); break;
                    case 6: SearchFilterRooms(); break;
                    case 7: GuestBookingStatistics(); break;
                    case 8: UpdateRoomPrice(); break;
                    case 9: GuestLookupByName(); break;
                    case 10: RoomTypeBreakdown(); break;
                    case 11: CheckOutGuest(); break;
                    case 12: RemoveUnavailableRooms(); break;
                    case 13: ExtendGuestStay(); break;
                    case 14: HighestRevenueBooking(); break;
                    case 15: GuestPaginationViewer(); break;
                    case 0:
                        exit = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Choose 0-15.");
                        break;
                }
            }
        }

        static void AddNewRoom()
        {
            Console.Write("Enter room number: "); 
            string roomNumber = Console.ReadLine();

            Console.Write("Enter room type (Single / Double / Suite): ");
            string roomType = Console.ReadLine();

            Console.Write("Enter price per night: ");
            if (!double.TryParse(Console.ReadLine(), out double price))
            {
                Console.WriteLine("Invalid price. Please enter a number.");
                return;
            }
            if (price <= 0)
            {
                Console.WriteLine("Price must be a positive number.");
                return;
            }

            if (rooms.Any(r => r.roomNumber == roomNumber))
            {
                Console.WriteLine("A room with that number already exists.");
                return;
            }

            rooms.Add(new Room(roomNumber, roomType, price));

            Console.WriteLine("======= Room Added =======");
            Console.WriteLine($"Room {roomNumber} | {roomType} | {price} OMR | Available");
            Console.WriteLine($"Total rooms: {rooms.Count}");
        }

        static void RegisterNewGuest()
        {
            Console.Write("Enter guest name: ");
            string guestName = Console.ReadLine();

            Console.Write("Enter the date: ");
            string checkInDate = Console.ReadLine();

            Console.Write("Enter the number of nights: ");
            if (!int.TryParse(Console.ReadLine(), out int nights))
            {
                Console.WriteLine("Invalid format. Please enter a number."); return;
            }
            if (nights<=0)
            {
                Console.WriteLine("Number of nights must be a positive number."); return;
            }

            string guestId = "G" + (guests.Count + 1).ToString("D3");

            guests.Add(new Guest(guestId, guestName, checkInDate, nights));

            Console.WriteLine("======= Guest Registered =======");
            Console.WriteLine($"Guest ID: {guestId}");
            Console.WriteLine($"Name: {guestName} | Check-in: {checkInDate} | Nights: {nights}");
            Console.WriteLine($"Room: Not Assigned");
        }
    }
}
