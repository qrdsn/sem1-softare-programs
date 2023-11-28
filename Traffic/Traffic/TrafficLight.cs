using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic {
    public class TrafficLight {
        private string color = "Red";

        public TrafficLight() {
        }

        static void Main(string[] args) {
            TrafficLight trafficLight = new TrafficLight();

            while (true) {
                // color has to be "Red".
                Console.WriteLine(trafficLight.GetCurrentColor());
                trafficLight.NextState();

                // color has to be "Green".
                Console.WriteLine(trafficLight.GetCurrentColor());
                trafficLight.NextState();

                // color has to be "Orange".
                Console.WriteLine(trafficLight.GetCurrentColor());
                trafficLight.NextState();

                // and "Red" again!
                Console.WriteLine(trafficLight.GetCurrentColor());
                trafficLight.NextState();

                Console.ReadKey();
            }
        }

        public void NextState() {
            if (color == "Red") {
                color = "Green";
            } else if (color == "Green") {
                color = "Orange";
            } else if (color == "Orange") {
                color = "Red";
            }
        }

        public string GetCurrentColor() {
            if (color == "Red") {
                return "Red";
            } else if (color == "Green") {
                return "Green";
            } else {
                return "Orange";
            }
        }
    }
}