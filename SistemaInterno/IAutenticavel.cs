﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bytebank_ADM.Funcionarios;

namespace Bytebank_ADM.SistemaInterno
{
    public interface IAutenticavel
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha);
        
    }
}



