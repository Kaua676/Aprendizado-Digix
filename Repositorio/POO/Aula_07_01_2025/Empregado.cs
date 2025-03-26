using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_07_01_2025
{
    public class Empregado : Pessoa
    {
        protected double dSalario;
        protected double dSalarioMinimo = 240.00;
        protected int iLicencasPremioRecebidas;
        public TipoEmpregado Tipo { get; set; }
        public StatusLicenca StatusLicencaAtual { get; set; }

        public Empregado(string name, TipoEmpregado tipo) : base(name)
        {
            Tipo = tipo;
            dSalario = dSalarioMinimo;
            StatusLicencaAtual = StatusLicenca.Pendente;
        }

        public virtual double GetSalario()
        {
            return dSalario;
        }

        public void SetSalario(double salario)
        {
            dSalario = salario;
        }

        public int GetLicencasPremioRecebidas()
        {
            return iLicencasPremioRecebidas;
        }

        public void SetLicencasPremioRecebidas(int licencas)
        {
            iLicencasPremioRecebidas = licencas;
        }
    }
}