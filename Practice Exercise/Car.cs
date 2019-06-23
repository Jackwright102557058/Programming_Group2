
        class Car : Transport {
            public int Wheels;
            public string Rego;

            public Car (string make, string model, Color colour, int Wheels, string Rego) {
                Make = make;
                Model = model;
                Colour = colour;

            }

            public string Drive () {
                return "Driving";
            }

        }