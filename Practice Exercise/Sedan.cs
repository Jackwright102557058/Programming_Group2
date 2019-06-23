class Sedan : Car {


    public Car (string make, string model, Color colour,  int Wheels, string Rego, int Doors, int PassengerLimit, int Passengers):base(make, model, colour, Wheels, Rego) {

    }

    public bool AddPassenger() {
        if (Passengers < PassengerLimit) {
            return true;
        }
        else {
            return false;
        }
        
}