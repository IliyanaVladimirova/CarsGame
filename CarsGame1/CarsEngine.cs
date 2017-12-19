using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarsGame1
{
    public class CarsEngine : IGameEngine
    {
        internal IPositionalRenderer renderer = new ConsoleRenderer();
        private Car myCar;
        private Car InitialCar;
        private Car movingCar;

        internal CarsEngine(IPositionalRenderer renderer)
        {
            this.renderer = renderer;
            this.myCar = new Car(Constants.Symbol, renderer,new Directions(), Constants.StartingPosition);
        }

        public void StartGame()
        {
            Random rand = new Random();
            List<Car> cars = new List<Car>();

            while (true)
            {
                InitialCar = new Car(Constants.OtherCarsSymbol, renderer, new Coordinates(rand.Next(0, Constants.Playfieldsize), 0));
                cars.Add(InitialCar);

                for (int i = 0; i < cars.Count; i++)
                {
                    Car newCar = cars[i];
                    movingCar = new Car(Constants.OtherCarsSymbol, renderer, new Coordinates(newCar.Position.X, newCar.Position.Y++));
                    movingCar.Position.X = newCar.Position.X;
                    movingCar.Position.Y = newCar.Position.Y++;
                    cars.Remove(newCar);
                    if (movingCar.Position.Y < Constants.ConsoleHeight)
                        cars.Add(movingCar);
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyPressed = Console.ReadKey(true);
                    while (Console.KeyAvailable) Console.ReadKey(true);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            myCar.Direction.ChangeDIrection(DirectionsNames.Left);
                            break;
                        case ConsoleKey.RightArrow:
                            myCar.Direction.ChangeDIrection(DirectionsNames.Right);
                            break;
                        case ConsoleKey.Escape:
                            EndGame();
                            break;
                        default:
                            break;
                    }
                }

                DrawPlayfield pl = new DrawPlayfield(renderer, new Coordinates(Constants.Playfieldsize, 0));
                pl.Drawing(renderer);
                renderer.WriteAtPosition(new Coordinates(33, 10), "Cars Game running!");
                renderer.WriteAtPosition(new Coordinates(33, 11), "Press Esc to exit");
                myCar.Move();
                myCar.Print();
                Thread.Sleep(100);
                Console.Clear();
                foreach (Car car in cars)
                {
                    car.Print();
                }
            }

        }
       
        public void EndGame()
        {
            throw new ArgumentException("You stopped the game! Bye");
        }
    }

}

