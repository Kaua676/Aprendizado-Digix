using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo2
{
    public class Crud
    {
        public void InserirUsuario(int id, string nome, string email)
        {
            using (var db = new Ligacao())
            {
                db.Usuarios.Add(new Usuario { id = id, nome = nome, email = email });
                db.SaveChanges();
            }
        }

        public void ListarUsuario()
        {
            using (var db = new Ligacao())
            {
                var usuarios = db.Usuarios.ToList();
                foreach (var usuario in usuarios)
                {
                    System.Console.WriteLine($"\nId: {usuario.id}\n Nome: {usuario.nome}\n Email: {usuario.email}");
                }
            }
        }

        public void AtualizarUsuario(int id, string novoNome)
        {
            using (var db = new Ligacao())
            {
                var usuario = db.Usuarios.Find(id);
                if (usuario != null)
                {
                    usuario.nome = novoNome;
                    db.SaveChanges();
                    System.Console.WriteLine("Usuário atualizado com sucesso");
                }
                else
                {
                    System.Console.WriteLine("Usuario não encontrado");
                }
            }
        }

        public void DeletarUsuario(int id)
        {
            using (var db = new Ligacao())
            {
                var usuario = db.Usuarios.Find(id);
                if (usuario != null)
                {
                    db.Usuarios.Remove(usuario);
                    db.SaveChanges();
                    System.Console.WriteLine("Usuario deletado com sucesso!");
                }
                else
                {
                    System.Console.WriteLine("Usuario não encontrado");
                }
            }
        }
    }
}