﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace do_it
{
    static class Program
    {
        public static string activeUser;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLoginSignUp());
        }
    }
}
