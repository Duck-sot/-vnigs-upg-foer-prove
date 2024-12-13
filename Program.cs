/*
int a = Convert.ToInt32(Console.ReadLine());
if (a<0){
    Console.WriteLine("negative");
}
if (a == 0){
    Console.Write("0");
}
if ( a > 0 ){
    Console.WriteLine("posetive");
}

List<string> vege = new List<string>();
vege.Add("tomato");
vege.Add("apple");
vege.Add("wattermellon");
vege.Add("mango");

foreach (string element in vege){
    Console.WriteLine(element);
}

C c = new C();
int i = 0;
Add(c);
AddInt(ref i);

Console.WriteLine(c.num);
Console.WriteLine(i);

void Add(C c){
    c.num++;
}

void AddInt(ref int num){
    num++;
}
class C {
    public int num = 2;
}
*/



class Car {

    private string model; 
    private string brand; 
    private int årsmodel; 
    public string Model{
        set{model = value;}
        get{return model;}
    }
    public string Brand{
        set{brand = value;}
        get{return brand;}
    }
    public int Årsmodel{
        set{ årsmodel=value;}
        get{return årsmodel;}
    }
    public Car(string model, string brand, int årsmodel){
        Console.WriteLine(model);
        
    }



}
