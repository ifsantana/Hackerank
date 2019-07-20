import java.io.*;
import java.math.*;
import java.text.*;
import java.util.*;
import java.util.regex.*;

// Solution based on this article:
// https://www.khanacademy.org/computing/computer-science/cryptography/modarithmetic/a/the-euclidean-algorithm

public class PossiblePath {

    // Complete the solve function below.
    static String solve(long a, long b, long x, long y) {

        return gcd(a, b) == gcd(x, y) ? "YES" : "NO";
    }

    private static long gcd(long a, long b) {
        
        return a == 0 ? b : gcd(b % a, a);
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        int t = scanner.nextInt();
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int tItr = 0; tItr < t; tItr++) {
            String[] abxy = scanner.nextLine().split(" ");

            long a = Long.parseLong(abxy[0]);

            long b = Long.parseLong(abxy[1]);

            long x = Long.parseLong(abxy[2]);

            long y = Long.parseLong(abxy[3]);

            String result = solve(a, b, x, y);

            bufferedWriter.write(result);
            bufferedWriter.newLine();
        }

        bufferedWriter.close();

        scanner.close();
    }
}
