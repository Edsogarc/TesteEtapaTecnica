using Exe03.Entities;
using Exe03.Entities.Enums;

namespace Exe03.Entities
{
    class Filme
    {
        public string Titulo { get; set; }
        public Enum Genero { get; set; }
        public int DuracaoEmMinutos { get; set; }
        public string HorarioSessao { get; set; }
        public int Id { get; set; }

        public Filme()
        {

        }
        public Filme(string titulo)
        {
            Titulo = titulo;
        }
        public Filme(string titulo, Enum genero, int duracaoEmMinutos, string horarioSessao, int id)
        {
            Titulo = titulo;
            Genero = genero;
            DuracaoEmMinutos = duracaoEmMinutos;
            HorarioSessao = horarioSessao;
            Id = id;
        }

        public void CalcularDuracaoEmHoras()
        {
            int duracaoHoras = DuracaoEmMinutos / 60;
            int duracaoMinutos = DuracaoEmMinutos % 60;
            Console.WriteLine("Duração do filme " + duracaoHoras + " Hora(s) e " + duracaoMinutos + " minuto(s)");
        }
        public void RetornarHoraQueAcaba()
        {
            string[] horario = HorarioSessao.Split(':');
            int horas = int.Parse(horario[0]);
            int minutos = int.Parse(horario[1]);
            int duracaoHoras = DuracaoEmMinutos / 60;
            int duracaoMinutos = DuracaoEmMinutos % 60;
            int somaHoras = horas + duracaoHoras;
            int somaMinutos = minutos + duracaoMinutos;
            if (somaHoras > 23 && somaMinutos > 59)
            {
                somaHoras = (horas - 24) + duracaoHoras + 1;
                somaMinutos = minutos + duracaoMinutos - 60;
                if (somaMinutos <= 9)
                {
                    Console.WriteLine("Horário que o filme acaba: " + "0" + somaHoras + ":" + "0" + somaMinutos);    
                }
                else
                {
                    Console.WriteLine("Horário que o filme acaba: " + "0" + somaHoras + ":" + somaMinutos);
                }
            }
            else if (somaMinutos > 59)
            {
                somaHoras++;
                somaMinutos = minutos + duracaoMinutos - 60;
                if (somaMinutos <= 9)
                {
                    Console.WriteLine("Horário que o filme acaba: " + somaHoras + ":" + "0" + somaMinutos);    
                }
                else
                {
                    Console.WriteLine("Horário que o filme acaba: " + somaHoras + ":"+ somaMinutos);   
                }
            }
            else if (somaHoras > 23)
            {
                somaHoras = (horas - 24) + duracaoHoras;
                Console.WriteLine("Horário que o filme acaba: " + "0" + somaHoras + ":" + somaMinutos);
            }
            else
            {
                Console.WriteLine("Horário que o filme acaba: " + somaHoras + ":" + somaMinutos);
            }

        }
    }
}