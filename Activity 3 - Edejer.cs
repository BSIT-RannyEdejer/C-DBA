/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class Program {
  static void Main() {
    Console.WriteLine("Enter the number of newly hired males: ");
    int new_male = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Enter the number of newly hired females: ");
    int new_female = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Enter the number of newly hired males: ");
    int perm_male = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Enter the number of newly hired females: ");
    int perm_female = Convert.ToInt32(Console.ReadLine());
    
     Console.WriteLine("Enter the number of newly hired males: ");
    int res_male = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Enter the number of newly hired females: ");
    int res_female = Convert.ToInt32(Console.ReadLine());
    
    double new_total = new_female+new_male;
    double perm_total = perm_female+perm_male;
    double res_total = res_female+res_male;
    
    double nm_percentage = (new_male/new_total)*100;
    double nf_percentage = (new_female/new_total)*100;
    
    double pm_percentage = (perm_male/perm_total)*100;
    double pf_percentage = (perm_female/perm_total)*100;
    
    double rm_percentage = (res_male/res_total)*100;
    double rf_percentage = (res_female/res_total)*100;
    
    Console.WriteLine("Number of hired Employee: " + new_total);

    Console.WriteLine("Male: " +  Math.Round(nm_percentage,2) +"%");
    Console.WriteLine("Female: " +  Math.Round(nf_percentage,2) +"%");
    
    Console.WriteLine("Number of permanent Employee: " + perm_total);

    Console.WriteLine("Male: " +  Math.Round(pm_percentage,2) +"%");
    Console.WriteLine("Female: " +  Math.Round(pf_percentage,2) +"%");
    
    Console.WriteLine("Number of resigned Employee: " + perm_total);

    Console.WriteLine("Male: " +  Math.Round(rm_percentage,2) +"%");
    Console.WriteLine("Female: " +  Math.Round(rf_percentage,2) +"%");

  }
}
