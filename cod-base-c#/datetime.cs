using System;
using System.Globalization;

namespace MeuApp
{
   
    class Program
    {
        static void Main(string[] args)
        {
            var culture = CultureInfo.CurrentCulture;
            var ptBR = new CultureInfo("pt-BR");
            var enUS = new CultureInfo("en-US");
            var deDE = new CultureInfo("de-DE");
            Console.WriteLine(DateTime.Now.ToString("D", ptBR));
            Console.WriteLine(DateTime.Now.ToString("D", enUS));
            Console.WriteLine(DateTime.Now.ToString("D", deDE));

            var data_geral = DateTime.UtcNow;
            Console.WriteLine(data_geral);

            //listar todos os timezones disponiveis no sistema
            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
            }

            //criar um timespan

            var timeSpanNanoSegundos = new TimeSpan(1);
            var timeSpanSegundos = new TimeSpan(0, 0, 1);
            var timeSpanMinutos = new TimeSpan(0, 1, 0);
            var timeSpanHoras = new TimeSpan(1, 0, 0);
            var timeSpanDias = new TimeSpan(1, 0, 0, 0);
            var timeSpanDiasHorasMinutosSegundos = new TimeSpan(1, 1, 1, 1);  

            Console.WriteLine(timeSpanNanoSegundos);
            Console.WriteLine(timeSpanSegundos);
            Console.WriteLine(timeSpanMinutos);
            Console.WriteLine(timeSpanHoras);
            Console.WriteLine(timeSpanDias);
            Console.WriteLine(timeSpanDiasHorasMinutosSegundos);

            var dias_mes = DateTime.DaysInMonth(2021, 2);
            Console.WriteLine(dias_mes);

            var fim_de_semana = DayOfWeek.Saturday;
            Console.WriteLine(fim_de_semana);

            var horario_verao = TimeZoneInfo.Local.SupportsDaylightSavingTime;
            Console.WriteLine(horario_verao);


        }
    }
    
}