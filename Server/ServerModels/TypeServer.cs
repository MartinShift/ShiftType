using CommonLibrary.JsonModels;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace ModelLibrary.ServerModels
{
    public class TypeServer
    {
        public TcpListener Socket { get; set; }
        public IPAddress Ip { get; set; }
        public IPEndPoint Ep { get; set; }
        public Action<TcpClient> worker = (s) =>
        {
            try
            {
                var stream = s.GetStream();
                var buffer = new byte[10000000];
                var read = stream.Read(buffer);
                string raw = Encoding.UTF8.GetString(buffer, 0, read);
                Console.WriteLine(raw);
                DataMessage message = JsonSerializer.Deserialize<DataMessage>(raw);
                var response = "";
                switch (message.Type)
                {
                    case MessageType.RegisterMessage:
                        var register = DataCenter.CheckRegisterInfo(message);
                        response = JsonSerializer.Serialize(register);
                        break;
                    case MessageType.LoginMessage:
                        var login = DataCenter.CheckLoginInfo(message);
                        response = JsonSerializer.Serialize(login);
                        break;
                    case MessageType.ChangeProfile:
                        var profile = DataCenter.ChangeProfile(message);
                        response = JsonSerializer.Serialize(profile);
                        break;
                    case MessageType.ChangePassword:
                        var res = DataCenter.ChangePassword(message);
                        response = JsonSerializer.Serialize(res);
                        break;
                    case MessageType.CodeRequest:
                        var code = DataCenter.GetEmailCode(message);
                        response = JsonSerializer.Serialize(code);
                        break;
                    case MessageType.ResetPassword:
                        var reset = DataCenter.ResetPassword(message);
                        response = JsonSerializer.Serialize(reset);
                        break;
                    case MessageType.TestResult:
                        var data = DataCenter.AddResult(message);
                        response = JsonSerializer.Serialize(data);
                        break;
                    case MessageType.GetAllClients:
                        var clients = DataCenter.GetAllClients();
                        response = JsonSerializer.Serialize(clients);
                        break;
                }
                var mes = Encoding.UTF8.GetBytes(response);
                Console.WriteLine(response);
                stream.Write(mes);
                stream.Close();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        };
        public TypeServer()
        {
           
            Ip = IPAddress.Parse("127.0.0.69");
            Ep = new IPEndPoint(Ip,6900); 
            Socket = new TcpListener(Ip,6900);
        }

        public void Run()
        {
            while (true)
            {

                Socket.Start();
                TcpClient ns = Socket.AcceptTcpClient();
                Console.WriteLine("New socket connected");
                Task.Run(() =>
                {
                    worker(ns);
                });
            }
        }
    }
}