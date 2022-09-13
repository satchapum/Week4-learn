class Program {

    public static string InputAc() {
        Console.Write("Please input AC: ");

        return Console.ReadLine();
    }
    
    public static string InputMonth() {
        Console.Write("Please input Month: ");

        return Console.ReadLine();
    }

    public static string InputDay() {
        Console.Write("Please input Day: ");

        return Console.ReadLine();
    }

    public static int ConvertstringToInt(string Input) {
        int.TryParse(Input, out int number);

        return number;
    }
    
    public static void Main(string[] args) {
        string AcText = InputAc();
        string MonthText = InputMonth();
        string DayText = InputDay();
        int AcNumber = ConvertstringToInt(AcText);
        int MonthNumber = ConvertstringToInt(MonthText);
        int DayNumber = ConvertstringToInt(DayText);
        Operation Inputs = new Operation(AcNumber, MonthNumber, DayNumber);

        Inputs.Check();
    }
}