using Microsoft.JSInterop;
using System;

namespace CodeChallenge.Data.Model
{
    public class Animal
    {
       

        public string Tipo { get; set; }
        public string Especie { get; set; }
        public int Edad { get; set; }
        public string LugarOrigen { get; set; }
        public double Peso { get; set; }
        public double Porcentaje { get; set; }
        public double Kilos { get; set; }

        public DateTime FechaPrimerCambioPiel { get; set; }
        public int DiasEntreCambioPiel { get; set; }
        public double Porcentaje2 { get; set; }

        public  double CalcularAlimento()
        {
            var total = 0D;
            int diasDelMes = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);
            if (Tipo == "Carnivoro")
            {
                total = Peso / 100 * Porcentaje * diasDelMes;
            }
            else if (Tipo == "Herbivoro")
            {
                total = ((Peso * 2) + Kilos) * diasDelMes;
            }
            else if (Tipo == "Reptil")
            {
                bool termino = false;
                DateTime FechaCambioPiel = FechaPrimerCambioPiel;
                while (!termino)
                {
                    FechaCambioPiel = FechaCambioPiel.AddDays(DiasEntreCambioPiel);


                    if (FechaCambioPiel.Year == DateTime.Today.Year)
                    {
                        if (FechaCambioPiel.Month == DateTime.Today.Month)
                        {
                                diasDelMes = diasDelMes - 1;
                        }
                    }

                    if (FechaCambioPiel.AddDays(1).Year == DateTime.Today.Year)
                    {
                        if (FechaCambioPiel.AddDays(1).Month == DateTime.Today.Month)
                        {
                            diasDelMes = diasDelMes - 1;
                        }
                    }

                    if (FechaCambioPiel.AddDays(2).Year == DateTime.Today.Year)
                    {
                        if (FechaCambioPiel.AddDays(2).Month == DateTime.Today.Month)
                        {
                            diasDelMes = diasDelMes - 1;
                        }
                    }






                    if (FechaCambioPiel >= DateTime.Today)
                    {
                        termino = true;
                        break;
                    }
                }

                total = Peso / 100 * (Porcentaje/7) * diasDelMes;
            }

         
            return total;
        }

      

    }
}