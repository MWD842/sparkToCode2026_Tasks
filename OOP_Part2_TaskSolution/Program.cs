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
}
