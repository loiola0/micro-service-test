using System;
using System.Timers;

namespace TestTopShelf
{
    public class MyServiceWS
    {
        public void Start()
        {
            //Coloque aqui o código que executa quando o Serviço do Windows Iniciar
            var timer1 = new Timer();
            timer1.Interval = 10000; //a cada 10 segundos
            timer1.Elapsed += new System.Timers.ElapsedEventHandler(timer1_Tick);
            timer1.Enabled = true;
            Console.WriteLine("Meu Serviço do Windows foi inicado");
        }
        private void timer1_Tick(object sender,ElapsedEventArgs e)
        {
            Console.WriteLine("Meu Serviço do Windows sendo executado a cada 10 segundos");
        }

        public void Stop()
        {
            //Coloque aqui o código que executa quando o Serviço do Windows Parar
            Console.WriteLine("Meu Serviço do Windows Encerrou");
        }
    }
}