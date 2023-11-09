using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsWindowsApp
{
    public static class CarData
    {
        private static List<Car> cars = new List<Car>();

        public static void AddCar(Car car)
        {
            cars.Add(car);
        }

        public static IReadOnlyList<Car> GetCars()
        {
            return cars;
        }

        public static bool ShouldEnableFinishAction()
        {
            bool shouldStopProcess = StopProcess();
            bool continueProcess = ContinueProcess(); 
            return  (cars.Count > 9 && continueProcess== true)  || shouldStopProcess == true;
        }

        public static List<Car> GetUnique()
        {
            Dictionary<string, List<Car>> carDictionary = new Dictionary<string, List<Car>>();

            foreach (Car car in cars)
            {
                if (carDictionary.ContainsKey($"{car.Color},{car.CountryOfOrigin}"))
                {
                    carDictionary[$"{car.Color},{car.CountryOfOrigin}"].Add(car);
                }
                else
                {
                    carDictionary[$"{car.Color},{car.CountryOfOrigin}"] = new List<Car> { car };
                }
            }

            List<Car> result = new List<Car>();

            foreach (List<Car> value in carDictionary.Values)
            {
                if (value.Count == 1)
                {
                    result.AddRange(value);
                }
            }

            return result;
        }

        public static List<string> GetMissingAttributes()
        {
            List<string> missingAttributesList = new List<string>();
            int i = 1;
            foreach (Car car in cars)
            {
                string carResult = "Auto" + i + "-";

                if (string.IsNullOrEmpty(car.Name))
                {
                    carResult = carResult + "name,";
                }
                if (string.IsNullOrEmpty(car.Color))
                {
                    carResult = carResult + "color,";
                }
                if (car.Mileage == null)
                {
                    carResult = carResult + "mileage,";
                }
                if (car.NumberOfDoors == null)
                {
                    carResult = carResult + "number of doors,";
                }
                if (string.IsNullOrEmpty(car.CountryOfOrigin))
                {
                    carResult = carResult + "country of origin,";
                }
                string completeResultes = "Auto" + i + "-";
                if (carResult == completeResultes)
                {
                    carResult = carResult + "complete";
                }
                missingAttributesList.Add(carResult);
                i++;
            }
            return missingAttributesList;
        }

        public static bool StopProcess()
        {
           
            var redCars= cars.Where(car => car.Color == "red");
            var blueCars = cars.Where(car => car.Color == "blue");
            var greenCars = cars.Where(car => car.Color == "green");
            if(redCars.Count()==1 &&blueCars.Count()==2 && greenCars.Count() == 1)
            {
                return true;
            }
            return false;
        }

        public static bool ContinueProcess()
        {
            Dictionary<string, HashSet<string>> countryDictionary = new Dictionary<string, HashSet<string>>();
            foreach (Car car in cars)
            {
                if (countryDictionary.ContainsKey(car.CountryOfOrigin))
                {
                    countryDictionary[car.CountryOfOrigin].Add(car.Color);
                    if(countryDictionary[car.CountryOfOrigin].Count >=3)
                    {
                        return true;
                    }
                }
                else
                {
                    countryDictionary[car.CountryOfOrigin] = new HashSet<string>() { car.Color };
                }
            }
            return false;
        }
    }
}
