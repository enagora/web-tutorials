using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeldasPersonalizadas
{
    class Juego
    {
        public string ImageUri { get; set; }
        public string Titulo { get; set; }
        public string Plataforma { get; set; }

        public static List<Juego> ObtenerListaJuegos()
        {
            var listaJuegos = new List<Juego>
            {
                new Juego
                {
                    Plataforma="Xbox One",
                    Titulo= "Rise of Tomb Raider",
                    ImageUri="https://images-eds-ssl.xboxlive.com/image?url=8Oaj9Ryq1G1_p3lLnXlsaZgGzAie6Mnu24_PawYuDYIoH77pJ.X5Z.MqQPibUVTccmFKnirDv3gNn.Z.6MbRLYn4LUy4if1SwSqQge.I3jvpEUmippmEsV7.iCCCPrpv3zKRymwqb0UNZ5SCqGiCXH.F5A99JRKf6tNgIxO57J_64Oxzx3hl.y48oC2XIQAamkoy_UwnTAr80dF8WJjFf_pT.DrLc8VZow8oPyQ34og-"
                },
                new Juego
                {
                    Plataforma="PS4",
                    Titulo="Fifa 17",
                    ImageUri="https://media.game.es/COVERV2/3D_L/127/127809.png"
                },
                new Juego
                {
                    Plataforma="PC",
                    Titulo ="Mafia III",
                    ImageUri="https://media.game.es/COVERV2/3D_L/131/131102.png"
                }

            };

            return listaJuegos;
        }
    }
}
