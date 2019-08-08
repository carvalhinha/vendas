using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace VendaProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Menu menu = new Menu();
                menu.TelaD();
                menu.Tela();
            }
            catch
            {
                Menu menu = new Menu();
                menu.Tela();
            }
        }
    }
}
