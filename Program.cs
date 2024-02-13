using System.Drawing;
using StunningPancake;

namespace StunningPancake
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            Robot robot = new Robot();
            for (int i = 0; i < robot.Commands.Length; i++)
            {
                string input1 = Console.ReadLine();
                if (input1 == "on")
                {
                    OnCommand onCommand = new OnCommand();
                    robot.Commands[i] = onCommand;
                }
                else if (input1 == "off")
                {
                    OffCommand offCommand = new OffCommand();
                    robot.Commands[i] = offCommand;
                }
                else if (input1 == "north")
                {
                    NorthCommand northCommand = new NorthCommand();
                    robot.Commands[i] = northCommand;
                }
                else if (input1 == "south")
                {
                    SouthCommand southCommand = new SouthCommand();
                    robot.Commands[i] = southCommand;
                }
                else if (input1 == "west")
                {
                    WestCommand westCommand = new WestCommand();
                    robot.Commands[i] = westCommand;
                }
                else if (input1 == "east")
                {
                    EastCommand eastCommand = new EastCommand();
                    robot.Commands[i] = eastCommand;
                }
            }
                robot.Run();
        }
    }
    public class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsPowered { get; set; }
        public IRobotCommand?[] Commands { get; } = new IRobotCommand?[3];
        public void Run()
        {
            foreach (IRobotCommand? command in Commands)
            {
            command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
            }
        }
    }
    public interface IRobotCommand
    {
        void Run(Robot robot);
    }
    public class OnCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            robot.IsPowered = true;
        }
    }
    public class OffCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            robot.IsPowered = false;
        }
    }
    public class NorthCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            robot.Y = robot.Y + 1;
        }
    }
    public class SouthCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            robot.Y = robot.Y - 1;
        }
    }
    public class EastCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            robot.X = robot.X + 1;
        }
    }
    public class WestCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            robot.X = robot.X - 1;
        }
    }

}
