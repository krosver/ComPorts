namespace FirstTask
{
    class Msg
    {
        public string CH { get; set; }
        public string Flags { get; set; }
        public int ID { get; set; }
        public int DLC { get; set; }
        public string Data { get; set; }
        public int Period { get; set; }
        public int Counter { get; set; }
        public string ASCII { get; set; }
        public string Comment { get; set; }
        public bool Bit29 { get; set; }
        public bool RTR { get; set; }
        public int Value { get; set; }

        public void Send()
        {
            if (Bit29)
            {

            }
            else 
            {

            }

        }
    }
}
