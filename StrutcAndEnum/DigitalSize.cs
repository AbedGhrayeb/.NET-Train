using System.ComponentModel;

namespace StrutcAndEnum
{
    internal struct DigitalSize
    {
        private double _bit;

        public DigitalSize(double initialValue)
        {
            _bit = initialValue;
        }
        private const double bitInBit = 1d;
        private const double bitInByte = 8d;
        private const double bitInKB = bitInByte * 1204d;
        private const double bitInMB = bitInKB * 1024d;
        private const double bitInGB = bitInMB * 1204d;
        private const double bitInTB = bitInGB * 1024d;


        public string Bit => $"{(_bit / bitInBit):N0} Bit";
        public string Byte => $"{(_bit / bitInByte):N0} Byte";
        public string KB => $"{(_bit / bitInKB):N0} KB";
        public string MB => $"{(_bit / bitInMB):N0} MB";
        public string GB => $"{(_bit / bitInGB):N0} Bit";
        public string TB => $"{(_bit / bitInTB):N0} Bit";

        private DigitalSize Add(double value, double scale) => new DigitalSize(value * scale);

        public DigitalSize AddBit(double value) => Add(value, bitInBit);

        public DigitalSize AddByte(double value)=> Add(value, bitInByte);
        public DigitalSize AddKB(double value)=> Add(value, bitInKB);
        public DigitalSize AddMB(double value)=> Add(value, bitInMB);
        public DigitalSize AddGB(double value)=> Add(value, bitInGB);
        public DigitalSize AddTB(double value)=> Add(value, bitInTB);
    }
}
