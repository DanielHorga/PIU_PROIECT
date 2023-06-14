using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace BileteLibrary
{
    public class Bilete
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        public int IdBilet { get; set; }
        public string Meci { get; set; }
        public string LocatieMeci { get; set; }
        public int NumarBilete { get; set; }
        public int PretBilete { get; set; }
        public string TipAcces{ get; set; }   
        public DateTime DataCumparare { get; set; }
        public DateTime DataMeci { get; set; }

        public Bilete(int idBilet=0, string numeMeci = "NECUNOSCUT", string locatieMeci = "NECUNOSCUTA",string tipAcces = "NECUNOSCUT" , int numarBilete = 0, int pretBilete = 0, DateTime dataCumparare = default)
        {
            IdBilet = idBilet;
            Meci = numeMeci;
            LocatieMeci = locatieMeci;
            TipAcces = tipAcces;
            NumarBilete = numarBilete;
            PretBilete = pretBilete;
            DataCumparare = dataCumparare;
        }

        private const int ID_BILET = 0;
        private const int NUME_MECI = 1;
        private const int LOCATIE_MECI = 2;
        private const int NUMAR_BILETE = 3;
        private const int PRET_BILETE = 4;
        private const int DATA_CUMPARARE = 5;
        private const int DATE_MECI = 6;
        private const int TIP_ACCES = 7;

        public Bilete(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            IdBilet = int.Parse(dateFisier[ID_BILET]);
            Meci = dateFisier[NUME_MECI];
            LocatieMeci = dateFisier[LOCATIE_MECI];
            NumarBilete = int.Parse(dateFisier[NUMAR_BILETE]);
            PretBilete = int.Parse(dateFisier[PRET_BILETE]);
            TipAcces = dateFisier[TIP_ACCES];
            DateTime.TryParse(dateFisier[DATA_CUMPARARE],out DateTime DataCumparare);
            DataMeci = DateTime.Parse(dateFisier[DATE_MECI]);
        }

        public string Conversie_fisier()
        {
            string BileteFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{8}{0}{6}{0}{7}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                IdBilet.ToString(),
                (Meci ?? "NECUNOSCUT"),
                (LocatieMeci ?? "NECUNOSCUT"),
                NumarBilete.ToString(),
                PretBilete.ToString(),
                (DataCumparare.ToString() ?? "NECUNOSCUT"),
                (DataMeci.ToString() ?? "NECUNOSCUT"),
                (TipAcces ?? "NECUNOSCUT"));
            return BileteFisier;
        }

        public string Info()
        {
            string Info = string.Format("Meciul dintre {0}: {1} se va  sustine pe arena din  {2} la data de {5}. Pretul este de {4} iar numarul de bilete este {3} ",
                IdBilet.ToString(),
                (Meci ?? "NECUNOSCUT"),
                (LocatieMeci ?? "NECUNOSCUT"),
                NumarBilete.ToString(),
                PretBilete.ToString(),
                (DataMeci.ToString() ?? "NECUNOSCUT"),
                (TipAcces ?? "NECUNOSCUT"));
            return Info;
        }
    }
}
