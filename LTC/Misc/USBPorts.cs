using System;
using System.Collections.Generic;
using System.Management;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace LTC.Misc
{
    public struct ComPort // custom struct with our desired values
    {
        public string name;
        public string vid;
        public string pid;
        public string description;

        public override string ToString()
        {
            return description;
        }
    }

    public class USBPorts
    {
        private ComPort[] device = new ComPort[] {
            new ComPort { name = "Arduino Uno" , vid = "2341", pid = "0043"},
            new ComPort { name = "Arduino Mega", vid = "2A03", pid = "0042"},
            new ComPort { name = "Arduino Nano", vid = "1A86", pid = "7523"}
        };
        private List<ComPort> ports;

        public USBPorts()
        {
            ports = new List<ComPort>();
            foreach (ComPort filter in device)
            {
                String pattern = String.Format("^VID_{0}.PID_{1}", filter.vid, filter.pid);
                Regex _rx = new Regex(pattern, RegexOptions.IgnoreCase);
                RegistryKey rk1 = Registry.LocalMachine;
                RegistryKey rk2 = rk1.OpenSubKey("SYSTEM\\CurrentControlSet\\Enum");
                foreach (String s3 in rk2.GetSubKeyNames())
                {
                    RegistryKey rk3 = rk2.OpenSubKey(s3);
                    foreach (String s in rk3.GetSubKeyNames())
                    {
                        if (_rx.Match(s).Success)
                        {
                            RegistryKey rk4 = rk3.OpenSubKey(s);
                            foreach (String s2 in rk4.GetSubKeyNames())
                            {
                                RegistryKey rk5 = rk4.OpenSubKey(s2);
                                RegistryKey rk6 = rk5.OpenSubKey("Device Parameters");
                                ports.Add(new ComPort
                                {
                                    name = (string)rk6.GetValue("PortName"),
                                    vid = filter.vid,
                                    pid = filter.pid,
                                    description = filter.name + " (" +(string)rk6.GetValue("PortName") + ")"
                                });
                            }
                        }
                    }
                }
            }
        }

        public ComPort[] Ports
        {
            get { return ports.ToArray(); }
        }

        /// <summary>
        /// Compile an array of COM port names associated with given VID and PID
        /// </summary>
        /// <param name="VID"></param>
        /// <param name="PID"></param>
        /// <returns></returns>
        private void ComPortNames(String VID, String PID)
        {
            String pattern = String.Format("^VID_{0}.PID_{1}", VID, PID);
            Regex _rx = new Regex(pattern, RegexOptions.IgnoreCase);
            ports = new List<ComPort>();
            RegistryKey rk1 = Registry.LocalMachine;
            RegistryKey rk2 = rk1.OpenSubKey("SYSTEM\\CurrentControlSet\\Enum");
            foreach (String s3 in rk2.GetSubKeyNames())
            {
                RegistryKey rk3 = rk2.OpenSubKey(s3);
                foreach (String s in rk3.GetSubKeyNames())
                {
                    if (_rx.Match(s).Success)
                    {
                        RegistryKey rk4 = rk3.OpenSubKey(s);
                        foreach (String s2 in rk4.GetSubKeyNames())
                        {
                            RegistryKey rk5 = rk4.OpenSubKey(s2);
                            RegistryKey rk6 = rk5.OpenSubKey("Device Parameters");
                            ports.Add(new ComPort
                            {
                                name = (string)rk6.GetValue("PortName"),
                                //vid = p.GetPropertyValue("PNPDeviceID").ToString(),
                                description = (string)rk6.GetValue("PortName")
                            });
                            //comports.Add((string)rk6.GetValue("PortName"));
                        }
                    }
                }
            }
        }
    }
}
