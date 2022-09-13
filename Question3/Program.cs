class Program {

    public static string InputAlert() {
        Console.Write("Input : ");

        return Console.ReadLine();
    }

    public static int ConvertStringToNumber(string Input) {
        if(int.TryParse(Input, out int number)) {
            return number;
        }
        throw new Exception("Please input number");
    }

    public static void Check(int Input, ref string CheckYellow, ref string CheckRed, ref string CheckOrange) {
        while(Input != 0) {
            if(Input >= 4) {
                Input = Input-4;
                CheckRed = "Red\n";
            }
            else if(Input >= 2) {
                Input = Input-2;
                CheckOrange = "Orange\n";
            }
            else if(Input >= 1) {
                Input = Input-1;
                CheckYellow = "Yellow\n";
            }
        }
    }

    public static void Main(string[] args) {
        string CheckYellow = "";
        string CheckRed = "";
        string CheckOrange = "";
        string AlertText = InputAlert();
        int Alert = ConvertStringToNumber(AlertText);
        Check(Alert, ref CheckYellow, ref CheckRed, ref CheckOrange);
        printInfo(CheckYellow, CheckRed, CheckOrange);
    }

    public static void printInfo(string CheckYellow, string CheckRed, string CheckOrange) {
        Console.Write(CheckYellow);
        Console.Write(CheckOrange);
        Console.Write(CheckRed);

    }
}