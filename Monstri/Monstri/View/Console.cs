using System;
using System.Collections.Generic;
using System.Text;

namespace Monstri.View
{
    
    internal class Console
    {

        private admonstr.admonstr monstr;

        public Console(string path)
        {
            try
            {
                monstr = new admonstr.admonstr(path);
                consolepusk();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }

        private void consolem()
        {
            System.Console.WriteLine("com - список команд");
            System.Console.WriteLine("ml - список Монстров");
            System.Console.WriteLine("addm - добавить нового Монстра");
            System.Console.WriteLine("ex - Закрыть приложение");
        }

        public void consolepusk()
        {
            consolem();
            while (true)
            {
                try
                {
                    switch (Consolestart("Введите команду...").ToLower())
                    {
                        case "com": consolem(); break;
                        case "ml": ListMonstr(); break;
                        case "addm": AddMonstr(); break;
                        case "ex": Environment.Exit(0); break;
                        default:
                            System.Console.WriteLine("Неверная команда"); break;
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }
        }

        private void AddMonstr()
        {
            string name = Consolestart("Кого хотим добавить?");
            string yoa = Consolestart("Напишите год происхождения");
            string from = Consolestart("Откуда он?");
            string peculiarities = Consolestart("Укажите его особенности");
            monstr.Add(name, yoa, from, peculiarities);
            System.Console.WriteLine("Монстрик добавлен.");
            ListMonstr();
        }

        private void ListMonstr()
        {
            if (monstr.Monstrs.Count == 0)
            {
                System.Console.WriteLine("Монстров еще нету(");
                return;
            }

            foreach (var item in monstr.Monstrs)
            {
                System.Console.WriteLine(item);
            }
        }

        private string Consolestart(string v)
        {
            System.Console.WriteLine(v);
            var s = System.Console.ReadLine();
            if (string.IsNullOrWhiteSpace(s))
            {
                System.Console.WriteLine("некоректный ввод");
                return Consolestart(v);
            }
            return s.TrimStart().TrimEnd();
        }
    }
}

