using System.Collections.Generic;

namespace WoodCutterAlg
{
    public interface IWoodCutterAlgorithm
    {
        (BasicPlateModel, List<PlateModel>) CalculateMinimumBasicPlate(List<PlateModel> plates, bool turningAllowed = true);
    }
}