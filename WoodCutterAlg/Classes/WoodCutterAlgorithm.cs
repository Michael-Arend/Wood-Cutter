using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WoodCutterAlg
{
    public class WoodCutterAlgorithm : IWoodCutterAlgorithm
    {
        public (BasicPlateModel,List<PlateModel>) CalculateMinimumBasicPlate(List<PlateModel> plates, bool turningAllowed = true)
        {
            var calPlates = new List<PlateModel>();
            plates.ForEach(plate => calPlates.Add(plate.Clone() as PlateModel));

            var result = turningAllowed
            ? FindSmallestPlateWithTurning(calPlates, new List<PlateModel>())
            : FindSmallestPlateNoTurning(plates);

            return result;
        }

        private (BasicPlateModel, List<PlateModel>) FindSmallestPlateWithTurning( List<PlateModel> remainingPlates, List<PlateModel> setPlates)
        {
            (BasicPlateModel, List<PlateModel>) unturned = new(new BasicPlateModel(),new List<PlateModel>());
            (BasicPlateModel, List<PlateModel>) turned = new(new BasicPlateModel(),new List<PlateModel>());

            //creating turned as width/height changed unturned
            var unturnedList = new List<PlateModel>(setPlates); 
            unturnedList.Add(remainingPlates.First());
            var turnedPlate = remainingPlates.First();
            var w = turnedPlate.Width;
            turnedPlate.Width = turnedPlate.Height;
            turnedPlate.Height = w;
            var turnedList = new List<PlateModel>(setPlates);
            turnedList.Add(turnedPlate);

            if (remainingPlates.Count>1)
            {
                //If there are two same rectangles only one combination auf turned and unturned is checked
                if (!setPlates.Any() || (setPlates.Last().Width != remainingPlates.First().Width || setPlates.Last().Height == remainingPlates.First().Height))
                    unturned = FindSmallestPlateWithTurning( remainingPlates.Skip(1).ToList(), unturnedList);

                //if rectangle is a square turned will not be checked
                turned = turnedPlate.Width == turnedPlate.Height ? unturned : FindSmallestPlateWithTurning(remainingPlates.Skip(1).ToList(), turnedList);
                return (unturned.Item1.Area < turned.Item1.Area && unturned.Item1.Area != 0) ? unturned : turned;
            }

           
            unturned = FindSmallestPlateNoTurning(unturnedList);
            turned = turnedPlate.Width == turnedPlate.Height ? unturned : FindSmallestPlateNoTurning(turnedList);
            return (unturned.Item1.Area < turned.Item1.Area && unturned.Item1.Area != 0) ? unturned : turned;
        }

        private static (BasicPlateModel,List<PlateModel>) FindSmallestPlateNoTurning(List<PlateModel> plates)
        {
            var actualBasicPlate = new BasicPlateModel(plates.Sum(p => p.Width), plates.Max(p => p.Height));
            var smallestBasicPlate = new BasicPlateModel(actualBasicPlate.Width, actualBasicPlate.Height);
            var bestplates = new List<PlateModel>();

            while (actualBasicPlate.Width >= plates.Max(p => p.Width))
            {
                var woodPlates = plates.OrderByDescending(p => p.Height).ThenByDescending(p => p.Width).ToList();
                var placedPlates = PlaceRectanglesOnPlate(woodPlates, actualBasicPlate);
                if (placedPlates != null)
                {
                    actualBasicPlate.Width= placedPlates.Max(p => p.X+p.Width-1);
                    if (actualBasicPlate.Area <= smallestBasicPlate.Area)
                    {
                        smallestBasicPlate =  new BasicPlateModel(actualBasicPlate.Width, actualBasicPlate.Height);
                        bestplates = new List<PlateModel>(placedPlates);
                    }
                }
                var reducingWidth = placedPlates != null ? FindNecessaryHeigthToAdd(placedPlates) : 1;
                actualBasicPlate = new BasicPlateModel(actualBasicPlate.Width-1, actualBasicPlate.Height + reducingWidth);
            }
            return (smallestBasicPlate, bestplates);
        }

        private static int FindNecessaryHeigthToAdd(List<PlateModel> plates) => plates.Where(p => p.Width + p.X == plates.Max(x => x.Width + x.X)).Max(y=> y.Height);
       

        private static List<PlateModel> PlaceRectanglesOnPlate(List<PlateModel> plates, BasicPlateModel basicPlate)
        {
            var output= new List<PlateModel>();
            foreach (var plate in plates)
            {
                var pos = FindMostLeftPosition(plate, basicPlate);
                if (pos == null) return null;
                output.Add(new PlateModel { X= pos.X, Y = pos.Y, Height = plate.Height, Width = plate.Width, Color = plate.Color });
                basicPlate.Squares.Where(s => s.X >= pos.X && s.X <= pos.X + plate.Width-1 && s.Y >= pos.Y && s.Y <= pos.Y + plate.Height-1).ToList().ForEach(p => p.Used = true);
            }
            return output;
        }

        private static BasicSquare FindMostLeftPosition(PlateModel plate, BasicPlateModel basicPlate)
        {
            var freePositions = basicPlate.Squares.Where(s => !s.Used).OrderBy(s => s.X).ThenBy(s => s.Y).ToList();
            return freePositions.FirstOrDefault(p => CheckEnoughPlace(plate, p, basicPlate));
        }

        private static bool CheckEnoughPlace(PlateModel plate, BasicSquare position, BasicPlateModel basicPlate) =>
            !(basicPlate.Squares.Any(s => s.X >= position.X && s.X < position.X + plate.Width && s.Y>= position.Y && s.Y < position.Y + plate.Height && s.Used))
            && !(basicPlate.Height < position.Y + plate.Height-1 || basicPlate.Width < position.X + plate.Width-1);
    }
}

