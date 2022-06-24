using System;
using System.Collections.Generic;
using System.Linq;

/*

Allergy Class

Create an Allergies class that holds a person's name and the things s/he is allergic to. 
Each allergy has a unique score value.

By combining the scores for each allergy suffered by a person 
their overall allergy score is obtained. 
For example, if someone was allergic to Peanuts, Tomatoes, and Pollen, their allergy score would be 2 (Peanuts) + 16 (Tomatoes) + 64 (Pollen)
their allergy score would be 82.

---Allergy---Score---
*********************
Eggs - 1
Peanuts - 2
Shellfish - 4
Strawberries - 8
Tomatoes - 16
Chocolate - 32
Pollen - 64
Cats - 128
********************

--------------------
Constructors

One or more constructors allowing the following instantiations:

var mary = new Allergies("Mary") ➞ Mary initially has no allergies
var joe = new Allergies("Joe", 65) ➞ Joe is allergic to Eggs (1) and Pollen (64)
var rob = new Allergies("Rob", "Peanuts Chocolate Cats Strawberries") 
➞ Rob is allergic to Peanuts, Strawberries, Chocolate, and Cats.

-------------------

Methods
ToString() ⁠— (override) returns a string in one of the following forms

1. "Mary has no allergies!"
2. "Fred is allergic to Peanuts."
3. "Joe is allergic to Eggs and Pollen."
4. "Rob is allergic to Peanuts, Strawberries, Chocolate, and Cats."

IsAllergicTo() ⁠— taking either a string parameter (e.g. "Pollen") or an Allergen enum value and returning true or false depending on whether the person is allergic to the given allergen.

AddAllergy() ⁠— taking string or Allergen parameter as above and updating the Score property by adding the numeric value of the given allergen.

DeleteAllergy() ⁠— taking string or Allergen parameter as above and updating the Score property by subtracting the numeric value of the given allergen.
-------------------
*/

namespace Allergy_Algo
{
    class Allergy
    {
        public Dictionary<string, int> allergies = new Dictionary<string, int>
        {
            { "Eggs", 1 },
            { "Peanuts", 2 },
            { "Shellfish", 4 },
            { "Strawberries", 8 },
            { "Tomatoes", 16 },
            { "Chocolate", 32 },
            { "Pollen", 64 },
            { "Cats", 128 }
        };

        public Dictionary<string, int> p_allergies = new Dictionary<string, int>(){};
        public string name;

        public Allergy(string name)
        {
            this.name = name;
        }

        private string ToString()
        {
            if(this.p_allergies.Count == 0)
            {
                return $"{this.name} has no allergies!";
            }
            else
            {
                return "";
            }
        }

        private bool IsAllergicTo(object obj)
        {
            if(obj.GetType() == typeof(string))
            {
                string? nameOfAllergy = p_allergies.FirstOrDefault(x => x.Key == obj).Key;
                if(nameOfAllergy != null)
                {
                   return true;
                }
                return false;
            }
            else if(obj.GetType() == typeof(int))
            {
                int? scoreOfAllergy = p_allergies.FirstOrDefault(x => x.Value == (int)obj).Value;
                if(scoreOfAllergy != null)
                {
                   return true;
                }
                return false; 
            }
            else
            {
                Console.WriteLine("not an int or string data type");
                return false;
            }
        }
        private void AddAllergy()
        {

        }
        private void DeleteAllergy()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
