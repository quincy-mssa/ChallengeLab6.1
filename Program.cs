namespace ChallengeLab6._1
{
    internal class Program
    {
        //**Challenge Lab 6.1**
        //Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

        //**Approach**
        //create a dictionary to keep a tally of how many times each number appears.
        //loop through each element of the array and update the tally count in the dictionary.
        //loop through the dictionary to find the number with a count of 1.
        //return that number as the single number.

        static void Main(string[] args)
        {
            //hard code array
            int[] nums = { 4, 1, 2, 1, 2 };
            //call method
            int singleNumber = FindSingleNumber(nums);
            //print results
            Console.WriteLine($"The single number is: {singleNumber}");
        }

        static int FindSingleNumber(int[] nums)
        {
            //dictionary numberCounts
            var numberCounts = new Dictionary<int, int>();

            //count how many times each number appears
            foreach (int num in nums)
            {
                if (numberCounts.ContainsKey(num))
                {
                    numberCounts[num]++;
                }
                else
                {
                    numberCounts[num] = 1;
                }
            }

            //find the number that appears only once
            foreach (var pair in numberCounts)
            {
                if (pair.Value == 1)
                {
                    return pair.Key;
                }
            }

            return -1;
        }
    }
}
