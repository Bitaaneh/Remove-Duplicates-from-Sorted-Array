#region Problem 
//Given an integer array nums sorted in non-decreasing order,
//remove the duplicates in-place such that each unique element appears only once.
//The relative order of the elements should be kept the same. Then return the number of unique elements in nums.
//Consider the number of unique elements of nums be k, to get accepted, you need to do the following things:
//Change the array nums such that the first k elements of nums contain the unique elements in the order they were
//present in nums initially. The remaining elements of nums are not important as well as the size of nums.
#endregion 


#region solution

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
#endregion
