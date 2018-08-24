using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.IO.Ports;

namespace ThreeDPrinter
{
    public class SPreferenceSetting
    {
        public int ZCaliDist { get; set; }
        public int DelayAfterAction { get; set; }
        public bool Checked { get; set; }

        public SPreferenceSetting()
        {
            this.ZCaliDist = 135000;         // 173500;
            this.DelayAfterAction = 2000;
            this.Checked = false;
        }
    }

    public partial class ShareMemory
    {
        static public bool isDebug { get; set; }

        static public bool isConnected { get; set; }
        static public SerialPort LinkSerialPort { get; set; }
        static public SPreferenceSetting Preference;
        static public bool isPrintProcessInterrupt { get; set; }
        static public bool isProjectorUVON { get; set; }
        static public bool isHome { get; set; }

        static public bool isShutDown { get; set; }
        static public bool isCountBaseExposure { get; set; }
        static public bool isCountExposure { get; set; }
        static public bool isTimeUp { get; set; }

        static public int BaseExposure { get; set; }
        static public int Exposure { get; set; }

        static public List<string> lines;
        static public bool isStartParse { get; set; }
        static public bool isCompletedParse { get; set; }
        static public int TotalLayerNum { get; set; }

        static public void initial()
        {
            Preference = new SPreferenceSetting();
            lines = new List<string>();

            isDebug = false;
            isConnected = false;

            LinkSerialPort = null;

            isPrintProcessInterrupt = false;
            isProjectorUVON = false;
            isHome = false;

            isShutDown = false;
            isCountBaseExposure = false;
            isCountExposure = false;
            isTimeUp = false;

            isStartParse = false;
            isCompletedParse = false;

            BaseExposure = 0;
            Exposure = 0;

            TotalLayerNum = 0;
        }

        static public int ReturnPollingSignal()
        {
            int PollingSig = -999;
            try
            {
                PollingSig = int.Parse(LinkSerialPort.ReadLine());
            }
            catch (Exception) { }

            return PollingSig;
        }
    }

    public partial class CPrintTransData
    {
        public int screenWidth { set; get; }
        public int screenHeight { set; get; }

        public int panelWidth { set; get; }
        public int panelHeight { set; get; }
        public double transProduct { set; get; }

        public int panelX { set; get; }
        public int panelY { set; get; }

        public int screenX { set; get; }
        public int screenY { set; get; }

        public CPrintTransData(double product)
        {
            this.transProduct = product;

            this.screenWidth = -1;
            this.screenHeight = -1;
            this.panelWidth = -1;
            this.panelHeight = -1;
            this.panelX = -1;
            this.panelY = -1;
            this.screenX = -1;
            this.screenY = -1;
        }

        public bool TransformSize()
        {
            bool ret = false;

            if ((0 < this.screenWidth) && (0 < this.screenHeight))
            {
                this.panelWidth = Convert.ToInt32(this.screenWidth / this.transProduct);
                this.panelHeight = Convert.ToInt32(this.screenHeight / this.transProduct);

                ret = true;
            }
            return ret;
        }

        public void ChangeLocation()
        {
            this.screenX = Convert.ToInt32(this.panelX * this.transProduct);
            this.screenY = Convert.ToInt32(this.panelY * this.transProduct);
        }
    }

}
