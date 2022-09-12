class Program {

    public static string InputStationNumber() {
        Console.Write("Please input a number of stations: ");

        return Console.ReadLine();
    }

    public static int ConvertStationNumberToText(string StationNumberText) {
        int.TryParse(StationNumberText, out int number);

        return number;
    }

    public static int ConvertToCost(int StationNumber) {
        int[] cost = {16,23,26,30,33,37,40,44,59};
        
        if(StationNumber <= 7) {
            return cost[StationNumber-1];
        }
        else if(StationNumber >= 8 && StationNumber<= 15) {
            return cost[7];
        }
        else {
            return cost[8];
        }
    }

    public static void Main(string[] args) {
        string StationNumberText = InputStationNumber(); 
        int StationNumber = ConvertStationNumberToText(StationNumberText);
        int Cost = ConvertToCost(StationNumber); 

        PrintInfomation(Cost);
    }

    public static void PrintInfomation(int Cost) {
        Console.WriteLine("Cost (THB): {0}", Cost);
    }

}
