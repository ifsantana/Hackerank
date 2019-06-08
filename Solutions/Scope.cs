using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;

	// Add your code here
    public Difference(int[] elements)
    {
        this.elements = elements;
        
        computeDifference();
    }

    public void computeDifference()
    {
        int length = this.elements.Length;
        int finalElement = this.elements[length-1];

        for(int i = 0; i < length; i++)
        {
            int current = this.elements[i];

            for(int j = 0; j < length; j++)
            {
                int result = 0;

                if(current != this.elements[j] && j < length)
                {
                    if(current > this.elements[j])
                    {
                        result = current - this.elements[j];
                    }
                    else
                    {
                        result = this.elements[j] - current;
                    } 
                    
                    if(i == 0)
                    {
                        this.maximumDifference = result;
                    }
                    else
                    {
                        calculateDiff(result);
                    }
                }
            }
        }
    }

    void calculateDiff(int result)
    {
        if(result > this.maximumDifference)
            this.maximumDifference = result;
    }

} // End of Difference Class

class Scope {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}
