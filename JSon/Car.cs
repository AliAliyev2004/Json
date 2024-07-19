namespace JSon;


    public class Car
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Marka}-{Model}-{Year}";
        }
    }


