using InlämningsuppgiftKennel.Data;
using InlämningsuppgiftKennel.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace InlämningsuppgiftKennel
{
    public class Application : IApplication
    {
        public IDataBaseUsingLists Db { get; set; }
        public IMainMenu MainMenu { get; set; }

        public Application(IDataBaseUsingLists databaseUsingLists, IMainMenu mainMenu)
        {
            Db = databaseUsingLists;
            MainMenu = mainMenu;
        }
        public void Run()
        {
            while (true)
            {
                MainMenu.ShowMenu();
                MainMenu.GetInput();
            }
            
        }
    }

}
