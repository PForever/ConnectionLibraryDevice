using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeviceLibrary.Abstract.DataObjects.Containers;
using DeviceLibrary.Abstract.DataObjects.Devices;
using DeviceLibrary.Abstract.DataObjects.Messages;
using DeviceLibrary.Abstract.Modules.MessageManager.Handlers.Args;
using DeviceLibrary.Modules.MessageManager;
using Log4NetProj;
using LogSingleton;

namespace ConnectionLibraryDevice
{
    class Program
    {
        private const string MulticastHostint = "239.0.0.223";
        private const int UdpPort = 8083;
        private const int TcpPort = 8082;

        private static string _host = "krakadile";
        private static string _myCode = "pikachu";

        private static ServerManager _server;
        private static SenderManager _sender;
        private static MessageManager _messageManager;

        public static string propName = "Temperature";
        private static Random _rnd = new Random();
        static void Main(string[] args)
        {
            ILogger log = new Logger();
            Logging.Initialize(log);

            _server = new ServerManager(MulticastHostint, UdpPort, TcpPort);
            _sender = new SenderManager(MulticastHostint, TcpPort, UdpPort);
            _messageManager = new MessageManager(MulticastHostint, _myCode, _sender, _server, new[] { _host });

            _server.ServerStart();

            PropertyInfo propInfo = new PropertyInfo("", true, ProperyType.Int);

            Properties properties = new Properties(new Dictionary<string, PropertyInfo>{{propName, propInfo}});
            Device device = new Device(_myCode, "LALA", "Я ДЕВАЙС", properties);
            ConnectMessage connect = new ConnectMessage(device, _myCode, DateTime.Now, _host);
            _messageManager.OnConnectMessage(null, new EventMessageConnectArgs(connect));

            while (true)
            {
                Task.Delay(3000).Wait();
                Telemetry telemetry = new Telemetry(_myCode, new PropertiesValues{{propName, _rnd.Next(10, 20).ToString()}}, DateTime.Now, _host);
                Console.WriteLine($"{_myCode}: [{telemetry.TimeMarker}] {telemetry.Values[propName]}");
                _messageManager.OnTelemetry(null, new EventTelemetryArgs(telemetry));
            }
        }
    }
}
