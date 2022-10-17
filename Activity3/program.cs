import java.util.Scanner;
public class App {

    public static void main(String[] args) {  
    Scanner scan = new Scanner(System.in);
    double English,Math,Science,Mapeh,ave;
    System.out.println("English:");
    English = scan.nextDouble();
    System.out.println("Math");
    Math = scan.nextDouble();
    System.out.println("Science");
    Science = scan.nextDouble();
    System.out.println("Mapeh");
    Mapeh = scan.nextDouble();
    ave = (English/4) + (Math/4) + (Science/4) + (Mapeh/4);
    System.out.println("Average: " + ave);

    System.out.println(ave);

    if(ave>100){
        System.out.println("Invalid");
    }else if(ave>=98 && ave<=100){
        System.out.println("with Highest Honor");
    }else if(ave>=95 && ave<=97.99){
        System.out.println("with High Honor");     
    }else if (ave>=90 && ave<=94.99){
        System.out.println("with Honor");
    }else if (ave>=75 && ave<=89.99){
        System.out.println("Passed");
    }else if (ave<75){
        System.out.println("Failed");
     }
   
    }
    
}
