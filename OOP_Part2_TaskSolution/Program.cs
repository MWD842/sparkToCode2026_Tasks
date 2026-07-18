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
}
