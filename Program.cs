string ip = "1.1.1.1";

TestIp(ip);

void TestIp(string address)
{
    string[] ipArray = address.Split(".");
    if (ipArray.Length == 4)
    {
        Boolean leadingZero = false;
        foreach (string item in ipArray)
        {
            if (item.Substring(0, 1) == "0")
            {
                leadingZero = true;
                break;
            }
        }
        if (!leadingZero)
        {
            Boolean correctNumRange = true;
            foreach (string item in ipArray)
            {
                int numItem = int.Parse(item);
                if (numItem < 0 || numItem > 255) {
                    correctNumRange = false;
                    break;
                }

            }
            if (!!correctNumRange) {
                Console.WriteLine("IP address is valid");
            } else {
                Console.WriteLine("Number in the IP address is either less than 0 or more than 255, IP is invalid");
            }
        } else {
            Console.WriteLine("There are leading zeros in the IP address numbers, IP is invalid");
        }
    } else {
        Console.WriteLine("IP address length is shorter than 4 or longer than 4, IP is invalid");
    }
}
