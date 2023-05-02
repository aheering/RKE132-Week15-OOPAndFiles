// Objekt-orienteeritud programeerimine, failidest andmete lugemine

List<Movie> myMovies = new List<Movie>();

string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);
//ReadDataFromArray(GetDataFromMyFile());

//andmete lugemine ja lisaine listi
foreach(string line  in data)
{
    string[] tempArray = line.Split(new char[] { ';'}, StringSplitOptions.RemoveEmptyEntries);
    //Console.WriteLine("Temp array");
    //ReadDataFromArray(tempArray);
    Movie newMovie = new Movie(tempArray[0], tempArray[2]);
    myMovies.Add(newMovie);
}

//andmete kuvamine lauses
foreach(Movie movie in myMovies)
{
    Console.WriteLine($"One of my favorite movies {movie.Title} was released in {movie.Year}.");
}

static string[] GetDataFromMyFile()
{
    string filePath = @"C:\Users\smsike\Dropbox\Elektritehnika\RKE132 Programmeerimise algkursus\Weer15-Andmed\movies.txt";
    // string[] dataFromFile = File.ReadAllLines(filePath);

    return File.ReadAllLines(filePath); //või dataFromFile;
}

static void ReadDataFromArray(string[] someArray)
{
    foreach (string line  in someArray)
    {
        Console.WriteLine(line);
    }
}

//mobie klassi loomine
class Movie
{
    string title; //fields
    string year;

    //pealkirja getter
    public string Title
    {
        get { return title; }
    }

    //aasta getter
    public string Year
    {
        get { return year; }
    }

    //konstruktor
    public Movie(string _title, string _year)
    {
        this.title = _title;
        this.year = _year;
    }
}