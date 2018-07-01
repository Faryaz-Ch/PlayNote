using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Paractical_2_Q1
{
    /// <summary>
    /// PlayNote code
    /// C# code for the ProcessNotes method. When run, the program should produce an output similar to the following:  
    /// The Note D is played for 19 seconds or The Note C is played for 25 seconds
    /// Author: Faryaz
    /// </summary>
    
    class Note

    {
        //Public properties
        public string Pitch { get; set; }
        public int Duration { get; set; }
        public Note(string p, int d)//Two parameterized constructor
        {
            Pitch = p;
            Duration = d;
        }

        public void PlayNote()
        {
            WriteLine($"The Note {Pitch} is played for {Duration} seconds");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Note[] notesArray = {
                new Note("D",19),
                new Note("C",20),
                new Note("F",31),
                new Note("B",45),
                new Note("C", 73),
            };
            ProcessNotes(notesArray);
        }
        static void ProcessNotes(Note[] notes)
        {
            int sum = 0;
            foreach (Note n in notes)
            {
                n.PlayNote();
                sum += n.Duration;

            }

            WriteLine($"Total Duration of Notes {sum} Seconds.");
        }

    }

}
