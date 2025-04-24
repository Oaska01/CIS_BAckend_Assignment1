using System;

class Program
{

    static void hcf(int n1, int n2){ 
    int small, hcf = 1;
    double fraction;
        
    small = (n1 < n2) ? n1 : n2;
        
    for(int i = 1 ; i <= small; i++){
        if(n1 % i == 0 && n2 %i == 0){
            hcf = i;
        }
    }
        
    Console.Write("HCF " + hcf + "\n");
        
    int sn1 = n1 / hcf;
    int sn2 = n2 / hcf;
        
    // fraction = ((n1 / hcf) / (n2 / hcf));
        
    // Console.Write("The simplified factor is: " + fraction);
        
    Console.Write("The simplified factor is: " + sn1 + "/" + sn2);
    // Console.Write(sn1 + "\n");
    // Console.Write(sn2);
        
     }

    static void Main(string[] args)
    {
        Console.Write("Enter nominator number: ");
        int nominator = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter denominator number: ");
        int denominator = Convert.ToInt32(Console.ReadLine());
     
        hcf(nominator, denominator); 
    }
} 