class Operation {
    private int Ac;
    private int Month; 
    private int Day;

    public Operation(int Ac, int Month, int Day) {
        this.Ac  = Ac;
        this.Month = Month;
        this.Day = Day;
    }

    public void Check() {
        Meji();
    }

    public void Meji() {
        if((Ac >= 1868 && Ac <= 1911) || (Ac == 1912 && Month <= 7 && Day <= 29)) {
            Console.WriteLine("明治 (เมจิ)Meji");
        }
        else {
            Taisho();
        }
    }
    
    public void Taisho() {
        if((Ac >= 1912 && Ac <= 1925) || (Ac == 1926 && Month <= 12 && Day <= 24)) {
            Console.WriteLine("大正 (ไทโช)Taisho");
        }
        else {
            Showa();
        }
    }
    
    public void Showa() {
        if((Ac >= 1926 && Ac <= 1988) || (Ac == 1989 && Month <= 1 && Day <= 7)) {
            Console.WriteLine("昭和 (โชวะ)Showa");
        }
        else {
            Heze();
        }
    }

    public void Heze() {
        if((Ac >= 1989 && Ac <= 2018) || (Ac == 2019 && Month <= 4 && Day <= 30)) {
            Console.WriteLine("平成 (เฮเซ)Heze");
        }
        else {
            Rewa();
        }
    }
    
    public void Rewa() {
        Console.WriteLine("令和 (เรวะ)Rewa");
    }
}