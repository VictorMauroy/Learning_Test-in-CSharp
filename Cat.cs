using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_CSharp
{
    public class Cat
    {
        public string Name { get; set; }
        /// <summary>
        /// Age in years
        /// </summary>
        public int Age { get; set; } 
        public float Weigth { get; set; }

        /// <summary>
        /// Constructor of the Cat class
        /// </summary>
        /// <param name="name">Name of your cat</param>
        /// <param name="weigth">Current weigth of your cat</param>
        public Cat(string name, int age, float weigth) 
        {
            Name = name;
            Age = age;
            Weigth = weigth;
        }
        
        /// <summary>
        /// Add weigth in kg to your cat.
        /// </summary>
        /// <param name="weigthToAdd">Weigth in kg to add</param>
        /// <returns>new weigth of your cat</returns>
        public float RaiseWeigth(float weigthToAdd)
        {
            Weigth+= weigthToAdd;
            return Weigth;
        }

        public int UpdateAge(int newAge)
        {
            Age = newAge;
            return Age;
        }
        
        public string GetCatProfile()
        {
            return Name + ": " + Age + " years old has a weigth of " + Weigth + "kg.";
        }
    }
}
