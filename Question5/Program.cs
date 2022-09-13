class Program {

    public static string InputWidth() {
        Console.Write("Please input width : ");

        return Console.ReadLine();
    }

    public static int ConvertStringToInt(string input) {
        if(int.TryParse(input, out int number)) {
            if(number % 2 == 0) {
            return number;
            }
            else if(number <= 0) {
            throw new Exception("Please input a positive integer.");
            }
            else {
            throw new Exception("Please input an even positive integer.");
            }
        }
        throw new Exception("Please input an integer.");
    }

    public static int CalDoor1(int widthNumber) {
        int Door1 = (widthNumber/2);

        return Door1;
    }

    public static int CalDoor2(int widthNumber) {
        int Door2 = (widthNumber/2)+1;

        return Door2;
    }

    public static void Main(string[] args) {
        string width = InputWidth();
        int widthNumber = ConvertStringToInt(width);
        int calDoor1 = CalDoor1(widthNumber);
        int calDoor2 = CalDoor2(widthNumber);

        PrintInfo(calDoor1, calDoor2);
    }
    public static void PrintInfo(int calDoor1, int calDoor2) {
        Console.WriteLine("Door1 = {0}",calDoor1);
        Console.WriteLine("Door2 = {0}",calDoor2);
    } 
}
