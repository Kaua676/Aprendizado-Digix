using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio_1
{
    public class Crud
    {
        // CRUD USUARIOS
        public void InserirUsuario(int id, string password, string nome_usuario, int ramal, string especialidade)
        {
            using (var db = new Ligacao())
            {
                db.Usuarios.Add(new Usuarios { Id_Usuario = id, Password = password, Nome_Usuario = nome_usuario, Ramal = ramal, Especialidade = especialidade }); // Primeiro o atributo e depois o parametro
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
                    System.Console.WriteLine($"\nId: {usuario.Id_Usuario}\n Senha: {usuario.Password}\n Nome: {usuario.Nome_Usuario}\n Ramal: {usuario.Ramal}\n Especialidade: {usuario.Especialidade}\n");
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
                    usuario.Nome_Usuario = novoNome;
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

        // CRUD MAQUINA
        public void InserirMaquina(int id, string tipo, int velocidade, int hard_disk, int placa_rede, int memoria_ram, int fk_usuario)
        {
            using (var db = new Ligacao())
            {
                db.Maquinas.Add(new Maquina { Id_Maquina = id, Tipo = tipo, Velocidade = velocidade, Hard_Disk = hard_disk, Placa_Rede = placa_rede, Memoria_Ram = memoria_ram, Id_Usuario = fk_usuario });
                db.SaveChanges();
            }
        }

        public void ListarMaquina()
        {
            using (var db = new Ligacao())
            {
                var maquinas = db.Maquinas.ToList();
                foreach (var maquina in maquinas)
                {
                    System.Console.WriteLine($"\nId: {maquina.Id_Maquina}\n Tipo: {maquina.Tipo}\n Velocidade: {maquina.Velocidade}\n HardDisk: {maquina.Hard_Disk}\n Placa de Rede: {maquina.Placa_Rede}\n Memoria Ram: {maquina.Memoria_Ram}");
                }
            }
        }

        public void AtualizarMaquina(int id, string tipo)
        {
            using (var db = new Ligacao())
            {
                var maquinas = db.Maquinas.Find(id);
                if (maquinas != null)
                {
                    maquinas.Tipo = tipo;
                    db.SaveChanges();
                    System.Console.WriteLine("Maquina atualizada com sucesso");
                }
                else
                {
                    System.Console.WriteLine("Maquina não encontrada");
                }
            }
        }

        public void DeletarMaquina(int id)
        {
            using (var db = new Ligacao())
            {
                var maquina = db.Maquinas.Find(id);
                if (maquina != null)
                {
                    db.Maquinas.Remove(maquina);
                    db.SaveChanges();
                    System.Console.WriteLine("Maquina deletada com sucesso!");
                }
                else
                {
                    System.Console.WriteLine("Maquina não encontrada");
                }
            }
        }

        // CRUD SOFTWARE
        public void InserirSoftware(int id, string produto, int hard_disk, int memoria_ram, int fk_maquina)
        {
            using (var db = new Ligacao())
            {
                db.Softwares.Add(new Software { Id_Software = id, Produto = produto, Hard_Disk = hard_disk, Memoria_Ram = memoria_ram, Id_Maquina = fk_maquina });
                db.SaveChanges();
            }
        }

        public void ListarSoftware()
        {
            using (var db = new Ligacao())
            {
                var software = db.Softwares.ToList();
                foreach (var softwares in software)
                {
                    System.Console.WriteLine($"\nId: {softwares.Id_Software}\n Produto: {softwares.Produto} HardDisk: {softwares.Hard_Disk}\n Memoria Ram: {softwares.Memoria_Ram}");
                }
            }
        }

        public void AtualizarSoftware(int id, string produto)
        {
            using (var db = new Ligacao())
            {
                var software = db.Softwares.Find(id);
                if (software != null)
                {
                    software.Produto = produto;
                    db.SaveChanges();
                    System.Console.WriteLine("Software atualizado com sucesso");
                }
                else
                {
                    System.Console.WriteLine("Software não encontrada");
                }
            }
        }

        public void DeletarSoftware(int id)
        {
            using (var db = new Ligacao())
            {
                var software = db.Softwares.Find(id);
                if (software != null)
                {
                    db.Softwares.Remove(software);
                    db.SaveChanges();
                    System.Console.WriteLine("Software deletada com sucesso!");
                }
                else
                {
                    System.Console.WriteLine("Software não encontrada");
                }
            }
        }
    }
}