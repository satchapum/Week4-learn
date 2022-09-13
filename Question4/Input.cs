class Input {
    public string Calculate(int AmountNumber, int DiscountNumber) {
        const int Percent = 100;
        int Cost = 100;
        int Lopee = (Cost*AmountNumber)/(AmountNumber+1);
        int Shopzada = (((Cost*AmountNumber)*(Percent-DiscountNumber))/Percent)/(AmountNumber);
        string BestChoice;
        if (Lopee < Shopzada) {
            return BestChoice = "Lapee";
        }
        else if (Lopee > Shopzada) {
            return BestChoice = "Shopzada";
        }
        else {
            return BestChoice = "E-mazon";
        }
    }
}