using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace f1Teleform
{
    public partial class Form1 : Form
    {
        public PacketMotionData GloPacketMotionData;
        public PacketSessionData GloPacketSessionData;
        public CarTelemetryData GloMyCarTelemetryData;
        public PacketLapData GloPacketLapData;
        public float count = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void btnStartTelemetry_Click(object sender, EventArgs e)
        {
            GetTelemetryData();


        }
        private void btnStopTelemetry_Click(object sender, EventArgs e)
        {
            //Test
            //CarTelemetryData ddd = (CarTelemetryData)FromByteArray<CarTelemetryData>(asda);


            byte[] data = new byte[] { 62, 9, 26, 44, 55, 66, 2, 179, 23, 10, 7, 166, 2, 164, 2, 151, 1,
                 24, 1, 79, 0, 78, 0, 100, 0, 100, 0, 95, 0, 95, 0, 94, 0, 93, 0, 103, 0, 0, 0, 172, 65,
                 0, 0, 172, 65, 0, 0, 184, 65, 0, 0, 184, 65 };

            CarTelemetryData telem = (CarTelemetryData)GetInfos(data, typeof(CarTelemetryData));


            // var asdas = telem;
            var emre = "asdas";
        }


        private static readonly UdpClient udp = new UdpClient(20777);//new UdpClient(20777);
        public static string dd;
        public static List<int> sizes = new List<int>();
        void GetTelemetryData()
        {

            try
            {
                udp.BeginReceive(new AsyncCallback(Receive), null);
            }
            catch (Exception ex)
            {
                dd = "erer";
            }
        }

        private void Receive(IAsyncResult ar)
        {
            //if (count % 1000 != 0)
            //    return;
            // izlenecek ip adresi tanımlanıyor
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, 20777);

            //udp okuma başlatılıyor
            byte[] bytes = udp.EndReceive(ar, ref ip);

            string data = Encoding.UTF8.GetString(bytes);

            int len = data.Length;
            if (len > 14 && len < 150000)
            {
                byte[] HeaderBytes = new byte[21];

                Array.Copy(bytes, HeaderBytes, 21);
                PacketHeader header = (PacketHeader)GetHeader(HeaderBytes);
                byte packetId = header.m_packetId;
                //Console.WriteLine("Packet: " + header.m_packetId + "   -   Size: " + len);
                byte[] headless = new byte[bytes.Length - 21];
                Array.Copy(bytes, 21, headless, 0, bytes.Length - 21);

                if (packetId == (byte)PacketType.Motion)
                {
                    //PacketMotionData moti = (PacketMotionData)GetInfos(bytes, typeof(PacketMotionData));
                    //GloPacketMotionData = moti;

                    //Console.WriteLine(moti.m_frontWheelsAngle / 32767.0f);
                }
                else if (packetId == (byte)PacketType.Session)
                {
                    PacketSessionData moti = (PacketSessionData)GetInfos(headless, typeof(PacketSessionData));
                    GloPacketSessionData = moti;
                    Console.WriteLine(ip.Address + "_" + len + "_ session type:" + moti.m_totalLaps + " - pit" + moti.m_numMarshalZones /*+ "        " + sessionInfo.m_sessionDuration +" / " + sessionInfo.m_sessionTimeLeft*/);
                }
                else if (packetId == (byte)PacketType.Telemetry)
                {

                    byte[] tel1 = new byte[53];
                    Array.Copy(headless, 0, tel1, 0, 53);

                    CarTelemetryData carTelakdjalskdas = (CarTelemetryData)GetInfos(tel1, typeof(CarTelemetryData));


                    BitConverter.ToUInt16(new byte[] { tel1[11], tel1[12] }, 0);
                    Console.WriteLine(carTelakdjalskdas);

                    PacketCarTelemetryData carTel = (PacketCarTelemetryData)GetInfos(headless, typeof(PacketCarTelemetryData));
                    CarTelemetryData[] teleDataList = carTel.m_carTelemetryData;
                    CarTelemetryData myCar = teleDataList[0];
                    var spList = teleDataList.Select(x => x.t01_speed);
                    GloMyCarTelemetryData = myCar;
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        DrawTelemetryData(myCar);
                       }));
                    //                    Console.WriteLine(myCar.m_throttle + "-" + myCar.m_brake + "     " + myCar.m_speed + "     " + myCar.m_steer + "--" + myCar.m_engineRPM);
                }
                else if (packetId == (byte)PacketType.LapData)
                {

                    //PacketLapData lpp = (PacketLapData)GetInfos(headless, typeof(PacketLapData));
                    //GloPacketLapData = lpp;
                    //Console.WriteLine(ip.Address + "_" + len + "_ pos:" +
                    //    lpp.m_lapData.m_currentLapTime + " - pit" + lpp.m_lapData.m_totalDistance);

                }

            }

            //Thread.Sleep(100);

            udp.BeginReceive(new AsyncCallback(Receive), null);

        }

        private void DrawTelemetryData(CarTelemetryData myCar)
        {
            Properties.Settings.Default.throValue = myCar.t02_throttle;
            pbThrottle.Value = myCar.t02_throttle;
            vpbGaz.Value = myCar.t02_throttle;
            pbBrake.Value = myCar.t04_brake;
            lblSpeed.Text = myCar.t01_speed.ToString();
            tbSteer.Value = ((tbSteer.Maximum / 2) + Convert.ToInt32(myCar.t03_steer));
            pbSteer.Value = Convert.ToInt32(myCar.t03_steer) / 2 + 50;
            lbDRS.BackColor = myCar.t09_drs == 1 ? Color.Green : Color.DarkGray;
            lbGear.Text = myCar.t07_gear.ToString();
            pbRevLightPerc.Value = Convert.ToInt32(myCar.t10_revLightsPercent) % 100;
           
            lbRLTyreInTemp.Text = myCar.t13_tyresInnerTemperature.RearLeft.ToString();
            lbRRTyreInTemp.Text = myCar.t13_tyresInnerTemperature.RearRight.ToString();
            lbFRTyreInTemp.Text = myCar.t13_tyresInnerTemperature.FrontRight.ToString();
            lbFLTyreInTemp.Text = myCar.t13_tyresInnerTemperature.FrontLeft.ToString();

            lbRLTyreSurfaceTemp.Text = myCar.t12_tyresSurfaceTemperature.RearLeft.ToString();
            lbRRTyreSurfaceTemp.Text = myCar.t12_tyresSurfaceTemperature.RearRight.ToString();
            lbFRTyreSurfaceTemp.Text = myCar.t12_tyresSurfaceTemperature.FrontRight.ToString();
            lbFLTyreSurfaceTemp.Text = myCar.t12_tyresSurfaceTemperature.FrontLeft.ToString();

            lbRLBrakeTemp.Text = myCar.t11_brakesTemperature.RearLeft.ToString();
            lbRRBrakeTemp.Text = myCar.t11_brakesTemperature.RearRight.ToString();
            lbFRBrakeTemp.Text = myCar.t11_brakesTemperature.FrontRight.ToString();
            lbFLBrakeTemp.Text = myCar.t11_brakesTemperature.FrontLeft.ToString();

            lbEngineTemp.Text = myCar.t14_engineTemperature.ToString(); 

            lbFLTyrePressure.Text = myCar.t15_tyresPressure.FrontLeft.ToString();
            lbFLTyrePressure.Text = myCar.t15_tyresPressure.FrontLeft.ToString();
            lbFLTyrePressure.Text = myCar.t15_tyresPressure.FrontLeft.ToString();
            lbFLTyrePressure.Text = myCar.t15_tyresPressure.FrontLeft.ToString();
            richTextBox1.Text += String.Format("\r\n Added. {0}-{1}", DateTime.Now , count);
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
    [StructLayout(LayoutKind.Explicit, Size =21)]
    public struct PacketHeader
    {
        [FieldOffset(0)] public UInt16 m_packetFormat;         // 2018  -2
        [FieldOffset(2)] public byte m_packetVersion;        // Version of this packet type, all start from 1 -1
        [FieldOffset(3)] public byte m_packetId;             // Identifier for the packet type, see below -1
        [FieldOffset(4)] public UInt64 m_sessionUID;           // Unique identifier for the session -8
        [FieldOffset(12)] public uint m_sessionTime;          // Session timestamp -4
        [FieldOffset(16)] public uint m_frameIdentifier;      // Identifier for the frame the data was retrieved on -4
        [FieldOffset(20)] public byte m_playerCarIndex;       // Index of player's car in the array-1
    };
    #endregion

    #region CarMonitor  -  0

    public struct CarMotionData
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

    public struct PacketMotionData
    {
        public PacketHeader m_header;               // Header

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public CarMotionData[] m_carMotionData;    // Data for all cars on track

        // Extra player car ONLY data
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] m_suspensionPosition;       // Note: All wheel arrays have the following order:
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] m_suspensionVelocity;       // RL, RR, FL, FR
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] m_suspensionAcceleration;   // RL, RR, FL, FR
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public float[] m_wheelSpeed;               // Speed of each wheel
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
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

    [StructLayout(LayoutKind.Sequential)]
    public struct MarshalZone
    {
        public float m_zoneStart;   // Fraction (0..1) of way through the lap the marshal zone starts
        public sbyte m_zoneFlag;    // -1 = invalid/unknown, 0 = none, 1 = green, 2 = blue, 3 = yellow, 4 = red
    };
    [StructLayout(LayoutKind.Sequential)]
    public struct PacketSessionData
    {
        //public PacketHeader m_header;                  // Header - 21

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
        [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.Struct, SizeConst = 21)]
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
    [StructLayout(LayoutKind.Explicit, Size = 47)]
    public struct CarTelemetryData
    {
        [FieldOffset(0)]
        public ushort t01_speed;                      // Speed of car in kilometres per hour

        [FieldOffset(2)]
        public byte t02_throttle;                   // Amount of throttle applied (0 to 100)

        [FieldOffset(3)]
        public sbyte t03_steer;                      // Steering (-100 (full lock left) to 100 (full lock right))

        [FieldOffset(4)]
        public byte t04_brake;                      // Amount of brake applied (0 to 100)

        [FieldOffset(5)]
        public byte t06_clutch;                     // Amount of clutch applied (0 to 100)

        [FieldOffset(6)]
        public sbyte t07_gear;                       // Gear selected (1-8, N=0, R=-1)       

        [FieldOffset(7)]
        public UInt16 t08_engineRPM;                  // Engine RPM

        [FieldOffset(9)]
        public byte t09_drs;                        // 0 = off, 1 = on

        [FieldOffset(10)]
        public byte t10_revLightsPercent;           // Rev lights indicator (percentage)

        [FieldOffset(11)]
        public CardBody<ushort> t11_brakesTemperature;       // Brakes temperature (celsius)

        [FieldOffset(19)]
        public CardBody<ushort> t12_tyresSurfaceTemperature;  // Tyres surface temperature (celsius)

        [FieldOffset(27)]
        public CardBody<ushort> t13_tyresInnerTemperature; // Tyres inner temperature (celsius)

        [FieldOffset(35)]
        public UInt16 t14_engineTemperature;          // Engine temperature (celsius)

        [FieldOffset(37)]
        public CardBody<float> t15_tyresPressure;           // Tyres pressure (PSI)

    };
    public struct CardBody<T> 
    {
        public T RearLeft;
        public T RearRight;
        public T FrontLeft;
        public T FrontRight;
    }
    struct PacketCarTelemetryData
    {
        //public PacketHeader m_header;                // Header

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public CarTelemetryData[] m_carTelemetryData;

        public UInt32 zm_buttonStatus;         // Bit flags specifying which buttons are being
                                               // pressed currently - see appendices
    };
    #endregion
    #region LapData
    public struct LapData
    {
        public float m_lastLapTime;           // Last lap time in seconds
        public float m_currentLapTime;        // Current time around the lap in seconds
        public float m_bestLapTime;           // Best lap time of the session in seconds
        public float m_sector1Time;           // Sector 1 time in seconds
        public float m_sector2Time;           // Sector 2 time in seconds
        public float m_lapDistance;           // Distance vehicle is around current lap in metres – could
                                              // be negative if line hasn’t been crossed yet
        public float m_totalDistance;         // Total distance travelled in session in metres – could
                                              // be negative if line hasn’t been crossed yet
        public float m_safetyCarDelta;        // Delta in seconds for safety car
        public byte m_carPosition;           // Car race position
        public byte m_currentLapNum;         // Current lap number
        public byte m_pitStatus;             // 0 = none, 1 = pitting, 2 = in pit area
        public byte m_sector;                // 0 = sector1, 1 = sector2, 2 = sector3
        public byte m_currentLapInvalid;     // Current lap invalid - 0 = valid, 1 = invalid
        public byte m_penalties;             // Accumulated time penalties in seconds to be added
        public byte m_gridPosition;          // Grid position the vehicle started the race in
        public byte m_driverStatus;          // Status of driver - 0 = in garage, 1 = flying lap
                                             // 2 = in lap, 3 = out lap, 4 = on track
        public byte m_resultStatus;          // Result status - 0 = invalid, 1 = inactive, 2 = active
                                             // 3 = finished, 4 = disqualified, 5 = not classified
                                             // 6 = retired
    };

    public struct PacketLapData
    {
        //public PacketHeader m_header;              // Header

        public LapData m_lapData;         // Lap data for all cars on track
    };
    #endregion

}
