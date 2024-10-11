void Main (){
    Console.WriteLine("enter your whight in kg");
    double kg = double.Parse(Console.ReadLine());
    Console.WriteLine("entert your hight in meater");
    double m= double.Parse(Console.ReadLine());
    Console.WriteLine(bmi);
}
string bmi (double m , double kg){
    double blo = kg / (m * m);
    if(blo<18.5){
        string bmi = "underwhight";
    }
    if(blo>18.5 && blo<24.9){
        string bmi = "Normal";
        return bmi;
    }
    if (blo>=25 && blo<=29.9){
        string bmi = "over";
        return bmi;
    }
    if(blo>=30){
        string bmi = "obes";
        return bmi;
    }
}