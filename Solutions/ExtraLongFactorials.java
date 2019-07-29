import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class Solution {

    // Complete the extraLongFactorials function below.
    static void extraLongFactorials(int n) {
        System.out.println(factorial(n));
    }

    static String factorial(int n)
    {
       BigInteger factorial = new BigInteger("1");

       for (int i = 1; i <= n; i++) {
           factorial = factorial.multiply(new BigInteger(i + ""));
       }
       return factorial.toString();
    }


    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        int n = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        extraLongFactorials(n);

        scanner.close();
    }
}
