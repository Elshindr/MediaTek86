﻿using MediaTek.controleur;
using System;
using System.Windows.Forms;

namespace MediaTek
{
    /// <summary>
    /// Classe d'entrée de l'application
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new Controle();
        }
    }
}
