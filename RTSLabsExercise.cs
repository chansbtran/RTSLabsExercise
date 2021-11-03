using System;
using System.Collections.Generic;
					
public class RTSLabsExercise
{
	/**
	  * Compares a value to a list of integers to count values above and below. Ignores values that are equal.
	  *
	  *	@param {int[]} collection - array containing the collection of integers
	  *	@param {int} compareVal - an integer representing the comparison value
	  *	@returns {Dictionary<string, int>} Mapping with keys 'above' and 'below' with corresponding count of integers from list
	 **/
	public Dictionary<string, int> aboveBelow(List<int> collection, int compareVal) {
		// create mapping of values above and below comparison value
		Dictionary<string, int> mapping = new Dictionary<string, int>();
		mapping.Add("above", 0);
		mapping.Add("below", 0);
		foreach(int val in collection) {
			// checks if value is above comparison val
			if (val > compareVal) {
				mapping["above"] = mapping["above"] + 1;
			}
			// checks if value is below comparison val
			else if (val < compareVal) {
				mapping["below"] = mapping["below"] + 1;
			}
			else {
				// Do nothing, values are equal
			}
		}
		// output to display for user to see, can comment out
		Console.WriteLine("{\"above\": " + mapping["above"] + ", \"below\": " + mapping["below"] + "}");
		return mapping;
	}
	
	/**
	  * Rotates characters in original string by rotation amount. Overflow will appear at beginning.
	  *
	  *	@param {string} original - the original string
	  *	@param {int} rotation - positive rotation amount
	  *	@returns {string} New string that has been rotated
	 **/
	public string stringRotation(string original, int rotation) {
		// checks if rotation amount is positive, 
		if (rotation > 0) {
			// calculates for over-rotation of the string
			// if rotation value is greater than string length, continue rotating
			if (rotation > original.Length) {
				rotation = rotation % original.Length;
			}
			string newStr = original.Substring(original.Length - rotation) + original.Substring(0, (original.Length - rotation));
			return newStr;
		}
		// returns original string since conditions are not met
		else {
			return original;
		}
	}
	
	/**
	  *	Main method for testing purposes
	  **/
	public static void Main()
	{
		List<int> collection = new List<int>() {1,3,9,5,2,3,4,5,6};
		RTSLabsExercise temp = new RTSLabsExercise();
		Dictionary<string, int> test1 = temp.aboveBelow(collection, 9);
		string test2 = temp.stringRotation("MyString", 12);
		// Print out string for display
		Console.WriteLine(test2);
	}
}
