﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginDB.DAO;

namespace LoginDB.Controle
{
    class Controle1
    {
        private bool temAcesso = false;
        public String mensagem = "";
        private UsuarioDAO usuario;

        public bool Acessar(String email, String senha)
        {
            usuario = new UsuarioDAO();
            temAcesso = usuario.VerificarLoginFire(email, senha);

            if (!usuario.mensagem.Equals("")) mensagem = usuario.mensagem;

            return temAcesso;
           
        }

        public String Cadastrar(String login, String senha)
        {
            usuario = new UsuarioDAO();
            mensagem = usuario.CadastrarLoginFire(login, senha);

            return mensagem;
        }

        internal string Remover(string login)
        {
            usuario = new UsuarioDAO();
            mensagem = usuario.RemoverLoginFire(login);

            return mensagem;
        }
    }
}
