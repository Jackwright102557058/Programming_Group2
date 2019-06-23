
        class Aeroplane : Transport {
            public int WingSpan;
            public int PassengerLimit;
            public int Passengers;

            public Aeroplane (string make, string model, Color colour, int WingSpan, int PassengerLimit, int Passengers) {
                Make = make;
                Model = model;
                Colour = colour;
                WingSpan = wingspan;
                PassengerLimit = passengerlimit;
                Passengers = passengers;

            }

            public string Fly () {
                return "Flying";
            }

        }
