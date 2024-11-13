using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerLib
{
    public class Messenger
    {
        public readonly List<IKanal> _listaKanala;

        public Messenger(List<IKanal> listaKanala)
        {
            _listaKanala = listaKanala;
        }

        public string saljiPoruke(User user, string poruka)
        {
            StringBuilder report = new StringBuilder();

            foreach (var kanal in _listaKanala)
            {
                report.AppendLine(kanal.posaljiPoruku(user, poruka));
            }

            return report.ToString();
        }
    }
}
