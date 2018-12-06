using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{


	public class Solution
	{
		public int[] TwoSum(int[] nums, int target)
		{

			int[,] array2D;


			for (int i = 0; i < nums.Count(); i++)
			{
				int getvalue = target - nums[i];
				//int firstvalue = nums[i];
				//int secondvalue;
				//Console.WriteLine("target is " + target + " first value is " + firstvalue + " and getvalue is "+getvalue);
				for (int j = i+1; j < (nums.Count()-1); j++)
				{
					Console.WriteLine("options " + nums[j]);

					if (nums[j] == getvalue)
					{
						//second value is found
						//secondvalue = nums[j];

						//int firstIndicies = i;
						//int secondIndicies = j;

						//Console.WriteLine("Second value is " + secondvalue);

						array2D = new int[,] { { i, j } };

						Console.WriteLine("values [" + array2D[0,0] + ", " + array2D[0,1] + "]");

						return array2D;

						//if (firstvalue + secondvalue == target)
						//{
						//	array2D = new int[,] { { i, j } };
						//	Console.WriteLine("Array details are" );
						//}
					}

										
				}

			}

			return null;
		}
	}


		class Program
		{
			static void Main(string[] args)
			{

				int[] array1 = new int[] { 2, 7, 11, 15};
				int t2 = 13;

			for (int i = 0; i < array1.Count(); i++)
			{
				Console.WriteLine("The array of numbers are " + array1[i]);
			}
				
				Console.WriteLine("The target is " + t2);

			Solution getindex = new Solution();
			int[] testarray = new int[] { 0 };
			testarray = getindex.TwoSum(array1, t2);
			//Console.WriteLine("The list of indicies are " + testarray[1]);
			//Console.WriteLine("The list of indicies are " + testarray.2d);

		}

		


		}
}
