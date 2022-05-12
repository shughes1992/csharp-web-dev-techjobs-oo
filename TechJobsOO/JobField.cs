using System;
namespace TechJobsOO
{
    public class JobField
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }


        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is JobField jobfield &&
                   Id == jobfield.Id;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public override string ToString()
        {
            return Value;
        }
    }

}



//Create a new class called JobField.
//Consider the following questions to help you decide what code to put in the JobField class:
//What fields do ALL FOUR of the classes have in common? 


//Which constructors are the same in ALL FOUR classes?
//Which custom methods are identical in ALL of the classes?
//In JobField, declare each of the common class members.
//Code the constructors.
//Add in any inherited method overrides.
//Finally, to prevent the creation of a JobField object, make this class abstract.
