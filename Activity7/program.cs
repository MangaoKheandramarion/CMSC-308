import java.util.InputMismatchException;
import java.util.Scanner;

public class App {
    public static void main(String[] args) {

        Boolean flag = true;
        double x, y;

        // loops program until user choose exit
        do {
            Scanner scan = new Scanner(System.in);

            System.out.println("Calculator Menu");
            System.out.println("[1] Addition");
            System.out.println("[2] Subtraction");
            System.out.println("[3] Multiplication");
            System.out.println("[4] Division");
            System.out.println("[5] Exponent");
            System.out.println("[6] Modulo \n");
            System.out.println("[7] Exit \n");
            System.out.print("Enter choice [1-7] : ");

            // Catch Input Mismatch exception in scanner
            try {
                switch (scan.nextInt()) {
                    case 1:
                        System.out.println("Enter augend: ");
                        x = scan.nextDouble();
                        System.out.println("Enter addend: ");
                        y = scan.nextDouble();

                        System.out.println(addition(x, y));
                        break;

                    case 2:
                        System.out.println("Enter minuend: ");
                        x = scan.nextDouble();
                        System.out.println("Enter subtrahend: ");
                        y = scan.nextDouble();

                        System.out.println(subtraction(x, y));
                        break;

                    case 3:
                        System.out.println("Enter multiplicand: ");
                        x = scan.nextDouble();
                        System.out.println("Enter multiplier: ");
                        y = scan.nextDouble();

                        System.out.println(multiplication(x, y));
                        break;

                    case 4:
                        System.out.println("Enter dividend: ");
                        x = scan.nextDouble();
                        System.out.println("Enter divisor: ");
                        y = scan.nextDouble();

                        System.out.println(division(x, y));
                        break;

                    case 5:
                        System.out.println("Enter base number: ");
                        x = scan.nextDouble();
                        System.out.println("Enter exponent: ");
                        y = scan.nextDouble();

                        System.out.println(exponent(x, y));
                        break;

                    case 6:
                        System.out.println("Enter dividend: ");
                        x = scan.nextDouble();
                        System.out.println("Enter divisor: ");
                        y = scan.nextDouble();

                        System.out.println(modulo(x, y));
                        break;

                    case 7:
                        System.out.println("Exiting program...");
                        flag = false;
                        scan.close();
                        break;
                    default:
                        System.out.println("Enter numbers 1-7 only!");
                        break;
                }
            } catch (InputMismatchException e) {
                System.out.println("invalid input");
                System.out.println(e);
            }

        } while (flag == true);
    }

    // Operation methods
    public static String addition(double x, double y) {
        double sum = x + y;
        String result = String.format("The sum of %s and %s is %s", x, y, sum);
        return result;
    }

    public static String subtraction(double x, double y) {
        double diff = x - y;
        String result = String.format("The difference of %s and %s is %s", x, y, diff);
        return result;
    }

    public static String multiplication(double x, double y) {
        double prod = x * y;
        String result = String.format("The product of %s and %s is %s", x, y, prod);
        return result;
    }

    public static String division(double x, double y) {
        double quot = x / y;
        String result = String.format("The quotient of %s and %s is %s", x, y, quot);
        return result;
    }

    public static String exponent(double x, double y) {
        double pow = Math.pow(x, y);
        String result = String.format("%s raise to %s is %s", x, y, pow);
        return result;
    }

    public static String modulo(double x, double y) {
        double rem = x % y;
        String result = String.format("The remainder of %s and %s is %s", x, y, rem);
        return result;
    }
}
