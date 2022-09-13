class Program {

    public static string InputAmount() {
        Console.Write("Input Amount : ");

        return Console.ReadLine();
    }

    public static string InputDiscount() {
        Console.Write("Input Discount : ");

        return Console.ReadLine();
    }

    public static int ConvertStringToInt(string input) {
        if(int.TryParse(input, out int number)) {
            return number;
        }

        throw new Exception("Please input number");
    }

    public static void Main(string[] args) {
        string Amount = InputAmount();
        string Discount = InputDiscount();
        int AmountNumber = ConvertStringToInt(Amount);
        int DiscountNumber = ConvertStringToInt(Discount);

        Input input = new Input();
        string BestChoice = input.Calculate(AmountNumber, DiscountNumber);
        PrintInfo(BestChoice);
    }

    public static void PrintInfo(string Input) {
        Console.WriteLine("Best choice = {0}", Input);
    }
}