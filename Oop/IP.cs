namespace Oop
{
    internal class IP
    {
        private string[] _segments = new string[4];
        public string this[int index]
        {
            get { return _segments[index]; }
            set { _segments[index] = value; }
        }
        public IP(int segment1, int segment2, int segment3, int segment4)
        {
            _segments[0] = segment1 > 0 && segment1 < 256 ? segment1.ToString("000") : "000";
            _segments[1] = segment2 > 0 && segment2 < 256 ? segment2.ToString("000") : "000";
            _segments[2] = segment3 > 0 && segment3 < 256 ? segment3.ToString("000") : "000";
            _segments[3] = segment4 > 0 && segment4 < 256 ? segment4.ToString("000") : "000";

        }
        //suppose input string as xxx.xxx.xxx.xxx
        public IP(string address)
        {
            var seg=address.Split('.');
            for (int i = 0; i < seg.Length; i++)
            {
                _segments[i] = seg[i];
            }
        }
        public string Addres => !_segments.Any() ? "000.000.000.000" : string.Join(".", _segments);
    }
}
