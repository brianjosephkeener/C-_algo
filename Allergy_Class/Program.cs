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
        public List<KeyValuePair<string, int>> allergy_score_cal(int input) // done
        {
            List<KeyValuePair<string, int>> result = new List<KeyValuePair<string, int>>();
            List<KeyValuePair<string, int>> allergy_list = allergies.OrderByDescending(x => x.Value).ToList();
            for (int i = 0; i < allergy_list.Count; i++)
			{
                if(input - allergy_list[i].Value < 0)
                {
                    continue;
                }
                else if(input - allergy_list[i].Value >= 0)
                {
                    input -= allergy_list[i].Value;
                    result.Add(allergy_list[i]);
                }
			}
            return result;
        }
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

        public Allergy(string name) // done
        {
            this.name = name;
        }

        public Allergy(string name, int score)
        {
            this.name = name;
            List<KeyValuePair<string, int>> assignedAllergies = allergy_score_cal(score);
            foreach (KeyValuePair<string, int> item in assignedAllergies)
            {
                this.p_allergies.Add(item.Key, item.Value);
            }
        }

        public Allergy(string name, params string[] values) // done
        {
            this.name = name;
            for (int i = 0; i < values.Length; i++)
            {
                KeyValuePair<string, int>? temp = allergies.FirstOrDefault(x => x.Key == values[i]);
                if(temp != null)
                {
                    this.p_allergies.Add(temp.Value.Key, temp.Value.Value);
                }
            }
        }

        public new string ToString() // done
        {
            var temp = this.p_allergies.ToList();
            if(this.p_allergies.Count == 0)
            {
                return $"{this.name} has no allergies!";
            }
            else if(this.p_allergies.Count > 0)
            {
                string fstatement = $"{this.name} is allergic to ";
                    if(this.p_allergies.Count == 1)
                    {
                        fstatement+= " " + temp[0].Key + ".";
                        return fstatement;
                    }
                for (int i = 0; i < this.p_allergies.Count; i++)
                {
                    if(this.p_allergies.Count - 1 == i)
                    {
                        fstatement+=temp[i].Key + ".";
                        return fstatement;
                    }
                        fstatement+=temp[i].Key + ", ";
                }
            }
            return "Error in showing person's allergies!";
        }

        private bool IsAllergicTo(object obj) // done
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
        public void AddAllergy(object input) // done
        {
            if(input.GetType() == typeof(string))
            {
                KeyValuePair<string, int>? nameOfAllergy = allergies.FirstOrDefault(x => x.Key == input);
                if(nameOfAllergy != null)
                {
                    this.p_allergies.Add(nameOfAllergy.Value.Key, nameOfAllergy.Value.Value);
                }
            }
            else if(input.GetType() == typeof(int))
            {
                KeyValuePair<string, int>? scoreOfAllergy = allergies.FirstOrDefault(x => x.Value == (int)input);
                if(scoreOfAllergy != null)
                {
                    this.p_allergies.Add(scoreOfAllergy.Value.Key, scoreOfAllergy.Value.Value);
                }
            }
            else
            {
                Console.WriteLine("not an int or string data type");
            }
        }
        public void DeleteAllergy(object input) // done
        {
            if(input.GetType() == typeof(string))
            {
                KeyValuePair<string, int>? nameOfAllergy = p_allergies.FirstOrDefault(x => x.Key == input);
                if(nameOfAllergy != null)
                {
                    this.p_allergies.Remove(nameOfAllergy.Value.Key);
                }

            }
            else if(input.GetType() == typeof(int))
            {
                KeyValuePair<string, int>? scoreOfAllergy = p_allergies.FirstOrDefault(x => x.Value == (int)input);
                if(scoreOfAllergy != null)
                {
                    this.p_allergies.Remove(scoreOfAllergy.Value.Key);
                }
            }
            else
            {
                Console.WriteLine("not an int or string data type");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var mary = new Allergy("Mary");
            Console.WriteLine(mary.ToString());
            var joe = new Allergy("Joe", 65);
            Console.WriteLine(joe.ToString());
            var rob = new Allergy("Rob", "Peanuts", "Chocolate", "Cats", "Strawberries");
            Console.WriteLine(rob.ToString());
            rob.DeleteAllergy("Peanuts");
            rob.DeleteAllergy(128);
            Console.WriteLine(rob.ToString());
            mary.AddAllergy(128);
            mary.AddAllergy("Peanuts");
            Console.WriteLine(mary.ToString());
        }
    }
}
