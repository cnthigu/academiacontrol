﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula_99
{
    internal class Globais
    {
        public static string versao = "1.0";
        public static Boolean logado = false;
        public static int nivel = 0;
        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "banco_academia.db";
        public static string caminhoBanco = caminho+@"\banco\";




        // N_IDUSUARIO, T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO, T_STATUSUSUARIO, N_NIVELUSUARIO
    }
}
