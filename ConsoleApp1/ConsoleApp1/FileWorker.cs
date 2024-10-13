using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class FileWorker
    {
        private int maxSize { get; set; }
        public abstract string Extension { get; set; }

        public int MaxSize 
        { 
            get {  return maxSize; } 
            set 
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("value can not be negative!");
                } else
                {
                    maxSize = value;
                }
            } 
        }
        public virtual void Read() 
        {
            Console.WriteLine($"I can read from {Extension} file with max storage {MaxSize}");
        }

        public virtual void Write()
        {
            Console.WriteLine($"I can write to {Extension} file with max storage {MaxSize}");
        }

        public virtual void Edit()
        {
            Console.WriteLine($"I can edit {Extension} file with max storage {MaxSize}");
        }

        public virtual void Delete()
        {
            Console.WriteLine($"I can delete {Extension} file with max storage {MaxSize}");
        }
    }
}
