List<int> list = new List<int>() { 23,43,3,64,76,34,54,5,7,8,26,25,1,5,100,55,32,44,45,97,11,43,22,33,23,51,28,19,101 };

var result = hackerlandRadioTransmitters(list, 12);

Console.WriteLine(result);


int hackerlandRadioTransmitters(List<int> x, int k)
{
    Dictionary<int, bool> houseDict = new Dictionary<int, bool>();

    foreach (var i in x)
        houseDict[i] = true;

    x.Sort();

    int currentAntennaeIndex = 0 - k;
    int antennaeCount = 0;

    foreach (var i in x)
    {
        if ((i - currentAntennaeIndex) > k)
        {
            for (int j = i + k; j >= i; j--)
            {
                if (houseDict.ContainsKey(j))
                {
                    currentAntennaeIndex = j;
                    antennaeCount += 1;
                    break;
                }
            }
        }
    }

    return antennaeCount;
}