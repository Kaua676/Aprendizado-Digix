using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_07_01_2025
{
    public interface IGerente
    {
    void Autorizar();
    bool ConcedeAumento();
    bool AutorizaLicenca(Empregado empregado);

    }
}