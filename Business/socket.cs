using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Armonia_Music
{
    public static class socket
    {
        public static void cliente(string ipaddr)
        {
            Socket miPrimerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint miDireccion = new IPEndPoint(IPAddress.Parse(ipaddr), 1234);
            string cualquier = "Hola";
            try
            {
                miPrimerSocket.Connect(miDireccion); 
                MessageBox.Show("Conectado con exito");
                Byte[] bytesend = Encoding.ASCII.GetBytes(cualquier);

                miPrimerSocket.Send(bytesend);

                miPrimerSocket.Close();

            }

            catch (Exception error)

            {

                Console.WriteLine("Error: {0}", error.ToString());
            }

        }
        public static void servidor(string ipaddr)
        {
            Socket miPrimerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint miDireccion = new IPEndPoint(IPAddress.Parse(ipaddr), 1234);
            try
            {
                miPrimerSocket.Bind(miDireccion);
                miPrimerSocket.Listen(1);
                Console.WriteLine("Escuchando...");
                Socket Escuchar = miPrimerSocket.Accept();
                byte[] buffer = new byte[1024];
                Escuchar.Receive(buffer);
                Console.WriteLine(Encoding.ASCII.GetString(buffer, 0, 1024));
                Console.WriteLine("Conectado con exito");
                miPrimerSocket.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine("Error: {0}", error.ToString());
            }
        }
    }
}
