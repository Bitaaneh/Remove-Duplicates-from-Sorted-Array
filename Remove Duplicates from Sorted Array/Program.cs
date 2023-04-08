// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//var tmp = new int[10]{0, 0, 1, 1, 1, 2, 2, 3, 3, 4};
var tmp = new int[3]{0, 0, 1};
RemoveDuplicates(tmp);
 int RemoveDuplicates(int[] nums)
{
    int counter = 0;
    var innerLoopCounter = 0;
    for(int i=0;i<nums.Length-1;i++)
    {
        if(i+1<nums.Length && nums[i] == nums[i+1])
        {
            innerLoopCounter = i ;
            while (innerLoopCounter + 1 < nums.Length)
            {
                if (nums[innerLoopCounter] == nums[innerLoopCounter + 1])
                {
                    innerLoopCounter++;
                }
                else
                {
                    nums[i + 1] = nums[innerLoopCounter + 1];
                    counter++;
                    for(int j=i+1;j<innerLoopCounter+1;j++)
                    {
                        nums[j] = nums[innerLoopCounter + 1];
                    }
                    break;
                }
            }
        }
    }
    

    return counter;
}
