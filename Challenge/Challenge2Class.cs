using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Challenge
{
    public class Challenge2Class
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            
            public int Age { get; set; }
            
            public override bool Equals(object obj)
            {
                if (obj is Person p)
                {
                    return Equals(p);
                }
                return false;
            }

            public bool Equals(Person obj)
            {
                return GetHashCode() == obj.GetHashCode();
            }

            public override int GetHashCode()
            {
                var firstC = FirstName.First();
                var lastC = LastName.First();
                return HashCode.Combine(firstC,lastC);
            }
        }

        /// <summary>
        ///  Calculate the number of unique Initials among the people input.
        ///  "John Smith" has initials "JS", "Jane Stevens" has initials "JS", there is one unique initial between them.
        /// </summary>
        /// <param name="people">A collection of people with different names</param>
        /// <returns>Total number of unique Initials among the people given</returns>
        public static int Challenge2(IEnumerable<Person> people)
        {
            var hs = new HashSet<Person>(people);
            return hs.Count;
        }
    }
}