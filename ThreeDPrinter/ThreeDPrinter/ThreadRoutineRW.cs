using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreeDPrinter
{
    class ThreadRoutineRW
    {
        private AutoResetEvent autoEventOnRoutine;

        public ThreadRoutineRW()
        {
            this.autoEventOnRoutine = new AutoResetEvent(true);
        }

        private bool isShutDown = false;
        private int times = 0;
        private bool isStartCount = false;
        private int count_times = 0;
        public void Run()
        {
            while (!isShutDown)
            {
                this.autoEventOnRoutine.WaitOne(50);
                this.isShutDown = ShareMemory.isShutDown;

                if (true == ShareMemory.isCountBaseExposure)
                {
                    ShareMemory.isCountBaseExposure = false;
                    this.times = (int)(ShareMemory.BaseExposure / 50);
                    this.isStartCount = true;
                }
                if (true == ShareMemory.isCountExposure)
                {
                    ShareMemory.isCountExposure = false;
                    this.times = (int)(ShareMemory.Exposure / 50);
                    this.isStartCount = true;
                }
                if (true == this.isStartCount)
                {
                    if (this.times < this.count_times)
                    {
                        ShareMemory.isTimeUp = true;
                        this.isStartCount = false;
                        this.count_times = 0;
                    }
                    else
                    {
                        this.count_times++;
                    }
                }
            }
        }
    }

    class ThreadFileRW
    {
        private bool isShutDown = false;
        private bool isStartParse = false;
        private List<string> lines = new List<string>();
        private int TotalLayerNum = 0;

        public ThreadFileRW()
        {
        }
        
        public void Run()
        {
            while (!isShutDown)
            {
                this.isShutDown = ShareMemory.isShutDown;
                this.isStartParse = ShareMemory.isStartParse;

                if (true == this.isStartParse)
                {
                    ShareMemory.isStartParse = false;

                    this.lines = ShareMemory.lines;
                    this.TotalLayerNum = this.ParseSVGList(this.lines);
                    this.lines.Clear();

                    ShareMemory.TotalLayerNum = this.TotalLayerNum;
                    ShareMemory.isCompletedParse = true;
                }

                System.Threading.Thread.Sleep(100);
            }
        }

        private int ParseSVGList(List<string> list_str)
        {
            CRecord xml_section = new CRecord();
            CRecord svg_section = new CRecord();

            List<CRecord> layers = new List<CRecord>();

            // find xml & svg
            for (int i = 0; i < list_str.Count; i++)
            {
                if (true == xml_section.IsFound(list_str[i].IndexOf("<?xml")))
                {
                    xml_section.start_line = i;
                    xml_section.start_index = xml_section.result_index;

                    i = list_str.Count;
                }
            }
            for (int i = xml_section.start_line; i < list_str.Count; i++)
            {
                if (true == xml_section.IsFound(list_str[i].IndexOf("<svg")))
                {
                    xml_section.end_line = i - 1;
                    xml_section.end_index = list_str[i - 1].Length - 1;

                    svg_section.start_line = i;
                    svg_section.start_index = svg_section.result_index;

                    i = list_str.Count;
                }
            }
            for (int i = svg_section.start_line; i < list_str.Count; i++)
            {
                if (true == svg_section.IsFound(list_str[i].IndexOf(">")))
                {
                    svg_section.end_line = i;
                    svg_section.end_index = svg_section.result_index;

                    i = list_str.Count;
                }
            }

            for (int i = xml_section.start_line; i <= xml_section.end_line; i++)
            {
                xml_section.contain.Append(list_str[i]);
            }
            for (int i = svg_section.start_line; i <= svg_section.end_line; i++)
            {
                svg_section.contain.Append(list_str[i]);
            }

            // find layers
            bool isFindLayerStart = true;
            CRecord temp_record = null;
            for (int i = svg_section.end_line + 1; i < list_str.Count; i++)
            {
                if (true == isFindLayerStart)
                {
                    if (true == svg_section.IsFound(list_str[i].IndexOf("<g")))
                    {
                        temp_record = new CRecord();
                        temp_record.start_line = i + 1;
                        temp_record.start_index = 0;

                        isFindLayerStart = false;
                    }
                }
                else
                {
                    if (true == svg_section.IsFound(list_str[i].IndexOf("</g>")))
                    {
                        temp_record.end_line = i - 1;
                        temp_record.end_index = list_str[i - 1].Length - 1;

                        layers.Add(temp_record);
                        temp_record = null;
                        isFindLayerStart = true;
                    }
                }
            }

            for (int j = 0; j < layers.Count; j++)
            {
                layers[j].contain.AppendLine(xml_section.contain.ToString());
                layers[j].contain.AppendLine(svg_section.contain.ToString());
                for (int i = layers[j].start_line; i <= layers[j].end_line; i++)
                {
                    layers[j].contain.AppendLine(list_str[i]);
                }
                layers[j].contain.AppendLine("</svg>");
            }

            int index = 0;
            foreach (var item in layers)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Jabil\3D Printer\files\PriningLayer_" + (index++).ToString("0000000") + ".svg"))
                {
                    file.Write(item.contain.ToString());
                }
            }

            return layers.Count;
        }
    }
}
