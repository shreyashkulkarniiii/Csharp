using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    using System;
    public interface IMovable
    {
        void Move();
    }

    public class Machine
    {
        public void Start()
        {
            Console.WriteLine("Machine started.");
        }
    }
    public class Robot : Machine, IMovable
    {
        public void Move()
        {
            Console.WriteLine("Robot is moving.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            robot.Start();
            robot.Move();
        }
    }
}
