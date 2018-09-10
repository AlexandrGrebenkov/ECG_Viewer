using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG_Viewer.Service.Serial
{
    public class Requests
    {
        ISerial Serial;

        public Requests(ISerial serial)
        {
            Serial = serial;
        }

        public void StartMeasure()
        {
            if (!Serial.IsConnected) return;

            Serial.WriteData(new byte[] { 0x01 });
        }

        public void StopMeasure()
        {
            Serial.WriteData(new byte[] { 0x02 });
        }
    }
}
