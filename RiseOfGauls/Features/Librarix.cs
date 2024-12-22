using RiseOfGauls.Core;

namespace RiseOfGauls.Features;

public class Librarix : Batimentix
{


    public (string, string)?[][] Books { get; set; }


    public Librarix() : base(100, 50, 20)
    {

        Books = new (string, string)?[6][];
        for (int i = 0; i < 6; i++)
        {
            Books[i] = new (string, string)?[9];
        }

    }


    public string GetBookGenre(string bookName)
    {

        for (int i = 0; i < Books.Length; i++)
        {
            for (int j = 0; j < Books[i].Length; j++)
            {
                if (Books[i][j].HasValue)
                {
                    (string title, string genre) book = Books[i][j].Value;
                    if (book.title == (bookName))
                    {
                        return book.genre;

                    }
                }

            }
        }


        throw new GaulsException("this book is not in the librarixxx");


    }

    public void InsertBook(string name, string genre, int x, int y)
    {

        for (int i = 0; i < Books.Length; i++)
        {
            for (int j = 0; j < Books[i].Length; j++)
            {

                if (Books[i][j].HasValue)
                {
                    (string title, string genre) book = Books[i][j].Value;
                    if (book.title == name && book.genre == genre)
                    {
                        throw new GaulsException("this book already exists");
                    }
                }
            }
        }

        if (Books[x][y].HasValue)
        {
            throw new GaulsException("il y a deja un livre a cet emplacement");
        }
        else
        {
            Books[x][y] = new(name, genre);
        }

        
    }

    
    
    
    
    
}