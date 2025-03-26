namespace Aula_06_01_2025
{
    public enum Estado
    {
        SP,
        RJ,
        MG,
        BA
    }

    public class EstacaoEstado
    {
        public static string GetEstacao(Estado estado)
        {
            switch (estado)
            {
                case Estado.SP:
                    return "Verao";
                case Estado.RJ:
                    return "Outono";
                case Estado.MG:
                    return "Inverno";
                case Estado.BA:
                    return "Primavera";
                default:
                    return "Nao sei";
            }
        }
    }

    public class Cidade
    {
        public string[] Regioes = new string[4] { "Norte", "Nordeste", "Sudeste", "Sul" };

        public string GetRegiao(Estado estado)
        {
            return estado switch
            {
                // É possivel fazer um switch dentro do return porque ele retorna um valor diferente de acordo com o case do switch anterior
                Estado.SP => Regioes[2],
                Estado.RJ => Regioes[1],
                Estado.MG => Regioes[2],
                Estado.BA => Regioes[3],
                _ => "Nao sei"
            };
        }
    }
}