import java.io.*;
import java.math.*;
import java.security.*;
import java.text.*;
import java.util.*;
import java.util.concurrent.*;
import java.util.regex.*;

public class HackerlandRadioTransmitters {

    // Complete the hackerlandRadioTransmitters function below.
    static int hackerlandRadioTransmitters(int[] x, int k) {
        TreeSet<Integer> treeSet = convertArrayToSet(x);
        Integer current = treeSet.ceiling(0);
        int transmitters = 0;

        while(current != null)
        {
            transmitters++;
            current = treeSet.floor(current+k);
            current = treeSet.ceiling(current+k+1);
        }
        
        return transmitters;
    }



    public static TreeSet<Integer> convertArrayToSet(int[] arr)
    {
        TreeSet<Integer> mySet = new TreeSet<Integer>();

        for(int i = 0; i < arr.length; i++) {
            mySet.add(arr[i]);
        }

        return mySet;
    }

    private static final Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) throws IOException {
        BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(System.getenv("OUTPUT_PATH")));

        String[] nk = scanner.nextLine().split(" ");

        int n = Integer.parseInt(nk[0]);

        int k = Integer.parseInt(nk[1]);

        int[] x = new int[n];

        String[] xItems = scanner.nextLine().split(" ");
        scanner.skip("(\r\n|[\n\r\u2028\u2029\u0085])?");

        for (int i = 0; i < n; i++) {
            int xItem = Integer.parseInt(xItems[i]);
            x[i] = xItem;
        }

        int result = hackerlandRadioTransmitters(x, k);

        bufferedWriter.write(String.valueOf(result));
        bufferedWriter.newLine();

        bufferedWriter.close();

        scanner.close();
    }
}
