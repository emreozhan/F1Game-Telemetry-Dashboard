using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//        [MarshalAs(UnmanagedType.**, SizeConst = 21)]
//MarshalZone[] m_marshalZones;
namespace ConsoleApp2
{
    enum PacketType
    {
        Motion = 0,
        Session = 1,
        Telemetry = 6

    }
    class Program
    {
        private static readonly UdpClient udp = new UdpClient(20777);
        public static string dd;
        public static List<int> sizes = new List<int>();
        static void Main(string[] args)
        {

            //byte[] str = getBytes(stru);
            //string data2 = Encoding.UTF8.GetString(str);
            //var bToS = fromBytes(str);
            //var sToByteArray = fromBytes(str);


            //string myData = "?\a\u0001\u0004????\u0015?????8C?\b\0\0\0\u0001\0\a\0GSemreozhan\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\u0001\r\u0002\u0005\u001dlng_personal_best\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\u0001\u0006\0\a\u001blng_personal_best\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\u0001\u0002\0\u0003\u0003D. RICCIARDO\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\u0001\t\u0001!\u0016M. VERSTAPPEN\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\u0001\u000e\u0002\v4S. PEREZ\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\u0001\u0011\u0004\u001f\u001cE. OCON\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\u0001\u0013\u0003\u0012\rL. STROLL\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\u0001=\u0005#DS. SIROTKIN\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\u0001\n\u0006\u001b\u001dN. H??LKENBERG\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\u0001\0\a7NC. SAINZ\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\u0001<\b\u001c6B. HARTLEY\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\u0001;\t\n\u001cP. GASLY\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0\0";
            //byte[] myDataArr = Encoding.UTF8.GetBytes(myData);

            //var asdas  = fromBytes(myDataArr);
            //var asdkasd = "232";

            try
            {
                udp.BeginReceive(new AsyncCallback(Receive), null);
            }
            catch (Exception ex)
            {
                dd = "erer";
            }

            dd = Console.ReadLine();
            //dd = "e2";
        }

        private static void Receive(IAsyncResult ar)
        {
            // izlenecek ip adresi tanımlanıyor
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, 20777);

            //udp okuma başlatılıyor
            byte[] bytes = udp.EndReceive(ar, ref ip);

            //string data = Encoding.ASCII.GetString(bytes);

            string data = Encoding.UTF8.GetString(bytes);
            int len = data.Length;
            if (len > 14 && len < 150000)
            {
                byte[] HeaderBytes = new byte[21];

                Array.Copy(bytes, HeaderBytes, 21);
                PacketHeader header = (PacketHeader)GetHeader(HeaderBytes);
                byte packetId = header.m_packetId;
                //Console.WriteLine("Packet: " + header.m_packetId + "   -   Size: " + len);

                if (packetId == (byte) PacketType.Motion)
                {
                    //PacketMotionData moti = (PacketMotionData)GetInfos(bytes, typeof(PacketMotionData));
                    //Console.WriteLine(moti.m_frontWheelsAngle / 32767.0f);
                }
                else if (packetId == (byte) PacketType.Session)
                {
                    //PacketSessionData moti = (PacketSessionData)GetInfos(bytes, typeof(PacketSessionData));
                    //Console.WriteLine(ip.Address + "_" + len + "_ session type:" + sesIn.m_sessionType + " - pit" + sesIn.m_pitSpeedLimit /*+ "        " + sessionInfo.m_sessionDuration +" / " + sessionInfo.m_sessionTimeLeft*/);
                }else if (packetId == (byte) PacketType.Telemetry)
                {
                    PacketCarTelemetryData carTel = (PacketCarTelemetryData) GetInfos(bytes, typeof(PacketCarTelemetryData));
                    CarTelemetryData[] teleDataList = carTel.m_carTelemetryData;

                    string dumy ="";

                    foreach (var td in teleDataList)
                    {
                        dumy = dumy + "-" + td.m_drs;
                        //Console.WriteLine(td.m_throttle);

                    }
                    Console.WriteLine(dumy);

                }

            }

            Thread.Sleep(100);

            udp.BeginReceive(new AsyncCallback(Receive), null);

        }

        static object GetInfos(byte[] myDataArr, Type type)
        {
            var handle = GCHandle.Alloc(myDataArr, GCHandleType.Pinned);
            var structure = Marshal.PtrToStructure(handle.AddrOfPinnedObject(), type);
            handle.Free();
            return structure;
        }

        static object GetHeader(byte[] myDataArr)
        {
            var handle = GCHandle.Alloc(myDataArr, GCHandleType.Pinned);
            var structure = Marshal.PtrToStructure(handle.AddrOfPinnedObject(), typeof(PacketHeader));
            handle.Free();
            return structure;
        }

    }



    #region PacketHeader
    struct PacketHeader
    {
        public UInt16 m_packetFormat;         // 2018  -2
        public byte m_packetVersion;        // Version of this packet type, all start from 1 -1
        public byte m_packetId;             // Identifier for the packet type, see below -1
        public UInt64 m_sessionUID;           // Unique identifier for the session -8
        public float m_sessionTime;          // Session timestamp -4
        public uint m_frameIdentifier;      // Identifier for the frame the data was retrieved on -4
        public byte m_playerCarIndex;       // Index of player's car in the array-1
    };
    #endregion

    #region CarMonitor  -  0

    struct CarMotionData
    {
        float m_worldPositionX;           // World space X position
        float m_worldPositionY;           // World space Y position
        float m_worldPositionZ;           // World space Z position
        float m_worldVelocityX;           // Velocity in world space X
        float m_worldVelocityY;           // Velocity in world space Y
        float m_worldVelocityZ;           // Velocity in world space Z
        Int16 m_worldForwardDirX;         // World space forward X direction (normalised)
        Int16 m_worldForwardDirY;         // World space forward Y direction (normalised)
        Int16 m_worldForwardDirZ;         // World space forward Z direction (normalised)
        Int16 m_worldRightDirX;           // World space right X direction (normalised)
        Int16 m_worldRightDirY;           // World space right Y direction (normalised)
        Int16 m_worldRightDirZ;           // World space right Z direction (normalised)
        float m_gForceLateral;            // Lateral G-Force component
        float m_gForceLongitudinal;       // Longitudinal G-Force component
        float m_gForceVertical;           // Vertical G-Force component
        float m_yaw;                      // Yaw angle in radians
        float m_pitch;                    // Pitch angle in radians
        float m_roll;                     // Roll angle in radians
    };

    struct PacketMotionData
    {
        public PacketHeader m_header;               // Header

        [MarshalAs(UnmanagedType.Struct, SizeConst = 20)]
        public CarMotionData[] m_carMotionData;    // Data for all cars on track

        // Extra player car ONLY data
        [MarshalAs(UnmanagedType.R4, SizeConst = 4)]
        public float[] m_suspensionPosition;       // Note: All wheel arrays have the following order:
        [MarshalAs(UnmanagedType.R4, SizeConst = 4)]
        public float[] m_suspensionVelocity;       // RL, RR, FL, FR
        [MarshalAs(UnmanagedType.R4 , SizeConst = 4)]
        public float[] m_suspensionAcceleration;   // RL, RR, FL, FR
        [MarshalAs(UnmanagedType.R4, SizeConst = 4)]
        public float[] m_wheelSpeed;               // Speed of each wheel
        [MarshalAs(UnmanagedType.R4, SizeConst = 4)]
        public float[] m_wheelSlip;                // Slip ratio for each wheel
        public float m_localVelocityX;              // Velocity in local space
        public float m_localVelocityY;              // Velocity in local space
        public float m_localVelocityZ;              // Velocity in local space
        public float m_angularVelocityX;            // Angular velocity x-component
        public float m_angularVelocityY;            // Angular velocity y-component
        public float m_angularVelocityZ;            // Angular velocity z-component
        public float m_angularAccelerationX;        // Angular velocity x-component
        public float m_angularAccelerationY;        // Angular velocity y-component
        public float m_angularAccelerationZ;        // Angular velocity z-component
        public float m_frontWheelsAngle;            // Current front wheels angle in radians
    };
    #endregion

    #region SessionPacket -1
    /**
        SESSION PACKET
        The session packet includes details about the current session in progress.
        Frequency: 2 per second

        Size: 147 bytes
        */

    struct MarshalZone
    {
        public float m_zoneStart;   // Fraction (0..1) of way through the lap the marshal zone starts
        public sbyte m_zoneFlag;    // -1 = invalid/unknown, 0 = none, 1 = green, 2 = blue, 3 = yellow, 4 = red
    };
    struct PacketSessionData
    {
        public PacketHeader m_header;                  // Header - 21

        public byte m_weather;                // Weather - 0 = clear, 1 = light cloud, 2 = overcast   *1
                                              // 3 = light rain, 4 = heavy rain, 5 = storm 
        public sbyte m_trackTemperature;        // Track temp. in degrees celsius *1
        public sbyte m_airTemperature;          // Air temp. in degrees celsius *1
        public byte m_totalLaps;              // Total number of laps in this race *1
        public UInt16 m_trackLength;               // Track length in metres  *2
        public byte m_sessionType;            // 0 = unknown, 1 = P1, 2 = P2, 3 = P3, 4 = Short P *1
                                              // 5 = Q1, 6 = Q2, 7 = Q3, 8 = Short Q, 9 = OSQ
                                              // 10 = R, 11 = R2, 12 = Time Trial
        public sbyte m_trackId;                 // -1 for unknown, 0-21 for tracks, see appendix     * 1
        public byte m_era;                    // Era, 0 = modern, 1 = classic   *1
        public UInt16 m_sessionTimeLeft;       // Time left in session in seconds *2
        public UInt16 m_sessionDuration;       // Session duration in seconds *2
        public byte m_pitSpeedLimit;          // Pit speed limit in kilometres per hour *1 
        public byte m_gamePaused;               // Whether the game is paused *1
        public byte m_isSpectating;           // Whether the player is spectating *1
        public byte m_spectatorCarIndex;      // Index of the car being spectated *1
        public byte m_sliProNativeSupport;    // SLI Pro support, 0 = inactive, 1 = active *1
        public byte m_numMarshalZones;            // Number of marshal zones to follow *1
        [MarshalAs(UnmanagedType.Struct, SizeConst = 20)]
        public MarshalZone[] m_marshalZones;         // List of marshal zones – max    5*21 = 105
        public byte m_safetyCarStatus;          // 0 = no safety car, 1 = full safety car  *1 
                                                // 2 = virtual safety car
        public byte m_networkGame;              // 0 = offline, 1 = online   *1
    };
    #endregion

    #region Car Telemetry - 6
    /**  CAR TELEMETRY PACKET
        This packet details telemetry for all the cars in the race.It details various values that would be recorded on the car such as speed, throttle application, DRS etc.
        Frequency: Rate as specified in menus
        Size: 1085 bytes
    */
    struct CarTelemetryData
    {
        public UInt16 m_speed;                      // Speed of car in kilometres per hour
        public byte m_throttle;                   // Amount of throttle applied (0 to 100)
        public sbyte m_steer;                      // Steering (-100 (full lock left) to 100 (full lock right))
        public byte m_brake;                      // Amount of brake applied (0 to 100)
        public byte m_clutch;                     // Amount of clutch applied (0 to 100)
        public sbyte m_gear;                       // Gear selected (1-8, N=0, R=-1)
        public UInt16 m_engineRPM;                  // Engine RPM
        public byte m_drs;                        // 0 = off, 1 = on
        public byte m_revLightsPercent;           // Rev lights indicator (percentage)
        [MarshalAs(UnmanagedType.U2, SizeConst = 4)]
        public UInt16 [] m_brakesTemperature;       // Brakes temperature (celsius)
        [MarshalAs(UnmanagedType.U2, SizeConst = 4)]
        public UInt16 [] m_tyresSurfaceTemperature; // Tyres surface temperature (celsius)
        [MarshalAs(UnmanagedType.U2, SizeConst = 4)]
        public UInt16 [] m_tyresInnerTemperature;   // Tyres inner temperature (celsius)
        public UInt16  m_engineTemperature;          // Engine temperature (celsius)
        [MarshalAs(UnmanagedType.U2, SizeConst = 4)]
        public float  [] m_tyresPressure;           // Tyres pressure (PSI)
    };
    struct PacketCarTelemetryData
    {
        public PacketHeader m_header;                // Header

        [MarshalAs(UnmanagedType.Struct, SizeConst = 20)]
        public CarTelemetryData []m_carTelemetryData;

        public UInt32 m_buttonStatus;         // Bit flags specifying which buttons are being
                                       // pressed currently - see appendices
    };
    #endregion
    
}

//        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)] 