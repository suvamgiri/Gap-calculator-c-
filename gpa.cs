using System;

class Program {
  public static void Main (string[] args) {
   Console.WriteLine("calculate the Gpa or Cgpa");
Console.Write("enter the science :");
    int science = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter the math :");
    int mathematics = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter the social :");
    int social = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter the english :");
    int english = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter the nepali :");
    int nepali = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter the computer :");
    int computer = Convert.ToInt32(Console.ReadLine());

    int total = science + mathematics + social + english + nepali + computer;
    
double gpa = (double) total / 6 ;
    
pass(gpa);
    point(gpa);
    
    static void pass(double gpa){
    
    if(gpa >90){
      Console.WriteLine("A+");
    }else if (gpa >80){
      Console.WriteLine("A");
    }else if(gpa>70){
      Console.WriteLine("B+");
      
    }else if(gpa>60){
      Console.WriteLine("B");
      }
    else if(gpa>50){
      Console.WriteLine("c+");
      
    }else if(gpa>40){
      Console.WriteLine("c");
    }else{
      Console.WriteLine("fail");
    }

    }
    static void point(double gpa){
      if(gpa >90){
      Console.WriteLine("4.0");
    }else if (gpa >80){
      Console.WriteLine("3.6");
    }else if(gpa>70){
      Console.WriteLine("3.2");
      
    }else if(gpa>60){
      Console.WriteLine("2.8");
      }
    else if(gpa>50){
      Console.WriteLine("2.4");
      
    }else if(gpa>40){
      Console.WriteLine("2.0");
    }else{
      Console.WriteLine("try best");
    }
    }

if(science<40){
  Console.WriteLine("science fail you got this number "+science);
}else if(mathematics<40){
  Console.WriteLine("mathematics fail you got this numbers "+mathematics);
}
    else if(social<40){
      Console.WriteLine("social fail you got this number :"+social);
    
    }else if(english<40){
      Console.WriteLine("english fail you got this number :"+english);
    }else if(nepali<40){
      Console.WriteLine("nepali fail you got this number :"+nepali);
      
    }else if(computer<40){
      Console.WriteLine("computer fail you got this number :"+computer);
    }else{
      Console.WriteLine("pass");
    }
  
    
    }
}
