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
            Serial.DataReceived += data =>
            {
                //Очень не уверен, что это заработает. Надо дебажить!
                if (data.Length != 9) return;
                if ((data[0] != 0xAA) ||
                   (data[1] != 0xAB) ||
                   (data[2] != 0xAC) ||
                   (data[7] != 0x55) ||
                   (data[8] != 0x55)) return;
                var adc_data = new int[2];
                adc_data[0] = (data[4] << 16) + (data[3] << 8);
                adc_data[1] = (data[6] << 16) + (data[5] << 8);
                MeasureDataHandler?.Invoke(adc_data);
            };
        }

        public void StartMeasure()
        {
            if (!Serial.IsConnected) return;
            Serial.WriteData(new byte[] { 0x01 });
        }

        public void StopMeasure()
        {
            if (!Serial.IsConnected) return;
            Serial.WriteData(new byte[] { 0x02 });
        }

        public event Action<int[]> MeasureDataHandler;
    }
}
