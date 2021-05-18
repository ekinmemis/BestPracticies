using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class Shell
    {
        private Hashtable _commands;
        private const string _name = "FreeCSD";
        private string _version = "1.0.0.0";

        public string Name => _name;
        public string Version { get => _version; set => _version = value; }

        public Shell()
        {
            Console.Clear();
            Console.WriteLine("{0} ver: {1} ", _name, _version);
            Console.WriteLine("=================");
            Console.Beep(440, 1500);

            _commands = new Hashtable();
            _commands.Add("lst", new ListCommand());
            _commands.Add("mkd", new MakeDirCommand());
            _commands.Add("quit", new QuitCommand());
            _commands.Add("dlt", new DelCommand());
        }

        public void CommandTest()
        {
            Console.Write("> ");
            string cmdText = Console.ReadLine();

            string[] content = cmdText.Split(' ');

            if (content.Length == 1)
                AcceptCommand(content[0], "");
            else if (content.Length == 2)
                AcceptCommand(content[0], content[1]);
            else
                Console.WriteLine("Bad Command!");

        }

        private void AcceptCommand(string cmd, string path)
        {
            if (_commands.ContainsKey(cmd))
            {
                Command command = (Command)_commands[cmd];
                command.Path = path;
                command.Execute();
            }
            else
            {
                Console.Beep();
                Console.WriteLine("Bad Command!");
            }
        }

    }
}
