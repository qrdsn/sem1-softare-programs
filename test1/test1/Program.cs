string fullPath = "C:/Users/Quinn/School/Talk to me/other shit/plantpod2.png";
int locationOfLastSlash = 0;
int slashPos = 0;
int amountOfSlashes = 0;


foreach (char c in fullPath) {
    if (c == '/') amountOfSlashes++;
}

for (int i = 0; i < fullPath.Length; i++) { //continuously iterate through string receiving every character
    char c = Convert.ToChar(fullPath.Substring(i, 1));
    if (c == '/') { //chceck if received character is a slash
        slashPos++;
    }

    if (slashPos == amountOfSlashes) { //if last slash in full path
        locationOfLastSlash = i;
        break;
    }
}

Console.WriteLine("original path: {0}", fullPath);
Console.WriteLine("folder of file: {0}", fullPath.Substring(0, locationOfLastSlash+1));
Console.WriteLine("file name: {0}", fullPath.Substring(locationOfLastSlash+1, fullPath.Length-locationOfLastSlash-1));

Console.ReadKey();