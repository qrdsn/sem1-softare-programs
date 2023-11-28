using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic {
    public class TrafficLight {

        public enum TrafficlightColors {
            Red,
            Orange,
            Green
        }

        private TrafficlightColors color = TrafficlightColors.Red;

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
            if (color == TrafficlightColors.Red) {
                color = TrafficlightColors.Green;
            } else if (color == TrafficlightColors.Green) {
                color = TrafficlightColors.Orange;
            } else if (color == TrafficlightColors.Orange) {
                color = TrafficlightColors.Red;
            }
        }

        public TrafficlightColors GetCurrentColor() {
            if (color == TrafficlightColors.Red) {
                return TrafficlightColors.Red;
            } else if (color == TrafficlightColors.Green) {
                return TrafficlightColors.Green;
            } else {
                return TrafficlightColors.Orange;
            }
        }
    }
}